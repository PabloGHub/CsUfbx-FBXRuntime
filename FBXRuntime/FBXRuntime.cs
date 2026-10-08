using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using Ufbx;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using static Ufbx.Runtime.FBXRuntime.contextFBXR;
using static Ufbx.UfbxNative;
//using static Unity.Collections.AllocatorManager;

namespace Ufbx.Runtime
{
    /*
    -- Variables:
    starts: m_ = public, Recommended to use getters and setters
    starts: _ = private, NOT local
    starts: lowercase = private, local
    starts: "p" (lowercase) = local incoming parameter
    starts: uppercase = public
    -- Functions:
    starts: uppercase = public
    starts: lowercase = private
    starts: __ = public, ONLY for modders, Not recommended
    */


    /*
     -- Minicosas a Aprender:
        * Que es una Matrix
        * Descubirir porque m33 debe ser 1f de la matrix4x4
        * Recordar que hacia ^
        * Entender GetDataFace
        * Descubrir porque es necesario los bindPoses para que los huesos y peso de los huesos funcione
        * Descubrir que es cluster->geometry_to_bone
     */


    /*
     -- Features faltantres:
        * Distinguir entre SkinnedMeshRenderer y MesFilter
        * Crear Textura
        * Crear Animaciones
        * BlendsShapes
        * Completar Material
        * Crear Camara
        * Crear Luces
     */


    public static class FBXRuntimePipeline
    {
        public enum Backend : sbyte
        {
            BuiltIn,
            URP
        }

        public static Backend GetBackend()
        {
            RenderPipelineAsset pipeline =
                GraphicsSettings.currentRenderPipeline;

            if (pipeline == null)
                return Backend.BuiltIn;

            if (pipeline.GetType().Name == "UniversalRenderPipelineAsset")
                return Backend.URP;

            throw new System.NotSupportedException(
                $"Render Pipeline not supported: {pipeline.GetType().FullName}");
        }

        public static Shader FindDefaultLitShader()
        {
            switch (GetBackend())
            {
                case Backend.BuiltIn:
                    return Shader.Find("Standard");

                case Backend.URP:
                    return Shader.Find("Universal Render Pipeline/Lit");

                default:
                    return null;
            }
        }
    }








    // TODO:
    /*
     - Sistema de configuracion para por ejemplo: root en local o global.
     
     */




    // ************************************************ //
    //                       UNITY                      //
    // ************************************************ //
    public unsafe static class FBXRuntime
    {

        // ************************************************ //
        //                  CONST or "CONST"                //
        // ************************************************ //
        public static string ROOT_ARMATURE = "Armature";




        // ************************************************ //
        //                  SCENE CONTAINER                 //
        // ************************************************ //
        private static Scene _container;
        private static Scene _container_internal
        {
            get
            {
                if (!_container.IsValid())
                    _container = SceneManager.CreateScene("Container_CsUfbx");
                return _container;
            }
            set
            {
                if (value != null)
                    _container = value;
            }
        }
        public static Scene Container
        {
            get => _container_internal;
        }




        // ************************************************ //
        //                      CONTEXT                     //
        // ************************************************ //
        internal unsafe class contextFBXR : IDisposable
        {
            private bool _active = false;
            public bool IsActive => _active;
            public contextFBXR Init()
            {
                _active = true;
                return this;
            }


            private Dictionary<uint, SkinnedMeshRenderer> _skinnedMeshs;
            public Dictionary<uint, SkinnedMeshRenderer> Meshes
            {
                get
                {
                    if (_skinnedMeshs == null)
                        _skinnedMeshs = new();
                    return _skinnedMeshs;
                }
            }
            //internal unsafe class dataMesh
            //{
            //    public  Skinned;
            //    public ufbx_mesh* Mesh;
            //}

            private Dictionary<uint, GameObject> _bones;
            public Dictionary<uint, GameObject> Bones
            {
                get
                {
                    if (_bones == null)
                        _bones = new();
                    return _bones;
                }
            }



            //private ufbx_scene* _scene;
            //public ufbx_scene* Scene
            //{
            //    get => _scene;
            //    set => _scene = value;
            //}


            public void Dispose()
            {
                _active = false;
                _skinnedMeshs.Clear();
                _bones.Clear();
                //_scene = (ufbx_scene*)0x0;
            }
        }
        internal static AsyncLocal<contextFBXR> _context_internal = new() { Value = new() };








        // ************************************************ //
        //                         IO                       //
        // ************************************************ //

        public static unsafe GameObject Instantiate(ufbx_scene* pScene)
        {
            ufbx_node* rootNode = pScene->root_node;
            GameObject root;

            root = BuildNode(rootNode);
            root.name = Path.GetFileNameWithoutExtension(pScene->metadata.filename.ToString());


            return root;
        }

        public static unsafe GameObject Instantiate(ufbx_node* pRoot) =>
            BuildNode(pRoot);




        public static unsafe bool Export(GameObject pRoot, string pPath, string pName = null)
        {
            throw new NotImplementedException("WIP");
        }
        public static unsafe bool Export(Scene* pScene, string pPath, string pName = null)
        {
            throw new NotImplementedException("WIP");
        }






        // ************************************************ //
        //                                                  //
        // ************************************************ //

        internal static void postProcess(ufbx_scene* pScene)
        {
            if (!_context_internal.Value.IsActive)
                return;

            fillAllSkinnedMeshRendererBones(pScene);


            // Test
            for (nuint m = 0; m < pScene->meshes.count; m++)
            {
                ufbx_mesh* mesh = pScene->meshes.data[m];
                if (!_context_internal.Value.Meshes.TryGetValue(mesh->element_id, out var smr))
                    continue;

                var (weight, bonesPerVertex) = GetBoneWeight(mesh);

                smr.sharedMesh.SetBoneWeights(bonesPerVertex.ToArray(Allocator.Temp), weight.ToArray(Allocator.Temp));

            }

        }









        // ************************************************ //
        //                       NODES                      //
        // ************************************************ //
        public static unsafe GameObject BuildNode(ufbx_node* pNode, Transform pParent = null)
        {
            GameObject r;

            using (_context_internal.Value.Init())
            {
                r = buildNode_internal(pNode, pParent);

                postProcess(pNode->element.scene);
            }

            return r;
        }


        internal static unsafe GameObject buildNode_internal(ufbx_node* pNode, Transform pParent)
        {
            if (pNode == null) return null;

            GameObject go = CreateNode(pNode, pParent);

            processNode_internal(pNode, go);

            buildTreeNode_internal(pNode, go.transform);

            return go;
        }

        internal static unsafe void processNode_internal(ufbx_node* pNode, GameObject pGameNode)
        {
            if (pNode->bone != null)
            {
                processBone_internal(pNode, pGameNode);
            }

            if (pNode->mesh != null)
            {
                processMesh_internal(pNode, pGameNode);
            }


            if (pNode->light != null)
            {
                // TODO: Light
            }

            if (pNode->camera != null)
            {
                // TODO: Camera
            }
        }

        public static unsafe GameObject CreateNode(ufbx_node* pNode, Transform pParent)
        {
            string name = pNode->name.data != null
                        ? pNode->name.ToString()
                        : "Unnamed_Node";

            GameObject go = new GameObject(name);
            _ = NodeTraslateToTransform(pNode, ref go, pParent);

            return go;
        }


        internal static unsafe void buildTreeNode_internal(ufbx_node* pNode, Transform pParent)
        {
            for (ulong i = 0; i < (ulong)pNode->children.count; i++)
            {
                ufbx_node* childNode = pNode->children.data[i];
                buildNode_internal(childNode, pParent);
            }
        }








        // ************************************************ //
        //                       BONES                      //
        // ************************************************ //
        internal static unsafe void processBone_internal(ufbx_node* pNode, GameObject pGameNode)
        {
            contextFBXR context = _context_internal.Value;
            context.Bones.Add(pNode->bone->element_id, pGameNode);
        }



        public static unsafe void FindBones(ufbx_node* pNode, List<nint> pArmature)
        {
            if (pNode->bone != null)
            {
                pArmature.Add((nint)pNode);
            }

            for (nuint i = 0; i < pNode->children.count; i++)
            {
                ufbx_node* child = pNode->children.data[i];
                FindBones(child, pArmature);
            }
        }



        // ************************************************ //
        //                       Mesh                       //
        // ************************************************ //
        // TODO: Armature, Mesh, BlendShapes
        internal static unsafe void processMesh_internal(ufbx_node* pMeshNode, GameObject pTarjet)
        {
            if (isBuildSkinnedMesh(pMeshNode))
            {
                BuildSkinnedMeshRenderer(pMeshNode->mesh, pTarjet);
            }
            else
            {
                BuildMeshRenderer(pMeshNode->mesh, pTarjet);
            }
        }


        public static unsafe void BuildMeshRenderer(ufbx_mesh* pMesh, GameObject pTarjet, string pShader = null)
        {
            MeshFilter meshFilter = pTarjet.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = pTarjet.AddComponent<MeshRenderer>();
            Mesh unityMesh = CreateMesh(pMesh);


            meshFilter.sharedMesh = unityMesh;
            var mat = CreateMaterial(pMesh->materials.data[0], pShader);

            meshRenderer.material = mat;
            //meshRenderer.sharedMaterial = mat;
        }



        public static unsafe void BuildSkinnedMeshRenderer(ufbx_mesh* pMesh, GameObject pTarjet, string pShader = null)
        {
            SkinnedMeshRenderer skinned = pTarjet.AddComponent<SkinnedMeshRenderer>();
            Mesh unityMesh = CreateMesh(pMesh);


            skinned.sharedMesh = unityMesh;
            var mat = CreateMaterial(pMesh->materials.data[0], pShader);

            skinned.material = mat;
            //skinned.sharedMaterial = mat;


            _context_internal.Value.Meshes.Add(pMesh->element_id, skinned); // new dataMesh{ Skinned = skinned, Mesh = pMesh }
        }




        // TODO: Hay que extraer: Vertices, Normales, UV, Materiales
        public static unsafe Mesh CreateMesh(ufbx_mesh* pMesh)
        {
            DataFaces data = GetDataFaces(pMesh);

            Mesh mesh = new Mesh
            {
                name = pMesh->name.data != null
                        ? pMesh->name.ToString()
                        : "Ufbx_Mesh",

                vertices = data.Vertices,
                triangles = data.Triangles,

                //vertices = GetVertex(pMesh),
                //triangles = GetTrianges(pMesh),
                //tangents = GetTangent(pMesh),
                //colors = GetVextesColor(pMesh)
            };

            if (data.Normals != null)
                mesh.normals = data.Normals;
            else
                mesh.RecalculateNormals();

            //if (pMesh->vertex_normal.exists == 1)
            //    mesh.normals = GetNormals(pMesh);
            //else
            //    mesh.RecalculateNormals();

            if (data.UVs != null)
                mesh.uv = data.UVs;

            //Vector3[] post = GetVertexPosition(pMesh);

            //mesh.RecalculateBounds();

            // TODO: dar las tangentes del archivo.
            mesh.RecalculateTangents();


            //mesh.SetBoneWeights
            //    mesh.boneWeights

            return mesh;
        }


        private static unsafe bool isBuildSkinnedMesh(ufbx_node* pMeshNode)
        {
            if (pMeshNode->mesh == null)
                throw new Exception($"[FBXRuntime]: The node \"{pMeshNode->name}\" is not a Mesh.");

            fixed (ufbx_mesh_list* meshes = &pMeshNode->element.scene->meshes)
            {
                for (nuint i = 0; i < meshes->count; i++)
                {
                    ufbx_mesh* m = meshes->data[i];

                    if (m->element_id == pMeshNode->mesh->element_id)
                        return m->skin_deformers.count > (nuint)1 && m->skin_deformers.data[0]->clusters.count > (nuint)1;
                }
            }

            return false;
        }




        private static void fillSkinnedMeshRendererBones(ufbx_mesh* pMesh, SkinnedMeshRenderer pSMR)
        {
            List<Transform> allBones = new();
            List<Matrix4x4> bindPoses = new();

            for (nuint d = 0; d < pMesh->skin_deformers.count; d++)
            {
                ufbx_skin_deformer* deformer = pMesh->skin_deformers.data[d];

                //Debug.Log($"deformer->element_id: {deformer->element_id}");

                for (nuint c = 0; c < deformer->clusters.count; c++)
                {
                    ufbx_skin_cluster* cluster = deformer->clusters.data[c];

                    if (_context_internal.Value.Bones.TryGetValue(cluster->bone_node->bone->element_id, out var go))
                    {
                        allBones.Add(go.transform);
                        bindPoses.Add(cluster->geometry_to_bone.ToUnity());
                    }

                    //Debug.Log($"cluster->element_id: {cluster->bone_node->bone->element_id} | find: {(go != null ? "Yes" : "No")}");
                }
            }

            pSMR.bones = allBones.ToArray();
            pSMR.sharedMesh.bindposes = bindPoses.ToArray();

            // temporal: maybe its disordered.
            if (allBones.Count > 0) pSMR.rootBone = allBones[0]; 
        }

        private static void fillAllSkinnedMeshRendererBones(ufbx_scene* pScene)
        {
            for (nuint m = 0; m < pScene->meshes.count; m++)
            {
                ufbx_mesh* mesh = pScene->meshes.data[m];
                if (!_context_internal.Value.Meshes.TryGetValue(mesh->element_id, out var smr))
                    continue;

                fillSkinnedMeshRendererBones(mesh, smr);
            }
        }





        // ************************************************ //
        //                     Material                     //
        // ************************************************ //

        public static Shader CreateShader(ufbx_shader* pShader, string pNameStarter = null)
        {
            Shader s = string.IsNullOrEmpty(pNameStarter) || pNameStarter == null
                        ? FBXRuntimePipeline.FindDefaultLitShader()
                        : Shader.Find(pNameStarter);

            if (s == null)
                throw new NullReferenceException("Not find shader");

            if (pShader == null) return s;
            // TODO: Aplicar lo que se le pueda aplicar al shader

            //s.name = pShader->Anonymous.Anonymous.name.ToString();

            // Bindings → mapear texturas automáticamente
            //for (nuint i = 0; i < pShader->bindings.count; i++)
            //{
            //    var binding = pShader->bindings.data[i];
            //    for (nuint j = 0; j < binding->prop_bindings.count; j++)
            //    {
            //        var prop = binding->prop_bindings.data[j];
            //        string shaderProp = prop.shader_prop.ToString();
            //        string materialProp = prop.material_prop.ToString();
            //        // TODO: Asignar textura correspondiente
            //    }
            //}

            //var props = pShader->Anonymous.props;

            return s;
        }

        public static Texture CreateTexture(ufbx_material* pMaterial)
        {
            throw new NotImplementedException("TODO: Leer textura y crearla");
        }

        public static Material CreateMaterial(ufbx_material* pMaterial, string pShader = null)
        {
            if (pMaterial == null) return null;

            Material sharedMaterial = new Material(CreateShader(pMaterial->shader, pShader));

            sharedMaterial.name = pMaterial->name.data != null
                ? pMaterial->name.ToString()
                : "Ufbx_Material";

            ApplyMaterialProperties(pMaterial, sharedMaterial);

            RefreshMaterialKeywords(sharedMaterial);

            return sharedMaterial;
        }


        public static unsafe void ApplyMaterialProperties(ufbx_material* pUfbxMaterial, Material pMaterial)
        {
            applyBaseColor(pUfbxMaterial, pMaterial);
            applySmoothness(pUfbxMaterial, pMaterial);
            applyRoughness(pUfbxMaterial, pMaterial);
            applyEmission(pUfbxMaterial, pMaterial);

            // applyMetallic(pMaterial, material);


            // TODO: Carga de Texturas
            // Si (pMaterial->pbr.base_color.texture != null)
            // Deberás cargar la textura y asignarla usando: sharedMaterial.SetTexture("_MainTex", textura2D);

            if (pUfbxMaterial->pbr.base_color.texture != null)
            {
                Debug.LogError("Es una textura", pMaterial);
                //sharedMaterial.SetTexture("_MainTex", );
            }

            // TODO
            // applyAlbedoTexture(...)
            // applyNormalTexture(...)
            // applyMetallicTexture(...)
            // applyRoughnessTexture(...)
        }


        private static unsafe void applyBaseColor(ufbx_material* pMaterial, Material pShaderMaterial)
        {
            Color c;

            if (pMaterial->pbr.base_color.has_value != 0)
            {
                Vector4 colorVec = pMaterial->pbr.base_color.value_vec4.ToUnity();
                c = convertColor(colorVec);
            }
            else if (pMaterial->fbx.diffuse_color.has_value != 0)
            {
                Vector3 colorVec = pMaterial->fbx.diffuse_color.value_vec3.ToUnity();
                c = convertColor(colorVec);
            }
            else
            {
                return;
            }

            // La prodiedad "color" ya distinte entre papiles distintas.
            //pShaderMaterial.color = c;

            if (pShaderMaterial.HasProperty("_BaseColor"))
                pShaderMaterial.SetColor("_BaseColor", c);
            else if (pShaderMaterial.HasProperty("_Color"))
                pShaderMaterial.SetColor("_Color", c);
        }

        private static unsafe void applySmoothness(ufbx_material* pMaterial, Material pShaderMaterial)
        {
            // Metálico y Suavidad (Smoothness)
            if (pMaterial->pbr.metalness.has_value == 0)
                return;

            if (pShaderMaterial.HasProperty("_Metallic"))
                pShaderMaterial.SetFloat("_Metallic", (float)pMaterial->pbr.metalness.value_real);
        }

        private static unsafe void applyRoughness(ufbx_material* pMaterial, Material pShaderMaterial)
        {
            if (pMaterial->pbr.roughness.has_value == 0)
                return;

            // Unity Standard Shader usa 'Smoothness', que es matemáticamente el inverso de 'Roughness' (Rugosidad).
            float smoothness = 1.0f - (float)pMaterial->pbr.roughness.value_real;

            if (pShaderMaterial.HasProperty("_Smoothness"))
                // URP
                pShaderMaterial.SetFloat("_Smoothness", smoothness);

            else if (pShaderMaterial.HasProperty("_Glossiness"))
                // Built-in Standard
                pShaderMaterial.SetFloat("_Glossiness", smoothness);
        }

        private static unsafe void applyEmission(ufbx_material* pMaterial, Material pShaderMaterial)
        {
            Color emissionColor = Color.black;
            bool hasEmissionColor = false;


            if (pMaterial->pbr.emission_color.has_value != 0)
            {
                Vector3 emissionVec = pMaterial->pbr.emission_color.value_vec3.ToUnity();
                emissionColor = convertColor(emissionVec);
                hasEmissionColor = true;
            }
            else if (pMaterial->fbx.emission_color.has_value != 0)
            {
                Vector3 emissionVec = pMaterial->fbx.emission_color.value_vec3.ToUnity();
                emissionColor = convertColor(emissionVec);
                hasEmissionColor = true;
            }


            float emissionFactor = 1.0f;
            if (pMaterial->pbr.emission_factor.has_value != 0)
                emissionFactor = (float)pMaterial->pbr.emission_factor.value_real;
            else if (pMaterial->fbx.emission_factor.has_value != 0)
                emissionFactor = (float)pMaterial->fbx.emission_factor.value_real;

            emissionColor *= emissionFactor;


            bool hasEmissionTexture = (pMaterial->pbr.emission_color.texture != null) ||
                                      (pMaterial->fbx.emission_color.texture != null);


            if ((hasEmissionColor && emissionColor != Color.black) || hasEmissionTexture)
            {
                if (pShaderMaterial.HasProperty("_EmissionColor"))
                {
                    // Si el color es negro puro pero hay textura, forzamos blanco para que la textura sea visible
                    if (emissionColor == Color.black && hasEmissionTexture)
                        emissionColor = Color.white;

                    pShaderMaterial.SetColor("_EmissionColor", emissionColor);

                    // Es vital activar el keyword de emisión explícitamente en el shader
                    pShaderMaterial.EnableKeyword("_EMISSION");
                }

                // TODO: Cargar y asignar la textura a pShaderMaterial.SetTexture("_EmissionMap", texture);
            }
        }




        public static void RefreshMaterialKeywords(Material pMaterial)
        {
            //
            // NORMAL MAP
            //
            bool hasNormal =
                pMaterial.HasProperty("_BumpMap") &&
                pMaterial.GetTexture("_BumpMap") != null;

            SetKeyword(pMaterial, "_NORMALMAP", hasNormal);


            //
            // METALLIC MAP - Built-in
            //
            bool hasMetallicMap =
                pMaterial.HasProperty("_MetallicGlossMap") &&
                pMaterial.GetTexture("_MetallicGlossMap") != null;
            SetKeyword(
                pMaterial,
                "_METALLICGLOSSMAP",
                hasMetallicMap);


            //
            // METALLIC MAP - URP
            //
            bool hasURPMatcap =
                pMaterial.HasProperty("_MetallicGlossMap") &&
                pMaterial.GetTexture("_MetallicGlossMap") != null;
            SetKeyword(
                pMaterial,
                "_METALLICSPECGLOSSMAP",
                hasURPMatcap);


            //
            // EMISSION
            //
            bool hasEmission = false;
            if (pMaterial.HasProperty("_EmissionColor"))
            {
                Color emission =
                    pMaterial.GetColor("_EmissionColor");

                hasEmission =
                    emission.maxColorComponent > 0.0001f;
            }
            if (pMaterial.HasProperty("_EmissionMap") &&
                pMaterial.GetTexture("_EmissionMap") != null)
            {
                hasEmission = true;
            }
            SetKeyword(pMaterial, "_EMISSION", hasEmission);

            //pMaterial.globalIlluminationFlags = MaterialGlobalIlluminationFlags.None;
        }
        public static void SetKeyword(
            Material material,
            string keyword,
            bool enabled)
        {
            if (enabled)
                material.EnableKeyword(keyword);
            else
                material.DisableKeyword(keyword);
        }








        // ************************************************ //
        //                    Connections                   //
        // ************************************************ //
        //public struct DataConnections
        //{
        //    // TODO: Mapa de: Nodo_1 -> Armature_A
        //    // Animaciones, Mesh, Materiales, etc...

        //}

        //public struct RuntimeArmature
        //{


        //    public ufbx_node*[] Skeleton;
        //    public ufbx_node* Root;
        //}



        //public struct DataConnection
        //{
        //    public ufbx_connection** Conections;
        //    public nuint Count;
        //}


        //public static DataConnection FindAllConnection_tests(nuint pId, Allocator pAllo = Allocator.Temp)
        //{
        //    contextFBXR context = _context_internal.Value;

        //    nuint offset = 0;
        //    int m = (int)context.Scene->connections_src.count + (int)context.Scene->connections_dst.count;
        //    //ufbx_connection** conns = stackalloc ufbx_connection*[];

        //    ufbx_connection** conns = (ufbx_connection**)UnsafeUtility.Malloc(
        //        sizeof(ufbx_connection*) * (long)m,
        //        UnsafeUtility.AlignOf<IntPtr>(),
        //        pAllo
        //    );

        //    for (nuint i = 0; i < context.Scene->connections_src.count; i++)
        //    {
        //        ufbx_connection* c = &context.Scene->connections_src.data[i];
        //        if (c->src->element_id == pId || c->dst->element_id == pId)
        //        {
        //            conns[offset] = c;
        //            offset++;
        //        }
        //    }

        //    for (nuint i = 0; i < context.Scene->connections_dst.count; i++)
        //    {
        //        ufbx_connection* c = &context.Scene->connections_dst.data[i];
        //        if (c->src->element_id == pId || c->dst->element_id == pId)
        //        {
        //            conns[offset] = c;
        //            offset++;
        //        }
        //    }

        //    // TODO: Necesito acortar conns
        //    return new DataConnection
        //    {
        //        Conections = conns,
        //        Count = offset
        //    };
        //}
        //public static unsafe NativeArray<IntPtr> FindAllConnection(ref uint pId, Allocator allocator = Allocator.Temp)
        //{
        //    contextFBXR context = _context_internal.Value;

        //    int m = (int)context.Scene->connections_src.count + (int)context.Scene->connections_dst.count;
        //    NativeList<IntPtr> result = new NativeList<IntPtr>(m, allocator);

        //    for (nuint i = 0; i < context.Scene->connections_src.count; i++)
        //    {
        //        ufbx_connection* c = &context.Scene->connections_src.data[i];
        //        if (c->src->element_id == pId || c->dst->element_id == pId)
        //        {
        //            result.Add((IntPtr)c);
        //        }
        //    }

        //    for (nuint i = 0; i < context.Scene->connections_dst.count; i++)
        //    {
        //        ufbx_connection* c = &context.Scene->connections_dst.data[i];
        //        if (c->src->element_id == pId || c->dst->element_id == pId)
        //        {
        //            result.Add((IntPtr)c);
        //        }
        //    }

        //    return result.ToArray(allocator);
        //}




        public static unsafe int FindAllConnection(
                                    nuint pId,
                                    ufbx_scene* pContext,
                                    Span<IntPtr> destinationBuffer)
        {
            int offset = 0;


            nuint srcCount = pContext->connections_src.count;
            for (nuint i = 0; i < srcCount; i++)
            {
                ufbx_connection* c = &pContext->connections_src.data[i];
                if (c->src->element_id == pId || c->dst->element_id == pId)
                {
                    destinationBuffer[offset++] = (IntPtr)c;
                }
            }


            nuint dstCount = pContext->connections_dst.count;
            for (nuint i = 0; i < dstCount; i++)
            {
                ufbx_connection* c = &pContext->connections_dst.data[i];
                if (c->src->element_id == pId || c->dst->element_id == pId)
                {
                    destinationBuffer[offset++] = (IntPtr)c;
                }
            }

            return offset;
        }


        //private static DataArmature findArmature()
        //{
        //    throw new NotImplementedException("TODO");
        //    // TODO: recorer las conexiones para encontrar el root.
        //    // TODO: recorer las conexiones para formar el esqueleto.
        //}

        private static bool tryGetRoot(ufbx_scene* pContex, ufbx_node* pMesh, ufbx_node* pRoot)
        {
            throw new NotImplementedException("TODO");
            // TODO: recorer las conexiones para encontrar el root.
        }



        //private static void rangeConnections()
        //{
        //    // Usar punteros de funcion para evitar tener que recorer conexiones 2 veces o tener que duplicar codigo.
        //}


        /// <summary>
        /// Its Temporal.
        /// </summary>
        public static void FillSkinnedMeshRendererBones_tmp(ref SkinnedMeshRenderer pSmr)
        {
            if (pSmr.rootBone == null)
            {
                Debug.LogError($"The {pSmr.name} SkinnedMeshRenderer not find Root Bone", pSmr.gameObject);
                return;
            }

            Transform r = pSmr.rootBone;
            Transform[] t = r.GetComponentsInChildren<Transform>(includeInactive: true);

            pSmr.bones = t;
        }



        // ************************************************ //
        //                       Helpers                    //
        // ************************************************ //

        // TODO: Detectar como esta configurado el proyecto, (cc es gamma)
        private static Color convertColor(Vector3 pColor) =>
            new Color(pColor.x, pColor.y, pColor.z, 1.0f).gamma;
        private static Color convertColor(Vector4 pColor) =>
            new Color(pColor.x, pColor.y, pColor.z, pColor.w).gamma;




        public static unsafe Transform NodeTraslateToTransform(ufbx_node* pNode, ref GameObject pGO, Transform pParent = null)
        {
            Transform neo = pGO.transform;
            if (pParent != null)
                neo.SetParent(pParent, false);

            neo.localPosition = pNode->local_transform.translation.ToUnity();
            neo.localRotation = pNode->local_transform.rotation.ToUnity();
            neo.localScale = pNode->local_transform.scale.ToUnity();

            // TODO: Si es Root mover en local.
            //if (pNode->is_root == 1)
            //{
            //    neo.position = pNode->transform
            //}

            return neo;
        }














        public unsafe struct DataFaces
        {
            public Vector3[] Vertices;
            public Vector3[] Normals;
            public Vector2[] UVs;
            public int[] Triangles;
        }

        public unsafe struct DataVertex
        {
            public Vector3 Position;
            public Vector3 Normal;
            public Vector2 UV;
        }


        // TODO: Dividirlo por funciones mas pequeñas.
        // TODO: Coger: tangentes y colores de vertices, (Si se pueden otras cosas, mejor).
        // Problemas actuales: si, todo, all, cualquiera, tambien, tu!
        public static unsafe DataFaces GetDataFaces_old(ufbx_mesh* pMesh)
        {
            int totalTriangles = (int)pMesh->num_triangles;
            int totalVertices = totalTriangles * 3;

            Vector3[] vertices = new Vector3[totalVertices];
            Vector3[] normals = new Vector3[totalVertices];
            Vector2[] uvs = new Vector2[totalVertices];
            int[] triangles = new int[totalVertices];

            bool hasNormals = pMesh->vertex_normal.exists == 1;
            bool hasUVs = pMesh->vertex_uv.exists == 1;
            int vertexOutputIndex = 0;

            for (ulong f = 0; f < (ulong)pMesh->faces.count; f++)
            {
                ufbx_face* face = &pMesh->faces.data[f];

                for (uint v = 2; v < face->num_indices; v++)
                {
                    uint i0 = face->index_begin;
                    uint i1 = face->index_begin + v - 1;
                    uint i2 = face->index_begin + v;

                    int idx0 = vertexOutputIndex;
                    int idx1 = vertexOutputIndex + 1;
                    int idx2 = vertexOutputIndex + 2;

                    // Extraer Vértices
                    uint vIdx0 = pMesh->vertex_indices.data[i0];
                    uint vIdx1 = pMesh->vertex_indices.data[i1];
                    uint vIdx2 = pMesh->vertex_indices.data[i2];
                    vertices[idx0] = pMesh->vertices.data[vIdx0].ToUnity();
                    vertices[idx1] = pMesh->vertices.data[vIdx1].ToUnity();
                    vertices[idx2] = pMesh->vertices.data[vIdx2].ToUnity();

                    // Extraer Normales
                    if (hasNormals)
                    {
                        uint nIdx0 = pMesh->vertex_normal.indices.data[i0];
                        uint nIdx1 = pMesh->vertex_normal.indices.data[i1];
                        uint nIdx2 = pMesh->vertex_normal.indices.data[i2];
                        normals[idx0] = pMesh->vertex_normal.values.data[nIdx0].ToUnity();
                        normals[idx1] = pMesh->vertex_normal.values.data[nIdx1].ToUnity();
                        normals[idx2] = pMesh->vertex_normal.values.data[nIdx2].ToUnity();
                    }

                    // Extraer UVs
                    if (hasUVs)
                    {
                        uint uvIdx0 = pMesh->vertex_uv.indices.data[i0];
                        uint uvIdx1 = pMesh->vertex_uv.indices.data[i1];
                        uint uvIdx2 = pMesh->vertex_uv.indices.data[i2];
                        uvs[idx0] = pMesh->vertex_uv.values.data[uvIdx0].ToUnity();
                        uvs[idx1] = pMesh->vertex_uv.values.data[uvIdx1].ToUnity();
                        uvs[idx2] = pMesh->vertex_uv.values.data[uvIdx2].ToUnity();
                    }

                    triangles[idx0] = idx0;
                    triangles[idx1] = idx1;
                    triangles[idx2] = idx2;

                    vertexOutputIndex += 3;
                }
            }

            return new DataFaces
            {
                Vertices = vertices,
                Normals = hasNormals ? normals : null,
                UVs = hasUVs ? uvs : null,
                Triangles = triangles
            };
        }


        public static unsafe DataFaces GetDataFaces(ufbx_mesh* pMesh)
        {
            // Usamos estrictamente la cantidad de vértices originales (ej. 684)
            int vertexCount = (int)pMesh->num_vertices;

            Vector3[] vertices = new Vector3[vertexCount];
            Vector3[] normals = new Vector3[vertexCount];
            Vector2[] uvs = new Vector2[vertexCount];

            bool hasNormals = pMesh->vertex_normal.exists == 1;
            bool hasUVs = pMesh->vertex_uv.exists == 1;

            // 1. Llenamos el arreglo posicional base
            for (int i = 0; i < vertexCount; i++)
            {
                vertices[i] = pMesh->vertices.data[i].ToUnity();
            }

            // 2. Extraemos los triángulos usando los índices compartidos
            int totalTriangles = (int)pMesh->num_triangles;
            int[] triangles = new int[totalTriangles * 3];
            int triIndex = 0;

            for (ulong f = 0; f < (ulong)pMesh->faces.count; f++)
            {
                ufbx_face* face = &pMesh->faces.data[f];

                for (uint v = 2; v < face->num_indices; v++)
                {
                    uint i0 = face->index_begin;
                    uint i1 = face->index_begin + v - 1;
                    uint i2 = face->index_begin + v;

                    // Extraemos los índices originales que referencian de 0 a 683
                    uint vIdx0 = pMesh->vertex_indices.data[i0];
                    uint vIdx1 = pMesh->vertex_indices.data[i1];
                    uint vIdx2 = pMesh->vertex_indices.data[i2];

                    // Construimos la cara apuntando a los vértices originales sin crear copias
                    triangles[triIndex++] = (int)vIdx0;
                    triangles[triIndex++] = (int)vIdx1;
                    triangles[triIndex++] = (int)vIdx2;

                    // Proyectamos los datos de UVs y Normales al índice original del vértice
                    if (hasNormals)
                    {
                        normals[vIdx0] = pMesh->vertex_normal.values.data[pMesh->vertex_normal.indices.data[i0]].ToUnity();
                        normals[vIdx1] = pMesh->vertex_normal.values.data[pMesh->vertex_normal.indices.data[i1]].ToUnity();
                        normals[vIdx2] = pMesh->vertex_normal.values.data[pMesh->vertex_normal.indices.data[i2]].ToUnity();
                    }

                    if (hasUVs)
                    {
                        uvs[vIdx0] = pMesh->vertex_uv.values.data[pMesh->vertex_uv.indices.data[i0]].ToUnity();
                        uvs[vIdx1] = pMesh->vertex_uv.values.data[pMesh->vertex_uv.indices.data[i1]].ToUnity();
                        uvs[vIdx2] = pMesh->vertex_uv.values.data[pMesh->vertex_uv.indices.data[i2]].ToUnity();
                    }
                }
            }

            return new DataFaces
            {
                Vertices = vertices,
                Normals = hasNormals ? normals : null,
                UVs = hasUVs ? uvs : null,
                Triangles = triangles
            };
        }


        // TODO: Comprobar que llega a 1 de peso entre todos.
        public static unsafe (NativeList<BoneWeight1> weights, NativeList<byte> bonesPerVertex) GetBoneWeight(ufbx_mesh* pMesh)
        {
            NativeList<BoneWeight1> weights = new NativeList<BoneWeight1>(Allocator.Temp);
            NativeList<byte> bonesPerVertex = new NativeList<byte>((int)pMesh->num_vertices, Allocator.Temp);

            nuint betweenClusters = 0;

            for (nuint d = 0; d < pMesh->skin_deformers.count; d++)
            {
                ufbx_skin_deformer* deformer = pMesh->skin_deformers.data[d];

                // Debug.Log($"deformes: {pMesh->skin_deformers.count} | deformer: {deformer->vertices.count} | num_vertices: {pMesh->num_vertices}");

                addVertexArmature(deformer, ref betweenClusters, ref bonesPerVertex, ref weights);

                betweenClusters += deformer->clusters.count;
            }

            return (weights, bonesPerVertex);
        }

        // TODO: Un mejor nombre.
        private static unsafe void addVertexArmature(ufbx_skin_deformer* pDeformer, ref nuint pBetweenClusters, ref NativeList<byte> pBonesPerVertex, ref NativeList<BoneWeight1> pWeights)
        {
            for (nuint v = 0; v < pDeformer->vertices.count; v++)
            {
                ufbx_skin_vertex* vertex = &pDeformer->vertices.data[v];

                if (vertex->num_weights == 0)
                {
                    pBonesPerVertex.Add(1);
                    pWeights.Add(new BoneWeight1()
                    {
                        weight = 1.0f,
                        boneIndex = 0
                    });
                    Debug.LogError($"[FBXRuntime]: The fbx \"{pDeformer->Anonymous.element.scene->metadata.filename.ToString()}\" failed in Vertex \"{v}:aprox\" has zero weights in deformer \"{pDeformer->name}\".");
                    continue;
                }

                pBonesPerVertex.Add((byte)vertex->num_weights);

                for (uint w = 0; w < vertex->num_weights; w++)
                {
                    ufbx_skin_weight* weight = &pDeformer->weights.data[w + vertex->weight_begin];
                    pWeights.Add(new BoneWeight1() { weight = (float)weight->weight, boneIndex = (int)weight->cluster_index + (int)pBetweenClusters });
                }
            }
        }

        // Creo que hay una funcion interna que ya hace la conversion.
        public static unsafe int[] GetTrianges(ufbx_mesh* pMesh)
        {
            nuint l = pMesh->vertex_indices.count; // lenght
            int[] t = new int[l]; // triangles 

            for (nuint i = 0; i < l; i++)
            {
                t[i] = (int)pMesh->vertex_indices.data[i];
            }

            return t;
        }

        // TODO: Delegate para más ligerezca.
        public static unsafe void RoamSkinCluster(ufbx_mesh* pMesh, Action<nint> pEachDeformer = null, Action<nint, nint> pEachCluster = null)
        {
            for (nuint d = 0; d < pMesh->skin_deformers.count; d++)
            {
                ufbx_skin_deformer* deformer = pMesh->skin_deformers.data[d];
                pEachDeformer?.Invoke((nint)deformer);

                for (nuint c = 0; c < deformer->clusters.count; c++)
                {
                    ufbx_skin_cluster* cluster = deformer->clusters.data[c];
                    pEachCluster?.Invoke((nint)deformer, (nint)cluster);
                }
            }
        }
        public static unsafe void RoamSkinDeformer(ufbx_mesh* pMesh, Action<nint> pEachDeformer = null)
        {
            for (nuint d = 0; d < pMesh->skin_deformers.count; d++)
            {
                ufbx_skin_deformer* deformer = pMesh->skin_deformers.data[d];
                pEachDeformer?.Invoke((nint)deformer);
            }
        }


        public static unsafe Vector3[] GetVertex(ufbx_mesh* pMesh)
        {
            nuint length = pMesh->vertices.count;
            Vector3[] neo = new Vector3[length];

            for (nuint i = 0; i < length; i++)
            {
                ufbx_vec3 v3 = pMesh->vertices.data[i];
                neo[i] = new Vector3((float)v3.x, (float)v3.y, (float)v3.z);
            }

            return neo;
        }

        public static unsafe Vector4[] GetTangent(ufbx_mesh* pMesh)
        {
            nuint length = pMesh->vertex_tangent.values.count;
            Vector4[] neo = new Vector4[length];

            for (nuint i = 0; i < length; i++)
            {
                ufbx_vec3 v3 = pMesh->vertex_tangent.values.data[i];
                neo[i] = new Vector4((float)v3.x, (float)v3.y, (float)v3.z);
            }

            return neo;
        }

        public static unsafe Vector3[] GetVertexPosition(ufbx_mesh* pMesh)
        {
            Vector3[] neo;
            nuint length = pMesh->vertex_position.values.count;

            neo = new Vector3[length];
            for (nuint i = 0; i < length; i++)
            {
                ufbx_vec3 v3 = pMesh->vertex_position.values.data[i];
                neo[i] = new Vector3((float)v3.x, (float)v3.y, (float)v3.z);
            }

            return neo;
        }

        public static unsafe Vector3[] GetNormals(ufbx_mesh* pMesh)
        {
            Vector3[] neo;
            nuint length = pMesh->vertex_normal.values.count;

            neo = new Vector3[length];
            for (nuint i = 0; i < length; i++)
            {
                ufbx_vec3 v3 = pMesh->vertex_normal.values.data[i];
                neo[i] = new Vector3((float)v3.x, (float)v3.y, (float)v3.z);
            }

            return neo;
        }

        public static unsafe Color[] GetVextesColor(ufbx_mesh* pMesh)
        {
            nuint length = pMesh->vertex_color.values.count;
            Color[] neo = new Color[length];

            for (nuint i = 0; i < length; i++)
            {
                ufbx_vec4 v2 = pMesh->vertex_color.values.data[i];
                neo[i] = new Color((float)v2.x, (float)v2.y, (float)v2.z, (float)v2.w);
            }

            return neo;
        }

        public static unsafe Vector2[] GetUVs(ufbx_mesh* pMesh)
        {
            nuint length = pMesh->vertex_uv.values.count;
            Vector2[] neo = new Vector2[length];

            for (nuint i = 0; i < length; i++)
            {
                ufbx_vec2 v2 = pMesh->vertex_uv.values.data[i];
                neo[i] = new Vector2((float)v2.x, (float)v2.y);
            }

            return neo;
        }


        public static unsafe int[] GetTriangles(ufbx_mesh* pMesh)
        {
            nuint length = pMesh->vertex_indices.count;
            int[] neo = new int[length];

            fixed (int* dest = neo)
            {
                Buffer.MemoryCopy(pMesh->vertex_indices.data, dest,
                    (long)length * sizeof(uint), (long)length * sizeof(uint));
            }

            return neo;
        }































        /// <summary>
        /// Imprime toda la información de una ufbx_scene en la consola de Unity.
        /// </summary>
        /// <param name="pScene">Puntero a la escena ufbx cargada</param>
        public static unsafe void PrintSceneInfo(ufbx_scene* pScene)
        {
            if (pScene == null)
            {
                Debug.LogError("[UfbxScenePrinter] La escena es null.");
                return;
            }

            StringBuilder sb = GetSceneInfo(pScene);

            Debug.Log(sb.ToString());
        }

        public static unsafe StringBuilder GetSceneInfo(ufbx_scene* pScene)
        {
            if (pScene == null)
            {
                Debug.LogError("[UfbxScenePrinter] La escena es null.");
                return null;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("========== UFBX SCENE INFO ==========");

            // ---- Metadata ----
            PrintMetadata(pScene, sb);


            // ---- Settings ----
            PrintSettings(pScene, sb);


            // ---- Element counts ----
            PrintElementCounts(pScene, sb);


            // ---- Nodes ----
            PrintNodes(pScene, sb);


            // ---- Meshes ----
            PrintMeshes(pScene, sb);


            // ---- Materials ----
            PrintMaterials(pScene, sb);


            // ---- Textures ----
            PrintTextures(pScene, sb);


            // ---- Lights ----
            PrintLights(pScene, sb);


            // ---- Cameras ----
            PrintCameras(pScene, sb);


            // ---- Bones ----
            PrintBones(pScene, sb);


            // ---- Animation ----
            PrintAnimation(pScene, sb);


            // ---- Texture Files ----
            PrintTextureFiles(pScene, sb);


            // ---- Connections ----
            PrintConnections(pScene, sb);

            sb.AppendLine("========== END UFBX SCENE INFO ==========");

            return sb;
        }

        #region Private Helpers

        private static unsafe void PrintMetadata(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- METADATA ---");
            ref ufbx_metadata metadata = ref pScene->metadata;

            sb.AppendLine($"  Filename: {CsUfbx.ConvertString(in metadata.filename)}");
            sb.AppendLine($"  Creator: {CsUfbx.ConvertString(in metadata.creator)}");
            sb.AppendLine($"  Version: {metadata.version}");
            sb.AppendLine($"  File Format: {metadata.file_format}");
            sb.AppendLine($"  ASCII: {(metadata.ascii != 0 ? "Yes" : "No")}");
            sb.AppendLine($"  Big Endian: {(metadata.big_endian != 0 ? "Yes" : "No")}");
            sb.AppendLine($"  Exporter: {metadata.exporter}");
            sb.AppendLine($"  Exporter Version: {metadata.exporter_version}");
            sb.AppendLine($"  Original File Path: {CsUfbx.ConvertString(in metadata.original_file_path)}");
            sb.AppendLine($"  Relative Root: {CsUfbx.ConvertString(in metadata.relative_root)}");
            sb.AppendLine($"  Original Application: {CsUfbx.ConvertString(in metadata.original_application.name)} " +
                           $"v{CsUfbx.ConvertString(metadata.original_application.version)} " +
                           $"({CsUfbx.ConvertString(metadata.original_application.vendor)})");
            sb.AppendLine($"  Latest Application: {CsUfbx.ConvertString(in metadata.latest_application.name)} " +
                           $"v{CsUfbx.ConvertString(in metadata.latest_application.version)} " +
                           $"({CsUfbx.ConvertString(in metadata.latest_application.vendor)})");
            sb.AppendLine($"  Geometry Ignored: {(metadata.geometry_ignored != 0 ? "Yes" : "No")}");
            sb.AppendLine($"  Animation Ignored: {(metadata.animation_ignored != 0 ? "Yes" : "No")}");
            sb.AppendLine($"  Embedded Ignored: {(metadata.embedded_ignored != 0 ? "Yes" : "No")}");
            sb.AppendLine($"  Max Face Triangles: {metadata.max_face_triangles}");
            sb.AppendLine($"  Result Memory Used: {metadata.result_memory_used} bytes");
            sb.AppendLine($"  Temp Memory Used: {metadata.temp_memory_used} bytes");
            sb.AppendLine($"  Result Allocs: {metadata.result_allocs}");
            sb.AppendLine($"  Temp Allocs: {metadata.temp_allocs}");
            sb.AppendLine($"  Element Buffer Size: {metadata.element_buffer_size}");
            sb.AppendLine($"  Num Shader Textures: {metadata.num_shader_textures}");
            sb.AppendLine($"  Bone Prop Size Unit: {metadata.bone_prop_size_unit}");
            sb.AppendLine($"  Ortho Size Unit: {metadata.ortho_size_unit}");
            sb.AppendLine($"  KTime Second: {metadata.ktime_second}");
            sb.AppendLine($"  Space Conversion: {metadata.space_conversion}");
            sb.AppendLine($"  Geometry Transform Handling: {metadata.geometry_transform_handling}");
            sb.AppendLine($"  Inherit Mode Handling: {metadata.inherit_mode_handling}");
            sb.AppendLine($"  Pivot Handling: {metadata.pivot_handling}");
            sb.AppendLine($"  Handedness Conversion Axis: {metadata.handedness_conversion_axis}");
            sb.AppendLine($"  Root Scale: {metadata.root_scale}");
            sb.AppendLine($"  Mirror Axis: {metadata.mirror_axis}");
            sb.AppendLine($"  Geometry Scale: {metadata.geometry_scale}");

            // Warnings
            ufbx_warning_list warnings = metadata.warnings;
            sb.AppendLine($"  Warnings Count: {(int)warnings.count}");
            for (int i = 0; i < (int)warnings.count; i++)
            {
                ufbx_warning warning = warnings.data[i];
                sb.AppendLine($"    Warning [{i}]: Type={warning.type}, " +
                               $"Description={CsUfbx.ConvertString(in warning.description)}, " +
                               $"ElementID={warning.element_id}, " +
                               $"Count={warning.count}");
            }

            // Thumbnail
            sb.AppendLine($"  Thumbnail: {metadata.thumbnail.width}x{metadata.thumbnail.height}, " +
                           $"Format={metadata.thumbnail.format}");
        }

        private static unsafe void PrintSettings(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- SETTINGS ---");
            ref ufbx_scene_settings settings = ref pScene->settings;

            sb.AppendLine($"  Unit Meters: {settings.unit_meters}");
            sb.AppendLine($"  Frames Per Second: {settings.frames_per_second}");
            sb.AppendLine($"  Ambient Color: ({settings.ambient_color.x}, {settings.ambient_color.y}, {settings.ambient_color.z})");
            sb.AppendLine($"  Default Camera: {CsUfbx.ConvertString(in settings.default_camera)}");
            sb.AppendLine($"  Time Mode: {settings.time_mode}");
            sb.AppendLine($"  Time Protocol: {settings.time_protocol}");
            sb.AppendLine($"  Snap Mode: {settings.snap_mode}");
            sb.AppendLine($"  Original Axis Up: {settings.original_axis_up}");
            sb.AppendLine($"  Original Unit Meters: {settings.original_unit_meters}");
            sb.AppendLine($"  Axes: Right={settings.axes.right}, Up={settings.axes.up}, Front={settings.axes.front}");
        }

        private static unsafe void PrintElementCounts(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- ELEMENT COUNTS ---");
            sb.AppendLine($"  Nodes: {(int)pScene->nodes.count}");
            sb.AppendLine($"  Meshes: {(int)pScene->meshes.count}");
            sb.AppendLine($"  Lights: {(int)pScene->lights.count}");
            sb.AppendLine($"  Cameras: {(int)pScene->cameras.count}");
            sb.AppendLine($"  Bones: {(int)pScene->bones.count}");
            sb.AppendLine($"  Empties: {(int)pScene->empties.count}");
            sb.AppendLine($"  Line Curves: {(int)pScene->line_curves.count}");
            sb.AppendLine($"  Nurbs Curves: {(int)pScene->nurbs_curves.count}");
            sb.AppendLine($"  Nurbs Surfaces: {(int)pScene->nurbs_surfaces.count}");
            sb.AppendLine($"  Nurbs Trim Surfaces: {(int)pScene->nurbs_trim_surfaces.count}");
            sb.AppendLine($"  Nurbs Trim Boundaries: {(int)pScene->nurbs_trim_boundaries.count}");
            sb.AppendLine($"  Procedural Geometries: {(int)pScene->procedural_geometries.count}");
            sb.AppendLine($"  Stereo Cameras: {(int)pScene->stereo_cameras.count}");
            sb.AppendLine($"  Camera Switchers: {(int)pScene->camera_switchers.count}");
            sb.AppendLine($"  Markers: {(int)pScene->markers.count}");
            sb.AppendLine($"  LOD Groups: {(int)pScene->lod_groups.count}");
            sb.AppendLine($"  Skin Deformers: {(int)pScene->skin_deformers.count}");
            sb.AppendLine($"  Skin Clusters: {(int)pScene->skin_clusters.count}");
            sb.AppendLine($"  Blend Deformers: {(int)pScene->blend_deformers.count}");
            sb.AppendLine($"  Blend Channels: {(int)pScene->blend_channels.count}");
            sb.AppendLine($"  Blend Shapes: {(int)pScene->blend_shapes.count}");
            sb.AppendLine($"  Cache Deformers: {(int)pScene->cache_deformers.count}");
            sb.AppendLine($"  Cache Files: {(int)pScene->cache_files.count}");
            sb.AppendLine($"  Materials: {(int)pScene->materials.count}");
            sb.AppendLine($"  Textures: {(int)pScene->textures.count}");
            sb.AppendLine($"  Videos: {(int)pScene->videos.count}");
            sb.AppendLine($"  Shaders: {(int)pScene->shaders.count}");
            sb.AppendLine($"  Shader Bindings: {(int)pScene->shader_bindings.count}");
            sb.AppendLine($"  Anim Stacks: {(int)pScene->anim_stacks.count}");
            sb.AppendLine($"  Anim Layers: {(int)pScene->anim_layers.count}");
            sb.AppendLine($"  Anim Values: {(int)pScene->anim_values.count}");
            sb.AppendLine($"  Anim Curves: {(int)pScene->anim_curves.count}");
            sb.AppendLine($"  Display Layers: {(int)pScene->display_layers.count}");
            sb.AppendLine($"  Selection Sets: {(int)pScene->selection_sets.count}");
            sb.AppendLine($"  Selection Nodes: {(int)pScene->selection_nodes.count}");
            sb.AppendLine($"  Characters: {(int)pScene->characters.count}");
            sb.AppendLine($"  Constraints: {(int)pScene->constraints.count}");
            sb.AppendLine($"  Audio Layers: {(int)pScene->audio_layers.count}");
            sb.AppendLine($"  Audio Clips: {(int)pScene->audio_clips.count}");
            sb.AppendLine($"  Poses: {(int)pScene->poses.count}");
            sb.AppendLine($"  Metadata Objects: {(int)pScene->metadata_objects.count}");
            sb.AppendLine($"  Unknowns: {(int)pScene->unknowns.count}");
            sb.AppendLine($"  Total Elements: {(int)pScene->elements.count}");
            sb.AppendLine($"  Connections Src: {(int)pScene->connections_src.count}");
            sb.AppendLine($"  Connections Dst: {(int)pScene->connections_dst.count}");
            sb.AppendLine($"  Elements By Name: {(int)pScene->elements_by_name.count}");
        }

        private static unsafe void PrintNodes(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- NODES ---");
            ufbx_node_list nodes = pScene->nodes;
            for (int i = 0; i < (int)nodes.count; i++)
            {
                ufbx_node* node = nodes.data[i];
                string nodeName = CsUfbx.ConvertString(node->name);
                string parentName = node->parent != null ? CsUfbx.ConvertString(in node->parent->name) : "(null)";
                sb.AppendLine($"  [{i}] Name: \"{nodeName}\", " +
                               $"Parent: \"{parentName}\", " +
                               $"Children: {(int)node->children.count}, " +
                               $"Element_id: {node->element_id}, " +
                               $"Attribute: {node->attrib_type}, " +
                               $"IsRoot: {(node->is_root != 0 ? "Yes" : "No")}, " +
                               $"Visible: {(node->visible != 0 ? "Yes" : "No")}, " +
                               $"Depth: {node->node_depth}, " +
                               $"HasMesh: {(node->mesh != null ? "Yes" : "No")}, " +
                               $"HasLight: {(node->light != null ? "Yes" : "No")}, " +
                               $"HasCamera: {(node->camera != null ? "Yes" : "No")}, " +
                               $"HasBone: {(node->bone != null ? "Yes" : "No")}, " +
                               $"LocalTransform: T({node->local_transform.translation.x:F4}, {node->local_transform.translation.y:F4}, {node->local_transform.translation.z:F4}) " +
                               $"R({node->local_transform.rotation.x:F4}, {node->local_transform.rotation.y:F4}, {node->local_transform.rotation.z:F4}, {node->local_transform.rotation.w:F4}) " +
                               $"S({node->local_transform.scale.x:F4}, {node->local_transform.scale.y:F4}, {node->local_transform.scale.z:F4})");
            }
        }

        private static unsafe void PrintMeshes(ufbx_scene* pScene, StringBuilder sb)
        {
            ufbx_mesh_list meshes = pScene->meshes;

            sb.AppendLine();
            sb.AppendLine("--- MESHES ---");
            sb.AppendLine($"  Count: {(int)meshes.count}");

            for (int i = 0; i < (int)meshes.count; i++)
            {
                ufbx_mesh* mesh = meshes.data[i];
                sb.AppendLine($"  [{i}] Name: \"{CsUfbx.ConvertString(in mesh->name)}\"");
                sb.AppendLine($"      ElementId: {mesh->element_id}, TypedId: {mesh->typed_id}, " +
                               $"Instances: {(int)mesh->instances.count}");

                sb.AppendLine($"      Counts: Vertices={(int)mesh->num_vertices}, Indices={(int)mesh->num_indices}, " +
                               $"Faces={(int)mesh->num_faces}, Triangles={(int)mesh->num_triangles}, " +
                               $"Edges={(int)mesh->num_edges}, MaxFaceTriangles={(int)mesh->max_face_triangles}");
                sb.AppendLine($"      Face Types: Empty={(int)mesh->num_empty_faces}, " +
                               $"Point={(int)mesh->num_point_faces}, Line={(int)mesh->num_line_faces}");

                sb.AppendLine($"      Vertex Attributes (exists): " +
                               $"Position={(mesh->vertex_position.exists != 0 ? "Yes" : "No")}, " +
                               $"Normal={(mesh->vertex_normal.exists != 0 ? "Yes" : "No")}, " +
                               $"UV={(mesh->vertex_uv.exists != 0 ? "Yes" : "No")}, " +
                               $"Tangent={(mesh->vertex_tangent.exists != 0 ? "Yes" : "No")}, " +
                               $"Bitangent={(mesh->vertex_bitangent.exists != 0 ? "Yes" : "No")}, " +
                               $"Color={(mesh->vertex_color.exists != 0 ? "Yes" : "No")}, " +
                               $"Crease={(mesh->vertex_crease.exists != 0 ? "Yes" : "No")}");

                sb.AppendLine($"      Lists & Sets: UVSets={(int)mesh->uv_sets.count}, ColorSets={(int)mesh->color_sets.count}, " +
                               $"Materials={(int)mesh->materials.count}, FaceGroups={(int)mesh->face_groups.count}, " +
                               $"MaterialParts={(int)mesh->material_parts.count}");

                for (int u = 0; u < (int)mesh->uv_sets.count; u++)
                {
                    ufbx_uv_set uvSet = mesh->uv_sets.data[u];
                    sb.AppendLine($"          UVSet [{u}]: \"{CsUfbx.ConvertString(in uvSet.name)}\" (Index: {uvSet.index})");
                }

                for (int c = 0; c < (int)mesh->color_sets.count; c++)
                {
                    ufbx_color_set colorSet = mesh->color_sets.data[c];
                    sb.AppendLine($"          ColorSet [{c}]: \"{CsUfbx.ConvertString(in colorSet.name)}\" (Index: {colorSet.index})");
                }

                for (int j = 0; j < (int)mesh->materials.count; j++)
                {
                    ufbx_material* mat = mesh->materials.data[j];
                    if (mat != null)
                        sb.AppendLine($"          Material [{j}]: \"{CsUfbx.ConvertString(in mat->name)}\"");
                }

                sb.AppendLine($"      Deformers: Skin={(int)mesh->skin_deformers.count}, " +
                               $"Blend={(int)mesh->blend_deformers.count}, Cache={(int)mesh->cache_deformers.count}, " +
                               $"Total={(int)mesh->all_deformers.count}, SkinnedIsLocal={(mesh->skinned_is_local != 0 ? "Yes" : "No")}");

                for (int sd = 0; sd < (int)mesh->skin_deformers.count; sd++)
                {
                    ufbx_skin_deformer* skinDef = mesh->skin_deformers.data[sd];
                    if (skinDef != null)
                        sb.AppendLine($"          Skin Deformer [{sd}]: \"{CsUfbx.ConvertString(in skinDef->name)}\" (ElementID: {skinDef->element_id})");
                }

                for (int bd = 0; bd < (int)mesh->blend_deformers.count; bd++)
                {
                    ufbx_blend_deformer* blendDef = mesh->blend_deformers.data[bd];
                    if (blendDef != null)
                        sb.AppendLine($"          Blend Deformer [{bd}]: \"{CsUfbx.ConvertString(in blendDef->name)}\" (ElementID: {blendDef->element_id})");
                }

                for (int cd = 0; cd < (int)mesh->cache_deformers.count; cd++)
                {
                    ufbx_cache_deformer* cacheDef = mesh->cache_deformers.data[cd];
                    if (cacheDef != null)
                        sb.AppendLine($"          Cache Deformer [{cd}]: \"{CsUfbx.ConvertString(in cacheDef->name)}\" (ElementID: {cacheDef->element_id})");
                }

                sb.AppendLine($"      Subdivision: PreviewLevels={mesh->subdivision_preview_levels}, " +
                               $"RenderLevels={mesh->subdivision_render_levels}, " +
                               $"DisplayMode={mesh->subdivision_display_mode}, " +
                               $"Boundary={mesh->subdivision_boundary}, " +
                               $"UVBoundary={mesh->subdivision_uv_boundary}, " +
                               $"Evaluated={(mesh->subdivision_evaluated != 0 ? "Yes" : "No")}");

                sb.AppendLine($"      Flags: ReversedWinding={(mesh->reversed_winding != 0 ? "Yes" : "No")}, " +
                               $"GeneratedNormals={(mesh->generated_normals != 0 ? "Yes" : "No")}, " +
                               $"FromTessellatedNurbs={(mesh->from_tessellated_nurbs != 0 ? "Yes" : "No")}");
            }
        }

        private static unsafe void PrintMaterials(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- MATERIALS ---");
            ufbx_material_list materials = pScene->materials;
            for (int i = 0; i < (int)materials.count; i++)
            {
                ufbx_material* material = materials.data[i];
                sb.AppendLine($"  [{i}] Name: \"{CsUfbx.ConvertString(in material->name)}\", " +
                               $"ShaderType: {material->shader_type}, " +
                               $"Textures: {(int)material->textures.count}");
            }
        }

        private static unsafe void PrintTextures(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- TEXTURES ---");
            ufbx_texture_list textures = pScene->textures;
            for (int i = 0; i < (int)textures.count; i++)
            {
                ufbx_texture* texture = textures.data[i];
                sb.AppendLine($"  [{i}] Name: \"{CsUfbx.ConvertString(in texture->name)}\", " +
                               $"Type: {texture->type}, " +
                               $"Filename: \"{CsUfbx.ConvertString(in texture->filename)}\", " +
                               $"RelativeFilename: \"{CsUfbx.ConvertString(in texture->relative_filename)}\"");
            }
        }

        private static unsafe void PrintLights(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- LIGHTS ---");
            ufbx_light_list lights = pScene->lights;
            for (int i = 0; i < (int)lights.count; i++)
            {
                ufbx_light* light = lights.data[i];
                sb.AppendLine($"  [{i}] Name: \"{CsUfbx.ConvertString(in light->name)}\", " +
                               $"Type: {light->type}, " +
                               $"Color: ({light->color.x:F4}, {light->color.y:F4}, {light->color.z:F4}), " +
                               $"Intensity: {light->intensity}");
            }
        }

        private static unsafe void PrintCameras(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- CAMERAS ---");
            ufbx_camera_list cameras = pScene->cameras;
            for (int i = 0; i < (int)cameras.count; i++)
            {
                ufbx_camera* camera = cameras.data[i];
                sb.AppendLine($"  [{i}] Name: \"{CsUfbx.ConvertString(in camera->name)}\", " +
                               $"FOV: camera->field_of_view_degrees, " + // Error 
                               $"NearPlane: {camera->near_plane}, " +
                               $"FarPlane: {camera->far_plane}, " +
                               $"ProjectionMode: {camera->projection_mode}");
            }
        }

        private static unsafe void PrintBones(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- BONES ---");
            ufbx_bone_list bones = pScene->bones;
            sb.AppendLine($"  Count: {(int)bones.count}");

            for (int i = 0; i < (int)bones.count; i++)
            {
                ufbx_bone* bone = bones.data[i];
                sb.AppendLine($"  [{i}] Name: \"{CsUfbx.ConvertString(in bone->name)}\"");
                sb.AppendLine($"      ElementId: {bone->element_id}, TypedId: {bone->typed_id}");
                sb.AppendLine($"      Radius: {bone->radius:F4}, RelativeLength: {bone->relative_length:F4}, " +
                               $"IsRoot: {(bone->is_root != 0 ? "Yes" : "No")}, " +
                               $"Instances: {(int)bone->instances.count}");

                for (int j = 0; j < (int)bone->instances.count; j++)
                {
                    ufbx_node* node = bone->instances.data[j];
                    if (node == null) continue;

                    string nodeName = CsUfbx.ConvertString(in node->name);
                    string parentName = node->parent != null ? CsUfbx.ConvertString(in node->parent->name) : "(null)";

                    sb.AppendLine($"      Instance [{j}]: \"{nodeName}\"");
                    sb.AppendLine($"          Parent: \"{parentName}\", Children: {(int)node->children.count}, " +
                                   $"Depth: {node->node_depth}, Visible: {(node->visible != 0 ? "Yes" : "No")}");
                    sb.AppendLine($"          HasMesh: {(node->mesh != null ? "Yes" : "No")}, " +
                                   $"HasGeometryTransform: {(node->has_geometry_transform != 0 ? "Yes" : "No")}, " +
                                   $"InheritMode: {node->inherit_mode}, RotationOrder: {node->rotation_order}");

                    sb.AppendLine($"          LocalTransform:");
                    sb.AppendLine($"              T: ({node->local_transform.translation.x:F4}, {node->local_transform.translation.y:F4}, {node->local_transform.translation.z:F4})");
                    sb.AppendLine($"              R: ({node->local_transform.rotation.x:F4}, {node->local_transform.rotation.y:F4}, {node->local_transform.rotation.z:F4}, {node->local_transform.rotation.w:F4})");
                    sb.AppendLine($"              S: ({node->local_transform.scale.x:F4}, {node->local_transform.scale.y:F4}, {node->local_transform.scale.z:F4})");
                    sb.AppendLine($"          EulerRotation: ({node->euler_rotation.x:F4}, {node->euler_rotation.y:F4}, {node->euler_rotation.z:F4})");

                    sb.AppendLine($"          GeometryTransform:");
                    sb.AppendLine($"              T: ({node->geometry_transform.translation.x:F4}, {node->geometry_transform.translation.y:F4}, {node->geometry_transform.translation.z:F4})");
                    sb.AppendLine($"              R: ({node->geometry_transform.rotation.x:F4}, {node->geometry_transform.rotation.y:F4}, {node->geometry_transform.rotation.z:F4}, {node->geometry_transform.rotation.w:F4})");
                    sb.AppendLine($"              S: ({node->geometry_transform.scale.x:F4}, {node->geometry_transform.scale.y:F4}, {node->geometry_transform.scale.z:F4})");

                    sb.AppendLine($"          NodeToWorld: " +
                                   $"Pos({node->node_to_world.m03:F4}, {node->node_to_world.m13:F4}, {node->node_to_world.m23:F4})");
                }
            }
        }

        private static unsafe void PrintAnimation(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- ANIMATION ---");
            if (pScene->anim != null)
            {
                sb.AppendLine($"  Time Begin: {pScene->anim->time_begin}");
                sb.AppendLine($"  Time End: {pScene->anim->time_end}");
            }
            else
            {
                sb.AppendLine("  (No animation data)");
            }

            ufbx_anim_stack_list animStacks = pScene->anim_stacks;
            sb.AppendLine($"  Anim Stacks: {(int)animStacks.count}");
            for (int i = 0; i < (int)animStacks.count; i++)
            {
                ufbx_anim_stack* stack = animStacks.data[i];
                sb.AppendLine($"    [{i}] Name: \"{CsUfbx.ConvertString(in stack->name)}\", " +
                               $"Time Begin: {stack->time_begin}, " +
                               $"Time End: {stack->time_end}");
            }
        }

        private static unsafe void PrintTextureFiles(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- TEXTURE FILES ---");
            ufbx_texture_file_list textureFiles = pScene->texture_files;
            sb.AppendLine($"  Count: {(int)textureFiles.count}");
            for (int i = 0; i < (int)textureFiles.count; i++)
            {
                ufbx_texture_file file = textureFiles.data[i];
                sb.AppendLine($"  [{i}] Filename: \"{CsUfbx.ConvertString(in file.filename)}\", " +
                               $"RelativeFilename: \"{CsUfbx.ConvertString(in file.relative_filename)}\", " +
                               $"Content Size: {file.content.size} bytes");
            }
        }

        private static unsafe string describeElement(ufbx_element* pElement)
        {
            if (pElement == null) return "(null)";

            string name = CsUfbx.ConvertString(pElement->name);
            string label = name is null ? "<unnamed>" : $"\"{name}\"";
            return $"{label} [type={pElement->type}, element_id={pElement->element_id}, typed_id={pElement->typed_id}]";
        }

        private static unsafe void PrintConnections(ufbx_scene* pScene, StringBuilder sb)
        {
            sb.AppendLine();
            sb.AppendLine("--- CONNECTIONS ---");
            sb.AppendLine($"  Src Count: {(int)pScene->connections_src.count}, " +
                           $"Dst Count: {(int)pScene->connections_dst.count}");

            sb.AppendLine();
            sb.AppendLine("  -- By Source (connections_src) --");
            ufbx_connection_list srcList = pScene->connections_src;
            for (int i = 0; i < (int)srcList.count; i++)
            {
                ufbx_connection conn = srcList.data[i];
                string srcProp = CsUfbx.ConvertString(in conn.src_prop);
                string dstProp = CsUfbx.ConvertString(in conn.dst_prop);

                sb.AppendLine($"  [{i}] Src: {describeElement(conn.src)}" +
                               (string.IsNullOrEmpty(srcProp) ? "" : $" (Prop: \"{srcProp}\")"));
                sb.AppendLine($"       -> Dst: {describeElement(conn.dst)}" +
                               (string.IsNullOrEmpty(dstProp) ? "" : $" (Prop: \"{dstProp}\")"));
            }

            sb.AppendLine();
            sb.AppendLine("  -- By Destination (connections_dst) --");
            ufbx_connection_list dstList = pScene->connections_dst;
            for (int i = 0; i < (int)dstList.count; i++)
            {
                ufbx_connection conn = dstList.data[i];
                string srcProp = CsUfbx.ConvertString(in conn.src_prop);
                string dstProp = CsUfbx.ConvertString(in conn.dst_prop);

                sb.AppendLine($"  [{i}] Dst: {describeElement(conn.dst)}" +
                               (string.IsNullOrEmpty(dstProp) ? "" : $" (Prop: \"{dstProp}\")"));
                sb.AppendLine($"       <- Src: {describeElement(conn.src)}" +
                               (string.IsNullOrEmpty(srcProp) ? "" : $" (Prop: \"{srcProp}\")"));
            }
        }

        #endregion
    }











    public static unsafe class UfbxUnityExtensions
    {
        // Convierte ufbx_vec3 a UnityEngine.Vector3
        public static Vector3 ToUnity(this ufbx_vec3 v)
        {
            // ufbx_vec3 almacena datos como double (ufbx_real)[cite: 1]
            // NOTA: Unity usa un sistema de coordenadas Left-Handed (Y-up) y FBX suele ser Right-Handed.
            // Si no has configurado ufbx para que convierta el espacio de coordenadas automáticamente,
            // es posible que debas invertir el eje X aquí: return new Vector3((float)-v.x, (float)v.y, (float)v.z);
            return new Vector3((float)v.x, (float)v.y, (float)v.z);
        }

        // Convierte ufbx_quat a UnityEngine.Quaternion
        public static Quaternion ToUnity(this ufbx_quat q)
        {
            // Al igual que con los vectores, ufbx_quat almacena x, y, z, w como double[cite: 1]
            // Si inviertes el eje X arriba, debes ajustar el cuaternión: return new Quaternion((float)q.x, (float)-q.y, (float)-q.z, (float)q.w);
            return new Quaternion((float)q.x, (float)q.y, (float)q.z, (float)q.w);
        }


        public static Vector2 ToUnity(this ufbx_vec2 v)
        {
            return new Vector2((float)v.x, (float)v.y);
        }

        public static Vector4 ToUnity(this ufbx_vec4 v)
        {
            return new Vector4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        }


        public static Matrix4x4 ToUnity(this ufbx_matrix m)
        {
            Matrix4x4 mat = new()
            {
                m00 = (float)m.m00,  m10 = (float)m.m10,  m20 = (float)m.m20,
                m01 = (float)m.m01,  m11 = (float)m.m11,  m21 = (float)m.m21,
                m02 = (float)m.m02,  m12 = (float)m.m12,  m22 = (float)m.m22,
                m03 = (float)m.m03,  m13 = (float)m.m13,  m23 = (float)m.m23,

                m30 = 0f,
                m31 = 0f,
                m32 = 0f,
                m33 = 1f
            };
            return mat;
        }

        //public static BoneWeight1 ToBoneWeight1(this double r)
        //{

        //}

        // TODO: 
        //public static BoneWeight ToBoneWeight(this ufbx_real_list r)
        //{
        //    throw new NotImplementedException("WIMP");
        //    //return new BoneWeight
        //    //{
        //    //    weight0
        //    //};
        //}
    }







































}
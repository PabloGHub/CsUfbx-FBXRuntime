using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using static Ufbx.UfbxNative;

namespace Ufbx
{
    /*
    -- Variables:
    //starts: m_ = public, Recommended to use getters and setters
    starts: _ = private, NOT local
    starts: lowercase = private, local
    starts: "p" (lowercase) = local incoming parameter
    starts: uppercase = public
    -- Functions:
    starts: uppercase = public
    starts: lowercase = private
    //starts: __ = public, ONLY for modders, Not recommended
    */






    // ************************************************ //
    //                     CsUfbx                       //
    // ************************************************ //
    public static class CsUfbx
    {
        public static unsafe ufbx_scene* LoadScene(string pPath, out ufbx_error OutError)
        {
            return In.Internal_LoadScene(pPath, out OutError);
        }



        // Eh Comprobado que \/ tambien funciona.
        // new string((sbyte*)node->name.data, 0, (int)node->name.length)
        [Obsolete("Use: ConvertString")]
        public static unsafe string UfbxStringToString(ref ufbx_string pUSTR)
        {
            if (pUSTR.data == null || pUSTR.length == UIntPtr.Zero)
                return string.Empty;
            return Encoding.UTF8.GetString((byte*)pUSTR.data, (int)pUSTR.length);
        }
        [Obsolete("Use: ConvertString")]
        public static unsafe string UfbxStringToManaged(ufbx_string pUfbxString)
        {
            if (pUfbxString.data == null || pUfbxString.length == UIntPtr.Zero)
                return string.Empty;

            int length = (int)pUfbxString.length;
            byte[] bytes = new byte[length];
            for (int i = 0; i < length; i++)
            {
                bytes[i] = (byte)pUfbxString.data[i];
            }
            return Encoding.UTF8.GetString(bytes);
        }



        public static unsafe string ConvertString(in ufbx_string pU_str)
        {
            if (pU_str.data == null || pU_str.length == UIntPtr.Zero)
                return string.Empty;
            return Encoding.UTF8.GetString((byte*)pU_str.data, (int)pU_str.length);
        }
        public static unsafe string ConvertString(ufbx_string* pU_str)
        {
            if (pU_str == null || pU_str->data == null || pU_str->length == UIntPtr.Zero)
                return string.Empty;
            return Encoding.UTF8.GetString((byte*)pU_str->data, (int)pU_str->length);
        }
        public static string ConvertString(ufbx_string pU_str) =>
            ConvertString(in pU_str);









        // ************************************************ //
        //               Helpers from Ufbx.h                //
        // ************************************************ //
        // Utility functions for reading geometry data for a single index.
        //public static unsafe double ufbx_get_vertex_real(ufbx_vertex_real* v, [NativeTypeName("size_t")] UIntPtr index)
        //{
        //    ufbx_assert((int)index < (int)v->indices.count); // ufbx_assert esta en "check_fbx.c"
        //    return v->values.data[(int)v->indices.data[(int)index]];
        //}
        //public static unsafe ufbx_vec2 ufbx_get_vertex_vec2(const ufbx_vertex_vec2* v, size_t index) { ufbx_assert(index < v->indices.count); return v->values.data[(int32_t)v->indices.data[index]]; }
        //public static unsafe ufbx_vec3 ufbx_get_vertex_vec3(const ufbx_vertex_vec3* v, size_t index) { ufbx_assert(index < v->indices.count); return v->values.data[(int32_t)v->indices.data[index]]; }
        //public static unsafe ufbx_vec4 ufbx_get_vertex_vec4(const ufbx_vertex_vec4* v, size_t index) { ufbx_assert(index < v->indices.count); return v->values.data[(int32_t)v->indices.data[index]]; }


    }




    internal static class In
    {
        // [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        // public unsafe static extern ufbx_scene* ufbx_load_file([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("const ufbx_load_opts *")] ufbx_load_opts* opts, ufbx_error* error);
        internal static unsafe ufbx_scene* Internal_LoadScene(string pPath, out ufbx_error OutError)
        {
            byte[] pPathBytes = Encoding.UTF8.GetBytes(pPath + "\0");
            ufbx_load_opts opts = default;
            ufbx_error error = default;
            ufbx_scene* scene;

            fixed (byte* pPathPtr = pPathBytes)
            {
                ufbx_load_opts* pOpts = &opts;
                ufbx_error* pError = &error;
                scene = ufbx_load_file((sbyte*)pPathPtr, pOpts, pError);
            }

            OutError = error;

            if (error.type != ufbx_error_type.UFBX_ERROR_NONE)
                return null;

            return scene;
        }


    }










    internal static class Out
    {
        internal static unsafe bool Internal_SaveScene(string pPath, ufbx_scene* pScene, out ufbx_error OutError)
        {
            throw new NotImplementedException("TODO: Guardar escena en archivo");
            return false;
        }
    }










    public static unsafe class Ufbx_Extension
    {

    }




    public unsafe partial struct ufbx_string
    {
        public override readonly string ToString()
        {
            return CsUfbx.ConvertString(in this);
        }
    }





}




// Sui recuerda presionar "insert" para sustituir los espacios por letras.
// ************************************************ //
//                                                  //
// ************************************************ //
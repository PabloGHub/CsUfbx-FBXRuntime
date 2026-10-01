using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using static Ufbx.ufbx_aperture_format;
using static Ufbx.ufbx_aperture_mode;
using static Ufbx.ufbx_aspect_mode;
using static Ufbx.ufbx_bake_step_handling;
using static Ufbx.ufbx_blend_mode;
using static Ufbx.ufbx_cache_data_encoding;
using static Ufbx.ufbx_cache_data_format;
using static Ufbx.ufbx_cache_file_format;
using static Ufbx.ufbx_cache_interpretation;
using static Ufbx.ufbx_constraint_aim_up_type;
using static Ufbx.ufbx_constraint_ik_pole_type;
using static Ufbx.ufbx_constraint_type;
using static Ufbx.ufbx_coordinate_axis;
using static Ufbx.ufbx_dom_value_type;
using static Ufbx.ufbx_element_type;
using static Ufbx.ufbx_error_type;
using static Ufbx.ufbx_exporter;
using static Ufbx.ufbx_extrapolation_mode;
using static Ufbx.ufbx_file_format;
using static Ufbx.ufbx_gate_fit;
using static Ufbx.ufbx_geometry_transform_handling;
using static Ufbx.ufbx_index_error_handling;
using static Ufbx.ufbx_inherit_mode;
using static Ufbx.ufbx_inherit_mode_handling;
using static Ufbx.ufbx_interpolation;
using static Ufbx.ufbx_light_area_shape;
using static Ufbx.ufbx_light_decay;
using static Ufbx.ufbx_light_type;
using static Ufbx.ufbx_lod_display;
using static Ufbx.ufbx_marker_type;
using static Ufbx.ufbx_material_fbx_map;
using static Ufbx.ufbx_material_feature;
using static Ufbx.ufbx_material_pbr_map;
using static Ufbx.ufbx_mirror_axis;
using static Ufbx.ufbx_nurbs_topology;
using static Ufbx.ufbx_open_file_type;
using static Ufbx.ufbx_pivot_handling;
using static Ufbx.ufbx_projection_mode;
using static Ufbx.ufbx_prop_type;
using static Ufbx.ufbx_rotation_order;
using static Ufbx.ufbx_shader_texture_type;
using static Ufbx.ufbx_shader_type;
using static Ufbx.ufbx_skinning_method;
using static Ufbx.ufbx_snap_mode;
using static Ufbx.ufbx_space_conversion;
using static Ufbx.ufbx_subdivision_boundary;
using static Ufbx.ufbx_subdivision_display_mode;
using static Ufbx.ufbx_texture_type;
using static Ufbx.ufbx_thumbnail_format;
using static Ufbx.ufbx_time_mode;
using static Ufbx.ufbx_time_protocol;
using static Ufbx.ufbx_unicode_error_handling;
using static Ufbx.ufbx_warning_type;
using static Ufbx.ufbx_wrap_mode;

namespace Ufbx
{
    public unsafe partial struct ufbx_string
    {
        [NativeTypeName("const char *")]
        public sbyte* data;

        [NativeTypeName("size_t")]
        public UIntPtr length;
    }

    public unsafe partial struct ufbx_blob
    {
        [NativeTypeName("const void *")]
        public void* data;

        [NativeTypeName("size_t")]
        public UIntPtr size;
    }

    public unsafe partial struct ufbx_vec2
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L299_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref double x
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->x;
                }
            }
        }

        public ref double y
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->y;
                }
            }
        }

        public ref double v
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->v[0];
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L300_C3")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_real[2]")]
            public fixed double v[2];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_real")]
                public double x;

                [NativeTypeName("ufbx_real")]
                public double y;
            }
        }
    }

    public unsafe partial struct ufbx_vec3
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L309_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref double x
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->x;
                }
            }
        }

        public ref double y
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->y;
                }
            }
        }

        public ref double z
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->z;
                }
            }
        }

        public ref double v
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->v[0];
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L310_C3")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_real[3]")]
            public fixed double v[3];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_real")]
                public double x;

                [NativeTypeName("ufbx_real")]
                public double y;

                [NativeTypeName("ufbx_real")]
                public double z;
            }
        }
    }

    public unsafe partial struct ufbx_vec4
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L319_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref double x
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->x;
                }
            }
        }

        public ref double y
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->y;
                }
            }
        }

        public ref double z
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->z;
                }
            }
        }

        public ref double w
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->w;
                }
            }
        }

        public ref double v
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->v[0];
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L320_C3")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_real[4]")]
            public fixed double v[4];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_real")]
                public double x;

                [NativeTypeName("ufbx_real")]
                public double y;

                [NativeTypeName("ufbx_real")]
                public double z;

                [NativeTypeName("ufbx_real")]
                public double w;
            }
        }
    }

    public unsafe partial struct ufbx_quat
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L329_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref double x
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->x;
                }
            }
        }

        public ref double y
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->y;
                }
            }
        }

        public ref double z
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->z;
                }
            }
        }

        public ref double w
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->w;
                }
            }
        }

        public ref double v
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->v[0];
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L330_C3")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_real[4]")]
            public fixed double v[4];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_real")]
                public double x;

                [NativeTypeName("ufbx_real")]
                public double y;

                [NativeTypeName("ufbx_real")]
                public double z;

                [NativeTypeName("ufbx_real")]
                public double w;
            }
        }
    }

    public enum ufbx_rotation_order
    {
        UFBX_ROTATION_ORDER_XYZ,
        UFBX_ROTATION_ORDER_XZY,
        UFBX_ROTATION_ORDER_YZX,
        UFBX_ROTATION_ORDER_YXZ,
        UFBX_ROTATION_ORDER_ZXY,
        UFBX_ROTATION_ORDER_ZYX,
        UFBX_ROTATION_ORDER_SPHERIC,
        UFBX_ROTATION_ORDER_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_transform
    {
        public ufbx_vec3 translation;

        public ufbx_quat rotation;

        public ufbx_vec3 scale;
    }

    public unsafe partial struct ufbx_matrix
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L368_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref double m00
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m00;
                }
            }
        }

        public ref double m10
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m10;
                }
            }
        }

        public ref double m20
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m20;
                }
            }
        }

        public ref double m01
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m01;
                }
            }
        }

        public ref double m11
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m11;
                }
            }
        }

        public ref double m21
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m21;
                }
            }
        }

        public ref double m02
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m02;
                }
            }
        }

        public ref double m12
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m12;
                }
            }
        }

        public ref double m22
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m22;
                }
            }
        }

        public ref double m03
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m03;
                }
            }
        }

        public ref double m13
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m13;
                }
            }
        }

        public ref double m23
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->m23;
                }
            }
        }

        public ref _Anonymous_e__Union._cols_e__FixedBuffer cols
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->cols;
                }
            }
        }

        public ref double v
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->v[0];
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L369_C3")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_vec3[4]")]
            public _cols_e__FixedBuffer cols;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_real[12]")]
            public fixed double v[12];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ufbx_real")]
                public double m00;

                [NativeTypeName("ufbx_real")]
                public double m10;

                [NativeTypeName("ufbx_real")]
                public double m20;

                [NativeTypeName("ufbx_real")]
                public double m01;

                [NativeTypeName("ufbx_real")]
                public double m11;

                [NativeTypeName("ufbx_real")]
                public double m21;

                [NativeTypeName("ufbx_real")]
                public double m02;

                [NativeTypeName("ufbx_real")]
                public double m12;

                [NativeTypeName("ufbx_real")]
                public double m22;

                [NativeTypeName("ufbx_real")]
                public double m03;

                [NativeTypeName("ufbx_real")]
                public double m13;

                [NativeTypeName("ufbx_real")]
                public double m23;
            }

            public partial struct _cols_e__FixedBuffer
            {
                public ufbx_vec3 e0;
                public ufbx_vec3 e1;
                public ufbx_vec3 e2;
                public ufbx_vec3 e3;

                public unsafe ref ufbx_vec3 this[int index]
                {
                    get
                    {
                        fixed (ufbx_vec3* pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }
    }

    public unsafe partial struct ufbx_void_list
    {
        public void* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_bool_list
    {
        [NativeTypeName("bool*")]
        public byte* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_uint32_list
    {
        [NativeTypeName("uint32_t *")]
        public uint* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_real_list
    {
        [NativeTypeName("ufbx_real *")]
        public double* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_vec2_list
    {
        public ufbx_vec2* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_vec3_list
    {
        public ufbx_vec3* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_vec4_list
    {
        public ufbx_vec4* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_string_list
    {
        public ufbx_string* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public enum ufbx_dom_value_type
    {
        UFBX_DOM_VALUE_NUMBER,
        UFBX_DOM_VALUE_STRING,
        UFBX_DOM_VALUE_BLOB,
        UFBX_DOM_VALUE_ARRAY_I32,
        UFBX_DOM_VALUE_ARRAY_I64,
        UFBX_DOM_VALUE_ARRAY_F32,
        UFBX_DOM_VALUE_ARRAY_F64,
        UFBX_DOM_VALUE_ARRAY_BLOB,
        UFBX_DOM_VALUE_ARRAY_IGNORED,
        UFBX_DOM_VALUE_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_int32_list
    {
        [NativeTypeName("int32_t *")]
        public int* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_int64_list
    {
        [NativeTypeName("int64_t *")]
        public long* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_float_list
    {
        public float* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_double_list
    {
        public double* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_blob_list
    {
        public ufbx_blob* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_dom_value
    {
        public ufbx_dom_value_type type;

        public ufbx_string value_str;

        public ufbx_blob value_blob;

        [NativeTypeName("int64_t")]
        public long value_int;

        public double value_float;
    }

    public unsafe partial struct ufbx_dom_node_list
    {
        public ufbx_dom_node** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_dom_value_list
    {
        public ufbx_dom_value* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_dom_node
    {
        public ufbx_string name;

        public ufbx_dom_node_list children;

        public ufbx_dom_value_list values;
    }

    public enum ufbx_prop_type
    {
        UFBX_PROP_UNKNOWN,
        UFBX_PROP_BOOLEAN,
        UFBX_PROP_INTEGER,
        UFBX_PROP_NUMBER,
        UFBX_PROP_VECTOR,
        UFBX_PROP_COLOR,
        UFBX_PROP_COLOR_WITH_ALPHA,
        UFBX_PROP_STRING,
        UFBX_PROP_DATE_TIME,
        UFBX_PROP_TRANSLATION,
        UFBX_PROP_ROTATION,
        UFBX_PROP_SCALING,
        UFBX_PROP_DISTANCE,
        UFBX_PROP_COMPOUND,
        UFBX_PROP_BLOB,
        UFBX_PROP_REFERENCE,
        UFBX_PROP_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_prop_flags
    {
        UFBX_PROP_FLAG_ANIMATABLE = 0x1,
        UFBX_PROP_FLAG_USER_DEFINED = 0x2,
        UFBX_PROP_FLAG_HIDDEN = 0x4,
        UFBX_PROP_FLAG_LOCK_X = 0x10,
        UFBX_PROP_FLAG_LOCK_Y = 0x20,
        UFBX_PROP_FLAG_LOCK_Z = 0x40,
        UFBX_PROP_FLAG_LOCK_W = 0x80,
        UFBX_PROP_FLAG_MUTE_X = 0x100,
        UFBX_PROP_FLAG_MUTE_Y = 0x200,
        UFBX_PROP_FLAG_MUTE_Z = 0x400,
        UFBX_PROP_FLAG_MUTE_W = 0x800,
        UFBX_PROP_FLAG_SYNTHETIC = 0x1000,
        UFBX_PROP_FLAG_ANIMATED = 0x2000,
        UFBX_PROP_FLAG_NOT_FOUND = 0x4000,
        UFBX_PROP_FLAG_CONNECTED = 0x8000,
        UFBX_PROP_FLAG_NO_VALUE = 0x10000,
        UFBX_PROP_FLAG_OVERRIDDEN = 0x20000,
        UFBX_PROP_FLAG_VALUE_REAL = 0x100000,
        UFBX_PROP_FLAG_VALUE_VEC2 = 0x200000,
        UFBX_PROP_FLAG_VALUE_VEC3 = 0x400000,
        UFBX_PROP_FLAG_VALUE_VEC4 = 0x800000,
        UFBX_PROP_FLAG_VALUE_INT = 0x1000000,
        UFBX_PROP_FLAG_VALUE_STR = 0x2000000,
        UFBX_PROP_FLAG_VALUE_BLOB = 0x4000000,
        UFBX_PROP_FLAGS_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_prop
    {
        public ufbx_string name;

        [NativeTypeName("uint32_t")]
        public uint _internal_key;

        public ufbx_prop_type type;

        public ufbx_prop_flags flags;

        public ufbx_string value_str;

        public ufbx_blob value_blob;

        [NativeTypeName("int64_t")]
        public long value_int;

        [NativeTypeName("__AnonymousRecord_ufbx_L553_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref double value_real_arr
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_real_arr[0];
                }
            }
        }

        public ref double value_real
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_real;
                }
            }
        }

        public ref ufbx_vec2 value_vec2
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec2;
                }
            }
        }

        public ref ufbx_vec3 value_vec3
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec3;
                }
            }
        }

        public ref ufbx_vec4 value_vec4
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec4;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_real[4]")]
            public fixed double value_real_arr[4];

            [FieldOffset(0)]
            [NativeTypeName("ufbx_real")]
            public double value_real;

            [FieldOffset(0)]
            public ufbx_vec2 value_vec2;

            [FieldOffset(0)]
            public ufbx_vec3 value_vec3;

            [FieldOffset(0)]
            public ufbx_vec4 value_vec4;
        }
    }

    public unsafe partial struct ufbx_prop_list
    {
        public ufbx_prop* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_props
    {
        public ufbx_prop_list props;

        [NativeTypeName("size_t")]
        public UIntPtr num_animated;

        public ufbx_props* defaults;
    }

    public unsafe partial struct ufbx_element_list
    {
        public ufbx_element** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_unknown_list
    {
        public ufbx_unknown** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_node_list
    {
        public ufbx_node** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_mesh_list
    {
        public ufbx_mesh** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_light_list
    {
        public ufbx_light** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_camera_list
    {
        public ufbx_camera** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_bone_list
    {
        public ufbx_bone** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_empty_list
    {
        public ufbx_empty** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_line_curve_list
    {
        public ufbx_line_curve** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_nurbs_curve_list
    {
        public ufbx_nurbs_curve** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_nurbs_surface_list
    {
        public ufbx_nurbs_surface** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_nurbs_trim_surface_list
    {
        public ufbx_nurbs_trim_surface** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_nurbs_trim_boundary_list
    {
        public ufbx_nurbs_trim_boundary** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_procedural_geometry_list
    {
        public ufbx_procedural_geometry** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_stereo_camera_list
    {
        public ufbx_stereo_camera** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_camera_switcher_list
    {
        public ufbx_camera_switcher** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_marker_list
    {
        public ufbx_marker** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_lod_group_list
    {
        public ufbx_lod_group** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_skin_deformer_list
    {
        public ufbx_skin_deformer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_skin_cluster_list
    {
        public ufbx_skin_cluster** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_blend_deformer_list
    {
        public ufbx_blend_deformer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_blend_channel_list
    {
        public ufbx_blend_channel** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_blend_shape_list
    {
        public ufbx_blend_shape** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_cache_deformer_list
    {
        public ufbx_cache_deformer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_cache_file_list
    {
        public ufbx_cache_file** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_material_list
    {
        public ufbx_material** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_texture_list
    {
        public ufbx_texture** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_video_list
    {
        public ufbx_video** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_shader_list
    {
        public ufbx_shader** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_shader_binding_list
    {
        public ufbx_shader_binding** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_anim_stack_list
    {
        public ufbx_anim_stack** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_anim_layer_list
    {
        public ufbx_anim_layer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_anim_value_list
    {
        public ufbx_anim_value** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_anim_curve_list
    {
        public ufbx_anim_curve** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_display_layer_list
    {
        public ufbx_display_layer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_selection_set_list
    {
        public ufbx_selection_set** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_selection_node_list
    {
        public ufbx_selection_node** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_character_list
    {
        public ufbx_character** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_constraint_list
    {
        public ufbx_constraint** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_audio_layer_list
    {
        public ufbx_audio_layer** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_audio_clip_list
    {
        public ufbx_audio_clip** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_pose_list
    {
        public ufbx_pose** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_metadata_object_list
    {
        public ufbx_metadata_object** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public enum ufbx_element_type
    {
        UFBX_ELEMENT_UNKNOWN,
        UFBX_ELEMENT_NODE,
        UFBX_ELEMENT_MESH,
        UFBX_ELEMENT_LIGHT,
        UFBX_ELEMENT_CAMERA,
        UFBX_ELEMENT_BONE,
        UFBX_ELEMENT_EMPTY,
        UFBX_ELEMENT_LINE_CURVE,
        UFBX_ELEMENT_NURBS_CURVE,
        UFBX_ELEMENT_NURBS_SURFACE,
        UFBX_ELEMENT_NURBS_TRIM_SURFACE,
        UFBX_ELEMENT_NURBS_TRIM_BOUNDARY,
        UFBX_ELEMENT_PROCEDURAL_GEOMETRY,
        UFBX_ELEMENT_STEREO_CAMERA,
        UFBX_ELEMENT_CAMERA_SWITCHER,
        UFBX_ELEMENT_MARKER,
        UFBX_ELEMENT_LOD_GROUP,
        UFBX_ELEMENT_SKIN_DEFORMER,
        UFBX_ELEMENT_SKIN_CLUSTER,
        UFBX_ELEMENT_BLEND_DEFORMER,
        UFBX_ELEMENT_BLEND_CHANNEL,
        UFBX_ELEMENT_BLEND_SHAPE,
        UFBX_ELEMENT_CACHE_DEFORMER,
        UFBX_ELEMENT_CACHE_FILE,
        UFBX_ELEMENT_MATERIAL,
        UFBX_ELEMENT_TEXTURE,
        UFBX_ELEMENT_VIDEO,
        UFBX_ELEMENT_SHADER,
        UFBX_ELEMENT_SHADER_BINDING,
        UFBX_ELEMENT_ANIM_STACK,
        UFBX_ELEMENT_ANIM_LAYER,
        UFBX_ELEMENT_ANIM_VALUE,
        UFBX_ELEMENT_ANIM_CURVE,
        UFBX_ELEMENT_DISPLAY_LAYER,
        UFBX_ELEMENT_SELECTION_SET,
        UFBX_ELEMENT_SELECTION_NODE,
        UFBX_ELEMENT_CHARACTER,
        UFBX_ELEMENT_CONSTRAINT,
        UFBX_ELEMENT_AUDIO_LAYER,
        UFBX_ELEMENT_AUDIO_CLIP,
        UFBX_ELEMENT_POSE,
        UFBX_ELEMENT_METADATA_OBJECT,
        UFBX_ELEMENT_TYPE_FIRST_ATTRIB = UFBX_ELEMENT_MESH,
        UFBX_ELEMENT_TYPE_LAST_ATTRIB = UFBX_ELEMENT_LOD_GROUP,
        UFBX_ELEMENT_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_connection
    {
        public ufbx_element* src;

        public ufbx_element* dst;

        public ufbx_string src_prop;

        public ufbx_string dst_prop;
    }

    public unsafe partial struct ufbx_connection_list
    {
        public ufbx_connection* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_element
    {
        public ufbx_string name;

        public ufbx_props props;

        [NativeTypeName("uint32_t")]
        public uint element_id;

        [NativeTypeName("uint32_t")]
        public uint typed_id;

        public ufbx_node_list instances;

        public ufbx_element_type type;

        public ufbx_connection_list connections_src;

        public ufbx_connection_list connections_dst;

        public ufbx_dom_node* dom_node;

        public ufbx_scene* scene;
    }

    public unsafe partial struct ufbx_unknown
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L780_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_string type;

        public ufbx_string super_type;

        public ufbx_string sub_type;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L780_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public enum ufbx_inherit_mode
    {
        UFBX_INHERIT_MODE_NORMAL,
        UFBX_INHERIT_MODE_IGNORE_PARENT_SCALE,
        UFBX_INHERIT_MODE_COMPONENTWISE_SCALE,
        UFBX_INHERIT_MODE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_mirror_axis
    {
        UFBX_MIRROR_AXIS_NONE,
        UFBX_MIRROR_AXIS_X,
        UFBX_MIRROR_AXIS_Y,
        UFBX_MIRROR_AXIS_Z,
        UFBX_MIRROR_AXIS_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_node
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L845_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_node* parent;

        public ufbx_node_list children;

        public ufbx_mesh* mesh;

        public ufbx_light* light;

        public ufbx_camera* camera;

        public ufbx_bone* bone;

        public ufbx_element* attrib;

        public ufbx_node* geometry_transform_helper;

        public ufbx_node* scale_helper;

        public ufbx_element_type attrib_type;

        public ufbx_element_list all_attribs;

        public ufbx_inherit_mode inherit_mode;

        public ufbx_inherit_mode original_inherit_mode;

        public ufbx_transform local_transform;

        public ufbx_transform geometry_transform;

        public ufbx_vec3 inherit_scale;

        public ufbx_node* inherit_scale_node;

        public ufbx_rotation_order rotation_order;

        public ufbx_vec3 euler_rotation;

        public ufbx_matrix node_to_parent;

        public ufbx_matrix node_to_world;

        public ufbx_matrix geometry_to_node;

        public ufbx_matrix geometry_to_world;

        public ufbx_matrix unscaled_node_to_world;

        public ufbx_vec3 adjust_pre_translation;

        public ufbx_quat adjust_pre_rotation;

        [NativeTypeName("ufbx_real")]
        public double adjust_pre_scale;

        public ufbx_quat adjust_post_rotation;

        [NativeTypeName("ufbx_real")]
        public double adjust_post_scale;

        [NativeTypeName("ufbx_real")]
        public double adjust_translation_scale;

        public ufbx_mirror_axis adjust_mirror_axis;

        public ufbx_material_list materials;

        public ufbx_pose* bind_pose;

        [NativeTypeName("bool")]
        public byte visible;

        [NativeTypeName("bool")]
        public byte is_root;

        [NativeTypeName("bool")]
        public byte has_geometry_transform;

        [NativeTypeName("bool")]
        public byte use_rotation_space;

        [NativeTypeName("bool")]
        public byte has_adjust_transform;

        [NativeTypeName("bool")]
        public byte has_root_adjust_transform;

        [NativeTypeName("bool")]
        public byte is_geometry_transform_helper;

        [NativeTypeName("bool")]
        public byte is_scale_helper;

        [NativeTypeName("bool")]
        public byte is_scale_compensate_parent;

        [NativeTypeName("uint32_t")]
        public uint node_depth;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L845_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public partial struct ufbx_vertex_attrib
    {
        [NativeTypeName("bool")]
        public byte exists;

        public ufbx_void_list values;

        public ufbx_uint32_list indices;

        [NativeTypeName("size_t")]
        public UIntPtr value_reals;

        [NativeTypeName("bool")]
        public byte unique_per_vertex;

        public ufbx_real_list values_w;
    }

    public partial struct ufbx_vertex_real
    {
        [NativeTypeName("bool")]
        public byte exists;

        public ufbx_real_list values;

        public ufbx_uint32_list indices;

        [NativeTypeName("size_t")]
        public UIntPtr value_reals;

        [NativeTypeName("bool")]
        public byte unique_per_vertex;

        public ufbx_real_list values_w;
    }

    public partial struct ufbx_vertex_vec2
    {
        [NativeTypeName("bool")]
        public byte exists;

        public ufbx_vec2_list values;

        public ufbx_uint32_list indices;

        [NativeTypeName("size_t")]
        public UIntPtr value_reals;

        [NativeTypeName("bool")]
        public byte unique_per_vertex;

        public ufbx_real_list values_w;
    }

    public partial struct ufbx_vertex_vec3
    {
        [NativeTypeName("bool")]
        public byte exists;

        public ufbx_vec3_list values;

        public ufbx_uint32_list indices;

        [NativeTypeName("size_t")]
        public UIntPtr value_reals;

        [NativeTypeName("bool")]
        public byte unique_per_vertex;

        public ufbx_real_list values_w;
    }

    public partial struct ufbx_vertex_vec4
    {
        [NativeTypeName("bool")]
        public byte exists;

        public ufbx_vec4_list values;

        public ufbx_uint32_list indices;

        [NativeTypeName("size_t")]
        public UIntPtr value_reals;

        [NativeTypeName("bool")]
        public byte unique_per_vertex;

        public ufbx_real_list values_w;
    }

    public partial struct ufbx_uv_set
    {
        public ufbx_string name;

        [NativeTypeName("uint32_t")]
        public uint index;

        public ufbx_vertex_vec2 vertex_uv;

        public ufbx_vertex_vec3 vertex_tangent;

        public ufbx_vertex_vec3 vertex_bitangent;
    }

    public partial struct ufbx_color_set
    {
        public ufbx_string name;

        [NativeTypeName("uint32_t")]
        public uint index;

        public ufbx_vertex_vec4 vertex_color;
    }

    public unsafe partial struct ufbx_uv_set_list
    {
        public ufbx_uv_set* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_color_set_list
    {
        public ufbx_color_set* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_edge
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1100_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref uint a
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->a;
                }
            }
        }

        public ref uint b
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->b;
                }
            }
        }

        public ref uint indices
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->indices[0];
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1101_C3")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("uint32_t[2]")]
            public fixed uint indices[2];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("uint32_t")]
                public uint a;

                [NativeTypeName("uint32_t")]
                public uint b;
            }
        }
    }

    public unsafe partial struct ufbx_edge_list
    {
        public ufbx_edge* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_face
    {
        [NativeTypeName("uint32_t")]
        public uint index_begin;

        [NativeTypeName("uint32_t")]
        public uint num_indices;
    }

    public unsafe partial struct ufbx_face_list
    {
        public ufbx_face* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_mesh_part
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("size_t")]
        public UIntPtr num_faces;

        [NativeTypeName("size_t")]
        public UIntPtr num_triangles;

        [NativeTypeName("size_t")]
        public UIntPtr num_empty_faces;

        [NativeTypeName("size_t")]
        public UIntPtr num_point_faces;

        [NativeTypeName("size_t")]
        public UIntPtr num_line_faces;

        public ufbx_uint32_list face_indices;
    }

    public unsafe partial struct ufbx_mesh_part_list
    {
        public ufbx_mesh_part* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_face_group
    {
        [NativeTypeName("int32_t")]
        public int id;

        public ufbx_string name;
    }

    public unsafe partial struct ufbx_face_group_list
    {
        public ufbx_face_group* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_subdivision_weight_range
    {
        [NativeTypeName("uint32_t")]
        public uint weight_begin;

        [NativeTypeName("uint32_t")]
        public uint num_weights;
    }

    public unsafe partial struct ufbx_subdivision_weight_range_list
    {
        public ufbx_subdivision_weight_range* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_subdivision_weight
    {
        [NativeTypeName("ufbx_real")]
        public double weight;

        [NativeTypeName("uint32_t")]
        public uint index;
    }

    public unsafe partial struct ufbx_subdivision_weight_list
    {
        public ufbx_subdivision_weight* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_subdivision_result
    {
        [NativeTypeName("size_t")]
        public UIntPtr result_memory_used;

        [NativeTypeName("size_t")]
        public UIntPtr temp_memory_used;

        [NativeTypeName("size_t")]
        public UIntPtr result_allocs;

        [NativeTypeName("size_t")]
        public UIntPtr temp_allocs;

        public ufbx_subdivision_weight_range_list source_vertex_ranges;

        public ufbx_subdivision_weight_list source_vertex_weights;

        public ufbx_subdivision_weight_range_list skin_cluster_ranges;

        public ufbx_subdivision_weight_list skin_cluster_weights;
    }

    public enum ufbx_subdivision_display_mode
    {
        UFBX_SUBDIVISION_DISPLAY_DISABLED,
        UFBX_SUBDIVISION_DISPLAY_HULL,
        UFBX_SUBDIVISION_DISPLAY_HULL_AND_SMOOTH,
        UFBX_SUBDIVISION_DISPLAY_SMOOTH,
        UFBX_SUBDIVISION_DISPLAY_MODE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_subdivision_boundary
    {
        UFBX_SUBDIVISION_BOUNDARY_DEFAULT,
        UFBX_SUBDIVISION_BOUNDARY_LEGACY,
        UFBX_SUBDIVISION_BOUNDARY_SHARP_CORNERS,
        UFBX_SUBDIVISION_BOUNDARY_SHARP_NONE,
        UFBX_SUBDIVISION_BOUNDARY_SHARP_BOUNDARY,
        UFBX_SUBDIVISION_BOUNDARY_SHARP_INTERIOR,
        UFBX_SUBDIVISION_BOUNDARY_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_mesh
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1258_C2")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("size_t")]
        public UIntPtr num_vertices;

        [NativeTypeName("size_t")]
        public UIntPtr num_indices;

        [NativeTypeName("size_t")]
        public UIntPtr num_faces;

        [NativeTypeName("size_t")]
        public UIntPtr num_triangles;

        [NativeTypeName("size_t")]
        public UIntPtr num_edges;

        [NativeTypeName("size_t")]
        public UIntPtr max_face_triangles;

        [NativeTypeName("size_t")]
        public UIntPtr num_empty_faces;

        [NativeTypeName("size_t")]
        public UIntPtr num_point_faces;

        [NativeTypeName("size_t")]
        public UIntPtr num_line_faces;

        public ufbx_face_list faces;

        public ufbx_bool_list face_smoothing;

        public ufbx_uint32_list face_material;

        public ufbx_uint32_list face_group;

        public ufbx_bool_list face_hole;

        public ufbx_edge_list edges;

        public ufbx_bool_list edge_smoothing;

        public ufbx_real_list edge_crease;

        public ufbx_bool_list edge_visibility;

        public ufbx_uint32_list vertex_indices;

        public ufbx_vec3_list vertices;

        public ufbx_uint32_list vertex_first_index;

        public ufbx_vertex_vec3 vertex_position;

        public ufbx_vertex_vec3 vertex_normal;

        public ufbx_vertex_vec2 vertex_uv;

        public ufbx_vertex_vec3 vertex_tangent;

        public ufbx_vertex_vec3 vertex_bitangent;

        public ufbx_vertex_vec4 vertex_color;

        public ufbx_vertex_real vertex_crease;

        public ufbx_uv_set_list uv_sets;

        public ufbx_color_set_list color_sets;

        public ufbx_material_list materials;

        public ufbx_face_group_list face_groups;

        public ufbx_mesh_part_list material_parts;

        public ufbx_mesh_part_list face_group_parts;

        public ufbx_uint32_list material_part_usage_order;

        [NativeTypeName("bool")]
        public byte skinned_is_local;

        public ufbx_vertex_vec3 skinned_position;

        public ufbx_vertex_vec3 skinned_normal;

        public ufbx_skin_deformer_list skin_deformers;

        public ufbx_blend_deformer_list blend_deformers;

        public ufbx_cache_deformer_list cache_deformers;

        public ufbx_element_list all_deformers;

        [NativeTypeName("uint32_t")]
        public uint subdivision_preview_levels;

        [NativeTypeName("uint32_t")]
        public uint subdivision_render_levels;

        public ufbx_subdivision_display_mode subdivision_display_mode;

        public ufbx_subdivision_boundary subdivision_boundary;

        public ufbx_subdivision_boundary subdivision_uv_boundary;

        [NativeTypeName("bool")]
        public byte reversed_winding;

        [NativeTypeName("bool")]
        public byte generated_normals;

        [NativeTypeName("bool")]
        public byte subdivision_evaluated;

        public ufbx_subdivision_result* subdivision_result;

        [NativeTypeName("bool")]
        public byte from_tessellated_nurbs;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1258_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public enum ufbx_light_type
    {
        UFBX_LIGHT_POINT,
        UFBX_LIGHT_DIRECTIONAL,
        UFBX_LIGHT_SPOT,
        UFBX_LIGHT_AREA,
        UFBX_LIGHT_VOLUME,
        UFBX_LIGHT_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_light_decay
    {
        UFBX_LIGHT_DECAY_NONE,
        UFBX_LIGHT_DECAY_LINEAR,
        UFBX_LIGHT_DECAY_QUADRATIC,
        UFBX_LIGHT_DECAY_CUBIC,
        UFBX_LIGHT_DECAY_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_light_area_shape
    {
        UFBX_LIGHT_AREA_SHAPE_RECTANGLE,
        UFBX_LIGHT_AREA_SHAPE_SPHERE,
        UFBX_LIGHT_AREA_SHAPE_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_light
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1425_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_vec3 color;

        [NativeTypeName("ufbx_real")]
        public double intensity;

        public ufbx_vec3 local_direction;

        public ufbx_light_type type;

        public ufbx_light_decay decay;

        public ufbx_light_area_shape area_shape;

        [NativeTypeName("ufbx_real")]
        public double inner_angle;

        [NativeTypeName("ufbx_real")]
        public double outer_angle;

        [NativeTypeName("bool")]
        public byte cast_light;

        [NativeTypeName("bool")]
        public byte cast_shadows;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1425_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public enum ufbx_projection_mode
    {
        UFBX_PROJECTION_MODE_PERSPECTIVE,
        UFBX_PROJECTION_MODE_ORTHOGRAPHIC,
        UFBX_PROJECTION_MODE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_aspect_mode
    {
        UFBX_ASPECT_MODE_WINDOW_SIZE,
        UFBX_ASPECT_MODE_FIXED_RATIO,
        UFBX_ASPECT_MODE_FIXED_RESOLUTION,
        UFBX_ASPECT_MODE_FIXED_WIDTH,
        UFBX_ASPECT_MODE_FIXED_HEIGHT,
        UFBX_ASPECT_MODE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_aperture_mode
    {
        UFBX_APERTURE_MODE_HORIZONTAL_AND_VERTICAL,
        UFBX_APERTURE_MODE_HORIZONTAL,
        UFBX_APERTURE_MODE_VERTICAL,
        UFBX_APERTURE_MODE_FOCAL_LENGTH,
        UFBX_APERTURE_MODE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_gate_fit
    {
        UFBX_GATE_FIT_NONE,
        UFBX_GATE_FIT_VERTICAL,
        UFBX_GATE_FIT_HORIZONTAL,
        UFBX_GATE_FIT_FILL,
        UFBX_GATE_FIT_OVERSCAN,
        UFBX_GATE_FIT_STRETCH,
        UFBX_GATE_FIT_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_aperture_format
    {
        UFBX_APERTURE_FORMAT_CUSTOM,
        UFBX_APERTURE_FORMAT_16MM_THEATRICAL,
        UFBX_APERTURE_FORMAT_SUPER_16MM,
        UFBX_APERTURE_FORMAT_35MM_ACADEMY,
        UFBX_APERTURE_FORMAT_35MM_TV_PROJECTION,
        UFBX_APERTURE_FORMAT_35MM_FULL_APERTURE,
        UFBX_APERTURE_FORMAT_35MM_185_PROJECTION,
        UFBX_APERTURE_FORMAT_35MM_ANAMORPHIC,
        UFBX_APERTURE_FORMAT_70MM_PROJECTION,
        UFBX_APERTURE_FORMAT_VISTAVISION,
        UFBX_APERTURE_FORMAT_DYNAVISION,
        UFBX_APERTURE_FORMAT_IMAX,
        UFBX_APERTURE_FORMAT_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_coordinate_axis
    {
        UFBX_COORDINATE_AXIS_POSITIVE_X,
        UFBX_COORDINATE_AXIS_NEGATIVE_X,
        UFBX_COORDINATE_AXIS_POSITIVE_Y,
        UFBX_COORDINATE_AXIS_NEGATIVE_Y,
        UFBX_COORDINATE_AXIS_POSITIVE_Z,
        UFBX_COORDINATE_AXIS_NEGATIVE_Z,
        UFBX_COORDINATE_AXIS_UNKNOWN,
        UFBX_COORDINATE_AXIS_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_coordinate_axes
    {
        public ufbx_coordinate_axis right;

        public ufbx_coordinate_axis up;

        public ufbx_coordinate_axis front;
    }

    public unsafe partial struct ufbx_camera
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1568_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_projection_mode projection_mode;

        [NativeTypeName("bool")]
        public byte resolution_is_pixels;

        public ufbx_vec2 resolution;

        public ufbx_vec2 field_of_view_deg;

        public ufbx_vec2 field_of_view_tan;

        [NativeTypeName("ufbx_real")]
        public double orthographic_extent;

        public ufbx_vec2 orthographic_size;

        public ufbx_vec2 projection_plane;

        [NativeTypeName("ufbx_real")]
        public double aspect_ratio;

        [NativeTypeName("ufbx_real")]
        public double near_plane;

        [NativeTypeName("ufbx_real")]
        public double far_plane;

        public ufbx_coordinate_axes projection_axes;

        public ufbx_aspect_mode aspect_mode;

        public ufbx_aperture_mode aperture_mode;

        public ufbx_gate_fit gate_fit;

        public ufbx_aperture_format aperture_format;

        [NativeTypeName("ufbx_real")]
        public double focal_length_mm;

        public ufbx_vec2 film_size_inch;

        public ufbx_vec2 aperture_size_inch;

        [NativeTypeName("ufbx_real")]
        public double squeeze_ratio;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1568_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public unsafe partial struct ufbx_bone
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1636_C2")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_real")]
        public double radius;

        [NativeTypeName("ufbx_real")]
        public double relative_length;

        [NativeTypeName("bool")]
        public byte is_root;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1636_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public unsafe partial struct ufbx_empty
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1657_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1657_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public partial struct ufbx_line_segment
    {
        [NativeTypeName("uint32_t")]
        public uint index_begin;

        [NativeTypeName("uint32_t")]
        public uint num_indices;
    }

    public unsafe partial struct ufbx_line_segment_list
    {
        public ufbx_line_segment* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_line_curve
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1677_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_vec3 color;

        public ufbx_vec3_list control_points;

        public ufbx_uint32_list point_indices;

        public ufbx_line_segment_list segments;

        [NativeTypeName("bool")]
        public byte from_tessellated_nurbs;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1677_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public enum ufbx_nurbs_topology
    {
        UFBX_NURBS_TOPOLOGY_OPEN,
        UFBX_NURBS_TOPOLOGY_PERIODIC,
        UFBX_NURBS_TOPOLOGY_CLOSED,
        UFBX_NURBS_TOPOLOGY_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_nurbs_basis
    {
        [NativeTypeName("uint32_t")]
        public uint order;

        public ufbx_nurbs_topology topology;

        public ufbx_real_list knot_vector;

        [NativeTypeName("ufbx_real")]
        public double t_min;

        [NativeTypeName("ufbx_real")]
        public double t_max;

        public ufbx_real_list spans;

        [NativeTypeName("bool")]
        public byte is_2d;

        [NativeTypeName("size_t")]
        public UIntPtr num_wrap_control_points;

        [NativeTypeName("bool")]
        public byte valid;
    }

    public unsafe partial struct ufbx_nurbs_curve
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1746_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_nurbs_basis basis;

        public ufbx_vec4_list control_points;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1746_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public unsafe partial struct ufbx_nurbs_surface
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1764_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_nurbs_basis basis_u;

        public ufbx_nurbs_basis basis_v;

        [NativeTypeName("size_t")]
        public UIntPtr num_control_points_u;

        [NativeTypeName("size_t")]
        public UIntPtr num_control_points_v;

        public ufbx_vec4_list control_points;

        [NativeTypeName("uint32_t")]
        public uint span_subdivision_u;

        [NativeTypeName("uint32_t")]
        public uint span_subdivision_v;

        [NativeTypeName("bool")]
        public byte flip_normals;

        public ufbx_material* material;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1764_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public unsafe partial struct ufbx_nurbs_trim_surface
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1799_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1799_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public unsafe partial struct ufbx_nurbs_trim_boundary
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1809_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1809_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public unsafe partial struct ufbx_procedural_geometry
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1821_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1821_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public unsafe partial struct ufbx_stereo_camera
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1831_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_camera* left;

        public ufbx_camera* right;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1831_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public unsafe partial struct ufbx_camera_switcher
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1844_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1844_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public enum ufbx_marker_type
    {
        UFBX_MARKER_UNKNOWN,
        UFBX_MARKER_FK_EFFECTOR,
        UFBX_MARKER_IK_EFFECTOR,
        UFBX_MARKER_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_marker
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1865_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_marker_type type;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1865_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public enum ufbx_lod_display
    {
        UFBX_LOD_DISPLAY_USE_LOD,
        UFBX_LOD_DISPLAY_SHOW,
        UFBX_LOD_DISPLAY_HIDE,
        UFBX_LOD_DISPLAY_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_lod_level
    {
        [NativeTypeName("ufbx_real")]
        public double distance;

        public ufbx_lod_display display;
    }

    public unsafe partial struct ufbx_lod_level_list
    {
        public ufbx_lod_level* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_lod_group
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1909_C2")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("bool")]
        public byte relative_distances;

        public ufbx_lod_level_list lod_levels;

        [NativeTypeName("bool")]
        public byte ignore_parent_transform;

        [NativeTypeName("bool")]
        public byte use_distance_limit;

        [NativeTypeName("ufbx_real")]
        public double distance_limit_min;

        [NativeTypeName("ufbx_real")]
        public double distance_limit_max;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        public ref ufbx_node_list instances
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->instances;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1909_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;

                public ufbx_node_list instances;
            }
        }
    }

    public enum ufbx_skinning_method
    {
        UFBX_SKINNING_METHOD_LINEAR,
        UFBX_SKINNING_METHOD_RIGID,
        UFBX_SKINNING_METHOD_DUAL_QUATERNION,
        UFBX_SKINNING_METHOD_BLENDED_DQ_LINEAR,
        UFBX_SKINNING_METHOD_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_skin_vertex
    {
        [NativeTypeName("uint32_t")]
        public uint weight_begin;

        [NativeTypeName("uint32_t")]
        public uint num_weights;

        [NativeTypeName("ufbx_real")]
        public double dq_weight;
    }

    public unsafe partial struct ufbx_skin_vertex_list
    {
        public ufbx_skin_vertex* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_skin_weight
    {
        [NativeTypeName("uint32_t")]
        public uint cluster_index;

        [NativeTypeName("ufbx_real")]
        public double weight;
    }

    public unsafe partial struct ufbx_skin_weight_list
    {
        public ufbx_skin_weight* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_skin_deformer
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L1983_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_skinning_method skinning_method;

        public ufbx_skin_cluster_list clusters;

        public ufbx_skin_vertex_list vertices;

        public ufbx_skin_weight_list weights;

        [NativeTypeName("size_t")]
        public UIntPtr max_weights_per_vertex;

        [NativeTypeName("size_t")]
        public UIntPtr num_dq_weights;

        public ufbx_uint32_list dq_vertices;

        public ufbx_real_list dq_weights;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L1983_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_skin_cluster
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2012_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_node* bone_node;

        public ufbx_matrix geometry_to_bone;

        public ufbx_matrix mesh_node_to_bone;

        public ufbx_matrix bind_to_world;

        public ufbx_matrix geometry_to_world;

        public ufbx_transform geometry_to_world_transform;

        [NativeTypeName("size_t")]
        public UIntPtr num_weights;

        public ufbx_uint32_list vertices;

        public ufbx_real_list weights;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2012_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_blend_deformer
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2051_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_blend_channel_list channels;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2051_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_blend_keyframe
    {
        public ufbx_blend_shape* shape;

        [NativeTypeName("ufbx_real")]
        public double target_weight;

        [NativeTypeName("ufbx_real")]
        public double effective_weight;
    }

    public unsafe partial struct ufbx_blend_keyframe_list
    {
        public ufbx_blend_keyframe* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_blend_channel
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2079_C2")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_real")]
        public double weight;

        public ufbx_blend_keyframe_list keyframes;

        public ufbx_blend_shape* target_shape;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2079_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_blend_shape
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2099_C2")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("size_t")]
        public UIntPtr num_offsets;

        public ufbx_uint32_list offset_vertices;

        public ufbx_vec3_list position_offsets;

        public ufbx_vec3_list normal_offsets;

        public ufbx_real_list offset_weights;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2099_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public enum ufbx_cache_file_format
    {
        UFBX_CACHE_FILE_FORMAT_UNKNOWN,
        UFBX_CACHE_FILE_FORMAT_PC2,
        UFBX_CACHE_FILE_FORMAT_MC,
        UFBX_CACHE_FILE_FORMAT_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_cache_data_format
    {
        UFBX_CACHE_DATA_FORMAT_UNKNOWN,
        UFBX_CACHE_DATA_FORMAT_REAL_FLOAT,
        UFBX_CACHE_DATA_FORMAT_VEC3_FLOAT,
        UFBX_CACHE_DATA_FORMAT_REAL_DOUBLE,
        UFBX_CACHE_DATA_FORMAT_VEC3_DOUBLE,
        UFBX_CACHE_DATA_FORMAT_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_cache_data_encoding
    {
        UFBX_CACHE_DATA_ENCODING_UNKNOWN,
        UFBX_CACHE_DATA_ENCODING_LITTLE_ENDIAN,
        UFBX_CACHE_DATA_ENCODING_BIG_ENDIAN,
        UFBX_CACHE_DATA_ENCODING_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_cache_interpretation
    {
        UFBX_CACHE_INTERPRETATION_UNKNOWN,
        UFBX_CACHE_INTERPRETATION_POINTS,
        UFBX_CACHE_INTERPRETATION_VERTEX_POSITION,
        UFBX_CACHE_INTERPRETATION_VERTEX_NORMAL,
        UFBX_CACHE_INTERPRETATION_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_cache_frame
    {
        public ufbx_string channel;

        public double time;

        public ufbx_string filename;

        public ufbx_cache_file_format file_format;

        public ufbx_mirror_axis mirror_axis;

        [NativeTypeName("ufbx_real")]
        public double scale_factor;

        public ufbx_cache_data_format data_format;

        public ufbx_cache_data_encoding data_encoding;

        [NativeTypeName("uint64_t")]
        public ulong data_offset;

        [NativeTypeName("uint32_t")]
        public uint data_count;

        [NativeTypeName("uint32_t")]
        public uint data_element_bytes;

        [NativeTypeName("uint64_t")]
        public ulong data_total_bytes;
    }

    public unsafe partial struct ufbx_cache_frame_list
    {
        public ufbx_cache_frame* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_cache_channel
    {
        public ufbx_string name;

        public ufbx_cache_interpretation interpretation;

        public ufbx_string interpretation_name;

        public ufbx_cache_frame_list frames;

        public ufbx_mirror_axis mirror_axis;

        [NativeTypeName("ufbx_real")]
        public double scale_factor;
    }

    public unsafe partial struct ufbx_cache_channel_list
    {
        public ufbx_cache_channel* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_geometry_cache
    {
        public ufbx_string root_filename;

        public ufbx_cache_channel_list channels;

        public ufbx_cache_frame_list frames;

        public ufbx_string_list extra_info;
    }

    public unsafe partial struct ufbx_cache_deformer
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2236_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_string channel;

        public ufbx_cache_file* file;

        public ufbx_geometry_cache* external_cache;

        public ufbx_cache_channel* external_channel;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2236_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_cache_file
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2252_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_string filename;

        public ufbx_string absolute_filename;

        public ufbx_string relative_filename;

        public ufbx_blob raw_filename;

        public ufbx_blob raw_absolute_filename;

        public ufbx_blob raw_relative_filename;

        public ufbx_cache_file_format format;

        public ufbx_geometry_cache* external_cache;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2252_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_material_map
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2293_C2")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("int64_t")]
        public long value_int;

        public ufbx_texture* texture;

        [NativeTypeName("bool")]
        public byte has_value;

        [NativeTypeName("bool")]
        public byte texture_enabled;

        [NativeTypeName("bool")]
        public byte feature_disabled;

        [NativeTypeName("uint8_t")]
        public byte value_components;

        public ref double value_real
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_real;
                }
            }
        }

        public ref ufbx_vec2 value_vec2
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec2;
                }
            }
        }

        public ref ufbx_vec3 value_vec3
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec3;
                }
            }
        }

        public ref ufbx_vec4 value_vec4
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec4;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_real")]
            public double value_real;

            [FieldOffset(0)]
            public ufbx_vec2 value_vec2;

            [FieldOffset(0)]
            public ufbx_vec3 value_vec3;

            [FieldOffset(0)]
            public ufbx_vec4 value_vec4;
        }
    }

    public partial struct ufbx_material_feature_info
    {
        [NativeTypeName("bool")]
        public byte enabled;

        [NativeTypeName("bool")]
        public byte is_explicit;
    }

    public unsafe partial struct ufbx_material_texture
    {
        public ufbx_string material_prop;

        public ufbx_string shader_prop;

        public ufbx_texture* texture;
    }

    public unsafe partial struct ufbx_material_texture_list
    {
        public ufbx_material_texture* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public enum ufbx_shader_type
    {
        UFBX_SHADER_UNKNOWN,
        UFBX_SHADER_FBX_LAMBERT,
        UFBX_SHADER_FBX_PHONG,
        UFBX_SHADER_OSL_STANDARD_SURFACE,
        UFBX_SHADER_ARNOLD_STANDARD_SURFACE,
        UFBX_SHADER_3DS_MAX_PHYSICAL_MATERIAL,
        UFBX_SHADER_3DS_MAX_PBR_METAL_ROUGH,
        UFBX_SHADER_3DS_MAX_PBR_SPEC_GLOSS,
        UFBX_SHADER_GLTF_MATERIAL,
        UFBX_SHADER_OPENPBR_MATERIAL,
        UFBX_SHADER_SHADERFX_GRAPH,
        UFBX_SHADER_BLENDER_PHONG,
        UFBX_SHADER_WAVEFRONT_MTL,
        UFBX_SHADER_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_material_fbx_map
    {
        UFBX_MATERIAL_FBX_DIFFUSE_FACTOR,
        UFBX_MATERIAL_FBX_DIFFUSE_COLOR,
        UFBX_MATERIAL_FBX_SPECULAR_FACTOR,
        UFBX_MATERIAL_FBX_SPECULAR_COLOR,
        UFBX_MATERIAL_FBX_SPECULAR_EXPONENT,
        UFBX_MATERIAL_FBX_REFLECTION_FACTOR,
        UFBX_MATERIAL_FBX_REFLECTION_COLOR,
        UFBX_MATERIAL_FBX_TRANSPARENCY_FACTOR,
        UFBX_MATERIAL_FBX_TRANSPARENCY_COLOR,
        UFBX_MATERIAL_FBX_EMISSION_FACTOR,
        UFBX_MATERIAL_FBX_EMISSION_COLOR,
        UFBX_MATERIAL_FBX_AMBIENT_FACTOR,
        UFBX_MATERIAL_FBX_AMBIENT_COLOR,
        UFBX_MATERIAL_FBX_NORMAL_MAP,
        UFBX_MATERIAL_FBX_BUMP,
        UFBX_MATERIAL_FBX_BUMP_FACTOR,
        UFBX_MATERIAL_FBX_DISPLACEMENT_FACTOR,
        UFBX_MATERIAL_FBX_DISPLACEMENT,
        UFBX_MATERIAL_FBX_VECTOR_DISPLACEMENT_FACTOR,
        UFBX_MATERIAL_FBX_VECTOR_DISPLACEMENT,
        UFBX_MATERIAL_FBX_MAP_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_material_pbr_map
    {
        UFBX_MATERIAL_PBR_BASE_FACTOR,
        UFBX_MATERIAL_PBR_BASE_COLOR,
        UFBX_MATERIAL_PBR_ROUGHNESS,
        UFBX_MATERIAL_PBR_METALNESS,
        UFBX_MATERIAL_PBR_DIFFUSE_ROUGHNESS,
        UFBX_MATERIAL_PBR_SPECULAR_FACTOR,
        UFBX_MATERIAL_PBR_SPECULAR_COLOR,
        UFBX_MATERIAL_PBR_SPECULAR_IOR,
        UFBX_MATERIAL_PBR_SPECULAR_ANISOTROPY,
        UFBX_MATERIAL_PBR_SPECULAR_ROTATION,
        UFBX_MATERIAL_PBR_TRANSMISSION_FACTOR,
        UFBX_MATERIAL_PBR_TRANSMISSION_COLOR,
        UFBX_MATERIAL_PBR_TRANSMISSION_DEPTH,
        UFBX_MATERIAL_PBR_TRANSMISSION_SCATTER,
        UFBX_MATERIAL_PBR_TRANSMISSION_SCATTER_ANISOTROPY,
        UFBX_MATERIAL_PBR_TRANSMISSION_DISPERSION,
        UFBX_MATERIAL_PBR_TRANSMISSION_ROUGHNESS,
        UFBX_MATERIAL_PBR_TRANSMISSION_EXTRA_ROUGHNESS,
        UFBX_MATERIAL_PBR_TRANSMISSION_PRIORITY,
        UFBX_MATERIAL_PBR_TRANSMISSION_ENABLE_IN_AOV,
        UFBX_MATERIAL_PBR_SUBSURFACE_FACTOR,
        UFBX_MATERIAL_PBR_SUBSURFACE_COLOR,
        UFBX_MATERIAL_PBR_SUBSURFACE_RADIUS,
        UFBX_MATERIAL_PBR_SUBSURFACE_SCALE,
        UFBX_MATERIAL_PBR_SUBSURFACE_ANISOTROPY,
        UFBX_MATERIAL_PBR_SUBSURFACE_TINT_COLOR,
        UFBX_MATERIAL_PBR_SUBSURFACE_TYPE,
        UFBX_MATERIAL_PBR_SHEEN_FACTOR,
        UFBX_MATERIAL_PBR_SHEEN_COLOR,
        UFBX_MATERIAL_PBR_SHEEN_ROUGHNESS,
        UFBX_MATERIAL_PBR_COAT_FACTOR,
        UFBX_MATERIAL_PBR_COAT_COLOR,
        UFBX_MATERIAL_PBR_COAT_ROUGHNESS,
        UFBX_MATERIAL_PBR_COAT_IOR,
        UFBX_MATERIAL_PBR_COAT_ANISOTROPY,
        UFBX_MATERIAL_PBR_COAT_ROTATION,
        UFBX_MATERIAL_PBR_COAT_NORMAL,
        UFBX_MATERIAL_PBR_COAT_AFFECT_BASE_COLOR,
        UFBX_MATERIAL_PBR_COAT_AFFECT_BASE_ROUGHNESS,
        UFBX_MATERIAL_PBR_THIN_FILM_FACTOR,
        UFBX_MATERIAL_PBR_THIN_FILM_THICKNESS,
        UFBX_MATERIAL_PBR_THIN_FILM_IOR,
        UFBX_MATERIAL_PBR_EMISSION_FACTOR,
        UFBX_MATERIAL_PBR_EMISSION_COLOR,
        UFBX_MATERIAL_PBR_OPACITY,
        UFBX_MATERIAL_PBR_INDIRECT_DIFFUSE,
        UFBX_MATERIAL_PBR_INDIRECT_SPECULAR,
        UFBX_MATERIAL_PBR_NORMAL_MAP,
        UFBX_MATERIAL_PBR_TANGENT_MAP,
        UFBX_MATERIAL_PBR_DISPLACEMENT_MAP,
        UFBX_MATERIAL_PBR_MATTE_FACTOR,
        UFBX_MATERIAL_PBR_MATTE_COLOR,
        UFBX_MATERIAL_PBR_AMBIENT_OCCLUSION,
        UFBX_MATERIAL_PBR_GLOSSINESS,
        UFBX_MATERIAL_PBR_COAT_GLOSSINESS,
        UFBX_MATERIAL_PBR_TRANSMISSION_GLOSSINESS,
        UFBX_MATERIAL_PBR_MAP_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_material_feature
    {
        UFBX_MATERIAL_FEATURE_PBR,
        UFBX_MATERIAL_FEATURE_METALNESS,
        UFBX_MATERIAL_FEATURE_DIFFUSE,
        UFBX_MATERIAL_FEATURE_SPECULAR,
        UFBX_MATERIAL_FEATURE_EMISSION,
        UFBX_MATERIAL_FEATURE_TRANSMISSION,
        UFBX_MATERIAL_FEATURE_COAT,
        UFBX_MATERIAL_FEATURE_SHEEN,
        UFBX_MATERIAL_FEATURE_OPACITY,
        UFBX_MATERIAL_FEATURE_AMBIENT_OCCLUSION,
        UFBX_MATERIAL_FEATURE_MATTE,
        UFBX_MATERIAL_FEATURE_UNLIT,
        UFBX_MATERIAL_FEATURE_IOR,
        UFBX_MATERIAL_FEATURE_DIFFUSE_ROUGHNESS,
        UFBX_MATERIAL_FEATURE_TRANSMISSION_ROUGHNESS,
        UFBX_MATERIAL_FEATURE_THIN_WALLED,
        UFBX_MATERIAL_FEATURE_CAUSTICS,
        UFBX_MATERIAL_FEATURE_EXIT_TO_BACKGROUND,
        UFBX_MATERIAL_FEATURE_INTERNAL_REFLECTIONS,
        UFBX_MATERIAL_FEATURE_DOUBLE_SIDED,
        UFBX_MATERIAL_FEATURE_ROUGHNESS_AS_GLOSSINESS,
        UFBX_MATERIAL_FEATURE_COAT_ROUGHNESS_AS_GLOSSINESS,
        UFBX_MATERIAL_FEATURE_TRANSMISSION_ROUGHNESS_AS_GLOSSINESS,
        UFBX_MATERIAL_FEATURE_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_material_fbx_maps
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2514_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._maps_e__FixedBuffer maps
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->maps;
                }
            }
        }

        public ref ufbx_material_map diffuse_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->diffuse_factor;
                }
            }
        }

        public ref ufbx_material_map diffuse_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->diffuse_color;
                }
            }
        }

        public ref ufbx_material_map specular_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_factor;
                }
            }
        }

        public ref ufbx_material_map specular_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_color;
                }
            }
        }

        public ref ufbx_material_map specular_exponent
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_exponent;
                }
            }
        }

        public ref ufbx_material_map reflection_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->reflection_factor;
                }
            }
        }

        public ref ufbx_material_map reflection_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->reflection_color;
                }
            }
        }

        public ref ufbx_material_map transparency_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transparency_factor;
                }
            }
        }

        public ref ufbx_material_map transparency_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transparency_color;
                }
            }
        }

        public ref ufbx_material_map emission_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->emission_factor;
                }
            }
        }

        public ref ufbx_material_map emission_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->emission_color;
                }
            }
        }

        public ref ufbx_material_map ambient_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->ambient_factor;
                }
            }
        }

        public ref ufbx_material_map ambient_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->ambient_color;
                }
            }
        }

        public ref ufbx_material_map normal_map
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->normal_map;
                }
            }
        }

        public ref ufbx_material_map bump
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->bump;
                }
            }
        }

        public ref ufbx_material_map bump_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->bump_factor;
                }
            }
        }

        public ref ufbx_material_map displacement_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->displacement_factor;
                }
            }
        }

        public ref ufbx_material_map displacement
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->displacement;
                }
            }
        }

        public ref ufbx_material_map vector_displacement_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->vector_displacement_factor;
                }
            }
        }

        public ref ufbx_material_map vector_displacement
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->vector_displacement;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_material_map[20]")]
            public _maps_e__FixedBuffer maps;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2516_C3")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_material_map diffuse_factor;

                public ufbx_material_map diffuse_color;

                public ufbx_material_map specular_factor;

                public ufbx_material_map specular_color;

                public ufbx_material_map specular_exponent;

                public ufbx_material_map reflection_factor;

                public ufbx_material_map reflection_color;

                public ufbx_material_map transparency_factor;

                public ufbx_material_map transparency_color;

                public ufbx_material_map emission_factor;

                public ufbx_material_map emission_color;

                public ufbx_material_map ambient_factor;

                public ufbx_material_map ambient_color;

                public ufbx_material_map normal_map;

                public ufbx_material_map bump;

                public ufbx_material_map bump_factor;

                public ufbx_material_map displacement_factor;

                public ufbx_material_map displacement;

                public ufbx_material_map vector_displacement_factor;

                public ufbx_material_map vector_displacement;
            }

            public partial struct _maps_e__FixedBuffer
            {
                public ufbx_material_map e0;
                public ufbx_material_map e1;
                public ufbx_material_map e2;
                public ufbx_material_map e3;
                public ufbx_material_map e4;
                public ufbx_material_map e5;
                public ufbx_material_map e6;
                public ufbx_material_map e7;
                public ufbx_material_map e8;
                public ufbx_material_map e9;
                public ufbx_material_map e10;
                public ufbx_material_map e11;
                public ufbx_material_map e12;
                public ufbx_material_map e13;
                public ufbx_material_map e14;
                public ufbx_material_map e15;
                public ufbx_material_map e16;
                public ufbx_material_map e17;
                public ufbx_material_map e18;
                public ufbx_material_map e19;

                public unsafe ref ufbx_material_map this[int index]
                {
                    get
                    {
                        fixed (ufbx_material_map* pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }
    }

    public unsafe partial struct ufbx_material_pbr_maps
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2542_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._maps_e__FixedBuffer maps
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->maps;
                }
            }
        }

        public ref ufbx_material_map base_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->base_factor;
                }
            }
        }

        public ref ufbx_material_map base_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->base_color;
                }
            }
        }

        public ref ufbx_material_map roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->roughness;
                }
            }
        }

        public ref ufbx_material_map metalness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->metalness;
                }
            }
        }

        public ref ufbx_material_map diffuse_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->diffuse_roughness;
                }
            }
        }

        public ref ufbx_material_map specular_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_factor;
                }
            }
        }

        public ref ufbx_material_map specular_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_color;
                }
            }
        }

        public ref ufbx_material_map specular_ior
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_ior;
                }
            }
        }

        public ref ufbx_material_map specular_anisotropy
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_anisotropy;
                }
            }
        }

        public ref ufbx_material_map specular_rotation
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular_rotation;
                }
            }
        }

        public ref ufbx_material_map transmission_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_factor;
                }
            }
        }

        public ref ufbx_material_map transmission_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_color;
                }
            }
        }

        public ref ufbx_material_map transmission_depth
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_depth;
                }
            }
        }

        public ref ufbx_material_map transmission_scatter
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_scatter;
                }
            }
        }

        public ref ufbx_material_map transmission_scatter_anisotropy
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_scatter_anisotropy;
                }
            }
        }

        public ref ufbx_material_map transmission_dispersion
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_dispersion;
                }
            }
        }

        public ref ufbx_material_map transmission_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_roughness;
                }
            }
        }

        public ref ufbx_material_map transmission_extra_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_extra_roughness;
                }
            }
        }

        public ref ufbx_material_map transmission_priority
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_priority;
                }
            }
        }

        public ref ufbx_material_map transmission_enable_in_aov
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_enable_in_aov;
                }
            }
        }

        public ref ufbx_material_map subsurface_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_factor;
                }
            }
        }

        public ref ufbx_material_map subsurface_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_color;
                }
            }
        }

        public ref ufbx_material_map subsurface_radius
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_radius;
                }
            }
        }

        public ref ufbx_material_map subsurface_scale
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_scale;
                }
            }
        }

        public ref ufbx_material_map subsurface_anisotropy
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_anisotropy;
                }
            }
        }

        public ref ufbx_material_map subsurface_tint_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_tint_color;
                }
            }
        }

        public ref ufbx_material_map subsurface_type
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->subsurface_type;
                }
            }
        }

        public ref ufbx_material_map sheen_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->sheen_factor;
                }
            }
        }

        public ref ufbx_material_map sheen_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->sheen_color;
                }
            }
        }

        public ref ufbx_material_map sheen_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->sheen_roughness;
                }
            }
        }

        public ref ufbx_material_map coat_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_factor;
                }
            }
        }

        public ref ufbx_material_map coat_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_color;
                }
            }
        }

        public ref ufbx_material_map coat_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_roughness;
                }
            }
        }

        public ref ufbx_material_map coat_ior
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_ior;
                }
            }
        }

        public ref ufbx_material_map coat_anisotropy
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_anisotropy;
                }
            }
        }

        public ref ufbx_material_map coat_rotation
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_rotation;
                }
            }
        }

        public ref ufbx_material_map coat_normal
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_normal;
                }
            }
        }

        public ref ufbx_material_map coat_affect_base_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_affect_base_color;
                }
            }
        }

        public ref ufbx_material_map coat_affect_base_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_affect_base_roughness;
                }
            }
        }

        public ref ufbx_material_map thin_film_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->thin_film_factor;
                }
            }
        }

        public ref ufbx_material_map thin_film_thickness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->thin_film_thickness;
                }
            }
        }

        public ref ufbx_material_map thin_film_ior
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->thin_film_ior;
                }
            }
        }

        public ref ufbx_material_map emission_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->emission_factor;
                }
            }
        }

        public ref ufbx_material_map emission_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->emission_color;
                }
            }
        }

        public ref ufbx_material_map opacity
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->opacity;
                }
            }
        }

        public ref ufbx_material_map indirect_diffuse
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->indirect_diffuse;
                }
            }
        }

        public ref ufbx_material_map indirect_specular
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->indirect_specular;
                }
            }
        }

        public ref ufbx_material_map normal_map
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->normal_map;
                }
            }
        }

        public ref ufbx_material_map tangent_map
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->tangent_map;
                }
            }
        }

        public ref ufbx_material_map displacement_map
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->displacement_map;
                }
            }
        }

        public ref ufbx_material_map matte_factor
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->matte_factor;
                }
            }
        }

        public ref ufbx_material_map matte_color
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->matte_color;
                }
            }
        }

        public ref ufbx_material_map ambient_occlusion
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->ambient_occlusion;
                }
            }
        }

        public ref ufbx_material_map glossiness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->glossiness;
                }
            }
        }

        public ref ufbx_material_map coat_glossiness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_glossiness;
                }
            }
        }

        public ref ufbx_material_map transmission_glossiness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_glossiness;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_material_map[56]")]
            public _maps_e__FixedBuffer maps;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2544_C3")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_material_map base_factor;

                public ufbx_material_map base_color;

                public ufbx_material_map roughness;

                public ufbx_material_map metalness;

                public ufbx_material_map diffuse_roughness;

                public ufbx_material_map specular_factor;

                public ufbx_material_map specular_color;

                public ufbx_material_map specular_ior;

                public ufbx_material_map specular_anisotropy;

                public ufbx_material_map specular_rotation;

                public ufbx_material_map transmission_factor;

                public ufbx_material_map transmission_color;

                public ufbx_material_map transmission_depth;

                public ufbx_material_map transmission_scatter;

                public ufbx_material_map transmission_scatter_anisotropy;

                public ufbx_material_map transmission_dispersion;

                public ufbx_material_map transmission_roughness;

                public ufbx_material_map transmission_extra_roughness;

                public ufbx_material_map transmission_priority;

                public ufbx_material_map transmission_enable_in_aov;

                public ufbx_material_map subsurface_factor;

                public ufbx_material_map subsurface_color;

                public ufbx_material_map subsurface_radius;

                public ufbx_material_map subsurface_scale;

                public ufbx_material_map subsurface_anisotropy;

                public ufbx_material_map subsurface_tint_color;

                public ufbx_material_map subsurface_type;

                public ufbx_material_map sheen_factor;

                public ufbx_material_map sheen_color;

                public ufbx_material_map sheen_roughness;

                public ufbx_material_map coat_factor;

                public ufbx_material_map coat_color;

                public ufbx_material_map coat_roughness;

                public ufbx_material_map coat_ior;

                public ufbx_material_map coat_anisotropy;

                public ufbx_material_map coat_rotation;

                public ufbx_material_map coat_normal;

                public ufbx_material_map coat_affect_base_color;

                public ufbx_material_map coat_affect_base_roughness;

                public ufbx_material_map thin_film_factor;

                public ufbx_material_map thin_film_thickness;

                public ufbx_material_map thin_film_ior;

                public ufbx_material_map emission_factor;

                public ufbx_material_map emission_color;

                public ufbx_material_map opacity;

                public ufbx_material_map indirect_diffuse;

                public ufbx_material_map indirect_specular;

                public ufbx_material_map normal_map;

                public ufbx_material_map tangent_map;

                public ufbx_material_map displacement_map;

                public ufbx_material_map matte_factor;

                public ufbx_material_map matte_color;

                public ufbx_material_map ambient_occlusion;

                public ufbx_material_map glossiness;

                public ufbx_material_map coat_glossiness;

                public ufbx_material_map transmission_glossiness;
            }

            public partial struct _maps_e__FixedBuffer
            {
                public ufbx_material_map e0;
                public ufbx_material_map e1;
                public ufbx_material_map e2;
                public ufbx_material_map e3;
                public ufbx_material_map e4;
                public ufbx_material_map e5;
                public ufbx_material_map e6;
                public ufbx_material_map e7;
                public ufbx_material_map e8;
                public ufbx_material_map e9;
                public ufbx_material_map e10;
                public ufbx_material_map e11;
                public ufbx_material_map e12;
                public ufbx_material_map e13;
                public ufbx_material_map e14;
                public ufbx_material_map e15;
                public ufbx_material_map e16;
                public ufbx_material_map e17;
                public ufbx_material_map e18;
                public ufbx_material_map e19;
                public ufbx_material_map e20;
                public ufbx_material_map e21;
                public ufbx_material_map e22;
                public ufbx_material_map e23;
                public ufbx_material_map e24;
                public ufbx_material_map e25;
                public ufbx_material_map e26;
                public ufbx_material_map e27;
                public ufbx_material_map e28;
                public ufbx_material_map e29;
                public ufbx_material_map e30;
                public ufbx_material_map e31;
                public ufbx_material_map e32;
                public ufbx_material_map e33;
                public ufbx_material_map e34;
                public ufbx_material_map e35;
                public ufbx_material_map e36;
                public ufbx_material_map e37;
                public ufbx_material_map e38;
                public ufbx_material_map e39;
                public ufbx_material_map e40;
                public ufbx_material_map e41;
                public ufbx_material_map e42;
                public ufbx_material_map e43;
                public ufbx_material_map e44;
                public ufbx_material_map e45;
                public ufbx_material_map e46;
                public ufbx_material_map e47;
                public ufbx_material_map e48;
                public ufbx_material_map e49;
                public ufbx_material_map e50;
                public ufbx_material_map e51;
                public ufbx_material_map e52;
                public ufbx_material_map e53;
                public ufbx_material_map e54;
                public ufbx_material_map e55;

                public unsafe ref ufbx_material_map this[int index]
                {
                    get
                    {
                        fixed (ufbx_material_map* pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }
    }

    public unsafe partial struct ufbx_material_features
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2606_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref _Anonymous_e__Union._features_e__FixedBuffer features
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->features;
                }
            }
        }

        public ref ufbx_material_feature_info pbr
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->pbr;
                }
            }
        }

        public ref ufbx_material_feature_info metalness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->metalness;
                }
            }
        }

        public ref ufbx_material_feature_info diffuse
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->diffuse;
                }
            }
        }

        public ref ufbx_material_feature_info specular
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->specular;
                }
            }
        }

        public ref ufbx_material_feature_info emission
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->emission;
                }
            }
        }

        public ref ufbx_material_feature_info transmission
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission;
                }
            }
        }

        public ref ufbx_material_feature_info coat
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat;
                }
            }
        }

        public ref ufbx_material_feature_info sheen
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->sheen;
                }
            }
        }

        public ref ufbx_material_feature_info opacity
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->opacity;
                }
            }
        }

        public ref ufbx_material_feature_info ambient_occlusion
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->ambient_occlusion;
                }
            }
        }

        public ref ufbx_material_feature_info matte
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->matte;
                }
            }
        }

        public ref ufbx_material_feature_info unlit
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->unlit;
                }
            }
        }

        public ref ufbx_material_feature_info ior
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->ior;
                }
            }
        }

        public ref ufbx_material_feature_info diffuse_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->diffuse_roughness;
                }
            }
        }

        public ref ufbx_material_feature_info transmission_roughness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_roughness;
                }
            }
        }

        public ref ufbx_material_feature_info thin_walled
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->thin_walled;
                }
            }
        }

        public ref ufbx_material_feature_info caustics
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->caustics;
                }
            }
        }

        public ref ufbx_material_feature_info exit_to_background
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->exit_to_background;
                }
            }
        }

        public ref ufbx_material_feature_info internal_reflections
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->internal_reflections;
                }
            }
        }

        public ref ufbx_material_feature_info double_sided
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->double_sided;
                }
            }
        }

        public ref ufbx_material_feature_info roughness_as_glossiness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->roughness_as_glossiness;
                }
            }
        }

        public ref ufbx_material_feature_info coat_roughness_as_glossiness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->coat_roughness_as_glossiness;
                }
            }
        }

        public ref ufbx_material_feature_info transmission_roughness_as_glossiness
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->transmission_roughness_as_glossiness;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_material_feature_info[23]")]
            public _features_e__FixedBuffer features;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2608_C3")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_material_feature_info pbr;

                public ufbx_material_feature_info metalness;

                public ufbx_material_feature_info diffuse;

                public ufbx_material_feature_info specular;

                public ufbx_material_feature_info emission;

                public ufbx_material_feature_info transmission;

                public ufbx_material_feature_info coat;

                public ufbx_material_feature_info sheen;

                public ufbx_material_feature_info opacity;

                public ufbx_material_feature_info ambient_occlusion;

                public ufbx_material_feature_info matte;

                public ufbx_material_feature_info unlit;

                public ufbx_material_feature_info ior;

                public ufbx_material_feature_info diffuse_roughness;

                public ufbx_material_feature_info transmission_roughness;

                public ufbx_material_feature_info thin_walled;

                public ufbx_material_feature_info caustics;

                public ufbx_material_feature_info exit_to_background;

                public ufbx_material_feature_info internal_reflections;

                public ufbx_material_feature_info double_sided;

                public ufbx_material_feature_info roughness_as_glossiness;

                public ufbx_material_feature_info coat_roughness_as_glossiness;

                public ufbx_material_feature_info transmission_roughness_as_glossiness;
            }

            public partial struct _features_e__FixedBuffer
            {
                public ufbx_material_feature_info e0;
                public ufbx_material_feature_info e1;
                public ufbx_material_feature_info e2;
                public ufbx_material_feature_info e3;
                public ufbx_material_feature_info e4;
                public ufbx_material_feature_info e5;
                public ufbx_material_feature_info e6;
                public ufbx_material_feature_info e7;
                public ufbx_material_feature_info e8;
                public ufbx_material_feature_info e9;
                public ufbx_material_feature_info e10;
                public ufbx_material_feature_info e11;
                public ufbx_material_feature_info e12;
                public ufbx_material_feature_info e13;
                public ufbx_material_feature_info e14;
                public ufbx_material_feature_info e15;
                public ufbx_material_feature_info e16;
                public ufbx_material_feature_info e17;
                public ufbx_material_feature_info e18;
                public ufbx_material_feature_info e19;
                public ufbx_material_feature_info e20;
                public ufbx_material_feature_info e21;
                public ufbx_material_feature_info e22;

                public unsafe ref ufbx_material_feature_info this[int index]
                {
                    get
                    {
                        fixed (ufbx_material_feature_info* pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }
    }

    public unsafe partial struct ufbx_material
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2639_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_material_fbx_maps fbx;

        public ufbx_material_pbr_maps pbr;

        public ufbx_material_features features;

        public ufbx_shader_type shader_type;

        public ufbx_shader* shader;

        public ufbx_string shading_model_name;

        public ufbx_string shader_prop_prefix;

        public ufbx_material_texture_list textures;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2639_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public enum ufbx_texture_type
    {
        UFBX_TEXTURE_FILE,
        UFBX_TEXTURE_LAYERED,
        UFBX_TEXTURE_PROCEDURAL,
        UFBX_TEXTURE_SHADER,
        UFBX_TEXTURE_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_blend_mode
    {
        UFBX_BLEND_TRANSLUCENT,
        UFBX_BLEND_ADDITIVE,
        UFBX_BLEND_MULTIPLY,
        UFBX_BLEND_MULTIPLY_2X,
        UFBX_BLEND_OVER,
        UFBX_BLEND_REPLACE,
        UFBX_BLEND_DISSOLVE,
        UFBX_BLEND_DARKEN,
        UFBX_BLEND_COLOR_BURN,
        UFBX_BLEND_LINEAR_BURN,
        UFBX_BLEND_DARKER_COLOR,
        UFBX_BLEND_LIGHTEN,
        UFBX_BLEND_SCREEN,
        UFBX_BLEND_COLOR_DODGE,
        UFBX_BLEND_LINEAR_DODGE,
        UFBX_BLEND_LIGHTER_COLOR,
        UFBX_BLEND_SOFT_LIGHT,
        UFBX_BLEND_HARD_LIGHT,
        UFBX_BLEND_VIVID_LIGHT,
        UFBX_BLEND_LINEAR_LIGHT,
        UFBX_BLEND_PIN_LIGHT,
        UFBX_BLEND_HARD_MIX,
        UFBX_BLEND_DIFFERENCE,
        UFBX_BLEND_EXCLUSION,
        UFBX_BLEND_SUBTRACT,
        UFBX_BLEND_DIVIDE,
        UFBX_BLEND_HUE,
        UFBX_BLEND_SATURATION,
        UFBX_BLEND_COLOR,
        UFBX_BLEND_LUMINOSITY,
        UFBX_BLEND_OVERLAY,
        UFBX_BLEND_MODE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_wrap_mode
    {
        UFBX_WRAP_REPEAT,
        UFBX_WRAP_CLAMP,
        UFBX_WRAP_MODE_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_texture_layer
    {
        public ufbx_texture* texture;

        public ufbx_blend_mode blend_mode;

        [NativeTypeName("ufbx_real")]
        public double alpha;
    }

    public unsafe partial struct ufbx_texture_layer_list
    {
        public ufbx_texture_layer* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public enum ufbx_shader_texture_type
    {
        UFBX_SHADER_TEXTURE_UNKNOWN,
        UFBX_SHADER_TEXTURE_SELECT_OUTPUT,
        UFBX_SHADER_TEXTURE_OSL,
        UFBX_SHADER_TEXTURE_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_shader_texture_input
    {
        public ufbx_string name;

        [NativeTypeName("__AnonymousRecord_ufbx_L2781_C2")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("int64_t")]
        public long value_int;

        public ufbx_string value_str;

        public ufbx_blob value_blob;

        public ufbx_texture* texture;

        [NativeTypeName("int64_t")]
        public long texture_output_index;

        [NativeTypeName("bool")]
        public byte texture_enabled;

        public ufbx_prop* prop;

        public ufbx_prop* texture_prop;

        public ufbx_prop* texture_enabled_prop;

        public ref double value_real
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_real;
                }
            }
        }

        public ref ufbx_vec2 value_vec2
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec2;
                }
            }
        }

        public ref ufbx_vec3 value_vec3
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec3;
                }
            }
        }

        public ref ufbx_vec4 value_vec4
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->value_vec4;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ufbx_real")]
            public double value_real;

            [FieldOffset(0)]
            public ufbx_vec2 value_vec2;

            [FieldOffset(0)]
            public ufbx_vec3 value_vec3;

            [FieldOffset(0)]
            public ufbx_vec4 value_vec4;
        }
    }

    public unsafe partial struct ufbx_shader_texture_input_list
    {
        public ufbx_shader_texture_input* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_shader_texture
    {
        public ufbx_shader_texture_type type;

        public ufbx_string shader_name;

        [NativeTypeName("uint64_t")]
        public ulong shader_type_id;

        public ufbx_shader_texture_input_list inputs;

        public ufbx_string shader_source;

        public ufbx_blob raw_shader_source;

        public ufbx_texture* main_texture;

        [NativeTypeName("int64_t")]
        public long main_texture_output_index;

        public ufbx_string prop_prefix;
    }

    public partial struct ufbx_texture_file
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        public ufbx_string filename;

        public ufbx_string absolute_filename;

        public ufbx_string relative_filename;

        public ufbx_blob raw_filename;

        public ufbx_blob raw_absolute_filename;

        public ufbx_blob raw_relative_filename;

        public ufbx_blob content;
    }

    public unsafe partial struct ufbx_texture_file_list
    {
        public ufbx_texture_file* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_texture
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2891_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_texture_type type;

        public ufbx_string filename;

        public ufbx_string absolute_filename;

        public ufbx_string relative_filename;

        public ufbx_blob raw_filename;

        public ufbx_blob raw_absolute_filename;

        public ufbx_blob raw_relative_filename;

        public ufbx_blob content;

        public ufbx_video* video;

        [NativeTypeName("uint32_t")]
        public uint file_index;

        [NativeTypeName("bool")]
        public byte has_file;

        public ufbx_texture_layer_list layers;

        public ufbx_shader_texture* shader;

        public ufbx_texture_list file_textures;

        public ufbx_string uv_set;

        public ufbx_wrap_mode wrap_u;

        public ufbx_wrap_mode wrap_v;

        [NativeTypeName("bool")]
        public byte has_uv_transform;

        public ufbx_transform uv_transform;

        public ufbx_matrix texture_to_uv;

        public ufbx_matrix uv_to_texture;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2891_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_video
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2963_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_string filename;

        public ufbx_string absolute_filename;

        public ufbx_string relative_filename;

        public ufbx_blob raw_filename;

        public ufbx_blob raw_absolute_filename;

        public ufbx_blob raw_relative_filename;

        public ufbx_blob content;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2963_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_shader
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L2999_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_shader_type type;

        public ufbx_shader_binding_list bindings;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L2999_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public partial struct ufbx_shader_prop_binding
    {
        public ufbx_string shader_prop;

        public ufbx_string material_prop;
    }

    public unsafe partial struct ufbx_shader_prop_binding_list
    {
        public ufbx_shader_prop_binding* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_shader_binding
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3026_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_shader_prop_binding_list prop_bindings;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3026_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public partial struct ufbx_prop_override
    {
        [NativeTypeName("uint32_t")]
        public uint element_id;

        [NativeTypeName("uint32_t")]
        public uint _internal_key;

        public ufbx_string prop_name;

        public ufbx_vec4 value;

        public ufbx_string value_str;

        [NativeTypeName("int64_t")]
        public long value_int;
    }

    public unsafe partial struct ufbx_prop_override_list
    {
        public ufbx_prop_override* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_transform_override
    {
        [NativeTypeName("uint32_t")]
        public uint node_id;

        public ufbx_transform transform;
    }

    public unsafe partial struct ufbx_transform_override_list
    {
        public ufbx_transform_override* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_anim
    {
        public double time_begin;

        public double time_end;

        public ufbx_anim_layer_list layers;

        public ufbx_real_list override_layer_weights;

        public ufbx_prop_override_list prop_overrides;

        public ufbx_transform_override_list transform_overrides;

        [NativeTypeName("bool")]
        public byte ignore_connections;

        [NativeTypeName("bool")]
        public byte custom;
    }

    public unsafe partial struct ufbx_anim_stack
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3091_C2")]
        public _Anonymous_e__Union Anonymous;

        public double time_begin;

        public double time_end;

        public ufbx_anim_layer_list layers;

        public ufbx_anim* anim;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3091_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_anim_prop
    {
        public ufbx_element* element;

        [NativeTypeName("uint32_t")]
        public uint _internal_key;

        public ufbx_string prop_name;

        public ufbx_anim_value* anim_value;
    }

    public unsafe partial struct ufbx_anim_prop_list
    {
        public ufbx_anim_prop* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_anim_layer
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3117_C2")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ufbx_real")]
        public double weight;

        [NativeTypeName("bool")]
        public byte weight_is_animated;

        [NativeTypeName("bool")]
        public byte blended;

        [NativeTypeName("bool")]
        public byte additive;

        [NativeTypeName("bool")]
        public byte compose_rotation;

        [NativeTypeName("bool")]
        public byte compose_scale;

        public ufbx_anim_value_list anim_values;

        public ufbx_anim_prop_list anim_props;

        public ufbx_anim* anim;

        [NativeTypeName("uint32_t")]
        public uint _min_element_id;

        [NativeTypeName("uint32_t")]
        public uint _max_element_id;

        [NativeTypeName("uint32_t[4]")]
        public fixed uint _element_id_bitmask[4];

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3117_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_anim_value
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3142_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_vec3 default_value;

        [NativeTypeName("ufbx_anim_curve *[3]")]
        public _curves_e__FixedBuffer curves;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3142_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }

        public unsafe partial struct _curves_e__FixedBuffer
        {
            public ufbx_anim_curve* e0;
            public ufbx_anim_curve* e1;
            public ufbx_anim_curve* e2;

            public ref ufbx_anim_curve* this[int index]
            {
                get
                {
                    fixed (ufbx_anim_curve** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public enum ufbx_interpolation
    {
        UFBX_INTERPOLATION_CONSTANT_PREV,
        UFBX_INTERPOLATION_CONSTANT_NEXT,
        UFBX_INTERPOLATION_LINEAR,
        UFBX_INTERPOLATION_CUBIC,
        UFBX_INTERPOLATION_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_extrapolation_mode
    {
        UFBX_EXTRAPOLATION_CONSTANT,
        UFBX_EXTRAPOLATION_REPEAT,
        UFBX_EXTRAPOLATION_MIRROR,
        UFBX_EXTRAPOLATION_SLOPE,
        UFBX_EXTRAPOLATION_REPEAT_RELATIVE,
        UFBX_EXTRAPOLATION_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_extrapolation
    {
        public ufbx_extrapolation_mode mode;

        [NativeTypeName("int32_t")]
        public int repeat_count;
    }

    public partial struct ufbx_tangent
    {
        public float dx;

        public float dy;
    }

    public partial struct ufbx_keyframe
    {
        public double time;

        [NativeTypeName("ufbx_real")]
        public double value;

        public ufbx_interpolation interpolation;

        public ufbx_tangent left;

        public ufbx_tangent right;
    }

    public unsafe partial struct ufbx_keyframe_list
    {
        public ufbx_keyframe* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_anim_curve
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3214_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_keyframe_list keyframes;

        public ufbx_extrapolation pre_extrapolation;

        public ufbx_extrapolation post_extrapolation;

        [NativeTypeName("ufbx_real")]
        public double min_value;

        [NativeTypeName("ufbx_real")]
        public double max_value;

        public double min_time;

        public double max_time;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3214_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_display_layer
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3242_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_node_list nodes;

        [NativeTypeName("bool")]
        public byte visible;

        [NativeTypeName("bool")]
        public byte frozen;

        public ufbx_vec3 ui_color;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3242_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_selection_set
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3261_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_selection_node_list nodes;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3261_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_selection_node
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3274_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_node* target_node;

        public ufbx_mesh* target_mesh;

        [NativeTypeName("bool")]
        public byte include_node;

        public ufbx_uint32_list vertices;

        public ufbx_uint32_list edges;

        public ufbx_uint32_list faces;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3274_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_character
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3297_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3297_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public enum ufbx_constraint_type
    {
        UFBX_CONSTRAINT_UNKNOWN,
        UFBX_CONSTRAINT_AIM,
        UFBX_CONSTRAINT_PARENT,
        UFBX_CONSTRAINT_POSITION,
        UFBX_CONSTRAINT_ROTATION,
        UFBX_CONSTRAINT_SCALE,
        UFBX_CONSTRAINT_SINGLE_CHAIN_IK,
        UFBX_CONSTRAINT_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_constraint_target
    {
        public ufbx_node* node;

        [NativeTypeName("ufbx_real")]
        public double weight;

        public ufbx_transform transform;
    }

    public unsafe partial struct ufbx_constraint_target_list
    {
        public ufbx_constraint_target* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public enum ufbx_constraint_aim_up_type
    {
        UFBX_CONSTRAINT_AIM_UP_SCENE,
        UFBX_CONSTRAINT_AIM_UP_TO_NODE,
        UFBX_CONSTRAINT_AIM_UP_ALIGN_NODE,
        UFBX_CONSTRAINT_AIM_UP_VECTOR,
        UFBX_CONSTRAINT_AIM_UP_NONE,
        UFBX_CONSTRAINT_AIM_UP_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_constraint_ik_pole_type
    {
        UFBX_CONSTRAINT_IK_POLE_VECTOR,
        UFBX_CONSTRAINT_IK_POLE_NODE,
        UFBX_CONSTRAINT_IK_POLE_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_constraint
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3355_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_constraint_type type;

        public ufbx_string type_name;

        public ufbx_node* node;

        public ufbx_constraint_target_list targets;

        [NativeTypeName("ufbx_real")]
        public double weight;

        [NativeTypeName("bool")]
        public byte active;

        [NativeTypeName("bool[3]")]
        public fixed byte constrain_translation[3];

        [NativeTypeName("bool[3]")]
        public fixed byte constrain_rotation[3];

        [NativeTypeName("bool[3]")]
        public fixed byte constrain_scale[3];

        public ufbx_transform transform_offset;

        public ufbx_vec3 aim_vector;

        public ufbx_constraint_aim_up_type aim_up_type;

        public ufbx_node* aim_up_node;

        public ufbx_vec3 aim_up_vector;

        public ufbx_node* ik_effector;

        public ufbx_node* ik_end_node;

        public ufbx_vec3 ik_pole_vector;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3355_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_audio_layer
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3399_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_audio_clip_list clips;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3399_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_audio_clip
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3411_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_string filename;

        public ufbx_string absolute_filename;

        public ufbx_string relative_filename;

        public ufbx_blob raw_filename;

        public ufbx_blob raw_absolute_filename;

        public ufbx_blob raw_relative_filename;

        public ufbx_blob content;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3411_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_bone_pose
    {
        public ufbx_node* bone_node;

        public ufbx_matrix bone_to_world;

        public ufbx_matrix bone_to_parent;
    }

    public unsafe partial struct ufbx_bone_pose_list
    {
        public ufbx_bone_pose* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_pose
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3462_C2")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("bool")]
        public byte is_bind_pose;

        public ufbx_bone_pose_list bone_poses;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3462_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_metadata_object
    {
        [NativeTypeName("__AnonymousRecord_ufbx_L3478_C2")]
        public _Anonymous_e__Union Anonymous;

        public ref ufbx_element element
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->element;
                }
            }
        }

        public ref ufbx_string name
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->name;
                }
            }
        }

        public ref ufbx_props props
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->props;
                }
            }
        }

        public ref uint element_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->element_id;
                }
            }
        }

        public ref uint typed_id
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->typed_id;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public ufbx_element element;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3478_C32")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_string name;

                public ufbx_props props;

                [NativeTypeName("uint32_t")]
                public uint element_id;

                [NativeTypeName("uint32_t")]
                public uint typed_id;
            }
        }
    }

    public unsafe partial struct ufbx_name_element
    {
        public ufbx_string name;

        public ufbx_element_type type;

        [NativeTypeName("uint32_t")]
        public uint _internal_key;

        public ufbx_element* element;
    }

    public unsafe partial struct ufbx_name_element_list
    {
        public ufbx_name_element* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public enum ufbx_exporter
    {
        UFBX_EXPORTER_UNKNOWN,
        UFBX_EXPORTER_FBX_SDK,
        UFBX_EXPORTER_BLENDER_BINARY,
        UFBX_EXPORTER_BLENDER_ASCII,
        UFBX_EXPORTER_MOTION_BUILDER,
        UFBX_EXPORTER_UFBX_WRITE,
        UFBX_EXPORTER_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_application
    {
        public ufbx_string vendor;

        public ufbx_string name;

        public ufbx_string version;
    }

    public enum ufbx_file_format
    {
        UFBX_FILE_FORMAT_UNKNOWN,
        UFBX_FILE_FORMAT_FBX,
        UFBX_FILE_FORMAT_OBJ,
        UFBX_FILE_FORMAT_MTL,
        UFBX_FILE_FORMAT_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_warning_type
    {
        UFBX_WARNING_MISSING_EXTERNAL_FILE,
        UFBX_WARNING_IMPLICIT_MTL,
        UFBX_WARNING_TRUNCATED_ARRAY,
        UFBX_WARNING_MISSING_GEOMETRY_DATA,
        UFBX_WARNING_DUPLICATE_CONNECTION,
        UFBX_WARNING_BAD_VERTEX_W_ATTRIBUTE,
        UFBX_WARNING_MISSING_POLYGON_MAPPING,
        UFBX_WARNING_UNSUPPORTED_VERSION,
        UFBX_WARNING_INDEX_CLAMPED,
        UFBX_WARNING_BAD_UNICODE,
        UFBX_WARNING_BAD_BASE64_CONTENT,
        UFBX_WARNING_BAD_ELEMENT_CONNECTED_TO_ROOT,
        UFBX_WARNING_DUPLICATE_OBJECT_ID,
        UFBX_WARNING_EMPTY_FACE_REMOVED,
        UFBX_WARNING_UNKNOWN_OBJ_DIRECTIVE,
        UFBX_WARNING_TYPE_FIRST_DEDUPLICATED = UFBX_WARNING_INDEX_CLAMPED,
        UFBX_WARNING_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_warning
    {
        public ufbx_warning_type type;

        public ufbx_string description;

        [NativeTypeName("uint32_t")]
        public uint element_id;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_warning_list
    {
        public ufbx_warning* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public enum ufbx_thumbnail_format
    {
        UFBX_THUMBNAIL_FORMAT_UNKNOWN,
        UFBX_THUMBNAIL_FORMAT_RGB_24,
        UFBX_THUMBNAIL_FORMAT_RGBA_32,
        UFBX_THUMBNAIL_FORMAT_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_space_conversion
    {
        UFBX_SPACE_CONVERSION_TRANSFORM_ROOT,
        UFBX_SPACE_CONVERSION_ADJUST_TRANSFORMS,
        UFBX_SPACE_CONVERSION_MODIFY_GEOMETRY,
        UFBX_SPACE_CONVERSION_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_geometry_transform_handling
    {
        UFBX_GEOMETRY_TRANSFORM_HANDLING_PRESERVE,
        UFBX_GEOMETRY_TRANSFORM_HANDLING_HELPER_NODES,
        UFBX_GEOMETRY_TRANSFORM_HANDLING_MODIFY_GEOMETRY,
        UFBX_GEOMETRY_TRANSFORM_HANDLING_MODIFY_GEOMETRY_NO_FALLBACK,
        UFBX_GEOMETRY_TRANSFORM_HANDLING_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_inherit_mode_handling
    {
        UFBX_INHERIT_MODE_HANDLING_PRESERVE,
        UFBX_INHERIT_MODE_HANDLING_HELPER_NODES,
        UFBX_INHERIT_MODE_HANDLING_COMPENSATE,
        UFBX_INHERIT_MODE_HANDLING_COMPENSATE_NO_FALLBACK,
        UFBX_INHERIT_MODE_HANDLING_IGNORE,
        UFBX_INHERIT_MODE_HANDLING_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_pivot_handling
    {
        UFBX_PIVOT_HANDLING_RETAIN,
        UFBX_PIVOT_HANDLING_ADJUST_TO_PIVOT,
        UFBX_PIVOT_HANDLING_ADJUST_TO_ROTATION_PIVOT,
        UFBX_PIVOT_HANDLING_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_thumbnail
    {
        public ufbx_props props;

        [NativeTypeName("uint32_t")]
        public uint width;

        [NativeTypeName("uint32_t")]
        public uint height;

        public ufbx_thumbnail_format format;

        public ufbx_blob data;
    }

    public unsafe partial struct ufbx_metadata
    {
        public ufbx_warning_list warnings;

        [NativeTypeName("bool")]
        public byte ascii;

        [NativeTypeName("uint32_t")]
        public uint version;

        public ufbx_file_format file_format;

        [NativeTypeName("bool")]
        public byte may_contain_no_index;

        [NativeTypeName("bool")]
        public byte may_contain_missing_vertex_position;

        [NativeTypeName("bool")]
        public byte may_contain_broken_elements;

        [NativeTypeName("bool")]
        public byte is_unsafe;

        [NativeTypeName("bool[15]")]
        public fixed byte has_warning[15];

        public ufbx_string creator;

        [NativeTypeName("bool")]
        public byte big_endian;

        public ufbx_string filename;

        public ufbx_string relative_root;

        public ufbx_blob raw_filename;

        public ufbx_blob raw_relative_root;

        public ufbx_exporter exporter;

        [NativeTypeName("uint32_t")]
        public uint exporter_version;

        public ufbx_props scene_props;

        public ufbx_application original_application;

        public ufbx_application latest_application;

        public ufbx_thumbnail thumbnail;

        [NativeTypeName("bool")]
        public byte geometry_ignored;

        [NativeTypeName("bool")]
        public byte animation_ignored;

        [NativeTypeName("bool")]
        public byte embedded_ignored;

        [NativeTypeName("size_t")]
        public UIntPtr max_face_triangles;

        [NativeTypeName("size_t")]
        public UIntPtr result_memory_used;

        [NativeTypeName("size_t")]
        public UIntPtr temp_memory_used;

        [NativeTypeName("size_t")]
        public UIntPtr result_allocs;

        [NativeTypeName("size_t")]
        public UIntPtr temp_allocs;

        [NativeTypeName("size_t")]
        public UIntPtr element_buffer_size;

        [NativeTypeName("size_t")]
        public UIntPtr num_shader_textures;

        [NativeTypeName("ufbx_real")]
        public double bone_prop_size_unit;

        [NativeTypeName("bool")]
        public byte bone_prop_limb_length_relative;

        [NativeTypeName("ufbx_real")]
        public double ortho_size_unit;

        [NativeTypeName("int64_t")]
        public long ktime_second;

        public ufbx_string original_file_path;

        public ufbx_blob raw_original_file_path;

        public ufbx_space_conversion space_conversion;

        public ufbx_geometry_transform_handling geometry_transform_handling;

        public ufbx_inherit_mode_handling inherit_mode_handling;

        public ufbx_pivot_handling pivot_handling;

        public ufbx_mirror_axis handedness_conversion_axis;

        public ufbx_quat root_rotation;

        [NativeTypeName("ufbx_real")]
        public double root_scale;

        public ufbx_mirror_axis mirror_axis;

        [NativeTypeName("ufbx_real")]
        public double geometry_scale;
    }

    public enum ufbx_time_mode
    {
        UFBX_TIME_MODE_DEFAULT,
        UFBX_TIME_MODE_120_FPS,
        UFBX_TIME_MODE_100_FPS,
        UFBX_TIME_MODE_60_FPS,
        UFBX_TIME_MODE_50_FPS,
        UFBX_TIME_MODE_48_FPS,
        UFBX_TIME_MODE_30_FPS,
        UFBX_TIME_MODE_30_FPS_DROP,
        UFBX_TIME_MODE_NTSC_DROP_FRAME,
        UFBX_TIME_MODE_NTSC_FULL_FRAME,
        UFBX_TIME_MODE_PAL,
        UFBX_TIME_MODE_24_FPS,
        UFBX_TIME_MODE_1000_FPS,
        UFBX_TIME_MODE_FILM_FULL_FRAME,
        UFBX_TIME_MODE_CUSTOM,
        UFBX_TIME_MODE_96_FPS,
        UFBX_TIME_MODE_72_FPS,
        UFBX_TIME_MODE_59_94_FPS,
        UFBX_TIME_MODE_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_time_protocol
    {
        UFBX_TIME_PROTOCOL_SMPTE,
        UFBX_TIME_PROTOCOL_FRAME_COUNT,
        UFBX_TIME_PROTOCOL_DEFAULT,
        UFBX_TIME_PROTOCOL_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_snap_mode
    {
        UFBX_SNAP_MODE_NONE,
        UFBX_SNAP_MODE_SNAP,
        UFBX_SNAP_MODE_PLAY,
        UFBX_SNAP_MODE_SNAP_AND_PLAY,
        UFBX_SNAP_MODE_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_scene_settings
    {
        public ufbx_props props;

        public ufbx_coordinate_axes axes;

        [NativeTypeName("ufbx_real")]
        public double unit_meters;

        public double frames_per_second;

        public ufbx_vec3 ambient_color;

        public ufbx_string default_camera;

        public ufbx_time_mode time_mode;

        public ufbx_time_protocol time_protocol;

        public ufbx_snap_mode snap_mode;

        public ufbx_coordinate_axis original_axis_up;

        [NativeTypeName("ufbx_real")]
        public double original_unit_meters;
    }

    public unsafe partial struct ufbx_scene
    {
        public ufbx_metadata metadata;

        public ufbx_scene_settings settings;

        public ufbx_node* root_node;

        public ufbx_anim* anim;

        [NativeTypeName("__AnonymousRecord_ufbx_L3947_C2")]
        public _Anonymous_e__Union Anonymous;

        public ufbx_texture_file_list texture_files;

        public ufbx_element_list elements;

        public ufbx_connection_list connections_src;

        public ufbx_connection_list connections_dst;

        public ufbx_name_element_list elements_by_name;

        public ufbx_dom_node* dom_root;

        public ref ufbx_unknown_list unknowns
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->unknowns;
                }
            }
        }

        public ref ufbx_node_list nodes
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->nodes;
                }
            }
        }

        public ref ufbx_mesh_list meshes
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->meshes;
                }
            }
        }

        public ref ufbx_light_list lights
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->lights;
                }
            }
        }

        public ref ufbx_camera_list cameras
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->cameras;
                }
            }
        }

        public ref ufbx_bone_list bones
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->bones;
                }
            }
        }

        public ref ufbx_empty_list empties
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->empties;
                }
            }
        }

        public ref ufbx_line_curve_list line_curves
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->line_curves;
                }
            }
        }

        public ref ufbx_nurbs_curve_list nurbs_curves
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->nurbs_curves;
                }
            }
        }

        public ref ufbx_nurbs_surface_list nurbs_surfaces
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->nurbs_surfaces;
                }
            }
        }

        public ref ufbx_nurbs_trim_surface_list nurbs_trim_surfaces
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->nurbs_trim_surfaces;
                }
            }
        }

        public ref ufbx_nurbs_trim_boundary_list nurbs_trim_boundaries
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->nurbs_trim_boundaries;
                }
            }
        }

        public ref ufbx_procedural_geometry_list procedural_geometries
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->procedural_geometries;
                }
            }
        }

        public ref ufbx_stereo_camera_list stereo_cameras
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->stereo_cameras;
                }
            }
        }

        public ref ufbx_camera_switcher_list camera_switchers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->camera_switchers;
                }
            }
        }

        public ref ufbx_marker_list markers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->markers;
                }
            }
        }

        public ref ufbx_lod_group_list lod_groups
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->lod_groups;
                }
            }
        }

        public ref ufbx_skin_deformer_list skin_deformers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->skin_deformers;
                }
            }
        }

        public ref ufbx_skin_cluster_list skin_clusters
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->skin_clusters;
                }
            }
        }

        public ref ufbx_blend_deformer_list blend_deformers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->blend_deformers;
                }
            }
        }

        public ref ufbx_blend_channel_list blend_channels
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->blend_channels;
                }
            }
        }

        public ref ufbx_blend_shape_list blend_shapes
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->blend_shapes;
                }
            }
        }

        public ref ufbx_cache_deformer_list cache_deformers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->cache_deformers;
                }
            }
        }

        public ref ufbx_cache_file_list cache_files
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->cache_files;
                }
            }
        }

        public ref ufbx_material_list materials
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->materials;
                }
            }
        }

        public ref ufbx_texture_list textures
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->textures;
                }
            }
        }

        public ref ufbx_video_list videos
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->videos;
                }
            }
        }

        public ref ufbx_shader_list shaders
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->shaders;
                }
            }
        }

        public ref ufbx_shader_binding_list shader_bindings
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->shader_bindings;
                }
            }
        }

        public ref ufbx_anim_stack_list anim_stacks
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->anim_stacks;
                }
            }
        }

        public ref ufbx_anim_layer_list anim_layers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->anim_layers;
                }
            }
        }

        public ref ufbx_anim_value_list anim_values
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->anim_values;
                }
            }
        }

        public ref ufbx_anim_curve_list anim_curves
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->anim_curves;
                }
            }
        }

        public ref ufbx_display_layer_list display_layers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->display_layers;
                }
            }
        }

        public ref ufbx_selection_set_list selection_sets
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->selection_sets;
                }
            }
        }

        public ref ufbx_selection_node_list selection_nodes
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->selection_nodes;
                }
            }
        }

        public ref ufbx_character_list characters
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->characters;
                }
            }
        }

        public ref ufbx_constraint_list constraints
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->constraints;
                }
            }
        }

        public ref ufbx_audio_layer_list audio_layers
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->audio_layers;
                }
            }
        }

        public ref ufbx_audio_clip_list audio_clips
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->audio_clips;
                }
            }
        }

        public ref ufbx_pose_list poses
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->poses;
                }
            }
        }

        public ref ufbx_metadata_object_list metadata_objects
        {
            get
            {
                fixed (_Anonymous_e__Union._Anonymous_e__Struct* pField = &Anonymous.Anonymous)
                {
                    return ref pField->metadata_objects;
                }
            }
        }

        public ref _Anonymous_e__Union._elements_by_type_e__FixedBuffer elements_by_type
        {
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->elements_by_type;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ufbx_L3948_C3")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ufbx_element_list[42]")]
            public _elements_by_type_e__FixedBuffer elements_by_type;

            public partial struct _Anonymous_e__Struct
            {
                public ufbx_unknown_list unknowns;

                public ufbx_node_list nodes;

                public ufbx_mesh_list meshes;

                public ufbx_light_list lights;

                public ufbx_camera_list cameras;

                public ufbx_bone_list bones;

                public ufbx_empty_list empties;

                public ufbx_line_curve_list line_curves;

                public ufbx_nurbs_curve_list nurbs_curves;

                public ufbx_nurbs_surface_list nurbs_surfaces;

                public ufbx_nurbs_trim_surface_list nurbs_trim_surfaces;

                public ufbx_nurbs_trim_boundary_list nurbs_trim_boundaries;

                public ufbx_procedural_geometry_list procedural_geometries;

                public ufbx_stereo_camera_list stereo_cameras;

                public ufbx_camera_switcher_list camera_switchers;

                public ufbx_marker_list markers;

                public ufbx_lod_group_list lod_groups;

                public ufbx_skin_deformer_list skin_deformers;

                public ufbx_skin_cluster_list skin_clusters;

                public ufbx_blend_deformer_list blend_deformers;

                public ufbx_blend_channel_list blend_channels;

                public ufbx_blend_shape_list blend_shapes;

                public ufbx_cache_deformer_list cache_deformers;

                public ufbx_cache_file_list cache_files;

                public ufbx_material_list materials;

                public ufbx_texture_list textures;

                public ufbx_video_list videos;

                public ufbx_shader_list shaders;

                public ufbx_shader_binding_list shader_bindings;

                public ufbx_anim_stack_list anim_stacks;

                public ufbx_anim_layer_list anim_layers;

                public ufbx_anim_value_list anim_values;

                public ufbx_anim_curve_list anim_curves;

                public ufbx_display_layer_list display_layers;

                public ufbx_selection_set_list selection_sets;

                public ufbx_selection_node_list selection_nodes;

                public ufbx_character_list characters;

                public ufbx_constraint_list constraints;

                public ufbx_audio_layer_list audio_layers;

                public ufbx_audio_clip_list audio_clips;

                public ufbx_pose_list poses;

                public ufbx_metadata_object_list metadata_objects;
            }

            public partial struct _elements_by_type_e__FixedBuffer
            {
                public ufbx_element_list e0;
                public ufbx_element_list e1;
                public ufbx_element_list e2;
                public ufbx_element_list e3;
                public ufbx_element_list e4;
                public ufbx_element_list e5;
                public ufbx_element_list e6;
                public ufbx_element_list e7;
                public ufbx_element_list e8;
                public ufbx_element_list e9;
                public ufbx_element_list e10;
                public ufbx_element_list e11;
                public ufbx_element_list e12;
                public ufbx_element_list e13;
                public ufbx_element_list e14;
                public ufbx_element_list e15;
                public ufbx_element_list e16;
                public ufbx_element_list e17;
                public ufbx_element_list e18;
                public ufbx_element_list e19;
                public ufbx_element_list e20;
                public ufbx_element_list e21;
                public ufbx_element_list e22;
                public ufbx_element_list e23;
                public ufbx_element_list e24;
                public ufbx_element_list e25;
                public ufbx_element_list e26;
                public ufbx_element_list e27;
                public ufbx_element_list e28;
                public ufbx_element_list e29;
                public ufbx_element_list e30;
                public ufbx_element_list e31;
                public ufbx_element_list e32;
                public ufbx_element_list e33;
                public ufbx_element_list e34;
                public ufbx_element_list e35;
                public ufbx_element_list e36;
                public ufbx_element_list e37;
                public ufbx_element_list e38;
                public ufbx_element_list e39;
                public ufbx_element_list e40;
                public ufbx_element_list e41;

                public unsafe ref ufbx_element_list this[int index]
                {
                    get
                    {
                        fixed (ufbx_element_list* pThis = &e0)
                        {
                            return ref pThis[index];
                        }
                    }
                }
            }
        }
    }

    public partial struct ufbx_curve_point
    {
        [NativeTypeName("bool")]
        public byte valid;

        public ufbx_vec3 position;

        public ufbx_vec3 derivative;
    }

    public partial struct ufbx_surface_point
    {
        [NativeTypeName("bool")]
        public byte valid;

        public ufbx_vec3 position;

        public ufbx_vec3 derivative_u;

        public ufbx_vec3 derivative_v;
    }

    public enum ufbx_topo_flags
    {
        UFBX_TOPO_NON_MANIFOLD = 0x1,
        UFBX_TOPO_FLAGS_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_topo_edge
    {
        [NativeTypeName("uint32_t")]
        public uint index;

        [NativeTypeName("uint32_t")]
        public uint next;

        [NativeTypeName("uint32_t")]
        public uint prev;

        [NativeTypeName("uint32_t")]
        public uint twin;

        [NativeTypeName("uint32_t")]
        public uint face;

        [NativeTypeName("uint32_t")]
        public uint edge;

        public ufbx_topo_flags flags;
    }

    public unsafe partial struct ufbx_vertex_stream
    {
        public void* data;

        [NativeTypeName("size_t")]
        public UIntPtr vertex_count;

        [NativeTypeName("size_t")]
        public UIntPtr vertex_size;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* ufbx_alloc_fn(void* user, [NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* ufbx_realloc_fn(void* user, void* old_ptr, [NativeTypeName("size_t")] UIntPtr old_size, [NativeTypeName("size_t")] UIntPtr new_size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ufbx_free_fn(void* user, void* ptr, [NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ufbx_free_allocator_fn(void* user);

    public unsafe partial struct ufbx_allocator
    {
        [NativeTypeName("ufbx_alloc_fn *")]
        public IntPtr alloc_fn;

        [NativeTypeName("ufbx_realloc_fn *")]
        public IntPtr realloc_fn;

        [NativeTypeName("ufbx_free_fn *")]
        public IntPtr free_fn;

        [NativeTypeName("ufbx_free_allocator_fn *")]
        public IntPtr free_allocator_fn;

        public void* user;
    }

    public partial struct ufbx_allocator_opts
    {
        public ufbx_allocator allocator;

        [NativeTypeName("size_t")]
        public UIntPtr memory_limit;

        [NativeTypeName("size_t")]
        public UIntPtr allocation_limit;

        [NativeTypeName("size_t")]
        public UIntPtr huge_threshold;

        [NativeTypeName("size_t")]
        public UIntPtr max_chunk_size;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("size_t")]
    public unsafe delegate UIntPtr ufbx_read_fn(void* user, void* data, [NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool ufbx_skip_fn(void* user, [NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("uint64_t")]
    public unsafe delegate ulong ufbx_size_fn(void* user);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ufbx_close_fn(void* user);

    public unsafe partial struct ufbx_stream
    {
        [NativeTypeName("ufbx_read_fn *")]
        public IntPtr read_fn;

        [NativeTypeName("ufbx_skip_fn *")]
        public IntPtr skip_fn;

        [NativeTypeName("ufbx_size_fn *")]
        public IntPtr size_fn;

        [NativeTypeName("ufbx_close_fn *")]
        public IntPtr close_fn;

        public void* user;
    }

    public enum ufbx_open_file_type
    {
        UFBX_OPEN_FILE_MAIN_MODEL,
        UFBX_OPEN_FILE_GEOMETRY_CACHE,
        UFBX_OPEN_FILE_OBJ_MTL,
        UFBX_OPEN_FILE_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_open_file_info
    {
        [NativeTypeName("ufbx_open_file_context")]
        public UIntPtr context;

        public ufbx_open_file_type type;

        public ufbx_blob original_filename;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool ufbx_open_file_fn(void* user, ufbx_stream* stream, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("size_t")] UIntPtr path_len, [NativeTypeName("const ufbx_open_file_info *")] ufbx_open_file_info* info);

    public unsafe partial struct ufbx_open_file_cb
    {
        [NativeTypeName("ufbx_open_file_fn *")]
        public IntPtr fn;

        public void* user;
    }

    public partial struct ufbx_open_file_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_allocator_opts allocator;

        [NativeTypeName("bool")]
        public byte filename_null_terminated;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ufbx_close_memory_fn(void* user, void* data, [NativeTypeName("size_t")] UIntPtr data_size);

    public unsafe partial struct ufbx_close_memory_cb
    {
        [NativeTypeName("ufbx_close_memory_fn *")]
        public IntPtr fn;

        public void* user;
    }

    public partial struct ufbx_open_memory_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_allocator_opts allocator;

        [NativeTypeName("bool")]
        public byte no_copy;

        public ufbx_close_memory_cb close_cb;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    public partial struct ufbx_error_frame
    {
        [NativeTypeName("uint32_t")]
        public uint source_line;

        public ufbx_string function;

        public ufbx_string description;
    }

    public enum ufbx_error_type
    {
        UFBX_ERROR_NONE,
        UFBX_ERROR_UNKNOWN,
        UFBX_ERROR_FILE_NOT_FOUND,
        UFBX_ERROR_EMPTY_FILE,
        UFBX_ERROR_EXTERNAL_FILE_NOT_FOUND,
        UFBX_ERROR_OUT_OF_MEMORY,
        UFBX_ERROR_MEMORY_LIMIT,
        UFBX_ERROR_ALLOCATION_LIMIT,
        UFBX_ERROR_TRUNCATED_FILE,
        UFBX_ERROR_IO,
        UFBX_ERROR_CANCELLED,
        UFBX_ERROR_UNRECOGNIZED_FILE_FORMAT,
        UFBX_ERROR_UNINITIALIZED_OPTIONS,
        UFBX_ERROR_ZERO_VERTEX_SIZE,
        UFBX_ERROR_TRUNCATED_VERTEX_STREAM,
        UFBX_ERROR_INVALID_UTF8,
        UFBX_ERROR_FEATURE_DISABLED,
        UFBX_ERROR_BAD_NURBS,
        UFBX_ERROR_BAD_INDEX,
        UFBX_ERROR_NODE_DEPTH_LIMIT,
        UFBX_ERROR_THREADED_ASCII_PARSE,
        UFBX_ERROR_UNSAFE_OPTIONS,
        UFBX_ERROR_DUPLICATE_OVERRIDE,
        UFBX_ERROR_UNSUPPORTED_VERSION,
        UFBX_ERROR_TYPE_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_error
    {
        public ufbx_error_type type;

        public ufbx_string description;

        [NativeTypeName("uint32_t")]
        public uint stack_size;

        [NativeTypeName("ufbx_error_frame[8]")]
        public _stack_e__FixedBuffer stack;

        [NativeTypeName("size_t")]
        public UIntPtr info_length;

        [NativeTypeName("char[256]")]
        public fixed sbyte info[256];

        public partial struct _stack_e__FixedBuffer
        {
            public ufbx_error_frame e0;
            public ufbx_error_frame e1;
            public ufbx_error_frame e2;
            public ufbx_error_frame e3;
            public ufbx_error_frame e4;
            public ufbx_error_frame e5;
            public ufbx_error_frame e6;
            public ufbx_error_frame e7;

            public unsafe ref ufbx_error_frame this[int index]
            {
                get
                {
                    fixed (ufbx_error_frame* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public partial struct ufbx_progress
    {
        [NativeTypeName("uint64_t")]
        public ulong bytes_read;

        [NativeTypeName("uint64_t")]
        public ulong bytes_total;
    }

    public enum ufbx_progress_result
    {
        UFBX_PROGRESS_CONTINUE = 0x100,
        UFBX_PROGRESS_CANCEL = 0x200,
        UFBX_PROGRESS_RESULT_FORCE_32BIT = 0x7fffffff,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ufbx_progress_result ufbx_progress_fn(void* user, [NativeTypeName("const ufbx_progress *")] ufbx_progress* progress);

    public unsafe partial struct ufbx_progress_cb
    {
        [NativeTypeName("ufbx_progress_fn *")]
        public IntPtr fn;

        public void* user;
    }

    public unsafe partial struct ufbx_inflate_input
    {
        [NativeTypeName("size_t")]
        public UIntPtr total_size;

        [NativeTypeName("const void *")]
        public void* data;

        [NativeTypeName("size_t")]
        public UIntPtr data_size;

        public void* buffer;

        [NativeTypeName("size_t")]
        public UIntPtr buffer_size;

        [NativeTypeName("ufbx_read_fn *")]
        public IntPtr read_fn;

        public void* read_user;

        public ufbx_progress_cb progress_cb;

        [NativeTypeName("uint64_t")]
        public ulong progress_interval_hint;

        [NativeTypeName("uint64_t")]
        public ulong progress_size_before;

        [NativeTypeName("uint64_t")]
        public ulong progress_size_after;

        [NativeTypeName("bool")]
        public byte no_header;

        [NativeTypeName("bool")]
        public byte no_checksum;

        [NativeTypeName("size_t")]
        public UIntPtr internal_fast_bits;
    }

    public unsafe partial struct ufbx_inflate_retain
    {
        [NativeTypeName("bool")]
        public byte initialized;

        [NativeTypeName("uint64_t[1024]")]
        public fixed ulong data[1024];
    }

    public enum ufbx_index_error_handling
    {
        UFBX_INDEX_ERROR_HANDLING_CLAMP,
        UFBX_INDEX_ERROR_HANDLING_NO_INDEX,
        UFBX_INDEX_ERROR_HANDLING_ABORT_LOADING,
        UFBX_INDEX_ERROR_HANDLING_UNSAFE_IGNORE,
        UFBX_INDEX_ERROR_HANDLING_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_unicode_error_handling
    {
        UFBX_UNICODE_ERROR_HANDLING_REPLACEMENT_CHARACTER,
        UFBX_UNICODE_ERROR_HANDLING_UNDERSCORE,
        UFBX_UNICODE_ERROR_HANDLING_QUESTION_MARK,
        UFBX_UNICODE_ERROR_HANDLING_REMOVE,
        UFBX_UNICODE_ERROR_HANDLING_ABORT_LOADING,
        UFBX_UNICODE_ERROR_HANDLING_UNSAFE_IGNORE,
        UFBX_UNICODE_ERROR_HANDLING_FORCE_32BIT = 0x7fffffff,
    }

    public enum ufbx_baked_key_flags
    {
        UFBX_BAKED_KEY_STEP_LEFT = 0x1,
        UFBX_BAKED_KEY_STEP_RIGHT = 0x2,
        UFBX_BAKED_KEY_STEP_KEY = 0x4,
        UFBX_BAKED_KEY_KEYFRAME = 0x8,
        UFBX_BAKED_KEY_REDUCED = 0x10,
        UFBX_BAKED_KEY_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_baked_vec3
    {
        public double time;

        public ufbx_vec3 value;

        public ufbx_baked_key_flags flags;
    }

    public unsafe partial struct ufbx_baked_vec3_list
    {
        public ufbx_baked_vec3* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_baked_quat
    {
        public double time;

        public ufbx_quat value;

        public ufbx_baked_key_flags flags;
    }

    public unsafe partial struct ufbx_baked_quat_list
    {
        public ufbx_baked_quat* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_baked_node
    {
        [NativeTypeName("uint32_t")]
        public uint typed_id;

        [NativeTypeName("uint32_t")]
        public uint element_id;

        [NativeTypeName("bool")]
        public byte constant_translation;

        [NativeTypeName("bool")]
        public byte constant_rotation;

        [NativeTypeName("bool")]
        public byte constant_scale;

        public ufbx_baked_vec3_list translation_keys;

        public ufbx_baked_quat_list rotation_keys;

        public ufbx_baked_vec3_list scale_keys;
    }

    public unsafe partial struct ufbx_baked_node_list
    {
        public ufbx_baked_node* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_baked_prop
    {
        public ufbx_string name;

        [NativeTypeName("bool")]
        public byte constant_value;

        public ufbx_baked_vec3_list keys;
    }

    public unsafe partial struct ufbx_baked_prop_list
    {
        public ufbx_baked_prop* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_baked_element
    {
        [NativeTypeName("uint32_t")]
        public uint element_id;

        public ufbx_baked_prop_list props;
    }

    public unsafe partial struct ufbx_baked_element_list
    {
        public ufbx_baked_element* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_baked_anim_metadata
    {
        [NativeTypeName("size_t")]
        public UIntPtr result_memory_used;

        [NativeTypeName("size_t")]
        public UIntPtr temp_memory_used;

        [NativeTypeName("size_t")]
        public UIntPtr result_allocs;

        [NativeTypeName("size_t")]
        public UIntPtr temp_allocs;
    }

    public partial struct ufbx_baked_anim
    {
        public ufbx_baked_node_list nodes;

        public ufbx_baked_element_list elements;

        public double playback_time_begin;

        public double playback_time_end;

        public double playback_duration;

        public double key_time_min;

        public double key_time_max;

        public ufbx_baked_anim_metadata metadata;
    }

    public partial struct ufbx_thread_pool_info
    {
        [NativeTypeName("uint32_t")]
        public uint max_concurrent_tasks;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool ufbx_thread_pool_init_fn(void* user, [NativeTypeName("ufbx_thread_pool_context")] UIntPtr ctx, [NativeTypeName("const ufbx_thread_pool_info *")] ufbx_thread_pool_info* info);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ufbx_thread_pool_run_fn(void* user, [NativeTypeName("ufbx_thread_pool_context")] UIntPtr ctx, [NativeTypeName("uint32_t")] uint group, [NativeTypeName("uint32_t")] uint start_index, [NativeTypeName("uint32_t")] uint count);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ufbx_thread_pool_wait_fn(void* user, [NativeTypeName("ufbx_thread_pool_context")] UIntPtr ctx, [NativeTypeName("uint32_t")] uint group, [NativeTypeName("uint32_t")] uint max_index);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ufbx_thread_pool_free_fn(void* user, [NativeTypeName("ufbx_thread_pool_context")] UIntPtr ctx);

    public unsafe partial struct ufbx_thread_pool
    {
        [NativeTypeName("ufbx_thread_pool_init_fn *")]
        public IntPtr init_fn;

        [NativeTypeName("ufbx_thread_pool_run_fn *")]
        public IntPtr run_fn;

        [NativeTypeName("ufbx_thread_pool_wait_fn *")]
        public IntPtr wait_fn;

        [NativeTypeName("ufbx_thread_pool_free_fn *")]
        public IntPtr free_fn;

        public void* user;
    }

    public partial struct ufbx_thread_opts
    {
        public ufbx_thread_pool pool;

        [NativeTypeName("size_t")]
        public UIntPtr num_tasks;

        [NativeTypeName("size_t")]
        public UIntPtr memory_limit;
    }

    public enum ufbx_evaluate_flags
    {
        UFBX_EVALUATE_FLAG_NO_EXTRAPOLATION = 0x1,
        ufbx_evaluate_flags_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_load_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_allocator_opts temp_allocator;

        public ufbx_allocator_opts result_allocator;

        public ufbx_thread_opts thread_opts;

        [NativeTypeName("bool")]
        public byte ignore_geometry;

        [NativeTypeName("bool")]
        public byte ignore_animation;

        [NativeTypeName("bool")]
        public byte ignore_embedded;

        [NativeTypeName("bool")]
        public byte ignore_all_content;

        [NativeTypeName("bool")]
        public byte evaluate_skinning;

        [NativeTypeName("bool")]
        public byte evaluate_caches;

        [NativeTypeName("bool")]
        public byte load_external_files;

        [NativeTypeName("bool")]
        public byte ignore_missing_external_files;

        [NativeTypeName("bool")]
        public byte skip_skin_vertices;

        [NativeTypeName("bool")]
        public byte skip_mesh_parts;

        [NativeTypeName("bool")]
        public byte clean_skin_weights;

        [NativeTypeName("bool")]
        public byte use_blender_pbr_material;

        [NativeTypeName("bool")]
        public byte disable_quirks;

        [NativeTypeName("bool")]
        public byte strict;

        [NativeTypeName("bool")]
        public byte force_single_thread_ascii_parsing;

        [NativeTypeName("bool")]
        public byte allow_unsafe;

        public ufbx_index_error_handling index_error_handling;

        [NativeTypeName("bool")]
        public byte connect_broken_elements;

        [NativeTypeName("bool")]
        public byte allow_nodes_out_of_root;

        [NativeTypeName("bool")]
        public byte allow_missing_vertex_position;

        [NativeTypeName("bool")]
        public byte allow_empty_faces;

        [NativeTypeName("bool")]
        public byte generate_missing_normals;

        [NativeTypeName("bool")]
        public byte open_main_file_with_default;

        [NativeTypeName("char")]
        public sbyte path_separator;

        [NativeTypeName("uint32_t")]
        public uint node_depth_limit;

        [NativeTypeName("uint64_t")]
        public ulong file_size_estimate;

        [NativeTypeName("size_t")]
        public UIntPtr read_buffer_size;

        public ufbx_string filename;

        public ufbx_blob raw_filename;

        public ufbx_progress_cb progress_cb;

        [NativeTypeName("uint64_t")]
        public ulong progress_interval_hint;

        public ufbx_open_file_cb open_file_cb;

        public ufbx_geometry_transform_handling geometry_transform_handling;

        public ufbx_inherit_mode_handling inherit_mode_handling;

        public ufbx_space_conversion space_conversion;

        public ufbx_pivot_handling pivot_handling;

        [NativeTypeName("bool")]
        public byte pivot_handling_retain_empties;

        public ufbx_mirror_axis handedness_conversion_axis;

        [NativeTypeName("bool")]
        public byte handedness_conversion_retain_winding;

        [NativeTypeName("bool")]
        public byte reverse_winding;

        public ufbx_coordinate_axes target_axes;

        [NativeTypeName("ufbx_real")]
        public double target_unit_meters;

        public ufbx_coordinate_axes target_camera_axes;

        public ufbx_coordinate_axes target_light_axes;

        public ufbx_string geometry_transform_helper_name;

        public ufbx_string scale_helper_name;

        [NativeTypeName("bool")]
        public byte normalize_normals;

        [NativeTypeName("bool")]
        public byte normalize_tangents;

        [NativeTypeName("bool")]
        public byte use_root_transform;

        public ufbx_transform root_transform;

        public double key_clamp_threshold;

        public ufbx_unicode_error_handling unicode_error_handling;

        [NativeTypeName("bool")]
        public byte retain_vertex_attrib_w;

        [NativeTypeName("bool")]
        public byte retain_dom;

        public ufbx_file_format file_format;

        [NativeTypeName("size_t")]
        public UIntPtr file_format_lookahead;

        [NativeTypeName("bool")]
        public byte no_format_from_content;

        [NativeTypeName("bool")]
        public byte no_format_from_extension;

        [NativeTypeName("bool")]
        public byte obj_search_mtl_by_filename;

        [NativeTypeName("bool")]
        public byte obj_merge_objects;

        [NativeTypeName("bool")]
        public byte obj_merge_groups;

        [NativeTypeName("bool")]
        public byte obj_split_groups;

        public ufbx_string obj_mtl_path;

        public ufbx_blob obj_mtl_data;

        [NativeTypeName("ufbx_real")]
        public double obj_unit_meters;

        public ufbx_coordinate_axes obj_axes;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    public partial struct ufbx_evaluate_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_allocator_opts temp_allocator;

        public ufbx_allocator_opts result_allocator;

        [NativeTypeName("bool")]
        public byte evaluate_skinning;

        [NativeTypeName("bool")]
        public byte evaluate_caches;

        [NativeTypeName("uint32_t")]
        public uint evaluate_flags;

        [NativeTypeName("bool")]
        public byte load_external_files;

        public ufbx_open_file_cb open_file_cb;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    public unsafe partial struct ufbx_const_uint32_list
    {
        [NativeTypeName("const uint32_t *")]
        public uint* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_const_real_list
    {
        [NativeTypeName("const ufbx_real *")]
        public double* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_prop_override_desc
    {
        [NativeTypeName("uint32_t")]
        public uint element_id;

        public ufbx_string prop_name;

        public ufbx_vec4 value;

        public ufbx_string value_str;

        [NativeTypeName("int64_t")]
        public long value_int;
    }

    public unsafe partial struct ufbx_const_prop_override_desc_list
    {
        [NativeTypeName("const ufbx_prop_override_desc *")]
        public ufbx_prop_override_desc* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public unsafe partial struct ufbx_const_transform_override_list
    {
        [NativeTypeName("const ufbx_transform_override *")]
        public ufbx_transform_override* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }

    public partial struct ufbx_anim_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_const_uint32_list layer_ids;

        public ufbx_const_real_list override_layer_weights;

        public ufbx_const_prop_override_desc_list prop_overrides;

        public ufbx_const_transform_override_list transform_overrides;

        [NativeTypeName("bool")]
        public byte ignore_connections;

        public ufbx_allocator_opts result_allocator;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    public enum ufbx_bake_step_handling
    {
        UFBX_BAKE_STEP_HANDLING_DEFAULT,
        UFBX_BAKE_STEP_HANDLING_CUSTOM_DURATION,
        UFBX_BAKE_STEP_HANDLING_IDENTICAL_TIME,
        UFBX_BAKE_STEP_HANDLING_ADJACENT_DOUBLE,
        UFBX_BAKE_STEP_HANDLING_IGNORE,
        ufbx_bake_step_handling_FORCE_32BIT = 0x7fffffff,
    }

    public partial struct ufbx_bake_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_allocator_opts temp_allocator;

        public ufbx_allocator_opts result_allocator;

        [NativeTypeName("bool")]
        public byte trim_start_time;

        public double resample_rate;

        public double minimum_sample_rate;

        public double maximum_sample_rate;

        [NativeTypeName("bool")]
        public byte bake_transform_props;

        [NativeTypeName("bool")]
        public byte skip_node_transforms;

        [NativeTypeName("bool")]
        public byte no_resample_rotation;

        [NativeTypeName("bool")]
        public byte ignore_layer_weight_animation;

        [NativeTypeName("size_t")]
        public UIntPtr max_keyframe_segments;

        public ufbx_bake_step_handling step_handling;

        public double step_custom_duration;

        public double step_custom_epsilon;

        [NativeTypeName("uint32_t")]
        public uint evaluate_flags;

        [NativeTypeName("bool")]
        public byte key_reduction_enabled;

        [NativeTypeName("bool")]
        public byte key_reduction_rotation;

        public double key_reduction_threshold;

        [NativeTypeName("size_t")]
        public UIntPtr key_reduction_passes;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    public partial struct ufbx_tessellate_curve_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_allocator_opts temp_allocator;

        public ufbx_allocator_opts result_allocator;

        [NativeTypeName("size_t")]
        public UIntPtr span_subdivision;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    public partial struct ufbx_tessellate_surface_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_allocator_opts temp_allocator;

        public ufbx_allocator_opts result_allocator;

        [NativeTypeName("size_t")]
        public UIntPtr span_subdivision_u;

        [NativeTypeName("size_t")]
        public UIntPtr span_subdivision_v;

        [NativeTypeName("bool")]
        public byte skip_mesh_parts;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    public partial struct ufbx_subdivide_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_allocator_opts temp_allocator;

        public ufbx_allocator_opts result_allocator;

        public ufbx_subdivision_boundary boundary;

        public ufbx_subdivision_boundary uv_boundary;

        [NativeTypeName("bool")]
        public byte ignore_normals;

        [NativeTypeName("bool")]
        public byte interpolate_normals;

        [NativeTypeName("bool")]
        public byte interpolate_tangents;

        [NativeTypeName("bool")]
        public byte evaluate_source_vertices;

        [NativeTypeName("size_t")]
        public UIntPtr max_source_vertices;

        [NativeTypeName("bool")]
        public byte evaluate_skin_weights;

        [NativeTypeName("size_t")]
        public UIntPtr max_skin_weights;

        [NativeTypeName("size_t")]
        public UIntPtr skin_deformer_index;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    public partial struct ufbx_geometry_cache_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_allocator_opts temp_allocator;

        public ufbx_allocator_opts result_allocator;

        public ufbx_open_file_cb open_file_cb;

        public double frames_per_second;

        public ufbx_mirror_axis mirror_axis;

        [NativeTypeName("bool")]
        public byte use_scale_factor;

        [NativeTypeName("ufbx_real")]
        public double scale_factor;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    public partial struct ufbx_geometry_cache_data_opts
    {
        [NativeTypeName("uint32_t")]
        public uint _begin_zero;

        public ufbx_open_file_cb open_file_cb;

        [NativeTypeName("bool")]
        public byte additive;

        [NativeTypeName("bool")]
        public byte use_weight;

        [NativeTypeName("ufbx_real")]
        public double weight;

        [NativeTypeName("bool")]
        public byte ignore_transform;

        [NativeTypeName("uint32_t")]
        public uint _end_zero;
    }

    public unsafe partial struct ufbx_panic
    {
        [NativeTypeName("bool")]
        public byte did_panic;

        [NativeTypeName("size_t")]
        public UIntPtr message_length;

        [NativeTypeName("char[128]")]
        public fixed sbyte message[128];
    }

    public enum ufbx_transform_flags
    {
        UFBX_TRANSFORM_FLAG_IGNORE_SCALE_HELPER = 0x1,
        UFBX_TRANSFORM_FLAG_IGNORE_COMPONENTWISE_SCALE = 0x2,
        UFBX_TRANSFORM_FLAG_EXPLICIT_INCLUDES = 0x4,
        UFBX_TRANSFORM_FLAG_INCLUDE_TRANSLATION = 0x10,
        UFBX_TRANSFORM_FLAG_INCLUDE_ROTATION = 0x20,
        UFBX_TRANSFORM_FLAG_INCLUDE_SCALE = 0x40,
        UFBX_TRANSFORM_FLAG_NO_EXTRAPOLATION = 0x80,
        UFBX_TRANSFORM_FLAGS_FORCE_32BIT = 0x7fffffff,
    }

    public unsafe partial struct ufbx_string_view
    {
        [NativeTypeName("const char *")]
        public sbyte* data;

        [NativeTypeName("size_t")]
        public UIntPtr length;
    }

    public partial struct ufbx_deleter
    {
    }

    public static unsafe partial class UfbxNative
    {
        public const int UFBX_ROTATION_ORDER_COUNT = (int)(UFBX_ROTATION_ORDER_SPHERIC + 1);

        public const int UFBX_DOM_VALUE_TYPE_COUNT = (int)(UFBX_DOM_VALUE_ARRAY_IGNORED + 1);

        public const int UFBX_PROP_TYPE_COUNT = (int)(UFBX_PROP_REFERENCE + 1);

        public const int UFBX_ELEMENT_TYPE_COUNT = (int)(UFBX_ELEMENT_METADATA_OBJECT + 1);

        public const int UFBX_INHERIT_MODE_COUNT = (int)(UFBX_INHERIT_MODE_COMPONENTWISE_SCALE + 1);

        public const int UFBX_MIRROR_AXIS_COUNT = (int)(UFBX_MIRROR_AXIS_Z + 1);

        public const int UFBX_SUBDIVISION_DISPLAY_MODE_COUNT = (int)(UFBX_SUBDIVISION_DISPLAY_SMOOTH + 1);

        public const int UFBX_SUBDIVISION_BOUNDARY_COUNT = (int)(UFBX_SUBDIVISION_BOUNDARY_SHARP_INTERIOR + 1);

        public const int UFBX_LIGHT_TYPE_COUNT = (int)(UFBX_LIGHT_VOLUME + 1);

        public const int UFBX_LIGHT_DECAY_COUNT = (int)(UFBX_LIGHT_DECAY_CUBIC + 1);

        public const int UFBX_LIGHT_AREA_SHAPE_COUNT = (int)(UFBX_LIGHT_AREA_SHAPE_SPHERE + 1);

        public const int UFBX_PROJECTION_MODE_COUNT = (int)(UFBX_PROJECTION_MODE_ORTHOGRAPHIC + 1);

        public const int UFBX_ASPECT_MODE_COUNT = (int)(UFBX_ASPECT_MODE_FIXED_HEIGHT + 1);

        public const int UFBX_APERTURE_MODE_COUNT = (int)(UFBX_APERTURE_MODE_FOCAL_LENGTH + 1);

        public const int UFBX_GATE_FIT_COUNT = (int)(UFBX_GATE_FIT_STRETCH + 1);

        public const int UFBX_APERTURE_FORMAT_COUNT = (int)(UFBX_APERTURE_FORMAT_IMAX + 1);

        public const int UFBX_COORDINATE_AXIS_COUNT = (int)(UFBX_COORDINATE_AXIS_UNKNOWN + 1);

        public const int UFBX_NURBS_TOPOLOGY_COUNT = (int)(UFBX_NURBS_TOPOLOGY_CLOSED + 1);

        public const int UFBX_MARKER_TYPE_COUNT = (int)(UFBX_MARKER_IK_EFFECTOR + 1);

        public const int UFBX_LOD_DISPLAY_COUNT = (int)(UFBX_LOD_DISPLAY_HIDE + 1);

        public const int UFBX_SKINNING_METHOD_COUNT = (int)(UFBX_SKINNING_METHOD_BLENDED_DQ_LINEAR + 1);

        public const int UFBX_CACHE_FILE_FORMAT_COUNT = (int)(UFBX_CACHE_FILE_FORMAT_MC + 1);

        public const int UFBX_CACHE_DATA_FORMAT_COUNT = (int)(UFBX_CACHE_DATA_FORMAT_VEC3_DOUBLE + 1);

        public const int UFBX_CACHE_DATA_ENCODING_COUNT = (int)(UFBX_CACHE_DATA_ENCODING_BIG_ENDIAN + 1);

        public const int UFBX_CACHE_INTERPRETATION_COUNT = (int)(UFBX_CACHE_INTERPRETATION_VERTEX_NORMAL + 1);

        public const int UFBX_SHADER_TYPE_COUNT = (int)(UFBX_SHADER_WAVEFRONT_MTL + 1);

        public const int UFBX_MATERIAL_FBX_MAP_COUNT = (int)(UFBX_MATERIAL_FBX_VECTOR_DISPLACEMENT + 1);

        public const int UFBX_MATERIAL_PBR_MAP_COUNT = (int)(UFBX_MATERIAL_PBR_TRANSMISSION_GLOSSINESS + 1);

        public const int UFBX_MATERIAL_FEATURE_COUNT = (int)(UFBX_MATERIAL_FEATURE_TRANSMISSION_ROUGHNESS_AS_GLOSSINESS + 1);

        public const int UFBX_TEXTURE_TYPE_COUNT = (int)(UFBX_TEXTURE_SHADER + 1);

        public const int UFBX_BLEND_MODE_COUNT = (int)(UFBX_BLEND_OVERLAY + 1);

        public const int UFBX_WRAP_MODE_COUNT = (int)(UFBX_WRAP_CLAMP + 1);

        public const int UFBX_SHADER_TEXTURE_TYPE_COUNT = (int)(UFBX_SHADER_TEXTURE_OSL + 1);

        public const int UFBX_INTERPOLATION_COUNT = (int)(UFBX_INTERPOLATION_CUBIC + 1);

        public const int UFBX_EXTRAPOLATION_MODE_COUNT = (int)(UFBX_EXTRAPOLATION_REPEAT_RELATIVE + 1);

        public const int UFBX_CONSTRAINT_TYPE_COUNT = (int)(UFBX_CONSTRAINT_SINGLE_CHAIN_IK + 1);

        public const int UFBX_CONSTRAINT_AIM_UP_TYPE_COUNT = (int)(UFBX_CONSTRAINT_AIM_UP_NONE + 1);

        public const int UFBX_CONSTRAINT_IK_POLE_TYPE_COUNT = (int)(UFBX_CONSTRAINT_IK_POLE_NODE + 1);

        public const int UFBX_EXPORTER_COUNT = (int)(UFBX_EXPORTER_UFBX_WRITE + 1);

        public const int UFBX_FILE_FORMAT_COUNT = (int)(UFBX_FILE_FORMAT_MTL + 1);

        public const int UFBX_WARNING_TYPE_COUNT = (int)(UFBX_WARNING_UNKNOWN_OBJ_DIRECTIVE + 1);

        public const int UFBX_THUMBNAIL_FORMAT_COUNT = (int)(UFBX_THUMBNAIL_FORMAT_RGBA_32 + 1);

        public const int UFBX_SPACE_CONVERSION_COUNT = (int)(UFBX_SPACE_CONVERSION_MODIFY_GEOMETRY + 1);

        public const int UFBX_GEOMETRY_TRANSFORM_HANDLING_COUNT = (int)(UFBX_GEOMETRY_TRANSFORM_HANDLING_MODIFY_GEOMETRY_NO_FALLBACK + 1);

        public const int UFBX_INHERIT_MODE_HANDLING_COUNT = (int)(UFBX_INHERIT_MODE_HANDLING_IGNORE + 1);

        public const int UFBX_PIVOT_HANDLING_COUNT = (int)(UFBX_PIVOT_HANDLING_ADJUST_TO_ROTATION_PIVOT + 1);

        public const int UFBX_TIME_MODE_COUNT = (int)(UFBX_TIME_MODE_59_94_FPS + 1);

        public const int UFBX_TIME_PROTOCOL_COUNT = (int)(UFBX_TIME_PROTOCOL_DEFAULT + 1);

        public const int UFBX_SNAP_MODE_COUNT = (int)(UFBX_SNAP_MODE_SNAP_AND_PLAY + 1);

        public const int UFBX_OPEN_FILE_TYPE_COUNT = (int)(UFBX_OPEN_FILE_OBJ_MTL + 1);

        public const int UFBX_ERROR_TYPE_COUNT = (int)(UFBX_ERROR_UNSUPPORTED_VERSION + 1);

        public const int UFBX_INDEX_ERROR_HANDLING_COUNT = (int)(UFBX_INDEX_ERROR_HANDLING_UNSAFE_IGNORE + 1);

        public const int UFBX_UNICODE_ERROR_HANDLING_COUNT = (int)(UFBX_UNICODE_ERROR_HANDLING_UNSAFE_IGNORE + 1);

        public const int UFBX_BAKE_STEP_HANDLING_COUNT = (int)(UFBX_BAKE_STEP_HANDLING_IGNORE + 1);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ufbx_is_thread_safe();

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_scene* ufbx_load_memory([NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr data_size, [NativeTypeName("const ufbx_load_opts *")] ufbx_load_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_scene* ufbx_load_file([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("const ufbx_load_opts *")] ufbx_load_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_scene* ufbx_load_file_len([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("size_t")] UIntPtr filename_len, [NativeTypeName("const ufbx_load_opts *")] ufbx_load_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_scene* ufbx_load_stdio(void* file, [NativeTypeName("const ufbx_load_opts *")] ufbx_load_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_scene* ufbx_load_stdio_prefix(void* file, [NativeTypeName("const void *")] void* prefix, [NativeTypeName("size_t")] UIntPtr prefix_size, [NativeTypeName("const ufbx_load_opts *")] ufbx_load_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_scene* ufbx_load_stream([NativeTypeName("const ufbx_stream *")] ufbx_stream* stream, [NativeTypeName("const ufbx_load_opts *")] ufbx_load_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_scene* ufbx_load_stream_prefix([NativeTypeName("const ufbx_stream *")] ufbx_stream* stream, [NativeTypeName("const void *")] void* prefix, [NativeTypeName("size_t")] UIntPtr prefix_size, [NativeTypeName("const ufbx_load_opts *")] ufbx_load_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_free_scene(ufbx_scene* scene);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_retain_scene(ufbx_scene* scene);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ufbx_format_error([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("size_t")] UIntPtr dst_size, [NativeTypeName("const ufbx_error *")] ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_prop* ufbx_find_prop_len([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_prop* ufbx_find_prop([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_find_real_len([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, [NativeTypeName("ufbx_real")] double def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_find_real([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("ufbx_real")] double def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_find_vec3_len([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, ufbx_vec3 def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_find_vec3([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, ufbx_vec3 def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long ufbx_find_int_len([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, [NativeTypeName("int64_t")] long def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long ufbx_find_int([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("int64_t")] long def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ufbx_find_bool_len([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, [NativeTypeName("bool")] byte def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ufbx_find_bool([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("bool")] byte def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_string ufbx_find_string_len([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, ufbx_string def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_string ufbx_find_string([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, ufbx_string def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_blob ufbx_find_blob_len([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, ufbx_blob def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_blob ufbx_find_blob([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const char *")] sbyte* name, ufbx_blob def);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_prop* ufbx_find_prop_concat([NativeTypeName("const ufbx_props *")] ufbx_props* props, [NativeTypeName("const ufbx_string *")] ufbx_string* parts, [NativeTypeName("size_t")] UIntPtr num_parts);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_element* ufbx_get_prop_element([NativeTypeName("const ufbx_element *")] ufbx_element* element, [NativeTypeName("const ufbx_prop *")] ufbx_prop* prop, ufbx_element_type type);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_element* ufbx_find_prop_element_len([NativeTypeName("const ufbx_element *")] ufbx_element* element, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, ufbx_element_type type);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_element* ufbx_find_prop_element([NativeTypeName("const ufbx_element *")] ufbx_element* element, [NativeTypeName("const char *")] sbyte* name, ufbx_element_type type);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_element* ufbx_find_element_len([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, ufbx_element_type type, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_element* ufbx_find_element([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, ufbx_element_type type, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_node* ufbx_find_node_len([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_node* ufbx_find_node([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_anim_stack* ufbx_find_anim_stack_len([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_anim_stack* ufbx_find_anim_stack([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_material* ufbx_find_material_len([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_material* ufbx_find_material([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_anim_prop* ufbx_find_anim_prop_len([NativeTypeName("const ufbx_anim_layer *")] ufbx_anim_layer* layer, [NativeTypeName("const ufbx_element *")] ufbx_element* element, [NativeTypeName("const char *")] sbyte* prop, [NativeTypeName("size_t")] UIntPtr prop_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_anim_prop* ufbx_find_anim_prop([NativeTypeName("const ufbx_anim_layer *")] ufbx_anim_layer* layer, [NativeTypeName("const ufbx_element *")] ufbx_element* element, [NativeTypeName("const char *")] sbyte* prop);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_anim_prop_list ufbx_find_anim_props([NativeTypeName("const ufbx_anim_layer *")] ufbx_anim_layer* layer, [NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_matrix ufbx_get_compatible_matrix_for_normals([NativeTypeName("const ufbx_node *")] ufbx_node* node);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ptrdiff_t")]
        public static extern IntPtr ufbx_inflate(void* dst, [NativeTypeName("size_t")] UIntPtr dst_size, [NativeTypeName("const ufbx_inflate_input *")] ufbx_inflate_input* input, ufbx_inflate_retain* retain);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ufbx_default_open_file(void* user, ufbx_stream* stream, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("size_t")] UIntPtr path_len, [NativeTypeName("const ufbx_open_file_info *")] ufbx_open_file_info* info);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ufbx_open_file(ufbx_stream* stream, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("size_t")] UIntPtr path_len, [NativeTypeName("const ufbx_open_file_opts *")] ufbx_open_file_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ufbx_open_file_ctx(ufbx_stream* stream, [NativeTypeName("ufbx_open_file_context")] UIntPtr ctx, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("size_t")] UIntPtr path_len, [NativeTypeName("const ufbx_open_file_opts *")] ufbx_open_file_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ufbx_open_memory(ufbx_stream* stream, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr data_size, [NativeTypeName("const ufbx_open_memory_opts *")] ufbx_open_memory_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ufbx_open_memory_ctx(ufbx_stream* stream, [NativeTypeName("ufbx_open_file_context")] UIntPtr ctx, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr data_size, [NativeTypeName("const ufbx_open_memory_opts *")] ufbx_open_memory_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_evaluate_curve([NativeTypeName("const ufbx_anim_curve *")] ufbx_anim_curve* curve, double time, [NativeTypeName("ufbx_real")] double default_value);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_evaluate_curve_flags([NativeTypeName("const ufbx_anim_curve *")] ufbx_anim_curve* curve, double time, [NativeTypeName("ufbx_real")] double default_value, [NativeTypeName("uint32_t")] uint flags);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_evaluate_anim_value_real([NativeTypeName("const ufbx_anim_value *")] ufbx_anim_value* anim_value, double time);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_evaluate_anim_value_vec3([NativeTypeName("const ufbx_anim_value *")] ufbx_anim_value* anim_value, double time);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_evaluate_anim_value_real_flags([NativeTypeName("const ufbx_anim_value *")] ufbx_anim_value* anim_value, double time, [NativeTypeName("uint32_t")] uint flags);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_evaluate_anim_value_vec3_flags([NativeTypeName("const ufbx_anim_value *")] ufbx_anim_value* anim_value, double time, [NativeTypeName("uint32_t")] uint flags);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_prop ufbx_evaluate_prop_len([NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_element *")] ufbx_element* element, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, double time);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_prop ufbx_evaluate_prop([NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_element *")] ufbx_element* element, [NativeTypeName("const char *")] sbyte* name, double time);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_prop ufbx_evaluate_prop_flags_len([NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_element *")] ufbx_element* element, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len, double time, [NativeTypeName("uint32_t")] uint flags);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_prop ufbx_evaluate_prop_flags([NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_element *")] ufbx_element* element, [NativeTypeName("const char *")] sbyte* name, double time, [NativeTypeName("uint32_t")] uint flags);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_props ufbx_evaluate_props([NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_element *")] ufbx_element* element, double time, ufbx_prop* buffer, [NativeTypeName("size_t")] UIntPtr buffer_size);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_props ufbx_evaluate_props_flags([NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_element *")] ufbx_element* element, double time, ufbx_prop* buffer, [NativeTypeName("size_t")] UIntPtr buffer_size, [NativeTypeName("uint32_t")] uint flags);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_transform ufbx_evaluate_transform([NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_node *")] ufbx_node* node, double time);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_transform ufbx_evaluate_transform_flags([NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_node *")] ufbx_node* node, double time, [NativeTypeName("uint32_t")] uint flags);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_evaluate_blend_weight([NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_blend_channel *")] ufbx_blend_channel* channel, double time);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_evaluate_blend_weight_flags([NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_blend_channel *")] ufbx_blend_channel* channel, double time, [NativeTypeName("uint32_t")] uint flags);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_scene* ufbx_evaluate_scene([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, [NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, double time, [NativeTypeName("const ufbx_evaluate_opts *")] ufbx_evaluate_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_anim* ufbx_create_anim([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, [NativeTypeName("const ufbx_anim_opts *")] ufbx_anim_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_free_anim(ufbx_anim* anim);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_retain_anim(ufbx_anim* anim);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_baked_anim* ufbx_bake_anim([NativeTypeName("const ufbx_scene *")] ufbx_scene* scene, [NativeTypeName("const ufbx_anim *")] ufbx_anim* anim, [NativeTypeName("const ufbx_bake_opts *")] ufbx_bake_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_retain_baked_anim(ufbx_baked_anim* bake);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_free_baked_anim(ufbx_baked_anim* bake);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_baked_node* ufbx_find_baked_node_by_typed_id(ufbx_baked_anim* bake, [NativeTypeName("uint32_t")] uint typed_id);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_baked_node* ufbx_find_baked_node(ufbx_baked_anim* bake, ufbx_node* node);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_baked_element* ufbx_find_baked_element_by_element_id(ufbx_baked_anim* bake, [NativeTypeName("uint32_t")] uint element_id);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_baked_element* ufbx_find_baked_element(ufbx_baked_anim* bake, ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_evaluate_baked_vec3(ufbx_baked_vec3_list keyframes, double time);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_quat ufbx_evaluate_baked_quat(ufbx_baked_quat_list keyframes, double time);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_bone_pose* ufbx_get_bone_pose([NativeTypeName("const ufbx_pose *")] ufbx_pose* pose, [NativeTypeName("const ufbx_node *")] ufbx_node* node);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_texture* ufbx_find_prop_texture_len([NativeTypeName("const ufbx_material *")] ufbx_material* material, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_texture* ufbx_find_prop_texture([NativeTypeName("const ufbx_material *")] ufbx_material* material, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_string ufbx_find_shader_prop_len([NativeTypeName("const ufbx_shader *")] ufbx_shader* shader, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_string ufbx_find_shader_prop([NativeTypeName("const ufbx_shader *")] ufbx_shader* shader, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_shader_prop_binding_list ufbx_find_shader_prop_bindings_len([NativeTypeName("const ufbx_shader *")] ufbx_shader* shader, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_shader_prop_binding_list ufbx_find_shader_prop_bindings([NativeTypeName("const ufbx_shader *")] ufbx_shader* shader, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_shader_texture_input* ufbx_find_shader_texture_input_len([NativeTypeName("const ufbx_shader_texture *")] ufbx_shader_texture* shader, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_shader_texture_input* ufbx_find_shader_texture_input([NativeTypeName("const ufbx_shader_texture *")] ufbx_shader_texture* shader, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ufbx_coordinate_axes_valid(ufbx_coordinate_axes axes);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_vec3_normalize(ufbx_vec3 v);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_quat_dot(ufbx_quat a, ufbx_quat b);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_quat ufbx_quat_mul(ufbx_quat a, ufbx_quat b);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_quat ufbx_quat_normalize(ufbx_quat q);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_quat ufbx_quat_fix_antipodal(ufbx_quat q, ufbx_quat reference);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_quat ufbx_quat_slerp(ufbx_quat a, ufbx_quat b, [NativeTypeName("ufbx_real")] double t);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_quat_rotate_vec3(ufbx_quat q, ufbx_vec3 v);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_quat_to_euler(ufbx_quat q, ufbx_rotation_order order);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_quat ufbx_euler_to_quat(ufbx_vec3 v, ufbx_rotation_order order);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_matrix ufbx_matrix_mul([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* a, [NativeTypeName("const ufbx_matrix *")] ufbx_matrix* b);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_matrix_determinant([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_matrix ufbx_matrix_invert([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_matrix ufbx_matrix_for_normals([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_transform_position([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m, ufbx_vec3 v);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_transform_direction([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m, ufbx_vec3 v);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_matrix ufbx_transform_to_matrix([NativeTypeName("const ufbx_transform *")] ufbx_transform* t);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_transform ufbx_matrix_to_transform([NativeTypeName("const ufbx_matrix *")] ufbx_matrix* m);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_matrix ufbx_catch_get_skin_vertex_matrix(ufbx_panic* panic, [NativeTypeName("const ufbx_skin_deformer *")] ufbx_skin_deformer* skin, [NativeTypeName("size_t")] UIntPtr vertex, [NativeTypeName("const ufbx_matrix *")] ufbx_matrix* fallback);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint ufbx_get_blend_shape_offset_index([NativeTypeName("const ufbx_blend_shape *")] ufbx_blend_shape* shape, [NativeTypeName("size_t")] UIntPtr vertex);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_get_blend_shape_vertex_offset([NativeTypeName("const ufbx_blend_shape *")] ufbx_blend_shape* shape, [NativeTypeName("size_t")] UIntPtr vertex);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_get_blend_vertex_offset([NativeTypeName("const ufbx_blend_deformer *")] ufbx_blend_deformer* blend, [NativeTypeName("size_t")] UIntPtr vertex);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_add_blend_shape_vertex_offsets([NativeTypeName("const ufbx_blend_shape *")] ufbx_blend_shape* shape, ufbx_vec3* vertices, [NativeTypeName("size_t")] UIntPtr num_vertices, [NativeTypeName("ufbx_real")] double weight);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_add_blend_vertex_offsets([NativeTypeName("const ufbx_blend_deformer *")] ufbx_blend_deformer* blend, ufbx_vec3* vertices, [NativeTypeName("size_t")] UIntPtr num_vertices, [NativeTypeName("ufbx_real")] double weight);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ufbx_evaluate_nurbs_basis([NativeTypeName("const ufbx_nurbs_basis *")] ufbx_nurbs_basis* basis, [NativeTypeName("ufbx_real")] double u, [NativeTypeName("ufbx_real *")] double* weights, [NativeTypeName("size_t")] UIntPtr num_weights, [NativeTypeName("ufbx_real *")] double* derivatives, [NativeTypeName("size_t")] UIntPtr num_derivatives);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_curve_point ufbx_evaluate_nurbs_curve([NativeTypeName("const ufbx_nurbs_curve *")] ufbx_nurbs_curve* curve, [NativeTypeName("ufbx_real")] double u);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_surface_point ufbx_evaluate_nurbs_surface([NativeTypeName("const ufbx_nurbs_surface *")] ufbx_nurbs_surface* surface, [NativeTypeName("ufbx_real")] double u, [NativeTypeName("ufbx_real")] double v);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_line_curve* ufbx_tessellate_nurbs_curve([NativeTypeName("const ufbx_nurbs_curve *")] ufbx_nurbs_curve* curve, [NativeTypeName("const ufbx_tessellate_curve_opts *")] ufbx_tessellate_curve_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_mesh* ufbx_tessellate_nurbs_surface([NativeTypeName("const ufbx_nurbs_surface *")] ufbx_nurbs_surface* surface, [NativeTypeName("const ufbx_tessellate_surface_opts *")] ufbx_tessellate_surface_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_free_line_curve(ufbx_line_curve* curve);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_retain_line_curve(ufbx_line_curve* curve);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint ufbx_find_face_index(ufbx_mesh* mesh, [NativeTypeName("size_t")] UIntPtr index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint ufbx_catch_triangulate_face(ufbx_panic* panic, [NativeTypeName("uint32_t *")] uint* indices, [NativeTypeName("size_t")] UIntPtr num_indices, [NativeTypeName("const ufbx_mesh *")] ufbx_mesh* mesh, ufbx_face face);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint ufbx_triangulate_face([NativeTypeName("uint32_t *")] uint* indices, [NativeTypeName("size_t")] UIntPtr num_indices, [NativeTypeName("const ufbx_mesh *")] ufbx_mesh* mesh, ufbx_face face);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_catch_compute_topology(ufbx_panic* panic, [NativeTypeName("const ufbx_mesh *")] ufbx_mesh* mesh, ufbx_topo_edge* topo, [NativeTypeName("size_t")] UIntPtr num_topo);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_compute_topology([NativeTypeName("const ufbx_mesh *")] ufbx_mesh* mesh, ufbx_topo_edge* topo, [NativeTypeName("size_t")] UIntPtr num_topo);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint ufbx_catch_topo_next_vertex_edge(ufbx_panic* panic, [NativeTypeName("const ufbx_topo_edge *")] ufbx_topo_edge* topo, [NativeTypeName("size_t")] UIntPtr num_topo, [NativeTypeName("uint32_t")] uint index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint ufbx_topo_next_vertex_edge([NativeTypeName("const ufbx_topo_edge *")] ufbx_topo_edge* topo, [NativeTypeName("size_t")] UIntPtr num_topo, [NativeTypeName("uint32_t")] uint index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint ufbx_catch_topo_prev_vertex_edge(ufbx_panic* panic, [NativeTypeName("const ufbx_topo_edge *")] ufbx_topo_edge* topo, [NativeTypeName("size_t")] UIntPtr num_topo, [NativeTypeName("uint32_t")] uint index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint ufbx_topo_prev_vertex_edge([NativeTypeName("const ufbx_topo_edge *")] ufbx_topo_edge* topo, [NativeTypeName("size_t")] UIntPtr num_topo, [NativeTypeName("uint32_t")] uint index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_catch_get_weighted_face_normal(ufbx_panic* panic, [NativeTypeName("const ufbx_vertex_vec3 *")] ufbx_vertex_vec3* positions, ufbx_face face);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_get_weighted_face_normal([NativeTypeName("const ufbx_vertex_vec3 *")] ufbx_vertex_vec3* positions, ufbx_face face);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ufbx_catch_generate_normal_mapping(ufbx_panic* panic, [NativeTypeName("const ufbx_mesh *")] ufbx_mesh* mesh, [NativeTypeName("const ufbx_topo_edge *")] ufbx_topo_edge* topo, [NativeTypeName("size_t")] UIntPtr num_topo, [NativeTypeName("uint32_t *")] uint* normal_indices, [NativeTypeName("size_t")] UIntPtr num_normal_indices, [NativeTypeName("bool")] byte assume_smooth);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ufbx_generate_normal_mapping([NativeTypeName("const ufbx_mesh *")] ufbx_mesh* mesh, [NativeTypeName("const ufbx_topo_edge *")] ufbx_topo_edge* topo, [NativeTypeName("size_t")] UIntPtr num_topo, [NativeTypeName("uint32_t *")] uint* normal_indices, [NativeTypeName("size_t")] UIntPtr num_normal_indices, [NativeTypeName("bool")] byte assume_smooth);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_catch_compute_normals(ufbx_panic* panic, [NativeTypeName("const ufbx_mesh *")] ufbx_mesh* mesh, [NativeTypeName("const ufbx_vertex_vec3 *")] ufbx_vertex_vec3* positions, [NativeTypeName("const uint32_t *")] uint* normal_indices, [NativeTypeName("size_t")] UIntPtr num_normal_indices, ufbx_vec3* normals, [NativeTypeName("size_t")] UIntPtr num_normals);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_compute_normals([NativeTypeName("const ufbx_mesh *")] ufbx_mesh* mesh, [NativeTypeName("const ufbx_vertex_vec3 *")] ufbx_vertex_vec3* positions, [NativeTypeName("const uint32_t *")] uint* normal_indices, [NativeTypeName("size_t")] UIntPtr num_normal_indices, ufbx_vec3* normals, [NativeTypeName("size_t")] UIntPtr num_normals);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_mesh* ufbx_subdivide_mesh([NativeTypeName("const ufbx_mesh *")] ufbx_mesh* mesh, [NativeTypeName("size_t")] UIntPtr level, [NativeTypeName("const ufbx_subdivide_opts *")] ufbx_subdivide_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_free_mesh(ufbx_mesh* mesh);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_retain_mesh(ufbx_mesh* mesh);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_geometry_cache* ufbx_load_geometry_cache([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("const ufbx_geometry_cache_opts *")] ufbx_geometry_cache_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_geometry_cache* ufbx_load_geometry_cache_len([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("size_t")] UIntPtr filename_len, [NativeTypeName("const ufbx_geometry_cache_opts *")] ufbx_geometry_cache_opts* opts, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_free_geometry_cache(ufbx_geometry_cache* cache);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_retain_geometry_cache(ufbx_geometry_cache* cache);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ufbx_read_geometry_cache_real([NativeTypeName("const ufbx_cache_frame *")] ufbx_cache_frame* frame, [NativeTypeName("ufbx_real *")] double* data, [NativeTypeName("size_t")] UIntPtr num_data, [NativeTypeName("const ufbx_geometry_cache_data_opts *")] ufbx_geometry_cache_data_opts* opts);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ufbx_read_geometry_cache_vec3([NativeTypeName("const ufbx_cache_frame *")] ufbx_cache_frame* frame, ufbx_vec3* data, [NativeTypeName("size_t")] UIntPtr num_data, [NativeTypeName("const ufbx_geometry_cache_data_opts *")] ufbx_geometry_cache_data_opts* opts);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ufbx_sample_geometry_cache_real([NativeTypeName("const ufbx_cache_channel *")] ufbx_cache_channel* channel, double time, [NativeTypeName("ufbx_real *")] double* data, [NativeTypeName("size_t")] UIntPtr num_data, [NativeTypeName("const ufbx_geometry_cache_data_opts *")] ufbx_geometry_cache_data_opts* opts);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ufbx_sample_geometry_cache_vec3([NativeTypeName("const ufbx_cache_channel *")] ufbx_cache_channel* channel, double time, ufbx_vec3* data, [NativeTypeName("size_t")] UIntPtr num_data, [NativeTypeName("const ufbx_geometry_cache_data_opts *")] ufbx_geometry_cache_data_opts* opts);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_dom_node* ufbx_dom_find_len([NativeTypeName("const ufbx_dom_node *")] ufbx_dom_node* parent, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("size_t")] UIntPtr name_len);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_dom_node* ufbx_dom_find([NativeTypeName("const ufbx_dom_node *")] ufbx_dom_node* parent, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ufbx_generate_indices([NativeTypeName("const ufbx_vertex_stream *")] ufbx_vertex_stream* streams, [NativeTypeName("size_t")] UIntPtr num_streams, [NativeTypeName("uint32_t *")] uint* indices, [NativeTypeName("size_t")] UIntPtr num_indices, [NativeTypeName("const ufbx_allocator_opts *")] ufbx_allocator_opts* allocator, ufbx_error* error);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_thread_pool_run_task([NativeTypeName("ufbx_thread_pool_context")] UIntPtr ctx, [NativeTypeName("uint32_t")] uint index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ufbx_thread_pool_set_user_ptr([NativeTypeName("ufbx_thread_pool_context")] UIntPtr ctx, void* user_ptr);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* ufbx_thread_pool_get_user_ptr([NativeTypeName("ufbx_thread_pool_context")] UIntPtr ctx);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_catch_get_vertex_real(ufbx_panic* panic, [NativeTypeName("const ufbx_vertex_real *")] ufbx_vertex_real* v, [NativeTypeName("size_t")] UIntPtr index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec2 ufbx_catch_get_vertex_vec2(ufbx_panic* panic, [NativeTypeName("const ufbx_vertex_vec2 *")] ufbx_vertex_vec2* v, [NativeTypeName("size_t")] UIntPtr index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec3 ufbx_catch_get_vertex_vec3(ufbx_panic* panic, [NativeTypeName("const ufbx_vertex_vec3 *")] ufbx_vertex_vec3* v, [NativeTypeName("size_t")] UIntPtr index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_vec4 ufbx_catch_get_vertex_vec4(ufbx_panic* panic, [NativeTypeName("const ufbx_vertex_vec4 *")] ufbx_vertex_vec4* v, [NativeTypeName("size_t")] UIntPtr index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("ufbx_real")]
        public static extern double ufbx_catch_get_vertex_w_vec3(ufbx_panic* panic, [NativeTypeName("const ufbx_vertex_vec3 *")] ufbx_vertex_vec3* v, [NativeTypeName("size_t")] UIntPtr index);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_unknown* ufbx_as_unknown([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_node* ufbx_as_node([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_mesh* ufbx_as_mesh([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_light* ufbx_as_light([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_camera* ufbx_as_camera([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_bone* ufbx_as_bone([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_empty* ufbx_as_empty([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_line_curve* ufbx_as_line_curve([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_nurbs_curve* ufbx_as_nurbs_curve([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_nurbs_surface* ufbx_as_nurbs_surface([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_nurbs_trim_surface* ufbx_as_nurbs_trim_surface([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_nurbs_trim_boundary* ufbx_as_nurbs_trim_boundary([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_procedural_geometry* ufbx_as_procedural_geometry([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_stereo_camera* ufbx_as_stereo_camera([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_camera_switcher* ufbx_as_camera_switcher([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_marker* ufbx_as_marker([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_lod_group* ufbx_as_lod_group([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_skin_deformer* ufbx_as_skin_deformer([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_skin_cluster* ufbx_as_skin_cluster([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_blend_deformer* ufbx_as_blend_deformer([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_blend_channel* ufbx_as_blend_channel([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_blend_shape* ufbx_as_blend_shape([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_cache_deformer* ufbx_as_cache_deformer([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_cache_file* ufbx_as_cache_file([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_material* ufbx_as_material([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_texture* ufbx_as_texture([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_video* ufbx_as_video([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_shader* ufbx_as_shader([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_shader_binding* ufbx_as_shader_binding([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_anim_stack* ufbx_as_anim_stack([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_anim_layer* ufbx_as_anim_layer([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_anim_value* ufbx_as_anim_value([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_anim_curve* ufbx_as_anim_curve([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_display_layer* ufbx_as_display_layer([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_selection_set* ufbx_as_selection_set([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_selection_node* ufbx_as_selection_node([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_character* ufbx_as_character([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_constraint* ufbx_as_constraint([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_audio_layer* ufbx_as_audio_layer([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_audio_clip* ufbx_as_audio_clip([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_pose* ufbx_as_pose([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_metadata_object* ufbx_as_metadata_object([NativeTypeName("const ufbx_element *")] ufbx_element* element);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte ufbx_dom_is_array([NativeTypeName("const ufbx_dom_node *")] ufbx_dom_node* node);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr ufbx_dom_array_size([NativeTypeName("const ufbx_dom_node *")] ufbx_dom_node* node);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_int32_list ufbx_dom_as_int32_list([NativeTypeName("const ufbx_dom_node *")] ufbx_dom_node* node);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_int64_list ufbx_dom_as_int64_list([NativeTypeName("const ufbx_dom_node *")] ufbx_dom_node* node);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_float_list ufbx_dom_as_float_list([NativeTypeName("const ufbx_dom_node *")] ufbx_dom_node* node);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_double_list ufbx_dom_as_double_list([NativeTypeName("const ufbx_dom_node *")] ufbx_dom_node* node);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_real_list ufbx_dom_as_real_list([NativeTypeName("const ufbx_dom_node *")] ufbx_dom_node* node);

        [DllImport("ufbx", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ufbx_blob_list ufbx_dom_as_blob_list([NativeTypeName("const ufbx_dom_node *")] ufbx_dom_node* node);
    }
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    internal sealed class NativeTypeNameAttribute : Attribute
    {
        public NativeTypeNameAttribute(string name)
        {
        }
    }
}
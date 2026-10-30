using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Netcode;
using UnityEngine;

public static class BufferSerializerExtensions : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ForMemCpyClassDictionary
	{
		static ForMemCpyClassDictionary()
		{
			Il2CppClassPointerStore<ForMemCpyClassDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForMemCpyClassDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForMemCpyClassDictionary>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForMemCpyClassDictionary>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForPrimitiveClassDictionary
	{
		static ForPrimitiveClassDictionary()
		{
			Il2CppClassPointerStore<ForPrimitiveClassDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForPrimitiveClassDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForPrimitiveClassDictionary>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForPrimitiveClassDictionary>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForPrimitiveDictionary
	{
		static ForPrimitiveDictionary()
		{
			Il2CppClassPointerStore<ForPrimitiveDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForPrimitiveDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForPrimitiveDictionary>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForPrimitiveDictionary>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForMemCpyPrimitiveDictionary
	{
		static ForMemCpyPrimitiveDictionary()
		{
			Il2CppClassPointerStore<ForMemCpyPrimitiveDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForMemCpyPrimitiveDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForMemCpyPrimitiveDictionary>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForMemCpyPrimitiveDictionary>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForStringPrimitiveDictionary
	{
		static ForStringPrimitiveDictionary()
		{
			Il2CppClassPointerStore<ForStringPrimitiveDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForStringPrimitiveDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForStringPrimitiveDictionary>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForStringPrimitiveDictionary>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForMemCpyClassList
	{
		static ForMemCpyClassList()
		{
			Il2CppClassPointerStore<ForMemCpyClassList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForMemCpyClassList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForMemCpyClassList>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForMemCpyClassList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForEnumClassList
	{
		static ForEnumClassList()
		{
			Il2CppClassPointerStore<ForEnumClassList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForEnumClassList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForEnumClassList>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForEnumClassList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForEnumList
	{
		static ForEnumList()
		{
			Il2CppClassPointerStore<ForEnumList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForEnumList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForEnumList>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForEnumList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForStructList
	{
		static ForStructList()
		{
			Il2CppClassPointerStore<ForStructList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForStructList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForStructList>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForStructList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForMemCpyList
	{
		static ForMemCpyList()
		{
			Il2CppClassPointerStore<ForMemCpyList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForMemCpyList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForMemCpyList>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForMemCpyList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForPrimitiveList
	{
		static ForPrimitiveList()
		{
			Il2CppClassPointerStore<ForPrimitiveList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForPrimitiveList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForPrimitiveList>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForPrimitiveList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForPrimitiveTupleList
	{
		static ForPrimitiveTupleList()
		{
			Il2CppClassPointerStore<ForPrimitiveTupleList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForPrimitiveTupleList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForPrimitiveTupleList>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForPrimitiveTupleList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForPrimitiveHashSet
	{
		static ForPrimitiveHashSet()
		{
			Il2CppClassPointerStore<ForPrimitiveHashSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForPrimitiveHashSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForPrimitiveHashSet>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForPrimitiveHashSet>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ForClassList
	{
		static ForClassList()
		{
			Il2CppClassPointerStore<ForClassList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, "ForClassList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForClassList>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForClassList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private sealed class MethodInfoStoreGeneric_SerializeNullableString_Public_Static_Void_BufferSerializer_1_T_byref_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeNullableString_Public_Static_Void_BufferSerializer_1_T_byref_String_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeNullableValue_Public_Static_Void_BufferSerializer_1_T_byref_T1_0<T, T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeNullableValue_Public_Static_Void_BufferSerializer_1_T_byref_T1_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForMemCpyClassDictionary_0<T, T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForMemCpyClassDictionary_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForPrimitiveClassDictionary_0<T, T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForPrimitiveClassDictionary_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForPrimitiveDictionary_0<T, T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForPrimitiveDictionary_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForMemCpyPrimitiveDictionary_0<T, T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForMemCpyPrimitiveDictionary_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_String_T1_ForStringPrimitiveDictionary_0<T, T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_String_T1_ForStringPrimitiveDictionary_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_List_1_T2_ForMemCpyClassList_0<T, T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_List_1_T2_ForMemCpyClassList_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_List_1_T2_ForEnumClassList_0<T, T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_List_1_T2_ForEnumClassList_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForEnumList_0<T, T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForEnumList_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForStructList_0<T, T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForStructList_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForMemCpyList_0<T, T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForMemCpyList_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForPrimitiveList_0<T, T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForPrimitiveList_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_ValueTuple_2_T1_T2_ForPrimitiveTupleList_0<T, T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_ValueTuple_2_T1_T2_ForPrimitiveTupleList_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_Vector3_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_Vector3_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_String_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_T1_ForPrimitiveHashSet_0<T, T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_T1_ForPrimitiveHashSet_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_Vector2_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_Vector2_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_String_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForClassList_0<T, T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForClassList_0, Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeNullableString_Public_Static_Void_BufferSerializer_1_T_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeNullableValue_Public_Static_Void_BufferSerializer_1_T_byref_T1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForMemCpyClassDictionary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForPrimitiveClassDictionary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForPrimitiveDictionary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForMemCpyPrimitiveDictionary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_String_T1_ForStringPrimitiveDictionary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_List_1_T2_ForMemCpyClassList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_List_1_T2_ForEnumClassList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForEnumList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForStructList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForMemCpyList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForPrimitiveList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_ValueTuple_2_T1_T2_ForPrimitiveTupleList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_T1_ForPrimitiveHashSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForClassList_0;

	static BufferSerializerExtensions()
	{
		Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "BufferSerializerExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_SerializeNullableString_Public_Static_Void_BufferSerializer_1_T_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663764);
		NativeMethodInfoPtr_SerializeNullableValue_Public_Static_Void_BufferSerializer_1_T_byref_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663765);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForMemCpyClassDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663766);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForPrimitiveClassDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663767);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForPrimitiveDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663768);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForMemCpyPrimitiveDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663769);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_String_T1_ForStringPrimitiveDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663770);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_List_1_T2_ForMemCpyClassList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663771);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_List_1_T2_ForEnumClassList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663772);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForEnumList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663773);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForStructList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663774);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForMemCpyList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663775);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForPrimitiveList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663776);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_ValueTuple_2_T1_T2_ForPrimitiveTupleList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663777);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663778);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663779);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_T1_ForPrimitiveHashSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663780);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663781);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663782);
		NativeMethodInfoPtr_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForClassList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerExtensions>.NativeClassPtr, 100663783);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23138, XrefRangeEnd = 23141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeNullableString<T>(this BufferSerializer<T> serializer, ref string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeNullableString_Public_Static_Void_BufferSerializer_1_T_byref_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		str = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23141, XrefRangeEnd = 23143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeNullableValue<T, T1>(this BufferSerializer<T> serializer, ref T1 value) where T1 : class, new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeNullableValue_Public_Static_Void_BufferSerializer_1_T_byref_T1_0<T, T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr4, false, false));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23143, XrefRangeEnd = 23173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1, T2>(this BufferSerializer<T> serializer, ref Dictionary<T1, T2> dictionary, ForMemCpyClassDictionary unused = default(ForMemCpyClassDictionary)) where T1 : new() where T2 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*(System.IntPtr**)num = &intPtr;
		*(ForMemCpyClassDictionary**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForMemCpyClassDictionary_0<T, T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<T1, T2>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23173, XrefRangeEnd = 23205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1, T2>(this BufferSerializer<T> serializer, ref Dictionary<T1, T2> dictionary, ForPrimitiveClassDictionary unused = default(ForPrimitiveClassDictionary)) where T1 : new() where T2 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*(System.IntPtr**)num = &intPtr;
		*(ForPrimitiveClassDictionary**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForPrimitiveClassDictionary_0<T, T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<T1, T2>(intPtr4));
	}

	[CallerCount(0)]
	public unsafe static void SerializeValue<T, T1, T2>(this BufferSerializer<T> serializer, ref Dictionary<T1, T2> dictionary, ForPrimitiveDictionary unused = default(ForPrimitiveDictionary)) where T1 : new() where T2 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*(System.IntPtr**)num = &intPtr;
		*(ForPrimitiveDictionary**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForPrimitiveDictionary_0<T, T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<T1, T2>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23205, XrefRangeEnd = 23241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1, T2>(this BufferSerializer<T> serializer, ref Dictionary<T1, T2> dictionary, ForMemCpyPrimitiveDictionary unused = default(ForMemCpyPrimitiveDictionary)) where T1 : new() where T2 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*(System.IntPtr**)num = &intPtr;
		*(ForMemCpyPrimitiveDictionary**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_T2_ForMemCpyPrimitiveDictionary_0<T, T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<T1, T2>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23241, XrefRangeEnd = 23281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1>(this BufferSerializer<T> serializer, ref Dictionary<string, T1> dictionary, ForStringPrimitiveDictionary unused = default(ForStringPrimitiveDictionary)) where T1 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*(System.IntPtr**)num = &intPtr;
		*(ForStringPrimitiveDictionary**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_String_T1_ForStringPrimitiveDictionary_0<T, T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<string, T1>(intPtr4));
	}

	[CallerCount(0)]
	public unsafe static void SerializeValue<T, T1, T2>(this BufferSerializer<T> serializer, ref Dictionary<T1, List<T2>> dictionary, ForMemCpyClassList unused = default(ForMemCpyClassList)) where T1 : new() where T2 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*(System.IntPtr**)num = &intPtr;
		*(ForMemCpyClassList**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_List_1_T2_ForMemCpyClassList_0<T, T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<T1, List<T2>>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23281, XrefRangeEnd = 23333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1, T2>(this BufferSerializer<T> serializer, ref Dictionary<T1, List<T2>> dictionary, ForEnumClassList unused = default(ForEnumClassList)) where T1 : System.Enum, new() where T2 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*(System.IntPtr**)num = &intPtr;
		*(ForEnumClassList**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_Dictionary_2_T1_List_1_T2_ForEnumClassList_0<T, T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<T1, List<T2>>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23333, XrefRangeEnd = 23359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1>(this BufferSerializer<T> serializer, ref List<T1> list, ForEnumList unused = default(ForEnumList)) where T1 : System.Enum, new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr**)num = &intPtr;
		*(ForEnumList**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForEnumList_0<T, T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<T1>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23359, XrefRangeEnd = 23384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1>(this BufferSerializer<T> serializer, ref List<T1> list, ForStructList unused = default(ForStructList)) where T1 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr**)num = &intPtr;
		*(ForStructList**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForStructList_0<T, T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<T1>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23384, XrefRangeEnd = 23410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1>(this BufferSerializer<T> serializer, ref List<T1> list, ForMemCpyList unused = default(ForMemCpyList)) where T1 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr**)num = &intPtr;
		*(ForMemCpyList**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForMemCpyList_0<T, T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<T1>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23410, XrefRangeEnd = 23436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1>(this BufferSerializer<T> serializer, ref List<T1> list, ForPrimitiveList unused = default(ForPrimitiveList)) where T1 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr**)num = &intPtr;
		*(ForPrimitiveList**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForPrimitiveList_0<T, T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<T1>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23436, XrefRangeEnd = 23471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1, T2>(this BufferSerializer<T> serializer, ref List<Il2CppSystem.ValueTuple<T1, T2>> list, ForPrimitiveTupleList unused = default(ForPrimitiveTupleList)) where T1 : new() where T2 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr**)num = &intPtr;
		*(ForPrimitiveTupleList**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_ValueTuple_2_T1_T2_ForPrimitiveTupleList_0<T, T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<Il2CppSystem.ValueTuple<T1, T2>>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23471, XrefRangeEnd = 23517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T>(this BufferSerializer<T> serializer, ref List<Vector3> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_Vector3_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<Vector3>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23517, XrefRangeEnd = 23557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T>(this BufferSerializer<T> serializer, ref List<string> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<string>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23557, XrefRangeEnd = 23583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1>(this BufferSerializer<T> serializer, ref HashSet<T1> set, ForPrimitiveHashSet unused = default(ForPrimitiveHashSet)) where T1 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)set);
		*(System.IntPtr**)num = &intPtr;
		*(ForPrimitiveHashSet**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_T1_ForPrimitiveHashSet_0<T, T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		set = ((intPtr4 == (System.IntPtr)0) ? null : new HashSet<T1>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23583, XrefRangeEnd = 23631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T>(this BufferSerializer<T> serializer, ref HashSet<Vector2> set)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)set);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_Vector2_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		set = ((intPtr4 == (System.IntPtr)0) ? null : new HashSet<Vector2>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23631, XrefRangeEnd = 23687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T>(this BufferSerializer<T> serializer, ref HashSet<string> set)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)set);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_HashSet_1_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		set = ((intPtr4 == (System.IntPtr)0) ? null : new HashSet<string>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23687, XrefRangeEnd = 23710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SerializeValue<T, T1>(this BufferSerializer<T> serializer, ref List<T1> list, ForClassList unused = default(ForClassList)) where T1 : class, new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(System.IntPtr**)num = &intPtr;
		*(ForClassList**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Static_Void_BufferSerializer_1_T_byref_List_1_T1_ForClassList_0<T, T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<T1>(intPtr4));
	}

	public BufferSerializerExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

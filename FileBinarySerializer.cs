using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

public sealed class FileBinarySerializer : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_T_ForPrimitives_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForPrimitives_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_String_byref_T_ForPrimitives_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_String_byref_T_ForPrimitives_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_T_ForEnums_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForEnums_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_T_ForFileSerializable_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForFileSerializable_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_T_ForCoordinatesCollection_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForCoordinatesCollection_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_List_1_T_ForStructList_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_List_1_T_ForStructList_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_HashSet_1_T_ForStructHashSet_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_HashSet_1_T_ForStructHashSet_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Il2CppArrayBase_1_T_ForClassArray_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Il2CppArrayBase_1_T_ForClassArray_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_List_1_T_ForClassList_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_List_1_T_ForClassList_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Il2CppArrayBase_1_T_ForPrimitiveArray_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Il2CppArrayBase_1_T_ForPrimitiveArray_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Dictionary_2_T1_T2_ForPrimitiveDictionary_0<T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_T1_T2_ForPrimitiveDictionary_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Dictionary_2_String_T_ForStringPrimitiveDictionary_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_String_T_ForStringPrimitiveDictionary_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Dictionary_2_Coordinates_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_Coordinates_T_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Dictionary_2_T1_T2_ForPrimitiveClassDictionary_0<T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_T1_T2_ForPrimitiveClassDictionary_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Dictionary_2_Coordinates_List_1_T_ForStructClassListDictionary_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_Coordinates_List_1_T_ForStructClassListDictionary_0, Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_reader;

	private static readonly System.IntPtr NativeFieldInfoPtr_writer;

	private static readonly System.IntPtr NativeFieldInfoPtr_protocolVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_isReader;

	private static readonly System.IntPtr NativeFieldInfoPtr_isWriter;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamBinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StreamBinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReader_Public_StreamBinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWriter_Public_StreamBinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForPrimitives_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_String_byref_T_ForPrimitives_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForEnums_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForFileSerializable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForCoordinatesCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_List_1_T_ForStructList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_HashSet_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_HashSet_1_T_ForStructHashSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Il2CppArrayBase_1_T_ForClassArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_List_1_T_ForClassList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Il2CppArrayBase_1_T_ForPrimitiveArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_T1_T2_ForPrimitiveDictionary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_String_T_ForStringPrimitiveDictionary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_Coordinates_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_T1_T2_ForPrimitiveClassDictionary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_Coordinates_List_1_T_ForStructClassListDictionary_0;

	public unsafe StreamBinaryReader reader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StreamBinaryReader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streamBinaryReader));
		}
	}

	public unsafe StreamBinaryWriter writer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StreamBinaryWriter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streamBinaryWriter));
		}
	}

	public unsafe int protocolVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_protocolVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_protocolVersion)) = num;
		}
	}

	public unsafe bool isReader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReader);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReader)) = flag;
		}
	}

	public unsafe bool isWriter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWriter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWriter)) = flag;
		}
	}

	static FileBinarySerializer()
	{
		Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FileBinarySerializer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr);
		NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, "reader");
		NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, "writer");
		NativeFieldInfoPtr_protocolVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, "protocolVersion");
		NativeFieldInfoPtr_isReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, "isReader");
		NativeFieldInfoPtr_isWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, "isWriter");
		NativeMethodInfoPtr__ctor_Public_Void_StreamBinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679341);
		NativeMethodInfoPtr__ctor_Public_Void_StreamBinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679342);
		NativeMethodInfoPtr_GetReader_Public_StreamBinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679343);
		NativeMethodInfoPtr_GetWriter_Public_StreamBinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679344);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679345);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679346);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679347);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679348);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679349);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679350);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForPrimitives_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679351);
		NativeMethodInfoPtr_SerializeValue_Public_Void_String_byref_T_ForPrimitives_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679352);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForEnums_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679353);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForFileSerializable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679354);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679355);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_T_ForCoordinatesCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679356);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_List_1_T_ForStructList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679357);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679358);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_HashSet_1_T_ForStructHashSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679359);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Il2CppArrayBase_1_T_ForClassArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679360);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_List_1_T_ForClassList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679361);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Il2CppArrayBase_1_T_ForPrimitiveArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679362);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_T1_T2_ForPrimitiveDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679363);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_String_T_ForStringPrimitiveDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679364);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_Coordinates_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679365);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_T1_T2_ForPrimitiveClassDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679366);
		NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Dictionary_2_Coordinates_List_1_T_ForStructClassListDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr, 100679367);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 231360, RefRangeEnd = 231362, XrefRangeStart = 231360, XrefRangeEnd = 231362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FileBinarySerializer(StreamBinaryReader reader)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_StreamBinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 231362, RefRangeEnd = 231365, XrefRangeStart = 231362, XrefRangeEnd = 231365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FileBinarySerializer(StreamBinaryWriter writer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_StreamBinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231873, RefRangeEnd = 231874, XrefRangeStart = 231873, XrefRangeEnd = 231873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StreamBinaryReader GetReader()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReader_Public_StreamBinaryReader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StreamBinaryReader>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231874, RefRangeEnd = 231875, XrefRangeStart = 231874, XrefRangeEnd = 231874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StreamBinaryWriter GetWriter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWriter_Public_StreamBinaryWriter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StreamBinaryWriter>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231875, XrefRangeEnd = 231881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue(ref string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		value = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231883, RefRangeEnd = 231884, XrefRangeStart = 231881, XrefRangeEnd = 231883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue(ref Coordinates value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Coordinates_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231884, XrefRangeEnd = 231886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue(ref Vector2 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 231888, RefRangeEnd = 231891, XrefRangeStart = 231886, XrefRangeEnd = 231888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue(ref Vector3 value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231891, XrefRangeEnd = 231893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue(ref Quaternion value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Quaternion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231893, XrefRangeEnd = 231895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue(ref Color value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 231387, RefRangeEnd = 231391, XrefRangeStart = 231387, XrefRangeEnd = 231391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue<T>(ref T value, ForPrimitives unused = default(ForPrimitives)) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		*(ForPrimitives**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_T_ForPrimitives_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	public unsafe void SerializeValue<T>(string fieldName, ref T value, ForPrimitives unused = default(ForPrimitives)) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*(System.IntPtr**)num = &intPtr;
		*(ForPrimitives**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_String_byref_T_ForPrimitives_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	public unsafe void SerializeValue<T>(ref T value, ForEnums unused = default(ForEnums)) where T : System.Enum, new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		*(ForEnums**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_T_ForEnums_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231895, XrefRangeEnd = 231898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue<T>(ref T value, ForFileSerializable unused = default(ForFileSerializable))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		*(ForFileSerializable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_T_ForFileSerializable_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231898, XrefRangeEnd = 231943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue(ref List<string> list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_List_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<string>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231943, XrefRangeEnd = 231982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue<T>(ref T collection, ForCoordinatesCollection unused = default(ForCoordinatesCollection)) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref collection));
		*ptr = (nint)(&intPtr);
		*(ForCoordinatesCollection**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_T_ForCoordinatesCollection_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref collection) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231997, RefRangeEnd = 231998, XrefRangeStart = 231982, XrefRangeEnd = 231997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue<T>(ref List<T> list, ForStructList unused = default(ForStructList)) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*ptr = (nint)(&intPtr);
		*(ForStructList**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_List_1_T_ForStructList_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<T>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231998, XrefRangeEnd = 232043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue(ref HashSet<string> list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Void_byref_HashSet_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new HashSet<string>(intPtr4));
	}

	[CallerCount(0)]
	public unsafe void SerializeValue<T>(ref HashSet<T> list, ForStructHashSet unused = default(ForStructHashSet)) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*ptr = (nint)(&intPtr);
		*(ForStructHashSet**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_HashSet_1_T_ForStructHashSet_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new HashSet<T>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232043, XrefRangeEnd = 232057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue<T>(ref Il2CppArrayBase<T> array, ForClassArray unused = default(ForClassArray)) where T : class, new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(ForClassArray**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Il2CppArrayBase_1_T_ForClassArray_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232057, XrefRangeEnd = 232076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue<T>(ref List<T> list, ForClassList unused = default(ForClassList)) where T : class, new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*ptr = (nint)(&intPtr);
		*(ForClassList**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_List_1_T_ForClassList_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		list = ((intPtr4 == (System.IntPtr)0) ? null : new List<T>(intPtr4));
	}

	[CallerCount(0)]
	public unsafe void SerializeValue<T>(ref Il2CppArrayBase<T> array, ForPrimitiveArray unused = default(ForPrimitiveArray)) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(ForPrimitiveArray**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Il2CppArrayBase_1_T_ForPrimitiveArray_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(0)]
	public unsafe void SerializeValue<T1, T2>(ref Dictionary<T1, T2> dictionary, ForPrimitiveDictionary unused = default(ForPrimitiveDictionary)) where T1 : new() where T2 : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*ptr = (nint)(&intPtr);
		*(ForPrimitiveDictionary**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Dictionary_2_T1_T2_ForPrimitiveDictionary_0<T1, T2>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<T1, T2>(intPtr4));
	}

	[CallerCount(0)]
	public unsafe void SerializeValue<T>(ref Dictionary<string, T> dictionary, ForStringPrimitiveDictionary unused = default(ForStringPrimitiveDictionary)) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*ptr = (nint)(&intPtr);
		*(ForStringPrimitiveDictionary**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Dictionary_2_String_T_ForStringPrimitiveDictionary_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<string, T>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232076, XrefRangeEnd = 232096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue<T>(ref Dictionary<Coordinates, T> dictionary) where T : class, new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Dictionary_2_Coordinates_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<Coordinates, T>(intPtr4));
	}

	[CallerCount(0)]
	public unsafe void SerializeValue<T1, T2>(ref Dictionary<T1, T2> dictionary, ForPrimitiveClassDictionary unused = default(ForPrimitiveClassDictionary)) where T1 : new() where T2 : class, new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*ptr = (nint)(&intPtr);
		*(ForPrimitiveClassDictionary**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Dictionary_2_T1_T2_ForPrimitiveClassDictionary_0<T1, T2>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<T1, T2>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232096, XrefRangeEnd = 232124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeValue<T>(ref Dictionary<Coordinates, List<T>> dictionary, ForStructClassListDictionary unused = default(ForStructClassListDictionary)) where T : class, new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*ptr = (nint)(&intPtr);
		*(ForStructClassListDictionary**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Void_byref_Dictionary_2_Coordinates_List_1_T_ForStructClassListDictionary_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<Coordinates, List<T>>(intPtr4));
	}

	public FileBinarySerializer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FileBinarySerializer()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileBinarySerializer>.NativeClassPtr))
	{
	}
}

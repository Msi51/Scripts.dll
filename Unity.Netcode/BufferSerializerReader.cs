using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Unity.Netcode;

[StructLayout(LayoutKind.Explicit)]
public struct BufferSerializerReader
{
	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForEnums_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForEnums_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForStructs_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForStructs_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForNetworkSerializable_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForNetworkSerializable_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForNetworkSerializable_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForNetworkSerializable_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeNetworkSerializable_Public_Virtual_Final_New_Void_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeNetworkSerializable_Public_Virtual_Final_New_Void_byref_T_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForEnums_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForEnums_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForStructs_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForStructs_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0, Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Reader;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FastBufferReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReader_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsWriter_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFastBufferReader_Public_Virtual_Final_New_FastBufferReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFastBufferWriter_Public_Virtual_Final_New_FastBufferWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForEnums_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForStructs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForNetworkSerializable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForNetworkSerializable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Ray2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeNetworkSerializable_Public_Virtual_Final_New_Void_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreCheck_Public_Virtual_Final_New_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForEnums_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForStructs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Ray2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray2D_0;

	[FieldOffset(0)]
	public FastBufferReader m_Reader;

	public unsafe virtual bool IsReader
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 44231, RefRangeEnd = 44249, XrefRangeStart = 44231, XrefRangeEnd = 44249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsReader_Public_Virtual_Final_New_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe virtual bool IsWriter
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 27783, RefRangeEnd = 27926, XrefRangeStart = 27783, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsWriter_Public_Virtual_Final_New_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BufferSerializerReader()
	{
		Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "BufferSerializerReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr);
		NativeFieldInfoPtr_m_Reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, "m_Reader");
		NativeMethodInfoPtr__ctor_Public_Void_FastBufferReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685778);
		NativeMethodInfoPtr_get_IsReader_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685779);
		NativeMethodInfoPtr_get_IsWriter_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685780);
		NativeMethodInfoPtr_GetFastBufferReader_Public_Virtual_Final_New_FastBufferReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685781);
		NativeMethodInfoPtr_GetFastBufferWriter_Public_Virtual_Final_New_FastBufferWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685782);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685783);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685784);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685785);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685786);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForEnums_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685787);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685788);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForStructs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685789);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685790);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForNetworkSerializable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685791);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForNetworkSerializable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685792);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685793);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685794);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685795);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685796);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685797);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685798);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685799);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685800);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685801);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685802);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685803);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685804);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685805);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685806);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685807);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685808);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685809);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685810);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Ray2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685811);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685812);
		NativeMethodInfoPtr_SerializeNetworkSerializable_Public_Virtual_Final_New_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685813);
		NativeMethodInfoPtr_PreCheck_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685814);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685815);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685816);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685817);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685818);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForEnums_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685819);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685820);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForStructs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685821);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685822);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685823);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685824);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685825);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685826);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685827);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685828);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685829);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685830);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685831);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685832);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685833);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685834);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685835);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685836);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685837);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685838);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685839);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685840);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Ray2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685841);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, 100685842);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 25108, RefRangeEnd = 25117, XrefRangeStart = 25108, XrefRangeEnd = 25117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferSerializerReader(FastBufferReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FastBufferReader_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(91)]
	[CachedScanResults(RefRangeStart = 19321, RefRangeEnd = 19412, XrefRangeStart = 19321, XrefRangeEnd = 19412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual FastBufferReader GetFastBufferReader()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFastBufferReader_Public_Virtual_Final_New_FastBufferReader_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(FastBufferReader*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288477, RefRangeEnd = 288478, XrefRangeStart = 288470, XrefRangeEnd = 288477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual FastBufferWriter GetFastBufferWriter()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFastBufferWriter_Public_Virtual_Final_New_FastBufferWriter_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(FastBufferWriter*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288479, RefRangeEnd = 288480, XrefRangeStart = 288478, XrefRangeEnd = 288479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref string s, bool oneByteChars = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(s);
		*ptr = (nint)(&intPtr);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oneByteChars;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_String_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		s = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 288480, RefRangeEnd = 288486, XrefRangeStart = 288480, XrefRangeEnd = 288480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 288487, RefRangeEnd = 288489, XrefRangeStart = 288486, XrefRangeEnd = 288487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue<T>(ref T value, FastBufferWriter.ForPrimitives unused = default(FastBufferWriter.ForPrimitives)) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForPrimitives**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288496, RefRangeEnd = 288497, XrefRangeStart = 288489, XrefRangeEnd = 288496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue<T>(ref Il2CppArrayBase<T> value, FastBufferWriter.ForPrimitives unused = default(FastBufferWriter.ForPrimitives)) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForPrimitives**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 288498, RefRangeEnd = 288502, XrefRangeStart = 288497, XrefRangeEnd = 288498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue<T>(ref T value, FastBufferWriter.ForEnums unused = default(FastBufferWriter.ForEnums)) where T : System.Enum, new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForEnums**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForEnums_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	public unsafe virtual void SerializeValue<T>(ref Il2CppArrayBase<T> value, FastBufferWriter.ForEnums unused = default(FastBufferWriter.ForEnums)) where T : System.Enum, new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForEnums**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288503, RefRangeEnd = 288504, XrefRangeStart = 288502, XrefRangeEnd = 288503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue<T>(ref T value, FastBufferWriter.ForStructs unused = default(FastBufferWriter.ForStructs)) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForStructs**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForStructs_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	public unsafe virtual void SerializeValue<T>(ref Il2CppArrayBase<T> value, FastBufferWriter.ForStructs unused = default(FastBufferWriter.ForStructs)) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForStructs**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288510, RefRangeEnd = 288511, XrefRangeStart = 288504, XrefRangeEnd = 288510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue<T>(ref T value, FastBufferWriter.ForNetworkSerializable unused = default(FastBufferWriter.ForNetworkSerializable)) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForNetworkSerializable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForNetworkSerializable_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288511, XrefRangeEnd = 288512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue<T>(ref Il2CppArrayBase<T> value, FastBufferWriter.ForNetworkSerializable unused = default(FastBufferWriter.ForNetworkSerializable)) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForNetworkSerializable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForNetworkSerializable_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288514, RefRangeEnd = 288515, XrefRangeStart = 288512, XrefRangeEnd = 288514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288524, RefRangeEnd = 288525, XrefRangeStart = 288515, XrefRangeEnd = 288524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Il2CppStructArray<Vector2> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector2>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288527, RefRangeEnd = 288528, XrefRangeStart = 288525, XrefRangeEnd = 288527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288537, RefRangeEnd = 288538, XrefRangeStart = 288528, XrefRangeEnd = 288537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Il2CppStructArray<Vector3> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector3>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288540, RefRangeEnd = 288541, XrefRangeStart = 288538, XrefRangeEnd = 288540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Vector2Int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector2Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288550, RefRangeEnd = 288551, XrefRangeStart = 288541, XrefRangeEnd = 288550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Il2CppStructArray<Vector2Int> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector2Int>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288553, RefRangeEnd = 288554, XrefRangeStart = 288551, XrefRangeEnd = 288553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Vector3Int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288563, RefRangeEnd = 288564, XrefRangeStart = 288554, XrefRangeEnd = 288563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Il2CppStructArray<Vector3Int> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector3Int>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288566, RefRangeEnd = 288567, XrefRangeStart = 288564, XrefRangeEnd = 288566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Vector4 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288576, RefRangeEnd = 288577, XrefRangeStart = 288567, XrefRangeEnd = 288576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Il2CppStructArray<Vector4> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector4>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288579, RefRangeEnd = 288580, XrefRangeStart = 288577, XrefRangeEnd = 288579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288589, RefRangeEnd = 288590, XrefRangeStart = 288580, XrefRangeEnd = 288589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Il2CppStructArray<Quaternion> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Quaternion>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288592, RefRangeEnd = 288593, XrefRangeStart = 288590, XrefRangeEnd = 288592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Color value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288602, RefRangeEnd = 288603, XrefRangeStart = 288593, XrefRangeEnd = 288602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Il2CppStructArray<Color> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Color>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288605, RefRangeEnd = 288606, XrefRangeStart = 288603, XrefRangeEnd = 288605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Color32 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Color32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288615, RefRangeEnd = 288616, XrefRangeStart = 288606, XrefRangeEnd = 288615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Il2CppStructArray<Color32> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Color32>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288618, RefRangeEnd = 288619, XrefRangeStart = 288616, XrefRangeEnd = 288618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Ray value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Ray_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288628, RefRangeEnd = 288629, XrefRangeStart = 288619, XrefRangeEnd = 288628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Il2CppStructArray<Ray> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Ray>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288631, RefRangeEnd = 288632, XrefRangeStart = 288629, XrefRangeEnd = 288631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Ray2D value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Ray2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288641, RefRangeEnd = 288642, XrefRangeStart = 288632, XrefRangeEnd = 288641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Il2CppStructArray<Ray2D> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Ray2D>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288642, XrefRangeEnd = 288643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeNetworkSerializable<T>(ref T value) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeNetworkSerializable_Public_Virtual_Final_New_Void_byref_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288643, RefRangeEnd = 288644, XrefRangeStart = 288643, XrefRangeEnd = 288643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool PreCheck(int amount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreCheck_Public_Virtual_Final_New_Boolean_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288645, RefRangeEnd = 288646, XrefRangeStart = 288644, XrefRangeEnd = 288645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref string s, bool oneByteChars = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(s);
		*ptr = (nint)(&intPtr);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oneByteChars;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_String_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		s = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288646, RefRangeEnd = 288647, XrefRangeStart = 288646, XrefRangeEnd = 288646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288648, RefRangeEnd = 288649, XrefRangeStart = 288647, XrefRangeEnd = 288648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked<T>(ref T value, FastBufferWriter.ForPrimitives unused = default(FastBufferWriter.ForPrimitives)) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForPrimitives**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	public unsafe virtual void SerializeValuePreChecked<T>(ref Il2CppArrayBase<T> value, FastBufferWriter.ForPrimitives unused = default(FastBufferWriter.ForPrimitives)) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForPrimitives**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(0)]
	public unsafe virtual void SerializeValuePreChecked<T>(ref T value, FastBufferWriter.ForEnums unused = default(FastBufferWriter.ForEnums)) where T : System.Enum, new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForEnums**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForEnums_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	public unsafe virtual void SerializeValuePreChecked<T>(ref Il2CppArrayBase<T> value, FastBufferWriter.ForEnums unused = default(FastBufferWriter.ForEnums)) where T : System.Enum, new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForEnums**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(0)]
	public unsafe virtual void SerializeValuePreChecked<T>(ref T value, FastBufferWriter.ForStructs unused = default(FastBufferWriter.ForStructs)) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref value));
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForStructs**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForStructs_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref value) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	public unsafe virtual void SerializeValuePreChecked<T>(ref Il2CppArrayBase<T> value, FastBufferWriter.ForStructs unused = default(FastBufferWriter.ForStructs)) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		*(FastBufferWriter.ForStructs**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &unused;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<T>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288651, RefRangeEnd = 288652, XrefRangeStart = 288649, XrefRangeEnd = 288651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288660, RefRangeEnd = 288661, XrefRangeStart = 288652, XrefRangeEnd = 288660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Il2CppStructArray<Vector2> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector2>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288663, RefRangeEnd = 288664, XrefRangeStart = 288661, XrefRangeEnd = 288663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288672, RefRangeEnd = 288673, XrefRangeStart = 288664, XrefRangeEnd = 288672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Il2CppStructArray<Vector3> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector3>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288675, RefRangeEnd = 288676, XrefRangeStart = 288673, XrefRangeEnd = 288675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Vector2Int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector2Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288684, RefRangeEnd = 288685, XrefRangeStart = 288676, XrefRangeEnd = 288684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Il2CppStructArray<Vector2Int> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector2Int>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288687, RefRangeEnd = 288688, XrefRangeStart = 288685, XrefRangeEnd = 288687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Vector3Int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288696, RefRangeEnd = 288697, XrefRangeStart = 288688, XrefRangeEnd = 288696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Il2CppStructArray<Vector3Int> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector3Int>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288699, RefRangeEnd = 288700, XrefRangeStart = 288697, XrefRangeEnd = 288699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Vector4 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288708, RefRangeEnd = 288709, XrefRangeStart = 288700, XrefRangeEnd = 288708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Il2CppStructArray<Vector4> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Vector4>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288711, RefRangeEnd = 288712, XrefRangeStart = 288709, XrefRangeEnd = 288711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288720, RefRangeEnd = 288721, XrefRangeStart = 288712, XrefRangeEnd = 288720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Il2CppStructArray<Quaternion> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Quaternion>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288723, RefRangeEnd = 288724, XrefRangeStart = 288721, XrefRangeEnd = 288723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Color value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288732, RefRangeEnd = 288733, XrefRangeStart = 288724, XrefRangeEnd = 288732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Il2CppStructArray<Color> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Color>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288735, RefRangeEnd = 288736, XrefRangeStart = 288733, XrefRangeEnd = 288735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Color32 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Color32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288744, RefRangeEnd = 288745, XrefRangeStart = 288736, XrefRangeEnd = 288744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Il2CppStructArray<Color32> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Color32>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288747, RefRangeEnd = 288748, XrefRangeStart = 288745, XrefRangeEnd = 288747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Ray value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Ray_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288756, RefRangeEnd = 288757, XrefRangeStart = 288748, XrefRangeEnd = 288756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Il2CppStructArray<Ray> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Ray>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288759, RefRangeEnd = 288760, XrefRangeStart = 288757, XrefRangeEnd = 288759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Ray2D value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Ray2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288768, RefRangeEnd = 288769, XrefRangeStart = 288760, XrefRangeEnd = 288768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Il2CppStructArray<Ray2D> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		value = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<Ray2D>(intPtr4));
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BufferSerializerReader>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

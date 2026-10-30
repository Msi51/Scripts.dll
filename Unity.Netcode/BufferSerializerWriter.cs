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
public struct BufferSerializerWriter
{
	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForEnums_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForEnums_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForStructs_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForStructs_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForNetworkSerializable_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForNetworkSerializable_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForNetworkSerializable_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForNetworkSerializable_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeNetworkSerializable_Public_Virtual_Final_New_Void_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeNetworkSerializable_Public_Virtual_Final_New_Void_byref_T_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForEnums_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForEnums_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForStructs_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForStructs_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0, Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Writer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FastBufferWriter_0;

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
	public FastBufferWriter m_Writer;

	public unsafe virtual bool IsReader
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 27783, RefRangeEnd = 27926, XrefRangeStart = 27783, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 44231, RefRangeEnd = 44249, XrefRangeStart = 44231, XrefRangeEnd = 44249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsWriter_Public_Virtual_Final_New_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BufferSerializerWriter()
	{
		Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "BufferSerializerWriter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr);
		NativeFieldInfoPtr_m_Writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, "m_Writer");
		NativeMethodInfoPtr__ctor_Public_Void_FastBufferWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685843);
		NativeMethodInfoPtr_get_IsReader_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685844);
		NativeMethodInfoPtr_get_IsWriter_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685845);
		NativeMethodInfoPtr_GetFastBufferReader_Public_Virtual_Final_New_FastBufferReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685846);
		NativeMethodInfoPtr_GetFastBufferWriter_Public_Virtual_Final_New_FastBufferWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685847);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685848);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685849);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685850);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685851);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForEnums_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685852);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685853);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForStructs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685854);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685855);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_T_ForNetworkSerializable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685856);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForNetworkSerializable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685857);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685858);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685859);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685860);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685861);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685862);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685863);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685864);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685865);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685866);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685867);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685868);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685869);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685870);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685871);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685872);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685873);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685874);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685875);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Ray2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685876);
		NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685877);
		NativeMethodInfoPtr_SerializeNetworkSerializable_Public_Virtual_Final_New_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685878);
		NativeMethodInfoPtr_PreCheck_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685879);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685880);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685881);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForPrimitives_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685882);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForPrimitives_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685883);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForEnums_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685884);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForEnums_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685885);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_T_ForStructs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685886);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppArrayBase_1_T_ForStructs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685887);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685888);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685889);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685890);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685891);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685892);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685893);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685894);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685895);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685896);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685897);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685898);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685899);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685900);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685901);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685902);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685903);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685904);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685905);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Ray2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685906);
		NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Il2CppStructArray_1_Ray2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, 100685907);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 25108, RefRangeEnd = 25117, XrefRangeStart = 25108, XrefRangeEnd = 25117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferSerializerWriter(FastBufferWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FastBufferWriter_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288776, RefRangeEnd = 288777, XrefRangeStart = 288769, XrefRangeEnd = 288776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual FastBufferReader GetFastBufferReader()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFastBufferReader_Public_Virtual_Final_New_FastBufferReader_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(FastBufferReader*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(91)]
	[CachedScanResults(RefRangeStart = 19321, RefRangeEnd = 19412, XrefRangeStart = 19321, XrefRangeEnd = 19412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual FastBufferWriter GetFastBufferWriter()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFastBufferWriter_Public_Virtual_Final_New_FastBufferWriter_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(FastBufferWriter*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288781, RefRangeEnd = 288782, XrefRangeStart = 288777, XrefRangeEnd = 288781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288786, RefRangeEnd = 288787, XrefRangeStart = 288782, XrefRangeEnd = 288786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288791, RefRangeEnd = 288792, XrefRangeStart = 288787, XrefRangeEnd = 288791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 288810, RefRangeEnd = 288811, XrefRangeStart = 288792, XrefRangeEnd = 288810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288990, RefRangeEnd = 288991, XrefRangeStart = 288811, XrefRangeEnd = 288990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288991, XrefRangeEnd = 288995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289041, RefRangeEnd = 289042, XrefRangeStart = 288995, XrefRangeEnd = 289041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289042, XrefRangeEnd = 289049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289060, RefRangeEnd = 289061, XrefRangeStart = 289049, XrefRangeEnd = 289060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289080, RefRangeEnd = 289081, XrefRangeStart = 289061, XrefRangeEnd = 289080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289092, RefRangeEnd = 289093, XrefRangeStart = 289081, XrefRangeEnd = 289092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289112, RefRangeEnd = 289113, XrefRangeStart = 289093, XrefRangeEnd = 289112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289124, RefRangeEnd = 289125, XrefRangeStart = 289113, XrefRangeEnd = 289124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Vector2Int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector2Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289144, RefRangeEnd = 289145, XrefRangeStart = 289125, XrefRangeEnd = 289144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289156, RefRangeEnd = 289157, XrefRangeStart = 289145, XrefRangeEnd = 289156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Vector3Int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289157, XrefRangeEnd = 289176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289187, RefRangeEnd = 289188, XrefRangeStart = 289176, XrefRangeEnd = 289187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Vector4 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289207, RefRangeEnd = 289208, XrefRangeStart = 289188, XrefRangeEnd = 289207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289219, RefRangeEnd = 289220, XrefRangeStart = 289208, XrefRangeEnd = 289219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289239, RefRangeEnd = 289240, XrefRangeStart = 289220, XrefRangeEnd = 289239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289240, XrefRangeEnd = 289251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Color value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289270, RefRangeEnd = 289271, XrefRangeStart = 289251, XrefRangeEnd = 289270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289282, RefRangeEnd = 289283, XrefRangeStart = 289271, XrefRangeEnd = 289282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Color32 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Color32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289302, RefRangeEnd = 289303, XrefRangeStart = 289283, XrefRangeEnd = 289302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289314, RefRangeEnd = 289315, XrefRangeStart = 289303, XrefRangeEnd = 289314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Ray value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Ray_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289334, RefRangeEnd = 289335, XrefRangeStart = 289315, XrefRangeEnd = 289334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289346, RefRangeEnd = 289347, XrefRangeStart = 289335, XrefRangeEnd = 289346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValue(ref Ray2D value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValue_Public_Virtual_Final_New_Void_byref_Ray2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289366, RefRangeEnd = 289367, XrefRangeStart = 289347, XrefRangeEnd = 289366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289367, XrefRangeEnd = 289371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289375, RefRangeEnd = 289376, XrefRangeStart = 289371, XrefRangeEnd = 289375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289380, RefRangeEnd = 289381, XrefRangeStart = 289376, XrefRangeEnd = 289380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289384, RefRangeEnd = 289385, XrefRangeStart = 289381, XrefRangeEnd = 289384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289385, XrefRangeEnd = 289395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289406, RefRangeEnd = 289407, XrefRangeStart = 289395, XrefRangeEnd = 289406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289426, RefRangeEnd = 289427, XrefRangeStart = 289407, XrefRangeEnd = 289426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289438, RefRangeEnd = 289439, XrefRangeStart = 289427, XrefRangeEnd = 289438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289458, RefRangeEnd = 289459, XrefRangeStart = 289439, XrefRangeEnd = 289458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289470, RefRangeEnd = 289471, XrefRangeStart = 289459, XrefRangeEnd = 289470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Vector2Int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector2Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289490, RefRangeEnd = 289491, XrefRangeStart = 289471, XrefRangeEnd = 289490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289502, RefRangeEnd = 289503, XrefRangeStart = 289491, XrefRangeEnd = 289502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Vector3Int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289522, RefRangeEnd = 289523, XrefRangeStart = 289503, XrefRangeEnd = 289522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289534, RefRangeEnd = 289535, XrefRangeStart = 289523, XrefRangeEnd = 289534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Vector4 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289554, RefRangeEnd = 289555, XrefRangeStart = 289535, XrefRangeEnd = 289554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289566, RefRangeEnd = 289567, XrefRangeStart = 289555, XrefRangeEnd = 289566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289586, RefRangeEnd = 289587, XrefRangeStart = 289567, XrefRangeEnd = 289586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289598, RefRangeEnd = 289599, XrefRangeStart = 289587, XrefRangeEnd = 289598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Color value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289618, RefRangeEnd = 289619, XrefRangeStart = 289599, XrefRangeEnd = 289618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289630, RefRangeEnd = 289631, XrefRangeStart = 289619, XrefRangeEnd = 289630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Color32 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Color32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289650, RefRangeEnd = 289651, XrefRangeStart = 289631, XrefRangeEnd = 289650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289662, RefRangeEnd = 289663, XrefRangeStart = 289651, XrefRangeEnd = 289662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Ray value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Ray_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289682, RefRangeEnd = 289683, XrefRangeStart = 289663, XrefRangeEnd = 289682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 289694, RefRangeEnd = 289695, XrefRangeStart = 289683, XrefRangeEnd = 289694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SerializeValuePreChecked(ref Ray2D value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeValuePreChecked_Public_Virtual_Final_New_Void_byref_Ray2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289714, RefRangeEnd = 289715, XrefRangeStart = 289695, XrefRangeEnd = 289714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BufferSerializerWriter>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

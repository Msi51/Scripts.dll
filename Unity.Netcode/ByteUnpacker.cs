using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Unity.Netcode;

public static class ByteUnpacker : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_TEnum_0<TEnum>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_TEnum_0, Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ToSingle_Private_Static_Single_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ToSingle_Private_Static_Single_T_0, Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ToDouble_Private_Static_Double_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ToDouble_Private_Static_Double_T_0, Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_TEnum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Ray2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Private_Static_Single_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Private_Static_Double_T_0;

	static ByteUnpacker()
	{
		Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "ByteUnpacker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685938);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685939);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685940);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685941);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685942);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685943);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685944);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685945);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685946);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685947);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685948);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685949);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685950);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685951);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Ray2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685952);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685953);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685954);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685955);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685956);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685957);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685958);
		NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685959);
		NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685960);
		NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685961);
		NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685962);
		NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685963);
		NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685964);
		NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685965);
		NativeMethodInfoPtr_ToSingle_Private_Static_Single_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685966);
		NativeMethodInfoPtr_ToDouble_Private_Static_Double_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUnpacker>.NativeClassPtr, 100685967);
	}

	[CallerCount(0)]
	public unsafe static void ReadValuePacked<TEnum>(FastBufferReader reader, out TEnum value) where TEnum : System.Enum, new()
	{
		//IL_0033->IL0035: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref TEnum reference;
		if (!typeof(TEnum).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_TEnum_0<TEnum>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		if (!typeof(TEnum).IsValueType)
		{
			nint num3 = num2;
			Unsafe.As<TEnum, object>(ref value) = ((num3 == 0) ? ((TEnum)null) : IL2CPP.PointerToValueGeneric<TEnum>((System.IntPtr)num3, false, false));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289875, XrefRangeEnd = 289877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289877, XrefRangeEnd = 289879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289879, XrefRangeEnd = 289880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289880, XrefRangeEnd = 289882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289882, XrefRangeEnd = 289884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289884, XrefRangeEnd = 289885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289885, XrefRangeEnd = 289886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289886, XrefRangeEnd = 289888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289888, XrefRangeEnd = 289889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289889, XrefRangeEnd = 289890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289890, XrefRangeEnd = 289892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289892, XrefRangeEnd = 289895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out Ray ray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ray);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Ray_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289895, XrefRangeEnd = 289904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out Ray2D ray2d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ray2d);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Ray2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289904, XrefRangeEnd = 289912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289912, XrefRangeEnd = 289916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out Color32 color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289916, XrefRangeEnd = 289920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out Vector2 vector2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref vector2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 289926, RefRangeEnd = 289928, XrefRangeStart = 289920, XrefRangeEnd = 289926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out Vector3 vector3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref vector3);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out Vector4 vector4)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref vector4);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289928, XrefRangeEnd = 289935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValuePacked(FastBufferReader reader, out string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValuePacked_Public_Static_Void_FastBufferReader_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		s = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValueBitPacked(FastBufferReader reader, out short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 289935, RefRangeEnd = 289940, XrefRangeStart = 289935, XrefRangeEnd = 289935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValueBitPacked(FastBufferReader reader, out ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValueBitPacked(FastBufferReader reader, out int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 289940, RefRangeEnd = 289966, XrefRangeStart = 289940, XrefRangeEnd = 289940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValueBitPacked(FastBufferReader reader, out uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValueBitPacked(FastBufferReader reader, out long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 289966, RefRangeEnd = 289970, XrefRangeStart = 289966, XrefRangeEnd = 289966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadValueBitPacked(FastBufferReader reader, out ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadValueBitPacked_Public_Static_Void_FastBufferReader_byref_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float ToSingle<T>(T value) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ToSingle_Private_Static_Single_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static double ToDouble<T>(T value) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ToDouble_Private_Static_Double_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ByteUnpacker(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

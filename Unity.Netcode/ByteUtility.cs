using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Unity.Netcode;

public class ByteUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Internal_Static_Byte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_Byte_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_Byte_UInt16_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_UInt16_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_UInt16_UInt16_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_UInt32_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_UInt32_UInt16_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_UInt64_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_UInt64_UInt16_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ByteUtility()
	{
		Il2CppClassPointerStore<ByteUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "ByteUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr);
		NativeMethodInfoPtr_ToByte_Internal_Static_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr, 100685968);
		NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_Byte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr, 100685969);
		NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_Byte_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr, 100685970);
		NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr, 100685971);
		NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_UInt16_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr, 100685972);
		NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr, 100685973);
		NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_UInt32_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr, 100685974);
		NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_UInt64_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr, 100685975);
		NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_UInt64_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr, 100685976);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr, 100685977);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 289970, RefRangeEnd = 289971, XrefRangeStart = 289970, XrefRangeEnd = 289970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(bool b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Internal_Static_Byte_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool GetBit(byte bitField, ushort bitPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bitField);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_Byte_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetBit(ref byte bitField, ushort bitPosition, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref bitField);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitPosition;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_Byte_UInt16_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool GetBit(ushort bitField, ushort bitPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bitField);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_UInt16_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetBit(ref ushort bitField, ushort bitPosition, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref bitField);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitPosition;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_UInt16_UInt16_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool GetBit(uint bitField, ushort bitPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bitField);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_UInt32_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetBit(ref uint bitField, ushort bitPosition, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref bitField);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitPosition;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_UInt32_UInt16_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool GetBit(ulong bitField, ushort bitPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&bitField);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBit_Internal_Static_Boolean_UInt64_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetBit(ref ulong bitField, ushort bitPosition, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref bitField);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitPosition;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBit_Internal_Static_Void_byref_UInt64_UInt16_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ByteUtility()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteUtility>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ByteUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

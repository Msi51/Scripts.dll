using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Netcode;

[StructLayout(LayoutKind.Explicit)]
public struct BitReader
{
	private sealed class MethodInfoStoreGeneric_ReadPartialValue_Private_Void_byref_T_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadPartialValue_Private_Void_byref_T_Int32_Int32_0, Il2CppClassPointerStore<BitReader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Reader;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferPointer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BitPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_BitsPerByte;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BytePosition_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BitAligned_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FastBufferReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryBeginReadBits_Public_Boolean_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadBits_Public_Void_byref_UInt64_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadBits_Public_Void_byref_Byte_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadBit_Public_Void_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPartialValue_Private_Void_byref_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadByteBits_Private_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadMisaligned_Private_Void_byref_Byte_0;

	[FieldOffset(0)]
	public FastBufferReader m_Reader;

	[FieldOffset(8)]
	public readonly System.IntPtr m_BufferPointer;

	[FieldOffset(16)]
	public readonly int m_Position;

	[FieldOffset(20)]
	public int m_BitPosition;

	public unsafe static int k_BitsPerByte
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_BitsPerByte, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_BitsPerByte, (void*)(&num));
		}
	}

	public unsafe int BytePosition
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286736, RefRangeEnd = 286738, XrefRangeStart = 286736, XrefRangeEnd = 286736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BytePosition_Private_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool BitAligned
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BitAligned_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BitReader()
	{
		Il2CppClassPointerStore<BitReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "BitReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitReader>.NativeClassPtr);
		NativeFieldInfoPtr_m_Reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitReader>.NativeClassPtr, "m_Reader");
		NativeFieldInfoPtr_m_BufferPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitReader>.NativeClassPtr, "m_BufferPointer");
		NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitReader>.NativeClassPtr, "m_Position");
		NativeFieldInfoPtr_m_BitPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitReader>.NativeClassPtr, "m_BitPosition");
		NativeFieldInfoPtr_k_BitsPerByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitReader>.NativeClassPtr, "k_BitsPerByte");
		NativeMethodInfoPtr_get_BytePosition_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685692);
		NativeMethodInfoPtr_get_BitAligned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685693);
		NativeMethodInfoPtr__ctor_Internal_Void_FastBufferReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685694);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685695);
		NativeMethodInfoPtr_TryBeginReadBits_Public_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685696);
		NativeMethodInfoPtr_ReadBits_Public_Void_byref_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685697);
		NativeMethodInfoPtr_ReadBits_Public_Void_byref_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685698);
		NativeMethodInfoPtr_ReadBit_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685699);
		NativeMethodInfoPtr_ReadPartialValue_Private_Void_byref_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685700);
		NativeMethodInfoPtr_ReadByteBits_Private_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685701);
		NativeMethodInfoPtr_ReadMisaligned_Private_Void_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitReader>.NativeClassPtr, 100685702);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 286738, RefRangeEnd = 286740, XrefRangeStart = 286738, XrefRangeEnd = 286738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BitReader(FastBufferReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_FastBufferReader_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void Dispose()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool TryBeginReadBits(uint bitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bitCount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryBeginReadBits_Public_Boolean_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286740, XrefRangeEnd = 286745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadBits(out ulong value, uint bitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadBits_Public_Void_byref_UInt64_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286745, XrefRangeEnd = 286746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadBits(out byte value, uint bitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadBits_Public_Void_byref_Byte_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ReadBit(out bool bit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref bit);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadBit_Public_Void_byref_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286746, XrefRangeEnd = 286748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadPartialValue<T>(out T value, int bytesToRead, int offsetBytes = 0) where T : new()
	{
		//IL_0025->IL0027: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		Unsafe.SkipInit(out nint num);
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			num = 0;
			reference = ref *(_003F*)(&num);
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bytesToRead;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetBytes;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadPartialValue_Private_Void_byref_T_Int32_Int32_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		if (!typeof(T).IsValueType)
		{
			nint num2 = num;
			Unsafe.As<T, object>(ref value) = ((num2 == 0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>((System.IntPtr)num2, false, false));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 286749, RefRangeEnd = 286751, XrefRangeStart = 286748, XrefRangeEnd = 286749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe byte ReadByteBits(int bitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bitCount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadByteBits_Private_Byte_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ReadMisaligned(out byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadMisaligned_Private_Void_byref_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitReader>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

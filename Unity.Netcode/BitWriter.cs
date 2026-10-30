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
public struct BitWriter
{
	private sealed class MethodInfoStoreGeneric_WritePartialValue_Private_Void_T_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WritePartialValue_Private_Void_T_Int32_Int32_0, Il2CppClassPointerStore<BitWriter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Writer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferPointer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BitPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_BitsPerByte;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BitAligned_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BytePosition_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FastBufferWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryBeginWriteBits_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteBits_Public_Void_UInt64_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteBits_Public_Void_Byte_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteBit_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WritePartialValue_Private_Void_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteMisaligned_Private_Void_Byte_0;

	[FieldOffset(0)]
	public FastBufferWriter m_Writer;

	[FieldOffset(8)]
	public System.IntPtr m_BufferPointer;

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

	public unsafe int BytePosition
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286736, RefRangeEnd = 286738, XrefRangeStart = 286736, XrefRangeEnd = 286738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BytePosition_Private_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static BitWriter()
	{
		Il2CppClassPointerStore<BitWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "BitWriter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitWriter>.NativeClassPtr);
		NativeFieldInfoPtr_m_Writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, "m_Writer");
		NativeFieldInfoPtr_m_BufferPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, "m_BufferPointer");
		NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, "m_Position");
		NativeFieldInfoPtr_m_BitPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, "m_BitPosition");
		NativeFieldInfoPtr_k_BitsPerByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, "k_BitsPerByte");
		NativeMethodInfoPtr_get_BitAligned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, 100685703);
		NativeMethodInfoPtr_get_BytePosition_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, 100685704);
		NativeMethodInfoPtr__ctor_Internal_Void_FastBufferWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, 100685705);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, 100685706);
		NativeMethodInfoPtr_TryBeginWriteBits_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, 100685707);
		NativeMethodInfoPtr_WriteBits_Public_Void_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, 100685708);
		NativeMethodInfoPtr_WriteBits_Public_Void_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, 100685709);
		NativeMethodInfoPtr_WriteBit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, 100685710);
		NativeMethodInfoPtr_WritePartialValue_Private_Void_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, 100685711);
		NativeMethodInfoPtr_WriteMisaligned_Private_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, 100685712);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 286738, RefRangeEnd = 286740, XrefRangeStart = 286738, XrefRangeEnd = 286740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BitWriter(FastBufferWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_FastBufferWriter_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286751, XrefRangeEnd = 286754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286754, XrefRangeEnd = 286758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryBeginWriteBits(int bitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bitCount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryBeginWriteBits_Public_Boolean_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286758, XrefRangeEnd = 286761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteBits(ulong value, uint bitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteBits_Public_Void_UInt64_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286761, XrefRangeEnd = 286762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteBits(byte value, uint bitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bitCount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteBits_Public_Void_Byte_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void WriteBit(bool bit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bit);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteBit_Public_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286762, XrefRangeEnd = 286764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WritePartialValue<T>(T value, int bytesToWrite, int offsetBytes = 0) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
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
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bytesToWrite;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetBytes;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WritePartialValue_Private_Void_T_Int32_Int32_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void WriteMisaligned(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteMisaligned_Private_Void_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitWriter>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

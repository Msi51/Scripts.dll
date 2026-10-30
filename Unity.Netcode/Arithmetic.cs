using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Netcode;

public static class Arithmetic : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SIGN_BIT_64;

	private static readonly System.IntPtr NativeFieldInfoPtr_SIGN_BIT_32;

	private static readonly System.IntPtr NativeFieldInfoPtr_SIGN_BIT_16;

	private static readonly System.IntPtr NativeFieldInfoPtr_SIGN_BIT_8;

	private static readonly System.IntPtr NativeMethodInfoPtr_CeilingExact_Internal_Static_UInt64_UInt64_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CeilingExact_Internal_Static_Int64_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CeilingExact_Internal_Static_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CeilingExact_Internal_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CeilingExact_Internal_Static_UInt16_UInt16_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CeilingExact_Internal_Static_Int16_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CeilingExact_Internal_Static_Byte_Byte_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CeilingExact_Internal_Static_SByte_SByte_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ZigZagEncode_Public_Static_UInt64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ZigZagDecode_Public_Static_Int64_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VarIntSize_Public_Static_Int32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Div8Ceil_Internal_Static_Int64_UInt64_0;

	public unsafe static long SIGN_BIT_64
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SIGN_BIT_64, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SIGN_BIT_64, (void*)(&num));
		}
	}

	public unsafe static int SIGN_BIT_32
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SIGN_BIT_32, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SIGN_BIT_32, (void*)(&num));
		}
	}

	public unsafe static short SIGN_BIT_16
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SIGN_BIT_16, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SIGN_BIT_16, (void*)(&num));
		}
	}

	public unsafe static sbyte SIGN_BIT_8
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SIGN_BIT_8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SIGN_BIT_8, (void*)(&b));
		}
	}

	static Arithmetic()
	{
		Il2CppClassPointerStore<Arithmetic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "Arithmetic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr);
		NativeFieldInfoPtr_SIGN_BIT_64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, "SIGN_BIT_64");
		NativeFieldInfoPtr_SIGN_BIT_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, "SIGN_BIT_32");
		NativeFieldInfoPtr_SIGN_BIT_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, "SIGN_BIT_16");
		NativeFieldInfoPtr_SIGN_BIT_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, "SIGN_BIT_8");
		NativeMethodInfoPtr_CeilingExact_Internal_Static_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685675);
		NativeMethodInfoPtr_CeilingExact_Internal_Static_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685676);
		NativeMethodInfoPtr_CeilingExact_Internal_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685677);
		NativeMethodInfoPtr_CeilingExact_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685678);
		NativeMethodInfoPtr_CeilingExact_Internal_Static_UInt16_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685679);
		NativeMethodInfoPtr_CeilingExact_Internal_Static_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685680);
		NativeMethodInfoPtr_CeilingExact_Internal_Static_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685681);
		NativeMethodInfoPtr_CeilingExact_Internal_Static_SByte_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685682);
		NativeMethodInfoPtr_ZigZagEncode_Public_Static_UInt64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685683);
		NativeMethodInfoPtr_ZigZagDecode_Public_Static_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685684);
		NativeMethodInfoPtr_VarIntSize_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685685);
		NativeMethodInfoPtr_Div8Ceil_Internal_Static_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arithmetic>.NativeClassPtr, 100685686);
	}

	[CallerCount(0)]
	public unsafe static ulong CeilingExact(ulong u1, ulong u2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u1);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CeilingExact_Internal_Static_UInt64_UInt64_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static long CeilingExact(long u1, long u2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u1);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CeilingExact_Internal_Static_Int64_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static uint CeilingExact(uint u1, uint u2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u1);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CeilingExact_Internal_Static_UInt32_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int CeilingExact(int u1, int u2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CeilingExact_Internal_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static ushort CeilingExact(ushort u1, ushort u2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u1);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CeilingExact_Internal_Static_UInt16_UInt16_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static short CeilingExact(short u1, short u2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u1);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CeilingExact_Internal_Static_Int16_Int16_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static byte CeilingExact(byte u1, byte u2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u1);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CeilingExact_Internal_Static_Byte_Byte_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static sbyte CeilingExact(sbyte u1, sbyte u2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&u1);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &u2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CeilingExact_Internal_Static_SByte_SByte_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static ulong ZigZagEncode(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ZigZagEncode_Public_Static_UInt64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 286712, RefRangeEnd = 286718, XrefRangeStart = 286712, XrefRangeEnd = 286712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ZigZagDecode(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ZigZagDecode_Public_Static_Int64_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int VarIntSize(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VarIntSize_Public_Static_Int32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static long Div8Ceil(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Div8Ceil_Internal_Static_Int64_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Arithmetic(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

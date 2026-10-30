using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Netcode;

public static class BitCounter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_k_DeBruijnMagic64;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DeBruijnMagic32;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DeBruijnTableBytes64;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DeBruijnTableBytes32;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DeBruijnTableBits64;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DeBruijnTableBits32;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUsedByteCount_Public_Static_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUsedByteCount_Public_Static_Int32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUsedBitCount_Public_Static_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUsedBitCount_Public_Static_Int32_UInt64_0;

	public unsafe static ulong k_DeBruijnMagic64
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DeBruijnMagic64, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DeBruijnMagic64, (void*)(&num));
		}
	}

	public unsafe static uint k_DeBruijnMagic32
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DeBruijnMagic32, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DeBruijnMagic32, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> k_DeBruijnTableBytes64
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DeBruijnTableBytes64, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DeBruijnTableBytes64, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> k_DeBruijnTableBytes32
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DeBruijnTableBytes32, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DeBruijnTableBytes32, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> k_DeBruijnTableBits64
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DeBruijnTableBits64, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DeBruijnTableBits64, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> k_DeBruijnTableBits32
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DeBruijnTableBits32, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DeBruijnTableBits32, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static BitCounter()
	{
		Il2CppClassPointerStore<BitCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "BitCounter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitCounter>.NativeClassPtr);
		NativeFieldInfoPtr_k_DeBruijnMagic64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitCounter>.NativeClassPtr, "k_DeBruijnMagic64");
		NativeFieldInfoPtr_k_DeBruijnMagic32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitCounter>.NativeClassPtr, "k_DeBruijnMagic32");
		NativeFieldInfoPtr_k_DeBruijnTableBytes64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitCounter>.NativeClassPtr, "k_DeBruijnTableBytes64");
		NativeFieldInfoPtr_k_DeBruijnTableBytes32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitCounter>.NativeClassPtr, "k_DeBruijnTableBytes32");
		NativeFieldInfoPtr_k_DeBruijnTableBits64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitCounter>.NativeClassPtr, "k_DeBruijnTableBits64");
		NativeFieldInfoPtr_k_DeBruijnTableBits32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitCounter>.NativeClassPtr, "k_DeBruijnTableBits32");
		NativeMethodInfoPtr_GetUsedByteCount_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCounter>.NativeClassPtr, 100685687);
		NativeMethodInfoPtr_GetUsedByteCount_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCounter>.NativeClassPtr, 100685688);
		NativeMethodInfoPtr_GetUsedBitCount_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCounter>.NativeClassPtr, 100685689);
		NativeMethodInfoPtr_GetUsedBitCount_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitCounter>.NativeClassPtr, 100685690);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286718, XrefRangeEnd = 286722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetUsedByteCount(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUsedByteCount_Public_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286722, XrefRangeEnd = 286727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetUsedByteCount(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUsedByteCount_Public_Static_Int32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286727, XrefRangeEnd = 286731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetUsedBitCount(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUsedBitCount_Public_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286731, XrefRangeEnd = 286736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetUsedBitCount(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUsedBitCount_Public_Static_Int32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public BitCounter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

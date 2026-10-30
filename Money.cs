using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct Money
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PENNIES_PER_GROAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_GROATS_PER_FLORIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_PENNIES_PER_FLORIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_penniesSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_groatSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_florinSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_penniesShort;

	private static readonly System.IntPtr NativeFieldInfoPtr_groatShort;

	private static readonly System.IntPtr NativeFieldInfoPtr_florinShort;

	private static readonly System.IntPtr NativeFieldInfoPtr_florins;

	private static readonly System.IntPtr NativeFieldInfoPtr_groats;

	private static readonly System.IntPtr NativeFieldInfoPtr_pennies;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalPennies_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayString_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Normalized_Public_Money_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromPennies_Public_Static_Money_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Money_Money_Money_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Money_Money_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Money_Money_Single_0;

	[FieldOffset(0)]
	public int florins;

	[FieldOffset(4)]
	public int groats;

	[FieldOffset(8)]
	public int pennies;

	public unsafe static int PENNIES_PER_GROAT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PENNIES_PER_GROAT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PENNIES_PER_GROAT, (void*)(&num));
		}
	}

	public unsafe static int GROATS_PER_FLORIN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GROATS_PER_FLORIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GROATS_PER_FLORIN, (void*)(&num));
		}
	}

	public unsafe static int PENNIES_PER_FLORIN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PENNIES_PER_FLORIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PENNIES_PER_FLORIN, (void*)(&num));
		}
	}

	public unsafe static string penniesSprite
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_penniesSprite, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_penniesSprite, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string groatSprite
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_groatSprite, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_groatSprite, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string florinSprite
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_florinSprite, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_florinSprite, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string penniesShort
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_penniesShort, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_penniesShort, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string groatShort
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_groatShort, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_groatShort, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string florinShort
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_florinShort, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_florinShort, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int TotalPennies
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 234710, RefRangeEnd = 234717, XrefRangeStart = 234710, XrefRangeEnd = 234710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TotalPennies_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe string DisplayString
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 234721, RefRangeEnd = 234727, XrefRangeStart = 234717, XrefRangeEnd = 234721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DisplayString_Public_get_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static Money()
	{
		Il2CppClassPointerStore<Money>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "Money");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Money>.NativeClassPtr);
		NativeFieldInfoPtr_PENNIES_PER_GROAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "PENNIES_PER_GROAT");
		NativeFieldInfoPtr_GROATS_PER_FLORIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "GROATS_PER_FLORIN");
		NativeFieldInfoPtr_PENNIES_PER_FLORIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "PENNIES_PER_FLORIN");
		NativeFieldInfoPtr_penniesSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "penniesSprite");
		NativeFieldInfoPtr_groatSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "groatSprite");
		NativeFieldInfoPtr_florinSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "florinSprite");
		NativeFieldInfoPtr_penniesShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "penniesShort");
		NativeFieldInfoPtr_groatShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "groatShort");
		NativeFieldInfoPtr_florinShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "florinShort");
		NativeFieldInfoPtr_florins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "florins");
		NativeFieldInfoPtr_groats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "groats");
		NativeFieldInfoPtr_pennies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Money>.NativeClassPtr, "pennies");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679838);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679839);
		NativeMethodInfoPtr_get_TotalPennies_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679840);
		NativeMethodInfoPtr_get_DisplayString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679841);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679842);
		NativeMethodInfoPtr_ToString_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679843);
		NativeMethodInfoPtr_Normalized_Public_Money_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679844);
		NativeMethodInfoPtr_FromPennies_Public_Static_Money_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679845);
		NativeMethodInfoPtr_op_Addition_Public_Static_Money_Money_Money_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679846);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Money_Money_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679847);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Money_Money_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Money>.NativeClassPtr, 100679848);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234700, RefRangeEnd = 234701, XrefRangeStart = 234700, XrefRangeEnd = 234700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Money(int florins, int groats, int pennies)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&florins);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &groats;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pennies;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 234704, RefRangeEnd = 234710, XrefRangeStart = 234701, XrefRangeEnd = 234704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Money(int totalPennies)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&totalPennies);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234727, XrefRangeEnd = 234731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234782, RefRangeEnd = 234784, XrefRangeStart = 234731, XrefRangeEnd = 234782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToString(bool withSprites)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&withSprites);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_String_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234788, RefRangeEnd = 234790, XrefRangeStart = 234784, XrefRangeEnd = 234788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Money Normalized()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Normalized_Public_Money_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Money*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234790, XrefRangeEnd = 234791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Money FromPennies(int pennies)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pennies);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromPennies_Public_Static_Money_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Money*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 234791, RefRangeEnd = 234794, XrefRangeStart = 234791, XrefRangeEnd = 234791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Money operator +(Money a, Money b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Money**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_Money_Money_Money_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Money*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234794, XrefRangeEnd = 234798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Money operator *(Money a, int val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Money_Money_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Money*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 234812, RefRangeEnd = 234816, XrefRangeStart = 234798, XrefRangeEnd = 234812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Money operator *(Money a, float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Money_Money_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Money*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Money>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

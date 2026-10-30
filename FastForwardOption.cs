using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class FastForwardOption : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_OFF;

	private static readonly System.IntPtr NativeFieldInfoPtr_SOME_INTERACTIONS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ALL_INTERACTIONS;

	private static readonly System.IntPtr NativeFieldInfoPtr_values;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValues_Public_Static_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int OFF
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OFF, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OFF, (void*)(&num));
		}
	}

	public unsafe static int SOME_INTERACTIONS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SOME_INTERACTIONS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SOME_INTERACTIONS, (void*)(&num));
		}
	}

	public unsafe static int ALL_INTERACTIONS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALL_INTERACTIONS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALL_INTERACTIONS, (void*)(&num));
		}
	}

	public unsafe static List<Il2CppSystem.ValueTuple<int, string>> values
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_values, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<int, string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_values, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static FastForwardOption()
	{
		Il2CppClassPointerStore<FastForwardOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FastForwardOption");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastForwardOption>.NativeClassPtr);
		NativeFieldInfoPtr_OFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastForwardOption>.NativeClassPtr, "OFF");
		NativeFieldInfoPtr_SOME_INTERACTIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastForwardOption>.NativeClassPtr, "SOME_INTERACTIONS");
		NativeFieldInfoPtr_ALL_INTERACTIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastForwardOption>.NativeClassPtr, "ALL_INTERACTIONS");
		NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastForwardOption>.NativeClassPtr, "values");
		NativeMethodInfoPtr_GetValues_Public_Static_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardOption>.NativeClassPtr, 100663617);
		NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardOption>.NativeClassPtr, 100663618);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastForwardOption>.NativeClassPtr, 100663619);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20156, RefRangeEnd = 20158, XrefRangeStart = 20139, XrefRangeEnd = 20156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> GetValues()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValues_Public_Static_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20181, RefRangeEnd = 20183, XrefRangeStart = 20158, XrefRangeEnd = 20181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetNames()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FastForwardOption()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastForwardOption>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FastForwardOption(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class SurvivalShadowQuality : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_OFF;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOW;

	private static readonly System.IntPtr NativeFieldInfoPtr_MEDIUM;

	private static readonly System.IntPtr NativeFieldInfoPtr_HIGH;

	private static readonly System.IntPtr NativeFieldInfoPtr_names;

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

	public unsafe static int LOW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOW, (void*)(&num));
		}
	}

	public unsafe static int MEDIUM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MEDIUM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MEDIUM, (void*)(&num));
		}
	}

	public unsafe static int HIGH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HIGH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HIGH, (void*)(&num));
		}
	}

	public unsafe static Il2CppStringArray names
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_names, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_names, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static SurvivalShadowQuality()
	{
		Il2CppClassPointerStore<SurvivalShadowQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SurvivalShadowQuality");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurvivalShadowQuality>.NativeClassPtr);
		NativeFieldInfoPtr_OFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalShadowQuality>.NativeClassPtr, "OFF");
		NativeFieldInfoPtr_LOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalShadowQuality>.NativeClassPtr, "LOW");
		NativeFieldInfoPtr_MEDIUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalShadowQuality>.NativeClassPtr, "MEDIUM");
		NativeFieldInfoPtr_HIGH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalShadowQuality>.NativeClassPtr, "HIGH");
		NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalShadowQuality>.NativeClassPtr, "names");
		NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivalShadowQuality>.NativeClassPtr, 100663674);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivalShadowQuality>.NativeClassPtr, 100663675);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 21171, RefRangeEnd = 21173, XrefRangeStart = 21154, XrefRangeEnd = 21171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe SurvivalShadowQuality()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurvivalShadowQuality>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SurvivalShadowQuality(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

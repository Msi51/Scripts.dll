using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[StructLayout(LayoutKind.Explicit)]
public struct SurvivalQualitySettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_textureQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_anisotropicFiltering;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_grassShadowsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_firesCastShadows;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterReflectionQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_postProcessingEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_ssaoQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_antiAliasingQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_grassAntiAliasingEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudQuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudShadowsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTessellationEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_vsync;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitFramerate;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxFramerate;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_SurvivalQualitySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0;

	[FieldOffset(0)]
	public int textureQuality;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.U1)]
	public bool anisotropicFiltering;

	[FieldOffset(8)]
	public int objectQuality;

	[FieldOffset(12)]
	public int shadowQuality;

	[FieldOffset(16)]
	public float viewDistance;

	[FieldOffset(20)]
	[MarshalAs(UnmanagedType.U1)]
	public bool grassShadowsEnabled;

	[FieldOffset(21)]
	[MarshalAs(UnmanagedType.U1)]
	public bool firesCastShadows;

	[FieldOffset(24)]
	public int waterReflectionQuality;

	[FieldOffset(28)]
	[MarshalAs(UnmanagedType.U1)]
	public bool postProcessingEnabled;

	[FieldOffset(32)]
	public int ssaoQuality;

	[FieldOffset(36)]
	public int antiAliasingQuality;

	[FieldOffset(40)]
	[MarshalAs(UnmanagedType.U1)]
	public bool grassAntiAliasingEnabled;

	[FieldOffset(44)]
	public int cloudQuality;

	[FieldOffset(48)]
	[MarshalAs(UnmanagedType.U1)]
	public bool cloudShadowsEnabled;

	[FieldOffset(49)]
	[MarshalAs(UnmanagedType.U1)]
	public bool terrainTessellationEnabled;

	[FieldOffset(50)]
	[MarshalAs(UnmanagedType.U1)]
	public bool vsync;

	[FieldOffset(51)]
	[MarshalAs(UnmanagedType.U1)]
	public bool limitFramerate;

	[FieldOffset(52)]
	public int maxFramerate;

	static SurvivalQualitySettings()
	{
		Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SurvivalQualitySettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr);
		NativeFieldInfoPtr_textureQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "textureQuality");
		NativeFieldInfoPtr_anisotropicFiltering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "anisotropicFiltering");
		NativeFieldInfoPtr_objectQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "objectQuality");
		NativeFieldInfoPtr_shadowQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "shadowQuality");
		NativeFieldInfoPtr_viewDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "viewDistance");
		NativeFieldInfoPtr_grassShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "grassShadowsEnabled");
		NativeFieldInfoPtr_firesCastShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "firesCastShadows");
		NativeFieldInfoPtr_waterReflectionQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "waterReflectionQuality");
		NativeFieldInfoPtr_postProcessingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "postProcessingEnabled");
		NativeFieldInfoPtr_ssaoQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "ssaoQuality");
		NativeFieldInfoPtr_antiAliasingQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "antiAliasingQuality");
		NativeFieldInfoPtr_grassAntiAliasingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "grassAntiAliasingEnabled");
		NativeFieldInfoPtr_cloudQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "cloudQuality");
		NativeFieldInfoPtr_cloudShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "cloudShadowsEnabled");
		NativeFieldInfoPtr_terrainTessellationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "terrainTessellationEnabled");
		NativeFieldInfoPtr_vsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "vsync");
		NativeFieldInfoPtr_limitFramerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "limitFramerate");
		NativeFieldInfoPtr_maxFramerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, "maxFramerate");
		NativeMethodInfoPtr_Equals_Public_Boolean_SurvivalQualitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, 100663671);
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, 100663672);
		NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, 100663673);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20917, RefRangeEnd = 20919, XrefRangeStart = 20913, XrefRangeEnd = 20917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(SurvivalQualitySettings other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_SurvivalQualitySettings_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21034, RefRangeEnd = 21035, XrefRangeStart = 20919, XrefRangeEnd = 21034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 21153, RefRangeEnd = 21154, XrefRangeStart = 21035, XrefRangeEnd = 21153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Dictionary<string, Il2CppSystem.Object> MapToDictionary()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SurvivalQualitySettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

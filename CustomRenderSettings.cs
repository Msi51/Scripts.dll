using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class CustomRenderSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_distanceFogDensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerFogDensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightFogMaxHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_accumulatedWind;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoExposureBuffer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float distanceFogDensity
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_distanceFogDensity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_distanceFogDensity, (void*)(&num));
		}
	}

	public unsafe static float playerFogDensity
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_playerFogDensity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_playerFogDensity, (void*)(&num));
		}
	}

	public unsafe static float heightFogMaxHeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_heightFogMaxHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_heightFogMaxHeight, (void*)(&num));
		}
	}

	public unsafe static Vector2 accumulatedWind
	{
		get
		{
			Unsafe.SkipInit(out Vector2 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_accumulatedWind, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_accumulatedWind, (void*)(&vector));
		}
	}

	public unsafe static ComputeBuffer autoExposureBuffer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_autoExposureBuffer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_autoExposureBuffer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)computeBuffer));
		}
	}

	static CustomRenderSettings()
	{
		Il2CppClassPointerStore<CustomRenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CustomRenderSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderSettings>.NativeClassPtr);
		NativeFieldInfoPtr_distanceFogDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderSettings>.NativeClassPtr, "distanceFogDensity");
		NativeFieldInfoPtr_playerFogDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderSettings>.NativeClassPtr, "playerFogDensity");
		NativeFieldInfoPtr_heightFogMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderSettings>.NativeClassPtr, "heightFogMaxHeight");
		NativeFieldInfoPtr_accumulatedWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderSettings>.NativeClassPtr, "accumulatedWind");
		NativeFieldInfoPtr_autoExposureBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderSettings>.NativeClassPtr, "autoExposureBuffer");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderSettings>.NativeClassPtr, 100664371);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomRenderSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomRenderSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CustomRenderSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

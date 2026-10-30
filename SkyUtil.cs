using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

public static class SkyUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_colorSpaceDouble;

	private static readonly System.IntPtr NativeFieldInfoPtr_GAMMA;

	private static readonly System.IntPtr NativeFieldInfoPtr_kDefaultScatteringWavelength;

	private static readonly System.IntPtr NativeFieldInfoPtr_kVariableRangeForScatteringWavelength;

	private static readonly System.IntPtr NativeFieldInfoPtr_OUTER_RADIUS;

	private static readonly System.IntPtr NativeFieldInfoPtr_kOuterRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_kOuterRadius2;

	private static readonly System.IntPtr NativeFieldInfoPtr_kInnerRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_kInnerRadius2;

	private static readonly System.IntPtr NativeFieldInfoPtr_kCameraHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_kRAYLEIGH;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMIE;

	private static readonly System.IntPtr NativeFieldInfoPtr_kSUN_BRIGHTNESS;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMAX_SCATTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_kHDSundiskIntensityFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_kSimpleSundiskIntensityFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_kSunScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_kKmESun;

	private static readonly System.IntPtr NativeFieldInfoPtr_kKm4PI;

	private static readonly System.IntPtr NativeFieldInfoPtr_kScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_kScaleDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_kScaleOverScaleDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_kSamples;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKY_GROUND_THRESHOLD;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIE_G;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIE_G2;

	private static readonly System.IntPtr NativeMethodInfoPtr_COLOR_2_GAMMA_Private_Static_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scale_Private_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRayleighPhase_Private_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRayleighPhase_Private_Static_Single_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMiePhase_Private_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Luminance_Private_Static_float3_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_colors_Private_Static_Void_float3_float3_float3_float3_byref_float3_byref_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkyColors_Public_Static_Void_float3_Single_Single_float3_float3_byref_float3_0;

	public unsafe static float4 colorSpaceDouble
	{
		get
		{
			Unsafe.SkipInit(out float4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_colorSpaceDouble, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_colorSpaceDouble, (void*)(&float5));
		}
	}

	public unsafe static float GAMMA
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GAMMA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GAMMA, (void*)(&num));
		}
	}

	public unsafe static float3 kDefaultScatteringWavelength
	{
		get
		{
			Unsafe.SkipInit(out float3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDefaultScatteringWavelength, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDefaultScatteringWavelength, (void*)(&float5));
		}
	}

	public unsafe static float3 kVariableRangeForScatteringWavelength
	{
		get
		{
			Unsafe.SkipInit(out float3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kVariableRangeForScatteringWavelength, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kVariableRangeForScatteringWavelength, (void*)(&float5));
		}
	}

	public unsafe static float OUTER_RADIUS
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OUTER_RADIUS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OUTER_RADIUS, (void*)(&num));
		}
	}

	public unsafe static float kOuterRadius
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kOuterRadius, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kOuterRadius, (void*)(&num));
		}
	}

	public unsafe static float kOuterRadius2
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kOuterRadius2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kOuterRadius2, (void*)(&num));
		}
	}

	public unsafe static float kInnerRadius
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kInnerRadius, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kInnerRadius, (void*)(&num));
		}
	}

	public unsafe static float kInnerRadius2
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kInnerRadius2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kInnerRadius2, (void*)(&num));
		}
	}

	public unsafe static float kCameraHeight
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kCameraHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kCameraHeight, (void*)(&num));
		}
	}

	public unsafe static float kRAYLEIGH
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kRAYLEIGH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kRAYLEIGH, (void*)(&num));
		}
	}

	public unsafe static float kMIE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMIE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMIE, (void*)(&num));
		}
	}

	public unsafe static float kSUN_BRIGHTNESS
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSUN_BRIGHTNESS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSUN_BRIGHTNESS, (void*)(&num));
		}
	}

	public unsafe static float kMAX_SCATTER
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMAX_SCATTER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMAX_SCATTER, (void*)(&num));
		}
	}

	public unsafe static float kHDSundiskIntensityFactor
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kHDSundiskIntensityFactor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kHDSundiskIntensityFactor, (void*)(&num));
		}
	}

	public unsafe static float kSimpleSundiskIntensityFactor
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSimpleSundiskIntensityFactor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSimpleSundiskIntensityFactor, (void*)(&num));
		}
	}

	public unsafe static float kSunScale
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSunScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSunScale, (void*)(&num));
		}
	}

	public unsafe static float kKmESun
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kKmESun, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kKmESun, (void*)(&num));
		}
	}

	public unsafe static float kKm4PI
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kKm4PI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kKm4PI, (void*)(&num));
		}
	}

	public unsafe static float kScale
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kScale, (void*)(&num));
		}
	}

	public unsafe static float kScaleDepth
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kScaleDepth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kScaleDepth, (void*)(&num));
		}
	}

	public unsafe static float kScaleOverScaleDepth
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kScaleOverScaleDepth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kScaleOverScaleDepth, (void*)(&num));
		}
	}

	public unsafe static float kSamples
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSamples, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSamples, (void*)(&num));
		}
	}

	public unsafe static float SKY_GROUND_THRESHOLD
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKY_GROUND_THRESHOLD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKY_GROUND_THRESHOLD, (void*)(&num));
		}
	}

	public unsafe static float MIE_G
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIE_G, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIE_G, (void*)(&num));
		}
	}

	public unsafe static float MIE_G2
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIE_G2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIE_G2, (void*)(&num));
		}
	}

	static SkyUtil()
	{
		Il2CppClassPointerStore<SkyUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SkyUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr);
		NativeFieldInfoPtr_colorSpaceDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "colorSpaceDouble");
		NativeFieldInfoPtr_GAMMA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "GAMMA");
		NativeFieldInfoPtr_kDefaultScatteringWavelength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kDefaultScatteringWavelength");
		NativeFieldInfoPtr_kVariableRangeForScatteringWavelength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kVariableRangeForScatteringWavelength");
		NativeFieldInfoPtr_OUTER_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "OUTER_RADIUS");
		NativeFieldInfoPtr_kOuterRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kOuterRadius");
		NativeFieldInfoPtr_kOuterRadius2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kOuterRadius2");
		NativeFieldInfoPtr_kInnerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kInnerRadius");
		NativeFieldInfoPtr_kInnerRadius2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kInnerRadius2");
		NativeFieldInfoPtr_kCameraHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kCameraHeight");
		NativeFieldInfoPtr_kRAYLEIGH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kRAYLEIGH");
		NativeFieldInfoPtr_kMIE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kMIE");
		NativeFieldInfoPtr_kSUN_BRIGHTNESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kSUN_BRIGHTNESS");
		NativeFieldInfoPtr_kMAX_SCATTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kMAX_SCATTER");
		NativeFieldInfoPtr_kHDSundiskIntensityFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kHDSundiskIntensityFactor");
		NativeFieldInfoPtr_kSimpleSundiskIntensityFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kSimpleSundiskIntensityFactor");
		NativeFieldInfoPtr_kSunScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kSunScale");
		NativeFieldInfoPtr_kKmESun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kKmESun");
		NativeFieldInfoPtr_kKm4PI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kKm4PI");
		NativeFieldInfoPtr_kScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kScale");
		NativeFieldInfoPtr_kScaleDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kScaleDepth");
		NativeFieldInfoPtr_kScaleOverScaleDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kScaleOverScaleDepth");
		NativeFieldInfoPtr_kSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "kSamples");
		NativeFieldInfoPtr_SKY_GROUND_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "SKY_GROUND_THRESHOLD");
		NativeFieldInfoPtr_MIE_G = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "MIE_G");
		NativeFieldInfoPtr_MIE_G2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, "MIE_G2");
		NativeMethodInfoPtr_COLOR_2_GAMMA_Private_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, 100667934);
		NativeMethodInfoPtr_scale_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, 100667935);
		NativeMethodInfoPtr_getRayleighPhase_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, 100667936);
		NativeMethodInfoPtr_getRayleighPhase_Private_Static_Single_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, 100667937);
		NativeMethodInfoPtr_getMiePhase_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, 100667938);
		NativeMethodInfoPtr_Luminance_Private_Static_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, 100667939);
		NativeMethodInfoPtr_colors_Private_Static_Void_float3_float3_float3_float3_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, 100667940);
		NativeMethodInfoPtr_GetSkyColors_Public_Static_Void_float3_Single_Single_float3_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyUtil>.NativeClassPtr, 100667941);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85570, XrefRangeEnd = 85578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float3 COLOR_2_GAMMA(float3 color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_COLOR_2_GAMMA_Private_Static_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85578, XrefRangeEnd = 85579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float scale(float inCos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inCos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scale_Private_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float getRayleighPhase(float eyeCos2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eyeCos2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRayleighPhase_Private_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85579, XrefRangeEnd = 85583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float getRayleighPhase(float3 light, float3 ray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&light);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ray;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRayleighPhase_Private_Static_Single_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85583, XrefRangeEnd = 85597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float getMiePhase(float eyeCos, float eyeCos2, float sunSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&eyeCos);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eyeCos2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sunSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMiePhase_Private_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float3 Luminance(float3 linearRgb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&linearRgb);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Luminance_Private_Static_float3_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 85656, RefRangeEnd = 85658, XrefRangeStart = 85597, XrefRangeEnd = 85656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void colors(float3 eyeRay, float3 cameraPos, float3 lightPos, float3 skyTint, out float3 cIn, out float3 cOut)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&eyeRay);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraPos;
		*(float3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightPos;
		*(float3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &skyTint;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cIn);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cOut);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_colors_Private_Static_Void_float3_float3_float3_float3_byref_float3_byref_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85687, RefRangeEnd = 85688, XrefRangeStart = 85658, XrefRangeEnd = 85687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSkyColors(float3 eyeRay, float exposure, float cloudCover, float3 sunDirection, float3 skyTint, out float3 skyColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&eyeRay);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exposure;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cloudCover;
		*(float3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sunDirection;
		*(float3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &skyTint;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref skyColor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkyColors_Public_Static_Void_float3_Single_Single_float3_float3_byref_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkyUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

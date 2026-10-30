using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class ShaderProperties : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cloudNoiseKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunDisabledKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_undergroundKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflectionRenderedKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowReflectionKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveClippingKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_watermapDisplacementKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionTerrainKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTessellationKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainSnowDisplacementKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightBlendingKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainMaskMapsKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterCustomizationCutoutKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_grassMSAAKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudShadowsKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_contactShadowsKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflectionCameraKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoExposureKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoExposureComputeBufferKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoExposureIntensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_radialBlurKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_radialBlurSamplesProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_radialBlurIntensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_dryingKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_dryingIntensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_coldKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_coldIntensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_wetnessKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_wetnessIntensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_toxicSmokeEffectKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_toxicSmokeIntensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_painKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_painDirectionalIntensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_painDirectionlessIntensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_painDirectionProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseExposureKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseExposureIntensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseasedKeyword;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseasedIntensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_offsetProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultAutoExposureProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPositionProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerFogDensityProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceFogDensityProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunDirectionProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_exposureProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHeightProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_accumulatedWindProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudCover;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflectionTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_puddleReflectionTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_bumpScale1;

	private static readonly System.IntPtr NativeFieldInfoPtr_bumpScale2;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthFogStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertexWaveA;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertexWaveB;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterRipplesProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterSwampProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldWaterLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldWaterLevelSmoothnessHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainCursorPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainCursorHighlightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainCursorHighlightRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDrynessProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDeadnessProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldWetnessProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldFallAmountProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSnowAmountProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_windStrengthProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_windDirectionProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_cutoutPositionProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_cutoutRadiusProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_grassMSAA;

	private static readonly System.IntPtr NativeFieldInfoPtr_displacementPosition1Property;

	private static readonly System.IntPtr NativeFieldInfoPtr_displacementPosition2Property;

	private static readonly System.IntPtr NativeFieldInfoPtr_displacementPosition3Property;

	private static readonly System.IntPtr NativeFieldInfoPtr_displacementPosition4Property;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseColorProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_emissionColorProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_smoothnessProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectColorProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_intensityProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkMapProp;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveClippingPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveEntranceDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_controlsProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_splatsProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalsProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_maskMapsProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerData1Property;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerData2Property;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerData3Property;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionRenderProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraPositionProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_fineSunDirectionProperty;

	public unsafe static string cloudNoiseKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cloudNoiseKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cloudNoiseKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string sunDisabledKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sunDisabledKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sunDisabledKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string undergroundKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_undergroundKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_undergroundKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string reflectionRenderedKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reflectionRenderedKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reflectionRenderedKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string allowReflectionKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_allowReflectionKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_allowReflectionKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string caveClippingKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_caveClippingKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_caveClippingKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string watermapDisplacementKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_watermapDisplacementKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_watermapDisplacementKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string regionTerrainKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_regionTerrainKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_regionTerrainKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string terrainTessellationKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainTessellationKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainTessellationKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string terrainSnowDisplacementKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainSnowDisplacementKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainSnowDisplacementKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string heightBlendingKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_heightBlendingKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_heightBlendingKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string terrainMaskMapsKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainMaskMapsKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainMaskMapsKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string characterCustomizationCutoutKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_characterCustomizationCutoutKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_characterCustomizationCutoutKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string grassMSAAKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_grassMSAAKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_grassMSAAKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string cloudShadowsKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cloudShadowsKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cloudShadowsKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string contactShadowsKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_contactShadowsKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_contactShadowsKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string reflectionCameraKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reflectionCameraKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reflectionCameraKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string autoExposureKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_autoExposureKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_autoExposureKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string autoExposureComputeBufferKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_autoExposureComputeBufferKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_autoExposureComputeBufferKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int autoExposureIntensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_autoExposureIntensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_autoExposureIntensityProperty, (void*)(&num));
		}
	}

	public unsafe static string radialBlurKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_radialBlurKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_radialBlurKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int radialBlurSamplesProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_radialBlurSamplesProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_radialBlurSamplesProperty, (void*)(&num));
		}
	}

	public unsafe static int radialBlurIntensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_radialBlurIntensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_radialBlurIntensityProperty, (void*)(&num));
		}
	}

	public unsafe static string dryingKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dryingKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dryingKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int dryingIntensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dryingIntensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dryingIntensityProperty, (void*)(&num));
		}
	}

	public unsafe static string coldKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_coldKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_coldKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int coldIntensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_coldIntensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_coldIntensityProperty, (void*)(&num));
		}
	}

	public unsafe static string wetnessKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wetnessKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wetnessKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int wetnessIntensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wetnessIntensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wetnessIntensityProperty, (void*)(&num));
		}
	}

	public unsafe static string toxicSmokeEffectKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_toxicSmokeEffectKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_toxicSmokeEffectKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int toxicSmokeIntensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_toxicSmokeIntensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_toxicSmokeIntensityProperty, (void*)(&num));
		}
	}

	public unsafe static string painKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_painKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_painKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int painDirectionalIntensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_painDirectionalIntensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_painDirectionalIntensityProperty, (void*)(&num));
		}
	}

	public unsafe static int painDirectionlessIntensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_painDirectionlessIntensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_painDirectionlessIntensityProperty, (void*)(&num));
		}
	}

	public unsafe static int painDirectionProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_painDirectionProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_painDirectionProperty, (void*)(&num));
		}
	}

	public unsafe static string diseaseExposureKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_diseaseExposureKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_diseaseExposureKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int diseaseExposureIntensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_diseaseExposureIntensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_diseaseExposureIntensityProperty, (void*)(&num));
		}
	}

	public unsafe static string diseasedKeyword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_diseasedKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_diseasedKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int diseasedIntensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_diseasedIntensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_diseasedIntensityProperty, (void*)(&num));
		}
	}

	public unsafe static int offsetProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_offsetProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_offsetProperty, (void*)(&num));
		}
	}

	public unsafe static int resultAutoExposureProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_resultAutoExposureProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_resultAutoExposureProperty, (void*)(&num));
		}
	}

	public unsafe static int playerPositionProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_playerPositionProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_playerPositionProp, (void*)(&num));
		}
	}

	public unsafe static int playerFogDensityProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_playerFogDensityProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_playerFogDensityProp, (void*)(&num));
		}
	}

	public unsafe static int distanceFogDensityProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_distanceFogDensityProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_distanceFogDensityProp, (void*)(&num));
		}
	}

	public unsafe static int sunDirectionProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sunDirectionProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sunDirectionProp, (void*)(&num));
		}
	}

	public unsafe static int exposureProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_exposureProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_exposureProp, (void*)(&num));
		}
	}

	public unsafe static int maxHeightProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxHeightProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxHeightProp, (void*)(&num));
		}
	}

	public unsafe static int accumulatedWindProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_accumulatedWindProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_accumulatedWindProp, (void*)(&num));
		}
	}

	public unsafe static int cloudCover
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cloudCover, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cloudCover, (void*)(&num));
		}
	}

	public unsafe static int cloudTime
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cloudTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cloudTime, (void*)(&num));
		}
	}

	public unsafe static int reflectionTexture
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reflectionTexture, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reflectionTexture, (void*)(&num));
		}
	}

	public unsafe static int puddleReflectionTexture
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_puddleReflectionTexture, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_puddleReflectionTexture, (void*)(&num));
		}
	}

	public unsafe static int bumpScale1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bumpScale1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bumpScale1, (void*)(&num));
		}
	}

	public unsafe static int bumpScale2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bumpScale2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bumpScale2, (void*)(&num));
		}
	}

	public unsafe static int depthFogStart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_depthFogStart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_depthFogStart, (void*)(&num));
		}
	}

	public unsafe static int vertexWaveA
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vertexWaveA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vertexWaveA, (void*)(&num));
		}
	}

	public unsafe static int vertexWaveB
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vertexWaveB, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vertexWaveB, (void*)(&num));
		}
	}

	public unsafe static int waterRipplesProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_waterRipplesProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_waterRipplesProp, (void*)(&num));
		}
	}

	public unsafe static int waterSwampProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_waterSwampProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_waterSwampProp, (void*)(&num));
		}
	}

	public unsafe static int worldWaterLevel
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_worldWaterLevel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_worldWaterLevel, (void*)(&num));
		}
	}

	public unsafe static int worldWaterLevelSmoothnessHeight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_worldWaterLevelSmoothnessHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_worldWaterLevelSmoothnessHeight, (void*)(&num));
		}
	}

	public unsafe static int terrainCursorPosition
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainCursorPosition, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainCursorPosition, (void*)(&num));
		}
	}

	public unsafe static int terrainCursorHighlightColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainCursorHighlightColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainCursorHighlightColor, (void*)(&num));
		}
	}

	public unsafe static int terrainCursorHighlightRadius
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainCursorHighlightRadius, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainCursorHighlightRadius, (void*)(&num));
		}
	}

	public unsafe static int worldDrynessProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_worldDrynessProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_worldDrynessProp, (void*)(&num));
		}
	}

	public unsafe static int worldDeadnessProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_worldDeadnessProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_worldDeadnessProp, (void*)(&num));
		}
	}

	public unsafe static int worldWetnessProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_worldWetnessProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_worldWetnessProperty, (void*)(&num));
		}
	}

	public unsafe static int worldFallAmountProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_worldFallAmountProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_worldFallAmountProp, (void*)(&num));
		}
	}

	public unsafe static int worldSnowAmountProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_worldSnowAmountProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_worldSnowAmountProp, (void*)(&num));
		}
	}

	public unsafe static int windStrengthProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_windStrengthProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_windStrengthProperty, (void*)(&num));
		}
	}

	public unsafe static int windDirectionProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_windDirectionProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_windDirectionProperty, (void*)(&num));
		}
	}

	public unsafe static int cutoutPositionProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cutoutPositionProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cutoutPositionProperty, (void*)(&num));
		}
	}

	public unsafe static int cutoutRadiusProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cutoutRadiusProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cutoutRadiusProperty, (void*)(&num));
		}
	}

	public unsafe static int grassMSAA
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_grassMSAA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_grassMSAA, (void*)(&num));
		}
	}

	public unsafe static int displacementPosition1Property
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_displacementPosition1Property, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_displacementPosition1Property, (void*)(&num));
		}
	}

	public unsafe static int displacementPosition2Property
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_displacementPosition2Property, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_displacementPosition2Property, (void*)(&num));
		}
	}

	public unsafe static int displacementPosition3Property
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_displacementPosition3Property, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_displacementPosition3Property, (void*)(&num));
		}
	}

	public unsafe static int displacementPosition4Property
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_displacementPosition4Property, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_displacementPosition4Property, (void*)(&num));
		}
	}

	public unsafe static int colorProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_colorProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_colorProperty, (void*)(&num));
		}
	}

	public unsafe static int baseColorProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_baseColorProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_baseColorProperty, (void*)(&num));
		}
	}

	public unsafe static int emissionColorProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_emissionColorProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_emissionColorProperty, (void*)(&num));
		}
	}

	public unsafe static int smoothnessProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_smoothnessProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_smoothnessProperty, (void*)(&num));
		}
	}

	public unsafe static int effectColorProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_effectColorProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_effectColorProperty, (void*)(&num));
		}
	}

	public unsafe static int intensityProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_intensityProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_intensityProperty, (void*)(&num));
		}
	}

	public unsafe static int chunkMapProp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chunkMapProp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chunkMapProp, (void*)(&num));
		}
	}

	public unsafe static int caveClippingPosition
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_caveClippingPosition, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_caveClippingPosition, (void*)(&num));
		}
	}

	public unsafe static int caveEntranceDirection
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_caveEntranceDirection, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_caveEntranceDirection, (void*)(&num));
		}
	}

	public unsafe static int controlsProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_controlsProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_controlsProperty, (void*)(&num));
		}
	}

	public unsafe static int splatsProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_splatsProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_splatsProperty, (void*)(&num));
		}
	}

	public unsafe static int normalsProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_normalsProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_normalsProperty, (void*)(&num));
		}
	}

	public unsafe static int maskMapsProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maskMapsProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maskMapsProperty, (void*)(&num));
		}
	}

	public unsafe static int layerData1Property
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_layerData1Property, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_layerData1Property, (void*)(&num));
		}
	}

	public unsafe static int layerData2Property
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_layerData2Property, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_layerData2Property, (void*)(&num));
		}
	}

	public unsafe static int layerData3Property
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_layerData3Property, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_layerData3Property, (void*)(&num));
		}
	}

	public unsafe static int regionRenderProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_regionRenderProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_regionRenderProperty, (void*)(&num));
		}
	}

	public unsafe static int cameraPositionProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cameraPositionProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cameraPositionProperty, (void*)(&num));
		}
	}

	public unsafe static int fineSunDirectionProperty
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fineSunDirectionProperty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fineSunDirectionProperty, (void*)(&num));
		}
	}

	static ShaderProperties()
	{
		Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShaderProperties");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr);
		NativeFieldInfoPtr_cloudNoiseKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "cloudNoiseKeyword");
		NativeFieldInfoPtr_sunDisabledKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "sunDisabledKeyword");
		NativeFieldInfoPtr_undergroundKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "undergroundKeyword");
		NativeFieldInfoPtr_reflectionRenderedKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "reflectionRenderedKeyword");
		NativeFieldInfoPtr_allowReflectionKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "allowReflectionKeyword");
		NativeFieldInfoPtr_caveClippingKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "caveClippingKeyword");
		NativeFieldInfoPtr_watermapDisplacementKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "watermapDisplacementKeyword");
		NativeFieldInfoPtr_regionTerrainKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "regionTerrainKeyword");
		NativeFieldInfoPtr_terrainTessellationKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "terrainTessellationKeyword");
		NativeFieldInfoPtr_terrainSnowDisplacementKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "terrainSnowDisplacementKeyword");
		NativeFieldInfoPtr_heightBlendingKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "heightBlendingKeyword");
		NativeFieldInfoPtr_terrainMaskMapsKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "terrainMaskMapsKeyword");
		NativeFieldInfoPtr_characterCustomizationCutoutKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "characterCustomizationCutoutKeyword");
		NativeFieldInfoPtr_grassMSAAKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "grassMSAAKeyword");
		NativeFieldInfoPtr_cloudShadowsKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "cloudShadowsKeyword");
		NativeFieldInfoPtr_contactShadowsKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "contactShadowsKeyword");
		NativeFieldInfoPtr_reflectionCameraKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "reflectionCameraKeyword");
		NativeFieldInfoPtr_autoExposureKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "autoExposureKeyword");
		NativeFieldInfoPtr_autoExposureComputeBufferKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "autoExposureComputeBufferKeyword");
		NativeFieldInfoPtr_autoExposureIntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "autoExposureIntensityProperty");
		NativeFieldInfoPtr_radialBlurKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "radialBlurKeyword");
		NativeFieldInfoPtr_radialBlurSamplesProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "radialBlurSamplesProperty");
		NativeFieldInfoPtr_radialBlurIntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "radialBlurIntensityProperty");
		NativeFieldInfoPtr_dryingKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "dryingKeyword");
		NativeFieldInfoPtr_dryingIntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "dryingIntensityProperty");
		NativeFieldInfoPtr_coldKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "coldKeyword");
		NativeFieldInfoPtr_coldIntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "coldIntensityProperty");
		NativeFieldInfoPtr_wetnessKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "wetnessKeyword");
		NativeFieldInfoPtr_wetnessIntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "wetnessIntensityProperty");
		NativeFieldInfoPtr_toxicSmokeEffectKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "toxicSmokeEffectKeyword");
		NativeFieldInfoPtr_toxicSmokeIntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "toxicSmokeIntensityProperty");
		NativeFieldInfoPtr_painKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "painKeyword");
		NativeFieldInfoPtr_painDirectionalIntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "painDirectionalIntensityProperty");
		NativeFieldInfoPtr_painDirectionlessIntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "painDirectionlessIntensityProperty");
		NativeFieldInfoPtr_painDirectionProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "painDirectionProperty");
		NativeFieldInfoPtr_diseaseExposureKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "diseaseExposureKeyword");
		NativeFieldInfoPtr_diseaseExposureIntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "diseaseExposureIntensityProperty");
		NativeFieldInfoPtr_diseasedKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "diseasedKeyword");
		NativeFieldInfoPtr_diseasedIntensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "diseasedIntensityProperty");
		NativeFieldInfoPtr_offsetProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "offsetProperty");
		NativeFieldInfoPtr_resultAutoExposureProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "resultAutoExposureProperty");
		NativeFieldInfoPtr_playerPositionProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "playerPositionProp");
		NativeFieldInfoPtr_playerFogDensityProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "playerFogDensityProp");
		NativeFieldInfoPtr_distanceFogDensityProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "distanceFogDensityProp");
		NativeFieldInfoPtr_sunDirectionProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "sunDirectionProp");
		NativeFieldInfoPtr_exposureProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "exposureProp");
		NativeFieldInfoPtr_maxHeightProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "maxHeightProp");
		NativeFieldInfoPtr_accumulatedWindProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "accumulatedWindProp");
		NativeFieldInfoPtr_cloudCover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "cloudCover");
		NativeFieldInfoPtr_cloudTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "cloudTime");
		NativeFieldInfoPtr_reflectionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "reflectionTexture");
		NativeFieldInfoPtr_puddleReflectionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "puddleReflectionTexture");
		NativeFieldInfoPtr_bumpScale1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "bumpScale1");
		NativeFieldInfoPtr_bumpScale2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "bumpScale2");
		NativeFieldInfoPtr_depthFogStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "depthFogStart");
		NativeFieldInfoPtr_vertexWaveA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "vertexWaveA");
		NativeFieldInfoPtr_vertexWaveB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "vertexWaveB");
		NativeFieldInfoPtr_waterRipplesProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "waterRipplesProp");
		NativeFieldInfoPtr_waterSwampProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "waterSwampProp");
		NativeFieldInfoPtr_worldWaterLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "worldWaterLevel");
		NativeFieldInfoPtr_worldWaterLevelSmoothnessHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "worldWaterLevelSmoothnessHeight");
		NativeFieldInfoPtr_terrainCursorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "terrainCursorPosition");
		NativeFieldInfoPtr_terrainCursorHighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "terrainCursorHighlightColor");
		NativeFieldInfoPtr_terrainCursorHighlightRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "terrainCursorHighlightRadius");
		NativeFieldInfoPtr_worldDrynessProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "worldDrynessProp");
		NativeFieldInfoPtr_worldDeadnessProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "worldDeadnessProp");
		NativeFieldInfoPtr_worldWetnessProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "worldWetnessProperty");
		NativeFieldInfoPtr_worldFallAmountProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "worldFallAmountProp");
		NativeFieldInfoPtr_worldSnowAmountProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "worldSnowAmountProp");
		NativeFieldInfoPtr_windStrengthProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "windStrengthProperty");
		NativeFieldInfoPtr_windDirectionProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "windDirectionProperty");
		NativeFieldInfoPtr_cutoutPositionProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "cutoutPositionProperty");
		NativeFieldInfoPtr_cutoutRadiusProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "cutoutRadiusProperty");
		NativeFieldInfoPtr_grassMSAA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "grassMSAA");
		NativeFieldInfoPtr_displacementPosition1Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "displacementPosition1Property");
		NativeFieldInfoPtr_displacementPosition2Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "displacementPosition2Property");
		NativeFieldInfoPtr_displacementPosition3Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "displacementPosition3Property");
		NativeFieldInfoPtr_displacementPosition4Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "displacementPosition4Property");
		NativeFieldInfoPtr_colorProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "colorProperty");
		NativeFieldInfoPtr_baseColorProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "baseColorProperty");
		NativeFieldInfoPtr_emissionColorProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "emissionColorProperty");
		NativeFieldInfoPtr_smoothnessProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "smoothnessProperty");
		NativeFieldInfoPtr_effectColorProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "effectColorProperty");
		NativeFieldInfoPtr_intensityProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "intensityProperty");
		NativeFieldInfoPtr_chunkMapProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "chunkMapProp");
		NativeFieldInfoPtr_caveClippingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "caveClippingPosition");
		NativeFieldInfoPtr_caveEntranceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "caveEntranceDirection");
		NativeFieldInfoPtr_controlsProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "controlsProperty");
		NativeFieldInfoPtr_splatsProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "splatsProperty");
		NativeFieldInfoPtr_normalsProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "normalsProperty");
		NativeFieldInfoPtr_maskMapsProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "maskMapsProperty");
		NativeFieldInfoPtr_layerData1Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "layerData1Property");
		NativeFieldInfoPtr_layerData2Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "layerData2Property");
		NativeFieldInfoPtr_layerData3Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "layerData3Property");
		NativeFieldInfoPtr_regionRenderProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "regionRenderProperty");
		NativeFieldInfoPtr_cameraPositionProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "cameraPositionProperty");
		NativeFieldInfoPtr_fineSunDirectionProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "fineSunDirectionProperty");
	}

	public ShaderProperties(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

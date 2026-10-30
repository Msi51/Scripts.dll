using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public sealed class OutlineResources : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr__renderShader;

	private static readonly IntPtr NativeFieldInfoPtr__outlineShader;

	private static readonly IntPtr NativeFieldInfoPtr__renderMaterial;

	private static readonly IntPtr NativeFieldInfoPtr__outlineMaterial;

	private static readonly IntPtr NativeFieldInfoPtr__props;

	private static readonly IntPtr NativeFieldInfoPtr__fullscreenTriangleMesh;

	private static readonly IntPtr NativeFieldInfoPtr__gaussSamples;

	private static readonly IntPtr NativeFieldInfoPtr__useDrawMesh;

	private static readonly IntPtr NativeFieldInfoPtr_MinWidth;

	private static readonly IntPtr NativeFieldInfoPtr_MaxWidth;

	private static readonly IntPtr NativeFieldInfoPtr_MinIntensity;

	private static readonly IntPtr NativeFieldInfoPtr_MaxIntensity;

	private static readonly IntPtr NativeFieldInfoPtr_SolidIntensity;

	private static readonly IntPtr NativeFieldInfoPtr_MinAlphaCutoff;

	private static readonly IntPtr NativeFieldInfoPtr_MaxAlphaCutoff;

	private static readonly IntPtr NativeFieldInfoPtr_MainTexName;

	private static readonly IntPtr NativeFieldInfoPtr_MaskTexName;

	private static readonly IntPtr NativeFieldInfoPtr_TempTexName;

	private static readonly IntPtr NativeFieldInfoPtr_ColorName;

	private static readonly IntPtr NativeFieldInfoPtr_WidthName;

	private static readonly IntPtr NativeFieldInfoPtr_IntensityName;

	private static readonly IntPtr NativeFieldInfoPtr_AlphaCutoffName;

	private static readonly IntPtr NativeFieldInfoPtr_GaussSamplesName;

	private static readonly IntPtr NativeFieldInfoPtr_UseDrawMeshFeatureName;

	private static readonly IntPtr NativeFieldInfoPtr_EffectName;

	private static readonly IntPtr NativeFieldInfoPtr_OutlineResourcesTooltip;

	private static readonly IntPtr NativeFieldInfoPtr_OutlineLayerCollectionTooltip;

	private static readonly IntPtr NativeFieldInfoPtr_OutlineLayerMaskTooltip;

	private static readonly IntPtr NativeFieldInfoPtr_OutlineRenderingLayerMaskTooltip;

	private static readonly IntPtr NativeFieldInfoPtr_OutlineShaderHPassId;

	private static readonly IntPtr NativeFieldInfoPtr_OutlineShaderVPassId;

	private static readonly IntPtr NativeFieldInfoPtr_SrpNotSupported;

	private static readonly IntPtr NativeFieldInfoPtr_PpNotSupported;

	private static readonly IntPtr NativeFieldInfoPtr_MainTexId;

	private static readonly IntPtr NativeFieldInfoPtr_MainTex;

	private static readonly IntPtr NativeFieldInfoPtr_MaskTexId;

	private static readonly IntPtr NativeFieldInfoPtr_MaskTex;

	private static readonly IntPtr NativeFieldInfoPtr_TempTexId;

	private static readonly IntPtr NativeFieldInfoPtr_TempTex;

	private static readonly IntPtr NativeFieldInfoPtr_ColorId;

	private static readonly IntPtr NativeFieldInfoPtr_WidthId;

	private static readonly IntPtr NativeFieldInfoPtr_IntensityId;

	private static readonly IntPtr NativeFieldInfoPtr_AlphaCutoffId;

	private static readonly IntPtr NativeFieldInfoPtr_GaussSamplesId;

	private static readonly IntPtr NativeFieldInfoPtr_TmpMaterials;

	private static readonly IntPtr NativeMethodInfoPtr_get_RenderShader_Public_get_Shader_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_OutlineShader_Public_get_Shader_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RenderMaterial_Public_get_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_OutlineMaterial_Public_get_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_MaterialPropertyBlock_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FullscreenTriangleMesh_Public_get_Mesh_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_FullscreenTriangleMesh_Public_set_Void_Mesh_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_UseFullscreenTriangleMesh_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_UseFullscreenTriangleMesh_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_MaterialPropertyBlock_IOutlineSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetGaussSamples_Public_Il2CppStructArray_1_Single_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetToDefaults_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Gauss_Public_Static_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetGaussSamples_Public_Static_Il2CppStructArray_1_Single_Int32_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_LogSrpNotSupported_Public_Static_Void_Object_0;

	private static readonly IntPtr NativeMethodInfoPtr_LogPpNotSupported_Public_Static_Void_Object_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Shader _renderShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderShader);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader));
		}
	}

	public unsafe Shader _outlineShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outlineShader);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outlineShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader));
		}
	}

	public unsafe Material _renderMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material _outlineMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outlineMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__outlineMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe MaterialPropertyBlock _props
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__props);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__props)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertyBlock));
		}
	}

	public unsafe Mesh _fullscreenTriangleMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fullscreenTriangleMesh);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fullscreenTriangleMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<float>> _gaussSamples
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gaussSamples);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<float>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gaussSamples)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool _useDrawMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useDrawMesh);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useDrawMesh)) = flag;
		}
	}

	public unsafe static int MinWidth
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinWidth, (void*)(&num));
		}
	}

	public unsafe static int MaxWidth
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxWidth, (void*)(&num));
		}
	}

	public unsafe static int MinIntensity
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinIntensity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinIntensity, (void*)(&num));
		}
	}

	public unsafe static int MaxIntensity
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxIntensity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxIntensity, (void*)(&num));
		}
	}

	public unsafe static int SolidIntensity
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SolidIntensity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SolidIntensity, (void*)(&num));
		}
	}

	public unsafe static float MinAlphaCutoff
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinAlphaCutoff, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinAlphaCutoff, (void*)(&num));
		}
	}

	public unsafe static float MaxAlphaCutoff
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxAlphaCutoff, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxAlphaCutoff, (void*)(&num));
		}
	}

	public unsafe static string MainTexName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainTexName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainTexName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MaskTexName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaskTexName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaskTexName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TempTexName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TempTexName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TempTexName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ColorName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ColorName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ColorName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WidthName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WidthName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WidthName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string IntensityName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IntensityName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IntensityName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AlphaCutoffName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AlphaCutoffName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AlphaCutoffName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GaussSamplesName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GaussSamplesName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GaussSamplesName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UseDrawMeshFeatureName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UseDrawMeshFeatureName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UseDrawMeshFeatureName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EffectName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EffectName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EffectName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OutlineResourcesTooltip
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OutlineResourcesTooltip, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OutlineResourcesTooltip, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OutlineLayerCollectionTooltip
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OutlineLayerCollectionTooltip, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OutlineLayerCollectionTooltip, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OutlineLayerMaskTooltip
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OutlineLayerMaskTooltip, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OutlineLayerMaskTooltip, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OutlineRenderingLayerMaskTooltip
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OutlineRenderingLayerMaskTooltip, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OutlineRenderingLayerMaskTooltip, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int OutlineShaderHPassId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OutlineShaderHPassId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OutlineShaderHPassId, (void*)(&num));
		}
	}

	public unsafe static int OutlineShaderVPassId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OutlineShaderVPassId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OutlineShaderVPassId, (void*)(&num));
		}
	}

	public unsafe static string SrpNotSupported
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SrpNotSupported, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SrpNotSupported, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PpNotSupported
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PpNotSupported, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PpNotSupported, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int MainTexId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainTexId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainTexId)) = num;
		}
	}

	public unsafe RenderTargetIdentifier MainTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainTex);
			return *(RenderTargetIdentifier*)num;
		}
		set
		{
			*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainTex)) = renderTargetIdentifier;
		}
	}

	public unsafe int MaskTexId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaskTexId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaskTexId)) = num;
		}
	}

	public unsafe RenderTargetIdentifier MaskTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaskTex);
			return *(RenderTargetIdentifier*)num;
		}
		set
		{
			*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaskTex)) = renderTargetIdentifier;
		}
	}

	public unsafe int TempTexId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TempTexId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TempTexId)) = num;
		}
	}

	public unsafe RenderTargetIdentifier TempTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TempTex);
			return *(RenderTargetIdentifier*)num;
		}
		set
		{
			*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TempTex)) = renderTargetIdentifier;
		}
	}

	public unsafe int ColorId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorId)) = num;
		}
	}

	public unsafe int WidthId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WidthId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WidthId)) = num;
		}
	}

	public unsafe int IntensityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IntensityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IntensityId)) = num;
		}
	}

	public unsafe int AlphaCutoffId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlphaCutoffId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlphaCutoffId)) = num;
		}
	}

	public unsafe int GaussSamplesId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GaussSamplesId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GaussSamplesId)) = num;
		}
	}

	public unsafe List<Material> TmpMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TmpMaterials);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Material>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TmpMaterials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Shader RenderShader
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RenderShader_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
	}

	public unsafe Shader OutlineShader
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18747, RefRangeEnd = 18748, XrefRangeStart = 18747, XrefRangeEnd = 18748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OutlineShader_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
	}

	public unsafe Material RenderMaterial
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29125, RefRangeEnd = 29127, XrefRangeStart = 29112, XrefRangeEnd = 29125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RenderMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
	}

	public unsafe Material OutlineMaterial
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29143, RefRangeEnd = 29144, XrefRangeStart = 29127, XrefRangeEnd = 29143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OutlineMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
	}

	public unsafe MaterialPropertyBlock Properties
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29144, XrefRangeEnd = 29149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Properties_Public_get_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr) : null;
		}
	}

	public unsafe Mesh FullscreenTriangleMesh
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29149, XrefRangeEnd = 29171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FullscreenTriangleMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29171, XrefRangeEnd = 29172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FullscreenTriangleMesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool UseFullscreenTriangleMesh
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UseFullscreenTriangleMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29172, XrefRangeEnd = 29179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UseFullscreenTriangleMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool IsValid
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29179, XrefRangeEnd = 29183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static OutlineResources()
	{
		Il2CppClassPointerStore<OutlineResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "OutlineResources");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr);
		NativeFieldInfoPtr__renderShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "_renderShader");
		NativeFieldInfoPtr__outlineShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "_outlineShader");
		NativeFieldInfoPtr__renderMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "_renderMaterial");
		NativeFieldInfoPtr__outlineMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "_outlineMaterial");
		NativeFieldInfoPtr__props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "_props");
		NativeFieldInfoPtr__fullscreenTriangleMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "_fullscreenTriangleMesh");
		NativeFieldInfoPtr__gaussSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "_gaussSamples");
		NativeFieldInfoPtr__useDrawMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "_useDrawMesh");
		NativeFieldInfoPtr_MinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MinWidth");
		NativeFieldInfoPtr_MaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MaxWidth");
		NativeFieldInfoPtr_MinIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MinIntensity");
		NativeFieldInfoPtr_MaxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MaxIntensity");
		NativeFieldInfoPtr_SolidIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "SolidIntensity");
		NativeFieldInfoPtr_MinAlphaCutoff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MinAlphaCutoff");
		NativeFieldInfoPtr_MaxAlphaCutoff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MaxAlphaCutoff");
		NativeFieldInfoPtr_MainTexName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MainTexName");
		NativeFieldInfoPtr_MaskTexName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MaskTexName");
		NativeFieldInfoPtr_TempTexName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "TempTexName");
		NativeFieldInfoPtr_ColorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "ColorName");
		NativeFieldInfoPtr_WidthName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "WidthName");
		NativeFieldInfoPtr_IntensityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "IntensityName");
		NativeFieldInfoPtr_AlphaCutoffName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "AlphaCutoffName");
		NativeFieldInfoPtr_GaussSamplesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "GaussSamplesName");
		NativeFieldInfoPtr_UseDrawMeshFeatureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "UseDrawMeshFeatureName");
		NativeFieldInfoPtr_EffectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "EffectName");
		NativeFieldInfoPtr_OutlineResourcesTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "OutlineResourcesTooltip");
		NativeFieldInfoPtr_OutlineLayerCollectionTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "OutlineLayerCollectionTooltip");
		NativeFieldInfoPtr_OutlineLayerMaskTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "OutlineLayerMaskTooltip");
		NativeFieldInfoPtr_OutlineRenderingLayerMaskTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "OutlineRenderingLayerMaskTooltip");
		NativeFieldInfoPtr_OutlineShaderHPassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "OutlineShaderHPassId");
		NativeFieldInfoPtr_OutlineShaderVPassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "OutlineShaderVPassId");
		NativeFieldInfoPtr_SrpNotSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "SrpNotSupported");
		NativeFieldInfoPtr_PpNotSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "PpNotSupported");
		NativeFieldInfoPtr_MainTexId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MainTexId");
		NativeFieldInfoPtr_MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MainTex");
		NativeFieldInfoPtr_MaskTexId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MaskTexId");
		NativeFieldInfoPtr_MaskTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "MaskTex");
		NativeFieldInfoPtr_TempTexId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "TempTexId");
		NativeFieldInfoPtr_TempTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "TempTex");
		NativeFieldInfoPtr_ColorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "ColorId");
		NativeFieldInfoPtr_WidthId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "WidthId");
		NativeFieldInfoPtr_IntensityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "IntensityId");
		NativeFieldInfoPtr_AlphaCutoffId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "AlphaCutoffId");
		NativeFieldInfoPtr_GaussSamplesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "GaussSamplesId");
		NativeFieldInfoPtr_TmpMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, "TmpMaterials");
		NativeMethodInfoPtr_get_RenderShader_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664309);
		NativeMethodInfoPtr_get_OutlineShader_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664310);
		NativeMethodInfoPtr_get_RenderMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664311);
		NativeMethodInfoPtr_get_OutlineMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664312);
		NativeMethodInfoPtr_get_Properties_Public_get_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664313);
		NativeMethodInfoPtr_get_FullscreenTriangleMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664314);
		NativeMethodInfoPtr_set_FullscreenTriangleMesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664315);
		NativeMethodInfoPtr_get_UseFullscreenTriangleMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664316);
		NativeMethodInfoPtr_set_UseFullscreenTriangleMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664317);
		NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664318);
		NativeMethodInfoPtr_GetProperties_Public_MaterialPropertyBlock_IOutlineSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664319);
		NativeMethodInfoPtr_GetGaussSamples_Public_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664320);
		NativeMethodInfoPtr_ResetToDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664321);
		NativeMethodInfoPtr_Gauss_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664322);
		NativeMethodInfoPtr_GetGaussSamples_Public_Static_Il2CppStructArray_1_Single_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664323);
		NativeMethodInfoPtr_LogSrpNotSupported_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664324);
		NativeMethodInfoPtr_LogPpNotSupported_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664325);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664326);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr, 100664327);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29202, RefRangeEnd = 29203, XrefRangeStart = 29183, XrefRangeEnd = 29202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaterialPropertyBlock GetProperties(IOutlineSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProperties_Public_MaterialPropertyBlock_IOutlineSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29223, RefRangeEnd = 29224, XrefRangeStart = 29203, XrefRangeEnd = 29223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<float> GetGaussSamples(int width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&width);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGaussSamples_Public_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29224, XrefRangeEnd = 29232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetToDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetToDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29232, XrefRangeEnd = 29241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Gauss(float x, float stdDev)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &stdDev;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Gauss_Public_Static_Single_Single_Single_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29241, XrefRangeEnd = 29253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<float> GetGaussSamples(int width, Il2CppStructArray<float> samples)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&width);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)samples);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGaussSamples_Public_Static_Il2CppStructArray_1_Single_Int32_Il2CppStructArray_1_Single_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29253, XrefRangeEnd = 29270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogSrpNotSupported(UnityEngine.Object obj)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogSrpNotSupported_Public_Static_Void_Object_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29270, XrefRangeEnd = 29286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogPpNotSupported(UnityEngine.Object obj)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogPpNotSupported_Public_Static_Void_Object_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29286, XrefRangeEnd = 29295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29295, XrefRangeEnd = 29333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutlineResources()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutlineResources>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OutlineResources(IntPtr pointer)
		: base(pointer)
	{
	}
}

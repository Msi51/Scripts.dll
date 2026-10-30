using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CustomScreenSpaceAmbientOcclusionFeature : ScriptableRendererFeature
{
	public class ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass
	{
		public enum ShaderPasses
		{
			AO,
			BlurHorizontal,
			BlurVertical,
			BlurFinal,
			AfterOpaque
		}

		private static readonly IntPtr NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat;

		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		private static readonly IntPtr NativeFieldInfoPtr_m_CameraTopLeftCorner;

		private static readonly IntPtr NativeFieldInfoPtr_m_CameraXExtent;

		private static readonly IntPtr NativeFieldInfoPtr_m_CameraYExtent;

		private static readonly IntPtr NativeFieldInfoPtr_m_CameraZExtent;

		private static readonly IntPtr NativeFieldInfoPtr_m_CameraViewProjections;

		private static readonly IntPtr NativeFieldInfoPtr_m_Renderer;

		private static readonly IntPtr NativeFieldInfoPtr_m_SSAOTexture1Target;

		private static readonly IntPtr NativeFieldInfoPtr_m_SSAOTexture2Target;

		private static readonly IntPtr NativeFieldInfoPtr_m_SSAOTexture3Target;

		private static readonly IntPtr NativeFieldInfoPtr_m_SSAOTextureFinalTarget;

		private static readonly IntPtr NativeFieldInfoPtr_m_AOPassDescriptor;

		private static readonly IntPtr NativeFieldInfoPtr_m_BlurPassesDescriptor;

		private static readonly IntPtr NativeFieldInfoPtr_m_FinalDescriptor;

		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSettings;

		private static readonly IntPtr NativeFieldInfoPtr_k_SSAOTextureName;

		private static readonly IntPtr NativeFieldInfoPtr_k_SSAOAmbientOcclusionParamName;

		private static readonly IntPtr NativeFieldInfoPtr_s_BaseMapID;

		private static readonly IntPtr NativeFieldInfoPtr_s_SSAOParamsID;

		private static readonly IntPtr NativeFieldInfoPtr_s_SSAOTexture1ID;

		private static readonly IntPtr NativeFieldInfoPtr_s_SSAOTexture2ID;

		private static readonly IntPtr NativeFieldInfoPtr_s_SSAOTexture3ID;

		private static readonly IntPtr NativeFieldInfoPtr_s_SSAOTextureFinalID;

		private static readonly IntPtr NativeFieldInfoPtr_s_CameraViewXExtentID;

		private static readonly IntPtr NativeFieldInfoPtr_s_CameraViewYExtentID;

		private static readonly IntPtr NativeFieldInfoPtr_s_CameraViewZExtentID;

		private static readonly IntPtr NativeFieldInfoPtr_s_ProjectionParams2ID;

		private static readonly IntPtr NativeFieldInfoPtr_s_CameraViewProjectionsID;

		private static readonly IntPtr NativeFieldInfoPtr_s_CameraViewTopLeftCornerID;

		private static readonly IntPtr NativeMethodInfoPtr_get_isRendererDeferred_Private_get_Boolean_0;

		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Boolean_ScreenSpaceAmbientOcclusionSettings_ScriptableRenderer_Material_0;

		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		private static readonly IntPtr NativeMethodInfoPtr_Render_Private_Void_CommandBuffer_RenderTargetIdentifier_ShaderPasses_0;

		private static readonly IntPtr NativeMethodInfoPtr_RenderAndSetBaseMap_Private_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ShaderPasses_0;

		private static readonly IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;

		public unsafe bool m_SupportsR8RenderTextureFormat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat)) = flag;
			}
		}

		public unsafe Material m_Material
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Material);
				IntPtr intPtr = *(IntPtr*)num;
				return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		public unsafe Il2CppStructArray<Vector4> m_CameraTopLeftCorner
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraTopLeftCorner);
				IntPtr intPtr = *(IntPtr*)num;
				return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
			}
			set
			{
				IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraTopLeftCorner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<Vector4> m_CameraXExtent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraXExtent);
				IntPtr intPtr = *(IntPtr*)num;
				return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
			}
			set
			{
				IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraXExtent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<Vector4> m_CameraYExtent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraYExtent);
				IntPtr intPtr = *(IntPtr*)num;
				return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
			}
			set
			{
				IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraYExtent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<Vector4> m_CameraZExtent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraZExtent);
				IntPtr intPtr = *(IntPtr*)num;
				return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
			}
			set
			{
				IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraZExtent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<Matrix4x4> m_CameraViewProjections
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraViewProjections);
				IntPtr intPtr = *(IntPtr*)num;
				return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr) : null;
			}
			set
			{
				IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraViewProjections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe ScriptableRenderer m_Renderer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Renderer);
				IntPtr intPtr = *(IntPtr*)num;
				return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr) : null;
			}
			set
			{
				IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Renderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scriptableRenderer));
			}
		}

		public unsafe RenderTargetIdentifier m_SSAOTexture1Target
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOTexture1Target);
				return *(RenderTargetIdentifier*)num;
			}
			set
			{
				*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOTexture1Target)) = renderTargetIdentifier;
			}
		}

		public unsafe RenderTargetIdentifier m_SSAOTexture2Target
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOTexture2Target);
				return *(RenderTargetIdentifier*)num;
			}
			set
			{
				*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOTexture2Target)) = renderTargetIdentifier;
			}
		}

		public unsafe RenderTargetIdentifier m_SSAOTexture3Target
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOTexture3Target);
				return *(RenderTargetIdentifier*)num;
			}
			set
			{
				*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOTexture3Target)) = renderTargetIdentifier;
			}
		}

		public unsafe RenderTargetIdentifier m_SSAOTextureFinalTarget
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOTextureFinalTarget);
				return *(RenderTargetIdentifier*)num;
			}
			set
			{
				*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOTextureFinalTarget)) = renderTargetIdentifier;
			}
		}

		public unsafe RenderTextureDescriptor m_AOPassDescriptor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AOPassDescriptor);
				return *(RenderTextureDescriptor*)num;
			}
			set
			{
				*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AOPassDescriptor)) = renderTextureDescriptor;
			}
		}

		public unsafe RenderTextureDescriptor m_BlurPassesDescriptor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlurPassesDescriptor);
				return *(RenderTextureDescriptor*)num;
			}
			set
			{
				*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlurPassesDescriptor)) = renderTextureDescriptor;
			}
		}

		public unsafe RenderTextureDescriptor m_FinalDescriptor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinalDescriptor);
				return *(RenderTextureDescriptor*)num;
			}
			set
			{
				*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinalDescriptor)) = renderTextureDescriptor;
			}
		}

		public unsafe ScreenSpaceAmbientOcclusionSettings m_CurrentSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentSettings);
				IntPtr intPtr = *(IntPtr*)num;
				return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ScreenSpaceAmbientOcclusionSettings>(intPtr) : null;
			}
			set
			{
				IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screenSpaceAmbientOcclusionSettings));
			}
		}

		public unsafe static string k_SSAOTextureName
		{
			get
			{
				Unsafe.SkipInit(out IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SSAOTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SSAOTextureName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe static string k_SSAOAmbientOcclusionParamName
		{
			get
			{
				Unsafe.SkipInit(out IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SSAOAmbientOcclusionParamName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SSAOAmbientOcclusionParamName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe static int s_BaseMapID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BaseMapID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BaseMapID, (void*)(&num));
			}
		}

		public unsafe static int s_SSAOParamsID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SSAOParamsID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SSAOParamsID, (void*)(&num));
			}
		}

		public unsafe static int s_SSAOTexture1ID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SSAOTexture1ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SSAOTexture1ID, (void*)(&num));
			}
		}

		public unsafe static int s_SSAOTexture2ID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SSAOTexture2ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SSAOTexture2ID, (void*)(&num));
			}
		}

		public unsafe static int s_SSAOTexture3ID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SSAOTexture3ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SSAOTexture3ID, (void*)(&num));
			}
		}

		public unsafe static int s_SSAOTextureFinalID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SSAOTextureFinalID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SSAOTextureFinalID, (void*)(&num));
			}
		}

		public unsafe static int s_CameraViewXExtentID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraViewXExtentID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraViewXExtentID, (void*)(&num));
			}
		}

		public unsafe static int s_CameraViewYExtentID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraViewYExtentID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraViewYExtentID, (void*)(&num));
			}
		}

		public unsafe static int s_CameraViewZExtentID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraViewZExtentID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraViewZExtentID, (void*)(&num));
			}
		}

		public unsafe static int s_ProjectionParams2ID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ProjectionParams2ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ProjectionParams2ID, (void*)(&num));
			}
		}

		public unsafe static int s_CameraViewProjectionsID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraViewProjectionsID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraViewProjectionsID, (void*)(&num));
			}
		}

		public unsafe static int s_CameraViewTopLeftCornerID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraViewTopLeftCornerID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraViewTopLeftCornerID, (void*)(&num));
			}
		}

		public unsafe bool isRendererDeferred
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29440, XrefRangeEnd = 29441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IntPtr* ptr = null;
				Unsafe.SkipInit(out IntPtr intPtr2);
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRendererDeferred_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static ScreenSpaceAmbientOcclusionPass()
		{
			Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "ScreenSpaceAmbientOcclusionPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr);
			NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_SupportsR8RenderTextureFormat");
			NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_Material");
			NativeFieldInfoPtr_m_CameraTopLeftCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraTopLeftCorner");
			NativeFieldInfoPtr_m_CameraXExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraXExtent");
			NativeFieldInfoPtr_m_CameraYExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraYExtent");
			NativeFieldInfoPtr_m_CameraZExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraZExtent");
			NativeFieldInfoPtr_m_CameraViewProjections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraViewProjections");
			NativeFieldInfoPtr_m_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_Renderer");
			NativeFieldInfoPtr_m_SSAOTexture1Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_SSAOTexture1Target");
			NativeFieldInfoPtr_m_SSAOTexture2Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_SSAOTexture2Target");
			NativeFieldInfoPtr_m_SSAOTexture3Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_SSAOTexture3Target");
			NativeFieldInfoPtr_m_SSAOTextureFinalTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_SSAOTextureFinalTarget");
			NativeFieldInfoPtr_m_AOPassDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_AOPassDescriptor");
			NativeFieldInfoPtr_m_BlurPassesDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BlurPassesDescriptor");
			NativeFieldInfoPtr_m_FinalDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_FinalDescriptor");
			NativeFieldInfoPtr_m_CurrentSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CurrentSettings");
			NativeFieldInfoPtr_k_SSAOTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "k_SSAOTextureName");
			NativeFieldInfoPtr_k_SSAOAmbientOcclusionParamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "k_SSAOAmbientOcclusionParamName");
			NativeFieldInfoPtr_s_BaseMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_BaseMapID");
			NativeFieldInfoPtr_s_SSAOParamsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_SSAOParamsID");
			NativeFieldInfoPtr_s_SSAOTexture1ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_SSAOTexture1ID");
			NativeFieldInfoPtr_s_SSAOTexture2ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_SSAOTexture2ID");
			NativeFieldInfoPtr_s_SSAOTexture3ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_SSAOTexture3ID");
			NativeFieldInfoPtr_s_SSAOTextureFinalID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_SSAOTextureFinalID");
			NativeFieldInfoPtr_s_CameraViewXExtentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewXExtentID");
			NativeFieldInfoPtr_s_CameraViewYExtentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewYExtentID");
			NativeFieldInfoPtr_s_CameraViewZExtentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewZExtentID");
			NativeFieldInfoPtr_s_ProjectionParams2ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_ProjectionParams2ID");
			NativeFieldInfoPtr_s_CameraViewProjectionsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewProjectionsID");
			NativeFieldInfoPtr_s_CameraViewTopLeftCornerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewTopLeftCornerID");
			NativeMethodInfoPtr_get_isRendererDeferred_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100664382);
			NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100664383);
			NativeMethodInfoPtr_Setup_Internal_Boolean_ScreenSpaceAmbientOcclusionSettings_ScriptableRenderer_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100664384);
			NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100664385);
			NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100664386);
			NativeMethodInfoPtr_Render_Private_Void_CommandBuffer_RenderTargetIdentifier_ShaderPasses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100664387);
			NativeMethodInfoPtr_RenderAndSetBaseMap_Private_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ShaderPasses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100664388);
			NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100664389);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29476, RefRangeEnd = 29477, XrefRangeStart = 29441, XrefRangeEnd = 29476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenSpaceAmbientOcclusionPass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29477, XrefRangeEnd = 29486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Setup(ScreenSpaceAmbientOcclusionSettings featureSettings, ScriptableRenderer renderer, Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)featureSettings);
			*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
			*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Internal_Boolean_ScreenSpaceAmbientOcclusionSettings_ScriptableRenderer_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29486, XrefRangeEnd = 29583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
			*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData));
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29583, XrefRangeEnd = 29662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[2];
			*ptr = (nint)(&context);
			*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData));
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 29670, RefRangeEnd = 29675, XrefRangeStart = 29662, XrefRangeEnd = 29670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(CommandBuffer cmd, RenderTargetIdentifier target, ShaderPasses pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
			*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &target;
			*(ShaderPasses**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &pass;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Private_Void_CommandBuffer_RenderTargetIdentifier_ShaderPasses_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29675, XrefRangeEnd = 29681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderAndSetBaseMap(CommandBuffer cmd, RenderTargetIdentifier baseMap, RenderTargetIdentifier target, ShaderPasses pass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
			*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &baseMap;
			*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &target;
			*(ShaderPasses**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &pass;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderAndSetBaseMap_Private_Void_CommandBuffer_RenderTargetIdentifier_RenderTargetIdentifier_ShaderPasses_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29681, XrefRangeEnd = 29706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraCleanup(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ScreenSpaceAmbientOcclusionPass(IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly IntPtr NativeFieldInfoPtr__SourceSize;

	private static readonly IntPtr NativeFieldInfoPtr_m_Shader;

	private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

	private static readonly IntPtr NativeFieldInfoPtr_m_Material;

	private static readonly IntPtr NativeFieldInfoPtr_m_SSAOPass;

	private static readonly IntPtr NativeFieldInfoPtr_k_ShaderName;

	private static readonly IntPtr NativeFieldInfoPtr_k_OrthographicCameraKeyword;

	private static readonly IntPtr NativeFieldInfoPtr_k_NormalReconstructionLowKeyword;

	private static readonly IntPtr NativeFieldInfoPtr_k_NormalReconstructionMediumKeyword;

	private static readonly IntPtr NativeFieldInfoPtr_k_NormalReconstructionHighKeyword;

	private static readonly IntPtr NativeFieldInfoPtr_k_SourceDepthKeyword;

	private static readonly IntPtr NativeFieldInfoPtr_k_SourceDepthNormalsKeyword;

	private static readonly IntPtr NativeMethodInfoPtr_get_afterOpaque_Internal_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSourceSize_Private_Static_Void_CommandBuffer_RenderTextureDescriptor_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int _SourceSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SourceSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SourceSize, (void*)(&num));
		}
	}

	public unsafe Shader m_Shader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Shader);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Shader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader));
		}
	}

	public unsafe ScreenSpaceAmbientOcclusionSettings m_Settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Settings);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ScreenSpaceAmbientOcclusionSettings>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Settings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screenSpaceAmbientOcclusionSettings));
		}
	}

	public unsafe Material m_Material
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Material);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe ScreenSpaceAmbientOcclusionPass m_SSAOPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOPass);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ScreenSpaceAmbientOcclusionPass>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screenSpaceAmbientOcclusionPass));
		}
	}

	public unsafe static string k_ShaderName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShaderName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShaderName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string k_OrthographicCameraKeyword
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_OrthographicCameraKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_OrthographicCameraKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string k_NormalReconstructionLowKeyword
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_NormalReconstructionLowKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_NormalReconstructionLowKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string k_NormalReconstructionMediumKeyword
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_NormalReconstructionMediumKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_NormalReconstructionMediumKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string k_NormalReconstructionHighKeyword
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_NormalReconstructionHighKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_NormalReconstructionHighKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string k_SourceDepthKeyword
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SourceDepthKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SourceDepthKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string k_SourceDepthNormalsKeyword
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SourceDepthNormalsKeyword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SourceDepthNormalsKeyword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool afterOpaque
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_afterOpaque_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static CustomScreenSpaceAmbientOcclusionFeature()
	{
		Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CustomScreenSpaceAmbientOcclusionFeature");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr);
		NativeFieldInfoPtr__SourceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "_SourceSize");
		NativeFieldInfoPtr_m_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "m_Shader");
		NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "m_Settings");
		NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "m_Material");
		NativeFieldInfoPtr_m_SSAOPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "m_SSAOPass");
		NativeFieldInfoPtr_k_ShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "k_ShaderName");
		NativeFieldInfoPtr_k_OrthographicCameraKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "k_OrthographicCameraKeyword");
		NativeFieldInfoPtr_k_NormalReconstructionLowKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "k_NormalReconstructionLowKeyword");
		NativeFieldInfoPtr_k_NormalReconstructionMediumKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "k_NormalReconstructionMediumKeyword");
		NativeFieldInfoPtr_k_NormalReconstructionHighKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "k_NormalReconstructionHighKeyword");
		NativeFieldInfoPtr_k_SourceDepthKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "k_SourceDepthKeyword");
		NativeFieldInfoPtr_k_SourceDepthNormalsKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, "k_SourceDepthNormalsKeyword");
		NativeMethodInfoPtr_get_afterOpaque_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, 100664374);
		NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, 100664375);
		NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, 100664376);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, 100664377);
		NativeMethodInfoPtr_GetMaterial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, 100664378);
		NativeMethodInfoPtr_SetSourceSize_Private_Static_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, 100664379);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr, 100664380);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29706, XrefRangeEnd = 29713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Create()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29713, XrefRangeEnd = 29738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29738, XrefRangeEnd = 29742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29757, RefRangeEnd = 29759, XrefRangeStart = 29742, XrefRangeEnd = 29757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetMaterial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29767, RefRangeEnd = 29769, XrefRangeStart = 29759, XrefRangeEnd = 29767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSourceSize(CommandBuffer cmd, RenderTextureDescriptor desc)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &desc;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourceSize_Private_Static_Void_CommandBuffer_RenderTextureDescriptor_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29769, XrefRangeEnd = 29776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomScreenSpaceAmbientOcclusionFeature()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomScreenSpaceAmbientOcclusionFeature>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CustomScreenSpaceAmbientOcclusionFeature(IntPtr pointer)
		: base(pointer)
	{
	}
}

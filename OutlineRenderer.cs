using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public sealed class OutlineRenderer : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__defaultRenderPassId;

	private static readonly System.IntPtr NativeFieldInfoPtr__alphaTestRenderPassId;

	private static readonly System.IntPtr NativeFieldInfoPtr__rtDimention;

	private static readonly System.IntPtr NativeFieldInfoPtr__rt;

	private static readonly System.IntPtr NativeFieldInfoPtr__depth;

	private static readonly System.IntPtr NativeFieldInfoPtr__commandBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr__resources;

	private static readonly System.IntPtr NativeFieldInfoPtr_RenderEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_RtFormat;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderingPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_RenderingPath_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_RenderTargetIdentifier_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_RenderTargetIdentifier_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Public_Void_IReadOnlyList_1_Renderer_IOutlineSettings_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Public_Void_Renderer_IOutlineSettings_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBuiltinDepth_Public_Static_RenderTargetIdentifier_RenderingPath_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderObjectClear_Public_Void_OutlineRenderFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderOutline_Public_Void_IOutlineSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawRenderer_Private_Void_Renderer_IOutlineSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blit_Private_Void_RenderTargetIdentifier_Int32_Material_MaterialPropertyBlock_0;

	public unsafe static int _defaultRenderPassId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__defaultRenderPassId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__defaultRenderPassId, (void*)(&num));
		}
	}

	public unsafe static int _alphaTestRenderPassId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__alphaTestRenderPassId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__alphaTestRenderPassId, (void*)(&num));
		}
	}

	public unsafe TextureDimension _rtDimention
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rtDimention);
			return *(TextureDimension*)num;
		}
		set
		{
			*(TextureDimension*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rtDimention)) = textureDimension;
		}
	}

	public unsafe RenderTargetIdentifier _rt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rt);
			return *(RenderTargetIdentifier*)num;
		}
		set
		{
			*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rt)) = renderTargetIdentifier;
		}
	}

	public unsafe RenderTargetIdentifier _depth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__depth);
			return *(RenderTargetIdentifier*)num;
		}
		set
		{
			*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__depth)) = renderTargetIdentifier;
		}
	}

	public unsafe CommandBuffer _commandBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__commandBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__commandBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commandBuffer));
		}
	}

	public unsafe OutlineResources _resources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OutlineResources>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outlineResources));
		}
	}

	public unsafe static CameraEvent RenderEvent
	{
		get
		{
			Unsafe.SkipInit(out CameraEvent result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RenderEvent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RenderEvent, (void*)(&cameraEvent));
		}
	}

	public unsafe static RenderTextureFormat RtFormat
	{
		get
		{
			Unsafe.SkipInit(out RenderTextureFormat result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RtFormat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RtFormat, (void*)(&renderTextureFormat));
		}
	}

	static OutlineRenderer()
	{
		Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "OutlineRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr);
		NativeFieldInfoPtr__defaultRenderPassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, "_defaultRenderPassId");
		NativeFieldInfoPtr__alphaTestRenderPassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, "_alphaTestRenderPassId");
		NativeFieldInfoPtr__rtDimention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, "_rtDimention");
		NativeFieldInfoPtr__rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, "_rt");
		NativeFieldInfoPtr__depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, "_depth");
		NativeFieldInfoPtr__commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, "_commandBuffer");
		NativeFieldInfoPtr__resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, "_resources");
		NativeFieldInfoPtr_RenderEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, "RenderEvent");
		NativeFieldInfoPtr_RtFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, "RtFormat");
		NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664295);
		NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderingPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664296);
		NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664297);
		NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_RenderingPath_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664298);
		NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_RenderTargetIdentifier_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664299);
		NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_RenderTargetIdentifier_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664300);
		NativeMethodInfoPtr_Render_Public_Void_IReadOnlyList_1_Renderer_IOutlineSettings_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664301);
		NativeMethodInfoPtr_Render_Public_Void_Renderer_IOutlineSettings_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664302);
		NativeMethodInfoPtr_GetBuiltinDepth_Public_Static_RenderTargetIdentifier_RenderingPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664303);
		NativeMethodInfoPtr_RenderObjectClear_Public_Void_OutlineRenderFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664304);
		NativeMethodInfoPtr_RenderOutline_Public_Void_IOutlineSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664305);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664306);
		NativeMethodInfoPtr_DrawRenderer_Private_Void_Renderer_IOutlineSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664307);
		NativeMethodInfoPtr_Blit_Private_Void_RenderTargetIdentifier_Int32_Material_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr, 100664308);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28957, XrefRangeEnd = 28962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutlineRenderer(CommandBuffer cmd, OutlineResources resources)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28962, XrefRangeEnd = 28967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutlineRenderer(CommandBuffer cmd, OutlineResources resources, RenderingPath renderingPath)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(RenderingPath**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderingPath;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderingPath_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28967, XrefRangeEnd = 28971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutlineRenderer(CommandBuffer cmd, OutlineResources resources, RenderTargetIdentifier dst)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28971, XrefRangeEnd = 28973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutlineRenderer(CommandBuffer cmd, OutlineResources resources, RenderTargetIdentifier dst, RenderingPath renderingPath, Vector2Int rtSize)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		*(RenderingPath**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderingPath;
		*(Vector2Int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rtSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_RenderingPath_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 28984, RefRangeEnd = 28988, XrefRangeStart = 28973, XrefRangeEnd = 28984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutlineRenderer(CommandBuffer cmd, OutlineResources resources, RenderTargetIdentifier dst, RenderTargetIdentifier depth, Vector2Int rtSize)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(Vector2Int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rtSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_RenderTargetIdentifier_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28988, XrefRangeEnd = 28994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OutlineRenderer(CommandBuffer cmd, OutlineResources resources, RenderTargetIdentifier dst, RenderTargetIdentifier depth, RenderTextureDescriptor rtDesc)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dst;
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rtDesc;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CommandBuffer_OutlineResources_RenderTargetIdentifier_RenderTargetIdentifier_RenderTextureDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28994, XrefRangeEnd = 29017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Render(IReadOnlyList<Renderer> renderers, IOutlineSettings settings, string sampleName = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sampleName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Public_Void_IReadOnlyList_1_Renderer_IOutlineSettings_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29017, XrefRangeEnd = 29042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Render(Renderer renderer, IOutlineSettings settings, string sampleName = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sampleName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Public_Void_Renderer_IOutlineSettings_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29042, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTargetIdentifier GetBuiltinDepth(RenderingPath renderingPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renderingPath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBuiltinDepth_Public_Static_RenderTargetIdentifier_RenderingPath_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29053, XrefRangeStart = 29043, XrefRangeEnd = 29051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderObjectClear(OutlineRenderFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderObjectClear_Public_Void_OutlineRenderFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29064, RefRangeEnd = 29066, XrefRangeStart = 29053, XrefRangeEnd = 29064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderOutline(IOutlineSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderOutline_Public_Void_IOutlineSettings_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29066, XrefRangeEnd = 29069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29102, RefRangeEnd = 29104, XrefRangeStart = 29069, XrefRangeEnd = 29102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawRenderer(Renderer renderer, IOutlineSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawRenderer_Private_Void_Renderer_IOutlineSettings_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29110, RefRangeEnd = 29112, XrefRangeStart = 29104, XrefRangeEnd = 29110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Blit(RenderTargetIdentifier src, int shaderPass, Material mat, MaterialPropertyBlock props)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shaderPass;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)props);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blit_Private_Void_RenderTargetIdentifier_Int32_Material_MaterialPropertyBlock_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OutlineRenderer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public OutlineRenderer()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutlineRenderer>.NativeClassPtr))
	{
	}
}

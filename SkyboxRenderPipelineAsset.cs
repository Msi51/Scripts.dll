using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;

public class SkyboxRenderPipelineAsset : RenderPipelineAsset
{
	private static readonly IntPtr NativeMethodInfoPtr_CreatePipeline_Protected_Virtual_RenderPipeline_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static SkyboxRenderPipelineAsset()
	{
		Il2CppClassPointerStore<SkyboxRenderPipelineAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SkyboxRenderPipelineAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyboxRenderPipelineAsset>.NativeClassPtr);
		NativeMethodInfoPtr_CreatePipeline_Protected_Virtual_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxRenderPipelineAsset>.NativeClassPtr, 100664435);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxRenderPipelineAsset>.NativeClassPtr, 100664436);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30217, XrefRangeEnd = 30221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override RenderPipeline CreatePipeline()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreatePipeline_Protected_Virtual_RenderPipeline_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30221, XrefRangeEnd = 30222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkyboxRenderPipelineAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyboxRenderPipelineAsset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkyboxRenderPipelineAsset(IntPtr pointer)
		: base(pointer)
	{
	}
}

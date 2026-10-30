using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;
using UnityEngine.Rendering;

public class SkyboxRenderPipeline : RenderPipeline
{
	private static readonly IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static SkyboxRenderPipeline()
	{
		Il2CppClassPointerStore<SkyboxRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SkyboxRenderPipeline");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyboxRenderPipeline>.NativeClassPtr);
		NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxRenderPipeline>.NativeClassPtr, 100664433);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxRenderPipeline>.NativeClassPtr, 100664434);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30200, XrefRangeEnd = 30217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Render(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&context);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Render_Protected_Virtual_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(283)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 284, XrefRangeStart = 1, XrefRangeEnd = 284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkyboxRenderPipeline()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyboxRenderPipeline>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkyboxRenderPipeline(IntPtr pointer)
		: base(pointer)
	{
	}
}

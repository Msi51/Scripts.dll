using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Rendering.Universal;

[System.Serializable]
public class ScreenSpaceShadowsSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_passEvent;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RenderPassEvent passEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passEvent);
			return *(RenderPassEvent*)num;
		}
		set
		{
			*(RenderPassEvent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passEvent)) = renderPassEvent;
		}
	}

	static ScreenSpaceShadowsSettings()
	{
		Il2CppClassPointerStore<ScreenSpaceShadowsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ScreenSpaceShadowsSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceShadowsSettings>.NativeClassPtr);
		NativeFieldInfoPtr_passEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceShadowsSettings>.NativeClassPtr, "passEvent");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceShadowsSettings>.NativeClassPtr, 100664391);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenSpaceShadowsSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceShadowsSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ScreenSpaceShadowsSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

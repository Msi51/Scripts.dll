using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowCataloguePopupUIEvent : GameEvent<ShowCataloguePopupUIEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowCataloguePopupUIEventParams_0;

	static ShowCataloguePopupUIEvent()
	{
		Il2CppClassPointerStore<ShowCataloguePopupUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowCataloguePopupUIEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowCataloguePopupUIEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowCataloguePopupUIEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowCataloguePopupUIEvent>.NativeClassPtr, 100663485);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4344, RefRangeEnd = 4345, XrefRangeStart = 4341, XrefRangeEnd = 4344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowCataloguePopupUIEvent(GameEventHandler<ShowCataloguePopupUIEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowCataloguePopupUIEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowCataloguePopupUIEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowCataloguePopupUIEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

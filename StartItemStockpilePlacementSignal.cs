using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class StartItemStockpilePlacementSignal : Signal<StartItemStockpilePlacementSignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static StartItemStockpilePlacementSignal()
	{
		Il2CppClassPointerStore<StartItemStockpilePlacementSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartItemStockpilePlacementSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartItemStockpilePlacementSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartItemStockpilePlacementSignal>.NativeClassPtr, 100679588);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233512, XrefRangeEnd = 233515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartItemStockpilePlacementSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartItemStockpilePlacementSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartItemStockpilePlacementSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

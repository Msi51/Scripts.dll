using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class ShowCraftingQueueUISignal : Signal
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ShowCraftingQueueUISignal()
	{
		Il2CppClassPointerStore<ShowCraftingQueueUISignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowCraftingQueueUISignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowCraftingQueueUISignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowCraftingQueueUISignal>.NativeClassPtr, 100679559);
	}

	[CallerCount(283)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 284, XrefRangeStart = 1, XrefRangeEnd = 284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowCraftingQueueUISignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowCraftingQueueUISignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowCraftingQueueUISignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

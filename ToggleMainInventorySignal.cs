using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class ToggleMainInventorySignal : Signal<ToggleMainInventorySignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ToggleMainInventorySignal()
	{
		Il2CppClassPointerStore<ToggleMainInventorySignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ToggleMainInventorySignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleMainInventorySignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleMainInventorySignal>.NativeClassPtr, 100679566);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233446, XrefRangeEnd = 233449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ToggleMainInventorySignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleMainInventorySignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ToggleMainInventorySignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

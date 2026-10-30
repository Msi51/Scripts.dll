using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class PointerFocusUIShownSignal : Signal<PointerFocusUIShownSignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PointerFocusUIShownSignal()
	{
		Il2CppClassPointerStore<PointerFocusUIShownSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PointerFocusUIShownSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerFocusUIShownSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerFocusUIShownSignal>.NativeClassPtr, 100679574);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233470, XrefRangeEnd = 233473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PointerFocusUIShownSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerFocusUIShownSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PointerFocusUIShownSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

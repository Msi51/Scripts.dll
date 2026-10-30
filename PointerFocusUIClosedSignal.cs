using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class PointerFocusUIClosedSignal : Signal<PointerFocusUIClosedSignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PointerFocusUIClosedSignal()
	{
		Il2CppClassPointerStore<PointerFocusUIClosedSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PointerFocusUIClosedSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerFocusUIClosedSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerFocusUIClosedSignal>.NativeClassPtr, 100679575);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233473, XrefRangeEnd = 233476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PointerFocusUIClosedSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerFocusUIClosedSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PointerFocusUIClosedSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

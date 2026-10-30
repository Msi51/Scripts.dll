using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class StartSignal : Signal
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static StartSignal()
	{
		Il2CppClassPointerStore<StartSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSignal>.NativeClassPtr, 100679553);
	}

	[CallerCount(283)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 284, XrefRangeStart = 1, XrefRangeEnd = 284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

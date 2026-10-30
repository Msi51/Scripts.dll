using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class ConstructionCompleteSignal : Signal<ConstructionCompleteSignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ConstructionCompleteSignal()
	{
		Il2CppClassPointerStore<ConstructionCompleteSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConstructionCompleteSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionCompleteSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCompleteSignal>.NativeClassPtr, 100679589);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233515, XrefRangeEnd = 233518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConstructionCompleteSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCompleteSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ConstructionCompleteSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

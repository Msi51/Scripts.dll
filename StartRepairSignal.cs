using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class StartRepairSignal : Signal<StartRepairSignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static StartRepairSignal()
	{
		Il2CppClassPointerStore<StartRepairSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartRepairSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartRepairSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartRepairSignal>.NativeClassPtr, 100679649);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233674, XrefRangeEnd = 233677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartRepairSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartRepairSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartRepairSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class ShowWorkbenchUISignal : Signal<ShowWorkbenchUISignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ShowWorkbenchUISignal()
	{
		Il2CppClassPointerStore<ShowWorkbenchUISignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowWorkbenchUISignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowWorkbenchUISignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowWorkbenchUISignal>.NativeClassPtr, 100679598);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233542, XrefRangeEnd = 233545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowWorkbenchUISignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowWorkbenchUISignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowWorkbenchUISignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

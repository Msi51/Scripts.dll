using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class IgnitedFuelDepletedSignal : Signal<Entity>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static IgnitedFuelDepletedSignal()
	{
		Il2CppClassPointerStore<IgnitedFuelDepletedSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IgnitedFuelDepletedSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnitedFuelDepletedSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnitedFuelDepletedSignal>.NativeClassPtr, 100679600);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233548, XrefRangeEnd = 233551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IgnitedFuelDepletedSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnitedFuelDepletedSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IgnitedFuelDepletedSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

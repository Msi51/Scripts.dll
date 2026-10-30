using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class DamageDealtSignal : Signal<DamageDealtSignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static DamageDealtSignal()
	{
		Il2CppClassPointerStore<DamageDealtSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DamageDealtSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageDealtSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DamageDealtSignal>.NativeClassPtr, 100679641);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233650, XrefRangeEnd = 233653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DamageDealtSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DamageDealtSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DamageDealtSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

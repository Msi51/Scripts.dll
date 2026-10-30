using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class FadeScreenOutSignal : Signal<float>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static FadeScreenOutSignal()
	{
		Il2CppClassPointerStore<FadeScreenOutSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FadeScreenOutSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeScreenOutSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeScreenOutSignal>.NativeClassPtr, 100679621);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233590, XrefRangeEnd = 233593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FadeScreenOutSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeScreenOutSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FadeScreenOutSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

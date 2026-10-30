using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;
using UnityEngine;

public class ShowRadialMenuSignal : Signal<LocalPlayer, Vector2>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ShowRadialMenuSignal()
	{
		Il2CppClassPointerStore<ShowRadialMenuSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowRadialMenuSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowRadialMenuSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowRadialMenuSignal>.NativeClassPtr, 100679624);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233599, XrefRangeEnd = 233602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowRadialMenuSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowRadialMenuSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowRadialMenuSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

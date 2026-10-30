using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

public static class ScrollRectExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SnapTo_Public_Static_Void_ScrollRect_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Scroll_Public_Static_Void_ScrollRect_Single_0;

	static ScrollRectExtensions()
	{
		Il2CppClassPointerStore<ScrollRectExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ScrollRectExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_SnapTo_Public_Static_Void_ScrollRect_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectExtensions>.NativeClassPtr, 100667513);
		NativeMethodInfoPtr_Scroll_Public_Static_Void_ScrollRect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectExtensions>.NativeClassPtr, 100667514);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 79213, RefRangeEnd = 79214, XrefRangeStart = 79200, XrefRangeEnd = 79213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SnapTo(this ScrollRect scrollRect, RectTransform child)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scrollRect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)child);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SnapTo_Public_Static_Void_ScrollRect_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 79225, RefRangeEnd = 79226, XrefRangeStart = 79214, XrefRangeEnd = 79225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Scroll(this ScrollRect scrollRect, float amount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scrollRect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Scroll_Public_Static_Void_ScrollRect_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ScrollRectExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

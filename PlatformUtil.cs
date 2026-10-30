using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class PlatformUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatform_Public_Static_Platform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatformSpecificUIScrollSensitivity_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatformSpecificGameScrollSensitivity_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PlatformUtil()
	{
		Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlatformUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr);
		NativeMethodInfoPtr_GetPlatform_Public_Static_Platform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100667869);
		NativeMethodInfoPtr_GetPlatformSpecificUIScrollSensitivity_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100667870);
		NativeMethodInfoPtr_GetPlatformSpecificGameScrollSensitivity_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100667871);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr, 100667872);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 83724, RefRangeEnd = 83731, XrefRangeStart = 83723, XrefRangeEnd = 83724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Platform GetPlatform()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlatform_Public_Static_Platform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Platform*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 83732, RefRangeEnd = 83757, XrefRangeStart = 83731, XrefRangeEnd = 83732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPlatformSpecificUIScrollSensitivity()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlatformSpecificUIScrollSensitivity_Public_Static_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83758, RefRangeEnd = 83759, XrefRangeStart = 83757, XrefRangeEnd = 83758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPlatformSpecificGameScrollSensitivity()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlatformSpecificGameScrollSensitivity_Public_Static_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlatformUtil()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformUtil>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlatformUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

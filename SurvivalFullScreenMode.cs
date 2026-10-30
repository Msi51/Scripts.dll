using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class SurvivalFullScreenMode : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_WINDOWED;

	private static readonly System.IntPtr NativeFieldInfoPtr_FULLSCREEN_WINDOW;

	private static readonly System.IntPtr NativeFieldInfoPtr_EXCLUSIVE_FULLSCREEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_names;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityFullScreenMode_Public_Static_FullScreenMode_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSurvivalFullScreenMode_Public_Static_Int32_FullScreenMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int WINDOWED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WINDOWED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WINDOWED, (void*)(&num));
		}
	}

	public unsafe static int FULLSCREEN_WINDOW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FULLSCREEN_WINDOW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FULLSCREEN_WINDOW, (void*)(&num));
		}
	}

	public unsafe static int EXCLUSIVE_FULLSCREEN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EXCLUSIVE_FULLSCREEN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EXCLUSIVE_FULLSCREEN, (void*)(&num));
		}
	}

	public unsafe static Il2CppStringArray names
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_names, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_names, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static SurvivalFullScreenMode()
	{
		Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SurvivalFullScreenMode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr);
		NativeFieldInfoPtr_WINDOWED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr, "WINDOWED");
		NativeFieldInfoPtr_FULLSCREEN_WINDOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr, "FULLSCREEN_WINDOW");
		NativeFieldInfoPtr_EXCLUSIVE_FULLSCREEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr, "EXCLUSIVE_FULLSCREEN");
		NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr, "names");
		NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr, 100663666);
		NativeMethodInfoPtr_UnityFullScreenMode_Public_Static_FullScreenMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr_GetSurvivalFullScreenMode_Public_Static_Int32_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr, 100663668);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr, 100663669);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20908, RefRangeEnd = 20910, XrefRangeStart = 20891, XrefRangeEnd = 20908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetNames()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNames_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20910, RefRangeEnd = 20912, XrefRangeStart = 20910, XrefRangeEnd = 20910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FullScreenMode UnityFullScreenMode(int mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityFullScreenMode_Public_Static_FullScreenMode_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(FullScreenMode*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20912, RefRangeEnd = 20913, XrefRangeStart = 20912, XrefRangeEnd = 20912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSurvivalFullScreenMode(FullScreenMode unityMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&unityMode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSurvivalFullScreenMode_Public_Static_Int32_FullScreenMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SurvivalFullScreenMode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurvivalFullScreenMode>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SurvivalFullScreenMode(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

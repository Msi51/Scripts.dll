using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[StructLayout(LayoutKind.Explicit)]
public struct SoundSettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_GAME_VOLUME;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_UI_VOLUME;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiVolume;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_SoundSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaults_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0;

	[FieldOffset(0)]
	public float gameVolume;

	[FieldOffset(4)]
	public float uiVolume;

	public unsafe static float DEFAULT_GAME_VOLUME
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_GAME_VOLUME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_GAME_VOLUME, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_UI_VOLUME
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_UI_VOLUME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_UI_VOLUME, (void*)(&num));
		}
	}

	static SoundSettings()
	{
		Il2CppClassPointerStore<SoundSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SoundSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_GAME_VOLUME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, "DEFAULT_GAME_VOLUME");
		NativeFieldInfoPtr_DEFAULT_UI_VOLUME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, "DEFAULT_UI_VOLUME");
		NativeFieldInfoPtr_gameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, "gameVolume");
		NativeFieldInfoPtr_uiVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, "uiVolume");
		NativeMethodInfoPtr_Equals_Public_Boolean_SoundSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_SetDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, 100663662);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20828, RefRangeEnd = 20829, XrefRangeStart = 20824, XrefRangeEnd = 20828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(SoundSettings other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_SoundSettings_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20829, RefRangeEnd = 20831, XrefRangeStart = 20829, XrefRangeEnd = 20829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaults()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaults_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20850, RefRangeEnd = 20851, XrefRangeStart = 20831, XrefRangeEnd = 20850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20871, RefRangeEnd = 20872, XrefRangeStart = 20851, XrefRangeEnd = 20871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Dictionary<string, Il2CppSystem.Object> MapToDictionary()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SoundSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

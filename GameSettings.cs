using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class GameSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gameplaySettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_displaySettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_qualitySettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplayerSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_controlSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0;

	public unsafe GameplaySettings gameplaySettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameplaySettings);
			return new GameplaySettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameplaySettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameplaySettings)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe SoundSettings soundSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundSettings);
			return *(SoundSettings*)num;
		}
		set
		{
			*(SoundSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundSettings)) = soundSettings;
		}
	}

	public unsafe DisplaySettings displaySettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displaySettings);
			return new DisplaySettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displaySettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)displaySettings)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe SurvivalQualitySettings qualitySettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualitySettings);
			return *(SurvivalQualitySettings*)num;
		}
		set
		{
			*(SurvivalQualitySettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualitySettings)) = survivalQualitySettings;
		}
	}

	public unsafe MultiplayerSettings multiplayerSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplayerSettings);
			return new MultiplayerSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplayerSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)multiplayerSettings)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ControlSettings controlSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlSettings));
		}
	}

	static GameSettings()
	{
		Il2CppClassPointerStore<GameSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GameSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettings>.NativeClassPtr);
		NativeFieldInfoPtr_gameplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "gameplaySettings");
		NativeFieldInfoPtr_soundSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "soundSettings");
		NativeFieldInfoPtr_displaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "displaySettings");
		NativeFieldInfoPtr_qualitySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "qualitySettings");
		NativeFieldInfoPtr_multiplayerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "multiplayerSettings");
		NativeFieldInfoPtr_controlSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "controlSettings");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100663632);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 20410, RefRangeEnd = 20412, XrefRangeStart = 20382, XrefRangeEnd = 20410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20457, RefRangeEnd = 20458, XrefRangeStart = 20412, XrefRangeEnd = 20457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20495, RefRangeEnd = 20496, XrefRangeStart = 20458, XrefRangeEnd = 20495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Dictionary<string, Il2CppSystem.Object> MapToDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
	}

	public GameSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

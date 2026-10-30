using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class GameplaySettings : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_language;

	private static readonly System.IntPtr NativeFieldInfoPtr_hideHints;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipTutorialTasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_autosaveMinutes;

	private static readonly System.IntPtr NativeFieldInfoPtr_autosaveOnCaveEnter;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraAngles;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraCursorMovementAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastForwardOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastForwardBlurEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_concussionBlurEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_quickPickups;

	private static readonly System.IntPtr NativeFieldInfoPtr_showDiscoveries;

	private static readonly System.IntPtr NativeFieldInfoPtr_consoleEnabled;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaults_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0;

	public unsafe string language
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_language);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_language)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool hideHints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideHints);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideHints)) = flag;
		}
	}

	public unsafe bool skipTutorialTasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipTutorialTasks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipTutorialTasks)) = flag;
		}
	}

	public unsafe int autosaveMinutes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autosaveMinutes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autosaveMinutes)) = num;
		}
	}

	public unsafe bool autosaveOnCaveEnter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autosaveOnCaveEnter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autosaveOnCaveEnter)) = flag;
		}
	}

	public unsafe float cameraAngles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraAngles);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraAngles)) = num;
		}
	}

	public unsafe float cameraCursorMovementAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraCursorMovementAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraCursorMovementAmount)) = num;
		}
	}

	public unsafe int fastForwardOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastForwardOption);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastForwardOption)) = num;
		}
	}

	public unsafe bool fastForwardBlurEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastForwardBlurEffect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastForwardBlurEffect)) = flag;
		}
	}

	public unsafe bool concussionBlurEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_concussionBlurEffect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_concussionBlurEffect)) = flag;
		}
	}

	public unsafe bool quickPickups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quickPickups);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quickPickups)) = flag;
		}
	}

	public unsafe bool showDiscoveries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDiscoveries);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDiscoveries)) = flag;
		}
	}

	public unsafe bool consoleEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consoleEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consoleEnabled)) = flag;
		}
	}

	static GameplaySettings()
	{
		Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GameplaySettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr);
		NativeFieldInfoPtr_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "language");
		NativeFieldInfoPtr_hideHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "hideHints");
		NativeFieldInfoPtr_skipTutorialTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "skipTutorialTasks");
		NativeFieldInfoPtr_autosaveMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "autosaveMinutes");
		NativeFieldInfoPtr_autosaveOnCaveEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "autosaveOnCaveEnter");
		NativeFieldInfoPtr_cameraAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "cameraAngles");
		NativeFieldInfoPtr_cameraCursorMovementAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "cameraCursorMovementAmount");
		NativeFieldInfoPtr_fastForwardOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "fastForwardOption");
		NativeFieldInfoPtr_fastForwardBlurEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "fastForwardBlurEffect");
		NativeFieldInfoPtr_concussionBlurEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "concussionBlurEffect");
		NativeFieldInfoPtr_quickPickups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "quickPickups");
		NativeFieldInfoPtr_showDiscoveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "showDiscoveries");
		NativeFieldInfoPtr_consoleEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, "consoleEnabled");
		NativeMethodInfoPtr_SetDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, 100663624);
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, 100663625);
		NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr, 100663626);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20202, RefRangeEnd = 20203, XrefRangeStart = 20202, XrefRangeEnd = 20202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaults_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20274, RefRangeEnd = 20275, XrefRangeStart = 20203, XrefRangeEnd = 20274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20362, RefRangeEnd = 20363, XrefRangeStart = 20275, XrefRangeEnd = 20362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Dictionary<string, Il2CppSystem.Object> MapToDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
	}

	public GameplaySettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GameplaySettings()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplaySettings>.NativeClassPtr))
	{
	}
}

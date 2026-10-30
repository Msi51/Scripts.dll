using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameDetailsUI : UIComponent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_headerTabArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_alert;

	private static readonly System.IntPtr NativeFieldInfoPtr_alertText;

	private static readonly System.IntPtr NativeFieldInfoPtr_body;

	private static readonly System.IntPtr NativeFieldInfoPtr_slotListUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameSaves;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_slotName;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplayerGameOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipTutorialTasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_settingsManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_preferencesManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_persistenceManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_advancedGameOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_headerTabBarUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_tabs;

	private static readonly System.IntPtr NativeFieldInfoPtr_tabButtonMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_tabTransformMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameCustomizationUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_onValidateDetails;

	private static readonly System.IntPtr NativeFieldInfoPtr_onRevertClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_onCancel;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficultyOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficultyOptionsTooltips;

	private static readonly System.IntPtr NativeFieldInfoPtr_immersionOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_immersionOptionTooltips;

	private static readonly System.IntPtr NativeFieldInfoPtr_startSeasonOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_seasonProgressionOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_seasonProgressionOptionTooltips;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibilityOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_offlineTimePassageOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_respawnTypeOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_respawnTypeOptionsTooltips;

	private static readonly System.IntPtr NativeMethodInfoPtr_Created_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeTab_Private_Void_GameDetailsTab_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeTab_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_changeTab_Private_Void_GameDetailsTab_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buildTabContent_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buildCoopTabContent_Private_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDifficultyIndex_Private_Int32_GameDifficulty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buildGameTabContent_Private_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createSlotListComponent_Private_UIComponent_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bindSlotListComponent_Private_Void_UIComponent_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_numElementsSlotList_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_refreshSlotList_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buildRevertTabContent_Private_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onChange_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewMultiplayerGameOptions_Public_NewMultiplayerGameOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLoadMultiplayerGameOptions_Public_LoadMultiplayerGameOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onMenuLeft_Private_Void_InputEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onMenuRight_Private_Void_InputEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onRestoreDefaults_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGame_Public_Void_GameInfoSave_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onRevertGameClick_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onRevertCancel_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Created_b__37_1_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Created_b__37_2_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Created_b__37_3_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Created_b__37_0_Private_Void_HeaderTabBarUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_0_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_7_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_1_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_8_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_2_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_9_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_3_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_10_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_11_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_4_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_12_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_5_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_13_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_6_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildCoopTabContent_b__43_14_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_0_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_5_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_6_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_1_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_7_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_8_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_2_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_9_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_10_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_3_Private_Void_SettingRowUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_11_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_12_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__buildGameTabContent_b__45_4_Private_Void_GameCustomizationUI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__createSlotListComponent_b__46_0_Private_Void_RevertGameSlotUI_0;

	public unsafe Transform headerTabArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headerTabArea);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headerTabArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform alert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alert);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alert)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe TextMeshProUGUI alertText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe Transform body
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_body);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_body)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe PooledListUI slotListUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotListUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PooledListUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotListUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pooledListUI));
		}
	}

	public unsafe List<Il2CppSystem.ValueTuple<string, string, GameSave>> gameSaves
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameSaves);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<string, string, GameSave>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameSaves)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameInfoSave gameInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameInfoSave>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameInfoSave));
		}
	}

	public unsafe string slotName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe GameOptions gameOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameOptions);
			return new GameOptions(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameOptions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameOptions)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameOptions>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe MultiplayerGameOptions multiplayerGameOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplayerGameOptions);
			return new MultiplayerGameOptions(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplayerGameOptions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)multiplayerGameOptions)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe INetworkManager networkManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<INetworkManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager));
		}
	}

	public unsafe ISettingsManager settingsManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settingsManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISettingsManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settingsManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settingsManager));
		}
	}

	public unsafe IPreferencesManager preferencesManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferencesManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPreferencesManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferencesManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preferencesManager));
		}
	}

	public unsafe IPersistenceManager persistenceManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persistenceManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPersistenceManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persistenceManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)persistenceManager));
		}
	}

	public unsafe IGameManager gameManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameManager));
		}
	}

	public unsafe AdvancedGameOptions advancedGameOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedGameOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdvancedGameOptions>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedGameOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)advancedGameOptions));
		}
	}

	public unsafe HeaderTabBarUI headerTabBarUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headerTabBarUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeaderTabBarUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headerTabBarUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)headerTabBarUI));
		}
	}

	public unsafe List<GameDetailsTab> tabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameDetailsTab>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<GameDetailsTab, TabButtonData> tabButtonMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabButtonMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameDetailsTab, TabButtonData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabButtonMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<GameDetailsTab, Transform> tabTransformMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabTransformMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameDetailsTab, Transform>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tabTransformMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe GameCustomizationUI gameCustomizationUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameCustomizationUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCustomizationUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameCustomizationUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCustomizationUI));
		}
	}

	public unsafe GameDetailsTab currentTab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTab);
			return *(GameDetailsTab*)num;
		}
		set
		{
			*(GameDetailsTab*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTab)) = gameDetailsTab;
		}
	}

	public unsafe UnityEvent<MultiplayerGameOptions> onValidateDetails
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onValidateDetails);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent<MultiplayerGameOptions>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onValidateDetails)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent<string, string> onRevertClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRevertClick);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent<string, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRevertClick)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent onCancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCancel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCancel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe List<string> difficultyOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> difficultyOptionsTooltips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyOptionsTooltips);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyOptionsTooltips)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> immersionOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_immersionOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_immersionOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> immersionOptionTooltips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_immersionOptionTooltips);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_immersionOptionTooltips)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> startSeasonOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startSeasonOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startSeasonOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> seasonProgressionOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seasonProgressionOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seasonProgressionOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> seasonProgressionOptionTooltips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seasonProgressionOptionTooltips);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seasonProgressionOptionTooltips)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> visibilityOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibilityOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibilityOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> offlineTimePassageOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offlineTimePassageOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offlineTimePassageOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> respawnTypeOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_respawnTypeOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_respawnTypeOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> respawnTypeOptionsTooltips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_respawnTypeOptionsTooltips);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_respawnTypeOptionsTooltips)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static GameDetailsUI()
	{
		Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GameDetailsUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr);
		NativeFieldInfoPtr_headerTabArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "headerTabArea");
		NativeFieldInfoPtr_alert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "alert");
		NativeFieldInfoPtr_alertText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "alertText");
		NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "body");
		NativeFieldInfoPtr_slotListUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "slotListUI");
		NativeFieldInfoPtr_gameSaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "gameSaves");
		NativeFieldInfoPtr_gameInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "gameInfo");
		NativeFieldInfoPtr_slotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "slotName");
		NativeFieldInfoPtr_gameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "gameOptions");
		NativeFieldInfoPtr_multiplayerGameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "multiplayerGameOptions");
		NativeFieldInfoPtr_skipTutorialTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "skipTutorialTasks");
		NativeFieldInfoPtr_networkManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "networkManager");
		NativeFieldInfoPtr_settingsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "settingsManager");
		NativeFieldInfoPtr_preferencesManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "preferencesManager");
		NativeFieldInfoPtr_persistenceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "persistenceManager");
		NativeFieldInfoPtr_gameManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "gameManager");
		NativeFieldInfoPtr_advancedGameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "advancedGameOptions");
		NativeFieldInfoPtr_headerTabBarUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "headerTabBarUI");
		NativeFieldInfoPtr_tabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "tabs");
		NativeFieldInfoPtr_tabButtonMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "tabButtonMap");
		NativeFieldInfoPtr_tabTransformMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "tabTransformMap");
		NativeFieldInfoPtr_gameCustomizationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "gameCustomizationUI");
		NativeFieldInfoPtr_currentTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "currentTab");
		NativeFieldInfoPtr_onValidateDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "onValidateDetails");
		NativeFieldInfoPtr_onRevertClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "onRevertClick");
		NativeFieldInfoPtr_onCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "onCancel");
		NativeFieldInfoPtr_difficultyOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "difficultyOptions");
		NativeFieldInfoPtr_difficultyOptionsTooltips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "difficultyOptionsTooltips");
		NativeFieldInfoPtr_immersionOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "immersionOptions");
		NativeFieldInfoPtr_immersionOptionTooltips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "immersionOptionTooltips");
		NativeFieldInfoPtr_startSeasonOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "startSeasonOptions");
		NativeFieldInfoPtr_seasonProgressionOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "seasonProgressionOptions");
		NativeFieldInfoPtr_seasonProgressionOptionTooltips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "seasonProgressionOptionTooltips");
		NativeFieldInfoPtr_visibilityOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "visibilityOptions");
		NativeFieldInfoPtr_offlineTimePassageOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "offlineTimePassageOptions");
		NativeFieldInfoPtr_respawnTypeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "respawnTypeOptions");
		NativeFieldInfoPtr_respawnTypeOptionsTooltips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, "respawnTypeOptionsTooltips");
		NativeMethodInfoPtr_Created_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665024);
		NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665025);
		NativeMethodInfoPtr_ChangeTab_Private_Void_GameDetailsTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665026);
		NativeMethodInfoPtr_ChangeTab_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665027);
		NativeMethodInfoPtr_changeTab_Private_Void_GameDetailsTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665028);
		NativeMethodInfoPtr_buildTabContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665029);
		NativeMethodInfoPtr_buildCoopTabContent_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665030);
		NativeMethodInfoPtr_getDifficultyIndex_Private_Int32_GameDifficulty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665031);
		NativeMethodInfoPtr_buildGameTabContent_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665032);
		NativeMethodInfoPtr_createSlotListComponent_Private_UIComponent_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665033);
		NativeMethodInfoPtr_bindSlotListComponent_Private_Void_UIComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665034);
		NativeMethodInfoPtr_numElementsSlotList_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665035);
		NativeMethodInfoPtr_refreshSlotList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665036);
		NativeMethodInfoPtr_buildRevertTabContent_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665037);
		NativeMethodInfoPtr_onChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665038);
		NativeMethodInfoPtr_GetNewMultiplayerGameOptions_Public_NewMultiplayerGameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665039);
		NativeMethodInfoPtr_GetLoadMultiplayerGameOptions_Public_LoadMultiplayerGameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665040);
		NativeMethodInfoPtr_Refresh_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665041);
		NativeMethodInfoPtr_onMenuLeft_Private_Void_InputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665042);
		NativeMethodInfoPtr_onMenuRight_Private_Void_InputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665043);
		NativeMethodInfoPtr_onRestoreDefaults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665044);
		NativeMethodInfoPtr_SetGame_Public_Void_GameInfoSave_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665045);
		NativeMethodInfoPtr_onRevertGameClick_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665046);
		NativeMethodInfoPtr_onRevertCancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665047);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665048);
		NativeMethodInfoPtr__Created_b__37_1_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665049);
		NativeMethodInfoPtr__Created_b__37_2_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665050);
		NativeMethodInfoPtr__Created_b__37_3_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665051);
		NativeMethodInfoPtr__Created_b__37_0_Private_Void_HeaderTabBarUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665052);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_0_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665053);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_7_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665054);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_1_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665055);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_8_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665056);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_2_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665057);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_9_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665058);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_3_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665059);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_10_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665060);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_11_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665061);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_4_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665062);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_12_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665063);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_5_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665064);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_13_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665065);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_6_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665066);
		NativeMethodInfoPtr__buildCoopTabContent_b__43_14_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665067);
		NativeMethodInfoPtr__buildGameTabContent_b__45_0_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665068);
		NativeMethodInfoPtr__buildGameTabContent_b__45_5_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665069);
		NativeMethodInfoPtr__buildGameTabContent_b__45_6_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665070);
		NativeMethodInfoPtr__buildGameTabContent_b__45_1_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665071);
		NativeMethodInfoPtr__buildGameTabContent_b__45_7_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665072);
		NativeMethodInfoPtr__buildGameTabContent_b__45_8_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665073);
		NativeMethodInfoPtr__buildGameTabContent_b__45_2_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665074);
		NativeMethodInfoPtr__buildGameTabContent_b__45_9_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665075);
		NativeMethodInfoPtr__buildGameTabContent_b__45_10_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665076);
		NativeMethodInfoPtr__buildGameTabContent_b__45_3_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665077);
		NativeMethodInfoPtr__buildGameTabContent_b__45_11_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665078);
		NativeMethodInfoPtr__buildGameTabContent_b__45_12_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665079);
		NativeMethodInfoPtr__buildGameTabContent_b__45_4_Private_Void_GameCustomizationUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665080);
		NativeMethodInfoPtr__createSlotListComponent_b__46_0_Private_Void_RevertGameSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr, 100665081);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41082, XrefRangeEnd = 41448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Created()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Created_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41448, XrefRangeEnd = 41462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Destroyed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41468, RefRangeEnd = 41470, XrefRangeStart = 41462, XrefRangeEnd = 41468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeTab(GameDetailsTab tab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tab);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeTab_Private_Void_GameDetailsTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41490, RefRangeEnd = 41492, XrefRangeStart = 41470, XrefRangeEnd = 41490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeTab(int dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeTab_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 41522, RefRangeEnd = 41526, XrefRangeStart = 41492, XrefRangeEnd = 41522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void changeTab(GameDetailsTab tab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tab);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_changeTab_Private_Void_GameDetailsTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41596, RefRangeEnd = 41598, XrefRangeStart = 41526, XrefRangeEnd = 41596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buildTabContent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildTabContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41669, RefRangeEnd = 41670, XrefRangeStart = 41598, XrefRangeEnd = 41669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buildCoopTabContent(Transform transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildCoopTabContent_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int getDifficultyIndex(GameDifficulty difficulty)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&difficulty);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDifficultyIndex_Private_Int32_GameDifficulty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41728, RefRangeEnd = 41729, XrefRangeStart = 41670, XrefRangeEnd = 41728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buildGameTabContent(Transform transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildGameTabContent_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41729, XrefRangeEnd = 41742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIComponent createSlotListComponent(Transform transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createSlotListComponent_Private_UIComponent_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIComponent>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41742, XrefRangeEnd = 41748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void bindSlotListComponent(UIComponent component, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bindSlotListComponent_Private_Void_UIComponent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41748, XrefRangeEnd = 41749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int numElementsSlotList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_numElementsSlotList_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41791, RefRangeEnd = 41792, XrefRangeStart = 41749, XrefRangeEnd = 41791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void refreshSlotList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_refreshSlotList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41818, RefRangeEnd = 41819, XrefRangeStart = 41792, XrefRangeEnd = 41818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buildRevertTabContent(Transform transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildRevertTabContent_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 41829, RefRangeEnd = 41841, XrefRangeStart = 41819, XrefRangeEnd = 41829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41843, RefRangeEnd = 41844, XrefRangeStart = 41841, XrefRangeEnd = 41843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewMultiplayerGameOptions GetNewMultiplayerGameOptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewMultiplayerGameOptions_Public_NewMultiplayerGameOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NewMultiplayerGameOptions(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41847, RefRangeEnd = 41849, XrefRangeStart = 41844, XrefRangeEnd = 41847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoadMultiplayerGameOptions GetLoadMultiplayerGameOptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLoadMultiplayerGameOptions_Public_LoadMultiplayerGameOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new LoadMultiplayerGameOptions(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41851, RefRangeEnd = 41852, XrefRangeStart = 41849, XrefRangeEnd = 41851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Refresh(string newSlotName = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newSlotName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41852, XrefRangeEnd = 41856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onMenuLeft(InputEvent ev)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ev);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onMenuLeft_Private_Void_InputEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41856, XrefRangeEnd = 41860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onMenuRight(InputEvent ev)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ev);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onMenuRight_Private_Void_InputEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41860, XrefRangeEnd = 41876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onRestoreDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onRestoreDefaults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41909, RefRangeEnd = 41910, XrefRangeStart = 41876, XrefRangeEnd = 41909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGame(GameInfoSave gameInfo, string slotName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGame_Public_Void_GameInfoSave_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41910, XrefRangeEnd = 41914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onRevertGameClick(string gameName, string slotName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(gameName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onRevertGameClick_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41914, XrefRangeEnd = 41916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onRevertCancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onRevertCancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41916, XrefRangeEnd = 41944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameDetailsUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDetailsUI>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41944, XrefRangeEnd = 41945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Created_b__37_1(int _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Created_b__37_1_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41945, XrefRangeEnd = 41946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Created_b__37_2(int _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Created_b__37_2_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41946, XrefRangeEnd = 41947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Created_b__37_3(int _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Created_b__37_3_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41947, XrefRangeEnd = 41958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Created_b__37_0(HeaderTabBarUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Created_b__37_0_Private_Void_HeaderTabBarUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41958, XrefRangeEnd = 41974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_0(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_0_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41974, XrefRangeEnd = 41976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_7(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_7_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41976, XrefRangeEnd = 41991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_1(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_1_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41991, XrefRangeEnd = 41993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_8(float option)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&option);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_8_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41993, XrefRangeEnd = 42009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_2(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_2_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42009, XrefRangeEnd = 42014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_9(string option)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_9_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42014, XrefRangeEnd = 42041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_3(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_3_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42041, XrefRangeEnd = 42043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_10(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_10_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildCoopTabContent_b__43_11()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_11_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42043, XrefRangeEnd = 42063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_4(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_4_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42063, XrefRangeEnd = 42068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_12(string option)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_12_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42068, XrefRangeEnd = 42083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_5(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_5_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42083, XrefRangeEnd = 42084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_13(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_13_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42084, XrefRangeEnd = 42101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_6(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_6_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42101, XrefRangeEnd = 42106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildCoopTabContent_b__43_14(string option)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildCoopTabContent_b__43_14_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42106, XrefRangeEnd = 42132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildGameTabContent_b__45_0(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_0_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42132, XrefRangeEnd = 42140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildGameTabContent_b__45_5(string option)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_5_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildGameTabContent_b__45_6()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_6_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42140, XrefRangeEnd = 42164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildGameTabContent_b__45_1(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_1_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42164, XrefRangeEnd = 42169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildGameTabContent_b__45_7(string option)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_7_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildGameTabContent_b__45_8()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_8_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42169, XrefRangeEnd = 42192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildGameTabContent_b__45_2(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_2_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42192, XrefRangeEnd = 42197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildGameTabContent_b__45_9(string option)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_9_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildGameTabContent_b__45_10()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_10_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42197, XrefRangeEnd = 42221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildGameTabContent_b__45_3(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_3_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42221, XrefRangeEnd = 42226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildGameTabContent_b__45_11(string option)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_11_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildGameTabContent_b__45_12()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_12_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42226, XrefRangeEnd = 42235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildGameTabContent_b__45_4(GameCustomizationUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildGameTabContent_b__45_4_Private_Void_GameCustomizationUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42235, XrefRangeEnd = 42252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _createSlotListComponent_b__46_0(RevertGameSlotUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__createSlotListComponent_b__46_0_Private_Void_RevertGameSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameDetailsUI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

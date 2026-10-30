using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SettingsManager : Il2CppSystem.Object
{
	[ObfuscatedName("SettingsManager+<Init>d__59")]
	public sealed class _Init_d__59 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe SettingsManager __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SettingsManager>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settingsManager));
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _Init_d__59()
		{
			Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "<Init>d__59");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr, 100677379);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr, 100677380);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr, 100677381);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr, 100677382);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr, 100677383);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr, 100677384);
		}

		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 37231, RefRangeEnd = 37260, XrefRangeStart = 37231, XrefRangeEnd = 37260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Init_d__59(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Init_d__59>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(13368)]
		[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199291, XrefRangeEnd = 199450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199450, XrefRangeEnd = 199456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _Init_d__59(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_QUALITY_LEVEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIN_SHADOW_DISTANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SHADOW_DISTANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_STEAM_DECK_DEFAULT_UI_SCALE;

	private static readonly System.IntPtr NativeFieldInfoPtr__persistenceManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__localizationManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__steamIntegrationManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__uiManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_resolutionOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderPipelineAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_mappingInputMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputKeyMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputGamepadMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputAxisMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputGamepads;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputAxes;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultKeyboardMouseMappings;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultGamepadMappings;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialKeyboardMouseMappings;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialGamepadMappings;

	private static readonly System.IntPtr NativeFieldInfoPtr_qualityPresetSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_grassShadowsSettingChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewDistanceSettingChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_firesCastShadowsSettingChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_postProcessingSettingChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_ssaoQualitySettingChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterReflectionQualitySettingChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloomIntensitySettingChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectionHighlightBrightnessChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_chromaticAberrationSettingChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraPerspectiveChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraInvertMouseYChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraAngleChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraCursorMovementAmounthangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerMovementStyleChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerOrientationStyleChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerInteractionStyleChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerAttackStyleChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerRotationSensitivityCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerGamepadLookSensitivityCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerGamepadGlyphsCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerToggleRunChangeCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_languageChangeCallbacks;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_persistenceManager_Public_get_IPersistenceManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_persistenceManager_Public_set_Void_IPersistenceManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localizationManager_Public_get_ILocalizationManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localizationManager_Public_set_Void_ILocalizationManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_steamIntegrationManager_Public_get_ISteamIntegrationManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_steamIntegrationManager_Public_set_Void_ISteamIntegrationManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uiManager_Public_get_IUIManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_uiManager_Public_set_Void_IUIManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplaySettings_Public_Virtual_Final_New_GameplaySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGameplaySettings_Private_Void_GameplaySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGameplaySettings_Public_Virtual_Final_New_Void_GameplaySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSoundSettings_Private_Void_SoundSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSoundSettings_Public_Virtual_Final_New_Void_SoundSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSoundSettings_Public_Virtual_Final_New_SoundSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyKeyboardMouseIdentifierMappings_Private_Void_Dictionary_2_InputAction_ValueTuple_2_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyGamepadIdentifierMappings_Private_Void_Dictionary_2_InputAction_ValueTuple_2_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applySpecialControlMappings_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDefaultControlMappings_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetKeyboardMouseDefaults_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGamepadDefaults_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initControls_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setInput_Private_Void_InputAction_ControlInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPlayerMovementStyle_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPlayerOrientationStyle_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPlayerInteractionStyle_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPlayerAttackStyle_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPerspective_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setInvertMouseY_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSwapMacCommandAlt_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setRotationSensitivity_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGamepadLookSensitivity_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGamepadGlyphs_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setToggleRun_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setToggleShowItems_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setControlSettings_Private_Void_ControlSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_assignKeyboardMouseMapping_Private_Void_InputAction_ControlMapping_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_assignGamepadMapping_Private_Void_InputAction_ControlMapping_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetControlSettings_Public_Virtual_Final_New_Void_ControlSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControlSettings_Public_Virtual_Final_New_ControlSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControlSettingsCopy_Public_Virtual_Final_New_ControlSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCameraPerspectiveChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCameraInvertMouseYChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCameraAngleChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCameraCursorMovementAmountChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerMovementStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerOrientationStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemovePlayerOrientationStyleSettingChangeListener_Public_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerInteractionStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemovePlayerInteractionStyleSettingChangeListener_Public_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerAttackStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemovePlayerAttackStyleSettingChangeListener_Public_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerRotationSensitivityChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerGamepadLookSensitivityChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerGamepadGlyphsSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerToggleRunSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLanguageChangeListener_Public_Virtual_Final_New_Void_LanguageChangeCallback_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputKeyPressed_Public_Virtual_Final_New_InputKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGamepadPressed_Public_Virtual_Final_New_InputGamepad_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputAxisPressed_Public_Virtual_Final_New_InputAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMultiplayerSettings_Public_Virtual_Final_New_MultiplayerSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLanguage_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setHideHints_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSkipTutorialTasks_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAutosaveMinutes_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAutosaveWhenCaveEnter_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCameraAngles_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCameraCursorMovementAmount_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFastForwardOption_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFastForwardBlurEffect_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setConcussionBlurEffect_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setQuickPickups_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setShowDiscoveries_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setConsoleEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGameVolume_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setUIVolume_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplaySettings_Public_Virtual_Final_New_DisplaySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQualitySettingsForPreset_Public_Virtual_Final_New_SurvivalQualitySettings_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQualityPresetLevelForSettings_Public_Virtual_Final_New_Int32_SurvivalQualitySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDisplaySettings_Public_Virtual_Final_New_Void_DisplaySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setQualitySettings_Private_Void_SurvivalQualitySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetQualitySettings_Public_Virtual_Final_New_Void_SurvivalQualitySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQualitySettings_Public_Virtual_Final_New_SurvivalQualitySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResolutionOptions_Public_Virtual_Final_New_Il2CppReferenceArray_1_ScreenResolution_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getPreferredResolution_Private_ScreenResolution_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setScreenResolution_Private_Void_ScreenResolution_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setUIScale_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTextureQuality_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAnisotropicFilteringEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setObjectQuality_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setShadowQuality_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getShadowDistance_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setViewDistance_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGrassShadowsEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFiresCastShadows_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GrassShadowsEnabled_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGrassShadowSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetViewDistance_Public_Virtual_Final_New_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddViewDistanceChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FiresCastShadows_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFiresCastShadowsSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPostProcessingEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostProcessingEnabled_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSSAOQualityLevel_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSelectionHighlightBrightness_Public_Virtual_Final_New_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWaterReflectionQualityLevel_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCloudQualityLevel_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCloudShadowsEnabled_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBloomIntensity_Public_Virtual_Final_New_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsChromaticAberrationEnabled_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBloomIntensityChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSelectionHighlightBrightnessChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChromaticAberrationChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPostProcessingSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSSAOSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWaterReflectionQualityChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyboardMouseControls_Public_Virtual_Final_New_Controls_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGamepadControls_Public_Virtual_Final_New_Controls_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setWaterReflectionQuality_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSSAOQuality_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAntiAliasingQuality_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setGrassAntiAliasingEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCloudQuality_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCloudShadowsEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTrrainTessellationEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setBloomIntensity_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSelectionHighlightBrightness_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setChromaticAberrationEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setVsyncEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLimitFramerateEnabled_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMaxFramerate_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBannedUserId_Public_Virtual_Final_New_Void_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBannedUserId_Public_Virtual_Final_New_Void_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUserIdBanned_Public_Virtual_Final_New_Boolean_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUserIdMod_Public_Virtual_Final_New_Boolean_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBannedUserIds_Public_Virtual_Final_New_HashSet_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int DEFAULT_QUALITY_LEVEL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_QUALITY_LEVEL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_QUALITY_LEVEL, (void*)(&num));
		}
	}

	public unsafe static float MIN_SHADOW_DISTANCE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_SHADOW_DISTANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_SHADOW_DISTANCE, (void*)(&num));
		}
	}

	public unsafe static float MAX_SHADOW_DISTANCE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_SHADOW_DISTANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_SHADOW_DISTANCE, (void*)(&num));
		}
	}

	public unsafe static float STEAM_DECK_DEFAULT_UI_SCALE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STEAM_DECK_DEFAULT_UI_SCALE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STEAM_DECK_DEFAULT_UI_SCALE, (void*)(&num));
		}
	}

	public unsafe IPersistenceManager _persistenceManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__persistenceManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPersistenceManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__persistenceManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)persistenceManager));
		}
	}

	public unsafe ILocalizationManager _localizationManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__localizationManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILocalizationManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__localizationManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)localizationManager));
		}
	}

	public unsafe ISteamIntegrationManager _steamIntegrationManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__steamIntegrationManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISteamIntegrationManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__steamIntegrationManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)steamIntegrationManager));
		}
	}

	public unsafe IUIManager _uiManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uiManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IUIManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uiManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iUIManager));
		}
	}

	public unsafe bool initialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialized)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<ScreenResolution> resolutionOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolutionOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScreenResolution>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolutionOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe GameSettings gameSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameSettings));
		}
	}

	public unsafe Shader terrainShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader));
		}
	}

	public unsafe UniversalRenderPipelineAsset renderPipelineAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderPipelineAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderPipelineAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)universalRenderPipelineAsset));
		}
	}

	public unsafe Dictionary<ControlInput, List<InputAction>> mappingInputMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mappingInputMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ControlInput, List<InputAction>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mappingInputMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, InputKey> inputKeyMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputKeyMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, InputKey>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputKeyMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, InputGamepad> inputGamepadMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputGamepadMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, InputGamepad>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputGamepadMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, InputAxis> inputAxisMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputAxisMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, InputAxis>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputAxisMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<InputKey> inputKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputKeys);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InputKey>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InputGamepad> inputGamepads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputGamepads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InputGamepad>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputGamepads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InputAxis> inputAxes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputAxes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InputAxis>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputAxes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<InputAction, Il2CppSystem.ValueTuple<string, string>> defaultKeyboardMouseMappings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultKeyboardMouseMappings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InputAction, Il2CppSystem.ValueTuple<string, string>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultKeyboardMouseMappings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InputAction, Il2CppSystem.ValueTuple<string, string>> defaultGamepadMappings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultGamepadMappings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InputAction, Il2CppSystem.ValueTuple<string, string>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultGamepadMappings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InputAction, Il2CppSystem.ValueTuple<string, string>> specialKeyboardMouseMappings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialKeyboardMouseMappings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InputAction, Il2CppSystem.ValueTuple<string, string>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialKeyboardMouseMappings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InputAction, Il2CppSystem.ValueTuple<string, string>> specialGamepadMappings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialGamepadMappings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InputAction, Il2CppSystem.ValueTuple<string, string>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialGamepadMappings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, SurvivalQualitySettings> qualityPresetSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualityPresetSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, SurvivalQualitySettings>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualityPresetSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<BoolSettingChangeCallback> grassShadowsSettingChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grassShadowsSettingChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BoolSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grassShadowsSettingChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FloatSettingChangeCallback> viewDistanceSettingChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewDistanceSettingChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FloatSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewDistanceSettingChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BoolSettingChangeCallback> firesCastShadowsSettingChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firesCastShadowsSettingChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BoolSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firesCastShadowsSettingChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BoolSettingChangeCallback> postProcessingSettingChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessingSettingChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BoolSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessingSettingChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IntSettingChangeCallback> ssaoQualitySettingChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ssaoQualitySettingChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ssaoQualitySettingChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IntSettingChangeCallback> waterReflectionQualitySettingChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterReflectionQualitySettingChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterReflectionQualitySettingChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FloatSettingChangeCallback> bloomIntensitySettingChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomIntensitySettingChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FloatSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomIntensitySettingChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FloatSettingChangeCallback> selectionHighlightBrightnessChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectionHighlightBrightnessChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FloatSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectionHighlightBrightnessChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BoolSettingChangeCallback> chromaticAberrationSettingChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chromaticAberrationSettingChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BoolSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chromaticAberrationSettingChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IntSettingChangeCallback> cameraPerspectiveChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraPerspectiveChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraPerspectiveChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BoolSettingChangeCallback> cameraInvertMouseYChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraInvertMouseYChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BoolSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraInvertMouseYChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FloatSettingChangeCallback> cameraAngleChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraAngleChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FloatSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraAngleChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FloatSettingChangeCallback> cameraCursorMovementAmounthangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraCursorMovementAmounthangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FloatSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraCursorMovementAmounthangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IntSettingChangeCallback> playerMovementStyleChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMovementStyleChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMovementStyleChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IntSettingChangeCallback> playerOrientationStyleChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerOrientationStyleChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerOrientationStyleChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IntSettingChangeCallback> playerInteractionStyleChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerInteractionStyleChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerInteractionStyleChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IntSettingChangeCallback> playerAttackStyleChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAttackStyleChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAttackStyleChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FloatSettingChangeCallback> playerRotationSensitivityCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerRotationSensitivityCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FloatSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerRotationSensitivityCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FloatSettingChangeCallback> playerGamepadLookSensitivityCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGamepadLookSensitivityCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FloatSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGamepadLookSensitivityCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IntSettingChangeCallback> playerGamepadGlyphsCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGamepadGlyphsCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGamepadGlyphsCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BoolSettingChangeCallback> playerToggleRunChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerToggleRunChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BoolSettingChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerToggleRunChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<LanguageChangeCallback> languageChangeCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_languageChangeCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LanguageChangeCallback>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_languageChangeCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe IPersistenceManager persistenceManager
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 3866, RefRangeEnd = 3876, XrefRangeStart = 3866, XrefRangeEnd = 3876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_persistenceManager_Public_get_IPersistenceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPersistenceManager>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29379, RefRangeEnd = 29381, XrefRangeStart = 29379, XrefRangeEnd = 29381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_persistenceManager_Public_set_Void_IPersistenceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ILocalizationManager localizationManager
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localizationManager_Public_get_ILocalizationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILocalizationManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localizationManager_Public_set_Void_ILocalizationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ISteamIntegrationManager steamIntegrationManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18747, RefRangeEnd = 18748, XrefRangeStart = 18747, XrefRangeEnd = 18748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_steamIntegrationManager_Public_get_ISteamIntegrationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISteamIntegrationManager>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18749, RefRangeEnd = 18750, XrefRangeStart = 18749, XrefRangeEnd = 18750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_steamIntegrationManager_Public_set_Void_ISteamIntegrationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IUIManager uiManager
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19167, RefRangeEnd = 19170, XrefRangeStart = 19167, XrefRangeEnd = 19170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uiManager_Public_get_IUIManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IUIManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_uiManager_Public_set_Void_IUIManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static SettingsManager()
	{
		Il2CppClassPointerStore<SettingsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SettingsManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_QUALITY_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "DEFAULT_QUALITY_LEVEL");
		NativeFieldInfoPtr_MIN_SHADOW_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "MIN_SHADOW_DISTANCE");
		NativeFieldInfoPtr_MAX_SHADOW_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "MAX_SHADOW_DISTANCE");
		NativeFieldInfoPtr_STEAM_DECK_DEFAULT_UI_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "STEAM_DECK_DEFAULT_UI_SCALE");
		NativeFieldInfoPtr__persistenceManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "<persistenceManager>k__BackingField");
		NativeFieldInfoPtr__localizationManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "<localizationManager>k__BackingField");
		NativeFieldInfoPtr__steamIntegrationManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "<steamIntegrationManager>k__BackingField");
		NativeFieldInfoPtr__uiManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "<uiManager>k__BackingField");
		NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "initialized");
		NativeFieldInfoPtr_resolutionOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "resolutionOptions");
		NativeFieldInfoPtr_gameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "gameSettings");
		NativeFieldInfoPtr_terrainShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "terrainShader");
		NativeFieldInfoPtr_renderPipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "renderPipelineAsset");
		NativeFieldInfoPtr_mappingInputMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "mappingInputMap");
		NativeFieldInfoPtr_inputKeyMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "inputKeyMap");
		NativeFieldInfoPtr_inputGamepadMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "inputGamepadMap");
		NativeFieldInfoPtr_inputAxisMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "inputAxisMap");
		NativeFieldInfoPtr_inputKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "inputKeys");
		NativeFieldInfoPtr_inputGamepads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "inputGamepads");
		NativeFieldInfoPtr_inputAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "inputAxes");
		NativeFieldInfoPtr_defaultKeyboardMouseMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "defaultKeyboardMouseMappings");
		NativeFieldInfoPtr_defaultGamepadMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "defaultGamepadMappings");
		NativeFieldInfoPtr_specialKeyboardMouseMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "specialKeyboardMouseMappings");
		NativeFieldInfoPtr_specialGamepadMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "specialGamepadMappings");
		NativeFieldInfoPtr_qualityPresetSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "qualityPresetSettings");
		NativeFieldInfoPtr_grassShadowsSettingChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "grassShadowsSettingChangeCallbacks");
		NativeFieldInfoPtr_viewDistanceSettingChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "viewDistanceSettingChangeCallbacks");
		NativeFieldInfoPtr_firesCastShadowsSettingChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "firesCastShadowsSettingChangeCallbacks");
		NativeFieldInfoPtr_postProcessingSettingChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "postProcessingSettingChangeCallbacks");
		NativeFieldInfoPtr_ssaoQualitySettingChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "ssaoQualitySettingChangeCallbacks");
		NativeFieldInfoPtr_waterReflectionQualitySettingChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "waterReflectionQualitySettingChangeCallbacks");
		NativeFieldInfoPtr_bloomIntensitySettingChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "bloomIntensitySettingChangeCallbacks");
		NativeFieldInfoPtr_selectionHighlightBrightnessChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "selectionHighlightBrightnessChangeCallbacks");
		NativeFieldInfoPtr_chromaticAberrationSettingChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "chromaticAberrationSettingChangeCallbacks");
		NativeFieldInfoPtr_cameraPerspectiveChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "cameraPerspectiveChangeCallbacks");
		NativeFieldInfoPtr_cameraInvertMouseYChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "cameraInvertMouseYChangeCallbacks");
		NativeFieldInfoPtr_cameraAngleChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "cameraAngleChangeCallbacks");
		NativeFieldInfoPtr_cameraCursorMovementAmounthangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "cameraCursorMovementAmounthangeCallbacks");
		NativeFieldInfoPtr_playerMovementStyleChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "playerMovementStyleChangeCallbacks");
		NativeFieldInfoPtr_playerOrientationStyleChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "playerOrientationStyleChangeCallbacks");
		NativeFieldInfoPtr_playerInteractionStyleChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "playerInteractionStyleChangeCallbacks");
		NativeFieldInfoPtr_playerAttackStyleChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "playerAttackStyleChangeCallbacks");
		NativeFieldInfoPtr_playerRotationSensitivityCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "playerRotationSensitivityCallbacks");
		NativeFieldInfoPtr_playerGamepadLookSensitivityCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "playerGamepadLookSensitivityCallbacks");
		NativeFieldInfoPtr_playerGamepadGlyphsCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "playerGamepadGlyphsCallbacks");
		NativeFieldInfoPtr_playerToggleRunChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "playerToggleRunChangeCallbacks");
		NativeFieldInfoPtr_languageChangeCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, "languageChangeCallbacks");
		NativeMethodInfoPtr_get_persistenceManager_Public_get_IPersistenceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677242);
		NativeMethodInfoPtr_set_persistenceManager_Public_set_Void_IPersistenceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677243);
		NativeMethodInfoPtr_get_localizationManager_Public_get_ILocalizationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677244);
		NativeMethodInfoPtr_set_localizationManager_Public_set_Void_ILocalizationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677245);
		NativeMethodInfoPtr_get_steamIntegrationManager_Public_get_ISteamIntegrationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677246);
		NativeMethodInfoPtr_set_steamIntegrationManager_Public_set_Void_ISteamIntegrationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677247);
		NativeMethodInfoPtr_get_uiManager_Public_get_IUIManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677248);
		NativeMethodInfoPtr_set_uiManager_Public_set_Void_IUIManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677249);
		NativeMethodInfoPtr_Init_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677250);
		NativeMethodInfoPtr_GetGameplaySettings_Public_Virtual_Final_New_GameplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677251);
		NativeMethodInfoPtr_setGameplaySettings_Private_Void_GameplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677252);
		NativeMethodInfoPtr_SetGameplaySettings_Public_Virtual_Final_New_Void_GameplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677253);
		NativeMethodInfoPtr_setSoundSettings_Private_Void_SoundSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677254);
		NativeMethodInfoPtr_SetSoundSettings_Public_Virtual_Final_New_Void_SoundSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677255);
		NativeMethodInfoPtr_GetSoundSettings_Public_Virtual_Final_New_SoundSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677256);
		NativeMethodInfoPtr_applyKeyboardMouseIdentifierMappings_Private_Void_Dictionary_2_InputAction_ValueTuple_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677257);
		NativeMethodInfoPtr_applyGamepadIdentifierMappings_Private_Void_Dictionary_2_InputAction_ValueTuple_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677258);
		NativeMethodInfoPtr_applySpecialControlMappings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677259);
		NativeMethodInfoPtr_setDefaultControlMappings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677260);
		NativeMethodInfoPtr_SetKeyboardMouseDefaults_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677261);
		NativeMethodInfoPtr_SetGamepadDefaults_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677262);
		NativeMethodInfoPtr_initControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677263);
		NativeMethodInfoPtr_setInput_Private_Void_InputAction_ControlInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677264);
		NativeMethodInfoPtr_setPlayerMovementStyle_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677265);
		NativeMethodInfoPtr_setPlayerOrientationStyle_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677266);
		NativeMethodInfoPtr_setPlayerInteractionStyle_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677267);
		NativeMethodInfoPtr_setPlayerAttackStyle_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677268);
		NativeMethodInfoPtr_setPerspective_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677269);
		NativeMethodInfoPtr_setInvertMouseY_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677270);
		NativeMethodInfoPtr_setSwapMacCommandAlt_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677271);
		NativeMethodInfoPtr_setRotationSensitivity_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677272);
		NativeMethodInfoPtr_setGamepadLookSensitivity_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677273);
		NativeMethodInfoPtr_setGamepadGlyphs_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677274);
		NativeMethodInfoPtr_setToggleRun_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677275);
		NativeMethodInfoPtr_setToggleShowItems_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677276);
		NativeMethodInfoPtr_setControlSettings_Private_Void_ControlSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677277);
		NativeMethodInfoPtr_assignKeyboardMouseMapping_Private_Void_InputAction_ControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677278);
		NativeMethodInfoPtr_assignGamepadMapping_Private_Void_InputAction_ControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677279);
		NativeMethodInfoPtr_SetControlSettings_Public_Virtual_Final_New_Void_ControlSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677280);
		NativeMethodInfoPtr_GetControlSettings_Public_Virtual_Final_New_ControlSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677281);
		NativeMethodInfoPtr_GetControlSettingsCopy_Public_Virtual_Final_New_ControlSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677282);
		NativeMethodInfoPtr_AddCameraPerspectiveChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677283);
		NativeMethodInfoPtr_AddCameraInvertMouseYChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677284);
		NativeMethodInfoPtr_AddCameraAngleChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677285);
		NativeMethodInfoPtr_AddCameraCursorMovementAmountChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677286);
		NativeMethodInfoPtr_AddPlayerMovementStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677287);
		NativeMethodInfoPtr_AddPlayerOrientationStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677288);
		NativeMethodInfoPtr_RemovePlayerOrientationStyleSettingChangeListener_Public_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677289);
		NativeMethodInfoPtr_AddPlayerInteractionStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677290);
		NativeMethodInfoPtr_RemovePlayerInteractionStyleSettingChangeListener_Public_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677291);
		NativeMethodInfoPtr_AddPlayerAttackStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677292);
		NativeMethodInfoPtr_RemovePlayerAttackStyleSettingChangeListener_Public_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677293);
		NativeMethodInfoPtr_AddPlayerRotationSensitivityChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677294);
		NativeMethodInfoPtr_AddPlayerGamepadLookSensitivityChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677295);
		NativeMethodInfoPtr_AddPlayerGamepadGlyphsSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677296);
		NativeMethodInfoPtr_AddPlayerToggleRunSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677297);
		NativeMethodInfoPtr_AddLanguageChangeListener_Public_Virtual_Final_New_Void_LanguageChangeCallback_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677298);
		NativeMethodInfoPtr_GetInputKeyPressed_Public_Virtual_Final_New_InputKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677299);
		NativeMethodInfoPtr_GetGamepadPressed_Public_Virtual_Final_New_InputGamepad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677300);
		NativeMethodInfoPtr_GetInputAxisPressed_Public_Virtual_Final_New_InputAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677301);
		NativeMethodInfoPtr_GetMultiplayerSettings_Public_Virtual_Final_New_MultiplayerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677302);
		NativeMethodInfoPtr_setLanguage_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677303);
		NativeMethodInfoPtr_setHideHints_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677304);
		NativeMethodInfoPtr_setSkipTutorialTasks_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677305);
		NativeMethodInfoPtr_setAutosaveMinutes_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677306);
		NativeMethodInfoPtr_setAutosaveWhenCaveEnter_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677307);
		NativeMethodInfoPtr_setCameraAngles_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677308);
		NativeMethodInfoPtr_setCameraCursorMovementAmount_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677309);
		NativeMethodInfoPtr_setFastForwardOption_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677310);
		NativeMethodInfoPtr_setFastForwardBlurEffect_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677311);
		NativeMethodInfoPtr_setConcussionBlurEffect_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677312);
		NativeMethodInfoPtr_setQuickPickups_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677313);
		NativeMethodInfoPtr_setShowDiscoveries_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677314);
		NativeMethodInfoPtr_setConsoleEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677315);
		NativeMethodInfoPtr_setGameVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677316);
		NativeMethodInfoPtr_setUIVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677317);
		NativeMethodInfoPtr_GetDisplaySettings_Public_Virtual_Final_New_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677318);
		NativeMethodInfoPtr_GetQualitySettingsForPreset_Public_Virtual_Final_New_SurvivalQualitySettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677319);
		NativeMethodInfoPtr_GetQualityPresetLevelForSettings_Public_Virtual_Final_New_Int32_SurvivalQualitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677320);
		NativeMethodInfoPtr_SetDisplaySettings_Public_Virtual_Final_New_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677321);
		NativeMethodInfoPtr_setQualitySettings_Private_Void_SurvivalQualitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677322);
		NativeMethodInfoPtr_SetQualitySettings_Public_Virtual_Final_New_Void_SurvivalQualitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677323);
		NativeMethodInfoPtr_GetQualitySettings_Public_Virtual_Final_New_SurvivalQualitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677324);
		NativeMethodInfoPtr_GetResolutionOptions_Public_Virtual_Final_New_Il2CppReferenceArray_1_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677325);
		NativeMethodInfoPtr_getPreferredResolution_Private_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677326);
		NativeMethodInfoPtr_setScreenResolution_Private_Void_ScreenResolution_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677327);
		NativeMethodInfoPtr_setUIScale_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677328);
		NativeMethodInfoPtr_setTextureQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677329);
		NativeMethodInfoPtr_setAnisotropicFilteringEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677330);
		NativeMethodInfoPtr_setObjectQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677331);
		NativeMethodInfoPtr_setShadowQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677332);
		NativeMethodInfoPtr_getShadowDistance_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677333);
		NativeMethodInfoPtr_setViewDistance_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677334);
		NativeMethodInfoPtr_setGrassShadowsEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677335);
		NativeMethodInfoPtr_setFiresCastShadows_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677336);
		NativeMethodInfoPtr_GrassShadowsEnabled_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677337);
		NativeMethodInfoPtr_AddGrassShadowSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677338);
		NativeMethodInfoPtr_GetViewDistance_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677339);
		NativeMethodInfoPtr_AddViewDistanceChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677340);
		NativeMethodInfoPtr_FiresCastShadows_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677341);
		NativeMethodInfoPtr_AddFiresCastShadowsSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677342);
		NativeMethodInfoPtr_setPostProcessingEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677343);
		NativeMethodInfoPtr_PostProcessingEnabled_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677344);
		NativeMethodInfoPtr_GetSSAOQualityLevel_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677345);
		NativeMethodInfoPtr_GetSelectionHighlightBrightness_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677346);
		NativeMethodInfoPtr_GetWaterReflectionQualityLevel_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677347);
		NativeMethodInfoPtr_GetCloudQualityLevel_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677348);
		NativeMethodInfoPtr_IsCloudShadowsEnabled_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677349);
		NativeMethodInfoPtr_GetBloomIntensity_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677350);
		NativeMethodInfoPtr_IsChromaticAberrationEnabled_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677351);
		NativeMethodInfoPtr_AddBloomIntensityChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677352);
		NativeMethodInfoPtr_AddSelectionHighlightBrightnessChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677353);
		NativeMethodInfoPtr_AddChromaticAberrationChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677354);
		NativeMethodInfoPtr_AddPostProcessingSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677355);
		NativeMethodInfoPtr_AddSSAOSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677356);
		NativeMethodInfoPtr_AddWaterReflectionQualityChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677357);
		NativeMethodInfoPtr_GetKeyboardMouseControls_Public_Virtual_Final_New_Controls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677358);
		NativeMethodInfoPtr_GetGamepadControls_Public_Virtual_Final_New_Controls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677359);
		NativeMethodInfoPtr_setWaterReflectionQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677360);
		NativeMethodInfoPtr_setSSAOQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677361);
		NativeMethodInfoPtr_setAntiAliasingQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677362);
		NativeMethodInfoPtr_setGrassAntiAliasingEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677363);
		NativeMethodInfoPtr_setCloudQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677364);
		NativeMethodInfoPtr_setCloudShadowsEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677365);
		NativeMethodInfoPtr_setTrrainTessellationEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677366);
		NativeMethodInfoPtr_setBloomIntensity_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677367);
		NativeMethodInfoPtr_setSelectionHighlightBrightness_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677368);
		NativeMethodInfoPtr_setChromaticAberrationEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677369);
		NativeMethodInfoPtr_setVsyncEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677370);
		NativeMethodInfoPtr_setLimitFramerateEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677371);
		NativeMethodInfoPtr_setMaxFramerate_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677372);
		NativeMethodInfoPtr_AddBannedUserId_Public_Virtual_Final_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677373);
		NativeMethodInfoPtr_RemoveBannedUserId_Public_Virtual_Final_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677374);
		NativeMethodInfoPtr_IsUserIdBanned_Public_Virtual_Final_New_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677375);
		NativeMethodInfoPtr_IsUserIdMod_Public_Virtual_Final_New_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677376);
		NativeMethodInfoPtr_GetBannedUserIds_Public_Virtual_Final_New_HashSet_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677377);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr, 100677378);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199456, XrefRangeEnd = 199461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameplaySettings GetGameplaySettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGameplaySettings_Public_Virtual_Final_New_GameplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new GameplaySettings(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199464, RefRangeEnd = 199466, XrefRangeStart = 199461, XrefRangeEnd = 199464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setGameplaySettings(GameplaySettings newGameplaySettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)newGameplaySettings));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGameplaySettings_Private_Void_GameplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199466, XrefRangeEnd = 199471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetGameplaySettings(GameplaySettings newGameplaySettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)newGameplaySettings));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGameplaySettings_Public_Virtual_Final_New_Void_GameplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199477, RefRangeEnd = 199478, XrefRangeStart = 199471, XrefRangeEnd = 199477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setSoundSettings(SoundSettings newSoundSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newSoundSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSoundSettings_Private_Void_SoundSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199478, XrefRangeEnd = 199488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetSoundSettings(SoundSettings newSoundSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newSoundSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSoundSettings_Public_Virtual_Final_New_Void_SoundSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual SoundSettings GetSoundSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSoundSettings_Public_Virtual_Final_New_SoundSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SoundSettings*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 199534, RefRangeEnd = 199538, XrefRangeStart = 199488, XrefRangeEnd = 199534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyKeyboardMouseIdentifierMappings(Dictionary<InputAction, Il2CppSystem.ValueTuple<string, string>> mappings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mappings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyKeyboardMouseIdentifierMappings_Private_Void_Dictionary_2_InputAction_ValueTuple_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 199573, RefRangeEnd = 199577, XrefRangeStart = 199538, XrefRangeEnd = 199573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyGamepadIdentifierMappings(Dictionary<InputAction, Il2CppSystem.ValueTuple<string, string>> mappings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mappings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyGamepadIdentifierMappings_Private_Void_Dictionary_2_InputAction_ValueTuple_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199579, RefRangeEnd = 199580, XrefRangeStart = 199577, XrefRangeEnd = 199579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applySpecialControlMappings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applySpecialControlMappings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199582, RefRangeEnd = 199583, XrefRangeStart = 199580, XrefRangeEnd = 199582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setDefaultControlMappings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDefaultControlMappings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199583, XrefRangeEnd = 199588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetKeyboardMouseDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetKeyboardMouseDefaults_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199588, XrefRangeEnd = 199593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetGamepadDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGamepadDefaults_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199679, RefRangeEnd = 199680, XrefRangeStart = 199593, XrefRangeEnd = 199679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initControls()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 199708, RefRangeEnd = 199720, XrefRangeStart = 199680, XrefRangeEnd = 199708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setInput(InputAction inputAction, ControlInput controlInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inputAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlInput);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setInput_Private_Void_InputAction_ControlInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199734, RefRangeEnd = 199736, XrefRangeStart = 199720, XrefRangeEnd = 199734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPlayerMovementStyle(int playerMovementStyle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerMovementStyle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPlayerMovementStyle_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199750, RefRangeEnd = 199752, XrefRangeStart = 199736, XrefRangeEnd = 199750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPlayerOrientationStyle(int playerOrientationStyle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerOrientationStyle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPlayerOrientationStyle_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199766, RefRangeEnd = 199768, XrefRangeStart = 199752, XrefRangeEnd = 199766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPlayerInteractionStyle(int playerInteractionStyle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerInteractionStyle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPlayerInteractionStyle_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199782, RefRangeEnd = 199784, XrefRangeStart = 199768, XrefRangeEnd = 199782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPlayerAttackStyle(int playerAttackStyle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerAttackStyle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPlayerAttackStyle_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199798, RefRangeEnd = 199800, XrefRangeStart = 199784, XrefRangeEnd = 199798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPerspective(int perspective)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&perspective);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPerspective_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199814, RefRangeEnd = 199816, XrefRangeStart = 199800, XrefRangeEnd = 199814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setInvertMouseY(bool invertMouseY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&invertMouseY);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setInvertMouseY_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199868, RefRangeEnd = 199870, XrefRangeStart = 199816, XrefRangeEnd = 199868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setSwapMacCommandAlt(bool macExternalKeyboardLayout)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&macExternalKeyboardLayout);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSwapMacCommandAlt_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199887, RefRangeEnd = 199889, XrefRangeStart = 199870, XrefRangeEnd = 199887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setRotationSensitivity(float sensitivity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sensitivity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setRotationSensitivity_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199906, RefRangeEnd = 199908, XrefRangeStart = 199889, XrefRangeEnd = 199906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setGamepadLookSensitivity(float sensitivity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sensitivity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGamepadLookSensitivity_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199922, RefRangeEnd = 199924, XrefRangeStart = 199908, XrefRangeEnd = 199922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setGamepadGlyphs(int gamepadGlyphs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gamepadGlyphs);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGamepadGlyphs_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 199938, RefRangeEnd = 199940, XrefRangeStart = 199924, XrefRangeEnd = 199938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setToggleRun(bool toggleRun)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&toggleRun);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setToggleRun_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setToggleShowItems(bool toggleShowItems)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&toggleShowItems);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setToggleShowItems_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199951, RefRangeEnd = 199952, XrefRangeStart = 199940, XrefRangeEnd = 199951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setControlSettings(ControlSettings newControlSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newControlSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setControlSettings_Private_Void_ControlSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199956, RefRangeEnd = 199957, XrefRangeStart = 199952, XrefRangeEnd = 199956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void assignKeyboardMouseMapping(InputAction inputAction, ControlMapping mapping)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inputAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)mapping));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_assignKeyboardMouseMapping_Private_Void_InputAction_ControlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 199961, RefRangeEnd = 199962, XrefRangeStart = 199957, XrefRangeEnd = 199961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void assignGamepadMapping(InputAction inputAction, ControlMapping mapping)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&inputAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)mapping));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_assignGamepadMapping_Private_Void_InputAction_ControlMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199962, XrefRangeEnd = 200013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetControlSettings(ControlSettings newControlSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newControlSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetControlSettings_Public_Virtual_Final_New_Void_ControlSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual ControlSettings GetControlSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControlSettings_Public_Virtual_Final_New_ControlSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlSettings>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200013, XrefRangeEnd = 200026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ControlSettings GetControlSettingsCopy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControlSettingsCopy_Public_Virtual_Final_New_ControlSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlSettings>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200026, XrefRangeEnd = 200030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddCameraPerspectiveChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCameraPerspectiveChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200030, XrefRangeEnd = 200034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddCameraInvertMouseYChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCameraInvertMouseYChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200034, XrefRangeEnd = 200038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddCameraAngleChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCameraAngleChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200038, XrefRangeEnd = 200042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddCameraCursorMovementAmountChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCameraCursorMovementAmountChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200042, XrefRangeEnd = 200046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddPlayerMovementStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerMovementStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200046, XrefRangeEnd = 200050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddPlayerOrientationStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerOrientationStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200050, XrefRangeEnd = 200054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePlayerOrientationStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemovePlayerOrientationStyleSettingChangeListener_Public_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200054, XrefRangeEnd = 200058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddPlayerInteractionStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerInteractionStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200058, XrefRangeEnd = 200062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePlayerInteractionStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemovePlayerInteractionStyleSettingChangeListener_Public_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200062, XrefRangeEnd = 200066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddPlayerAttackStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerAttackStyleSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200066, XrefRangeEnd = 200070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePlayerAttackStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemovePlayerAttackStyleSettingChangeListener_Public_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200070, XrefRangeEnd = 200074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddPlayerRotationSensitivityChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerRotationSensitivityChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200074, XrefRangeEnd = 200078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddPlayerGamepadLookSensitivityChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerGamepadLookSensitivityChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200078, XrefRangeEnd = 200082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddPlayerGamepadGlyphsSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerGamepadGlyphsSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200082, XrefRangeEnd = 200086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddPlayerToggleRunSettingChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlayerToggleRunSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200086, XrefRangeEnd = 200093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddLanguageChangeListener(LanguageChangeCallback callback, bool priority = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &priority;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLanguageChangeListener_Public_Virtual_Final_New_Void_LanguageChangeCallback_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200093, XrefRangeEnd = 200118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual InputKey GetInputKeyPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputKeyPressed_Public_Virtual_Final_New_InputKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputKey>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200118, XrefRangeEnd = 200138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual InputGamepad GetGamepadPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGamepadPressed_Public_Virtual_Final_New_InputGamepad_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputGamepad>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200138, XrefRangeEnd = 200151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual InputAxis GetInputAxisPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputAxisPressed_Public_Virtual_Final_New_InputAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputAxis>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual MultiplayerSettings GetMultiplayerSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMultiplayerSettings_Public_Virtual_Final_New_MultiplayerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new MultiplayerSettings(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200170, RefRangeEnd = 200171, XrefRangeStart = 200151, XrefRangeEnd = 200170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setLanguage(string language)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(language);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLanguage_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setHideHints(bool hideHints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hideHints);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setHideHints_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setSkipTutorialTasks(bool skipTutorialTasks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skipTutorialTasks);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSkipTutorialTasks_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setAutosaveMinutes(int autosaveMinutes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&autosaveMinutes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAutosaveMinutes_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setAutosaveWhenCaveEnter(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAutosaveWhenCaveEnter_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200185, RefRangeEnd = 200186, XrefRangeStart = 200171, XrefRangeEnd = 200185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setCameraAngles(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCameraAngles_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200200, RefRangeEnd = 200201, XrefRangeStart = 200186, XrefRangeEnd = 200200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setCameraCursorMovementAmount(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCameraCursorMovementAmount_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setFastForwardOption(int option)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&option);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFastForwardOption_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setFastForwardBlurEffect(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFastForwardBlurEffect_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setConcussionBlurEffect(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setConcussionBlurEffect_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setQuickPickups(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setQuickPickups_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setShowDiscoveries(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setShowDiscoveries_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setConsoleEnabled(bool consoleEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&consoleEnabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setConsoleEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200201, XrefRangeEnd = 200204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setGameVolume(float gameVolume)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gameVolume);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGameVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200204, XrefRangeEnd = 200207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setUIVolume(float uiVolume)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uiVolume);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setUIVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual DisplaySettings GetDisplaySettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDisplaySettings_Public_Virtual_Final_New_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DisplaySettings(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200210, RefRangeEnd = 200211, XrefRangeStart = 200207, XrefRangeEnd = 200210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual SurvivalQualitySettings GetQualitySettingsForPreset(int qualityPreset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&qualityPreset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQualitySettingsForPreset_Public_Virtual_Final_New_SurvivalQualitySettings_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurvivalQualitySettings*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200211, XrefRangeEnd = 200224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int GetQualityPresetLevelForSettings(SurvivalQualitySettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&settings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQualityPresetLevelForSettings_Public_Virtual_Final_New_Int32_SurvivalQualitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200243, RefRangeEnd = 200244, XrefRangeStart = 200224, XrefRangeEnd = 200243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetDisplaySettings(DisplaySettings newDisplaySettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)newDisplaySettings));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDisplaySettings_Public_Virtual_Final_New_Void_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 200326, RefRangeEnd = 200328, XrefRangeStart = 200244, XrefRangeEnd = 200326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setQualitySettings(SurvivalQualitySettings newQualitySettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newQualitySettings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setQualitySettings_Private_Void_SurvivalQualitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200328, XrefRangeEnd = 200333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetQualitySettings(SurvivalQualitySettings newQualitySettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newQualitySettings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetQualitySettings_Public_Virtual_Final_New_Void_SurvivalQualitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual SurvivalQualitySettings GetQualitySettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQualitySettings_Public_Virtual_Final_New_SurvivalQualitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurvivalQualitySettings*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 977, RefRangeEnd = 983, XrefRangeStart = 977, XrefRangeEnd = 983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppReferenceArray<ScreenResolution> GetResolutionOptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResolutionOptions_Public_Virtual_Final_New_Il2CppReferenceArray_1_ScreenResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScreenResolution>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe ScreenResolution getPreferredResolution()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getPreferredResolution_Private_ScreenResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScreenResolution>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200333, XrefRangeEnd = 200341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setScreenResolution(ScreenResolution resolution, int fullScreenMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resolution);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullScreenMode;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setScreenResolution_Private_Void_ScreenResolution_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200341, XrefRangeEnd = 200347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setUIScale(float uiScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uiScale);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setUIScale_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200347, XrefRangeEnd = 200348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setTextureQuality(int quality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTextureQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200348, XrefRangeEnd = 200349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setAnisotropicFilteringEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAnisotropicFilteringEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200349, XrefRangeEnd = 200350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setObjectQuality(int quality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setObjectQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200364, RefRangeEnd = 200365, XrefRangeStart = 200350, XrefRangeEnd = 200364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setShadowQuality(int quality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setShadowQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 200371, RefRangeEnd = 200375, XrefRangeStart = 200365, XrefRangeEnd = 200371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getShadowDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getShadowDistance_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200398, RefRangeEnd = 200399, XrefRangeStart = 200375, XrefRangeEnd = 200398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setViewDistance(float viewDistance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewDistance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setViewDistance_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200413, RefRangeEnd = 200414, XrefRangeStart = 200399, XrefRangeEnd = 200413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setGrassShadowsEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGrassShadowsEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200428, RefRangeEnd = 200429, XrefRangeStart = 200414, XrefRangeEnd = 200428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setFiresCastShadows(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFiresCastShadows_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool GrassShadowsEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GrassShadowsEnabled_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200429, XrefRangeEnd = 200433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddGrassShadowSettingChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGrassShadowSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual float GetViewDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetViewDistance_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200433, XrefRangeEnd = 200437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddViewDistanceChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddViewDistanceChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool FiresCastShadows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FiresCastShadows_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200437, XrefRangeEnd = 200441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddFiresCastShadowsSettingChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFiresCastShadowsSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200455, RefRangeEnd = 200456, XrefRangeStart = 200441, XrefRangeEnd = 200455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPostProcessingEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPostProcessingEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool PostProcessingEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostProcessingEnabled_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int GetSSAOQualityLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSSAOQualityLevel_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetSelectionHighlightBrightness()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSelectionHighlightBrightness_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int GetWaterReflectionQualityLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWaterReflectionQualityLevel_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int GetCloudQualityLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCloudQualityLevel_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsCloudShadowsEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCloudShadowsEnabled_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetBloomIntensity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBloomIntensity_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsChromaticAberrationEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsChromaticAberrationEnabled_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200456, XrefRangeEnd = 200460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddBloomIntensityChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBloomIntensityChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200460, XrefRangeEnd = 200464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddSelectionHighlightBrightnessChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSelectionHighlightBrightnessChangeListener_Public_Virtual_Final_New_Void_FloatSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200464, XrefRangeEnd = 200468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddChromaticAberrationChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChromaticAberrationChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200468, XrefRangeEnd = 200472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddPostProcessingSettingChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPostProcessingSettingChangeListener_Public_Virtual_Final_New_Void_BoolSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200472, XrefRangeEnd = 200476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddSSAOSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSSAOSettingChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200476, XrefRangeEnd = 200480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddWaterReflectionQualityChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWaterReflectionQualityChangeListener_Public_Virtual_Final_New_Void_IntSettingChangeCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Controls GetKeyboardMouseControls()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyboardMouseControls_Public_Virtual_Final_New_Controls_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controls>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Controls GetGamepadControls()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGamepadControls_Public_Virtual_Final_New_Controls_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controls>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200494, RefRangeEnd = 200495, XrefRangeStart = 200480, XrefRangeEnd = 200494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setWaterReflectionQuality(int quality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setWaterReflectionQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200509, RefRangeEnd = 200510, XrefRangeStart = 200495, XrefRangeEnd = 200509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setSSAOQuality(int quality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSSAOQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200510, XrefRangeEnd = 200514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setAntiAliasingQuality(int quality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAntiAliasingQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200514, XrefRangeEnd = 200528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setGrassAntiAliasingEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setGrassAntiAliasingEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200528, XrefRangeEnd = 200533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setCloudQuality(int quality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quality);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCloudQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200533, XrefRangeEnd = 200538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setCloudShadowsEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCloudShadowsEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200538, XrefRangeEnd = 200552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setTrrainTessellationEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTrrainTessellationEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200569, RefRangeEnd = 200570, XrefRangeStart = 200552, XrefRangeEnd = 200569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setBloomIntensity(float bloomIntensity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bloomIntensity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setBloomIntensity_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200587, RefRangeEnd = 200588, XrefRangeStart = 200570, XrefRangeEnd = 200587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setSelectionHighlightBrightness(float selectionHighlightBrightness)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&selectionHighlightBrightness);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSelectionHighlightBrightness_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 200602, RefRangeEnd = 200603, XrefRangeStart = 200588, XrefRangeEnd = 200602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setChromaticAberrationEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setChromaticAberrationEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200603, XrefRangeEnd = 200604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setVsyncEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setVsyncEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200604, XrefRangeEnd = 200606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setLimitFramerateEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLimitFramerateEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200606, XrefRangeEnd = 200607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setMaxFramerate(int framerate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&framerate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMaxFramerate_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200607, XrefRangeEnd = 200614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddBannedUserId(ulong userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&userId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBannedUserId_Public_Virtual_Final_New_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200614, XrefRangeEnd = 200621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveBannedUserId(ulong userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&userId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBannedUserId_Public_Virtual_Final_New_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200621, XrefRangeEnd = 200625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsUserIdBanned(ulong userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&userId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUserIdBanned_Public_Virtual_Final_New_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200625, XrefRangeEnd = 200628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsUserIdMod(ulong userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&userId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUserIdMod_Public_Virtual_Final_New_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual HashSet<ulong> GetBannedUserIds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBannedUserIds_Public_Virtual_Final_New_HashSet_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ulong>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200628, XrefRangeEnd = 203751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SettingsManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SettingsManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

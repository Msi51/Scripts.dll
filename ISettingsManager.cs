using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class ISettingsManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetGameplaySettings_Public_Abstract_Virtual_New_GameplaySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetGameplaySettings_Public_Abstract_Virtual_New_Void_GameplaySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSoundSettings_Public_Abstract_Virtual_New_Void_SoundSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSoundSettings_Public_Abstract_Virtual_New_SoundSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetControlSettings_Public_Abstract_Virtual_New_ControlSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetControlSettingsCopy_Public_Abstract_Virtual_New_ControlSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetControlSettings_Public_Abstract_Virtual_New_Void_ControlSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetKeyboardMouseDefaults_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetGamepadDefaults_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInputKeyPressed_Public_Abstract_Virtual_New_InputKey_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetGamepadPressed_Public_Abstract_Virtual_New_InputGamepad_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInputAxisPressed_Public_Abstract_Virtual_New_InputAxis_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMultiplayerSettings_Public_Abstract_Virtual_New_MultiplayerSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDisplaySettings_Public_Abstract_Virtual_New_DisplaySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDisplaySettings_Public_Abstract_Virtual_New_Void_DisplaySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResolutionOptions_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ScreenResolution_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetQualitySettings_Public_Abstract_Virtual_New_SurvivalQualitySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetQualitySettings_Public_Abstract_Virtual_New_Void_SurvivalQualitySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetQualityPresetLevelForSettings_Public_Abstract_Virtual_New_Int32_SurvivalQualitySettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetQualitySettingsForPreset_Public_Abstract_Virtual_New_SurvivalQualitySettings_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GrassShadowsEnabled_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddGrassShadowSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetViewDistance_Public_Abstract_Virtual_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_FiresCastShadows_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddFiresCastShadowsSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_PostProcessingEnabled_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSSAOQualityLevel_Public_Abstract_Virtual_New_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSelectionHighlightBrightness_Public_Abstract_Virtual_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWaterReflectionQualityLevel_Public_Abstract_Virtual_New_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCloudQualityLevel_Public_Abstract_Virtual_New_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsCloudShadowsEnabled_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBloomIntensity_Public_Abstract_Virtual_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsChromaticAberrationEnabled_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddPostProcessingSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddSSAOSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddWaterReflectionQualityChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetKeyboardMouseControls_Public_Abstract_Virtual_New_Controls_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetGamepadControls_Public_Abstract_Virtual_New_Controls_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddCameraPerspectiveChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddCameraInvertMouseYChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddCameraAngleChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddCameraCursorMovementAmountChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddPlayerMovementStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddPlayerOrientationStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddPlayerInteractionStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToggleRunSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddPlayerAttackStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddPlayerRotationSensitivityChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddPlayerGamepadLookSensitivityChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddPlayerGamepadGlyphsSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddLanguageChangeListener_Public_Abstract_Virtual_New_Void_LanguageChangeCallback_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddViewDistanceChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddBloomIntensityChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddSelectionHighlightBrightnessChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddChromaticAberrationChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddBannedUserId_Public_Abstract_Virtual_New_Void_UInt64_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveBannedUserId_Public_Abstract_Virtual_New_Void_UInt64_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsUserIdBanned_Public_Abstract_Virtual_New_Boolean_UInt64_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsUserIdMod_Public_Abstract_Virtual_New_Boolean_UInt64_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBannedUserIds_Public_Abstract_Virtual_New_HashSet_1_UInt64_0;

	static ISettingsManager()
	{
		Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISettingsManager");
		NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675776);
		NativeMethodInfoPtr_GetGameplaySettings_Public_Abstract_Virtual_New_GameplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675777);
		NativeMethodInfoPtr_SetGameplaySettings_Public_Abstract_Virtual_New_Void_GameplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675778);
		NativeMethodInfoPtr_SetSoundSettings_Public_Abstract_Virtual_New_Void_SoundSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675779);
		NativeMethodInfoPtr_GetSoundSettings_Public_Abstract_Virtual_New_SoundSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675780);
		NativeMethodInfoPtr_GetControlSettings_Public_Abstract_Virtual_New_ControlSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675781);
		NativeMethodInfoPtr_GetControlSettingsCopy_Public_Abstract_Virtual_New_ControlSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675782);
		NativeMethodInfoPtr_SetControlSettings_Public_Abstract_Virtual_New_Void_ControlSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675783);
		NativeMethodInfoPtr_SetKeyboardMouseDefaults_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675784);
		NativeMethodInfoPtr_SetGamepadDefaults_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675785);
		NativeMethodInfoPtr_GetInputKeyPressed_Public_Abstract_Virtual_New_InputKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675786);
		NativeMethodInfoPtr_GetGamepadPressed_Public_Abstract_Virtual_New_InputGamepad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675787);
		NativeMethodInfoPtr_GetInputAxisPressed_Public_Abstract_Virtual_New_InputAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675788);
		NativeMethodInfoPtr_GetMultiplayerSettings_Public_Abstract_Virtual_New_MultiplayerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675789);
		NativeMethodInfoPtr_GetDisplaySettings_Public_Abstract_Virtual_New_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675790);
		NativeMethodInfoPtr_SetDisplaySettings_Public_Abstract_Virtual_New_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675791);
		NativeMethodInfoPtr_GetResolutionOptions_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675792);
		NativeMethodInfoPtr_GetQualitySettings_Public_Abstract_Virtual_New_SurvivalQualitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675793);
		NativeMethodInfoPtr_SetQualitySettings_Public_Abstract_Virtual_New_Void_SurvivalQualitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675794);
		NativeMethodInfoPtr_GetQualityPresetLevelForSettings_Public_Abstract_Virtual_New_Int32_SurvivalQualitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675795);
		NativeMethodInfoPtr_GetQualitySettingsForPreset_Public_Abstract_Virtual_New_SurvivalQualitySettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675796);
		NativeMethodInfoPtr_GrassShadowsEnabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675797);
		NativeMethodInfoPtr_AddGrassShadowSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675798);
		NativeMethodInfoPtr_GetViewDistance_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675799);
		NativeMethodInfoPtr_FiresCastShadows_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675800);
		NativeMethodInfoPtr_AddFiresCastShadowsSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675801);
		NativeMethodInfoPtr_PostProcessingEnabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675802);
		NativeMethodInfoPtr_GetSSAOQualityLevel_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675803);
		NativeMethodInfoPtr_GetSelectionHighlightBrightness_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675804);
		NativeMethodInfoPtr_GetWaterReflectionQualityLevel_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675805);
		NativeMethodInfoPtr_GetCloudQualityLevel_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675806);
		NativeMethodInfoPtr_IsCloudShadowsEnabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675807);
		NativeMethodInfoPtr_GetBloomIntensity_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675808);
		NativeMethodInfoPtr_IsChromaticAberrationEnabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675809);
		NativeMethodInfoPtr_AddPostProcessingSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675810);
		NativeMethodInfoPtr_AddSSAOSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675811);
		NativeMethodInfoPtr_AddWaterReflectionQualityChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675812);
		NativeMethodInfoPtr_GetKeyboardMouseControls_Public_Abstract_Virtual_New_Controls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675813);
		NativeMethodInfoPtr_GetGamepadControls_Public_Abstract_Virtual_New_Controls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675814);
		NativeMethodInfoPtr_AddCameraPerspectiveChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675815);
		NativeMethodInfoPtr_AddCameraInvertMouseYChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675816);
		NativeMethodInfoPtr_AddCameraAngleChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675817);
		NativeMethodInfoPtr_AddCameraCursorMovementAmountChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675818);
		NativeMethodInfoPtr_AddPlayerMovementStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675819);
		NativeMethodInfoPtr_AddPlayerOrientationStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675820);
		NativeMethodInfoPtr_AddPlayerInteractionStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675821);
		NativeMethodInfoPtr_AddPlayerToggleRunSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675822);
		NativeMethodInfoPtr_AddPlayerAttackStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675823);
		NativeMethodInfoPtr_AddPlayerRotationSensitivityChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675824);
		NativeMethodInfoPtr_AddPlayerGamepadLookSensitivityChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675825);
		NativeMethodInfoPtr_AddPlayerGamepadGlyphsSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675826);
		NativeMethodInfoPtr_AddLanguageChangeListener_Public_Abstract_Virtual_New_Void_LanguageChangeCallback_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675827);
		NativeMethodInfoPtr_AddViewDistanceChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675828);
		NativeMethodInfoPtr_AddBloomIntensityChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675829);
		NativeMethodInfoPtr_AddSelectionHighlightBrightnessChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675830);
		NativeMethodInfoPtr_AddChromaticAberrationChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675831);
		NativeMethodInfoPtr_AddBannedUserId_Public_Abstract_Virtual_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675832);
		NativeMethodInfoPtr_RemoveBannedUserId_Public_Abstract_Virtual_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675833);
		NativeMethodInfoPtr_IsUserIdBanned_Public_Abstract_Virtual_New_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675834);
		NativeMethodInfoPtr_IsUserIdMod_Public_Abstract_Virtual_New_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675835);
		NativeMethodInfoPtr_GetBannedUserIds_Public_Abstract_Virtual_New_HashSet_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISettingsManager>.NativeClassPtr, 100675836);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameplaySettings GetGameplaySettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetGameplaySettings_Public_Abstract_Virtual_New_GameplaySettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new GameplaySettings(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual void SetGameplaySettings(GameplaySettings newGameplaySettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)newGameplaySettings));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetGameplaySettings_Public_Abstract_Virtual_New_Void_GameplaySettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetSoundSettings(SoundSettings newSoundSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&newSoundSettings);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetSoundSettings_Public_Abstract_Virtual_New_Void_SoundSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual SoundSettings GetSoundSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSoundSettings_Public_Abstract_Virtual_New_SoundSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SoundSettings*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual ControlSettings GetControlSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetControlSettings_Public_Abstract_Virtual_New_ControlSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ControlSettings>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ControlSettings GetControlSettingsCopy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetControlSettingsCopy_Public_Abstract_Virtual_New_ControlSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ControlSettings>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SetControlSettings(ControlSettings newControlSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newControlSettings);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetControlSettings_Public_Abstract_Virtual_New_Void_ControlSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetKeyboardMouseDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetKeyboardMouseDefaults_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetGamepadDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetGamepadDefaults_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual InputKey GetInputKeyPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInputKeyPressed_Public_Abstract_Virtual_New_InputKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputKey>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InputGamepad GetGamepadPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetGamepadPressed_Public_Abstract_Virtual_New_InputGamepad_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputGamepad>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InputAxis GetInputAxisPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInputAxisPressed_Public_Abstract_Virtual_New_InputAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InputAxis>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual MultiplayerSettings GetMultiplayerSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMultiplayerSettings_Public_Abstract_Virtual_New_MultiplayerSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new MultiplayerSettings(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual DisplaySettings GetDisplaySettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDisplaySettings_Public_Abstract_Virtual_New_DisplaySettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DisplaySettings(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual void SetDisplaySettings(DisplaySettings newDisplaySettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)newDisplaySettings));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetDisplaySettings_Public_Abstract_Virtual_New_Void_DisplaySettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppReferenceArray<ScreenResolution> GetResolutionOptions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResolutionOptions_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_ScreenResolution_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScreenResolution>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual SurvivalQualitySettings GetQualitySettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetQualitySettings_Public_Abstract_Virtual_New_SurvivalQualitySettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurvivalQualitySettings*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetQualitySettings(SurvivalQualitySettings qualitySettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&qualitySettings);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetQualitySettings_Public_Abstract_Virtual_New_Void_SurvivalQualitySettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual int GetQualityPresetLevelForSettings(SurvivalQualitySettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&settings);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetQualityPresetLevelForSettings_Public_Abstract_Virtual_New_Int32_SurvivalQualitySettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual SurvivalQualitySettings GetQualitySettingsForPreset(int qualityPreset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&qualityPreset);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetQualitySettingsForPreset_Public_Abstract_Virtual_New_SurvivalQualitySettings_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurvivalQualitySettings*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool GrassShadowsEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GrassShadowsEnabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void AddGrassShadowSettingChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddGrassShadowSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual float GetViewDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetViewDistance_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool FiresCastShadows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FiresCastShadows_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void AddFiresCastShadowsSettingChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddFiresCastShadowsSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool PostProcessingEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PostProcessingEnabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int GetSSAOQualityLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSSAOQualityLevel_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetSelectionHighlightBrightness()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSelectionHighlightBrightness_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int GetWaterReflectionQualityLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWaterReflectionQualityLevel_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int GetCloudQualityLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCloudQualityLevel_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsCloudShadowsEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsCloudShadowsEnabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetBloomIntensity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBloomIntensity_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsChromaticAberrationEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsChromaticAberrationEnabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void AddPostProcessingSettingChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddPostProcessingSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddSSAOSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddSSAOSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddWaterReflectionQualityChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddWaterReflectionQualityChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Controls GetKeyboardMouseControls()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetKeyboardMouseControls_Public_Abstract_Virtual_New_Controls_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Controls>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Controls GetGamepadControls()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetGamepadControls_Public_Abstract_Virtual_New_Controls_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Controls>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void AddCameraPerspectiveChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddCameraPerspectiveChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddCameraInvertMouseYChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddCameraInvertMouseYChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddCameraAngleChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddCameraAngleChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddCameraCursorMovementAmountChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddCameraCursorMovementAmountChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddPlayerMovementStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddPlayerMovementStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddPlayerOrientationStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddPlayerOrientationStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddPlayerInteractionStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddPlayerInteractionStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddPlayerToggleRunSettingChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddPlayerToggleRunSettingChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddPlayerAttackStyleSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddPlayerAttackStyleSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddPlayerRotationSensitivityChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddPlayerRotationSensitivityChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddPlayerGamepadLookSensitivityChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddPlayerGamepadLookSensitivityChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddPlayerGamepadGlyphsSettingChangeListener(IntSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddPlayerGamepadGlyphsSettingChangeListener_Public_Abstract_Virtual_New_Void_IntSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddLanguageChangeListener(LanguageChangeCallback callback, bool priority = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &priority;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddLanguageChangeListener_Public_Abstract_Virtual_New_Void_LanguageChangeCallback_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddViewDistanceChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddViewDistanceChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddBloomIntensityChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddBloomIntensityChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddSelectionHighlightBrightnessChangeListener(FloatSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddSelectionHighlightBrightnessChangeListener_Public_Abstract_Virtual_New_Void_FloatSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddChromaticAberrationChangeListener(BoolSettingChangeCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddChromaticAberrationChangeListener_Public_Abstract_Virtual_New_Void_BoolSettingChangeCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddBannedUserId(ulong userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&userId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddBannedUserId_Public_Abstract_Virtual_New_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveBannedUserId(ulong userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&userId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveBannedUserId_Public_Abstract_Virtual_New_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsUserIdBanned(ulong userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&userId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsUserIdBanned_Public_Abstract_Virtual_New_Boolean_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsUserIdMod(ulong userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&userId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsUserIdMod_Public_Abstract_Virtual_New_Boolean_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual HashSet<ulong> GetBannedUserIds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBannedUserIds_Public_Abstract_Virtual_New_HashSet_1_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ulong>>(intPtr) : null;
	}

	public ISettingsManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

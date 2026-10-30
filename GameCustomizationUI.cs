using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GameCustomizationUI : UIComponent
{
	private static readonly IntPtr NativeFieldInfoPtr_advancedGameOptions;

	private static readonly IntPtr NativeFieldInfoPtr_editable;

	private static readonly IntPtr NativeFieldInfoPtr_diseaseTypeOptions;

	private static readonly IntPtr NativeFieldInfoPtr_onCancel;

	private static readonly IntPtr NativeFieldInfoPtr_onRestoreDefaults;

	private static readonly IntPtr NativeMethodInfoPtr_Created_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_buildAdvancedSettingsContents_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_0_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_18_Private_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_19_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_1_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_20_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_21_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_2_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_22_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_23_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_3_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_24_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_25_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_4_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_26_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_27_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_5_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_28_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_29_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_6_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_30_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_31_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_7_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_32_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_33_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_8_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_34_Private_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_35_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_9_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_36_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_37_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_10_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_38_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_39_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_11_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_40_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_41_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_12_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_42_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_43_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_13_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_44_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_45_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_14_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_46_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_47_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_15_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_48_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_49_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_16_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_50_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_51_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_17_Private_Void_SettingRowUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_52_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_53_Private_Boolean_0;

	public unsafe AdvancedGameOptions advancedGameOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedGameOptions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AdvancedGameOptions>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_advancedGameOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)advancedGameOptions));
		}
	}

	public unsafe bool editable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editable)) = flag;
		}
	}

	public unsafe List<string> diseaseTypeOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseTypeOptions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseTypeOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe UnityEvent onCancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCancel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCancel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent onRestoreDefaults
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRestoreDefaults);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onRestoreDefaults)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	static GameCustomizationUI()
	{
		Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GameCustomizationUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr);
		NativeFieldInfoPtr_advancedGameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, "advancedGameOptions");
		NativeFieldInfoPtr_editable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, "editable");
		NativeFieldInfoPtr_diseaseTypeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, "diseaseTypeOptions");
		NativeFieldInfoPtr_onCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, "onCancel");
		NativeFieldInfoPtr_onRestoreDefaults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, "onRestoreDefaults");
		NativeMethodInfoPtr_Created_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664965);
		NativeMethodInfoPtr_buildAdvancedSettingsContents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664966);
		NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664967);
		NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664968);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664969);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_0_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664970);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_18_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664971);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_19_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664972);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_1_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664973);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_20_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664974);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_21_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664975);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_2_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664976);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_22_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664977);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_23_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664978);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_3_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664979);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_24_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664980);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_25_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664981);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_4_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664982);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_26_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664983);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_27_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664984);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_5_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664985);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_28_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664986);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_29_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664987);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_6_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664988);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_30_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664989);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_31_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664990);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_7_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664991);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_32_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664992);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_33_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664993);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_8_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664994);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_34_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664995);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_35_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664996);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_9_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664997);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_36_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664998);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_37_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100664999);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_10_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665000);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_38_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665001);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_39_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665002);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_11_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665003);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_40_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665004);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_41_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665005);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_12_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665006);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_42_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665007);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_43_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665008);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_13_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665009);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_44_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665010);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_45_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665011);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_14_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665012);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_46_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665013);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_47_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665014);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_15_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665015);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_48_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665016);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_49_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665017);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_16_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665018);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_50_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665019);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_51_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665020);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_17_Private_Void_SettingRowUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665021);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_52_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665022);
		NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_53_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr, 100665023);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40457, XrefRangeEnd = 40480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Created()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Created_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 40652, RefRangeEnd = 40655, XrefRangeStart = 40480, XrefRangeEnd = 40652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buildAdvancedSettingsContents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildAdvancedSettingsContents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40663, RefRangeEnd = 40664, XrefRangeStart = 40655, XrefRangeEnd = 40663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Refresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40664, XrefRangeEnd = 40666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnCancel(BaseEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40666, XrefRangeEnd = 40677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCustomizationUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCustomizationUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40677, XrefRangeEnd = 40700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_0(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_0_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40700, XrefRangeEnd = 40703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_18(string option)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_18_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_19()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_19_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40703, XrefRangeEnd = 40725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_1(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_1_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_20(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_20_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_21()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_21_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40725, XrefRangeEnd = 40747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_2(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_2_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_22(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_22_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_23()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_23_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40747, XrefRangeEnd = 40769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_3(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_3_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_24(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_24_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_25()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_25_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40769, XrefRangeEnd = 40791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_4(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_4_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_26(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_26_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_27()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_27_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40791, XrefRangeEnd = 40813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_5(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_5_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_28(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_28_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_29()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_29_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40813, XrefRangeEnd = 40835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_6(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_6_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40835, XrefRangeEnd = 40836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_30(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_30_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_31()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_31_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40836, XrefRangeEnd = 40858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_7(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_7_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40858, XrefRangeEnd = 40859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_32(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_32_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_33()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_33_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40859, XrefRangeEnd = 40881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_8(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_8_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_34(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_34_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_35()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_35_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40881, XrefRangeEnd = 40903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_9(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_9_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40903, XrefRangeEnd = 40904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_36(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_36_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_37()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_37_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40904, XrefRangeEnd = 40926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_10(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_10_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_38(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_38_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_39()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_39_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40926, XrefRangeEnd = 40948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_11(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_11_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_40(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_40_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_41()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_41_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40948, XrefRangeEnd = 40970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_12(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_12_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_42(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_42_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_43()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_43_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40970, XrefRangeEnd = 40992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_13(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_13_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_44(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_44_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_45()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_45_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40992, XrefRangeEnd = 41014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_14(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_14_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_46(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_46_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_47()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_47_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41014, XrefRangeEnd = 41036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_15(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_15_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_48(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_48_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_49()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_49_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41036, XrefRangeEnd = 41058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_16(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_16_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _buildAdvancedSettingsContents_b__6_50(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_50_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_51()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_51_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41058, XrefRangeEnd = 41080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_17(SettingRowUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_17_Private_Void_SettingRowUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41080, XrefRangeEnd = 41082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _buildAdvancedSettingsContents_b__6_52()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_52_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _buildAdvancedSettingsContents_b__6_53()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__buildAdvancedSettingsContents_b__6_53_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public GameCustomizationUI(IntPtr pointer)
		: base(pointer)
	{
	}
}

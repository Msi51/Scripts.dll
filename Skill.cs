using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class Skill : Model
{
	private static readonly IntPtr NativeFieldInfoPtr_identifier;

	private static readonly IntPtr NativeFieldInfoPtr_skillType;

	private static readonly IntPtr NativeFieldInfoPtr_skillCategory;

	private static readonly IntPtr NativeFieldInfoPtr_skillIcon;

	private static readonly IntPtr NativeFieldInfoPtr_rawXpModifier;

	private static readonly IntPtr NativeFieldInfoPtr_chopDamagePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_miningDamagePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_staminaIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_staminaDrainDecreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_critChanceIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_accuracyIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_foragingBonusDropChanceBaseAmount;

	private static readonly IntPtr NativeFieldInfoPtr_foragingBonusDropChanceIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_foragingBonusDropIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_medicalDurabilityIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_antisepticPotencyIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_cookingSpeedIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_fuelEfficiencyIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_igniteChanceIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_fertilizerPotencyIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_cropResilienceIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_butcheringIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_survivalistCraftSpeedIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_woodworkingCraftSpeedIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_metalworkingCraftSpeedIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_leatherworkingCraftSpeedIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_sculptingCraftSpeedIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_herbalismCraftSpeedIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_meatHandlingCraftSpeedIncreasePerLevel;

	private static readonly IntPtr NativeFieldInfoPtr_milestones;

	private static readonly IntPtr NativeFieldInfoPtr_localizedName;

	private static readonly IntPtr NativeFieldInfoPtr_localizedDescription;

	private static readonly IntPtr NativeFieldInfoPtr_effects;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SkillType_Public_get_SkillType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SkillCategory_Public_get_SkillCategory_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SkillIcon_Public_get_IconType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RawXpModifier_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ChopDamagePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MiningDamagePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_StaminaIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_StaminaDrainDecreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CritChanceIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_AccuracyIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ForagingBonusDropChanceBaseAmount_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ForagingBonusDropChanceIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ForagingBonusDropIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MedicalDurabilityIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_AntisepticPotencyIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CookingSpeedIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ButcheringIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FuelEfficiencyIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IgniteChanceIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FertilizerPotencyIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CropResilienceIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SurvivalistCraftSpeedIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_WoodworkingCraftSpeedIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MetalworkingCraftSpeedIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_LeatherworkingCraftSpeedIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SculptingCraftSpeedIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HerbalismCraftSpeedIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MeatHandlingCraftSpeedIncreasePerLevel_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLocalizedName_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLocalizedDescription_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddEffect_Public_Void_SkillEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Effects_Public_get_List_1_SkillEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Milestones_Public_get_List_1_ActiveSkillMilestone_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetXpRequiredForLevelUp_Public_Single_Int32_0;

	public unsafe SerializableStringField identifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifier);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringField));
		}
	}

	public unsafe SerializableEnumField<SkillType> skillType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillType);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableEnumField<SkillType>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableEnumField));
		}
	}

	public unsafe SerializableEnumField<SkillCategory> skillCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillCategory);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableEnumField<SkillCategory>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillCategory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableEnumField));
		}
	}

	public unsafe SerializableEnumField<IconType> skillIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillIcon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableEnumField<IconType>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableEnumField));
		}
	}

	public unsafe SerializablePrimitiveField<float> rawXpModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawXpModifier);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawXpModifier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> chopDamagePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chopDamagePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chopDamagePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> miningDamagePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miningDamagePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miningDamagePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> staminaIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> staminaDrainDecreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaDrainDecreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaDrainDecreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> critChanceIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_critChanceIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_critChanceIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> accuracyIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracyIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracyIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> foragingBonusDropChanceBaseAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foragingBonusDropChanceBaseAmount);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foragingBonusDropChanceBaseAmount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> foragingBonusDropChanceIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foragingBonusDropChanceIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foragingBonusDropChanceIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> foragingBonusDropIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foragingBonusDropIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foragingBonusDropIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> medicalDurabilityIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalDurabilityIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalDurabilityIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> antisepticPotencyIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antisepticPotencyIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antisepticPotencyIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> cookingSpeedIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingSpeedIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingSpeedIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> fuelEfficiencyIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelEfficiencyIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelEfficiencyIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> igniteChanceIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_igniteChanceIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_igniteChanceIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> fertilizerPotencyIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fertilizerPotencyIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fertilizerPotencyIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> cropResilienceIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cropResilienceIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cropResilienceIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> butcheringIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_butcheringIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_butcheringIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> survivalistCraftSpeedIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_survivalistCraftSpeedIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_survivalistCraftSpeedIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> woodworkingCraftSpeedIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_woodworkingCraftSpeedIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_woodworkingCraftSpeedIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> metalworkingCraftSpeedIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metalworkingCraftSpeedIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metalworkingCraftSpeedIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> leatherworkingCraftSpeedIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leatherworkingCraftSpeedIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leatherworkingCraftSpeedIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> sculptingCraftSpeedIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sculptingCraftSpeedIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sculptingCraftSpeedIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> herbalismCraftSpeedIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_herbalismCraftSpeedIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_herbalismCraftSpeedIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> meatHandlingCraftSpeedIncreasePerLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meatHandlingCraftSpeedIncreasePerLevel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meatHandlingCraftSpeedIncreasePerLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe ReadOnlySerializableDictionaryListField<ActiveSkillMilestone> milestones
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_milestones);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlySerializableDictionaryListField<ActiveSkillMilestone>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_milestones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlySerializableDictionaryListField));
		}
	}

	public unsafe string localizedName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string localizedDescription
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedDescription);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedDescription)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<SkillEffect> effects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<SkillEffect>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe override string Name
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string Description
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string Identifier
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233841, XrefRangeEnd = 233842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe SkillType SkillType
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233843, RefRangeEnd = 233845, XrefRangeStart = 233842, XrefRangeEnd = 233843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SkillType_Public_get_SkillType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(SkillType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe SkillCategory SkillCategory
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233846, RefRangeEnd = 233847, XrefRangeStart = 233845, XrefRangeEnd = 233846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SkillCategory_Public_get_SkillCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(SkillCategory*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe IconType SkillIcon
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233848, RefRangeEnd = 233849, XrefRangeStart = 233847, XrefRangeEnd = 233848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SkillIcon_Public_get_IconType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(IconType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float RawXpModifier
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233849, XrefRangeEnd = 233850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RawXpModifier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float ChopDamagePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233851, RefRangeEnd = 233854, XrefRangeStart = 233850, XrefRangeEnd = 233851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ChopDamagePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float MiningDamagePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233855, RefRangeEnd = 233858, XrefRangeStart = 233854, XrefRangeEnd = 233855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MiningDamagePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float StaminaIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233859, RefRangeEnd = 233862, XrefRangeStart = 233858, XrefRangeEnd = 233859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StaminaIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float StaminaDrainDecreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233863, RefRangeEnd = 233866, XrefRangeStart = 233862, XrefRangeEnd = 233863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StaminaDrainDecreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float CritChanceIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233867, RefRangeEnd = 233870, XrefRangeStart = 233866, XrefRangeEnd = 233867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CritChanceIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float AccuracyIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233871, RefRangeEnd = 233874, XrefRangeStart = 233870, XrefRangeEnd = 233871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AccuracyIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float ForagingBonusDropChanceBaseAmount
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233875, RefRangeEnd = 233877, XrefRangeStart = 233874, XrefRangeEnd = 233875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ForagingBonusDropChanceBaseAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float ForagingBonusDropChanceIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233878, RefRangeEnd = 233881, XrefRangeStart = 233877, XrefRangeEnd = 233878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ForagingBonusDropChanceIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float ForagingBonusDropIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233882, RefRangeEnd = 233885, XrefRangeStart = 233881, XrefRangeEnd = 233882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ForagingBonusDropIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float MedicalDurabilityIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233886, RefRangeEnd = 233889, XrefRangeStart = 233885, XrefRangeEnd = 233886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MedicalDurabilityIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float AntisepticPotencyIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233890, RefRangeEnd = 233893, XrefRangeStart = 233889, XrefRangeEnd = 233890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AntisepticPotencyIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float CookingSpeedIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233894, RefRangeEnd = 233897, XrefRangeStart = 233893, XrefRangeEnd = 233894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CookingSpeedIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float ButcheringIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233898, RefRangeEnd = 233901, XrefRangeStart = 233897, XrefRangeEnd = 233898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ButcheringIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float FuelEfficiencyIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233902, RefRangeEnd = 233905, XrefRangeStart = 233901, XrefRangeEnd = 233902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FuelEfficiencyIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float IgniteChanceIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233906, RefRangeEnd = 233909, XrefRangeStart = 233905, XrefRangeEnd = 233906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IgniteChanceIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float FertilizerPotencyIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233910, RefRangeEnd = 233913, XrefRangeStart = 233909, XrefRangeEnd = 233910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FertilizerPotencyIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float CropResilienceIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233914, RefRangeEnd = 233917, XrefRangeStart = 233913, XrefRangeEnd = 233914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CropResilienceIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float SurvivalistCraftSpeedIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233918, RefRangeEnd = 233921, XrefRangeStart = 233917, XrefRangeEnd = 233918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SurvivalistCraftSpeedIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float WoodworkingCraftSpeedIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233922, RefRangeEnd = 233925, XrefRangeStart = 233921, XrefRangeEnd = 233922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WoodworkingCraftSpeedIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float MetalworkingCraftSpeedIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233926, RefRangeEnd = 233929, XrefRangeStart = 233925, XrefRangeEnd = 233926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MetalworkingCraftSpeedIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float LeatherworkingCraftSpeedIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233930, RefRangeEnd = 233933, XrefRangeStart = 233929, XrefRangeEnd = 233930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LeatherworkingCraftSpeedIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float SculptingCraftSpeedIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233934, RefRangeEnd = 233937, XrefRangeStart = 233933, XrefRangeEnd = 233934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SculptingCraftSpeedIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float HerbalismCraftSpeedIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233938, RefRangeEnd = 233941, XrefRangeStart = 233937, XrefRangeEnd = 233938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HerbalismCraftSpeedIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float MeatHandlingCraftSpeedIncreasePerLevel
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 233942, RefRangeEnd = 233945, XrefRangeStart = 233941, XrefRangeEnd = 233942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MeatHandlingCraftSpeedIncreasePerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe List<SkillEffect> Effects
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Effects_Public_get_List_1_SkillEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<SkillEffect>>(intPtr) : null;
		}
	}

	public unsafe List<ActiveSkillMilestone> Milestones
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233971, RefRangeEnd = 233973, XrefRangeStart = 233970, XrefRangeEnd = 233971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Milestones_Public_get_List_1_ActiveSkillMilestone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ActiveSkillMilestone>>(intPtr) : null;
		}
	}

	static Skill()
	{
		Il2CppClassPointerStore<Skill>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "Skill");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skill>.NativeClassPtr);
		NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "identifier");
		NativeFieldInfoPtr_skillType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "skillType");
		NativeFieldInfoPtr_skillCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "skillCategory");
		NativeFieldInfoPtr_skillIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "skillIcon");
		NativeFieldInfoPtr_rawXpModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "rawXpModifier");
		NativeFieldInfoPtr_chopDamagePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "chopDamagePerLevel");
		NativeFieldInfoPtr_miningDamagePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "miningDamagePerLevel");
		NativeFieldInfoPtr_staminaIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "staminaIncreasePerLevel");
		NativeFieldInfoPtr_staminaDrainDecreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "staminaDrainDecreasePerLevel");
		NativeFieldInfoPtr_critChanceIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "critChanceIncreasePerLevel");
		NativeFieldInfoPtr_accuracyIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "accuracyIncreasePerLevel");
		NativeFieldInfoPtr_foragingBonusDropChanceBaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "foragingBonusDropChanceBaseAmount");
		NativeFieldInfoPtr_foragingBonusDropChanceIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "foragingBonusDropChanceIncreasePerLevel");
		NativeFieldInfoPtr_foragingBonusDropIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "foragingBonusDropIncreasePerLevel");
		NativeFieldInfoPtr_medicalDurabilityIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "medicalDurabilityIncreasePerLevel");
		NativeFieldInfoPtr_antisepticPotencyIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "antisepticPotencyIncreasePerLevel");
		NativeFieldInfoPtr_cookingSpeedIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "cookingSpeedIncreasePerLevel");
		NativeFieldInfoPtr_fuelEfficiencyIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "fuelEfficiencyIncreasePerLevel");
		NativeFieldInfoPtr_igniteChanceIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "igniteChanceIncreasePerLevel");
		NativeFieldInfoPtr_fertilizerPotencyIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "fertilizerPotencyIncreasePerLevel");
		NativeFieldInfoPtr_cropResilienceIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "cropResilienceIncreasePerLevel");
		NativeFieldInfoPtr_butcheringIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "butcheringIncreasePerLevel");
		NativeFieldInfoPtr_survivalistCraftSpeedIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "survivalistCraftSpeedIncreasePerLevel");
		NativeFieldInfoPtr_woodworkingCraftSpeedIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "woodworkingCraftSpeedIncreasePerLevel");
		NativeFieldInfoPtr_metalworkingCraftSpeedIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "metalworkingCraftSpeedIncreasePerLevel");
		NativeFieldInfoPtr_leatherworkingCraftSpeedIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "leatherworkingCraftSpeedIncreasePerLevel");
		NativeFieldInfoPtr_sculptingCraftSpeedIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "sculptingCraftSpeedIncreasePerLevel");
		NativeFieldInfoPtr_herbalismCraftSpeedIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "herbalismCraftSpeedIncreasePerLevel");
		NativeFieldInfoPtr_meatHandlingCraftSpeedIncreasePerLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "meatHandlingCraftSpeedIncreasePerLevel");
		NativeFieldInfoPtr_milestones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "milestones");
		NativeFieldInfoPtr_localizedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "localizedName");
		NativeFieldInfoPtr_localizedDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "localizedDescription");
		NativeFieldInfoPtr_effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "effects");
		NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679658);
		NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679659);
		NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679660);
		NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679661);
		NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679662);
		NativeMethodInfoPtr_get_SkillType_Public_get_SkillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679663);
		NativeMethodInfoPtr_get_SkillCategory_Public_get_SkillCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679664);
		NativeMethodInfoPtr_get_SkillIcon_Public_get_IconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679665);
		NativeMethodInfoPtr_get_RawXpModifier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679666);
		NativeMethodInfoPtr_get_ChopDamagePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679667);
		NativeMethodInfoPtr_get_MiningDamagePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679668);
		NativeMethodInfoPtr_get_StaminaIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679669);
		NativeMethodInfoPtr_get_StaminaDrainDecreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679670);
		NativeMethodInfoPtr_get_CritChanceIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679671);
		NativeMethodInfoPtr_get_AccuracyIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679672);
		NativeMethodInfoPtr_get_ForagingBonusDropChanceBaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679673);
		NativeMethodInfoPtr_get_ForagingBonusDropChanceIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679674);
		NativeMethodInfoPtr_get_ForagingBonusDropIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679675);
		NativeMethodInfoPtr_get_MedicalDurabilityIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679676);
		NativeMethodInfoPtr_get_AntisepticPotencyIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679677);
		NativeMethodInfoPtr_get_CookingSpeedIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679678);
		NativeMethodInfoPtr_get_ButcheringIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679679);
		NativeMethodInfoPtr_get_FuelEfficiencyIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679680);
		NativeMethodInfoPtr_get_IgniteChanceIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679681);
		NativeMethodInfoPtr_get_FertilizerPotencyIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679682);
		NativeMethodInfoPtr_get_CropResilienceIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679683);
		NativeMethodInfoPtr_get_SurvivalistCraftSpeedIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679684);
		NativeMethodInfoPtr_get_WoodworkingCraftSpeedIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679685);
		NativeMethodInfoPtr_get_MetalworkingCraftSpeedIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679686);
		NativeMethodInfoPtr_get_LeatherworkingCraftSpeedIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679687);
		NativeMethodInfoPtr_get_SculptingCraftSpeedIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679688);
		NativeMethodInfoPtr_get_HerbalismCraftSpeedIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679689);
		NativeMethodInfoPtr_get_MeatHandlingCraftSpeedIncreasePerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679690);
		NativeMethodInfoPtr_SetLocalizedName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679691);
		NativeMethodInfoPtr_SetLocalizedDescription_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679692);
		NativeMethodInfoPtr_AddEffect_Public_Void_SkillEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679693);
		NativeMethodInfoPtr_get_Effects_Public_get_List_1_SkillEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679694);
		NativeMethodInfoPtr_get_Milestones_Public_get_List_1_ActiveSkillMilestone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679695);
		NativeMethodInfoPtr_GetXpRequiredForLevelUp_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100679696);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233714, RefRangeEnd = 233715, XrefRangeStart = 233705, XrefRangeEnd = 233714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Skill(ModelDefinition definition)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skill>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)definition);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233715, XrefRangeEnd = 233841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeSerializableFields(SerializationContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalizedName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalizedName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalizedDescription(string description)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalizedDescription_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 233947, RefRangeEnd = 233970, XrefRangeStart = 233945, XrefRangeEnd = 233947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddEffect(SkillEffect effect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)effect));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEffect_Public_Void_SkillEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233980, RefRangeEnd = 233981, XrefRangeStart = 233973, XrefRangeEnd = 233980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetXpRequiredForLevelUp(int level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&level);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetXpRequiredForLevelUp_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Skill(IntPtr pointer)
		: base(pointer)
	{
	}
}

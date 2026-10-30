using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class StatusEffect : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_duration;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusEffectDefinition;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusEffectDefinitionIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemId;

	private static readonly System.IntPtr NativeFieldInfoPtr_substanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitpointsRecoveryRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirstReplenishmentRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_hungerReplenishmentRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_energyReplenishmentRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxStaminaReductionAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseHungerThirstIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_staminaRecoveryRateChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_staminaExertionRateChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementSpeedChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseSusceptibilityAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_mosquitoRepellentAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionSpeedChange;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Timed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	public unsafe float duration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration)) = num;
		}
	}

	public unsafe StatusEffectDefinition statusEffectDefinition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectDefinition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusEffectDefinition>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectDefinition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusEffectDefinition));
		}
	}

	public unsafe string statusEffectDefinitionIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectDefinitionIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectDefinitionIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe StatusEffectType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(StatusEffectType*)num;
		}
		set
		{
			*(StatusEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = statusEffectType;
		}
	}

	public unsafe int itemId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemId)) = num;
		}
	}

	public unsafe int substanceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_substanceId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_substanceId)) = num;
		}
	}

	public unsafe float hitpointsRecoveryRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitpointsRecoveryRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitpointsRecoveryRate)) = num;
		}
	}

	public unsafe float thirstReplenishmentRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirstReplenishmentRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirstReplenishmentRate)) = num;
		}
	}

	public unsafe float hungerReplenishmentRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hungerReplenishmentRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hungerReplenishmentRate)) = num;
		}
	}

	public unsafe float energyReplenishmentRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyReplenishmentRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyReplenishmentRate)) = num;
		}
	}

	public unsafe float diseaseRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseRate)) = num;
		}
	}

	public unsafe float maxStaminaReductionAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStaminaReductionAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStaminaReductionAmount)) = num;
		}
	}

	public unsafe float diseaseHungerThirstIncreaseAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseHungerThirstIncreaseAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseHungerThirstIncreaseAmount)) = num;
		}
	}

	public unsafe float staminaRecoveryRateChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaRecoveryRateChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaRecoveryRateChange)) = num;
		}
	}

	public unsafe float staminaExertionRateChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaExertionRateChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaExertionRateChange)) = num;
		}
	}

	public unsafe float movementSpeedChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeedChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeedChange)) = num;
		}
	}

	public unsafe float diseaseSusceptibilityAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseSusceptibilityAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseSusceptibilityAmount)) = num;
		}
	}

	public unsafe float mosquitoRepellentAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mosquitoRepellentAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mosquitoRepellentAmount)) = num;
		}
	}

	public unsafe float actionSpeedChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSpeedChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSpeedChange)) = num;
		}
	}

	public unsafe bool Timed
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234157, RefRangeEnd = 234159, XrefRangeStart = 234157, XrefRangeEnd = 234157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Timed_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static StatusEffect()
	{
		Il2CppClassPointerStore<StatusEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StatusEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr);
		NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "duration");
		NativeFieldInfoPtr_statusEffectDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "statusEffectDefinition");
		NativeFieldInfoPtr_statusEffectDefinitionIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "statusEffectDefinitionIdentifier");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "type");
		NativeFieldInfoPtr_itemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "itemId");
		NativeFieldInfoPtr_substanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "substanceId");
		NativeFieldInfoPtr_hitpointsRecoveryRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "hitpointsRecoveryRate");
		NativeFieldInfoPtr_thirstReplenishmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "thirstReplenishmentRate");
		NativeFieldInfoPtr_hungerReplenishmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "hungerReplenishmentRate");
		NativeFieldInfoPtr_energyReplenishmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "energyReplenishmentRate");
		NativeFieldInfoPtr_diseaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "diseaseRate");
		NativeFieldInfoPtr_maxStaminaReductionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "maxStaminaReductionAmount");
		NativeFieldInfoPtr_diseaseHungerThirstIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "diseaseHungerThirstIncreaseAmount");
		NativeFieldInfoPtr_staminaRecoveryRateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "staminaRecoveryRateChange");
		NativeFieldInfoPtr_staminaExertionRateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "staminaExertionRateChange");
		NativeFieldInfoPtr_movementSpeedChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "movementSpeedChange");
		NativeFieldInfoPtr_diseaseSusceptibilityAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "diseaseSusceptibilityAmount");
		NativeFieldInfoPtr_mosquitoRepellentAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "mosquitoRepellentAmount");
		NativeFieldInfoPtr_actionSpeedChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, "actionSpeedChange");
		NativeMethodInfoPtr_get_Timed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, 100679773);
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr, 100679774);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234159, XrefRangeEnd = 234311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StatusEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public StatusEffect()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusEffect>.NativeClassPtr))
	{
	}
}

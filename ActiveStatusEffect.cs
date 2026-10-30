using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Netcode;

[System.Serializable]
public class ActiveStatusEffect : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_itemId;

	private static readonly System.IntPtr NativeFieldInfoPtr_substanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusEffectDefinitionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusEffectDefinition;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusEffectType;

	private static readonly System.IntPtr NativeFieldInfoPtr_rate;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_elapsedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_duration;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeInjuryIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastProcessedFrame;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFrom_Public_Static_ActiveStatusEffect_StatusEffect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Rate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RemainingTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_Boolean_StatusEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMatchingRate_Public_Single_StatusEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTitle_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe int statusEffectDefinitionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectDefinitionId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectDefinitionId)) = num;
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

	public unsafe StatusEffectType statusEffectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectType);
			return *(StatusEffectType*)num;
		}
		set
		{
			*(StatusEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectType)) = statusEffectType;
		}
	}

	public unsafe float rate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rate)) = num;
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

	public unsafe float elapsedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elapsedTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elapsedTime)) = num;
		}
	}

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

	public unsafe List<int> activeInjuryIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInjuryIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInjuryIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float lastProcessedFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastProcessedFrame);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastProcessedFrame)) = num;
		}
	}

	public unsafe float Rate
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234058, RefRangeEnd = 234060, XrefRangeStart = 234058, XrefRangeEnd = 234058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Rate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float RemainingTime
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234060, RefRangeEnd = 234062, XrefRangeStart = 234060, XrefRangeEnd = 234060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RemainingTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ActiveStatusEffect()
	{
		Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ActiveStatusEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr);
		NativeFieldInfoPtr_itemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "itemId");
		NativeFieldInfoPtr_substanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "substanceId");
		NativeFieldInfoPtr_statusEffectDefinitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "statusEffectDefinitionId");
		NativeFieldInfoPtr_statusEffectDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "statusEffectDefinition");
		NativeFieldInfoPtr_statusEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "statusEffectType");
		NativeFieldInfoPtr_rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "rate");
		NativeFieldInfoPtr_hitpointsRecoveryRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "hitpointsRecoveryRate");
		NativeFieldInfoPtr_thirstReplenishmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "thirstReplenishmentRate");
		NativeFieldInfoPtr_hungerReplenishmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "hungerReplenishmentRate");
		NativeFieldInfoPtr_energyReplenishmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "energyReplenishmentRate");
		NativeFieldInfoPtr_diseaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "diseaseRate");
		NativeFieldInfoPtr_maxStaminaReductionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "maxStaminaReductionAmount");
		NativeFieldInfoPtr_diseaseHungerThirstIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "diseaseHungerThirstIncreaseAmount");
		NativeFieldInfoPtr_staminaRecoveryRateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "staminaRecoveryRateChange");
		NativeFieldInfoPtr_staminaExertionRateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "staminaExertionRateChange");
		NativeFieldInfoPtr_movementSpeedChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "movementSpeedChange");
		NativeFieldInfoPtr_diseaseSusceptibilityAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "diseaseSusceptibilityAmount");
		NativeFieldInfoPtr_mosquitoRepellentAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "mosquitoRepellentAmount");
		NativeFieldInfoPtr_actionSpeedChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "actionSpeedChange");
		NativeFieldInfoPtr_elapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "elapsedTime");
		NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "duration");
		NativeFieldInfoPtr_activeInjuryIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "activeInjuryIds");
		NativeFieldInfoPtr_lastProcessedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, "lastProcessedFrame");
		NativeMethodInfoPtr_CreateFrom_Public_Static_ActiveStatusEffect_StatusEffect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679761);
		NativeMethodInfoPtr_Process_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679762);
		NativeMethodInfoPtr_get_Rate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679763);
		NativeMethodInfoPtr_get_RemainingTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679764);
		NativeMethodInfoPtr_Matches_Public_Boolean_StatusEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679765);
		NativeMethodInfoPtr_GetMatchingRate_Public_Single_StatusEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679766);
		NativeMethodInfoPtr_GetTitle_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679767);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679768);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679769);
		NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679770);
		NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679771);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr, 100679772);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234056, RefRangeEnd = 234057, XrefRangeStart = 234044, XrefRangeEnd = 234056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ActiveStatusEffect CreateFrom(StatusEffect statusEffect, int activeInjuryId = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)statusEffect));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &activeInjuryId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFrom_Public_Static_ActiveStatusEffect_StatusEffect_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActiveStatusEffect>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234057, RefRangeEnd = 234058, XrefRangeStart = 234057, XrefRangeEnd = 234057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Process(float deltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deltaTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234062, RefRangeEnd = 234063, XrefRangeStart = 234062, XrefRangeEnd = 234062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Matches(StatusEffect statusEffect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)statusEffect));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Matches_Public_Boolean_StatusEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetMatchingRate(StatusEffect statusEffect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)statusEffect));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMatchingRate_Public_Single_StatusEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 234134, RefRangeEnd = 234138, XrefRangeStart = 234063, XrefRangeEnd = 234134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTitle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTitle_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234138, XrefRangeEnd = 234139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234139, XrefRangeEnd = 234157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActiveStatusEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveStatusEffect>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActiveStatusEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

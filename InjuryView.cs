using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class InjuryView : BaseView
{
	[System.Serializable]
	[ObfuscatedName("InjuryView+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__69_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__69_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__handleInjuries_b__69_0_Internal_Boolean_ActiveInjury_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__handleInjuries_b__69_1_Internal_Boolean_ActiveInjury_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Predicate<ActiveInjury> __9__69_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__69_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ActiveInjury>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__69_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<ActiveInjury> __9__69_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__69_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ActiveInjury>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__69_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__69_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__69_0");
			NativeFieldInfoPtr___9__69_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__69_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100681055);
			NativeMethodInfoPtr__handleInjuries_b__69_0_Internal_Boolean_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100681056);
			NativeMethodInfoPtr__handleInjuries_b__69_1_Internal_Boolean_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100681057);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _handleInjuries_b__69_0(ActiveInjury item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__handleInjuries_b__69_0_Internal_Boolean_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _handleInjuries_b__69_1(ActiveInjury item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__handleInjuries_b__69_1_Internal_Boolean_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MIN_COMBINED_INFECTION_PERCENTAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONCUSSION_HARMFUL_DURABILITY_PERCENTAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_entityMovement;

	private static readonly System.IntPtr NativeFieldInfoPtr_sleeper;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiControlled;

	private static readonly System.IntPtr NativeFieldInfoPtr_warmth;

	private static readonly System.IntPtr NativeFieldInfoPtr_energy;

	private static readonly System.IntPtr NativeFieldInfoPtr_skills;

	private static readonly System.IntPtr NativeFieldInfoPtr_showMessageEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionGameEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_createDecalEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_gainExperienceEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeInjuries;

	private static readonly System.IntPtr NativeFieldInfoPtr_treatInjuriesAutomatically;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextInjuryId;

	private static readonly System.IntPtr NativeFieldInfoPtr_injurableLocations;

	private static readonly System.IntPtr NativeFieldInfoPtr_numSlots;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryIdentifierWhitelist;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryApplicationDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_locationInfectionPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryIdStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_fractureInteractions;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryLocationToCategoryMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryLocationToActiveInjuriesMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryLocationToInfectedPercentageMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryStateChangedListeners;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryRemovedListeners;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryAddedListeners;

	private static readonly System.IntPtr NativeFieldInfoPtr_oneUseInjuryAddedListeners;

	private static readonly System.IntPtr NativeFieldInfoPtr_cleanlinessChangedListeners;

	private static readonly System.IntPtr NativeFieldInfoPtr_infectionStatusDefinition;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasUntreatedInjury;

	private static readonly System.IntPtr NativeFieldInfoPtr_treatmentInventorySection;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_healingState;

	private static readonly System.IntPtr NativeFieldInfoPtr_tryDirtyInjuriesTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaledDeltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_sleeping;

	private static readonly System.IntPtr NativeFieldInfoPtr_bleedEffectAcc;

	private static readonly System.IntPtr NativeFieldInfoPtr_bleedIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_numInjuriesAppliedThisFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastXpEventTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_accumulatedMedicineXp;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEvents_Public_Virtual_Void_IGameEventManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activated_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deactivated_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initializeActiveInjury_Private_ActiveInjury_Injury_InjuryLocation_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyInjury_Public_Virtual_Final_New_Boolean_Injury_InjuryLocation_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInjury_Public_Virtual_Final_New_Void_String_InjuryLocation_InventorySlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleSpecialInjuryRemovalEffects_Private_Void_ActiveInjury_InjuryCategoryInformation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleHealInteractionComplete_Public_Virtual_Final_New_Void_String_InjuryLocation_Single_Int32_List_1_InventoryItemStack_HealInjuryInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_treatInjury_Private_Void_String_InjuryLocation_List_1_InventoryItemStack_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_treatInjury_Private_Void_String_InjuryLocation_HealInjuryInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_assignTreatmentInfo_Private_Void_ActiveInjury_List_1_InventoryItemStack_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_assignTreatmentInfo_Private_Void_ActiveInjury_HealInjuryInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_untreatInjury_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyOnReceiveStatusEffects_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyTreatedStatusEffects_Protected_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeTreatedStatusEffects_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyIndefiniteStatusEffects_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeIndefiniteStatusEffects_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyInjuryStatusEffect_Private_Void_StatusEffect_ActiveInjury_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleInjuries_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleInjury_Private_Void_ActiveInjury_InventorySlot_List_1_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleAnimalInjury_Private_Void_ActiveInjury_List_1_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleTreatment_Private_Boolean_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleInfectionStatus_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleBleedEffect_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyExternalTreatmentRates_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_keepInjuryDurabilityClamped_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInjuryMaxDurability_Private_Int32_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_Private_Void_ActiveInjury_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_Private_ActiveInjury_String_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_find_Private_ActiveInjury_String_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasInjury_Public_Virtual_Final_New_Boolean_String_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidLocation_Public_Virtual_Final_New_Boolean_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInjuryCategoryInformation_Private_InjuryCategoryInformation_Injury_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllowedThroughWhitelist_Public_Virtual_Final_New_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBodyLocationsInCategory_Public_Virtual_Final_New_List_1_InjuryLocation_InjuryCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getLocationCategory_Private_InjuryCategory_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInjuriesByLocation_Public_Virtual_Final_New_Boolean_InjuryLocation_byref_List_1_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInjuries_Public_Virtual_Final_New_List_1_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConcussionRadialBlurIntensity_Public_Virtual_Final_New_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConcussionKnockoutActive_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isInjuryRemovedInstantlyWhenTreated_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInjurableLocations_Public_Virtual_Final_New_List_1_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHealingState_Public_Virtual_Final_New_Void_String_InjuryLocation_IInteraction_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetHealingState_Public_Virtual_Final_New_Void_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setInteractInjury_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setActiveInteraction_Private_Void_IInteraction_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHealingState_Public_Virtual_Final_New_HealingState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumInjuriesAppliedThisFrame_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInjuryIdentifierWhitelist_Public_Virtual_Final_New_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanApplyInjuries_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCanApplyInjuries_Public_Virtual_Final_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasInjuryWhitelist_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInjuryWhitelist_Public_Virtual_Final_New_Void_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearInjuryWhitelist_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleInjuryCleanliness_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_randomlyDirtyInjuries_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyBodilyInfectionFromDirtiedInjury_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCombinedInfectionPercentage_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasUntreatedInjury_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInfectionPercentageByLocation_Public_Virtual_Final_New_Single_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddInfectionPercentageByLocation_Public_Virtual_Final_New_Void_Single_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInfectionPercentageByLocation_Public_Virtual_Final_New_Void_Single_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInfectionStatusDefinition_Public_Void_StatusEffectDefinition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInfectedLocations_Public_Virtual_Final_New_List_1_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInjuryCleanlinessState_Public_Virtual_Final_New_InjuryCleanliness_String_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInjuryCleanlinessState_Public_Virtual_Final_New_Void_String_InjuryLocation_InjuryCleanliness_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInjuryDirty_Public_Virtual_Final_New_Boolean_String_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFilthLevel_Public_Virtual_Final_New_Single_String_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSanitationLevel_Public_Virtual_Final_New_Single_String_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCleanliness_Public_Virtual_Final_New_Boolean_String_InjuryLocation_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInjuryDamageEffects_Public_Virtual_Final_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DamageMedicalItems_Public_Virtual_Final_New_Void_ActiveInjury_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncreaseInjuryDurabilityOnDamage_Public_Virtual_Final_New_Void_ActiveInjury_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartCauterization_Public_Virtual_Final_New_Void_String_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndCauterization_Public_Virtual_Final_New_Void_String_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setInjuryTreatmentRate_Private_Void_String_InjuryLocation_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInjury_Public_Virtual_Final_New_ActiveInjury_String_InjuryLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetActiveInjury_Public_Boolean_String_InjuryLocation_byref_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInjuryMap_Public_Void_Dictionary_2_String_Injury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInjuryLocationToCategoryMap_Public_Void_Dictionary_2_InjuryLocation_InjuryCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initializeBodyPartInjuryDict_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onActiveInjuriesUpdated_Private_Void_List_1_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initializeInfectionDict_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initializeNonSerializedFields_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initializeNonSerializedFields_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reconstructInjuryIdStack_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyUpdate_Private_Void_ActiveInjury_byref_NetworkActiveInjuryUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUpdateListenerActive_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleUpdate_Public_Virtual_Final_New_Void_byref_NetworkActiveInjuryUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddInjuryAddedListener_Public_Virtual_Final_New_Void_InjuryListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOneUseInjuryAddedListener_Public_Virtual_Final_New_Void_InjuryListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInjuryAddedListener_Public_Virtual_Final_New_Void_InjuryListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddInjuryRemovedListener_Public_Virtual_Final_New_Void_InjuryListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInjuryRemovedListener_Public_Virtual_Final_New_Void_InjuryListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddInjuryStateChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInjuryStateChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCleanlinessChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCleanlinessChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_dispatchInjuryAddedEvent_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_dispatchInjuryRemovedEvent_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_dispatchInjuryStateChangedEvent_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_dispatchCleanlinessChangedEvent_Private_Void_ActiveInjury_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_dispatchUpdateListeners_Private_Void_ActiveInjury_ICollection_1_InjuryListener_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float MIN_COMBINED_INFECTION_PERCENTAGE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_COMBINED_INFECTION_PERCENTAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_COMBINED_INFECTION_PERCENTAGE, (void*)(&num));
		}
	}

	public unsafe static float CONCUSSION_HARMFUL_DURABILITY_PERCENTAGE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONCUSSION_HARMFUL_DURABILITY_PERCENTAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONCUSSION_HARMFUL_DURABILITY_PERCENTAGE, (void*)(&num));
		}
	}

	public unsafe IStatusEffects statusEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IStatusEffects>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusEffects));
		}
	}

	public unsafe IInteractor interactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteractor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactor));
		}
	}

	public unsafe IEntityMovement entityMovement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityMovement);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEntityMovement>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityMovement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityMovement));
		}
	}

	public unsafe ISleeper sleeper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleeper);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISleeper>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleeper)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sleeper));
		}
	}

	public unsafe IAIControlled aiControlled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiControlled);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAIControlled>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiControlled)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iAIControlled));
		}
	}

	public unsafe IWarmth warmth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warmth);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWarmth>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warmth)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)warmth));
		}
	}

	public unsafe IEnergy energy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnergy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)energy));
		}
	}

	public unsafe ISkills skills
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skills);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISkills>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skills)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skills));
		}
	}

	public unsafe ShowMessageEvent showMessageEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMessageEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowMessageEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMessageEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showMessageEvent));
		}
	}

	public unsafe InteractionGameEvent interactionGameEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionGameEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractionGameEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionGameEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionGameEvent));
		}
	}

	public unsafe CreateDecalEvent createDecalEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createDecalEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CreateDecalEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createDecalEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createDecalEvent));
		}
	}

	public unsafe GainExperienceEvent gainExperienceEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gainExperienceEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GainExperienceEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gainExperienceEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gainExperienceEvent));
		}
	}

	public unsafe SerializableClassListField<ActiveInjury> activeInjuries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInjuries);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableClassListField<ActiveInjury>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInjuries)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableClassListField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> treatInjuriesAutomatically
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatInjuriesAutomatically);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatInjuriesAutomatically)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<int> nextInjuryId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextInjuryId);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextInjuryId)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializableEnumListField<InjuryLocation> injurableLocations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injurableLocations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableEnumListField<InjuryLocation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injurableLocations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableEnumListField));
		}
	}

	public unsafe SerializablePrimitiveField<int> numSlots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSlots);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSlots)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializableStringListField injuryIdentifierWhitelist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryIdentifierWhitelist);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringListField>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryIdentifierWhitelist)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringListField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> injuryApplicationDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryApplicationDisabled);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryApplicationDisabled)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializableClassListField<BodyLocationInfo> locationInfectionPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationInfectionPercentage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableClassListField<BodyLocationInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationInfectionPercentage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableClassListField));
		}
	}

	public unsafe Stack<int> injuryIdStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryIdStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryIdStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack));
		}
	}

	public unsafe ICollection<InteractionType> fractureInteractions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fractureInteractions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<InteractionType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fractureInteractions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collection));
		}
	}

	public unsafe Dictionary<string, Injury> injuryMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Injury>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InjuryLocation, InjuryCategory> injuryLocationToCategoryMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryLocationToCategoryMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InjuryLocation, InjuryCategory>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryLocationToCategoryMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InjuryLocation, List<ActiveInjury>> injuryLocationToActiveInjuriesMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryLocationToActiveInjuriesMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InjuryLocation, List<ActiveInjury>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryLocationToActiveInjuriesMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InjuryLocation, BodyLocationInfo> injuryLocationToInfectedPercentageMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryLocationToInfectedPercentageMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InjuryLocation, BodyLocationInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryLocationToInfectedPercentageMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<InjuryListener> injuryStateChangedListeners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryStateChangedListeners);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InjuryListener>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryStateChangedListeners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<InjuryListener> injuryRemovedListeners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryRemovedListeners);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InjuryListener>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryRemovedListeners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<InjuryListener> injuryAddedListeners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryAddedListeners);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InjuryListener>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryAddedListeners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<InjuryListener> oneUseInjuryAddedListeners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneUseInjuryAddedListeners);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InjuryListener>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oneUseInjuryAddedListeners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<InjuryListener> cleanlinessChangedListeners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanlinessChangedListeners);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InjuryListener>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanlinessChangedListeners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe StatusEffectDefinition infectionStatusDefinition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infectionStatusDefinition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusEffectDefinition>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infectionStatusDefinition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusEffectDefinition));
		}
	}

	public unsafe bool hasUntreatedInjury
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasUntreatedInjury);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasUntreatedInjury)) = flag;
		}
	}

	public unsafe InjuryTreatmentInventorySection treatmentInventorySection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatmentInventorySection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InjuryTreatmentInventorySection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatmentInventorySection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuryTreatmentInventorySection));
		}
	}

	public unsafe Inventory inventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Inventory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory));
		}
	}

	public unsafe HealingState healingState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_healingState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HealingState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_healingState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)healingState));
		}
	}

	public unsafe float tryDirtyInjuriesTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tryDirtyInjuriesTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tryDirtyInjuriesTimer)) = num;
		}
	}

	public unsafe float scaledDeltaTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaledDeltaTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaledDeltaTime)) = num;
		}
	}

	public unsafe bool sleeping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleeping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleeping)) = flag;
		}
	}

	public unsafe float bleedEffectAcc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleedEffectAcc);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleedEffectAcc)) = num;
		}
	}

	public unsafe float bleedIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleedIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleedIntensity)) = num;
		}
	}

	public unsafe int numInjuriesAppliedThisFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numInjuriesAppliedThisFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numInjuriesAppliedThisFrame)) = num;
		}
	}

	public unsafe float lastXpEventTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastXpEventTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastXpEventTime)) = num;
		}
	}

	public unsafe float accumulatedMedicineXp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accumulatedMedicineXp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accumulatedMedicineXp)) = num;
		}
	}

	static InjuryView()
	{
		Il2CppClassPointerStore<InjuryView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InjuryView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjuryView>.NativeClassPtr);
		NativeFieldInfoPtr_MIN_COMBINED_INFECTION_PERCENTAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "MIN_COMBINED_INFECTION_PERCENTAGE");
		NativeFieldInfoPtr_CONCUSSION_HARMFUL_DURABILITY_PERCENTAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "CONCUSSION_HARMFUL_DURABILITY_PERCENTAGE");
		NativeFieldInfoPtr_statusEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "statusEffects");
		NativeFieldInfoPtr_interactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "interactor");
		NativeFieldInfoPtr_entityMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "entityMovement");
		NativeFieldInfoPtr_sleeper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "sleeper");
		NativeFieldInfoPtr_aiControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "aiControlled");
		NativeFieldInfoPtr_warmth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "warmth");
		NativeFieldInfoPtr_energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "energy");
		NativeFieldInfoPtr_skills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "skills");
		NativeFieldInfoPtr_showMessageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "showMessageEvent");
		NativeFieldInfoPtr_interactionGameEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "interactionGameEvent");
		NativeFieldInfoPtr_createDecalEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "createDecalEvent");
		NativeFieldInfoPtr_gainExperienceEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "gainExperienceEvent");
		NativeFieldInfoPtr_activeInjuries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "activeInjuries");
		NativeFieldInfoPtr_treatInjuriesAutomatically = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "treatInjuriesAutomatically");
		NativeFieldInfoPtr_nextInjuryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "nextInjuryId");
		NativeFieldInfoPtr_injurableLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injurableLocations");
		NativeFieldInfoPtr_numSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "numSlots");
		NativeFieldInfoPtr_injuryIdentifierWhitelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injuryIdentifierWhitelist");
		NativeFieldInfoPtr_injuryApplicationDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injuryApplicationDisabled");
		NativeFieldInfoPtr_locationInfectionPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "locationInfectionPercentage");
		NativeFieldInfoPtr_injuryIdStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injuryIdStack");
		NativeFieldInfoPtr_fractureInteractions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "fractureInteractions");
		NativeFieldInfoPtr_injuryMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injuryMap");
		NativeFieldInfoPtr_injuryLocationToCategoryMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injuryLocationToCategoryMap");
		NativeFieldInfoPtr_injuryLocationToActiveInjuriesMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injuryLocationToActiveInjuriesMap");
		NativeFieldInfoPtr_injuryLocationToInfectedPercentageMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injuryLocationToInfectedPercentageMap");
		NativeFieldInfoPtr_injuryStateChangedListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injuryStateChangedListeners");
		NativeFieldInfoPtr_injuryRemovedListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injuryRemovedListeners");
		NativeFieldInfoPtr_injuryAddedListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "injuryAddedListeners");
		NativeFieldInfoPtr_oneUseInjuryAddedListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "oneUseInjuryAddedListeners");
		NativeFieldInfoPtr_cleanlinessChangedListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "cleanlinessChangedListeners");
		NativeFieldInfoPtr_infectionStatusDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "infectionStatusDefinition");
		NativeFieldInfoPtr_hasUntreatedInjury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "hasUntreatedInjury");
		NativeFieldInfoPtr_treatmentInventorySection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "treatmentInventorySection");
		NativeFieldInfoPtr_inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "inventory");
		NativeFieldInfoPtr_healingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "healingState");
		NativeFieldInfoPtr_tryDirtyInjuriesTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "tryDirtyInjuriesTimer");
		NativeFieldInfoPtr_scaledDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "scaledDeltaTime");
		NativeFieldInfoPtr_sleeping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "sleeping");
		NativeFieldInfoPtr_bleedEffectAcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "bleedEffectAcc");
		NativeFieldInfoPtr_bleedIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "bleedIntensity");
		NativeFieldInfoPtr_numInjuriesAppliedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "numInjuriesAppliedThisFrame");
		NativeFieldInfoPtr_lastXpEventTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "lastXpEventTime");
		NativeFieldInfoPtr_accumulatedMedicineXp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, "accumulatedMedicineXp");
		NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680945);
		NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680946);
		NativeMethodInfoPtr_SetEvents_Public_Virtual_Void_IGameEventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680947);
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680948);
		NativeMethodInfoPtr_Activated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680949);
		NativeMethodInfoPtr_Deactivated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680950);
		NativeMethodInfoPtr_initializeActiveInjury_Private_ActiveInjury_Injury_InjuryLocation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680951);
		NativeMethodInfoPtr_ApplyInjury_Public_Virtual_Final_New_Boolean_Injury_InjuryLocation_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680952);
		NativeMethodInfoPtr_RemoveInjury_Public_Virtual_Final_New_Void_String_InjuryLocation_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680953);
		NativeMethodInfoPtr_handleSpecialInjuryRemovalEffects_Private_Void_ActiveInjury_InjuryCategoryInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680954);
		NativeMethodInfoPtr_HandleHealInteractionComplete_Public_Virtual_Final_New_Void_String_InjuryLocation_Single_Int32_List_1_InventoryItemStack_HealInjuryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680955);
		NativeMethodInfoPtr_treatInjury_Private_Void_String_InjuryLocation_List_1_InventoryItemStack_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680956);
		NativeMethodInfoPtr_treatInjury_Private_Void_String_InjuryLocation_HealInjuryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680957);
		NativeMethodInfoPtr_assignTreatmentInfo_Private_Void_ActiveInjury_List_1_InventoryItemStack_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680958);
		NativeMethodInfoPtr_assignTreatmentInfo_Private_Void_ActiveInjury_HealInjuryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680959);
		NativeMethodInfoPtr_untreatInjury_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680960);
		NativeMethodInfoPtr_applyOnReceiveStatusEffects_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680961);
		NativeMethodInfoPtr_applyTreatedStatusEffects_Protected_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680962);
		NativeMethodInfoPtr_removeTreatedStatusEffects_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680963);
		NativeMethodInfoPtr_applyIndefiniteStatusEffects_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680964);
		NativeMethodInfoPtr_removeIndefiniteStatusEffects_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680965);
		NativeMethodInfoPtr_applyInjuryStatusEffect_Private_Void_StatusEffect_ActiveInjury_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680966);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680967);
		NativeMethodInfoPtr_handleInjuries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680968);
		NativeMethodInfoPtr_handleInjury_Private_Void_ActiveInjury_InventorySlot_List_1_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680969);
		NativeMethodInfoPtr_handleAnimalInjury_Private_Void_ActiveInjury_List_1_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680970);
		NativeMethodInfoPtr_handleTreatment_Private_Boolean_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680971);
		NativeMethodInfoPtr_handleInfectionStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680972);
		NativeMethodInfoPtr_handleBleedEffect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680973);
		NativeMethodInfoPtr_applyExternalTreatmentRates_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680974);
		NativeMethodInfoPtr_keepInjuryDurabilityClamped_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680975);
		NativeMethodInfoPtr_getInjuryMaxDurability_Private_Int32_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680976);
		NativeMethodInfoPtr_add_Private_Void_ActiveInjury_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680977);
		NativeMethodInfoPtr_remove_Private_ActiveInjury_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680978);
		NativeMethodInfoPtr_find_Private_ActiveInjury_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680979);
		NativeMethodInfoPtr_HasInjury_Public_Virtual_Final_New_Boolean_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680980);
		NativeMethodInfoPtr_ValidLocation_Public_Virtual_Final_New_Boolean_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680981);
		NativeMethodInfoPtr_getInjuryCategoryInformation_Private_InjuryCategoryInformation_Injury_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680982);
		NativeMethodInfoPtr_AllowedThroughWhitelist_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680983);
		NativeMethodInfoPtr_GetBodyLocationsInCategory_Public_Virtual_Final_New_List_1_InjuryLocation_InjuryCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680984);
		NativeMethodInfoPtr_getLocationCategory_Private_InjuryCategory_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680985);
		NativeMethodInfoPtr_GetActiveInjuriesByLocation_Public_Virtual_Final_New_Boolean_InjuryLocation_byref_List_1_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680986);
		NativeMethodInfoPtr_GetActiveInjuries_Public_Virtual_Final_New_List_1_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680987);
		NativeMethodInfoPtr_GetConcussionRadialBlurIntensity_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680988);
		NativeMethodInfoPtr_ConcussionKnockoutActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680989);
		NativeMethodInfoPtr_isInjuryRemovedInstantlyWhenTreated_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680990);
		NativeMethodInfoPtr_GetInjurableLocations_Public_Virtual_Final_New_List_1_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680991);
		NativeMethodInfoPtr_SetHealingState_Public_Virtual_Final_New_Void_String_InjuryLocation_IInteraction_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680992);
		NativeMethodInfoPtr_ResetHealingState_Public_Virtual_Final_New_Void_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680993);
		NativeMethodInfoPtr_setInteractInjury_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680994);
		NativeMethodInfoPtr_setActiveInteraction_Private_Void_IInteraction_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680995);
		NativeMethodInfoPtr_GetHealingState_Public_Virtual_Final_New_HealingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680996);
		NativeMethodInfoPtr_GetNumInjuriesAppliedThisFrame_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680997);
		NativeMethodInfoPtr_GetInjuryIdentifierWhitelist_Public_Virtual_Final_New_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680998);
		NativeMethodInfoPtr_CanApplyInjuries_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100680999);
		NativeMethodInfoPtr_SetCanApplyInjuries_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681000);
		NativeMethodInfoPtr_HasInjuryWhitelist_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681001);
		NativeMethodInfoPtr_SetInjuryWhitelist_Public_Virtual_Final_New_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681002);
		NativeMethodInfoPtr_ClearInjuryWhitelist_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681003);
		NativeMethodInfoPtr_handleInjuryCleanliness_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681004);
		NativeMethodInfoPtr_randomlyDirtyInjuries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681005);
		NativeMethodInfoPtr_applyBodilyInfectionFromDirtiedInjury_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681006);
		NativeMethodInfoPtr_getCombinedInfectionPercentage_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681007);
		NativeMethodInfoPtr_HasUntreatedInjury_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681008);
		NativeMethodInfoPtr_GetInfectionPercentageByLocation_Public_Virtual_Final_New_Single_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681009);
		NativeMethodInfoPtr_AddInfectionPercentageByLocation_Public_Virtual_Final_New_Void_Single_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681010);
		NativeMethodInfoPtr_RemoveInfectionPercentageByLocation_Public_Virtual_Final_New_Void_Single_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681011);
		NativeMethodInfoPtr_SetInfectionStatusDefinition_Public_Void_StatusEffectDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681012);
		NativeMethodInfoPtr_GetInfectedLocations_Public_Virtual_Final_New_List_1_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681013);
		NativeMethodInfoPtr_GetInjuryCleanlinessState_Public_Virtual_Final_New_InjuryCleanliness_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681014);
		NativeMethodInfoPtr_SetInjuryCleanlinessState_Public_Virtual_Final_New_Void_String_InjuryLocation_InjuryCleanliness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681015);
		NativeMethodInfoPtr_IsInjuryDirty_Public_Virtual_Final_New_Boolean_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681016);
		NativeMethodInfoPtr_GetFilthLevel_Public_Virtual_Final_New_Single_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681017);
		NativeMethodInfoPtr_GetSanitationLevel_Public_Virtual_Final_New_Single_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681018);
		NativeMethodInfoPtr_AddCleanliness_Public_Virtual_Final_New_Boolean_String_InjuryLocation_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681019);
		NativeMethodInfoPtr_HandleInjuryDamageEffects_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681020);
		NativeMethodInfoPtr_DamageMedicalItems_Public_Virtual_Final_New_Void_ActiveInjury_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681021);
		NativeMethodInfoPtr_IncreaseInjuryDurabilityOnDamage_Public_Virtual_Final_New_Void_ActiveInjury_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681022);
		NativeMethodInfoPtr_StartCauterization_Public_Virtual_Final_New_Void_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681023);
		NativeMethodInfoPtr_EndCauterization_Public_Virtual_Final_New_Void_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681024);
		NativeMethodInfoPtr_setInjuryTreatmentRate_Private_Void_String_InjuryLocation_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681025);
		NativeMethodInfoPtr_GetActiveInjury_Public_Virtual_Final_New_ActiveInjury_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681026);
		NativeMethodInfoPtr_TryGetActiveInjury_Public_Boolean_String_InjuryLocation_byref_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681027);
		NativeMethodInfoPtr_SetInjuryMap_Public_Void_Dictionary_2_String_Injury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681028);
		NativeMethodInfoPtr_SetInjuryLocationToCategoryMap_Public_Void_Dictionary_2_InjuryLocation_InjuryCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681029);
		NativeMethodInfoPtr_initializeBodyPartInjuryDict_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681030);
		NativeMethodInfoPtr_onActiveInjuriesUpdated_Private_Void_List_1_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681031);
		NativeMethodInfoPtr_initializeInfectionDict_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681032);
		NativeMethodInfoPtr_initializeNonSerializedFields_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681033);
		NativeMethodInfoPtr_initializeNonSerializedFields_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681034);
		NativeMethodInfoPtr_reconstructInjuryIdStack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681035);
		NativeMethodInfoPtr_applyUpdate_Private_Void_ActiveInjury_byref_NetworkActiveInjuryUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681036);
		NativeMethodInfoPtr_IsUpdateListenerActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681037);
		NativeMethodInfoPtr_HandleUpdate_Public_Virtual_Final_New_Void_byref_NetworkActiveInjuryUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681038);
		NativeMethodInfoPtr_AddInjuryAddedListener_Public_Virtual_Final_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681039);
		NativeMethodInfoPtr_AddOneUseInjuryAddedListener_Public_Virtual_Final_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681040);
		NativeMethodInfoPtr_RemoveInjuryAddedListener_Public_Virtual_Final_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681041);
		NativeMethodInfoPtr_AddInjuryRemovedListener_Public_Virtual_Final_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681042);
		NativeMethodInfoPtr_RemoveInjuryRemovedListener_Public_Virtual_Final_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681043);
		NativeMethodInfoPtr_AddInjuryStateChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681044);
		NativeMethodInfoPtr_RemoveInjuryStateChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681045);
		NativeMethodInfoPtr_AddCleanlinessChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681046);
		NativeMethodInfoPtr_RemoveCleanlinessChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681047);
		NativeMethodInfoPtr_dispatchInjuryAddedEvent_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681048);
		NativeMethodInfoPtr_dispatchInjuryRemovedEvent_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681049);
		NativeMethodInfoPtr_dispatchInjuryStateChangedEvent_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681050);
		NativeMethodInfoPtr_dispatchCleanlinessChangedEvent_Private_Void_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681051);
		NativeMethodInfoPtr_dispatchUpdateListeners_Private_Void_ActiveInjury_ICollection_1_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681052);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryView>.NativeClassPtr, 100681053);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245900, XrefRangeEnd = 245902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetComponentName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245902, XrefRangeEnd = 245940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeSerializableFields(SerializationContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245940, XrefRangeEnd = 245960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetEvents(IGameEventManager gameEventManager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetEvents_Public_Virtual_Void_IGameEventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245960, XrefRangeEnd = 246030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246030, XrefRangeEnd = 246110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Activated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Activated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246110, XrefRangeEnd = 246119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Deactivated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Deactivated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246134, RefRangeEnd = 246135, XrefRangeStart = 246119, XrefRangeEnd = 246134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActiveInjury initializeActiveInjury(Injury injury, InjuryLocation location, int injuryId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initializeActiveInjury_Private_ActiveInjury_Injury_InjuryLocation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActiveInjury>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246135, XrefRangeEnd = 246163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ApplyInjury(Injury injury, InjuryLocation location, float startingDurabilityPercentage = 1f, float startingCleanlinessAmount = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingDurabilityPercentage;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingCleanlinessAmount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyInjury_Public_Virtual_Final_New_Boolean_Injury_InjuryLocation_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 246226, RefRangeEnd = 246228, XrefRangeStart = 246163, XrefRangeEnd = 246226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveInjury(string identifier, InjuryLocation location, InventorySlot connectedMedicalSlot = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)connectedMedicalSlot);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveInjury_Public_Virtual_Final_New_Void_String_InjuryLocation_InventorySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246228, XrefRangeEnd = 246249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleSpecialInjuryRemovalEffects(ActiveInjury removedInjury, InjuryCategoryInformation categoryInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)removedInjury);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)categoryInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleSpecialInjuryRemovalEffects_Private_Void_ActiveInjury_InjuryCategoryInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246249, XrefRangeEnd = 246262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void HandleHealInteractionComplete(string injuryIdentifier, InjuryLocation location, float conditionPercentage, int numItemsUsed, List<InventoryItemStack> itemStacks = null, HealInjuryInfo info = default(HealInjuryInfo))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &conditionPercentage;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &numItemsUsed;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemStacks);
		*(HealInjuryInfo**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleHealInteractionComplete_Public_Virtual_Final_New_Void_String_InjuryLocation_Single_Int32_List_1_InventoryItemStack_HealInjuryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246262, XrefRangeEnd = 246277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void treatInjury(string identifier, InjuryLocation location, List<InventoryItemStack> itemStacks, float conditionPercentage, int numItemsUsed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemStacks);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &conditionPercentage;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &numItemsUsed;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_treatInjury_Private_Void_String_InjuryLocation_List_1_InventoryItemStack_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246277, XrefRangeEnd = 246294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void treatInjury(string identifier, InjuryLocation location, HealInjuryInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(HealInjuryInfo**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_treatInjury_Private_Void_String_InjuryLocation_HealInjuryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246335, RefRangeEnd = 246336, XrefRangeStart = 246294, XrefRangeEnd = 246335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void assignTreatmentInfo(ActiveInjury treatedInjury, List<InventoryItemStack> itemStacks, float conditionPercentage, int numItemsUsed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)treatedInjury);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemStacks);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &conditionPercentage;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &numItemsUsed;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_assignTreatmentInfo_Private_Void_ActiveInjury_List_1_InventoryItemStack_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void assignTreatmentInfo(ActiveInjury treatedInjury, HealInjuryInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)treatedInjury);
		*(HealInjuryInfo**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_assignTreatmentInfo_Private_Void_ActiveInjury_HealInjuryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246341, RefRangeEnd = 246342, XrefRangeStart = 246336, XrefRangeEnd = 246341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void untreatInjury(ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_untreatInjury_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246358, RefRangeEnd = 246359, XrefRangeStart = 246342, XrefRangeEnd = 246358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyOnReceiveStatusEffects(ActiveInjury injury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyOnReceiveStatusEffects_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 246375, RefRangeEnd = 246378, XrefRangeStart = 246359, XrefRangeEnd = 246375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyTreatedStatusEffects(ActiveInjury injury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyTreatedStatusEffects_Protected_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 246397, RefRangeEnd = 246401, XrefRangeStart = 246378, XrefRangeEnd = 246397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeTreatedStatusEffects(ActiveInjury injury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeTreatedStatusEffects_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 246417, RefRangeEnd = 246421, XrefRangeStart = 246401, XrefRangeEnd = 246417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyIndefiniteStatusEffects(ActiveInjury injury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyIndefiniteStatusEffects_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 246440, RefRangeEnd = 246444, XrefRangeStart = 246421, XrefRangeEnd = 246440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeIndefiniteStatusEffects(ActiveInjury injury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeIndefiniteStatusEffects_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 246465, RefRangeEnd = 246468, XrefRangeStart = 246444, XrefRangeEnd = 246465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyInjuryStatusEffect(StatusEffect statusEffect, ActiveInjury activeInjury, int injuryId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)statusEffect));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyInjuryStatusEffect_Private_Void_StatusEffect_ActiveInjury_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246468, XrefRangeEnd = 246510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246638, RefRangeEnd = 246639, XrefRangeStart = 246510, XrefRangeEnd = 246638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleInjuries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleInjuries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246706, RefRangeEnd = 246707, XrefRangeStart = 246639, XrefRangeEnd = 246706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleInjury(ActiveInjury activeInjury, InventorySlot treatmentSlot, List<ActiveInjury> injuriesToRemove)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)treatmentSlot);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuriesToRemove);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleInjury_Private_Void_ActiveInjury_InventorySlot_List_1_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246719, RefRangeEnd = 246720, XrefRangeStart = 246707, XrefRangeEnd = 246719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleAnimalInjury(ActiveInjury activeInjury, List<ActiveInjury> injuriesToRemove)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuriesToRemove);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleAnimalInjury_Private_Void_ActiveInjury_List_1_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246829, RefRangeEnd = 246830, XrefRangeStart = 246720, XrefRangeEnd = 246829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool handleTreatment(ActiveInjury treatedInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)treatedInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleTreatment_Private_Boolean_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246871, RefRangeEnd = 246872, XrefRangeStart = 246830, XrefRangeEnd = 246871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleInfectionStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleInfectionStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246889, RefRangeEnd = 246890, XrefRangeStart = 246872, XrefRangeEnd = 246889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleBleedEffect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleBleedEffect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246890, XrefRangeEnd = 246902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyExternalTreatmentRates(ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyExternalTreatmentRates_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246902, XrefRangeEnd = 246903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void keepInjuryDurabilityClamped(ActiveInjury injury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_keepInjuryDurabilityClamped_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246903, XrefRangeEnd = 246904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getInjuryMaxDurability(ActiveInjury injury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInjuryMaxDurability_Private_Int32_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246904, XrefRangeEnd = 246912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add(ActiveInjury activeInjury, InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_Private_Void_ActiveInjury_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246949, RefRangeEnd = 246950, XrefRangeStart = 246912, XrefRangeEnd = 246949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActiveInjury remove(string identifier, InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_Private_ActiveInjury_String_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActiveInjury>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 246965, RefRangeEnd = 246973, XrefRangeStart = 246950, XrefRangeEnd = 246965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActiveInjury find(string identifier, InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_find_Private_ActiveInjury_String_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActiveInjury>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 246985, RefRangeEnd = 246990, XrefRangeStart = 246973, XrefRangeEnd = 246985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool HasInjury(string identifier, InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasInjury_Public_Virtual_Final_New_Boolean_String_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246990, XrefRangeEnd = 246995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ValidLocation(InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&location);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidLocation_Public_Virtual_Final_New_Boolean_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 247008, RefRangeEnd = 247018, XrefRangeStart = 246995, XrefRangeEnd = 247008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InjuryCategoryInformation getInjuryCategoryInformation(Injury injury, InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInjuryCategoryInformation_Private_InjuryCategoryInformation_Injury_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InjuryCategoryInformation>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247018, XrefRangeEnd = 247023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool AllowedThroughWhitelist(string injuryIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllowedThroughWhitelist_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247023, XrefRangeEnd = 247048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual List<InjuryLocation> GetBodyLocationsInCategory(InjuryCategory injuryCategory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&injuryCategory);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBodyLocationsInCategory_Public_Virtual_Final_New_List_1_InjuryLocation_InjuryCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InjuryLocation>>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 247058, RefRangeEnd = 247063, XrefRangeStart = 247048, XrefRangeEnd = 247058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InjuryCategory getLocationCategory(InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&location);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getLocationCategory_Private_InjuryCategory_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InjuryCategory*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 247079, RefRangeEnd = 247088, XrefRangeStart = 247063, XrefRangeEnd = 247079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool GetActiveInjuriesByLocation(InjuryLocation location, out List<ActiveInjury> locInjuries)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&location);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveInjuriesByLocation_Public_Virtual_Final_New_Boolean_InjuryLocation_byref_List_1_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		locInjuries = ((num3 == 0) ? null : new List<ActiveInjury>(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247088, XrefRangeEnd = 247089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual List<ActiveInjury> GetActiveInjuries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveInjuries_Public_Virtual_Final_New_List_1_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ActiveInjury>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247089, XrefRangeEnd = 247098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetConcussionRadialBlurIntensity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConcussionRadialBlurIntensity_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247098, XrefRangeEnd = 247101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ConcussionKnockoutActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConcussionKnockoutActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247101, XrefRangeEnd = 247111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isInjuryRemovedInstantlyWhenTreated(string injuryIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isInjuryRemovedInstantlyWhenTreated_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247111, XrefRangeEnd = 247112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual List<InjuryLocation> GetInjurableLocations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInjurableLocations_Public_Virtual_Final_New_List_1_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InjuryLocation>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247112, XrefRangeEnd = 247115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetHealingState(string injuryIdentifier, InjuryLocation injuryLocation, IInteraction activeInjuryInteraction, InteractionType activeInjuryInteractionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjuryInteraction);
		*(InteractionType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &activeInjuryInteractionType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHealingState_Public_Virtual_Final_New_Void_String_InjuryLocation_IInteraction_InteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247115, XrefRangeEnd = 247116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ResetHealingState(InteractionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetHealingState_Public_Virtual_Final_New_Void_InteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247116, XrefRangeEnd = 247118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setInteractInjury(ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setInteractInjury_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247118, XrefRangeEnd = 247119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setActiveInteraction(IInteraction activeInjuryInteraction, InteractionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjuryInteraction);
		*(InteractionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setActiveInteraction_Private_Void_IInteraction_InteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual HealingState GetHealingState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHealingState_Public_Virtual_Final_New_HealingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HealingState>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual int GetNumInjuriesAppliedThisFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumInjuriesAppliedThisFrame_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247119, XrefRangeEnd = 247120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual List<string> GetInjuryIdentifierWhitelist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInjuryIdentifierWhitelist_Public_Virtual_Final_New_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247120, XrefRangeEnd = 247121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool CanApplyInjuries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanApplyInjuries_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247121, XrefRangeEnd = 247125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetCanApplyInjuries(bool canApplyInjuries)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&canApplyInjuries);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCanApplyInjuries_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247125, XrefRangeEnd = 247127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool HasInjuryWhitelist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasInjuryWhitelist_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247127, XrefRangeEnd = 247147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetInjuryWhitelist(List<string> identifiers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInjuryWhitelist_Public_Virtual_Final_New_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247147, XrefRangeEnd = 247151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ClearInjuryWhitelist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearInjuryWhitelist_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247155, RefRangeEnd = 247157, XrefRangeStart = 247151, XrefRangeEnd = 247155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleInjuryCleanliness(ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleInjuryCleanliness_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247175, RefRangeEnd = 247176, XrefRangeStart = 247157, XrefRangeEnd = 247175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void randomlyDirtyInjuries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_randomlyDirtyInjuries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247178, RefRangeEnd = 247180, XrefRangeStart = 247176, XrefRangeEnd = 247178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyBodilyInfectionFromDirtiedInjury(ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyBodilyInfectionFromDirtiedInjury_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247200, RefRangeEnd = 247201, XrefRangeStart = 247180, XrefRangeEnd = 247200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getCombinedInfectionPercentage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCombinedInfectionPercentage_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool HasUntreatedInjury()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasUntreatedInjury_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247201, XrefRangeEnd = 247206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetInfectionPercentageByLocation(InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&location);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInfectionPercentageByLocation_Public_Virtual_Final_New_Single_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 247218, RefRangeEnd = 247221, XrefRangeStart = 247206, XrefRangeEnd = 247218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddInfectionPercentageByLocation(float value, InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInfectionPercentageByLocation_Public_Virtual_Final_New_Void_Single_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247221, XrefRangeEnd = 247233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveInfectionPercentageByLocation(float value, InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveInfectionPercentageByLocation_Public_Virtual_Final_New_Void_Single_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInfectionStatusDefinition(StatusEffectDefinition def)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)def);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInfectionStatusDefinition_Public_Void_StatusEffectDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247233, XrefRangeEnd = 247259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual List<InjuryLocation> GetInfectedLocations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInfectedLocations_Public_Virtual_Final_New_List_1_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InjuryLocation>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247259, XrefRangeEnd = 247260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual InjuryCleanliness GetInjuryCleanlinessState(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInjuryCleanlinessState_Public_Virtual_Final_New_InjuryCleanliness_String_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InjuryCleanliness*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247260, XrefRangeEnd = 247261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetInjuryCleanlinessState(string injuryIdentifier, InjuryLocation injuryLocation, InjuryCleanliness state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		*(InjuryCleanliness**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInjuryCleanlinessState_Public_Virtual_Final_New_Void_String_InjuryLocation_InjuryCleanliness_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247261, XrefRangeEnd = 247262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsInjuryDirty(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInjuryDirty_Public_Virtual_Final_New_Boolean_String_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247262, XrefRangeEnd = 247263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetFilthLevel(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFilthLevel_Public_Virtual_Final_New_Single_String_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247263, XrefRangeEnd = 247264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetSanitationLevel(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSanitationLevel_Public_Virtual_Final_New_Single_String_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247296, RefRangeEnd = 247297, XrefRangeStart = 247264, XrefRangeEnd = 247296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool AddCleanliness(string injuryIdentifier, InjuryLocation injuryLocation, float sanitationAdded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sanitationAdded;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCleanliness_Public_Virtual_Final_New_Boolean_String_InjuryLocation_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247297, XrefRangeEnd = 247321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void HandleInjuryDamageEffects(float damageDealt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&damageDealt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInjuryDamageEffects_Public_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247321, XrefRangeEnd = 247326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void DamageMedicalItems(ActiveInjury activeInjury, float damageDealt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &damageDealt;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DamageMedicalItems_Public_Virtual_Final_New_Void_ActiveInjury_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247326, XrefRangeEnd = 247329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void IncreaseInjuryDurabilityOnDamage(ActiveInjury activeInjury, float damageDealt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &damageDealt;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncreaseInjuryDurabilityOnDamage_Public_Virtual_Final_New_Void_ActiveInjury_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247329, XrefRangeEnd = 247333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void StartCauterization(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartCauterization_Public_Virtual_Final_New_Void_String_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247333, XrefRangeEnd = 247340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void EndCauterization(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndCauterization_Public_Virtual_Final_New_Void_String_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247340, XrefRangeEnd = 247341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setInjuryTreatmentRate(string injuryIdentifier, InjuryLocation injuryLocation, float rate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setInjuryTreatmentRate_Private_Void_String_InjuryLocation_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 247349, RefRangeEnd = 247355, XrefRangeStart = 247341, XrefRangeEnd = 247349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ActiveInjury GetActiveInjury(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveInjury_Public_Virtual_Final_New_ActiveInjury_String_InjuryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActiveInjury>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 247375, RefRangeEnd = 247379, XrefRangeStart = 247355, XrefRangeEnd = 247375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetActiveInjury(string injuryIdentifier, InjuryLocation injuryLocation, out ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetActiveInjury_Public_Boolean_String_InjuryLocation_byref_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		activeInjury = ((num3 == 0) ? null : new ActiveInjury(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInjuryMap(Dictionary<string, Injury> map)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInjuryMap_Public_Void_Dictionary_2_String_Injury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInjuryLocationToCategoryMap(Dictionary<InjuryLocation, InjuryCategory> map)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInjuryLocationToCategoryMap_Public_Void_Dictionary_2_InjuryLocation_InjuryCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247456, RefRangeEnd = 247457, XrefRangeStart = 247379, XrefRangeEnd = 247456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initializeBodyPartInjuryDict()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initializeBodyPartInjuryDict_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247457, XrefRangeEnd = 247687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onActiveInjuriesUpdated(List<ActiveInjury> activeInjuryUpdate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjuryUpdate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onActiveInjuriesUpdated_Private_Void_List_1_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247716, RefRangeEnd = 247717, XrefRangeStart = 247687, XrefRangeEnd = 247716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initializeInfectionDict()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initializeInfectionDict_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247789, RefRangeEnd = 247790, XrefRangeStart = 247717, XrefRangeEnd = 247789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initializeNonSerializedFields()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initializeNonSerializedFields_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247810, RefRangeEnd = 247812, XrefRangeStart = 247790, XrefRangeEnd = 247810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initializeNonSerializedFields(ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initializeNonSerializedFields_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247853, RefRangeEnd = 247854, XrefRangeStart = 247812, XrefRangeEnd = 247853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reconstructInjuryIdStack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reconstructInjuryIdStack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247857, RefRangeEnd = 247858, XrefRangeStart = 247854, XrefRangeEnd = 247857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyUpdate(ActiveInjury injury, ref NetworkActiveInjuryUpdate update)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyUpdate_Private_Void_ActiveInjury_byref_NetworkActiveInjuryUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247858, XrefRangeEnd = 247863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsUpdateListenerActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUpdateListenerActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247863, XrefRangeEnd = 247879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void HandleUpdate(ref NetworkActiveInjuryUpdate update)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleUpdate_Public_Virtual_Final_New_Void_byref_NetworkActiveInjuryUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247879, XrefRangeEnd = 247890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddInjuryAddedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInjuryAddedListener_Public_Virtual_Final_New_Void_InjuryListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247890, XrefRangeEnd = 247901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddOneUseInjuryAddedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOneUseInjuryAddedListener_Public_Virtual_Final_New_Void_InjuryListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247901, XrefRangeEnd = 247904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveInjuryAddedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveInjuryAddedListener_Public_Virtual_Final_New_Void_InjuryListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247904, XrefRangeEnd = 247915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddInjuryRemovedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInjuryRemovedListener_Public_Virtual_Final_New_Void_InjuryListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247915, XrefRangeEnd = 247918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveInjuryRemovedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveInjuryRemovedListener_Public_Virtual_Final_New_Void_InjuryListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247918, XrefRangeEnd = 247929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddInjuryStateChangedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInjuryStateChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247929, XrefRangeEnd = 247932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveInjuryStateChangedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveInjuryStateChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247932, XrefRangeEnd = 247943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddCleanlinessChangedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCleanlinessChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247943, XrefRangeEnd = 247946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveCleanlinessChangedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCleanlinessChangedListener_Public_Virtual_Final_New_Void_InjuryListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247951, RefRangeEnd = 247953, XrefRangeStart = 247946, XrefRangeEnd = 247951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void dispatchInjuryAddedEvent(ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dispatchInjuryAddedEvent_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247953, XrefRangeEnd = 247954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void dispatchInjuryRemovedEvent(ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dispatchInjuryRemovedEvent_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247954, XrefRangeEnd = 247955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void dispatchInjuryStateChangedEvent(ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dispatchInjuryStateChangedEvent_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247955, XrefRangeEnd = 247956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void dispatchCleanlinessChangedEvent(ActiveInjury activeInjury)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dispatchCleanlinessChangedEvent_Private_Void_ActiveInjury_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 247978, RefRangeEnd = 247991, XrefRangeStart = 247956, XrefRangeEnd = 247978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void dispatchUpdateListeners(ActiveInjury activeInjury, ICollection<InjuryListener> listeners)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listeners);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_dispatchUpdateListeners_Private_Void_ActiveInjury_ICollection_1_InjuryListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InjuryView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjuryView>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InjuryView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

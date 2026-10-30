using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class CreatureView : BaseView
{
	private static readonly IntPtr NativeFieldInfoPtr_showDeadCreatureUISignal;

	private static readonly IntPtr NativeFieldInfoPtr_packId;

	private static readonly IntPtr NativeFieldInfoPtr_creature;

	private static readonly IntPtr NativeFieldInfoPtr_aiControlled;

	private static readonly IntPtr NativeFieldInfoPtr_living;

	private static readonly IntPtr NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDamageValues_Public_Virtual_Final_New_DamageValues_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCreature_Public_Virtual_Final_New_Creature_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackRange_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeFullAimTime_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileFullAimTime_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileFullAccuracyAimTime_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackDuration_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAttackDuration_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TakeConditionDamage_Public_Virtual_Final_New_Void_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileWeaponItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsOrHasAmmoItem_Public_Virtual_Final_New_Boolean_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAimSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAttackSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAttackHitSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_SurfaceType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAttackAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAimAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAimAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlockAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlockHitAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemEquipPoint_Public_Virtual_Final_New_EquipPoint_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileLaunchSpeed_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStaminaExertion_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStaminaExertionRate_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsStaminaBasedProjectileLaunch_Public_Virtual_Final_New_Boolean_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TargetHit_Public_Virtual_Final_New_Void_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_AimedAttackFinished_Public_Virtual_Final_New_Void_ActionType_InventoryItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileMinRange_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileRange_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_UseAmmoItem_Public_Virtual_Final_New_Void_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCreature_Public_Void_Creature_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPackId_Public_Virtual_Final_New_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetPackId_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsUsable_Public_Virtual_Final_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUsed_Public_Virtual_Final_New_Void_IInteraction_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetFutureDescription_Public_Virtual_Final_New_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPresentDescription_Public_Virtual_Final_New_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetShowDeadCreatureUISignal_Public_Void_ShowDeadCreatureUISignal_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsBuried_Public_Virtual_Final_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAttackInjuries_Public_Virtual_Final_New_List_1_AttackInjuryContainer_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ShowDeadCreatureUISignal showDeadCreatureUISignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDeadCreatureUISignal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ShowDeadCreatureUISignal>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDeadCreatureUISignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showDeadCreatureUISignal));
		}
	}

	public unsafe SerializablePrimitiveField<int> packId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packId);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packId)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe Creature creature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creature);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Creature>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creature)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creature));
		}
	}

	public unsafe IAIControlled aiControlled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiControlled);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IAIControlled>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiControlled)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iAIControlled));
		}
	}

	public unsafe ILiving living
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_living);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ILiving>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_living)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)living));
		}
	}

	static CreatureView()
	{
		Il2CppClassPointerStore<CreatureView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreatureView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatureView>.NativeClassPtr);
		NativeFieldInfoPtr_showDeadCreatureUISignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, "showDeadCreatureUISignal");
		NativeFieldInfoPtr_packId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, "packId");
		NativeFieldInfoPtr_creature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, "creature");
		NativeFieldInfoPtr_aiControlled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, "aiControlled");
		NativeFieldInfoPtr_living = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, "living");
		NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680315);
		NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680316);
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680317);
		NativeMethodInfoPtr_GetDamageValues_Public_Virtual_Final_New_DamageValues_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680318);
		NativeMethodInfoPtr_GetCreature_Public_Virtual_Final_New_Creature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680319);
		NativeMethodInfoPtr_GetMeleeAttackRange_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680320);
		NativeMethodInfoPtr_GetMeleeFullAimTime_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680321);
		NativeMethodInfoPtr_GetProjectileFullAimTime_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680322);
		NativeMethodInfoPtr_GetProjectileFullAccuracyAimTime_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680323);
		NativeMethodInfoPtr_GetMeleeAttackDuration_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680324);
		NativeMethodInfoPtr_GetProjectileAttackDuration_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680325);
		NativeMethodInfoPtr_TakeConditionDamage_Public_Virtual_Final_New_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680326);
		NativeMethodInfoPtr_GetMeleeItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680327);
		NativeMethodInfoPtr_GetProjectileWeaponItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680328);
		NativeMethodInfoPtr_GetProjectileItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680329);
		NativeMethodInfoPtr_IsOrHasAmmoItem_Public_Virtual_Final_New_Boolean_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680330);
		NativeMethodInfoPtr_GetMeleeAttackSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680331);
		NativeMethodInfoPtr_GetProjectileAimSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680332);
		NativeMethodInfoPtr_GetProjectileAttackSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680333);
		NativeMethodInfoPtr_GetAttackHitSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_SurfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680334);
		NativeMethodInfoPtr_GetMeleeAttackAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680335);
		NativeMethodInfoPtr_GetProjectileAttackAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680336);
		NativeMethodInfoPtr_GetProjectileAimAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680337);
		NativeMethodInfoPtr_GetMeleeAimAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680338);
		NativeMethodInfoPtr_GetBlockAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680339);
		NativeMethodInfoPtr_GetBlockHitAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680340);
		NativeMethodInfoPtr_GetItemEquipPoint_Public_Virtual_Final_New_EquipPoint_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680341);
		NativeMethodInfoPtr_GetProjectileLaunchSpeed_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680342);
		NativeMethodInfoPtr_GetStaminaExertion_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680343);
		NativeMethodInfoPtr_GetStaminaExertionRate_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680344);
		NativeMethodInfoPtr_IsStaminaBasedProjectileLaunch_Public_Virtual_Final_New_Boolean_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680345);
		NativeMethodInfoPtr_TargetHit_Public_Virtual_Final_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680346);
		NativeMethodInfoPtr_AimedAttackFinished_Public_Virtual_Final_New_Void_ActionType_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680347);
		NativeMethodInfoPtr_GetProjectileMinRange_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680348);
		NativeMethodInfoPtr_GetProjectileRange_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680349);
		NativeMethodInfoPtr_UseAmmoItem_Public_Virtual_Final_New_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680350);
		NativeMethodInfoPtr_SetCreature_Public_Void_Creature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680351);
		NativeMethodInfoPtr_GetPackId_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680352);
		NativeMethodInfoPtr_SetPackId_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680353);
		NativeMethodInfoPtr_IsUsable_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680354);
		NativeMethodInfoPtr_OnUsed_Public_Virtual_Final_New_Void_IInteraction_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680355);
		NativeMethodInfoPtr_GetFutureDescription_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680356);
		NativeMethodInfoPtr_GetPresentDescription_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680357);
		NativeMethodInfoPtr_SetShowDeadCreatureUISignal_Public_Void_ShowDeadCreatureUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680358);
		NativeMethodInfoPtr_IsBuried_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680359);
		NativeMethodInfoPtr_GetAttackInjuries_Public_Virtual_Final_New_List_1_AttackInjuryContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680360);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureView>.NativeClassPtr, 100680361);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239991, XrefRangeEnd = 239993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetComponentName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239993, XrefRangeEnd = 239998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeSerializableFields(SerializationContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239998, XrefRangeEnd = 240006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240006, XrefRangeEnd = 240009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual DamageValues GetDamageValues(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDamageValues_Public_Virtual_Final_New_DamageValues_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DamageValues*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 977, RefRangeEnd = 983, XrefRangeStart = 977, XrefRangeEnd = 983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Creature GetCreature()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCreature_Public_Virtual_Final_New_Creature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Creature>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240009, XrefRangeEnd = 240011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetMeleeAttackRange(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeleeAttackRange_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetMeleeFullAimTime(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeleeFullAimTime_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetProjectileFullAimTime(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileFullAimTime_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetProjectileFullAccuracyAimTime(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileFullAccuracyAimTime_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240011, XrefRangeEnd = 240013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetMeleeAttackDuration(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeleeAttackDuration_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetProjectileAttackDuration(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileAttackDuration_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void TakeConditionDamage(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TakeConditionDamage_Public_Virtual_Final_New_Void_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual InventoryItemStack GetMeleeItemStack(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeleeItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual InventoryItemStack GetProjectileWeaponItemStack(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileWeaponItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual InventoryItemStack GetProjectileItemStack(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 27783, RefRangeEnd = 27926, XrefRangeStart = 27783, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsOrHasAmmoItem(InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOrHasAmmoItem_Public_Virtual_Final_New_Boolean_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240013, XrefRangeEnd = 240015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual SoundEffectType GetMeleeAttackSoundEffect(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeleeAttackSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SoundEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual SoundEffectType GetProjectileAimSoundEffect(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileAimSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SoundEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual SoundEffectType GetProjectileAttackSoundEffect(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileAttackSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SoundEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual SoundEffectType GetAttackHitSoundEffect(ActionType actionType, SurfaceType surfaceType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&actionType);
		*(SurfaceType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &surfaceType;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttackHitSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_SurfaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SoundEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240015, XrefRangeEnd = 240016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual AnimationState GetMeleeAttackAnimationState(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeleeAttackAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetProjectileAttackAnimationState(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileAttackAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetProjectileAimAnimationState(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileAimAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual AnimationState GetMeleeAimAnimationState(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeleeAimAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual AnimationState GetBlockAnimationState(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlockAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual AnimationState GetBlockHitAnimationState(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlockHitAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual EquipPoint GetItemEquipPoint(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemEquipPoint_Public_Virtual_Final_New_EquipPoint_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EquipPoint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetProjectileLaunchSpeed(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileLaunchSpeed_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetStaminaExertion(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStaminaExertion_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetStaminaExertionRate(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStaminaExertionRate_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 27783, RefRangeEnd = 27926, XrefRangeStart = 27783, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsStaminaBasedProjectileLaunch(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsStaminaBasedProjectileLaunch_Public_Virtual_Final_New_Boolean_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240016, XrefRangeEnd = 240019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void TargetHit(Entity hitEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hitEntity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TargetHit_Public_Virtual_Final_New_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AimedAttackFinished(ActionType actionType, InventoryItem projectileItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&actionType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)projectileItem);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AimedAttackFinished_Public_Virtual_Final_New_Void_ActionType_InventoryItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual float GetProjectileMinRange(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileMinRange_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetProjectileRange(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectileRange_Public_Virtual_Final_New_Single_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UseAmmoItem(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseAmmoItem_Public_Virtual_Final_New_Void_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCreature(Creature creature)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creature);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCreature_Public_Void_Creature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240019, XrefRangeEnd = 240020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int GetPackId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPackId_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240020, XrefRangeEnd = 240024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetPackId(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPackId_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240024, XrefRangeEnd = 240028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsUsable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsable_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240028, XrefRangeEnd = 240033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnUsed(IInteraction withInteraction, Entity userEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)withInteraction);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)userEntity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUsed_Public_Virtual_Final_New_Void_IInteraction_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetFutureDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFutureDescription_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetPresentDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPresentDescription_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetShowDeadCreatureUISignal(ShowDeadCreatureUISignal signal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)signal);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShowDeadCreatureUISignal_Public_Void_ShowDeadCreatureUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsBuried()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBuried_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240033, XrefRangeEnd = 240035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual List<AttackInjuryContainer> GetAttackInjuries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttackInjuries_Public_Virtual_Final_New_List_1_AttackInjuryContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AttackInjuryContainer>>(intPtr) : null;
	}

	[CallerCount(229)]
	[CachedScanResults(RefRangeStart = 18764, RefRangeEnd = 18993, XrefRangeStart = 18764, XrefRangeEnd = 18993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreatureView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatureView>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreatureView(IntPtr pointer)
		: base(pointer)
	{
	}
}

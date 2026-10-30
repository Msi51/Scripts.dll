using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class HumanoidAttackerView : BaseView
{
	private static readonly IntPtr NativeFieldInfoPtr_damageItemStackSignal;

	private static readonly IntPtr NativeFieldInfoPtr_equipItemStackEvent;

	private static readonly IntPtr NativeFieldInfoPtr_inventoryHolder;

	private static readonly IntPtr NativeFieldInfoPtr_characterInventorySection;

	private static readonly IntPtr NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetEvents_Public_Virtual_Void_IGameEventManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Activated_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetDamageValues_Public_Virtual_Final_New_DamageValues_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAttackInjuries_Public_Virtual_Final_New_List_1_AttackInjuryContainer_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackRange_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeFullAimTime_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileFullAimTime_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileFullAccuracyAimTime_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackDuration_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAttackDuration_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TakeConditionDamage_Public_Virtual_Final_New_Void_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileWeaponItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_getProjectileItemStack_Private_InventoryItemStack_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsOrHasAmmoItem_Public_Virtual_Final_New_Boolean_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_UseAmmoItem_Public_Virtual_Final_New_Void_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAimSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAttackSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAttackHitSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_SurfaceType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAttackAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAimAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAimAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlockAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlockHitAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemEquipPoint_Public_Virtual_Final_New_EquipPoint_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsStaminaBasedProjectileLaunch_Public_Virtual_Final_New_Boolean_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileLaunchSpeed_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileMinRange_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileRange_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStaminaExertion_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStaminaExertionRate_Public_Virtual_Final_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TargetHit_Public_Virtual_Final_New_Void_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_AimedAttackFinished_Public_Virtual_Final_New_Void_ActionType_InventoryItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDamageStackSignal_Public_Void_DamageItemStackSignal_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe DamageItemStackSignal damageItemStackSignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageItemStackSignal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DamageItemStackSignal>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageItemStackSignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)damageItemStackSignal));
		}
	}

	public unsafe EquipItemStackEvent equipItemStackEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipItemStackEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EquipItemStackEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipItemStackEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)equipItemStackEvent));
		}
	}

	public unsafe IInventoryHolder inventoryHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolder);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInventoryHolder>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryHolder));
		}
	}

	public unsafe CharacterInventorySection characterInventorySection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInventorySection);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterInventorySection>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInventorySection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterInventorySection));
		}
	}

	static HumanoidAttackerView()
	{
		Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HumanoidAttackerView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr);
		NativeFieldInfoPtr_damageItemStackSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, "damageItemStackSignal");
		NativeFieldInfoPtr_equipItemStackEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, "equipItemStackEvent");
		NativeFieldInfoPtr_inventoryHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, "inventoryHolder");
		NativeFieldInfoPtr_characterInventorySection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, "characterInventorySection");
		NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680808);
		NativeMethodInfoPtr_SetEvents_Public_Virtual_Void_IGameEventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680809);
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680810);
		NativeMethodInfoPtr_Activated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680811);
		NativeMethodInfoPtr_GetDamageValues_Public_Virtual_Final_New_DamageValues_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680812);
		NativeMethodInfoPtr_GetAttackInjuries_Public_Virtual_Final_New_List_1_AttackInjuryContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680813);
		NativeMethodInfoPtr_GetMeleeAttackRange_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680814);
		NativeMethodInfoPtr_GetMeleeFullAimTime_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680815);
		NativeMethodInfoPtr_GetProjectileFullAimTime_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680816);
		NativeMethodInfoPtr_GetProjectileFullAccuracyAimTime_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680817);
		NativeMethodInfoPtr_GetMeleeAttackDuration_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680818);
		NativeMethodInfoPtr_GetProjectileAttackDuration_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680819);
		NativeMethodInfoPtr_TakeConditionDamage_Public_Virtual_Final_New_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680820);
		NativeMethodInfoPtr_GetMeleeItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680821);
		NativeMethodInfoPtr_GetProjectileWeaponItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680822);
		NativeMethodInfoPtr_getProjectileItemStack_Private_InventoryItemStack_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680823);
		NativeMethodInfoPtr_GetProjectileItemStack_Public_Virtual_Final_New_InventoryItemStack_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680824);
		NativeMethodInfoPtr_IsOrHasAmmoItem_Public_Virtual_Final_New_Boolean_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680825);
		NativeMethodInfoPtr_UseAmmoItem_Public_Virtual_Final_New_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680826);
		NativeMethodInfoPtr_GetMeleeAttackSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680827);
		NativeMethodInfoPtr_GetProjectileAimSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680828);
		NativeMethodInfoPtr_GetProjectileAttackSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680829);
		NativeMethodInfoPtr_GetAttackHitSoundEffect_Public_Virtual_Final_New_SoundEffectType_ActionType_SurfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680830);
		NativeMethodInfoPtr_GetMeleeAttackAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680831);
		NativeMethodInfoPtr_GetProjectileAttackAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680832);
		NativeMethodInfoPtr_GetMeleeAimAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680833);
		NativeMethodInfoPtr_GetProjectileAimAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680834);
		NativeMethodInfoPtr_GetBlockAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680835);
		NativeMethodInfoPtr_GetBlockHitAnimationState_Public_Virtual_Final_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680836);
		NativeMethodInfoPtr_GetItemEquipPoint_Public_Virtual_Final_New_EquipPoint_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680837);
		NativeMethodInfoPtr_IsStaminaBasedProjectileLaunch_Public_Virtual_Final_New_Boolean_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680838);
		NativeMethodInfoPtr_GetProjectileLaunchSpeed_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680839);
		NativeMethodInfoPtr_GetProjectileMinRange_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680840);
		NativeMethodInfoPtr_GetProjectileRange_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680841);
		NativeMethodInfoPtr_GetStaminaExertion_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680842);
		NativeMethodInfoPtr_GetStaminaExertionRate_Public_Virtual_Final_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680843);
		NativeMethodInfoPtr_TargetHit_Public_Virtual_Final_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680844);
		NativeMethodInfoPtr_AimedAttackFinished_Public_Virtual_Final_New_Void_ActionType_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680845);
		NativeMethodInfoPtr_SetDamageStackSignal_Public_Void_DamageItemStackSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680846);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr, 100680847);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244630, XrefRangeEnd = 244632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244632, XrefRangeEnd = 244637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetEvents(IGameEventManager gameEventManager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetEvents_Public_Virtual_Void_IGameEventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244637, XrefRangeEnd = 244641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244641, XrefRangeEnd = 244649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Activated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Activated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244649, XrefRangeEnd = 244650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244650, XrefRangeEnd = 244651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual List<AttackInjuryContainer> GetAttackInjuries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttackInjuries_Public_Virtual_Final_New_List_1_AttackInjuryContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AttackInjuryContainer>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244651, XrefRangeEnd = 244652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244652, XrefRangeEnd = 244653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244653, XrefRangeEnd = 244654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244654, XrefRangeEnd = 244655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244655, XrefRangeEnd = 244656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244656, XrefRangeEnd = 244657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244657, XrefRangeEnd = 244663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void TakeConditionDamage(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TakeConditionDamage_Public_Virtual_Final_New_Void_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244663, XrefRangeEnd = 244665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244665, XrefRangeEnd = 244667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 244723, RefRangeEnd = 244726, XrefRangeStart = 244667, XrefRangeEnd = 244723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InventoryItemStack getProjectileItemStack(InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getProjectileItemStack_Private_InventoryItemStack_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244726, XrefRangeEnd = 244729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244729, XrefRangeEnd = 244730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244730, XrefRangeEnd = 244733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244733, XrefRangeEnd = 244734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244734, XrefRangeEnd = 244735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244735, XrefRangeEnd = 244736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244736, XrefRangeEnd = 244737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244737, XrefRangeEnd = 244738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244738, XrefRangeEnd = 244739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244739, XrefRangeEnd = 244740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244740, XrefRangeEnd = 244741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244741, XrefRangeEnd = 244742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244742, XrefRangeEnd = 244743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244743, XrefRangeEnd = 244744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244744, XrefRangeEnd = 244745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244745, XrefRangeEnd = 244746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244746, XrefRangeEnd = 244747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244747, XrefRangeEnd = 244750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244750, XrefRangeEnd = 244751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244751, XrefRangeEnd = 244752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void TargetHit(Entity hitEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hitEntity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TargetHit_Public_Virtual_Final_New_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244752, XrefRangeEnd = 244762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDamageStackSignal(DamageItemStackSignal signal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)signal);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDamageStackSignal_Public_Void_DamageItemStackSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HumanoidAttackerView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HumanoidAttackerView>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HumanoidAttackerView(IntPtr pointer)
		: base(pointer)
	{
	}
}

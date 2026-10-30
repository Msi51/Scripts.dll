using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IAttacker : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetDamageValues_Public_Abstract_Virtual_New_DamageValues_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackRange_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeFullAimTime_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileFullAimTime_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileFullAccuracyAimTime_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackDuration_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAttackDuration_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TakeConditionDamage_Public_Abstract_Virtual_New_Void_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeItemStack_Public_Abstract_Virtual_New_InventoryItemStack_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileWeaponItemStack_Public_Abstract_Virtual_New_InventoryItemStack_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileItemStack_Public_Abstract_Virtual_New_InventoryItemStack_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsOrHasAmmoItem_Public_Abstract_Virtual_New_Boolean_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_UseAmmoItem_Public_Abstract_Virtual_New_Void_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAimSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAttackSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAttackHitSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_SurfaceType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAttackAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAttackAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileAimAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMeleeAimAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlockAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlockHitAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemEquipPoint_Public_Abstract_Virtual_New_EquipPoint_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileLaunchSpeed_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStaminaExertion_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStaminaExertionRate_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsStaminaBasedProjectileLaunch_Public_Abstract_Virtual_New_Boolean_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TargetHit_Public_Abstract_Virtual_New_Void_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_AimedAttackFinished_Public_Abstract_Virtual_New_Void_ActionType_InventoryItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileMinRange_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProjectileRange_Public_Abstract_Virtual_New_Single_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAttackInjuries_Public_Abstract_Virtual_New_List_1_AttackInjuryContainer_0;

	static IAttacker()
	{
		Il2CppClassPointerStore<IAttacker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IAttacker");
		NativeMethodInfoPtr_GetDamageValues_Public_Abstract_Virtual_New_DamageValues_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681219);
		NativeMethodInfoPtr_GetMeleeAttackRange_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681220);
		NativeMethodInfoPtr_GetMeleeFullAimTime_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681221);
		NativeMethodInfoPtr_GetProjectileFullAimTime_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681222);
		NativeMethodInfoPtr_GetProjectileFullAccuracyAimTime_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681223);
		NativeMethodInfoPtr_GetMeleeAttackDuration_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681224);
		NativeMethodInfoPtr_GetProjectileAttackDuration_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681225);
		NativeMethodInfoPtr_TakeConditionDamage_Public_Abstract_Virtual_New_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681226);
		NativeMethodInfoPtr_GetMeleeItemStack_Public_Abstract_Virtual_New_InventoryItemStack_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681227);
		NativeMethodInfoPtr_GetProjectileWeaponItemStack_Public_Abstract_Virtual_New_InventoryItemStack_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681228);
		NativeMethodInfoPtr_GetProjectileItemStack_Public_Abstract_Virtual_New_InventoryItemStack_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681229);
		NativeMethodInfoPtr_IsOrHasAmmoItem_Public_Abstract_Virtual_New_Boolean_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681230);
		NativeMethodInfoPtr_UseAmmoItem_Public_Abstract_Virtual_New_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681231);
		NativeMethodInfoPtr_GetMeleeAttackSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681232);
		NativeMethodInfoPtr_GetProjectileAimSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681233);
		NativeMethodInfoPtr_GetProjectileAttackSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681234);
		NativeMethodInfoPtr_GetAttackHitSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_SurfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681235);
		NativeMethodInfoPtr_GetMeleeAttackAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681236);
		NativeMethodInfoPtr_GetProjectileAttackAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681237);
		NativeMethodInfoPtr_GetProjectileAimAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681238);
		NativeMethodInfoPtr_GetMeleeAimAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681239);
		NativeMethodInfoPtr_GetBlockAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681240);
		NativeMethodInfoPtr_GetBlockHitAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681241);
		NativeMethodInfoPtr_GetItemEquipPoint_Public_Abstract_Virtual_New_EquipPoint_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681242);
		NativeMethodInfoPtr_GetProjectileLaunchSpeed_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681243);
		NativeMethodInfoPtr_GetStaminaExertion_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681244);
		NativeMethodInfoPtr_GetStaminaExertionRate_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681245);
		NativeMethodInfoPtr_IsStaminaBasedProjectileLaunch_Public_Abstract_Virtual_New_Boolean_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681246);
		NativeMethodInfoPtr_TargetHit_Public_Abstract_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681247);
		NativeMethodInfoPtr_AimedAttackFinished_Public_Abstract_Virtual_New_Void_ActionType_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681248);
		NativeMethodInfoPtr_GetProjectileMinRange_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681249);
		NativeMethodInfoPtr_GetProjectileRange_Public_Abstract_Virtual_New_Single_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681250);
		NativeMethodInfoPtr_GetAttackInjuries_Public_Abstract_Virtual_New_List_1_AttackInjuryContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttacker>.NativeClassPtr, 100681251);
	}

	[CallerCount(0)]
	public unsafe virtual DamageValues GetDamageValues(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDamageValues_Public_Abstract_Virtual_New_DamageValues_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DamageValues*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetMeleeAttackRange(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMeleeAttackRange_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetMeleeFullAimTime(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMeleeFullAimTime_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileFullAimTime_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileFullAccuracyAimTime_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetMeleeAttackDuration(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMeleeAttackDuration_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileAttackDuration_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void TakeConditionDamage(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TakeConditionDamage_Public_Abstract_Virtual_New_Void_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItemStack GetMeleeItemStack(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMeleeItemStack_Public_Abstract_Virtual_New_InventoryItemStack_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItemStack GetProjectileWeaponItemStack(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileWeaponItemStack_Public_Abstract_Virtual_New_InventoryItemStack_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItemStack GetProjectileItemStack(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileItemStack_Public_Abstract_Virtual_New_InventoryItemStack_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool IsOrHasAmmoItem(InventoryItemStack stack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsOrHasAmmoItem_Public_Abstract_Virtual_New_Boolean_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UseAmmoItem(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UseAmmoItem_Public_Abstract_Virtual_New_Void_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual SoundEffectType GetMeleeAttackSoundEffect(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMeleeAttackSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SoundEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual SoundEffectType GetProjectileAimSoundEffect(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileAimSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SoundEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual SoundEffectType GetProjectileAttackSoundEffect(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileAttackSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAttackHitSoundEffect_Public_Abstract_Virtual_New_SoundEffectType_ActionType_SurfaceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SoundEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetMeleeAttackAnimationState(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMeleeAttackAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileAttackAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileAimAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetMeleeAimAnimationState(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMeleeAimAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetBlockAnimationState(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBlockAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetBlockHitAnimationState(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBlockHitAnimationState_Public_Abstract_Virtual_New_AnimationState_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual EquipPoint GetItemEquipPoint(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItemEquipPoint_Public_Abstract_Virtual_New_EquipPoint_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileLaunchSpeed_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStaminaExertion_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStaminaExertionRate_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsStaminaBasedProjectileLaunch(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsStaminaBasedProjectileLaunch_Public_Abstract_Virtual_New_Boolean_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void TargetHit(Entity hitEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hitEntity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TargetHit_Public_Abstract_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AimedAttackFinished(ActionType actionType, InventoryItem projectileItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&actionType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)projectileItem);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AimedAttackFinished_Public_Abstract_Virtual_New_Void_ActionType_InventoryItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual float GetProjectileMinRange(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileMinRange_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProjectileRange_Public_Abstract_Virtual_New_Single_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual List<AttackInjuryContainer> GetAttackInjuries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAttackInjuries_Public_Abstract_Virtual_New_List_1_AttackInjuryContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AttackInjuryContainer>>(intPtr) : null;
	}

	public IAttacker(IntPtr pointer)
		: base(pointer)
	{
	}
}

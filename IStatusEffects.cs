using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IStatusEffects : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ApplyStatusEffect_Public_Abstract_Virtual_New_Void_StatusEffect_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveManualStatusEffect_Public_Abstract_Virtual_New_Void_StatusEffectDefinition_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveManualStatusEffect_Public_Abstract_Virtual_New_Void_StatusEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetActiveStatusEffects_Public_Abstract_Virtual_New_Void_ICollection_1_ActiveStatusEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetActionSpeedModifier_Public_Abstract_Virtual_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddActionSpeedModifier_Public_Abstract_Virtual_New_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetActiveStatusEffect_Public_Abstract_Virtual_New_ActiveStatusEffect_StatusEffectDefinition_0;

	static IStatusEffects()
	{
		Il2CppClassPointerStore<IStatusEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IStatusEffects");
		NativeMethodInfoPtr_ApplyStatusEffect_Public_Abstract_Virtual_New_Void_StatusEffect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffects>.NativeClassPtr, 100682016);
		NativeMethodInfoPtr_RemoveManualStatusEffect_Public_Abstract_Virtual_New_Void_StatusEffectDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffects>.NativeClassPtr, 100682017);
		NativeMethodInfoPtr_RemoveManualStatusEffect_Public_Abstract_Virtual_New_Void_StatusEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffects>.NativeClassPtr, 100682018);
		NativeMethodInfoPtr_GetActiveStatusEffects_Public_Abstract_Virtual_New_Void_ICollection_1_ActiveStatusEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffects>.NativeClassPtr, 100682019);
		NativeMethodInfoPtr_GetActionSpeedModifier_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffects>.NativeClassPtr, 100682020);
		NativeMethodInfoPtr_AddActionSpeedModifier_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffects>.NativeClassPtr, 100682021);
		NativeMethodInfoPtr_GetActiveStatusEffect_Public_Abstract_Virtual_New_ActiveStatusEffect_StatusEffectDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStatusEffects>.NativeClassPtr, 100682022);
	}

	[CallerCount(0)]
	public unsafe virtual void ApplyStatusEffect(StatusEffect newEffect, int injuryId = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)newEffect));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryId;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ApplyStatusEffect_Public_Abstract_Virtual_New_Void_StatusEffect_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveManualStatusEffect(StatusEffectDefinition statusEffectDefinition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusEffectDefinition);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveManualStatusEffect_Public_Abstract_Virtual_New_Void_StatusEffectDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveManualStatusEffect(StatusEffect statusEffect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)statusEffect));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveManualStatusEffect_Public_Abstract_Virtual_New_Void_StatusEffect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetActiveStatusEffects(ICollection<ActiveStatusEffect> statusEffectsResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusEffectsResult);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveStatusEffects_Public_Abstract_Virtual_New_Void_ICollection_1_ActiveStatusEffect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual float GetActionSpeedModifier()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActionSpeedModifier_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void AddActionSpeedModifier(float modifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&modifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddActionSpeedModifier_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual ActiveStatusEffect GetActiveStatusEffect(StatusEffectDefinition definition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)definition);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveStatusEffect_Public_Abstract_Virtual_New_ActiveStatusEffect_StatusEffectDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActiveStatusEffect>(intPtr) : null;
	}

	public IStatusEffects(IntPtr pointer)
		: base(pointer)
	{
	}
}

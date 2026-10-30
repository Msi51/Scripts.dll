using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class IEquippedItem : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_Entity_InventoryItem_IEquippedItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEquipperIdleAnimationState_Public_Abstract_Virtual_New_AnimationState_InteractionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEquipperPuttingDownAnimationState_Public_Abstract_Virtual_New_AnimationState_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEquipperInteractionAnimationState_Public_Abstract_Virtual_New_AnimationState_InteractionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlayAnimation_Public_Abstract_Virtual_New_Void_ItemAnimation_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTargetTransformRotationEnabled_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInventoryItem_Public_Abstract_Virtual_New_InventoryItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLiquidPercentage_Public_Abstract_Virtual_New_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLidEnabled_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetWateringEffectEnabled_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSubItemObject_Public_Abstract_Virtual_New_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSubItemObject_Public_Abstract_Virtual_New_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEquipperEntity_Public_Abstract_Virtual_New_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTargetRotation_Public_Abstract_Virtual_New_Void_Quaternion_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTargetRotationToEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTargetRotationToEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_Vector3_Vector3_0;

	static IEquippedItem()
	{
		Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IEquippedItem");
		NativeMethodInfoPtr_SetEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_Entity_InventoryItem_IEquippedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681490);
		NativeMethodInfoPtr_GetEquipperIdleAnimationState_Public_Abstract_Virtual_New_AnimationState_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681491);
		NativeMethodInfoPtr_GetEquipperPuttingDownAnimationState_Public_Abstract_Virtual_New_AnimationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681492);
		NativeMethodInfoPtr_GetEquipperInteractionAnimationState_Public_Abstract_Virtual_New_AnimationState_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681493);
		NativeMethodInfoPtr_PlayAnimation_Public_Abstract_Virtual_New_Void_ItemAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681494);
		NativeMethodInfoPtr_SetTargetTransformRotationEnabled_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681495);
		NativeMethodInfoPtr_GetInventoryItem_Public_Abstract_Virtual_New_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681496);
		NativeMethodInfoPtr_SetLiquidPercentage_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681497);
		NativeMethodInfoPtr_SetLidEnabled_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681498);
		NativeMethodInfoPtr_SetWateringEffectEnabled_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681499);
		NativeMethodInfoPtr_SetSubItemObject_Public_Abstract_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681500);
		NativeMethodInfoPtr_GetSubItemObject_Public_Abstract_Virtual_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681501);
		NativeMethodInfoPtr_GetEquipperEntity_Public_Abstract_Virtual_New_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681502);
		NativeMethodInfoPtr_SetTargetRotation_Public_Abstract_Virtual_New_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681503);
		NativeMethodInfoPtr_SetTargetRotationToEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681504);
		NativeMethodInfoPtr_SetTargetRotationToEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquippedItem>.NativeClassPtr, 100681505);
	}

	[CallerCount(0)]
	public unsafe virtual void SetEquipPoint(EquipPoint equipPoint, Entity equipperEntity, InventoryItem item, IEquippedItem parentEquippedItem = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&equipPoint);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)equipperEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentEquippedItem);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_Entity_InventoryItem_IEquippedItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetEquipperIdleAnimationState(InteractionType interactionType = InteractionType.NONE)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&interactionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEquipperIdleAnimationState_Public_Abstract_Virtual_New_AnimationState_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetEquipperPuttingDownAnimationState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEquipperPuttingDownAnimationState_Public_Abstract_Virtual_New_AnimationState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetEquipperInteractionAnimationState(InteractionType interactionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&interactionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEquipperInteractionAnimationState_Public_Abstract_Virtual_New_AnimationState_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void PlayAnimation(ItemAnimation itemAnimation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&itemAnimation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PlayAnimation_Public_Abstract_Virtual_New_Void_ItemAnimation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetTargetTransformRotationEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetTargetTransformRotationEnabled_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItem GetInventoryItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInventoryItem_Public_Abstract_Virtual_New_InventoryItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItem>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SetLiquidPercentage(float percentage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&percentage);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetLiquidPercentage_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetLidEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetLidEnabled_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetWateringEffectEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetWateringEffectEnabled_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetSubItemObject(GameObject subObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetSubItemObject_Public_Abstract_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual GameObject GetSubItemObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSubItemObject_Public_Abstract_Virtual_New_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity GetEquipperEntity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEquipperEntity_Public_Abstract_Virtual_New_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SetTargetRotation(Quaternion targetRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&targetRotation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetTargetRotation_Public_Abstract_Virtual_New_Void_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetTargetRotationToEquipPoint(EquipPoint equipPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&equipPoint);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetTargetRotationToEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetTargetRotationToEquipPoint(EquipPoint equipPoint, Vector3 rotationOffset, Vector3 positionOffset = default(Vector3))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&equipPoint);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &rotationOffset;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &positionOffset;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetTargetRotationToEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IEquippedItem(IntPtr pointer)
		: base(pointer)
	{
	}
}

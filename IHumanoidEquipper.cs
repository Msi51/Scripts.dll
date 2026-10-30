using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class IHumanoidEquipper : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ShowTemporaryItem_Public_Abstract_Virtual_New_Void_InventoryItem_EquipPoint_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_HideTemporaryItem_Public_Abstract_Virtual_New_Void_InventoryItem_EquipPoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemTransform_Public_Abstract_Virtual_New_Transform_EquipPoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemTransform_Public_Abstract_Virtual_New_Transform_InventorySlot_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemObject_Public_Abstract_Virtual_New_GameObject_InventorySlot_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEquipPointTransform_Public_Abstract_Virtual_New_Transform_EquipPoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEquipPointGameObject_Public_Abstract_Virtual_New_GameObject_EquipPoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEquipPointPositionOffset_Public_Abstract_Virtual_New_Vector3_EquipPoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEquipPointRotationOffset_Public_Abstract_Virtual_New_Quaternion_EquipPoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRootRotation_Public_Abstract_Virtual_New_Quaternion_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetGameObject_Public_Abstract_Virtual_New_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_HideHandItems_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_HideHandItem_Public_Abstract_Virtual_New_Void_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_HideEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_HideOppositeHandItem_Public_Abstract_Virtual_New_Void_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_HideOppositeHandEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearTempEquipPoints_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlayEquippedItemAnimation_Public_Abstract_Virtual_New_Void_EquipPoint_ItemAnimation_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetEquippedItemWateringEffect_Public_Abstract_Virtual_New_Void_EquipPoint_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInteractionAnimationState_Public_Abstract_Virtual_New_AnimationState_EquipPoint_InteractionType_0;

	static IHumanoidEquipper()
	{
		Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IHumanoidEquipper");
		NativeMethodInfoPtr_ShowTemporaryItem_Public_Abstract_Virtual_New_Void_InventoryItem_EquipPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681604);
		NativeMethodInfoPtr_HideTemporaryItem_Public_Abstract_Virtual_New_Void_InventoryItem_EquipPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681605);
		NativeMethodInfoPtr_GetItemTransform_Public_Abstract_Virtual_New_Transform_EquipPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681606);
		NativeMethodInfoPtr_GetItemTransform_Public_Abstract_Virtual_New_Transform_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681607);
		NativeMethodInfoPtr_GetItemObject_Public_Abstract_Virtual_New_GameObject_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681608);
		NativeMethodInfoPtr_GetEquipPointTransform_Public_Abstract_Virtual_New_Transform_EquipPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681609);
		NativeMethodInfoPtr_GetEquipPointGameObject_Public_Abstract_Virtual_New_GameObject_EquipPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681610);
		NativeMethodInfoPtr_GetEquipPointPositionOffset_Public_Abstract_Virtual_New_Vector3_EquipPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681611);
		NativeMethodInfoPtr_GetEquipPointRotationOffset_Public_Abstract_Virtual_New_Quaternion_EquipPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681612);
		NativeMethodInfoPtr_GetRootRotation_Public_Abstract_Virtual_New_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681613);
		NativeMethodInfoPtr_GetGameObject_Public_Abstract_Virtual_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681614);
		NativeMethodInfoPtr_HideHandItems_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681615);
		NativeMethodInfoPtr_HideHandItem_Public_Abstract_Virtual_New_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681616);
		NativeMethodInfoPtr_HideEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681617);
		NativeMethodInfoPtr_HideOppositeHandItem_Public_Abstract_Virtual_New_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681618);
		NativeMethodInfoPtr_HideOppositeHandEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681619);
		NativeMethodInfoPtr_ClearTempEquipPoints_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681620);
		NativeMethodInfoPtr_PlayEquippedItemAnimation_Public_Abstract_Virtual_New_Void_EquipPoint_ItemAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681621);
		NativeMethodInfoPtr_SetEquippedItemWateringEffect_Public_Abstract_Virtual_New_Void_EquipPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681622);
		NativeMethodInfoPtr_GetInteractionAnimationState_Public_Abstract_Virtual_New_AnimationState_EquipPoint_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidEquipper>.NativeClassPtr, 100681623);
	}

	[CallerCount(0)]
	public unsafe virtual void ShowTemporaryItem(InventoryItem item, EquipPoint equipPoint = EquipPoint.NONE, bool useIdleAnimation = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(EquipPoint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &equipPoint;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &useIdleAnimation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShowTemporaryItem_Public_Abstract_Virtual_New_Void_InventoryItem_EquipPoint_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HideTemporaryItem(InventoryItem item, EquipPoint equipPoint = EquipPoint.NONE)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(EquipPoint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &equipPoint;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HideTemporaryItem_Public_Abstract_Virtual_New_Void_InventoryItem_EquipPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Transform GetItemTransform(EquipPoint equipPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&equipPoint);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItemTransform_Public_Abstract_Virtual_New_Transform_EquipPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Transform GetItemTransform(InventorySlot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItemTransform_Public_Abstract_Virtual_New_Transform_InventorySlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameObject GetItemObject(InventorySlot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItemObject_Public_Abstract_Virtual_New_GameObject_InventorySlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Transform GetEquipPointTransform(EquipPoint equipPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&equipPoint);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEquipPointTransform_Public_Abstract_Virtual_New_Transform_EquipPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameObject GetEquipPointGameObject(EquipPoint equipPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&equipPoint);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEquipPointGameObject_Public_Abstract_Virtual_New_GameObject_EquipPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Vector3 GetEquipPointPositionOffset(EquipPoint equipPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&equipPoint);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEquipPointPositionOffset_Public_Abstract_Virtual_New_Vector3_EquipPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Quaternion GetEquipPointRotationOffset(EquipPoint equipPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&equipPoint);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEquipPointRotationOffset_Public_Abstract_Virtual_New_Quaternion_EquipPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Quaternion GetRootRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRootRotation_Public_Abstract_Virtual_New_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual GameObject GetGameObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetGameObject_Public_Abstract_Virtual_New_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void HideHandItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HideHandItems_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HideHandItem(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HideHandItem_Public_Abstract_Virtual_New_Void_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HideEquipPoint(EquipPoint equipPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&equipPoint);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HideEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HideOppositeHandItem(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HideOppositeHandItem_Public_Abstract_Virtual_New_Void_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HideOppositeHandEquipPoint(EquipPoint equipPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&equipPoint);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HideOppositeHandEquipPoint_Public_Abstract_Virtual_New_Void_EquipPoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void ClearTempEquipPoints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClearTempEquipPoints_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void PlayEquippedItemAnimation(EquipPoint equipPoint, ItemAnimation itemAnimation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&equipPoint);
		*(ItemAnimation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &itemAnimation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PlayEquippedItemAnimation_Public_Abstract_Virtual_New_Void_EquipPoint_ItemAnimation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetEquippedItemWateringEffect(EquipPoint equipPoint, bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&equipPoint);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &enabled;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetEquippedItemWateringEffect_Public_Abstract_Virtual_New_Void_EquipPoint_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual AnimationState GetInteractionAnimationState(EquipPoint equipPoint, InteractionType interactionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&equipPoint);
		*(InteractionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &interactionType;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInteractionAnimationState_Public_Abstract_Virtual_New_AnimationState_EquipPoint_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IHumanoidEquipper(IntPtr pointer)
		: base(pointer)
	{
	}
}

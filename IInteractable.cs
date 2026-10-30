using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class IInteractable : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractionType_Public_Abstract_Virtual_New_InteractionType_ActionType_InteractionOrdinality_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainInteractionType_Public_Abstract_Virtual_New_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAlternateInteractionType_Public_Abstract_Virtual_New_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSecondaryInteractionType_Public_Abstract_Virtual_New_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractableTypes_Public_Abstract_Virtual_New_HashSet_1_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanBeInteractedWith_Public_Abstract_Virtual_New_Boolean_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsInventoryUse_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsMovement_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsTurning_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerInteractionDisabled_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerInteractionDisabled_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMainInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAlternateInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInteraction_Public_Abstract_Virtual_New_IInteraction_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActiveInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInteractions_Public_Abstract_Virtual_New_List_1_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPoint_Public_Abstract_Virtual_New_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCenterPosition_Public_Abstract_Virtual_New_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllInteractableTypes_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActiveInteractionEndListener_Public_Abstract_Virtual_New_Void_Action_1_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveInteractionEndListener_Public_Abstract_Virtual_New_Void_Action_1_IInteraction_0;

	static IInteractable()
	{
		Il2CppClassPointerStore<IInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IInteractable");
		NativeMethodInfoPtr_GetInteractionType_Public_Abstract_Virtual_New_InteractionType_ActionType_InteractionOrdinality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681687);
		NativeMethodInfoPtr_GetMainInteractionType_Public_Abstract_Virtual_New_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681688);
		NativeMethodInfoPtr_GetAlternateInteractionType_Public_Abstract_Virtual_New_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681689);
		NativeMethodInfoPtr_GetSecondaryInteractionType_Public_Abstract_Virtual_New_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681690);
		NativeMethodInfoPtr_GetInteractableTypes_Public_Abstract_Virtual_New_HashSet_1_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681691);
		NativeMethodInfoPtr_CanBeInteractedWith_Public_Abstract_Virtual_New_Boolean_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681692);
		NativeMethodInfoPtr_ActiveInteractionPreventsInventoryUse_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681693);
		NativeMethodInfoPtr_ActiveInteractionPreventsMovement_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681694);
		NativeMethodInfoPtr_ActiveInteractionPreventsTurning_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681695);
		NativeMethodInfoPtr_IsPlayerInteractionDisabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681696);
		NativeMethodInfoPtr_SetPlayerInteractionDisabled_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681697);
		NativeMethodInfoPtr_SetMainInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681698);
		NativeMethodInfoPtr_SetAlternateInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681699);
		NativeMethodInfoPtr_RemoveInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681700);
		NativeMethodInfoPtr_AddInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681701);
		NativeMethodInfoPtr_GetActiveInteraction_Public_Abstract_Virtual_New_IInteraction_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681702);
		NativeMethodInfoPtr_AddActiveInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681703);
		NativeMethodInfoPtr_RemoveActiveInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681704);
		NativeMethodInfoPtr_GetActiveInteractions_Public_Abstract_Virtual_New_List_1_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681705);
		NativeMethodInfoPtr_GetClosestPoint_Public_Abstract_Virtual_New_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681706);
		NativeMethodInfoPtr_GetCenterPosition_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681707);
		NativeMethodInfoPtr_ClearAllInteractableTypes_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681708);
		NativeMethodInfoPtr_AddActiveInteractionEndListener_Public_Abstract_Virtual_New_Void_Action_1_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681709);
		NativeMethodInfoPtr_RemoveActiveInteractionEndListener_Public_Abstract_Virtual_New_Void_Action_1_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100681710);
	}

	[CallerCount(0)]
	public unsafe virtual InteractionType GetInteractionType(ActionType actionType, InteractionOrdinality ordinality)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&actionType);
		*(InteractionOrdinality**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ordinality;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInteractionType_Public_Abstract_Virtual_New_InteractionType_ActionType_InteractionOrdinality_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual InteractionType GetMainInteractionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMainInteractionType_Public_Abstract_Virtual_New_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual InteractionType GetAlternateInteractionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAlternateInteractionType_Public_Abstract_Virtual_New_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual InteractionType GetSecondaryInteractionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSecondaryInteractionType_Public_Abstract_Virtual_New_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual HashSet<InteractionType> GetInteractableTypes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInteractableTypes_Public_Abstract_Virtual_New_HashSet_1_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InteractionType>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool CanBeInteractedWith(InteractionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CanBeInteractedWith_Public_Abstract_Virtual_New_Boolean_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ActiveInteractionPreventsInventoryUse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ActiveInteractionPreventsInventoryUse_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ActiveInteractionPreventsMovement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ActiveInteractionPreventsMovement_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ActiveInteractionPreventsTurning()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ActiveInteractionPreventsTurning_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsPlayerInteractionDisabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsPlayerInteractionDisabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetPlayerInteractionDisabled(bool disabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetPlayerInteractionDisabled_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetMainInteractionType(InteractionType interactionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&interactionType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetMainInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetAlternateInteractionType(InteractionType interactionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&interactionType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetAlternateInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveInteractionType(InteractionType interactionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&interactionType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddInteractionType(InteractionType interactionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&interactionType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddInteractionType_Public_Abstract_Virtual_New_Void_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual IInteraction GetActiveInteraction(InteractionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveInteraction_Public_Abstract_Virtual_New_IInteraction_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void AddActiveInteraction(IInteraction interaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddActiveInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveActiveInteraction(IInteraction interaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveActiveInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual List<IInteraction> GetActiveInteractions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveInteractions_Public_Abstract_Virtual_New_List_1_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IInteraction>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Vector3 GetClosestPoint(Vector3 sourcePosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sourcePosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetClosestPoint_Public_Abstract_Virtual_New_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Vector3 GetCenterPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCenterPosition_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void ClearAllInteractableTypes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClearAllInteractableTypes_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddActiveInteractionEndListener(Il2CppSystem.Action<IInteraction> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddActiveInteractionEndListener_Public_Abstract_Virtual_New_Void_Action_1_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveActiveInteractionEndListener(Il2CppSystem.Action<IInteraction> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveActiveInteractionEndListener_Public_Abstract_Virtual_New_Void_Action_1_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IInteractable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

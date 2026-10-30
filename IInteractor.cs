using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class IInteractor : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllInteractorTypes_Public_Abstract_Virtual_New_Void_HashSet_1_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentInteractionTypes_Public_Abstract_Virtual_New_Void_ActionType_InteractionOrdinality_List_1_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPotentialInteractions_Public_Abstract_Virtual_New_Void_IInteraction_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPotentialAlternateInteractions_Public_Abstract_Virtual_New_Void_IInteraction_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActiveInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInteractions_Public_Abstract_Virtual_New_List_1_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInteraction_Public_Abstract_Virtual_New_IInteraction_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInteraction_Public_Abstract_Virtual_New_IInteraction_ICollection_1_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsInventoryUse_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsSelection_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsMovement_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsTurning_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPotentialInteractions_Public_Abstract_Virtual_New_ValueTuple_2_IInteraction_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPotentialAlternateInteractions_Public_Abstract_Virtual_New_ValueTuple_2_IInteraction_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetQueuedInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndQueuedInteractionOnStart_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQueuedInteraction_Public_Abstract_Virtual_New_QueuedInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPoint_Public_Abstract_Virtual_New_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActiveInteractionEndListener_Public_Abstract_Virtual_New_Void_Action_1_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveInteractionEndListener_Public_Abstract_Virtual_New_Void_Action_1_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLastInteractionResult_Public_Abstract_Virtual_New_Void_InteractionType_InteractionResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastInteractionResult_Public_Abstract_Virtual_New_InteractionResult_InteractionType_0;

	static IInteractor()
	{
		Il2CppClassPointerStore<IInteractor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IInteractor");
		NativeMethodInfoPtr_GetAllInteractorTypes_Public_Abstract_Virtual_New_Void_HashSet_1_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681711);
		NativeMethodInfoPtr_GetCurrentInteractionTypes_Public_Abstract_Virtual_New_Void_ActionType_InteractionOrdinality_List_1_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681712);
		NativeMethodInfoPtr_SetPotentialInteractions_Public_Abstract_Virtual_New_Void_IInteraction_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681713);
		NativeMethodInfoPtr_SetPotentialAlternateInteractions_Public_Abstract_Virtual_New_Void_IInteraction_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681714);
		NativeMethodInfoPtr_AddActiveInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681715);
		NativeMethodInfoPtr_RemoveActiveInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681716);
		NativeMethodInfoPtr_GetActiveInteractions_Public_Abstract_Virtual_New_List_1_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681717);
		NativeMethodInfoPtr_GetActiveInteraction_Public_Abstract_Virtual_New_IInteraction_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681718);
		NativeMethodInfoPtr_GetActiveInteraction_Public_Abstract_Virtual_New_IInteraction_ICollection_1_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681719);
		NativeMethodInfoPtr_ActiveInteractionPreventsInventoryUse_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681720);
		NativeMethodInfoPtr_ActiveInteractionPreventsSelection_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681721);
		NativeMethodInfoPtr_ActiveInteractionPreventsMovement_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681722);
		NativeMethodInfoPtr_ActiveInteractionPreventsTurning_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681723);
		NativeMethodInfoPtr_GetPotentialInteractions_Public_Abstract_Virtual_New_ValueTuple_2_IInteraction_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681724);
		NativeMethodInfoPtr_GetPotentialAlternateInteractions_Public_Abstract_Virtual_New_ValueTuple_2_IInteraction_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681725);
		NativeMethodInfoPtr_SetQueuedInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681726);
		NativeMethodInfoPtr_EndQueuedInteractionOnStart_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681727);
		NativeMethodInfoPtr_GetQueuedInteraction_Public_Abstract_Virtual_New_QueuedInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681728);
		NativeMethodInfoPtr_GetClosestPoint_Public_Abstract_Virtual_New_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681729);
		NativeMethodInfoPtr_AddActiveInteractionEndListener_Public_Abstract_Virtual_New_Void_Action_1_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681730);
		NativeMethodInfoPtr_RemoveActiveInteractionEndListener_Public_Abstract_Virtual_New_Void_Action_1_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681731);
		NativeMethodInfoPtr_SetLastInteractionResult_Public_Abstract_Virtual_New_Void_InteractionType_InteractionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681732);
		NativeMethodInfoPtr_GetLastInteractionResult_Public_Abstract_Virtual_New_InteractionResult_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractor>.NativeClassPtr, 100681733);
	}

	[CallerCount(0)]
	public unsafe virtual void GetAllInteractorTypes(HashSet<InteractionType> allInteractionTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allInteractionTypes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAllInteractorTypes_Public_Abstract_Virtual_New_Void_HashSet_1_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetCurrentInteractionTypes(ActionType actionType, InteractionOrdinality ordinality, List<InteractionType> resultInteractions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&actionType);
		*(InteractionOrdinality**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ordinality;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultInteractions);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCurrentInteractionTypes_Public_Abstract_Virtual_New_Void_ActionType_InteractionOrdinality_List_1_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetPotentialInteractions(IInteraction primaryInteraction, IInteraction secondaryInteraction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)primaryInteraction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)secondaryInteraction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetPotentialInteractions_Public_Abstract_Virtual_New_Void_IInteraction_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetPotentialAlternateInteractions(IInteraction primaryInteraction, IInteraction secondaryInteraction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)primaryInteraction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)secondaryInteraction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetPotentialAlternateInteractions_Public_Abstract_Virtual_New_Void_IInteraction_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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
	public unsafe virtual IInteraction GetActiveInteraction(ICollection<InteractionType> type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveInteraction_Public_Abstract_Virtual_New_IInteraction_ICollection_1_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
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
	public unsafe virtual bool ActiveInteractionPreventsSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ActiveInteractionPreventsSelection_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
	public unsafe virtual Il2CppSystem.ValueTuple<IInteraction, IInteraction> GetPotentialInteractions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPotentialInteractions_Public_Abstract_Virtual_New_ValueTuple_2_IInteraction_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<IInteraction, IInteraction>(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppSystem.ValueTuple<IInteraction, IInteraction> GetPotentialAlternateInteractions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPotentialAlternateInteractions_Public_Abstract_Virtual_New_ValueTuple_2_IInteraction_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<IInteraction, IInteraction>(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual void SetQueuedInteraction(IInteraction interaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetQueuedInteraction_Public_Abstract_Virtual_New_Void_IInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void EndQueuedInteractionOnStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EndQueuedInteractionOnStart_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual QueuedInteraction GetQueuedInteraction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetQueuedInteraction_Public_Abstract_Virtual_New_QueuedInteraction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QueuedInteraction>(intPtr) : null;
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

	[CallerCount(0)]
	public unsafe virtual void SetLastInteractionResult(InteractionType type, InteractionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetLastInteractionResult_Public_Abstract_Virtual_New_Void_InteractionType_InteractionResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual InteractionResult GetLastInteractionResult(InteractionType interactionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&interactionType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetLastInteractionResult_Public_Abstract_Virtual_New_InteractionResult_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InteractionResult(pointer);
	}

	public IInteractor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

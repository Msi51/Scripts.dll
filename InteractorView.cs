using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class InteractorView : BaseView
{
	private static readonly System.IntPtr NativeFieldInfoPtr_attackInteractionTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseInteractorInteractions;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeInteractions;

	private static readonly System.IntPtr NativeFieldInfoPtr_potentialPrimaryInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_potentialSecondaryInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_potentialAlternatePrimaryInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_potentialAlternateSecondaryInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_rigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryHolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeInteractionEndListeners;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastInteractionResults;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deactivated_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllInteractorTypes_Public_Virtual_Final_New_Void_HashSet_1_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentInteractionTypes_Public_Virtual_Final_New_Void_ActionType_InteractionOrdinality_List_1_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInteraction_Public_Virtual_Final_New_IInteraction_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInteraction_Public_Virtual_Final_New_IInteraction_ICollection_1_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsInventoryUse_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsSelection_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsMovement_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveInteractionPreventsTurning_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActiveInteraction_Public_Virtual_Final_New_Void_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveInteraction_Public_Virtual_Final_New_Void_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveInteractions_Public_Virtual_Final_New_List_1_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPotentialInteractions_Public_Virtual_Final_New_Void_IInteraction_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPotentialAlternateInteractions_Public_Virtual_Final_New_Void_IInteraction_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPotentialInteractions_Public_Virtual_Final_New_ValueTuple_2_IInteraction_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPotentialAlternateInteractions_Public_Virtual_Final_New_ValueTuple_2_IInteraction_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetQueuedInteraction_Public_Virtual_Final_New_Void_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndQueuedInteractionOnStart_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQueuedInteraction_Public_Virtual_Final_New_QueuedInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPoint_Public_Virtual_Final_New_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActiveInteractionEndListener_Public_Virtual_Final_New_Void_Action_1_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveInteractionEndListener_Public_Virtual_Final_New_Void_Action_1_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLastInteractionResult_Public_Virtual_Final_New_Void_InteractionType_InteractionResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastInteractionResult_Public_Virtual_Final_New_InteractionResult_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static HashSet<InteractionType> attackInteractionTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_attackInteractionTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InteractionType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_attackInteractionTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe SerializableEnumListField<InteractionType> baseInteractorInteractions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseInteractorInteractions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializableEnumListField<InteractionType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseInteractorInteractions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableEnumListField));
		}
	}

	public unsafe List<IInteraction> activeInteractions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInteractions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IInteraction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInteractions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe IInteraction potentialPrimaryInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialPrimaryInteraction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialPrimaryInteraction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction));
		}
	}

	public unsafe IInteraction potentialSecondaryInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialSecondaryInteraction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialSecondaryInteraction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction));
		}
	}

	public unsafe IInteraction potentialAlternatePrimaryInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialAlternatePrimaryInteraction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialAlternatePrimaryInteraction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction));
		}
	}

	public unsafe IInteraction potentialAlternateSecondaryInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialAlternateSecondaryInteraction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potentialAlternateSecondaryInteraction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction));
		}
	}

	public unsafe QueuedInteraction queuedInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedInteraction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QueuedInteraction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedInteraction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queuedInteraction));
		}
	}

	public unsafe Rigidbody rigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rigidbody)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody));
		}
	}

	public unsafe IInventoryHolder inventoryHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryHolder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryHolder));
		}
	}

	public unsafe List<Il2CppSystem.Action<IInteraction>> activeInteractionEndListeners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInteractionEndListeners);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Action<IInteraction>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeInteractionEndListeners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<InteractionType, InteractionResult> lastInteractionResults
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastInteractionResults);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InteractionType, InteractionResult>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastInteractionResults)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static InteractorView()
	{
		Il2CppClassPointerStore<InteractorView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InteractorView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractorView>.NativeClassPtr);
		NativeFieldInfoPtr_attackInteractionTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "attackInteractionTypes");
		NativeFieldInfoPtr_baseInteractorInteractions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "baseInteractorInteractions");
		NativeFieldInfoPtr_activeInteractions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "activeInteractions");
		NativeFieldInfoPtr_potentialPrimaryInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "potentialPrimaryInteraction");
		NativeFieldInfoPtr_potentialSecondaryInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "potentialSecondaryInteraction");
		NativeFieldInfoPtr_potentialAlternatePrimaryInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "potentialAlternatePrimaryInteraction");
		NativeFieldInfoPtr_potentialAlternateSecondaryInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "potentialAlternateSecondaryInteraction");
		NativeFieldInfoPtr_queuedInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "queuedInteraction");
		NativeFieldInfoPtr_rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "rigidbody");
		NativeFieldInfoPtr_inventoryHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "inventoryHolder");
		NativeFieldInfoPtr_activeInteractionEndListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "activeInteractionEndListeners");
		NativeFieldInfoPtr_lastInteractionResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, "lastInteractionResults");
		NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681089);
		NativeMethodInfoPtr_InitializeSerializableFields_FamOrAssem_Virtual_Void_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681090);
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681091);
		NativeMethodInfoPtr_Deactivated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681092);
		NativeMethodInfoPtr_GetAllInteractorTypes_Public_Virtual_Final_New_Void_HashSet_1_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681093);
		NativeMethodInfoPtr_GetCurrentInteractionTypes_Public_Virtual_Final_New_Void_ActionType_InteractionOrdinality_List_1_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681094);
		NativeMethodInfoPtr_GetActiveInteraction_Public_Virtual_Final_New_IInteraction_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681095);
		NativeMethodInfoPtr_GetActiveInteraction_Public_Virtual_Final_New_IInteraction_ICollection_1_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681096);
		NativeMethodInfoPtr_ActiveInteractionPreventsInventoryUse_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681097);
		NativeMethodInfoPtr_ActiveInteractionPreventsSelection_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681098);
		NativeMethodInfoPtr_ActiveInteractionPreventsMovement_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681099);
		NativeMethodInfoPtr_ActiveInteractionPreventsTurning_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681100);
		NativeMethodInfoPtr_AddActiveInteraction_Public_Virtual_Final_New_Void_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681101);
		NativeMethodInfoPtr_RemoveActiveInteraction_Public_Virtual_Final_New_Void_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681102);
		NativeMethodInfoPtr_GetActiveInteractions_Public_Virtual_Final_New_List_1_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681103);
		NativeMethodInfoPtr_SetPotentialInteractions_Public_Virtual_Final_New_Void_IInteraction_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681104);
		NativeMethodInfoPtr_SetPotentialAlternateInteractions_Public_Virtual_Final_New_Void_IInteraction_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681105);
		NativeMethodInfoPtr_GetPotentialInteractions_Public_Virtual_Final_New_ValueTuple_2_IInteraction_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681106);
		NativeMethodInfoPtr_GetPotentialAlternateInteractions_Public_Virtual_Final_New_ValueTuple_2_IInteraction_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681107);
		NativeMethodInfoPtr_SetQueuedInteraction_Public_Virtual_Final_New_Void_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681108);
		NativeMethodInfoPtr_EndQueuedInteractionOnStart_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681109);
		NativeMethodInfoPtr_GetQueuedInteraction_Public_Virtual_Final_New_QueuedInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681110);
		NativeMethodInfoPtr_GetClosestPoint_Public_Virtual_Final_New_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681111);
		NativeMethodInfoPtr_AddActiveInteractionEndListener_Public_Virtual_Final_New_Void_Action_1_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681112);
		NativeMethodInfoPtr_RemoveActiveInteractionEndListener_Public_Virtual_Final_New_Void_Action_1_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681113);
		NativeMethodInfoPtr_SetLastInteractionResult_Public_Virtual_Final_New_Void_InteractionType_InteractionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681114);
		NativeMethodInfoPtr_GetLastInteractionResult_Public_Virtual_Final_New_InteractionResult_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681115);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractorView>.NativeClassPtr, 100681116);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248362, XrefRangeEnd = 248364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248364, XrefRangeEnd = 248369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248369, XrefRangeEnd = 248399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248399, XrefRangeEnd = 248403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Deactivated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Deactivated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248403, XrefRangeEnd = 248461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void GetAllInteractorTypes(HashSet<InteractionType> allInteractionTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allInteractionTypes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllInteractorTypes_Public_Virtual_Final_New_Void_HashSet_1_InteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248461, XrefRangeEnd = 248518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void GetCurrentInteractionTypes(ActionType actionType, InteractionOrdinality ordinality, List<InteractionType> resultInteractions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&actionType);
		*(InteractionOrdinality**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ordinality;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultInteractions);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentInteractionTypes_Public_Virtual_Final_New_Void_ActionType_InteractionOrdinality_List_1_InteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248518, XrefRangeEnd = 248531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IInteraction GetActiveInteraction(InteractionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveInteraction_Public_Virtual_Final_New_IInteraction_InteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248531, XrefRangeEnd = 248547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IInteraction GetActiveInteraction(ICollection<InteractionType> types)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveInteraction_Public_Virtual_Final_New_IInteraction_ICollection_1_InteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248547, XrefRangeEnd = 248560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ActiveInteractionPreventsInventoryUse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActiveInteractionPreventsInventoryUse_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248560, XrefRangeEnd = 248573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ActiveInteractionPreventsSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActiveInteractionPreventsSelection_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248573, XrefRangeEnd = 248586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ActiveInteractionPreventsMovement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActiveInteractionPreventsMovement_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248586, XrefRangeEnd = 248599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool ActiveInteractionPreventsTurning()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActiveInteractionPreventsTurning_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248599, XrefRangeEnd = 248603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddActiveInteraction(IInteraction interaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActiveInteraction_Public_Virtual_Final_New_Void_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248603, XrefRangeEnd = 248645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveActiveInteraction(IInteraction interaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveActiveInteraction_Public_Virtual_Final_New_Void_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 19179, RefRangeEnd = 19194, XrefRangeStart = 19179, XrefRangeEnd = 19194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual List<IInteraction> GetActiveInteractions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveInteractions_Public_Virtual_Final_New_List_1_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IInteraction>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248645, XrefRangeEnd = 248647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetPotentialInteractions(IInteraction primaryInteraction, IInteraction secondaryInteraction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)primaryInteraction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)secondaryInteraction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPotentialInteractions_Public_Virtual_Final_New_Void_IInteraction_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248647, XrefRangeEnd = 248649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetPotentialAlternateInteractions(IInteraction primaryInteraction, IInteraction secondaryInteraction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)primaryInteraction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)secondaryInteraction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPotentialAlternateInteractions_Public_Virtual_Final_New_Void_IInteraction_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248649, XrefRangeEnd = 248652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.ValueTuple<IInteraction, IInteraction> GetPotentialInteractions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPotentialInteractions_Public_Virtual_Final_New_ValueTuple_2_IInteraction_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<IInteraction, IInteraction>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248652, XrefRangeEnd = 248655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.ValueTuple<IInteraction, IInteraction> GetPotentialAlternateInteractions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPotentialAlternateInteractions_Public_Virtual_Final_New_ValueTuple_2_IInteraction_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<IInteraction, IInteraction>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248655, XrefRangeEnd = 248684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetQueuedInteraction(IInteraction interaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetQueuedInteraction_Public_Virtual_Final_New_Void_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void EndQueuedInteractionOnStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndQueuedInteractionOnStart_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual QueuedInteraction GetQueuedInteraction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQueuedInteraction_Public_Virtual_Final_New_QueuedInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QueuedInteraction>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248684, XrefRangeEnd = 248692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Vector3 GetClosestPoint(Vector3 sourcePosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sourcePosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClosestPoint_Public_Virtual_Final_New_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248692, XrefRangeEnd = 248696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddActiveInteractionEndListener(Il2CppSystem.Action<IInteraction> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActiveInteractionEndListener_Public_Virtual_Final_New_Void_Action_1_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248696, XrefRangeEnd = 248700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveActiveInteractionEndListener(Il2CppSystem.Action<IInteraction> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveActiveInteractionEndListener_Public_Virtual_Final_New_Void_Action_1_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248700, XrefRangeEnd = 248703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetLastInteractionResult(InteractionType type, InteractionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLastInteractionResult_Public_Virtual_Final_New_Void_InteractionType_InteractionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248703, XrefRangeEnd = 248706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual InteractionResult GetLastInteractionResult(InteractionType interactionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&interactionType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastInteractionResult_Public_Virtual_Final_New_InteractionResult_InteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InteractionResult(pointer);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractorView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractorView>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InteractorView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

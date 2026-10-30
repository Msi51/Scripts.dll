using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using strange.extensions.injector.api;
using UnityEngine;

public class SelectDialogResponseEventHandler : NetworkedGameEventHandler<SelectDialogResponseEventParams, SelectDialogResponseEventResult>
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dialogManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectiveManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_analyticsManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_DYNAMIC_FETCH_TASK_IDENTIFIER;

	private static readonly System.IntPtr NativeFieldInfoPtr_DYNAMIC_HAND_IN_TASK_IDENTIFIER;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_SelectDialogResponseEventResult_Int32_SelectDialogResponseEventParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleItemConditions_Private_List_1_ValueTuple_2_Int32_Int32_Entity_DialogLink_Int32_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeItemsFromInventory_Private_List_1_ValueTuple_2_Int32_Int32_Entity_List_1_ValueTuple_2_InventoryItem_Int32_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleReceivedItems_Private_List_1_ValueTuple_2_Int32_Int32_Entity_DialogLink_Int32_IDialogConverser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleDiscoveries_Private_List_1_String_Entity_DialogLink_Int32_IDialogConverser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleMapMarkers_Private_Boolean_Entity_DialogLinkDestination_Int32_IDialogConverser_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNearbyEntityLocationHint_Private_DialogLocationHint_Entity_Entity_DialogLinkDestination_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tryFindNearbyEntityByIdentifier_Private_Boolean_World_Vector3_List_1_String_Single_byref_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCardinalDirectionIdentifier_Private_String_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleUpdatedObjective_Private_Void_Entity_DialogLink_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleWorldEvent_Private_Void_World_DialogLink_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getItemRequest_Private_AIItemRequest_Entity_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleItemRequestAccept_Private_Boolean_WorldPlayer_Entity_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleNpcRequestHandIn_Private_ValueTuple_2_List_1_ValueTuple_2_Int32_Int32_List_1_ValueTuple_2_Int32_Int32_WorldPlayer_Entity_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_transferCoinsFromNpcToPlayer_Private_Void_Entity_Entity_Int32_List_1_ValueTuple_2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_transferCoinDenomination_Private_Int32_Inventory_Entity_String_Int32_Int32_List_1_ValueTuple_2_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeItemQuantity_Private_Int32_Inventory_InventoryItem_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addItemToInventoryOrDrop_Private_Void_Entity_InventoryItem_Int32_List_1_ValueTuple_2_Int32_Int32_0;

	public unsafe IDialogManager dialogManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDialogManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogManager));
		}
	}

	public unsafe IInventoryManager inventoryManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager));
		}
	}

	public unsafe ICookingManager cookingManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICookingManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cookingManager));
		}
	}

	public unsafe IObjectiveManager objectiveManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IObjectiveManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveManager));
		}
	}

	public new unsafe IPlayerManager playerManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPlayerManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerManager));
		}
	}

	public unsafe IAnalyticsManager analyticsManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_analyticsManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAnalyticsManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_analyticsManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)analyticsManager));
		}
	}

	public unsafe IInteractionManager interactionManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteractionManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionManager));
		}
	}

	public unsafe IWorldManager worldManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWorldManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldManager));
		}
	}

	public unsafe IAIManager aiManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAIManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iAIManager));
		}
	}

	public unsafe static string DYNAMIC_FETCH_TASK_IDENTIFIER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DYNAMIC_FETCH_TASK_IDENTIFIER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DYNAMIC_FETCH_TASK_IDENTIFIER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DYNAMIC_HAND_IN_TASK_IDENTIFIER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DYNAMIC_HAND_IN_TASK_IDENTIFIER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DYNAMIC_HAND_IN_TASK_IDENTIFIER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static SelectDialogResponseEventHandler()
	{
		Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SelectDialogResponseEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr);
		NativeFieldInfoPtr_dialogManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "dialogManager");
		NativeFieldInfoPtr_inventoryManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "inventoryManager");
		NativeFieldInfoPtr_cookingManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "cookingManager");
		NativeFieldInfoPtr_objectiveManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "objectiveManager");
		NativeFieldInfoPtr_playerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "playerManager");
		NativeFieldInfoPtr_analyticsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "analyticsManager");
		NativeFieldInfoPtr_interactionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "interactionManager");
		NativeFieldInfoPtr_worldManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "worldManager");
		NativeFieldInfoPtr_aiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "aiManager");
		NativeFieldInfoPtr_DYNAMIC_FETCH_TASK_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "DYNAMIC_FETCH_TASK_IDENTIFIER");
		NativeFieldInfoPtr_DYNAMIC_HAND_IN_TASK_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, "DYNAMIC_HAND_IN_TASK_IDENTIFIER");
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670157);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670158);
		NativeMethodInfoPtr_Execute_Public_Virtual_SelectDialogResponseEventResult_Int32_SelectDialogResponseEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670159);
		NativeMethodInfoPtr_handleItemConditions_Private_List_1_ValueTuple_2_Int32_Int32_Entity_DialogLink_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670160);
		NativeMethodInfoPtr_removeItemsFromInventory_Private_List_1_ValueTuple_2_Int32_Int32_Entity_List_1_ValueTuple_2_InventoryItem_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670161);
		NativeMethodInfoPtr_handleReceivedItems_Private_List_1_ValueTuple_2_Int32_Int32_Entity_DialogLink_Int32_IDialogConverser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670162);
		NativeMethodInfoPtr_handleDiscoveries_Private_List_1_String_Entity_DialogLink_Int32_IDialogConverser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670163);
		NativeMethodInfoPtr_handleMapMarkers_Private_Boolean_Entity_DialogLinkDestination_Int32_IDialogConverser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670164);
		NativeMethodInfoPtr_getNearbyEntityLocationHint_Private_DialogLocationHint_Entity_Entity_DialogLinkDestination_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670165);
		NativeMethodInfoPtr_tryFindNearbyEntityByIdentifier_Private_Boolean_World_Vector3_List_1_String_Single_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670166);
		NativeMethodInfoPtr_getCardinalDirectionIdentifier_Private_String_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670167);
		NativeMethodInfoPtr_handleUpdatedObjective_Private_Void_Entity_DialogLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670168);
		NativeMethodInfoPtr_handleWorldEvent_Private_Void_World_DialogLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670169);
		NativeMethodInfoPtr_getItemRequest_Private_AIItemRequest_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670170);
		NativeMethodInfoPtr_handleItemRequestAccept_Private_Boolean_WorldPlayer_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670171);
		NativeMethodInfoPtr_handleNpcRequestHandIn_Private_ValueTuple_2_List_1_ValueTuple_2_Int32_Int32_List_1_ValueTuple_2_Int32_Int32_WorldPlayer_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670172);
		NativeMethodInfoPtr_transferCoinsFromNpcToPlayer_Private_Void_Entity_Entity_Int32_List_1_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670173);
		NativeMethodInfoPtr_transferCoinDenomination_Private_Int32_Inventory_Entity_String_Int32_Int32_List_1_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670174);
		NativeMethodInfoPtr_removeItemQuantity_Private_Int32_Inventory_InventoryItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670175);
		NativeMethodInfoPtr_addItemToInventoryOrDrop_Private_Void_Entity_InventoryItem_Int32_List_1_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr, 100670176);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114356, RefRangeEnd = 114357, XrefRangeStart = 114353, XrefRangeEnd = 114356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SelectDialogResponseEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectDialogResponseEventHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114357, XrefRangeEnd = 114394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114394, XrefRangeEnd = 114578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override SelectDialogResponseEventResult Execute(int clientId, SelectDialogResponseEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&clientId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventParams));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_SelectDialogResponseEventResult_Int32_SelectDialogResponseEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new SelectDialogResponseEventResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114621, RefRangeEnd = 114622, XrefRangeStart = 114578, XrefRangeEnd = 114621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Il2CppSystem.ValueTuple<int, int>> handleItemConditions(Entity playerEntity, DialogLink link, int nextNodeId, Entity converserEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)link);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nextNodeId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)converserEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleItemConditions_Private_List_1_ValueTuple_2_Int32_Int32_Entity_DialogLink_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<int, int>>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 114720, RefRangeEnd = 114722, XrefRangeStart = 114622, XrefRangeEnd = 114720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Il2CppSystem.ValueTuple<int, int>> removeItemsFromInventory(Entity playerEntity, List<Il2CppSystem.ValueTuple<InventoryItem, int>> itemsToRemove, Entity converserEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemsToRemove);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)converserEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeItemsFromInventory_Private_List_1_ValueTuple_2_Int32_Int32_Entity_List_1_ValueTuple_2_InventoryItem_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<int, int>>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114807, RefRangeEnd = 114808, XrefRangeStart = 114722, XrefRangeEnd = 114807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Il2CppSystem.ValueTuple<int, int>> handleReceivedItems(Entity playerEntity, DialogLink link, int nextNodeId, IDialogConverser dialogConverser)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)link);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nextNodeId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogConverser);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleReceivedItems_Private_List_1_ValueTuple_2_Int32_Int32_Entity_DialogLink_Int32_IDialogConverser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<int, int>>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114847, RefRangeEnd = 114848, XrefRangeStart = 114808, XrefRangeEnd = 114847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> handleDiscoveries(Entity playerEntity, DialogLink link, int nextNodeId, IDialogConverser dialogConverser)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)link);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nextNodeId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogConverser);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleDiscoveries_Private_List_1_String_Entity_DialogLink_Int32_IDialogConverser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114887, RefRangeEnd = 114888, XrefRangeStart = 114848, XrefRangeEnd = 114887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool handleMapMarkers(Entity playerEntity, DialogLinkDestination destination, int nextNodeId, IDialogConverser dialogConverser)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nextNodeId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogConverser);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleMapMarkers_Private_Boolean_Entity_DialogLinkDestination_Int32_IDialogConverser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114923, RefRangeEnd = 114924, XrefRangeStart = 114888, XrefRangeEnd = 114923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DialogLocationHint getNearbyEntityLocationHint(Entity playerEntity, Entity converserEntity, DialogLinkDestination destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)converserEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNearbyEntityLocationHint_Private_DialogLocationHint_Entity_Entity_DialogLinkDestination_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogLocationHint>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114959, RefRangeEnd = 114960, XrefRangeStart = 114924, XrefRangeEnd = 114959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool tryFindNearbyEntityByIdentifier(World world, Vector3 center, List<string> identifiers, float range, out Entity foundEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tryFindNearbyEntityByIdentifier_Private_Boolean_World_Vector3_List_1_String_Single_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		foundEntity = ((num3 == 0) ? null : new Entity(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114960, XrefRangeEnd = 114966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getCardinalDirectionIdentifier(Vector3 fromPosition, Vector3 toPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&fromPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCardinalDirectionIdentifier_Private_String_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115015, RefRangeEnd = 115016, XrefRangeStart = 114966, XrefRangeEnd = 115015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleUpdatedObjective(Entity playerEntity, DialogLink link)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)link);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleUpdatedObjective_Private_Void_Entity_DialogLink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115016, XrefRangeEnd = 115026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleWorldEvent(World world, DialogLink link)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)link);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleWorldEvent_Private_Void_World_DialogLink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115026, XrefRangeEnd = 115051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIItemRequest getItemRequest(Entity playerEntity, Entity converserEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)converserEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getItemRequest_Private_AIItemRequest_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIItemRequest>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115118, RefRangeEnd = 115119, XrefRangeStart = 115051, XrefRangeEnd = 115118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool handleItemRequestAccept(WorldPlayer worldPlayer, Entity playerEntity, Entity converserEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)converserEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleItemRequestAccept_Private_Boolean_WorldPlayer_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115239, RefRangeEnd = 115240, XrefRangeStart = 115119, XrefRangeEnd = 115239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<List<Il2CppSystem.ValueTuple<int, int>>, List<Il2CppSystem.ValueTuple<int, int>>> handleNpcRequestHandIn(WorldPlayer worldPlayer, Entity playerEntity, Entity converserEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)converserEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleNpcRequestHandIn_Private_ValueTuple_2_List_1_ValueTuple_2_Int32_Int32_List_1_ValueTuple_2_Int32_Int32_WorldPlayer_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<List<Il2CppSystem.ValueTuple<int, int>>, List<Il2CppSystem.ValueTuple<int, int>>>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115240, XrefRangeEnd = 115255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void transferCoinsFromNpcToPlayer(Entity converserEntity, Entity playerEntity, int maxPennies, List<Il2CppSystem.ValueTuple<int, int>> rewardItems)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)converserEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxPennies;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rewardItems);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_transferCoinsFromNpcToPlayer_Private_Void_Entity_Entity_Int32_List_1_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 115262, RefRangeEnd = 115268, XrefRangeStart = 115255, XrefRangeEnd = 115262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int transferCoinDenomination(Inventory fromInventory, Entity playerEntity, string coinItemIdentifier, int denominationPennies, int remainingPennies, List<Il2CppSystem.ValueTuple<int, int>> rewardItems)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromInventory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(coinItemIdentifier);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &denominationPennies;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &remainingPennies;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rewardItems);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_transferCoinDenomination_Private_Int32_Inventory_Entity_String_Int32_Int32_List_1_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115268, XrefRangeEnd = 115270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int removeItemQuantity(Inventory inventory, InventoryItem item, int quantity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &quantity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeItemQuantity_Private_Int32_Inventory_InventoryItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115290, RefRangeEnd = 115291, XrefRangeStart = 115270, XrefRangeEnd = 115290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addItemToInventoryOrDrop(Entity playerEntity, InventoryItem item, int amount, List<Il2CppSystem.ValueTuple<int, int>> rewardItems)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rewardItems);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addItemToInventoryOrDrop_Private_Void_Entity_InventoryItem_Int32_List_1_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SelectDialogResponseEventHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

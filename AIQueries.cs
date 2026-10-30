using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public static class AIQueries : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ATTACK_TARGET_WATER_DEPTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_avoidanceRotations;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERACTION_TYPE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SEARCH_DISTANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_HARVESTABLE_CARCASS_RADIUS;

	private static readonly System.IntPtr NativeFieldInfoPtr_HOME_STORABLE_COOKED_MEAT_RADIUS;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsReachable_Public_Static_Boolean_AIContext_Entity_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearbyLightEmitter_Public_Static_Entity_World_Vector3_IAIControlled_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckLightEmitterPresent_Public_Static_Boolean_World_Vector3_IAIControlled_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArePointsValidOnRoute_Public_Static_Boolean_Entity_IAIControlled_World_Vector3_Boolean_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindValidPosition_Public_Static_Boolean_AIContext_Boolean_Single_Single_Func_4_World_Entity_Vector3_Boolean_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindValidPosition_Public_Static_Boolean_AIContext_Func_3_AIContext_Int32_ValueTuple_2_Vector3_Quaternion_Func_3_AIContext_Vector3_Boolean_byref_Vector3_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldApproachTrap_Public_Static_Boolean_World_Entity_byref_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindClosestLand_Public_Static_Boolean_World_Vector3_byref_Vector3_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldAvoidTarget_Public_Static_Boolean_Entity_Entity_ICreatureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TargetWillEscape_Public_Static_Boolean_Entity_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLocationDiseased_Public_Static_Boolean_World_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeMeleeAttackTarget_Public_Static_AttackTargetResult_AIContext_ICharacterManager_ICreatureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeRangedAttackTarget_Public_Static_AttackTargetResult_AIContext_ICharacterManager_ICreatureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determineAttackTarget_Private_Static_Entity_AIContext_Entity_Boolean_ICharacterManager_ICreatureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeCanCraft_Public_Static_CanCraftResult_AIContext_String_ICraftingManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeCanPickup_Public_Static_CanPickupResult_AIContext_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeEscapeTargets_Public_Static_EscapeTargetsResult_AIContext_ICreatureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determineEscapeFromTargets_Private_Static_Void_Entity_HashSet_1_Entity_ICreatureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determineAvoidancePositions_Private_Static_Void_Entity_IAIControlled_List_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determineEscapePosition_Private_Static_Void_Entity_IAIControlled_HashSet_1_Entity_List_1_Vector3_byref_Vector3_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isValidAvoidancePosition_Private_Static_Boolean_World_IAIControlled_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindConsumableInteraction_Public_Static_FindConsumableInteractionResult_AIContext_IInteractionManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindValidEntity_Public_Static_FindEntitiesResult_AIContext_List_1_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindValidEntity_Public_Static_FindEntitiesResult_AIContext_List_1_String_PrefabVariantType_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindValidEntity_Public_Static_FindEntitiesResult_AIContext_ToolType_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindClosestStockpileEntity_Public_Static_FindEntitiesResult_AIContext_List_1_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkEntityValid_Private_Static_Boolean_AIContext_World_Entity_Entity_Single_byref_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_shouldIgnoreNewEntity_Private_Static_Boolean_Entity_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_shouldIgnoreEntityProperties_Private_Static_Boolean_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldIgnoreOutsideHomeConstruction_Public_Static_Boolean_AIContext_Entity_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_shouldIgnoreEntityLevel_Private_Static_Boolean_Entity_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRawMeatStack_Public_Static_Boolean_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRawMeatIdentifier_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCookedMeatStack_Public_Static_Boolean_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCookedMeatIdentifier_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCookerRequiredRawMeatIdentifier_Public_Static_Boolean_ICooker_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstRawMeatStack_Public_Static_InventoryItemStack_Inventory_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstCookedMeatStack_Public_Static_InventoryItemStack_Inventory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstCookedMeatStackWithRoom_Public_Static_InventoryItemStack_Inventory_Inventory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindCookerAcceptingRawMeat_Public_Static_CookerRawMeatResult_AIContext_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindCookerWithCookedMeat_Public_Static_CookerCookedMeatResult_AIContext_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindHarvestableMeatCarcass_Public_Static_HarvestableMeatCarcassResult_AIContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidHarvestableMeatCarcassTarget_Private_Static_Boolean_AIContext_Entity_World_Entity_Single_byref_InventorySlot_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindNearbyHomeStorableForCookedMeatStorage_Public_Static_FindEntitiesResult_AIContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindNearbyHomeStorableWithCookedMeat_Public_Static_HomeStorableCookedMeatResult_AIContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isValidHomeStorableTarget_Private_Static_Boolean_AIContext_Entity_World_Entity_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeThreatenTarget_Public_Static_ThreatenTargetResult_AIContext_ICreatureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFindClosestWater_Public_Static_FindWaterResult_AIContext_List_1_String_0;

	public unsafe static float MAX_ATTACK_TARGET_WATER_DEPTH
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_ATTACK_TARGET_WATER_DEPTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_ATTACK_TARGET_WATER_DEPTH, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<Quaternion> avoidanceRotations
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_avoidanceRotations, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Quaternion>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_avoidanceRotations, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static InteractionType INTERACTION_TYPE
	{
		get
		{
			Unsafe.SkipInit(out InteractionType result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERACTION_TYPE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERACTION_TYPE, (void*)(&interactionType));
		}
	}

	public unsafe static float MAX_SEARCH_DISTANCE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_SEARCH_DISTANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_SEARCH_DISTANCE, (void*)(&num));
		}
	}

	public unsafe static float HARVESTABLE_CARCASS_RADIUS
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HARVESTABLE_CARCASS_RADIUS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HARVESTABLE_CARCASS_RADIUS, (void*)(&num));
		}
	}

	public unsafe static float HOME_STORABLE_COOKED_MEAT_RADIUS
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HOME_STORABLE_COOKED_MEAT_RADIUS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HOME_STORABLE_COOKED_MEAT_RADIUS, (void*)(&num));
		}
	}

	static AIQueries()
	{
		Il2CppClassPointerStore<AIQueries>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AIQueries");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIQueries>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_ATTACK_TARGET_WATER_DEPTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, "MAX_ATTACK_TARGET_WATER_DEPTH");
		NativeFieldInfoPtr_avoidanceRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, "avoidanceRotations");
		NativeFieldInfoPtr_INTERACTION_TYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, "INTERACTION_TYPE");
		NativeFieldInfoPtr_MAX_SEARCH_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, "MAX_SEARCH_DISTANCE");
		NativeFieldInfoPtr_HARVESTABLE_CARCASS_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, "HARVESTABLE_CARCASS_RADIUS");
		NativeFieldInfoPtr_HOME_STORABLE_COOKED_MEAT_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, "HOME_STORABLE_COOKED_MEAT_RADIUS");
		NativeMethodInfoPtr_IsReachable_Public_Static_Boolean_AIContext_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668423);
		NativeMethodInfoPtr_GetNearbyLightEmitter_Public_Static_Entity_World_Vector3_IAIControlled_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668424);
		NativeMethodInfoPtr_CheckLightEmitterPresent_Public_Static_Boolean_World_Vector3_IAIControlled_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668425);
		NativeMethodInfoPtr_ArePointsValidOnRoute_Public_Static_Boolean_Entity_IAIControlled_World_Vector3_Boolean_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668426);
		NativeMethodInfoPtr_FindValidPosition_Public_Static_Boolean_AIContext_Boolean_Single_Single_Func_4_World_Entity_Vector3_Boolean_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668427);
		NativeMethodInfoPtr_FindValidPosition_Public_Static_Boolean_AIContext_Func_3_AIContext_Int32_ValueTuple_2_Vector3_Quaternion_Func_3_AIContext_Vector3_Boolean_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668428);
		NativeMethodInfoPtr_ShouldApproachTrap_Public_Static_Boolean_World_Entity_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668429);
		NativeMethodInfoPtr_TryFindClosestLand_Public_Static_Boolean_World_Vector3_byref_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668430);
		NativeMethodInfoPtr_ShouldAvoidTarget_Public_Static_Boolean_Entity_Entity_ICreatureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668431);
		NativeMethodInfoPtr_TargetWillEscape_Public_Static_Boolean_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668432);
		NativeMethodInfoPtr_IsLocationDiseased_Public_Static_Boolean_World_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668433);
		NativeMethodInfoPtr_ComputeMeleeAttackTarget_Public_Static_AttackTargetResult_AIContext_ICharacterManager_ICreatureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668434);
		NativeMethodInfoPtr_ComputeRangedAttackTarget_Public_Static_AttackTargetResult_AIContext_ICharacterManager_ICreatureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668435);
		NativeMethodInfoPtr_determineAttackTarget_Private_Static_Entity_AIContext_Entity_Boolean_ICharacterManager_ICreatureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668436);
		NativeMethodInfoPtr_ComputeCanCraft_Public_Static_CanCraftResult_AIContext_String_ICraftingManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668437);
		NativeMethodInfoPtr_ComputeCanPickup_Public_Static_CanPickupResult_AIContext_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668438);
		NativeMethodInfoPtr_ComputeEscapeTargets_Public_Static_EscapeTargetsResult_AIContext_ICreatureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668439);
		NativeMethodInfoPtr_determineEscapeFromTargets_Private_Static_Void_Entity_HashSet_1_Entity_ICreatureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668440);
		NativeMethodInfoPtr_determineAvoidancePositions_Private_Static_Void_Entity_IAIControlled_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668441);
		NativeMethodInfoPtr_determineEscapePosition_Private_Static_Void_Entity_IAIControlled_HashSet_1_Entity_List_1_Vector3_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668442);
		NativeMethodInfoPtr_isValidAvoidancePosition_Private_Static_Boolean_World_IAIControlled_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668443);
		NativeMethodInfoPtr_ComputeFindConsumableInteraction_Public_Static_FindConsumableInteractionResult_AIContext_IInteractionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668444);
		NativeMethodInfoPtr_ComputeFindValidEntity_Public_Static_FindEntitiesResult_AIContext_List_1_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668445);
		NativeMethodInfoPtr_ComputeFindValidEntity_Public_Static_FindEntitiesResult_AIContext_List_1_String_PrefabVariantType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668446);
		NativeMethodInfoPtr_ComputeFindValidEntity_Public_Static_FindEntitiesResult_AIContext_ToolType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668447);
		NativeMethodInfoPtr_ComputeFindClosestStockpileEntity_Public_Static_FindEntitiesResult_AIContext_List_1_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668448);
		NativeMethodInfoPtr_checkEntityValid_Private_Static_Boolean_AIContext_World_Entity_Entity_Single_byref_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668449);
		NativeMethodInfoPtr_shouldIgnoreNewEntity_Private_Static_Boolean_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668450);
		NativeMethodInfoPtr_shouldIgnoreEntityProperties_Private_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668451);
		NativeMethodInfoPtr_ShouldIgnoreOutsideHomeConstruction_Public_Static_Boolean_AIContext_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668452);
		NativeMethodInfoPtr_shouldIgnoreEntityLevel_Private_Static_Boolean_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668453);
		NativeMethodInfoPtr_IsRawMeatStack_Public_Static_Boolean_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668454);
		NativeMethodInfoPtr_IsRawMeatIdentifier_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668455);
		NativeMethodInfoPtr_IsCookedMeatStack_Public_Static_Boolean_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668456);
		NativeMethodInfoPtr_IsCookedMeatIdentifier_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668457);
		NativeMethodInfoPtr_TryGetCookerRequiredRawMeatIdentifier_Public_Static_Boolean_ICooker_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668458);
		NativeMethodInfoPtr_FindFirstRawMeatStack_Public_Static_InventoryItemStack_Inventory_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668459);
		NativeMethodInfoPtr_FindFirstCookedMeatStack_Public_Static_InventoryItemStack_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668460);
		NativeMethodInfoPtr_FindFirstCookedMeatStackWithRoom_Public_Static_InventoryItemStack_Inventory_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668461);
		NativeMethodInfoPtr_ComputeFindCookerAcceptingRawMeat_Public_Static_CookerRawMeatResult_AIContext_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668462);
		NativeMethodInfoPtr_ComputeFindCookerWithCookedMeat_Public_Static_CookerCookedMeatResult_AIContext_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668463);
		NativeMethodInfoPtr_ComputeFindHarvestableMeatCarcass_Public_Static_HarvestableMeatCarcassResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668464);
		NativeMethodInfoPtr_IsValidHarvestableMeatCarcassTarget_Private_Static_Boolean_AIContext_Entity_World_Entity_Single_byref_InventorySlot_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668465);
		NativeMethodInfoPtr_ComputeFindNearbyHomeStorableForCookedMeatStorage_Public_Static_FindEntitiesResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668466);
		NativeMethodInfoPtr_ComputeFindNearbyHomeStorableWithCookedMeat_Public_Static_HomeStorableCookedMeatResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668467);
		NativeMethodInfoPtr_isValidHomeStorableTarget_Private_Static_Boolean_AIContext_Entity_World_Entity_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668468);
		NativeMethodInfoPtr_ComputeThreatenTarget_Public_Static_ThreatenTargetResult_AIContext_ICreatureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668469);
		NativeMethodInfoPtr_ComputeFindClosestWater_Public_Static_FindWaterResult_AIContext_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIQueries>.NativeClassPtr, 100668470);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 90727, RefRangeEnd = 90730, XrefRangeStart = 90722, XrefRangeEnd = 90727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsReachable(AIContext ctx, Entity aiEntity, Entity targetEntity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsReachable_Public_Static_Boolean_AIContext_Entity_Entity_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 90760, RefRangeEnd = 90762, XrefRangeStart = 90730, XrefRangeEnd = 90760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Entity GetNearbyLightEmitter(World world, Vector3 targetPosition, IAIControlled aiControlled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetPosition;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiControlled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearbyLightEmitter_Public_Static_Entity_World_Vector3_IAIControlled_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 90766, RefRangeEnd = 90768, XrefRangeStart = 90762, XrefRangeEnd = 90766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckLightEmitterPresent(World world, Vector3 targetPosition, IAIControlled aiControlled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetPosition;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiControlled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckLightEmitterPresent_Public_Static_Boolean_World_Vector3_IAIControlled_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90779, RefRangeEnd = 90780, XrefRangeStart = 90768, XrefRangeEnd = 90779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ArePointsValidOnRoute(Entity aiEntity, IAIControlled aiControlled, World world, Vector3 targetPosition, bool aboveWater = true, float waterLevelOffset = 0f, bool noDisease = true, bool noLightEmitters = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiControlled);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetPosition;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &aboveWater;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &waterLevelOffset;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &noDisease;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &noLightEmitters;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArePointsValidOnRoute_Public_Static_Boolean_Entity_IAIControlled_World_Vector3_Boolean_Single_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90780, XrefRangeEnd = 90786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FindValidPosition(AIContext ctx, bool nearHome, float minDistance, float maxDistance, Il2CppSystem.Func<World, Entity, Vector3, bool> validFunc, out Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nearHome;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDistance;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)validFunc);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindValidPosition_Public_Static_Boolean_AIContext_Boolean_Single_Single_Func_4_World_Entity_Vector3_Boolean_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90786, XrefRangeEnd = 90788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FindValidPosition(AIContext ctx, Il2CppSystem.Func<AIContext, int, Il2CppSystem.ValueTuple<Vector3, Quaternion>> positionFunc, Il2CppSystem.Func<AIContext, Vector3, bool> validFunc, out Vector3 position, out Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)positionFunc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)validFunc);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindValidPosition_Public_Static_Boolean_AIContext_Func_3_AIContext_Int32_ValueTuple_2_Vector3_Quaternion_Func_3_AIContext_Vector3_Boolean_byref_Vector3_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90856, RefRangeEnd = 90857, XrefRangeStart = 90788, XrefRangeEnd = 90856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldApproachTrap(World world, Entity aiEntity, out Entity trapEntity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldApproachTrap_Public_Static_Boolean_World_Entity_byref_Entity_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		trapEntity = ((num3 == 0) ? null : new Entity(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90865, RefRangeEnd = 90866, XrefRangeStart = 90857, XrefRangeEnd = 90865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryFindClosestLand(World world, Vector3 position, out Vector3 positionOnLand, float buffer = 0.5f, float maxSearchDistance = 10f, float stepSize = 2f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref positionOnLand);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSearchDistance;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &stepSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindClosestLand_Public_Static_Boolean_World_Vector3_byref_Vector3_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 90904, RefRangeEnd = 90907, XrefRangeStart = 90866, XrefRangeEnd = 90904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldAvoidTarget(Entity aiEntity, Entity targetEntity, ICreatureManager creatureManager)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creatureManager);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldAvoidTarget_Public_Static_Boolean_Entity_Entity_ICreatureManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90907, XrefRangeEnd = 90926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TargetWillEscape(Entity aiEntity, Entity targetEntity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TargetWillEscape_Public_Static_Boolean_Entity_Entity_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90926, XrefRangeEnd = 90928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLocationDiseased(World world, Entity entity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLocationDiseased_Public_Static_Boolean_World_Entity_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90933, RefRangeEnd = 90934, XrefRangeStart = 90928, XrefRangeEnd = 90933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AttackTargetResult ComputeMeleeAttackTarget(AIContext ctx, ICharacterManager characterManager, ICreatureManager creatureManager)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creatureManager);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeMeleeAttackTarget_Public_Static_AttackTargetResult_AIContext_ICharacterManager_ICreatureManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new AttackTargetResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90939, RefRangeEnd = 90940, XrefRangeStart = 90934, XrefRangeEnd = 90939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AttackTargetResult ComputeRangedAttackTarget(AIContext ctx, ICharacterManager characterManager, ICreatureManager creatureManager)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creatureManager);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeRangedAttackTarget_Public_Static_AttackTargetResult_AIContext_ICharacterManager_ICreatureManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new AttackTargetResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 91004, RefRangeEnd = 91006, XrefRangeStart = 90940, XrefRangeEnd = 91004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Entity determineAttackTarget(AIContext ctx, Entity aiEntity, bool rangedAttack, ICharacterManager characterManager, ICreatureManager creatureManager)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rangedAttack;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creatureManager);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineAttackTarget_Private_Static_Entity_AIContext_Entity_Boolean_ICharacterManager_ICreatureManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91011, RefRangeEnd = 91012, XrefRangeStart = 91006, XrefRangeEnd = 91011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CanCraftResult ComputeCanCraft(AIContext ctx, string recipeIdentifier, ICraftingManager craftingManager)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(recipeIdentifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)craftingManager);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeCanCraft_Public_Static_CanCraftResult_AIContext_String_ICraftingManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CanCraftResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91062, RefRangeEnd = 91063, XrefRangeStart = 91012, XrefRangeEnd = 91062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CanPickupResult ComputeCanPickup(AIContext ctx, InventoryItemStack stack)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeCanPickup_Public_Static_CanPickupResult_AIContext_InventoryItemStack_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CanPickupResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91146, RefRangeEnd = 91147, XrefRangeStart = 91063, XrefRangeEnd = 91146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static EscapeTargetsResult ComputeEscapeTargets(AIContext ctx, ICreatureManager creatureManager)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creatureManager);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeEscapeTargets_Public_Static_EscapeTargetsResult_AIContext_ICreatureManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new EscapeTargetsResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91309, RefRangeEnd = 91310, XrefRangeStart = 91147, XrefRangeEnd = 91309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void determineEscapeFromTargets(Entity aiEntity, HashSet<Entity> result, ICreatureManager creatureManager)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creatureManager);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineEscapeFromTargets_Private_Static_Void_Entity_HashSet_1_Entity_ICreatureManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91367, RefRangeEnd = 91368, XrefRangeStart = 91310, XrefRangeEnd = 91367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void determineAvoidancePositions(Entity aiEntity, IAIControlled aiControlled, List<Vector3> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiControlled);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineAvoidancePositions_Private_Static_Void_Entity_IAIControlled_List_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91456, RefRangeEnd = 91457, XrefRangeStart = 91368, XrefRangeEnd = 91456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void determineEscapePosition(Entity aiEntity, IAIControlled aiControlled, HashSet<Entity> escapeFromTargets, List<Vector3> avoidancePositions, out Vector3 targetPosition, out float urgency)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiControlled);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)escapeFromTargets);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)avoidancePositions);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref targetPosition);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref urgency);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineEscapePosition_Private_Static_Void_Entity_IAIControlled_HashSet_1_Entity_List_1_Vector3_byref_Vector3_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91457, XrefRangeEnd = 91463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isValidAvoidancePosition(World world, IAIControlled aiControlled, Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiControlled);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isValidAvoidancePosition_Private_Static_Boolean_World_IAIControlled_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91569, RefRangeEnd = 91570, XrefRangeStart = 91463, XrefRangeEnd = 91569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FindConsumableInteractionResult ComputeFindConsumableInteraction(AIContext ctx, IInteractionManager interactionManager)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionManager);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindConsumableInteraction_Public_Static_FindConsumableInteractionResult_AIContext_IInteractionManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindConsumableInteractionResult(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 91597, RefRangeEnd = 91601, XrefRangeStart = 91570, XrefRangeEnd = 91597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FindEntitiesResult ComputeFindValidEntity(AIContext ctx, List<string> identifiers, bool excludeClaimed = true, bool requireHomeOwnedConstruction = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeClaimed;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &requireHomeOwnedConstruction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindValidEntity_Public_Static_FindEntitiesResult_AIContext_List_1_String_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindEntitiesResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 91628, RefRangeEnd = 91630, XrefRangeStart = 91601, XrefRangeEnd = 91628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FindEntitiesResult ComputeFindValidEntity(AIContext ctx, List<string> identifiers, PrefabVariantType prefabVariantType, bool excludeClaimed = true, bool requireHomeOwnedConstruction = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariantType;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeClaimed;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &requireHomeOwnedConstruction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindValidEntity_Public_Static_FindEntitiesResult_AIContext_List_1_String_PrefabVariantType_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindEntitiesResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91660, RefRangeEnd = 91661, XrefRangeStart = 91630, XrefRangeEnd = 91660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FindEntitiesResult ComputeFindValidEntity(AIContext ctx, ToolType toolType, bool excludeClaimed = true, bool requireHomeOwnedConstruction = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(ToolType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toolType;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeClaimed;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &requireHomeOwnedConstruction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindValidEntity_Public_Static_FindEntitiesResult_AIContext_ToolType_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindEntitiesResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 91710, RefRangeEnd = 91712, XrefRangeStart = 91661, XrefRangeEnd = 91710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FindEntitiesResult ComputeFindClosestStockpileEntity(AIContext ctx, List<string> itemIdentifiers, bool excludeFull = true, bool excludeClaimed = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIdentifiers);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeFull;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeClaimed;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindClosestStockpileEntity_Public_Static_FindEntitiesResult_AIContext_List_1_String_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindEntitiesResult(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 91741, RefRangeEnd = 91745, XrefRangeStart = 91712, XrefRangeEnd = 91741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool checkEntityValid(AIContext ctx, World world, Entity aiEntity, Entity entity, float closestDistance, out float distance, bool excludeClaimed = true, bool requireHomeOwnedConstruction = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &closestDistance;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distance);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeClaimed;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &requireHomeOwnedConstruction;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkEntityValid_Private_Static_Boolean_AIContext_World_Entity_Entity_Single_byref_Single_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool shouldIgnoreNewEntity(Entity entity, float distance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_shouldIgnoreNewEntity_Private_Static_Boolean_Entity_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91745, XrefRangeEnd = 91751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool shouldIgnoreEntityProperties(Entity targetEntity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_shouldIgnoreEntityProperties_Private_Static_Boolean_Entity_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91751, XrefRangeEnd = 91754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldIgnoreOutsideHomeConstruction(AIContext ctx, Entity targetEntity, bool requireHomeOwnedConstruction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEntity);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &requireHomeOwnedConstruction;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldIgnoreOutsideHomeConstruction_Public_Static_Boolean_AIContext_Entity_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool shouldIgnoreEntityLevel(Entity aiEntity, Entity targetEntity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_shouldIgnoreEntityLevel_Private_Static_Boolean_Entity_Entity_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 91755, RefRangeEnd = 91759, XrefRangeStart = 91754, XrefRangeEnd = 91755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRawMeatStack(InventoryItemStack stack)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRawMeatStack_Public_Static_Boolean_InventoryItemStack_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91759, XrefRangeEnd = 91761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRawMeatIdentifier(string identifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRawMeatIdentifier_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 91762, RefRangeEnd = 91766, XrefRangeStart = 91761, XrefRangeEnd = 91762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCookedMeatStack(InventoryItemStack stack)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCookedMeatStack_Public_Static_Boolean_InventoryItemStack_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91766, XrefRangeEnd = 91769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCookedMeatIdentifier(string identifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCookedMeatIdentifier_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91813, RefRangeEnd = 91814, XrefRangeStart = 91769, XrefRangeEnd = 91813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetCookerRequiredRawMeatIdentifier(ICooker cooker, out string requiredRawMeatIdentifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cooker);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetCookerRequiredRawMeatIdentifier_Public_Static_Boolean_ICooker_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		requiredRawMeatIdentifier = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91831, RefRangeEnd = 91832, XrefRangeStart = 91814, XrefRangeEnd = 91831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InventoryItemStack FindFirstRawMeatStack(Inventory inventory, string requiredRawMeatIdentifier = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(requiredRawMeatIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstRawMeatStack_Public_Static_InventoryItemStack_Inventory_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 91847, RefRangeEnd = 91850, XrefRangeStart = 91832, XrefRangeEnd = 91847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InventoryItemStack FindFirstCookedMeatStack(Inventory inventory)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstCookedMeatStack_Public_Static_InventoryItemStack_Inventory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91866, RefRangeEnd = 91867, XrefRangeStart = 91850, XrefRangeEnd = 91866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InventoryItemStack FindFirstCookedMeatStackWithRoom(Inventory sourceInventory, Inventory destinationInventory)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceInventory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destinationInventory);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstCookedMeatStackWithRoom_Public_Static_InventoryItemStack_Inventory_Inventory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91916, RefRangeEnd = 91917, XrefRangeStart = 91867, XrefRangeEnd = 91916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CookerRawMeatResult ComputeFindCookerAcceptingRawMeat(AIContext ctx, string cookerIdentifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(cookerIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindCookerAcceptingRawMeat_Public_Static_CookerRawMeatResult_AIContext_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new CookerRawMeatResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91933, RefRangeEnd = 91934, XrefRangeStart = 91917, XrefRangeEnd = 91933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CookerCookedMeatResult ComputeFindCookerWithCookedMeat(AIContext ctx, string cookerIdentifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(cookerIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindCookerWithCookedMeat_Public_Static_CookerCookedMeatResult_AIContext_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new CookerCookedMeatResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92003, RefRangeEnd = 92004, XrefRangeStart = 91934, XrefRangeEnd = 92003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HarvestableMeatCarcassResult ComputeFindHarvestableMeatCarcass(AIContext ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindHarvestableMeatCarcass_Public_Static_HarvestableMeatCarcassResult_AIContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new HarvestableMeatCarcassResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92063, RefRangeEnd = 92065, XrefRangeStart = 92004, XrefRangeEnd = 92063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidHarvestableMeatCarcassTarget(AIContext ctx, Entity aiEntity, World world, Entity entity, float closestDistance, out InventorySlot harvestSlot, out float distance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &closestDistance;
		byte* num = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidHarvestableMeatCarcassTarget_Private_Static_Boolean_AIContext_Entity_World_Entity_Single_byref_InventorySlot_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		harvestSlot = ((num3 == 0) ? null : new InventorySlot(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92119, RefRangeEnd = 92120, XrefRangeStart = 92065, XrefRangeEnd = 92119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FindEntitiesResult ComputeFindNearbyHomeStorableForCookedMeatStorage(AIContext ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindNearbyHomeStorableForCookedMeatStorage_Public_Static_FindEntitiesResult_AIContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindEntitiesResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92192, RefRangeEnd = 92193, XrefRangeStart = 92120, XrefRangeEnd = 92192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HomeStorableCookedMeatResult ComputeFindNearbyHomeStorableWithCookedMeat(AIContext ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindNearbyHomeStorableWithCookedMeat_Public_Static_HomeStorableCookedMeatResult_AIContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new HomeStorableCookedMeatResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92205, RefRangeEnd = 92207, XrefRangeStart = 92193, XrefRangeEnd = 92205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isValidHomeStorableTarget(AIContext ctx, Entity aiEntity, World world, Entity entity, float closestDistance, out float distance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &closestDistance;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isValidHomeStorableTarget_Private_Static_Boolean_AIContext_Entity_World_Entity_Single_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92351, RefRangeEnd = 92352, XrefRangeStart = 92207, XrefRangeEnd = 92351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ThreatenTargetResult ComputeThreatenTarget(AIContext ctx, ICreatureManager creatureManager)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creatureManager);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeThreatenTarget_Public_Static_ThreatenTargetResult_AIContext_ICreatureManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ThreatenTargetResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92384, RefRangeEnd = 92385, XrefRangeStart = 92352, XrefRangeEnd = 92384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FindWaterResult ComputeFindClosestWater(AIContext ctx, List<string> identifiers)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFindClosestWater_Public_Static_FindWaterResult_AIContext_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindWaterResult(pointer);
	}

	public AIQueries(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

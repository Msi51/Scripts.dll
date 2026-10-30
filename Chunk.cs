using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Pool;

[System.Serializable]
public class Chunk : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<Chunk>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_detailObjectPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodObjectPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundColliderObjectPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellsPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveChunkPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_world;

	private static readonly System.IntPtr NativeFieldInfoPtr_coordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveChunkEntityIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveWaterEntityIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_cells;

	private static readonly System.IntPtr NativeFieldInfoPtr_entities;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentEntityMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_identifierToEntitiesMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_childIdentifierToChunkSpawnLimitMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_surroundingChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_updatedCellCulling;

	private static readonly System.IntPtr NativeFieldInfoPtr_physicsCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedDetailObjectCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherChunkQueuedTexturePaints;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherChunkQueuedTextureRectanglePaints;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedTerrainHeightmapChanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedTerrainAlphamapChanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedTerrainDetailmapCellChanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedTerrainClearedSnowChanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrain;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunBlockerObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveEntranceEntities;

	private static readonly System.IntPtr NativeFieldInfoPtr_entitiesToCreate;

	private static readonly System.IntPtr NativeFieldInfoPtr_pendingCaveChunksToGenerate;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseChunkData;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkData;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveData;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightmapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_alphamapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTypeResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_detailResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightmap;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_alphamaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_detailmaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_holeMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_solidObjectTakenPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearedSnowMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearedSnowMapEmpty;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkMapTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_slopeData;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainLayerZoneMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterMapPendingUpdates;

	private static readonly System.IntPtr NativeFieldInfoPtr_generatedCaveCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveChunksToGenerate;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastDiseaseUpdateDateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastActiveDateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_seed;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimapColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_exposedWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_requireSaving;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkRandom;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkState;

	private static readonly System.IntPtr NativeFieldInfoPtr_culled;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_activatedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_catchupTimeSpan;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_World_Coordinates_ChunkInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCellDetails_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActive_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecentlyActivated_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginalHeight_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginalHeight_Public_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeight_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeight_Public_Single_TerrainPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeight_Public_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeight_Public_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationOnTerrain_Public_Quaternion_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSlopeMagnitude_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSlope_Public_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWaterAmount_Public_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEntity_Public_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEntity_Public_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWeight_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveWeight_Public_Void_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_TerrainPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnTerrainAndWater_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCenterPositionXZ_Public_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCenterPositionOnTerrain_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCenterPositionOnTerrainAndWater_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomPositionOnTerrain_Public_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomPositionOnTerrainAndWater_Public_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkPositionRatio_Public_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkPositionRatio_Public_Vector2_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshAlphamaps_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshClearedSnow_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshHeightmap_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTerrainPhysics_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureTypeAmountAtPosition_Public_Single_Vector3_TextureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureTypeAtPosition_Public_TextureType_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tryGetClampedAlphamapIndices_Private_Boolean_Vector3_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClearedSnowAtPosition_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCaveCoordinates_Public_Coordinates_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainTypeAmount_Public_Single_Vector3_TerrainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainTypeAtPosition_Public_TerrainType_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainTypesForHeightmapPoint_Public_Void_Int32_Int32_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainTypeAmountForHeightmapPoint_Public_Single_Int32_Int32_TerrainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTerrainTypesForHeightmapPoint_Public_Void_Int32_Int32_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiseaseAmountAtPosition_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldRefreshDiseaseMap_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cellCoordinatesValid_Private_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellEntities_Public_HashSet_1_Entity_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellEntities_Public_HashSet_1_Entity_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesWithComponent_Public_Void_ICollection_1_Entity_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesWithComponent_Public_HashSet_1_Entity_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesWithIdentifier_Public_HashSet_1_Entity_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsQueuedDetailObjectCell_Public_Boolean_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveQueuedDetailObjectCell_Public_Void_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearUpdatedCellCulling_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WasCellCullingUpdated_Public_Boolean_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCellDetailsCulled_Public_Boolean_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTrackedPhysicsCell_Public_Void_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearPhysicsCells_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCellPhysicsTracked_Public_Boolean_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCellPhysics_Public_Void_Cell_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CullEverything_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTerrainCulled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWaterCulled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCellCulling_Public_Void_Cell_Coordinates_CellCulling_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCellDetailPlacementInfo_Public_Void_Coordinates_DetailPlacementInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellDetailPlacementInfo_Public_List_1_DetailPlacementInfo_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearDetailPlacementInfo_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearDetailPlacementInfo_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCellDetailObjects_Public_Void_Coordinates_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCellDetailRenderers_Public_Void_Coordinates_MeshRenderer_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellDetailRenderers_Public_List_1_MeshRenderer_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSoundColliderObject_Public_Void_Coordinates_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEffectObject_Public_Void_Coordinates_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellEffectObjects_Public_List_1_GameObject_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshEntityVisibility_Public_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_refreshEntityVisibility_Private_Void_Entity_Cell_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTallEntity_Private_Boolean_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setShortEntitiesCulled_Private_Void_Cell_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTallEntitiesCulled_Private_Void_Cell_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_shouldHideEntityWhenUnderground_Private_Boolean_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEntityCulled_Private_Void_Entity_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDetailsCulled_Private_Void_Cell_Coordinates_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEffectObjectCulled_Private_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEntityPhysics_Private_Void_Entity_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSoundColliderPhysics_Private_Void_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInChunk_Public_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInChunk_Public_Boolean_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addCellEntity_Private_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleObjectMovement_Public_Boolean_Entity_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeCellEntity_Private_Void_Entity_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeCellEntity_Private_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueuePendingEntityCreations_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueuePendingStructureCreations_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellPositionRatio_Public_Vector2_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellCenterPosition_Public_Vector3_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCell_Public_Cell_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellBounds_Public_Bounds_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSurroundingChunkCoordinates_Public_Il2CppReferenceArray_1_Il2CppStructArray_1_Coordinates_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTerrainLayerZone_Public_Void_TerrainLayerZone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTerrainLayerZone_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntities_Public_HashSet_1_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeEntities_Public_Void_List_1_SerializedEntity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetChunkData_Public_Void_ChunkData_ChunkData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetChunkCaveData_Public_Void_CaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe static ObjectPool<GameObject> detailObjectPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_detailObjectPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPool<GameObject>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_detailObjectPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectPool));
		}
	}

	public unsafe static ObjectPool<GameObject> lodObjectPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lodObjectPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPool<GameObject>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lodObjectPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectPool));
		}
	}

	public unsafe static ObjectPool<GameObject> soundColliderObjectPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_soundColliderObjectPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPool<GameObject>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_soundColliderObjectPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectPool));
		}
	}

	public unsafe static ChunkCellsPool cellsPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cellsPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChunkCellsPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cellsPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkCellsPool));
		}
	}

	public unsafe static CaveChunkPool caveChunkPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_caveChunkPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CaveChunkPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_caveChunkPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveChunkPool));
		}
	}

	public unsafe World world
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
		}
	}

	public unsafe Coordinates coordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates)) = coordinates;
		}
	}

	public unsafe ChunkInfo chunkInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChunkInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkInfo));
		}
	}

	public unsafe int terrainEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainEntityId)) = num;
		}
	}

	public unsafe int waterEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterEntityId)) = num;
		}
	}

	public unsafe Dictionary<Coordinates, int> caveChunkEntityIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunkEntityIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunkEntityIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Coordinates, int> caveWaterEntityIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveWaterEntityIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveWaterEntityIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppReferenceArray<Cell>> cells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<Cell>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe HashSet<Entity> entities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<string, HashSet<Entity>> componentEntityMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentEntityMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<Entity>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentEntityMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, HashSet<Entity>> identifierToEntitiesMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifierToEntitiesMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<Entity>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifierToEntitiesMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, float> childIdentifierToChunkSpawnLimitMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childIdentifierToChunkSpawnLimitMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childIdentifierToChunkSpawnLimitMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, Il2CppReferenceArray<Il2CppStructArray<Coordinates>>> surroundingChunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surroundingChunkCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Il2CppStructArray<Coordinates>>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surroundingChunkCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<Cell> updatedCellCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updatedCellCulling);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Cell>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updatedCellCulling)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<Coordinates> physicsCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<Coordinates> queuedDetailObjectCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedDetailObjectCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedDetailObjectCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<QueuedTexturePaint> otherChunkQueuedTexturePaints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherChunkQueuedTexturePaints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<QueuedTexturePaint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherChunkQueuedTexturePaints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<QueuedTextureRectanglePaint> otherChunkQueuedTextureRectanglePaints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherChunkQueuedTextureRectanglePaints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<QueuedTextureRectanglePaint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherChunkQueuedTextureRectanglePaints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Il2CppSystem.ValueTuple<int, int>> queuedTerrainHeightmapChanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTerrainHeightmapChanges);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<int, int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTerrainHeightmapChanges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Il2CppSystem.ValueTuple<int, int>> queuedTerrainAlphamapChanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTerrainAlphamapChanges);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<int, int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTerrainAlphamapChanges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Coordinates> queuedTerrainDetailmapCellChanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTerrainDetailmapCellChanges);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTerrainDetailmapCellChanges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Il2CppSystem.ValueTuple<int, int>> queuedTerrainClearedSnowChanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTerrainClearedSnowChanges);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<int, int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTerrainClearedSnowChanges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe GameObject terrainObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe CustomTerrain terrain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrain);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomTerrain>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customTerrain));
		}
	}

	public unsafe Entity waterEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe GameObject sunBlockerObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunBlockerObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunBlockerObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe List<GameObject> caveObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Entity> caveEntranceEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveEntranceEntities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveEntranceEntities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<EntityCreationInfo> entitiesToCreate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entitiesToCreate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EntityCreationInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entitiesToCreate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<Coordinates> pendingCaveChunksToGenerate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingCaveChunksToGenerate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingCaveChunksToGenerate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe ChunkData baseChunkData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChunkData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChunkData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChunkData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkData));
		}
	}

	public unsafe ChunkData chunkData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChunkData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkData));
		}
	}

	public unsafe CaveData caveData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CaveData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveData));
		}
	}

	public unsafe int heightmapResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapResolution)) = num;
		}
	}

	public unsafe int alphamapResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamapResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamapResolution)) = num;
		}
	}

	public unsafe int terrainTypeResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeResolution)) = num;
		}
	}

	public unsafe int detailResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailResolution)) = num;
		}
	}

	public unsafe Il2CppObjectBase heightmap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmap)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppObjectBase terrainTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypes)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppObjectBase alphamaps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamaps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamaps)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppObjectBase detailmaps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailmaps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailmaps)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppObjectBase waterMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterMap)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppObjectBase holeMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holeMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holeMap)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<bool>> solidObjectTakenPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_solidObjectTakenPositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<bool>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_solidObjectTakenPositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppObjectBase diseaseMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseMap)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppObjectBase clearedSnowMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearedSnowMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearedSnowMap)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe bool clearedSnowMapEmpty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearedSnowMapEmpty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearedSnowMapEmpty)) = flag;
		}
	}

	public unsafe Texture2D chunkMapTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkMapTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkMapTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Material waterMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<Vector2>> slopeData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slopeData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<Vector2>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slopeData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Dictionary<int, TerrainLayerZone> terrainLayerZoneMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainLayerZoneMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, TerrainLayerZone>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainLayerZoneMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Vector2Int, float> waterMapPendingUpdates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterMapPendingUpdates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Vector2Int, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterMapPendingUpdates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<Coordinates> generatedCaveCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedCaveCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedCaveCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<Coordinates> caveChunksToGenerate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunksToGenerate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunksToGenerate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Il2CppSystem.DateTime lastDiseaseUpdateDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDiseaseUpdateDateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDiseaseUpdateDateTime)) = dateTime;
		}
	}

	public unsafe Il2CppSystem.DateTime lastActiveDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastActiveDateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastActiveDateTime)) = dateTime;
		}
	}

	public unsafe int seed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed)) = num;
		}
	}

	public unsafe Il2CppStructArray<Color> minimapColors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimapColors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimapColors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool exposedWater
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposedWater);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposedWater)) = flag;
		}
	}

	public unsafe bool requireSaving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requireSaving);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requireSaving)) = flag;
		}
	}

	public unsafe CustomRandom chunkRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkRandom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomRandom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkRandom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customRandom));
		}
	}

	public unsafe ChunkState chunkState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkState);
			return *(ChunkState*)num;
		}
		set
		{
			*(ChunkState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkState)) = chunkState;
		}
	}

	public unsafe bool culled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culled)) = flag;
		}
	}

	public unsafe Texture2D mapTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe float activatedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activatedTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activatedTime)) = num;
		}
	}

	public unsafe Il2CppSystem.TimeSpan catchupTimeSpan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_catchupTimeSpan);
			return *(Il2CppSystem.TimeSpan*)num;
		}
		set
		{
			*(Il2CppSystem.TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_catchupTimeSpan)) = timeSpan;
		}
	}

	static Chunk()
	{
		Il2CppClassPointerStore<Chunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "Chunk");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chunk>.NativeClassPtr);
		NativeFieldInfoPtr_detailObjectPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "detailObjectPool");
		NativeFieldInfoPtr_lodObjectPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "lodObjectPool");
		NativeFieldInfoPtr_soundColliderObjectPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "soundColliderObjectPool");
		NativeFieldInfoPtr_cellsPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "cellsPool");
		NativeFieldInfoPtr_caveChunkPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "caveChunkPool");
		NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "world");
		NativeFieldInfoPtr_coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "coordinates");
		NativeFieldInfoPtr_chunkInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "chunkInfo");
		NativeFieldInfoPtr_terrainEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "terrainEntityId");
		NativeFieldInfoPtr_waterEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "waterEntityId");
		NativeFieldInfoPtr_caveChunkEntityIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "caveChunkEntityIds");
		NativeFieldInfoPtr_caveWaterEntityIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "caveWaterEntityIds");
		NativeFieldInfoPtr_cells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "cells");
		NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "entities");
		NativeFieldInfoPtr_componentEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "componentEntityMap");
		NativeFieldInfoPtr_identifierToEntitiesMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "identifierToEntitiesMap");
		NativeFieldInfoPtr_childIdentifierToChunkSpawnLimitMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "childIdentifierToChunkSpawnLimitMap");
		NativeFieldInfoPtr_surroundingChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "surroundingChunkCoordinates");
		NativeFieldInfoPtr_updatedCellCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "updatedCellCulling");
		NativeFieldInfoPtr_physicsCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "physicsCells");
		NativeFieldInfoPtr_queuedDetailObjectCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "queuedDetailObjectCells");
		NativeFieldInfoPtr_otherChunkQueuedTexturePaints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "otherChunkQueuedTexturePaints");
		NativeFieldInfoPtr_otherChunkQueuedTextureRectanglePaints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "otherChunkQueuedTextureRectanglePaints");
		NativeFieldInfoPtr_queuedTerrainHeightmapChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "queuedTerrainHeightmapChanges");
		NativeFieldInfoPtr_queuedTerrainAlphamapChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "queuedTerrainAlphamapChanges");
		NativeFieldInfoPtr_queuedTerrainDetailmapCellChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "queuedTerrainDetailmapCellChanges");
		NativeFieldInfoPtr_queuedTerrainClearedSnowChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "queuedTerrainClearedSnowChanges");
		NativeFieldInfoPtr_terrainObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "terrainObject");
		NativeFieldInfoPtr_terrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "terrain");
		NativeFieldInfoPtr_waterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "waterEntity");
		NativeFieldInfoPtr_sunBlockerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "sunBlockerObject");
		NativeFieldInfoPtr_caveObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "caveObjects");
		NativeFieldInfoPtr_caveEntranceEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "caveEntranceEntities");
		NativeFieldInfoPtr_entitiesToCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "entitiesToCreate");
		NativeFieldInfoPtr_pendingCaveChunksToGenerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "pendingCaveChunksToGenerate");
		NativeFieldInfoPtr_baseChunkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "baseChunkData");
		NativeFieldInfoPtr_chunkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "chunkData");
		NativeFieldInfoPtr_caveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "caveData");
		NativeFieldInfoPtr_heightmapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "heightmapResolution");
		NativeFieldInfoPtr_alphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "alphamapResolution");
		NativeFieldInfoPtr_terrainTypeResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "terrainTypeResolution");
		NativeFieldInfoPtr_detailResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "detailResolution");
		NativeFieldInfoPtr_heightmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "heightmap");
		NativeFieldInfoPtr_terrainTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "terrainTypes");
		NativeFieldInfoPtr_alphamaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "alphamaps");
		NativeFieldInfoPtr_detailmaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "detailmaps");
		NativeFieldInfoPtr_waterMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "waterMap");
		NativeFieldInfoPtr_holeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "holeMap");
		NativeFieldInfoPtr_solidObjectTakenPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "solidObjectTakenPositions");
		NativeFieldInfoPtr_diseaseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "diseaseMap");
		NativeFieldInfoPtr_clearedSnowMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "clearedSnowMap");
		NativeFieldInfoPtr_clearedSnowMapEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "clearedSnowMapEmpty");
		NativeFieldInfoPtr_chunkMapTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "chunkMapTex");
		NativeFieldInfoPtr_waterMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "waterMaterial");
		NativeFieldInfoPtr_slopeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "slopeData");
		NativeFieldInfoPtr_terrainLayerZoneMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "terrainLayerZoneMap");
		NativeFieldInfoPtr_waterMapPendingUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "waterMapPendingUpdates");
		NativeFieldInfoPtr_generatedCaveCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "generatedCaveCoordinates");
		NativeFieldInfoPtr_caveChunksToGenerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "caveChunksToGenerate");
		NativeFieldInfoPtr_lastDiseaseUpdateDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "lastDiseaseUpdateDateTime");
		NativeFieldInfoPtr_lastActiveDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "lastActiveDateTime");
		NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "seed");
		NativeFieldInfoPtr_minimapColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "minimapColors");
		NativeFieldInfoPtr_exposedWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "exposedWater");
		NativeFieldInfoPtr_requireSaving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "requireSaving");
		NativeFieldInfoPtr_chunkRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "chunkRandom");
		NativeFieldInfoPtr_chunkState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "chunkState");
		NativeFieldInfoPtr_culled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "culled");
		NativeFieldInfoPtr_mapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "mapTexture");
		NativeFieldInfoPtr_activatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "activatedTime");
		NativeFieldInfoPtr_catchupTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chunk>.NativeClassPtr, "catchupTimeSpan");
		NativeMethodInfoPtr__ctor_Public_Void_World_Coordinates_ChunkInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683165);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683166);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683167);
		NativeMethodInfoPtr_ClearCellDetails_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683168);
		NativeMethodInfoPtr_IsActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683169);
		NativeMethodInfoPtr_RecentlyActivated_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683170);
		NativeMethodInfoPtr_GetOriginalHeight_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683171);
		NativeMethodInfoPtr_GetOriginalHeight_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683172);
		NativeMethodInfoPtr_GetHeight_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683173);
		NativeMethodInfoPtr_GetHeight_Public_Single_TerrainPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683174);
		NativeMethodInfoPtr_GetHeight_Public_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683175);
		NativeMethodInfoPtr_GetHeight_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683176);
		NativeMethodInfoPtr_GetRotationOnTerrain_Public_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683177);
		NativeMethodInfoPtr_GetSlopeMagnitude_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683178);
		NativeMethodInfoPtr_GetSlope_Public_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683179);
		NativeMethodInfoPtr_GetWaterAmount_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683180);
		NativeMethodInfoPtr_AddEntity_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683181);
		NativeMethodInfoPtr_RemoveEntity_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683182);
		NativeMethodInfoPtr_AddWeight_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683183);
		NativeMethodInfoPtr_RemoveWeight_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683184);
		NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683185);
		NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_TerrainPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683186);
		NativeMethodInfoPtr_GetPositionOnTerrainAndWater_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683187);
		NativeMethodInfoPtr_GetCenterPositionXZ_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683188);
		NativeMethodInfoPtr_GetCenterPositionOnTerrain_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683189);
		NativeMethodInfoPtr_GetCenterPositionOnTerrainAndWater_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683190);
		NativeMethodInfoPtr_GetRandomPositionOnTerrain_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683191);
		NativeMethodInfoPtr_GetRandomPositionOnTerrainAndWater_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683192);
		NativeMethodInfoPtr_GetChunkPositionRatio_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683193);
		NativeMethodInfoPtr_GetChunkPositionRatio_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683194);
		NativeMethodInfoPtr_RefreshAlphamaps_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683195);
		NativeMethodInfoPtr_RefreshClearedSnow_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683196);
		NativeMethodInfoPtr_RefreshHeightmap_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683197);
		NativeMethodInfoPtr_RefreshTerrainPhysics_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683198);
		NativeMethodInfoPtr_GetTextureTypeAmountAtPosition_Public_Single_Vector3_TextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683199);
		NativeMethodInfoPtr_GetTextureTypeAtPosition_Public_TextureType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683200);
		NativeMethodInfoPtr_tryGetClampedAlphamapIndices_Private_Boolean_Vector3_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683201);
		NativeMethodInfoPtr_GetClearedSnowAtPosition_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683202);
		NativeMethodInfoPtr_GetCaveCoordinates_Public_Coordinates_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683203);
		NativeMethodInfoPtr_GetTerrainTypeAmount_Public_Single_Vector3_TerrainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683204);
		NativeMethodInfoPtr_GetTerrainTypeAtPosition_Public_TerrainType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683205);
		NativeMethodInfoPtr_GetTerrainTypesForHeightmapPoint_Public_Void_Int32_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683206);
		NativeMethodInfoPtr_GetTerrainTypeAmountForHeightmapPoint_Public_Single_Int32_Int32_TerrainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683207);
		NativeMethodInfoPtr_SetTerrainTypesForHeightmapPoint_Public_Void_Int32_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683208);
		NativeMethodInfoPtr_GetDiseaseAmountAtPosition_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683209);
		NativeMethodInfoPtr_ShouldRefreshDiseaseMap_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683210);
		NativeMethodInfoPtr_cellCoordinatesValid_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683211);
		NativeMethodInfoPtr_GetCellEntities_Public_HashSet_1_Entity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683212);
		NativeMethodInfoPtr_GetCellEntities_Public_HashSet_1_Entity_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683213);
		NativeMethodInfoPtr_GetEntitiesWithComponent_Public_Void_ICollection_1_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683214);
		NativeMethodInfoPtr_GetEntitiesWithComponent_Public_HashSet_1_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683215);
		NativeMethodInfoPtr_GetEntitiesWithIdentifier_Public_HashSet_1_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683216);
		NativeMethodInfoPtr_IsQueuedDetailObjectCell_Public_Boolean_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683217);
		NativeMethodInfoPtr_RemoveQueuedDetailObjectCell_Public_Void_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683218);
		NativeMethodInfoPtr_ClearUpdatedCellCulling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683219);
		NativeMethodInfoPtr_WasCellCullingUpdated_Public_Boolean_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683220);
		NativeMethodInfoPtr_IsCellDetailsCulled_Public_Boolean_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683221);
		NativeMethodInfoPtr_AddTrackedPhysicsCell_Public_Void_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683222);
		NativeMethodInfoPtr_ClearPhysicsCells_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683223);
		NativeMethodInfoPtr_IsCellPhysicsTracked_Public_Boolean_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683224);
		NativeMethodInfoPtr_SetCellPhysics_Public_Void_Cell_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683225);
		NativeMethodInfoPtr_CullEverything_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683226);
		NativeMethodInfoPtr_SetTerrainCulled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683227);
		NativeMethodInfoPtr_SetWaterCulled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683228);
		NativeMethodInfoPtr_SetCellCulling_Public_Void_Cell_Coordinates_CellCulling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683229);
		NativeMethodInfoPtr_AddCellDetailPlacementInfo_Public_Void_Coordinates_DetailPlacementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683230);
		NativeMethodInfoPtr_GetCellDetailPlacementInfo_Public_List_1_DetailPlacementInfo_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683231);
		NativeMethodInfoPtr_ClearDetailPlacementInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683232);
		NativeMethodInfoPtr_ClearDetailPlacementInfo_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683233);
		NativeMethodInfoPtr_AddCellDetailObjects_Public_Void_Coordinates_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683234);
		NativeMethodInfoPtr_AddCellDetailRenderers_Public_Void_Coordinates_MeshRenderer_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683235);
		NativeMethodInfoPtr_GetCellDetailRenderers_Public_List_1_MeshRenderer_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683236);
		NativeMethodInfoPtr_AddSoundColliderObject_Public_Void_Coordinates_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683237);
		NativeMethodInfoPtr_AddEffectObject_Public_Void_Coordinates_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683238);
		NativeMethodInfoPtr_GetCellEffectObjects_Public_List_1_GameObject_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683239);
		NativeMethodInfoPtr_RefreshEntityVisibility_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683240);
		NativeMethodInfoPtr_refreshEntityVisibility_Private_Void_Entity_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683241);
		NativeMethodInfoPtr_isTallEntity_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683242);
		NativeMethodInfoPtr_setShortEntitiesCulled_Private_Void_Cell_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683243);
		NativeMethodInfoPtr_setTallEntitiesCulled_Private_Void_Cell_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683244);
		NativeMethodInfoPtr_shouldHideEntityWhenUnderground_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683245);
		NativeMethodInfoPtr_setEntityCulled_Private_Void_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683246);
		NativeMethodInfoPtr_setDetailsCulled_Private_Void_Cell_Coordinates_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683247);
		NativeMethodInfoPtr_setEffectObjectCulled_Private_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683248);
		NativeMethodInfoPtr_setEntityPhysics_Private_Void_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683249);
		NativeMethodInfoPtr_setSoundColliderPhysics_Private_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683250);
		NativeMethodInfoPtr_IsInChunk_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683251);
		NativeMethodInfoPtr_IsInChunk_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683252);
		NativeMethodInfoPtr_addCellEntity_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683253);
		NativeMethodInfoPtr_HandleObjectMovement_Public_Boolean_Entity_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683254);
		NativeMethodInfoPtr_removeCellEntity_Private_Void_Entity_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683255);
		NativeMethodInfoPtr_removeCellEntity_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683256);
		NativeMethodInfoPtr_QueuePendingEntityCreations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683257);
		NativeMethodInfoPtr_QueuePendingStructureCreations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683258);
		NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683259);
		NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683260);
		NativeMethodInfoPtr_GetCellPositionRatio_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683261);
		NativeMethodInfoPtr_GetCellCenterPosition_Public_Vector3_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683262);
		NativeMethodInfoPtr_GetCell_Public_Cell_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683263);
		NativeMethodInfoPtr_GetCellBounds_Public_Bounds_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683264);
		NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683265);
		NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683266);
		NativeMethodInfoPtr_GetSurroundingChunkCoordinates_Public_Il2CppReferenceArray_1_Il2CppStructArray_1_Coordinates_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683267);
		NativeMethodInfoPtr_UpdateTerrainLayerZone_Public_Void_TerrainLayerZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683268);
		NativeMethodInfoPtr_RemoveTerrainLayerZone_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683269);
		NativeMethodInfoPtr_GetEntities_Public_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683270);
		NativeMethodInfoPtr_SerializeEntities_Public_Void_List_1_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683271);
		NativeMethodInfoPtr_SetChunkData_Public_Void_ChunkData_ChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683272);
		NativeMethodInfoPtr_SetChunkCaveData_Public_Void_CaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683273);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chunk>.NativeClassPtr, 100683274);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 258695, RefRangeEnd = 258697, XrefRangeStart = 258676, XrefRangeEnd = 258695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Chunk(World world, Coordinates coordinates, ChunkInfo chunkInfo)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chunk>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_World_Coordinates_ChunkInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 258806, RefRangeEnd = 258808, XrefRangeStart = 258697, XrefRangeEnd = 258806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259011, RefRangeEnd = 259012, XrefRangeStart = 258808, XrefRangeEnd = 259011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259063, RefRangeEnd = 259065, XrefRangeStart = 259012, XrefRangeEnd = 259063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCellDetails(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCellDetails_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 259066, RefRangeEnd = 259096, XrefRangeStart = 259065, XrefRangeEnd = 259066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259096, XrefRangeEnd = 259098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RecentlyActivated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecentlyActivated_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259098, XrefRangeEnd = 259103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetOriginalHeight(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOriginalHeight_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259103, XrefRangeEnd = 259107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetOriginalHeight(float x, float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOriginalHeight_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 259108, RefRangeEnd = 259115, XrefRangeStart = 259107, XrefRangeEnd = 259108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHeight(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeight_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetHeight(TerrainPoint terrainPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&terrainPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeight_Public_Single_TerrainPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetHeight(int i, int j)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeight_Public_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 259119, RefRangeEnd = 259131, XrefRangeStart = 259115, XrefRangeEnd = 259119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetHeight(float x, float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeight_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259135, RefRangeEnd = 259137, XrefRangeStart = 259131, XrefRangeEnd = 259135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetRotationOnTerrain(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationOnTerrain_Public_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 259141, RefRangeEnd = 259145, XrefRangeStart = 259137, XrefRangeEnd = 259141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSlopeMagnitude(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSlopeMagnitude_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 259149, RefRangeEnd = 259152, XrefRangeStart = 259145, XrefRangeEnd = 259149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetSlope(float x, float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSlope_Public_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259153, RefRangeEnd = 259154, XrefRangeStart = 259152, XrefRangeEnd = 259153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWaterAmount(float x, float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWaterAmount_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259192, RefRangeEnd = 259194, XrefRangeStart = 259154, XrefRangeEnd = 259192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEntity_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259231, RefRangeEnd = 259233, XrefRangeStart = 259194, XrefRangeEnd = 259231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveEntity_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259246, RefRangeEnd = 259247, XrefRangeStart = 259233, XrefRangeEnd = 259246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWeight(string resourceIdentifier, float weightAdded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceIdentifier);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &weightAdded;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWeight_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259260, RefRangeEnd = 259261, XrefRangeStart = 259247, XrefRangeEnd = 259260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveWeight(string resourceIdentifier, float weightRemoved)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceIdentifier);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &weightRemoved;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveWeight_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 259262, RefRangeEnd = 259272, XrefRangeStart = 259261, XrefRangeEnd = 259262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionOnTerrain(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259273, RefRangeEnd = 259274, XrefRangeStart = 259272, XrefRangeEnd = 259273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionOnTerrain(TerrainPoint terrainPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&terrainPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_TerrainPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259277, RefRangeEnd = 259278, XrefRangeStart = 259274, XrefRangeEnd = 259277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionOnTerrainAndWater(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnTerrainAndWater_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector2 GetCenterPositionXZ()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCenterPositionXZ_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 259279, RefRangeEnd = 259292, XrefRangeStart = 259278, XrefRangeEnd = 259279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetCenterPositionOnTerrain()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCenterPositionOnTerrain_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259297, RefRangeEnd = 259298, XrefRangeStart = 259292, XrefRangeEnd = 259297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetCenterPositionOnTerrainAndWater()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCenterPositionOnTerrainAndWater_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 259301, RefRangeEnd = 259305, XrefRangeStart = 259298, XrefRangeEnd = 259301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetRandomPositionOnTerrain(float borderBuffer = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&borderBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomPositionOnTerrain_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259305, XrefRangeEnd = 259312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetRandomPositionOnTerrainAndWater(float borderBuffer = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&borderBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomPositionOnTerrainAndWater_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259312, XrefRangeEnd = 259323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetChunkPositionRatio(Vector2 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkPositionRatio_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 259334, RefRangeEnd = 259338, XrefRangeStart = 259323, XrefRangeEnd = 259334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetChunkPositionRatio(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkPositionRatio_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259346, RefRangeEnd = 259347, XrefRangeStart = 259338, XrefRangeEnd = 259346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshAlphamaps(int minI, int maxI, int minJ, int maxJ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&minI);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxI;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minJ;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxJ;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshAlphamaps_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259356, RefRangeEnd = 259357, XrefRangeStart = 259347, XrefRangeEnd = 259356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshClearedSnow(int minI, int maxI, int minJ, int maxJ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&minI);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxI;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minJ;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxJ;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshClearedSnow_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259368, RefRangeEnd = 259369, XrefRangeStart = 259357, XrefRangeEnd = 259368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshHeightmap(int minI, int minJ, int maxI, int maxJ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&minI);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minJ;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxI;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxJ;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshHeightmap_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259401, RefRangeEnd = 259403, XrefRangeStart = 259369, XrefRangeEnd = 259401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshTerrainPhysics(bool updateNavMesh = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&updateNavMesh);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshTerrainPhysics_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259408, RefRangeEnd = 259410, XrefRangeStart = 259403, XrefRangeEnd = 259408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTextureTypeAmountAtPosition(Vector3 position, TextureType textureType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(TextureType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureTypeAmountAtPosition_Public_Single_Vector3_TextureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 259416, RefRangeEnd = 259419, XrefRangeStart = 259410, XrefRangeEnd = 259416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureType GetTextureTypeAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureTypeAtPosition_Public_TextureType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TextureType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259427, RefRangeEnd = 259429, XrefRangeStart = 259419, XrefRangeEnd = 259427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool tryGetClampedAlphamapIndices(Vector3 position, out int alphamapI, out int alphamapJ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref alphamapI);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref alphamapJ);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tryGetClampedAlphamapIndices_Private_Boolean_Vector3_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259429, RefRangeEnd = 259431, XrefRangeStart = 259429, XrefRangeEnd = 259429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetClearedSnowAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClearedSnowAtPosition_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259431, XrefRangeEnd = 259444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetCaveCoordinates(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaveCoordinates_Public_Coordinates_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 259451, RefRangeEnd = 259464, XrefRangeStart = 259444, XrefRangeEnd = 259451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTerrainTypeAmount(Vector3 position, TerrainType terrainType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(TerrainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainTypeAmount_Public_Single_Vector3_TerrainType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259472, RefRangeEnd = 259473, XrefRangeStart = 259464, XrefRangeEnd = 259472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainType GetTerrainTypeAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainTypeAtPosition_Public_TerrainType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TerrainType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 259478, RefRangeEnd = 259481, XrefRangeStart = 259473, XrefRangeEnd = 259478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetTerrainTypesForHeightmapPoint(int heightmapI, int heightmapJ, Il2CppStructArray<float> resultTerrainTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&heightmapI);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultTerrainTypes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainTypesForHeightmapPoint_Public_Void_Int32_Int32_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259488, RefRangeEnd = 259490, XrefRangeStart = 259481, XrefRangeEnd = 259488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTerrainTypeAmountForHeightmapPoint(int heightmapI, int heightmapJ, TerrainType terrainType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&heightmapI);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(TerrainType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainTypeAmountForHeightmapPoint_Public_Single_Int32_Int32_TerrainType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259502, RefRangeEnd = 259503, XrefRangeStart = 259490, XrefRangeEnd = 259502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTerrainTypesForHeightmapPoint(int heightmapI, int heightmapJ, Il2CppStructArray<float> newTerrainTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&heightmapI);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTerrainTypes);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTerrainTypesForHeightmapPoint_Public_Void_Int32_Int32_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 259516, RefRangeEnd = 259520, XrefRangeStart = 259503, XrefRangeEnd = 259516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetDiseaseAmountAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiseaseAmountAtPosition_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259593, RefRangeEnd = 259594, XrefRangeStart = 259520, XrefRangeEnd = 259593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldRefreshDiseaseMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldRefreshDiseaseMap_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool cellCoordinatesValid(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cellCoordinatesValid_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259596, RefRangeEnd = 259597, XrefRangeStart = 259594, XrefRangeEnd = 259596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Entity> GetCellEntities(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellEntities_Public_HashSet_1_Entity_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 259599, RefRangeEnd = 259607, XrefRangeStart = 259597, XrefRangeEnd = 259599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Entity> GetCellEntities(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellEntities_Public_HashSet_1_Entity_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259628, RefRangeEnd = 259630, XrefRangeStart = 259607, XrefRangeEnd = 259628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetEntitiesWithComponent(ICollection<Entity> result, string componentName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(componentName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntitiesWithComponent_Public_Void_ICollection_1_Entity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259630, XrefRangeEnd = 259633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Entity> GetEntitiesWithComponent(string componentName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(componentName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntitiesWithComponent_Public_HashSet_1_Entity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259636, RefRangeEnd = 259638, XrefRangeStart = 259633, XrefRangeEnd = 259636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Entity> GetEntitiesWithIdentifier(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntitiesWithIdentifier_Public_HashSet_1_Entity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259642, RefRangeEnd = 259643, XrefRangeStart = 259638, XrefRangeEnd = 259642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsQueuedDetailObjectCell(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsQueuedDetailObjectCell_Public_Boolean_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259647, RefRangeEnd = 259648, XrefRangeStart = 259643, XrefRangeEnd = 259647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveQueuedDetailObjectCell(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveQueuedDetailObjectCell_Public_Void_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259652, RefRangeEnd = 259653, XrefRangeStart = 259648, XrefRangeEnd = 259652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearUpdatedCellCulling()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearUpdatedCellCulling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259657, RefRangeEnd = 259658, XrefRangeStart = 259653, XrefRangeEnd = 259657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WasCellCullingUpdated(Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WasCellCullingUpdated_Public_Boolean_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259658, RefRangeEnd = 259659, XrefRangeStart = 259658, XrefRangeEnd = 259658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCellDetailsCulled(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCellDetailsCulled_Public_Boolean_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259663, RefRangeEnd = 259664, XrefRangeStart = 259659, XrefRangeEnd = 259663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTrackedPhysicsCell(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTrackedPhysicsCell_Public_Void_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259668, RefRangeEnd = 259669, XrefRangeStart = 259664, XrefRangeEnd = 259668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearPhysicsCells()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearPhysicsCells_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259673, RefRangeEnd = 259674, XrefRangeStart = 259669, XrefRangeEnd = 259673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCellPhysicsTracked(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCellPhysicsTracked_Public_Boolean_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 259704, RefRangeEnd = 259707, XrefRangeStart = 259674, XrefRangeEnd = 259704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCellPhysics(Cell cell, bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enabled;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCellPhysics_Public_Void_Cell_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259720, RefRangeEnd = 259721, XrefRangeStart = 259707, XrefRangeEnd = 259720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CullEverything()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CullEverything_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259724, RefRangeEnd = 259726, XrefRangeStart = 259721, XrefRangeEnd = 259724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTerrainCulled(bool isCulled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isCulled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTerrainCulled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 259755, RefRangeEnd = 259760, XrefRangeStart = 259726, XrefRangeEnd = 259755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWaterCulled(bool isCulled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isCulled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWaterCulled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 259766, RefRangeEnd = 259769, XrefRangeStart = 259760, XrefRangeEnd = 259766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCellCulling(Cell cell, Coordinates cellCoordinates, CellCulling cellCulling)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellCoordinates;
		*(CellCulling**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellCulling;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCellCulling_Public_Void_Cell_Coordinates_CellCulling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259771, RefRangeEnd = 259772, XrefRangeStart = 259769, XrefRangeEnd = 259771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCellDetailPlacementInfo(Coordinates cellCoordinates, DetailPlacementInfo detailPlacementInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cellCoordinates);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)detailPlacementInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCellDetailPlacementInfo_Public_Void_Coordinates_DetailPlacementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259772, RefRangeEnd = 259773, XrefRangeStart = 259772, XrefRangeEnd = 259772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DetailPlacementInfo> GetCellDetailPlacementInfo(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellDetailPlacementInfo_Public_List_1_DetailPlacementInfo_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DetailPlacementInfo>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259773, XrefRangeEnd = 259777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearDetailPlacementInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearDetailPlacementInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259779, RefRangeEnd = 259780, XrefRangeStart = 259777, XrefRangeEnd = 259779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearDetailPlacementInfo(int cellX, int cellY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cellX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellY;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearDetailPlacementInfo_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259785, RefRangeEnd = 259786, XrefRangeStart = 259780, XrefRangeEnd = 259785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCellDetailObjects(Coordinates cellCoordinates, GameObject detailObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cellCoordinates);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)detailObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCellDetailObjects_Public_Void_Coordinates_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259793, RefRangeEnd = 259794, XrefRangeStart = 259786, XrefRangeEnd = 259793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCellDetailRenderers(Coordinates cellCoordinates, MeshRenderer meshRenderer, GameObject lodObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cellCoordinates);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lodObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCellDetailRenderers_Public_Void_Coordinates_MeshRenderer_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259794, RefRangeEnd = 259795, XrefRangeStart = 259794, XrefRangeEnd = 259794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<MeshRenderer> GetCellDetailRenderers(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellDetailRenderers_Public_List_1_MeshRenderer_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259801, RefRangeEnd = 259802, XrefRangeStart = 259795, XrefRangeEnd = 259801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSoundColliderObject(Coordinates cellCoordinates, GameObject soundColliderObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cellCoordinates);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundColliderObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSoundColliderObject_Public_Void_Coordinates_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259808, RefRangeEnd = 259810, XrefRangeStart = 259802, XrefRangeEnd = 259808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddEffectObject(Coordinates cellCoordinates, GameObject effectObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cellCoordinates);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEffectObject_Public_Void_Coordinates_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259810, RefRangeEnd = 259811, XrefRangeStart = 259810, XrefRangeEnd = 259810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GameObject> GetCellEffectObjects(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellEffectObjects_Public_List_1_GameObject_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259817, RefRangeEnd = 259818, XrefRangeStart = 259811, XrefRangeEnd = 259817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshEntityVisibility(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshEntityVisibility_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259818, XrefRangeEnd = 259821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void refreshEntityVisibility(Entity entity, Cell cell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_refreshEntityVisibility_Private_Void_Entity_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259821, XrefRangeEnd = 259822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isTallEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTallEntity_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259837, RefRangeEnd = 259838, XrefRangeStart = 259822, XrefRangeEnd = 259837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setShortEntitiesCulled(Cell cell, bool isCulled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCulled;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setShortEntitiesCulled_Private_Void_Cell_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259853, RefRangeEnd = 259854, XrefRangeStart = 259838, XrefRangeEnd = 259853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setTallEntitiesCulled(Cell cell, bool isCulled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCulled;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTallEntitiesCulled_Private_Void_Cell_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259865, RefRangeEnd = 259866, XrefRangeStart = 259854, XrefRangeEnd = 259865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool shouldHideEntityWhenUnderground(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_shouldHideEntityWhenUnderground_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 259898, RefRangeEnd = 259903, XrefRangeStart = 259866, XrefRangeEnd = 259898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setEntityCulled(Entity entity, bool isCulled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCulled;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEntityCulled_Private_Void_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 259935, RefRangeEnd = 259936, XrefRangeStart = 259903, XrefRangeEnd = 259935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setDetailsCulled(Cell cell, Coordinates cellCoordinates, bool isCulled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellCoordinates;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCulled;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDetailsCulled_Private_Void_Cell_Coordinates_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 259958, RefRangeEnd = 259960, XrefRangeStart = 259936, XrefRangeEnd = 259958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setEffectObjectCulled(GameObject effectObject, bool isCulled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectObject);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCulled;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEffectObjectCulled_Private_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 260018, RefRangeEnd = 260020, XrefRangeStart = 259960, XrefRangeEnd = 260018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setEntityPhysics(Entity entity, bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enabled;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEntityPhysics_Private_Void_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 260049, RefRangeEnd = 260051, XrefRangeStart = 260020, XrefRangeEnd = 260049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setSoundColliderPhysics(GameObject gameObject, bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enabled;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSoundColliderPhysics_Private_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 260051, RefRangeEnd = 260056, XrefRangeStart = 260051, XrefRangeEnd = 260051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsInChunk(float x, float z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInChunk_Public_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 260057, RefRangeEnd = 260062, XrefRangeStart = 260056, XrefRangeEnd = 260057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsInChunk(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInChunk_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 260094, RefRangeEnd = 260096, XrefRangeStart = 260062, XrefRangeEnd = 260094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addCellEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addCellEntity_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260125, RefRangeEnd = 260126, XrefRangeStart = 260096, XrefRangeEnd = 260125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleObjectMovement(Entity entity, float lastX, float lastZ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastX;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastZ;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleObjectMovement_Public_Boolean_Entity_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260126, XrefRangeEnd = 260145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeCellEntity(Entity entity, Coordinates lastCellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastCellCoordinates;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeCellEntity_Private_Void_Entity_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260145, XrefRangeEnd = 260153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeCellEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeCellEntity_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260170, RefRangeEnd = 260171, XrefRangeStart = 260153, XrefRangeEnd = 260170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueuePendingEntityCreations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueuePendingEntityCreations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 260189, RefRangeEnd = 260191, XrefRangeStart = 260171, XrefRangeEnd = 260189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueuePendingStructureCreations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueuePendingStructureCreations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260202, RefRangeEnd = 260203, XrefRangeStart = 260191, XrefRangeEnd = 260202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetCellCoordinates(int heightmapI, int heightmapJ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&heightmapI);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 260222, RefRangeEnd = 260233, XrefRangeStart = 260203, XrefRangeEnd = 260222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetCellCoordinates(float x, float z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 260246, RefRangeEnd = 260248, XrefRangeStart = 260233, XrefRangeEnd = 260246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetCellPositionRatio(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellPositionRatio_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 260249, RefRangeEnd = 260251, XrefRangeStart = 260248, XrefRangeEnd = 260249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetCellCenterPosition(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellCenterPosition_Public_Vector3_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 260251, RefRangeEnd = 260256, XrefRangeStart = 260251, XrefRangeEnd = 260251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cell GetCell(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCell_Public_Cell_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Cell>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260256, RefRangeEnd = 260257, XrefRangeStart = 260256, XrefRangeEnd = 260256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Bounds GetCellBounds(Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellBounds_Public_Bounds_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 260258, RefRangeEnd = 260269, XrefRangeStart = 260257, XrefRangeEnd = 260258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetCellCoordinates(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260269, XrefRangeEnd = 260272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetCellCoordinates(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260288, RefRangeEnd = 260289, XrefRangeStart = 260272, XrefRangeEnd = 260288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Il2CppStructArray<Coordinates>> GetSurroundingChunkCoordinates(int radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&radius);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSurroundingChunkCoordinates_Public_Il2CppReferenceArray_1_Il2CppStructArray_1_Coordinates_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<Coordinates>>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260293, RefRangeEnd = 260294, XrefRangeStart = 260289, XrefRangeEnd = 260293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTerrainLayerZone(TerrainLayerZone terrainLayerZone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainLayerZone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTerrainLayerZone_Public_Void_TerrainLayerZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260294, XrefRangeEnd = 260298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveTerrainLayerZone(int terrainLayerZoneMapId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&terrainLayerZoneMapId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveTerrainLayerZone_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe HashSet<Entity> GetEntities()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntities_Public_HashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 260329, RefRangeEnd = 260331, XrefRangeStart = 260298, XrefRangeEnd = 260329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SerializeEntities(List<SerializedEntity> serializedEntities)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializedEntities);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeEntities_Public_Void_List_1_SerializedEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 260340, RefRangeEnd = 260342, XrefRangeStart = 260331, XrefRangeEnd = 260340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetChunkData(ChunkData baseChunkData, ChunkData chunkData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseChunkData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChunkData_Public_Void_ChunkData_ChunkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetChunkCaveData(CaveData caveData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChunkCaveData_Public_Void_CaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260342, XrefRangeEnd = 260352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Chunk(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

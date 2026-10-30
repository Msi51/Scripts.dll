using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class Resource : Model
{
	private static readonly IntPtr NativeFieldInfoPtr_identifier;

	private static readonly IntPtr NativeFieldInfoPtr_prefabName;

	private static readonly IntPtr NativeFieldInfoPtr_name;

	private static readonly IntPtr NativeFieldInfoPtr_componentNames;

	private static readonly IntPtr NativeFieldInfoPtr_tallShadowCaster;

	private static readonly IntPtr NativeFieldInfoPtr_growablePhases;

	private static readonly IntPtr NativeFieldInfoPtr_growablePhaseResetIndex;

	private static readonly IntPtr NativeFieldInfoPtr_minablePieces;

	private static readonly IntPtr NativeFieldInfoPtr_removeLeaves;

	private static readonly IntPtr NativeFieldInfoPtr_removeLeavesEffectType;

	private static readonly IntPtr NativeFieldInfoPtr_restrictsToolTypeOnDamage;

	private static readonly IntPtr NativeFieldInfoPtr_resourceMinedResults;

	private static readonly IntPtr NativeFieldInfoPtr_leavesRemovedEffects;

	private static readonly IntPtr NativeFieldInfoPtr_mineProgressEffects;

	private static readonly IntPtr NativeFieldInfoPtr_panningResultDrops;

	private static readonly IntPtr NativeFieldInfoPtr_pickupableDrops;

	private static readonly IntPtr NativeFieldInfoPtr_dryingRate;

	private static readonly IntPtr NativeFieldInfoPtr_driedResourceIdentifier;

	private static readonly IntPtr NativeFieldInfoPtr_digUpItemIdentifiers;

	private static readonly IntPtr NativeFieldInfoPtr_fullFertilizationAddedGrowth;

	private static readonly IntPtr NativeFieldInfoPtr_targetSunlight;

	private static readonly IntPtr NativeFieldInfoPtr_targetSunlightRange;

	private static readonly IntPtr NativeFieldInfoPtr_winterResilience;

	private static readonly IntPtr NativeFieldInfoPtr_canMineFromBottom;

	private static readonly IntPtr NativeFieldInfoPtr_minePieceCenters;

	private static readonly IntPtr NativeFieldInfoPtr_miningShake;

	private static readonly IntPtr NativeFieldInfoPtr_terrainChangeBlockingSize;

	private static readonly IntPtr NativeFieldInfoPtr_removeOnGather;

	private static readonly IntPtr NativeFieldInfoPtr_shouldUseHoverPointSelection;

	private static readonly IntPtr NativeFieldInfoPtr_hideGrowingStatus;

	private static readonly IntPtr NativeFieldInfoPtr_navMeshObstacle;

	private static readonly IntPtr NativeFieldInfoPtr_navMeshObstacleRadius;

	private static readonly IntPtr NativeFieldInfoPtr_thumbnailSizeFactor;

	private static readonly IntPtr NativeFieldInfoPtr_thumbnailRotation;

	private static readonly IntPtr NativeFieldInfoPtr_thumbnailCameraAngle;

	private static readonly IntPtr NativeFieldInfoPtr_maxNumChildren;

	private static readonly IntPtr NativeFieldInfoPtr_childConnectionData;

	private static readonly IntPtr NativeFieldInfoPtr_chunkChildLimitWeights;

	private static readonly IntPtr NativeFieldInfoPtr_localizedName;

	private static readonly IntPtr NativeFieldInfoPtr_totalGrowthTime;

	private static readonly IntPtr NativeFieldInfoPtr_thumbnailTexture;

	private static readonly IntPtr NativeFieldInfoPtr_displayProperties;

	private static readonly IntPtr NativeFieldInfoPtr_ChildWeightMap;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_ModelDefinition_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddDisplayProperty_Public_Void_ModelDisplayProperty_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_List_1_ModelDisplayProperty_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRawName_Public_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLocalizedName_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsTallShadowCaster_Public_Virtual_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsDiscoverable_Public_Virtual_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ComponentNames_Public_get_HashSet_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_GrowablePhases_Public_get_List_1_GrowablePhase_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_GrowablePhaseResetIndex_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetGrowablePhases_Public_Void_List_1_GrowablePhase_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ResourceMinedResults_Public_get_List_1_ResourceMinedResult_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_LeavesRemovedEffects_Public_get_List_1_ResourceMinedEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MineProgressEffects_Public_get_List_1_ResourceMinedEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PanningResultDrops_Public_get_List_1_ItemDrop_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PickupableDrops_Public_get_List_1_ItemDrop_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DryingRate_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DriedResourceIdentifier_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DigUpItemIdentifiers_Public_get_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FullFertilizationAddedGrowth_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TargetSunlight_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TargetSunlightRange_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_WinterResilience_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CanMineFromBottom_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MinePieceCenters_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MiningShake_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_NumMinablePieces_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ShouldRemoveLeaves_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RemoveLeavesEffectType_Public_get_EffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RestrictsToolTypeOnDamage_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TerrainChangeBlockingSize_Public_get_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PrefabName_Public_Virtual_Final_New_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ShouldUseHoverPointSelection_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HideGrowingStatus_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_NavMeshObstacle_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_NavMeshObstacleRadius_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MaxNumChildren_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ChildConnectionData_Public_get_List_1_ChildResourceConnectionData_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ChunkChildLimitWeights_Public_get_List_1_ChunkResourceWeight_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetThumbnailSizeFactor_Public_Virtual_Final_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ThumbnailRotation_Public_Virtual_Final_New_get_Quaternion_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RemoveOnGather_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetThumbnailCameraAngle_Public_Virtual_Final_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetThumbnail_Public_Virtual_Final_New_Void_Texture2D_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetThumbnail_Public_Virtual_Final_New_Texture2D_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetThumbnailActivatedTransforms_Public_Virtual_Final_New_Il2CppStringArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetThumbnailDeactivatedTransforms_Public_Virtual_Final_New_Il2CppStringArray_0;

	public unsafe SerializableStringField identifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifier);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringField));
		}
	}

	public unsafe SerializableStringField prefabName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabName);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringField));
		}
	}

	public unsafe SerializableStringField name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringField));
		}
	}

	public unsafe SerializableStringHashSetField componentNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentNames);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringHashSetField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringHashSetField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> tallShadowCaster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tallShadowCaster);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tallShadowCaster)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe ReadOnlySerializableDictionaryListField<GrowablePhase> growablePhases
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growablePhases);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlySerializableDictionaryListField<GrowablePhase>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growablePhases)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlySerializableDictionaryListField));
		}
	}

	public unsafe SerializablePrimitiveField<int> growablePhaseResetIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growablePhaseResetIndex);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growablePhaseResetIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<int> minablePieces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minablePieces);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minablePieces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> removeLeaves
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeLeaves);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeLeaves)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializableEnumField<EffectType> removeLeavesEffectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeLeavesEffectType);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableEnumField<EffectType>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeLeavesEffectType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableEnumField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> restrictsToolTypeOnDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restrictsToolTypeOnDamage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_restrictsToolTypeOnDamage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe ReadOnlySerializableDictionaryListField<ResourceMinedResult> resourceMinedResults
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceMinedResults);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlySerializableDictionaryListField<ResourceMinedResult>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resourceMinedResults)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlySerializableDictionaryListField));
		}
	}

	public unsafe ReadOnlySerializableDictionaryListField<ResourceMinedEffect> leavesRemovedEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leavesRemovedEffects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlySerializableDictionaryListField<ResourceMinedEffect>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leavesRemovedEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlySerializableDictionaryListField));
		}
	}

	public unsafe ReadOnlySerializableDictionaryListField<ResourceMinedEffect> mineProgressEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mineProgressEffects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlySerializableDictionaryListField<ResourceMinedEffect>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mineProgressEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlySerializableDictionaryListField));
		}
	}

	public unsafe ReadOnlySerializableDictionaryListField<ItemDrop> panningResultDrops
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_panningResultDrops);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlySerializableDictionaryListField<ItemDrop>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_panningResultDrops)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlySerializableDictionaryListField));
		}
	}

	public unsafe ReadOnlySerializableDictionaryListField<ItemDrop> pickupableDrops
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickupableDrops);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlySerializableDictionaryListField<ItemDrop>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickupableDrops)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlySerializableDictionaryListField));
		}
	}

	public unsafe SerializablePrimitiveField<float> dryingRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dryingRate);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dryingRate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializableStringField driedResourceIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_driedResourceIdentifier);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_driedResourceIdentifier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringField));
		}
	}

	public unsafe SerializableStringListField digUpItemIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_digUpItemIdentifiers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringListField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_digUpItemIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringListField));
		}
	}

	public unsafe SerializablePrimitiveField<float> fullFertilizationAddedGrowth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullFertilizationAddedGrowth);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullFertilizationAddedGrowth)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> targetSunlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSunlight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSunlight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> targetSunlightRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSunlightRange);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSunlightRange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> winterResilience
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winterResilience);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winterResilience)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> canMineFromBottom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canMineFromBottom);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canMineFromBottom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> minePieceCenters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minePieceCenters);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minePieceCenters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> miningShake
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miningShake);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miningShake)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializableVector2Field terrainChangeBlockingSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainChangeBlockingSize);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableVector2Field>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainChangeBlockingSize)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableVector2Field));
		}
	}

	public unsafe SerializablePrimitiveField<bool> removeOnGather
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeOnGather);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeOnGather)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> shouldUseHoverPointSelection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shouldUseHoverPointSelection);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shouldUseHoverPointSelection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> hideGrowingStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideGrowingStatus);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideGrowingStatus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> navMeshObstacle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshObstacle);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshObstacle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> navMeshObstacleRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshObstacleRadius);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshObstacleRadius)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<float> thumbnailSizeFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnailSizeFactor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnailSizeFactor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializableVector3Field thumbnailRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnailRotation);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableVector3Field>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnailRotation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableVector3Field));
		}
	}

	public unsafe SerializablePrimitiveField<float> thumbnailCameraAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnailCameraAngle);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnailCameraAngle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe SerializablePrimitiveField<int> maxNumChildren
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNumChildren);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxNumChildren)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe ReadOnlySerializableDictionaryListField<ChildResourceConnectionData> childConnectionData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childConnectionData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlySerializableDictionaryListField<ChildResourceConnectionData>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childConnectionData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlySerializableDictionaryListField));
		}
	}

	public unsafe ReadOnlySerializableDictionaryListField<ChunkResourceWeight> chunkChildLimitWeights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkChildLimitWeights);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlySerializableDictionaryListField<ChunkResourceWeight>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkChildLimitWeights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlySerializableDictionaryListField));
		}
	}

	public unsafe string localizedName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float totalGrowthTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalGrowthTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalGrowthTime)) = num;
		}
	}

	public unsafe Texture2D thumbnailTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnailTexture);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thumbnailTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe List<ModelDisplayProperty> displayProperties
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayProperties);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ModelDisplayProperty>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayProperties)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<string, float> ChildWeightMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChildWeightMap);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChildWeightMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe override string Identifier
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224882, XrefRangeEnd = 224883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override string Name
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe override bool IsTallShadowCaster
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224885, XrefRangeEnd = 224886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_IsTallShadowCaster_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe override bool IsDiscoverable
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 27783, RefRangeEnd = 27926, XrefRangeStart = 27783, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_IsDiscoverable_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe HashSet<string> ComponentNames
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 224887, RefRangeEnd = 224891, XrefRangeStart = 224886, XrefRangeEnd = 224887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ComponentNames_Public_get_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
	}

	public unsafe List<GrowablePhase> GrowablePhases
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 224892, RefRangeEnd = 224914, XrefRangeStart = 224891, XrefRangeEnd = 224892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GrowablePhases_Public_get_List_1_GrowablePhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GrowablePhase>>(intPtr) : null;
		}
	}

	public unsafe int GrowablePhaseResetIndex
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224915, RefRangeEnd = 224917, XrefRangeStart = 224914, XrefRangeEnd = 224915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GrowablePhaseResetIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe List<ResourceMinedResult> ResourceMinedResults
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224939, RefRangeEnd = 224940, XrefRangeStart = 224938, XrefRangeEnd = 224939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ResourceMinedResults_Public_get_List_1_ResourceMinedResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ResourceMinedResult>>(intPtr) : null;
		}
	}

	public unsafe List<ResourceMinedEffect> LeavesRemovedEffects
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224941, RefRangeEnd = 224942, XrefRangeStart = 224940, XrefRangeEnd = 224941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LeavesRemovedEffects_Public_get_List_1_ResourceMinedEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ResourceMinedEffect>>(intPtr) : null;
		}
	}

	public unsafe List<ResourceMinedEffect> MineProgressEffects
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224943, RefRangeEnd = 224945, XrefRangeStart = 224942, XrefRangeEnd = 224943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MineProgressEffects_Public_get_List_1_ResourceMinedEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ResourceMinedEffect>>(intPtr) : null;
		}
	}

	public unsafe List<ItemDrop> PanningResultDrops
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224946, RefRangeEnd = 224948, XrefRangeStart = 224945, XrefRangeEnd = 224946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PanningResultDrops_Public_get_List_1_ItemDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ItemDrop>>(intPtr) : null;
		}
	}

	public unsafe List<ItemDrop> PickupableDrops
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224948, XrefRangeEnd = 224949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PickupableDrops_Public_get_List_1_ItemDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ItemDrop>>(intPtr) : null;
		}
	}

	public unsafe float DryingRate
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224950, RefRangeEnd = 224952, XrefRangeStart = 224949, XrefRangeEnd = 224950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DryingRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe string DriedResourceIdentifier
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 224953, RefRangeEnd = 224957, XrefRangeStart = 224952, XrefRangeEnd = 224953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DriedResourceIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe List<string> DigUpItemIdentifiers
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224958, RefRangeEnd = 224960, XrefRangeStart = 224957, XrefRangeEnd = 224958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DigUpItemIdentifiers_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
	}

	public unsafe float FullFertilizationAddedGrowth
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224961, RefRangeEnd = 224962, XrefRangeStart = 224960, XrefRangeEnd = 224961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FullFertilizationAddedGrowth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float TargetSunlight
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224963, RefRangeEnd = 224966, XrefRangeStart = 224962, XrefRangeEnd = 224963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetSunlight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float TargetSunlightRange
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224967, RefRangeEnd = 224969, XrefRangeStart = 224966, XrefRangeEnd = 224967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetSunlightRange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float WinterResilience
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224970, RefRangeEnd = 224972, XrefRangeStart = 224969, XrefRangeEnd = 224970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WinterResilience_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool CanMineFromBottom
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224973, RefRangeEnd = 224976, XrefRangeStart = 224972, XrefRangeEnd = 224973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CanMineFromBottom_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool MinePieceCenters
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224977, RefRangeEnd = 224978, XrefRangeStart = 224976, XrefRangeEnd = 224977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MinePieceCenters_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool MiningShake
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224979, RefRangeEnd = 224980, XrefRangeStart = 224978, XrefRangeEnd = 224979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MiningShake_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int NumMinablePieces
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 224981, RefRangeEnd = 224986, XrefRangeStart = 224980, XrefRangeEnd = 224981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NumMinablePieces_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool ShouldRemoveLeaves
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224987, RefRangeEnd = 224990, XrefRangeStart = 224986, XrefRangeEnd = 224987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShouldRemoveLeaves_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe EffectType RemoveLeavesEffectType
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224991, RefRangeEnd = 224992, XrefRangeStart = 224990, XrefRangeEnd = 224991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RemoveLeavesEffectType_Public_get_EffectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(EffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool RestrictsToolTypeOnDamage
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224993, RefRangeEnd = 224994, XrefRangeStart = 224992, XrefRangeEnd = 224993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RestrictsToolTypeOnDamage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Vector2 TerrainChangeBlockingSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224995, RefRangeEnd = 224996, XrefRangeStart = 224994, XrefRangeEnd = 224995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TerrainChangeBlockingSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe virtual string PrefabName
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224997, RefRangeEnd = 225000, XrefRangeStart = 224996, XrefRangeEnd = 224997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PrefabName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe bool ShouldUseHoverPointSelection
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225001, RefRangeEnd = 225002, XrefRangeStart = 225000, XrefRangeEnd = 225001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShouldUseHoverPointSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HideGrowingStatus
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 225003, RefRangeEnd = 225005, XrefRangeStart = 225002, XrefRangeEnd = 225003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HideGrowingStatus_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool NavMeshObstacle
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 225006, RefRangeEnd = 225008, XrefRangeStart = 225005, XrefRangeEnd = 225006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NavMeshObstacle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float NavMeshObstacleRadius
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 225009, RefRangeEnd = 225011, XrefRangeStart = 225008, XrefRangeEnd = 225009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NavMeshObstacleRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe int MaxNumChildren
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 225012, RefRangeEnd = 225014, XrefRangeStart = 225011, XrefRangeEnd = 225012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxNumChildren_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe List<ChildResourceConnectionData> ChildConnectionData
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 225015, RefRangeEnd = 225021, XrefRangeStart = 225014, XrefRangeEnd = 225015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ChildConnectionData_Public_get_List_1_ChildResourceConnectionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ChildResourceConnectionData>>(intPtr) : null;
		}
	}

	public unsafe List<ChunkResourceWeight> ChunkChildLimitWeights
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225022, RefRangeEnd = 225023, XrefRangeStart = 225021, XrefRangeEnd = 225022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ChunkChildLimitWeights_Public_get_List_1_ChunkResourceWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ChunkResourceWeight>>(intPtr) : null;
		}
	}

	public unsafe virtual Quaternion ThumbnailRotation
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225024, XrefRangeEnd = 225026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ThumbnailRotation_Public_Virtual_Final_New_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool RemoveOnGather
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 225027, RefRangeEnd = 225029, XrefRangeStart = 225026, XrefRangeEnd = 225027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RemoveOnGather_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static Resource()
	{
		Il2CppClassPointerStore<Resource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "Resource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resource>.NativeClassPtr);
		NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "identifier");
		NativeFieldInfoPtr_prefabName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "prefabName");
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "name");
		NativeFieldInfoPtr_componentNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "componentNames");
		NativeFieldInfoPtr_tallShadowCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "tallShadowCaster");
		NativeFieldInfoPtr_growablePhases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "growablePhases");
		NativeFieldInfoPtr_growablePhaseResetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "growablePhaseResetIndex");
		NativeFieldInfoPtr_minablePieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "minablePieces");
		NativeFieldInfoPtr_removeLeaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "removeLeaves");
		NativeFieldInfoPtr_removeLeavesEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "removeLeavesEffectType");
		NativeFieldInfoPtr_restrictsToolTypeOnDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "restrictsToolTypeOnDamage");
		NativeFieldInfoPtr_resourceMinedResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "resourceMinedResults");
		NativeFieldInfoPtr_leavesRemovedEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "leavesRemovedEffects");
		NativeFieldInfoPtr_mineProgressEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "mineProgressEffects");
		NativeFieldInfoPtr_panningResultDrops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "panningResultDrops");
		NativeFieldInfoPtr_pickupableDrops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "pickupableDrops");
		NativeFieldInfoPtr_dryingRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "dryingRate");
		NativeFieldInfoPtr_driedResourceIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "driedResourceIdentifier");
		NativeFieldInfoPtr_digUpItemIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "digUpItemIdentifiers");
		NativeFieldInfoPtr_fullFertilizationAddedGrowth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "fullFertilizationAddedGrowth");
		NativeFieldInfoPtr_targetSunlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "targetSunlight");
		NativeFieldInfoPtr_targetSunlightRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "targetSunlightRange");
		NativeFieldInfoPtr_winterResilience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "winterResilience");
		NativeFieldInfoPtr_canMineFromBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "canMineFromBottom");
		NativeFieldInfoPtr_minePieceCenters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "minePieceCenters");
		NativeFieldInfoPtr_miningShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "miningShake");
		NativeFieldInfoPtr_terrainChangeBlockingSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "terrainChangeBlockingSize");
		NativeFieldInfoPtr_removeOnGather = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "removeOnGather");
		NativeFieldInfoPtr_shouldUseHoverPointSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "shouldUseHoverPointSelection");
		NativeFieldInfoPtr_hideGrowingStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "hideGrowingStatus");
		NativeFieldInfoPtr_navMeshObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "navMeshObstacle");
		NativeFieldInfoPtr_navMeshObstacleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "navMeshObstacleRadius");
		NativeFieldInfoPtr_thumbnailSizeFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "thumbnailSizeFactor");
		NativeFieldInfoPtr_thumbnailRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "thumbnailRotation");
		NativeFieldInfoPtr_thumbnailCameraAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "thumbnailCameraAngle");
		NativeFieldInfoPtr_maxNumChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "maxNumChildren");
		NativeFieldInfoPtr_childConnectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "childConnectionData");
		NativeFieldInfoPtr_chunkChildLimitWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "chunkChildLimitWeights");
		NativeFieldInfoPtr_localizedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "localizedName");
		NativeFieldInfoPtr_totalGrowthTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "totalGrowthTime");
		NativeFieldInfoPtr_thumbnailTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "thumbnailTexture");
		NativeFieldInfoPtr_displayProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "displayProperties");
		NativeFieldInfoPtr_ChildWeightMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resource>.NativeClassPtr, "ChildWeightMap");
		NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678364);
		NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_ModelDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678365);
		NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678366);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678367);
		NativeMethodInfoPtr_AddDisplayProperty_Public_Void_ModelDisplayProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678368);
		NativeMethodInfoPtr_GetProperties_Public_List_1_ModelDisplayProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678369);
		NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678370);
		NativeMethodInfoPtr_GetRawName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678371);
		NativeMethodInfoPtr_SetLocalizedName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678372);
		NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678373);
		NativeMethodInfoPtr_get_IsTallShadowCaster_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678374);
		NativeMethodInfoPtr_get_IsDiscoverable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678375);
		NativeMethodInfoPtr_get_ComponentNames_Public_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678376);
		NativeMethodInfoPtr_get_GrowablePhases_Public_get_List_1_GrowablePhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678377);
		NativeMethodInfoPtr_get_GrowablePhaseResetIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678378);
		NativeMethodInfoPtr_SetGrowablePhases_Public_Void_List_1_GrowablePhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678379);
		NativeMethodInfoPtr_get_ResourceMinedResults_Public_get_List_1_ResourceMinedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678380);
		NativeMethodInfoPtr_get_LeavesRemovedEffects_Public_get_List_1_ResourceMinedEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678381);
		NativeMethodInfoPtr_get_MineProgressEffects_Public_get_List_1_ResourceMinedEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678382);
		NativeMethodInfoPtr_get_PanningResultDrops_Public_get_List_1_ItemDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678383);
		NativeMethodInfoPtr_get_PickupableDrops_Public_get_List_1_ItemDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678384);
		NativeMethodInfoPtr_get_DryingRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678385);
		NativeMethodInfoPtr_get_DriedResourceIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678386);
		NativeMethodInfoPtr_get_DigUpItemIdentifiers_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678387);
		NativeMethodInfoPtr_get_FullFertilizationAddedGrowth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678388);
		NativeMethodInfoPtr_get_TargetSunlight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678389);
		NativeMethodInfoPtr_get_TargetSunlightRange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678390);
		NativeMethodInfoPtr_get_WinterResilience_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678391);
		NativeMethodInfoPtr_get_CanMineFromBottom_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678392);
		NativeMethodInfoPtr_get_MinePieceCenters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678393);
		NativeMethodInfoPtr_get_MiningShake_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678394);
		NativeMethodInfoPtr_get_NumMinablePieces_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678395);
		NativeMethodInfoPtr_get_ShouldRemoveLeaves_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678396);
		NativeMethodInfoPtr_get_RemoveLeavesEffectType_Public_get_EffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678397);
		NativeMethodInfoPtr_get_RestrictsToolTypeOnDamage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678398);
		NativeMethodInfoPtr_get_TerrainChangeBlockingSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678399);
		NativeMethodInfoPtr_get_PrefabName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678400);
		NativeMethodInfoPtr_get_ShouldUseHoverPointSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678401);
		NativeMethodInfoPtr_get_HideGrowingStatus_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678402);
		NativeMethodInfoPtr_get_NavMeshObstacle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678403);
		NativeMethodInfoPtr_get_NavMeshObstacleRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678404);
		NativeMethodInfoPtr_get_MaxNumChildren_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678405);
		NativeMethodInfoPtr_get_ChildConnectionData_Public_get_List_1_ChildResourceConnectionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678406);
		NativeMethodInfoPtr_get_ChunkChildLimitWeights_Public_get_List_1_ChunkResourceWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678407);
		NativeMethodInfoPtr_GetThumbnailSizeFactor_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678408);
		NativeMethodInfoPtr_get_ThumbnailRotation_Public_Virtual_Final_New_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678409);
		NativeMethodInfoPtr_get_RemoveOnGather_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678410);
		NativeMethodInfoPtr_GetThumbnailCameraAngle_Public_Virtual_Final_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678411);
		NativeMethodInfoPtr_SetThumbnail_Public_Virtual_Final_New_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678412);
		NativeMethodInfoPtr_GetThumbnail_Public_Virtual_Final_New_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678413);
		NativeMethodInfoPtr_GetThumbnailActivatedTransforms_Public_Virtual_Final_New_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678414);
		NativeMethodInfoPtr_GetThumbnailDeactivatedTransforms_Public_Virtual_Final_New_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resource>.NativeClassPtr, 100678415);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 95788, RefRangeEnd = 95815, XrefRangeStart = 95788, XrefRangeEnd = 95815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Resource(ModelDefinition definition)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Resource>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)definition);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 224021, RefRangeEnd = 224026, XrefRangeStart = 224021, XrefRangeEnd = 224026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Resource(ModelDefinition baseDefinition, ModelDefinition definitionOverrides)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Resource>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseDefinition);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)definitionOverrides);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_ModelDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224693, XrefRangeEnd = 224863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeSerializableFields(SerializationContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224863, XrefRangeEnd = 224872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 224874, RefRangeEnd = 224882, XrefRangeStart = 224872, XrefRangeEnd = 224874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDisplayProperty(ModelDisplayProperty property)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)property));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDisplayProperty_Public_Void_ModelDisplayProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe List<ModelDisplayProperty> GetProperties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProperties_Public_List_1_ModelDisplayProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ModelDisplayProperty>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224884, RefRangeEnd = 224885, XrefRangeStart = 224883, XrefRangeEnd = 224884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetRawName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRawName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalizedName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalizedName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224937, RefRangeEnd = 224938, XrefRangeStart = 224917, XrefRangeEnd = 224937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGrowablePhases(List<GrowablePhase> growablePhases)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)growablePhases);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGrowablePhases_Public_Void_List_1_GrowablePhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225023, XrefRangeEnd = 225024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetThumbnailSizeFactor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThumbnailSizeFactor_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225029, XrefRangeEnd = 225030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float GetThumbnailCameraAngle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThumbnailCameraAngle_Public_Virtual_Final_New_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetThumbnail(Texture2D texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetThumbnail_Public_Virtual_Final_New_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Texture2D GetThumbnail()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThumbnail_Public_Virtual_Final_New_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppStringArray GetThumbnailActivatedTransforms()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThumbnailActivatedTransforms_Public_Virtual_Final_New_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppStringArray GetThumbnailDeactivatedTransforms()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetThumbnailDeactivatedTransforms_Public_Virtual_Final_New_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public Resource(IntPtr pointer)
		: base(pointer)
	{
	}
}

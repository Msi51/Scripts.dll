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

[System.Serializable]
public class ChunkInfo : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_sampledTerrainTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_cornerHeights;

	private static readonly System.IntPtr NativeFieldInfoPtr_averageSampledHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowestSampledHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDryness;

	private static readonly System.IntPtr NativeFieldInfoPtr_islandAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_containsRiver;

	private static readonly System.IntPtr NativeFieldInfoPtr_riverStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_riverEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_riverDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_riverDirectionBack;

	private static readonly System.IntPtr NativeFieldInfoPtr_numRiverBranches;

	private static readonly System.IntPtr NativeFieldInfoPtr_riverBranchDirection1;

	private static readonly System.IntPtr NativeFieldInfoPtr_riverBranchDirection2;

	private static readonly System.IntPtr NativeFieldInfoPtr_containsRoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_roadDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_roadDirectionBack;

	private static readonly System.IntPtr NativeFieldInfoPtr_roadStartDirections;

	private static readonly System.IntPtr NativeFieldInfoPtr_roadEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_numRoadBranches;

	private static readonly System.IntPtr NativeFieldInfoPtr_roadBranchDirection1;

	private static readonly System.IntPtr NativeFieldInfoPtr_roadBranchDirection2;

	private static readonly System.IntPtr NativeFieldInfoPtr_containsVillage;

	private static readonly System.IntPtr NativeFieldInfoPtr_villageExtension;

	private static readonly System.IntPtr NativeFieldInfoPtr_villageOriginCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_capitalCity;

	private static readonly System.IntPtr NativeFieldInfoPtr_containsSwamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_swampRelativeCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_containsBridge;

	private static readonly System.IntPtr NativeFieldInfoPtr_containsCave;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveOriginRelativeCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_containsCliff;

	private static readonly System.IntPtr NativeFieldInfoPtr_cliffOriginRelativeCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearbyFeatures;

	private static readonly System.IntPtr NativeFieldInfoPtr_featuresToGenerate;

	private static readonly System.IntPtr NativeFieldInfoPtr_structuresToPlace;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CaveEntranceHeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsWater_Public_Boolean_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsLake_Public_Boolean_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsIsland_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsSea_Public_Boolean_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsTerrainType_Public_Boolean_World_TerrainType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainTypeAmount_Public_Single_World_TerrainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFeatureToGenerate_Public_Void_IWorldGenerationFeatureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFeatureToGenerate_Public_Boolean_WorldGenerationFeatureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddStructureToPlace_Public_Void_StructurePlacementInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNearbyFeature_Public_Void_ChunkInfoFeatureType_ChunkInfoFeature_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasNearbyFeature_Public_Boolean_ChunkInfoFeatureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearbyFeatures_Public_List_1_ChunkInfoFeature_ChunkInfoFeatureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountNearbyFeatures_Public_Int32_ChunkInfoFeatureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestFeature_Public_Boolean_ChunkInfoFeatureType_Coordinates_byref_ChunkInfoFeature_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStructArray<float> sampledTerrainTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampledTerrainTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampledTerrainTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<float> cornerHeights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cornerHeights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cornerHeights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe float averageSampledHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageSampledHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageSampledHeight)) = num;
		}
	}

	public unsafe float lowestSampledHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowestSampledHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowestSampledHeight)) = num;
		}
	}

	public unsafe float worldDryness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDryness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDryness)) = num;
		}
	}

	public unsafe float islandAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_islandAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_islandAmount)) = num;
		}
	}

	public unsafe bool containsRiver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsRiver);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsRiver)) = flag;
		}
	}

	public unsafe bool riverStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverStart)) = flag;
		}
	}

	public unsafe bool riverEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverEnd);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverEnd)) = flag;
		}
	}

	public unsafe Vector2Int riverDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverDirection);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverDirection)) = vector2Int;
		}
	}

	public unsafe Vector2Int riverDirectionBack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverDirectionBack);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverDirectionBack)) = vector2Int;
		}
	}

	public unsafe int numRiverBranches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numRiverBranches);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numRiverBranches)) = num;
		}
	}

	public unsafe Vector2Int riverBranchDirection1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverBranchDirection1);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverBranchDirection1)) = vector2Int;
		}
	}

	public unsafe Vector2Int riverBranchDirection2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverBranchDirection2);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_riverBranchDirection2)) = vector2Int;
		}
	}

	public unsafe bool containsRoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsRoad);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsRoad)) = flag;
		}
	}

	public unsafe Vector2Int roadDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadDirection);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadDirection)) = vector2Int;
		}
	}

	public unsafe Vector2Int roadDirectionBack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadDirectionBack);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadDirectionBack)) = vector2Int;
		}
	}

	public unsafe HashSet<Vector2> roadStartDirections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadStartDirections);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Vector2>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadStartDirections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe bool roadEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadEnd);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadEnd)) = flag;
		}
	}

	public unsafe int numRoadBranches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numRoadBranches);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numRoadBranches)) = num;
		}
	}

	public unsafe Vector2Int roadBranchDirection1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadBranchDirection1);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadBranchDirection1)) = vector2Int;
		}
	}

	public unsafe Vector2Int roadBranchDirection2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadBranchDirection2);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roadBranchDirection2)) = vector2Int;
		}
	}

	public unsafe bool containsVillage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsVillage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsVillage)) = flag;
		}
	}

	public unsafe bool villageExtension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villageExtension);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villageExtension)) = flag;
		}
	}

	public unsafe Coordinates villageOriginCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villageOriginCoordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villageOriginCoordinates)) = coordinates;
		}
	}

	public unsafe bool capitalCity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capitalCity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capitalCity)) = flag;
		}
	}

	public unsafe bool containsSwamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsSwamp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsSwamp)) = flag;
		}
	}

	public unsafe Vector2 swampRelativeCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_swampRelativeCenter);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_swampRelativeCenter)) = vector;
		}
	}

	public unsafe bool containsBridge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsBridge);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsBridge)) = flag;
		}
	}

	public unsafe bool containsCave
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsCave);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsCave)) = flag;
		}
	}

	public unsafe Vector2 caveOriginRelativeCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveOriginRelativeCenter);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveOriginRelativeCenter)) = vector;
		}
	}

	public unsafe bool containsCliff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsCliff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containsCliff)) = flag;
		}
	}

	public unsafe Vector2 cliffOriginRelativeCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cliffOriginRelativeCenter);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cliffOriginRelativeCenter)) = vector;
		}
	}

	public unsafe Dictionary<ChunkInfoFeatureType, List<ChunkInfoFeature>> nearbyFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearbyFeatures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ChunkInfoFeatureType, List<ChunkInfoFeature>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearbyFeatures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<IWorldGenerationFeatureInfo> featuresToGenerate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featuresToGenerate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IWorldGenerationFeatureInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featuresToGenerate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StructurePlacementInfo> structuresToPlace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_structuresToPlace);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StructurePlacementInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_structuresToPlace)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float CaveEntranceHeight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CaveEntranceHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsIsland
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 260558, RefRangeEnd = 260567, XrefRangeStart = 260558, XrefRangeEnd = 260558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsIsland_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ChunkInfo()
	{
		Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChunkInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr);
		NativeFieldInfoPtr_sampledTerrainTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "sampledTerrainTypes");
		NativeFieldInfoPtr_cornerHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "cornerHeights");
		NativeFieldInfoPtr_averageSampledHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "averageSampledHeight");
		NativeFieldInfoPtr_lowestSampledHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "lowestSampledHeight");
		NativeFieldInfoPtr_worldDryness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "worldDryness");
		NativeFieldInfoPtr_islandAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "islandAmount");
		NativeFieldInfoPtr_containsRiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "containsRiver");
		NativeFieldInfoPtr_riverStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "riverStart");
		NativeFieldInfoPtr_riverEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "riverEnd");
		NativeFieldInfoPtr_riverDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "riverDirection");
		NativeFieldInfoPtr_riverDirectionBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "riverDirectionBack");
		NativeFieldInfoPtr_numRiverBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "numRiverBranches");
		NativeFieldInfoPtr_riverBranchDirection1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "riverBranchDirection1");
		NativeFieldInfoPtr_riverBranchDirection2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "riverBranchDirection2");
		NativeFieldInfoPtr_containsRoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "containsRoad");
		NativeFieldInfoPtr_roadDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "roadDirection");
		NativeFieldInfoPtr_roadDirectionBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "roadDirectionBack");
		NativeFieldInfoPtr_roadStartDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "roadStartDirections");
		NativeFieldInfoPtr_roadEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "roadEnd");
		NativeFieldInfoPtr_numRoadBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "numRoadBranches");
		NativeFieldInfoPtr_roadBranchDirection1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "roadBranchDirection1");
		NativeFieldInfoPtr_roadBranchDirection2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "roadBranchDirection2");
		NativeFieldInfoPtr_containsVillage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "containsVillage");
		NativeFieldInfoPtr_villageExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "villageExtension");
		NativeFieldInfoPtr_villageOriginCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "villageOriginCoordinates");
		NativeFieldInfoPtr_capitalCity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "capitalCity");
		NativeFieldInfoPtr_containsSwamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "containsSwamp");
		NativeFieldInfoPtr_swampRelativeCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "swampRelativeCenter");
		NativeFieldInfoPtr_containsBridge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "containsBridge");
		NativeFieldInfoPtr_containsCave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "containsCave");
		NativeFieldInfoPtr_caveOriginRelativeCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "caveOriginRelativeCenter");
		NativeFieldInfoPtr_containsCliff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "containsCliff");
		NativeFieldInfoPtr_cliffOriginRelativeCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "cliffOriginRelativeCenter");
		NativeFieldInfoPtr_nearbyFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "nearbyFeatures");
		NativeFieldInfoPtr_featuresToGenerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "featuresToGenerate");
		NativeFieldInfoPtr_structuresToPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, "structuresToPlace");
		NativeMethodInfoPtr_get_CaveEntranceHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683289);
		NativeMethodInfoPtr_ContainsWater_Public_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683290);
		NativeMethodInfoPtr_ContainsLake_Public_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683291);
		NativeMethodInfoPtr_get_IsIsland_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683292);
		NativeMethodInfoPtr_ContainsSea_Public_Boolean_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683293);
		NativeMethodInfoPtr_ContainsTerrainType_Public_Boolean_World_TerrainType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683294);
		NativeMethodInfoPtr_GetTerrainTypeAmount_Public_Single_World_TerrainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683295);
		NativeMethodInfoPtr_AddFeatureToGenerate_Public_Void_IWorldGenerationFeatureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683296);
		NativeMethodInfoPtr_HasFeatureToGenerate_Public_Boolean_WorldGenerationFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683297);
		NativeMethodInfoPtr_AddStructureToPlace_Public_Void_StructurePlacementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683298);
		NativeMethodInfoPtr_AddNearbyFeature_Public_Void_ChunkInfoFeatureType_ChunkInfoFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683299);
		NativeMethodInfoPtr_HasNearbyFeature_Public_Boolean_ChunkInfoFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683300);
		NativeMethodInfoPtr_GetNearbyFeatures_Public_List_1_ChunkInfoFeature_ChunkInfoFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683301);
		NativeMethodInfoPtr_CountNearbyFeatures_Public_Int32_ChunkInfoFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683302);
		NativeMethodInfoPtr_GetClosestFeature_Public_Boolean_ChunkInfoFeatureType_Coordinates_byref_ChunkInfoFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683303);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683304);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683305);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr, 100683306);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 260535, RefRangeEnd = 260548, XrefRangeStart = 260535, XrefRangeEnd = 260535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsWater(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsWater_Public_Boolean_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 260548, RefRangeEnd = 260558, XrefRangeStart = 260548, XrefRangeEnd = 260548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsLake(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsLake_Public_Boolean_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 260570, RefRangeEnd = 260583, XrefRangeStart = 260567, XrefRangeEnd = 260570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsSea(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsSea_Public_Boolean_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 260586, RefRangeEnd = 260595, XrefRangeStart = 260583, XrefRangeEnd = 260586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ContainsTerrainType(World world, TerrainType terrainType, float threshold)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(TerrainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainType;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &threshold;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsTerrainType_Public_Boolean_World_TerrainType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 260598, RefRangeEnd = 260600, XrefRangeStart = 260595, XrefRangeEnd = 260598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTerrainTypeAmount(World world, TerrainType terrainType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(TerrainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainTypeAmount_Public_Single_World_TerrainType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 260611, RefRangeEnd = 260614, XrefRangeStart = 260600, XrefRangeEnd = 260611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFeatureToGenerate(IWorldGenerationFeatureInfo worldGenerationFeatureInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGenerationFeatureInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFeatureToGenerate_Public_Void_IWorldGenerationFeatureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260627, RefRangeEnd = 260628, XrefRangeStart = 260614, XrefRangeEnd = 260627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasFeatureToGenerate(WorldGenerationFeatureType featureType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&featureType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFeatureToGenerate_Public_Boolean_WorldGenerationFeatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 260637, RefRangeEnd = 260641, XrefRangeStart = 260628, XrefRangeEnd = 260637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddStructureToPlace(StructurePlacementInfo structurePlacementInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)structurePlacementInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddStructureToPlace_Public_Void_StructurePlacementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 260662, RefRangeEnd = 260666, XrefRangeStart = 260641, XrefRangeEnd = 260662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNearbyFeature(ChunkInfoFeatureType type, ChunkInfoFeature feature)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(ChunkInfoFeature**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &feature;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNearbyFeature_Public_Void_ChunkInfoFeatureType_ChunkInfoFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 260669, RefRangeEnd = 260675, XrefRangeStart = 260666, XrefRangeEnd = 260669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasNearbyFeature(ChunkInfoFeatureType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasNearbyFeature_Public_Boolean_ChunkInfoFeatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 260678, RefRangeEnd = 260686, XrefRangeStart = 260675, XrefRangeEnd = 260678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ChunkInfoFeature> GetNearbyFeatures(ChunkInfoFeatureType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearbyFeatures_Public_List_1_ChunkInfoFeature_ChunkInfoFeatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ChunkInfoFeature>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260686, XrefRangeEnd = 260690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CountNearbyFeatures(ChunkInfoFeatureType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountNearbyFeatures_Public_Int32_ChunkInfoFeatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 260721, RefRangeEnd = 260726, XrefRangeStart = 260690, XrefRangeEnd = 260721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetClosestFeature(ChunkInfoFeatureType type, Coordinates fromCoordinates, out ChunkInfoFeature resultFeature)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromCoordinates;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref resultFeature);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClosestFeature_Public_Boolean_ChunkInfoFeatureType_Coordinates_byref_ChunkInfoFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260726, XrefRangeEnd = 260768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260768, XrefRangeEnd = 260808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 260817, RefRangeEnd = 260818, XrefRangeStart = 260808, XrefRangeEnd = 260817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChunkInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

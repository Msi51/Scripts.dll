using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class WorldGen : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_heightmapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_alphamapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTypeResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveResolutionXZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveResolutionY;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseTerrainMinHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseTerrainMaxHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionTerrainNoiseFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_localTerrainNoiseFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDrynessNoiseFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainDetails;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseTextureLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_villageNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_seaNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldGenSurvivorCamps;

	private static readonly System.IntPtr NativeFieldInfoPtr_simpleTerrain;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainDetailsMap;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe int caveResolutionXZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionXZ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionXZ)) = num;
		}
	}

	public unsafe int caveResolutionY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionY)) = num;
		}
	}

	public unsafe float baseTerrainMinHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainMinHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainMinHeight)) = num;
		}
	}

	public unsafe float baseTerrainMaxHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainMaxHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainMaxHeight)) = num;
		}
	}

	public unsafe NoiseFilter regionTerrainNoiseFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionTerrainNoiseFilter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NoiseFilter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionTerrainNoiseFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)noiseFilter));
		}
	}

	public unsafe NoiseFilter localTerrainNoiseFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localTerrainNoiseFilter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NoiseFilter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localTerrainNoiseFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)noiseFilter));
		}
	}

	public unsafe NoiseFilter worldDrynessNoiseFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDrynessNoiseFilter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NoiseFilter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDrynessNoiseFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)noiseFilter));
		}
	}

	public unsafe Vector3 startingPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPosition)) = vector;
		}
	}

	public unsafe float waterLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterLevel)) = num;
		}
	}

	public unsafe WorldGenTerrainDetails terrainDetails
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainDetails);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldGenTerrainDetails>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainDetails)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGenTerrainDetails));
		}
	}

	public unsafe List<WorldGenTerrainLayer> terrainLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldGenTerrainLayer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainLayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<WorldGenTextureLayer> baseTextureLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTextureLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldGenTextureLayer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTextureLayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<WorldGenObject> caveObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldGenObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> villageNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villageNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villageNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> seaNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> regionNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe WorldGenSurvivorCamps worldGenSurvivorCamps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldGenSurvivorCamps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldGenSurvivorCamps>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldGenSurvivorCamps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGenSurvivorCamps));
		}
	}

	public unsafe bool simpleTerrain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleTerrain);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleTerrain)) = flag;
		}
	}

	public unsafe List<WorldGenTerrainType> terrainTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldGenTerrainType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<string, int> terrainDetailsMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainDetailsMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainDetailsMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static WorldGen()
	{
		Il2CppClassPointerStore<WorldGen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WorldGen");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldGen>.NativeClassPtr);
		NativeFieldInfoPtr_heightmapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "heightmapResolution");
		NativeFieldInfoPtr_alphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "alphamapResolution");
		NativeFieldInfoPtr_terrainTypeResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "terrainTypeResolution");
		NativeFieldInfoPtr_caveResolutionXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "caveResolutionXZ");
		NativeFieldInfoPtr_caveResolutionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "caveResolutionY");
		NativeFieldInfoPtr_baseTerrainMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "baseTerrainMinHeight");
		NativeFieldInfoPtr_baseTerrainMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "baseTerrainMaxHeight");
		NativeFieldInfoPtr_regionTerrainNoiseFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "regionTerrainNoiseFilter");
		NativeFieldInfoPtr_localTerrainNoiseFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "localTerrainNoiseFilter");
		NativeFieldInfoPtr_worldDrynessNoiseFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "worldDrynessNoiseFilter");
		NativeFieldInfoPtr_startingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "startingPosition");
		NativeFieldInfoPtr_waterLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "waterLevel");
		NativeFieldInfoPtr_terrainDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "terrainDetails");
		NativeFieldInfoPtr_terrainLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "terrainLayers");
		NativeFieldInfoPtr_baseTextureLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "baseTextureLayers");
		NativeFieldInfoPtr_caveObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "caveObjects");
		NativeFieldInfoPtr_villageNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "villageNames");
		NativeFieldInfoPtr_seaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "seaNames");
		NativeFieldInfoPtr_regionNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "regionNames");
		NativeFieldInfoPtr_worldGenSurvivorCamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "worldGenSurvivorCamps");
		NativeFieldInfoPtr_simpleTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "simpleTerrain");
		NativeFieldInfoPtr_terrainTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "terrainTypes");
		NativeFieldInfoPtr_terrainDetailsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, "terrainDetailsMap");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, 100670382);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGen>.NativeClassPtr, 100670383);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119570, RefRangeEnd = 119571, XrefRangeStart = 119362, XrefRangeEnd = 119570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119587, RefRangeEnd = 119588, XrefRangeStart = 119571, XrefRangeEnd = 119587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldGen()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldGen>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldGen(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

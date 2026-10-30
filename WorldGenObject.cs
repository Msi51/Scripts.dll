using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class WorldGenObject : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_identifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_density;

	private static readonly System.IntPtr NativeFieldInfoPtr_minDisease;

	private static readonly System.IntPtr NativeFieldInfoPtr_growthPercentageMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_growthPercentageMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearance;

	private static readonly System.IntPtr NativeFieldInfoPtr_minHeightAboveWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHeightAboveWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_minIslandAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxIslandAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_minTerrainType;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTerrainType;

	private static readonly System.IntPtr NativeFieldInfoPtr_minStartingChunkDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_slopeCompensationFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_alignToSurface;

	private static readonly System.IntPtr NativeFieldInfoPtr_validTextureTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_minTextureAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintedTextureType;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintedTextureOpacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintedTextureRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_avoidRoadChunks;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseFilters;

	private static readonly System.IntPtr NativeFieldInfoPtr_subObjects;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<WorldGenObjectIdentifier> identifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldGenObjectIdentifier>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float density
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_density);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_density)) = num;
		}
	}

	public unsafe float minDisease
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDisease);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDisease)) = num;
		}
	}

	public unsafe float growthPercentageMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growthPercentageMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growthPercentageMin)) = num;
		}
	}

	public unsafe float growthPercentageMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growthPercentageMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growthPercentageMax)) = num;
		}
	}

	public unsafe float clearance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearance)) = num;
		}
	}

	public unsafe float minHeightAboveWater
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minHeightAboveWater);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minHeightAboveWater)) = num;
		}
	}

	public unsafe float maxHeightAboveWater
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHeightAboveWater);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHeightAboveWater)) = num;
		}
	}

	public unsafe float minSlope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlope);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlope)) = num;
		}
	}

	public unsafe float maxSlope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlope);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlope)) = num;
		}
	}

	public unsafe float minIslandAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minIslandAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minIslandAmount)) = num;
		}
	}

	public unsafe float maxIslandAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxIslandAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxIslandAmount)) = num;
		}
	}

	public unsafe float minTerrainType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minTerrainType);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minTerrainType)) = num;
		}
	}

	public unsafe float maxTerrainType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTerrainType);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTerrainType)) = num;
		}
	}

	public unsafe float minStartingChunkDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minStartingChunkDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minStartingChunkDistance)) = num;
		}
	}

	public unsafe float slopeCompensationFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slopeCompensationFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slopeCompensationFactor)) = num;
		}
	}

	public unsafe bool alignToSurface
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignToSurface);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignToSurface)) = flag;
		}
	}

	public unsafe List<TextureType> validTextureTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validTextureTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TextureType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validTextureTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float minTextureAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minTextureAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minTextureAmount)) = num;
		}
	}

	public unsafe TextureType paintedTextureType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintedTextureType);
			return *(TextureType*)num;
		}
		set
		{
			*(TextureType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintedTextureType)) = textureType;
		}
	}

	public unsafe float paintedTextureOpacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintedTextureOpacity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintedTextureOpacity)) = num;
		}
	}

	public unsafe float paintedTextureRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintedTextureRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintedTextureRange)) = num;
		}
	}

	public unsafe bool avoidRoadChunks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidRoadChunks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidRoadChunks)) = flag;
		}
	}

	public unsafe List<NoiseFilter> noiseFilters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseFilters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NoiseFilter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseFilters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<WorldGenSubObject> subObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldGenSubObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static WorldGenObject()
	{
		Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WorldGenObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr);
		NativeFieldInfoPtr_identifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "identifiers");
		NativeFieldInfoPtr_density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "density");
		NativeFieldInfoPtr_minDisease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "minDisease");
		NativeFieldInfoPtr_growthPercentageMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "growthPercentageMin");
		NativeFieldInfoPtr_growthPercentageMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "growthPercentageMax");
		NativeFieldInfoPtr_clearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "clearance");
		NativeFieldInfoPtr_minHeightAboveWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "minHeightAboveWater");
		NativeFieldInfoPtr_maxHeightAboveWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "maxHeightAboveWater");
		NativeFieldInfoPtr_minSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "minSlope");
		NativeFieldInfoPtr_maxSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "maxSlope");
		NativeFieldInfoPtr_minIslandAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "minIslandAmount");
		NativeFieldInfoPtr_maxIslandAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "maxIslandAmount");
		NativeFieldInfoPtr_minTerrainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "minTerrainType");
		NativeFieldInfoPtr_maxTerrainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "maxTerrainType");
		NativeFieldInfoPtr_minStartingChunkDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "minStartingChunkDistance");
		NativeFieldInfoPtr_slopeCompensationFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "slopeCompensationFactor");
		NativeFieldInfoPtr_alignToSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "alignToSurface");
		NativeFieldInfoPtr_validTextureTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "validTextureTypes");
		NativeFieldInfoPtr_minTextureAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "minTextureAmount");
		NativeFieldInfoPtr_paintedTextureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "paintedTextureType");
		NativeFieldInfoPtr_paintedTextureOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "paintedTextureOpacity");
		NativeFieldInfoPtr_paintedTextureRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "paintedTextureRange");
		NativeFieldInfoPtr_avoidRoadChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "avoidRoadChunks");
		NativeFieldInfoPtr_noiseFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "noiseFilters");
		NativeFieldInfoPtr_subObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, "subObjects");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, 100670388);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr, 100670389);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119661, XrefRangeEnd = 119888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldGenObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldGenObject>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldGenObject(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

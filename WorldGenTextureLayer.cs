using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class WorldGenTextureLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_textureType;

	private static readonly System.IntPtr NativeFieldInfoPtr_minHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_minHeightFadeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHeightFadeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSlopeFadeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSlopeFadeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_minTerrainType;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTerrainType;

	private static readonly System.IntPtr NativeFieldInfoPtr_minTerrainTypeFadeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTerrainTypeFadeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainHeightDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainHeightDeltaNoiseFilters;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseFilters;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TextureType textureType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureType);
			return *(TextureType*)num;
		}
		set
		{
			*(TextureType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureType)) = textureType;
		}
	}

	public unsafe float minHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minHeight)) = num;
		}
	}

	public unsafe float maxHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHeight)) = num;
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

	public unsafe float minHeightFadeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minHeightFadeRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minHeightFadeRange)) = num;
		}
	}

	public unsafe float maxHeightFadeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHeightFadeRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHeightFadeRange)) = num;
		}
	}

	public unsafe float minSlopeFadeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlopeFadeRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSlopeFadeRange)) = num;
		}
	}

	public unsafe float maxSlopeFadeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlopeFadeRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlopeFadeRange)) = num;
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

	public unsafe float minTerrainTypeFadeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minTerrainTypeFadeRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minTerrainTypeFadeRange)) = num;
		}
	}

	public unsafe float maxTerrainTypeFadeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTerrainTypeFadeRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTerrainTypeFadeRange)) = num;
		}
	}

	public unsafe float terrainHeightDelta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainHeightDelta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainHeightDelta)) = num;
		}
	}

	public unsafe List<NoiseFilter> terrainHeightDeltaNoiseFilters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainHeightDeltaNoiseFilters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NoiseFilter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainHeightDeltaNoiseFilters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

	static WorldGenTextureLayer()
	{
		Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WorldGenTextureLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr);
		NativeFieldInfoPtr_textureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "textureType");
		NativeFieldInfoPtr_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "minHeight");
		NativeFieldInfoPtr_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "maxHeight");
		NativeFieldInfoPtr_minSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "minSlope");
		NativeFieldInfoPtr_maxSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "maxSlope");
		NativeFieldInfoPtr_minHeightFadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "minHeightFadeRange");
		NativeFieldInfoPtr_maxHeightFadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "maxHeightFadeRange");
		NativeFieldInfoPtr_minSlopeFadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "minSlopeFadeRange");
		NativeFieldInfoPtr_maxSlopeFadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "maxSlopeFadeRange");
		NativeFieldInfoPtr_minTerrainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "minTerrainType");
		NativeFieldInfoPtr_maxTerrainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "maxTerrainType");
		NativeFieldInfoPtr_minTerrainTypeFadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "minTerrainTypeFadeRange");
		NativeFieldInfoPtr_maxTerrainTypeFadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "maxTerrainTypeFadeRange");
		NativeFieldInfoPtr_terrainHeightDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "terrainHeightDelta");
		NativeFieldInfoPtr_terrainHeightDeltaNoiseFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "terrainHeightDeltaNoiseFilters");
		NativeFieldInfoPtr_noiseFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, "noiseFilters");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, 100670420);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr, 100670421);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120788, XrefRangeEnd = 120947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe WorldGenTextureLayer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldGenTextureLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldGenTextureLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

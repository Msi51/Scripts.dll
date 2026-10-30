using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TerrainTextureLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_textureTypeIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTextureHeightFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSlopeFadeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSlopeFadeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_minTerrainType;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTerrainType;

	private static readonly System.IntPtr NativeFieldInfoPtr_minTerrainTypeFadeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTerrainTypeFadeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainHeightDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainHeightDeltaNoiseFilters;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseFilters;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_WorldGenTextureLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureTypeIndex_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureTypeIndex_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AffectsTerrainHeight_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHeightDelta_Public_Virtual_Final_New_Single_Chunk_Single_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeTextureAmount_Public_Virtual_Final_New_Single_Coordinates_Single_Single_Single_Single_Single_Int32_Vector2_0;

	public unsafe int textureTypeIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureTypeIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureTypeIndex)) = num;
		}
	}

	public unsafe TerrainTextureHeightFilter terrainTextureHeightFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTextureHeightFilter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TerrainTextureHeightFilter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTextureHeightFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainTextureHeightFilter));
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

	static TerrainTextureLayer()
	{
		Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TerrainTextureLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr);
		NativeFieldInfoPtr_textureTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "textureTypeIndex");
		NativeFieldInfoPtr_terrainTextureHeightFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "terrainTextureHeightFilter");
		NativeFieldInfoPtr_minSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "minSlope");
		NativeFieldInfoPtr_maxSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "maxSlope");
		NativeFieldInfoPtr_minSlopeFadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "minSlopeFadeRange");
		NativeFieldInfoPtr_maxSlopeFadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "maxSlopeFadeRange");
		NativeFieldInfoPtr_minTerrainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "minTerrainType");
		NativeFieldInfoPtr_maxTerrainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "maxTerrainType");
		NativeFieldInfoPtr_minTerrainTypeFadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "minTerrainTypeFadeRange");
		NativeFieldInfoPtr_maxTerrainTypeFadeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "maxTerrainTypeFadeRange");
		NativeFieldInfoPtr_terrainHeightDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "terrainHeightDelta");
		NativeFieldInfoPtr_terrainHeightDeltaNoiseFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "terrainHeightDeltaNoiseFilters");
		NativeFieldInfoPtr_noiseFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, "noiseFilters");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_WorldGenTextureLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, 100683942);
		NativeMethodInfoPtr_GetTextureTypeIndex_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, 100683943);
		NativeMethodInfoPtr_SetTextureTypeIndex_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, 100683944);
		NativeMethodInfoPtr_AffectsTerrainHeight_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, 100683945);
		NativeMethodInfoPtr_ComputeHeightDelta_Public_Virtual_Final_New_Single_Chunk_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, 100683946);
		NativeMethodInfoPtr_ComputeTextureAmount_Public_Virtual_Final_New_Single_Coordinates_Single_Single_Single_Single_Single_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr, 100683947);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272142, RefRangeEnd = 272143, XrefRangeStart = 272133, XrefRangeEnd = 272142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainTextureLayer(int textureTypeIndex, WorldGenTextureLayer textureLayer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainTextureLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textureTypeIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureLayer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_WorldGenTextureLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual int GetTextureTypeIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureTypeIndex_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 292, RefRangeEnd = 297, XrefRangeStart = 292, XrefRangeEnd = 297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetTextureTypeIndex(int textureTypeIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&textureTypeIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextureTypeIndex_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool AffectsTerrainHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AffectsTerrainHeight_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272143, XrefRangeEnd = 272161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float ComputeHeightDelta(Chunk chunk, float terrainHeight, float terrainTypeAmount, float terrainSlope, float heightmapI, float heightmapJ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainHeight;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainTypeAmount;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainSlope;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHeightDelta_Public_Virtual_Final_New_Single_Chunk_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272161, XrefRangeEnd = 272163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float ComputeTextureAmount(Coordinates coordinates, float terrainHeight, float terrainTypeAmount, float terrainSlope, float heightmapI, float heightmapJ, int heightmapResolution, Vector2 seedOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&coordinates);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainHeight;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainTypeAmount;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainSlope;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapResolution;
		*(Vector2**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeTextureAmount_Public_Virtual_Final_New_Single_Coordinates_Single_Single_Single_Single_Single_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public TerrainTextureLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

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
public class TerrainTypeLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTypeIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoPlacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDrynessMinMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDrynessMaxMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDrynessBorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseFilters;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_WorldGenTerrainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeTerrainTypeAmount_Public_Single_Int32_Coordinates_Vector2_Int32_Int32_Single_0;

	public unsafe int terrainTypeIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeIndex)) = num;
		}
	}

	public unsafe bool autoPlacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPlacement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPlacement)) = flag;
		}
	}

	public unsafe float worldDrynessMinMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDrynessMinMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDrynessMinMultiplier)) = num;
		}
	}

	public unsafe float worldDrynessMaxMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDrynessMaxMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDrynessMaxMultiplier)) = num;
		}
	}

	public unsafe float worldDrynessBorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDrynessBorder);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDrynessBorder)) = num;
		}
	}

	public unsafe float maxDensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDensity)) = num;
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

	static TerrainTypeLayer()
	{
		Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TerrainTypeLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr);
		NativeFieldInfoPtr_terrainTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr, "terrainTypeIndex");
		NativeFieldInfoPtr_autoPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr, "autoPlacement");
		NativeFieldInfoPtr_worldDrynessMinMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr, "worldDrynessMinMultiplier");
		NativeFieldInfoPtr_worldDrynessMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr, "worldDrynessMaxMultiplier");
		NativeFieldInfoPtr_worldDrynessBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr, "worldDrynessBorder");
		NativeFieldInfoPtr_maxDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr, "maxDensity");
		NativeFieldInfoPtr_noiseFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr, "noiseFilters");
		NativeMethodInfoPtr__ctor_Public_Void_WorldGenTerrainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr, 100683948);
		NativeMethodInfoPtr_ComputeTerrainTypeAmount_Public_Single_Int32_Coordinates_Vector2_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr, 100683949);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272166, RefRangeEnd = 272167, XrefRangeStart = 272163, XrefRangeEnd = 272166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainTypeLayer(WorldGenTerrainType worldGenTerrainType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainTypeLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGenTerrainType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_WorldGenTerrainType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272172, RefRangeEnd = 272173, XrefRangeStart = 272167, XrefRangeEnd = 272172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ComputeTerrainTypeAmount(int heightmapResolution, Coordinates coordinates, Vector2 seedOffset, int heightmapI, int heightmapJ, float worldDryness)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&heightmapResolution);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldDryness;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeTerrainTypeAmount_Public_Single_Int32_Coordinates_Vector2_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public TerrainTypeLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

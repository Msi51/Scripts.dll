using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class WorldGenTerrainDetailLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_prefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureType;

	private static readonly System.IntPtr NativeFieldInfoPtr_minTextureAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTextureAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_minDisease;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDisease;

	private static readonly System.IntPtr NativeFieldInfoPtr_minHeightAboveWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHeightAboveWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTerrainSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_minTerrainType;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTerrainType;

	private static readonly System.IntPtr NativeFieldInfoPtr_density;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseFilters;

	private static readonly System.IntPtr NativeFieldInfoPtr_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_prototypeObject;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string prefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

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

	public unsafe float maxTextureAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTextureAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTextureAmount)) = num;
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

	public unsafe float maxDisease
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDisease);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDisease)) = num;
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

	public unsafe float maxTerrainSlope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTerrainSlope);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTerrainSlope)) = num;
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

	public unsafe int index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index)) = num;
		}
	}

	public unsafe GameObject prototypeObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prototypeObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prototypeObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	static WorldGenTerrainDetailLayer()
	{
		Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WorldGenTerrainDetailLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr);
		NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "prefab");
		NativeFieldInfoPtr_textureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "textureType");
		NativeFieldInfoPtr_minTextureAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "minTextureAmount");
		NativeFieldInfoPtr_maxTextureAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "maxTextureAmount");
		NativeFieldInfoPtr_minDisease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "minDisease");
		NativeFieldInfoPtr_maxDisease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "maxDisease");
		NativeFieldInfoPtr_minHeightAboveWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "minHeightAboveWater");
		NativeFieldInfoPtr_maxHeightAboveWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "maxHeightAboveWater");
		NativeFieldInfoPtr_maxTerrainSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "maxTerrainSlope");
		NativeFieldInfoPtr_minTerrainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "minTerrainType");
		NativeFieldInfoPtr_maxTerrainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "maxTerrainType");
		NativeFieldInfoPtr_density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "density");
		NativeFieldInfoPtr_noiseFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "noiseFilters");
		NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "index");
		NativeFieldInfoPtr_prototypeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, "prototypeObject");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, 100670414);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr, 100670415);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120390, XrefRangeEnd = 120521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe WorldGenTerrainDetailLayer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldGenTerrainDetailLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldGenTerrainDetailLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

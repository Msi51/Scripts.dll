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
public class NoiseFilter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_noiseType;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseBorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseResultPowerIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_noiseResultPowerOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_octaves;

	private static readonly System.IntPtr NativeFieldInfoPtr_domainWarpVectors;

	private static readonly System.IntPtr NativeFieldInfoPtr_domainWarpOctaves;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastNoiseType;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastNoiseFractalType;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastNoiseDomainWarpAmp;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastNoiseDomainWarpType;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastNoiseCellularDistanceFunction;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastNoiseCellularReturnType;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastNoiseLite;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NoiseType noiseType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseType);
			return *(NoiseType*)num;
		}
		set
		{
			*(NoiseType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseType)) = noiseType;
		}
	}

	public unsafe float noiseMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseMin)) = num;
		}
	}

	public unsafe float noiseBorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseBorder);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseBorder)) = num;
		}
	}

	public unsafe float noiseMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseMax)) = num;
		}
	}

	public unsafe float noiseScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseScale)) = num;
		}
	}

	public unsafe float noiseMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseMultiplier)) = num;
		}
	}

	public unsafe float noiseResultPowerIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseResultPowerIn);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseResultPowerIn)) = num;
		}
	}

	public unsafe float noiseResultPowerOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseResultPowerOut);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseResultPowerOut)) = num;
		}
	}

	public unsafe int octaves
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_octaves);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_octaves)) = num;
		}
	}

	public unsafe List<Vector2> domainWarpVectors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_domainWarpVectors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_domainWarpVectors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int domainWarpOctaves
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_domainWarpOctaves);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_domainWarpOctaves)) = num;
		}
	}

	public unsafe FastNoiseLite.NoiseType fastNoiseType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseType);
			return *(FastNoiseLite.NoiseType*)num;
		}
		set
		{
			*(FastNoiseLite.NoiseType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseType)) = noiseType;
		}
	}

	public unsafe FastNoiseLite.FractalType fastNoiseFractalType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseFractalType);
			return *(FastNoiseLite.FractalType*)num;
		}
		set
		{
			*(FastNoiseLite.FractalType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseFractalType)) = fractalType;
		}
	}

	public unsafe float fastNoiseDomainWarpAmp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseDomainWarpAmp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseDomainWarpAmp)) = num;
		}
	}

	public unsafe FastNoiseLite.DomainWarpType fastNoiseDomainWarpType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseDomainWarpType);
			return *(FastNoiseLite.DomainWarpType*)num;
		}
		set
		{
			*(FastNoiseLite.DomainWarpType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseDomainWarpType)) = domainWarpType;
		}
	}

	public unsafe FastNoiseLite.CellularDistanceFunction fastNoiseCellularDistanceFunction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseCellularDistanceFunction);
			return *(FastNoiseLite.CellularDistanceFunction*)num;
		}
		set
		{
			*(FastNoiseLite.CellularDistanceFunction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseCellularDistanceFunction)) = cellularDistanceFunction;
		}
	}

	public unsafe FastNoiseLite.CellularReturnType fastNoiseCellularReturnType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseCellularReturnType);
			return *(FastNoiseLite.CellularReturnType*)num;
		}
		set
		{
			*(FastNoiseLite.CellularReturnType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseCellularReturnType)) = cellularReturnType;
		}
	}

	public unsafe FastNoiseLite fastNoiseLite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseLite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastNoiseLite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastNoiseLite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fastNoiseLite));
		}
	}

	static NoiseFilter()
	{
		Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NoiseFilter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr);
		NativeFieldInfoPtr_noiseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "noiseType");
		NativeFieldInfoPtr_noiseMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "noiseMin");
		NativeFieldInfoPtr_noiseBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "noiseBorder");
		NativeFieldInfoPtr_noiseMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "noiseMax");
		NativeFieldInfoPtr_noiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "noiseScale");
		NativeFieldInfoPtr_noiseMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "noiseMultiplier");
		NativeFieldInfoPtr_noiseResultPowerIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "noiseResultPowerIn");
		NativeFieldInfoPtr_noiseResultPowerOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "noiseResultPowerOut");
		NativeFieldInfoPtr_octaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "octaves");
		NativeFieldInfoPtr_domainWarpVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "domainWarpVectors");
		NativeFieldInfoPtr_domainWarpOctaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "domainWarpOctaves");
		NativeFieldInfoPtr_fastNoiseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "fastNoiseType");
		NativeFieldInfoPtr_fastNoiseFractalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "fastNoiseFractalType");
		NativeFieldInfoPtr_fastNoiseDomainWarpAmp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "fastNoiseDomainWarpAmp");
		NativeFieldInfoPtr_fastNoiseDomainWarpType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "fastNoiseDomainWarpType");
		NativeFieldInfoPtr_fastNoiseCellularDistanceFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "fastNoiseCellularDistanceFunction");
		NativeFieldInfoPtr_fastNoiseCellularReturnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "fastNoiseCellularReturnType");
		NativeFieldInfoPtr_fastNoiseLite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, "fastNoiseLite");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, 100683721);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr, 100683722);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268889, XrefRangeEnd = 269074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269074, XrefRangeEnd = 269075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NoiseFilter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoiseFilter>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NoiseFilter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

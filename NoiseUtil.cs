using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public static class NoiseUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetNoiseCoords_Public_Static_Void_Int32_Coordinates_Vector2_Single_Single_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_domainWarp_Private_Static_Void_byref_Single_byref_Single_Vector2_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_domainWarp_Private_Static_Void_byref_Single_byref_Single_List_1_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyNoiseFilterResult_Private_Static_Void_byref_Single_NoiseFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_NoiseFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_NoiseFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Filter_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_List_1_NoiseFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Filter_Public_Static_Single_Single_Single_List_1_NoiseFilter_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimplexNoise_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_NoiseFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimplexNoise_Public_Static_Single_Single_Single_NoiseFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimplexNoise_Public_Static_Single_Single_Single_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DerivativeSimplexNoise_Public_Static_Single_Single_Single_NoiseFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DerivativeSimplexNoise_Public_Static_Single_Single_Single_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastNoise_Public_Static_Single_FastNoiseLite_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastNoise_Public_Static_Single_FastNoiseLite_Single_Single_Single_0;

	static NoiseUtil()
	{
		Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NoiseUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr);
		NativeMethodInfoPtr_GetNoiseCoords_Public_Static_Void_Int32_Coordinates_Vector2_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667846);
		NativeMethodInfoPtr_domainWarp_Private_Static_Void_byref_Single_byref_Single_Vector2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667847);
		NativeMethodInfoPtr_domainWarp_Private_Static_Void_byref_Single_byref_Single_List_1_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667848);
		NativeMethodInfoPtr_applyNoiseFilterResult_Private_Static_Void_byref_Single_NoiseFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667849);
		NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667850);
		NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_NoiseFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667851);
		NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_NoiseFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667852);
		NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667853);
		NativeMethodInfoPtr_Filter_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_List_1_NoiseFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667854);
		NativeMethodInfoPtr_Filter_Public_Static_Single_Single_Single_List_1_NoiseFilter_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667855);
		NativeMethodInfoPtr_SimplexNoise_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_NoiseFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667856);
		NativeMethodInfoPtr_SimplexNoise_Public_Static_Single_Single_Single_NoiseFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667857);
		NativeMethodInfoPtr_SimplexNoise_Public_Static_Single_Single_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667858);
		NativeMethodInfoPtr_DerivativeSimplexNoise_Public_Static_Single_Single_Single_NoiseFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667859);
		NativeMethodInfoPtr_DerivativeSimplexNoise_Public_Static_Single_Single_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667860);
		NativeMethodInfoPtr_FastNoise_Public_Static_Single_FastNoiseLite_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667861);
		NativeMethodInfoPtr_FastNoise_Public_Static_Single_FastNoiseLite_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtil>.NativeClassPtr, 100667862);
	}

	[CallerCount(0)]
	public unsafe static void GetNoiseCoords(int heightmapResolution, Coordinates coordinates, Vector2 seedOffset, float heightmapI, float heightmapJ, out float xCoord, out float yCoord)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&heightmapResolution);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref xCoord);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref yCoord);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNoiseCoords_Public_Static_Void_Int32_Coordinates_Vector2_Single_Single_byref_Single_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83459, XrefRangeEnd = 83461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void domainWarp(ref float xCoord, ref float yCoord, Vector2 displacement1, Vector2 displacement2, int octaves)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref xCoord);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref yCoord);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &displacement1;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &displacement2;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &octaves;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_domainWarp_Private_Static_Void_byref_Single_byref_Single_Vector2_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 83470, RefRangeEnd = 83475, XrefRangeStart = 83461, XrefRangeEnd = 83470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void domainWarp(ref float xCoord, ref float yCoord, List<Vector2> domainWarpVectors, int octaves)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref xCoord);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref yCoord);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)domainWarpVectors);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &octaves;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_domainWarp_Private_Static_Void_byref_Single_byref_Single_List_1_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83475, XrefRangeEnd = 83477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void applyNoiseFilterResult(ref float result, NoiseFilter filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyNoiseFilterResult_Private_Static_Void_byref_Single_NoiseFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83477, XrefRangeEnd = 83478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float PerlinNoise(int heightmapResolution, Coordinates coordinates, Vector2 seedOffset, float heightmapI, float heightmapJ, float noiseScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&heightmapResolution);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &noiseScale;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83478, XrefRangeEnd = 83483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float PerlinNoise(int heightmapResolution, Coordinates coordinates, Vector2 seedOffset, float heightmapI, float heightmapJ, NoiseFilter filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&heightmapResolution);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_NoiseFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83483, XrefRangeEnd = 83488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float PerlinNoise(float xCoord, float yCoord, NoiseFilter filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xCoord);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yCoord;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_NoiseFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 83490, RefRangeEnd = 83504, XrefRangeStart = 83488, XrefRangeEnd = 83490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float PerlinNoise(float xCoord, float yCoord, int octaves = 1, float amp = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&xCoord);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yCoord;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &octaves;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &amp;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 83505, RefRangeEnd = 83510, XrefRangeStart = 83504, XrefRangeEnd = 83505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Filter(int heightmapResolution, Coordinates coordinates, Vector2 seedOffset, float heightmapI, float heightmapJ, List<NoiseFilter> noiseFilters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&heightmapResolution);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)noiseFilters);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Filter_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_List_1_NoiseFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 83543, RefRangeEnd = 83545, XrefRangeStart = 83510, XrefRangeEnd = 83543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Filter(float xCoord, float yCoord, List<NoiseFilter> noiseFilters, float minMaxMultiplier = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&xCoord);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yCoord;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)noiseFilters);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &minMaxMultiplier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Filter_Public_Static_Single_Single_Single_List_1_NoiseFilter_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 83550, RefRangeEnd = 83553, XrefRangeStart = 83545, XrefRangeEnd = 83550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SimplexNoise(int heightmapResolution, Coordinates coordinates, Vector2 seedOffset, float heightmapI, float heightmapJ, NoiseFilter filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&heightmapResolution);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimplexNoise_Public_Static_Single_Int32_Coordinates_Vector2_Single_Single_NoiseFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83558, RefRangeEnd = 83559, XrefRangeStart = 83553, XrefRangeEnd = 83558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SimplexNoise(float xCoord, float yCoord, NoiseFilter filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xCoord);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yCoord;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimplexNoise_Public_Static_Single_Single_Single_NoiseFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 83561, RefRangeEnd = 83578, XrefRangeStart = 83559, XrefRangeEnd = 83561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SimplexNoise(float xCoord, float yCoord, int octaves = 1, float amp = 1f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&xCoord);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yCoord;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &octaves;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &amp;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimplexNoise_Public_Static_Single_Single_Single_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83584, RefRangeEnd = 83585, XrefRangeStart = 83578, XrefRangeEnd = 83584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DerivativeSimplexNoise(float xCoord, float yCoord, NoiseFilter filter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xCoord);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yCoord;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DerivativeSimplexNoise_Public_Static_Single_Single_Single_NoiseFilter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 83587, RefRangeEnd = 83594, XrefRangeStart = 83585, XrefRangeEnd = 83587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DerivativeSimplexNoise(float xCoord, float yCoord, int octaves = 1, float amp = 0.5f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&xCoord);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yCoord;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &octaves;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &amp;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DerivativeSimplexNoise_Public_Static_Single_Single_Single_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 83596, RefRangeEnd = 83602, XrefRangeStart = 83594, XrefRangeEnd = 83596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float FastNoise(FastNoiseLite fastNoiseLite, float xCoord, float yCoord)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fastNoiseLite);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &xCoord;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &yCoord;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastNoise_Public_Static_Single_FastNoiseLite_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83602, XrefRangeEnd = 83604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float FastNoise(FastNoiseLite fastNoiseLite, float xCoord, float yCoord, float zCoord)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fastNoiseLite);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &xCoord;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &yCoord;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &zCoord;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastNoise_Public_Static_Single_FastNoiseLite_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public NoiseUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

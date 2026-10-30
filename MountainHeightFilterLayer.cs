using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

[System.Serializable]
public class MountainHeightFilterLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_seaDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_deviationNoiseScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_mountainNoiseScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_mountainRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunksFromCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightmapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkSize;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_Single_Single_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMountainFactor_Private_Single_byref_WorldGenerationHeightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeMinMaxHeights_Public_Virtual_Final_New_Void_byref_WorldGenerationHeightData_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHeight_Public_Virtual_Final_New_Single_byref_WorldGenerationHeightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0;

	public unsafe Vector2 seaDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaDirection);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaDirection)) = vector;
		}
	}

	public unsafe float deviationNoiseScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviationNoiseScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviationNoiseScale)) = num;
		}
	}

	public unsafe float mountainNoiseScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mountainNoiseScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mountainNoiseScale)) = num;
		}
	}

	public unsafe float mountainRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mountainRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mountainRadius)) = num;
		}
	}

	public unsafe int chunksFromCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunksFromCenter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunksFromCenter)) = num;
		}
	}

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

	public unsafe int chunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkSize)) = num;
		}
	}

	static MountainHeightFilterLayer()
	{
		Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MountainHeightFilterLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr);
		NativeFieldInfoPtr_seaDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, "seaDirection");
		NativeFieldInfoPtr_deviationNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, "deviationNoiseScale");
		NativeFieldInfoPtr_mountainNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, "mountainNoiseScale");
		NativeFieldInfoPtr_mountainRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, "mountainRadius");
		NativeFieldInfoPtr_chunksFromCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, "chunksFromCenter");
		NativeFieldInfoPtr_heightmapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, "heightmapResolution");
		NativeFieldInfoPtr_chunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, "chunkSize");
		NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_Single_Single_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, 100683891);
		NativeMethodInfoPtr_getMountainFactor_Private_Single_byref_WorldGenerationHeightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, 100683892);
		NativeMethodInfoPtr_ComputeMinMaxHeights_Public_Virtual_Final_New_Void_byref_WorldGenerationHeightData_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, 100683893);
		NativeMethodInfoPtr_ComputeHeight_Public_Virtual_Final_New_Single_byref_WorldGenerationHeightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, 100683894);
		NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr, 100683895);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 271750, RefRangeEnd = 271751, XrefRangeStart = 271749, XrefRangeEnd = 271750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MountainHeightFilterLayer(Vector2 seaDirection, float deviationNoiseScale, float mountainNoiseScale, float mountainRadius, int chunksFromCenter, int heightmapResolution, int chunkSize)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MountainHeightFilterLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&seaDirection);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deviationNoiseScale;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mountainNoiseScale;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mountainRadius;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunksFromCenter;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapResolution;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector2_Single_Single_Single_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 271762, RefRangeEnd = 271764, XrefRangeStart = 271751, XrefRangeEnd = 271762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getMountainFactor(ref WorldGenerationHeightData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMountainFactor_Private_Single_byref_WorldGenerationHeightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271764, XrefRangeEnd = 271772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ComputeMinMaxHeights(ref WorldGenerationHeightData data, out float baseMinHeight, out float baseMaxHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref baseMinHeight);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref baseMaxHeight);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeMinMaxHeights_Public_Virtual_Final_New_Void_byref_WorldGenerationHeightData_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271772, XrefRangeEnd = 271789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float ComputeHeight(ref WorldGenerationHeightData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHeight_Public_Virtual_Final_New_Single_byref_WorldGenerationHeightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PostProcessHeight(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MountainHeightFilterLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

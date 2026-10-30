using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

[System.Serializable]
public class RoadHeightFilterLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_perlinScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_deviationMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightmapResolution;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHeight_Public_Virtual_Final_New_Single_byref_WorldGenerationHeightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getHeightFactor_Private_Single_ChunkInfo_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEndDirectionFactor_Private_Single_Vector2_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getStartDirectionFactor_Private_Single_Vector2_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getStartDirectionAmount_Private_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getHeightFactor_Private_Single_Vector2_Vector2_Single_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getVerticalHeightFactor_Private_Single_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getHorizontalHeightFactor_Private_Single_Vector2_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFactor_Private_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCurvedHeightFactor_Private_Single_Vector2_Vector2_Single_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lerp_Private_Single_Single_0;

	public unsafe float perlinScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perlinScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perlinScale)) = num;
		}
	}

	public unsafe float deviationMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviationMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviationMax)) = num;
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

	static RoadHeightFilterLayer()
	{
		Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RoadHeightFilterLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr);
		NativeFieldInfoPtr_perlinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, "perlinScale");
		NativeFieldInfoPtr_deviationMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, "deviationMax");
		NativeFieldInfoPtr_heightmapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, "heightmapResolution");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683915);
		NativeMethodInfoPtr_ComputeHeight_Public_Virtual_Final_New_Single_byref_WorldGenerationHeightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683916);
		NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683917);
		NativeMethodInfoPtr_getHeightFactor_Private_Single_ChunkInfo_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683918);
		NativeMethodInfoPtr_getEndDirectionFactor_Private_Single_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683919);
		NativeMethodInfoPtr_getStartDirectionFactor_Private_Single_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683920);
		NativeMethodInfoPtr_getStartDirectionAmount_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683921);
		NativeMethodInfoPtr_getHeightFactor_Private_Single_Vector2_Vector2_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683922);
		NativeMethodInfoPtr_getVerticalHeightFactor_Private_Single_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683923);
		NativeMethodInfoPtr_getHorizontalHeightFactor_Private_Single_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683924);
		NativeMethodInfoPtr_getFactor_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683925);
		NativeMethodInfoPtr_getCurvedHeightFactor_Private_Single_Vector2_Vector2_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683926);
		NativeMethodInfoPtr_lerp_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr, 100683927);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 271791, RefRangeEnd = 271794, XrefRangeStart = 271791, XrefRangeEnd = 271794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoadHeightFilterLayer(float perlinScale, float deviationMax, int heightmapResolution)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadHeightFilterLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&perlinScale);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deviationMax;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapResolution;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271914, XrefRangeEnd = 271948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271948, XrefRangeEnd = 271964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PostProcessHeight(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272010, RefRangeEnd = 272011, XrefRangeStart = 271964, XrefRangeEnd = 272010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getHeightFactor(ChunkInfo chunkInfo, float x, float y, float center)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkInfo);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getHeightFactor_Private_Single_ChunkInfo_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 272016, RefRangeEnd = 272019, XrefRangeStart = 272011, XrefRangeEnd = 272016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getEndDirectionFactor(Vector2 endDirection, float x, float y, float center)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&endDirection);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEndDirectionFactor_Private_Single_Vector2_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272019, XrefRangeEnd = 272024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getStartDirectionFactor(Vector2 startDirection, float x, float y, float center)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&startDirection);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getStartDirectionFactor_Private_Single_Vector2_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float getStartDirectionAmount(float direction, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&direction);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getStartDirectionAmount_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 272025, RefRangeEnd = 272032, XrefRangeStart = 272024, XrefRangeEnd = 272025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getHeightFactor(Vector2 directionForward, Vector2 directionBack, float x, float y, float center, bool intersection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&directionForward);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &directionBack;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &intersection;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getHeightFactor_Private_Single_Vector2_Vector2_Single_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272032, XrefRangeEnd = 272033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getVerticalHeightFactor(Vector2 roadDirection, float center, float x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&roadDirection);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getVerticalHeightFactor_Private_Single_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272033, XrefRangeEnd = 272034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getHorizontalHeightFactor(Vector2 roadDirection, float center, float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&roadDirection);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getHorizontalHeightFactor_Private_Single_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 272036, RefRangeEnd = 272038, XrefRangeStart = 272034, XrefRangeEnd = 272036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getFactor(float value, float center)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFactor_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272052, RefRangeEnd = 272053, XrefRangeStart = 272038, XrefRangeEnd = 272052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getCurvedHeightFactor(Vector2 directionForward, Vector2 directionBack, float center, float x, float y, bool intersection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&directionForward);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &directionBack;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &center;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &intersection;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCurvedHeightFactor_Private_Single_Vector2_Vector2_Single_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272053, XrefRangeEnd = 272054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float lerp(float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&distance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lerp_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public RoadHeightFilterLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

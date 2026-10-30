using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ProceduralNoiseProject;

public class VoronoiNoise : Noise
{
	private static readonly IntPtr NativeFieldInfoPtr__Distance_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Combination_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Perm_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_Distance_Public_get_VORONOI_DISTANCE_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Distance_Public_set_Void_VORONOI_DISTANCE_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Combination_Public_get_VORONOI_COMBINATION_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Combination_Public_set_Void_VORONOI_COMBINATION_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Perm_Private_get_PermutationTable_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Perm_Private_set_Void_PermutationTable_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateSeed_Public_Virtual_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Sample1D_Public_Virtual_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Sample2D_Public_Virtual_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Sample3D_Public_Virtual_Single_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Distance1_Private_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Distance2_Private_Single_Single_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Distance3_Private_Single_Single_Single_Single_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Single_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_ProbLookup_Private_Int32_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Vector3_Vector3_Single_0;

	public unsafe VORONOI_DISTANCE _Distance_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Distance_k__BackingField);
			return *(VORONOI_DISTANCE*)num;
		}
		set
		{
			*(VORONOI_DISTANCE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Distance_k__BackingField)) = vORONOI_DISTANCE;
		}
	}

	public unsafe VORONOI_COMBINATION _Combination_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Combination_k__BackingField);
			return *(VORONOI_COMBINATION*)num;
		}
		set
		{
			*(VORONOI_COMBINATION*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Combination_k__BackingField)) = vORONOI_COMBINATION;
		}
	}

	public unsafe PermutationTable _Perm_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Perm_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PermutationTable>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Perm_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)permutationTable));
		}
	}

	public unsafe VORONOI_DISTANCE Distance
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29360, RefRangeEnd = 29361, XrefRangeStart = 29360, XrefRangeEnd = 29361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Distance_Public_get_VORONOI_DISTANCE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(VORONOI_DISTANCE*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Distance_Public_set_Void_VORONOI_DISTANCE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe VORONOI_COMBINATION Combination
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Combination_Public_get_VORONOI_COMBINATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(VORONOI_COMBINATION*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122654, RefRangeEnd = 122655, XrefRangeStart = 122654, XrefRangeEnd = 122655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Combination_Public_set_Void_VORONOI_COMBINATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe PermutationTable Perm
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 19179, RefRangeEnd = 19194, XrefRangeStart = 19179, XrefRangeEnd = 19194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Perm_Private_get_PermutationTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PermutationTable>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Perm_Private_set_Void_PermutationTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static VoronoiNoise()
	{
		Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "ProceduralNoiseProject", "VoronoiNoise");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr);
		NativeFieldInfoPtr__Distance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, "<Distance>k__BackingField");
		NativeFieldInfoPtr__Combination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, "<Combination>k__BackingField");
		NativeFieldInfoPtr__Perm_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, "<Perm>k__BackingField");
		NativeMethodInfoPtr_get_Distance_Public_get_VORONOI_DISTANCE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686341);
		NativeMethodInfoPtr_set_Distance_Public_set_Void_VORONOI_DISTANCE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686342);
		NativeMethodInfoPtr_get_Combination_Public_get_VORONOI_COMBINATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686343);
		NativeMethodInfoPtr_set_Combination_Public_set_Void_VORONOI_COMBINATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686344);
		NativeMethodInfoPtr_get_Perm_Private_get_PermutationTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686345);
		NativeMethodInfoPtr_set_Perm_Private_set_Void_PermutationTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686346);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686347);
		NativeMethodInfoPtr_UpdateSeed_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686348);
		NativeMethodInfoPtr_Sample1D_Public_Virtual_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686349);
		NativeMethodInfoPtr_Sample2D_Public_Virtual_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686350);
		NativeMethodInfoPtr_Sample3D_Public_Virtual_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686351);
		NativeMethodInfoPtr_Distance1_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686352);
		NativeMethodInfoPtr_Distance2_Private_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686353);
		NativeMethodInfoPtr_Distance3_Private_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686354);
		NativeMethodInfoPtr_Combine_Private_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686355);
		NativeMethodInfoPtr_ProbLookup_Private_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686356);
		NativeMethodInfoPtr_Insert_Private_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr, 100686357);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291248, XrefRangeEnd = 291257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VoronoiNoise(int seed, float frequency, float amplitude = 1f)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoronoiNoise>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&seed);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &frequency;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &amplitude;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291257, XrefRangeEnd = 291259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void UpdateSeed(int seed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&seed);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateSeed_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291259, XrefRangeEnd = 291270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float Sample1D(float x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Sample1D_Public_Virtual_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291270, XrefRangeEnd = 291283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float Sample2D(float x, float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &y;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Sample2D_Public_Virtual_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291283, XrefRangeEnd = 291298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float Sample3D(float x, float y, float z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &z;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Sample3D_Public_Virtual_Single_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 291299, RefRangeEnd = 291300, XrefRangeStart = 291298, XrefRangeEnd = 291299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Distance1(float p1x, float p2x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&p1x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &p2x;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Distance1_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 291309, RefRangeEnd = 291310, XrefRangeStart = 291300, XrefRangeEnd = 291309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Distance2(float p1x, float p1y, float p2x, float p2y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&p1x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &p1y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &p2x;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &p2y;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Distance2_Private_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 291320, RefRangeEnd = 291321, XrefRangeStart = 291310, XrefRangeEnd = 291320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Distance3(float p1x, float p1y, float p1z, float p2x, float p2y, float p2z)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = (nint)(&p1x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &p1y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &p1z;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &p2x;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &p2y;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &p2z;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Distance3_Private_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float Combine(Vector3 arr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&arr);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Private_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 291321, RefRangeEnd = 291324, XrefRangeStart = 291321, XrefRangeEnd = 291321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ProbLookup(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProbLookup_Private_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291324, XrefRangeEnd = 291328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 Insert(Vector3 arr, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&arr);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Insert_Private_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public VoronoiNoise(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace ProceduralNoiseProject;

public class WorleyNoise : Noise
{
	private static readonly IntPtr NativeFieldInfoPtr_OFFSET_F;

	private static readonly IntPtr NativeFieldInfoPtr_K;

	private static readonly IntPtr NativeFieldInfoPtr_Ko;

	private static readonly IntPtr NativeFieldInfoPtr__Jitter_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Distance_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Combination_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Perm_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_Jitter_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Jitter_Public_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Distance_Public_get_VORONOI_DISTANCE_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Distance_Public_set_Void_VORONOI_DISTANCE_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Combination_Public_get_VORONOI_COMBINATION_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Combination_Public_set_Void_VORONOI_COMBINATION_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Perm_Private_get_PermutationTable_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Perm_Private_set_Void_PermutationTable_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateSeed_Public_Virtual_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Sample1D_Public_Virtual_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Sample2D_Public_Virtual_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Sample3D_Public_Virtual_Single_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Mod_Private_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Frac_Private_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Distance1_Private_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Distance2_Private_Single_Single_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Distance3_Private_Single_Single_Single_Single_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Single_Single_Single_Single_0;

	public unsafe static Il2CppStructArray<float> OFFSET_F
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OFFSET_F, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OFFSET_F, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static float K
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_K, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_K, (void*)(&num));
		}
	}

	public unsafe static float Ko
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Ko, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Ko, (void*)(&num));
		}
	}

	public unsafe float _Jitter_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Jitter_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Jitter_k__BackingField)) = num;
		}
	}

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

	public unsafe float Jitter
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Jitter_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254649, RefRangeEnd = 254650, XrefRangeStart = 254649, XrefRangeEnd = 254650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Jitter_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe VORONOI_DISTANCE Distance
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Distance_Public_get_VORONOI_DISTANCE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(VORONOI_DISTANCE*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122654, RefRangeEnd = 122655, XrefRangeStart = 122654, XrefRangeEnd = 122655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122653, RefRangeEnd = 122654, XrefRangeStart = 122653, XrefRangeEnd = 122654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 257159, RefRangeEnd = 257160, XrefRangeStart = 257159, XrefRangeEnd = 257160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 977, RefRangeEnd = 983, XrefRangeStart = 977, XrefRangeEnd = 983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static WorleyNoise()
	{
		Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "ProceduralNoiseProject", "WorleyNoise");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr);
		NativeFieldInfoPtr_OFFSET_F = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, "OFFSET_F");
		NativeFieldInfoPtr_K = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, "K");
		NativeFieldInfoPtr_Ko = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, "Ko");
		NativeFieldInfoPtr__Jitter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, "<Jitter>k__BackingField");
		NativeFieldInfoPtr__Distance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, "<Distance>k__BackingField");
		NativeFieldInfoPtr__Combination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, "<Combination>k__BackingField");
		NativeFieldInfoPtr__Perm_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, "<Perm>k__BackingField");
		NativeMethodInfoPtr_get_Jitter_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686358);
		NativeMethodInfoPtr_set_Jitter_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686359);
		NativeMethodInfoPtr_get_Distance_Public_get_VORONOI_DISTANCE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686360);
		NativeMethodInfoPtr_set_Distance_Public_set_Void_VORONOI_DISTANCE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686361);
		NativeMethodInfoPtr_get_Combination_Public_get_VORONOI_COMBINATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686362);
		NativeMethodInfoPtr_set_Combination_Public_set_Void_VORONOI_COMBINATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686363);
		NativeMethodInfoPtr_get_Perm_Private_get_PermutationTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686364);
		NativeMethodInfoPtr_set_Perm_Private_set_Void_PermutationTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686365);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686366);
		NativeMethodInfoPtr_UpdateSeed_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686367);
		NativeMethodInfoPtr_Sample1D_Public_Virtual_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686368);
		NativeMethodInfoPtr_Sample2D_Public_Virtual_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686369);
		NativeMethodInfoPtr_Sample3D_Public_Virtual_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686370);
		NativeMethodInfoPtr_Mod_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686371);
		NativeMethodInfoPtr_Frac_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686372);
		NativeMethodInfoPtr_Distance1_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686373);
		NativeMethodInfoPtr_Distance2_Private_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686374);
		NativeMethodInfoPtr_Distance3_Private_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686375);
		NativeMethodInfoPtr_Combine_Private_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr, 100686376);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291328, XrefRangeEnd = 291344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorleyNoise(int seed, float frequency, float jitter, float amplitude = 1f)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorleyNoise>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&seed);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &frequency;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &jitter;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &amplitude;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291344, XrefRangeEnd = 291356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291356, XrefRangeEnd = 291375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291375, XrefRangeEnd = 291412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291412, XrefRangeEnd = 291459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291459, XrefRangeEnd = 291460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Mod(float x, float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &y;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Mod_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291460, XrefRangeEnd = 291461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Frac(float v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Frac_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 291462, RefRangeEnd = 291465, XrefRangeStart = 291461, XrefRangeEnd = 291462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 291474, RefRangeEnd = 291477, XrefRangeStart = 291465, XrefRangeEnd = 291474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 291487, RefRangeEnd = 291490, XrefRangeStart = 291477, XrefRangeEnd = 291487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe float Combine(float f0, float f1, float f2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&f0);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &f1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &f2;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Private_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public WorleyNoise(IntPtr pointer)
		: base(pointer)
	{
	}
}

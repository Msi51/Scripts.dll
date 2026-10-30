using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class SubstanceMixtureHolder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_maxSubstanceStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxFillRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_substanceMixture;

	private static readonly System.IntPtr NativeMethodInfoPtr_Extract_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSubstance_Public_Void_Substance_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSubstanceMixture_Public_Single_SubstanceMixture_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSubstance_Public_Single_Substance_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubstanceMixture_Public_SubstanceMixture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubstancePercentage_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApproximatelyFull_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLiquidSubstancePercentage_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxSubstanceStorage_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxFillRate_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanAcceptSubstance_Public_Boolean_SubstanceMixture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float maxSubstanceStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSubstanceStorage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSubstanceStorage)) = num;
		}
	}

	public unsafe float maxFillRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFillRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFillRate)) = num;
		}
	}

	public unsafe SubstanceMixture substanceMixture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_substanceMixture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubstanceMixture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_substanceMixture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substanceMixture));
		}
	}

	static SubstanceMixtureHolder()
	{
		Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SubstanceMixtureHolder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr);
		NativeFieldInfoPtr_maxSubstanceStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, "maxSubstanceStorage");
		NativeFieldInfoPtr_maxFillRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, "maxFillRate");
		NativeFieldInfoPtr_substanceMixture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, "substanceMixture");
		NativeMethodInfoPtr_Extract_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673846);
		NativeMethodInfoPtr_RemoveSubstance_Public_Void_Substance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673847);
		NativeMethodInfoPtr_AddSubstanceMixture_Public_Single_SubstanceMixture_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673848);
		NativeMethodInfoPtr_AddSubstance_Public_Single_Substance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673849);
		NativeMethodInfoPtr_GetSubstanceMixture_Public_SubstanceMixture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673850);
		NativeMethodInfoPtr_GetSubstancePercentage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673851);
		NativeMethodInfoPtr_ApproximatelyFull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673852);
		NativeMethodInfoPtr_GetLiquidSubstancePercentage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673853);
		NativeMethodInfoPtr_GetMaxSubstanceStorage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673854);
		NativeMethodInfoPtr_GetMaxFillRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673855);
		NativeMethodInfoPtr_CanAcceptSubstance_Public_Boolean_SubstanceMixture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673856);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr, 100673857);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144886, XrefRangeEnd = 144890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Extract(float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Extract_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144890, XrefRangeEnd = 144892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveSubstance(Substance substance, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substance);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSubstance_Public_Void_Substance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144892, XrefRangeEnd = 144898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float AddSubstanceMixture(SubstanceMixture addedMixture, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)addedMixture);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSubstanceMixture_Public_Single_SubstanceMixture_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144898, XrefRangeEnd = 144900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float AddSubstance(Substance substance, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substance);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSubstance_Public_Single_Substance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubstanceMixture GetSubstanceMixture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubstanceMixture_Public_SubstanceMixture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubstanceMixture>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe float GetSubstancePercentage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubstancePercentage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144900, XrefRangeEnd = 144902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ApproximatelyFull()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApproximatelyFull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetLiquidSubstancePercentage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLiquidSubstancePercentage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetMaxSubstanceStorage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxSubstanceStorage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetMaxFillRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxFillRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool CanAcceptSubstance(SubstanceMixture substance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanAcceptSubstance_Public_Boolean_SubstanceMixture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubstanceMixtureHolder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubstanceMixtureHolder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SubstanceMixtureHolder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

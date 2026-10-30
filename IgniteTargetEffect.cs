using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IgniteTargetEffect : BaseInteractionEffect
{
	private static readonly IntPtr NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_fuelIgnitedSignal_Public_get_FuelIgnitedSignal_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_fuelIgnitedSignal_Public_set_Void_FuelIgnitedSignal_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_IInteractionEffectResult_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe FuelIgnitedSignal _fuelIgnitedSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FuelIgnitedSignal>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fuelIgnitedSignal));
		}
	}

	public unsafe FuelIgnitedSignal fuelIgnitedSignal
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 19179, RefRangeEnd = 19194, XrefRangeStart = 19179, XrefRangeEnd = 19194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fuelIgnitedSignal_Public_get_FuelIgnitedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FuelIgnitedSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fuelIgnitedSignal_Public_set_Void_FuelIgnitedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static IgniteTargetEffect()
	{
		Il2CppClassPointerStore<IgniteTargetEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IgniteTargetEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgniteTargetEffect>.NativeClassPtr);
		NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteTargetEffect>.NativeClassPtr, "<fuelIgnitedSignal>k__BackingField");
		NativeMethodInfoPtr_get_fuelIgnitedSignal_Public_get_FuelIgnitedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteTargetEffect>.NativeClassPtr, 100671238);
		NativeMethodInfoPtr_set_fuelIgnitedSignal_Public_set_Void_FuelIgnitedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteTargetEffect>.NativeClassPtr, 100671239);
		NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteTargetEffect>.NativeClassPtr, 100671240);
		NativeMethodInfoPtr_Execute_Public_Virtual_IInteractionEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteTargetEffect>.NativeClassPtr, 100671241);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteTargetEffect>.NativeClassPtr, 100671242);
	}

	[CallerCount(0)]
	public unsafe override InteractionEffectType GetEffectType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126318, XrefRangeEnd = 126347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IInteractionEffectResult Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_IInteractionEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInteractionEffectResult>(intPtr) : null;
	}

	[CallerCount(283)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 284, XrefRangeStart = 1, XrefRangeEnd = 284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IgniteTargetEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgniteTargetEffect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IgniteTargetEffect(IntPtr pointer)
		: base(pointer)
	{
	}
}

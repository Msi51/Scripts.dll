using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class HealthMenuInjuryDurabilityBarTick : UIComponent
{
	private static readonly IntPtr NativeMethodInfoPtr_Created_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static HealthMenuInjuryDurabilityBarTick()
	{
		Il2CppClassPointerStore<HealthMenuInjuryDurabilityBarTick>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HealthMenuInjuryDurabilityBarTick");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealthMenuInjuryDurabilityBarTick>.NativeClassPtr);
		NativeMethodInfoPtr_Created_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMenuInjuryDurabilityBarTick>.NativeClassPtr, 100665161);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthMenuInjuryDurabilityBarTick>.NativeClassPtr, 100665162);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Created()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Created_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HealthMenuInjuryDurabilityBarTick()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HealthMenuInjuryDurabilityBarTick>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HealthMenuInjuryDurabilityBarTick(IntPtr pointer)
		: base(pointer)
	{
	}
}

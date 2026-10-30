using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CanAttackRangedConsideration : AIConsideration
{
	private static readonly IntPtr NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CanAttackRangedConsideration()
	{
		Il2CppClassPointerStore<CanAttackRangedConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CanAttackRangedConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanAttackRangedConsideration>.NativeClassPtr);
		NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAttackRangedConsideration>.NativeClassPtr, 100668217);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanAttackRangedConsideration>.NativeClassPtr, 100668218);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89104, XrefRangeEnd = 89128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float Score(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 88908, RefRangeEnd = 88961, XrefRangeStart = 88908, XrefRangeEnd = 88961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CanAttackRangedConsideration()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanAttackRangedConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CanAttackRangedConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

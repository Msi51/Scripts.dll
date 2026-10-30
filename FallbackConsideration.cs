using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class FallbackConsideration : AIConsideration
{
	private static readonly IntPtr NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static FallbackConsideration()
	{
		Il2CppClassPointerStore<FallbackConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FallbackConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackConsideration>.NativeClassPtr);
		NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackConsideration>.NativeClassPtr, 100668273);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackConsideration>.NativeClassPtr, 100668274);
	}

	[CallerCount(0)]
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
	public unsafe FallbackConsideration()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FallbackConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

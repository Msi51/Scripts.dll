using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CanTakeStorableCookedMeatConsideration : AIConsideration<HomeStorableCookedMeatResult>
{
	private static readonly IntPtr NativeMethodInfoPtr_ComputeResult_Protected_Virtual_HomeStorableCookedMeatResult_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_HomeStorableCookedMeatResult_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CanTakeStorableCookedMeatConsideration()
	{
		Il2CppClassPointerStore<CanTakeStorableCookedMeatConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CanTakeStorableCookedMeatConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanTakeStorableCookedMeatConsideration>.NativeClassPtr);
		NativeMethodInfoPtr_ComputeResult_Protected_Virtual_HomeStorableCookedMeatResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanTakeStorableCookedMeatConsideration>.NativeClassPtr, 100668242);
		NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_HomeStorableCookedMeatResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanTakeStorableCookedMeatConsideration>.NativeClassPtr, 100668243);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanTakeStorableCookedMeatConsideration>.NativeClassPtr, 100668244);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89309, XrefRangeEnd = 89313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override HomeStorableCookedMeatResult ComputeResult(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeResult_Protected_Virtual_HomeStorableCookedMeatResult_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new HomeStorableCookedMeatResult(pointer);
	}

	[CallerCount(0)]
	public unsafe override float Score(AIContext ctx, HomeStorableCookedMeatResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_HomeStorableCookedMeatResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89316, RefRangeEnd = 89317, XrefRangeStart = 89313, XrefRangeEnd = 89316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CanTakeStorableCookedMeatConsideration()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanTakeStorableCookedMeatConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CanTakeStorableCookedMeatConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

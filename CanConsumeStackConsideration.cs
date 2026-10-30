using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CanConsumeStackConsideration : AIConsideration<ConsumeStackResult>
{
	private static readonly IntPtr NativeMethodInfoPtr_ComputeResult_Protected_Virtual_ConsumeStackResult_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_ConsumeStackResult_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CanConsumeStackConsideration()
	{
		Il2CppClassPointerStore<CanConsumeStackConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CanConsumeStackConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanConsumeStackConsideration>.NativeClassPtr);
		NativeMethodInfoPtr_ComputeResult_Protected_Virtual_ConsumeStackResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanConsumeStackConsideration>.NativeClassPtr, 100668225);
		NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_ConsumeStackResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanConsumeStackConsideration>.NativeClassPtr, 100668226);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanConsumeStackConsideration>.NativeClassPtr, 100668227);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89156, XrefRangeEnd = 89196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override ConsumeStackResult ComputeResult(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeResult_Protected_Virtual_ConsumeStackResult_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ConsumeStackResult(pointer);
	}

	[CallerCount(0)]
	public unsafe override float Score(AIContext ctx, ConsumeStackResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_ConsumeStackResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89199, RefRangeEnd = 89200, XrefRangeStart = 89196, XrefRangeEnd = 89199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CanConsumeStackConsideration()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanConsumeStackConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CanConsumeStackConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

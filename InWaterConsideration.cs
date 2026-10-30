using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class InWaterConsideration : AIConsideration
{
	private static readonly IntPtr NativeFieldInfoPtr_belowDepth;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0;

	public unsafe float belowDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belowDepth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belowDepth)) = num;
		}
	}

	static InWaterConsideration()
	{
		Il2CppClassPointerStore<InWaterConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InWaterConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InWaterConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_belowDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InWaterConsideration>.NativeClassPtr, "belowDepth");
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InWaterConsideration>.NativeClassPtr, 100668322);
		NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InWaterConsideration>.NativeClassPtr, 100668323);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 88885, RefRangeEnd = 88899, XrefRangeStart = 88885, XrefRangeEnd = 88899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InWaterConsideration(float belowDepth)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InWaterConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&belowDepth);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89787, XrefRangeEnd = 89793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public InWaterConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

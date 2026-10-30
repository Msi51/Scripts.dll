using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class HungerLevelAboveConsideration : AIConsideration
{
	private static readonly IntPtr NativeFieldInfoPtr_threshold;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0;

	public unsafe float threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threshold)) = num;
		}
	}

	static HungerLevelAboveConsideration()
	{
		Il2CppClassPointerStore<HungerLevelAboveConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HungerLevelAboveConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HungerLevelAboveConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HungerLevelAboveConsideration>.NativeClassPtr, "threshold");
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HungerLevelAboveConsideration>.NativeClassPtr, 100668308);
		NativeMethodInfoPtr_Score_Public_Virtual_Single_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HungerLevelAboveConsideration>.NativeClassPtr, 100668309);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 88885, RefRangeEnd = 88899, XrefRangeStart = 88885, XrefRangeEnd = 88899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HungerLevelAboveConsideration(float threshold)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HungerLevelAboveConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&threshold);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89701, XrefRangeEnd = 89711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public HungerLevelAboveConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

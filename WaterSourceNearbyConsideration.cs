using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class WaterSourceNearbyConsideration : AIConsideration<FindWaterResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_waterIdentifiers;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindWaterResult_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindWaterResult_0;

	public unsafe List<string> waterIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterIdentifiers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static WaterSourceNearbyConsideration()
	{
		Il2CppClassPointerStore<WaterSourceNearbyConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WaterSourceNearbyConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterSourceNearbyConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_waterIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterSourceNearbyConsideration>.NativeClassPtr, "waterIdentifiers");
		NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterSourceNearbyConsideration>.NativeClassPtr, 100668395);
		NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindWaterResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterSourceNearbyConsideration>.NativeClassPtr, 100668396);
		NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindWaterResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterSourceNearbyConsideration>.NativeClassPtr, 100668397);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90396, RefRangeEnd = 90397, XrefRangeStart = 90392, XrefRangeEnd = 90396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaterSourceNearbyConsideration(List<string> waterIdentifiers)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterSourceNearbyConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)waterIdentifiers);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90397, XrefRangeEnd = 90401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override FindWaterResult ComputeResult(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindWaterResult_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindWaterResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90401, XrefRangeEnd = 90410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float Score(AIContext ctx, FindWaterResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindWaterResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public WaterSourceNearbyConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

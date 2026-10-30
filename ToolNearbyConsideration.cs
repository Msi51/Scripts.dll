using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ToolNearbyConsideration : AIConsideration<FindEntitiesResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_toolType;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ToolType_0;

	private static readonly IntPtr NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindEntitiesResult_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindEntitiesResult_0;

	public unsafe ToolType toolType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toolType);
			return *(ToolType*)num;
		}
		set
		{
			*(ToolType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toolType)) = toolType;
		}
	}

	static ToolNearbyConsideration()
	{
		Il2CppClassPointerStore<ToolNearbyConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ToolNearbyConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolNearbyConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_toolType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolNearbyConsideration>.NativeClassPtr, "toolType");
		NativeMethodInfoPtr__ctor_Public_Void_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolNearbyConsideration>.NativeClassPtr, 100668388);
		NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindEntitiesResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolNearbyConsideration>.NativeClassPtr, 100668389);
		NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindEntitiesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolNearbyConsideration>.NativeClassPtr, 100668390);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90320, RefRangeEnd = 90321, XrefRangeStart = 90317, XrefRangeEnd = 90320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ToolNearbyConsideration(ToolType toolType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolNearbyConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&toolType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ToolType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90321, XrefRangeEnd = 90325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override FindEntitiesResult ComputeResult(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindEntitiesResult_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindEntitiesResult(pointer);
	}

	[CallerCount(0)]
	public unsafe override float Score(AIContext ctx, FindEntitiesResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindEntitiesResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ToolNearbyConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CookerCanAcceptRawMeatConsideration : AIConsideration<CookerRawMeatResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_cookerIdentifier;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ComputeResult_Protected_Virtual_CookerRawMeatResult_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_CookerRawMeatResult_0;

	public unsafe string cookerIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookerIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookerIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static CookerCanAcceptRawMeatConsideration()
	{
		Il2CppClassPointerStore<CookerCanAcceptRawMeatConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CookerCanAcceptRawMeatConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookerCanAcceptRawMeatConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_cookerIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerCanAcceptRawMeatConsideration>.NativeClassPtr, "cookerIdentifier");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerCanAcceptRawMeatConsideration>.NativeClassPtr, 100668250);
		NativeMethodInfoPtr_ComputeResult_Protected_Virtual_CookerRawMeatResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerCanAcceptRawMeatConsideration>.NativeClassPtr, 100668251);
		NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_CookerRawMeatResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerCanAcceptRawMeatConsideration>.NativeClassPtr, 100668252);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89347, RefRangeEnd = 89348, XrefRangeStart = 89343, XrefRangeEnd = 89347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CookerCanAcceptRawMeatConsideration(string cookerIdentifier)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookerCanAcceptRawMeatConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(cookerIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89348, XrefRangeEnd = 89352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override CookerRawMeatResult ComputeResult(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeResult_Protected_Virtual_CookerRawMeatResult_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new CookerRawMeatResult(pointer);
	}

	[CallerCount(0)]
	public unsafe override float Score(AIContext ctx, CookerRawMeatResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_CookerRawMeatResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public CookerCanAcceptRawMeatConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

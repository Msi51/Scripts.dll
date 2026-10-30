using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class NearbyFuelBurnerIgnitedConsideration : AIConsideration<FindEntitiesResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_entityIdentifiers;

	private static readonly IntPtr NativeFieldInfoPtr_requireHomeOwnedConstruction;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindEntitiesResult_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindEntitiesResult_0;

	public unsafe List<string> entityIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityIdentifiers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool requireHomeOwnedConstruction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requireHomeOwnedConstruction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requireHomeOwnedConstruction)) = flag;
		}
	}

	static NearbyFuelBurnerIgnitedConsideration()
	{
		Il2CppClassPointerStore<NearbyFuelBurnerIgnitedConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NearbyFuelBurnerIgnitedConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NearbyFuelBurnerIgnitedConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_entityIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyFuelBurnerIgnitedConsideration>.NativeClassPtr, "entityIdentifiers");
		NativeFieldInfoPtr_requireHomeOwnedConstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyFuelBurnerIgnitedConsideration>.NativeClassPtr, "requireHomeOwnedConstruction");
		NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyFuelBurnerIgnitedConsideration>.NativeClassPtr, 100668335);
		NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindEntitiesResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyFuelBurnerIgnitedConsideration>.NativeClassPtr, 100668336);
		NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindEntitiesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyFuelBurnerIgnitedConsideration>.NativeClassPtr, 100668337);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89941, XrefRangeEnd = 89954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NearbyFuelBurnerIgnitedConsideration(string fuelBurnerIdentifier, bool requireHomeOwnedConstruction = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NearbyFuelBurnerIgnitedConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fuelBurnerIdentifier);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &requireHomeOwnedConstruction;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89954, XrefRangeEnd = 89958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89958, XrefRangeEnd = 89964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public NearbyFuelBurnerIgnitedConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

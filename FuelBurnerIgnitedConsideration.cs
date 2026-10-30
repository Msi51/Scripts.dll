using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class FuelBurnerIgnitedConsideration : AIConsideration<FindEntitiesResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_fuelBurnerIdentifier;

	private static readonly IntPtr NativeFieldInfoPtr_requireHomeOwnedConstruction;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindEntitiesResult_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindEntitiesResult_0;

	public unsafe string fuelBurnerIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelBurnerIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelBurnerIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	static FuelBurnerIgnitedConsideration()
	{
		Il2CppClassPointerStore<FuelBurnerIgnitedConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FuelBurnerIgnitedConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FuelBurnerIgnitedConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_fuelBurnerIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FuelBurnerIgnitedConsideration>.NativeClassPtr, "fuelBurnerIdentifier");
		NativeFieldInfoPtr_requireHomeOwnedConstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FuelBurnerIgnitedConsideration>.NativeClassPtr, "requireHomeOwnedConstruction");
		NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FuelBurnerIgnitedConsideration>.NativeClassPtr, 100668277);
		NativeMethodInfoPtr_ComputeResult_Protected_Virtual_FindEntitiesResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FuelBurnerIgnitedConsideration>.NativeClassPtr, 100668278);
		NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_FindEntitiesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FuelBurnerIgnitedConsideration>.NativeClassPtr, 100668279);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89532, RefRangeEnd = 89533, XrefRangeStart = 89528, XrefRangeEnd = 89532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FuelBurnerIgnitedConsideration(string fuelBurnerIdentifier, bool requireHomeOwnedConstruction = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FuelBurnerIgnitedConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fuelBurnerIdentifier);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &requireHomeOwnedConstruction;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89533, XrefRangeEnd = 89537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89537, XrefRangeEnd = 89543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public FuelBurnerIgnitedConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

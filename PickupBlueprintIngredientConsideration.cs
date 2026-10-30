using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.injector.api;

public class PickupBlueprintIngredientConsideration : AIConsideration<PickupItemResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_inventoryManager;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_ComputeResult_Protected_Virtual_PickupItemResult_AIContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_PickupItemResult_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IInventoryManager inventoryManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager));
		}
	}

	static PickupBlueprintIngredientConsideration()
	{
		Il2CppClassPointerStore<PickupBlueprintIngredientConsideration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PickupBlueprintIngredientConsideration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickupBlueprintIngredientConsideration>.NativeClassPtr);
		NativeFieldInfoPtr_inventoryManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickupBlueprintIngredientConsideration>.NativeClassPtr, "inventoryManager");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickupBlueprintIngredientConsideration>.NativeClassPtr, 100668360);
		NativeMethodInfoPtr_ComputeResult_Protected_Virtual_PickupItemResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickupBlueprintIngredientConsideration>.NativeClassPtr, 100668361);
		NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_PickupItemResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickupBlueprintIngredientConsideration>.NativeClassPtr, 100668362);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PickupBlueprintIngredientConsideration>.NativeClassPtr, 100668363);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90086, XrefRangeEnd = 90091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize(IInjectionBinder binder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IInjectionBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90091, XrefRangeEnd = 90122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override PickupItemResult ComputeResult(AIContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ComputeResult_Protected_Virtual_PickupItemResult_AIContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new PickupItemResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90122, XrefRangeEnd = 90123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float Score(AIContext ctx, PickupItemResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Score_Protected_Virtual_Single_AIContext_PickupItemResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90126, RefRangeEnd = 90127, XrefRangeStart = 90123, XrefRangeEnd = 90126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PickupBlueprintIngredientConsideration()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickupBlueprintIngredientConsideration>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PickupBlueprintIngredientConsideration(IntPtr pointer)
		: base(pointer)
	{
	}
}

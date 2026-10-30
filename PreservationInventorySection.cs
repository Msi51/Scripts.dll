using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

[Serializable]
public class PreservationInventorySection : BaseTiledInventorySection
{
	private static readonly IntPtr NativeFieldInfoPtr_itemTagWhitelist;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Inventory_0;

	private static readonly IntPtr NativeMethodInfoPtr_DefaultActive_Public_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemTagWhitelist_Protected_Virtual_Il2CppStructArray_1_ItemTag_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSectionType_Public_Virtual_InventorySectionType_0;

	public unsafe static Il2CppStructArray<ItemTag> itemTagWhitelist
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_itemTagWhitelist, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ItemTag>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_itemTagWhitelist, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static PreservationInventorySection()
	{
		Il2CppClassPointerStore<PreservationInventorySection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PreservationInventorySection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreservationInventorySection>.NativeClassPtr);
		NativeFieldInfoPtr_itemTagWhitelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreservationInventorySection>.NativeClassPtr, "itemTagWhitelist");
		NativeMethodInfoPtr__ctor_Public_Void_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreservationInventorySection>.NativeClassPtr, 100673718);
		NativeMethodInfoPtr_DefaultActive_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreservationInventorySection>.NativeClassPtr, 100673719);
		NativeMethodInfoPtr_GetItemTagWhitelist_Protected_Virtual_Il2CppStructArray_1_ItemTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreservationInventorySection>.NativeClassPtr, 100673720);
		NativeMethodInfoPtr_GetSectionType_Public_Virtual_InventorySectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreservationInventorySection>.NativeClassPtr, 100673721);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PreservationInventorySection(Inventory parentInventory)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreservationInventorySection>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentInventory);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Inventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 44231, RefRangeEnd = 44249, XrefRangeStart = 44231, XrefRangeEnd = 44249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool DefaultActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DefaultActive_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143654, XrefRangeEnd = 143658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStructArray<ItemTag> GetItemTagWhitelist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItemTagWhitelist_Protected_Virtual_Il2CppStructArray_1_ItemTag_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ItemTag>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe override InventorySectionType GetSectionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSectionType_Public_Virtual_InventorySectionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InventorySectionType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public PreservationInventorySection(IntPtr pointer)
		: base(pointer)
	{
	}
}

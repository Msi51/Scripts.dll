using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class IInventoryManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_InitializeInventoryItems_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_Abstract_Virtual_New_InventoryItem_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_Abstract_Virtual_New_InventoryItem_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSubstance_Public_Abstract_Virtual_New_Substance_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSubstance_Public_Abstract_Virtual_New_Substance_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMixableWaterSubstances_Public_Abstract_Virtual_New_List_1_Substance_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetQualityType_Public_Abstract_Virtual_New_QualityType_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItems_Public_Abstract_Virtual_New_IEnumerable_1_InventoryItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSubstances_Public_Abstract_Virtual_New_IEnumerable_1_Substance_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInventoryItemStack_Public_Abstract_Virtual_New_InventoryItemStack_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetToolTypeItems_Public_Abstract_Virtual_New_List_1_InventoryItem_ToolType_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddInventorySection_Public_Abstract_Virtual_New_IInventorySection_Inventory_InventorySectionData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddInventorySection_Public_Abstract_Virtual_New_IInventorySection_Inventory_InventorySectionType_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateItemStacks_Public_Abstract_Virtual_New_List_1_InventoryItemStack_ItemDrop_Single_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateItemStacks_Public_Abstract_Virtual_New_List_1_InventoryItemStack_List_1_ItemDrop_Single_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeInventory_Public_Abstract_Virtual_New_Void_Inventory_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeSlot_Public_Abstract_Virtual_New_Void_InventorySlot_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeSubstanceMixture_Public_Abstract_Virtual_New_Void_SubstanceMixture_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMetalType_Public_Abstract_Virtual_New_MetalType_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInventoryItemIdMap_Public_Abstract_Virtual_New_Dictionary_2_Int32_InventoryItem_0;

	static IInventoryManager()
	{
		Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IInventoryManager");
		NativeMethodInfoPtr_InitializeInventoryItems_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675491);
		NativeMethodInfoPtr_GetItem_Public_Abstract_Virtual_New_InventoryItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675492);
		NativeMethodInfoPtr_GetItem_Public_Abstract_Virtual_New_InventoryItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675493);
		NativeMethodInfoPtr_GetSubstance_Public_Abstract_Virtual_New_Substance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675494);
		NativeMethodInfoPtr_GetSubstance_Public_Abstract_Virtual_New_Substance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675495);
		NativeMethodInfoPtr_GetMixableWaterSubstances_Public_Abstract_Virtual_New_List_1_Substance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675496);
		NativeMethodInfoPtr_GetQualityType_Public_Abstract_Virtual_New_QualityType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675497);
		NativeMethodInfoPtr_GetItems_Public_Abstract_Virtual_New_IEnumerable_1_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675498);
		NativeMethodInfoPtr_GetSubstances_Public_Abstract_Virtual_New_IEnumerable_1_Substance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675499);
		NativeMethodInfoPtr_GetInventoryItemStack_Public_Abstract_Virtual_New_InventoryItemStack_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675500);
		NativeMethodInfoPtr_GetToolTypeItems_Public_Abstract_Virtual_New_List_1_InventoryItem_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675501);
		NativeMethodInfoPtr_AddInventorySection_Public_Abstract_Virtual_New_IInventorySection_Inventory_InventorySectionData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675502);
		NativeMethodInfoPtr_AddInventorySection_Public_Abstract_Virtual_New_IInventorySection_Inventory_InventorySectionType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675503);
		NativeMethodInfoPtr_GenerateItemStacks_Public_Abstract_Virtual_New_List_1_InventoryItemStack_ItemDrop_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675504);
		NativeMethodInfoPtr_GenerateItemStacks_Public_Abstract_Virtual_New_List_1_InventoryItemStack_List_1_ItemDrop_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675505);
		NativeMethodInfoPtr_InitializeInventory_Public_Abstract_Virtual_New_Void_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675506);
		NativeMethodInfoPtr_InitializeSlot_Public_Abstract_Virtual_New_Void_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675507);
		NativeMethodInfoPtr_InitializeSubstanceMixture_Public_Abstract_Virtual_New_Void_SubstanceMixture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675508);
		NativeMethodInfoPtr_GetMetalType_Public_Abstract_Virtual_New_MetalType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675509);
		NativeMethodInfoPtr_GetInventoryItemIdMap_Public_Abstract_Virtual_New_Dictionary_2_Int32_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryManager>.NativeClassPtr, 100675510);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator InitializeInventoryItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeInventoryItems_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItem GetItem(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItem_Public_Abstract_Virtual_New_InventoryItem_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItem>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItem GetItem(int itemId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&itemId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItem_Public_Abstract_Virtual_New_InventoryItem_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItem>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Substance GetSubstance(string substanceIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(substanceIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSubstance_Public_Abstract_Virtual_New_Substance_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Substance>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Substance GetSubstance(int substanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&substanceId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSubstance_Public_Abstract_Virtual_New_Substance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Substance>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual List<Substance> GetMixableWaterSubstances()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMixableWaterSubstances_Public_Abstract_Virtual_New_List_1_Substance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Substance>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual QualityType GetQualityType(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetQualityType_Public_Abstract_Virtual_New_QualityType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<QualityType>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerable<InventoryItem> GetItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItems_Public_Abstract_Virtual_New_IEnumerable_1_InventoryItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<InventoryItem>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerable<Substance> GetSubstances()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSubstances_Public_Abstract_Virtual_New_IEnumerable_1_Substance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<Substance>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItemStack GetInventoryItemStack(string identifier, int quantity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &quantity;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInventoryItemStack_Public_Abstract_Virtual_New_InventoryItemStack_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual List<InventoryItem> GetToolTypeItems(ToolType toolType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&toolType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetToolTypeItems_Public_Abstract_Virtual_New_List_1_InventoryItem_ToolType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InventoryItem>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IInventorySection AddInventorySection(Inventory inventory, InventorySectionData data, bool sendUpdates = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		*(InventorySectionData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &data;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &sendUpdates;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddInventorySection_Public_Abstract_Virtual_New_IInventorySection_Inventory_InventorySectionData_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInventorySection>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IInventorySection AddInventorySection(Inventory inventory, InventorySectionType type, bool sendUpdates = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		*(InventorySectionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &sendUpdates;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddInventorySection_Public_Abstract_Virtual_New_IInventorySection_Inventory_InventorySectionType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInventorySection>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual List<InventoryItemStack> GenerateItemStacks(ItemDrop itemDrop, float multiplier = 1f, int maxQuantityPerStack = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemDrop);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &multiplier;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &maxQuantityPerStack;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateItemStacks_Public_Abstract_Virtual_New_List_1_InventoryItemStack_ItemDrop_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InventoryItemStack>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual List<InventoryItemStack> GenerateItemStacks(List<ItemDrop> itemDrops, float multiplier = 1f, int maxQuantityPerStack = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemDrops);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &multiplier;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &maxQuantityPerStack;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateItemStacks_Public_Abstract_Virtual_New_List_1_InventoryItemStack_List_1_ItemDrop_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InventoryItemStack>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void InitializeInventory(Inventory inventory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeInventory_Public_Abstract_Virtual_New_Void_Inventory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void InitializeSlot(InventorySlot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeSlot_Public_Abstract_Virtual_New_Void_InventorySlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void InitializeSubstanceMixture(SubstanceMixture substanceMixture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substanceMixture);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeSubstanceMixture_Public_Abstract_Virtual_New_Void_SubstanceMixture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual MetalType GetMetalType(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMetalType_Public_Abstract_Virtual_New_MetalType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MetalType>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Dictionary<int, InventoryItem> GetInventoryItemIdMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInventoryItemIdMap_Public_Abstract_Virtual_New_Dictionary_2_Int32_InventoryItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, InventoryItem>>(intPtr) : null;
	}

	public IInventoryManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

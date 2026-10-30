using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class IRepairManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_InitializeRecipes_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRepairResultsForSlots_Public_Abstract_Virtual_New_Dictionary_2_InventorySlot_List_1_RepairResult_List_1_InventorySlot_ToolType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPotentialRepairResult_Public_Abstract_Virtual_New_RepairResult_RepairRecipe_InventoryItemStack_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_RepairRecipe_Int32_0;

	static IRepairManager()
	{
		Il2CppClassPointerStore<IRepairManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IRepairManager");
		NativeMethodInfoPtr_InitializeRecipes_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRepairManager>.NativeClassPtr, 100675748);
		NativeMethodInfoPtr_GetRepairResultsForSlots_Public_Abstract_Virtual_New_Dictionary_2_InventorySlot_List_1_RepairResult_List_1_InventorySlot_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRepairManager>.NativeClassPtr, 100675749);
		NativeMethodInfoPtr_GetPotentialRepairResult_Public_Abstract_Virtual_New_RepairResult_RepairRecipe_InventoryItemStack_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRepairManager>.NativeClassPtr, 100675750);
		NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_RepairRecipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRepairManager>.NativeClassPtr, 100675751);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator InitializeRecipes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeRecipes_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Dictionary<InventorySlot, List<RepairResult>> GetRepairResultsForSlots(List<InventorySlot> slots, ToolType toolTypeFilter = ToolType.NONE)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slots);
		*(ToolType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &toolTypeFilter;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRepairResultsForSlots_Public_Abstract_Virtual_New_Dictionary_2_InventorySlot_List_1_RepairResult_List_1_InventorySlot_ToolType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InventorySlot, List<RepairResult>>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual RepairResult GetPotentialRepairResult(RepairRecipe recipe, InventoryItemStack repairedStack, InventoryItemStack toolStack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recipe);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)repairedStack);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toolStack);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPotentialRepairResult_Public_Abstract_Virtual_New_RepairResult_RepairRecipe_InventoryItemStack_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RepairResult>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual RepairRecipe GetRecipe(int recipeId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&recipeId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_RepairRecipe_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RepairRecipe>(intPtr) : null;
	}

	public IRepairManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

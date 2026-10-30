using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class ICraftingManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_InitializeRecipes_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllRecipesForItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_WorkbenchType_List_1_CraftingRecipe_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllRecipesForItem_Public_Abstract_Virtual_New_Void_String_WorkbenchType_List_1_CraftingRecipe_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipesForOutputItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_WorkbenchType_List_1_CraftingRecipe_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipesForInputItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_WorkbenchType_List_1_CraftingRecipe_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipesForPurpose_Public_Abstract_Virtual_New_Void_CraftingPurpose_WorkbenchType_MetalType_List_1_CraftingRecipe_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipesForWorkbenchType_Public_Abstract_Virtual_New_Void_WorkbenchType_List_1_CraftingRecipe_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipesForSearchValue_Public_Abstract_Virtual_New_Void_String_WorkbenchType_List_1_CraftingRecipe_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CraftingRecipe_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CraftingRecipe_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckRecipeValid_Public_Abstract_Virtual_New_Boolean_CraftingRecipe_InventoryItemStack_Entity_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_ExecuteCraft_Public_Abstract_Virtual_New_CraftingResult_CraftingRecipe_Inventory_InventoryItemStack_InventoryItemStack_Int32_0;

	static ICraftingManager()
	{
		Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ICraftingManager");
		NativeMethodInfoPtr_InitializeRecipes_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675315);
		NativeMethodInfoPtr_GetAllRecipesForItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_WorkbenchType_List_1_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675316);
		NativeMethodInfoPtr_GetAllRecipesForItem_Public_Abstract_Virtual_New_Void_String_WorkbenchType_List_1_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675317);
		NativeMethodInfoPtr_GetRecipesForOutputItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_WorkbenchType_List_1_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675318);
		NativeMethodInfoPtr_GetRecipesForInputItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_WorkbenchType_List_1_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675319);
		NativeMethodInfoPtr_GetRecipesForPurpose_Public_Abstract_Virtual_New_Void_CraftingPurpose_WorkbenchType_MetalType_List_1_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675320);
		NativeMethodInfoPtr_GetRecipesForWorkbenchType_Public_Abstract_Virtual_New_Void_WorkbenchType_List_1_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675321);
		NativeMethodInfoPtr_GetRecipesForSearchValue_Public_Abstract_Virtual_New_Void_String_WorkbenchType_List_1_CraftingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675322);
		NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CraftingRecipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675323);
		NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CraftingRecipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675324);
		NativeMethodInfoPtr_CheckRecipeValid_Public_Abstract_Virtual_New_Boolean_CraftingRecipe_InventoryItemStack_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675325);
		NativeMethodInfoPtr_ExecuteCraft_Public_Abstract_Virtual_New_CraftingResult_CraftingRecipe_Inventory_InventoryItemStack_InventoryItemStack_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICraftingManager>.NativeClassPtr, 100675326);
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
	public unsafe virtual void GetAllRecipesForItems(HashSet<string> itemIdentifiers, WorkbenchType workbenchType, List<CraftingRecipe> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIdentifiers);
		*(WorkbenchType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &workbenchType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAllRecipesForItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_WorkbenchType_List_1_CraftingRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetAllRecipesForItem(string itemIdentifier, WorkbenchType workbenchType, List<CraftingRecipe> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemIdentifier);
		*(WorkbenchType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &workbenchType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAllRecipesForItem_Public_Abstract_Virtual_New_Void_String_WorkbenchType_List_1_CraftingRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetRecipesForOutputItems(HashSet<string> itemIdentifiers, WorkbenchType workbenchType, List<CraftingRecipe> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIdentifiers);
		*(WorkbenchType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &workbenchType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipesForOutputItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_WorkbenchType_List_1_CraftingRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetRecipesForInputItems(HashSet<string> identifiers, WorkbenchType workbenchType, List<CraftingRecipe> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		*(WorkbenchType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &workbenchType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipesForInputItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_WorkbenchType_List_1_CraftingRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetRecipesForPurpose(CraftingPurpose purpose, WorkbenchType workbenchType, MetalType metalType, List<CraftingRecipe> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&purpose);
		*(WorkbenchType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &workbenchType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metalType);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipesForPurpose_Public_Abstract_Virtual_New_Void_CraftingPurpose_WorkbenchType_MetalType_List_1_CraftingRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetRecipesForWorkbenchType(WorkbenchType workbenchType, List<CraftingRecipe> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&workbenchType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipesForWorkbenchType_Public_Abstract_Virtual_New_Void_WorkbenchType_List_1_CraftingRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetRecipesForSearchValue(string searchValue, WorkbenchType workbenchType, List<CraftingRecipe> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchValue);
		*(WorkbenchType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &workbenchType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipesForSearchValue_Public_Abstract_Virtual_New_Void_String_WorkbenchType_List_1_CraftingRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual CraftingRecipe GetRecipe(string recipeIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(recipeIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CraftingRecipe_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CraftingRecipe>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual CraftingRecipe GetRecipe(int recipeId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&recipeId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CraftingRecipe_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CraftingRecipe>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool CheckRecipeValid(CraftingRecipe recipe, InventoryItemStack toolStack, Entity crafterEntity, Entity workbenchInventory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recipe);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toolStack);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)crafterEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)workbenchInventory);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CheckRecipeValid_Public_Abstract_Virtual_New_Boolean_CraftingRecipe_InventoryItemStack_Entity_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual CraftingResult ExecuteCraft(CraftingRecipe recipe, Inventory inventory, InventoryItemStack toolStack, InventoryItemStack inputStack = null, int amount = 1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recipe);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toolStack);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputStack);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &amount;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ExecuteCraft_Public_Abstract_Virtual_New_CraftingResult_CraftingRecipe_Inventory_InventoryItemStack_InventoryItemStack_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new CraftingResult(pointer);
	}

	public ICraftingManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

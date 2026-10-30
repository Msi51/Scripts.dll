using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class IRefuelManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_InitializeRecipes_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipesForItem_Public_Abstract_Virtual_New_Void_InventoryItem_List_1_RefuelRecipe_0;

	private static readonly IntPtr NativeMethodInfoPtr_ExecuteRefuel_Public_Abstract_Virtual_New_RefuelResult_RefuelRecipe_InventoryItemStack_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_RefuelRecipe_Int32_0;

	static IRefuelManager()
	{
		Il2CppClassPointerStore<IRefuelManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IRefuelManager");
		NativeMethodInfoPtr_InitializeRecipes_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRefuelManager>.NativeClassPtr, 100675744);
		NativeMethodInfoPtr_GetRecipesForItem_Public_Abstract_Virtual_New_Void_InventoryItem_List_1_RefuelRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRefuelManager>.NativeClassPtr, 100675745);
		NativeMethodInfoPtr_ExecuteRefuel_Public_Abstract_Virtual_New_RefuelResult_RefuelRecipe_InventoryItemStack_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRefuelManager>.NativeClassPtr, 100675746);
		NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_RefuelRecipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRefuelManager>.NativeClassPtr, 100675747);
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
	public unsafe virtual void GetRecipesForItem(InventoryItem item, List<RefuelRecipe> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipesForItem_Public_Abstract_Virtual_New_Void_InventoryItem_List_1_RefuelRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual RefuelResult ExecuteRefuel(RefuelRecipe recipe, InventoryItemStack refueledStack, InventoryItemStack fuelStack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recipe);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)refueledStack);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fuelStack);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ExecuteRefuel_Public_Abstract_Virtual_New_RefuelResult_RefuelRecipe_InventoryItemStack_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RefuelResult>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual RefuelRecipe GetRecipe(int recipeId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&recipeId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_RefuelRecipe_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RefuelRecipe>(intPtr) : null;
	}

	public IRefuelManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

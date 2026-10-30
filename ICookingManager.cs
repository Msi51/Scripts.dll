using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class ICookingManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_InitializeRecipes_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipesForInputIdentifiers_Public_Abstract_Virtual_New_Void_HashSet_1_String_HashSet_1_CookingRecipe_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipesForOutputIdentifiers_Public_Abstract_Virtual_New_Void_HashSet_1_String_HashSet_1_CookingRecipe_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResultForIngredients_Public_Abstract_Virtual_New_CookingRecipeResult_CookingRecipe_InventoryItemStack_List_1_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CookingRecipe_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CookingRecipe_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRecipes_Public_Abstract_Virtual_New_ICollection_1_CookingRecipe_0;

	static ICookingManager()
	{
		Il2CppClassPointerStore<ICookingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ICookingManager");
		NativeMethodInfoPtr_InitializeRecipes_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICookingManager>.NativeClassPtr, 100675308);
		NativeMethodInfoPtr_GetRecipesForInputIdentifiers_Public_Abstract_Virtual_New_Void_HashSet_1_String_HashSet_1_CookingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICookingManager>.NativeClassPtr, 100675309);
		NativeMethodInfoPtr_GetRecipesForOutputIdentifiers_Public_Abstract_Virtual_New_Void_HashSet_1_String_HashSet_1_CookingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICookingManager>.NativeClassPtr, 100675310);
		NativeMethodInfoPtr_GetResultForIngredients_Public_Abstract_Virtual_New_CookingRecipeResult_CookingRecipe_InventoryItemStack_List_1_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICookingManager>.NativeClassPtr, 100675311);
		NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CookingRecipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICookingManager>.NativeClassPtr, 100675312);
		NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CookingRecipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICookingManager>.NativeClassPtr, 100675313);
		NativeMethodInfoPtr_GetRecipes_Public_Abstract_Virtual_New_ICollection_1_CookingRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICookingManager>.NativeClassPtr, 100675314);
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
	public unsafe virtual void GetRecipesForInputIdentifiers(HashSet<string> identifiers, HashSet<CookingRecipe> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipesForInputIdentifiers_Public_Abstract_Virtual_New_Void_HashSet_1_String_HashSet_1_CookingRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetRecipesForOutputIdentifiers(HashSet<string> identifiers, HashSet<CookingRecipe> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipesForOutputIdentifiers_Public_Abstract_Virtual_New_Void_HashSet_1_String_HashSet_1_CookingRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual CookingRecipeResult GetResultForIngredients(CookingRecipe recipe, InventoryItemStack containerStack, List<InventoryItemStack> inputStacks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)recipe);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)containerStack);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputStacks);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResultForIngredients_Public_Abstract_Virtual_New_CookingRecipeResult_CookingRecipe_InventoryItemStack_List_1_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CookingRecipeResult>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual CookingRecipe GetRecipe(string recipeIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(recipeIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CookingRecipe_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CookingRecipe>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual CookingRecipe GetRecipe(int recipeId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&recipeId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipe_Public_Abstract_Virtual_New_CookingRecipe_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CookingRecipe>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ICollection<CookingRecipe> GetRecipes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRecipes_Public_Abstract_Virtual_New_ICollection_1_CookingRecipe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ICollection<CookingRecipe>>(intPtr) : null;
	}

	public ICookingManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

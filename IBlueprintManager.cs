using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class IBlueprintManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_InitializeBlueprints_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlueprintsForInputItems_Public_Abstract_Virtual_New_HashSet_1_Blueprint_HashSet_1_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlueprintsForInputItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_ICollection_1_Blueprint_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllBlueprints_Public_Abstract_Virtual_New_HashSet_1_Blueprint_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlueprintsForInputItem_Public_Abstract_Virtual_New_HashSet_1_Blueprint_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlueprintsForSearchValue_Public_Abstract_Virtual_New_Void_String_List_1_Blueprint_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlueprint_Public_Abstract_Virtual_New_Blueprint_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlueprintForConstruction_Public_Abstract_Virtual_New_Blueprint_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetUpgradeBlueprints_Public_Abstract_Virtual_New_List_1_Blueprint_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCategoryBlueprints_Public_Abstract_Virtual_New_Void_BuildingCategory_List_1_Blueprint_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBuildingPieceBlueprints_Public_Abstract_Virtual_New_Void_BuildingPieceType_List_1_Blueprint_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetShelterTypeBlueprints_Public_Abstract_Virtual_New_Void_ShelterType_BuildingPieceType_List_1_Blueprint_Boolean_0;

	static IBlueprintManager()
	{
		Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IBlueprintManager");
		NativeMethodInfoPtr_InitializeBlueprints_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675242);
		NativeMethodInfoPtr_GetBlueprintsForInputItems_Public_Abstract_Virtual_New_HashSet_1_Blueprint_HashSet_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675243);
		NativeMethodInfoPtr_GetBlueprintsForInputItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_ICollection_1_Blueprint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675244);
		NativeMethodInfoPtr_GetAllBlueprints_Public_Abstract_Virtual_New_HashSet_1_Blueprint_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675245);
		NativeMethodInfoPtr_GetBlueprintsForInputItem_Public_Abstract_Virtual_New_HashSet_1_Blueprint_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675246);
		NativeMethodInfoPtr_GetBlueprintsForSearchValue_Public_Abstract_Virtual_New_Void_String_List_1_Blueprint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675247);
		NativeMethodInfoPtr_GetBlueprint_Public_Abstract_Virtual_New_Blueprint_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675248);
		NativeMethodInfoPtr_GetBlueprintForConstruction_Public_Abstract_Virtual_New_Blueprint_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675249);
		NativeMethodInfoPtr_GetUpgradeBlueprints_Public_Abstract_Virtual_New_List_1_Blueprint_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675250);
		NativeMethodInfoPtr_GetCategoryBlueprints_Public_Abstract_Virtual_New_Void_BuildingCategory_List_1_Blueprint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675251);
		NativeMethodInfoPtr_GetBuildingPieceBlueprints_Public_Abstract_Virtual_New_Void_BuildingPieceType_List_1_Blueprint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675252);
		NativeMethodInfoPtr_GetShelterTypeBlueprints_Public_Abstract_Virtual_New_Void_ShelterType_BuildingPieceType_List_1_Blueprint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBlueprintManager>.NativeClassPtr, 100675253);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator InitializeBlueprints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeBlueprints_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual HashSet<Blueprint> GetBlueprintsForInputItems(HashSet<string> itemIdentifiers, bool includeUpgrades = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIdentifiers);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &includeUpgrades;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBlueprintsForInputItems_Public_Abstract_Virtual_New_HashSet_1_Blueprint_HashSet_1_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Blueprint>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void GetBlueprintsForInputItems(HashSet<string> itemIdentifiers, ICollection<Blueprint> result, bool includeUpgrades = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemIdentifiers);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &includeUpgrades;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBlueprintsForInputItems_Public_Abstract_Virtual_New_Void_HashSet_1_String_ICollection_1_Blueprint_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual HashSet<Blueprint> GetAllBlueprints(bool includeUpgrades = false, bool includeShelterPieces = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&includeUpgrades);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &includeShelterPieces;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAllBlueprints_Public_Abstract_Virtual_New_HashSet_1_Blueprint_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Blueprint>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual HashSet<Blueprint> GetBlueprintsForInputItem(string itemIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(itemIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBlueprintsForInputItem_Public_Abstract_Virtual_New_HashSet_1_Blueprint_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Blueprint>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void GetBlueprintsForSearchValue(string searchValue, List<Blueprint> result, bool includeUpgrades = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchValue);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &includeUpgrades;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBlueprintsForSearchValue_Public_Abstract_Virtual_New_Void_String_List_1_Blueprint_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Blueprint GetBlueprint(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBlueprint_Public_Abstract_Virtual_New_Blueprint_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Blueprint>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Blueprint GetBlueprintForConstruction(string constructionIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(constructionIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBlueprintForConstruction_Public_Abstract_Virtual_New_Blueprint_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Blueprint>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual List<Blueprint> GetUpgradeBlueprints(string constructionIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(constructionIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetUpgradeBlueprints_Public_Abstract_Virtual_New_List_1_Blueprint_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Blueprint>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void GetCategoryBlueprints(BuildingCategory category, List<Blueprint> result, bool includeUpgrades = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&category);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &includeUpgrades;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCategoryBlueprints_Public_Abstract_Virtual_New_Void_BuildingCategory_List_1_Blueprint_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetBuildingPieceBlueprints(BuildingPieceType buildingPieceType, List<Blueprint> result, bool includeUpgrades = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&buildingPieceType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &includeUpgrades;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBuildingPieceBlueprints_Public_Abstract_Virtual_New_Void_BuildingPieceType_List_1_Blueprint_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetShelterTypeBlueprints(ShelterType shelterType, BuildingPieceType buildingPieceType, List<Blueprint> result, bool includeUpgrades = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shelterType);
		*(BuildingPieceType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &buildingPieceType;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &includeUpgrades;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetShelterTypeBlueprints_Public_Abstract_Virtual_New_Void_ShelterType_BuildingPieceType_List_1_Blueprint_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IBlueprintManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

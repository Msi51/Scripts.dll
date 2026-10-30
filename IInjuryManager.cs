using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class IInjuryManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInjury_Public_Abstract_Virtual_New_Injury_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInjury_Public_Abstract_Virtual_New_Injury_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInjuryMap_Public_Abstract_Virtual_New_Dictionary_2_String_Injury_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetLocationCategory_Public_Abstract_Virtual_New_InjuryCategory_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInjuryIconType_Public_Abstract_Virtual_New_IconType_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInjuryLocationToCategoryMap_Public_Abstract_Virtual_New_Dictionary_2_InjuryLocation_InjuryCategory_0;

	private static readonly IntPtr NativeMethodInfoPtr_CanInjuryHealWithoutItem_Public_Abstract_Virtual_New_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHashId_Public_Abstract_Virtual_New_Int32_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetIdentifier_Public_Abstract_Virtual_New_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SearchForApplicableMedicalItem_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Inventory_byref_InventorySlot_0;

	private static readonly IntPtr NativeMethodInfoPtr_InventoryContainsApplicableMedicalItem_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Inventory_0;

	private static readonly IntPtr NativeMethodInfoPtr_SearchForApplicableMedicalTool_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Single_Inventory_byref_InventorySlot_0;

	private static readonly IntPtr NativeMethodInfoPtr_InventoryContainsApplicableMedicalTool_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Single_Inventory_0;

	private static readonly IntPtr NativeMethodInfoPtr_SearchForApplicableMedicalConsumable_Public_Abstract_Virtual_New_Boolean_String_Single_Single_Inventory_List_1_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_SearchForApplicableMedicalConsumable_Public_Abstract_Virtual_New_Boolean_String_Int32_Inventory_List_1_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_InventoryContainsSufficientMedicalConsumable_Public_Abstract_Virtual_New_Boolean_String_Single_Single_Inventory_0;

	private static readonly IntPtr NativeMethodInfoPtr_FindNumConsumablesNeeded_Public_Abstract_Virtual_New_Int32_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_TryApplyInjuryToCategory_Public_Abstract_Virtual_New_Boolean_Entity_Injury_InjuryCategory_Single_Single_InjuryAppliedEventParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_TryApplyInjuryToCategory_Public_Abstract_Virtual_New_Boolean_Entity_String_InjuryCategory_Single_Single_InjuryAppliedEventParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleMeleeInjuries_Public_Abstract_Virtual_New_Void_Entity_Entity_List_1_AttackInjuryContainer_Single_Single_List_1_Injury_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_IInjury_Entity_Injury_InjuryLocation_Single_Single_InjuryAppliedEventParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_Entity_Injury_InjuryLocation_Single_Single_InjuryAppliedEventParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_IInjury_Entity_String_InjuryLocation_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_Entity_String_InjuryLocation_Single_Single_0;

	static IInjuryManager()
	{
		Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IInjuryManager");
		NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675450);
		NativeMethodInfoPtr_GetInjury_Public_Abstract_Virtual_New_Injury_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675451);
		NativeMethodInfoPtr_GetInjury_Public_Abstract_Virtual_New_Injury_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675452);
		NativeMethodInfoPtr_GetInjuryMap_Public_Abstract_Virtual_New_Dictionary_2_String_Injury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675453);
		NativeMethodInfoPtr_GetLocationCategory_Public_Abstract_Virtual_New_InjuryCategory_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675454);
		NativeMethodInfoPtr_GetInjuryIconType_Public_Abstract_Virtual_New_IconType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675455);
		NativeMethodInfoPtr_GetInjuryLocationToCategoryMap_Public_Abstract_Virtual_New_Dictionary_2_InjuryLocation_InjuryCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675456);
		NativeMethodInfoPtr_CanInjuryHealWithoutItem_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675457);
		NativeMethodInfoPtr_GetHashId_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675458);
		NativeMethodInfoPtr_GetIdentifier_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675459);
		NativeMethodInfoPtr_SearchForApplicableMedicalItem_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Inventory_byref_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675460);
		NativeMethodInfoPtr_InventoryContainsApplicableMedicalItem_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675461);
		NativeMethodInfoPtr_SearchForApplicableMedicalTool_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Single_Inventory_byref_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675462);
		NativeMethodInfoPtr_InventoryContainsApplicableMedicalTool_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Single_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675463);
		NativeMethodInfoPtr_SearchForApplicableMedicalConsumable_Public_Abstract_Virtual_New_Boolean_String_Single_Single_Inventory_List_1_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675464);
		NativeMethodInfoPtr_SearchForApplicableMedicalConsumable_Public_Abstract_Virtual_New_Boolean_String_Int32_Inventory_List_1_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675465);
		NativeMethodInfoPtr_InventoryContainsSufficientMedicalConsumable_Public_Abstract_Virtual_New_Boolean_String_Single_Single_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675466);
		NativeMethodInfoPtr_FindNumConsumablesNeeded_Public_Abstract_Virtual_New_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675467);
		NativeMethodInfoPtr_TryApplyInjuryToCategory_Public_Abstract_Virtual_New_Boolean_Entity_Injury_InjuryCategory_Single_Single_InjuryAppliedEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675468);
		NativeMethodInfoPtr_TryApplyInjuryToCategory_Public_Abstract_Virtual_New_Boolean_Entity_String_InjuryCategory_Single_Single_InjuryAppliedEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675469);
		NativeMethodInfoPtr_HandleMeleeInjuries_Public_Abstract_Virtual_New_Void_Entity_Entity_List_1_AttackInjuryContainer_Single_Single_List_1_Injury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675470);
		NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_IInjury_Entity_Injury_InjuryLocation_Single_Single_InjuryAppliedEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675471);
		NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_Entity_Injury_InjuryLocation_Single_Single_InjuryAppliedEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675472);
		NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_IInjury_Entity_String_InjuryLocation_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675473);
		NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_Entity_String_InjuryLocation_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjuryManager>.NativeClassPtr, 100675474);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Injury GetInjury(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInjury_Public_Abstract_Virtual_New_Injury_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Injury>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Injury GetInjury(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInjury_Public_Abstract_Virtual_New_Injury_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Injury>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Dictionary<string, Injury> GetInjuryMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInjuryMap_Public_Abstract_Virtual_New_Dictionary_2_String_Injury_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Injury>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InjuryCategory GetLocationCategory(InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&location);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetLocationCategory_Public_Abstract_Virtual_New_InjuryCategory_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InjuryCategory*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual IconType GetInjuryIconType(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInjuryIconType_Public_Abstract_Virtual_New_IconType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(IconType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Dictionary<InjuryLocation, InjuryCategory> GetInjuryLocationToCategoryMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInjuryLocationToCategoryMap_Public_Abstract_Virtual_New_Dictionary_2_InjuryLocation_InjuryCategory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InjuryLocation, InjuryCategory>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool CanInjuryHealWithoutItem(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CanInjuryHealWithoutItem_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int GetHashId(string injuryIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHashId_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual string GetIdentifier(int injuryHashId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&injuryHashId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetIdentifier_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool SearchForApplicableMedicalItem(string injuryIdentifier, InjuryLocation location, Inventory inventory, out InventorySlot returnSlot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SearchForApplicableMedicalItem_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Inventory_byref_InventorySlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		returnSlot = ((num3 == 0) ? null : new InventorySlot(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool InventoryContainsApplicableMedicalItem(string injuryIdentifier, InjuryLocation location, Inventory inventory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InventoryContainsApplicableMedicalItem_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Inventory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool SearchForApplicableMedicalTool(string injuryIdentifier, InjuryLocation location, float curInjuryDurability, Inventory inventory, out InventorySlot toolSlot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &curInjuryDurability;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SearchForApplicableMedicalTool_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Single_Inventory_byref_InventorySlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		toolSlot = ((num3 == 0) ? null : new InventorySlot(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool InventoryContainsApplicableMedicalTool(string injuryIdentifier, InjuryLocation location, float curInjuryDurability, Inventory inventory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &curInjuryDurability;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InventoryContainsApplicableMedicalTool_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Single_Inventory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool SearchForApplicableMedicalConsumable(string consumableIdentifier, float curInjuryDurability, float durabilityPerConsumable, Inventory inventory, List<InventoryItemStack> slotIndices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(consumableIdentifier);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &curInjuryDurability;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &durabilityPerConsumable;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slotIndices);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SearchForApplicableMedicalConsumable_Public_Abstract_Virtual_New_Boolean_String_Single_Single_Inventory_List_1_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool SearchForApplicableMedicalConsumable(string consumableIdentifier, int quantity, Inventory inventory, List<InventoryItemStack> consumableStacks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(consumableIdentifier);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &quantity;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)consumableStacks);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SearchForApplicableMedicalConsumable_Public_Abstract_Virtual_New_Boolean_String_Int32_Inventory_List_1_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool InventoryContainsSufficientMedicalConsumable(string consumableIdentifier, float curInjuryDurability, float durabilityPerConsumable, Inventory inventory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(consumableIdentifier);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &curInjuryDurability;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &durabilityPerConsumable;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InventoryContainsSufficientMedicalConsumable_Public_Abstract_Virtual_New_Boolean_String_Single_Single_Inventory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int FindNumConsumablesNeeded(float curInjuryDurability, float durabilityPerConsumable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&curInjuryDurability);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &durabilityPerConsumable;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FindNumConsumablesNeeded_Public_Abstract_Virtual_New_Int32_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool TryApplyInjuryToCategory(Entity injuredEntity, Injury injury, InjuryCategory category, float startingDurabilityPercentage = 1f, float startingCleanlinessAmount = 0f, InjuryAppliedEventParams eventParams = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuredEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		*(InjuryCategory**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &category;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startingDurabilityPercentage;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &startingCleanlinessAmount;
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventParams));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TryApplyInjuryToCategory_Public_Abstract_Virtual_New_Boolean_Entity_Injury_InjuryCategory_Single_Single_InjuryAppliedEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool TryApplyInjuryToCategory(Entity injuredEntity, string injuryIdentifier, InjuryCategory category, float startingDurabilityPercentage = 1f, float startingCleanlinessAmount = 0f, InjuryAppliedEventParams eventParams = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuredEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryCategory**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &category;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startingDurabilityPercentage;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &startingCleanlinessAmount;
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventParams));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TryApplyInjuryToCategory_Public_Abstract_Virtual_New_Boolean_Entity_String_InjuryCategory_Single_Single_InjuryAppliedEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleMeleeInjuries(Entity attackerEntity, Entity injuredEntity, List<AttackInjuryContainer> attackInjuries, float attackStrength, float damageDealt, List<Injury> appliedInjuries)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attackerEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuredEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attackInjuries);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &attackStrength;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &damageDealt;
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)appliedInjuries);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleMeleeInjuries_Public_Abstract_Virtual_New_Void_Entity_Entity_List_1_AttackInjuryContainer_Single_Single_List_1_Injury_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool ApplyInjury(IInjury injuredEntityInjury, Entity injuredEntity, Injury injury, InjuryLocation location, float startingDurabilityPercentage = 1f, float startingCleanlinessAmount = 0f, InjuryAppliedEventParams eventParams = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuredEntityInjury);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuredEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &startingDurabilityPercentage;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &startingCleanlinessAmount;
		*(IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventParams));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_IInjury_Entity_Injury_InjuryLocation_Single_Single_InjuryAppliedEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ApplyInjury(Entity injuredEntity, Injury injury, InjuryLocation location, float startingDurabilityPercentage = 1f, float startingCleanlinessAmount = 0f, InjuryAppliedEventParams eventParams = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuredEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startingDurabilityPercentage;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &startingCleanlinessAmount;
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventParams));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_Entity_Injury_InjuryLocation_Single_Single_InjuryAppliedEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ApplyInjury(IInjury injuredEntityInjury, Entity injuredEntity, string injuryIdentifier, InjuryLocation location, float startingDurabilityPercentage = 1f, float startingCleanlinessAmount = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuredEntityInjury);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuredEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &startingDurabilityPercentage;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &startingCleanlinessAmount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_IInjury_Entity_String_InjuryLocation_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ApplyInjury(Entity injuredEntity, string injuryIdentifier, InjuryLocation location, float startingDurabilityPercentage = 1f, float startingCleanlinessAmount = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuredEntity);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startingDurabilityPercentage;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &startingCleanlinessAmount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_Entity_String_InjuryLocation_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IInjuryManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

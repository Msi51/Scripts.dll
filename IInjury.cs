using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IInjury : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_Injury_InjuryLocation_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleHealInteractionComplete_Public_Abstract_Virtual_New_Void_String_InjuryLocation_Single_Int32_List_1_InventoryItemStack_HealInjuryInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveInjury_Public_Abstract_Virtual_New_Void_String_InjuryLocation_InventorySlot_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetActiveInjuriesByLocation_Public_Abstract_Virtual_New_Boolean_InjuryLocation_byref_List_1_ActiveInjury_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasInjury_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBodyLocationsInCategory_Public_Abstract_Virtual_New_List_1_InjuryLocation_InjuryCategory_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInjurableLocations_Public_Abstract_Virtual_New_List_1_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddInjuryAddedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddOneUseInjuryAddedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveInjuryAddedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddInjuryRemovedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveInjuryRemovedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddInjuryStateChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveInjuryStateChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddCleanlinessChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveCleanlinessChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInfectionPercentageByLocation_Public_Abstract_Virtual_New_Single_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddInfectionPercentageByLocation_Public_Abstract_Virtual_New_Void_Single_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveInfectionPercentageByLocation_Public_Abstract_Virtual_New_Void_Single_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasUntreatedInjury_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ValidLocation_Public_Abstract_Virtual_New_Boolean_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInfectedLocations_Public_Abstract_Virtual_New_List_1_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInjuryCleanlinessState_Public_Abstract_Virtual_New_InjuryCleanliness_String_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetInjuryCleanlinessState_Public_Abstract_Virtual_New_Void_String_InjuryLocation_InjuryCleanliness_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsInjuryDirty_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetFilthLevel_Public_Abstract_Virtual_New_Single_String_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSanitationLevel_Public_Abstract_Virtual_New_Single_String_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddCleanliness_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetActiveInjuries_Public_Abstract_Virtual_New_List_1_ActiveInjury_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetConcussionRadialBlurIntensity_Public_Abstract_Virtual_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_ConcussionKnockoutActive_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartCauterization_Public_Abstract_Virtual_New_Void_String_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_EndCauterization_Public_Abstract_Virtual_New_Void_String_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleInjuryDamageEffects_Public_Abstract_Virtual_New_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_DamageMedicalItems_Public_Abstract_Virtual_New_Void_ActiveInjury_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_IncreaseInjuryDurabilityOnDamage_Public_Abstract_Virtual_New_Void_ActiveInjury_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetActiveInjury_Public_Abstract_Virtual_New_ActiveInjury_String_InjuryLocation_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetHealingState_Public_Abstract_Virtual_New_Void_String_InjuryLocation_IInteraction_InteractionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHealingState_Public_Abstract_Virtual_New_HealingState_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNumInjuriesAppliedThisFrame_Public_Abstract_Virtual_New_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetHealingState_Public_Abstract_Virtual_New_Void_InteractionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInjuryIdentifierWhitelist_Public_Abstract_Virtual_New_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_AllowedThroughWhitelist_Public_Abstract_Virtual_New_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_CanApplyInjuries_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCanApplyInjuries_Public_Abstract_Virtual_New_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasInjuryWhitelist_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetInjuryWhitelist_Public_Abstract_Virtual_New_Void_List_1_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearInjuryWhitelist_Public_Abstract_Virtual_New_Void_0;

	static IInjury()
	{
		Il2CppClassPointerStore<IInjury>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IInjury");
		NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_Injury_InjuryLocation_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681639);
		NativeMethodInfoPtr_HandleHealInteractionComplete_Public_Abstract_Virtual_New_Void_String_InjuryLocation_Single_Int32_List_1_InventoryItemStack_HealInjuryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681640);
		NativeMethodInfoPtr_RemoveInjury_Public_Abstract_Virtual_New_Void_String_InjuryLocation_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681641);
		NativeMethodInfoPtr_GetActiveInjuriesByLocation_Public_Abstract_Virtual_New_Boolean_InjuryLocation_byref_List_1_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681642);
		NativeMethodInfoPtr_HasInjury_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681643);
		NativeMethodInfoPtr_GetBodyLocationsInCategory_Public_Abstract_Virtual_New_List_1_InjuryLocation_InjuryCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681644);
		NativeMethodInfoPtr_GetInjurableLocations_Public_Abstract_Virtual_New_List_1_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681645);
		NativeMethodInfoPtr_AddInjuryAddedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681646);
		NativeMethodInfoPtr_AddOneUseInjuryAddedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681647);
		NativeMethodInfoPtr_RemoveInjuryAddedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681648);
		NativeMethodInfoPtr_AddInjuryRemovedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681649);
		NativeMethodInfoPtr_RemoveInjuryRemovedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681650);
		NativeMethodInfoPtr_AddInjuryStateChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681651);
		NativeMethodInfoPtr_RemoveInjuryStateChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681652);
		NativeMethodInfoPtr_AddCleanlinessChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681653);
		NativeMethodInfoPtr_RemoveCleanlinessChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681654);
		NativeMethodInfoPtr_GetInfectionPercentageByLocation_Public_Abstract_Virtual_New_Single_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681655);
		NativeMethodInfoPtr_AddInfectionPercentageByLocation_Public_Abstract_Virtual_New_Void_Single_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681656);
		NativeMethodInfoPtr_RemoveInfectionPercentageByLocation_Public_Abstract_Virtual_New_Void_Single_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681657);
		NativeMethodInfoPtr_HasUntreatedInjury_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681658);
		NativeMethodInfoPtr_ValidLocation_Public_Abstract_Virtual_New_Boolean_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681659);
		NativeMethodInfoPtr_GetInfectedLocations_Public_Abstract_Virtual_New_List_1_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681660);
		NativeMethodInfoPtr_GetInjuryCleanlinessState_Public_Abstract_Virtual_New_InjuryCleanliness_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681661);
		NativeMethodInfoPtr_SetInjuryCleanlinessState_Public_Abstract_Virtual_New_Void_String_InjuryLocation_InjuryCleanliness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681662);
		NativeMethodInfoPtr_IsInjuryDirty_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681663);
		NativeMethodInfoPtr_GetFilthLevel_Public_Abstract_Virtual_New_Single_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681664);
		NativeMethodInfoPtr_GetSanitationLevel_Public_Abstract_Virtual_New_Single_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681665);
		NativeMethodInfoPtr_AddCleanliness_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681666);
		NativeMethodInfoPtr_GetActiveInjuries_Public_Abstract_Virtual_New_List_1_ActiveInjury_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681667);
		NativeMethodInfoPtr_GetConcussionRadialBlurIntensity_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681668);
		NativeMethodInfoPtr_ConcussionKnockoutActive_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681669);
		NativeMethodInfoPtr_StartCauterization_Public_Abstract_Virtual_New_Void_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681670);
		NativeMethodInfoPtr_EndCauterization_Public_Abstract_Virtual_New_Void_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681671);
		NativeMethodInfoPtr_HandleInjuryDamageEffects_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681672);
		NativeMethodInfoPtr_DamageMedicalItems_Public_Abstract_Virtual_New_Void_ActiveInjury_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681673);
		NativeMethodInfoPtr_IncreaseInjuryDurabilityOnDamage_Public_Abstract_Virtual_New_Void_ActiveInjury_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681674);
		NativeMethodInfoPtr_GetActiveInjury_Public_Abstract_Virtual_New_ActiveInjury_String_InjuryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681675);
		NativeMethodInfoPtr_SetHealingState_Public_Abstract_Virtual_New_Void_String_InjuryLocation_IInteraction_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681676);
		NativeMethodInfoPtr_GetHealingState_Public_Abstract_Virtual_New_HealingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681677);
		NativeMethodInfoPtr_GetNumInjuriesAppliedThisFrame_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681678);
		NativeMethodInfoPtr_ResetHealingState_Public_Abstract_Virtual_New_Void_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681679);
		NativeMethodInfoPtr_GetInjuryIdentifierWhitelist_Public_Abstract_Virtual_New_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681680);
		NativeMethodInfoPtr_AllowedThroughWhitelist_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681681);
		NativeMethodInfoPtr_CanApplyInjuries_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681682);
		NativeMethodInfoPtr_SetCanApplyInjuries_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681683);
		NativeMethodInfoPtr_HasInjuryWhitelist_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681684);
		NativeMethodInfoPtr_SetInjuryWhitelist_Public_Abstract_Virtual_New_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681685);
		NativeMethodInfoPtr_ClearInjuryWhitelist_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjury>.NativeClassPtr, 100681686);
	}

	[CallerCount(0)]
	public unsafe virtual bool ApplyInjury(Injury injury, InjuryLocation location, float startingDurabilityPercentage = 1f, float startingCleanlinessAmount = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &startingDurabilityPercentage;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startingCleanlinessAmount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ApplyInjury_Public_Abstract_Virtual_New_Boolean_Injury_InjuryLocation_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleHealInteractionComplete(string injuryIdentifier, InjuryLocation location, float durabilityPercentage = 1f, int numItemsUsed = 1, List<InventoryItemStack> itemStacks = null, HealInjuryInfo info = default(HealInjuryInfo))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &durabilityPercentage;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &numItemsUsed;
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemStacks);
		*(HealInjuryInfo**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &info;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleHealInteractionComplete_Public_Abstract_Virtual_New_Void_String_InjuryLocation_Single_Int32_List_1_InventoryItemStack_HealInjuryInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveInjury(string identifier, InjuryLocation location, InventorySlot connectedMedicalSlot = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)connectedMedicalSlot);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveInjury_Public_Abstract_Virtual_New_Void_String_InjuryLocation_InventorySlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool GetActiveInjuriesByLocation(InjuryLocation location, out List<ActiveInjury> locationInjuries)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&location);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveInjuriesByLocation_Public_Abstract_Virtual_New_Boolean_InjuryLocation_byref_List_1_ActiveInjury_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		locationInjuries = ((num3 == 0) ? null : new List<ActiveInjury>(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool HasInjury(string identifier, InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HasInjury_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual List<InjuryLocation> GetBodyLocationsInCategory(InjuryCategory injuryCategory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&injuryCategory);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBodyLocationsInCategory_Public_Abstract_Virtual_New_List_1_InjuryLocation_InjuryCategory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InjuryLocation>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual List<InjuryLocation> GetInjurableLocations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInjurableLocations_Public_Abstract_Virtual_New_List_1_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InjuryLocation>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void AddInjuryAddedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddInjuryAddedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddOneUseInjuryAddedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddOneUseInjuryAddedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveInjuryAddedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveInjuryAddedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddInjuryRemovedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddInjuryRemovedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveInjuryRemovedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveInjuryRemovedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddInjuryStateChangedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddInjuryStateChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveInjuryStateChangedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveInjuryStateChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddCleanlinessChangedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddCleanlinessChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveCleanlinessChangedListener(InjuryListener listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveCleanlinessChangedListener_Public_Abstract_Virtual_New_Void_InjuryListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual float GetInfectionPercentageByLocation(InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&location);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInfectionPercentageByLocation_Public_Abstract_Virtual_New_Single_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void AddInfectionPercentageByLocation(float value, InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddInfectionPercentageByLocation_Public_Abstract_Virtual_New_Void_Single_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveInfectionPercentageByLocation(float value, InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveInfectionPercentageByLocation_Public_Abstract_Virtual_New_Void_Single_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool HasUntreatedInjury()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HasUntreatedInjury_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ValidLocation(InjuryLocation location)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&location);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ValidLocation_Public_Abstract_Virtual_New_Boolean_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual List<InjuryLocation> GetInfectedLocations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInfectedLocations_Public_Abstract_Virtual_New_List_1_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InjuryLocation>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InjuryCleanliness GetInjuryCleanlinessState(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInjuryCleanlinessState_Public_Abstract_Virtual_New_InjuryCleanliness_String_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InjuryCleanliness*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetInjuryCleanlinessState(string injuryIdentifier, InjuryLocation injuryLocation, InjuryCleanliness sanitized)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryLocation;
		*(InjuryCleanliness**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &sanitized;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetInjuryCleanlinessState_Public_Abstract_Virtual_New_Void_String_InjuryLocation_InjuryCleanliness_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsInjuryDirty(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsInjuryDirty_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetFilthLevel(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetFilthLevel_Public_Abstract_Virtual_New_Single_String_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetSanitationLevel(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSanitationLevel_Public_Abstract_Virtual_New_Single_String_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool AddCleanliness(string injuryIdentifier, InjuryLocation injuryLocation, float sanitationAdded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryLocation;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &sanitationAdded;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddCleanliness_Public_Abstract_Virtual_New_Boolean_String_InjuryLocation_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual List<ActiveInjury> GetActiveInjuries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveInjuries_Public_Abstract_Virtual_New_List_1_ActiveInjury_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ActiveInjury>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual float GetConcussionRadialBlurIntensity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetConcussionRadialBlurIntensity_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ConcussionKnockoutActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ConcussionKnockoutActive_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void StartCauterization(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_StartCauterization_Public_Abstract_Virtual_New_Void_String_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void EndCauterization(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EndCauterization_Public_Abstract_Virtual_New_Void_String_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleInjuryDamageEffects(float damageDealt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&damageDealt);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleInjuryDamageEffects_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void DamageMedicalItems(ActiveInjury activeInjury, float damageDealt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &damageDealt;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DamageMedicalItems_Public_Abstract_Virtual_New_Void_ActiveInjury_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void IncreaseInjuryDurabilityOnDamage(ActiveInjury activeInjury, float damageDealt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjury);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &damageDealt;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IncreaseInjuryDurabilityOnDamage_Public_Abstract_Virtual_New_Void_ActiveInjury_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual ActiveInjury GetActiveInjury(string injuryIdentifier, InjuryLocation injuryLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryLocation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveInjury_Public_Abstract_Virtual_New_ActiveInjury_String_InjuryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ActiveInjury>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SetHealingState(string injuryIdentifier, InjuryLocation injuryLocation, IInteraction activeInjuryInteraction, InteractionType activeInjuryInteractionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(InjuryLocation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &injuryLocation;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeInjuryInteraction);
		*(InteractionType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &activeInjuryInteractionType;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetHealingState_Public_Abstract_Virtual_New_Void_String_InjuryLocation_IInteraction_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual HealingState GetHealingState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHealingState_Public_Abstract_Virtual_New_HealingState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HealingState>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual int GetNumInjuriesAppliedThisFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetNumInjuriesAppliedThisFrame_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void ResetHealingState(InteractionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ResetHealingState_Public_Abstract_Virtual_New_Void_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual List<string> GetInjuryIdentifierWhitelist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInjuryIdentifierWhitelist_Public_Abstract_Virtual_New_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool AllowedThroughWhitelist(string injuryIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AllowedThroughWhitelist_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool CanApplyInjuries()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CanApplyInjuries_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetCanApplyInjuries(bool canApplyInjuries)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&canApplyInjuries);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetCanApplyInjuries_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool HasInjuryWhitelist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HasInjuryWhitelist_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetInjuryWhitelist(List<string> identifiers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetInjuryWhitelist_Public_Abstract_Virtual_New_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void ClearInjuryWhitelist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClearInjuryWhitelist_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IInjury(IntPtr pointer)
		: base(pointer)
	{
	}
}

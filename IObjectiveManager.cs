using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

public class IObjectiveManager : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateObjectiveTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_Il2CppReferenceArray_1_Hint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDynamicCollectItemTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDynamicBasicTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_LocalizedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddObjectiveTaskGroups_Public_Abstract_Virtual_New_Void_Objective_Il2CppReferenceArray_1_ObjectiveTaskGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignNewObjective_Public_Abstract_Virtual_New_Objective_WorldPlayer_String_Boolean_Boolean_List_1_ObjectiveTaskGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignNewObjective_Public_Abstract_Virtual_New_Objective_WorldPlayer_String_Boolean_Boolean_Il2CppReferenceArray_1_ObjectiveTaskGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOpenHint_Public_Abstract_Virtual_New_Hint_String_Single_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputActionHint_Public_Abstract_Virtual_New_Hint_String_Single_Il2CppStructArray_1_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputActionHint_Public_Abstract_Virtual_New_Hint_String_Single_Boolean_Il2CppStructArray_1_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTimedHint_Public_Abstract_Virtual_New_Hint_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHint_Public_Abstract_Virtual_New_Hint_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHintCompleted_Public_Abstract_Virtual_New_Boolean_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkHintCompleted_Public_Abstract_Virtual_New_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadObjectiveTaskGroup_Public_Abstract_Virtual_New_Void_Int32_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearActiveObjectives_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjective_Public_Abstract_Virtual_New_Objective_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompletedObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkedObjectiveTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompleteNetworkedObjective_Public_Abstract_Virtual_New_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandlePlayerActivation_Public_Abstract_Virtual_New_Void_WorldPlayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Void_GameSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadGame_Public_Abstract_Virtual_New_Void_GameSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignNpcRequestObjective_Public_Abstract_Virtual_New_Objective_WorldPlayer_Int32_Il2CppReferenceArray_1_ObjectiveTaskGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNpcRequestObjective_Public_Abstract_Virtual_New_Objective_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveNpcRequestObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompletedNpcRequestObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNetworkedObjective_Public_Abstract_Virtual_New_Void_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNetworkedObjectiveTaskGroup_Public_Abstract_Virtual_New_Void_String_ObjectiveTaskGroup_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompleteNetworkedNpcRequestObjective_Public_Abstract_Virtual_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCompletedHintIdentifiers_Public_Abstract_Virtual_New_Void_HashSet_1_String_0;

	static IObjectiveManager()
	{
		Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IObjectiveManager");
		NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675628);
		NativeMethodInfoPtr_CreateObjectiveTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_Il2CppReferenceArray_1_Hint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675629);
		NativeMethodInfoPtr_CreateDynamicCollectItemTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675630);
		NativeMethodInfoPtr_CreateDynamicBasicTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675631);
		NativeMethodInfoPtr_AddObjectiveTaskGroups_Public_Abstract_Virtual_New_Void_Objective_Il2CppReferenceArray_1_ObjectiveTaskGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675632);
		NativeMethodInfoPtr_AssignNewObjective_Public_Abstract_Virtual_New_Objective_WorldPlayer_String_Boolean_Boolean_List_1_ObjectiveTaskGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675633);
		NativeMethodInfoPtr_AssignNewObjective_Public_Abstract_Virtual_New_Objective_WorldPlayer_String_Boolean_Boolean_Il2CppReferenceArray_1_ObjectiveTaskGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675634);
		NativeMethodInfoPtr_CreateUIOpenHint_Public_Abstract_Virtual_New_Hint_String_Single_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675635);
		NativeMethodInfoPtr_CreateInputActionHint_Public_Abstract_Virtual_New_Hint_String_Single_Il2CppStructArray_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675636);
		NativeMethodInfoPtr_CreateInputActionHint_Public_Abstract_Virtual_New_Hint_String_Single_Boolean_Il2CppStructArray_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675637);
		NativeMethodInfoPtr_CreateTimedHint_Public_Abstract_Virtual_New_Hint_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675638);
		NativeMethodInfoPtr_CreateHint_Public_Abstract_Virtual_New_Hint_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675639);
		NativeMethodInfoPtr_IsHintCompleted_Public_Abstract_Virtual_New_Boolean_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675640);
		NativeMethodInfoPtr_MarkHintCompleted_Public_Abstract_Virtual_New_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675641);
		NativeMethodInfoPtr_ReadObjectiveTaskGroup_Public_Abstract_Virtual_New_Void_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675642);
		NativeMethodInfoPtr_ClearActiveObjectives_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675643);
		NativeMethodInfoPtr_GetObjective_Public_Abstract_Virtual_New_Objective_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675644);
		NativeMethodInfoPtr_GetCompletedObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675645);
		NativeMethodInfoPtr_GetActiveObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675646);
		NativeMethodInfoPtr_GetNetworkedObjectiveTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675647);
		NativeMethodInfoPtr_CompleteNetworkedObjective_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675648);
		NativeMethodInfoPtr_HandlePlayerActivation_Public_Abstract_Virtual_New_Void_WorldPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675649);
		NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Void_GameSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675650);
		NativeMethodInfoPtr_LoadGame_Public_Abstract_Virtual_New_Void_GameSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675651);
		NativeMethodInfoPtr_AssignNpcRequestObjective_Public_Abstract_Virtual_New_Objective_WorldPlayer_Int32_Il2CppReferenceArray_1_ObjectiveTaskGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675652);
		NativeMethodInfoPtr_GetNpcRequestObjective_Public_Abstract_Virtual_New_Objective_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675653);
		NativeMethodInfoPtr_GetActiveNpcRequestObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675654);
		NativeMethodInfoPtr_GetCompletedNpcRequestObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675655);
		NativeMethodInfoPtr_AddNetworkedObjective_Public_Abstract_Virtual_New_Void_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675656);
		NativeMethodInfoPtr_AddNetworkedObjectiveTaskGroup_Public_Abstract_Virtual_New_Void_String_ObjectiveTaskGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675657);
		NativeMethodInfoPtr_CompleteNetworkedNpcRequestObjective_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675658);
		NativeMethodInfoPtr_AddCompletedHintIdentifiers_Public_Abstract_Virtual_New_Void_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectiveManager>.NativeClassPtr, 100675659);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ObjectiveTaskGroup CreateObjectiveTaskGroup(string identifier, Il2CppReferenceArray<Hint> hints = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateObjectiveTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_Il2CppReferenceArray_1_Hint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroup>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ObjectiveTaskGroup CreateDynamicCollectItemTaskGroup(string identifier, LocalizedString title, LocalizedString description, string requestItemIdentifier, int requestQuantity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)title));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)description));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(requestItemIdentifier);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestQuantity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateDynamicCollectItemTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroup>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ObjectiveTaskGroup CreateDynamicBasicTaskGroup(string identifier, LocalizedString title, LocalizedString description, LocalizedString taskText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)title));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)description));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)taskText));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateDynamicBasicTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_LocalizedString_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroup>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void AddObjectiveTaskGroups(Objective existingObjective, [Optional] Il2CppReferenceArray<ObjectiveTaskGroup> objectiveTaskGroups)
	{
		if (objectiveTaskGroups == null)
		{
			objectiveTaskGroups = new Il2CppReferenceArray<ObjectiveTaskGroup>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)existingObjective);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroups);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddObjectiveTaskGroups_Public_Abstract_Virtual_New_Void_Objective_Il2CppReferenceArray_1_ObjectiveTaskGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Objective AssignNewObjective(WorldPlayer worldPlayer, string identifier, bool hidden, bool showJournal, List<ObjectiveTaskGroup> objectiveTaskGroups)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hidden;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showJournal;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroups);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AssignNewObjective_Public_Abstract_Virtual_New_Objective_WorldPlayer_String_Boolean_Boolean_List_1_ObjectiveTaskGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Objective AssignNewObjective(WorldPlayer worldPlayer, string identifier, bool hidden, bool showJournal, [Optional] Il2CppReferenceArray<ObjectiveTaskGroup> objectiveTaskGroups)
	{
		if (objectiveTaskGroups == null)
		{
			objectiveTaskGroups = new Il2CppReferenceArray<ObjectiveTaskGroup>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hidden;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showJournal;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroups);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AssignNewObjective_Public_Abstract_Virtual_New_Objective_WorldPlayer_String_Boolean_Boolean_Il2CppReferenceArray_1_ObjectiveTaskGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Hint CreateUIOpenHint(string identifier, float hideDuration, Il2CppSystem.Type uiType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideDuration;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uiType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateUIOpenHint_Public_Abstract_Virtual_New_Hint_String_Single_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hint>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Hint CreateInputActionHint(string identifier, float hideDuration, [Optional] Il2CppStructArray<InputAction> triggerActions)
	{
		if (triggerActions == null)
		{
			triggerActions = new Il2CppStructArray<InputAction>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideDuration;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)triggerActions);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateInputActionHint_Public_Abstract_Virtual_New_Hint_String_Single_Il2CppStructArray_1_InputAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hint>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Hint CreateInputActionHint(string identifier, float hideDuration, bool requiresMouseMovement, [Optional] Il2CppStructArray<InputAction> triggerActions)
	{
		if (triggerActions == null)
		{
			triggerActions = new Il2CppStructArray<InputAction>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideDuration;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiresMouseMovement;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)triggerActions);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateInputActionHint_Public_Abstract_Virtual_New_Hint_String_Single_Boolean_Il2CppStructArray_1_InputAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hint>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Hint CreateTimedHint(string identifier, float showDuration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showDuration;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateTimedHint_Public_Abstract_Virtual_New_Hint_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hint>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Hint CreateHint(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateHint_Public_Abstract_Virtual_New_Hint_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hint>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool IsHintCompleted(int playerId, string hintIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(hintIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsHintCompleted_Public_Abstract_Virtual_New_Boolean_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void MarkHintCompleted(int playerId, string hintIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(hintIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MarkHintCompleted_Public_Abstract_Virtual_New_Void_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void ReadObjectiveTaskGroup(int playerId, string objectiveIdentifier, string objectiveTaskGroupIdentifier, int targetCharacterInstanceId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectiveIdentifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectiveTaskGroupIdentifier);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReadObjectiveTaskGroup_Public_Abstract_Virtual_New_Void_Int32_String_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void ClearActiveObjectives()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClearActiveObjectives_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Objective GetObjective(int playerId, string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetObjective_Public_Abstract_Virtual_New_Objective_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void GetCompletedObjectives(int playerId, List<Objective> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCompletedObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetActiveObjectives(int playerId, List<Objective> result, bool includeHidden = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeHidden;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual ObjectiveTaskGroup GetNetworkedObjectiveTaskGroup(string objectiveIdentifier, string objectiveTaskGroupIdentifier, int targetCharacterInstanceId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(objectiveIdentifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectiveTaskGroupIdentifier);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetNetworkedObjectiveTaskGroup_Public_Abstract_Virtual_New_ObjectiveTaskGroup_String_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroup>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void CompleteNetworkedObjective(string messageObjectiveIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(messageObjectiveIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CompleteNetworkedObjective_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HandlePlayerActivation(WorldPlayer worldPlayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandlePlayerActivation_Public_Abstract_Virtual_New_Void_WorldPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SaveGame(GameSave gameSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameSave);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Void_GameSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void LoadGame(GameSave gameSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameSave);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadGame_Public_Abstract_Virtual_New_Void_GameSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Objective AssignNpcRequestObjective(WorldPlayer worldPlayer, int targetCharacterInstanceId, [Optional] Il2CppReferenceArray<ObjectiveTaskGroup> objectiveTaskGroups)
	{
		if (objectiveTaskGroups == null)
		{
			objectiveTaskGroups = new Il2CppReferenceArray<ObjectiveTaskGroup>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroups);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AssignNpcRequestObjective_Public_Abstract_Virtual_New_Objective_WorldPlayer_Int32_Il2CppReferenceArray_1_ObjectiveTaskGroup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Objective GetNpcRequestObjective(int playerId, int targetCharacterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetNpcRequestObjective_Public_Abstract_Virtual_New_Objective_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void GetActiveNpcRequestObjectives(int playerId, List<Objective> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveNpcRequestObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetCompletedNpcRequestObjectives(int playerId, List<Objective> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCompletedNpcRequestObjectives_Public_Abstract_Virtual_New_Void_Int32_List_1_Objective_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddNetworkedObjective(Objective objective)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddNetworkedObjective_Public_Abstract_Virtual_New_Void_Objective_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddNetworkedObjectiveTaskGroup(string objectiveIdentifier, ObjectiveTaskGroup objectiveTaskGroup, int targetCharacterInstanceId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(objectiveIdentifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroup);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddNetworkedObjectiveTaskGroup_Public_Abstract_Virtual_New_Void_String_ObjectiveTaskGroup_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void CompleteNetworkedNpcRequestObjective(int targetCharacterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetCharacterInstanceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CompleteNetworkedNpcRequestObjective_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddCompletedHintIdentifiers(HashSet<string> identifiers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddCompletedHintIdentifiers_Public_Abstract_Virtual_New_Void_HashSet_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public virtual void AddObjectiveTaskGroups(Objective existingObjective, params ObjectiveTaskGroup[] objectiveTaskGroups)
	{
		AddObjectiveTaskGroups(existingObjective, new Il2CppReferenceArray<ObjectiveTaskGroup>(objectiveTaskGroups));
	}

	public virtual Objective AssignNewObjective(WorldPlayer worldPlayer, string identifier, bool hidden, bool showJournal, params ObjectiveTaskGroup[] objectiveTaskGroups)
	{
		return AssignNewObjective(worldPlayer, identifier, hidden, showJournal, new Il2CppReferenceArray<ObjectiveTaskGroup>(objectiveTaskGroups));
	}

	public virtual Hint CreateInputActionHint(string identifier, float hideDuration, params InputAction[] triggerActions)
	{
		return CreateInputActionHint(identifier, hideDuration, new Il2CppStructArray<InputAction>(triggerActions));
	}

	public virtual Hint CreateInputActionHint(string identifier, float hideDuration, bool requiresMouseMovement, params InputAction[] triggerActions)
	{
		return CreateInputActionHint(identifier, hideDuration, requiresMouseMovement, new Il2CppStructArray<InputAction>(triggerActions));
	}

	public virtual Objective AssignNpcRequestObjective(WorldPlayer worldPlayer, int targetCharacterInstanceId, params ObjectiveTaskGroup[] objectiveTaskGroups)
	{
		return AssignNpcRequestObjective(worldPlayer, targetCharacterInstanceId, new Il2CppReferenceArray<ObjectiveTaskGroup>(objectiveTaskGroups));
	}

	public IObjectiveManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

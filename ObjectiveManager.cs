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

public class ObjectiveManager : Il2CppSystem.Object
{
	[ObfuscatedName("ObjectiveManager+<Initialize>d__83")]
	public sealed class _Initialize_d__83 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe ObjectiveManager __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveManager>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveManager));
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _Initialize_d__83()
		{
			Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<Initialize>d__83");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr, 100676632);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr, 100676633);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr, 100676634);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr, 100676635);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr, 100676636);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr, 100676637);
		}

		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 37231, RefRangeEnd = 37260, XrefRangeStart = 37231, XrefRangeEnd = 37260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Initialize_d__83(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Initialize_d__83>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(13368)]
		[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184914, XrefRangeEnd = 185206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185206, XrefRangeEnd = 185212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _Initialize_d__83(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__gameManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__worldManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__playerManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__networkManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__modelDefinitionManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__inventoryManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__constructionManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__injuryManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__analyticsManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__settingsManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__placementSuccessSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__constructionCompleteSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__cookingCompleteSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__itemHardenedSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__itemTreatedSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__objectiveCompleteSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__objectiveTaskGroupCompleteSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectiveDefinitionMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectiveTaskGroupDefinitionMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_hintDefinitionMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeObjectives;

	private static readonly System.IntPtr NativeFieldInfoPtr_completedObjectives;

	private static readonly System.IntPtr NativeFieldInfoPtr_completedHintIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeNpcRequestObjectives;

	private static readonly System.IntPtr NativeFieldInfoPtr_completedNpcRequestObjectives;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectivesToComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectivesToLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcRequestObjectivesToLoad;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gameManager_Public_get_IGameManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_gameManager_Public_set_Void_IGameManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_worldManager_Public_get_IWorldManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_worldManager_Public_set_Void_IWorldManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerManager_Public_get_IPlayerManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playerManager_Public_set_Void_IPlayerManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_networkManager_Public_get_INetworkManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_networkManager_Public_set_Void_INetworkManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_modelDefinitionManager_Public_get_IModelDefinitionManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_modelDefinitionManager_Public_set_Void_IModelDefinitionManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inventoryManager_Public_get_IInventoryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_inventoryManager_Public_set_Void_IInventoryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_constructionManager_Public_get_IConstructionManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_constructionManager_Public_set_Void_IConstructionManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_injuryManager_Public_get_IInjuryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_injuryManager_Public_set_Void_IInjuryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_analyticsManager_Public_get_IAnalyticsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_analyticsManager_Public_set_Void_IAnalyticsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_settingsManager_Public_get_ISettingsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_settingsManager_Public_set_Void_ISettingsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_placementSuccessSignal_Public_get_PlacementSuccessSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_placementSuccessSignal_Public_set_Void_PlacementSuccessSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_constructionCompleteSignal_Public_get_ConstructionCompleteSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_constructionCompleteSignal_Public_set_Void_ConstructionCompleteSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fuelIgnitedSignal_Public_get_FuelIgnitedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fuelIgnitedSignal_Public_set_Void_FuelIgnitedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cookingCompleteSignal_Public_get_CookingCompleteSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cookingCompleteSignal_Public_set_Void_CookingCompleteSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_itemHardenedSignal_Public_get_ItemHardenedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_itemHardenedSignal_Public_set_Void_ItemHardenedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_itemTreatedSignal_Public_get_ItemTreatedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_itemTreatedSignal_Public_set_Void_ItemTreatedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_objectiveCompleteSignal_Public_get_ObjectiveCompleteSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_objectiveCompleteSignal_Public_set_Void_ObjectiveCompleteSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_objectiveTaskGroupCompleteSignal_Public_get_ObjectiveTaskGroupCompleteSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_objectiveTaskGroupCompleteSignal_Public_set_Void_ObjectiveTaskGroupCompleteSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onLanguageChange_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onGameUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resolveObjectiveDefinition_Private_Boolean_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tryGetObjectiveDefinition_Private_Boolean_String_byref_ObjectiveDefinition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getOrCreateObjectiveMap_Private_Dictionary_2_String_Objective_Dictionary_2_Int32_Dictionary_2_String_Objective_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getOrCreateObjectiveList_Private_List_1_Objective_Dictionary_2_Int32_List_1_Objective_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createObjective_Private_Objective_ObjectiveDefinition_String_Int32_Boolean_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initializeAssignedObjectiveTaskGroups_Private_Void_Objective_IEnumerable_1_ObjectiveTaskGroup_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_notifyObjectiveAssigned_Private_Void_WorldPlayer_Objective_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getObjectiveByNetworkIdentifier_Private_Objective_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadObjective_Private_Void_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadNpcRequestObjective_Private_Void_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadObjectiveTaskGroup_Private_Boolean_Objective_ObjectiveTaskGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_processActiveObjective_Private_Boolean_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_completeObjective_Private_Void_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleActiveObjectives_Private_Void_Dictionary_2_String_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleActiveNpcRequestObjectives_Private_Void_List_1_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateObjectiveTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_Il2CppReferenceArray_1_Hint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDynamicCollectItemTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDynamicBasicTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_LocalizedString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddObjectiveTaskGroups_Public_Virtual_Final_New_Void_Objective_Il2CppReferenceArray_1_ObjectiveTaskGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignNewObjective_Public_Virtual_Final_New_Objective_WorldPlayer_String_Boolean_Boolean_List_1_ObjectiveTaskGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignNewObjective_Public_Virtual_Final_New_Objective_WorldPlayer_String_Boolean_Boolean_Il2CppReferenceArray_1_ObjectiveTaskGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignNpcRequestObjective_Public_Virtual_Final_New_Objective_WorldPlayer_Int32_Il2CppReferenceArray_1_ObjectiveTaskGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNpcRequestObjective_Public_Virtual_Final_New_Objective_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveNpcRequestObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompletedNpcRequestObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateUIOpenHint_Public_Virtual_Final_New_Hint_String_Single_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputActionHint_Public_Virtual_Final_New_Hint_String_Single_Il2CppStructArray_1_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInputActionHint_Public_Virtual_Final_New_Hint_String_Single_Boolean_Il2CppStructArray_1_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTimedHint_Public_Virtual_Final_New_Hint_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHint_Public_Virtual_Final_New_Hint_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHintCompleted_Public_Virtual_Final_New_Boolean_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkHintCompleted_Public_Virtual_Final_New_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadObjectiveTaskGroup_Public_Virtual_Final_New_Void_Int32_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearActiveObjectives_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjective_Public_Virtual_Final_New_Objective_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompletedObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkedObjectiveTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompleteNetworkedObjective_Public_Virtual_Final_New_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandlePlayerActivation_Public_Virtual_Final_New_Void_WorldPlayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveGame_Public_Virtual_Final_New_Void_GameSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadGame_Public_Virtual_Final_New_Void_GameSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNetworkedObjective_Public_Virtual_Final_New_Void_Objective_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompleteNetworkedNpcRequestObjective_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNetworkedObjectiveTaskGroup_Public_Virtual_Final_New_Void_String_ObjectiveTaskGroup_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCompletedHintIdentifiers_Public_Virtual_Final_New_Void_HashSet_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initializeTask_Private_Void_IObjectiveTask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTaskCondition_Private_IObjectiveTaskCondition_ObjectiveTaskConditionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IGameManager _gameManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameManager));
		}
	}

	public unsafe IWorldManager _worldManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__worldManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWorldManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__worldManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldManager));
		}
	}

	public unsafe IPlayerManager _playerManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPlayerManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerManager));
		}
	}

	public unsafe INetworkManager _networkManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__networkManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<INetworkManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__networkManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager));
		}
	}

	public unsafe IModelDefinitionManager _modelDefinitionManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__modelDefinitionManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IModelDefinitionManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__modelDefinitionManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)modelDefinitionManager));
		}
	}

	public unsafe IInventoryManager _inventoryManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inventoryManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inventoryManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager));
		}
	}

	public unsafe IConstructionManager _constructionManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__constructionManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IConstructionManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__constructionManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constructionManager));
		}
	}

	public unsafe IInjuryManager _injuryManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__injuryManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjuryManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__injuryManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuryManager));
		}
	}

	public unsafe IAnalyticsManager _analyticsManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__analyticsManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAnalyticsManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__analyticsManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)analyticsManager));
		}
	}

	public unsafe ISettingsManager _settingsManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settingsManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISettingsManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settingsManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settingsManager));
		}
	}

	public unsafe PlacementSuccessSignal _placementSuccessSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__placementSuccessSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlacementSuccessSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__placementSuccessSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placementSuccessSignal));
		}
	}

	public unsafe ConstructionCompleteSignal _constructionCompleteSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__constructionCompleteSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConstructionCompleteSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__constructionCompleteSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constructionCompleteSignal));
		}
	}

	public unsafe FuelIgnitedSignal _fuelIgnitedSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FuelIgnitedSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fuelIgnitedSignal));
		}
	}

	public unsafe CookingCompleteSignal _cookingCompleteSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cookingCompleteSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CookingCompleteSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cookingCompleteSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cookingCompleteSignal));
		}
	}

	public unsafe ItemHardenedSignal _itemHardenedSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemHardenedSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemHardenedSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemHardenedSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemHardenedSignal));
		}
	}

	public unsafe ItemTreatedSignal _itemTreatedSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemTreatedSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemTreatedSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemTreatedSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemTreatedSignal));
		}
	}

	public unsafe ObjectiveCompleteSignal _objectiveCompleteSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectiveCompleteSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveCompleteSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectiveCompleteSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveCompleteSignal));
		}
	}

	public unsafe ObjectiveTaskGroupCompleteSignal _objectiveTaskGroupCompleteSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectiveTaskGroupCompleteSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroupCompleteSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__objectiveTaskGroupCompleteSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroupCompleteSignal));
		}
	}

	public unsafe Dictionary<string, ObjectiveDefinition> objectiveDefinitionMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveDefinitionMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, ObjectiveDefinition>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveDefinitionMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, ObjectiveTaskGroupDefinition> objectiveTaskGroupDefinitionMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveTaskGroupDefinitionMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, ObjectiveTaskGroupDefinition>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveTaskGroupDefinitionMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, HintDefinition> hintDefinitionMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hintDefinitionMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HintDefinition>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hintDefinitionMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, Dictionary<string, Objective>> activeObjectives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeObjectives);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<string, Objective>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeObjectives)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, Dictionary<string, Objective>> completedObjectives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedObjectives);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<string, Objective>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedObjectives)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, HashSet<string>> completedHintIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedHintIdentifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, HashSet<string>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedHintIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, List<Objective>> activeNpcRequestObjectives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeNpcRequestObjectives);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<Objective>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeNpcRequestObjectives)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, List<Objective>> completedNpcRequestObjectives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedNpcRequestObjectives);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<Objective>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedNpcRequestObjectives)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<Objective> objectivesToComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectivesToComplete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Objective>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectivesToComplete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Objective> objectivesToLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectivesToLoad);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Objective>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectivesToLoad)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Objective> npcRequestObjectivesToLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcRequestObjectivesToLoad);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Objective>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcRequestObjectivesToLoad)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe IGameManager gameManager
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 3866, RefRangeEnd = 3876, XrefRangeStart = 3866, XrefRangeEnd = 3876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gameManager_Public_get_IGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameManager>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29379, RefRangeEnd = 29381, XrefRangeStart = 29379, XrefRangeEnd = 29381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gameManager_Public_set_Void_IGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IWorldManager worldManager
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldManager_Public_get_IWorldManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWorldManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_worldManager_Public_set_Void_IWorldManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IPlayerManager playerManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18747, RefRangeEnd = 18748, XrefRangeStart = 18747, XrefRangeEnd = 18748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerManager_Public_get_IPlayerManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPlayerManager>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18749, RefRangeEnd = 18750, XrefRangeStart = 18749, XrefRangeEnd = 18750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerManager_Public_set_Void_IPlayerManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe INetworkManager networkManager
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19167, RefRangeEnd = 19170, XrefRangeStart = 19167, XrefRangeEnd = 19170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_networkManager_Public_get_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<INetworkManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_networkManager_Public_set_Void_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IModelDefinitionManager modelDefinitionManager
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 19179, RefRangeEnd = 19194, XrefRangeStart = 19179, XrefRangeEnd = 19194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_modelDefinitionManager_Public_get_IModelDefinitionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IModelDefinitionManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_modelDefinitionManager_Public_set_Void_IModelDefinitionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IInventoryManager inventoryManager
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 977, RefRangeEnd = 983, XrefRangeStart = 977, XrefRangeEnd = 983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inventoryManager_Public_get_IInventoryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inventoryManager_Public_set_Void_IInventoryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IConstructionManager constructionManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97543, RefRangeEnd = 97544, XrefRangeStart = 97543, XrefRangeEnd = 97544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_constructionManager_Public_get_IConstructionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IConstructionManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_constructionManager_Public_set_Void_IConstructionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IInjuryManager injuryManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_injuryManager_Public_get_IInjuryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjuryManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_injuryManager_Public_set_Void_IInjuryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IAnalyticsManager analyticsManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32262, RefRangeEnd = 32263, XrefRangeStart = 32262, XrefRangeEnd = 32263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_analyticsManager_Public_get_IAnalyticsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAnalyticsManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_analyticsManager_Public_set_Void_IAnalyticsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ISettingsManager settingsManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_settingsManager_Public_get_ISettingsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISettingsManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_settingsManager_Public_set_Void_ISettingsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe PlacementSuccessSignal placementSuccessSignal
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 96676, RefRangeEnd = 96716, XrefRangeStart = 96676, XrefRangeEnd = 96716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_placementSuccessSignal_Public_get_PlacementSuccessSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlacementSuccessSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_placementSuccessSignal_Public_set_Void_PlacementSuccessSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ConstructionCompleteSignal constructionCompleteSignal
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 30821, RefRangeEnd = 30837, XrefRangeStart = 30821, XrefRangeEnd = 30837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_constructionCompleteSignal_Public_get_ConstructionCompleteSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConstructionCompleteSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_constructionCompleteSignal_Public_set_Void_ConstructionCompleteSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe FuelIgnitedSignal fuelIgnitedSignal
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96991, RefRangeEnd = 96992, XrefRangeStart = 96991, XrefRangeEnd = 96992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fuelIgnitedSignal_Public_get_FuelIgnitedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FuelIgnitedSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fuelIgnitedSignal_Public_set_Void_FuelIgnitedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe CookingCompleteSignal cookingCompleteSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cookingCompleteSignal_Public_get_CookingCompleteSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CookingCompleteSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cookingCompleteSignal_Public_set_Void_CookingCompleteSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ItemHardenedSignal itemHardenedSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_itemHardenedSignal_Public_get_ItemHardenedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemHardenedSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_itemHardenedSignal_Public_set_Void_ItemHardenedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ItemTreatedSignal itemTreatedSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_itemTreatedSignal_Public_get_ItemTreatedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemTreatedSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_itemTreatedSignal_Public_set_Void_ItemTreatedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ObjectiveCompleteSignal objectiveCompleteSignal
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 96529, RefRangeEnd = 96536, XrefRangeStart = 96529, XrefRangeEnd = 96536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_objectiveCompleteSignal_Public_get_ObjectiveCompleteSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveCompleteSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_objectiveCompleteSignal_Public_set_Void_ObjectiveCompleteSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ObjectiveTaskGroupCompleteSignal objectiveTaskGroupCompleteSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_objectiveTaskGroupCompleteSignal_Public_get_ObjectiveTaskGroupCompleteSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroupCompleteSignal>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98360, RefRangeEnd = 98361, XrefRangeStart = 98360, XrefRangeEnd = 98361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_objectiveTaskGroupCompleteSignal_Public_set_Void_ObjectiveTaskGroupCompleteSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ObjectiveManager()
	{
		Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ObjectiveManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr);
		NativeFieldInfoPtr__gameManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<gameManager>k__BackingField");
		NativeFieldInfoPtr__worldManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<worldManager>k__BackingField");
		NativeFieldInfoPtr__playerManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<playerManager>k__BackingField");
		NativeFieldInfoPtr__networkManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<networkManager>k__BackingField");
		NativeFieldInfoPtr__modelDefinitionManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<modelDefinitionManager>k__BackingField");
		NativeFieldInfoPtr__inventoryManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<inventoryManager>k__BackingField");
		NativeFieldInfoPtr__constructionManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<constructionManager>k__BackingField");
		NativeFieldInfoPtr__injuryManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<injuryManager>k__BackingField");
		NativeFieldInfoPtr__analyticsManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<analyticsManager>k__BackingField");
		NativeFieldInfoPtr__settingsManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<settingsManager>k__BackingField");
		NativeFieldInfoPtr__placementSuccessSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<placementSuccessSignal>k__BackingField");
		NativeFieldInfoPtr__constructionCompleteSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<constructionCompleteSignal>k__BackingField");
		NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<fuelIgnitedSignal>k__BackingField");
		NativeFieldInfoPtr__cookingCompleteSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<cookingCompleteSignal>k__BackingField");
		NativeFieldInfoPtr__itemHardenedSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<itemHardenedSignal>k__BackingField");
		NativeFieldInfoPtr__itemTreatedSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<itemTreatedSignal>k__BackingField");
		NativeFieldInfoPtr__objectiveCompleteSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<objectiveCompleteSignal>k__BackingField");
		NativeFieldInfoPtr__objectiveTaskGroupCompleteSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "<objectiveTaskGroupCompleteSignal>k__BackingField");
		NativeFieldInfoPtr_objectiveDefinitionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "objectiveDefinitionMap");
		NativeFieldInfoPtr_objectiveTaskGroupDefinitionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "objectiveTaskGroupDefinitionMap");
		NativeFieldInfoPtr_hintDefinitionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "hintDefinitionMap");
		NativeFieldInfoPtr_activeObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "activeObjectives");
		NativeFieldInfoPtr_completedObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "completedObjectives");
		NativeFieldInfoPtr_completedHintIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "completedHintIdentifiers");
		NativeFieldInfoPtr_activeNpcRequestObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "activeNpcRequestObjectives");
		NativeFieldInfoPtr_completedNpcRequestObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "completedNpcRequestObjectives");
		NativeFieldInfoPtr_objectivesToComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "objectivesToComplete");
		NativeFieldInfoPtr_objectivesToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "objectivesToLoad");
		NativeFieldInfoPtr_npcRequestObjectivesToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, "npcRequestObjectivesToLoad");
		NativeMethodInfoPtr_get_gameManager_Public_get_IGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676544);
		NativeMethodInfoPtr_set_gameManager_Public_set_Void_IGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676545);
		NativeMethodInfoPtr_get_worldManager_Public_get_IWorldManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676546);
		NativeMethodInfoPtr_set_worldManager_Public_set_Void_IWorldManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676547);
		NativeMethodInfoPtr_get_playerManager_Public_get_IPlayerManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676548);
		NativeMethodInfoPtr_set_playerManager_Public_set_Void_IPlayerManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676549);
		NativeMethodInfoPtr_get_networkManager_Public_get_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676550);
		NativeMethodInfoPtr_set_networkManager_Public_set_Void_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676551);
		NativeMethodInfoPtr_get_modelDefinitionManager_Public_get_IModelDefinitionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676552);
		NativeMethodInfoPtr_set_modelDefinitionManager_Public_set_Void_IModelDefinitionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676553);
		NativeMethodInfoPtr_get_inventoryManager_Public_get_IInventoryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676554);
		NativeMethodInfoPtr_set_inventoryManager_Public_set_Void_IInventoryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676555);
		NativeMethodInfoPtr_get_constructionManager_Public_get_IConstructionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676556);
		NativeMethodInfoPtr_set_constructionManager_Public_set_Void_IConstructionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676557);
		NativeMethodInfoPtr_get_injuryManager_Public_get_IInjuryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676558);
		NativeMethodInfoPtr_set_injuryManager_Public_set_Void_IInjuryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676559);
		NativeMethodInfoPtr_get_analyticsManager_Public_get_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676560);
		NativeMethodInfoPtr_set_analyticsManager_Public_set_Void_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676561);
		NativeMethodInfoPtr_get_settingsManager_Public_get_ISettingsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676562);
		NativeMethodInfoPtr_set_settingsManager_Public_set_Void_ISettingsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676563);
		NativeMethodInfoPtr_get_placementSuccessSignal_Public_get_PlacementSuccessSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676564);
		NativeMethodInfoPtr_set_placementSuccessSignal_Public_set_Void_PlacementSuccessSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676565);
		NativeMethodInfoPtr_get_constructionCompleteSignal_Public_get_ConstructionCompleteSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676566);
		NativeMethodInfoPtr_set_constructionCompleteSignal_Public_set_Void_ConstructionCompleteSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676567);
		NativeMethodInfoPtr_get_fuelIgnitedSignal_Public_get_FuelIgnitedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676568);
		NativeMethodInfoPtr_set_fuelIgnitedSignal_Public_set_Void_FuelIgnitedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676569);
		NativeMethodInfoPtr_get_cookingCompleteSignal_Public_get_CookingCompleteSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676570);
		NativeMethodInfoPtr_set_cookingCompleteSignal_Public_set_Void_CookingCompleteSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676571);
		NativeMethodInfoPtr_get_itemHardenedSignal_Public_get_ItemHardenedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676572);
		NativeMethodInfoPtr_set_itemHardenedSignal_Public_set_Void_ItemHardenedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676573);
		NativeMethodInfoPtr_get_itemTreatedSignal_Public_get_ItemTreatedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676574);
		NativeMethodInfoPtr_set_itemTreatedSignal_Public_set_Void_ItemTreatedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676575);
		NativeMethodInfoPtr_get_objectiveCompleteSignal_Public_get_ObjectiveCompleteSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676576);
		NativeMethodInfoPtr_set_objectiveCompleteSignal_Public_set_Void_ObjectiveCompleteSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676577);
		NativeMethodInfoPtr_get_objectiveTaskGroupCompleteSignal_Public_get_ObjectiveTaskGroupCompleteSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676578);
		NativeMethodInfoPtr_set_objectiveTaskGroupCompleteSignal_Public_set_Void_ObjectiveTaskGroupCompleteSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676579);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676580);
		NativeMethodInfoPtr_onLanguageChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676581);
		NativeMethodInfoPtr_onGameUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676582);
		NativeMethodInfoPtr_resolveObjectiveDefinition_Private_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676583);
		NativeMethodInfoPtr_tryGetObjectiveDefinition_Private_Boolean_String_byref_ObjectiveDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676584);
		NativeMethodInfoPtr_getOrCreateObjectiveMap_Private_Dictionary_2_String_Objective_Dictionary_2_Int32_Dictionary_2_String_Objective_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676585);
		NativeMethodInfoPtr_getOrCreateObjectiveList_Private_List_1_Objective_Dictionary_2_Int32_List_1_Objective_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676586);
		NativeMethodInfoPtr_createObjective_Private_Objective_ObjectiveDefinition_String_Int32_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676587);
		NativeMethodInfoPtr_initializeAssignedObjectiveTaskGroups_Private_Void_Objective_IEnumerable_1_ObjectiveTaskGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676588);
		NativeMethodInfoPtr_notifyObjectiveAssigned_Private_Void_WorldPlayer_Objective_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676589);
		NativeMethodInfoPtr_getObjectiveByNetworkIdentifier_Private_Objective_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676590);
		NativeMethodInfoPtr_loadObjective_Private_Void_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676591);
		NativeMethodInfoPtr_loadNpcRequestObjective_Private_Void_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676592);
		NativeMethodInfoPtr_loadObjectiveTaskGroup_Private_Boolean_Objective_ObjectiveTaskGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676593);
		NativeMethodInfoPtr_processActiveObjective_Private_Boolean_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676594);
		NativeMethodInfoPtr_completeObjective_Private_Void_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676595);
		NativeMethodInfoPtr_handleActiveObjectives_Private_Void_Dictionary_2_String_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676596);
		NativeMethodInfoPtr_handleActiveNpcRequestObjectives_Private_Void_List_1_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676597);
		NativeMethodInfoPtr_CreateObjectiveTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_Il2CppReferenceArray_1_Hint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676598);
		NativeMethodInfoPtr_CreateDynamicCollectItemTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676599);
		NativeMethodInfoPtr_CreateDynamicBasicTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676600);
		NativeMethodInfoPtr_AddObjectiveTaskGroups_Public_Virtual_Final_New_Void_Objective_Il2CppReferenceArray_1_ObjectiveTaskGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676601);
		NativeMethodInfoPtr_AssignNewObjective_Public_Virtual_Final_New_Objective_WorldPlayer_String_Boolean_Boolean_List_1_ObjectiveTaskGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676602);
		NativeMethodInfoPtr_AssignNewObjective_Public_Virtual_Final_New_Objective_WorldPlayer_String_Boolean_Boolean_Il2CppReferenceArray_1_ObjectiveTaskGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676603);
		NativeMethodInfoPtr_AssignNpcRequestObjective_Public_Virtual_Final_New_Objective_WorldPlayer_Int32_Il2CppReferenceArray_1_ObjectiveTaskGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676604);
		NativeMethodInfoPtr_GetNpcRequestObjective_Public_Virtual_Final_New_Objective_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676605);
		NativeMethodInfoPtr_GetActiveNpcRequestObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676606);
		NativeMethodInfoPtr_GetCompletedNpcRequestObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676607);
		NativeMethodInfoPtr_CreateUIOpenHint_Public_Virtual_Final_New_Hint_String_Single_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676608);
		NativeMethodInfoPtr_CreateInputActionHint_Public_Virtual_Final_New_Hint_String_Single_Il2CppStructArray_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676609);
		NativeMethodInfoPtr_CreateInputActionHint_Public_Virtual_Final_New_Hint_String_Single_Boolean_Il2CppStructArray_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676610);
		NativeMethodInfoPtr_CreateTimedHint_Public_Virtual_Final_New_Hint_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676611);
		NativeMethodInfoPtr_CreateHint_Public_Virtual_Final_New_Hint_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676612);
		NativeMethodInfoPtr_IsHintCompleted_Public_Virtual_Final_New_Boolean_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676613);
		NativeMethodInfoPtr_MarkHintCompleted_Public_Virtual_Final_New_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676614);
		NativeMethodInfoPtr_ReadObjectiveTaskGroup_Public_Virtual_Final_New_Void_Int32_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676615);
		NativeMethodInfoPtr_ClearActiveObjectives_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676616);
		NativeMethodInfoPtr_GetObjective_Public_Virtual_Final_New_Objective_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676617);
		NativeMethodInfoPtr_GetCompletedObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676618);
		NativeMethodInfoPtr_GetActiveObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676619);
		NativeMethodInfoPtr_GetNetworkedObjectiveTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676620);
		NativeMethodInfoPtr_CompleteNetworkedObjective_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676621);
		NativeMethodInfoPtr_HandlePlayerActivation_Public_Virtual_Final_New_Void_WorldPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676622);
		NativeMethodInfoPtr_SaveGame_Public_Virtual_Final_New_Void_GameSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676623);
		NativeMethodInfoPtr_LoadGame_Public_Virtual_Final_New_Void_GameSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676624);
		NativeMethodInfoPtr_AddNetworkedObjective_Public_Virtual_Final_New_Void_Objective_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676625);
		NativeMethodInfoPtr_CompleteNetworkedNpcRequestObjective_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676626);
		NativeMethodInfoPtr_AddNetworkedObjectiveTaskGroup_Public_Virtual_Final_New_Void_String_ObjectiveTaskGroup_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676627);
		NativeMethodInfoPtr_AddCompletedHintIdentifiers_Public_Virtual_Final_New_Void_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676628);
		NativeMethodInfoPtr_initializeTask_Private_Void_IObjectiveTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676629);
		NativeMethodInfoPtr_getTaskCondition_Private_IObjectiveTaskCondition_ObjectiveTaskConditionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676630);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr, 100676631);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185212, XrefRangeEnd = 185217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185217, XrefRangeEnd = 185334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onLanguageChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onLanguageChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185334, XrefRangeEnd = 185411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onGameUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGameUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 185471, RefRangeEnd = 185473, XrefRangeStart = 185411, XrefRangeEnd = 185471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool resolveObjectiveDefinition(Objective objective)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resolveObjectiveDefinition_Private_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185473, XrefRangeEnd = 185480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool tryGetObjectiveDefinition(string identifier, out ObjectiveDefinition definition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tryGetObjectiveDefinition_Private_Boolean_String_byref_ObjectiveDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		definition = ((num3 == 0) ? null : new ObjectiveDefinition(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185480, XrefRangeEnd = 185492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<string, Objective> getOrCreateObjectiveMap(Dictionary<int, Dictionary<string, Objective>> objectivesByPlayer, int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectivesByPlayer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getOrCreateObjectiveMap_Private_Dictionary_2_String_Objective_Dictionary_2_Int32_Dictionary_2_String_Objective_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Objective>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185492, XrefRangeEnd = 185504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Objective> getOrCreateObjectiveList(Dictionary<int, List<Objective>> objectivesByPlayer, int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectivesByPlayer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getOrCreateObjectiveList_Private_List_1_Objective_Dictionary_2_Int32_List_1_Objective_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Objective>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185504, XrefRangeEnd = 185509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Objective createObjective(ObjectiveDefinition definition, string identifier, int playerId, bool hidden, bool showJournal, int targetCharacterInstanceId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)definition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerId;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hidden;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &showJournal;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createObjective_Private_Objective_ObjectiveDefinition_String_Int32_Boolean_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185509, XrefRangeEnd = 185546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initializeAssignedObjectiveTaskGroups(Objective objective, IEnumerable<ObjectiveTaskGroup> objectiveTaskGroups, bool activateFirstGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroups);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &activateFirstGroup;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initializeAssignedObjectiveTaskGroups_Private_Void_Objective_IEnumerable_1_ObjectiveTaskGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185546, XrefRangeEnd = 185550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void notifyObjectiveAssigned(WorldPlayer worldPlayer, Objective objective, string analyticsIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(analyticsIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_notifyObjectiveAssigned_Private_Void_WorldPlayer_Objective_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 185592, RefRangeEnd = 185595, XrefRangeStart = 185550, XrefRangeEnd = 185592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Objective getObjectiveByNetworkIdentifier(int playerId, string objectiveIdentifier, int targetCharacterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectiveIdentifier);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getObjectiveByNetworkIdentifier_Private_Objective_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 185621, RefRangeEnd = 185622, XrefRangeStart = 185595, XrefRangeEnd = 185621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadObjective(Objective objective)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadObjective_Private_Void_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 185648, RefRangeEnd = 185649, XrefRangeStart = 185622, XrefRangeEnd = 185648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadNpcRequestObjective(Objective objective)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadNpcRequestObjective_Private_Void_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 185816, RefRangeEnd = 185818, XrefRangeStart = 185649, XrefRangeEnd = 185816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool loadObjectiveTaskGroup(Objective objective, ObjectiveTaskGroup objectiveTaskGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroup);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadObjectiveTaskGroup_Private_Boolean_Objective_ObjectiveTaskGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 185886, RefRangeEnd = 185888, XrefRangeStart = 185818, XrefRangeEnd = 185886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool processActiveObjective(Objective objective)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_processActiveObjective_Private_Boolean_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 185899, RefRangeEnd = 185901, XrefRangeStart = 185888, XrefRangeEnd = 185899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void completeObjective(Objective objective)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_completeObjective_Private_Void_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186001, RefRangeEnd = 186002, XrefRangeStart = 185901, XrefRangeEnd = 186001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleActiveObjectives(Dictionary<string, Objective> activeObjectiveMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeObjectiveMap);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleActiveObjectives_Private_Void_Dictionary_2_String_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186065, RefRangeEnd = 186066, XrefRangeStart = 186002, XrefRangeEnd = 186065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleActiveNpcRequestObjectives(List<Objective> objectiveList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleActiveNpcRequestObjectives_Private_Void_List_1_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186066, XrefRangeEnd = 186120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ObjectiveTaskGroup CreateObjectiveTaskGroup(string identifier, Il2CppReferenceArray<Hint> hints = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateObjectiveTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_Il2CppReferenceArray_1_Hint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroup>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186120, XrefRangeEnd = 186139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ObjectiveTaskGroup CreateDynamicCollectItemTaskGroup(string identifier, LocalizedString title, LocalizedString description, string itemIdentifier, int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)title));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)description));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(itemIdentifier);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDynamicCollectItemTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroup>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186139, XrefRangeEnd = 186154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ObjectiveTaskGroup CreateDynamicBasicTaskGroup(string identifier, LocalizedString title, LocalizedString description, LocalizedString taskText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)title));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)description));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)taskText));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDynamicBasicTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_LocalizedString_LocalizedString_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroup>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186154, XrefRangeEnd = 186183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddObjectiveTaskGroups_Public_Virtual_Final_New_Void_Objective_Il2CppReferenceArray_1_ObjectiveTaskGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 186192, RefRangeEnd = 186193, XrefRangeStart = 186183, XrefRangeEnd = 186192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignNewObjective_Public_Virtual_Final_New_Objective_WorldPlayer_String_Boolean_Boolean_List_1_ObjectiveTaskGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186193, XrefRangeEnd = 186201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignNewObjective_Public_Virtual_Final_New_Objective_WorldPlayer_String_Boolean_Boolean_Il2CppReferenceArray_1_ObjectiveTaskGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186201, XrefRangeEnd = 186211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignNpcRequestObjective_Public_Virtual_Final_New_Objective_WorldPlayer_Int32_Il2CppReferenceArray_1_ObjectiveTaskGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186211, XrefRangeEnd = 186238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Objective GetNpcRequestObjective(int playerId, int targetCharacterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNpcRequestObjective_Public_Virtual_Final_New_Objective_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186238, XrefRangeEnd = 186258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void GetActiveNpcRequestObjectives(int playerId, List<Objective> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveNpcRequestObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186258, XrefRangeEnd = 186278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void GetCompletedNpcRequestObjectives(int playerId, List<Objective> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompletedNpcRequestObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186278, XrefRangeEnd = 186285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Hint CreateUIOpenHint(string identifier, float hideDuration, Il2CppSystem.Type uiType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hideDuration;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uiType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateUIOpenHint_Public_Virtual_Final_New_Hint_String_Single_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hint>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186285, XrefRangeEnd = 186293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputActionHint_Public_Virtual_Final_New_Hint_String_Single_Il2CppStructArray_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hint>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186293, XrefRangeEnd = 186300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInputActionHint_Public_Virtual_Final_New_Hint_String_Single_Boolean_Il2CppStructArray_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hint>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186300, XrefRangeEnd = 186307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Hint CreateTimedHint(string identifier, float showDuration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showDuration;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTimedHint_Public_Virtual_Final_New_Hint_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hint>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186307, XrefRangeEnd = 186314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Hint CreateHint(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHint_Public_Virtual_Final_New_Hint_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hint>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186314, XrefRangeEnd = 186318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsHintCompleted(int playerId, string hintIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(hintIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHintCompleted_Public_Virtual_Final_New_Boolean_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186318, XrefRangeEnd = 186336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MarkHintCompleted(int playerId, string hintIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(hintIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkHintCompleted_Public_Virtual_Final_New_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186336, XrefRangeEnd = 186338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ReadObjectiveTaskGroup(int playerId, string objectiveIdentifier, string objectiveTaskGroupIdentifier, int targetCharacterInstanceId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectiveIdentifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectiveTaskGroupIdentifier);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadObjectiveTaskGroup_Public_Virtual_Final_New_Void_Int32_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186338, XrefRangeEnd = 186466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ClearActiveObjectives()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearActiveObjectives_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186466, XrefRangeEnd = 186476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Objective GetObjective(int playerId, string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjective_Public_Virtual_Final_New_Objective_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Objective>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186476, XrefRangeEnd = 186499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void GetCompletedObjectives(int playerId, List<Objective> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompletedObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186499, XrefRangeEnd = 186522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void GetActiveObjectives(int playerId, List<Objective> result, bool includeHidden = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeHidden;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveObjectives_Public_Virtual_Final_New_Void_Int32_List_1_Objective_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186522, XrefRangeEnd = 186537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ObjectiveTaskGroup GetNetworkedObjectiveTaskGroup(string objectiveIdentifier, string objectiveTaskGroupIdentifier, int targetCharacterInstanceId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(objectiveIdentifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(objectiveTaskGroupIdentifier);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNetworkedObjectiveTaskGroup_Public_Virtual_Final_New_ObjectiveTaskGroup_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroup>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186537, XrefRangeEnd = 186578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void CompleteNetworkedObjective(string objectiveIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(objectiveIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompleteNetworkedObjective_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186578, XrefRangeEnd = 186660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void HandlePlayerActivation(WorldPlayer worldPlayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandlePlayerActivation_Public_Virtual_Final_New_Void_WorldPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186660, XrefRangeEnd = 186804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SaveGame(GameSave gameSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameSave);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveGame_Public_Virtual_Final_New_Void_GameSave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186804, XrefRangeEnd = 186834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LoadGame(GameSave gameSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameSave);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadGame_Public_Virtual_Final_New_Void_GameSave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186834, XrefRangeEnd = 186839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddNetworkedObjective(Objective objective)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objective);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNetworkedObjective_Public_Virtual_Final_New_Void_Objective_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186839, XrefRangeEnd = 186884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void CompleteNetworkedNpcRequestObjective(int targetCharacterInstanceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetCharacterInstanceId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompleteNetworkedNpcRequestObjective_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186884, XrefRangeEnd = 186892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddNetworkedObjectiveTaskGroup(string objectiveIdentifier, ObjectiveTaskGroup objectiveTaskGroup, int targetCharacterInstanceId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(objectiveIdentifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroup);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCharacterInstanceId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNetworkedObjectiveTaskGroup_Public_Virtual_Final_New_Void_String_ObjectiveTaskGroup_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186892, XrefRangeEnd = 186927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddCompletedHintIdentifiers(HashSet<string> identifiers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCompletedHintIdentifiers_Public_Virtual_Final_New_Void_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 187025, RefRangeEnd = 187028, XrefRangeStart = 186927, XrefRangeEnd = 187025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initializeTask(IObjectiveTask task)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initializeTask_Private_Void_IObjectiveTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187028, XrefRangeEnd = 187029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IObjectiveTaskCondition getTaskCondition(ObjectiveTaskConditionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTaskCondition_Private_IObjectiveTaskCondition_ObjectiveTaskConditionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IObjectiveTaskCondition>(intPtr) : null;
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectiveManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectiveManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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

	public virtual Objective AssignNpcRequestObjective(WorldPlayer worldPlayer, int targetCharacterInstanceId, params ObjectiveTaskGroup[] objectiveTaskGroups)
	{
		return AssignNpcRequestObjective(worldPlayer, targetCharacterInstanceId, new Il2CppReferenceArray<ObjectiveTaskGroup>(objectiveTaskGroups));
	}

	public virtual Hint CreateInputActionHint(string identifier, float hideDuration, params InputAction[] triggerActions)
	{
		return CreateInputActionHint(identifier, hideDuration, new Il2CppStructArray<InputAction>(triggerActions));
	}

	public virtual Hint CreateInputActionHint(string identifier, float hideDuration, bool requiresMouseMovement, params InputAction[] triggerActions)
	{
		return CreateInputActionHint(identifier, hideDuration, requiresMouseMovement, new Il2CppStructArray<InputAction>(triggerActions));
	}

	public ObjectiveManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class LocalPlayer : Il2CppSystem.Object
{
	[ObfuscatedName("LocalPlayer+<>c__DisplayClass193_0")]
	public sealed class __c__DisplayClass193_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_world;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__InterpolateNames_b__0_Internal_String_Match_0;

		public unsafe World world
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
			}
		}

		static __c__DisplayClass193_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass193_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<>c__DisplayClass193_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass193_0>.NativeClassPtr);
			NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass193_0>.NativeClassPtr, "world");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass193_0>.NativeClassPtr, 100678951);
			NativeMethodInfoPtr__InterpolateNames_b__0_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass193_0>.NativeClassPtr, 100678952);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass193_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass193_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228377, XrefRangeEnd = 228387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _InterpolateNames_b__0(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InterpolateNames_b__0_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		public __c__DisplayClass193_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("LocalPlayer+<>c__DisplayClass195_0")]
	public sealed class __c__DisplayClass195_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_append;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_prepend;

		private static readonly System.IntPtr NativeFieldInfoPtr_shortVersion;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__InterpolateInputs_b__0_Internal_String_Match_0;

		public unsafe string append
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_append);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_append)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe LocalPlayer __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalPlayer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)localPlayer));
			}
		}

		public unsafe string prepend
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prepend);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prepend)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool shortVersion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortVersion);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortVersion)) = flag;
			}
		}

		static __c__DisplayClass195_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<>c__DisplayClass195_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr);
			NativeFieldInfoPtr_append = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr, "append");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_prepend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr, "prepend");
			NativeFieldInfoPtr_shortVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr, "shortVersion");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr, 100678953);
			NativeMethodInfoPtr__InterpolateInputs_b__0_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr, 100678954);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass195_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass195_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228387, XrefRangeEnd = 228414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _InterpolateInputs_b__0(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InterpolateInputs_b__0_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		public __c__DisplayClass195_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_keyInterpolationRegex;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameInterpolationRegex;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerId;

	private static readonly System.IntPtr NativeFieldInfoPtr_userId;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_cinematicControlsActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotatingCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseLockPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldCursorFocusTaken;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldPointerActionsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_highPriorityInputFocusTaken;

	private static readonly System.IntPtr NativeFieldInfoPtr_allInputEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectionDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentHints;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentInputHints;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastPickupUnequippedSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastLargeDamageTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_highlightedEntities;

	private static readonly System.IntPtr NativeFieldInfoPtr_obscureShownEntities;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearbyPlayerEntities;

	private static readonly System.IntPtr NativeFieldInfoPtr_focusedEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_focusedTerrainPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainLayerZones;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrollWheelSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputDownCallbackMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputUpCallbackMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputHeldCallbackMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_consumedKeyDowns;

	private static readonly System.IntPtr NativeFieldInfoPtr_consumedGamepadDowns;

	private static readonly System.IntPtr NativeFieldInfoPtr_pendingCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyboardMouseControls;

	private static readonly System.IntPtr NativeFieldInfoPtr_gamepadControls;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyNameInputs;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeTerrainHighlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSteamDeck;

	private static readonly System.IntPtr NativeFieldInfoPtr_gamepadGlyphs;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentGamepadType;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastInputType;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedPlayerMessagesSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedPlayerMessages;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastDequeuedMessageTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_onInputTypeChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputDevicesToConfirm;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabledDevices;

	private static readonly System.IntPtr NativeFieldInfoPtr__DraggedStack_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__DraggedStackAmount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__DraggedStackPositionValid_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MapZoomAmount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MapOffset_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CraftingListTabIndex_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CraftingListScrollAmount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__BuildMenuTabIndex_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__BuildMenuScrollAmount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__JournalTab_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__JournalCatalogueCategoryTab_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__JournalCatalogueSortType_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__JournalCatalogueSubCategoryTab_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectedActiveInjuryId;

	private static readonly System.IntPtr NativeFieldInfoPtr__AccuracyIndicatorObject_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TerrainLevelIndicatorObject_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntity_Public_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObject_Public_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSteamDeck_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAlive_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerId_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUserId_Public_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerEntity_Public_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWorldPlayer_Public_Void_WorldPlayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldPlayer_Public_WorldPlayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraObject_Public_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraObject_Public_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerCamera_Public_IPlayerCamera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseRay_Public_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHighlightedEntities_Public_HashSet_1_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObscureShownEntities_Public_HashSet_1_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearbyPlayerEntities_Public_HashSet_1_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHighlightedTerrainZones_Public_HashSet_1_TerrainLayerZone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFocusedEntity_Public_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFocusedEntity_Public_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFocusedTerrainPosition_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFocusedTerrainPosition_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWorldPointerActionsEnabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWorldPointerActionsEnabled_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWorldCursorFocusTaken_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHighPriorityInputFocusTaken_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHighPriorityInputFocusTaken_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectionDisabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSelectionDisabled_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanInteractWithWorld_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAllInputEnabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAllInputEnabled_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetControls_Public_Void_Controls_Controls_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGamepadGlyphs_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLeftMouseHeld_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLeftMouseDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLeftMouseUp_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRightMouseHeld_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRightMouseDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRightMouseUp_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAnyMouseDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAnyMouseUp_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrimaryActionHeld_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrimaryActionDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrimaryActionUp_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSecondaryActionHeld_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSecondaryActionDown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSecondaryActionUp_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInputsForAction_Private_Il2CppReferenceArray_1_ControlInput_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeInput_Public_Void_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActionDownListener_Public_Void_InputAction_InputActionCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActionDownListener_Public_Void_InputAction_InputActionCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActionUpListener_Public_Void_InputAction_InputActionCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActionUpListener_Public_Void_InputAction_InputActionCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActionHeldListener_Public_Void_InputAction_InputActionCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActionHeldListener_Public_Void_InputAction_InputActionCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddInputTypeChangedListener_Public_Void_UnityAction_1_InputType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInputTypeChangedListener_Public_Void_UnityAction_1_InputType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removePendingCallback_Private_Void_Dictionary_2_InputAction_List_1_InputActionCallback_InputAction_InputActionCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getButtonControl_Private_Boolean_InputKey_byref_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getAxisControl_Private_Boolean_InputAxis_byref_AxisControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isButtonControlPressed_Private_Boolean_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_wasButtonControlPressedThisFrame_Private_Boolean_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_wasButtonControlReleasedThisFrame_Private_Boolean_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActionHeld_Public_Boolean_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActionUp_Public_Boolean_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKeyDown_Public_Boolean_Key_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActionDown_Public_Boolean_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionAxis_Public_Single_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPointerPosition_Public_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMousePositionCenterRelative_Public_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMouseDelta_Public_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastLargeDamageTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LastLargeDamageTime_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentCursor_Public_get_CursorType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentCursor_Public_set_Void_CursorType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DraggedStack_Public_get_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DraggedStack_Public_set_Void_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DraggedStackAmount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DraggedStackAmount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DraggedStackPositionValid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DraggedStackPositionValid_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LastPickupUnequippedSlot_Public_get_InventorySlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LastPickupUnequippedSlot_Public_set_Void_InventorySlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MapZoomAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MapZoomAmount_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MapOffset_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MapOffset_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CraftingListTabIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CraftingListTabIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CraftingListScrollAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CraftingListScrollAmount_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BuildMenuTabIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BuildMenuTabIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BuildMenuScrollAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_BuildMenuScrollAmount_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_JournalTab_Public_get_JournalCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_JournalTab_Public_set_Void_JournalCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_JournalCatalogueCategoryTab_Public_get_CatalogueCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_JournalCatalogueCategoryTab_Public_set_Void_CatalogueCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_JournalCatalogueSortType_Public_get_SortType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_JournalCatalogueSortType_Public_set_Void_SortType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_JournalCatalogueSubCategoryTab_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_JournalCatalogueSubCategoryTab_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InputActionHasMapping_Public_Boolean_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGamepadType_Public_GamepadType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInputDisplay_Private_InputNameDisplay_Il2CppReferenceArray_1_ControlInput_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInputDisplay_Private_InputNameDisplay_ControlInput_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyBindLabelName_Public_InputNameDisplay_InputAction_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyNamesTextForAction_Public_String_InputAction_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InterpolateString_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InterpolateNames_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InterpolateInputs_Public_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InterpolateInputs_Public_String_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMode_Public_Void_PlayerMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMode_Public_PlayerMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlacing_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCursorDisabled_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorDisabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRotatingCamera_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIsRotatingCamera_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCinematicControlsActive_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCinematicControlsActive_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseLockedMousePosition_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsGamepadInput_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsKeyboardMouseInput_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentInputType_Public_InputType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractionEscapeInputAction_Public_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputDevicesToConfirm_Public_List_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseInputDevices_Public_Void_HashSet_1_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAddedDevice_Public_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractionOrdinality_Public_InteractionOrdinality_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHint_Public_Void_Hint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertHint_Public_Void_Hint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveHints_Public_List_1_Hint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseHint_Public_Void_Hint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearHints_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputHints_Public_HashSet_1_InputAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueuePlayerMessage_Public_Void_PlayerMessageInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DequeuePlayerMessage_Public_Boolean_byref_PlayerMessageInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AccuracyIndicatorObject_Public_set_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AccuracyIndicatorObject_Public_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TerrainLevelIndicatorObject_Public_set_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TerrainLevelIndicatorObject_Public_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveTerrainHighlight_Public_TerrainHighlight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveTerrainHighlight_Public_Void_TerrainHighlight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearActiveTerrainHighlight_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasDied_Public_Void_0;

	public unsafe static Regex keyInterpolationRegex
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_keyInterpolationRegex, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_keyInterpolationRegex, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex));
		}
	}

	public unsafe static Regex nameInterpolationRegex
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nameInterpolationRegex, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nameInterpolationRegex, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex));
		}
	}

	public unsafe int playerId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerId)) = num;
		}
	}

	public unsafe ulong userId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userId);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userId)) = num;
		}
	}

	public unsafe Entity playerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe GameObject cameraObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe WorldPlayer worldPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPlayer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldPlayer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPlayer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer));
		}
	}

	public unsafe IPlayerCamera playerCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPlayerCamera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCamera)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerCamera));
		}
	}

	public unsafe PlayerMode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(PlayerMode*)num;
		}
		set
		{
			*(PlayerMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = playerMode;
		}
	}

	public unsafe bool cursorDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorDisabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorDisabled)) = flag;
		}
	}

	public unsafe bool cinematicControlsActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cinematicControlsActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cinematicControlsActive)) = flag;
		}
	}

	public unsafe bool rotatingCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotatingCamera);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotatingCamera)) = flag;
		}
	}

	public unsafe Vector2 mouseLockPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLockPosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseLockPosition)) = vector;
		}
	}

	public unsafe bool worldCursorFocusTaken
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldCursorFocusTaken);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldCursorFocusTaken)) = flag;
		}
	}

	public unsafe bool worldPointerActionsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPointerActionsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPointerActionsEnabled)) = flag;
		}
	}

	public unsafe bool highPriorityInputFocusTaken
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highPriorityInputFocusTaken);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highPriorityInputFocusTaken)) = flag;
		}
	}

	public unsafe bool allInputEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allInputEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allInputEnabled)) = flag;
		}
	}

	public unsafe bool selectionDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectionDisabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectionDisabled)) = flag;
		}
	}

	public unsafe List<Hint> currentHints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Hint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<InputAction> currentInputHints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentInputHints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InputAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentInputHints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe InventorySlot lastPickupUnequippedSlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPickupUnequippedSlot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventorySlot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPickupUnequippedSlot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventorySlot));
		}
	}

	public unsafe float lastLargeDamageTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastLargeDamageTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastLargeDamageTime)) = num;
		}
	}

	public unsafe CursorType currentCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCursor);
			return *(CursorType*)num;
		}
		set
		{
			*(CursorType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCursor)) = cursorType;
		}
	}

	public unsafe HashSet<Entity> highlightedEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightedEntities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_highlightedEntities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<Entity> obscureShownEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obscureShownEntities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obscureShownEntities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<Entity> nearbyPlayerEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearbyPlayerEntities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearbyPlayerEntities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Entity focusedEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusedEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusedEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Vector3 focusedTerrainPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusedTerrainPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusedTerrainPosition)) = vector;
		}
	}

	public unsafe HashSet<TerrainLayerZone> terrainLayerZones
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainLayerZones);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<TerrainLayerZone>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainLayerZones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe float scrollWheelSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollWheelSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollWheelSensitivity)) = num;
		}
	}

	public unsafe Dictionary<InputAction, List<InputActionCallback>> inputDownCallbackMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputDownCallbackMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InputAction, List<InputActionCallback>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputDownCallbackMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InputAction, List<InputActionCallback>> inputUpCallbackMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputUpCallbackMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InputAction, List<InputActionCallback>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputUpCallbackMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InputAction, List<InputActionCallback>> inputHeldCallbackMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputHeldCallbackMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InputAction, List<InputActionCallback>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputHeldCallbackMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<string> consumedKeyDowns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumedKeyDowns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumedKeyDowns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<string> consumedGamepadDowns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumedGamepadDowns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumedGamepadDowns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<Il2CppSystem.ValueTuple<Dictionary<InputAction, List<InputActionCallback>>, InputAction, InputActionCallback>> pendingCallbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingCallbacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<Dictionary<InputAction, List<InputActionCallback>>, InputAction, InputActionCallback>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingCallbacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Controls keyboardMouseControls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyboardMouseControls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controls>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyboardMouseControls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controls));
		}
	}

	public unsafe Controls gamepadControls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadControls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controls>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadControls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controls));
		}
	}

	public unsafe List<string> keyNameInputs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyNameInputs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyNameInputs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe TerrainHighlight activeTerrainHighlight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeTerrainHighlight);
			return *(TerrainHighlight*)num;
		}
		set
		{
			*(TerrainHighlight*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeTerrainHighlight)) = terrainHighlight;
		}
	}

	public unsafe bool isSteamDeck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSteamDeck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSteamDeck)) = flag;
		}
	}

	public unsafe PlayerGamepadGlyphs gamepadGlyphs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadGlyphs);
			return *(PlayerGamepadGlyphs*)num;
		}
		set
		{
			*(PlayerGamepadGlyphs*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamepadGlyphs)) = playerGamepadGlyphs;
		}
	}

	public unsafe GamepadType currentGamepadType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGamepadType);
			return *(GamepadType*)num;
		}
		set
		{
			*(GamepadType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGamepadType)) = gamepadType;
		}
	}

	public unsafe InputType lastInputType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastInputType);
			return *(InputType*)num;
		}
		set
		{
			*(InputType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastInputType)) = inputType;
		}
	}

	public unsafe HashSet<string> queuedPlayerMessagesSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedPlayerMessagesSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedPlayerMessagesSet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Queue<PlayerMessageInfo> queuedPlayerMessages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedPlayerMessages);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<PlayerMessageInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedPlayerMessages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe float lastDequeuedMessageTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDequeuedMessageTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDequeuedMessageTime)) = num;
		}
	}

	public unsafe UnityEvent<InputType> onInputTypeChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onInputTypeChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent<InputType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onInputTypeChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe List<InputDevice> inputDevicesToConfirm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputDevicesToConfirm);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InputDevice>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputDevicesToConfirm)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe HashSet<string> disabledDevices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledDevices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledDevices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe InventoryItemStack _DraggedStack_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DraggedStack_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DraggedStack_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryItemStack));
		}
	}

	public unsafe int _DraggedStackAmount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DraggedStackAmount_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DraggedStackAmount_k__BackingField)) = num;
		}
	}

	public unsafe bool _DraggedStackPositionValid_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DraggedStackPositionValid_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DraggedStackPositionValid_k__BackingField)) = flag;
		}
	}

	public unsafe float _MapZoomAmount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MapZoomAmount_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MapZoomAmount_k__BackingField)) = num;
		}
	}

	public unsafe Vector2 _MapOffset_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MapOffset_k__BackingField);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MapOffset_k__BackingField)) = vector;
		}
	}

	public unsafe int _CraftingListTabIndex_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CraftingListTabIndex_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CraftingListTabIndex_k__BackingField)) = num;
		}
	}

	public unsafe float _CraftingListScrollAmount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CraftingListScrollAmount_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CraftingListScrollAmount_k__BackingField)) = num;
		}
	}

	public unsafe int _BuildMenuTabIndex_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BuildMenuTabIndex_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BuildMenuTabIndex_k__BackingField)) = num;
		}
	}

	public unsafe float _BuildMenuScrollAmount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BuildMenuScrollAmount_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BuildMenuScrollAmount_k__BackingField)) = num;
		}
	}

	public unsafe JournalCategory _JournalTab_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__JournalTab_k__BackingField);
			return *(JournalCategory*)num;
		}
		set
		{
			*(JournalCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__JournalTab_k__BackingField)) = journalCategory;
		}
	}

	public unsafe CatalogueCategory _JournalCatalogueCategoryTab_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__JournalCatalogueCategoryTab_k__BackingField);
			return *(CatalogueCategory*)num;
		}
		set
		{
			*(CatalogueCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__JournalCatalogueCategoryTab_k__BackingField)) = catalogueCategory;
		}
	}

	public unsafe SortType _JournalCatalogueSortType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__JournalCatalogueSortType_k__BackingField);
			return *(SortType*)num;
		}
		set
		{
			*(SortType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__JournalCatalogueSortType_k__BackingField)) = sortType;
		}
	}

	public unsafe string _JournalCatalogueSubCategoryTab_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__JournalCatalogueSubCategoryTab_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__JournalCatalogueSubCategoryTab_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int SelectedActiveInjuryId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedActiveInjuryId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectedActiveInjuryId)) = num;
		}
	}

	public unsafe GameObject _AccuracyIndicatorObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AccuracyIndicatorObject_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AccuracyIndicatorObject_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject _TerrainLevelIndicatorObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TerrainLevelIndicatorObject_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TerrainLevelIndicatorObject_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float LastLargeDamageTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastLargeDamageTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229529, RefRangeEnd = 229530, XrefRangeStart = 229529, XrefRangeEnd = 229529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LastLargeDamageTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe CursorType CurrentCursor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229530, RefRangeEnd = 229531, XrefRangeStart = 229530, XrefRangeEnd = 229530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentCursor_Public_get_CursorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(CursorType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentCursor_Public_set_Void_CursorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe InventoryItemStack DraggedStack
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DraggedStack_Public_get_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DraggedStack_Public_set_Void_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int DraggedStackAmount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DraggedStackAmount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DraggedStackAmount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool DraggedStackPositionValid
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DraggedStackPositionValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DraggedStackPositionValid_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe InventorySlot LastPickupUnequippedSlot
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 30821, RefRangeEnd = 30837, XrefRangeStart = 30821, XrefRangeEnd = 30837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastPickupUnequippedSlot_Public_get_InventorySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventorySlot>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LastPickupUnequippedSlot_Public_set_Void_InventorySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float MapZoomAmount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MapZoomAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MapZoomAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe Vector2 MapOffset
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MapOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MapOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int CraftingListTabIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CraftingListTabIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CraftingListTabIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float CraftingListScrollAmount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CraftingListScrollAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CraftingListScrollAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int BuildMenuTabIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BuildMenuTabIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BuildMenuTabIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float BuildMenuScrollAmount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BuildMenuScrollAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BuildMenuScrollAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe JournalCategory JournalTab
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_JournalTab_Public_get_JournalCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(JournalCategory*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_JournalTab_Public_set_Void_JournalCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe CatalogueCategory JournalCatalogueCategoryTab
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_JournalCatalogueCategoryTab_Public_get_CatalogueCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(CatalogueCategory*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_JournalCatalogueCategoryTab_Public_set_Void_CatalogueCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe SortType JournalCatalogueSortType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_JournalCatalogueSortType_Public_get_SortType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(SortType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_JournalCatalogueSortType_Public_set_Void_SortType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string JournalCatalogueSubCategoryTab
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_JournalCatalogueSubCategoryTab_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_JournalCatalogueSubCategoryTab_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool IsGamepadInput
	{
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 229772, RefRangeEnd = 229898, XrefRangeStart = 229772, XrefRangeEnd = 229772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsGamepadInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsKeyboardMouseInput
	{
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 229898, RefRangeEnd = 229933, XrefRangeStart = 229898, XrefRangeEnd = 229898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsKeyboardMouseInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe GameObject AccuracyIndicatorObject
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 167443, RefRangeEnd = 167453, XrefRangeStart = 167443, XrefRangeEnd = 167453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AccuracyIndicatorObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AccuracyIndicatorObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe GameObject TerrainLevelIndicatorObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TerrainLevelIndicatorObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TerrainLevelIndicatorObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static LocalPlayer()
	{
		Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "LocalPlayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr);
		NativeFieldInfoPtr_keyInterpolationRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "keyInterpolationRegex");
		NativeFieldInfoPtr_nameInterpolationRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "nameInterpolationRegex");
		NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "playerId");
		NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "userId");
		NativeFieldInfoPtr_playerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "playerEntity");
		NativeFieldInfoPtr_cameraObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "cameraObject");
		NativeFieldInfoPtr_worldPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "worldPlayer");
		NativeFieldInfoPtr_playerCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "playerCamera");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_cursorDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "cursorDisabled");
		NativeFieldInfoPtr_cinematicControlsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "cinematicControlsActive");
		NativeFieldInfoPtr_rotatingCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "rotatingCamera");
		NativeFieldInfoPtr_mouseLockPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "mouseLockPosition");
		NativeFieldInfoPtr_worldCursorFocusTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "worldCursorFocusTaken");
		NativeFieldInfoPtr_worldPointerActionsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "worldPointerActionsEnabled");
		NativeFieldInfoPtr_highPriorityInputFocusTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "highPriorityInputFocusTaken");
		NativeFieldInfoPtr_allInputEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "allInputEnabled");
		NativeFieldInfoPtr_selectionDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "selectionDisabled");
		NativeFieldInfoPtr_currentHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "currentHints");
		NativeFieldInfoPtr_currentInputHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "currentInputHints");
		NativeFieldInfoPtr_lastPickupUnequippedSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "lastPickupUnequippedSlot");
		NativeFieldInfoPtr_lastLargeDamageTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "lastLargeDamageTime");
		NativeFieldInfoPtr_currentCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "currentCursor");
		NativeFieldInfoPtr_highlightedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "highlightedEntities");
		NativeFieldInfoPtr_obscureShownEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "obscureShownEntities");
		NativeFieldInfoPtr_nearbyPlayerEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "nearbyPlayerEntities");
		NativeFieldInfoPtr_focusedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "focusedEntity");
		NativeFieldInfoPtr_focusedTerrainPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "focusedTerrainPosition");
		NativeFieldInfoPtr_terrainLayerZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "terrainLayerZones");
		NativeFieldInfoPtr_scrollWheelSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "scrollWheelSensitivity");
		NativeFieldInfoPtr_inputDownCallbackMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "inputDownCallbackMap");
		NativeFieldInfoPtr_inputUpCallbackMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "inputUpCallbackMap");
		NativeFieldInfoPtr_inputHeldCallbackMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "inputHeldCallbackMap");
		NativeFieldInfoPtr_consumedKeyDowns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "consumedKeyDowns");
		NativeFieldInfoPtr_consumedGamepadDowns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "consumedGamepadDowns");
		NativeFieldInfoPtr_pendingCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "pendingCallbacks");
		NativeFieldInfoPtr_keyboardMouseControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "keyboardMouseControls");
		NativeFieldInfoPtr_gamepadControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "gamepadControls");
		NativeFieldInfoPtr_keyNameInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "keyNameInputs");
		NativeFieldInfoPtr_activeTerrainHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "activeTerrainHighlight");
		NativeFieldInfoPtr_isSteamDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "isSteamDeck");
		NativeFieldInfoPtr_gamepadGlyphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "gamepadGlyphs");
		NativeFieldInfoPtr_currentGamepadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "currentGamepadType");
		NativeFieldInfoPtr_lastInputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "lastInputType");
		NativeFieldInfoPtr_queuedPlayerMessagesSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "queuedPlayerMessagesSet");
		NativeFieldInfoPtr_queuedPlayerMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "queuedPlayerMessages");
		NativeFieldInfoPtr_lastDequeuedMessageTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "lastDequeuedMessageTime");
		NativeFieldInfoPtr_onInputTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "onInputTypeChanged");
		NativeFieldInfoPtr_inputDevicesToConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "inputDevicesToConfirm");
		NativeFieldInfoPtr_disabledDevices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "disabledDevices");
		NativeFieldInfoPtr__DraggedStack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<DraggedStack>k__BackingField");
		NativeFieldInfoPtr__DraggedStackAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<DraggedStackAmount>k__BackingField");
		NativeFieldInfoPtr__DraggedStackPositionValid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<DraggedStackPositionValid>k__BackingField");
		NativeFieldInfoPtr__MapZoomAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<MapZoomAmount>k__BackingField");
		NativeFieldInfoPtr__MapOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<MapOffset>k__BackingField");
		NativeFieldInfoPtr__CraftingListTabIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<CraftingListTabIndex>k__BackingField");
		NativeFieldInfoPtr__CraftingListScrollAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<CraftingListScrollAmount>k__BackingField");
		NativeFieldInfoPtr__BuildMenuTabIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<BuildMenuTabIndex>k__BackingField");
		NativeFieldInfoPtr__BuildMenuScrollAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<BuildMenuScrollAmount>k__BackingField");
		NativeFieldInfoPtr__JournalTab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<JournalTab>k__BackingField");
		NativeFieldInfoPtr__JournalCatalogueCategoryTab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<JournalCatalogueCategoryTab>k__BackingField");
		NativeFieldInfoPtr__JournalCatalogueSortType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<JournalCatalogueSortType>k__BackingField");
		NativeFieldInfoPtr__JournalCatalogueSubCategoryTab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<JournalCatalogueSubCategoryTab>k__BackingField");
		NativeFieldInfoPtr_SelectedActiveInjuryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "SelectedActiveInjuryId");
		NativeFieldInfoPtr__AccuracyIndicatorObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<AccuracyIndicatorObject>k__BackingField");
		NativeFieldInfoPtr__TerrainLevelIndicatorObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, "<TerrainLevelIndicatorObject>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678800);
		NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678801);
		NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678802);
		NativeMethodInfoPtr_GetEntity_Public_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678803);
		NativeMethodInfoPtr_GetGameObject_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678804);
		NativeMethodInfoPtr_SetSteamDeck_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678805);
		NativeMethodInfoPtr_IsAlive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678806);
		NativeMethodInfoPtr_GetPlayerId_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678807);
		NativeMethodInfoPtr_GetUserId_Public_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678808);
		NativeMethodInfoPtr_SetPlayerEntity_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678809);
		NativeMethodInfoPtr_SetWorldPlayer_Public_Void_WorldPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678810);
		NativeMethodInfoPtr_GetWorldPlayer_Public_WorldPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678811);
		NativeMethodInfoPtr_SetCameraObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678812);
		NativeMethodInfoPtr_GetCameraObject_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678813);
		NativeMethodInfoPtr_GetPlayerCamera_Public_IPlayerCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678814);
		NativeMethodInfoPtr_GetMouseRay_Public_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678815);
		NativeMethodInfoPtr_GetHighlightedEntities_Public_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678816);
		NativeMethodInfoPtr_GetObscureShownEntities_Public_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678817);
		NativeMethodInfoPtr_GetNearbyPlayerEntities_Public_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678818);
		NativeMethodInfoPtr_GetHighlightedTerrainZones_Public_HashSet_1_TerrainLayerZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678819);
		NativeMethodInfoPtr_GetFocusedEntity_Public_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678820);
		NativeMethodInfoPtr_SetFocusedEntity_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678821);
		NativeMethodInfoPtr_SetFocusedTerrainPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678822);
		NativeMethodInfoPtr_GetFocusedTerrainPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678823);
		NativeMethodInfoPtr_SetWorldPointerActionsEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678824);
		NativeMethodInfoPtr_IsWorldPointerActionsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678825);
		NativeMethodInfoPtr_SetWorldCursorFocusTaken_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678826);
		NativeMethodInfoPtr_SetHighPriorityInputFocusTaken_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678827);
		NativeMethodInfoPtr_IsHighPriorityInputFocusTaken_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678828);
		NativeMethodInfoPtr_SetSelectionDisabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678829);
		NativeMethodInfoPtr_IsSelectionDisabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678830);
		NativeMethodInfoPtr_CanInteractWithWorld_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678831);
		NativeMethodInfoPtr_SetAllInputEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678832);
		NativeMethodInfoPtr_IsAllInputEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678833);
		NativeMethodInfoPtr_SetControls_Public_Void_Controls_Controls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678834);
		NativeMethodInfoPtr_SetGamepadGlyphs_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678835);
		NativeMethodInfoPtr_IsLeftMouseHeld_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678836);
		NativeMethodInfoPtr_IsLeftMouseDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678837);
		NativeMethodInfoPtr_IsLeftMouseUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678838);
		NativeMethodInfoPtr_IsRightMouseHeld_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678839);
		NativeMethodInfoPtr_IsRightMouseDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678840);
		NativeMethodInfoPtr_IsRightMouseUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678841);
		NativeMethodInfoPtr_IsAnyMouseDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678842);
		NativeMethodInfoPtr_IsAnyMouseUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678843);
		NativeMethodInfoPtr_IsPrimaryActionHeld_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678844);
		NativeMethodInfoPtr_IsPrimaryActionDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678845);
		NativeMethodInfoPtr_IsPrimaryActionUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678846);
		NativeMethodInfoPtr_IsSecondaryActionHeld_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678847);
		NativeMethodInfoPtr_IsSecondaryActionDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678848);
		NativeMethodInfoPtr_IsSecondaryActionUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678849);
		NativeMethodInfoPtr_getInputsForAction_Private_Il2CppReferenceArray_1_ControlInput_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678850);
		NativeMethodInfoPtr_ConsumeInput_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678851);
		NativeMethodInfoPtr_AddActionDownListener_Public_Void_InputAction_InputActionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678852);
		NativeMethodInfoPtr_RemoveActionDownListener_Public_Void_InputAction_InputActionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678853);
		NativeMethodInfoPtr_AddActionUpListener_Public_Void_InputAction_InputActionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678854);
		NativeMethodInfoPtr_RemoveActionUpListener_Public_Void_InputAction_InputActionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678855);
		NativeMethodInfoPtr_AddActionHeldListener_Public_Void_InputAction_InputActionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678856);
		NativeMethodInfoPtr_RemoveActionHeldListener_Public_Void_InputAction_InputActionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678857);
		NativeMethodInfoPtr_AddInputTypeChangedListener_Public_Void_UnityAction_1_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678858);
		NativeMethodInfoPtr_RemoveInputTypeChangedListener_Public_Void_UnityAction_1_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678859);
		NativeMethodInfoPtr_removePendingCallback_Private_Void_Dictionary_2_InputAction_List_1_InputActionCallback_InputAction_InputActionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678860);
		NativeMethodInfoPtr_getButtonControl_Private_Boolean_InputKey_byref_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678861);
		NativeMethodInfoPtr_getAxisControl_Private_Boolean_InputAxis_byref_AxisControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678862);
		NativeMethodInfoPtr_isButtonControlPressed_Private_Boolean_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678863);
		NativeMethodInfoPtr_wasButtonControlPressedThisFrame_Private_Boolean_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678864);
		NativeMethodInfoPtr_wasButtonControlReleasedThisFrame_Private_Boolean_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678865);
		NativeMethodInfoPtr_IsActionHeld_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678866);
		NativeMethodInfoPtr_IsActionUp_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678867);
		NativeMethodInfoPtr_IsKeyDown_Public_Boolean_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678868);
		NativeMethodInfoPtr_IsActionDown_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678869);
		NativeMethodInfoPtr_GetActionAxis_Public_Single_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678870);
		NativeMethodInfoPtr_GetPointerPosition_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678871);
		NativeMethodInfoPtr_GetMousePositionCenterRelative_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678872);
		NativeMethodInfoPtr_GetMouseDelta_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678873);
		NativeMethodInfoPtr_get_LastLargeDamageTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678874);
		NativeMethodInfoPtr_set_LastLargeDamageTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678875);
		NativeMethodInfoPtr_get_CurrentCursor_Public_get_CursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678876);
		NativeMethodInfoPtr_set_CurrentCursor_Public_set_Void_CursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678877);
		NativeMethodInfoPtr_get_DraggedStack_Public_get_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678878);
		NativeMethodInfoPtr_set_DraggedStack_Public_set_Void_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678879);
		NativeMethodInfoPtr_get_DraggedStackAmount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678880);
		NativeMethodInfoPtr_set_DraggedStackAmount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678881);
		NativeMethodInfoPtr_get_DraggedStackPositionValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678882);
		NativeMethodInfoPtr_set_DraggedStackPositionValid_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678883);
		NativeMethodInfoPtr_get_LastPickupUnequippedSlot_Public_get_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678884);
		NativeMethodInfoPtr_set_LastPickupUnequippedSlot_Public_set_Void_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678885);
		NativeMethodInfoPtr_get_MapZoomAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678886);
		NativeMethodInfoPtr_set_MapZoomAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678887);
		NativeMethodInfoPtr_get_MapOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678888);
		NativeMethodInfoPtr_set_MapOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678889);
		NativeMethodInfoPtr_get_CraftingListTabIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678890);
		NativeMethodInfoPtr_set_CraftingListTabIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678891);
		NativeMethodInfoPtr_get_CraftingListScrollAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678892);
		NativeMethodInfoPtr_set_CraftingListScrollAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678893);
		NativeMethodInfoPtr_get_BuildMenuTabIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678894);
		NativeMethodInfoPtr_set_BuildMenuTabIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678895);
		NativeMethodInfoPtr_get_BuildMenuScrollAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678896);
		NativeMethodInfoPtr_set_BuildMenuScrollAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678897);
		NativeMethodInfoPtr_get_JournalTab_Public_get_JournalCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678898);
		NativeMethodInfoPtr_set_JournalTab_Public_set_Void_JournalCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678899);
		NativeMethodInfoPtr_get_JournalCatalogueCategoryTab_Public_get_CatalogueCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678900);
		NativeMethodInfoPtr_set_JournalCatalogueCategoryTab_Public_set_Void_CatalogueCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678901);
		NativeMethodInfoPtr_get_JournalCatalogueSortType_Public_get_SortType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678902);
		NativeMethodInfoPtr_set_JournalCatalogueSortType_Public_set_Void_SortType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678903);
		NativeMethodInfoPtr_get_JournalCatalogueSubCategoryTab_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678904);
		NativeMethodInfoPtr_set_JournalCatalogueSubCategoryTab_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678905);
		NativeMethodInfoPtr_InputActionHasMapping_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678906);
		NativeMethodInfoPtr_GetGamepadType_Public_GamepadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678907);
		NativeMethodInfoPtr_getInputDisplay_Private_InputNameDisplay_Il2CppReferenceArray_1_ControlInput_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678908);
		NativeMethodInfoPtr_getInputDisplay_Private_InputNameDisplay_ControlInput_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678909);
		NativeMethodInfoPtr_GetKeyBindLabelName_Public_InputNameDisplay_InputAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678910);
		NativeMethodInfoPtr_GetKeyNamesTextForAction_Public_String_InputAction_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678911);
		NativeMethodInfoPtr_InterpolateString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678912);
		NativeMethodInfoPtr_InterpolateNames_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678913);
		NativeMethodInfoPtr_InterpolateInputs_Public_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678914);
		NativeMethodInfoPtr_InterpolateInputs_Public_String_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678915);
		NativeMethodInfoPtr_SetMode_Public_Void_PlayerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678916);
		NativeMethodInfoPtr_GetMode_Public_PlayerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678917);
		NativeMethodInfoPtr_IsPlacing_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678918);
		NativeMethodInfoPtr_IsCursorDisabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678919);
		NativeMethodInfoPtr_SetCursorDisabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678920);
		NativeMethodInfoPtr_IsRotatingCamera_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678921);
		NativeMethodInfoPtr_SetIsRotatingCamera_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678922);
		NativeMethodInfoPtr_IsCinematicControlsActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678923);
		NativeMethodInfoPtr_SetCinematicControlsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678924);
		NativeMethodInfoPtr_UseLockedMousePosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678925);
		NativeMethodInfoPtr_get_IsGamepadInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678926);
		NativeMethodInfoPtr_get_IsKeyboardMouseInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678927);
		NativeMethodInfoPtr_GetCurrentInputType_Public_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678928);
		NativeMethodInfoPtr_GetInteractionEscapeInputAction_Public_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678929);
		NativeMethodInfoPtr_GetInputDevicesToConfirm_Public_List_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678930);
		NativeMethodInfoPtr_UseInputDevices_Public_Void_HashSet_1_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678931);
		NativeMethodInfoPtr_CheckAddedDevice_Public_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678932);
		NativeMethodInfoPtr_GetInteractionOrdinality_Public_InteractionOrdinality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678933);
		NativeMethodInfoPtr_AddHint_Public_Void_Hint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678934);
		NativeMethodInfoPtr_InsertHint_Public_Void_Hint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678935);
		NativeMethodInfoPtr_GetActiveHints_Public_List_1_Hint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678936);
		NativeMethodInfoPtr_CloseHint_Public_Void_Hint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678937);
		NativeMethodInfoPtr_ClearHints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678938);
		NativeMethodInfoPtr_GetInputHints_Public_HashSet_1_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678939);
		NativeMethodInfoPtr_QueuePlayerMessage_Public_Void_PlayerMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678940);
		NativeMethodInfoPtr_DequeuePlayerMessage_Public_Boolean_byref_PlayerMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678941);
		NativeMethodInfoPtr_set_AccuracyIndicatorObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678942);
		NativeMethodInfoPtr_get_AccuracyIndicatorObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678943);
		NativeMethodInfoPtr_set_TerrainLevelIndicatorObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678944);
		NativeMethodInfoPtr_get_TerrainLevelIndicatorObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678945);
		NativeMethodInfoPtr_GetActiveTerrainHighlight_Public_TerrainHighlight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678946);
		NativeMethodInfoPtr_SetActiveTerrainHighlight_Public_Void_TerrainHighlight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678947);
		NativeMethodInfoPtr_ClearActiveTerrainHighlight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678948);
		NativeMethodInfoPtr_HasDied_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr, 100678949);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228593, RefRangeEnd = 228594, XrefRangeStart = 228414, XrefRangeEnd = 228593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalPlayer(ulong userId)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&userId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228800, RefRangeEnd = 228801, XrefRangeStart = 228594, XrefRangeEnd = 228800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228807, RefRangeEnd = 228808, XrefRangeStart = 228801, XrefRangeEnd = 228807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18747, RefRangeEnd = 18748, XrefRangeStart = 18747, XrefRangeEnd = 18748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Entity GetEntity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntity_Public_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 228808, RefRangeEnd = 228842, XrefRangeStart = 228808, XrefRangeEnd = 228808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetGameObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGameObject_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void SetSteamDeck(bool isSteamDeck)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isSteamDeck);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSteamDeck_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 228844, RefRangeEnd = 228852, XrefRangeStart = 228842, XrefRangeEnd = 228844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAlive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAlive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetPlayerId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerId_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ulong GetUserId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUserId_Public_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 228859, RefRangeEnd = 228862, XrefRangeStart = 228852, XrefRangeEnd = 228859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerEntity(Entity playerEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerEntity_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWorldPlayer(WorldPlayer worldPlayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWorldPlayer_Public_Void_WorldPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 19179, RefRangeEnd = 19194, XrefRangeStart = 19179, XrefRangeEnd = 19194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldPlayer GetWorldPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldPlayer_Public_WorldPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldPlayer>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228873, RefRangeEnd = 228874, XrefRangeStart = 228862, XrefRangeEnd = 228873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCameraObject(GameObject cameraObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 19167, RefRangeEnd = 19170, XrefRangeStart = 19167, XrefRangeEnd = 19170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetCameraObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraObject_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 977, RefRangeEnd = 983, XrefRangeStart = 977, XrefRangeEnd = 983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IPlayerCamera GetPlayerCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPlayerCamera_Public_IPlayerCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPlayerCamera>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 228879, RefRangeEnd = 228891, XrefRangeStart = 228874, XrefRangeEnd = 228879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Ray GetMouseRay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseRay_Public_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Ray*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe HashSet<Entity> GetHighlightedEntities()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHighlightedEntities_Public_HashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe HashSet<Entity> GetObscureShownEntities()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObscureShownEntities_Public_HashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe HashSet<Entity> GetNearbyPlayerEntities()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearbyPlayerEntities_Public_HashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe HashSet<TerrainLayerZone> GetHighlightedTerrainZones()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHighlightedTerrainZones_Public_HashSet_1_TerrainLayerZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<TerrainLayerZone>>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 96529, RefRangeEnd = 96536, XrefRangeStart = 96529, XrefRangeEnd = 96536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Entity GetFocusedEntity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFocusedEntity_Public_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228892, RefRangeEnd = 228894, XrefRangeStart = 228891, XrefRangeEnd = 228892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFocusedEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFocusedEntity_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetFocusedTerrainPosition(Vector3 terrainPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&terrainPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFocusedTerrainPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Vector3 GetFocusedTerrainPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFocusedTerrainPosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetWorldPointerActionsEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWorldPointerActionsEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsWorldPointerActionsEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWorldPointerActionsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetWorldCursorFocusTaken(bool focusTaken)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&focusTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWorldCursorFocusTaken_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetHighPriorityInputFocusTaken(bool focusTaken)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&focusTaken);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHighPriorityInputFocusTaken_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsHighPriorityInputFocusTaken()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHighPriorityInputFocusTaken_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetSelectionDisabled(bool disabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectionDisabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsSelectionDisabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSelectionDisabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 228897, RefRangeEnd = 228919, XrefRangeStart = 228894, XrefRangeEnd = 228897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanInteractWithWorld()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanInteractWithWorld_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetAllInputEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAllInputEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsAllInputEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAllInputEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228921, RefRangeEnd = 228922, XrefRangeStart = 228919, XrefRangeEnd = 228921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetControls(Controls keyboardMouseControls, Controls gamepadControls)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyboardMouseControls);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gamepadControls);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetControls_Public_Void_Controls_Controls_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228922, RefRangeEnd = 228924, XrefRangeStart = 228922, XrefRangeEnd = 228922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGamepadGlyphs(int gamepadGlyphs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gamepadGlyphs);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGamepadGlyphs_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228926, RefRangeEnd = 228927, XrefRangeStart = 228924, XrefRangeEnd = 228926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsLeftMouseHeld()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLeftMouseHeld_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228927, XrefRangeEnd = 228929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsLeftMouseDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLeftMouseDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228931, RefRangeEnd = 228932, XrefRangeStart = 228929, XrefRangeEnd = 228931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsLeftMouseUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLeftMouseUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228932, XrefRangeEnd = 228934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRightMouseHeld()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRightMouseHeld_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228934, XrefRangeEnd = 228936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRightMouseDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRightMouseDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228936, XrefRangeEnd = 228938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRightMouseUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRightMouseUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228943, RefRangeEnd = 228945, XrefRangeStart = 228938, XrefRangeEnd = 228943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAnyMouseDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAnyMouseDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228950, RefRangeEnd = 228951, XrefRangeStart = 228945, XrefRangeEnd = 228950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAnyMouseUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAnyMouseUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 228952, RefRangeEnd = 228957, XrefRangeStart = 228951, XrefRangeEnd = 228952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPrimaryActionHeld()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrimaryActionHeld_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228958, RefRangeEnd = 228962, XrefRangeStart = 228957, XrefRangeEnd = 228958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPrimaryActionDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrimaryActionDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228963, RefRangeEnd = 228967, XrefRangeStart = 228962, XrefRangeEnd = 228963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPrimaryActionUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrimaryActionUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228968, RefRangeEnd = 228970, XrefRangeStart = 228967, XrefRangeEnd = 228968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSecondaryActionHeld()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSecondaryActionHeld_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228971, RefRangeEnd = 228973, XrefRangeStart = 228970, XrefRangeEnd = 228971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSecondaryActionDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSecondaryActionDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 228974, RefRangeEnd = 228977, XrefRangeStart = 228973, XrefRangeEnd = 228974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSecondaryActionUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSecondaryActionUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228977, XrefRangeEnd = 228979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<ControlInput> getInputsForAction(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInputsForAction_Private_Il2CppReferenceArray_1_ControlInput_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControlInput>>(intPtr) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 228988, RefRangeEnd = 228999, XrefRangeStart = 228979, XrefRangeEnd = 228988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConsumeInput(InputAction inputAction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputAction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConsumeInput_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 229016, RefRangeEnd = 229064, XrefRangeStart = 228999, XrefRangeEnd = 229016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddActionDownListener(InputAction action, InputActionCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionDownListener_Public_Void_InputAction_InputActionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 229071, RefRangeEnd = 229120, XrefRangeStart = 229064, XrefRangeEnd = 229071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveActionDownListener(InputAction action, InputActionCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveActionDownListener_Public_Void_InputAction_InputActionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229137, RefRangeEnd = 229138, XrefRangeStart = 229120, XrefRangeEnd = 229137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddActionUpListener(InputAction action, InputActionCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionUpListener_Public_Void_InputAction_InputActionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229145, RefRangeEnd = 229146, XrefRangeStart = 229138, XrefRangeEnd = 229145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveActionUpListener(InputAction action, InputActionCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveActionUpListener_Public_Void_InputAction_InputActionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229146, XrefRangeEnd = 229163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddActionHeldListener(InputAction action, InputActionCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActionHeldListener_Public_Void_InputAction_InputActionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229163, XrefRangeEnd = 229170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveActionHeldListener(InputAction action, InputActionCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveActionHeldListener_Public_Void_InputAction_InputActionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229174, RefRangeEnd = 229175, XrefRangeStart = 229170, XrefRangeEnd = 229174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddInputTypeChangedListener(UnityAction<InputType> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddInputTypeChangedListener_Public_Void_UnityAction_1_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229179, RefRangeEnd = 229180, XrefRangeStart = 229175, XrefRangeEnd = 229179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveInputTypeChangedListener(UnityAction<InputType> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveInputTypeChangedListener_Public_Void_UnityAction_1_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 229200, RefRangeEnd = 229203, XrefRangeStart = 229180, XrefRangeEnd = 229200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removePendingCallback(Dictionary<InputAction, List<InputActionCallback>> dictionary, InputAction action, InputActionCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		*(InputAction**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &action;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removePendingCallback_Private_Void_Dictionary_2_InputAction_List_1_InputActionCallback_InputAction_InputActionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229210, RefRangeEnd = 229211, XrefRangeStart = 229203, XrefRangeEnd = 229210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool getButtonControl(InputKey inputKey, out ButtonControl buttonControl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputKey);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getButtonControl_Private_Boolean_InputKey_byref_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		buttonControl = ((num3 == 0) ? null : new ButtonControl(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 229218, RefRangeEnd = 229220, XrefRangeStart = 229211, XrefRangeEnd = 229218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool getAxisControl(InputAxis inputAxis, out AxisControl axisControl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputAxis);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getAxisControl_Private_Boolean_InputAxis_byref_AxisControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		axisControl = ((num3 == 0) ? null : new AxisControl(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229220, XrefRangeEnd = 229222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isButtonControlPressed(ButtonControl buttonControl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buttonControl);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isButtonControlPressed_Private_Boolean_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229222, XrefRangeEnd = 229224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool wasButtonControlPressedThisFrame(ButtonControl buttonControl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buttonControl);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_wasButtonControlPressedThisFrame_Private_Boolean_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229224, XrefRangeEnd = 229226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool wasButtonControlReleasedThisFrame(ButtonControl buttonControl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buttonControl);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_wasButtonControlReleasedThisFrame_Private_Boolean_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 229246, RefRangeEnd = 229293, XrefRangeStart = 229226, XrefRangeEnd = 229246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsActionHeld(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActionHeld_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 229311, RefRangeEnd = 229320, XrefRangeStart = 229293, XrefRangeEnd = 229311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsActionUp(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActionUp_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 229322, RefRangeEnd = 229336, XrefRangeStart = 229320, XrefRangeEnd = 229322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsKeyDown(Key key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKeyDown_Public_Boolean_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(56)]
	[CachedScanResults(RefRangeStart = 229354, RefRangeEnd = 229410, XrefRangeStart = 229336, XrefRangeEnd = 229354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsActionDown(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActionDown_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 229452, RefRangeEnd = 229484, XrefRangeStart = 229410, XrefRangeEnd = 229452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetActionAxis(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionAxis_Public_Single_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 229489, RefRangeEnd = 229506, XrefRangeStart = 229484, XrefRangeEnd = 229489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetPointerPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPointerPosition_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229506, XrefRangeEnd = 229517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetMousePositionCenterRelative()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMousePositionCenterRelative_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 229524, RefRangeEnd = 229529, XrefRangeStart = 229517, XrefRangeEnd = 229524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetMouseDelta()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMouseDelta_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 229533, RefRangeEnd = 229535, XrefRangeStart = 229531, XrefRangeEnd = 229533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InputActionHasMapping(InputAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InputActionHasMapping_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe GamepadType GetGamepadType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGamepadType_Public_GamepadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(GamepadType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229561, RefRangeEnd = 229562, XrefRangeStart = 229535, XrefRangeEnd = 229561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputNameDisplay getInputDisplay(Il2CppReferenceArray<ControlInput> inputs, bool shortVersion, bool allowNoMapping)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputs);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortVersion;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowNoMapping;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInputDisplay_Private_InputNameDisplay_Il2CppReferenceArray_1_ControlInput_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputNameDisplay(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229563, RefRangeEnd = 229564, XrefRangeStart = 229562, XrefRangeEnd = 229563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputNameDisplay getInputDisplay(ControlInput input, bool shortVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortVersion;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInputDisplay_Private_InputNameDisplay_ControlInput_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputNameDisplay(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 229567, RefRangeEnd = 229569, XrefRangeStart = 229564, XrefRangeEnd = 229567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputNameDisplay GetKeyBindLabelName(InputAction action, bool allowNoMapping)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowNoMapping;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyBindLabelName_Public_InputNameDisplay_InputAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InputNameDisplay(pointer);
	}

	[CallerCount(41)]
	[CachedScanResults(RefRangeStart = 229629, RefRangeEnd = 229670, XrefRangeStart = 229569, XrefRangeEnd = 229629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetKeyNamesTextForAction(InputAction action, string prepend = "", string append = "", bool shortVersion = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prepend);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(append);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortVersion;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyNamesTextForAction_Public_String_InputAction_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229670, XrefRangeEnd = 229692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string InterpolateString(string content)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InterpolateString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 229709, RefRangeEnd = 229711, XrefRangeStart = 229692, XrefRangeEnd = 229709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string InterpolateNames(string content)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InterpolateNames_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 229714, RefRangeEnd = 229722, XrefRangeStart = 229711, XrefRangeEnd = 229714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string InterpolateInputs(string content, bool shortVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortVersion;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InterpolateInputs_Public_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 229740, RefRangeEnd = 229753, XrefRangeStart = 229722, XrefRangeEnd = 229740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string InterpolateInputs(string content, string prepend = "", string append = "", bool shortVersion = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prepend);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(append);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &shortVersion;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InterpolateInputs_Public_String_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetMode(PlayerMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMode_Public_Void_PlayerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe PlayerMode GetMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMode_Public_PlayerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(PlayerMode*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 229753, RefRangeEnd = 229762, XrefRangeStart = 229753, XrefRangeEnd = 229753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPlacing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlacing_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsCursorDisabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCursorDisabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229763, RefRangeEnd = 229764, XrefRangeStart = 229762, XrefRangeEnd = 229763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCursorDisabled(bool disabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorDisabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsRotatingCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRotatingCamera_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229766, RefRangeEnd = 229767, XrefRangeStart = 229764, XrefRangeEnd = 229766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsRotatingCamera(bool rotating)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rotating);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIsRotatingCamera_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsCinematicControlsActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCinematicControlsActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetCinematicControlsActive(bool active)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&active);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCinematicControlsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229771, RefRangeEnd = 229772, XrefRangeStart = 229767, XrefRangeEnd = 229771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseLockedMousePosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseLockedMousePosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe InputType GetCurrentInputType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentInputType_Public_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InputType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229933, RefRangeEnd = 229934, XrefRangeStart = 229933, XrefRangeEnd = 229933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputAction GetInteractionEscapeInputAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInteractionEscapeInputAction_Public_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InputAction*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe List<InputDevice> GetInputDevicesToConfirm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputDevicesToConfirm_Public_List_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InputDevice>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229958, RefRangeEnd = 229959, XrefRangeStart = 229934, XrefRangeEnd = 229958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseInputDevices(HashSet<InputDevice> inputDevicesToUse)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputDevicesToUse);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseInputDevices_Public_Void_HashSet_1_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229974, RefRangeEnd = 229975, XrefRangeStart = 229959, XrefRangeEnd = 229974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAddedDevice(InputDevice device)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckAddedDevice_Public_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 229977, RefRangeEnd = 229987, XrefRangeStart = 229975, XrefRangeEnd = 229977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractionOrdinality GetInteractionOrdinality()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInteractionOrdinality_Public_InteractionOrdinality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionOrdinality*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229991, RefRangeEnd = 229992, XrefRangeStart = 229987, XrefRangeEnd = 229991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddHint(Hint hint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddHint_Public_Void_Hint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 229999, RefRangeEnd = 230001, XrefRangeStart = 229992, XrefRangeEnd = 229999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertHint(Hint hint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertHint_Public_Void_Hint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe List<Hint> GetActiveHints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveHints_Public_List_1_Hint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Hint>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 230005, RefRangeEnd = 230008, XrefRangeStart = 230001, XrefRangeEnd = 230005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseHint(Hint hint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseHint_Public_Void_Hint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230010, RefRangeEnd = 230011, XrefRangeStart = 230008, XrefRangeEnd = 230010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearHints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearHints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 96676, RefRangeEnd = 96716, XrefRangeStart = 96676, XrefRangeEnd = 96716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<InputAction> GetInputHints()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputHints_Public_HashSet_1_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InputAction>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230017, RefRangeEnd = 230018, XrefRangeStart = 230011, XrefRangeEnd = 230017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueuePlayerMessage(PlayerMessageInfo playerMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)playerMessage));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueuePlayerMessage_Public_Void_PlayerMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 230026, RefRangeEnd = 230028, XrefRangeStart = 230018, XrefRangeEnd = 230026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DequeuePlayerMessage(out PlayerMessageInfo playerMessageInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DequeuePlayerMessage_Public_Boolean_byref_PlayerMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num2 = num;
		playerMessageInfo = ((num2 == 0) ? null : new PlayerMessageInfo(num2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe TerrainHighlight GetActiveTerrainHighlight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveTerrainHighlight_Public_TerrainHighlight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TerrainHighlight*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetActiveTerrainHighlight(TerrainHighlight terrainHighlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&terrainHighlight);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveTerrainHighlight_Public_Void_TerrainHighlight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230030, RefRangeEnd = 230031, XrefRangeStart = 230028, XrefRangeEnd = 230030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearActiveTerrainHighlight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearActiveTerrainHighlight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230042, RefRangeEnd = 230043, XrefRangeStart = 230031, XrefRangeEnd = 230042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HasDied()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasDied_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LocalPlayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

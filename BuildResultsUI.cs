using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class BuildResultsUI : UIComponent
{
	public sealed class CategorySetup : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_header;

		private static readonly System.IntPtr NativeFieldInfoPtr_text;

		private static readonly System.IntPtr NativeFieldInfoPtr_category;

		private static readonly System.IntPtr NativeFieldInfoPtr_pieceType;

		public unsafe bool header
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_header);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_header)) = flag;
			}
		}

		public unsafe string text
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe BuildingCategory category
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category);
				return *(BuildingCategory*)num;
			}
			set
			{
				*(BuildingCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category)) = buildingCategory;
			}
		}

		public unsafe BuildingPieceType pieceType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieceType);
				return *(BuildingPieceType*)num;
			}
			set
			{
				*(BuildingPieceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieceType)) = buildingPieceType;
			}
		}

		static CategorySetup()
		{
			Il2CppClassPointerStore<CategorySetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "CategorySetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CategorySetup>.NativeClassPtr);
			NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategorySetup>.NativeClassPtr, "header");
			NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategorySetup>.NativeClassPtr, "text");
			NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategorySetup>.NativeClassPtr, "category");
			NativeFieldInfoPtr_pieceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategorySetup>.NativeClassPtr, "pieceType");
		}

		public CategorySetup(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CategorySetup()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CategorySetup>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("BuildResultsUI+<>c__DisplayClass27_0")]
	public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_setup;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Created_b__0_Internal_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Created_b__1_Internal_Void_Int32_0;

		public unsafe CategorySetup setup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setup);
				return new CategorySetup(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CategorySetup>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)categorySetup)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CategorySetup>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe BuildResultsUI __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BuildResultsUI>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildResultsUI));
			}
		}

		static __c__DisplayClass27_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "<>c__DisplayClass27_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr);
			NativeFieldInfoPtr_setup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, "setup");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100664629);
			NativeMethodInfoPtr__Created_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100664630);
			NativeMethodInfoPtr__Created_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100664631);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass27_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32999, XrefRangeEnd = 33002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Created_b__0(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Created_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33002, XrefRangeEnd = 33004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Created_b__1(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Created_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass27_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_blueprintManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_constructionManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_startConstructionPlacementSignal;

	private static readonly System.IntPtr NativeFieldInfoPtr_showCraftingListSignal;

	private static readonly System.IntPtr NativeFieldInfoPtr_showBuildMenuSignal;

	private static readonly System.IntPtr NativeFieldInfoPtr_showCataloguePopupUIEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_filteredItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_filteredConstruction;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownerInventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_substanceCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingCategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingPieceType;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingSearch;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockedBlueprintIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_filterableResultsUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_searchButtonData;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastScrollPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_categoryTabData;

	private static readonly System.IntPtr NativeFieldInfoPtr_categoryTabsSetupList;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingTabIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_blueprintsResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedCategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedShelterType;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedBuildingPieceType;

	private static readonly System.IntPtr NativeMethodInfoPtr_Created_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshList_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterItem_Public_Void_InventoryItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FilterConstruction_Public_Void_Construction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createComponent_Private_UIComponent_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bindComponent_Private_Void_UIComponent_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_numElements_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_elementHeight_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onSearch_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onTabSubmitted_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBlueprints_Private_Void_String_List_1_Blueprint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBlueprints_Private_Void_BuildingPieceType_List_1_Blueprint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBlueprints_Private_Void_ShelterType_BuildingPieceType_List_1_Blueprint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBlueprints_Private_Void_BuildingCategory_List_1_Blueprint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addBlueprint_Private_Void_Blueprint_List_1_Blueprint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onSearchClick_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCategoryClick_Private_Void_Int32_BuildingCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onShelterTypeClick_Private_Void_Int32_ShelterType_BuildingPieceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onBuildingPieceClick_Private_Void_Int32_BuildingPieceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_filterItem_Private_Void_InventoryItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_filterConstruction_Private_Void_Construction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onPlaceClicked_Private_Void_Blueprint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onIngredientSelected_Private_Void_CraftingIngredient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onConstructionSelected_Private_Void_Construction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onIngredientDetailed_Private_Void_CraftingIngredient_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onConstructionDetailed_Private_Void_Construction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCancel_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_refreshNoResults_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__onPlaceClicked_b__51_0_Private_Void_Boolean_0;

	public unsafe IBlueprintManager blueprintManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprintManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IBlueprintManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprintManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blueprintManager));
		}
	}

	public unsafe IConstructionManager constructionManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IConstructionManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constructionManager));
		}
	}

	public unsafe StartConstructionPlacementSignal startConstructionPlacementSignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startConstructionPlacementSignal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StartConstructionPlacementSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startConstructionPlacementSignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startConstructionPlacementSignal));
		}
	}

	public unsafe ShowCraftingListSignal showCraftingListSignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCraftingListSignal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowCraftingListSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCraftingListSignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showCraftingListSignal));
		}
	}

	public unsafe ShowBuildMenuSignal showBuildMenuSignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showBuildMenuSignal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowBuildMenuSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showBuildMenuSignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showBuildMenuSignal));
		}
	}

	public unsafe ShowCataloguePopupUIEvent showCataloguePopupUIEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCataloguePopupUIEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowCataloguePopupUIEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCataloguePopupUIEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showCataloguePopupUIEvent));
		}
	}

	public unsafe InventoryItem filteredItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filteredItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filteredItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryItem));
		}
	}

	public unsafe Construction filteredConstruction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filteredConstruction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Construction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filteredConstruction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)construction));
		}
	}

	public unsafe Entity ownerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Inventory ownerInventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownerInventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Inventory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownerInventory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory));
		}
	}

	public unsafe Dictionary<InventoryItem, int> itemCounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemCounts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InventoryItem, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemCounts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Substance, int> substanceCounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_substanceCounts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Substance, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_substanceCounts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe BuildingCategory startingCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCategory);
			return *(BuildingCategory*)num;
		}
		set
		{
			*(BuildingCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCategory)) = buildingCategory;
		}
	}

	public unsafe BuildingPieceType startingPieceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPieceType);
			return *(BuildingPieceType*)num;
		}
		set
		{
			*(BuildingPieceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPieceType)) = buildingPieceType;
		}
	}

	public unsafe string startingSearch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingSearch);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingSearch)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe HashSet<string> unlockedBlueprintIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedBlueprintIdentifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedBlueprintIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe FilterableResultsUI filterableResultsUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filterableResultsUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FilterableResultsUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filterableResultsUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)filterableResultsUI));
		}
	}

	public unsafe TabButtonData searchButtonData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchButtonData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TabButtonData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchButtonData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tabButtonData));
		}
	}

	public unsafe float lastScrollPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastScrollPosition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastScrollPosition)) = num;
		}
	}

	public unsafe List<TabData> categoryTabData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_categoryTabData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TabData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_categoryTabData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CategorySetup> categoryTabsSetupList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_categoryTabsSetupList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CategorySetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_categoryTabsSetupList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int startingTabIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingTabIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingTabIndex)) = num;
		}
	}

	public unsafe List<Blueprint> blueprintsResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprintsResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Blueprint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprintsResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BuildingCategory selectedCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedCategory);
			return *(BuildingCategory*)num;
		}
		set
		{
			*(BuildingCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedCategory)) = buildingCategory;
		}
	}

	public unsafe ShelterType selectedShelterType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedShelterType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShelterType>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedShelterType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shelterType));
		}
	}

	public unsafe BuildingPieceType selectedBuildingPieceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedBuildingPieceType);
			return *(BuildingPieceType*)num;
		}
		set
		{
			*(BuildingPieceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedBuildingPieceType)) = buildingPieceType;
		}
	}

	static BuildResultsUI()
	{
		Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "BuildResultsUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr);
		NativeFieldInfoPtr_blueprintManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "blueprintManager");
		NativeFieldInfoPtr_constructionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "constructionManager");
		NativeFieldInfoPtr_startConstructionPlacementSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "startConstructionPlacementSignal");
		NativeFieldInfoPtr_showCraftingListSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "showCraftingListSignal");
		NativeFieldInfoPtr_showBuildMenuSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "showBuildMenuSignal");
		NativeFieldInfoPtr_showCataloguePopupUIEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "showCataloguePopupUIEvent");
		NativeFieldInfoPtr_filteredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "filteredItem");
		NativeFieldInfoPtr_filteredConstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "filteredConstruction");
		NativeFieldInfoPtr_ownerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "ownerEntity");
		NativeFieldInfoPtr_ownerInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "ownerInventory");
		NativeFieldInfoPtr_itemCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "itemCounts");
		NativeFieldInfoPtr_substanceCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "substanceCounts");
		NativeFieldInfoPtr_startingCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "startingCategory");
		NativeFieldInfoPtr_startingPieceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "startingPieceType");
		NativeFieldInfoPtr_startingSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "startingSearch");
		NativeFieldInfoPtr_unlockedBlueprintIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "unlockedBlueprintIdentifiers");
		NativeFieldInfoPtr_filterableResultsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "filterableResultsUI");
		NativeFieldInfoPtr_searchButtonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "searchButtonData");
		NativeFieldInfoPtr_lastScrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "lastScrollPosition");
		NativeFieldInfoPtr_categoryTabData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "categoryTabData");
		NativeFieldInfoPtr_categoryTabsSetupList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "categoryTabsSetupList");
		NativeFieldInfoPtr_startingTabIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "startingTabIndex");
		NativeFieldInfoPtr_blueprintsResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "blueprintsResult");
		NativeFieldInfoPtr_selectedCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "selectedCategory");
		NativeFieldInfoPtr_selectedShelterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "selectedShelterType");
		NativeFieldInfoPtr_selectedBuildingPieceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, "selectedBuildingPieceType");
		NativeMethodInfoPtr_Created_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664596);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664597);
		NativeMethodInfoPtr_Shown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664598);
		NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664599);
		NativeMethodInfoPtr_RefreshList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664600);
		NativeMethodInfoPtr_FilterItem_Public_Void_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664601);
		NativeMethodInfoPtr_FilterConstruction_Public_Void_Construction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664602);
		NativeMethodInfoPtr_createComponent_Private_UIComponent_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664603);
		NativeMethodInfoPtr_bindComponent_Private_Void_UIComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664604);
		NativeMethodInfoPtr_numElements_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664605);
		NativeMethodInfoPtr_elementHeight_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664606);
		NativeMethodInfoPtr_onSearch_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664607);
		NativeMethodInfoPtr_onTabSubmitted_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664608);
		NativeMethodInfoPtr_getBlueprints_Private_Void_String_List_1_Blueprint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664609);
		NativeMethodInfoPtr_getBlueprints_Private_Void_BuildingPieceType_List_1_Blueprint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664610);
		NativeMethodInfoPtr_getBlueprints_Private_Void_ShelterType_BuildingPieceType_List_1_Blueprint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664611);
		NativeMethodInfoPtr_getBlueprints_Private_Void_BuildingCategory_List_1_Blueprint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664612);
		NativeMethodInfoPtr_addBlueprint_Private_Void_Blueprint_List_1_Blueprint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664613);
		NativeMethodInfoPtr_onSearchClick_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664614);
		NativeMethodInfoPtr_onCategoryClick_Private_Void_Int32_BuildingCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664615);
		NativeMethodInfoPtr_onShelterTypeClick_Private_Void_Int32_ShelterType_BuildingPieceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664616);
		NativeMethodInfoPtr_onBuildingPieceClick_Private_Void_Int32_BuildingPieceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664617);
		NativeMethodInfoPtr_filterItem_Private_Void_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664618);
		NativeMethodInfoPtr_filterConstruction_Private_Void_Construction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664619);
		NativeMethodInfoPtr_onPlaceClicked_Private_Void_Blueprint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664620);
		NativeMethodInfoPtr_onIngredientSelected_Private_Void_CraftingIngredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664621);
		NativeMethodInfoPtr_onConstructionSelected_Private_Void_Construction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664622);
		NativeMethodInfoPtr_onIngredientDetailed_Private_Void_CraftingIngredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664623);
		NativeMethodInfoPtr_onConstructionDetailed_Private_Void_Construction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664624);
		NativeMethodInfoPtr_onCancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664625);
		NativeMethodInfoPtr_refreshNoResults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664626);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664627);
		NativeMethodInfoPtr__onPlaceClicked_b__51_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr, 100664628);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33004, XrefRangeEnd = 33281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Created()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Created_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33281, XrefRangeEnd = 33304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33304, XrefRangeEnd = 33307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Shown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33307, XrefRangeEnd = 33360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Destroyed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 33378, RefRangeEnd = 33385, XrefRangeStart = 33360, XrefRangeEnd = 33378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 33386, RefRangeEnd = 33388, XrefRangeStart = 33385, XrefRangeEnd = 33386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FilterItem(InventoryItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterItem_Public_Void_InventoryItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 33386, RefRangeEnd = 33388, XrefRangeStart = 33386, XrefRangeEnd = 33388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FilterConstruction(Construction construction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)construction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FilterConstruction_Public_Void_Construction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33388, XrefRangeEnd = 33445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIComponent createComponent(Transform transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createComponent_Private_UIComponent_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UIComponent>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33445, XrefRangeEnd = 33453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void bindComponent(UIComponent component, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bindComponent_Private_Void_UIComponent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33453, XrefRangeEnd = 33454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int numElements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_numElements_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33454, XrefRangeEnd = 33460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float elementHeight(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_elementHeight_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33460, XrefRangeEnd = 33461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onSearch(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onSearch_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33464, RefRangeEnd = 33465, XrefRangeStart = 33461, XrefRangeEnd = 33464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onTabSubmitted(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onTabSubmitted_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33501, RefRangeEnd = 33502, XrefRangeStart = 33465, XrefRangeEnd = 33501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getBlueprints(string searchValue, List<Blueprint> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(searchValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBlueprints_Private_Void_String_List_1_Blueprint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33582, RefRangeEnd = 33583, XrefRangeStart = 33502, XrefRangeEnd = 33582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getBlueprints(BuildingPieceType buildingPieceType, List<Blueprint> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&buildingPieceType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBlueprints_Private_Void_BuildingPieceType_List_1_Blueprint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33664, RefRangeEnd = 33665, XrefRangeStart = 33583, XrefRangeEnd = 33664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getBlueprints(ShelterType shelterType, BuildingPieceType buildingPieceType, List<Blueprint> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shelterType);
		*(BuildingPieceType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buildingPieceType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBlueprints_Private_Void_ShelterType_BuildingPieceType_List_1_Blueprint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33749, RefRangeEnd = 33750, XrefRangeStart = 33665, XrefRangeEnd = 33749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getBlueprints(BuildingCategory category, List<Blueprint> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&category);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBlueprints_Private_Void_BuildingCategory_List_1_Blueprint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 33757, RefRangeEnd = 33760, XrefRangeStart = 33750, XrefRangeEnd = 33757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addBlueprint(Blueprint blueprint, List<Blueprint> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blueprint);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addBlueprint_Private_Void_Blueprint_List_1_Blueprint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33760, XrefRangeEnd = 33761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onSearchClick(int tabIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tabIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onSearchClick_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33764, RefRangeEnd = 33765, XrefRangeStart = 33761, XrefRangeEnd = 33764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onCategoryClick(int tabIndex, BuildingCategory category)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tabIndex);
		*(BuildingCategory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCategoryClick_Private_Void_Int32_BuildingCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33765, XrefRangeEnd = 33768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onShelterTypeClick(int tabIndex, ShelterType shelterType, BuildingPieceType buildingPieceType = BuildingPieceType.NONE)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&tabIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shelterType);
		*(BuildingPieceType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buildingPieceType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onShelterTypeClick_Private_Void_Int32_ShelterType_BuildingPieceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 33771, RefRangeEnd = 33773, XrefRangeStart = 33768, XrefRangeEnd = 33771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onBuildingPieceClick(int tabIndex, BuildingPieceType buildingPieceType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tabIndex);
		*(BuildingPieceType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buildingPieceType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onBuildingPieceClick_Private_Void_Int32_BuildingPieceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 33776, RefRangeEnd = 33778, XrefRangeStart = 33773, XrefRangeEnd = 33776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void filterItem(InventoryItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_filterItem_Private_Void_InventoryItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 33776, RefRangeEnd = 33778, XrefRangeStart = 33776, XrefRangeEnd = 33778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void filterConstruction(Construction construction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)construction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_filterConstruction_Private_Void_Construction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33778, XrefRangeEnd = 33790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onPlaceClicked(Blueprint blueprint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blueprint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onPlaceClicked_Private_Void_Blueprint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33790, XrefRangeEnd = 33794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onIngredientSelected(CraftingIngredient ingredient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ingredient);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onIngredientSelected_Private_Void_CraftingIngredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onConstructionSelected(Construction construction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)construction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onConstructionSelected_Private_Void_Construction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33794, XrefRangeEnd = 33798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onIngredientDetailed(CraftingIngredient ingredient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ingredient);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onIngredientDetailed_Private_Void_CraftingIngredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33798, XrefRangeEnd = 33802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onConstructionDetailed(Construction construction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)construction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onConstructionDetailed_Private_Void_Construction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33802, XrefRangeEnd = 33804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onCancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33804, XrefRangeEnd = 33812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void refreshNoResults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_refreshNoResults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuildResultsUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildResultsUI>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33812, XrefRangeEnd = 33813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _onPlaceClicked_b__51_0(bool success)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&success);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__onPlaceClicked_b__51_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BuildResultsUI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

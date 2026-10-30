using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CookingMenuUI : UIWindow
{
	[ObfuscatedName("CookingMenuUI+<>c__DisplayClass83_0")]
	public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_dryingSection;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputSection;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__constructCookingView_b__3_Internal_Void_TileInventoryUI_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__constructCookingView_b__0_Internal_Void_TileInventoryUI_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__constructCookingView_b__1_Internal_Void_TileInventoryUI_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__constructCookingView_b__2_Internal_Void_FuelBurnerIgniteUI_0;

		public unsafe IInventorySection dryingSection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dryingSection);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventorySection>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dryingSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventorySection));
			}
		}

		public unsafe IInventorySection inputSection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputSection);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventorySection>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventorySection));
			}
		}

		public unsafe CookingMenuUI __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CookingMenuUI>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cookingMenuUI));
			}
		}

		static __c__DisplayClass83_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "<>c__DisplayClass83_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr);
			NativeFieldInfoPtr_dryingSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr, "dryingSection");
			NativeFieldInfoPtr_inputSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr, "inputSection");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr, 100666376);
			NativeMethodInfoPtr__constructCookingView_b__3_Internal_Void_TileInventoryUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr, 100666377);
			NativeMethodInfoPtr__constructCookingView_b__0_Internal_Void_TileInventoryUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr, 100666378);
			NativeMethodInfoPtr__constructCookingView_b__1_Internal_Void_TileInventoryUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr, 100666379);
			NativeMethodInfoPtr__constructCookingView_b__2_Internal_Void_FuelBurnerIgniteUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr, 100666380);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass83_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass83_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58306, XrefRangeEnd = 58308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _constructCookingView_b__3(TileInventoryUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__constructCookingView_b__3_Internal_Void_TileInventoryUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58308, XrefRangeEnd = 58310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _constructCookingView_b__0(TileInventoryUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__constructCookingView_b__0_Internal_Void_TileInventoryUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58310, XrefRangeEnd = 58315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _constructCookingView_b__1(TileInventoryUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__constructCookingView_b__1_Internal_Void_TileInventoryUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58315, XrefRangeEnd = 58342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _constructCookingView_b__2(FuelBurnerIgniteUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__constructCookingView_b__2_Internal_Void_FuelBurnerIgniteUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass83_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CookingMenuUI+<>c__DisplayClass83_1")]
	public sealed class __c__DisplayClass83_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_slot;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__constructCookingView_b__4_Internal_Void_InventorySlotUI_0;

		public unsafe InventorySlot slot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slot);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventorySlot>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventorySlot));
			}
		}

		static __c__DisplayClass83_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass83_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "<>c__DisplayClass83_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass83_1>.NativeClassPtr);
			NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass83_1>.NativeClassPtr, "slot");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass83_1>.NativeClassPtr, 100666381);
			NativeMethodInfoPtr__constructCookingView_b__4_Internal_Void_InventorySlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass83_1>.NativeClassPtr, 100666382);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass83_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass83_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58342, XrefRangeEnd = 58344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _constructCookingView_b__4(InventorySlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__constructCookingView_b__4_Internal_Void_InventorySlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass83_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CookingMenuUI+<>c__DisplayClass88_0")]
	public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_outputMixture;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__updateState_b__0_Internal_Void_SubstanceMixtureUI_0;

		public unsafe SubstanceMixture outputMixture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputMixture);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SubstanceMixture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputMixture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substanceMixture));
			}
		}

		static __c__DisplayClass88_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "<>c__DisplayClass88_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr);
			NativeFieldInfoPtr_outputMixture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr, "outputMixture");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr, 100666383);
			NativeMethodInfoPtr__updateState_b__0_Internal_Void_SubstanceMixtureUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr, 100666384);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass88_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58344, XrefRangeEnd = 58346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _updateState_b__0(SubstanceMixtureUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__updateState_b__0_Internal_Void_SubstanceMixtureUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass88_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_titleText;

	private static readonly System.IntPtr NativeFieldInfoPtr_infoSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_startCookingButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingButtonText;

	private static readonly System.IntPtr NativeFieldInfoPtr_igniteSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelButtonSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelHeadingText;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelButtonText;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitedFuelArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelTimeRemainingArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelTimeRemainingHeaderText;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelTimeRemainingText;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelTemperatureArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelTemperatureHeaderText;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelTemperatureText;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelToAddIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelToAddText;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelBackgroundImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_outputSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_outputResultHeaderText;

	private static readonly System.IntPtr NativeFieldInfoPtr_outputSlotsSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_outputMixtureSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_extractButtonText;

	private static readonly System.IntPtr NativeFieldInfoPtr_extractButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_discardButtonText;

	private static readonly System.IntPtr NativeFieldInfoPtr_discardButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_dryingSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_dryingHeaderText;

	private static readonly System.IntPtr NativeFieldInfoPtr_dryingSlotsSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingProgressSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingProgressIngredientsSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingProgressBarBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingProgressBar;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingProgressText;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingProgressTimeRemainingText;

	private static readonly System.IntPtr NativeFieldInfoPtr_ingredientsSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_ingredientsText;

	private static readonly System.IntPtr NativeFieldInfoPtr_ingredientsSlotSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_ingredientsTiledInventorySection;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelSlotSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingHeader;

	private static readonly System.IntPtr NativeFieldInfoPtr_containerSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_containerText;

	private static readonly System.IntPtr NativeFieldInfoPtr_containerSlotsSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionIndicatorImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredTimeText;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredTemperatureText;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultHeaderText;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultIngredientsSection;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultQualityText;

	private static readonly System.IntPtr NativeFieldInfoPtr_mixtureText;

	private static readonly System.IntPtr NativeFieldInfoPtr_warningArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_warningText;

	private static readonly System.IntPtr NativeFieldInfoPtr_showMessageOnObjectSignal;

	private static readonly System.IntPtr NativeFieldInfoPtr_showFillItemSelectionEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_startCookingEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_discardDistillerSubstanceEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_startIgnitingEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_igniteAddedFuelEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelBurner;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemFueled;

	private static readonly System.IntPtr NativeFieldInfoPtr_cooker;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildable;

	private static readonly System.IntPtr NativeFieldInfoPtr_placedItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_distiller;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

	private static readonly System.IntPtr NativeFieldInfoPtr_ownerSkills;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_shownRecipeResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTemperature;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingProgressTimeRemaining;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelEfficiencyBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_transitionOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelBurnerIgniteUI;

	private static readonly System.IntPtr NativeMethodInfoPtr_Created_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_constructCookingView_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleFuelBurner_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleItemFueled_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateState_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getIngredientMixtureWarning_Private_String_CookingRecipeResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onInventoryUpdated_Private_Void_Inventory_InventorySlot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onPotentialRecipeChange_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onFuelDepleted_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCookHoverEnter_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCookHoverExit_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onStartCookingClick_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onIgniteClick_Private_Void_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onFuelActionClick_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onFuelHoverEnter_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onFuelHoverExit_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onExtractButtonClick_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onDiscardButtonClick_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onInteractableInteractionEnd_Private_Void_IInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInventory_Public_Virtual_Final_New_Inventory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValidItemTags_Public_Virtual_Final_New_Void_HashSet_1_ItemTag_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetProgress_Public_Virtual_Final_New_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetProgress_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__onStartCookingClick_b__95_0_Private_Void_Int32_StartCookingEventResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__onIgniteClick_b__96_0_Private_Void_Int32_StartIgnitingEventResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__onFuelActionClick_b__97_0_Private_Void_Int32_IgniteAddedFuelEventResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__onExtractButtonClick_b__100_0_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__onDiscardButtonClick_b__101_0_Private_Void_Int32_DiscardDistillerSubstanceEventResult_0;

	public unsafe TextMeshProUGUI titleText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_titleText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_titleText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup infoSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe SurvivalButton startCookingButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startCookingButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SurvivalButton>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startCookingButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)survivalButton));
		}
	}

	public unsafe TextMeshProUGUI cookingButtonText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingButtonText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingButtonText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe Transform igniteSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_igniteSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_igniteSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform fuelButtonSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelButtonSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelButtonSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe SurvivalButton fuelButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SurvivalButton>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)survivalButton));
		}
	}

	public unsafe TextMeshProUGUI fuelHeadingText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelHeadingText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelHeadingText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI fuelButtonText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelButtonText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelButtonText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup ignitedFuelArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitedFuelArea);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignitedFuelArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe LayoutGroup fuelTimeRemainingArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTimeRemainingArea);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTimeRemainingArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe TextMeshProUGUI fuelTimeRemainingHeaderText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTimeRemainingHeaderText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTimeRemainingHeaderText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI fuelTimeRemainingText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTimeRemainingText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTimeRemainingText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup fuelTemperatureArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTemperatureArea);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTemperatureArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe TextMeshProUGUI fuelTemperatureHeaderText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTemperatureHeaderText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTemperatureHeaderText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI fuelTemperatureText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTemperatureText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelTemperatureText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe Image fuelToAddIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelToAddIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelToAddIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe TextMeshProUGUI fuelToAddText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelToAddText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelToAddText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe Image fuelBackgroundImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelBackgroundImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelBackgroundImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe LayoutGroup outputSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe TextMeshProUGUI outputResultHeaderText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputResultHeaderText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputResultHeaderText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup outputSlotsSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputSlotsSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputSlotsSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe LayoutGroup outputMixtureSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputMixtureSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputMixtureSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe TextMeshProUGUI extractButtonText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extractButtonText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extractButtonText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe SurvivalButton extractButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extractButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SurvivalButton>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extractButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)survivalButton));
		}
	}

	public unsafe TextMeshProUGUI discardButtonText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discardButtonText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discardButtonText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe SurvivalButton discardButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discardButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SurvivalButton>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discardButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)survivalButton));
		}
	}

	public unsafe LayoutGroup dryingSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dryingSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dryingSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe TextMeshProUGUI dryingHeaderText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dryingHeaderText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dryingHeaderText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup dryingSlotsSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dryingSlotsSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dryingSlotsSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe LayoutGroup cookingProgressSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe LayoutGroup cookingProgressIngredientsSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressIngredientsSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressIngredientsSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe Image cookingProgressBarBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressBarBackground);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressBarBackground)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Image cookingProgressBar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressBar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressBar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe TextMeshProUGUI cookingProgressText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI cookingProgressTimeRemainingText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressTimeRemainingText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressTimeRemainingText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup ingredientsSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientsSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientsSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe TextMeshProUGUI ingredientsText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientsText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientsText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup ingredientsSlotSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientsSlotSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientsSlotSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe LayoutGroup ingredientsTiledInventorySection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientsTiledInventorySection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientsTiledInventorySection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe LayoutGroup fuelSlotSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelSlotSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelSlotSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe LayoutGroup cookingSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe TextMeshProUGUI cookingHeader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingHeader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingHeader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup containerSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containerSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containerSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe TextMeshProUGUI containerText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containerText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containerText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup containerSlotsSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containerSlotsSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containerSlotsSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe LayoutGroup transitionSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe Image transitionIndicatorImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionIndicatorImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionIndicatorImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe TextMeshProUGUI requiredTimeText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredTimeText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredTimeText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI requiredTemperatureText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredTemperatureText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredTemperatureText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup resultSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe TextMeshProUGUI resultHeaderText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultHeaderText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultHeaderText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe LayoutGroup resultIngredientsSection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultIngredientsSection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultIngredientsSection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe TextMeshProUGUI resultQualityText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultQualityText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultQualityText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI mixtureText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mixtureText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mixtureText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe Image warningArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warningArea);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warningArea)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe TextMeshProUGUI warningText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warningText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_warningText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe ShowMessageOnObjectSignal showMessageOnObjectSignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMessageOnObjectSignal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowMessageOnObjectSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMessageOnObjectSignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showMessageOnObjectSignal));
		}
	}

	public unsafe ShowFillItemSelectionEvent showFillItemSelectionEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showFillItemSelectionEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowFillItemSelectionEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showFillItemSelectionEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showFillItemSelectionEvent));
		}
	}

	public unsafe StartCookingEvent startCookingEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startCookingEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StartCookingEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startCookingEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startCookingEvent));
		}
	}

	public unsafe DiscardDistillerSubstanceEvent discardDistillerSubstanceEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discardDistillerSubstanceEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DiscardDistillerSubstanceEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discardDistillerSubstanceEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)discardDistillerSubstanceEvent));
		}
	}

	public unsafe StartIgnitingEvent startIgnitingEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startIgnitingEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StartIgnitingEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startIgnitingEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startIgnitingEvent));
		}
	}

	public unsafe IgniteAddedFuelEvent igniteAddedFuelEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_igniteAddedFuelEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IgniteAddedFuelEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_igniteAddedFuelEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)igniteAddedFuelEvent));
		}
	}

	public unsafe Entity cookerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
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

	public unsafe IFuelBurner fuelBurner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelBurner);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IFuelBurner>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelBurner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fuelBurner));
		}
	}

	public unsafe IItemFueled itemFueled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFueled);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IItemFueled>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFueled)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemFueled));
		}
	}

	public unsafe ICooker cooker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cooker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICooker>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cooker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cooker));
		}
	}

	public unsafe IInteractor interactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteractor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactor));
		}
	}

	public unsafe IBuildable buildable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IBuildable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buildable));
		}
	}

	public unsafe IPlacedItem placedItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placedItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IPlacedItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placedItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placedItem));
		}
	}

	public unsafe IDistiller distiller
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distiller);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDistiller>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distiller)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)distiller));
		}
	}

	public unsafe IInteractable interactable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteractable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
		}
	}

	public unsafe ISkills ownerSkills
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownerSkills);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISkills>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownerSkills)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skills));
		}
	}

	public unsafe IInteraction cookingInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingInteraction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingInteraction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction));
		}
	}

	public unsafe CookingRecipeResult shownRecipeResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shownRecipeResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CookingRecipeResult>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shownRecipeResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cookingRecipeResult));
		}
	}

	public unsafe float lastTemperature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTemperature);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTemperature)) = num;
		}
	}

	public unsafe float cookingProgressTimeRemaining
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressTimeRemaining);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookingProgressTimeRemaining)) = num;
		}
	}

	public unsafe float fuelEfficiencyBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelEfficiencyBonus);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelEfficiencyBonus)) = num;
		}
	}

	public unsafe bool transitionOpen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionOpen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionOpen)) = flag;
		}
	}

	public unsafe FuelBurnerIgniteUI fuelBurnerIgniteUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelBurnerIgniteUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FuelBurnerIgniteUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fuelBurnerIgniteUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fuelBurnerIgniteUI));
		}
	}

	static CookingMenuUI()
	{
		Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CookingMenuUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr);
		NativeFieldInfoPtr_titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "titleText");
		NativeFieldInfoPtr_infoSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "infoSection");
		NativeFieldInfoPtr_startCookingButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "startCookingButton");
		NativeFieldInfoPtr_cookingButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingButtonText");
		NativeFieldInfoPtr_igniteSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "igniteSection");
		NativeFieldInfoPtr_fuelButtonSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelButtonSection");
		NativeFieldInfoPtr_fuelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelButton");
		NativeFieldInfoPtr_fuelHeadingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelHeadingText");
		NativeFieldInfoPtr_fuelButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelButtonText");
		NativeFieldInfoPtr_ignitedFuelArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "ignitedFuelArea");
		NativeFieldInfoPtr_fuelTimeRemainingArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelTimeRemainingArea");
		NativeFieldInfoPtr_fuelTimeRemainingHeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelTimeRemainingHeaderText");
		NativeFieldInfoPtr_fuelTimeRemainingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelTimeRemainingText");
		NativeFieldInfoPtr_fuelTemperatureArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelTemperatureArea");
		NativeFieldInfoPtr_fuelTemperatureHeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelTemperatureHeaderText");
		NativeFieldInfoPtr_fuelTemperatureText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelTemperatureText");
		NativeFieldInfoPtr_fuelToAddIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelToAddIcon");
		NativeFieldInfoPtr_fuelToAddText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelToAddText");
		NativeFieldInfoPtr_fuelBackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelBackgroundImage");
		NativeFieldInfoPtr_outputSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "outputSection");
		NativeFieldInfoPtr_outputResultHeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "outputResultHeaderText");
		NativeFieldInfoPtr_outputSlotsSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "outputSlotsSection");
		NativeFieldInfoPtr_outputMixtureSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "outputMixtureSection");
		NativeFieldInfoPtr_extractButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "extractButtonText");
		NativeFieldInfoPtr_extractButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "extractButton");
		NativeFieldInfoPtr_discardButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "discardButtonText");
		NativeFieldInfoPtr_discardButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "discardButton");
		NativeFieldInfoPtr_dryingSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "dryingSection");
		NativeFieldInfoPtr_dryingHeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "dryingHeaderText");
		NativeFieldInfoPtr_dryingSlotsSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "dryingSlotsSection");
		NativeFieldInfoPtr_cookingProgressSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingProgressSection");
		NativeFieldInfoPtr_cookingProgressIngredientsSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingProgressIngredientsSection");
		NativeFieldInfoPtr_cookingProgressBarBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingProgressBarBackground");
		NativeFieldInfoPtr_cookingProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingProgressBar");
		NativeFieldInfoPtr_cookingProgressText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingProgressText");
		NativeFieldInfoPtr_cookingProgressTimeRemainingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingProgressTimeRemainingText");
		NativeFieldInfoPtr_ingredientsSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "ingredientsSection");
		NativeFieldInfoPtr_ingredientsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "ingredientsText");
		NativeFieldInfoPtr_ingredientsSlotSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "ingredientsSlotSection");
		NativeFieldInfoPtr_ingredientsTiledInventorySection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "ingredientsTiledInventorySection");
		NativeFieldInfoPtr_fuelSlotSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelSlotSection");
		NativeFieldInfoPtr_cookingSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingSection");
		NativeFieldInfoPtr_cookingHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingHeader");
		NativeFieldInfoPtr_containerSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "containerSection");
		NativeFieldInfoPtr_containerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "containerText");
		NativeFieldInfoPtr_containerSlotsSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "containerSlotsSection");
		NativeFieldInfoPtr_transitionSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "transitionSection");
		NativeFieldInfoPtr_transitionIndicatorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "transitionIndicatorImage");
		NativeFieldInfoPtr_requiredTimeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "requiredTimeText");
		NativeFieldInfoPtr_requiredTemperatureText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "requiredTemperatureText");
		NativeFieldInfoPtr_resultSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "resultSection");
		NativeFieldInfoPtr_resultHeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "resultHeaderText");
		NativeFieldInfoPtr_resultIngredientsSection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "resultIngredientsSection");
		NativeFieldInfoPtr_resultQualityText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "resultQualityText");
		NativeFieldInfoPtr_mixtureText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "mixtureText");
		NativeFieldInfoPtr_warningArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "warningArea");
		NativeFieldInfoPtr_warningText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "warningText");
		NativeFieldInfoPtr_showMessageOnObjectSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "showMessageOnObjectSignal");
		NativeFieldInfoPtr_showFillItemSelectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "showFillItemSelectionEvent");
		NativeFieldInfoPtr_startCookingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "startCookingEvent");
		NativeFieldInfoPtr_discardDistillerSubstanceEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "discardDistillerSubstanceEvent");
		NativeFieldInfoPtr_startIgnitingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "startIgnitingEvent");
		NativeFieldInfoPtr_igniteAddedFuelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "igniteAddedFuelEvent");
		NativeFieldInfoPtr_cookerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookerEntity");
		NativeFieldInfoPtr_ownerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "ownerEntity");
		NativeFieldInfoPtr_fuelBurner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelBurner");
		NativeFieldInfoPtr_itemFueled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "itemFueled");
		NativeFieldInfoPtr_cooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cooker");
		NativeFieldInfoPtr_interactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "interactor");
		NativeFieldInfoPtr_buildable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "buildable");
		NativeFieldInfoPtr_placedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "placedItem");
		NativeFieldInfoPtr_distiller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "distiller");
		NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "interactable");
		NativeFieldInfoPtr_ownerSkills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "ownerSkills");
		NativeFieldInfoPtr_cookingInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingInteraction");
		NativeFieldInfoPtr_shownRecipeResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "shownRecipeResult");
		NativeFieldInfoPtr_lastTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "lastTemperature");
		NativeFieldInfoPtr_cookingProgressTimeRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "cookingProgressTimeRemaining");
		NativeFieldInfoPtr_fuelEfficiencyBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelEfficiencyBonus");
		NativeFieldInfoPtr_transitionOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "transitionOpen");
		NativeFieldInfoPtr_fuelBurnerIgniteUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, "fuelBurnerIgniteUI");
		NativeMethodInfoPtr_Created_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666344);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666345);
		NativeMethodInfoPtr_constructCookingView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666346);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666347);
		NativeMethodInfoPtr_handleFuelBurner_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666348);
		NativeMethodInfoPtr_handleItemFueled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666349);
		NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666350);
		NativeMethodInfoPtr_updateState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666351);
		NativeMethodInfoPtr_getIngredientMixtureWarning_Private_String_CookingRecipeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666352);
		NativeMethodInfoPtr_onInventoryUpdated_Private_Void_Inventory_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666353);
		NativeMethodInfoPtr_onPotentialRecipeChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666354);
		NativeMethodInfoPtr_onFuelDepleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666355);
		NativeMethodInfoPtr_onCookHoverEnter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666356);
		NativeMethodInfoPtr_onCookHoverExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666357);
		NativeMethodInfoPtr_onStartCookingClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666358);
		NativeMethodInfoPtr_onIgniteClick_Private_Void_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666359);
		NativeMethodInfoPtr_onFuelActionClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666360);
		NativeMethodInfoPtr_onFuelHoverEnter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666361);
		NativeMethodInfoPtr_onFuelHoverExit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666362);
		NativeMethodInfoPtr_onExtractButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666363);
		NativeMethodInfoPtr_onDiscardButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666364);
		NativeMethodInfoPtr_onInteractableInteractionEnd_Private_Void_IInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666365);
		NativeMethodInfoPtr_GetInventory_Public_Virtual_Final_New_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666366);
		NativeMethodInfoPtr_GetValidItemTags_Public_Virtual_Final_New_Void_HashSet_1_ItemTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666367);
		NativeMethodInfoPtr_SetProgress_Public_Virtual_Final_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666368);
		NativeMethodInfoPtr_ResetProgress_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666369);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666370);
		NativeMethodInfoPtr__onStartCookingClick_b__95_0_Private_Void_Int32_StartCookingEventResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666371);
		NativeMethodInfoPtr__onIgniteClick_b__96_0_Private_Void_Int32_StartIgnitingEventResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666372);
		NativeMethodInfoPtr__onFuelActionClick_b__97_0_Private_Void_Int32_IgniteAddedFuelEventResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666373);
		NativeMethodInfoPtr__onExtractButtonClick_b__100_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666374);
		NativeMethodInfoPtr__onDiscardButtonClick_b__101_0_Private_Void_Int32_DiscardDistillerSubstanceEventResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr, 100666375);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58346, XrefRangeEnd = 58399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Created()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Created_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58399, XrefRangeEnd = 58650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58819, RefRangeEnd = 58820, XrefRangeStart = 58650, XrefRangeEnd = 58819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void constructCookingView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_constructCookingView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58820, XrefRangeEnd = 58853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58955, RefRangeEnd = 58956, XrefRangeStart = 58853, XrefRangeEnd = 58955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleFuelBurner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleFuelBurner_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58997, RefRangeEnd = 58998, XrefRangeStart = 58956, XrefRangeEnd = 58997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleItemFueled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleItemFueled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58998, XrefRangeEnd = 59090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Destroyed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 59469, RefRangeEnd = 59480, XrefRangeStart = 59090, XrefRangeEnd = 59469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59531, RefRangeEnd = 59532, XrefRangeStart = 59480, XrefRangeEnd = 59531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getIngredientMixtureWarning(CookingRecipeResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getIngredientMixtureWarning_Private_String_CookingRecipeResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59532, XrefRangeEnd = 59533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onInventoryUpdated(Inventory inventory, InventorySlot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onInventoryUpdated_Private_Void_Inventory_InventorySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onPotentialRecipeChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onPotentialRecipeChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onFuelDepleted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onFuelDepleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59533, XrefRangeEnd = 59561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onCookHoverEnter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCookHoverEnter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59561, XrefRangeEnd = 59567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onCookHoverExit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCookHoverExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59567, XrefRangeEnd = 59581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onStartCookingClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onStartCookingClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59581, XrefRangeEnd = 59595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onIgniteClick(InventoryItemStack toolStack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toolStack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onIgniteClick_Private_Void_InventoryItemStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59595, XrefRangeEnd = 59607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onFuelActionClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onFuelActionClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59607, XrefRangeEnd = 59621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onFuelHoverEnter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onFuelHoverEnter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59621, XrefRangeEnd = 59627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onFuelHoverExit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onFuelHoverExit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59627, XrefRangeEnd = 59649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onExtractButtonClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onExtractButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59649, XrefRangeEnd = 59658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onDiscardButtonClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onDiscardButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59658, XrefRangeEnd = 59662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onInteractableInteractionEnd(IInteraction interaction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onInteractableInteractionEnd_Private_Void_IInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59662, XrefRangeEnd = 59669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Inventory GetInventory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInventory_Public_Virtual_Final_New_Inventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Inventory>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59669, XrefRangeEnd = 59707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void GetValidItemTags(HashSet<ItemTag> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValidItemTags_Public_Virtual_Final_New_Void_HashSet_1_ItemTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59707, XrefRangeEnd = 59712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetProgress(float progress, float duration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&progress);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProgress_Public_Virtual_Final_New_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ResetProgress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetProgress_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CookingMenuUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookingMenuUI>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59712, XrefRangeEnd = 59724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _onStartCookingClick_b__95_0(int resultCode, StartCookingEventResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&resultCode);
		*(StartCookingEventResult**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__onStartCookingClick_b__95_0_Private_Void_Int32_StartCookingEventResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void _onIgniteClick_b__96_0(int resultCode, StartIgnitingEventResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&resultCode);
		*(StartIgnitingEventResult**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__onIgniteClick_b__96_0_Private_Void_Int32_StartIgnitingEventResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59724, XrefRangeEnd = 59725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _onFuelActionClick_b__97_0(int resultCode, IgniteAddedFuelEventResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&resultCode);
		*(IgniteAddedFuelEventResult**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__onFuelActionClick_b__97_0_Private_Void_Int32_IgniteAddedFuelEventResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59725, XrefRangeEnd = 59738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _onExtractButtonClick_b__100_0(bool success)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&success);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__onExtractButtonClick_b__100_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _onDiscardButtonClick_b__101_0(int resultCode, DiscardDistillerSubstanceEventResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&resultCode);
		*(DiscardDistillerSubstanceEventResult**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &result;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__onDiscardButtonClick_b__101_0_Private_Void_Int32_DiscardDistillerSubstanceEventResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CookingMenuUI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

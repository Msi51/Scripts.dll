using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public class CraftingOutputUI : UIComponent
{
	private static readonly IntPtr NativeFieldInfoPtr_parentLayoutElement;

	private static readonly IntPtr NativeFieldInfoPtr_soloIngredientSize;

	private static readonly IntPtr NativeFieldInfoPtr_firstIngredientSize;

	private static readonly IntPtr NativeFieldInfoPtr_secondIngredientSize;

	private static readonly IntPtr NativeFieldInfoPtr_ingredientUIResult;

	private static readonly IntPtr NativeFieldInfoPtr_onIngredientClicked;

	private static readonly IntPtr NativeFieldInfoPtr_onIngredientDetailed;

	private static readonly IntPtr NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetRecipe_Public_Void_List_1_CraftingIngredient_Boolean_Boolean_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_onIngredientClick_Private_Void_CraftingIngredient_0;

	private static readonly IntPtr NativeMethodInfoPtr_onIngredientDetailClick_Private_Void_CraftingIngredient_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe LayoutElement parentLayoutElement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentLayoutElement);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentLayoutElement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutElement));
		}
	}

	public unsafe float soloIngredientSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soloIngredientSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soloIngredientSize)) = num;
		}
	}

	public unsafe float firstIngredientSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstIngredientSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstIngredientSize)) = num;
		}
	}

	public unsafe float secondIngredientSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondIngredientSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondIngredientSize)) = num;
		}
	}

	public unsafe List<CraftingIngredientUI> ingredientUIResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientUIResult);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CraftingIngredientUI>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ingredientUIResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe UnityEvent<CraftingIngredient> onIngredientClicked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onIngredientClicked);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent<CraftingIngredient>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onIngredientClicked)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	public unsafe UnityEvent<CraftingIngredient> onIngredientDetailed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onIngredientDetailed);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent<CraftingIngredient>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onIngredientDetailed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	static CraftingOutputUI()
	{
		Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CraftingOutputUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr);
		NativeFieldInfoPtr_parentLayoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, "parentLayoutElement");
		NativeFieldInfoPtr_soloIngredientSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, "soloIngredientSize");
		NativeFieldInfoPtr_firstIngredientSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, "firstIngredientSize");
		NativeFieldInfoPtr_secondIngredientSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, "secondIngredientSize");
		NativeFieldInfoPtr_ingredientUIResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, "ingredientUIResult");
		NativeFieldInfoPtr_onIngredientClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, "onIngredientClicked");
		NativeFieldInfoPtr_onIngredientDetailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, "onIngredientDetailed");
		NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, 100664803);
		NativeMethodInfoPtr_SetRecipe_Public_Void_List_1_CraftingIngredient_Boolean_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, 100664804);
		NativeMethodInfoPtr_onIngredientClick_Private_Void_CraftingIngredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, 100664805);
		NativeMethodInfoPtr_onIngredientDetailClick_Private_Void_CraftingIngredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, 100664806);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr, 100664807);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36947, XrefRangeEnd = 36982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Destroyed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Destroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 37058, RefRangeEnd = 37059, XrefRangeStart = 36982, XrefRangeEnd = 37058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRecipe(List<CraftingIngredient> ingredients, bool useAllInputAmount, bool allIngredientsPresent, int waterMixingIngredientAmountPossible, int totalAmountPossible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ingredients);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &useAllInputAmount;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &allIngredientsPresent;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &waterMixingIngredientAmountPossible;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &totalAmountPossible;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRecipe_Public_Void_List_1_CraftingIngredient_Boolean_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37059, XrefRangeEnd = 37063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onIngredientClick(CraftingIngredient ingredient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ingredient);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onIngredientClick_Private_Void_CraftingIngredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37063, XrefRangeEnd = 37067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onIngredientDetailClick(CraftingIngredient ingredient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ingredient);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onIngredientDetailClick_Private_Void_CraftingIngredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37067, XrefRangeEnd = 37088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CraftingOutputUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CraftingOutputUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CraftingOutputUI(IntPtr pointer)
		: base(pointer)
	{
	}
}

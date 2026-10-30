using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class ModelDisplayProperty : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_iconType;

	private static readonly System.IntPtr NativeFieldInfoPtr_text;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemFunc;

	private static readonly System.IntPtr NativeFieldInfoPtr_stackTextFunc;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeStatusEffectFunc;

	private static readonly System.IntPtr NativeFieldInfoPtr_craftingTextFunc;

	private static readonly System.IntPtr NativeFieldInfoPtr_stackColorFunc;

	private static readonly System.IntPtr NativeFieldInfoPtr_growableTextFunc;

	private static readonly System.IntPtr NativeFieldInfoPtr_growableChangeFunc;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetText_Public_String_World_InventoryItemStack_CraftingProperties_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetText_Public_String_World_IGrowable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetText_Public_String_World_ActiveStatusEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Color_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChangeIndicator_Public_Boolean_IGrowable_byref_Boolean_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithItemFunc_Public_ModelDisplayProperty_Func_2_World_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithStackFunc_Public_ModelDisplayProperty_Func_3_World_InventoryItemStack_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithStackColorFunc_Public_ModelDisplayProperty_Func_2_InventoryItemStack_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithCraftingPropertiesFunc_Public_ModelDisplayProperty_Func_3_World_CraftingProperties_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithGrowableFunc_Public_ModelDisplayProperty_Func_3_World_IGrowable_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithGrowableChangeFunc_Public_ModelDisplayProperty_Func_2_IGrowable_ValueTuple_3_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithActiveStatusEffectFunc_Public_ModelDisplayProperty_Func_3_World_ActiveStatusEffect_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_String_Color_0;

	public unsafe IconType iconType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconType);
			return *(IconType*)num;
		}
		set
		{
			*(IconType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconType)) = iconType;
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

	public unsafe Color color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = color;
		}
	}

	public unsafe Il2CppSystem.Func<World, string> itemFunc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFunc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<World, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	public unsafe Il2CppSystem.Func<World, InventoryItemStack, string> stackTextFunc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackTextFunc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<World, InventoryItemStack, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackTextFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	public unsafe Il2CppSystem.Func<World, ActiveStatusEffect, string> activeStatusEffectFunc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeStatusEffectFunc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<World, ActiveStatusEffect, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeStatusEffectFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	public unsafe Il2CppSystem.Func<World, CraftingProperties, string> craftingTextFunc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftingTextFunc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<World, CraftingProperties, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftingTextFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	public unsafe Il2CppSystem.Func<InventoryItemStack, Color> stackColorFunc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackColorFunc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<InventoryItemStack, Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stackColorFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	public unsafe Il2CppSystem.Func<World, IGrowable, string> growableTextFunc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growableTextFunc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<World, IGrowable, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growableTextFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	public unsafe Il2CppSystem.Func<IGrowable, Il2CppSystem.ValueTuple<bool, bool, bool>> growableChangeFunc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growableChangeFunc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<IGrowable, Il2CppSystem.ValueTuple<bool, bool, bool>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growableChangeFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
		}
	}

	static ModelDisplayProperty()
	{
		Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ModelDisplayProperty");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr);
		NativeFieldInfoPtr_iconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, "iconType");
		NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, "text");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, "color");
		NativeFieldInfoPtr_itemFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, "itemFunc");
		NativeFieldInfoPtr_stackTextFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, "stackTextFunc");
		NativeFieldInfoPtr_activeStatusEffectFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, "activeStatusEffectFunc");
		NativeFieldInfoPtr_craftingTextFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, "craftingTextFunc");
		NativeFieldInfoPtr_stackColorFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, "stackColorFunc");
		NativeFieldInfoPtr_growableTextFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, "growableTextFunc");
		NativeFieldInfoPtr_growableChangeFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, "growableChangeFunc");
		NativeMethodInfoPtr_GetText_Public_String_World_InventoryItemStack_CraftingProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678326);
		NativeMethodInfoPtr_GetText_Public_String_World_IGrowable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678327);
		NativeMethodInfoPtr_GetText_Public_String_World_ActiveStatusEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678328);
		NativeMethodInfoPtr_GetColor_Public_Color_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678329);
		NativeMethodInfoPtr_GetChangeIndicator_Public_Boolean_IGrowable_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678330);
		NativeMethodInfoPtr_WithItemFunc_Public_ModelDisplayProperty_Func_2_World_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678331);
		NativeMethodInfoPtr_WithStackFunc_Public_ModelDisplayProperty_Func_3_World_InventoryItemStack_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678332);
		NativeMethodInfoPtr_WithStackColorFunc_Public_ModelDisplayProperty_Func_2_InventoryItemStack_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678333);
		NativeMethodInfoPtr_WithCraftingPropertiesFunc_Public_ModelDisplayProperty_Func_3_World_CraftingProperties_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678334);
		NativeMethodInfoPtr_WithGrowableFunc_Public_ModelDisplayProperty_Func_3_World_IGrowable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678335);
		NativeMethodInfoPtr_WithGrowableChangeFunc_Public_ModelDisplayProperty_Func_2_IGrowable_ValueTuple_3_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678336);
		NativeMethodInfoPtr_WithActiveStatusEffectFunc_Public_ModelDisplayProperty_Func_3_World_ActiveStatusEffect_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678337);
		NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678338);
		NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678339);
		NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678340);
		NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678341);
		NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678342);
		NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr, 100678343);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 224182, RefRangeEnd = 224187, XrefRangeStart = 224182, XrefRangeEnd = 224182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetText(World world, InventoryItemStack stack = null, CraftingProperties craftingProperties = default(CraftingProperties))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		*(CraftingProperties**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &craftingProperties;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetText_Public_String_World_InventoryItemStack_CraftingProperties_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 224187, RefRangeEnd = 224189, XrefRangeStart = 224187, XrefRangeEnd = 224187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetText(World world, IGrowable growable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)growable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetText_Public_String_World_IGrowable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 224189, RefRangeEnd = 224193, XrefRangeStart = 224189, XrefRangeEnd = 224189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetText(World world, ActiveStatusEffect activeStatusEffect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeStatusEffect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetText_Public_String_World_ActiveStatusEffect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 224193, RefRangeEnd = 224201, XrefRangeStart = 224193, XrefRangeEnd = 224193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColor(InventoryItemStack stack = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Color_InventoryItemStack_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224201, RefRangeEnd = 224202, XrefRangeStart = 224201, XrefRangeEnd = 224201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetChangeIndicator(IGrowable growable, out bool up, out bool positive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)growable);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref up);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref positive);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChangeIndicator_Public_Boolean_IGrowable_byref_Boolean_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 224203, RefRangeEnd = 224206, XrefRangeStart = 224202, XrefRangeEnd = 224203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModelDisplayProperty WithItemFunc(Il2CppSystem.Func<World, string> itemFunc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithItemFunc_Public_ModelDisplayProperty_Func_2_World_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 224207, RefRangeEnd = 224236, XrefRangeStart = 224206, XrefRangeEnd = 224207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModelDisplayProperty WithStackFunc(Il2CppSystem.Func<World, InventoryItemStack, string> stackFunc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stackFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithStackFunc_Public_ModelDisplayProperty_Func_3_World_InventoryItemStack_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 224237, RefRangeEnd = 224240, XrefRangeStart = 224236, XrefRangeEnd = 224237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModelDisplayProperty WithStackColorFunc(Il2CppSystem.Func<InventoryItemStack, Color> stackColorFunc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stackColorFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithStackColorFunc_Public_ModelDisplayProperty_Func_2_InventoryItemStack_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 224241, RefRangeEnd = 224255, XrefRangeStart = 224240, XrefRangeEnd = 224241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModelDisplayProperty WithCraftingPropertiesFunc(Il2CppSystem.Func<World, CraftingProperties, string> craftingFunc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)craftingFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithCraftingPropertiesFunc_Public_ModelDisplayProperty_Func_3_World_CraftingProperties_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 224256, RefRangeEnd = 224264, XrefRangeStart = 224255, XrefRangeEnd = 224256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModelDisplayProperty WithGrowableFunc(Il2CppSystem.Func<World, IGrowable, string> growableFunc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)growableFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithGrowableFunc_Public_ModelDisplayProperty_Func_3_World_IGrowable_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 224265, RefRangeEnd = 224268, XrefRangeStart = 224264, XrefRangeEnd = 224265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModelDisplayProperty WithGrowableChangeFunc(Il2CppSystem.Func<IGrowable, Il2CppSystem.ValueTuple<bool, bool, bool>> growableFunc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)growableFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithGrowableChangeFunc_Public_ModelDisplayProperty_Func_2_IGrowable_ValueTuple_3_Boolean_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 224269, RefRangeEnd = 224282, XrefRangeStart = 224268, XrefRangeEnd = 224269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModelDisplayProperty WithActiveStatusEffectFunc(Il2CppSystem.Func<World, ActiveStatusEffect, string> effectFunc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithActiveStatusEffectFunc_Public_ModelDisplayProperty_Func_3_World_ActiveStatusEffect_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 224283, RefRangeEnd = 224311, XrefRangeStart = 224282, XrefRangeEnd = 224283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ModelDisplayProperty New(string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 224312, RefRangeEnd = 224325, XrefRangeStart = 224311, XrefRangeEnd = 224312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ModelDisplayProperty New(string text, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 224325, RefRangeEnd = 224337, XrefRangeStart = 224325, XrefRangeEnd = 224325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ModelDisplayProperty New(IconType iconType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&iconType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 224337, RefRangeEnd = 224353, XrefRangeStart = 224337, XrefRangeEnd = 224337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ModelDisplayProperty New(IconType iconType, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&iconType);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 224354, RefRangeEnd = 224373, XrefRangeStart = 224353, XrefRangeEnd = 224354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ModelDisplayProperty New(IconType iconType, string text)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&iconType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	[CallerCount(46)]
	[CachedScanResults(RefRangeStart = 224374, RefRangeEnd = 224420, XrefRangeStart = 224373, XrefRangeEnd = 224374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ModelDisplayProperty New(IconType iconType, string text, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&iconType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_New_Public_Static_ModelDisplayProperty_IconType_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ModelDisplayProperty(pointer);
	}

	public ModelDisplayProperty(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ModelDisplayProperty()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelDisplayProperty>.NativeClassPtr))
	{
	}
}

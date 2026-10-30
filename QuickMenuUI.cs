using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class QuickMenuUI : UIWindow
{
	private static readonly IntPtr NativeFieldInfoPtr_radialMenuActionFactory;

	private static readonly IntPtr NativeFieldInfoPtr_leftAction;

	private static readonly IntPtr NativeFieldInfoPtr_rightAction;

	private static readonly IntPtr NativeFieldInfoPtr_topAction;

	private static readonly IntPtr NativeFieldInfoPtr_bottomAction;

	private static readonly IntPtr NativeFieldInfoPtr_items;

	private static readonly IntPtr NativeFieldInfoPtr_shownSubmenuItem;

	private static readonly IntPtr NativeMethodInfoPtr_Created_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_showSubmenu_Private_Void_IQuickMenuItemUI_QuickMenuSubMenuDetails_0;

	private static readonly IntPtr NativeMethodInfoPtr_initItemData_Private_Void_IQuickMenuItemUI_IRadialMenuItemAction_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHighlightedAction_Public_IRadialMenuItemAction_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowSubMenu_Public_Void_IRadialMenuItemAction_QuickMenuSubMenuDetails_0;

	private static readonly IntPtr NativeMethodInfoPtr_HideItems_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReShow_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GoBack_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__Start_b__8_0_Private_Void_QuickMenuItemUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__Start_b__8_1_Private_Void_QuickMenuItemUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__Start_b__8_2_Private_Void_QuickMenuItemUI_0;

	private static readonly IntPtr NativeMethodInfoPtr__Start_b__8_3_Private_Void_QuickMenuItemUI_0;

	public unsafe IRadialMenuActionFactory radialMenuActionFactory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radialMenuActionFactory);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IRadialMenuActionFactory>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radialMenuActionFactory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)radialMenuActionFactory));
		}
	}

	public unsafe IRadialMenuItemAction leftAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IRadialMenuItemAction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)radialMenuItemAction));
		}
	}

	public unsafe IRadialMenuItemAction rightAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IRadialMenuItemAction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)radialMenuItemAction));
		}
	}

	public unsafe IRadialMenuItemAction topAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IRadialMenuItemAction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)radialMenuItemAction));
		}
	}

	public unsafe IRadialMenuItemAction bottomAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bottomAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IRadialMenuItemAction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bottomAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)radialMenuItemAction));
		}
	}

	public unsafe List<IQuickMenuItemUI> items
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<IQuickMenuItemUI>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_items)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe IQuickMenuItemUI shownSubmenuItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shownSubmenuItem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IQuickMenuItemUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shownSubmenuItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)quickMenuItemUI));
		}
	}

	static QuickMenuUI()
	{
		Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "QuickMenuUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr);
		NativeFieldInfoPtr_radialMenuActionFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, "radialMenuActionFactory");
		NativeFieldInfoPtr_leftAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, "leftAction");
		NativeFieldInfoPtr_rightAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, "rightAction");
		NativeFieldInfoPtr_topAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, "topAction");
		NativeFieldInfoPtr_bottomAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, "bottomAction");
		NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, "items");
		NativeFieldInfoPtr_shownSubmenuItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, "shownSubmenuItem");
		NativeMethodInfoPtr_Created_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667180);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667181);
		NativeMethodInfoPtr_showSubmenu_Private_Void_IQuickMenuItemUI_QuickMenuSubMenuDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667182);
		NativeMethodInfoPtr_initItemData_Private_Void_IQuickMenuItemUI_IRadialMenuItemAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667183);
		NativeMethodInfoPtr_GetHighlightedAction_Public_IRadialMenuItemAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667184);
		NativeMethodInfoPtr_ShowSubMenu_Public_Void_IRadialMenuItemAction_QuickMenuSubMenuDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667185);
		NativeMethodInfoPtr_HideItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667186);
		NativeMethodInfoPtr_ReShow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667187);
		NativeMethodInfoPtr_GoBack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667188);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667189);
		NativeMethodInfoPtr__Start_b__8_0_Private_Void_QuickMenuItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667190);
		NativeMethodInfoPtr__Start_b__8_1_Private_Void_QuickMenuItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667191);
		NativeMethodInfoPtr__Start_b__8_2_Private_Void_QuickMenuItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667192);
		NativeMethodInfoPtr__Start_b__8_3_Private_Void_QuickMenuItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr, 100667193);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74465, XrefRangeEnd = 74479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Created()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Created_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74479, XrefRangeEnd = 74520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void showSubmenu(IQuickMenuItemUI itemUI, QuickMenuSubMenuDetails details)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemUI);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)details));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showSubmenu_Private_Void_IQuickMenuItemUI_QuickMenuSubMenuDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 74528, RefRangeEnd = 74532, XrefRangeStart = 74520, XrefRangeEnd = 74528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initItemData(IQuickMenuItemUI itemUI, IRadialMenuItemAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemUI);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initItemData_Private_Void_IQuickMenuItemUI_IRadialMenuItemAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74541, RefRangeEnd = 74542, XrefRangeStart = 74532, XrefRangeEnd = 74541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IRadialMenuItemAction GetHighlightedAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHighlightedAction_Public_IRadialMenuItemAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IRadialMenuItemAction>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 74573, RefRangeEnd = 74577, XrefRangeStart = 74542, XrefRangeEnd = 74573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowSubMenu(IRadialMenuItemAction action, QuickMenuSubMenuDetails details)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)details));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowSubMenu_Public_Void_IRadialMenuItemAction_QuickMenuSubMenuDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74597, RefRangeEnd = 74598, XrefRangeStart = 74577, XrefRangeEnd = 74597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74619, RefRangeEnd = 74620, XrefRangeStart = 74598, XrefRangeEnd = 74619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReShow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReShow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74627, RefRangeEnd = 74628, XrefRangeStart = 74620, XrefRangeEnd = 74627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GoBack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe QuickMenuUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuickMenuUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74628, XrefRangeEnd = 74633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__8_0(QuickMenuItemUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__8_0_Private_Void_QuickMenuItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74633, XrefRangeEnd = 74638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__8_1(QuickMenuItemUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__8_1_Private_Void_QuickMenuItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74638, XrefRangeEnd = 74643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__8_2(QuickMenuItemUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__8_2_Private_Void_QuickMenuItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74643, XrefRangeEnd = 74648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__8_3(QuickMenuItemUI ui)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ui);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__8_3_Private_Void_QuickMenuItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public QuickMenuUI(IntPtr pointer)
		: base(pointer)
	{
	}
}

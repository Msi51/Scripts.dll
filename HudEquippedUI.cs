using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class HudEquippedUI : UIComponent
{
	private static readonly IntPtr NativeFieldInfoPtr_mainHandSlotSize;

	private static readonly IntPtr NativeFieldInfoPtr_offhandSlotSize;

	private static readonly IntPtr NativeFieldInfoPtr_mainHandSlotUI;

	private static readonly IntPtr NativeFieldInfoPtr_offhandSlotUI;

	private static readonly IntPtr NativeFieldInfoPtr_inventoryHolder;

	private static readonly IntPtr NativeFieldInfoPtr_interactor;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInventory_Public_Virtual_Final_New_Inventory_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAttachedWindow_Public_Virtual_Final_New_UIWindow_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetValidItemTags_Public_Virtual_Final_New_Void_HashSet_1_ItemTag_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnLanguageChanged_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float mainHandSlotSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainHandSlotSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainHandSlotSize)) = num;
		}
	}

	public unsafe float offhandSlotSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offhandSlotSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offhandSlotSize)) = num;
		}
	}

	public unsafe HudSlotUI mainHandSlotUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainHandSlotUI);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HudSlotUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainHandSlotUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hudSlotUI));
		}
	}

	public unsafe HudSlotUI offhandSlotUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offhandSlotUI);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HudSlotUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offhandSlotUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hudSlotUI));
		}
	}

	public unsafe IInventoryHolder inventoryHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolder);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInventoryHolder>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryHolder));
		}
	}

	public unsafe IInteractor interactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInteractor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactor));
		}
	}

	static HudEquippedUI()
	{
		Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HudEquippedUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr);
		NativeFieldInfoPtr_mainHandSlotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, "mainHandSlotSize");
		NativeFieldInfoPtr_offhandSlotSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, "offhandSlotSize");
		NativeFieldInfoPtr_mainHandSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, "mainHandSlotUI");
		NativeFieldInfoPtr_offhandSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, "offhandSlotUI");
		NativeFieldInfoPtr_inventoryHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, "inventoryHolder");
		NativeFieldInfoPtr_interactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, "interactor");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, 100665237);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, 100665238);
		NativeMethodInfoPtr_GetInventory_Public_Virtual_Final_New_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, 100665239);
		NativeMethodInfoPtr_GetAttachedWindow_Public_Virtual_Final_New_UIWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, 100665240);
		NativeMethodInfoPtr_GetValidItemTags_Public_Virtual_Final_New_Void_HashSet_1_ItemTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, 100665241);
		NativeMethodInfoPtr_OnLanguageChanged_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, 100665242);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr, 100665243);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44252, XrefRangeEnd = 44294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44294, XrefRangeEnd = 44321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Inventory GetInventory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInventory_Public_Virtual_Final_New_Inventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Inventory>(intPtr) : null;
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual UIWindow GetAttachedWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttachedWindow_Public_Virtual_Final_New_UIWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIWindow>(intPtr) : null;
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void GetValidItemTags(HashSet<ItemTag> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValidItemTags_Public_Virtual_Final_New_Void_HashSet_1_ItemTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44321, XrefRangeEnd = 44331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnLanguageChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLanguageChanged_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HudEquippedUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HudEquippedUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HudEquippedUI(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class ShowItemSelectionDropdownSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dropdownButtonUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemStacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_callback;

	public unsafe IDropdownButtonUI dropdownButtonUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropdownButtonUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDropdownButtonUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropdownButtonUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dropdownButtonUI));
		}
	}

	public unsafe List<InventoryItemStack> itemStacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemStacks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InventoryItemStack>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemStacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe DropdownItemSelectionCallback callback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DropdownItemSelectionCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dropdownItemSelectionCallback));
		}
	}

	static ShowItemSelectionDropdownSignalParams()
	{
		Il2CppClassPointerStore<ShowItemSelectionDropdownSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowItemSelectionDropdownSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowItemSelectionDropdownSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_dropdownButtonUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowItemSelectionDropdownSignalParams>.NativeClassPtr, "dropdownButtonUI");
		NativeFieldInfoPtr_itemStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowItemSelectionDropdownSignalParams>.NativeClassPtr, "itemStacks");
		NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowItemSelectionDropdownSignalParams>.NativeClassPtr, "callback");
	}

	public ShowItemSelectionDropdownSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ShowItemSelectionDropdownSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowItemSelectionDropdownSignalParams>.NativeClassPtr))
	{
	}
}

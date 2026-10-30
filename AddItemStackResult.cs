using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class AddItemStackResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_fits;

	private static readonly System.IntPtr NativeFieldInfoPtr_item;

	private static readonly System.IntPtr NativeFieldInfoPtr_quantityAdded;

	private static readonly System.IntPtr NativeFieldInfoPtr_slotsUsed;

	public unsafe bool fits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fits);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fits)) = flag;
		}
	}

	public unsafe InventoryItem item
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_item)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryItem));
		}
	}

	public unsafe int quantityAdded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quantityAdded);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quantityAdded)) = num;
		}
	}

	public unsafe List<InventorySlot> slotsUsed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotsUsed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InventorySlot>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotsUsed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static AddItemStackResult()
	{
		Il2CppClassPointerStore<AddItemStackResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AddItemStackResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddItemStackResult>.NativeClassPtr);
		NativeFieldInfoPtr_fits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemStackResult>.NativeClassPtr, "fits");
		NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemStackResult>.NativeClassPtr, "item");
		NativeFieldInfoPtr_quantityAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemStackResult>.NativeClassPtr, "quantityAdded");
		NativeFieldInfoPtr_slotsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddItemStackResult>.NativeClassPtr, "slotsUsed");
	}

	public AddItemStackResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AddItemStackResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddItemStackResult>.NativeClassPtr))
	{
	}
}

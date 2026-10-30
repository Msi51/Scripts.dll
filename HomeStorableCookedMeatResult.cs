using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class HomeStorableCookedMeatResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookedMeatSlotIndex;

	public unsafe Entity target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe InventorySlotIndex cookedMeatSlotIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookedMeatSlotIndex);
			return *(InventorySlotIndex*)num;
		}
		set
		{
			*(InventorySlotIndex*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookedMeatSlotIndex)) = inventorySlotIndex;
		}
	}

	static HomeStorableCookedMeatResult()
	{
		Il2CppClassPointerStore<HomeStorableCookedMeatResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HomeStorableCookedMeatResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HomeStorableCookedMeatResult>.NativeClassPtr);
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeStorableCookedMeatResult>.NativeClassPtr, "target");
		NativeFieldInfoPtr_cookedMeatSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HomeStorableCookedMeatResult>.NativeClassPtr, "cookedMeatSlotIndex");
	}

	public HomeStorableCookedMeatResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HomeStorableCookedMeatResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HomeStorableCookedMeatResult>.NativeClassPtr))
	{
	}
}

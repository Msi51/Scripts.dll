using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class CookerRawMeatResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_rawMeatSlotIndex;

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

	public unsafe InventorySlotIndex rawMeatSlotIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawMeatSlotIndex);
			return *(InventorySlotIndex*)num;
		}
		set
		{
			*(InventorySlotIndex*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawMeatSlotIndex)) = inventorySlotIndex;
		}
	}

	static CookerRawMeatResult()
	{
		Il2CppClassPointerStore<CookerRawMeatResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CookerRawMeatResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookerRawMeatResult>.NativeClassPtr);
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerRawMeatResult>.NativeClassPtr, "target");
		NativeFieldInfoPtr_rawMeatSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerRawMeatResult>.NativeClassPtr, "rawMeatSlotIndex");
	}

	public CookerRawMeatResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CookerRawMeatResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookerRawMeatResult>.NativeClassPtr))
	{
	}
}

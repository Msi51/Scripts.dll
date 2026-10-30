using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class HarvestableMeatCarcassResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_harvestedSlotIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_knifeSlotIndex;

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

	public unsafe InventorySlotIndex harvestedSlotIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_harvestedSlotIndex);
			return *(InventorySlotIndex*)num;
		}
		set
		{
			*(InventorySlotIndex*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_harvestedSlotIndex)) = inventorySlotIndex;
		}
	}

	public unsafe InventorySlotIndex knifeSlotIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knifeSlotIndex);
			return *(InventorySlotIndex*)num;
		}
		set
		{
			*(InventorySlotIndex*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knifeSlotIndex)) = inventorySlotIndex;
		}
	}

	static HarvestableMeatCarcassResult()
	{
		Il2CppClassPointerStore<HarvestableMeatCarcassResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HarvestableMeatCarcassResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HarvestableMeatCarcassResult>.NativeClassPtr);
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestableMeatCarcassResult>.NativeClassPtr, "target");
		NativeFieldInfoPtr_harvestedSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestableMeatCarcassResult>.NativeClassPtr, "harvestedSlotIndex");
		NativeFieldInfoPtr_knifeSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestableMeatCarcassResult>.NativeClassPtr, "knifeSlotIndex");
	}

	public HarvestableMeatCarcassResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HarvestableMeatCarcassResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HarvestableMeatCarcassResult>.NativeClassPtr))
	{
	}
}

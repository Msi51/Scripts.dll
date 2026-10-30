using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class StartRepairSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_repairerInventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_recipe;

	private static readonly System.IntPtr NativeFieldInfoPtr_repairedStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_toolStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressableUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_repairBenchEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_callback;

	public unsafe Inventory repairerInventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repairerInventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Inventory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repairerInventory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory));
		}
	}

	public unsafe RepairRecipe recipe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recipe);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RepairRecipe>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recipe)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)repairRecipe));
		}
	}

	public unsafe InventoryItemStack repairedStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repairedStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repairedStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryItemStack));
		}
	}

	public unsafe InventoryItemStack toolStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toolStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toolStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryItemStack));
		}
	}

	public unsafe IProgressableUI progressableUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressableUI);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IProgressableUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressableUI)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progressableUI));
		}
	}

	public unsafe Entity repairBenchEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repairBenchEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repairBenchEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Il2CppSystem.Action<bool> callback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	static StartRepairSignalParams()
	{
		Il2CppClassPointerStore<StartRepairSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartRepairSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartRepairSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_repairerInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartRepairSignalParams>.NativeClassPtr, "repairerInventory");
		NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartRepairSignalParams>.NativeClassPtr, "recipe");
		NativeFieldInfoPtr_repairedStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartRepairSignalParams>.NativeClassPtr, "repairedStack");
		NativeFieldInfoPtr_toolStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartRepairSignalParams>.NativeClassPtr, "toolStack");
		NativeFieldInfoPtr_progressableUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartRepairSignalParams>.NativeClassPtr, "progressableUI");
		NativeFieldInfoPtr_repairBenchEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartRepairSignalParams>.NativeClassPtr, "repairBenchEntity");
		NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartRepairSignalParams>.NativeClassPtr, "callback");
	}

	public StartRepairSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public StartRepairSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartRepairSignalParams>.NativeClassPtr))
	{
	}
}

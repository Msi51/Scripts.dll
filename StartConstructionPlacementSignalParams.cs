using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class StartConstructionPlacementSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_inventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_blueprint;

	private static readonly System.IntPtr NativeFieldInfoPtr_startPlacementCallback;

	public unsafe Inventory inventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Inventory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventory));
		}
	}

	public unsafe Blueprint blueprint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Blueprint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blueprint));
		}
	}

	public unsafe StartPlacementCallback startPlacementCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startPlacementCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StartPlacementCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startPlacementCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startPlacementCallback));
		}
	}

	static StartConstructionPlacementSignalParams()
	{
		Il2CppClassPointerStore<StartConstructionPlacementSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartConstructionPlacementSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartConstructionPlacementSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConstructionPlacementSignalParams>.NativeClassPtr, "inventory");
		NativeFieldInfoPtr_blueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConstructionPlacementSignalParams>.NativeClassPtr, "blueprint");
		NativeFieldInfoPtr_startPlacementCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConstructionPlacementSignalParams>.NativeClassPtr, "startPlacementCallback");
	}

	public StartConstructionPlacementSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public StartConstructionPlacementSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartConstructionPlacementSignalParams>.NativeClassPtr))
	{
	}
}

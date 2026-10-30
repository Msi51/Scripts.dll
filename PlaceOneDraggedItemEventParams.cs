using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class PlaceOneDraggedItemEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_player;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetSlot;

	public unsafe LocalPlayer player
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LocalPlayer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)localPlayer));
		}
	}

	public unsafe InventorySlot targetSlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSlot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventorySlot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSlot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventorySlot));
		}
	}

	static PlaceOneDraggedItemEventParams()
	{
		Il2CppClassPointerStore<PlaceOneDraggedItemEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlaceOneDraggedItemEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceOneDraggedItemEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceOneDraggedItemEventParams>.NativeClassPtr, "player");
		NativeFieldInfoPtr_targetSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceOneDraggedItemEventParams>.NativeClassPtr, "targetSlot");
	}

	public PlaceOneDraggedItemEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PlaceOneDraggedItemEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceOneDraggedItemEventParams>.NativeClassPtr))
	{
	}
}

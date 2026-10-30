using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class PickupItemResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_canPickup;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemIdentifier;

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

	public unsafe CanPickupResult canPickup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPickup);
			return *(CanPickupResult*)num;
		}
		set
		{
			*(CanPickupResult*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canPickup)) = canPickupResult;
		}
	}

	public unsafe string itemIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static PickupItemResult()
	{
		Il2CppClassPointerStore<PickupItemResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PickupItemResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PickupItemResult>.NativeClassPtr);
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickupItemResult>.NativeClassPtr, "target");
		NativeFieldInfoPtr_canPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickupItemResult>.NativeClassPtr, "canPickup");
		NativeFieldInfoPtr_itemIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PickupItemResult>.NativeClassPtr, "itemIdentifier");
	}

	public PickupItemResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PickupItemResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PickupItemResult>.NativeClassPtr))
	{
	}
}

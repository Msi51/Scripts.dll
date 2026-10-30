using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class CreateItemStackEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_itemStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_dropperEntity;

	public unsafe InventoryItemStack itemStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryItemStack));
		}
	}

	public unsafe Entity dropperEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropperEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropperEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	static CreateItemStackEventParams()
	{
		Il2CppClassPointerStore<CreateItemStackEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreateItemStackEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateItemStackEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_itemStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemStackEventParams>.NativeClassPtr, "itemStack");
		NativeFieldInfoPtr_dropperEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateItemStackEventParams>.NativeClassPtr, "dropperEntity");
	}

	public CreateItemStackEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CreateItemStackEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateItemStackEventParams>.NativeClassPtr))
	{
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ConsumeStackResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_consumableStack;

	public unsafe InventoryItemStack consumableStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumableStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumableStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryItemStack));
		}
	}

	static ConsumeStackResult()
	{
		Il2CppClassPointerStore<ConsumeStackResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConsumeStackResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsumeStackResult>.NativeClassPtr);
		NativeFieldInfoPtr_consumableStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeStackResult>.NativeClassPtr, "consumableStack");
	}

	public ConsumeStackResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ConsumeStackResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsumeStackResult>.NativeClassPtr))
	{
	}
}

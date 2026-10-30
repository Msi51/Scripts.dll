using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class DestroyItemEntityEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_itemEntity;

	public unsafe Entity itemEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	static DestroyItemEntityEventParams()
	{
		Il2CppClassPointerStore<DestroyItemEntityEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DestroyItemEntityEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyItemEntityEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_itemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyItemEntityEventParams>.NativeClassPtr, "itemEntity");
	}

	public DestroyItemEntityEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DestroyItemEntityEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyItemEntityEventParams>.NativeClassPtr))
	{
	}
}

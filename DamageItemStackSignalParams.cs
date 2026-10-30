using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class DamageItemStackSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ownerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_fromSurfaceCollision;

	private static readonly System.IntPtr NativeFieldInfoPtr_numTimes;

	public unsafe Entity ownerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

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

	public unsafe SurfaceType fromSurfaceCollision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromSurfaceCollision);
			return *(SurfaceType*)num;
		}
		set
		{
			*(SurfaceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromSurfaceCollision)) = surfaceType;
		}
	}

	public unsafe int numTimes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numTimes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numTimes)) = num;
		}
	}

	static DamageItemStackSignalParams()
	{
		Il2CppClassPointerStore<DamageItemStackSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DamageItemStackSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageItemStackSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_ownerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageItemStackSignalParams>.NativeClassPtr, "ownerEntity");
		NativeFieldInfoPtr_itemStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageItemStackSignalParams>.NativeClassPtr, "itemStack");
		NativeFieldInfoPtr_fromSurfaceCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageItemStackSignalParams>.NativeClassPtr, "fromSurfaceCollision");
		NativeFieldInfoPtr_numTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageItemStackSignalParams>.NativeClassPtr, "numTimes");
	}

	public DamageItemStackSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DamageItemStackSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DamageItemStackSignalParams>.NativeClassPtr))
	{
	}
}

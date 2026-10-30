using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ProjectileFinishEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_projectileEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickupableEntityCallback;

	public unsafe Entity projectileEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projectileEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projectileEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Il2CppSystem.Action<Entity> pickupableEntityCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickupableEntityCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickupableEntityCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	static ProjectileFinishEventParams()
	{
		Il2CppClassPointerStore<ProjectileFinishEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ProjectileFinishEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectileFinishEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_projectileEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileFinishEventParams>.NativeClassPtr, "projectileEntity");
		NativeFieldInfoPtr_pickupableEntityCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileFinishEventParams>.NativeClassPtr, "pickupableEntityCallback");
	}

	public ProjectileFinishEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ProjectileFinishEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectileFinishEventParams>.NativeClassPtr))
	{
	}
}

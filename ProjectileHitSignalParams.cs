using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class ProjectileHitSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_shooterEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectileEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_launchDamagePercentage;

	public unsafe Entity shooterEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shooterEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shooterEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

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

	public unsafe GameObject hitObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Vector3 hitPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitPosition)) = vector;
		}
	}

	public unsafe Vector3 hitVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitVelocity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitVelocity)) = vector;
		}
	}

	public unsafe float launchDamagePercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_launchDamagePercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_launchDamagePercentage)) = num;
		}
	}

	static ProjectileHitSignalParams()
	{
		Il2CppClassPointerStore<ProjectileHitSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ProjectileHitSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectileHitSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_shooterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileHitSignalParams>.NativeClassPtr, "shooterEntity");
		NativeFieldInfoPtr_projectileEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileHitSignalParams>.NativeClassPtr, "projectileEntity");
		NativeFieldInfoPtr_hitObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileHitSignalParams>.NativeClassPtr, "hitObject");
		NativeFieldInfoPtr_hitPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileHitSignalParams>.NativeClassPtr, "hitPosition");
		NativeFieldInfoPtr_hitVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileHitSignalParams>.NativeClassPtr, "hitVelocity");
		NativeFieldInfoPtr_launchDamagePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileHitSignalParams>.NativeClassPtr, "launchDamagePercentage");
	}

	public ProjectileHitSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ProjectileHitSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectileHitSignalParams>.NativeClassPtr))
	{
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class PhysicsCollisionEffectEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_entity;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCollisionTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_collisionSoundDelay;

	public unsafe Entity entity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
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

	public unsafe float lastCollisionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCollisionTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCollisionTime)) = num;
		}
	}

	public unsafe float collisionSoundDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionSoundDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionSoundDelay)) = num;
		}
	}

	static PhysicsCollisionEffectEventParams()
	{
		Il2CppClassPointerStore<PhysicsCollisionEffectEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PhysicsCollisionEffectEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsCollisionEffectEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsCollisionEffectEventParams>.NativeClassPtr, "entity");
		NativeFieldInfoPtr_hitObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsCollisionEffectEventParams>.NativeClassPtr, "hitObject");
		NativeFieldInfoPtr_hitPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsCollisionEffectEventParams>.NativeClassPtr, "hitPosition");
		NativeFieldInfoPtr_hitVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsCollisionEffectEventParams>.NativeClassPtr, "hitVelocity");
		NativeFieldInfoPtr_lastCollisionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsCollisionEffectEventParams>.NativeClassPtr, "lastCollisionTime");
		NativeFieldInfoPtr_collisionSoundDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsCollisionEffectEventParams>.NativeClassPtr, "collisionSoundDelay");
	}

	public PhysicsCollisionEffectEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PhysicsCollisionEffectEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsCollisionEffectEventParams>.NativeClassPtr))
	{
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class CollisionDamageSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_damagerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_collision;

	public unsafe Entity damagerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damagerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damagerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe GameObject targetObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe UnityEngine.Collision collision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collision);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Collision>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collision)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision));
		}
	}

	static CollisionDamageSignalParams()
	{
		Il2CppClassPointerStore<CollisionDamageSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CollisionDamageSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionDamageSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_damagerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDamageSignalParams>.NativeClassPtr, "damagerEntity");
		NativeFieldInfoPtr_targetObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDamageSignalParams>.NativeClassPtr, "targetObject");
		NativeFieldInfoPtr_collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollisionDamageSignalParams>.NativeClassPtr, "collision");
	}

	public CollisionDamageSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CollisionDamageSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollisionDamageSignalParams>.NativeClassPtr))
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class DamageDealtSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_world;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_showDamage;

	private static readonly System.IntPtr NativeFieldInfoPtr_critical;

	public unsafe World world
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
		}
	}

	public unsafe DamageResult damageResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageResult);
			return new DamageResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DamageResult>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageResult), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)damageResult)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DamageResult>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Entity attackerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Vector3 damageDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageDirection)) = vector;
		}
	}

	public unsafe Vector3 weaponDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponDirection)) = vector;
		}
	}

	public unsafe bool showDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDamage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showDamage)) = flag;
		}
	}

	public unsafe bool critical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_critical);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_critical)) = flag;
		}
	}

	static DamageDealtSignalParams()
	{
		Il2CppClassPointerStore<DamageDealtSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DamageDealtSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DamageDealtSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageDealtSignalParams>.NativeClassPtr, "world");
		NativeFieldInfoPtr_damageResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageDealtSignalParams>.NativeClassPtr, "damageResult");
		NativeFieldInfoPtr_attackerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageDealtSignalParams>.NativeClassPtr, "attackerEntity");
		NativeFieldInfoPtr_damageDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageDealtSignalParams>.NativeClassPtr, "damageDirection");
		NativeFieldInfoPtr_weaponDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageDealtSignalParams>.NativeClassPtr, "weaponDirection");
		NativeFieldInfoPtr_showDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageDealtSignalParams>.NativeClassPtr, "showDamage");
		NativeFieldInfoPtr_critical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DamageDealtSignalParams>.NativeClassPtr, "critical");
	}

	public DamageDealtSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DamageDealtSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DamageDealtSignalParams>.NativeClassPtr))
	{
	}
}

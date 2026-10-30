using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public sealed class CreateResourceMinedEffectEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_minedEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_effect;

	private static readonly System.IntPtr NativeFieldInfoPtr_positions;

	public unsafe Entity minedEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minedEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minedEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe ResourceMinedEffect effect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResourceMinedEffect>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceMinedEffect));
		}
	}

	public unsafe List<Vector3> positions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static CreateResourceMinedEffectEventParams()
	{
		Il2CppClassPointerStore<CreateResourceMinedEffectEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreateResourceMinedEffectEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateResourceMinedEffectEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_minedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateResourceMinedEffectEventParams>.NativeClassPtr, "minedEntity");
		NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateResourceMinedEffectEventParams>.NativeClassPtr, "effect");
		NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateResourceMinedEffectEventParams>.NativeClassPtr, "positions");
	}

	public CreateResourceMinedEffectEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CreateResourceMinedEffectEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateResourceMinedEffectEventParams>.NativeClassPtr))
	{
	}
}

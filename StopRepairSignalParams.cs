using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class StopRepairSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_repairerObject;

	public unsafe GameObject repairerObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repairerObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repairerObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	static StopRepairSignalParams()
	{
		Il2CppClassPointerStore<StopRepairSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StopRepairSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopRepairSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_repairerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopRepairSignalParams>.NativeClassPtr, "repairerObject");
	}

	public StopRepairSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public StopRepairSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopRepairSignalParams>.NativeClassPtr))
	{
	}
}

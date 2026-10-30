using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class StopEffectEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_effectObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_instant;

	public unsafe GameObject effectObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool instant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instant);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instant)) = flag;
		}
	}

	static StopEffectEventParams()
	{
		Il2CppClassPointerStore<StopEffectEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StopEffectEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopEffectEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_effectObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopEffectEventParams>.NativeClassPtr, "effectObject");
		NativeFieldInfoPtr_instant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopEffectEventParams>.NativeClassPtr, "instant");
	}

	public StopEffectEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public StopEffectEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopEffectEventParams>.NativeClassPtr))
	{
	}
}

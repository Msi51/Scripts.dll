using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public sealed class DetailObjectData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tag;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowsDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodInstanceListMap;

	public unsafe string tag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tag);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tag)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool shadowsDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowsDisabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowsDisabled)) = flag;
		}
	}

	public unsafe List<List<CombineInstance>> lodInstanceListMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodInstanceListMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<CombineInstance>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodInstanceListMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static DetailObjectData()
	{
		Il2CppClassPointerStore<DetailObjectData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DetailObjectData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetailObjectData>.NativeClassPtr);
		NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetailObjectData>.NativeClassPtr, "tag");
		NativeFieldInfoPtr_shadowsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetailObjectData>.NativeClassPtr, "shadowsDisabled");
		NativeFieldInfoPtr_lodInstanceListMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetailObjectData>.NativeClassPtr, "lodInstanceListMap");
	}

	public DetailObjectData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DetailObjectData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetailObjectData>.NativeClassPtr))
	{
	}
}

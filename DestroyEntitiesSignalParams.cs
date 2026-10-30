using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class DestroyEntitiesSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_singularEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_multipleEntities;

	public unsafe Entity singularEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_singularEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_singularEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe ICollection<Entity> multipleEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multipleEntities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multipleEntities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collection));
		}
	}

	static DestroyEntitiesSignalParams()
	{
		Il2CppClassPointerStore<DestroyEntitiesSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DestroyEntitiesSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyEntitiesSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_singularEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyEntitiesSignalParams>.NativeClassPtr, "singularEntity");
		NativeFieldInfoPtr_multipleEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyEntitiesSignalParams>.NativeClassPtr, "multipleEntities");
	}

	public DestroyEntitiesSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DestroyEntitiesSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyEntitiesSignalParams>.NativeClassPtr))
	{
	}
}

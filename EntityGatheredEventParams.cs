using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class EntityGatheredEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gathererEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_gatheredEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_gatheredCallback;

	public unsafe Entity gathererEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gathererEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gathererEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Entity gatheredEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gatheredEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gatheredEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe EntityGatheredCallback gatheredCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gatheredCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityGatheredCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gatheredCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityGatheredCallback));
		}
	}

	static EntityGatheredEventParams()
	{
		Il2CppClassPointerStore<EntityGatheredEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EntityGatheredEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityGatheredEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_gathererEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGatheredEventParams>.NativeClassPtr, "gathererEntity");
		NativeFieldInfoPtr_gatheredEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGatheredEventParams>.NativeClassPtr, "gatheredEntity");
		NativeFieldInfoPtr_gatheredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityGatheredEventParams>.NativeClassPtr, "gatheredCallback");
	}

	public EntityGatheredEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public EntityGatheredEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGatheredEventParams>.NativeClassPtr))
	{
	}
}

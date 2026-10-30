using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class PlacementSuccessSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_placerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_placedEntity;

	public unsafe Entity placerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Entity placedEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placedEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placedEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	static PlacementSuccessSignalParams()
	{
		Il2CppClassPointerStore<PlacementSuccessSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlacementSuccessSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementSuccessSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_placerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementSuccessSignalParams>.NativeClassPtr, "placerEntity");
		NativeFieldInfoPtr_placedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementSuccessSignalParams>.NativeClassPtr, "placedEntity");
	}

	public PlacementSuccessSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PlacementSuccessSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlacementSuccessSignalParams>.NativeClassPtr))
	{
	}
}

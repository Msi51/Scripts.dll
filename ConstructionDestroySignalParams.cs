using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ConstructionDestroySignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_constructionEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroyerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_damaged;

	public unsafe Entity constructionEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Entity destroyerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe bool damaged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damaged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damaged)) = flag;
		}
	}

	static ConstructionDestroySignalParams()
	{
		Il2CppClassPointerStore<ConstructionDestroySignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConstructionDestroySignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionDestroySignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_constructionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionDestroySignalParams>.NativeClassPtr, "constructionEntity");
		NativeFieldInfoPtr_destroyerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionDestroySignalParams>.NativeClassPtr, "destroyerEntity");
		NativeFieldInfoPtr_damaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionDestroySignalParams>.NativeClassPtr, "damaged");
	}

	public ConstructionDestroySignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ConstructionDestroySignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionDestroySignalParams>.NativeClassPtr))
	{
	}
}

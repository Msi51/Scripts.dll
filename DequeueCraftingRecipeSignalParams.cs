using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class DequeueCraftingRecipeSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_crafterEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_index;

	public unsafe Entity crafterEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crafterEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crafterEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe int index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_index)) = num;
		}
	}

	static DequeueCraftingRecipeSignalParams()
	{
		Il2CppClassPointerStore<DequeueCraftingRecipeSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DequeueCraftingRecipeSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DequeueCraftingRecipeSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_crafterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DequeueCraftingRecipeSignalParams>.NativeClassPtr, "crafterEntity");
		NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DequeueCraftingRecipeSignalParams>.NativeClassPtr, "index");
	}

	public DequeueCraftingRecipeSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DequeueCraftingRecipeSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DequeueCraftingRecipeSignalParams>.NativeClassPtr))
	{
	}
}

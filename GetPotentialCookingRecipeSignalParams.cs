using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class GetPotentialCookingRecipeSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cookerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_userEntity;

	public unsafe Entity cookerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Entity userEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	static GetPotentialCookingRecipeSignalParams()
	{
		Il2CppClassPointerStore<GetPotentialCookingRecipeSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GetPotentialCookingRecipeSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetPotentialCookingRecipeSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_cookerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPotentialCookingRecipeSignalParams>.NativeClassPtr, "cookerEntity");
		NativeFieldInfoPtr_userEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetPotentialCookingRecipeSignalParams>.NativeClassPtr, "userEntity");
	}

	public GetPotentialCookingRecipeSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GetPotentialCookingRecipeSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetPotentialCookingRecipeSignalParams>.NativeClassPtr))
	{
	}
}

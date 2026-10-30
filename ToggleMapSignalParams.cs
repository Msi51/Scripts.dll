using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ToggleMapSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ownerEntity;

	public unsafe Entity ownerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	static ToggleMapSignalParams()
	{
		Il2CppClassPointerStore<ToggleMapSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ToggleMapSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleMapSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_ownerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleMapSignalParams>.NativeClassPtr, "ownerEntity");
	}

	public ToggleMapSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ToggleMapSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleMapSignalParams>.NativeClassPtr))
	{
	}
}

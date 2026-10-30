using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class AwakenSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_awakenedEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_peaceful;

	public unsafe Entity awakenedEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awakenedEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awakenedEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe bool peaceful
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peaceful);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peaceful)) = flag;
		}
	}

	static AwakenSignalParams()
	{
		Il2CppClassPointerStore<AwakenSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AwakenSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwakenSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_awakenedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwakenSignalParams>.NativeClassPtr, "awakenedEntity");
		NativeFieldInfoPtr_peaceful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwakenSignalParams>.NativeClassPtr, "peaceful");
	}

	public AwakenSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AwakenSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwakenSignalParams>.NativeClassPtr))
	{
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class DequeueHarvestingSlotSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_harvesterEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_index;

	public unsafe Entity harvesterEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_harvesterEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_harvesterEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
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

	static DequeueHarvestingSlotSignalParams()
	{
		Il2CppClassPointerStore<DequeueHarvestingSlotSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DequeueHarvestingSlotSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DequeueHarvestingSlotSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_harvesterEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DequeueHarvestingSlotSignalParams>.NativeClassPtr, "harvesterEntity");
		NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DequeueHarvestingSlotSignalParams>.NativeClassPtr, "index");
	}

	public DequeueHarvestingSlotSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DequeueHarvestingSlotSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DequeueHarvestingSlotSignalParams>.NativeClassPtr))
	{
	}
}

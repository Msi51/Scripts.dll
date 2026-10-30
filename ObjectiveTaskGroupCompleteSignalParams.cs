using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ObjectiveTaskGroupCompleteSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_worldPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectiveTaskGroup;

	public unsafe WorldPlayer worldPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPlayer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldPlayer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldPlayer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer));
		}
	}

	public unsafe ObjectiveTaskGroup objectiveTaskGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveTaskGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectiveTaskGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectiveTaskGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectiveTaskGroup));
		}
	}

	static ObjectiveTaskGroupCompleteSignalParams()
	{
		Il2CppClassPointerStore<ObjectiveTaskGroupCompleteSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ObjectiveTaskGroupCompleteSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectiveTaskGroupCompleteSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_worldPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveTaskGroupCompleteSignalParams>.NativeClassPtr, "worldPlayer");
		NativeFieldInfoPtr_objectiveTaskGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveTaskGroupCompleteSignalParams>.NativeClassPtr, "objectiveTaskGroup");
	}

	public ObjectiveTaskGroupCompleteSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ObjectiveTaskGroupCompleteSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectiveTaskGroupCompleteSignalParams>.NativeClassPtr))
	{
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class QueuedObjectActivation : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_chunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_entity;

	public unsafe Chunk chunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunk);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Chunk>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunk)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk));
		}
	}

	public unsafe Entity entity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	static QueuedObjectActivation()
	{
		Il2CppClassPointerStore<QueuedObjectActivation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "QueuedObjectActivation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueuedObjectActivation>.NativeClassPtr);
		NativeFieldInfoPtr_chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedObjectActivation>.NativeClassPtr, "chunk");
		NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedObjectActivation>.NativeClassPtr, "entity");
	}

	public QueuedObjectActivation(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public QueuedObjectActivation()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueuedObjectActivation>.NativeClassPtr))
	{
	}
}

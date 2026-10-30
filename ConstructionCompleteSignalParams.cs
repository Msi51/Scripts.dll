using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ConstructionCompleteSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_builderEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_constructionEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_blueprint;

	private static readonly System.IntPtr NativeFieldInfoPtr_callback;

	public unsafe Entity builderEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builderEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_builderEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

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

	public unsafe Blueprint blueprint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Blueprint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blueprint));
		}
	}

	public unsafe Il2CppSystem.Action<Entity> callback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	static ConstructionCompleteSignalParams()
	{
		Il2CppClassPointerStore<ConstructionCompleteSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConstructionCompleteSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionCompleteSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_builderEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCompleteSignalParams>.NativeClassPtr, "builderEntity");
		NativeFieldInfoPtr_constructionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCompleteSignalParams>.NativeClassPtr, "constructionEntity");
		NativeFieldInfoPtr_blueprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCompleteSignalParams>.NativeClassPtr, "blueprint");
		NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCompleteSignalParams>.NativeClassPtr, "callback");
	}

	public ConstructionCompleteSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ConstructionCompleteSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCompleteSignalParams>.NativeClassPtr))
	{
	}
}

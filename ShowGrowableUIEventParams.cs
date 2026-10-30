using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ShowGrowableUIEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_triggerInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_growableEntity;

	public unsafe IInteraction triggerInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerInteraction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteraction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerInteraction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interaction));
		}
	}

	public unsafe Entity growableEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growableEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growableEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	static ShowGrowableUIEventParams()
	{
		Il2CppClassPointerStore<ShowGrowableUIEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowGrowableUIEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowGrowableUIEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_triggerInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowGrowableUIEventParams>.NativeClassPtr, "triggerInteraction");
		NativeFieldInfoPtr_growableEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowGrowableUIEventParams>.NativeClassPtr, "growableEntity");
	}

	public ShowGrowableUIEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ShowGrowableUIEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowGrowableUIEventParams>.NativeClassPtr))
	{
	}
}

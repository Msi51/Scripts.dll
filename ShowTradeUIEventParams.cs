using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ShowTradeUIEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_targetEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggerInteraction;

	public unsafe Entity targetEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

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

	static ShowTradeUIEventParams()
	{
		Il2CppClassPointerStore<ShowTradeUIEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowTradeUIEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTradeUIEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_targetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTradeUIEventParams>.NativeClassPtr, "targetEntity");
		NativeFieldInfoPtr_triggerInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTradeUIEventParams>.NativeClassPtr, "triggerInteraction");
	}

	public ShowTradeUIEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ShowTradeUIEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTradeUIEventParams>.NativeClassPtr))
	{
	}
}

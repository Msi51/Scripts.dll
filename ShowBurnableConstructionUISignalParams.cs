using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ShowBurnableConstructionUISignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_constructionEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggerInteraction;

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

	static ShowBurnableConstructionUISignalParams()
	{
		Il2CppClassPointerStore<ShowBurnableConstructionUISignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowBurnableConstructionUISignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowBurnableConstructionUISignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_constructionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowBurnableConstructionUISignalParams>.NativeClassPtr, "constructionEntity");
		NativeFieldInfoPtr_triggerInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowBurnableConstructionUISignalParams>.NativeClassPtr, "triggerInteraction");
	}

	public ShowBurnableConstructionUISignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ShowBurnableConstructionUISignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowBurnableConstructionUISignalParams>.NativeClassPtr))
	{
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class ConversationDialogUIClosedSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_closerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_converserTargetEntity;

	public unsafe Entity closerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Entity converserTargetEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converserTargetEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converserTargetEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	static ConversationDialogUIClosedSignalParams()
	{
		Il2CppClassPointerStore<ConversationDialogUIClosedSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConversationDialogUIClosedSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationDialogUIClosedSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_closerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationDialogUIClosedSignalParams>.NativeClassPtr, "closerEntity");
		NativeFieldInfoPtr_converserTargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationDialogUIClosedSignalParams>.NativeClassPtr, "converserTargetEntity");
	}

	public ConversationDialogUIClosedSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ConversationDialogUIClosedSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationDialogUIClosedSignalParams>.NativeClassPtr))
	{
	}
}

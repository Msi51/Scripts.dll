using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public sealed class ChatMessageSentEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_message;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageType;

	public unsafe string message
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_message);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_message)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int messageType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageType)) = num;
		}
	}

	static ChatMessageSentEventParams()
	{
		Il2CppClassPointerStore<ChatMessageSentEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChatMessageSentEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageSentEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSentEventParams>.NativeClassPtr, "message");
		NativeFieldInfoPtr_messageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageSentEventParams>.NativeClassPtr, "messageType");
	}

	public ChatMessageSentEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ChatMessageSentEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageSentEventParams>.NativeClassPtr))
	{
	}
}

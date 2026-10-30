using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public sealed class ChatMessageReceivedEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	public unsafe ChatMessageData data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
			return new ChatMessageData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChatMessageData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chatMessageData)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChatMessageData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static ChatMessageReceivedEventParams()
	{
		Il2CppClassPointerStore<ChatMessageReceivedEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChatMessageReceivedEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageReceivedEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageReceivedEventParams>.NativeClassPtr, "data");
	}

	public ChatMessageReceivedEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ChatMessageReceivedEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageReceivedEventParams>.NativeClassPtr))
	{
	}
}

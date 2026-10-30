using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ChatMessageReceivedEvent : GameEvent<ChatMessageReceivedEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ChatMessageReceivedEventParams_0;

	static ChatMessageReceivedEvent()
	{
		Il2CppClassPointerStore<ChatMessageReceivedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChatMessageReceivedEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageReceivedEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ChatMessageReceivedEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageReceivedEvent>.NativeClassPtr, 100663427);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4091, RefRangeEnd = 4092, XrefRangeStart = 4088, XrefRangeEnd = 4091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChatMessageReceivedEvent(GameEventHandler<ChatMessageReceivedEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageReceivedEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ChatMessageReceivedEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChatMessageReceivedEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

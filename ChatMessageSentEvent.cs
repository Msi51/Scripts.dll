using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ChatMessageSentEvent : GameEvent<ChatMessageSentEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ChatMessageSentEventParams_0;

	static ChatMessageSentEvent()
	{
		Il2CppClassPointerStore<ChatMessageSentEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChatMessageSentEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageSentEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ChatMessageSentEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageSentEvent>.NativeClassPtr, 100663428);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4095, RefRangeEnd = 4096, XrefRangeStart = 4092, XrefRangeEnd = 4095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChatMessageSentEvent(GameEventHandler<ChatMessageSentEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageSentEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ChatMessageSentEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChatMessageSentEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

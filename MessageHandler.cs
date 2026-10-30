using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Netcode;
using Unity.Profiling;

public class MessageHandler<TMessageBody> : Il2CppSystem.Object where TMessageBody : new()
{
	private static readonly System.IntPtr NativeFieldInfoPtr_messagingManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiveMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_sendMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiveCallbackMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkMessageType;

	private static readonly System.IntPtr NativeFieldInfoPtr_channel;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiving;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageDelivery;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastClientMessageSentTimes;

	private static readonly System.IntPtr NativeFieldInfoPtr_writer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Byte_INetworkManager_MessagingManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeReceiveMessage_Protected_Virtual_New_Void_byref_TMessageBody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeMessage_Protected_Virtual_New_Void_Int32_FastBufferReader_byref_TMessageBody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnReceiveMessage_Protected_Abstract_Virtual_New_Void_Int32_byref_TMessageBody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_shouldProcessMessage_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Final_New_Void_Int32_FastBufferReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeMessage_Protected_Virtual_New_Void_byref_TMessageBody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Public_Int32_Int32_TMessageBody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Protected_Int32_Int32_TMessageBody_MessageDelivery_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastMessageSentTime_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LastMessageTimeElapsed_Public_Boolean_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	public unsafe MessagingManager messagingManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messagingManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MessagingManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messagingManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager));
		}
	}

	public unsafe INetworkManager networkManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<INetworkManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager));
		}
	}

	public unsafe ProfilerMarker receiveMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiveMarker);
			return *(ProfilerMarker*)num;
		}
		set
		{
			*(ProfilerMarker*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiveMarker)) = profilerMarker;
		}
	}

	public unsafe ProfilerMarker sendMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sendMarker);
			return *(ProfilerMarker*)num;
		}
		set
		{
			*(ProfilerMarker*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sendMarker)) = profilerMarker;
		}
	}

	public unsafe ProfilerMarker receiveCallbackMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiveCallbackMarker);
			return *(ProfilerMarker*)num;
		}
		set
		{
			*(ProfilerMarker*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiveCallbackMarker)) = profilerMarker;
		}
	}

	public unsafe byte networkMessageType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkMessageType);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkMessageType)) = b;
		}
	}

	public unsafe int channel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channel)) = num;
		}
	}

	public unsafe MessageHandlerReceiving receiving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiving);
			return *(MessageHandlerReceiving*)num;
		}
		set
		{
			*(MessageHandlerReceiving*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiving)) = messageHandlerReceiving;
		}
	}

	public unsafe MessageDelivery messageDelivery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageDelivery);
			return *(MessageDelivery*)num;
		}
		set
		{
			*(MessageDelivery*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageDelivery)) = messageDelivery;
		}
	}

	public unsafe Dictionary<int, float> lastClientMessageSentTimes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastClientMessageSentTimes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastClientMessageSentTimes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe FastBufferWriter writer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer);
			return *(FastBufferWriter*)num;
		}
		set
		{
			*(FastBufferWriter*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer)) = fastBufferWriter;
		}
	}

	static MessageHandler()
	{
		Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Scripts.dll", "", "MessageHandler`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMessageBody>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr);
		NativeFieldInfoPtr_messagingManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "messagingManager");
		NativeFieldInfoPtr_networkManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "networkManager");
		NativeFieldInfoPtr_receiveMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "receiveMarker");
		NativeFieldInfoPtr_sendMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "sendMarker");
		NativeFieldInfoPtr_receiveCallbackMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "receiveCallbackMarker");
		NativeFieldInfoPtr_networkMessageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "networkMessageType");
		NativeFieldInfoPtr_channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "channel");
		NativeFieldInfoPtr_receiving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "receiving");
		NativeFieldInfoPtr_messageDelivery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "messageDelivery");
		NativeFieldInfoPtr_lastClientMessageSentTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "lastClientMessageSentTimes");
		NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, "writer");
		NativeMethodInfoPtr__ctor_Protected_Void_Byte_INetworkManager_MessagingManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664111);
		NativeMethodInfoPtr_InitializeReceiveMessage_Protected_Virtual_New_Void_byref_TMessageBody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664112);
		NativeMethodInfoPtr_DeserializeMessage_Protected_Virtual_New_Void_Int32_FastBufferReader_byref_TMessageBody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664113);
		NativeMethodInfoPtr_OnReceiveMessage_Protected_Abstract_Virtual_New_Void_Int32_byref_TMessageBody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664114);
		NativeMethodInfoPtr_shouldProcessMessage_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664115);
		NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Final_New_Void_Int32_FastBufferReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664116);
		NativeMethodInfoPtr_DisposeMessage_Protected_Virtual_New_Void_byref_TMessageBody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664117);
		NativeMethodInfoPtr_SendMessage_Public_Int32_Int32_TMessageBody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664118);
		NativeMethodInfoPtr_SendMessage_Protected_Int32_Int32_TMessageBody_MessageDelivery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664119);
		NativeMethodInfoPtr_GetLastMessageSentTime_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664120);
		NativeMethodInfoPtr_LastMessageTimeElapsed_Public_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664121);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr, 100664122);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26927, XrefRangeEnd = 26958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageHandler<TMessageBody>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&networkMessageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_Byte_INetworkManager_MessagingManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void InitializeReceiveMessage(ref TMessageBody message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TMessageBody, object>(ref message));
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeReceiveMessage_Protected_Virtual_New_Void_byref_TMessageBody_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TMessageBody, object>(ref message) = ((intPtr4 == (System.IntPtr)0) ? ((TMessageBody)null) : IL2CPP.PointerToValueGeneric<TMessageBody>(intPtr4, false, false));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26959, RefRangeEnd = 26960, XrefRangeStart = 26958, XrefRangeEnd = 26959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void DeserializeMessage(int senderId, FastBufferReader reader, ref TMessageBody message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&senderId);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TMessageBody, object>(ref message));
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DeserializeMessage_Protected_Virtual_New_Void_Int32_FastBufferReader_byref_TMessageBody_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TMessageBody, object>(ref message) = ((intPtr4 == (System.IntPtr)0) ? ((TMessageBody)null) : IL2CPP.PointerToValueGeneric<TMessageBody>(intPtr4, false, false));
	}

	[CallerCount(0)]
	public unsafe virtual void OnReceiveMessage(int senderId, ref TMessageBody message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&senderId);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TMessageBody, object>(ref message));
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnReceiveMessage_Protected_Abstract_Virtual_New_Void_Int32_byref_TMessageBody_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TMessageBody, object>(ref message) = ((intPtr4 == (System.IntPtr)0) ? ((TMessageBody)null) : IL2CPP.PointerToValueGeneric<TMessageBody>(intPtr4, false, false));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26960, XrefRangeEnd = 26961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool shouldProcessMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_shouldProcessMessage_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26961, XrefRangeEnd = 26979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ReceiveMessage(int senderId, FastBufferReader reader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&senderId);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Final_New_Void_Int32_FastBufferReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void DisposeMessage(ref TMessageBody message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TMessageBody, object>(ref message));
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DisposeMessage_Protected_Virtual_New_Void_byref_TMessageBody_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TMessageBody, object>(ref message) = ((intPtr4 == (System.IntPtr)0) ? ((TMessageBody)null) : IL2CPP.PointerToValueGeneric<TMessageBody>(intPtr4, false, false));
	}

	[CallerCount(0)]
	public unsafe int SendMessage(int toClientId, TMessageBody data)
	{
		//IL_005a->IL005d: Incompatible stack types: I vs Ref
		//IL_004d->IL005d: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&toClientId);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TMessageBody reference;
		if (!typeof(TMessageBody).IsValueType)
		{
			object obj = data;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref data;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessage_Public_Int32_Int32_TMessageBody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26979, XrefRangeEnd = 27013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SendMessage(int toClientId, TMessageBody data, MessageDelivery messageDelivery)
	{
		//IL_005a->IL005d: Incompatible stack types: I vs Ref
		//IL_004d->IL005d: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&toClientId);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TMessageBody reference;
		if (!typeof(TMessageBody).IsValueType)
		{
			object obj = data;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref data;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(MessageDelivery**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &messageDelivery;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendMessage_Protected_Int32_Int32_TMessageBody_MessageDelivery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27013, XrefRangeEnd = 27016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLastMessageSentTime(int clientId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&clientId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastMessageSentTime_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 27017, RefRangeEnd = 27019, XrefRangeStart = 27016, XrefRangeEnd = 27017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LastMessageTimeElapsed(int clientId, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&clientId);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LastMessageTimeElapsed_Public_Boolean_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27019, XrefRangeEnd = 27142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MessageHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

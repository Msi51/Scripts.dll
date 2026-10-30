using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ChunkDataReceivedMessageHandler : MessageHandler<ChunkDataReceivedRequest>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_ChunkDataReceivedRequest_0;

	static ChunkDataReceivedMessageHandler()
	{
		Il2CppClassPointerStore<ChunkDataReceivedMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChunkDataReceivedMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkDataReceivedMessageHandler>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataReceivedMessageHandler>.NativeClassPtr, 100663954);
		NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_ChunkDataReceivedRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataReceivedMessageHandler>.NativeClassPtr, 100663955);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25216, RefRangeEnd = 25217, XrefRangeStart = 25213, XrefRangeEnd = 25216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkDataReceivedMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkDataReceivedMessageHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&networkMessageType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25217, XrefRangeEnd = 25222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnReceiveMessage(int senderId, ref ChunkDataReceivedRequest message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&senderId);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref message);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_ChunkDataReceivedRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChunkDataReceivedMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

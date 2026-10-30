using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Unity.Netcode;

public class TerrainAlphamapUpdateMessageHandler : MessageHandler<TerrainAlphamapUpdateMessage>
{
	private static readonly IntPtr NativeFieldInfoPtr_worldManager;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IWorldManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_DeserializeMessage_Protected_Virtual_Void_Int32_FastBufferReader_byref_TerrainAlphamapUpdateMessage_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_TerrainAlphamapUpdateMessage_0;

	public unsafe IWorldManager worldManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IWorldManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldManager));
		}
	}

	static TerrainAlphamapUpdateMessageHandler()
	{
		Il2CppClassPointerStore<TerrainAlphamapUpdateMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TerrainAlphamapUpdateMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainAlphamapUpdateMessageHandler>.NativeClassPtr);
		NativeFieldInfoPtr_worldManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainAlphamapUpdateMessageHandler>.NativeClassPtr, "worldManager");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IWorldManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainAlphamapUpdateMessageHandler>.NativeClassPtr, 100664171);
		NativeMethodInfoPtr_DeserializeMessage_Protected_Virtual_Void_Int32_FastBufferReader_byref_TerrainAlphamapUpdateMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainAlphamapUpdateMessageHandler>.NativeClassPtr, 100664172);
		NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_TerrainAlphamapUpdateMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainAlphamapUpdateMessageHandler>.NativeClassPtr, 100664173);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 27498, RefRangeEnd = 27499, XrefRangeStart = 27494, XrefRangeEnd = 27498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainAlphamapUpdateMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager, IWorldManager worldManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainAlphamapUpdateMessageHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&networkMessageType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IWorldManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27499, XrefRangeEnd = 27526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DeserializeMessage(int senderId, FastBufferReader reader, ref TerrainAlphamapUpdateMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&senderId);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &reader;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DeserializeMessage_Protected_Virtual_Void_Int32_FastBufferReader_byref_TerrainAlphamapUpdateMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnReceiveMessage(int senderId, ref TerrainAlphamapUpdateMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&senderId);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_TerrainAlphamapUpdateMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TerrainAlphamapUpdateMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

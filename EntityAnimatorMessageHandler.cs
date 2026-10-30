using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

public class EntityAnimatorMessageHandler<TComponent> : EntityUpdateMessageHandler<NetworkAnimatorUpdate, TComponent> where TComponent : class
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IEntityManager_MessageHandlerReceiving_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeReceiveMessage_Protected_Virtual_Void_byref_EntityUpdateMessage_1_NetworkAnimatorUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeMessage_Protected_Virtual_Void_byref_EntityUpdateMessage_1_NetworkAnimatorUpdate_0;

	static EntityAnimatorMessageHandler()
	{
		Il2CppClassPointerStore<EntityAnimatorMessageHandler<TComponent>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Scripts.dll", "", "EntityAnimatorMessageHandler`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAnimatorMessageHandler<TComponent>>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IEntityManager_MessageHandlerReceiving_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAnimatorMessageHandler<TComponent>>.NativeClassPtr, 100664019);
		NativeMethodInfoPtr_InitializeReceiveMessage_Protected_Virtual_Void_byref_EntityUpdateMessage_1_NetworkAnimatorUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAnimatorMessageHandler<TComponent>>.NativeClassPtr, 100664020);
		NativeMethodInfoPtr_DisposeMessage_Protected_Virtual_Void_byref_EntityUpdateMessage_1_NetworkAnimatorUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAnimatorMessageHandler<TComponent>>.NativeClassPtr, 100664021);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 26051, RefRangeEnd = 26054, XrefRangeStart = 26051, XrefRangeEnd = 26054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EntityAnimatorMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager, IEntityManager entityManager, MessageHandlerReceiving receiving)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityAnimatorMessageHandler<TComponent>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&networkMessageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityManager);
		*(MessageHandlerReceiving**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &receiving;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IEntityManager_MessageHandlerReceiving_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26067, XrefRangeEnd = 26074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeReceiveMessage(ref EntityUpdateMessage<NetworkAnimatorUpdate> message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeReceiveMessage_Protected_Virtual_Void_byref_EntityUpdateMessage_1_NetworkAnimatorUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26074, XrefRangeEnd = 26080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DisposeMessage(ref EntityUpdateMessage<NetworkAnimatorUpdate> message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DisposeMessage_Protected_Virtual_Void_byref_EntityUpdateMessage_1_NetworkAnimatorUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EntityAnimatorMessageHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

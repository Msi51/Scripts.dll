using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Netcode;

public class EntitySkillSetupMessageHandler<TComponent> : EntityUpdateMessageHandler<NetworkSkillProgressesUpdate, TComponent> where TComponent : class
{
	private static readonly System.IntPtr NativeFieldInfoPtr_skillsManager;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IEntityManager_ISkillsManager_MessageHandlerReceiving_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeMessage_Protected_Virtual_Void_Int32_FastBufferReader_byref_EntityUpdateMessage_1_NetworkSkillProgressesUpdate_0;

	public unsafe ISkillsManager skillsManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillsManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISkillsManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillsManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillsManager));
		}
	}

	static EntitySkillSetupMessageHandler()
	{
		Il2CppClassPointerStore<EntitySkillSetupMessageHandler<TComponent>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Scripts.dll", "", "EntitySkillSetupMessageHandler`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitySkillSetupMessageHandler<TComponent>>.NativeClassPtr);
		NativeFieldInfoPtr_skillsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkillSetupMessageHandler<TComponent>>.NativeClassPtr, "skillsManager");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IEntityManager_ISkillsManager_MessageHandlerReceiving_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitySkillSetupMessageHandler<TComponent>>.NativeClassPtr, 100664033);
		NativeMethodInfoPtr_DeserializeMessage_Protected_Virtual_Void_Int32_FastBufferReader_byref_EntityUpdateMessage_1_NetworkSkillProgressesUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitySkillSetupMessageHandler<TComponent>>.NativeClassPtr, 100664034);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 26081, RefRangeEnd = 26087, XrefRangeStart = 26081, XrefRangeEnd = 26087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EntitySkillSetupMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager, IEntityManager entityManager, ISkillsManager skillsManager, MessageHandlerReceiving receiving)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntitySkillSetupMessageHandler<TComponent>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&networkMessageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillsManager);
		*(MessageHandlerReceiving**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &receiving;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IEntityManager_ISkillsManager_MessageHandlerReceiving_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26203, XrefRangeEnd = 26219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DeserializeMessage(int senderId, FastBufferReader reader, ref EntityUpdateMessage<NetworkSkillProgressesUpdate> message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&senderId);
		*(FastBufferReader**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reader;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DeserializeMessage_Protected_Virtual_Void_Int32_FastBufferReader_byref_EntityUpdateMessage_1_NetworkSkillProgressesUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EntitySkillSetupMessageHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

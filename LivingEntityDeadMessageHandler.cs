using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class LivingEntityDeadMessageHandler : MessageHandler<LivingEntityDeadMessage>
{
	private static readonly IntPtr NativeFieldInfoPtr_entityManager;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IEntityManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_LivingEntityDeadMessage_0;

	public unsafe IEntityManager entityManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEntityManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityManager));
		}
	}

	static LivingEntityDeadMessageHandler()
	{
		Il2CppClassPointerStore<LivingEntityDeadMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "LivingEntityDeadMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LivingEntityDeadMessageHandler>.NativeClassPtr);
		NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LivingEntityDeadMessageHandler>.NativeClassPtr, "entityManager");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LivingEntityDeadMessageHandler>.NativeClassPtr, 100664109);
		NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_LivingEntityDeadMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LivingEntityDeadMessageHandler>.NativeClassPtr, 100664110);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26917, RefRangeEnd = 26918, XrefRangeStart = 26913, XrefRangeEnd = 26917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LivingEntityDeadMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager, IEntityManager entityManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LivingEntityDeadMessageHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&networkMessageType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26918, XrefRangeEnd = 26927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnReceiveMessage(int senderId, ref LivingEntityDeadMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&senderId);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref message);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_LivingEntityDeadMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LivingEntityDeadMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

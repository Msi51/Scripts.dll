using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class EndInteractionMessageHandler : MessageHandler<EndInteractionMessage>
{
	private static readonly IntPtr NativeFieldInfoPtr_interactionManager;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IInteractionManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_EndInteractionMessage_0;

	public unsafe IInteractionManager interactionManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInteractionManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionManager));
		}
	}

	static EndInteractionMessageHandler()
	{
		Il2CppClassPointerStore<EndInteractionMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EndInteractionMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndInteractionMessageHandler>.NativeClassPtr);
		NativeFieldInfoPtr_interactionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndInteractionMessageHandler>.NativeClassPtr, "interactionManager");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IInteractionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndInteractionMessageHandler>.NativeClassPtr, 100664000);
		NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_EndInteractionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndInteractionMessageHandler>.NativeClassPtr, 100664001);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25782, RefRangeEnd = 25783, XrefRangeStart = 25778, XrefRangeEnd = 25782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EndInteractionMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager, IInteractionManager interactionManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndInteractionMessageHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&networkMessageType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_IInteractionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25783, XrefRangeEnd = 25787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnReceiveMessage(int senderId, ref EndInteractionMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&senderId);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref message);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnReceiveMessage_Protected_Virtual_Void_Int32_byref_EndInteractionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EndInteractionMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

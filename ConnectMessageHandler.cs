using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ConnectMessageHandler : BasicTwoWayMessageHandler<ConnectMessageRequest, ConnectMessageResponse>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Protected_Virtual_ConnectMessageResponse_0;

	static ConnectMessageHandler()
	{
		Il2CppClassPointerStore<ConnectMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConnectMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectMessageHandler>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectMessageHandler>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr_GetResponse_Protected_Virtual_ConnectMessageResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectMessageHandler>.NativeClassPtr, 100663982);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25656, RefRangeEnd = 25657, XrefRangeStart = 25653, XrefRangeEnd = 25656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConnectMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectMessageHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&networkMessageType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override ConnectMessageResponse GetResponse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResponse_Protected_Virtual_ConnectMessageResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ConnectMessageResponse*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ConnectMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

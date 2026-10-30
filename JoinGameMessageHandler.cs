using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class JoinGameMessageHandler : BasicTwoWayMessageHandler<JoinGameMessageRequest, JoinGameMessageResponse>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Protected_Virtual_JoinGameMessageResponse_0;

	static JoinGameMessageHandler()
	{
		Il2CppClassPointerStore<JoinGameMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "JoinGameMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinGameMessageHandler>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinGameMessageHandler>.NativeClassPtr, 100664105);
		NativeMethodInfoPtr_GetResponse_Protected_Virtual_JoinGameMessageResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinGameMessageHandler>.NativeClassPtr, 100664106);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26897, RefRangeEnd = 26898, XrefRangeStart = 26894, XrefRangeEnd = 26897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JoinGameMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinGameMessageHandler>.NativeClassPtr))
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26898, XrefRangeEnd = 26913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override JoinGameMessageResponse GetResponse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResponse_Protected_Virtual_JoinGameMessageResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new JoinGameMessageResponse(pointer);
	}

	public JoinGameMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class FinishLoadMessageHandler : BasicTwoWayMessageHandler<FinishLoadMessageRequest, FinishLoadMessageResponse>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0;

	static FinishLoadMessageHandler()
	{
		Il2CppClassPointerStore<FinishLoadMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FinishLoadMessageHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinishLoadMessageHandler>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLoadMessageHandler>.NativeClassPtr, 100664048);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26329, RefRangeEnd = 26330, XrefRangeStart = 26326, XrefRangeEnd = 26329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FinishLoadMessageHandler(byte networkMessageType, INetworkManager networkManager, MessagingManager messagingManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinishLoadMessageHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&networkMessageType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messagingManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_INetworkManager_MessagingManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FinishLoadMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

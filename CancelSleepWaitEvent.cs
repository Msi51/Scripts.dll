using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CancelSleepWaitEvent : NetworkedGameEvent<CancelSleepWaitEventParams, CancelSleepWaitEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CancelSleepWaitEventParams_CancelSleepWaitEventResult_INetworkManager_0;

	static CancelSleepWaitEvent()
	{
		Il2CppClassPointerStore<CancelSleepWaitEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CancelSleepWaitEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancelSleepWaitEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CancelSleepWaitEventParams_CancelSleepWaitEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelSleepWaitEvent>.NativeClassPtr, 100663426);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4087, RefRangeEnd = 4088, XrefRangeStart = 4084, XrefRangeEnd = 4087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CancelSleepWaitEvent(NetworkedGameEventHandler<CancelSleepWaitEventParams, CancelSleepWaitEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancelSleepWaitEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CancelSleepWaitEventParams_CancelSleepWaitEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CancelSleepWaitEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

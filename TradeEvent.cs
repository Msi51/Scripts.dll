using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class TradeEvent : NetworkedGameEvent<TradeEventParams, TradeEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_TradeEventParams_TradeEventResult_INetworkManager_0;

	static TradeEvent()
	{
		Il2CppClassPointerStore<TradeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TradeEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TradeEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_TradeEventParams_TradeEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TradeEvent>.NativeClassPtr, 100670375);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119159, RefRangeEnd = 119160, XrefRangeStart = 119156, XrefRangeEnd = 119159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TradeEvent(NetworkedGameEventHandler<TradeEventParams, TradeEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TradeEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_TradeEventParams_TradeEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TradeEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

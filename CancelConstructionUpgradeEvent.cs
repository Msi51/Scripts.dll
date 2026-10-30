using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CancelConstructionUpgradeEvent : NetworkedGameEvent<CancelConstructionUpgradeEventParams, CancelConstructionUpgradeEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CancelConstructionUpgradeEventParams_CancelConstructionUpgradeEventResult_INetworkManager_0;

	static CancelConstructionUpgradeEvent()
	{
		Il2CppClassPointerStore<CancelConstructionUpgradeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CancelConstructionUpgradeEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancelConstructionUpgradeEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CancelConstructionUpgradeEventParams_CancelConstructionUpgradeEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelConstructionUpgradeEvent>.NativeClassPtr, 100663423);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4082, RefRangeEnd = 4083, XrefRangeStart = 4079, XrefRangeEnd = 4082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CancelConstructionUpgradeEvent(NetworkedGameEventHandler<CancelConstructionUpgradeEventParams, CancelConstructionUpgradeEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancelConstructionUpgradeEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CancelConstructionUpgradeEventParams_CancelConstructionUpgradeEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CancelConstructionUpgradeEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

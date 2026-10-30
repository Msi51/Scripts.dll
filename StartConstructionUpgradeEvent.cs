using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class StartConstructionUpgradeEvent : NetworkedGameEvent<StartConstructionUpgradeEventParams, StartConstructionUpgradeEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartConstructionUpgradeEventParams_StartConstructionUpgradeEventResult_INetworkManager_0;

	static StartConstructionUpgradeEvent()
	{
		Il2CppClassPointerStore<StartConstructionUpgradeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartConstructionUpgradeEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartConstructionUpgradeEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartConstructionUpgradeEventParams_StartConstructionUpgradeEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionUpgradeEvent>.NativeClassPtr, 100663503);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4404, RefRangeEnd = 4405, XrefRangeStart = 4401, XrefRangeEnd = 4404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartConstructionUpgradeEvent(NetworkedGameEventHandler<StartConstructionUpgradeEventParams, StartConstructionUpgradeEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartConstructionUpgradeEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartConstructionUpgradeEventParams_StartConstructionUpgradeEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartConstructionUpgradeEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

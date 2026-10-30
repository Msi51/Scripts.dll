using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class SetupStockpileEvent : NetworkedGameEvent<SetupStockpileEventParams, SetupStockpileEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_SetupStockpileEventParams_SetupStockpileEventResult_INetworkManager_0;

	static SetupStockpileEvent()
	{
		Il2CppClassPointerStore<SetupStockpileEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SetupStockpileEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupStockpileEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_SetupStockpileEventParams_SetupStockpileEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupStockpileEvent>.NativeClassPtr, 100670179);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115297, RefRangeEnd = 115298, XrefRangeStart = 115294, XrefRangeEnd = 115297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SetupStockpileEvent(NetworkedGameEventHandler<SetupStockpileEventParams, SetupStockpileEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupStockpileEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_SetupStockpileEventParams_SetupStockpileEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SetupStockpileEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

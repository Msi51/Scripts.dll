using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class AddItemsToStockpileEvent : NetworkedGameEvent<AddItemsToStockpileEventParams, AddItemsToStockpileEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddItemsToStockpileEventParams_AddItemsToStockpileEventResult_INetworkManager_0;

	static AddItemsToStockpileEvent()
	{
		Il2CppClassPointerStore<AddItemsToStockpileEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AddItemsToStockpileEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddItemsToStockpileEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddItemsToStockpileEventParams_AddItemsToStockpileEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddItemsToStockpileEvent>.NativeClassPtr, 100663411);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4064, RefRangeEnd = 4065, XrefRangeStart = 4061, XrefRangeEnd = 4064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddItemsToStockpileEvent(NetworkedGameEventHandler<AddItemsToStockpileEventParams, AddItemsToStockpileEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddItemsToStockpileEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddItemsToStockpileEventParams_AddItemsToStockpileEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AddItemsToStockpileEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

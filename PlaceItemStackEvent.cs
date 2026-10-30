using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class PlaceItemStackEvent : NetworkedGameEvent<PlaceItemStackEventParams, PlaceItemStackEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_PlaceItemStackEventParams_PlaceItemStackEventResult_INetworkManager_0;

	static PlaceItemStackEvent()
	{
		Il2CppClassPointerStore<PlaceItemStackEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlaceItemStackEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceItemStackEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_PlaceItemStackEventParams_PlaceItemStackEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceItemStackEvent>.NativeClassPtr, 100663471);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4308, RefRangeEnd = 4309, XrefRangeStart = 4305, XrefRangeEnd = 4308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlaceItemStackEvent(NetworkedGameEventHandler<PlaceItemStackEventParams, PlaceItemStackEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceItemStackEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_PlaceItemStackEventParams_PlaceItemStackEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlaceItemStackEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

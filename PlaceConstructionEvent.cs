using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class PlaceConstructionEvent : NetworkedGameEvent<PlaceConstructionEventParams, PlaceConstructionEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_PlaceConstructionEventParams_PlaceConstructionEventResult_INetworkManager_0;

	static PlaceConstructionEvent()
	{
		Il2CppClassPointerStore<PlaceConstructionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlaceConstructionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceConstructionEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_PlaceConstructionEventParams_PlaceConstructionEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceConstructionEvent>.NativeClassPtr, 100663468);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4296, RefRangeEnd = 4297, XrefRangeStart = 4293, XrefRangeEnd = 4296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlaceConstructionEvent(NetworkedGameEventHandler<PlaceConstructionEventParams, PlaceConstructionEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceConstructionEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_PlaceConstructionEventParams_PlaceConstructionEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlaceConstructionEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class RemovePlayerMarkerEvent : NetworkedGameEvent<RemovePlayerMarkerEventParams, RemovePlayerMarkerEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_RemovePlayerMarkerEventParams_RemovePlayerMarkerEventResult_INetworkManager_0;

	static RemovePlayerMarkerEvent()
	{
		Il2CppClassPointerStore<RemovePlayerMarkerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RemovePlayerMarkerEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemovePlayerMarkerEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_RemovePlayerMarkerEventParams_RemovePlayerMarkerEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemovePlayerMarkerEvent>.NativeClassPtr, 100663483);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4336, RefRangeEnd = 4337, XrefRangeStart = 4333, XrefRangeEnd = 4336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RemovePlayerMarkerEvent(NetworkedGameEventHandler<RemovePlayerMarkerEventParams, RemovePlayerMarkerEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemovePlayerMarkerEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_RemovePlayerMarkerEventParams_RemovePlayerMarkerEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RemovePlayerMarkerEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

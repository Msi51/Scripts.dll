using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class SortInventoryEvent : NetworkedGameEvent<SortInventoryEventParams, SortInventoryEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_SortInventoryEventParams_SortInventoryEventResult_INetworkManager_0;

	static SortInventoryEvent()
	{
		Il2CppClassPointerStore<SortInventoryEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SortInventoryEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortInventoryEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_SortInventoryEventParams_SortInventoryEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortInventoryEvent>.NativeClassPtr, 100663499);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4390, RefRangeEnd = 4391, XrefRangeStart = 4387, XrefRangeEnd = 4390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SortInventoryEvent(NetworkedGameEventHandler<SortInventoryEventParams, SortInventoryEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortInventoryEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_SortInventoryEventParams_SortInventoryEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SortInventoryEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class AddItemsToSoakerEvent : NetworkedGameEvent<AddItemsToSoakerEventParams, AddItemsToSoakerEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddItemsToSoakerEventParams_AddItemsToSoakerEventResult_INetworkManager_0;

	static AddItemsToSoakerEvent()
	{
		Il2CppClassPointerStore<AddItemsToSoakerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AddItemsToSoakerEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddItemsToSoakerEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddItemsToSoakerEventParams_AddItemsToSoakerEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddItemsToSoakerEvent>.NativeClassPtr, 100663408);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4058, RefRangeEnd = 4059, XrefRangeStart = 4055, XrefRangeEnd = 4058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddItemsToSoakerEvent(NetworkedGameEventHandler<AddItemsToSoakerEventParams, AddItemsToSoakerEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddItemsToSoakerEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddItemsToSoakerEventParams_AddItemsToSoakerEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AddItemsToSoakerEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class AddFertilizerEvent : NetworkedGameEvent<AddFertilizerEventParams, AddFertilizerEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddFertilizerEventParams_AddFertilizerEventResult_INetworkManager_0;

	static AddFertilizerEvent()
	{
		Il2CppClassPointerStore<AddFertilizerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AddFertilizerEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddFertilizerEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddFertilizerEventParams_AddFertilizerEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFertilizerEvent>.NativeClassPtr, 100663402);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4050, RefRangeEnd = 4051, XrefRangeStart = 4047, XrefRangeEnd = 4050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddFertilizerEvent(NetworkedGameEventHandler<AddFertilizerEventParams, AddFertilizerEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddFertilizerEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddFertilizerEventParams_AddFertilizerEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AddFertilizerEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

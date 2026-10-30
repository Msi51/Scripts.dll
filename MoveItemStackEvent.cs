using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class MoveItemStackEvent : NetworkedGameEvent<MoveItemStackEventParams, MoveItemStackEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_MoveItemStackEventParams_MoveItemStackEventResult_INetworkManager_0;

	static MoveItemStackEvent()
	{
		Il2CppClassPointerStore<MoveItemStackEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MoveItemStackEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemStackEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_MoveItemStackEventParams_MoveItemStackEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemStackEvent>.NativeClassPtr, 100670085);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112956, RefRangeEnd = 112957, XrefRangeStart = 112953, XrefRangeEnd = 112956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MoveItemStackEvent(NetworkedGameEventHandler<MoveItemStackEventParams, MoveItemStackEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemStackEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_MoveItemStackEventParams_MoveItemStackEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MoveItemStackEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

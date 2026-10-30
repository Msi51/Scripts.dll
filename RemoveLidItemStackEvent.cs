using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class RemoveLidItemStackEvent : NetworkedGameEvent<RemoveLidItemStackEventParams, RemoveLidItemStackEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_RemoveLidItemStackEventParams_RemoveLidItemStackEventResult_INetworkManager_0;

	static RemoveLidItemStackEvent()
	{
		Il2CppClassPointerStore<RemoveLidItemStackEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RemoveLidItemStackEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveLidItemStackEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_RemoveLidItemStackEventParams_RemoveLidItemStackEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLidItemStackEvent>.NativeClassPtr, 100663480);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4332, RefRangeEnd = 4333, XrefRangeStart = 4329, XrefRangeEnd = 4332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RemoveLidItemStackEvent(NetworkedGameEventHandler<RemoveLidItemStackEventParams, RemoveLidItemStackEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveLidItemStackEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_RemoveLidItemStackEventParams_RemoveLidItemStackEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RemoveLidItemStackEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

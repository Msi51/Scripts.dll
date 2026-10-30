using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ConsoleCommandEvent : NetworkedGameEvent<ConsoleCommandEventParams, ConsoleCommandEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_ConsoleCommandEventParams_ConsoleCommandEventResult_INetworkManager_0;

	static ConsoleCommandEvent()
	{
		Il2CppClassPointerStore<ConsoleCommandEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConsoleCommandEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleCommandEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_ConsoleCommandEventParams_ConsoleCommandEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCommandEvent>.NativeClassPtr, 100663431);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4104, RefRangeEnd = 4105, XrefRangeStart = 4101, XrefRangeEnd = 4104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConsoleCommandEvent(NetworkedGameEventHandler<ConsoleCommandEventParams, ConsoleCommandEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCommandEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_ConsoleCommandEventParams_ConsoleCommandEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ConsoleCommandEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

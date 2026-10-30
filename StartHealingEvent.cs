using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class StartHealingEvent : NetworkedGameEvent<StartHealingEventParams, StartHealingEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartHealingEventParams_StartHealingEventResult_INetworkManager_0;

	static StartHealingEvent()
	{
		Il2CppClassPointerStore<StartHealingEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartHealingEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartHealingEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartHealingEventParams_StartHealingEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartHealingEvent>.NativeClassPtr, 100663513);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4434, RefRangeEnd = 4435, XrefRangeStart = 4431, XrefRangeEnd = 4434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartHealingEvent(NetworkedGameEventHandler<StartHealingEventParams, StartHealingEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartHealingEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartHealingEventParams_StartHealingEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartHealingEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class StartSanitizingEvent : NetworkedGameEvent<StartSanitizingEventParams, StartSanitizingEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartSanitizingEventParams_StartSanitizingEventResult_INetworkManager_0;

	static StartSanitizingEvent()
	{
		Il2CppClassPointerStore<StartSanitizingEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartSanitizingEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartSanitizingEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartSanitizingEventParams_StartSanitizingEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartSanitizingEvent>.NativeClassPtr, 100663509);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4419, RefRangeEnd = 4420, XrefRangeStart = 4416, XrefRangeEnd = 4419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartSanitizingEvent(NetworkedGameEventHandler<StartSanitizingEventParams, StartSanitizingEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartSanitizingEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartSanitizingEventParams_StartSanitizingEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartSanitizingEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class StartCauterizingEvent : NetworkedGameEvent<StartCauterizingEventParams, StartCauterizingEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartCauterizingEventParams_StartCauterizingEventResult_INetworkManager_0;

	static StartCauterizingEvent()
	{
		Il2CppClassPointerStore<StartCauterizingEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartCauterizingEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartCauterizingEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartCauterizingEventParams_StartCauterizingEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartCauterizingEvent>.NativeClassPtr, 100670335);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118565, RefRangeEnd = 118566, XrefRangeStart = 118562, XrefRangeEnd = 118565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartCauterizingEvent(NetworkedGameEventHandler<StartCauterizingEventParams, StartCauterizingEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartCauterizingEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartCauterizingEventParams_StartCauterizingEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartCauterizingEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

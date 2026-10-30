using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class StartIgnitingEvent : NetworkedGameEvent<StartIgnitingEventParams, StartIgnitingEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartIgnitingEventParams_StartIgnitingEventResult_INetworkManager_0;

	static StartIgnitingEvent()
	{
		Il2CppClassPointerStore<StartIgnitingEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartIgnitingEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartIgnitingEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartIgnitingEventParams_StartIgnitingEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartIgnitingEvent>.NativeClassPtr, 100663516);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4438, RefRangeEnd = 4439, XrefRangeStart = 4435, XrefRangeEnd = 4438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartIgnitingEvent(NetworkedGameEventHandler<StartIgnitingEventParams, StartIgnitingEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartIgnitingEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_StartIgnitingEventParams_StartIgnitingEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartIgnitingEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

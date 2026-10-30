using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class SkipTaskGroupEvent : NetworkedGameEvent<SkipTaskGroupEventParams, SkipTaskGroupEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_SkipTaskGroupEventParams_SkipTaskGroupEventResult_INetworkManager_0;

	static SkipTaskGroupEvent()
	{
		Il2CppClassPointerStore<SkipTaskGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SkipTaskGroupEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkipTaskGroupEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_SkipTaskGroupEventParams_SkipTaskGroupEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipTaskGroupEvent>.NativeClassPtr, 100663496);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4383, RefRangeEnd = 4384, XrefRangeStart = 4380, XrefRangeEnd = 4383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkipTaskGroupEvent(NetworkedGameEventHandler<SkipTaskGroupEventParams, SkipTaskGroupEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkipTaskGroupEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_SkipTaskGroupEventParams_SkipTaskGroupEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkipTaskGroupEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

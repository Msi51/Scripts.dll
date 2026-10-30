using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CancelConstructionEvent : NetworkedGameEvent<CancelConstructionEventParams, CancelConstructionEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CancelConstructionEventParams_CancelConstructionEventResult_INetworkManager_0;

	static CancelConstructionEvent()
	{
		Il2CppClassPointerStore<CancelConstructionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CancelConstructionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancelConstructionEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CancelConstructionEventParams_CancelConstructionEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelConstructionEvent>.NativeClassPtr, 100663420);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4078, RefRangeEnd = 4079, XrefRangeStart = 4075, XrefRangeEnd = 4078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CancelConstructionEvent(NetworkedGameEventHandler<CancelConstructionEventParams, CancelConstructionEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancelConstructionEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CancelConstructionEventParams_CancelConstructionEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CancelConstructionEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class TakeSoakerSubstanceEvent : NetworkedGameEvent<TakeSoakerSubstanceEventParams, TakeSoakerSubstanceEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_TakeSoakerSubstanceEventParams_TakeSoakerSubstanceEventResult_INetworkManager_0;

	static TakeSoakerSubstanceEvent()
	{
		Il2CppClassPointerStore<TakeSoakerSubstanceEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TakeSoakerSubstanceEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakeSoakerSubstanceEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_TakeSoakerSubstanceEventParams_TakeSoakerSubstanceEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakeSoakerSubstanceEvent>.NativeClassPtr, 100663519);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4442, RefRangeEnd = 4443, XrefRangeStart = 4439, XrefRangeEnd = 4442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TakeSoakerSubstanceEvent(NetworkedGameEventHandler<TakeSoakerSubstanceEventParams, TakeSoakerSubstanceEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TakeSoakerSubstanceEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_TakeSoakerSubstanceEventParams_TakeSoakerSubstanceEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TakeSoakerSubstanceEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

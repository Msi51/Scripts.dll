using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class DiscardDistillerSubstanceEvent : NetworkedGameEvent<DiscardDistillerSubstanceEventParams, DiscardDistillerSubstanceEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_DiscardDistillerSubstanceEventParams_DiscardDistillerSubstanceEventResult_INetworkManager_0;

	static DiscardDistillerSubstanceEvent()
	{
		Il2CppClassPointerStore<DiscardDistillerSubstanceEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DiscardDistillerSubstanceEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscardDistillerSubstanceEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_DiscardDistillerSubstanceEventParams_DiscardDistillerSubstanceEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscardDistillerSubstanceEvent>.NativeClassPtr, 100663448);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4161, RefRangeEnd = 4162, XrefRangeStart = 4158, XrefRangeEnd = 4161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscardDistillerSubstanceEvent(NetworkedGameEventHandler<DiscardDistillerSubstanceEventParams, DiscardDistillerSubstanceEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscardDistillerSubstanceEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_DiscardDistillerSubstanceEventParams_DiscardDistillerSubstanceEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DiscardDistillerSubstanceEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

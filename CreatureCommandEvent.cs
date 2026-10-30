using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CreatureCommandEvent : NetworkedGameEvent<CreatureCommandEventParams, CreatureCommandEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CreatureCommandEventParams_CreatureCommandEventResult_INetworkManager_0;

	static CreatureCommandEvent()
	{
		Il2CppClassPointerStore<CreatureCommandEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreatureCommandEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatureCommandEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CreatureCommandEventParams_CreatureCommandEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureCommandEvent>.NativeClassPtr, 100663438);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4126, RefRangeEnd = 4127, XrefRangeStart = 4123, XrefRangeEnd = 4126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreatureCommandEvent(NetworkedGameEventHandler<CreatureCommandEventParams, CreatureCommandEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatureCommandEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_CreatureCommandEventParams_CreatureCommandEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreatureCommandEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

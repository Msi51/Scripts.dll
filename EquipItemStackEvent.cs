using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class EquipItemStackEvent : NetworkedGameEvent<EquipItemStackEventParams, EquipItemStackEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_EquipItemStackEventParams_EquipItemStackEventResult_INetworkManager_0;

	static EquipItemStackEvent()
	{
		Il2CppClassPointerStore<EquipItemStackEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EquipItemStackEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipItemStackEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_EquipItemStackEventParams_EquipItemStackEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemStackEvent>.NativeClassPtr, 100670020);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111862, RefRangeEnd = 111863, XrefRangeStart = 111859, XrefRangeEnd = 111862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EquipItemStackEvent(NetworkedGameEventHandler<EquipItemStackEventParams, EquipItemStackEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipItemStackEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_EquipItemStackEventParams_EquipItemStackEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EquipItemStackEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

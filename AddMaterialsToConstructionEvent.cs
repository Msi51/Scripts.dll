using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class AddMaterialsToConstructionEvent : NetworkedGameEvent<AddMaterialsToConstructionEventParams, AddMaterialsToConstructionEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddMaterialsToConstructionEventParams_AddMaterialsToConstructionEventResult_INetworkManager_0;

	static AddMaterialsToConstructionEvent()
	{
		Il2CppClassPointerStore<AddMaterialsToConstructionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AddMaterialsToConstructionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddMaterialsToConstructionEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddMaterialsToConstructionEventParams_AddMaterialsToConstructionEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddMaterialsToConstructionEvent>.NativeClassPtr, 100663414);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4068, RefRangeEnd = 4069, XrefRangeStart = 4065, XrefRangeEnd = 4068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddMaterialsToConstructionEvent(NetworkedGameEventHandler<AddMaterialsToConstructionEventParams, AddMaterialsToConstructionEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddMaterialsToConstructionEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_AddMaterialsToConstructionEventParams_AddMaterialsToConstructionEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AddMaterialsToConstructionEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class EmptyItemStackEvent : NetworkedGameEvent<EmptyItemStackEventParams, EmptyItemStackEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_EmptyItemStackEventParams_EmptyItemStackEventResult_INetworkManager_0;

	static EmptyItemStackEvent()
	{
		Il2CppClassPointerStore<EmptyItemStackEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EmptyItemStackEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyItemStackEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_EmptyItemStackEventParams_EmptyItemStackEventResult_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmptyItemStackEvent>.NativeClassPtr, 100670000);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111448, RefRangeEnd = 111449, XrefRangeStart = 111445, XrefRangeEnd = 111448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EmptyItemStackEvent(NetworkedGameEventHandler<EmptyItemStackEventParams, EmptyItemStackEventResult> handler, INetworkManager networkManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmptyItemStackEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NetworkedGameEventHandler_2_EmptyItemStackEventParams_EmptyItemStackEventResult_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EmptyItemStackEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

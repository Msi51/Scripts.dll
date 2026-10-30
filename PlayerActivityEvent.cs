using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class PlayerActivityEvent : GameEvent<PlayerActivityEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PlayerActivityEventParams_0;

	static PlayerActivityEvent()
	{
		Il2CppClassPointerStore<PlayerActivityEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlayerActivityEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerActivityEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PlayerActivityEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActivityEvent>.NativeClassPtr, 100663475);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4320, RefRangeEnd = 4321, XrefRangeStart = 4317, XrefRangeEnd = 4320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerActivityEvent(GameEventHandler<PlayerActivityEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerActivityEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PlayerActivityEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlayerActivityEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

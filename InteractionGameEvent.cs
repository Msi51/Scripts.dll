using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class InteractionGameEvent : GameEvent<InteractionEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_InteractionEventParams_0;

	static InteractionGameEvent()
	{
		Il2CppClassPointerStore<InteractionGameEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InteractionGameEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionGameEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_InteractionEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionGameEvent>.NativeClassPtr, 100670060);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112498, RefRangeEnd = 112499, XrefRangeStart = 112495, XrefRangeEnd = 112498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractionGameEvent(GameEventHandler<InteractionEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionGameEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_InteractionEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InteractionGameEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

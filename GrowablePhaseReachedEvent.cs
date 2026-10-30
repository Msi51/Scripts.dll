using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class GrowablePhaseReachedEvent : GameEvent<GrowablePhaseReachedEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_GrowablePhaseReachedEventParams_0;

	static GrowablePhaseReachedEvent()
	{
		Il2CppClassPointerStore<GrowablePhaseReachedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GrowablePhaseReachedEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowablePhaseReachedEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_GrowablePhaseReachedEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowablePhaseReachedEvent>.NativeClassPtr, 100663457);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4191, RefRangeEnd = 4192, XrefRangeStart = 4188, XrefRangeEnd = 4191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GrowablePhaseReachedEvent(GameEventHandler<GrowablePhaseReachedEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowablePhaseReachedEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_GrowablePhaseReachedEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GrowablePhaseReachedEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class SpeedupCancelledEvent : GameEvent<SpeedupCancelledEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_SpeedupCancelledEventParams_0;

	static SpeedupCancelledEvent()
	{
		Il2CppClassPointerStore<SpeedupCancelledEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SpeedupCancelledEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeedupCancelledEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_SpeedupCancelledEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeedupCancelledEvent>.NativeClassPtr, 100663500);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4394, RefRangeEnd = 4395, XrefRangeStart = 4391, XrefRangeEnd = 4394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpeedupCancelledEvent(GameEventHandler<SpeedupCancelledEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeedupCancelledEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_SpeedupCancelledEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SpeedupCancelledEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

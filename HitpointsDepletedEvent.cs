using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class HitpointsDepletedEvent : GameEvent<HitpointsDepletedEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_HitpointsDepletedEventParams_0;

	static HitpointsDepletedEvent()
	{
		Il2CppClassPointerStore<HitpointsDepletedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HitpointsDepletedEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitpointsDepletedEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_HitpointsDepletedEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitpointsDepletedEvent>.NativeClassPtr, 100663458);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4195, RefRangeEnd = 4196, XrefRangeStart = 4192, XrefRangeEnd = 4195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HitpointsDepletedEvent(GameEventHandler<HitpointsDepletedEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HitpointsDepletedEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_HitpointsDepletedEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HitpointsDepletedEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

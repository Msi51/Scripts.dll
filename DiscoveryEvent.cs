using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class DiscoveryEvent : GameEvent<DiscoveryEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DiscoveryEventParams_0;

	static DiscoveryEvent()
	{
		Il2CppClassPointerStore<DiscoveryEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DiscoveryEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscoveryEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DiscoveryEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryEvent>.NativeClassPtr, 100663449);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4165, RefRangeEnd = 4166, XrefRangeStart = 4162, XrefRangeEnd = 4165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscoveryEvent(GameEventHandler<DiscoveryEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscoveryEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DiscoveryEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DiscoveryEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

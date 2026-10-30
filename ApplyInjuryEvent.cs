using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ApplyInjuryEvent : GameEvent<ApplyInjuryEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ApplyInjuryEventParams_0;

	static ApplyInjuryEvent()
	{
		Il2CppClassPointerStore<ApplyInjuryEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ApplyInjuryEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyInjuryEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ApplyInjuryEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyInjuryEvent>.NativeClassPtr, 100669913);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108379, RefRangeEnd = 108380, XrefRangeStart = 108376, XrefRangeEnd = 108379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ApplyInjuryEvent(GameEventHandler<ApplyInjuryEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplyInjuryEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ApplyInjuryEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ApplyInjuryEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

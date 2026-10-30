using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class FallDamageEvent : GameEvent<FallDamageEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_FallDamageEventParams_0;

	static FallDamageEvent()
	{
		Il2CppClassPointerStore<FallDamageEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FallDamageEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallDamageEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_FallDamageEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallDamageEvent>.NativeClassPtr, 100663454);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4179, RefRangeEnd = 4180, XrefRangeStart = 4176, XrefRangeEnd = 4179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FallDamageEvent(GameEventHandler<FallDamageEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallDamageEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_FallDamageEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FallDamageEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

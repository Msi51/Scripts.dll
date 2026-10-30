using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class InjuryAppliedEvent : GameEvent<InjuryAppliedEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_InjuryAppliedEventParams_0;

	static InjuryAppliedEvent()
	{
		Il2CppClassPointerStore<InjuryAppliedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InjuryAppliedEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjuryAppliedEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_InjuryAppliedEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryAppliedEvent>.NativeClassPtr, 100670056);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112458, RefRangeEnd = 112459, XrefRangeStart = 112455, XrefRangeEnd = 112458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InjuryAppliedEvent(GameEventHandler<InjuryAppliedEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjuryAppliedEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_InjuryAppliedEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InjuryAppliedEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

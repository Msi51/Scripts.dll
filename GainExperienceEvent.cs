using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class GainExperienceEvent : GameEvent<GainExperienceEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_GainExperienceEventParams_0;

	static GainExperienceEvent()
	{
		Il2CppClassPointerStore<GainExperienceEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GainExperienceEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GainExperienceEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_GainExperienceEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GainExperienceEvent>.NativeClassPtr, 100670043);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112213, RefRangeEnd = 112214, XrefRangeStart = 112210, XrefRangeEnd = 112213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GainExperienceEvent(GameEventHandler<GainExperienceEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GainExperienceEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_GainExperienceEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GainExperienceEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

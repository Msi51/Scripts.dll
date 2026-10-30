using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowTooltipEvent : GameEvent<ShowTooltipEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowTooltipEventParams_0;

	static ShowTooltipEvent()
	{
		Il2CppClassPointerStore<ShowTooltipEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowTooltipEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTooltipEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowTooltipEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTooltipEvent>.NativeClassPtr, 100663493);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4376, RefRangeEnd = 4377, XrefRangeStart = 4373, XrefRangeEnd = 4376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowTooltipEvent(GameEventHandler<ShowTooltipEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTooltipEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowTooltipEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowTooltipEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowRefuelItemSelectionEvent : GameEvent<ShowRefuelItemSelectionEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowRefuelItemSelectionEventParams_0;

	static ShowRefuelItemSelectionEvent()
	{
		Il2CppClassPointerStore<ShowRefuelItemSelectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowRefuelItemSelectionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowRefuelItemSelectionEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowRefuelItemSelectionEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowRefuelItemSelectionEvent>.NativeClassPtr, 100663492);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4372, RefRangeEnd = 4373, XrefRangeStart = 4369, XrefRangeEnd = 4372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowRefuelItemSelectionEvent(GameEventHandler<ShowRefuelItemSelectionEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowRefuelItemSelectionEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowRefuelItemSelectionEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowRefuelItemSelectionEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

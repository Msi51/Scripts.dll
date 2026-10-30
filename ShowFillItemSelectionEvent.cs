using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowFillItemSelectionEvent : GameEvent<ShowFillItemSelectionEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowFillItemSelectionEventParams_0;

	static ShowFillItemSelectionEvent()
	{
		Il2CppClassPointerStore<ShowFillItemSelectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowFillItemSelectionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowFillItemSelectionEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowFillItemSelectionEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowFillItemSelectionEvent>.NativeClassPtr, 100663486);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4348, RefRangeEnd = 4349, XrefRangeStart = 4345, XrefRangeEnd = 4348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowFillItemSelectionEvent(GameEventHandler<ShowFillItemSelectionEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowFillItemSelectionEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowFillItemSelectionEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowFillItemSelectionEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

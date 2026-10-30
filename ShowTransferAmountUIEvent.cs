using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowTransferAmountUIEvent : GameEvent<ShowTransferAmountUIEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowTransferAmountUIEventParams_0;

	static ShowTransferAmountUIEvent()
	{
		Il2CppClassPointerStore<ShowTransferAmountUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowTransferAmountUIEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTransferAmountUIEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowTransferAmountUIEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTransferAmountUIEvent>.NativeClassPtr, 100670314);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118337, RefRangeEnd = 118338, XrefRangeStart = 118334, XrefRangeEnd = 118337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowTransferAmountUIEvent(GameEventHandler<ShowTransferAmountUIEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTransferAmountUIEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowTransferAmountUIEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowTransferAmountUIEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

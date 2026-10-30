using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowTradeUIEvent : GameEvent<ShowTradeUIEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowTradeUIEventParams_0;

	static ShowTradeUIEvent()
	{
		Il2CppClassPointerStore<ShowTradeUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowTradeUIEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTradeUIEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowTradeUIEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTradeUIEvent>.NativeClassPtr, 100670309);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118247, RefRangeEnd = 118248, XrefRangeStart = 118244, XrefRangeEnd = 118247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowTradeUIEvent(GameEventHandler<ShowTradeUIEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTradeUIEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowTradeUIEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowTradeUIEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

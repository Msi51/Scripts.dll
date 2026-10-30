using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowMessageEvent : GameEvent<ShowMessageEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowMessageEventParams_0;

	static ShowMessageEvent()
	{
		Il2CppClassPointerStore<ShowMessageEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowMessageEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowMessageEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowMessageEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowMessageEvent>.NativeClassPtr, 100663490);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4364, RefRangeEnd = 4365, XrefRangeStart = 4361, XrefRangeEnd = 4364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowMessageEvent(GameEventHandler<ShowMessageEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowMessageEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowMessageEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowMessageEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

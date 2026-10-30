using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowStatusMenuEvent : GameEvent<ShowStatusMenuEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowStatusMenuEventParams_0;

	static ShowStatusMenuEvent()
	{
		Il2CppClassPointerStore<ShowStatusMenuEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowStatusMenuEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowStatusMenuEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowStatusMenuEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowStatusMenuEvent>.NativeClassPtr, 100670226);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116051, RefRangeEnd = 116052, XrefRangeStart = 116048, XrefRangeEnd = 116051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowStatusMenuEvent(GameEventHandler<ShowStatusMenuEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowStatusMenuEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowStatusMenuEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowStatusMenuEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

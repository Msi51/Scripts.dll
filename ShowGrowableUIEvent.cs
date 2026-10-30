using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowGrowableUIEvent : GameEvent<ShowGrowableUIEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowGrowableUIEventParams_0;

	static ShowGrowableUIEvent()
	{
		Il2CppClassPointerStore<ShowGrowableUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowGrowableUIEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowGrowableUIEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowGrowableUIEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGrowableUIEvent>.NativeClassPtr, 100663487);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4352, RefRangeEnd = 4353, XrefRangeStart = 4349, XrefRangeEnd = 4352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowGrowableUIEvent(GameEventHandler<ShowGrowableUIEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowGrowableUIEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowGrowableUIEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowGrowableUIEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

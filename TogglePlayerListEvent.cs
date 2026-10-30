using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class TogglePlayerListEvent : GameEvent<TogglePlayerListEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_TogglePlayerListEventParams_0;

	static TogglePlayerListEvent()
	{
		Il2CppClassPointerStore<TogglePlayerListEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TogglePlayerListEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TogglePlayerListEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_TogglePlayerListEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TogglePlayerListEvent>.NativeClassPtr, 100663521);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4455, RefRangeEnd = 4456, XrefRangeStart = 4447, XrefRangeEnd = 4455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TogglePlayerListEvent(GameEventHandler<TogglePlayerListEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TogglePlayerListEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_TogglePlayerListEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TogglePlayerListEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

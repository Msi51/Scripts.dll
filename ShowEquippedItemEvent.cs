using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowEquippedItemEvent : GameEvent<ShowEquippedItemEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowEquippedItemEventParams_0;

	static ShowEquippedItemEvent()
	{
		Il2CppClassPointerStore<ShowEquippedItemEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowEquippedItemEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowEquippedItemEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowEquippedItemEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowEquippedItemEvent>.NativeClassPtr, 100670186);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115370, RefRangeEnd = 115371, XrefRangeStart = 115367, XrefRangeEnd = 115370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowEquippedItemEvent(GameEventHandler<ShowEquippedItemEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowEquippedItemEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowEquippedItemEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowEquippedItemEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

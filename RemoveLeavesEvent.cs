using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class RemoveLeavesEvent : GameEvent<RemoveLeavesEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_RemoveLeavesEventParams_0;

	static RemoveLeavesEvent()
	{
		Il2CppClassPointerStore<RemoveLeavesEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RemoveLeavesEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveLeavesEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_RemoveLeavesEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLeavesEvent>.NativeClassPtr, 100670141);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114086, RefRangeEnd = 114087, XrefRangeStart = 114083, XrefRangeEnd = 114086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RemoveLeavesEvent(GameEventHandler<RemoveLeavesEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveLeavesEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_RemoveLeavesEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RemoveLeavesEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

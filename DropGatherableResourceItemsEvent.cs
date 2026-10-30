using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class DropGatherableResourceItemsEvent : GameEvent<DropGatherableResourceItemsEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DropGatherableResourceItemsEventParams_0;

	static DropGatherableResourceItemsEvent()
	{
		Il2CppClassPointerStore<DropGatherableResourceItemsEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DropGatherableResourceItemsEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropGatherableResourceItemsEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DropGatherableResourceItemsEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropGatherableResourceItemsEvent>.NativeClassPtr, 100669987);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111301, RefRangeEnd = 111302, XrefRangeStart = 111298, XrefRangeEnd = 111301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DropGatherableResourceItemsEvent(GameEventHandler<DropGatherableResourceItemsEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropGatherableResourceItemsEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DropGatherableResourceItemsEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DropGatherableResourceItemsEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

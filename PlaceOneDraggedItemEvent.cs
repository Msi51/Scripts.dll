using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class PlaceOneDraggedItemEvent : GameEvent<PlaceOneDraggedItemEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PlaceOneDraggedItemEventParams_0;

	static PlaceOneDraggedItemEvent()
	{
		Il2CppClassPointerStore<PlaceOneDraggedItemEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlaceOneDraggedItemEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceOneDraggedItemEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PlaceOneDraggedItemEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceOneDraggedItemEvent>.NativeClassPtr, 100670114);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113746, RefRangeEnd = 113747, XrefRangeStart = 113743, XrefRangeEnd = 113746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlaceOneDraggedItemEvent(GameEventHandler<PlaceOneDraggedItemEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceOneDraggedItemEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PlaceOneDraggedItemEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlaceOneDraggedItemEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

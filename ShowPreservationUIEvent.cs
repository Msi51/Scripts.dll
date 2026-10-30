using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowPreservationUIEvent : GameEvent<ShowPreservationUIEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowPreservationUIEventParams_0;

	static ShowPreservationUIEvent()
	{
		Il2CppClassPointerStore<ShowPreservationUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowPreservationUIEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowPreservationUIEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowPreservationUIEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowPreservationUIEvent>.NativeClassPtr, 100663491);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4368, RefRangeEnd = 4369, XrefRangeStart = 4365, XrefRangeEnd = 4368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowPreservationUIEvent(GameEventHandler<ShowPreservationUIEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowPreservationUIEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowPreservationUIEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowPreservationUIEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

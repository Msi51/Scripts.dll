using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class TillSoilEvent : GameEvent<TillSoilEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_TillSoilEventParams_0;

	static TillSoilEvent()
	{
		Il2CppClassPointerStore<TillSoilEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TillSoilEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TillSoilEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_TillSoilEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TillSoilEvent>.NativeClassPtr, 100663520);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4446, RefRangeEnd = 4447, XrefRangeStart = 4443, XrefRangeEnd = 4446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TillSoilEvent(GameEventHandler<TillSoilEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TillSoilEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_TillSoilEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TillSoilEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

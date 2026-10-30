using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class DestroyItemEntityEvent : GameEvent<DestroyItemEntityEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DestroyItemEntityEventParams_0;

	static DestroyItemEntityEvent()
	{
		Il2CppClassPointerStore<DestroyItemEntityEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DestroyItemEntityEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyItemEntityEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DestroyItemEntityEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyItemEntityEvent>.NativeClassPtr, 100663440);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4134, RefRangeEnd = 4135, XrefRangeStart = 4131, XrefRangeEnd = 4134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DestroyItemEntityEvent(GameEventHandler<DestroyItemEntityEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyItemEntityEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DestroyItemEntityEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DestroyItemEntityEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

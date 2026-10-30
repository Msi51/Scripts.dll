using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class DestroyObjectEvent : GameEvent<DestroyObjectEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DestroyObjectEventParams_0;

	static DestroyObjectEvent()
	{
		Il2CppClassPointerStore<DestroyObjectEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DestroyObjectEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyObjectEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DestroyObjectEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyObjectEvent>.NativeClassPtr, 100663439);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4130, RefRangeEnd = 4131, XrefRangeStart = 4127, XrefRangeEnd = 4130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DestroyObjectEvent(GameEventHandler<DestroyObjectEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyObjectEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DestroyObjectEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DestroyObjectEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

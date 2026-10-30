using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CreateDecalEvent : GameEvent<CreateDecalEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateDecalEventParams_0;

	static CreateDecalEvent()
	{
		Il2CppClassPointerStore<CreateDecalEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreateDecalEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateDecalEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateDecalEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateDecalEvent>.NativeClassPtr, 100669955);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 110729, RefRangeEnd = 110730, XrefRangeStart = 110726, XrefRangeEnd = 110729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreateDecalEvent(GameEventHandler<CreateDecalEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateDecalEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateDecalEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreateDecalEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

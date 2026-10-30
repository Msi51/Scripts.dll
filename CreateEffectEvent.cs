using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CreateEffectEvent : GameEvent<CreateEffectEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateEffectEventParams_0;

	static CreateEffectEvent()
	{
		Il2CppClassPointerStore<CreateEffectEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreateEffectEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateEffectEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateEffectEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateEffectEvent>.NativeClassPtr, 100663432);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4108, RefRangeEnd = 4109, XrefRangeStart = 4105, XrefRangeEnd = 4108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreateEffectEvent(GameEventHandler<CreateEffectEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateEffectEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateEffectEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreateEffectEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

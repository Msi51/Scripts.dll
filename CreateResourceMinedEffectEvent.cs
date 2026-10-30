using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CreateResourceMinedEffectEvent : GameEvent<CreateResourceMinedEffectEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateResourceMinedEffectEventParams_0;

	static CreateResourceMinedEffectEvent()
	{
		Il2CppClassPointerStore<CreateResourceMinedEffectEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreateResourceMinedEffectEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateResourceMinedEffectEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateResourceMinedEffectEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateResourceMinedEffectEvent>.NativeClassPtr, 100663434);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4116, RefRangeEnd = 4117, XrefRangeStart = 4113, XrefRangeEnd = 4116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreateResourceMinedEffectEvent(GameEventHandler<CreateResourceMinedEffectEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateResourceMinedEffectEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateResourceMinedEffectEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreateResourceMinedEffectEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class PlaySoundEvent : GameEvent<PlaySoundEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PlaySoundEventParams_0;

	static PlaySoundEvent()
	{
		Il2CppClassPointerStore<PlaySoundEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlaySoundEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySoundEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PlaySoundEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundEvent>.NativeClassPtr, 100663476);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4324, RefRangeEnd = 4325, XrefRangeStart = 4321, XrefRangeEnd = 4324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlaySoundEvent(GameEventHandler<PlaySoundEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySoundEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PlaySoundEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlaySoundEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

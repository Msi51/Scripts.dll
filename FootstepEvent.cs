using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class FootstepEvent : GameEvent<FootstepEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_FootstepEventParams_0;

	static FootstepEvent()
	{
		Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FootstepEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_FootstepEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr, 100663456);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4187, RefRangeEnd = 4188, XrefRangeStart = 4184, XrefRangeEnd = 4187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FootstepEvent(GameEventHandler<FootstepEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_FootstepEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FootstepEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

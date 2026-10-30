using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ProjectileFinishEvent : GameEvent<ProjectileFinishEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ProjectileFinishEventParams_0;

	static ProjectileFinishEvent()
	{
		Il2CppClassPointerStore<ProjectileFinishEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ProjectileFinishEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectileFinishEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ProjectileFinishEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileFinishEvent>.NativeClassPtr, 100670133);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113990, RefRangeEnd = 113991, XrefRangeStart = 113987, XrefRangeEnd = 113990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProjectileFinishEvent(GameEventHandler<ProjectileFinishEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectileFinishEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ProjectileFinishEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ProjectileFinishEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

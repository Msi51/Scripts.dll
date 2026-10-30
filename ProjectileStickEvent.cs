using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ProjectileStickEvent : GameEvent<ProjectileStickEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ProjectileStickEventParams_0;

	static ProjectileStickEvent()
	{
		Il2CppClassPointerStore<ProjectileStickEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ProjectileStickEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectileStickEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ProjectileStickEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileStickEvent>.NativeClassPtr, 100670137);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114037, RefRangeEnd = 114038, XrefRangeStart = 114034, XrefRangeEnd = 114037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProjectileStickEvent(GameEventHandler<ProjectileStickEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectileStickEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ProjectileStickEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ProjectileStickEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

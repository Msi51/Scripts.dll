using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class PhysicsCollisionEffectEvent : GameEvent<PhysicsCollisionEffectEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PhysicsCollisionEffectEventParams_0;

	static PhysicsCollisionEffectEvent()
	{
		Il2CppClassPointerStore<PhysicsCollisionEffectEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PhysicsCollisionEffectEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsCollisionEffectEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PhysicsCollisionEffectEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsCollisionEffectEvent>.NativeClassPtr, 100670098);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113178, RefRangeEnd = 113179, XrefRangeStart = 113175, XrefRangeEnd = 113178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhysicsCollisionEffectEvent(GameEventHandler<PhysicsCollisionEffectEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsCollisionEffectEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_PhysicsCollisionEffectEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PhysicsCollisionEffectEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

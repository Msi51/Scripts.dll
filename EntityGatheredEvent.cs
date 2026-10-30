using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class EntityGatheredEvent : GameEvent<EntityGatheredEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_EntityGatheredEventParams_0;

	static EntityGatheredEvent()
	{
		Il2CppClassPointerStore<EntityGatheredEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EntityGatheredEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityGatheredEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_EntityGatheredEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityGatheredEvent>.NativeClassPtr, 100670010);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111586, RefRangeEnd = 111587, XrefRangeStart = 111583, XrefRangeEnd = 111586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EntityGatheredEvent(GameEventHandler<EntityGatheredEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityGatheredEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_EntityGatheredEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EntityGatheredEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

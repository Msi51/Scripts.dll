using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class EntityEnterChunkEvent : GameEvent<EntityEnterChunkEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_EntityEnterChunkEventParams_0;

	static EntityEnterChunkEvent()
	{
		Il2CppClassPointerStore<EntityEnterChunkEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EntityEnterChunkEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityEnterChunkEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_EntityEnterChunkEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityEnterChunkEvent>.NativeClassPtr, 100663450);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4169, RefRangeEnd = 4170, XrefRangeStart = 4166, XrefRangeEnd = 4169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EntityEnterChunkEvent(GameEventHandler<EntityEnterChunkEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityEnterChunkEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_EntityEnterChunkEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EntityEnterChunkEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

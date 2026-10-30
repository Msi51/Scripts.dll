using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class LevelTerrainEvent : GameEvent<LevelTerrainEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_LevelTerrainEventParams_0;

	static LevelTerrainEvent()
	{
		Il2CppClassPointerStore<LevelTerrainEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "LevelTerrainEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelTerrainEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_LevelTerrainEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelTerrainEvent>.NativeClassPtr, 100670079);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112822, RefRangeEnd = 112823, XrefRangeStart = 112819, XrefRangeEnd = 112822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LevelTerrainEvent(GameEventHandler<LevelTerrainEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelTerrainEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_LevelTerrainEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LevelTerrainEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

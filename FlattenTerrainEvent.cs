using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class FlattenTerrainEvent : GameEvent<FlattenTerrainEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_FlattenTerrainEventParams_0;

	static FlattenTerrainEvent()
	{
		Il2CppClassPointerStore<FlattenTerrainEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FlattenTerrainEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlattenTerrainEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_FlattenTerrainEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenTerrainEvent>.NativeClassPtr, 100670033);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111963, RefRangeEnd = 111964, XrefRangeStart = 111960, XrefRangeEnd = 111963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FlattenTerrainEvent(GameEventHandler<FlattenTerrainEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlattenTerrainEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_FlattenTerrainEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FlattenTerrainEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

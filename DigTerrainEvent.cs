using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class DigTerrainEvent : GameEvent<DigTerrainEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DigTerrainEventParams_0;

	static DigTerrainEvent()
	{
		Il2CppClassPointerStore<DigTerrainEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DigTerrainEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigTerrainEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DigTerrainEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigTerrainEvent>.NativeClassPtr, 100663445);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4157, RefRangeEnd = 4158, XrefRangeStart = 4154, XrefRangeEnd = 4157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DigTerrainEvent(GameEventHandler<DigTerrainEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigTerrainEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_DigTerrainEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DigTerrainEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

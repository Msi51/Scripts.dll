using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class SmoothTerrainEvent : GameEvent<SmoothTerrainEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_SmoothTerrainEventParams_0;

	static SmoothTerrainEvent()
	{
		Il2CppClassPointerStore<SmoothTerrainEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SmoothTerrainEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothTerrainEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_SmoothTerrainEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothTerrainEvent>.NativeClassPtr, 100670322);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118388, RefRangeEnd = 118389, XrefRangeStart = 118385, XrefRangeEnd = 118388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SmoothTerrainEvent(GameEventHandler<SmoothTerrainEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothTerrainEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_SmoothTerrainEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SmoothTerrainEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

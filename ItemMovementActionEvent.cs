using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ItemMovementActionEvent : GameEvent<ItemMovementActionEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ItemMovementActionEventParams_0;

	static ItemMovementActionEvent()
	{
		Il2CppClassPointerStore<ItemMovementActionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ItemMovementActionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemMovementActionEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ItemMovementActionEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemMovementActionEvent>.NativeClassPtr, 100670070);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112685, RefRangeEnd = 112686, XrefRangeStart = 112682, XrefRangeEnd = 112685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemMovementActionEvent(GameEventHandler<ItemMovementActionEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemMovementActionEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ItemMovementActionEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ItemMovementActionEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ResourceDriedEvent : GameEvent<ResourceDriedEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ResourceDriedEventParams_0;

	static ResourceDriedEvent()
	{
		Il2CppClassPointerStore<ResourceDriedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ResourceDriedEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceDriedEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ResourceDriedEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceDriedEvent>.NativeClassPtr, 100663484);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4340, RefRangeEnd = 4341, XrefRangeStart = 4337, XrefRangeEnd = 4340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceDriedEvent(GameEventHandler<ResourceDriedEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceDriedEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ResourceDriedEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ResourceDriedEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

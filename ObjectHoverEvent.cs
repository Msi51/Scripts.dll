using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ObjectHoverEvent : GameEvent<ObjectHoverEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ObjectHoverEventParams_0;

	static ObjectHoverEvent()
	{
		Il2CppClassPointerStore<ObjectHoverEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ObjectHoverEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHoverEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ObjectHoverEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHoverEvent>.NativeClassPtr, 100663465);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4279, RefRangeEnd = 4280, XrefRangeStart = 4204, XrefRangeEnd = 4279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectHoverEvent(GameEventHandler<ObjectHoverEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHoverEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ObjectHoverEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ObjectHoverEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class OffsetExistingChildResourceMeshEvent : GameEvent<OffsetExistingChildResourceMeshEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_OffsetExistingChildResourceMeshEventParams_0;

	static OffsetExistingChildResourceMeshEvent()
	{
		Il2CppClassPointerStore<OffsetExistingChildResourceMeshEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "OffsetExistingChildResourceMeshEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffsetExistingChildResourceMeshEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_OffsetExistingChildResourceMeshEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetExistingChildResourceMeshEvent>.NativeClassPtr, 100670094);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113152, RefRangeEnd = 113153, XrefRangeStart = 113149, XrefRangeEnd = 113152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OffsetExistingChildResourceMeshEvent(GameEventHandler<OffsetExistingChildResourceMeshEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffsetExistingChildResourceMeshEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_OffsetExistingChildResourceMeshEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public OffsetExistingChildResourceMeshEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

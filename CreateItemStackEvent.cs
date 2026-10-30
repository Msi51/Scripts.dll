using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CreateItemStackEvent : GameEvent<CreateItemStackEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateItemStackEventParams_0;

	static CreateItemStackEvent()
	{
		Il2CppClassPointerStore<CreateItemStackEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreateItemStackEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateItemStackEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateItemStackEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateItemStackEvent>.NativeClassPtr, 100663433);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4112, RefRangeEnd = 4113, XrefRangeStart = 4109, XrefRangeEnd = 4112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreateItemStackEvent(GameEventHandler<CreateItemStackEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateItemStackEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateItemStackEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreateItemStackEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

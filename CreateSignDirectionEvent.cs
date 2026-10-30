using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class CreateSignDirectionEvent : GameEvent<CreateSignDirectionEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateSignDirectionEventParams_0;

	static CreateSignDirectionEvent()
	{
		Il2CppClassPointerStore<CreateSignDirectionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreateSignDirectionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateSignDirectionEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateSignDirectionEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSignDirectionEvent>.NativeClassPtr, 100663435);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4120, RefRangeEnd = 4121, XrefRangeStart = 4117, XrefRangeEnd = 4120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreateSignDirectionEvent(GameEventHandler<CreateSignDirectionEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateSignDirectionEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_CreateSignDirectionEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreateSignDirectionEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ShowJournalUIEvent : GameEvent<ShowJournalUIEventParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowJournalUIEventParams_0;

	static ShowJournalUIEvent()
	{
		Il2CppClassPointerStore<ShowJournalUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ShowJournalUIEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowJournalUIEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowJournalUIEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowJournalUIEvent>.NativeClassPtr, 100670208);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115722, RefRangeEnd = 115723, XrefRangeStart = 115719, XrefRangeEnd = 115722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowJournalUIEvent(GameEventHandler<ShowJournalUIEventParams> handler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowJournalUIEvent>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handler);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameEventHandler_1_ShowJournalUIEventParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ShowJournalUIEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

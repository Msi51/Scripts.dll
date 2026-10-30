using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class ObjectiveCompleteSignal : Signal<ObjectiveCompleteSignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ObjectiveCompleteSignal()
	{
		Il2CppClassPointerStore<ObjectiveCompleteSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ObjectiveCompleteSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectiveCompleteSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveCompleteSignal>.NativeClassPtr, 100679643);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233656, XrefRangeEnd = 233659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectiveCompleteSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectiveCompleteSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ObjectiveCompleteSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

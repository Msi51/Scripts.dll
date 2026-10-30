using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Events;

public class CheckboxValueChangedEvent : UnityEvent<bool>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CheckboxValueChangedEvent()
	{
		Il2CppClassPointerStore<CheckboxValueChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CheckboxValueChangedEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckboxValueChangedEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckboxValueChangedEvent>.NativeClassPtr, 100664706);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35443, XrefRangeEnd = 35446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CheckboxValueChangedEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckboxValueChangedEvent>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CheckboxValueChangedEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}

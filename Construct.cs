using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class Construct : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static Construct()
	{
		Il2CppClassPointerStore<Construct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "Construct");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Construct>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Construct>.NativeClassPtr, 100684101);
	}

	[CallerCount(283)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 284, XrefRangeStart = 1, XrefRangeEnd = 284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Construct()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Construct>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Construct(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

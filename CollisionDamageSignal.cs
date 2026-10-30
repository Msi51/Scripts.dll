using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class CollisionDamageSignal : Signal<CollisionDamageSignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CollisionDamageSignal()
	{
		Il2CppClassPointerStore<CollisionDamageSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CollisionDamageSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollisionDamageSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollisionDamageSignal>.NativeClassPtr, 100679640);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233647, XrefRangeEnd = 233650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CollisionDamageSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollisionDamageSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CollisionDamageSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

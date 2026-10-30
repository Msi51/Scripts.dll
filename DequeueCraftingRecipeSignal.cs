using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.signal.impl;

public class DequeueCraftingRecipeSignal : Signal<DequeueCraftingRecipeSignalParams>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static DequeueCraftingRecipeSignal()
	{
		Il2CppClassPointerStore<DequeueCraftingRecipeSignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DequeueCraftingRecipeSignal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DequeueCraftingRecipeSignal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DequeueCraftingRecipeSignal>.NativeClassPtr, 100679584);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233500, XrefRangeEnd = 233503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DequeueCraftingRecipeSignal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DequeueCraftingRecipeSignal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DequeueCraftingRecipeSignal(IntPtr pointer)
		: base(pointer)
	{
	}
}

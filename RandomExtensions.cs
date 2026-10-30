using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public static class RandomExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_RandomState_Random_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Restore_Public_Static_Random_RandomState_0;

	static RandomExtensions()
	{
		Il2CppClassPointerStore<RandomExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RandomExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_Save_Public_Static_RandomState_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomExtensions>.NativeClassPtr, 100667897);
		NativeMethodInfoPtr_Restore_Public_Static_Random_RandomState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomExtensions>.NativeClassPtr, 100667898);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84609, XrefRangeEnd = 84625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RandomState Save(this Il2CppSystem.Random random)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_RandomState_Random_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new RandomState(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84625, XrefRangeEnd = 84642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Random Restore(this RandomState state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)state));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Restore_Public_Static_Random_RandomState_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Random>(intPtr) : null;
	}

	public RandomExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

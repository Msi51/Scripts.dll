using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

public static class UnityUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

	static UnityUtil()
	{
		Il2CppClassPointerStore<UnityUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "UnityUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr);
		NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUtil>.NativeClassPtr, 100667956);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85969, XrefRangeEnd = 85976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(UnityEngine.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UnityUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

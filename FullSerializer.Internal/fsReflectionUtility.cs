using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace FullSerializer.Internal;

public static class fsReflectionUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetInterface_Public_Static_Type_Type_Type_0;

	static fsReflectionUtility()
	{
		Il2CppClassPointerStore<fsReflectionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer.Internal", "fsReflectionUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsReflectionUtility>.NativeClassPtr);
		NativeMethodInfoPtr_GetInterface_Public_Static_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsReflectionUtility>.NativeClassPtr, 100686961);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 299843, RefRangeEnd = 299846, XrefRangeStart = 299822, XrefRangeEnd = 299843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetInterface(Il2CppSystem.Type type, Il2CppSystem.Type interfaceType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interfaceType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInterface_Public_Static_Type_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	public fsReflectionUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

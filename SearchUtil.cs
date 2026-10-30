using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class SearchUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SanitizeSearchInput_Public_Static_String_String_0;

	static SearchUtil()
	{
		Il2CppClassPointerStore<SearchUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SearchUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchUtil>.NativeClassPtr);
		NativeMethodInfoPtr_SanitizeSearchInput_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchUtil>.NativeClassPtr, 100667900);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 84649, RefRangeEnd = 84652, XrefRangeStart = 84642, XrefRangeEnd = 84649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SanitizeSearchInput(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SanitizeSearchInput_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public SearchUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

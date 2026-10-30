using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class IOUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteDirectory_Public_Static_Boolean_String_0;

	static IOUtil()
	{
		Il2CppClassPointerStore<IOUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IOUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOUtil>.NativeClassPtr);
		NativeMethodInfoPtr_DeleteDirectory_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100667762);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 82172, RefRangeEnd = 82176, XrefRangeStart = 82163, XrefRangeEnd = 82172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DeleteDirectory(string directoryName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteDirectory_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IOUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

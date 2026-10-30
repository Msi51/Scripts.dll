using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SimpleJSON;

public static class JSON : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0;

	static JSON()
	{
		Il2CppClassPointerStore<JSON>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "SimpleJSON", "JSON");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSON>.NativeClassPtr);
		NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSON>.NativeClassPtr, 100685674);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 286706, RefRangeEnd = 286712, XrefRangeStart = 286702, XrefRangeEnd = 286706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JSONNode Parse(string aJSON)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(aJSON);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_JSONNode_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<JSONNode>(intPtr) : null;
	}

	public JSON(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

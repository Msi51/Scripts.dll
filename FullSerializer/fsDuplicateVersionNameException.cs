using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace FullSerializer;

public sealed class fsDuplicateVersionNameException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_String_0;

	static fsDuplicateVersionNameException()
	{
		Il2CppClassPointerStore<fsDuplicateVersionNameException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsDuplicateVersionNameException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsDuplicateVersionNameException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Type_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsDuplicateVersionNameException>.NativeClassPtr, 100686636);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294715, XrefRangeEnd = 294759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsDuplicateVersionNameException(Il2CppSystem.Type typeA, Il2CppSystem.Type typeB, string version)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsDuplicateVersionNameException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeA);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeB);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(version);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsDuplicateVersionNameException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

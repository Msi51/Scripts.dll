using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace FullSerializer;

public sealed class fsMissingVersionConstructorException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0;

	static fsMissingVersionConstructorException()
	{
		Il2CppClassPointerStore<fsMissingVersionConstructorException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsMissingVersionConstructorException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsMissingVersionConstructorException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsMissingVersionConstructorException>.NativeClassPtr, 100686635);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294707, XrefRangeEnd = 294715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsMissingVersionConstructorException(Il2CppSystem.Type versionedType, Il2CppSystem.Type constructorType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsMissingVersionConstructorException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)versionedType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constructorType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsMissingVersionConstructorException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

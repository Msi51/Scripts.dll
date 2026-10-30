using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using strange.extensions.injector.api;

namespace strange.extensions.injector.impl;

public class InjectionException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeFieldInfoPtr__type_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_InjectionExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_InjectionExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_InjectionExceptionType_0;

	public unsafe InjectionExceptionType _type_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_k__BackingField);
			return *(InjectionExceptionType*)num;
		}
		set
		{
			*(InjectionExceptionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_k__BackingField)) = injectionExceptionType;
		}
	}

	public unsafe InjectionExceptionType type
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 277381, RefRangeEnd = 277393, XrefRangeStart = 277381, XrefRangeEnd = 277393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_InjectionExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(InjectionExceptionType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_type_Public_set_Void_InjectionExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static InjectionException()
	{
		Il2CppClassPointerStore<InjectionException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.injector.impl", "InjectionException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjectionException>.NativeClassPtr);
		NativeFieldInfoPtr__type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjectionException>.NativeClassPtr, "<type>k__BackingField");
		NativeMethodInfoPtr_get_type_Public_get_InjectionExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionException>.NativeClassPtr, 100684820);
		NativeMethodInfoPtr_set_type_Public_set_Void_InjectionExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionException>.NativeClassPtr, 100684821);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionException>.NativeClassPtr, 100684822);
		NativeMethodInfoPtr__ctor_Public_Void_String_InjectionExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionException>.NativeClassPtr, 100684823);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280148, XrefRangeEnd = 280152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InjectionException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjectionException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 280156, RefRangeEnd = 280158, XrefRangeStart = 280152, XrefRangeEnd = 280156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InjectionException(string message, InjectionExceptionType exceptionType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjectionException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(InjectionExceptionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_InjectionExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InjectionException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

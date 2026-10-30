using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using strange.extensions.signal.api;

namespace strange.extensions.signal.impl;

public class SignalException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeFieldInfoPtr__type_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_SignalExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_SignalExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SignalExceptionType_0;

	public unsafe SignalExceptionType _type_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_k__BackingField);
			return *(SignalExceptionType*)num;
		}
		set
		{
			*(SignalExceptionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_k__BackingField)) = signalExceptionType;
		}
	}

	public unsafe SignalExceptionType type
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 277381, RefRangeEnd = 277393, XrefRangeStart = 277381, XrefRangeEnd = 277393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_SignalExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(SignalExceptionType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_type_Public_set_Void_SignalExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static SignalException()
	{
		Il2CppClassPointerStore<SignalException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.signal.impl", "SignalException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalException>.NativeClassPtr);
		NativeFieldInfoPtr__type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalException>.NativeClassPtr, "<type>k__BackingField");
		NativeMethodInfoPtr_get_type_Public_get_SignalExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalException>.NativeClassPtr, 100684359);
		NativeMethodInfoPtr_set_type_Public_set_Void_SignalExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalException>.NativeClassPtr, 100684360);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalException>.NativeClassPtr, 100684361);
		NativeMethodInfoPtr__ctor_Public_Void_String_SignalExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalException>.NativeClassPtr, 100684362);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278057, XrefRangeEnd = 278061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SignalException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278061, XrefRangeEnd = 278065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SignalException(string message, SignalExceptionType exceptionType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(SignalExceptionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_SignalExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SignalException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using strange.extensions.mediation.api;

namespace strange.extensions.mediation.impl;

public class MediationException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeFieldInfoPtr__type_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_MediationExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_MediationExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_MediationExceptionType_0;

	public unsafe MediationExceptionType _type_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_k__BackingField);
			return *(MediationExceptionType*)num;
		}
		set
		{
			*(MediationExceptionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_k__BackingField)) = mediationExceptionType;
		}
	}

	public unsafe MediationExceptionType type
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 277381, RefRangeEnd = 277393, XrefRangeStart = 277381, XrefRangeEnd = 277393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_MediationExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(MediationExceptionType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_type_Public_set_Void_MediationExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static MediationException()
	{
		Il2CppClassPointerStore<MediationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.mediation.impl", "MediationException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediationException>.NativeClassPtr);
		NativeFieldInfoPtr__type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediationException>.NativeClassPtr, "<type>k__BackingField");
		NativeMethodInfoPtr_get_type_Public_get_MediationExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationException>.NativeClassPtr, 100684707);
		NativeMethodInfoPtr_set_type_Public_set_Void_MediationExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationException>.NativeClassPtr, 100684708);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationException>.NativeClassPtr, 100684709);
		NativeMethodInfoPtr__ctor_Public_Void_String_MediationExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationException>.NativeClassPtr, 100684710);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279548, XrefRangeEnd = 279552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MediationException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediationException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 279556, RefRangeEnd = 279557, XrefRangeStart = 279552, XrefRangeEnd = 279556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MediationException(string message, MediationExceptionType exceptionType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediationException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(MediationExceptionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &exceptionType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_MediationExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MediationException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

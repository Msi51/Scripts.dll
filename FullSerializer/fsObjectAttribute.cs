using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace FullSerializer;

public sealed class fsObjectAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PreviousModels;

	private static readonly System.IntPtr NativeFieldInfoPtr_VersionString;

	private static readonly System.IntPtr NativeFieldInfoPtr_MemberSerialization;

	private static readonly System.IntPtr NativeFieldInfoPtr_Converter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Processor;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0;

	public unsafe Il2CppReferenceArray<Il2CppSystem.Type> PreviousModels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviousModels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreviousModels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string VersionString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VersionString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VersionString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe fsMemberSerialization MemberSerialization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MemberSerialization);
			return *(fsMemberSerialization*)num;
		}
		set
		{
			*(fsMemberSerialization*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MemberSerialization)) = fsMemberSerialization2;
		}
	}

	public unsafe Il2CppSystem.Type Converter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Converter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Converter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
		}
	}

	public unsafe Il2CppSystem.Type Processor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Processor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Processor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
		}
	}

	static fsObjectAttribute()
	{
		Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsObjectAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_PreviousModels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr, "PreviousModels");
		NativeFieldInfoPtr_VersionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr, "VersionString");
		NativeFieldInfoPtr_MemberSerialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr, "MemberSerialization");
		NativeFieldInfoPtr_Converter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr, "Converter");
		NativeFieldInfoPtr_Processor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr, "Processor");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr, 100686675);
		NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr, 100686676);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295339, XrefRangeEnd = 295340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsObjectAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295340, XrefRangeEnd = 295343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsObjectAttribute(string versionString, [Optional] Il2CppReferenceArray<Il2CppSystem.Type> previousModels)
	{
		if (previousModels == null)
		{
			previousModels = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsObjectAttribute>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(versionString);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)previousModels);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsObjectAttribute(string versionString, params Il2CppSystem.Type[] previousModels)
		: this(versionString, new Il2CppReferenceArray<Il2CppSystem.Type>(previousModels))
	{
	}

	public fsObjectAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

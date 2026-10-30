using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class GDPRResponse : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__is_request_in_eea_or_unknown_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_is_request_in_eea_or_unknown_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_is_request_in_eea_or_unknown_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool _is_request_in_eea_or_unknown_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__is_request_in_eea_or_unknown_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__is_request_in_eea_or_unknown_k__BackingField)) = flag;
		}
	}

	public unsafe bool is_request_in_eea_or_unknown
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196885, RefRangeEnd = 196886, XrefRangeStart = 196885, XrefRangeEnd = 196885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_is_request_in_eea_or_unknown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_is_request_in_eea_or_unknown_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static GDPRResponse()
	{
		Il2CppClassPointerStore<GDPRResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GDPRResponse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GDPRResponse>.NativeClassPtr);
		NativeFieldInfoPtr__is_request_in_eea_or_unknown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GDPRResponse>.NativeClassPtr, "<is_request_in_eea_or_unknown>k__BackingField");
		NativeMethodInfoPtr_get_is_request_in_eea_or_unknown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GDPRResponse>.NativeClassPtr, 100677052);
		NativeMethodInfoPtr_set_is_request_in_eea_or_unknown_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GDPRResponse>.NativeClassPtr, 100677053);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GDPRResponse>.NativeClassPtr, 100677054);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GDPRResponse()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GDPRResponse>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GDPRResponse(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

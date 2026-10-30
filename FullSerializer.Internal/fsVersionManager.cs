using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace FullSerializer.Internal;

public static class fsVersionManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__cache;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVersionImportPath_Public_Static_fsResult_String_fsVersionedType_byref_List_1_fsVersionedType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVersionImportPathRecursive_Private_Static_Boolean_List_1_fsVersionedType_String_fsVersionedType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVersionedType_Public_Static_fsOption_1_fsVersionedType_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyConstructors_Private_Static_Void_fsVersionedType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VerifyUniqueVersionStrings_Private_Static_Void_fsVersionedType_0;

	public unsafe static Dictionary<Il2CppSystem.Type, fsOption<fsVersionedType>> _cache
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__cache, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, fsOption<fsVersionedType>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__cache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static fsVersionManager()
	{
		Il2CppClassPointerStore<fsVersionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer.Internal", "fsVersionManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsVersionManager>.NativeClassPtr);
		NativeFieldInfoPtr__cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsVersionManager>.NativeClassPtr, "_cache");
		NativeMethodInfoPtr_GetVersionImportPath_Public_Static_fsResult_String_fsVersionedType_byref_List_1_fsVersionedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsVersionManager>.NativeClassPtr, 100686934);
		NativeMethodInfoPtr_GetVersionImportPathRecursive_Private_Static_Boolean_List_1_fsVersionedType_String_fsVersionedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsVersionManager>.NativeClassPtr, 100686935);
		NativeMethodInfoPtr_GetVersionedType_Public_Static_fsOption_1_fsVersionedType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsVersionManager>.NativeClassPtr, 100686936);
		NativeMethodInfoPtr_VerifyConstructors_Private_Static_Void_fsVersionedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsVersionManager>.NativeClassPtr, 100686937);
		NativeMethodInfoPtr_VerifyUniqueVersionStrings_Private_Static_Void_fsVersionedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsVersionManager>.NativeClassPtr, 100686938);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 299641, RefRangeEnd = 299642, XrefRangeStart = 299619, XrefRangeEnd = 299641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(currentVersion);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)targetVersion));
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVersionImportPath_Public_Static_fsResult_String_fsVersionedType_byref_List_1_fsVersionedType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		path = ((num3 == 0) ? null : new List<fsVersionedType>(num3));
		return new fsResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 299651, RefRangeEnd = 299653, XrefRangeStart = 299642, XrefRangeEnd = 299651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(currentVersion);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)current));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVersionImportPathRecursive_Private_Static_Boolean_List_1_fsVersionedType_String_fsVersionedType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 299699, RefRangeEnd = 299702, XrefRangeStart = 299653, XrefRangeEnd = 299699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static fsOption<fsVersionedType> GetVersionedType(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVersionedType_Public_Static_fsOption_1_fsVersionedType_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsOption<fsVersionedType>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 299715, RefRangeEnd = 299716, XrefRangeStart = 299702, XrefRangeEnd = 299715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void VerifyConstructors(fsVersionedType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)type));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyConstructors_Private_Static_Void_fsVersionedType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 299751, RefRangeEnd = 299752, XrefRangeStart = 299716, XrefRangeEnd = 299751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void VerifyUniqueVersionStrings(fsVersionedType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)type));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VerifyUniqueVersionStrings_Private_Static_Void_fsVersionedType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsVersionManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

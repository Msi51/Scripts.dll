using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public static class LinkUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stringCategoryMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_categoryStringMap;

	private static readonly System.IntPtr NativeMethodInfoPtr_setupMappings_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseLink_Public_Static_Boolean_String_byref_CatalogueCategory_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringForCategory_Public_Static_String_CatalogueCategory_0;

	public unsafe static Dictionary<string, CatalogueCategory> stringCategoryMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stringCategoryMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, CatalogueCategory>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stringCategoryMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<CatalogueCategory, string> categoryStringMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_categoryStringMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CatalogueCategory, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_categoryStringMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static LinkUtil()
	{
		Il2CppClassPointerStore<LinkUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "LinkUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkUtil>.NativeClassPtr);
		NativeFieldInfoPtr_stringCategoryMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkUtil>.NativeClassPtr, "stringCategoryMap");
		NativeFieldInfoPtr_categoryStringMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkUtil>.NativeClassPtr, "categoryStringMap");
		NativeMethodInfoPtr_setupMappings_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkUtil>.NativeClassPtr, 100667769);
		NativeMethodInfoPtr_TryParseLink_Public_Static_Boolean_String_byref_CatalogueCategory_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkUtil>.NativeClassPtr, 100667770);
		NativeMethodInfoPtr_StringForCategory_Public_Static_String_CatalogueCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkUtil>.NativeClassPtr, 100667771);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 82326, RefRangeEnd = 82333, XrefRangeStart = 82287, XrefRangeEnd = 82326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setupMappings()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setupMappings_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 82346, RefRangeEnd = 82347, XrefRangeStart = 82333, XrefRangeEnd = 82346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseLink(string link, out CatalogueCategory category, out string identifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(link);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref category);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseLink_Public_Static_Boolean_String_byref_CatalogueCategory_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		identifier = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82347, XrefRangeEnd = 82355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StringForCategory(CatalogueCategory category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&category);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringForCategory_Public_Static_String_CatalogueCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public LinkUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

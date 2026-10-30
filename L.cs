using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public static class L : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MISSING_LOCALIZATION_PLACEHOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_localizationInfoMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_localizationMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_newKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_language;

	private static readonly System.IntPtr NativeFieldInfoPtr_genderEndingRules;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenderSuffix_Public_Static_String_GrammaticalGender_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenderedKey_Public_Static_String_String_GrammaticalGender_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpeakerGenderedKey_Public_Static_String_String_GrammaticalGender_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValueWithKeyNormalization_Private_Static_Boolean_String_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetInfoWithKeyNormalization_Private_Static_Boolean_String_byref_LocalizationInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_T_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_T_Public_Static_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_T_Public_Static_String_String_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_T_Public_Static_String_String_Object_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tp_Public_Static_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tg_Public_Static_String_String_GrammaticalGender_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Te_Public_Static_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_G_Public_Static_GrammaticalGender_String_0;

	public unsafe static string MISSING_LOCALIZATION_PLACEHOLDER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MISSING_LOCALIZATION_PLACEHOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MISSING_LOCALIZATION_PLACEHOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Dictionary<string, LocalizationInfo> localizationInfoMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_localizationInfoMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, LocalizationInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_localizationInfoMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<string, string> localizationMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_localizationMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_localizationMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static List<string> newKeys
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_newKeys, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_newKeys, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static string language
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_language, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_language, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Dictionary<string, Dictionary<string, GrammaticalGender>> genderEndingRules
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_genderEndingRules, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Dictionary<string, GrammaticalGender>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_genderEndingRules, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static L()
	{
		Il2CppClassPointerStore<L>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "L");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<L>.NativeClassPtr);
		NativeFieldInfoPtr_MISSING_LOCALIZATION_PLACEHOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "MISSING_LOCALIZATION_PLACEHOLDER");
		NativeFieldInfoPtr_localizationInfoMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "localizationInfoMap");
		NativeFieldInfoPtr_localizationMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "localizationMap");
		NativeFieldInfoPtr_newKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "newKeys");
		NativeFieldInfoPtr_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "language");
		NativeFieldInfoPtr_genderEndingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<L>.NativeClassPtr, "genderEndingRules");
		NativeMethodInfoPtr_GetGenderSuffix_Public_Static_String_GrammaticalGender_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676224);
		NativeMethodInfoPtr_GetGenderedKey_Public_Static_String_String_GrammaticalGender_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676225);
		NativeMethodInfoPtr_GetSpeakerGenderedKey_Public_Static_String_String_GrammaticalGender_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676226);
		NativeMethodInfoPtr_TryGetValueWithKeyNormalization_Private_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676227);
		NativeMethodInfoPtr_TryGetInfoWithKeyNormalization_Private_Static_Boolean_String_byref_LocalizationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676228);
		NativeMethodInfoPtr_T_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676229);
		NativeMethodInfoPtr_T_Public_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676230);
		NativeMethodInfoPtr_T_Public_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676231);
		NativeMethodInfoPtr_T_Public_Static_String_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676232);
		NativeMethodInfoPtr_Tp_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676233);
		NativeMethodInfoPtr_Tg_Public_Static_String_String_GrammaticalGender_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676234);
		NativeMethodInfoPtr_Te_Public_Static_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676235);
		NativeMethodInfoPtr_G_Public_Static_GrammaticalGender_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<L>.NativeClassPtr, 100676236);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 175628, RefRangeEnd = 175630, XrefRangeStart = 175624, XrefRangeEnd = 175628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetGenderSuffix(GrammaticalGender grammaticalGender, bool includeNeuter = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&grammaticalGender);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeNeuter;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenderSuffix_Public_Static_String_GrammaticalGender_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175630, XrefRangeEnd = 175637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetGenderedKey(string keyBase, GrammaticalGender grammaticalGender, bool includeNeuter = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyBase);
		*(GrammaticalGender**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &grammaticalGender;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeNeuter;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenderedKey_Public_Static_String_String_GrammaticalGender_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 175644, RefRangeEnd = 175645, XrefRangeStart = 175637, XrefRangeEnd = 175644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetSpeakerGenderedKey(string keyBase, GrammaticalGender grammaticalGender, bool includeNeuter = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyBase);
		*(GrammaticalGender**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &grammaticalGender;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeNeuter;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpeakerGenderedKey_Public_Static_String_String_GrammaticalGender_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 175662, RefRangeEnd = 175670, XrefRangeStart = 175645, XrefRangeEnd = 175662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetValueWithKeyNormalization(string key, out string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetValueWithKeyNormalization_Private_Static_Boolean_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		value = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 175687, RefRangeEnd = 175696, XrefRangeStart = 175670, XrefRangeEnd = 175687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetInfoWithKeyNormalization(string key, out LocalizationInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetInfoWithKeyNormalization_Private_Static_Boolean_String_byref_LocalizationInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		info = ((num3 == 0) ? null : new LocalizationInfo(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1180)]
	[CachedScanResults(RefRangeStart = 175710, RefRangeEnd = 176890, XrefRangeStart = 175696, XrefRangeEnd = 175710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string T(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_T_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(153)]
	[CachedScanResults(RefRangeStart = 176904, RefRangeEnd = 177057, XrefRangeStart = 176890, XrefRangeEnd = 176904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string T(string key, Il2CppSystem.Object arg0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_T_Public_Static_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 177071, RefRangeEnd = 177091, XrefRangeStart = 177057, XrefRangeEnd = 177071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string T(string key, Il2CppSystem.Object arg0, Il2CppSystem.Object arg1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_T_Public_Static_String_String_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 177110, RefRangeEnd = 177113, XrefRangeStart = 177091, XrefRangeEnd = 177110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string T(string key, Il2CppSystem.Object arg0, Il2CppSystem.Object arg1, Il2CppSystem.Object arg2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arg2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_T_Public_Static_String_String_Object_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177136, RefRangeEnd = 177137, XrefRangeStart = 177113, XrefRangeEnd = 177136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Tp(string keyBase, int amount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyBase);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tp_Public_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 177164, RefRangeEnd = 177171, XrefRangeStart = 177137, XrefRangeEnd = 177164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Tg(string keyBase, GrammaticalGender grammaticalGender, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> formatValues)
	{
		if (formatValues == null)
		{
			formatValues = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keyBase);
		*(GrammaticalGender**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &grammaticalGender;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatValues);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tg_Public_Static_String_String_GrammaticalGender_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 177207, RefRangeEnd = 177241, XrefRangeStart = 177171, XrefRangeEnd = 177207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Te(string key, string englishValue, bool forceUpdate = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(englishValue);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceUpdate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Te_Public_Static_String_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 177282, RefRangeEnd = 177287, XrefRangeStart = 177241, XrefRangeEnd = 177282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GrammaticalGender G(string noun)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(noun);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_G_Public_Static_GrammaticalGender_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(GrammaticalGender*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public static string Tg(string keyBase, GrammaticalGender grammaticalGender, params Il2CppSystem.Object[] formatValues)
	{
		return Tg(keyBase, grammaticalGender, new Il2CppReferenceArray<Il2CppSystem.Object>(formatValues));
	}

	public L(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

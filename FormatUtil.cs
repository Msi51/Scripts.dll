using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine;

public static class FormatUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_linkPattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_richTextPattern;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatColor_Public_Static_String_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateIdentifierLink_Public_Static_String_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateIdentifierImage_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateIdentifierImage_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateItemLink_Public_Static_String_InventoryItem_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateItemImage_Public_Static_String_InventoryItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateItemLink_Public_Static_String_InventoryItem_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSubstanceImage_Public_Static_String_Substance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateConstructionLink_Public_Static_String_Construction_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateConstructionLink_Public_Static_String_Construction_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInjuryLink_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StripLinks_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StripRichText_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Round_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundAndFormatValue_Public_Static_String_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToJSON_Public_Static_String_Vector3_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToJSON_Public_Static_String_Quaternion_String_0;

	public unsafe static Regex linkPattern
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_linkPattern, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_linkPattern, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex));
		}
	}

	public unsafe static Regex richTextPattern
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_richTextPattern, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_richTextPattern, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex));
		}
	}

	static FormatUtil()
	{
		Il2CppClassPointerStore<FormatUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "FormatUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr);
		NativeFieldInfoPtr_linkPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, "linkPattern");
		NativeFieldInfoPtr_richTextPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, "richTextPattern");
		NativeMethodInfoPtr_FormatColor_Public_Static_String_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667734);
		NativeMethodInfoPtr_CreateIdentifierLink_Public_Static_String_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667735);
		NativeMethodInfoPtr_CreateIdentifierImage_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667736);
		NativeMethodInfoPtr_CreateIdentifierImage_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667737);
		NativeMethodInfoPtr_CreateItemLink_Public_Static_String_InventoryItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667738);
		NativeMethodInfoPtr_CreateItemImage_Public_Static_String_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667739);
		NativeMethodInfoPtr_CreateItemLink_Public_Static_String_InventoryItem_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667740);
		NativeMethodInfoPtr_CreateSubstanceImage_Public_Static_String_Substance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667741);
		NativeMethodInfoPtr_CreateConstructionLink_Public_Static_String_Construction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667742);
		NativeMethodInfoPtr_CreateConstructionLink_Public_Static_String_Construction_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667743);
		NativeMethodInfoPtr_CreateInjuryLink_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667744);
		NativeMethodInfoPtr_StripLinks_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667745);
		NativeMethodInfoPtr_StripRichText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667746);
		NativeMethodInfoPtr_Round_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667747);
		NativeMethodInfoPtr_RoundAndFormatValue_Public_Static_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667748);
		NativeMethodInfoPtr_ToJSON_Public_Static_String_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667749);
		NativeMethodInfoPtr_ToJSON_Public_Static_String_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatUtil>.NativeClassPtr, 100667750);
	}

	[CallerCount(46)]
	[CachedScanResults(RefRangeStart = 81475, RefRangeEnd = 81521, XrefRangeStart = 81439, XrefRangeEnd = 81475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatColor(string input, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatColor_Public_Static_String_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 81545, RefRangeEnd = 81550, XrefRangeStart = 81521, XrefRangeEnd = 81545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateIdentifierLink(string type, string identifier, string name, bool showImage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &showImage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateIdentifierLink_Public_Static_String_String_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 81558, RefRangeEnd = 81560, XrefRangeStart = 81550, XrefRangeEnd = 81558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateIdentifierImage(string identifier, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateIdentifierImage_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 81569, RefRangeEnd = 81571, XrefRangeStart = 81560, XrefRangeEnd = 81569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateIdentifierImage(string identifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateIdentifierImage_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 81586, RefRangeEnd = 81593, XrefRangeStart = 81571, XrefRangeEnd = 81586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateItemLink(InventoryItem item, bool showImage = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showImage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateItemLink_Public_Static_String_InventoryItem_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 81598, RefRangeEnd = 81609, XrefRangeStart = 81593, XrefRangeEnd = 81598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateItemImage(InventoryItem item)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateItemImage_Public_Static_String_InventoryItem_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 81625, RefRangeEnd = 81627, XrefRangeStart = 81609, XrefRangeEnd = 81625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateItemLink(InventoryItem item, int amount, bool showImage = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showImage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateItemLink_Public_Static_String_InventoryItem_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 81632, RefRangeEnd = 81634, XrefRangeStart = 81627, XrefRangeEnd = 81632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateSubstanceImage(Substance substance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSubstanceImage_Public_Static_String_Substance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 81649, RefRangeEnd = 81654, XrefRangeStart = 81634, XrefRangeEnd = 81649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateConstructionLink(Construction construction, bool showImage = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)construction);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &showImage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateConstructionLink_Public_Static_String_Construction_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81654, XrefRangeEnd = 81670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateConstructionLink(Construction construction, int amount, bool showImage = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)construction);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showImage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateConstructionLink_Public_Static_String_Construction_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 81694, RefRangeEnd = 81695, XrefRangeStart = 81670, XrefRangeEnd = 81694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateInjuryLink(string injuryIdentifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInjuryLink_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 81701, RefRangeEnd = 81703, XrefRangeStart = 81695, XrefRangeEnd = 81701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StripLinks(string content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StripLinks_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 81709, RefRangeEnd = 81711, XrefRangeStart = 81703, XrefRangeEnd = 81709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StripRichText(string content)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StripRichText_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 81721, RefRangeEnd = 81757, XrefRangeStart = 81711, XrefRangeEnd = 81721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Round(float input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&input);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Round_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 81774, RefRangeEnd = 81788, XrefRangeStart = 81757, XrefRangeEnd = 81774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string RoundAndFormatValue(float value, bool negativeBad = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &negativeBad;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundAndFormatValue_Public_Static_String_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81788, XrefRangeEnd = 81822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToJSON(Vector3 vector3, string key = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&vector3);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToJSON_Public_Static_String_Vector3_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81822, XrefRangeEnd = 81870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToJSON(Quaternion rotation, string key = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rotation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToJSON_Public_Static_String_Quaternion_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public FormatUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

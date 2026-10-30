using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace FullSerializer;

public static class fsJsonPrinter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_InsertSpacing_Private_Static_Void_TextWriter_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EscapeString_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildCompressedString_Private_Static_Void_fsData_TextWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildPrettyString_Private_Static_Void_fsData_TextWriter_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrettyJson_Public_Static_Void_fsData_TextWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrettyJson_Public_Static_String_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompressedJson_Public_Static_Void_fsData_StreamWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompressedJson_Public_Static_String_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertDoubleToString_Private_Static_String_Double_0;

	static fsJsonPrinter()
	{
		Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsJsonPrinter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr);
		NativeMethodInfoPtr_InsertSpacing_Private_Static_Void_TextWriter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr, 100686666);
		NativeMethodInfoPtr_EscapeString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr, 100686667);
		NativeMethodInfoPtr_BuildCompressedString_Private_Static_Void_fsData_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr, 100686668);
		NativeMethodInfoPtr_BuildPrettyString_Private_Static_Void_fsData_TextWriter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr, 100686669);
		NativeMethodInfoPtr_PrettyJson_Public_Static_Void_fsData_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr, 100686670);
		NativeMethodInfoPtr_PrettyJson_Public_Static_String_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr, 100686671);
		NativeMethodInfoPtr_CompressedJson_Public_Static_Void_fsData_StreamWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr, 100686672);
		NativeMethodInfoPtr_CompressedJson_Public_Static_String_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr, 100686673);
		NativeMethodInfoPtr_ConvertDoubleToString_Private_Static_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonPrinter>.NativeClassPtr, 100686674);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295123, XrefRangeEnd = 295125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertSpacing(TextWriter stream, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertSpacing_Private_Static_Void_TextWriter_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295125, XrefRangeEnd = 295186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EscapeString(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EscapeString_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 295235, RefRangeEnd = 295239, XrefRangeStart = 295186, XrefRangeEnd = 295235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildCompressedString(fsData data, TextWriter stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildCompressedString_Private_Static_Void_fsData_TextWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 295276, RefRangeEnd = 295279, XrefRangeStart = 295239, XrefRangeEnd = 295276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildPrettyString(fsData data, TextWriter stream, int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildPrettyString_Private_Static_Void_fsData_TextWriter_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295279, XrefRangeEnd = 295280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PrettyJson(fsData data, TextWriter outputStream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputStream);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrettyJson_Public_Static_Void_fsData_TextWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 295295, RefRangeEnd = 295297, XrefRangeStart = 295280, XrefRangeEnd = 295295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string PrettyJson(fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrettyJson_Public_Static_String_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295297, XrefRangeEnd = 295298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CompressedJson(fsData data, StreamWriter outputStream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputStream);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompressedJson_Public_Static_Void_fsData_StreamWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 295313, RefRangeEnd = 295315, XrefRangeStart = 295298, XrefRangeEnd = 295313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CompressedJson(fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompressedJson_Public_Static_String_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 295338, RefRangeEnd = 295339, XrefRangeStart = 295315, XrefRangeEnd = 295338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ConvertDoubleToString(double d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertDoubleToString_Private_Static_String_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public fsJsonPrinter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace FullSerializer;

public class fsJsonParser : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__start;

	private static readonly System.IntPtr NativeFieldInfoPtr__input;

	private static readonly System.IntPtr NativeFieldInfoPtr__cachedStringBuilder;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeFailure_Private_fsResult_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveNext_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasValue_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasValue_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Character_Private_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Character_Private_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipSpace_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHex_Private_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseSingleChar_Private_UInt32_Char_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseUnicode_Private_UInt32_Char_Char_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryUnescapeChar_Private_fsResult_byref_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseExact_Private_fsResult_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseTrue_Private_fsResult_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseFalse_Private_fsResult_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseNull_Private_fsResult_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSeparator_Private_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseNumber_Private_fsResult_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseString_Private_fsResult_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseArray_Private_fsResult_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseObject_Private_fsResult_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunParse_Private_fsResult_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_fsResult_String_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_fsData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

	public unsafe int _start
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__start);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__start)) = num;
		}
	}

	public unsafe string _input
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__input);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__input)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe StringBuilder _cachedStringBuilder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedStringBuilder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedStringBuilder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stringBuilder));
		}
	}

	static fsJsonParser()
	{
		Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsJsonParser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr);
		NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, "_start");
		NativeFieldInfoPtr__input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, "_input");
		NativeFieldInfoPtr__cachedStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, "_cachedStringBuilder");
		NativeMethodInfoPtr_MakeFailure_Private_fsResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686642);
		NativeMethodInfoPtr_TryMoveNext_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686643);
		NativeMethodInfoPtr_HasValue_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686644);
		NativeMethodInfoPtr_HasValue_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686645);
		NativeMethodInfoPtr_Character_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686646);
		NativeMethodInfoPtr_Character_Private_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686647);
		NativeMethodInfoPtr_SkipSpace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686648);
		NativeMethodInfoPtr_IsHex_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686649);
		NativeMethodInfoPtr_ParseSingleChar_Private_UInt32_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686650);
		NativeMethodInfoPtr_ParseUnicode_Private_UInt32_Char_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686651);
		NativeMethodInfoPtr_TryUnescapeChar_Private_fsResult_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686652);
		NativeMethodInfoPtr_TryParseExact_Private_fsResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686653);
		NativeMethodInfoPtr_TryParseTrue_Private_fsResult_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686654);
		NativeMethodInfoPtr_TryParseFalse_Private_fsResult_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686655);
		NativeMethodInfoPtr_TryParseNull_Private_fsResult_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686656);
		NativeMethodInfoPtr_IsSeparator_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686657);
		NativeMethodInfoPtr_TryParseNumber_Private_fsResult_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686658);
		NativeMethodInfoPtr_TryParseString_Private_fsResult_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686659);
		NativeMethodInfoPtr_TryParseArray_Private_fsResult_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686660);
		NativeMethodInfoPtr_TryParseObject_Private_fsResult_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686661);
		NativeMethodInfoPtr_RunParse_Private_fsResult_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686662);
		NativeMethodInfoPtr_Parse_Public_Static_fsResult_String_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686663);
		NativeMethodInfoPtr_Parse_Public_Static_fsData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686664);
		NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr, 100686665);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 294801, RefRangeEnd = 294805, XrefRangeStart = 294759, XrefRangeEnd = 294801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult MakeFailure(string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeFailure_Private_fsResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	public unsafe bool TryMoveNext()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryMoveNext_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool HasValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasValue_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool HasValue(int offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasValue_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294805, XrefRangeEnd = 294807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe char Character()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Character_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294807, XrefRangeEnd = 294809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe char Character(int offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&offset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Character_Private_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 294829, RefRangeEnd = 294830, XrefRangeStart = 294809, XrefRangeEnd = 294829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipSpace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipSpace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsHex(char c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHex_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe uint ParseSingleChar(char c1, uint multipliyer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c1);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &multipliyer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseSingleChar_Private_UInt32_Char_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294830, XrefRangeEnd = 294836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint ParseUnicode(char c1, char c2, char c3, char c4)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&c1);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
		*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c3;
		*(char**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &c4;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseUnicode_Private_UInt32_Char_Char_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 294846, RefRangeEnd = 294847, XrefRangeStart = 294836, XrefRangeEnd = 294846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryUnescapeChar(out char escaped)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref escaped);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryUnescapeChar_Private_fsResult_byref_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 294863, RefRangeEnd = 294869, XrefRangeStart = 294847, XrefRangeEnd = 294863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryParseExact(string content)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseExact_Private_fsResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294869, XrefRangeEnd = 294877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryParseTrue(out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseTrue_Private_fsResult_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		data = ((num2 == 0) ? null : new fsData(num2));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294877, XrefRangeEnd = 294885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryParseFalse(out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseFalse_Private_fsResult_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		data = ((num2 == 0) ? null : new fsData(num2));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294885, XrefRangeEnd = 294893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryParseNull(out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseNull_Private_fsResult_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		data = ((num2 == 0) ? null : new fsData(num2));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294893, XrefRangeEnd = 294897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSeparator(char c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSeparator_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 294937, RefRangeEnd = 294938, XrefRangeStart = 294897, XrefRangeEnd = 294937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryParseNumber(out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseNumber_Private_fsResult_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		data = ((num2 == 0) ? null : new fsData(num2));
		return new fsResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 294959, RefRangeEnd = 294960, XrefRangeStart = 294938, XrefRangeEnd = 294959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryParseString(out string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseString_Private_fsResult_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		str = IL2CPP.Il2CppStringToManaged((System.IntPtr)num);
		return new fsResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 294972, RefRangeEnd = 294973, XrefRangeStart = 294960, XrefRangeEnd = 294972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryParseArray(out fsData arr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseArray_Private_fsResult_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		arr = ((num2 == 0) ? null : new fsData(num2));
		return new fsResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 294989, RefRangeEnd = 294990, XrefRangeStart = 294973, XrefRangeEnd = 294989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryParseObject(out fsData obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseObject_Private_fsResult_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		obj = ((num2 == 0) ? null : new fsData(num2));
		return new fsResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 295072, RefRangeEnd = 295074, XrefRangeStart = 294990, XrefRangeEnd = 295072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult RunParse(out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunParse_Private_fsResult_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		data = ((num2 == 0) ? null : new fsData(num2));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295074, XrefRangeEnd = 295088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static fsResult Parse(string input, out fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_fsResult_String_byref_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		data = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 295114, RefRangeEnd = 295116, XrefRangeStart = 295088, XrefRangeEnd = 295114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static fsData Parse(string input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_fsData_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<fsData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295116, XrefRangeEnd = 295123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsJsonParser(string input)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsJsonParser>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsJsonParser(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

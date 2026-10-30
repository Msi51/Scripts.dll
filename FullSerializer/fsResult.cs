using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace FullSerializer;

public sealed class fsResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EmptyStringArray;

	private static readonly System.IntPtr NativeFieldInfoPtr__success;

	private static readonly System.IntPtr NativeFieldInfoPtr__messages;

	private static readonly System.IntPtr NativeFieldInfoPtr_Success;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMessage_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMessages_Public_Void_fsResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Merge_Public_fsResult_fsResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Warn_Public_Static_fsResult_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Fail_Public_Static_fsResult_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_fsResult_fsResult_fsResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasWarnings_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssertSuccess_Public_fsResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssertSuccessWithoutWarnings_Public_fsResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AsException_Public_get_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RawMessages_Public_get_IEnumerable_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FormattedMessages_Public_get_String_0;

	public unsafe static Il2CppStringArray EmptyStringArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EmptyStringArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EmptyStringArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool _success
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__success);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__success)) = flag;
		}
	}

	public unsafe List<string> _messages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__messages);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__messages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static fsResult Success
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<fsResult>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Success, (void*)intPtr);
			return new fsResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<fsResult>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Success, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)fsResult2)));
		}
	}

	public unsafe bool Failed
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 295544, RefRangeEnd = 295563, XrefRangeStart = 295544, XrefRangeEnd = 295544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool Succeeded
	{
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 295563, RefRangeEnd = 295591, XrefRangeStart = 295563, XrefRangeEnd = 295563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasWarnings
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295591, XrefRangeEnd = 295592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasWarnings_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Il2CppSystem.Exception AsException
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295608, XrefRangeEnd = 295628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AsException_Public_get_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Exception>(intPtr) : null;
		}
	}

	public unsafe IEnumerable<string> RawMessages
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295628, XrefRangeEnd = 295632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RawMessages_Public_get_IEnumerable_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr) : null;
		}
	}

	public unsafe string FormattedMessages
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295646, RefRangeEnd = 295647, XrefRangeStart = 295632, XrefRangeEnd = 295646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FormattedMessages_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static fsResult()
	{
		Il2CppClassPointerStore<fsResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsResult>.NativeClassPtr);
		NativeFieldInfoPtr_EmptyStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsResult>.NativeClassPtr, "EmptyStringArray");
		NativeFieldInfoPtr__success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsResult>.NativeClassPtr, "_success");
		NativeFieldInfoPtr__messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsResult>.NativeClassPtr, "_messages");
		NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsResult>.NativeClassPtr, "Success");
		NativeMethodInfoPtr_AddMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686686);
		NativeMethodInfoPtr_AddMessages_Public_Void_fsResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686687);
		NativeMethodInfoPtr_Merge_Public_fsResult_fsResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686688);
		NativeMethodInfoPtr_Warn_Public_Static_fsResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686689);
		NativeMethodInfoPtr_Fail_Public_Static_fsResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686690);
		NativeMethodInfoPtr_op_Addition_Public_Static_fsResult_fsResult_fsResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686691);
		NativeMethodInfoPtr_get_Failed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686692);
		NativeMethodInfoPtr_get_Succeeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686693);
		NativeMethodInfoPtr_get_HasWarnings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686694);
		NativeMethodInfoPtr_AssertSuccess_Public_fsResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686695);
		NativeMethodInfoPtr_AssertSuccessWithoutWarnings_Public_fsResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686696);
		NativeMethodInfoPtr_get_AsException_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686697);
		NativeMethodInfoPtr_get_RawMessages_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686698);
		NativeMethodInfoPtr_get_FormattedMessages_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsResult>.NativeClassPtr, 100686699);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 295364, RefRangeEnd = 295367, XrefRangeStart = 295353, XrefRangeEnd = 295364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMessage(string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMessage_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 295377, RefRangeEnd = 295387, XrefRangeStart = 295367, XrefRangeEnd = 295377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMessages(fsResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMessages_Public_Void_fsResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295387, XrefRangeEnd = 295393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult Merge(fsResult other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Merge_Public_fsResult_fsResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295393, XrefRangeEnd = 295403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static fsResult Warn(string warning)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(warning);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Warn_Public_Static_fsResult_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 295413, RefRangeEnd = 295425, XrefRangeStart = 295403, XrefRangeEnd = 295413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static fsResult Fail(string warning)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(warning);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Fail_Public_Static_fsResult_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(110)]
	[CachedScanResults(RefRangeStart = 295434, RefRangeEnd = 295544, XrefRangeStart = 295425, XrefRangeEnd = 295434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static fsResult operator +(fsResult a, fsResult b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_fsResult_fsResult_fsResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295592, XrefRangeEnd = 295595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult AssertSuccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssertSuccess_Public_fsResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295595, XrefRangeEnd = 295608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult AssertSuccessWithoutWarnings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssertSuccessWithoutWarnings_Public_fsResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	public fsResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public fsResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsResult>.NativeClassPtr))
	{
	}
}

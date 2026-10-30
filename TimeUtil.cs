using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class TimeUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Deg2Rad;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSeconds_Public_Static_String_Single_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSecondsWithHours_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSecondsAsHoursAndMinutes_Public_Static_String_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSecondsAsHoursAndMinutes_Public_Static_String_Single_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSecondsAsWeeksDaysHours_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSecondsAsHours_Public_Static_String_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatDateTimeAgo_Public_Static_String_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSunPosition_Public_Static_ValueTuple_2_Double_Double_DateTime_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CorrectAngle_Private_Static_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UnscaledDeltaTimeWithPause_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static double Deg2Rad
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Deg2Rad, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Deg2Rad, (void*)(&num));
		}
	}

	public unsafe static float UnscaledDeltaTimeWithPause
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 85962, RefRangeEnd = 85969, XrefRangeStart = 85960, XrefRangeEnd = 85962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UnscaledDeltaTimeWithPause_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static TimeUtil()
	{
		Il2CppClassPointerStore<TimeUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TimeUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr);
		NativeFieldInfoPtr_Deg2Rad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, "Deg2Rad");
		NativeMethodInfoPtr_FormatSeconds_Public_Static_String_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667945);
		NativeMethodInfoPtr_FormatSecondsWithHours_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667946);
		NativeMethodInfoPtr_FormatSecondsAsHoursAndMinutes_Public_Static_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667947);
		NativeMethodInfoPtr_FormatSecondsAsHoursAndMinutes_Public_Static_String_Single_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667948);
		NativeMethodInfoPtr_FormatSecondsAsWeeksDaysHours_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667949);
		NativeMethodInfoPtr_FormatSecondsAsHours_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667950);
		NativeMethodInfoPtr_FormatDateTimeAgo_Public_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667951);
		NativeMethodInfoPtr_CalculateSunPosition_Public_Static_ValueTuple_2_Double_Double_DateTime_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667952);
		NativeMethodInfoPtr_CorrectAngle_Private_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667953);
		NativeMethodInfoPtr_get_UnscaledDeltaTimeWithPause_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667954);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr, 100667955);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85703, XrefRangeEnd = 85713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatSeconds(float seconds, int digits, bool showMinutes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&seconds);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &showMinutes;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSeconds_Public_Static_String_Single_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85713, XrefRangeEnd = 85723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatSecondsWithHours(float seconds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&seconds);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSecondsWithHours_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 85724, RefRangeEnd = 85728, XrefRangeStart = 85723, XrefRangeEnd = 85724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatSecondsAsHoursAndMinutes(float seconds, float hourCap)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&seconds);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hourCap;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSecondsAsHoursAndMinutes_Public_Static_String_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 85754, RefRangeEnd = 85792, XrefRangeStart = 85728, XrefRangeEnd = 85754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatSecondsAsHoursAndMinutes(float seconds, bool alwaysShowHours = true, float hourCap = 100f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&seconds);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alwaysShowHours;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hourCap;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSecondsAsHoursAndMinutes_Public_Static_String_Single_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85847, RefRangeEnd = 85848, XrefRangeStart = 85792, XrefRangeEnd = 85847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatSecondsAsWeeksDaysHours(float seconds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&seconds);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSecondsAsWeeksDaysHours_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 85862, RefRangeEnd = 85864, XrefRangeStart = 85848, XrefRangeEnd = 85862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatSecondsAsHours(float seconds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&seconds);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSecondsAsHours_Public_Static_String_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 85891, RefRangeEnd = 85895, XrefRangeStart = 85864, XrefRangeEnd = 85891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string FormatDateTimeAgo(Il2CppSystem.DateTime dateTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatDateTimeAgo_Public_Static_String_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 85946, RefRangeEnd = 85951, XrefRangeStart = 85895, XrefRangeEnd = 85946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<double, double> CalculateSunPosition(Il2CppSystem.DateTime dateTime, double latitude, double longitude)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&dateTime);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &latitude;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &longitude;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSunPosition_Public_Static_ValueTuple_2_Double_Double_DateTime_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<double, double>(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 85956, RefRangeEnd = 85960, XrefRangeStart = 85951, XrefRangeEnd = 85956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double CorrectAngle(double angleInRadians)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angleInRadians);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CorrectAngle_Private_Static_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeUtil()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeUtil>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TimeUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

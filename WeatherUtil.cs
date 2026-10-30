using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class WeatherUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_WEATHER_LATITUDE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DAY_OF_PEAK_TEMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_MID_SPRING_DAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MID_FALL_DAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_SEASON_LENGTH_DAYS;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateTemperature_Public_Static_Single_DateTime_WeatherStateHistoryData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSeasonTemperatureFactor_Public_Static_Single_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getSeasonPercentage_Private_Static_Single_DateTime_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpringPercentage_Public_Static_Single_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFallPercentage_Public_Static_Single_DateTime_0;

	public unsafe static float WEATHER_LATITUDE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WEATHER_LATITUDE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WEATHER_LATITUDE, (void*)(&num));
		}
	}

	public unsafe static float DAY_OF_PEAK_TEMP
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DAY_OF_PEAK_TEMP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DAY_OF_PEAK_TEMP, (void*)(&num));
		}
	}

	public unsafe static float MID_SPRING_DAY
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MID_SPRING_DAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MID_SPRING_DAY, (void*)(&num));
		}
	}

	public unsafe static float MID_FALL_DAY
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MID_FALL_DAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MID_FALL_DAY, (void*)(&num));
		}
	}

	public unsafe static float SEASON_LENGTH_DAYS
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SEASON_LENGTH_DAYS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SEASON_LENGTH_DAYS, (void*)(&num));
		}
	}

	static WeatherUtil()
	{
		Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WeatherUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr);
		NativeFieldInfoPtr_WEATHER_LATITUDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr, "WEATHER_LATITUDE");
		NativeFieldInfoPtr_DAY_OF_PEAK_TEMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr, "DAY_OF_PEAK_TEMP");
		NativeFieldInfoPtr_MID_SPRING_DAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr, "MID_SPRING_DAY");
		NativeFieldInfoPtr_MID_FALL_DAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr, "MID_FALL_DAY");
		NativeFieldInfoPtr_SEASON_LENGTH_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr, "SEASON_LENGTH_DAYS");
		NativeMethodInfoPtr_CalculateTemperature_Public_Static_Single_DateTime_WeatherStateHistoryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr, 100667963);
		NativeMethodInfoPtr_GetSeasonTemperatureFactor_Public_Static_Single_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr, 100667964);
		NativeMethodInfoPtr_getSeasonPercentage_Private_Static_Single_DateTime_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr, 100667965);
		NativeMethodInfoPtr_GetSpringPercentage_Public_Static_Single_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr, 100667966);
		NativeMethodInfoPtr_GetFallPercentage_Public_Static_Single_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherUtil>.NativeClassPtr, 100667967);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 86056, RefRangeEnd = 86057, XrefRangeStart = 86027, XrefRangeEnd = 86056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalculateTemperature(Il2CppSystem.DateTime dateTime, WeatherStateHistoryData pastDayHistoryData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dateTime);
		*(WeatherStateHistoryData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pastDayHistoryData;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateTemperature_Public_Static_Single_DateTime_WeatherStateHistoryData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 86068, RefRangeEnd = 86070, XrefRangeStart = 86057, XrefRangeEnd = 86068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetSeasonTemperatureFactor(Il2CppSystem.DateTime dateTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSeasonTemperatureFactor_Public_Static_Single_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 86088, RefRangeEnd = 86090, XrefRangeStart = 86070, XrefRangeEnd = 86088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float getSeasonPercentage(Il2CppSystem.DateTime dateTime, float midSeasonDay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dateTime);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &midSeasonDay;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getSeasonPercentage_Private_Static_Single_DateTime_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 86091, RefRangeEnd = 86092, XrefRangeStart = 86090, XrefRangeEnd = 86091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetSpringPercentage(Il2CppSystem.DateTime dateTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpringPercentage_Public_Static_Single_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 86093, RefRangeEnd = 86094, XrefRangeStart = 86092, XrefRangeEnd = 86093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetFallPercentage(Il2CppSystem.DateTime dateTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFallPercentage_Public_Static_Single_DateTime_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public WeatherUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct WeatherStateHistoryData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_overallTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalRainTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalSnowTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalCloudTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalDiseaseStormTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RainPercentage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SnowPercentage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CloudPercentage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DiseaseStormPercentage_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	[FieldOffset(0)]
	public float overallTime;

	[FieldOffset(4)]
	public float totalRainTime;

	[FieldOffset(8)]
	public float totalSnowTime;

	[FieldOffset(12)]
	public float totalCloudTime;

	[FieldOffset(16)]
	public float totalDiseaseStormTime;

	public unsafe float RainPercentage
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RainPercentage_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float SnowPercentage
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SnowPercentage_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float CloudPercentage
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261517, RefRangeEnd = 261518, XrefRangeStart = 261517, XrefRangeEnd = 261517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CloudPercentage_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float DiseaseStormPercentage
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DiseaseStormPercentage_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static WeatherStateHistoryData()
	{
		Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WeatherStateHistoryData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr);
		NativeFieldInfoPtr_overallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, "overallTime");
		NativeFieldInfoPtr_totalRainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, "totalRainTime");
		NativeFieldInfoPtr_totalSnowTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, "totalSnowTime");
		NativeFieldInfoPtr_totalCloudTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, "totalCloudTime");
		NativeFieldInfoPtr_totalDiseaseStormTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, "totalDiseaseStormTime");
		NativeMethodInfoPtr_get_RainPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, 100683387);
		NativeMethodInfoPtr_get_SnowPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, 100683388);
		NativeMethodInfoPtr_get_CloudPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, 100683389);
		NativeMethodInfoPtr_get_DiseaseStormPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, 100683390);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, 100683391);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261518, XrefRangeEnd = 261553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WeatherStateHistoryData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

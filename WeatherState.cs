using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;
using UnityEngine;

[System.Serializable]
public class WeatherState : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<WeatherState>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_targetRainIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentRainIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_rainStartDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_remainingRainFreeTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetSnowIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSnowIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseStormIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetDiseaseStormIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastDiseaseStormTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_duration;

	private static readonly System.IntPtr NativeFieldInfoPtr_remainingTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalTimeElapsed;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetCloudPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentCloudPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxWindIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_minWindIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_windIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetWindDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_windDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_accumulatedWind;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float targetRainIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetRainIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetRainIntensity)) = num;
		}
	}

	public unsafe float currentRainIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentRainIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentRainIntensity)) = num;
		}
	}

	public unsafe float rainStartDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainStartDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainStartDelay)) = num;
		}
	}

	public unsafe float remainingRainFreeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingRainFreeTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingRainFreeTime)) = num;
		}
	}

	public unsafe float targetSnowIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSnowIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSnowIntensity)) = num;
		}
	}

	public unsafe float currentSnowIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSnowIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSnowIntensity)) = num;
		}
	}

	public unsafe float diseaseStormIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseStormIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseStormIntensity)) = num;
		}
	}

	public unsafe float targetDiseaseStormIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetDiseaseStormIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetDiseaseStormIntensity)) = num;
		}
	}

	public unsafe Il2CppSystem.DateTime lastDiseaseStormTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDiseaseStormTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDiseaseStormTime)) = dateTime;
		}
	}

	public unsafe float duration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration)) = num;
		}
	}

	public unsafe float remainingTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingTime)) = num;
		}
	}

	public unsafe float totalTimeElapsed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalTimeElapsed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalTimeElapsed)) = num;
		}
	}

	public unsafe float targetCloudPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetCloudPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetCloudPercentage)) = num;
		}
	}

	public unsafe float currentCloudPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCloudPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCloudPercentage)) = num;
		}
	}

	public unsafe float maxWindIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWindIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxWindIntensity)) = num;
		}
	}

	public unsafe float minWindIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minWindIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minWindIntensity)) = num;
		}
	}

	public unsafe float windIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windIntensity)) = num;
		}
	}

	public unsafe Vector3 targetWindDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetWindDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetWindDirection)) = vector;
		}
	}

	public unsafe Vector3 windDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windDirection)) = vector;
		}
	}

	public unsafe Vector2 accumulatedWind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accumulatedWind);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accumulatedWind)) = vector;
		}
	}

	static WeatherState()
	{
		Il2CppClassPointerStore<WeatherState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WeatherState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherState>.NativeClassPtr);
		NativeFieldInfoPtr_targetRainIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "targetRainIntensity");
		NativeFieldInfoPtr_currentRainIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "currentRainIntensity");
		NativeFieldInfoPtr_rainStartDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "rainStartDelay");
		NativeFieldInfoPtr_remainingRainFreeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "remainingRainFreeTime");
		NativeFieldInfoPtr_targetSnowIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "targetSnowIntensity");
		NativeFieldInfoPtr_currentSnowIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "currentSnowIntensity");
		NativeFieldInfoPtr_diseaseStormIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "diseaseStormIntensity");
		NativeFieldInfoPtr_targetDiseaseStormIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "targetDiseaseStormIntensity");
		NativeFieldInfoPtr_lastDiseaseStormTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "lastDiseaseStormTime");
		NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "duration");
		NativeFieldInfoPtr_remainingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "remainingTime");
		NativeFieldInfoPtr_totalTimeElapsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "totalTimeElapsed");
		NativeFieldInfoPtr_targetCloudPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "targetCloudPercentage");
		NativeFieldInfoPtr_currentCloudPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "currentCloudPercentage");
		NativeFieldInfoPtr_maxWindIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "maxWindIntensity");
		NativeFieldInfoPtr_minWindIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "minWindIntensity");
		NativeFieldInfoPtr_windIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "windIntensity");
		NativeFieldInfoPtr_targetWindDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "targetWindDirection");
		NativeFieldInfoPtr_windDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "windDirection");
		NativeFieldInfoPtr_accumulatedWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, "accumulatedWind");
		NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, 100683383);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, 100683384);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherState>.NativeClassPtr, 100683385);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 261495, RefRangeEnd = 261497, XrefRangeStart = 261458, XrefRangeEnd = 261495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update(float deltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deltaTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261497, XrefRangeEnd = 261517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WeatherState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WeatherState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

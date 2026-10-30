using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class WeatherStateHistory : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_startWorldDateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_endWorldDateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherState;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppSystem.DateTime startWorldDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startWorldDateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startWorldDateTime)) = dateTime;
		}
	}

	public unsafe Il2CppSystem.DateTime endWorldDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endWorldDateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endWorldDateTime)) = dateTime;
		}
	}

	public unsafe WeatherState weatherState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WeatherState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)weatherState));
		}
	}

	static WeatherStateHistory()
	{
		Il2CppClassPointerStore<WeatherStateHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WeatherStateHistory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherStateHistory>.NativeClassPtr);
		NativeFieldInfoPtr_startWorldDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherStateHistory>.NativeClassPtr, "startWorldDateTime");
		NativeFieldInfoPtr_endWorldDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherStateHistory>.NativeClassPtr, "endWorldDateTime");
		NativeFieldInfoPtr_weatherState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherStateHistory>.NativeClassPtr, "weatherState");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherStateHistory>.NativeClassPtr, 100683386);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WeatherStateHistory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherStateHistory>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WeatherStateHistory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

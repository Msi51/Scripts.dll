using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class AIReputationEvent : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_defaultExpiry;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventType;

	private static readonly System.IntPtr NativeFieldInfoPtr_value;

	private static readonly System.IntPtr NativeFieldInfoPtr_dateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_expiry;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReputationEventType_Single_DateTime_Nullable_1_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsExpired_Public_Boolean_DateTime_0;

	public unsafe static Il2CppSystem.TimeSpan defaultExpiry
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultExpiry, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultExpiry, (void*)(&timeSpan));
		}
	}

	public unsafe ReputationEventType eventType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventType);
			return *(ReputationEventType*)num;
		}
		set
		{
			*(ReputationEventType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventType)) = reputationEventType;
		}
	}

	public unsafe float value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = num;
		}
	}

	public unsafe Il2CppSystem.DateTime dateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateTime)) = dateTime;
		}
	}

	public unsafe Il2CppSystem.TimeSpan expiry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expiry);
			return *(Il2CppSystem.TimeSpan*)num;
		}
		set
		{
			*(Il2CppSystem.TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expiry)) = timeSpan;
		}
	}

	static AIReputationEvent()
	{
		Il2CppClassPointerStore<AIReputationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AIReputationEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIReputationEvent>.NativeClassPtr);
		NativeFieldInfoPtr_defaultExpiry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIReputationEvent>.NativeClassPtr, "defaultExpiry");
		NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIReputationEvent>.NativeClassPtr, "eventType");
		NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIReputationEvent>.NativeClassPtr, "value");
		NativeFieldInfoPtr_dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIReputationEvent>.NativeClassPtr, "dateTime");
		NativeFieldInfoPtr_expiry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIReputationEvent>.NativeClassPtr, "expiry");
		NativeMethodInfoPtr__ctor_Public_Void_ReputationEventType_Single_DateTime_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIReputationEvent>.NativeClassPtr, 100668545);
		NativeMethodInfoPtr_IsExpired_Public_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIReputationEvent>.NativeClassPtr, 100668546);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 93111, RefRangeEnd = 93117, XrefRangeStart = 93103, XrefRangeEnd = 93111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIReputationEvent(ReputationEventType eventType, float value, Il2CppSystem.DateTime dateTime, Il2CppSystem.Nullable<Il2CppSystem.TimeSpan> expiry = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIReputationEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&eventType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(Il2CppSystem.DateTime**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dateTime;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)expiry));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ReputationEventType_Single_DateTime_Nullable_1_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93117, XrefRangeEnd = 93131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsExpired(Il2CppSystem.DateTime currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsExpired_Public_Boolean_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public AIReputationEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

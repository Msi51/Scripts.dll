using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class AIReputation : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_characterInstanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_events;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdated;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEvent_Public_Void_AIReputationEvent_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateReputation_Public_Single_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int characterInstanceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInstanceId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterInstanceId)) = num;
		}
	}

	public unsafe List<AIReputationEvent> events
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_events);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIReputationEvent>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_events)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Il2CppSystem.DateTime lastUpdated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdated);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdated)) = dateTime;
		}
	}

	static AIReputation()
	{
		Il2CppClassPointerStore<AIReputation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AIReputation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIReputation>.NativeClassPtr);
		NativeFieldInfoPtr_characterInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIReputation>.NativeClassPtr, "characterInstanceId");
		NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIReputation>.NativeClassPtr, "events");
		NativeFieldInfoPtr_lastUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIReputation>.NativeClassPtr, "lastUpdated");
		NativeMethodInfoPtr_AddEvent_Public_Void_AIReputationEvent_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIReputation>.NativeClassPtr, 100668542);
		NativeMethodInfoPtr_CalculateReputation_Public_Single_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIReputation>.NativeClassPtr, 100668543);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIReputation>.NativeClassPtr, 100668544);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 93068, RefRangeEnd = 93074, XrefRangeStart = 93065, XrefRangeEnd = 93068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddEvent(AIReputationEvent reputationEvent, Il2CppSystem.DateTime currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reputationEvent);
		*(Il2CppSystem.DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEvent_Public_Void_AIReputationEvent_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93092, RefRangeEnd = 93093, XrefRangeStart = 93074, XrefRangeEnd = 93092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateReputation(Il2CppSystem.DateTime currentTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateReputation_Public_Single_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93102, RefRangeEnd = 93103, XrefRangeStart = 93093, XrefRangeEnd = 93102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIReputation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIReputation>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AIReputation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

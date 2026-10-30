using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class SurvivorCampConditions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_minDistanceToStartingChunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDistanceToStartingChunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredWorldEvents;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int minDistanceToStartingChunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistanceToStartingChunk);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistanceToStartingChunk)) = num;
		}
	}

	public unsafe int maxDistanceToStartingChunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDistanceToStartingChunk);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDistanceToStartingChunk)) = num;
		}
	}

	public unsafe List<WorldEventType> requiredWorldEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredWorldEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldEventType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredWorldEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static SurvivorCampConditions()
	{
		Il2CppClassPointerStore<SurvivorCampConditions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SurvivorCampConditions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurvivorCampConditions>.NativeClassPtr);
		NativeFieldInfoPtr_minDistanceToStartingChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampConditions>.NativeClassPtr, "minDistanceToStartingChunk");
		NativeFieldInfoPtr_maxDistanceToStartingChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampConditions>.NativeClassPtr, "maxDistanceToStartingChunk");
		NativeFieldInfoPtr_requiredWorldEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampConditions>.NativeClassPtr, "requiredWorldEvents");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampConditions>.NativeClassPtr, 100670404);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampConditions>.NativeClassPtr, 100670405);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120208, XrefRangeEnd = 120235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SurvivorCampConditions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurvivorCampConditions>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SurvivorCampConditions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

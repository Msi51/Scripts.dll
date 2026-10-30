using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class SurvivorCampPlacementRules : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_minDistanceToStartingChunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_minDistanceToOtherCamps;

	private static readonly System.IntPtr NativeFieldInfoPtr_minDistanceToStructures;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresWaterNearby;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSlope;

	private static readonly System.IntPtr NativeFieldInfoPtr_forbiddenTextures;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearanceRadius;

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

	public unsafe int minDistanceToOtherCamps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistanceToOtherCamps);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistanceToOtherCamps)) = num;
		}
	}

	public unsafe int minDistanceToStructures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistanceToStructures);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minDistanceToStructures)) = num;
		}
	}

	public unsafe bool requiresWaterNearby
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresWaterNearby);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresWaterNearby)) = flag;
		}
	}

	public unsafe float maxSlope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlope);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlope)) = num;
		}
	}

	public unsafe List<TextureType> forbiddenTextures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbiddenTextures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TextureType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbiddenTextures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float clearanceRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearanceRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearanceRadius)) = num;
		}
	}

	static SurvivorCampPlacementRules()
	{
		Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SurvivorCampPlacementRules");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr);
		NativeFieldInfoPtr_minDistanceToStartingChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr, "minDistanceToStartingChunk");
		NativeFieldInfoPtr_minDistanceToOtherCamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr, "minDistanceToOtherCamps");
		NativeFieldInfoPtr_minDistanceToStructures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr, "minDistanceToStructures");
		NativeFieldInfoPtr_requiresWaterNearby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr, "requiresWaterNearby");
		NativeFieldInfoPtr_maxSlope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr, "maxSlope");
		NativeFieldInfoPtr_forbiddenTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr, "forbiddenTextures");
		NativeFieldInfoPtr_clearanceRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr, "clearanceRadius");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr, 100670397);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr, 100670398);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120033, XrefRangeEnd = 120091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe SurvivorCampPlacementRules()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurvivorCampPlacementRules>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SurvivorCampPlacementRules(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

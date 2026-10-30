using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Netcode;

[System.Serializable]
public class AdvancedGameOptions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseType;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingDiseaseLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseGrowthRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_creatureDiseaseFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseStormRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_plantGrowthRateFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingPassiveCreatureCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingHostileCreatureCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitHostileCreatures;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHostileCreatureCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_hostileCreatureSpawnDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_hostileCreatureAggressiveness;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirstFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_hungerFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_decayRateFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_rainChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_hostileCampChance;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCopy_Public_AdvancedGameOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameDiseaseType diseaseType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseType);
			return *(GameDiseaseType*)num;
		}
		set
		{
			*(GameDiseaseType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseType)) = gameDiseaseType;
		}
	}

	public unsafe float startingDiseaseLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDiseaseLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDiseaseLevel)) = num;
		}
	}

	public unsafe float diseaseGrowthRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseGrowthRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseGrowthRate)) = num;
		}
	}

	public unsafe float creatureDiseaseFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creatureDiseaseFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creatureDiseaseFactor)) = num;
		}
	}

	public unsafe float diseaseStormRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseStormRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseStormRate)) = num;
		}
	}

	public unsafe float plantGrowthRateFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plantGrowthRateFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plantGrowthRateFactor)) = num;
		}
	}

	public unsafe int startingPassiveCreatureCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPassiveCreatureCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPassiveCreatureCount)) = num;
		}
	}

	public unsafe int startingHostileCreatureCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingHostileCreatureCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingHostileCreatureCount)) = num;
		}
	}

	public unsafe bool limitHostileCreatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitHostileCreatures);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitHostileCreatures)) = flag;
		}
	}

	public unsafe int maxHostileCreatureCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHostileCreatureCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHostileCreatureCount)) = num;
		}
	}

	public unsafe float hostileCreatureSpawnDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostileCreatureSpawnDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostileCreatureSpawnDelay)) = num;
		}
	}

	public unsafe float hostileCreatureAggressiveness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostileCreatureAggressiveness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostileCreatureAggressiveness)) = num;
		}
	}

	public unsafe float thirstFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirstFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirstFactor)) = num;
		}
	}

	public unsafe float hungerFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hungerFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hungerFactor)) = num;
		}
	}

	public unsafe float decayRateFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decayRateFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decayRateFactor)) = num;
		}
	}

	public unsafe float rainChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainChance)) = num;
		}
	}

	public unsafe float hostileCampChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostileCampChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostileCampChance)) = num;
		}
	}

	static AdvancedGameOptions()
	{
		Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AdvancedGameOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr);
		NativeFieldInfoPtr_diseaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "diseaseType");
		NativeFieldInfoPtr_startingDiseaseLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "startingDiseaseLevel");
		NativeFieldInfoPtr_diseaseGrowthRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "diseaseGrowthRate");
		NativeFieldInfoPtr_creatureDiseaseFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "creatureDiseaseFactor");
		NativeFieldInfoPtr_diseaseStormRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "diseaseStormRate");
		NativeFieldInfoPtr_plantGrowthRateFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "plantGrowthRateFactor");
		NativeFieldInfoPtr_startingPassiveCreatureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "startingPassiveCreatureCount");
		NativeFieldInfoPtr_startingHostileCreatureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "startingHostileCreatureCount");
		NativeFieldInfoPtr_limitHostileCreatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "limitHostileCreatures");
		NativeFieldInfoPtr_maxHostileCreatureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "maxHostileCreatureCount");
		NativeFieldInfoPtr_hostileCreatureSpawnDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "hostileCreatureSpawnDelay");
		NativeFieldInfoPtr_hostileCreatureAggressiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "hostileCreatureAggressiveness");
		NativeFieldInfoPtr_thirstFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "thirstFactor");
		NativeFieldInfoPtr_hungerFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "hungerFactor");
		NativeFieldInfoPtr_decayRateFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "decayRateFactor");
		NativeFieldInfoPtr_rainChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "rainChance");
		NativeFieldInfoPtr_hostileCampChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, "hostileCampChance");
		NativeMethodInfoPtr_GetCopy_Public_AdvancedGameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr, 100663544);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 18445, RefRangeEnd = 18449, XrefRangeStart = 18441, XrefRangeEnd = 18445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdvancedGameOptions GetCopy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCopy_Public_AdvancedGameOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdvancedGameOptions>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18449, XrefRangeEnd = 18604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 18717, RefRangeEnd = 18718, XrefRangeStart = 18604, XrefRangeEnd = 18717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Dictionary<string, Il2CppSystem.Object> MapToDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18718, XrefRangeEnd = 18735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe AdvancedGameOptions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedGameOptions>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AdvancedGameOptions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class InjuryCategoryInformation : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_onReceiveStatusEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_indefiniteStatusEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_treatedStatusEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryDurability;

	private static readonly System.IntPtr NativeFieldInfoPtr_untreatedAutoTreatmentRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_bodyPartInfectionApplicationMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalDurabilityDrainMultiplier;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<StatusEffect> onReceiveStatusEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onReceiveStatusEffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StatusEffect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onReceiveStatusEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StatusEffect> indefiniteStatusEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indefiniteStatusEffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StatusEffect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indefiniteStatusEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StatusEffect> treatedStatusEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatedStatusEffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StatusEffect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatedStatusEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int injuryDurability
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryDurability);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryDurability)) = num;
		}
	}

	public unsafe float untreatedAutoTreatmentRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_untreatedAutoTreatmentRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_untreatedAutoTreatmentRate)) = num;
		}
	}

	public unsafe float bodyPartInfectionApplicationMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyPartInfectionApplicationMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyPartInfectionApplicationMultiplier)) = num;
		}
	}

	public unsafe float medicalDurabilityDrainMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalDurabilityDrainMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalDurabilityDrainMultiplier)) = num;
		}
	}

	static InjuryCategoryInformation()
	{
		Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InjuryCategoryInformation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr);
		NativeFieldInfoPtr_onReceiveStatusEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr, "onReceiveStatusEffects");
		NativeFieldInfoPtr_indefiniteStatusEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr, "indefiniteStatusEffects");
		NativeFieldInfoPtr_treatedStatusEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr, "treatedStatusEffects");
		NativeFieldInfoPtr_injuryDurability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr, "injuryDurability");
		NativeFieldInfoPtr_untreatedAutoTreatmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr, "untreatedAutoTreatmentRate");
		NativeFieldInfoPtr_bodyPartInfectionApplicationMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr, "bodyPartInfectionApplicationMultiplier");
		NativeFieldInfoPtr_medicalDurabilityDrainMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr, "medicalDurabilityDrainMultiplier");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr, 100670466);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr, 100670467);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121409, XrefRangeEnd = 121464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe InjuryCategoryInformation()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjuryCategoryInformation>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InjuryCategoryInformation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

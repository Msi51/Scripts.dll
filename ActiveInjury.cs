using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;

[System.Serializable]
public class ActiveInjury : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_identifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_location;

	private static readonly System.IntPtr NativeFieldInfoPtr_treated;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalItemId;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryDurability;

	private static readonly System.IntPtr NativeFieldInfoPtr_treatmentRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_externalTreatmentRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalEffectiveness;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxMedicalDurability;

	private static readonly System.IntPtr NativeFieldInfoPtr_remainingMedicalDurability;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalLosesDurabilityOverTreatment;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalDurabilityLostOnDamageMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryCleanlinessState;

	private static readonly System.IntPtr NativeFieldInfoPtr_filthAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_sanitationAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_basicSanitationRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalDurabilityDrainMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalItemSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalItem;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_InjuryDurabilityPercentage_Internal_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Injury_String_Int32_InjuryLocation_InjuryCategoryInformation_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe string identifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe InjuryLocation location
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
			return *(InjuryLocation*)num;
		}
		set
		{
			*(InjuryLocation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)) = injuryLocation;
		}
	}

	public unsafe bool treated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treated);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treated)) = flag;
		}
	}

	public unsafe int medicalItemId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalItemId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalItemId)) = num;
		}
	}

	public unsafe float injuryDurability
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryDurability);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryDurability)) = num;
		}
	}

	public unsafe float treatmentRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatmentRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatmentRate)) = num;
		}
	}

	public unsafe float externalTreatmentRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalTreatmentRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_externalTreatmentRate)) = num;
		}
	}

	public unsafe float medicalEffectiveness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalEffectiveness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalEffectiveness)) = num;
		}
	}

	public unsafe float maxMedicalDurability
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMedicalDurability);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMedicalDurability)) = num;
		}
	}

	public unsafe float remainingMedicalDurability
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingMedicalDurability);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainingMedicalDurability)) = num;
		}
	}

	public unsafe bool medicalLosesDurabilityOverTreatment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalLosesDurabilityOverTreatment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalLosesDurabilityOverTreatment)) = flag;
		}
	}

	public unsafe float medicalDurabilityLostOnDamageMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalDurabilityLostOnDamageMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalDurabilityLostOnDamageMultiplier)) = num;
		}
	}

	public unsafe InjuryCleanliness injuryCleanlinessState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryCleanlinessState);
			return *(InjuryCleanliness*)num;
		}
		set
		{
			*(InjuryCleanliness*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryCleanlinessState)) = injuryCleanliness;
		}
	}

	public unsafe float filthAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filthAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filthAmount)) = num;
		}
	}

	public unsafe float sanitationAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sanitationAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sanitationAmount)) = num;
		}
	}

	public unsafe float basicSanitationRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basicSanitationRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basicSanitationRate)) = num;
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

	public unsafe Injury injuryModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Injury>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury));
		}
	}

	public unsafe InventorySlot medicalItemSlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalItemSlot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventorySlot>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalItemSlot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventorySlot));
		}
	}

	public unsafe InventoryItem medicalItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_medicalItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryItem));
		}
	}

	public unsafe float InjuryDurabilityPercentage
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 120999, RefRangeEnd = 121004, XrefRangeStart = 120983, XrefRangeEnd = 120999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InjuryDurabilityPercentage_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ActiveInjury()
	{
		Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ActiveInjury");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr);
		NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "identifier");
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "id");
		NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "location");
		NativeFieldInfoPtr_treated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "treated");
		NativeFieldInfoPtr_medicalItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "medicalItemId");
		NativeFieldInfoPtr_injuryDurability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "injuryDurability");
		NativeFieldInfoPtr_treatmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "treatmentRate");
		NativeFieldInfoPtr_externalTreatmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "externalTreatmentRate");
		NativeFieldInfoPtr_medicalEffectiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "medicalEffectiveness");
		NativeFieldInfoPtr_maxMedicalDurability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "maxMedicalDurability");
		NativeFieldInfoPtr_remainingMedicalDurability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "remainingMedicalDurability");
		NativeFieldInfoPtr_medicalLosesDurabilityOverTreatment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "medicalLosesDurabilityOverTreatment");
		NativeFieldInfoPtr_medicalDurabilityLostOnDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "medicalDurabilityLostOnDamageMultiplier");
		NativeFieldInfoPtr_injuryCleanlinessState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "injuryCleanlinessState");
		NativeFieldInfoPtr_filthAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "filthAmount");
		NativeFieldInfoPtr_sanitationAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "sanitationAmount");
		NativeFieldInfoPtr_basicSanitationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "basicSanitationRate");
		NativeFieldInfoPtr_medicalDurabilityDrainMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "medicalDurabilityDrainMultiplier");
		NativeFieldInfoPtr_injuryModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "injuryModel");
		NativeFieldInfoPtr_medicalItemSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "medicalItemSlot");
		NativeFieldInfoPtr_medicalItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, "medicalItem");
		NativeMethodInfoPtr_get_InjuryDurabilityPercentage_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, 100670427);
		NativeMethodInfoPtr__ctor_Public_Void_Injury_String_Int32_InjuryLocation_InjuryCategoryInformation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, 100670428);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, 100670429);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr, 100670430);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121007, RefRangeEnd = 121008, XrefRangeStart = 121004, XrefRangeEnd = 121007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActiveInjury(Injury injury, string injuryIdentifier, int id, InjuryLocation injuryLocation, InjuryCategoryInformation categoryInfo, bool canBeDirtied)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injury);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(injuryIdentifier);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		*(InjuryLocation**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &injuryLocation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)categoryInfo);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &canBeDirtied;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Injury_String_Int32_InjuryLocation_InjuryCategoryInformation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121008, XrefRangeEnd = 121013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActiveInjury()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveInjury>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121013, XrefRangeEnd = 121031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ActiveInjury(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

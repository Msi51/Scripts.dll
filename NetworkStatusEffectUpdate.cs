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

public sealed class NetworkStatusEffectUpdate : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_itemId;

	private static readonly System.IntPtr NativeFieldInfoPtr_substanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusEffectDefinitionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusEffectType;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitpointsRecoveryRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirstReplenishmentRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_hungerReplenishmentRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_energyReplenishmentRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxStaminaReductionAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseHungerThirstIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_staminaRecoveryRateChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_staminaExertionRateChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementSpeedChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseSusceptibilityAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_mosquitoRepellentAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionSpeedChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_elapsedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_duration;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusEffectDefinition;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ActiveStatusEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe int itemId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemId)) = num;
		}
	}

	public unsafe int substanceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_substanceId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_substanceId)) = num;
		}
	}

	public unsafe int statusEffectDefinitionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectDefinitionId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectDefinitionId)) = num;
		}
	}

	public unsafe StatusEffectType statusEffectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectType);
			return *(StatusEffectType*)num;
		}
		set
		{
			*(StatusEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectType)) = statusEffectType;
		}
	}

	public unsafe float hitpointsRecoveryRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitpointsRecoveryRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hitpointsRecoveryRate)) = num;
		}
	}

	public unsafe float thirstReplenishmentRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirstReplenishmentRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirstReplenishmentRate)) = num;
		}
	}

	public unsafe float hungerReplenishmentRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hungerReplenishmentRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hungerReplenishmentRate)) = num;
		}
	}

	public unsafe float energyReplenishmentRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyReplenishmentRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyReplenishmentRate)) = num;
		}
	}

	public unsafe float diseaseRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseRate)) = num;
		}
	}

	public unsafe float maxStaminaReductionAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStaminaReductionAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStaminaReductionAmount)) = num;
		}
	}

	public unsafe float diseaseHungerThirstIncreaseAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseHungerThirstIncreaseAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseHungerThirstIncreaseAmount)) = num;
		}
	}

	public unsafe float staminaRecoveryRateChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaRecoveryRateChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaRecoveryRateChange)) = num;
		}
	}

	public unsafe float staminaExertionRateChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaExertionRateChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_staminaExertionRateChange)) = num;
		}
	}

	public unsafe float movementSpeedChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeedChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeedChange)) = num;
		}
	}

	public unsafe float diseaseSusceptibilityAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseSusceptibilityAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseSusceptibilityAmount)) = num;
		}
	}

	public unsafe float mosquitoRepellentAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mosquitoRepellentAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mosquitoRepellentAmount)) = num;
		}
	}

	public unsafe float actionSpeedChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSpeedChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionSpeedChange)) = num;
		}
	}

	public unsafe float elapsedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elapsedTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elapsedTime)) = num;
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

	public unsafe StatusEffectDefinition statusEffectDefinition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectDefinition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusEffectDefinition>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectDefinition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusEffectDefinition));
		}
	}

	static NetworkStatusEffectUpdate()
	{
		Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NetworkStatusEffectUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr);
		NativeFieldInfoPtr_itemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "itemId");
		NativeFieldInfoPtr_substanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "substanceId");
		NativeFieldInfoPtr_statusEffectDefinitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "statusEffectDefinitionId");
		NativeFieldInfoPtr_statusEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "statusEffectType");
		NativeFieldInfoPtr_hitpointsRecoveryRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "hitpointsRecoveryRate");
		NativeFieldInfoPtr_thirstReplenishmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "thirstReplenishmentRate");
		NativeFieldInfoPtr_hungerReplenishmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "hungerReplenishmentRate");
		NativeFieldInfoPtr_energyReplenishmentRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "energyReplenishmentRate");
		NativeFieldInfoPtr_diseaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "diseaseRate");
		NativeFieldInfoPtr_maxStaminaReductionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "maxStaminaReductionAmount");
		NativeFieldInfoPtr_diseaseHungerThirstIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "diseaseHungerThirstIncreaseAmount");
		NativeFieldInfoPtr_staminaRecoveryRateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "staminaRecoveryRateChange");
		NativeFieldInfoPtr_staminaExertionRateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "staminaExertionRateChange");
		NativeFieldInfoPtr_movementSpeedChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "movementSpeedChange");
		NativeFieldInfoPtr_diseaseSusceptibilityAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "diseaseSusceptibilityAmount");
		NativeFieldInfoPtr_mosquitoRepellentAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "mosquitoRepellentAmount");
		NativeFieldInfoPtr_actionSpeedChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "actionSpeedChange");
		NativeFieldInfoPtr_elapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "elapsedTime");
		NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "duration");
		NativeFieldInfoPtr_statusEffectDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, "statusEffectDefinition");
		NativeMethodInfoPtr__ctor_Public_Void_ActiveStatusEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr, 100663836);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 24045, RefRangeEnd = 24047, XrefRangeStart = 24043, XrefRangeEnd = 24045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NetworkStatusEffectUpdate(ActiveStatusEffect activeStatusEffect)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activeStatusEffect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ActiveStatusEffect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24047, XrefRangeEnd = 24066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NetworkStatusEffectUpdate(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public NetworkStatusEffectUpdate()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkStatusEffectUpdate>.NativeClassPtr))
	{
	}
}

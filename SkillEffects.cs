using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct SkillEffects
{
	private static readonly System.IntPtr NativeFieldInfoPtr_chopDamageIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_miningDamageIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxStaminaIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_staminaDrainDecreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_critChanceIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_accuracyIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_forageBonusDropChanceIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_forageBonusDropIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_medicalDurabilityIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_antisepticPotencyIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementSpeedIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingSpeedIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_butcheringSpeedIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookingYieldIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelEfficiencyIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_igniteChanceIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_fertilizerPotencyIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_cropResilienceIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_survivalistCraftSpeedIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_woodworkingCraftSpeedIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_metalworkingCraftSpeedIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_leatherworkingCraftSpeedIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_sculptingCraftSpeedIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_herbalismCraftSpeedIncreaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_meatHandlingCraftSpeedIncreaseAmount;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetEffectValues_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ChopDamageIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MiningDamageIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxStaminaIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StaminaDrainDecreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MovementSpeedIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CritChanceIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AccuracyIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ForagingBonusChanceIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ForagingBonusIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MedicalDurabilityIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AntisepticPotencyIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CookingSpeedIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ButcheringSpeedIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CookingYieldIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FuelEfficiencyIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IgniteChanceIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FertilizerPotencyIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CropResilienceIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SurvivalistCraftSpeedIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WoodworkingCraftSpeedIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MetalworkingCraftSpeedIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LeatherworkingCraftSpeedIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SculptingCraftSpeedIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HerbalismCraftSpeedIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MeatHandlingCraftSpeedIncreaseAmount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChopDamage_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMiningDamage_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMaxStaminaIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecreaseStaminaDrain_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMovementSpeedIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCritChance_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAccuracyIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddForageBonusChance_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddForageBonus_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMedicalDurabilityIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAntisepticPotencyIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCookingSpeedIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddButcheringIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCookingYieldIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFuelEfficiencyIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddIgniteChanceIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFertilizerPotencyIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCropResilienceIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSurvivalistCraftSpeedIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWoodworkingCraftSpeedIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMetalworkingCraftSpeedIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLeatherworkingCraftSpeedIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSculptingCraftSpeedIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHerbalismCraftSpeedIncrease_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMeatHandlingCraftSpeedIncrease_Public_Void_Single_0;

	[FieldOffset(0)]
	public float chopDamageIncreaseAmount;

	[FieldOffset(4)]
	public float miningDamageIncreaseAmount;

	[FieldOffset(8)]
	public float maxStaminaIncreaseAmount;

	[FieldOffset(12)]
	public float staminaDrainDecreaseAmount;

	[FieldOffset(16)]
	public float critChanceIncreaseAmount;

	[FieldOffset(20)]
	public float accuracyIncreaseAmount;

	[FieldOffset(24)]
	public float forageBonusDropChanceIncreaseAmount;

	[FieldOffset(28)]
	public float forageBonusDropIncreaseAmount;

	[FieldOffset(32)]
	public float medicalDurabilityIncreaseAmount;

	[FieldOffset(36)]
	public float antisepticPotencyIncreaseAmount;

	[FieldOffset(40)]
	public float movementSpeedIncreaseAmount;

	[FieldOffset(44)]
	public float cookingSpeedIncreaseAmount;

	[FieldOffset(48)]
	public float butcheringSpeedIncreaseAmount;

	[FieldOffset(52)]
	public float cookingYieldIncreaseAmount;

	[FieldOffset(56)]
	public float fuelEfficiencyIncreaseAmount;

	[FieldOffset(60)]
	public float igniteChanceIncreaseAmount;

	[FieldOffset(64)]
	public float fertilizerPotencyIncreaseAmount;

	[FieldOffset(68)]
	public float cropResilienceIncreaseAmount;

	[FieldOffset(72)]
	public float survivalistCraftSpeedIncreaseAmount;

	[FieldOffset(76)]
	public float woodworkingCraftSpeedIncreaseAmount;

	[FieldOffset(80)]
	public float metalworkingCraftSpeedIncreaseAmount;

	[FieldOffset(84)]
	public float leatherworkingCraftSpeedIncreaseAmount;

	[FieldOffset(88)]
	public float sculptingCraftSpeedIncreaseAmount;

	[FieldOffset(92)]
	public float herbalismCraftSpeedIncreaseAmount;

	[FieldOffset(96)]
	public float meatHandlingCraftSpeedIncreaseAmount;

	public unsafe float ChopDamageIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ChopDamageIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float MiningDamageIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MiningDamageIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float MaxStaminaIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxStaminaIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float StaminaDrainDecreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StaminaDrainDecreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float MovementSpeedIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MovementSpeedIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float CritChanceIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CritChanceIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float AccuracyIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AccuracyIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float ForagingBonusChanceIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ForagingBonusChanceIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float ForagingBonusIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ForagingBonusIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float MedicalDurabilityIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MedicalDurabilityIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float AntisepticPotencyIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AntisepticPotencyIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float CookingSpeedIncreaseAmount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29361, RefRangeEnd = 29362, XrefRangeStart = 29361, XrefRangeEnd = 29362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CookingSpeedIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float ButcheringSpeedIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ButcheringSpeedIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float CookingYieldIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CookingYieldIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float FuelEfficiencyIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FuelEfficiencyIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float IgniteChanceIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IgniteChanceIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float FertilizerPotencyIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FertilizerPotencyIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float CropResilienceIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CropResilienceIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float SurvivalistCraftSpeedIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SurvivalistCraftSpeedIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float WoodworkingCraftSpeedIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WoodworkingCraftSpeedIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float MetalworkingCraftSpeedIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MetalworkingCraftSpeedIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float LeatherworkingCraftSpeedIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LeatherworkingCraftSpeedIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float SculptingCraftSpeedIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SculptingCraftSpeedIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float HerbalismCraftSpeedIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HerbalismCraftSpeedIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe float MeatHandlingCraftSpeedIncreaseAmount
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MeatHandlingCraftSpeedIncreaseAmount_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static SkillEffects()
	{
		Il2CppClassPointerStore<SkillEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SkillEffects");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr);
		NativeFieldInfoPtr_chopDamageIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "chopDamageIncreaseAmount");
		NativeFieldInfoPtr_miningDamageIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "miningDamageIncreaseAmount");
		NativeFieldInfoPtr_maxStaminaIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "maxStaminaIncreaseAmount");
		NativeFieldInfoPtr_staminaDrainDecreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "staminaDrainDecreaseAmount");
		NativeFieldInfoPtr_critChanceIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "critChanceIncreaseAmount");
		NativeFieldInfoPtr_accuracyIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "accuracyIncreaseAmount");
		NativeFieldInfoPtr_forageBonusDropChanceIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "forageBonusDropChanceIncreaseAmount");
		NativeFieldInfoPtr_forageBonusDropIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "forageBonusDropIncreaseAmount");
		NativeFieldInfoPtr_medicalDurabilityIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "medicalDurabilityIncreaseAmount");
		NativeFieldInfoPtr_antisepticPotencyIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "antisepticPotencyIncreaseAmount");
		NativeFieldInfoPtr_movementSpeedIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "movementSpeedIncreaseAmount");
		NativeFieldInfoPtr_cookingSpeedIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "cookingSpeedIncreaseAmount");
		NativeFieldInfoPtr_butcheringSpeedIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "butcheringSpeedIncreaseAmount");
		NativeFieldInfoPtr_cookingYieldIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "cookingYieldIncreaseAmount");
		NativeFieldInfoPtr_fuelEfficiencyIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "fuelEfficiencyIncreaseAmount");
		NativeFieldInfoPtr_igniteChanceIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "igniteChanceIncreaseAmount");
		NativeFieldInfoPtr_fertilizerPotencyIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "fertilizerPotencyIncreaseAmount");
		NativeFieldInfoPtr_cropResilienceIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "cropResilienceIncreaseAmount");
		NativeFieldInfoPtr_survivalistCraftSpeedIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "survivalistCraftSpeedIncreaseAmount");
		NativeFieldInfoPtr_woodworkingCraftSpeedIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "woodworkingCraftSpeedIncreaseAmount");
		NativeFieldInfoPtr_metalworkingCraftSpeedIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "metalworkingCraftSpeedIncreaseAmount");
		NativeFieldInfoPtr_leatherworkingCraftSpeedIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "leatherworkingCraftSpeedIncreaseAmount");
		NativeFieldInfoPtr_sculptingCraftSpeedIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "sculptingCraftSpeedIncreaseAmount");
		NativeFieldInfoPtr_herbalismCraftSpeedIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "herbalismCraftSpeedIncreaseAmount");
		NativeFieldInfoPtr_meatHandlingCraftSpeedIncreaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, "meatHandlingCraftSpeedIncreaseAmount");
		NativeMethodInfoPtr_ResetEffectValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679697);
		NativeMethodInfoPtr_get_ChopDamageIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679698);
		NativeMethodInfoPtr_get_MiningDamageIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679699);
		NativeMethodInfoPtr_get_MaxStaminaIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679700);
		NativeMethodInfoPtr_get_StaminaDrainDecreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679701);
		NativeMethodInfoPtr_get_MovementSpeedIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679702);
		NativeMethodInfoPtr_get_CritChanceIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679703);
		NativeMethodInfoPtr_get_AccuracyIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679704);
		NativeMethodInfoPtr_get_ForagingBonusChanceIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679705);
		NativeMethodInfoPtr_get_ForagingBonusIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679706);
		NativeMethodInfoPtr_get_MedicalDurabilityIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679707);
		NativeMethodInfoPtr_get_AntisepticPotencyIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679708);
		NativeMethodInfoPtr_get_CookingSpeedIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679709);
		NativeMethodInfoPtr_get_ButcheringSpeedIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679710);
		NativeMethodInfoPtr_get_CookingYieldIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679711);
		NativeMethodInfoPtr_get_FuelEfficiencyIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679712);
		NativeMethodInfoPtr_get_IgniteChanceIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679713);
		NativeMethodInfoPtr_get_FertilizerPotencyIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679714);
		NativeMethodInfoPtr_get_CropResilienceIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679715);
		NativeMethodInfoPtr_get_SurvivalistCraftSpeedIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679716);
		NativeMethodInfoPtr_get_WoodworkingCraftSpeedIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679717);
		NativeMethodInfoPtr_get_MetalworkingCraftSpeedIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679718);
		NativeMethodInfoPtr_get_LeatherworkingCraftSpeedIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679719);
		NativeMethodInfoPtr_get_SculptingCraftSpeedIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679720);
		NativeMethodInfoPtr_get_HerbalismCraftSpeedIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679721);
		NativeMethodInfoPtr_get_MeatHandlingCraftSpeedIncreaseAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679722);
		NativeMethodInfoPtr_AddChopDamage_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679723);
		NativeMethodInfoPtr_AddMiningDamage_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679724);
		NativeMethodInfoPtr_AddMaxStaminaIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679725);
		NativeMethodInfoPtr_DecreaseStaminaDrain_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679726);
		NativeMethodInfoPtr_AddMovementSpeedIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679727);
		NativeMethodInfoPtr_AddCritChance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679728);
		NativeMethodInfoPtr_AddAccuracyIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679729);
		NativeMethodInfoPtr_AddForageBonusChance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679730);
		NativeMethodInfoPtr_AddForageBonus_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679731);
		NativeMethodInfoPtr_AddMedicalDurabilityIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679732);
		NativeMethodInfoPtr_AddAntisepticPotencyIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679733);
		NativeMethodInfoPtr_AddCookingSpeedIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679734);
		NativeMethodInfoPtr_AddButcheringIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679735);
		NativeMethodInfoPtr_AddCookingYieldIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679736);
		NativeMethodInfoPtr_AddFuelEfficiencyIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679737);
		NativeMethodInfoPtr_AddIgniteChanceIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679738);
		NativeMethodInfoPtr_AddFertilizerPotencyIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679739);
		NativeMethodInfoPtr_AddCropResilienceIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679740);
		NativeMethodInfoPtr_AddSurvivalistCraftSpeedIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679741);
		NativeMethodInfoPtr_AddWoodworkingCraftSpeedIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679742);
		NativeMethodInfoPtr_AddMetalworkingCraftSpeedIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679743);
		NativeMethodInfoPtr_AddLeatherworkingCraftSpeedIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679744);
		NativeMethodInfoPtr_AddSculptingCraftSpeedIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679745);
		NativeMethodInfoPtr_AddHerbalismCraftSpeedIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679746);
		NativeMethodInfoPtr_AddMeatHandlingCraftSpeedIncrease_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, 100679747);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233981, RefRangeEnd = 233983, XrefRangeStart = 233981, XrefRangeEnd = 233981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetEffectValues()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetEffectValues_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233983, RefRangeEnd = 233984, XrefRangeStart = 233983, XrefRangeEnd = 233983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddChopDamage(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChopDamage_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233984, RefRangeEnd = 233985, XrefRangeStart = 233984, XrefRangeEnd = 233984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMiningDamage(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMiningDamage_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233985, RefRangeEnd = 233986, XrefRangeStart = 233985, XrefRangeEnd = 233985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMaxStaminaIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMaxStaminaIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233986, RefRangeEnd = 233987, XrefRangeStart = 233986, XrefRangeEnd = 233986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DecreaseStaminaDrain(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecreaseStaminaDrain_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void AddMovementSpeedIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMovementSpeedIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233987, RefRangeEnd = 233988, XrefRangeStart = 233987, XrefRangeEnd = 233987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCritChance(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCritChance_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233988, RefRangeEnd = 233989, XrefRangeStart = 233988, XrefRangeEnd = 233988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAccuracyIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAccuracyIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233989, RefRangeEnd = 233990, XrefRangeStart = 233989, XrefRangeEnd = 233989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddForageBonusChance(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddForageBonusChance_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233990, RefRangeEnd = 233991, XrefRangeStart = 233990, XrefRangeEnd = 233990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddForageBonus(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddForageBonus_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233991, RefRangeEnd = 233993, XrefRangeStart = 233991, XrefRangeEnd = 233991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMedicalDurabilityIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMedicalDurabilityIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233993, RefRangeEnd = 233994, XrefRangeStart = 233993, XrefRangeEnd = 233993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAntisepticPotencyIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAntisepticPotencyIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233994, RefRangeEnd = 233995, XrefRangeStart = 233994, XrefRangeEnd = 233994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCookingSpeedIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCookingSpeedIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233995, RefRangeEnd = 233996, XrefRangeStart = 233995, XrefRangeEnd = 233995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddButcheringIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddButcheringIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233996, RefRangeEnd = 233997, XrefRangeStart = 233996, XrefRangeEnd = 233996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCookingYieldIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCookingYieldIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233997, RefRangeEnd = 233998, XrefRangeStart = 233997, XrefRangeEnd = 233997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFuelEfficiencyIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFuelEfficiencyIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233998, RefRangeEnd = 233999, XrefRangeStart = 233998, XrefRangeEnd = 233998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddIgniteChanceIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddIgniteChanceIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233999, RefRangeEnd = 234000, XrefRangeStart = 233999, XrefRangeEnd = 233999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFertilizerPotencyIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFertilizerPotencyIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234000, RefRangeEnd = 234001, XrefRangeStart = 234000, XrefRangeEnd = 234000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCropResilienceIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCropResilienceIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234001, RefRangeEnd = 234002, XrefRangeStart = 234001, XrefRangeEnd = 234001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSurvivalistCraftSpeedIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSurvivalistCraftSpeedIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234002, RefRangeEnd = 234003, XrefRangeStart = 234002, XrefRangeEnd = 234002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWoodworkingCraftSpeedIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWoodworkingCraftSpeedIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234003, RefRangeEnd = 234004, XrefRangeStart = 234003, XrefRangeEnd = 234003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMetalworkingCraftSpeedIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMetalworkingCraftSpeedIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234004, RefRangeEnd = 234005, XrefRangeStart = 234004, XrefRangeEnd = 234004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddLeatherworkingCraftSpeedIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLeatherworkingCraftSpeedIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234005, RefRangeEnd = 234006, XrefRangeStart = 234005, XrefRangeEnd = 234005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSculptingCraftSpeedIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSculptingCraftSpeedIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234006, RefRangeEnd = 234007, XrefRangeStart = 234006, XrefRangeEnd = 234006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddHerbalismCraftSpeedIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddHerbalismCraftSpeedIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234007, RefRangeEnd = 234008, XrefRangeStart = 234007, XrefRangeEnd = 234007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMeatHandlingCraftSpeedIncrease(float increase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&increase);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMeatHandlingCraftSpeedIncrease_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SkillEffects>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

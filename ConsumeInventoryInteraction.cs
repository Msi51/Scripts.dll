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

public class ConsumeInventoryInteraction : BaseInteraction
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MIN_FOOD_VALUE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONDITION_FALLOFF_PERCENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_decalManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_effectsManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_createItemStackEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_entityFullyDecayedSignal;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactorSoundEmitter;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactorAnimatedMover;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetInventoryHolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetLiving;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_consumeDuration;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextSoundTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextFoodConsumptionTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactorInterfaces;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetInterfaces;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputs;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractorInterfaces_Public_Virtual_HashSet_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetInterfaces_Public_Virtual_HashSet_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractionStartInputs_Public_Virtual_HashSet_1_InteractionInputType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDecalManager_IEffectsManager_CreateItemStackEvent_EntityFullyDecayedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InteractionSetup_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LocalStart_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LocalInteractionUpdate_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LocalTeardown_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPossible_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompletionPercentage_Public_Virtual_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractionType_Public_Virtual_InteractionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShowProgressBar_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldAutoMoveInRange_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequiresTarget_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithinRange_Public_Virtual_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Void_BufferSerializer_1_T_0;

	public unsafe static float MIN_FOOD_VALUE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_FOOD_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_FOOD_VALUE, (void*)(&num));
		}
	}

	public unsafe static float CONDITION_FALLOFF_PERCENT
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONDITION_FALLOFF_PERCENT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONDITION_FALLOFF_PERCENT, (void*)(&num));
		}
	}

	public unsafe IDecalManager decalManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDecalManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decalManager));
		}
	}

	public unsafe IEffectsManager effectsManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectsManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEffectsManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectsManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectsManager));
		}
	}

	public unsafe CreateItemStackEvent createItemStackEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createItemStackEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CreateItemStackEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createItemStackEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createItemStackEvent));
		}
	}

	public unsafe EntityFullyDecayedSignal entityFullyDecayedSignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityFullyDecayedSignal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityFullyDecayedSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityFullyDecayedSignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityFullyDecayedSignal));
		}
	}

	public unsafe ISoundEmitter interactorSoundEmitter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactorSoundEmitter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISoundEmitter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactorSoundEmitter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundEmitter));
		}
	}

	public unsafe IAnimatedMover interactorAnimatedMover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactorAnimatedMover);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAnimatedMover>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactorAnimatedMover)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animatedMover));
		}
	}

	public unsafe IInventoryHolder targetInventoryHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetInventoryHolder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryHolder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetInventoryHolder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryHolder));
		}
	}

	public unsafe ILiving targetLiving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetLiving);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILiving>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetLiving)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)living));
		}
	}

	public unsafe IInteractable targetInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetInteractable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInteractable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetInteractable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
		}
	}

	public unsafe float consumeDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumeDuration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_consumeDuration)) = num;
		}
	}

	public unsafe float nextSoundTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextSoundTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextSoundTime)) = num;
		}
	}

	public unsafe float nextFoodConsumptionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextFoodConsumptionTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextFoodConsumptionTime)) = num;
		}
	}

	public unsafe static HashSet<Il2CppSystem.Type> interactorInterfaces
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_interactorInterfaces, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Il2CppSystem.Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_interactorInterfaces, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static HashSet<Il2CppSystem.Type> targetInterfaces
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_targetInterfaces, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Il2CppSystem.Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_targetInterfaces, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static HashSet<InteractionInputType> inputs
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputs, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InteractionInputType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	static ConsumeInventoryInteraction()
	{
		Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConsumeInventoryInteraction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr);
		NativeFieldInfoPtr_MIN_FOOD_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "MIN_FOOD_VALUE");
		NativeFieldInfoPtr_CONDITION_FALLOFF_PERCENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "CONDITION_FALLOFF_PERCENT");
		NativeFieldInfoPtr_decalManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "decalManager");
		NativeFieldInfoPtr_effectsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "effectsManager");
		NativeFieldInfoPtr_createItemStackEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "createItemStackEvent");
		NativeFieldInfoPtr_entityFullyDecayedSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "entityFullyDecayedSignal");
		NativeFieldInfoPtr_interactorSoundEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "interactorSoundEmitter");
		NativeFieldInfoPtr_interactorAnimatedMover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "interactorAnimatedMover");
		NativeFieldInfoPtr_targetInventoryHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "targetInventoryHolder");
		NativeFieldInfoPtr_targetLiving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "targetLiving");
		NativeFieldInfoPtr_targetInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "targetInteractable");
		NativeFieldInfoPtr_consumeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "consumeDuration");
		NativeFieldInfoPtr_nextSoundTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "nextSoundTime");
		NativeFieldInfoPtr_nextFoodConsumptionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "nextFoodConsumptionTime");
		NativeFieldInfoPtr_interactorInterfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "interactorInterfaces");
		NativeFieldInfoPtr_targetInterfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "targetInterfaces");
		NativeFieldInfoPtr_inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, "inputs");
		NativeMethodInfoPtr_GetInteractorInterfaces_Public_Virtual_HashSet_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670806);
		NativeMethodInfoPtr_GetTargetInterfaces_Public_Virtual_HashSet_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670807);
		NativeMethodInfoPtr_GetInteractionStartInputs_Public_Virtual_HashSet_1_InteractionInputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670808);
		NativeMethodInfoPtr__ctor_Public_Void_IDecalManager_IEffectsManager_CreateItemStackEvent_EntityFullyDecayedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670809);
		NativeMethodInfoPtr_InteractionSetup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670810);
		NativeMethodInfoPtr_LocalStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670811);
		NativeMethodInfoPtr_LocalInteractionUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670812);
		NativeMethodInfoPtr_LocalTeardown_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670813);
		NativeMethodInfoPtr_IsPossible_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670814);
		NativeMethodInfoPtr_GetCompletionPercentage_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670815);
		NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670816);
		NativeMethodInfoPtr_GetInteractionType_Public_Virtual_InteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670817);
		NativeMethodInfoPtr_ShouldShowProgressBar_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670818);
		NativeMethodInfoPtr_ShouldAutoMoveInRange_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670819);
		NativeMethodInfoPtr_RequiresTarget_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670820);
		NativeMethodInfoPtr_WithinRange_Public_Virtual_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670821);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr, 100670822);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123672, XrefRangeEnd = 123676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override HashSet<Il2CppSystem.Type> GetInteractorInterfaces()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInteractorInterfaces_Public_Virtual_HashSet_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Il2CppSystem.Type>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123676, XrefRangeEnd = 123680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override HashSet<Il2CppSystem.Type> GetTargetInterfaces()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetTargetInterfaces_Public_Virtual_HashSet_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Il2CppSystem.Type>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123680, XrefRangeEnd = 123684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override HashSet<InteractionInputType> GetInteractionStartInputs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInteractionStartInputs_Public_Virtual_HashSet_1_InteractionInputType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<InteractionInputType>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123689, RefRangeEnd = 123690, XrefRangeStart = 123684, XrefRangeEnd = 123689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConsumeInventoryInteraction(IDecalManager decalManager, IEffectsManager effectsManager, CreateItemStackEvent createItemStackEvent, EntityFullyDecayedSignal entityFullyDecayedSignal)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsumeInventoryInteraction>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decalManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectsManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createItemStackEvent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityFullyDecayedSignal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IDecalManager_IEffectsManager_CreateItemStackEvent_EntityFullyDecayedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123690, XrefRangeEnd = 123711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InteractionSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InteractionSetup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123711, XrefRangeEnd = 123736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LocalStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LocalStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123736, XrefRangeEnd = 123821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LocalInteractionUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LocalInteractionUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123821, XrefRangeEnd = 123824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LocalTeardown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LocalTeardown_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123824, XrefRangeEnd = 123861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsPossible()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsPossible_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe override float GetCompletionPercentage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCompletionPercentage_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe override float GetDuration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe override InteractionType GetInteractionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInteractionType_Public_Virtual_InteractionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 27783, RefRangeEnd = 27926, XrefRangeStart = 27783, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ShouldShowProgressBar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShouldShowProgressBar_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 27783, RefRangeEnd = 27926, XrefRangeStart = 27783, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ShouldAutoMoveInRange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShouldAutoMoveInRange_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 44231, RefRangeEnd = 44249, XrefRangeStart = 44231, XrefRangeEnd = 44249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool RequiresTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RequiresTarget_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123861, XrefRangeEnd = 123862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool WithinRange(float rangeBuffer = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rangeBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WithinRange_Public_Virtual_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Void_BufferSerializer_1_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ConsumeInventoryInteraction(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

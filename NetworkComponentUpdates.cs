using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class NetworkComponentUpdates : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_transformEntityUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_animatorEntityUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_animatorEntityBoolUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_animatorEntityBoolsUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_animatorEntityTriggerUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryHolderSlotUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_containerMixtureUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryHolderSectionUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryHolderStackOriginUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementCorrectionMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusEffectUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundEmitterUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_distillerMixturesUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillsUpdateMessageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillsSetupMessageHandler;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkTransformUpdate_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorUpdate_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorBoolUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorBoolsUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorTriggerUpdate_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkInventoryHolderSlotUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkInventoryHolderSectionUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkInventoryHolderStackOriginUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkContainerMixtureUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkEntityMovementUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkEntityMovementCorrectionUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkStatusEffectUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkSoundEmitterUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkDistillerMixturesUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkActiveInjuryUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkSkillProgressUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkSkillProgressesUpdate_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe EntityUpdateMessageHandler<NetworkTransformUpdate, IPhysicsObject> transformEntityUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformEntityUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkTransformUpdate, IPhysicsObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformEntityUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityAnimatorMessageHandler<IAnimatedMover> animatorEntityUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorEntityUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityAnimatorMessageHandler<IAnimatedMover>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorEntityUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityAnimatorMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkAnimatorBoolUpdate, IAnimatedMover> animatorEntityBoolUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorEntityBoolUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkAnimatorBoolUpdate, IAnimatedMover>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorEntityBoolUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkAnimatorBoolsUpdate, IAnimatedMover> animatorEntityBoolsUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorEntityBoolsUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkAnimatorBoolsUpdate, IAnimatedMover>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorEntityBoolsUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkAnimatorTriggerUpdate, IAnimatedMover> animatorEntityTriggerUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorEntityTriggerUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkAnimatorTriggerUpdate, IAnimatedMover>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorEntityTriggerUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityInventoryHolderSlotUpdateMessageHandler<IInventoryHolder> inventoryHolderSlotUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolderSlotUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityInventoryHolderSlotUpdateMessageHandler<IInventoryHolder>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolderSlotUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityInventoryHolderSlotUpdateMessageHandler));
		}
	}

	public unsafe EntityContainerMixtureUpdateMessageHandler<IContainer> containerMixtureUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containerMixtureUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityContainerMixtureUpdateMessageHandler<IContainer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containerMixtureUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityContainerMixtureUpdateMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkInventoryHolderSectionUpdate, IInventoryHolder> inventoryHolderSectionUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolderSectionUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkInventoryHolderSectionUpdate, IInventoryHolder>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolderSectionUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkInventoryHolderStackOriginUpdate, IInventoryHolder> inventoryHolderStackOriginUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolderStackOriginUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkInventoryHolderStackOriginUpdate, IInventoryHolder>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryHolderStackOriginUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityMovementMessageHandler<IEntityMovement> movementUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityMovementMessageHandler<IEntityMovement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityMovementMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkEntityMovementCorrectionUpdate, IEntityMovement> movementCorrectionMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementCorrectionMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkEntityMovementCorrectionUpdate, IEntityMovement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementCorrectionMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkStatusEffectUpdate, IStatusEffects> statusEffectUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkStatusEffectUpdate, IStatusEffects>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusEffectUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkSoundEmitterUpdate, ISoundEmitter> soundEmitterUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundEmitterUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkSoundEmitterUpdate, ISoundEmitter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundEmitterUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityDistillerMixturesUpdateMessageHandler<IDistiller> distillerMixturesUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distillerMixturesUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityDistillerMixturesUpdateMessageHandler<IDistiller>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distillerMixturesUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityDistillerMixturesUpdateMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkActiveInjuryUpdate, IInjury> injuryUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkActiveInjuryUpdate, IInjury>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkSkillProgressUpdate, ISkills> skillsUpdateMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillsUpdateMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkSkillProgressUpdate, ISkills>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillsUpdateMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	public unsafe EntityUpdateMessageHandler<NetworkSkillProgressesUpdate, ISkills> skillsSetupMessageHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillsSetupMessageHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityUpdateMessageHandler<NetworkSkillProgressesUpdate, ISkills>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillsSetupMessageHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityUpdateMessageHandler));
		}
	}

	static NetworkComponentUpdates()
	{
		Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NetworkComponentUpdates");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr);
		NativeFieldInfoPtr_transformEntityUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "transformEntityUpdateMessageHandler");
		NativeFieldInfoPtr_animatorEntityUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "animatorEntityUpdateMessageHandler");
		NativeFieldInfoPtr_animatorEntityBoolUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "animatorEntityBoolUpdateMessageHandler");
		NativeFieldInfoPtr_animatorEntityBoolsUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "animatorEntityBoolsUpdateMessageHandler");
		NativeFieldInfoPtr_animatorEntityTriggerUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "animatorEntityTriggerUpdateMessageHandler");
		NativeFieldInfoPtr_inventoryHolderSlotUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "inventoryHolderSlotUpdateMessageHandler");
		NativeFieldInfoPtr_containerMixtureUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "containerMixtureUpdateMessageHandler");
		NativeFieldInfoPtr_inventoryHolderSectionUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "inventoryHolderSectionUpdateMessageHandler");
		NativeFieldInfoPtr_inventoryHolderStackOriginUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "inventoryHolderStackOriginUpdateMessageHandler");
		NativeFieldInfoPtr_movementUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "movementUpdateMessageHandler");
		NativeFieldInfoPtr_movementCorrectionMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "movementCorrectionMessageHandler");
		NativeFieldInfoPtr_statusEffectUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "statusEffectUpdateMessageHandler");
		NativeFieldInfoPtr_soundEmitterUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "soundEmitterUpdateMessageHandler");
		NativeFieldInfoPtr_distillerMixturesUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "distillerMixturesUpdateMessageHandler");
		NativeFieldInfoPtr_injuryUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "injuryUpdateMessageHandler");
		NativeFieldInfoPtr_skillsUpdateMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "skillsUpdateMessageHandler");
		NativeFieldInfoPtr_skillsSetupMessageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, "skillsSetupMessageHandler");
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkTransformUpdate_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663802);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorUpdate_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663803);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorBoolUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663804);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorBoolsUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663805);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorTriggerUpdate_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663806);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkInventoryHolderSlotUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663807);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkInventoryHolderSectionUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663808);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkInventoryHolderStackOriginUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663809);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkContainerMixtureUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663810);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkEntityMovementUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663811);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkEntityMovementCorrectionUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663812);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkStatusEffectUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663813);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkSoundEmitterUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663814);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkDistillerMixturesUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663815);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkActiveInjuryUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663816);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkSkillProgressUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663817);
		NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkSkillProgressesUpdate_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663818);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr, 100663819);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23899, RefRangeEnd = 23900, XrefRangeStart = 23899, XrefRangeEnd = 23899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkTransformUpdate update, int entityId, int toClientId = -1, int excludeClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&update);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkTransformUpdate_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23900, RefRangeEnd = 23901, XrefRangeStart = 23900, XrefRangeEnd = 23900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkAnimatorUpdate update, int entityId, int toClientId = -1, int excludeClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorUpdate_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23901, RefRangeEnd = 23902, XrefRangeStart = 23901, XrefRangeEnd = 23901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkAnimatorBoolUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&update);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorBoolUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23902, RefRangeEnd = 23903, XrefRangeStart = 23902, XrefRangeEnd = 23902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkAnimatorBoolsUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorBoolsUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23904, RefRangeEnd = 23905, XrefRangeStart = 23903, XrefRangeEnd = 23904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkAnimatorTriggerUpdate update, int entityId, int toClientId = -1, int excludeClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&update);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkAnimatorTriggerUpdate_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23905, RefRangeEnd = 23906, XrefRangeStart = 23905, XrefRangeEnd = 23905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkInventoryHolderSlotUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkInventoryHolderSlotUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23906, RefRangeEnd = 23907, XrefRangeStart = 23906, XrefRangeEnd = 23906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkInventoryHolderSectionUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&update);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkInventoryHolderSectionUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23907, RefRangeEnd = 23908, XrefRangeStart = 23907, XrefRangeEnd = 23907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkInventoryHolderStackOriginUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&update);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkInventoryHolderStackOriginUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23908, RefRangeEnd = 23909, XrefRangeStart = 23908, XrefRangeEnd = 23908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkContainerMixtureUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkContainerMixtureUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23909, RefRangeEnd = 23910, XrefRangeStart = 23909, XrefRangeEnd = 23909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkEntityMovementUpdate update, int entityId, int excludeClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&update);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkEntityMovementUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23910, RefRangeEnd = 23911, XrefRangeStart = 23910, XrefRangeEnd = 23910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkEntityMovementCorrectionUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&update);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkEntityMovementCorrectionUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23911, RefRangeEnd = 23912, XrefRangeStart = 23911, XrefRangeEnd = 23911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkStatusEffectUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkStatusEffectUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23912, RefRangeEnd = 23913, XrefRangeStart = 23912, XrefRangeEnd = 23912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkSoundEmitterUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&update);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkSoundEmitterUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23913, RefRangeEnd = 23914, XrefRangeStart = 23913, XrefRangeEnd = 23913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkDistillerMixturesUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkDistillerMixturesUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23914, RefRangeEnd = 23915, XrefRangeStart = 23914, XrefRangeEnd = 23914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkActiveInjuryUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkActiveInjuryUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23915, RefRangeEnd = 23916, XrefRangeStart = 23915, XrefRangeEnd = 23915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkSkillProgressUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkSkillProgressUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23916, RefRangeEnd = 23917, XrefRangeStart = 23916, XrefRangeEnd = 23916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdate(NetworkSkillProgressesUpdate update, int entityId, int toClientId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &entityId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toClientId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddUpdate_Public_Void_NetworkSkillProgressesUpdate_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NetworkComponentUpdates()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkComponentUpdates>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NetworkComponentUpdates(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

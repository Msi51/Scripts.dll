using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

public class ComponentManager : Il2CppSystem.Object
{
	[ObfuscatedName("ComponentManager+<Initialize>d__178")]
	public sealed class _Initialize_d__178 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe ComponentManager __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComponentManager>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)componentManager));
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _Initialize_d__178()
		{
			Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<Initialize>d__178");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr, 100674322);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr, 100674323);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr, 100674324);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr, 100674325);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr, 100674326);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr, 100674327);
		}

		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 37231, RefRangeEnd = 37260, XrefRangeStart = 37231, XrefRangeEnd = 37260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Initialize_d__178(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_Initialize_d__178>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(13368)]
		[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156072, XrefRangeEnd = 156484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156484, XrefRangeEnd = 156490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _Initialize_d__178(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("ComponentManager+<>c__DisplayClass180_0`1")]
	public sealed class __c__DisplayClass180_0<T> : Il2CppSystem.Object where T : class
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddComponentInitializer_b__0_Internal_Void_Entity_ISurvivalComponent_0;

		public unsafe Il2CppSystem.Action<Entity, T> action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Entity, T>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		static __c__DisplayClass180_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass180_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<>c__DisplayClass180_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass180_0<T>>.NativeClassPtr);
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass180_0<T>>.NativeClassPtr, "action");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass180_0<T>>.NativeClassPtr, 100674328);
			NativeMethodInfoPtr__AddComponentInitializer_b__0_Internal_Void_Entity_ISurvivalComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass180_0<T>>.NativeClassPtr, 100674329);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass180_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass180_0<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156490, XrefRangeEnd = 156496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddComponentInitializer_b__0(Entity entity, ISurvivalComponent component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddComponentInitializer_b__0_Internal_Void_Entity_ISurvivalComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass180_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_AddComponentInitializer_Public_Virtual_Final_New_Void_Action_2_Entity_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddComponentInitializer_Public_Virtual_Final_New_Void_Action_2_Entity_T_0, Il2CppClassPointerStore<ComponentManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__gameManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__gameEventManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__inventoryManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__resourceManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__constructionManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__blueprintManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__creatureManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__structureManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__settingsManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__characterManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__entityManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__statusEffectManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__injuryManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__meshMaterialManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ignitedFuelDepletedSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showCookingMenuSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showKilnMenuSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showStorableInventorySignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__projectileHitSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showRadialMenuSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__hideRadialMenuSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showDeadCreatureUISignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__entityFullyDecayedSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__stopLoopedSoundSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__itemDecaySignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__itemHardenedSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__constructionDestroySignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__entityTrapEnterSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ShowBurnableConstructionUISignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__getPotentialCookingRecipeSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showSoakingBasinUISignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__itemTreatedSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showTanningFrameUISignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__itemTannedSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showMoltenMetalMoldUISignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__collisionDamageSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__damageItemStackSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__pointerFocusUIShownSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showSmokeRackUISignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__alertingNoiseSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showRepairMenuSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__wheelEffectSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showConstructionInfoUISignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__showWorkbenchUISignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentInitializers;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentHandlerMap;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gameManager_Public_get_IGameManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_gameManager_Public_set_Void_IGameManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gameEventManager_Public_get_IGameEventManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_gameEventManager_Public_set_Void_IGameEventManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inventoryManager_Public_get_IInventoryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_inventoryManager_Public_set_Void_IInventoryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resourceManager_Public_get_IResourceManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_resourceManager_Public_set_Void_IResourceManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_constructionManager_Public_get_IConstructionManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_constructionManager_Public_set_Void_IConstructionManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blueprintManager_Public_get_IBlueprintManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blueprintManager_Public_set_Void_IBlueprintManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_creatureManager_Public_get_ICreatureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_creatureManager_Public_set_Void_ICreatureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_structureManager_Public_get_IStructureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_structureManager_Public_set_Void_IStructureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_settingsManager_Public_get_ISettingsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_settingsManager_Public_set_Void_ISettingsManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_characterManager_Public_get_ICharacterManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_characterManager_Public_set_Void_ICharacterManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_entityManager_Public_get_IEntityManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_entityManager_Public_set_Void_IEntityManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_statusEffectManager_Public_get_IStatusEffectManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_statusEffectManager_Public_set_Void_IStatusEffectManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_injuryManager_Public_get_IInjuryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_injuryManager_Public_set_Void_IInjuryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_meshMaterialManager_Public_get_IMeshMaterialManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_meshMaterialManager_Public_set_Void_IMeshMaterialManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ignitedFuelDepletedSignal_Public_get_IgnitedFuelDepletedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ignitedFuelDepletedSignal_Public_set_Void_IgnitedFuelDepletedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showCookingMenuSignal_Public_get_ShowCookingMenuSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showCookingMenuSignal_Public_set_Void_ShowCookingMenuSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showKilnMenuSignal_Public_get_ShowKilnMenuSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showKilnMenuSignal_Public_set_Void_ShowKilnMenuSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showStorableInventorySignal_Public_get_ShowStorableInventorySignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showStorableInventorySignal_Public_set_Void_ShowStorableInventorySignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_projectileHitSignal_Public_get_ProjectileHitSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_projectileHitSignal_Public_set_Void_ProjectileHitSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showRadialMenuSignal_Public_get_ShowRadialMenuSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showRadialMenuSignal_Public_set_Void_ShowRadialMenuSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hideRadialMenuSignal_Public_get_HideRadialMenuSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hideRadialMenuSignal_Public_set_Void_HideRadialMenuSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showDeadCreatureUISignal_Public_get_ShowDeadCreatureUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showDeadCreatureUISignal_Public_set_Void_ShowDeadCreatureUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_entityFullyDecayedSignal_Public_get_EntityFullyDecayedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_entityFullyDecayedSignal_Public_set_Void_EntityFullyDecayedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stopLoopedSoundSignal_Public_get_StopLoopedSoundSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stopLoopedSoundSignal_Public_set_Void_StopLoopedSoundSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_itemDecaySignal_Public_get_ItemDecaySignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_itemDecaySignal_Public_set_Void_ItemDecaySignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_itemHardenedSignal_Public_get_ItemHardenedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_itemHardenedSignal_Public_set_Void_ItemHardenedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_constructionDestroySignal_Public_get_ConstructionDestroySignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_constructionDestroySignal_Public_set_Void_ConstructionDestroySignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_entityTrapEnterSignal_Public_get_EntityTrapEnterSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_entityTrapEnterSignal_Public_set_Void_EntityTrapEnterSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ShowBurnableConstructionUISignal_Public_get_ShowBurnableConstructionUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ShowBurnableConstructionUISignal_Public_set_Void_ShowBurnableConstructionUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_getPotentialCookingRecipeSignal_Public_get_GetPotentialCookingRecipeSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_getPotentialCookingRecipeSignal_Public_set_Void_GetPotentialCookingRecipeSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showSoakingBasinUISignal_Public_get_ShowSoakingBasinUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showSoakingBasinUISignal_Public_set_Void_ShowSoakingBasinUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_itemTreatedSignal_Public_get_ItemTreatedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_itemTreatedSignal_Public_set_Void_ItemTreatedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showTanningFrameUISignal_Public_get_ShowTanningFrameUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showTanningFrameUISignal_Public_set_Void_ShowTanningFrameUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_itemTannedSignal_Public_get_ItemTannedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_itemTannedSignal_Public_set_Void_ItemTannedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showMoltenMetalMoldUISignal_Public_get_ShowMoltenMetalMoldUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showMoltenMetalMoldUISignal_Public_set_Void_ShowMoltenMetalMoldUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_collisionDamageSignal_Public_get_CollisionDamageSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_collisionDamageSignal_Public_set_Void_CollisionDamageSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_damageItemStackSignal_Public_get_DamageItemStackSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_damageItemStackSignal_Public_set_Void_DamageItemStackSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pointerFocusUIShownSignal_Public_get_PointerFocusUIShownSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_pointerFocusUIShownSignal_Public_set_Void_PointerFocusUIShownSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showSmokeRackUISignal_Public_get_ShowSmokeRackUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showSmokeRackUISignal_Public_set_Void_ShowSmokeRackUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_alertingNoiseSignal_Public_get_AlertingNoiseSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_alertingNoiseSignal_Public_set_Void_AlertingNoiseSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showRepairMenuSignal_Public_get_ShowRepairMenuSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showRepairMenuSignal_Public_set_Void_ShowRepairMenuSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wheelEffectSignal_Public_get_WheelEffectSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wheelEffectSignal_Public_set_Void_WheelEffectSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showConstructionInfoUISignal_Public_get_ShowConstructionInfoUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showConstructionInfoUISignal_Public_set_Void_ShowConstructionInfoUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showWorkbenchUISignal_Public_get_ShowWorkbenchUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showWorkbenchUISignal_Public_set_Void_ShowWorkbenchUISignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onGameUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddComponentInitializer_Public_Virtual_Final_New_Void_Action_2_Entity_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeComponents_Public_Virtual_Final_New_Void_Entity_List_1_BaseView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityComponent_Public_Virtual_Final_New_IEntityComponent_BaseView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupEntityComponent_Public_Virtual_Final_New_Void_Entity_BaseView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_0_Private_InventoryHolder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_1_Private_Growable_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_2_Private_PhysicsObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_3_Private_Void_Entity_PlayerInputView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_4_Private_Void_Entity_FuelBurnerView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_5_Private_Void_Entity_CookerView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_6_Private_Void_Entity_KilnView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_7_Private_Void_Entity_ConstructionView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_8_Private_Void_Entity_WorkbenchView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_9_Private_Void_Entity_CreatureView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_10_Private_Void_Entity_ResourceView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_11_Private_Void_Entity_StorableView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_12_Private_Void_Entity_EntityMovementView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_13_Private_Void_Entity_PlayerView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_14_Private_Void_Entity_CharacterView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_15_Private_Void_Entity_ProjectileView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_16_Private_Void_Entity_DecayableView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_17_Private_Void_Entity_SoundEmitterView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_18_Private_Void_Entity_TrapView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_19_Private_Void_Entity_BurnableConstructionView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_20_Private_Void_Entity_SoakerView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_21_Private_Void_Entity_TanningFrameView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_22_Private_Void_Entity_MoltenMetalMoldView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_23_Private_Void_Entity_StatusEffectsView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_24_Private_Void_Entity_InjuryView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_25_Private_Void_Entity_HumanoidAttackerView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_26_Private_Void_Entity_SmokeRackView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_27_Private_Void_Entity_RepairBenchView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_28_Private_Void_Entity_WheeledEntityView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_29_Private_Void_Entity_ItemStockpileView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_30_Private_Void_Entity_LooseSubstanceStockpileView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_31_Private_Void_Entity_ItemFueledView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_32_Private_Void_Entity_LightEmitterView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_33_Private_Void_Entity_DiseasedView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_34_Private_Void_Entity_EnergyView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_35_Private_Void_Entity_HungerView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_36_Private_Void_Entity_ThirstView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_37_Private_Void_Entity_WarmthView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_38_Private_Void_Entity_WetnessView_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__178_39_Private_Void_Entity_CustomizableSkinnedRendererView_0;

	public unsafe IGameManager _gameManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameManager));
		}
	}

	public unsafe IGameEventManager _gameEventManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameEventManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameEventManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameEventManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager));
		}
	}

	public unsafe IInventoryManager _inventoryManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inventoryManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inventoryManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager));
		}
	}

	public unsafe IResourceManager _resourceManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resourceManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IResourceManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__resourceManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceManager));
		}
	}

	public unsafe IConstructionManager _constructionManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__constructionManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IConstructionManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__constructionManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constructionManager));
		}
	}

	public unsafe IBlueprintManager _blueprintManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blueprintManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IBlueprintManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blueprintManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blueprintManager));
		}
	}

	public unsafe ICreatureManager _creatureManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__creatureManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICreatureManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__creatureManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)creatureManager));
		}
	}

	public unsafe IStructureManager _structureManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__structureManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IStructureManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__structureManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)structureManager));
		}
	}

	public unsafe ISettingsManager _settingsManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settingsManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISettingsManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settingsManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settingsManager));
		}
	}

	public unsafe ICharacterManager _characterManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__characterManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICharacterManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__characterManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterManager));
		}
	}

	public unsafe IEntityManager _entityManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__entityManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEntityManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__entityManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityManager));
		}
	}

	public unsafe IStatusEffectManager _statusEffectManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__statusEffectManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IStatusEffectManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__statusEffectManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusEffectManager));
		}
	}

	public unsafe IInjuryManager _injuryManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__injuryManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjuryManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__injuryManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injuryManager));
		}
	}

	public unsafe IMeshMaterialManager _meshMaterialManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshMaterialManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMeshMaterialManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshMaterialManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshMaterialManager));
		}
	}

	public unsafe IgnitedFuelDepletedSignal _ignitedFuelDepletedSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ignitedFuelDepletedSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IgnitedFuelDepletedSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ignitedFuelDepletedSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignitedFuelDepletedSignal));
		}
	}

	public unsafe ShowCookingMenuSignal _showCookingMenuSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showCookingMenuSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowCookingMenuSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showCookingMenuSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showCookingMenuSignal));
		}
	}

	public unsafe ShowKilnMenuSignal _showKilnMenuSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showKilnMenuSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowKilnMenuSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showKilnMenuSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showKilnMenuSignal));
		}
	}

	public unsafe ShowStorableInventorySignal _showStorableInventorySignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showStorableInventorySignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowStorableInventorySignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showStorableInventorySignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showStorableInventorySignal));
		}
	}

	public unsafe ProjectileHitSignal _projectileHitSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__projectileHitSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProjectileHitSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__projectileHitSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)projectileHitSignal));
		}
	}

	public unsafe ShowRadialMenuSignal _showRadialMenuSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showRadialMenuSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowRadialMenuSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showRadialMenuSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showRadialMenuSignal));
		}
	}

	public unsafe HideRadialMenuSignal _hideRadialMenuSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hideRadialMenuSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HideRadialMenuSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hideRadialMenuSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hideRadialMenuSignal));
		}
	}

	public unsafe ShowDeadCreatureUISignal _showDeadCreatureUISignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showDeadCreatureUISignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowDeadCreatureUISignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showDeadCreatureUISignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showDeadCreatureUISignal));
		}
	}

	public unsafe EntityFullyDecayedSignal _entityFullyDecayedSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__entityFullyDecayedSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityFullyDecayedSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__entityFullyDecayedSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityFullyDecayedSignal));
		}
	}

	public unsafe StopLoopedSoundSignal _stopLoopedSoundSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stopLoopedSoundSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StopLoopedSoundSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stopLoopedSoundSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stopLoopedSoundSignal));
		}
	}

	public unsafe ItemDecaySignal _itemDecaySignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemDecaySignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemDecaySignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemDecaySignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemDecaySignal));
		}
	}

	public unsafe ItemHardenedSignal _itemHardenedSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemHardenedSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemHardenedSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemHardenedSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemHardenedSignal));
		}
	}

	public unsafe ConstructionDestroySignal _constructionDestroySignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__constructionDestroySignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConstructionDestroySignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__constructionDestroySignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constructionDestroySignal));
		}
	}

	public unsafe EntityTrapEnterSignal _entityTrapEnterSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__entityTrapEnterSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityTrapEnterSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__entityTrapEnterSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityTrapEnterSignal));
		}
	}

	public unsafe ShowBurnableConstructionUISignal _ShowBurnableConstructionUISignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ShowBurnableConstructionUISignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowBurnableConstructionUISignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ShowBurnableConstructionUISignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showBurnableConstructionUISignal));
		}
	}

	public unsafe GetPotentialCookingRecipeSignal _getPotentialCookingRecipeSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__getPotentialCookingRecipeSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GetPotentialCookingRecipeSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__getPotentialCookingRecipeSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)getPotentialCookingRecipeSignal));
		}
	}

	public unsafe ShowSoakingBasinUISignal _showSoakingBasinUISignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showSoakingBasinUISignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowSoakingBasinUISignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showSoakingBasinUISignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showSoakingBasinUISignal));
		}
	}

	public unsafe ItemTreatedSignal _itemTreatedSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemTreatedSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemTreatedSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemTreatedSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemTreatedSignal));
		}
	}

	public unsafe ShowTanningFrameUISignal _showTanningFrameUISignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showTanningFrameUISignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowTanningFrameUISignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showTanningFrameUISignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showTanningFrameUISignal));
		}
	}

	public unsafe ItemTannedSignal _itemTannedSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemTannedSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemTannedSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemTannedSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemTannedSignal));
		}
	}

	public unsafe ShowMoltenMetalMoldUISignal _showMoltenMetalMoldUISignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showMoltenMetalMoldUISignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowMoltenMetalMoldUISignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showMoltenMetalMoldUISignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showMoltenMetalMoldUISignal));
		}
	}

	public unsafe CollisionDamageSignal _collisionDamageSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__collisionDamageSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CollisionDamageSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__collisionDamageSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collisionDamageSignal));
		}
	}

	public unsafe DamageItemStackSignal _damageItemStackSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__damageItemStackSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DamageItemStackSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__damageItemStackSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)damageItemStackSignal));
		}
	}

	public unsafe PointerFocusUIShownSignal _pointerFocusUIShownSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pointerFocusUIShownSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PointerFocusUIShownSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pointerFocusUIShownSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointerFocusUIShownSignal));
		}
	}

	public unsafe ShowSmokeRackUISignal _showSmokeRackUISignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showSmokeRackUISignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowSmokeRackUISignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showSmokeRackUISignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showSmokeRackUISignal));
		}
	}

	public unsafe AlertingNoiseSignal _alertingNoiseSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__alertingNoiseSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AlertingNoiseSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__alertingNoiseSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)alertingNoiseSignal));
		}
	}

	public unsafe ShowRepairMenuSignal _showRepairMenuSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showRepairMenuSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowRepairMenuSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showRepairMenuSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showRepairMenuSignal));
		}
	}

	public unsafe WheelEffectSignal _wheelEffectSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wheelEffectSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WheelEffectSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wheelEffectSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)wheelEffectSignal));
		}
	}

	public unsafe ShowConstructionInfoUISignal _showConstructionInfoUISignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showConstructionInfoUISignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowConstructionInfoUISignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showConstructionInfoUISignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showConstructionInfoUISignal));
		}
	}

	public unsafe ShowWorkbenchUISignal _showWorkbenchUISignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showWorkbenchUISignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowWorkbenchUISignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showWorkbenchUISignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showWorkbenchUISignal));
		}
	}

	public unsafe Dictionary<Il2CppSystem.Type, Il2CppSystem.Action<Entity, ISurvivalComponent>> componentInitializers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentInitializers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, Il2CppSystem.Action<Entity, ISurvivalComponent>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentInitializers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Il2CppSystem.Type, IComponentProcessingHandler> componentHandlerMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentHandlerMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, IComponentProcessingHandler>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentHandlerMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe IGameManager gameManager
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 3866, RefRangeEnd = 3876, XrefRangeStart = 3866, XrefRangeEnd = 3876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gameManager_Public_get_IGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameManager>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29379, RefRangeEnd = 29381, XrefRangeStart = 29379, XrefRangeEnd = 29381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gameManager_Public_set_Void_IGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IGameEventManager gameEventManager
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gameEventManager_Public_get_IGameEventManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameEventManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gameEventManager_Public_set_Void_IGameEventManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IInventoryManager inventoryManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18747, RefRangeEnd = 18748, XrefRangeStart = 18747, XrefRangeEnd = 18748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inventoryManager_Public_get_IInventoryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18749, RefRangeEnd = 18750, XrefRangeStart = 18749, XrefRangeEnd = 18750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inventoryManager_Public_set_Void_IInventoryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IResourceManager resourceManager
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19167, RefRangeEnd = 19170, XrefRangeStart = 19167, XrefRangeEnd = 19170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resourceManager_Public_get_IResourceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IResourceManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_resourceManager_Public_set_Void_IResourceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IConstructionManager constructionManager
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 19179, RefRangeEnd = 19194, XrefRangeStart = 19179, XrefRangeEnd = 19194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_constructionManager_Public_get_IConstructionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IConstructionManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_constructionManager_Public_set_Void_IConstructionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IBlueprintManager blueprintManager
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 977, RefRangeEnd = 983, XrefRangeStart = 977, XrefRangeEnd = 983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blueprintManager_Public_get_IBlueprintManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IBlueprintManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blueprintManager_Public_set_Void_IBlueprintManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ICreatureManager creatureManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97543, RefRangeEnd = 97544, XrefRangeStart = 97543, XrefRangeEnd = 97544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_creatureManager_Public_get_ICreatureManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICreatureManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_creatureManager_Public_set_Void_ICreatureManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IStructureManager structureManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_structureManager_Public_get_IStructureManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IStructureManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_structureManager_Public_set_Void_IStructureManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ISettingsManager settingsManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32262, RefRangeEnd = 32263, XrefRangeStart = 32262, XrefRangeEnd = 32263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_settingsManager_Public_get_ISettingsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISettingsManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_settingsManager_Public_set_Void_ISettingsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ICharacterManager characterManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_characterManager_Public_get_ICharacterManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICharacterManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_characterManager_Public_set_Void_ICharacterManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IEntityManager entityManager
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 96676, RefRangeEnd = 96716, XrefRangeStart = 96676, XrefRangeEnd = 96716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_entityManager_Public_get_IEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEntityManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_entityManager_Public_set_Void_IEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IStatusEffectManager statusEffectManager
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 30821, RefRangeEnd = 30837, XrefRangeStart = 30821, XrefRangeEnd = 30837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_statusEffectManager_Public_get_IStatusEffectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IStatusEffectManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_statusEffectManager_Public_set_Void_IStatusEffectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IInjuryManager injuryManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96991, RefRangeEnd = 96992, XrefRangeStart = 96991, XrefRangeEnd = 96992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_injuryManager_Public_get_IInjuryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjuryManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_injuryManager_Public_set_Void_IInjuryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IMeshMaterialManager meshMaterialManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_meshMaterialManager_Public_get_IMeshMaterialManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMeshMaterialManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_meshMaterialManager_Public_set_Void_IMeshMaterialManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IgnitedFuelDepletedSignal ignitedFuelDepletedSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ignitedFuelDepletedSignal_Public_get_IgnitedFuelDepletedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IgnitedFuelDepletedSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ignitedFuelDepletedSignal_Public_set_Void_IgnitedFuelDepletedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowCookingMenuSignal showCookingMenuSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showCookingMenuSignal_Public_get_ShowCookingMenuSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowCookingMenuSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showCookingMenuSignal_Public_set_Void_ShowCookingMenuSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowKilnMenuSignal showKilnMenuSignal
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 96529, RefRangeEnd = 96536, XrefRangeStart = 96529, XrefRangeEnd = 96536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showKilnMenuSignal_Public_get_ShowKilnMenuSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowKilnMenuSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showKilnMenuSignal_Public_set_Void_ShowKilnMenuSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowStorableInventorySignal showStorableInventorySignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showStorableInventorySignal_Public_get_ShowStorableInventorySignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowStorableInventorySignal>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98360, RefRangeEnd = 98361, XrefRangeStart = 98360, XrefRangeEnd = 98361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showStorableInventorySignal_Public_set_Void_ShowStorableInventorySignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ProjectileHitSignal projectileHitSignal
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103169, RefRangeEnd = 103170, XrefRangeStart = 103169, XrefRangeEnd = 103170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_projectileHitSignal_Public_get_ProjectileHitSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProjectileHitSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_projectileHitSignal_Public_set_Void_ProjectileHitSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowRadialMenuSignal showRadialMenuSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showRadialMenuSignal_Public_get_ShowRadialMenuSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowRadialMenuSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showRadialMenuSignal_Public_set_Void_ShowRadialMenuSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe HideRadialMenuSignal hideRadialMenuSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hideRadialMenuSignal_Public_get_HideRadialMenuSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HideRadialMenuSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hideRadialMenuSignal_Public_set_Void_HideRadialMenuSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowDeadCreatureUISignal showDeadCreatureUISignal
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96467, RefRangeEnd = 96470, XrefRangeStart = 96467, XrefRangeEnd = 96470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showDeadCreatureUISignal_Public_get_ShowDeadCreatureUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowDeadCreatureUISignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showDeadCreatureUISignal_Public_set_Void_ShowDeadCreatureUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe EntityFullyDecayedSignal entityFullyDecayedSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_entityFullyDecayedSignal_Public_get_EntityFullyDecayedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityFullyDecayedSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_entityFullyDecayedSignal_Public_set_Void_EntityFullyDecayedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe StopLoopedSoundSignal stopLoopedSoundSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stopLoopedSoundSignal_Public_get_StopLoopedSoundSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StopLoopedSoundSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stopLoopedSoundSignal_Public_set_Void_StopLoopedSoundSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ItemDecaySignal itemDecaySignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_itemDecaySignal_Public_get_ItemDecaySignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemDecaySignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_itemDecaySignal_Public_set_Void_ItemDecaySignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ItemHardenedSignal itemHardenedSignal
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97161, RefRangeEnd = 97162, XrefRangeStart = 97161, XrefRangeEnd = 97162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_itemHardenedSignal_Public_get_ItemHardenedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemHardenedSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_itemHardenedSignal_Public_set_Void_ItemHardenedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ConstructionDestroySignal constructionDestroySignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_constructionDestroySignal_Public_get_ConstructionDestroySignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConstructionDestroySignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_constructionDestroySignal_Public_set_Void_ConstructionDestroySignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe EntityTrapEnterSignal entityTrapEnterSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_entityTrapEnterSignal_Public_get_EntityTrapEnterSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EntityTrapEnterSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156496, XrefRangeEnd = 156497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_entityTrapEnterSignal_Public_set_Void_EntityTrapEnterSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowBurnableConstructionUISignal ShowBurnableConstructionUISignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShowBurnableConstructionUISignal_Public_get_ShowBurnableConstructionUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowBurnableConstructionUISignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ShowBurnableConstructionUISignal_Public_set_Void_ShowBurnableConstructionUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe GetPotentialCookingRecipeSignal getPotentialCookingRecipeSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_getPotentialCookingRecipeSignal_Public_get_GetPotentialCookingRecipeSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GetPotentialCookingRecipeSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_getPotentialCookingRecipeSignal_Public_set_Void_GetPotentialCookingRecipeSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowSoakingBasinUISignal showSoakingBasinUISignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showSoakingBasinUISignal_Public_get_ShowSoakingBasinUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowSoakingBasinUISignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156497, XrefRangeEnd = 156498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showSoakingBasinUISignal_Public_set_Void_ShowSoakingBasinUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ItemTreatedSignal itemTreatedSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_itemTreatedSignal_Public_get_ItemTreatedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemTreatedSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_itemTreatedSignal_Public_set_Void_ItemTreatedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowTanningFrameUISignal showTanningFrameUISignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showTanningFrameUISignal_Public_get_ShowTanningFrameUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowTanningFrameUISignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showTanningFrameUISignal_Public_set_Void_ShowTanningFrameUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ItemTannedSignal itemTannedSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_itemTannedSignal_Public_get_ItemTannedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemTannedSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_itemTannedSignal_Public_set_Void_ItemTannedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowMoltenMetalMoldUISignal showMoltenMetalMoldUISignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showMoltenMetalMoldUISignal_Public_get_ShowMoltenMetalMoldUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowMoltenMetalMoldUISignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showMoltenMetalMoldUISignal_Public_set_Void_ShowMoltenMetalMoldUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe CollisionDamageSignal collisionDamageSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_collisionDamageSignal_Public_get_CollisionDamageSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CollisionDamageSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156498, XrefRangeEnd = 156499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_collisionDamageSignal_Public_set_Void_CollisionDamageSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe DamageItemStackSignal damageItemStackSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_damageItemStackSignal_Public_get_DamageItemStackSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DamageItemStackSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156499, XrefRangeEnd = 156500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_damageItemStackSignal_Public_set_Void_DamageItemStackSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe PointerFocusUIShownSignal pointerFocusUIShownSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pointerFocusUIShownSignal_Public_get_PointerFocusUIShownSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PointerFocusUIShownSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156500, XrefRangeEnd = 156501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pointerFocusUIShownSignal_Public_set_Void_PointerFocusUIShownSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowSmokeRackUISignal showSmokeRackUISignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showSmokeRackUISignal_Public_get_ShowSmokeRackUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowSmokeRackUISignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156501, XrefRangeEnd = 156502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showSmokeRackUISignal_Public_set_Void_ShowSmokeRackUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe AlertingNoiseSignal alertingNoiseSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_alertingNoiseSignal_Public_get_AlertingNoiseSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AlertingNoiseSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156502, XrefRangeEnd = 156503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_alertingNoiseSignal_Public_set_Void_AlertingNoiseSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowRepairMenuSignal showRepairMenuSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showRepairMenuSignal_Public_get_ShowRepairMenuSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowRepairMenuSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156503, XrefRangeEnd = 156504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showRepairMenuSignal_Public_set_Void_ShowRepairMenuSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe WheelEffectSignal wheelEffectSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wheelEffectSignal_Public_get_WheelEffectSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WheelEffectSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156504, XrefRangeEnd = 156505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wheelEffectSignal_Public_set_Void_WheelEffectSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowConstructionInfoUISignal showConstructionInfoUISignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showConstructionInfoUISignal_Public_get_ShowConstructionInfoUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowConstructionInfoUISignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156505, XrefRangeEnd = 156506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showConstructionInfoUISignal_Public_set_Void_ShowConstructionInfoUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ShowWorkbenchUISignal showWorkbenchUISignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showWorkbenchUISignal_Public_get_ShowWorkbenchUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowWorkbenchUISignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156506, XrefRangeEnd = 156507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showWorkbenchUISignal_Public_set_Void_ShowWorkbenchUISignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ComponentManager()
	{
		Il2CppClassPointerStore<ComponentManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ComponentManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr);
		NativeFieldInfoPtr__gameManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<gameManager>k__BackingField");
		NativeFieldInfoPtr__gameEventManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<gameEventManager>k__BackingField");
		NativeFieldInfoPtr__inventoryManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<inventoryManager>k__BackingField");
		NativeFieldInfoPtr__resourceManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<resourceManager>k__BackingField");
		NativeFieldInfoPtr__constructionManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<constructionManager>k__BackingField");
		NativeFieldInfoPtr__blueprintManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<blueprintManager>k__BackingField");
		NativeFieldInfoPtr__creatureManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<creatureManager>k__BackingField");
		NativeFieldInfoPtr__structureManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<structureManager>k__BackingField");
		NativeFieldInfoPtr__settingsManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<settingsManager>k__BackingField");
		NativeFieldInfoPtr__characterManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<characterManager>k__BackingField");
		NativeFieldInfoPtr__entityManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<entityManager>k__BackingField");
		NativeFieldInfoPtr__statusEffectManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<statusEffectManager>k__BackingField");
		NativeFieldInfoPtr__injuryManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<injuryManager>k__BackingField");
		NativeFieldInfoPtr__meshMaterialManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<meshMaterialManager>k__BackingField");
		NativeFieldInfoPtr__ignitedFuelDepletedSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<ignitedFuelDepletedSignal>k__BackingField");
		NativeFieldInfoPtr__showCookingMenuSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showCookingMenuSignal>k__BackingField");
		NativeFieldInfoPtr__showKilnMenuSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showKilnMenuSignal>k__BackingField");
		NativeFieldInfoPtr__showStorableInventorySignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showStorableInventorySignal>k__BackingField");
		NativeFieldInfoPtr__projectileHitSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<projectileHitSignal>k__BackingField");
		NativeFieldInfoPtr__showRadialMenuSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showRadialMenuSignal>k__BackingField");
		NativeFieldInfoPtr__hideRadialMenuSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<hideRadialMenuSignal>k__BackingField");
		NativeFieldInfoPtr__showDeadCreatureUISignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showDeadCreatureUISignal>k__BackingField");
		NativeFieldInfoPtr__entityFullyDecayedSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<entityFullyDecayedSignal>k__BackingField");
		NativeFieldInfoPtr__stopLoopedSoundSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<stopLoopedSoundSignal>k__BackingField");
		NativeFieldInfoPtr__itemDecaySignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<itemDecaySignal>k__BackingField");
		NativeFieldInfoPtr__itemHardenedSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<itemHardenedSignal>k__BackingField");
		NativeFieldInfoPtr__constructionDestroySignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<constructionDestroySignal>k__BackingField");
		NativeFieldInfoPtr__entityTrapEnterSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<entityTrapEnterSignal>k__BackingField");
		NativeFieldInfoPtr__ShowBurnableConstructionUISignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<ShowBurnableConstructionUISignal>k__BackingField");
		NativeFieldInfoPtr__getPotentialCookingRecipeSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<getPotentialCookingRecipeSignal>k__BackingField");
		NativeFieldInfoPtr__showSoakingBasinUISignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showSoakingBasinUISignal>k__BackingField");
		NativeFieldInfoPtr__itemTreatedSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<itemTreatedSignal>k__BackingField");
		NativeFieldInfoPtr__showTanningFrameUISignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showTanningFrameUISignal>k__BackingField");
		NativeFieldInfoPtr__itemTannedSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<itemTannedSignal>k__BackingField");
		NativeFieldInfoPtr__showMoltenMetalMoldUISignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showMoltenMetalMoldUISignal>k__BackingField");
		NativeFieldInfoPtr__collisionDamageSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<collisionDamageSignal>k__BackingField");
		NativeFieldInfoPtr__damageItemStackSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<damageItemStackSignal>k__BackingField");
		NativeFieldInfoPtr__pointerFocusUIShownSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<pointerFocusUIShownSignal>k__BackingField");
		NativeFieldInfoPtr__showSmokeRackUISignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showSmokeRackUISignal>k__BackingField");
		NativeFieldInfoPtr__alertingNoiseSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<alertingNoiseSignal>k__BackingField");
		NativeFieldInfoPtr__showRepairMenuSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showRepairMenuSignal>k__BackingField");
		NativeFieldInfoPtr__wheelEffectSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<wheelEffectSignal>k__BackingField");
		NativeFieldInfoPtr__showConstructionInfoUISignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showConstructionInfoUISignal>k__BackingField");
		NativeFieldInfoPtr__showWorkbenchUISignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "<showWorkbenchUISignal>k__BackingField");
		NativeFieldInfoPtr_componentInitializers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "componentInitializers");
		NativeFieldInfoPtr_componentHandlerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, "componentHandlerMap");
		NativeMethodInfoPtr_get_gameManager_Public_get_IGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674187);
		NativeMethodInfoPtr_set_gameManager_Public_set_Void_IGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674188);
		NativeMethodInfoPtr_get_gameEventManager_Public_get_IGameEventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674189);
		NativeMethodInfoPtr_set_gameEventManager_Public_set_Void_IGameEventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674190);
		NativeMethodInfoPtr_get_inventoryManager_Public_get_IInventoryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674191);
		NativeMethodInfoPtr_set_inventoryManager_Public_set_Void_IInventoryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674192);
		NativeMethodInfoPtr_get_resourceManager_Public_get_IResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674193);
		NativeMethodInfoPtr_set_resourceManager_Public_set_Void_IResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674194);
		NativeMethodInfoPtr_get_constructionManager_Public_get_IConstructionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674195);
		NativeMethodInfoPtr_set_constructionManager_Public_set_Void_IConstructionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674196);
		NativeMethodInfoPtr_get_blueprintManager_Public_get_IBlueprintManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674197);
		NativeMethodInfoPtr_set_blueprintManager_Public_set_Void_IBlueprintManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674198);
		NativeMethodInfoPtr_get_creatureManager_Public_get_ICreatureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674199);
		NativeMethodInfoPtr_set_creatureManager_Public_set_Void_ICreatureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674200);
		NativeMethodInfoPtr_get_structureManager_Public_get_IStructureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674201);
		NativeMethodInfoPtr_set_structureManager_Public_set_Void_IStructureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674202);
		NativeMethodInfoPtr_get_settingsManager_Public_get_ISettingsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674203);
		NativeMethodInfoPtr_set_settingsManager_Public_set_Void_ISettingsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674204);
		NativeMethodInfoPtr_get_characterManager_Public_get_ICharacterManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674205);
		NativeMethodInfoPtr_set_characterManager_Public_set_Void_ICharacterManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674206);
		NativeMethodInfoPtr_get_entityManager_Public_get_IEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674207);
		NativeMethodInfoPtr_set_entityManager_Public_set_Void_IEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674208);
		NativeMethodInfoPtr_get_statusEffectManager_Public_get_IStatusEffectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674209);
		NativeMethodInfoPtr_set_statusEffectManager_Public_set_Void_IStatusEffectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674210);
		NativeMethodInfoPtr_get_injuryManager_Public_get_IInjuryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674211);
		NativeMethodInfoPtr_set_injuryManager_Public_set_Void_IInjuryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674212);
		NativeMethodInfoPtr_get_meshMaterialManager_Public_get_IMeshMaterialManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674213);
		NativeMethodInfoPtr_set_meshMaterialManager_Public_set_Void_IMeshMaterialManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674214);
		NativeMethodInfoPtr_get_ignitedFuelDepletedSignal_Public_get_IgnitedFuelDepletedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674215);
		NativeMethodInfoPtr_set_ignitedFuelDepletedSignal_Public_set_Void_IgnitedFuelDepletedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674216);
		NativeMethodInfoPtr_get_showCookingMenuSignal_Public_get_ShowCookingMenuSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674217);
		NativeMethodInfoPtr_set_showCookingMenuSignal_Public_set_Void_ShowCookingMenuSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674218);
		NativeMethodInfoPtr_get_showKilnMenuSignal_Public_get_ShowKilnMenuSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674219);
		NativeMethodInfoPtr_set_showKilnMenuSignal_Public_set_Void_ShowKilnMenuSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674220);
		NativeMethodInfoPtr_get_showStorableInventorySignal_Public_get_ShowStorableInventorySignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674221);
		NativeMethodInfoPtr_set_showStorableInventorySignal_Public_set_Void_ShowStorableInventorySignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674222);
		NativeMethodInfoPtr_get_projectileHitSignal_Public_get_ProjectileHitSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674223);
		NativeMethodInfoPtr_set_projectileHitSignal_Public_set_Void_ProjectileHitSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674224);
		NativeMethodInfoPtr_get_showRadialMenuSignal_Public_get_ShowRadialMenuSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674225);
		NativeMethodInfoPtr_set_showRadialMenuSignal_Public_set_Void_ShowRadialMenuSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674226);
		NativeMethodInfoPtr_get_hideRadialMenuSignal_Public_get_HideRadialMenuSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674227);
		NativeMethodInfoPtr_set_hideRadialMenuSignal_Public_set_Void_HideRadialMenuSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674228);
		NativeMethodInfoPtr_get_showDeadCreatureUISignal_Public_get_ShowDeadCreatureUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674229);
		NativeMethodInfoPtr_set_showDeadCreatureUISignal_Public_set_Void_ShowDeadCreatureUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674230);
		NativeMethodInfoPtr_get_entityFullyDecayedSignal_Public_get_EntityFullyDecayedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674231);
		NativeMethodInfoPtr_set_entityFullyDecayedSignal_Public_set_Void_EntityFullyDecayedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674232);
		NativeMethodInfoPtr_get_stopLoopedSoundSignal_Public_get_StopLoopedSoundSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674233);
		NativeMethodInfoPtr_set_stopLoopedSoundSignal_Public_set_Void_StopLoopedSoundSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674234);
		NativeMethodInfoPtr_get_itemDecaySignal_Public_get_ItemDecaySignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674235);
		NativeMethodInfoPtr_set_itemDecaySignal_Public_set_Void_ItemDecaySignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674236);
		NativeMethodInfoPtr_get_itemHardenedSignal_Public_get_ItemHardenedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674237);
		NativeMethodInfoPtr_set_itemHardenedSignal_Public_set_Void_ItemHardenedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674238);
		NativeMethodInfoPtr_get_constructionDestroySignal_Public_get_ConstructionDestroySignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674239);
		NativeMethodInfoPtr_set_constructionDestroySignal_Public_set_Void_ConstructionDestroySignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674240);
		NativeMethodInfoPtr_get_entityTrapEnterSignal_Public_get_EntityTrapEnterSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674241);
		NativeMethodInfoPtr_set_entityTrapEnterSignal_Public_set_Void_EntityTrapEnterSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674242);
		NativeMethodInfoPtr_get_ShowBurnableConstructionUISignal_Public_get_ShowBurnableConstructionUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674243);
		NativeMethodInfoPtr_set_ShowBurnableConstructionUISignal_Public_set_Void_ShowBurnableConstructionUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674244);
		NativeMethodInfoPtr_get_getPotentialCookingRecipeSignal_Public_get_GetPotentialCookingRecipeSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674245);
		NativeMethodInfoPtr_set_getPotentialCookingRecipeSignal_Public_set_Void_GetPotentialCookingRecipeSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674246);
		NativeMethodInfoPtr_get_showSoakingBasinUISignal_Public_get_ShowSoakingBasinUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674247);
		NativeMethodInfoPtr_set_showSoakingBasinUISignal_Public_set_Void_ShowSoakingBasinUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674248);
		NativeMethodInfoPtr_get_itemTreatedSignal_Public_get_ItemTreatedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674249);
		NativeMethodInfoPtr_set_itemTreatedSignal_Public_set_Void_ItemTreatedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674250);
		NativeMethodInfoPtr_get_showTanningFrameUISignal_Public_get_ShowTanningFrameUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674251);
		NativeMethodInfoPtr_set_showTanningFrameUISignal_Public_set_Void_ShowTanningFrameUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674252);
		NativeMethodInfoPtr_get_itemTannedSignal_Public_get_ItemTannedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674253);
		NativeMethodInfoPtr_set_itemTannedSignal_Public_set_Void_ItemTannedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674254);
		NativeMethodInfoPtr_get_showMoltenMetalMoldUISignal_Public_get_ShowMoltenMetalMoldUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674255);
		NativeMethodInfoPtr_set_showMoltenMetalMoldUISignal_Public_set_Void_ShowMoltenMetalMoldUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674256);
		NativeMethodInfoPtr_get_collisionDamageSignal_Public_get_CollisionDamageSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674257);
		NativeMethodInfoPtr_set_collisionDamageSignal_Public_set_Void_CollisionDamageSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674258);
		NativeMethodInfoPtr_get_damageItemStackSignal_Public_get_DamageItemStackSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674259);
		NativeMethodInfoPtr_set_damageItemStackSignal_Public_set_Void_DamageItemStackSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674260);
		NativeMethodInfoPtr_get_pointerFocusUIShownSignal_Public_get_PointerFocusUIShownSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674261);
		NativeMethodInfoPtr_set_pointerFocusUIShownSignal_Public_set_Void_PointerFocusUIShownSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674262);
		NativeMethodInfoPtr_get_showSmokeRackUISignal_Public_get_ShowSmokeRackUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674263);
		NativeMethodInfoPtr_set_showSmokeRackUISignal_Public_set_Void_ShowSmokeRackUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674264);
		NativeMethodInfoPtr_get_alertingNoiseSignal_Public_get_AlertingNoiseSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674265);
		NativeMethodInfoPtr_set_alertingNoiseSignal_Public_set_Void_AlertingNoiseSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674266);
		NativeMethodInfoPtr_get_showRepairMenuSignal_Public_get_ShowRepairMenuSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674267);
		NativeMethodInfoPtr_set_showRepairMenuSignal_Public_set_Void_ShowRepairMenuSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674268);
		NativeMethodInfoPtr_get_wheelEffectSignal_Public_get_WheelEffectSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674269);
		NativeMethodInfoPtr_set_wheelEffectSignal_Public_set_Void_WheelEffectSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674270);
		NativeMethodInfoPtr_get_showConstructionInfoUISignal_Public_get_ShowConstructionInfoUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674271);
		NativeMethodInfoPtr_set_showConstructionInfoUISignal_Public_set_Void_ShowConstructionInfoUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674272);
		NativeMethodInfoPtr_get_showWorkbenchUISignal_Public_get_ShowWorkbenchUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674273);
		NativeMethodInfoPtr_set_showWorkbenchUISignal_Public_set_Void_ShowWorkbenchUISignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674274);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674275);
		NativeMethodInfoPtr_onGameUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674276);
		NativeMethodInfoPtr_AddComponentInitializer_Public_Virtual_Final_New_Void_Action_2_Entity_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674277);
		NativeMethodInfoPtr_InitializeComponents_Public_Virtual_Final_New_Void_Entity_List_1_BaseView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674278);
		NativeMethodInfoPtr_GetEntityComponent_Public_Virtual_Final_New_IEntityComponent_BaseView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674279);
		NativeMethodInfoPtr_SetupEntityComponent_Public_Virtual_Final_New_Void_Entity_BaseView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674280);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674281);
		NativeMethodInfoPtr__Initialize_b__178_0_Private_InventoryHolder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674282);
		NativeMethodInfoPtr__Initialize_b__178_1_Private_Growable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674283);
		NativeMethodInfoPtr__Initialize_b__178_2_Private_PhysicsObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674284);
		NativeMethodInfoPtr__Initialize_b__178_3_Private_Void_Entity_PlayerInputView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674285);
		NativeMethodInfoPtr__Initialize_b__178_4_Private_Void_Entity_FuelBurnerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674286);
		NativeMethodInfoPtr__Initialize_b__178_5_Private_Void_Entity_CookerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674287);
		NativeMethodInfoPtr__Initialize_b__178_6_Private_Void_Entity_KilnView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674288);
		NativeMethodInfoPtr__Initialize_b__178_7_Private_Void_Entity_ConstructionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674289);
		NativeMethodInfoPtr__Initialize_b__178_8_Private_Void_Entity_WorkbenchView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674290);
		NativeMethodInfoPtr__Initialize_b__178_9_Private_Void_Entity_CreatureView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674291);
		NativeMethodInfoPtr__Initialize_b__178_10_Private_Void_Entity_ResourceView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674292);
		NativeMethodInfoPtr__Initialize_b__178_11_Private_Void_Entity_StorableView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674293);
		NativeMethodInfoPtr__Initialize_b__178_12_Private_Void_Entity_EntityMovementView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674294);
		NativeMethodInfoPtr__Initialize_b__178_13_Private_Void_Entity_PlayerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674295);
		NativeMethodInfoPtr__Initialize_b__178_14_Private_Void_Entity_CharacterView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674296);
		NativeMethodInfoPtr__Initialize_b__178_15_Private_Void_Entity_ProjectileView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674297);
		NativeMethodInfoPtr__Initialize_b__178_16_Private_Void_Entity_DecayableView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674298);
		NativeMethodInfoPtr__Initialize_b__178_17_Private_Void_Entity_SoundEmitterView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674299);
		NativeMethodInfoPtr__Initialize_b__178_18_Private_Void_Entity_TrapView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674300);
		NativeMethodInfoPtr__Initialize_b__178_19_Private_Void_Entity_BurnableConstructionView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674301);
		NativeMethodInfoPtr__Initialize_b__178_20_Private_Void_Entity_SoakerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674302);
		NativeMethodInfoPtr__Initialize_b__178_21_Private_Void_Entity_TanningFrameView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674303);
		NativeMethodInfoPtr__Initialize_b__178_22_Private_Void_Entity_MoltenMetalMoldView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674304);
		NativeMethodInfoPtr__Initialize_b__178_23_Private_Void_Entity_StatusEffectsView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674305);
		NativeMethodInfoPtr__Initialize_b__178_24_Private_Void_Entity_InjuryView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674306);
		NativeMethodInfoPtr__Initialize_b__178_25_Private_Void_Entity_HumanoidAttackerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674307);
		NativeMethodInfoPtr__Initialize_b__178_26_Private_Void_Entity_SmokeRackView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674308);
		NativeMethodInfoPtr__Initialize_b__178_27_Private_Void_Entity_RepairBenchView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674309);
		NativeMethodInfoPtr__Initialize_b__178_28_Private_Void_Entity_WheeledEntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674310);
		NativeMethodInfoPtr__Initialize_b__178_29_Private_Void_Entity_ItemStockpileView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674311);
		NativeMethodInfoPtr__Initialize_b__178_30_Private_Void_Entity_LooseSubstanceStockpileView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674312);
		NativeMethodInfoPtr__Initialize_b__178_31_Private_Void_Entity_ItemFueledView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674313);
		NativeMethodInfoPtr__Initialize_b__178_32_Private_Void_Entity_LightEmitterView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674314);
		NativeMethodInfoPtr__Initialize_b__178_33_Private_Void_Entity_DiseasedView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674315);
		NativeMethodInfoPtr__Initialize_b__178_34_Private_Void_Entity_EnergyView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674316);
		NativeMethodInfoPtr__Initialize_b__178_35_Private_Void_Entity_HungerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674317);
		NativeMethodInfoPtr__Initialize_b__178_36_Private_Void_Entity_ThirstView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674318);
		NativeMethodInfoPtr__Initialize_b__178_37_Private_Void_Entity_WarmthView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674319);
		NativeMethodInfoPtr__Initialize_b__178_38_Private_Void_Entity_WetnessView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674320);
		NativeMethodInfoPtr__Initialize_b__178_39_Private_Void_Entity_CustomizableSkinnedRendererView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr, 100674321);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156507, XrefRangeEnd = 156512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156512, XrefRangeEnd = 156534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onGameUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGameUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 156549, RefRangeEnd = 156586, XrefRangeStart = 156534, XrefRangeEnd = 156549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddComponentInitializer<T>(Il2CppSystem.Action<Entity, T> action) where T : class
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddComponentInitializer_Public_Virtual_Final_New_Void_Action_2_Entity_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156586, XrefRangeEnd = 156606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void InitializeComponents(Entity entity, List<BaseView> components)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)components);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeComponents_Public_Virtual_Final_New_Void_Entity_List_1_BaseView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156606, XrefRangeEnd = 156613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEntityComponent GetEntityComponent(BaseView view)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntityComponent_Public_Virtual_Final_New_IEntityComponent_BaseView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEntityComponent>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156613, XrefRangeEnd = 156623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetupEntityComponent(Entity entity, BaseView view)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupEntityComponent_Public_Virtual_Final_New_Void_Entity_BaseView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComponentManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156623, XrefRangeEnd = 156636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InventoryHolder _Initialize_b__178_0(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_0_Private_InventoryHolder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryHolder>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156636, XrefRangeEnd = 156652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Growable _Initialize_b__178_1(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_1_Private_Growable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Growable>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156652, XrefRangeEnd = 156660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhysicsObject _Initialize_b__178_2(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_2_Private_PhysicsObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhysicsObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156660, XrefRangeEnd = 156670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_3(Entity entity, PlayerInputView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_3_Private_Void_Entity_PlayerInputView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156670, XrefRangeEnd = 156672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_4(Entity entity, FuelBurnerView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_4_Private_Void_Entity_FuelBurnerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156672, XrefRangeEnd = 156675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_5(Entity entity, CookerView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_5_Private_Void_Entity_CookerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156675, XrefRangeEnd = 156677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_6(Entity entity, KilnView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_6_Private_Void_Entity_KilnView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156677, XrefRangeEnd = 156693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_7(Entity entity, ConstructionView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_7_Private_Void_Entity_ConstructionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156693, XrefRangeEnd = 156695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_8(Entity entity, WorkbenchView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_8_Private_Void_Entity_WorkbenchView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156695, XrefRangeEnd = 156702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_9(Entity entity, CreatureView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_9_Private_Void_Entity_CreatureView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156702, XrefRangeEnd = 156712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_10(Entity entity, ResourceView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_10_Private_Void_Entity_ResourceView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156712, XrefRangeEnd = 156714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_11(Entity entity, StorableView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_11_Private_Void_Entity_StorableView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156714, XrefRangeEnd = 156722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_12(Entity entity, EntityMovementView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_12_Private_Void_Entity_EntityMovementView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156722, XrefRangeEnd = 156746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_13(Entity entity, PlayerView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_13_Private_Void_Entity_PlayerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156746, XrefRangeEnd = 156751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_14(Entity entity, CharacterView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_14_Private_Void_Entity_CharacterView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156751, XrefRangeEnd = 156757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_15(Entity entity, ProjectileView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_15_Private_Void_Entity_ProjectileView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156757, XrefRangeEnd = 156759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_16(Entity entity, DecayableView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_16_Private_Void_Entity_DecayableView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156759, XrefRangeEnd = 156761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_17(Entity entity, SoundEmitterView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_17_Private_Void_Entity_SoundEmitterView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156761, XrefRangeEnd = 156763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_18(Entity entity, TrapView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_18_Private_Void_Entity_TrapView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156763, XrefRangeEnd = 156765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_19(Entity entity, BurnableConstructionView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_19_Private_Void_Entity_BurnableConstructionView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156765, XrefRangeEnd = 156768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_20(Entity entity, SoakerView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_20_Private_Void_Entity_SoakerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156768, XrefRangeEnd = 156771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_21(Entity entity, TanningFrameView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_21_Private_Void_Entity_TanningFrameView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156771, XrefRangeEnd = 156773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_22(Entity entity, MoltenMetalMoldView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_22_Private_Void_Entity_MoltenMetalMoldView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156773, XrefRangeEnd = 156807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_23(Entity entity, StatusEffectsView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_23_Private_Void_Entity_StatusEffectsView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156807, XrefRangeEnd = 156823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_24(Entity entity, InjuryView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_24_Private_Void_Entity_InjuryView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156823, XrefRangeEnd = 156825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_25(Entity entity, HumanoidAttackerView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_25_Private_Void_Entity_HumanoidAttackerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156825, XrefRangeEnd = 156827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_26(Entity entity, SmokeRackView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_26_Private_Void_Entity_SmokeRackView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156827, XrefRangeEnd = 156829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_27(Entity entity, RepairBenchView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_27_Private_Void_Entity_RepairBenchView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156829, XrefRangeEnd = 156831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_28(Entity entity, WheeledEntityView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_28_Private_Void_Entity_WheeledEntityView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156831, XrefRangeEnd = 156833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_29(Entity entity, ItemStockpileView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_29_Private_Void_Entity_ItemStockpileView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156833, XrefRangeEnd = 156835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_30(Entity entity, LooseSubstanceStockpileView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_30_Private_Void_Entity_LooseSubstanceStockpileView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_31(Entity entity, ItemFueledView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_31_Private_Void_Entity_ItemFueledView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156835, XrefRangeEnd = 156840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_32(Entity entity, LightEmitterView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_32_Private_Void_Entity_LightEmitterView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156840, XrefRangeEnd = 156852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_33(Entity entity, DiseasedView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_33_Private_Void_Entity_DiseasedView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156852, XrefRangeEnd = 156859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_34(Entity entity, EnergyView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_34_Private_Void_Entity_EnergyView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156859, XrefRangeEnd = 156866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_35(Entity entity, HungerView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_35_Private_Void_Entity_HungerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156866, XrefRangeEnd = 156873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_36(Entity entity, ThirstView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_36_Private_Void_Entity_ThirstView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156873, XrefRangeEnd = 156885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_37(Entity entity, WarmthView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_37_Private_Void_Entity_WarmthView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156885, XrefRangeEnd = 156892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_38(Entity entity, WetnessView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_38_Private_Void_Entity_WetnessView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156892, XrefRangeEnd = 156896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__178_39(Entity entity, CustomizableSkinnedRendererView comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__178_39_Private_Void_Entity_CustomizableSkinnedRendererView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ComponentManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

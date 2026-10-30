using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class NpcThinkerBuilder : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("NpcThinkerBuilder+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Build_b__24_0_Internal_Boolean_AIContext_Int32_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Func<AIContext, int, bool> __9__24_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<AIContext, int, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__24_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__24_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668565);
			NativeMethodInfoPtr__Build_b__24_0_Internal_Boolean_AIContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668566);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93431, XrefRangeEnd = 93432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Build_b__24_0(AIContext ctx, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Build_b__24_0_Internal_Boolean_AIContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mainFireIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_stickCrateIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_woodFuelItemIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_logIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_backpackIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_tinderIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_tinderIngredientIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_kindlingIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrowIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_bowIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrowQuiverIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignitionSourceIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_dogbaneResourceIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_plantRopeIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_plantRopeIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_stickIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_rabbitSnareIngredientPickupables;

	private static readonly System.IntPtr NativeFieldInfoPtr_treeEntityIdentifies;

	private static readonly System.IntPtr NativeFieldInfoPtr_treeTopEntityIdentifies;

	private static readonly System.IntPtr NativeFieldInfoPtr_pineBranchResourceIdentifies;

	private static readonly System.IntPtr NativeFieldInfoPtr_bedrollIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_rabbitSnareIdentifiers;

	private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Build_Public_Virtual_Final_New_AIThinker_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string mainFireIdentifier
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainFireIdentifier, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainFireIdentifier, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string stickCrateIdentifier
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stickCrateIdentifier, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stickCrateIdentifier, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<string> waterIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_waterIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_waterIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> woodFuelItemIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_woodFuelItemIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_woodFuelItemIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> logIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_logIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_logIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> backpackIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_backpackIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_backpackIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> tinderIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tinderIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tinderIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> tinderIngredientIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tinderIngredientIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tinderIngredientIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> kindlingIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kindlingIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kindlingIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> arrowIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_arrowIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_arrowIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> bowIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bowIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bowIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> arrowQuiverIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_arrowQuiverIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_arrowQuiverIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> ignitionSourceIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ignitionSourceIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ignitionSourceIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> dogbaneResourceIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dogbaneResourceIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dogbaneResourceIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static string plantRopeIdentifier
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_plantRopeIdentifier, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_plantRopeIdentifier, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<string> plantRopeIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_plantRopeIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_plantRopeIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static string stickIdentifier
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stickIdentifier, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stickIdentifier, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<string> rabbitSnareIngredientPickupables
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rabbitSnareIngredientPickupables, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rabbitSnareIngredientPickupables, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> treeEntityIdentifies
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_treeEntityIdentifies, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_treeEntityIdentifies, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> treeTopEntityIdentifies
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_treeTopEntityIdentifies, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_treeTopEntityIdentifies, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> pineBranchResourceIdentifies
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pineBranchResourceIdentifies, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pineBranchResourceIdentifies, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> bedrollIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bedrollIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bedrollIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> rabbitSnareIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rabbitSnareIdentifiers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rabbitSnareIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static NpcThinkerBuilder()
	{
		Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NpcThinkerBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr);
		NativeFieldInfoPtr_mainFireIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "mainFireIdentifier");
		NativeFieldInfoPtr_stickCrateIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "stickCrateIdentifier");
		NativeFieldInfoPtr_waterIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "waterIdentifiers");
		NativeFieldInfoPtr_woodFuelItemIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "woodFuelItemIdentifiers");
		NativeFieldInfoPtr_logIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "logIdentifiers");
		NativeFieldInfoPtr_backpackIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "backpackIdentifiers");
		NativeFieldInfoPtr_tinderIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "tinderIdentifiers");
		NativeFieldInfoPtr_tinderIngredientIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "tinderIngredientIdentifiers");
		NativeFieldInfoPtr_kindlingIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "kindlingIdentifiers");
		NativeFieldInfoPtr_arrowIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "arrowIdentifiers");
		NativeFieldInfoPtr_bowIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "bowIdentifiers");
		NativeFieldInfoPtr_arrowQuiverIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "arrowQuiverIdentifiers");
		NativeFieldInfoPtr_ignitionSourceIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "ignitionSourceIdentifiers");
		NativeFieldInfoPtr_dogbaneResourceIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "dogbaneResourceIdentifiers");
		NativeFieldInfoPtr_plantRopeIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "plantRopeIdentifier");
		NativeFieldInfoPtr_plantRopeIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "plantRopeIdentifiers");
		NativeFieldInfoPtr_stickIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "stickIdentifier");
		NativeFieldInfoPtr_rabbitSnareIngredientPickupables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "rabbitSnareIngredientPickupables");
		NativeFieldInfoPtr_treeEntityIdentifies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "treeEntityIdentifies");
		NativeFieldInfoPtr_treeTopEntityIdentifies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "treeTopEntityIdentifies");
		NativeFieldInfoPtr_pineBranchResourceIdentifies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "pineBranchResourceIdentifies");
		NativeFieldInfoPtr_bedrollIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "bedrollIdentifiers");
		NativeFieldInfoPtr_rabbitSnareIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, "rabbitSnareIdentifiers");
		NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, 100668560);
		NativeMethodInfoPtr_Build_Public_Virtual_Final_New_AIThinker_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, 100668561);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr, 100668562);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93432, XrefRangeEnd = 93436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Matches(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93436, XrefRangeEnd = 94905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual AIThinker Build(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Build_Public_Virtual_Final_New_AIThinker_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIThinker>(intPtr) : null;
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcThinkerBuilder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcThinkerBuilder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NpcThinkerBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

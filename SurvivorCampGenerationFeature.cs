using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class SurvivorCampGenerationFeature : WorldGenerationFeature
{
	[ObfuscatedName("SurvivorCampGenerationFeature+<>c__DisplayClass9_0")]
	public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_home;

		private static readonly System.IntPtr NativeFieldInfoPtr_chosenVariant;

		private static readonly System.IntPtr NativeFieldInfoPtr_chunk;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__generateCamp_b__0_Internal_Void_Entity_0;

		public unsafe AIHome home
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_home);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIHome>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_home)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIHome));
			}
		}

		public unsafe SurvivorCampVariant chosenVariant
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chosenVariant);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SurvivorCampVariant>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chosenVariant)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)survivorCampVariant));
			}
		}

		public unsafe Chunk chunk
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunk);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Chunk>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunk)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk));
			}
		}

		public unsafe Il2CppSystem.Action<Entity> __9__0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Entity>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		static __c__DisplayClass9_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, "<>c__DisplayClass9_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr);
			NativeFieldInfoPtr_home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "home");
			NativeFieldInfoPtr_chosenVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "chosenVariant");
			NativeFieldInfoPtr_chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "chunk");
			NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "<>9__0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100683842);
			NativeMethodInfoPtr__generateCamp_b__0_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100683843);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass9_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270720, XrefRangeEnd = 270726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _generateCamp_b__0(Entity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__generateCamp_b__0_Internal_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass9_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("SurvivorCampGenerationFeature+<>c__DisplayClass9_1")]
	public sealed class __c__DisplayClass9_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_claimedAiItemRequest;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__generateCamp_b__1_Internal_Void_Entity_0;

		public unsafe AIItemRequest claimedAiItemRequest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_claimedAiItemRequest);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIItemRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_claimedAiItemRequest)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIItemRequest));
			}
		}

		public unsafe __c__DisplayClass9_0 field_Public___c__DisplayClass9_0_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass9_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass9_));
			}
		}

		static __c__DisplayClass9_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, "<>c__DisplayClass9_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass9_1>.NativeClassPtr);
			NativeFieldInfoPtr_claimedAiItemRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_1>.NativeClassPtr, "claimedAiItemRequest");
			NativeFieldInfoPtr_field_Public___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_1>.NativeClassPtr, "CS$<>8__locals1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_1>.NativeClassPtr, 100683844);
			NativeMethodInfoPtr__generateCamp_b__1_Internal_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_1>.NativeClassPtr, 100683845);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass9_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass9_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270726, XrefRangeEnd = 270793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _generateCamp_b__1(Entity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__generateCamp_b__1_Internal_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c__DisplayClass9_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ITERATIONS;

	private static readonly System.IntPtr NativeFieldInfoPtr_aiManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryManager;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAIManager_IInventoryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldAutoGenerate_Public_Virtual_Boolean_World_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GeneratesInCave_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceGenerate_Public_Virtual_Void_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Generate_Protected_Virtual_Void_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_selectVariant_Internal_SurvivorCampVariant_List_1_SurvivorCampVariant_Int32_AdvancedGameOptions_CustomRandom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateCamp_Private_Void_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_WorldGenSurvivorCamps_SurvivorCampVariant_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buildItemOptions_Private_Void_WorldGenSurvivorCamps_List_1_String_List_1_SurvivorCampInventoryItemOption_List_1_SurvivorCampInventoryItemOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buildAiItemRequestPool_Private_Void_SurvivorCampVariant_CustomRandom_List_1_AIItemRequest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_claimAiItemRequest_Private_AIItemRequest_List_1_AIItemRequest_Single_CustomRandom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_processItemOptions_Private_Void_List_1_SurvivorCampInventoryItemOption_CustomRandom_HashSet_1_String_List_1_InventoryPlacementInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findCampCenterPosition_Private_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_SurvivorCampPlacementRules_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isCampPositionValid_Internal_Boolean_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_SurvivorCampPlacementRules_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isObjectPositionValid_Internal_Boolean_World_Chunk_Vector3_Single_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tryGetObjectPositionWithinRadius_Private_Boolean_World_Chunk_Vector3_Single_Single_Single_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_byref_Vector3_0;

	public unsafe static int MAX_ITERATIONS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_ITERATIONS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_ITERATIONS, (void*)(&num));
		}
	}

	public unsafe IAIManager aiManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAIManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aiManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iAIManager));
		}
	}

	public unsafe IInventoryManager inventoryManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager));
		}
	}

	static SurvivorCampGenerationFeature()
	{
		Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SurvivorCampGenerationFeature");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_ITERATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, "MAX_ITERATIONS");
		NativeFieldInfoPtr_aiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, "aiManager");
		NativeFieldInfoPtr_inventoryManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, "inventoryManager");
		NativeMethodInfoPtr__ctor_Public_Void_IAIManager_IInventoryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683827);
		NativeMethodInfoPtr_ShouldAutoGenerate_Public_Virtual_Boolean_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683828);
		NativeMethodInfoPtr_GeneratesInCave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683829);
		NativeMethodInfoPtr_ForceGenerate_Public_Virtual_Void_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683830);
		NativeMethodInfoPtr_Generate_Protected_Virtual_Void_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683831);
		NativeMethodInfoPtr_selectVariant_Internal_SurvivorCampVariant_List_1_SurvivorCampVariant_Int32_AdvancedGameOptions_CustomRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683832);
		NativeMethodInfoPtr_generateCamp_Private_Void_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_WorldGenSurvivorCamps_SurvivorCampVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683833);
		NativeMethodInfoPtr_buildItemOptions_Private_Void_WorldGenSurvivorCamps_List_1_String_List_1_SurvivorCampInventoryItemOption_List_1_SurvivorCampInventoryItemOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683834);
		NativeMethodInfoPtr_buildAiItemRequestPool_Private_Void_SurvivorCampVariant_CustomRandom_List_1_AIItemRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683835);
		NativeMethodInfoPtr_claimAiItemRequest_Private_AIItemRequest_List_1_AIItemRequest_Single_CustomRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683836);
		NativeMethodInfoPtr_processItemOptions_Private_Void_List_1_SurvivorCampInventoryItemOption_CustomRandom_HashSet_1_String_List_1_InventoryPlacementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683837);
		NativeMethodInfoPtr_findCampCenterPosition_Private_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_SurvivorCampPlacementRules_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683838);
		NativeMethodInfoPtr_isCampPositionValid_Internal_Boolean_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_SurvivorCampPlacementRules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683839);
		NativeMethodInfoPtr_isObjectPositionValid_Internal_Boolean_World_Chunk_Vector3_Single_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683840);
		NativeMethodInfoPtr_tryGetObjectPositionWithinRadius_Private_Boolean_World_Chunk_Vector3_Single_Single_Single_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr, 100683841);
	}

	[CallerCount(120)]
	[CachedScanResults(RefRangeStart = 3923, RefRangeEnd = 4043, XrefRangeStart = 3923, XrefRangeEnd = 4043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SurvivorCampGenerationFeature(IAIManager aiManager, IInventoryManager inventoryManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurvivorCampGenerationFeature>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IAIManager_IInventoryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270793, XrefRangeEnd = 270866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ShouldAutoGenerate(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShouldAutoGenerate_Public_Virtual_Boolean_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 27783, RefRangeEnd = 27926, XrefRangeStart = 27783, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool GeneratesInCave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GeneratesInCave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270866, XrefRangeEnd = 270870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ForceGenerate(World world, Chunk chunk, Vector3 position, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ForceGenerate_Public_Virtual_Void_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270870, XrefRangeEnd = 270924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Generate(World world, Chunk chunk, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Generate_Protected_Virtual_Void_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 270989, RefRangeEnd = 270990, XrefRangeStart = 270924, XrefRangeEnd = 270989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SurvivorCampVariant selectVariant(List<SurvivorCampVariant> validVariants, int totalWeight, AdvancedGameOptions advancedGameOptions, CustomRandom random)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)validVariants);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &totalWeight;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)advancedGameOptions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_selectVariant_Internal_SurvivorCampVariant_List_1_SurvivorCampVariant_Int32_AdvancedGameOptions_CustomRandom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SurvivorCampVariant>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 271168, RefRangeEnd = 271170, XrefRangeStart = 270990, XrefRangeEnd = 271168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateCamp(World world, Chunk chunk, Vector3 centerPosition, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions, WorldGenSurvivorCamps config, SurvivorCampVariant chosenVariant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerPosition;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)config);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chosenVariant);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateCamp_Private_Void_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_WorldGenSurvivorCamps_SurvivorCampVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 271214, RefRangeEnd = 271216, XrefRangeStart = 271170, XrefRangeEnd = 271214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buildItemOptions(WorldGenSurvivorCamps config, List<string> useItemLists, List<SurvivorCampInventoryItemOption> directOptions, List<SurvivorCampInventoryItemOption> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)config);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)useItemLists);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)directOptions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildItemOptions_Private_Void_WorldGenSurvivorCamps_List_1_String_List_1_SurvivorCampInventoryItemOption_List_1_SurvivorCampInventoryItemOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 271244, RefRangeEnd = 271245, XrefRangeStart = 271216, XrefRangeEnd = 271244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buildAiItemRequestPool(SurvivorCampVariant variant, CustomRandom random, List<AIItemRequest> pool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)variant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pool);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildAiItemRequestPool_Private_Void_SurvivorCampVariant_CustomRandom_List_1_AIItemRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271245, XrefRangeEnd = 271260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIItemRequest claimAiItemRequest(List<AIItemRequest> requestPool, float claimChance, CustomRandom random)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requestPool);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &claimChance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_claimAiItemRequest_Private_AIItemRequest_List_1_AIItemRequest_Single_CustomRandom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIItemRequest>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 271330, RefRangeEnd = 271332, XrefRangeStart = 271260, XrefRangeEnd = 271330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void processItemOptions(List<SurvivorCampInventoryItemOption> options, CustomRandom random, HashSet<string> chosenOptionIdentifiers, List<InventoryPlacementInfo> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chosenOptionIdentifiers);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_processItemOptions_Private_Void_List_1_SurvivorCampInventoryItemOption_CustomRandom_HashSet_1_String_List_1_InventoryPlacementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271332, XrefRangeEnd = 271336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool findCampCenterPosition(World world, Chunk chunk, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions, SurvivorCampPlacementRules placementRules, out Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placementRules);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findCampCenterPosition_Private_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_SurvivorCampPlacementRules_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 271360, RefRangeEnd = 271364, XrefRangeStart = 271336, XrefRangeEnd = 271360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isCampPositionValid(World world, Chunk chunk, Vector3 position, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions, SurvivorCampPlacementRules placementRules)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placementRules);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isCampPositionValid_Internal_Boolean_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_SurvivorCampPlacementRules_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271364, XrefRangeEnd = 271367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isObjectPositionValid(World world, Chunk chunk, Vector3 position, float clearance, float maxSlope, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearance;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSlope;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isObjectPositionValid_Internal_Boolean_World_Chunk_Vector3_Single_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 271379, RefRangeEnd = 271380, XrefRangeStart = 271367, XrefRangeEnd = 271379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool tryGetObjectPositionWithinRadius(World world, Chunk chunk, Vector3 startingPosition, float minRange, float maxRange, float clearance, float maxSlope, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions, out Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingPosition;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &minRange;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRange;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearance;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSlope;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tryGetObjectPositionWithinRadius_Private_Boolean_World_Chunk_Vector3_Single_Single_Single_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public SurvivorCampGenerationFeature(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

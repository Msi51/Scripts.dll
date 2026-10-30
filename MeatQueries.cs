using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public static class MeatQueries : Il2CppSystem.Object
{
	[ObfuscatedName("MeatQueries+<>c__DisplayClass6_0")]
	public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ctx;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Q_FindHarvestableMeatCarcass_b__0_Internal_HarvestableMeatCarcassResult_0;

		public unsafe AIContext ctx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctx);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIContext>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctx)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIContext));
			}
		}

		static __c__DisplayClass6_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, "<>c__DisplayClass6_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr);
			NativeFieldInfoPtr_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, "ctx");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100668529);
			NativeMethodInfoPtr__Q_FindHarvestableMeatCarcass_b__0_Internal_HarvestableMeatCarcassResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100668530);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass6_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92926, XrefRangeEnd = 92930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HarvestableMeatCarcassResult _Q_FindHarvestableMeatCarcass_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Q_FindHarvestableMeatCarcass_b__0_Internal_HarvestableMeatCarcassResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new HarvestableMeatCarcassResult(pointer);
		}

		public __c__DisplayClass6_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("MeatQueries+<>c__DisplayClass7_0")]
	public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ctx;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Q_FindNearbyHomeStorableForCookedMeatStorage_b__0_Internal_FindEntitiesResult_0;

		public unsafe AIContext ctx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctx);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIContext>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctx)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIContext));
			}
		}

		static __c__DisplayClass7_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, "<>c__DisplayClass7_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr);
			NativeFieldInfoPtr_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, "ctx");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100668531);
			NativeMethodInfoPtr__Q_FindNearbyHomeStorableForCookedMeatStorage_b__0_Internal_FindEntitiesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100668532);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass7_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92930, XrefRangeEnd = 92934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FindEntitiesResult _Q_FindNearbyHomeStorableForCookedMeatStorage_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Q_FindNearbyHomeStorableForCookedMeatStorage_b__0_Internal_FindEntitiesResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new FindEntitiesResult(pointer);
		}

		public __c__DisplayClass7_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("MeatQueries+<>c__DisplayClass8_0")]
	public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ctx;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Q_FindNearbyHomeStorableWithCookedMeat_b__0_Internal_HomeStorableCookedMeatResult_0;

		public unsafe AIContext ctx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctx);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIContext>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctx)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIContext));
			}
		}

		static __c__DisplayClass8_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, "<>c__DisplayClass8_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr);
			NativeFieldInfoPtr_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, "ctx");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, 100668533);
			NativeMethodInfoPtr__Q_FindNearbyHomeStorableWithCookedMeat_b__0_Internal_HomeStorableCookedMeatResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, 100668534);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass8_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92934, XrefRangeEnd = 92938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HomeStorableCookedMeatResult _Q_FindNearbyHomeStorableWithCookedMeat_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Q_FindNearbyHomeStorableWithCookedMeat_b__0_Internal_HomeStorableCookedMeatResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new HomeStorableCookedMeatResult(pointer);
		}

		public __c__DisplayClass8_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("MeatQueries+<>c__DisplayClass9_0")]
	public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ctx;

		private static readonly System.IntPtr NativeFieldInfoPtr_cookerIdentifier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Q_FindCookerAcceptingRawMeat_b__0_Internal_CookerRawMeatResult_0;

		public unsafe AIContext ctx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctx);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIContext>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctx)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIContext));
			}
		}

		public unsafe string cookerIdentifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookerIdentifier);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookerIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static __c__DisplayClass9_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, "<>c__DisplayClass9_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr);
			NativeFieldInfoPtr_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "ctx");
			NativeFieldInfoPtr_cookerIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, "cookerIdentifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100668535);
			NativeMethodInfoPtr__Q_FindCookerAcceptingRawMeat_b__0_Internal_CookerRawMeatResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass9_0>.NativeClassPtr, 100668536);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92938, XrefRangeEnd = 92942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookerRawMeatResult _Q_FindCookerAcceptingRawMeat_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Q_FindCookerAcceptingRawMeat_b__0_Internal_CookerRawMeatResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CookerRawMeatResult(pointer);
		}

		public __c__DisplayClass9_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("MeatQueries+<>c__DisplayClass10_0")]
	public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ctx;

		private static readonly System.IntPtr NativeFieldInfoPtr_cookerIdentifier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Q_FindCookerWithCookedMeat_b__0_Internal_CookerCookedMeatResult_0;

		public unsafe AIContext ctx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctx);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIContext>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctx)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIContext));
			}
		}

		public unsafe string cookerIdentifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookerIdentifier);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cookerIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static __c__DisplayClass10_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, "<>c__DisplayClass10_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr);
			NativeFieldInfoPtr_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "ctx");
			NativeFieldInfoPtr_cookerIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "cookerIdentifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100668537);
			NativeMethodInfoPtr__Q_FindCookerWithCookedMeat_b__0_Internal_CookerCookedMeatResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100668538);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass10_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92942, XrefRangeEnd = 92946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookerCookedMeatResult _Q_FindCookerWithCookedMeat_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Q_FindCookerWithCookedMeat_b__0_Internal_CookerCookedMeatResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CookerCookedMeatResult(pointer);
		}

		public __c__DisplayClass10_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_baseHarvestableMeatCarcassHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseHomeStorableCookedMeatHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseHomeStorableCookedMeatStorageHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCookerCanAcceptRawMeatHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCookerHasCookedMeatHashCode;

	private static readonly System.IntPtr NativeMethodInfoPtr_Q_FindHarvestableMeatCarcass_Public_Static_HarvestableMeatCarcassResult_AIContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Q_FindNearbyHomeStorableForCookedMeatStorage_Public_Static_FindEntitiesResult_AIContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Q_FindNearbyHomeStorableWithCookedMeat_Public_Static_HomeStorableCookedMeatResult_AIContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Q_FindCookerAcceptingRawMeat_Public_Static_CookerRawMeatResult_AIContext_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Q_FindCookerWithCookedMeat_Public_Static_CookerCookedMeatResult_AIContext_String_0;

	public unsafe static int baseHarvestableMeatCarcassHashCode
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_baseHarvestableMeatCarcassHashCode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_baseHarvestableMeatCarcassHashCode, (void*)(&num));
		}
	}

	public unsafe static int baseHomeStorableCookedMeatHashCode
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_baseHomeStorableCookedMeatHashCode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_baseHomeStorableCookedMeatHashCode, (void*)(&num));
		}
	}

	public unsafe static int baseHomeStorableCookedMeatStorageHashCode
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_baseHomeStorableCookedMeatStorageHashCode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_baseHomeStorableCookedMeatStorageHashCode, (void*)(&num));
		}
	}

	public unsafe static int baseCookerCanAcceptRawMeatHashCode
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_baseCookerCanAcceptRawMeatHashCode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_baseCookerCanAcceptRawMeatHashCode, (void*)(&num));
		}
	}

	public unsafe static int baseCookerHasCookedMeatHashCode
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_baseCookerHasCookedMeatHashCode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_baseCookerHasCookedMeatHashCode, (void*)(&num));
		}
	}

	static MeatQueries()
	{
		Il2CppClassPointerStore<MeatQueries>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MeatQueries");
		NativeFieldInfoPtr_baseHarvestableMeatCarcassHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, "baseHarvestableMeatCarcassHashCode");
		NativeFieldInfoPtr_baseHomeStorableCookedMeatHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, "baseHomeStorableCookedMeatHashCode");
		NativeFieldInfoPtr_baseHomeStorableCookedMeatStorageHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, "baseHomeStorableCookedMeatStorageHashCode");
		NativeFieldInfoPtr_baseCookerCanAcceptRawMeatHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, "baseCookerCanAcceptRawMeatHashCode");
		NativeFieldInfoPtr_baseCookerHasCookedMeatHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, "baseCookerHasCookedMeatHashCode");
		NativeMethodInfoPtr_Q_FindHarvestableMeatCarcass_Public_Static_HarvestableMeatCarcassResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, 100668524);
		NativeMethodInfoPtr_Q_FindNearbyHomeStorableForCookedMeatStorage_Public_Static_FindEntitiesResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, 100668525);
		NativeMethodInfoPtr_Q_FindNearbyHomeStorableWithCookedMeat_Public_Static_HomeStorableCookedMeatResult_AIContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, 100668526);
		NativeMethodInfoPtr_Q_FindCookerAcceptingRawMeat_Public_Static_CookerRawMeatResult_AIContext_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, 100668527);
		NativeMethodInfoPtr_Q_FindCookerWithCookedMeat_Public_Static_CookerCookedMeatResult_AIContext_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeatQueries>.NativeClassPtr, 100668528);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92964, RefRangeEnd = 92965, XrefRangeStart = 92946, XrefRangeEnd = 92964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HarvestableMeatCarcassResult Q_FindHarvestableMeatCarcass(this AIContext ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Q_FindHarvestableMeatCarcass_Public_Static_HarvestableMeatCarcassResult_AIContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new HarvestableMeatCarcassResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92984, RefRangeEnd = 92985, XrefRangeStart = 92965, XrefRangeEnd = 92984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FindEntitiesResult Q_FindNearbyHomeStorableForCookedMeatStorage(this AIContext ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Q_FindNearbyHomeStorableForCookedMeatStorage_Public_Static_FindEntitiesResult_AIContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FindEntitiesResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93003, RefRangeEnd = 93004, XrefRangeStart = 92985, XrefRangeEnd = 93003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HomeStorableCookedMeatResult Q_FindNearbyHomeStorableWithCookedMeat(this AIContext ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Q_FindNearbyHomeStorableWithCookedMeat_Public_Static_HomeStorableCookedMeatResult_AIContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new HomeStorableCookedMeatResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93023, RefRangeEnd = 93024, XrefRangeStart = 93004, XrefRangeEnd = 93023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CookerRawMeatResult Q_FindCookerAcceptingRawMeat(this AIContext ctx, string cookerIdentifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(cookerIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Q_FindCookerAcceptingRawMeat_Public_Static_CookerRawMeatResult_AIContext_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new CookerRawMeatResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93043, RefRangeEnd = 93044, XrefRangeStart = 93024, XrefRangeEnd = 93043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CookerCookedMeatResult Q_FindCookerWithCookedMeat(this AIContext ctx, string cookerIdentifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(cookerIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Q_FindCookerWithCookedMeat_Public_Static_CookerCookedMeatResult_AIContext_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new CookerCookedMeatResult(pointer);
	}

	public MeatQueries(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

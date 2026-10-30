using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class Blueprint : Model
{
	private static readonly IntPtr NativeFieldInfoPtr_identifier;

	private static readonly IntPtr NativeFieldInfoPtr_inputIngredients;

	private static readonly IntPtr NativeFieldInfoPtr_constructionIdentifier;

	private static readonly IntPtr NativeFieldInfoPtr_upgradedConstructionIdentifier;

	private static readonly IntPtr NativeFieldInfoPtr_initiallyLocked;

	private static readonly IntPtr NativeFieldInfoPtr_outputConstruction;

	private static readonly IntPtr NativeFieldInfoPtr_upgradedConstruction;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_InputIngredients_Public_get_List_1_CraftingIngredient_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ConstructionIdentifier_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_UpgradedConstructionIdentifier_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_InitiallyLocked_Public_get_Boolean_0;

	public unsafe SerializableStringField identifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifier);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringField));
		}
	}

	public unsafe ReadOnlySerializableDictionaryListField<CraftingIngredient> inputIngredients
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputIngredients);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlySerializableDictionaryListField<CraftingIngredient>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputIngredients)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)readOnlySerializableDictionaryListField));
		}
	}

	public unsafe SerializableStringField constructionIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionIdentifier);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionIdentifier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringField));
		}
	}

	public unsafe SerializableStringField upgradedConstructionIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradedConstructionIdentifier);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradedConstructionIdentifier)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringField));
		}
	}

	public unsafe SerializablePrimitiveField<bool> initiallyLocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initiallyLocked);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializablePrimitiveField<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initiallyLocked)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializablePrimitiveField));
		}
	}

	public unsafe Construction outputConstruction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputConstruction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Construction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputConstruction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)construction));
		}
	}

	public unsafe Construction upgradedConstruction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradedConstruction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Construction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgradedConstruction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)construction));
		}
	}

	public unsafe override string Identifier
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95838, XrefRangeEnd = 95839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe List<CraftingIngredient> InputIngredients
	{
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 95840, RefRangeEnd = 95866, XrefRangeStart = 95839, XrefRangeEnd = 95840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InputIngredients_Public_get_List_1_CraftingIngredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CraftingIngredient>>(intPtr) : null;
		}
	}

	public unsafe string ConstructionIdentifier
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95867, RefRangeEnd = 95868, XrefRangeStart = 95866, XrefRangeEnd = 95867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConstructionIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string UpgradedConstructionIdentifier
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 95869, RefRangeEnd = 95878, XrefRangeStart = 95868, XrefRangeEnd = 95869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpgradedConstructionIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe bool InitiallyLocked
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 95879, RefRangeEnd = 95884, XrefRangeStart = 95878, XrefRangeEnd = 95879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InitiallyLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static Blueprint()
	{
		Il2CppClassPointerStore<Blueprint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "Blueprint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Blueprint>.NativeClassPtr);
		NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, "identifier");
		NativeFieldInfoPtr_inputIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, "inputIngredients");
		NativeFieldInfoPtr_constructionIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, "constructionIdentifier");
		NativeFieldInfoPtr_upgradedConstructionIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, "upgradedConstructionIdentifier");
		NativeFieldInfoPtr_initiallyLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, "initiallyLocked");
		NativeFieldInfoPtr_outputConstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, "outputConstruction");
		NativeFieldInfoPtr_upgradedConstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, "upgradedConstruction");
		NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, 100668586);
		NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, 100668587);
		NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, 100668588);
		NativeMethodInfoPtr_get_InputIngredients_Public_get_List_1_CraftingIngredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, 100668589);
		NativeMethodInfoPtr_get_ConstructionIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, 100668590);
		NativeMethodInfoPtr_get_UpgradedConstructionIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, 100668591);
		NativeMethodInfoPtr_get_InitiallyLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Blueprint>.NativeClassPtr, 100668592);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 95788, RefRangeEnd = 95815, XrefRangeStart = 95787, XrefRangeEnd = 95788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Blueprint(ModelDefinition definition)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Blueprint>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)definition);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95815, XrefRangeEnd = 95838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeSerializableFields(SerializationContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Blueprint(IntPtr pointer)
		: base(pointer)
	{
	}
}

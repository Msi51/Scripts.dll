using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class CraftingType : Model
{
	private static readonly IntPtr NativeFieldInfoPtr_identifier;

	private static readonly IntPtr NativeFieldInfoPtr_craftText;

	private static readonly IntPtr NativeFieldInfoPtr_craftTextPresent;

	private static readonly IntPtr NativeFieldInfoPtr_craftingAnimationStateKneeling;

	private static readonly IntPtr NativeFieldInfoPtr_craftingAnimationStateStanding;

	private static readonly IntPtr NativeFieldInfoPtr_localizedCraftText;

	private static readonly IntPtr NativeFieldInfoPtr_localizedCraftTextPresent;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_ModelDefinition_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RawCraftText_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RawCraftTextPresent_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLocalizedCraftText_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLocalizedCraftTextPresent_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CraftText_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CraftTextPresent_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CraftingAnimationStateKneeling_Public_get_AnimationState_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CraftingAnimationStateStanding_Public_get_AnimationState_0;

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

	public unsafe SerializableStringField craftText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringField));
		}
	}

	public unsafe SerializableStringField craftTextPresent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftTextPresent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableStringField>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftTextPresent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableStringField));
		}
	}

	public unsafe SerializableEnumField<AnimationState> craftingAnimationStateKneeling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftingAnimationStateKneeling);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableEnumField<AnimationState>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftingAnimationStateKneeling)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableEnumField));
		}
	}

	public unsafe SerializableEnumField<AnimationState> craftingAnimationStateStanding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftingAnimationStateStanding);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SerializableEnumField<AnimationState>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_craftingAnimationStateStanding)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializableEnumField));
		}
	}

	public unsafe string localizedCraftText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedCraftText);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedCraftText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string localizedCraftTextPresent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedCraftTextPresent);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localizedCraftTextPresent)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe override string Identifier
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103694, XrefRangeEnd = 103695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe string RawCraftText
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103696, RefRangeEnd = 103697, XrefRangeStart = 103695, XrefRangeEnd = 103696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RawCraftText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string RawCraftTextPresent
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103698, RefRangeEnd = 103699, XrefRangeStart = 103697, XrefRangeEnd = 103698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RawCraftTextPresent_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string CraftText
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 96676, RefRangeEnd = 96716, XrefRangeStart = 96676, XrefRangeEnd = 96716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CraftText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe string CraftTextPresent
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 30821, RefRangeEnd = 30837, XrefRangeStart = 30821, XrefRangeEnd = 30837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CraftTextPresent_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe AnimationState CraftingAnimationStateKneeling
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103699, XrefRangeEnd = 103700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CraftingAnimationStateKneeling_Public_get_AnimationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe AnimationState CraftingAnimationStateStanding
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103700, XrefRangeEnd = 103701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CraftingAnimationStateStanding_Public_get_AnimationState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(AnimationState*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static CraftingType()
	{
		Il2CppClassPointerStore<CraftingType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CraftingType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CraftingType>.NativeClassPtr);
		NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, "identifier");
		NativeFieldInfoPtr_craftText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, "craftText");
		NativeFieldInfoPtr_craftTextPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, "craftTextPresent");
		NativeFieldInfoPtr_craftingAnimationStateKneeling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, "craftingAnimationStateKneeling");
		NativeFieldInfoPtr_craftingAnimationStateStanding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, "craftingAnimationStateStanding");
		NativeFieldInfoPtr_localizedCraftText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, "localizedCraftText");
		NativeFieldInfoPtr_localizedCraftTextPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, "localizedCraftTextPresent");
		NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669560);
		NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_ModelDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669561);
		NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669562);
		NativeMethodInfoPtr_get_Identifier_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669563);
		NativeMethodInfoPtr_get_RawCraftText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669564);
		NativeMethodInfoPtr_get_RawCraftTextPresent_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669565);
		NativeMethodInfoPtr_SetLocalizedCraftText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669566);
		NativeMethodInfoPtr_SetLocalizedCraftTextPresent_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669567);
		NativeMethodInfoPtr_get_CraftText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669568);
		NativeMethodInfoPtr_get_CraftTextPresent_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669569);
		NativeMethodInfoPtr_get_CraftingAnimationStateKneeling_Public_get_AnimationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669570);
		NativeMethodInfoPtr_get_CraftingAnimationStateStanding_Public_get_AnimationState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CraftingType>.NativeClassPtr, 100669571);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 95788, RefRangeEnd = 95815, XrefRangeStart = 95788, XrefRangeEnd = 95815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CraftingType(ModelDefinition definition)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CraftingType>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)definition);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95969, RefRangeEnd = 95970, XrefRangeStart = 95969, XrefRangeEnd = 95970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CraftingType(ModelDefinition baseDefinition, ModelDefinition definitionOverrides)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CraftingType>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseDefinition);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)definitionOverrides);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ModelDefinition_ModelDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103672, XrefRangeEnd = 103694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InitializeSerializableFields(SerializationContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeSerializableFields_Protected_Virtual_Void_SerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalizedCraftText(string craftText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(craftText);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalizedCraftText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalizedCraftTextPresent(string craftText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(craftText);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalizedCraftTextPresent_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CraftingType(IntPtr pointer)
		: base(pointer)
	{
	}
}

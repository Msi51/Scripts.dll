using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class ControlMapping : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_input1;

	private static readonly System.IntPtr NativeFieldInfoPtr_input2;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputs;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_InputKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_InputGamepad_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_InputAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Input1_Public_get_ControlInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Input1_Public_set_Void_ControlInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Input2_Public_get_ControlInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Input2_Public_set_Void_ControlInput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_storeInputsArray_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ControlMapping_0;

	public unsafe ControlInput input1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlInput>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlInput));
		}
	}

	public unsafe ControlInput input2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlInput>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_input2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controlInput));
		}
	}

	public unsafe Il2CppReferenceArray<ControlInput> inputs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ControlInput>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe ControlInput Input1
	{
		[CallerCount(91)]
		[CachedScanResults(RefRangeStart = 19321, RefRangeEnd = 19412, XrefRangeStart = 19321, XrefRangeEnd = 19321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Input1_Public_get_ControlInput_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlInput>(intPtr) : null;
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19414, RefRangeEnd = 19418, XrefRangeStart = 19412, XrefRangeEnd = 19414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Input1_Public_set_Void_ControlInput_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ControlInput Input2
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19418, RefRangeEnd = 19420, XrefRangeStart = 19418, XrefRangeEnd = 19418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Input2_Public_get_ControlInput_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControlInput>(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19422, RefRangeEnd = 19425, XrefRangeStart = 19420, XrefRangeEnd = 19422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Input2_Public_set_Void_ControlInput_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ControlMapping()
	{
		Il2CppClassPointerStore<ControlMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ControlMapping");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr);
		NativeFieldInfoPtr_input1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, "input1");
		NativeFieldInfoPtr_input2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, "input2");
		NativeFieldInfoPtr_inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, "inputs");
		NativeMethodInfoPtr__ctor_Public_Void_String_InputKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr__ctor_Public_Void_String_InputGamepad_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr__ctor_Public_Void_String_InputAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_get_Input1_Public_get_ControlInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_set_Input1_Public_set_Void_ControlInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_get_Input2_Public_get_ControlInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_set_Input2_Public_set_Void_ControlInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_storeInputsArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663589);
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_Equals_Public_Boolean_ControlMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr, 100663592);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19255, XrefRangeEnd = 19277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlMapping(string identifier, InputKey inputKey)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_InputKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19277, XrefRangeEnd = 19299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlMapping(string identifier, InputGamepad inputGamepad)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputGamepad);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_InputGamepad_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19299, XrefRangeEnd = 19321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControlMapping(string identifier, InputAxis inputAxis)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputAxis);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_InputAxis_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 19441, RefRangeEnd = 19444, XrefRangeStart = 19425, XrefRangeEnd = 19441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void storeInputsArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_storeInputsArray_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 19469, RefRangeEnd = 19471, XrefRangeStart = 19444, XrefRangeEnd = 19469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 19488, RefRangeEnd = 19489, XrefRangeStart = 19471, XrefRangeEnd = 19488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Dictionary<string, Il2CppSystem.Object> MapToDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 19497, RefRangeEnd = 19499, XrefRangeStart = 19489, XrefRangeEnd = 19497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(ControlMapping other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_ControlMapping_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ControlMapping(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ControlMapping()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlMapping>.NativeClassPtr))
	{
	}
}

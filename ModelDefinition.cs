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

public class ModelDefinition : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetValue_Public_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetValue_Public_T_Int32_0, Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetValue_Public_T_String_0, Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_IDENTIFIER_FIELD;

	private static readonly System.IntPtr NativeFieldInfoPtr_identifierFieldHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_fieldHashMap;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBaseDefinition_Public_Void_ModelDefinition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIdentifier_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasField_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_Int32_byref_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_T_String_0;

	public unsafe static string IDENTIFIER_FIELD
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IDENTIFIER_FIELD, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IDENTIFIER_FIELD, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int identifierFieldHash
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_identifierFieldHash, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_identifierFieldHash, (void*)(&num));
		}
	}

	public unsafe Dictionary<int, Il2CppSystem.Object> fieldHashMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldHashMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppSystem.Object>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldHashMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static ModelDefinition()
	{
		Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ModelDefinition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr);
		NativeFieldInfoPtr_IDENTIFIER_FIELD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, "IDENTIFIER_FIELD");
		NativeFieldInfoPtr_identifierFieldHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, "identifierFieldHash");
		NativeFieldInfoPtr_fieldHashMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, "fieldHashMap");
		NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, 100678317);
		NativeMethodInfoPtr_SetBaseDefinition_Public_Void_ModelDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, 100678318);
		NativeMethodInfoPtr_GetIdentifier_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, 100678319);
		NativeMethodInfoPtr_HasField_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, 100678320);
		NativeMethodInfoPtr_TryGetValue_Public_Boolean_Int32_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, 100678321);
		NativeMethodInfoPtr_GetValue_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, 100678322);
		NativeMethodInfoPtr_GetValue_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, 100678323);
		NativeMethodInfoPtr_GetValue_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr, 100678324);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 224117, RefRangeEnd = 224119, XrefRangeStart = 224087, XrefRangeEnd = 224117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModelDefinition(Dictionary<string, Il2CppSystem.Object> fieldMap)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelDefinition>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fieldMap);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224139, RefRangeEnd = 224140, XrefRangeStart = 224119, XrefRangeEnd = 224139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBaseDefinition(ModelDefinition baseDefinition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseDefinition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBaseDefinition_Public_Void_ModelDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 224147, RefRangeEnd = 224150, XrefRangeStart = 224140, XrefRangeEnd = 224147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetIdentifier()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIdentifier_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224150, XrefRangeEnd = 224154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasField(int fieldHash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fieldHash);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasField_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224162, RefRangeEnd = 224163, XrefRangeStart = 224154, XrefRangeEnd = 224162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetValue(int fieldHash, out Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&fieldHash);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetValue_Public_Boolean_Int32_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		value = ((num3 == 0) ? null : new Il2CppSystem.Object(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 224167, RefRangeEnd = 224169, XrefRangeStart = 224163, XrefRangeEnd = 224167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object GetValue(int fieldHash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fieldHash);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224176, RefRangeEnd = 224177, XrefRangeStart = 224169, XrefRangeEnd = 224176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetValue<T>(int fieldHash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fieldHash);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetValue_Public_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 224178, RefRangeEnd = 224182, XrefRangeStart = 224177, XrefRangeEnd = 224178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetValue<T>(string fieldName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	public ModelDefinition(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace FullSerializer;

public class fsBaseConverter : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("FullSerializer.fsBaseConverter+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FailExpectedType_b__6_0_Internal_String_fsDataType_0;

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

		public unsafe static Il2CppSystem.Func<fsDataType, string> __9__6_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<fsDataType, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__6_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__6_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686579);
			NativeMethodInfoPtr__FailExpectedType_b__6_0_Internal_String_fsDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100686580);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293988, XrefRangeEnd = 293991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _FailExpectedType_b__6_0(fsDataType t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&t);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FailExpectedType_b__6_0_Internal_String_fsDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_SerializeMember_Protected_fsResult_Dictionary_2_String_fsData_Type_String_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SerializeMember_Protected_fsResult_Dictionary_2_String_fsData_Type_String_T_0, Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_DeserializeMember_Protected_fsResult_Dictionary_2_String_fsData_Type_String_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DeserializeMember_Protected_fsResult_Dictionary_2_String_fsData_Type_String_byref_T_0, Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Serializer;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_Object_fsData_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestCycleSupport_Public_Virtual_New_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestInheritanceSupport_Public_Virtual_New_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrySerialize_Public_Abstract_Virtual_New_fsResult_Object_byref_fsData_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Abstract_Virtual_New_fsResult_fsData_byref_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FailExpectedType_Protected_fsResult_fsData_Il2CppStructArray_1_fsDataType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckType_Protected_fsResult_fsData_fsDataType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckKey_Protected_fsResult_fsData_String_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckKey_Protected_fsResult_Dictionary_2_String_fsData_String_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeMember_Protected_fsResult_Dictionary_2_String_fsData_Type_String_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeMember_Protected_fsResult_Dictionary_2_String_fsData_Type_String_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe fsSerializer Serializer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Serializer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<fsSerializer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Serializer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fsSerializer2));
		}
	}

	static fsBaseConverter()
	{
		Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsBaseConverter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr);
		NativeFieldInfoPtr_Serializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, "Serializer");
		NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_Object_fsData_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686566);
		NativeMethodInfoPtr_RequestCycleSupport_Public_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686567);
		NativeMethodInfoPtr_RequestInheritanceSupport_Public_Virtual_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686568);
		NativeMethodInfoPtr_TrySerialize_Public_Abstract_Virtual_New_fsResult_Object_byref_fsData_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686569);
		NativeMethodInfoPtr_TryDeserialize_Public_Abstract_Virtual_New_fsResult_fsData_byref_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686570);
		NativeMethodInfoPtr_FailExpectedType_Protected_fsResult_fsData_Il2CppStructArray_1_fsDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686571);
		NativeMethodInfoPtr_CheckType_Protected_fsResult_fsData_fsDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686572);
		NativeMethodInfoPtr_CheckKey_Protected_fsResult_fsData_String_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686573);
		NativeMethodInfoPtr_CheckKey_Protected_fsResult_Dictionary_2_String_fsData_String_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686574);
		NativeMethodInfoPtr_SerializeMember_Protected_fsResult_Dictionary_2_String_fsData_Type_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686575);
		NativeMethodInfoPtr_DeserializeMember_Protected_fsResult_Dictionary_2_String_fsData_Type_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686576);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr, 100686577);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppSystem.Object CreateInstance(fsData data, Il2CppSystem.Type storageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_Object_fsData_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293991, XrefRangeEnd = 294002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool RequestCycleSupport(Il2CppSystem.Type storageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RequestCycleSupport_Public_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294002, XrefRangeEnd = 294006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool RequestInheritanceSupport(Il2CppSystem.Type storageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RequestInheritanceSupport_Public_Virtual_New_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual fsResult TrySerialize(Il2CppSystem.Object instance, out fsData serialized, Il2CppSystem.Type storageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TrySerialize_Public_Abstract_Virtual_New_fsResult_Object_byref_fsData_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		serialized = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual fsResult TryDeserialize(fsData data, ref Il2CppSystem.Object instance, Il2CppSystem.Type storageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TryDeserialize_Public_Abstract_Virtual_New_fsResult_fsData_byref_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		instance = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppSystem.Object(intPtr3));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294006, XrefRangeEnd = 294075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult FailExpectedType(fsData data, [Optional] Il2CppStructArray<fsDataType> types)
	{
		if (types == null)
		{
			types = new Il2CppStructArray<fsDataType>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FailExpectedType_Protected_fsResult_fsData_Il2CppStructArray_1_fsDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 294118, RefRangeEnd = 294128, XrefRangeStart = 294075, XrefRangeEnd = 294118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult CheckType(fsData data, fsDataType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(fsDataType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckType_Protected_fsResult_fsData_fsDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294128, XrefRangeEnd = 294132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult CheckKey(fsData data, string key, out fsData subitem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckKey_Protected_fsResult_fsData_String_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		subitem = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 294142, RefRangeEnd = 294147, XrefRangeStart = 294132, XrefRangeEnd = 294142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckKey_Protected_fsResult_Dictionary_2_String_fsData_String_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		subitem = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 294160, RefRangeEnd = 294164, XrefRangeStart = 294147, XrefRangeEnd = 294160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult SerializeMember<T>(Dictionary<string, fsData> data, Il2CppSystem.Type overrideConverterType, string name, T value)
	{
		//IL_0083->IL0086: Incompatible stack types: I vs Ref
		//IL_0076->IL0086: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SerializeMember_Protected_fsResult_Dictionary_2_String_fsData_Type_String_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 294177, RefRangeEnd = 294181, XrefRangeStart = 294164, XrefRangeEnd = 294177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Il2CppSystem.Type overrideConverterType, string name, out T value)
	{
		//IL_0063->IL0066: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		Unsafe.SkipInit(out nint num2);
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DeserializeMember_Protected_fsResult_Dictionary_2_String_fsData_Type_String_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(T).IsValueType)
		{
			nint num3 = num2;
			Unsafe.As<T, object>(ref value) = ((num3 == 0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>((System.IntPtr)num3, false, false));
		}
		return new fsResult(pointer);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsBaseConverter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsBaseConverter>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsResult FailExpectedType(fsData data, params fsDataType[] types)
	{
		return FailExpectedType(data, new Il2CppStructArray<fsDataType>(types));
	}

	public fsBaseConverter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

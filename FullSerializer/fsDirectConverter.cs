using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace FullSerializer;

public class fsDirectConverter : fsBaseConverter
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_ModelType_Public_Abstract_Virtual_New_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe virtual Il2CppSystem.Type ModelType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ModelType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
	}

	static fsDirectConverter()
	{
		Il2CppClassPointerStore<fsDirectConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsDirectConverter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsDirectConverter>.NativeClassPtr);
		NativeMethodInfoPtr_get_ModelType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsDirectConverter>.NativeClassPtr, 100686627);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsDirectConverter>.NativeClassPtr, 100686628);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsDirectConverter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsDirectConverter>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsDirectConverter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
public class fsDirectConverter<TModel> : fsDirectConverter
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_ModelType_Public_Virtual_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrySerialize_Public_Virtual_Final_fsResult_Object_byref_fsData_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Final_fsResult_fsData_byref_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoSerialize_Protected_Abstract_Virtual_New_fsResult_TModel_Dictionary_2_String_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoDeserialize_Protected_Abstract_Virtual_New_fsResult_Dictionary_2_String_fsData_byref_TModel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe override Il2CppSystem.Type ModelType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294657, XrefRangeEnd = 294678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_ModelType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
	}

	static fsDirectConverter()
	{
		Il2CppClassPointerStore<fsDirectConverter<TModel>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsDirectConverter`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModel>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsDirectConverter<TModel>>.NativeClassPtr);
		NativeMethodInfoPtr_get_ModelType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsDirectConverter<TModel>>.NativeClassPtr, 100686629);
		NativeMethodInfoPtr_TrySerialize_Public_Virtual_Final_fsResult_Object_byref_fsData_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsDirectConverter<TModel>>.NativeClassPtr, 100686630);
		NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Final_fsResult_fsData_byref_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsDirectConverter<TModel>>.NativeClassPtr, 100686631);
		NativeMethodInfoPtr_DoSerialize_Protected_Abstract_Virtual_New_fsResult_TModel_Dictionary_2_String_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsDirectConverter<TModel>>.NativeClassPtr, 100686632);
		NativeMethodInfoPtr_DoDeserialize_Protected_Abstract_Virtual_New_fsResult_Dictionary_2_String_fsData_byref_TModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsDirectConverter<TModel>>.NativeClassPtr, 100686633);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsDirectConverter<TModel>>.NativeClassPtr, 100686634);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294678, XrefRangeEnd = 294691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override fsResult TrySerialize(Il2CppSystem.Object instance, out fsData serialized, Il2CppSystem.Type storageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrySerialize_Public_Virtual_Final_fsResult_Object_byref_fsData_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		serialized = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294691, XrefRangeEnd = 294707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override fsResult TryDeserialize(fsData data, ref Il2CppSystem.Object instance, Il2CppSystem.Type storageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Final_fsResult_fsData_byref_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		instance = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppSystem.Object(intPtr3));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref TModel reference;
		if (!typeof(TModel).IsValueType)
		{
			object obj = model;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref model;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serialized);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DoSerialize_Protected_Abstract_Virtual_New_fsResult_TModel_Dictionary_2_String_fsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	public unsafe virtual fsResult DoDeserialize(Dictionary<string, fsData> data, ref TModel model)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TModel, object>(ref model));
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DoDeserialize_Protected_Abstract_Virtual_New_fsResult_Dictionary_2_String_fsData_byref_TModel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		Unsafe.As<TModel, object>(ref model) = ((intPtr3 == (System.IntPtr)0) ? ((TModel)null) : IL2CPP.PointerToValueGeneric<TModel>(intPtr3, false, false));
		return new fsResult(pointer);
	}

	[CallerCount(283)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 284, XrefRangeStart = 1, XrefRangeEnd = 284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsDirectConverter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsDirectConverter<TModel>>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fsDirectConverter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

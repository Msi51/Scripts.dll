using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace FullSerializer.Internal.DirectConverters;

public class Keyframe_DirectConverter : fsDirectConverter<Keyframe>
{
	private static readonly System.IntPtr NativeMethodInfoPtr_DoSerialize_Protected_Virtual_fsResult_Keyframe_Dictionary_2_String_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoDeserialize_Protected_Virtual_fsResult_Dictionary_2_String_fsData_byref_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_fsData_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static Keyframe_DirectConverter()
	{
		Il2CppClassPointerStore<Keyframe_DirectConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer.Internal.DirectConverters", "Keyframe_DirectConverter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyframe_DirectConverter>.NativeClassPtr);
		NativeMethodInfoPtr_DoSerialize_Protected_Virtual_fsResult_Keyframe_Dictionary_2_String_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe_DirectConverter>.NativeClassPtr, 100686994);
		NativeMethodInfoPtr_DoDeserialize_Protected_Virtual_fsResult_Dictionary_2_String_fsData_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe_DirectConverter>.NativeClassPtr, 100686995);
		NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_fsData_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe_DirectConverter>.NativeClassPtr, 100686996);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe_DirectConverter>.NativeClassPtr, 100686997);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300594, XrefRangeEnd = 300642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&model);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serialized);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DoSerialize_Protected_Virtual_fsResult_Keyframe_Dictionary_2_String_fsData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300642, XrefRangeEnd = 300697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref model);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DoDeserialize_Protected_Virtual_fsResult_Dictionary_2_String_fsData_byref_Keyframe_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300697, XrefRangeEnd = 300700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppSystem.Object CreateInstance(fsData data, Il2CppSystem.Type storageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateInstance_Public_Virtual_Object_fsData_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300700, XrefRangeEnd = 300703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Keyframe_DirectConverter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Keyframe_DirectConverter>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Keyframe_DirectConverter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

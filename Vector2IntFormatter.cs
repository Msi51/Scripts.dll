using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using OdinSerializer;
using UnityEngine;

public class Vector2IntFormatter : MinimalBaseFormatter<Vector2Int>
{
	private static readonly IntPtr NativeFieldInfoPtr_intSerializer;

	private static readonly IntPtr NativeMethodInfoPtr_Read_Protected_Virtual_Void_byref_Vector2Int_IDataReader_0;

	private static readonly IntPtr NativeMethodInfoPtr_Write_Protected_Virtual_Void_byref_Vector2Int_IDataWriter_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Serializer<int> intSerializer
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_intSerializer, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Serializer<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_intSerializer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializer));
		}
	}

	static Vector2IntFormatter()
	{
		Il2CppClassPointerStore<Vector2IntFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "Vector2IntFormatter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2IntFormatter>.NativeClassPtr);
		NativeFieldInfoPtr_intSerializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2IntFormatter>.NativeClassPtr, "intSerializer");
		NativeMethodInfoPtr_Read_Protected_Virtual_Void_byref_Vector2Int_IDataReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntFormatter>.NativeClassPtr, 100679548);
		NativeMethodInfoPtr_Write_Protected_Virtual_Void_byref_Vector2Int_IDataWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntFormatter>.NativeClassPtr, 100679549);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntFormatter>.NativeClassPtr, 100679550);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233396, XrefRangeEnd = 233401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Read(ref Vector2Int value, IDataReader reader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Read_Protected_Virtual_Void_byref_Vector2Int_IDataReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233401, XrefRangeEnd = 233422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Write(ref Vector2Int value, IDataWriter writer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Write_Protected_Virtual_Void_byref_Vector2Int_IDataWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233422, XrefRangeEnd = 233428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2IntFormatter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2IntFormatter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Vector2IntFormatter(IntPtr pointer)
		: base(pointer)
	{
	}
}

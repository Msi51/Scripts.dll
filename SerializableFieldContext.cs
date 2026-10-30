using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class SerializableFieldContext : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dataStreamPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_fieldPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentField;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraContextSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_numFields;

	private static readonly System.IntPtr NativeFieldInfoPtr_writeFields;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

	public unsafe long dataStreamPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataStreamPosition);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataStreamPosition)) = num;
		}
	}

	public unsafe List<long> fieldPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldPositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<long>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldPositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int currentField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentField)) = num;
		}
	}

	public unsafe long extraContextSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraContextSize);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraContextSize)) = num;
		}
	}

	public unsafe int numFields
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numFields);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numFields)) = num;
		}
	}

	public unsafe bool writeFields
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeFields);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeFields)) = flag;
		}
	}

	static SerializableFieldContext()
	{
		Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SerializableFieldContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr);
		NativeFieldInfoPtr_dataStreamPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr, "dataStreamPosition");
		NativeFieldInfoPtr_fieldPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr, "fieldPositions");
		NativeFieldInfoPtr_currentField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr, "currentField");
		NativeFieldInfoPtr_extraContextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr, "extraContextSize");
		NativeFieldInfoPtr_numFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr, "numFields");
		NativeFieldInfoPtr_writeFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr, "writeFields");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr, 100679319);
		NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr, 100679320);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231644, XrefRangeEnd = 231653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SerializableFieldContext(int capacity)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231653, XrefRangeEnd = 231662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SerializableFieldContext(long dataStreamPosition)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableFieldContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dataStreamPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SerializableFieldContext(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

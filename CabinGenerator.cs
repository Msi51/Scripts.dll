using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class CabinGenerator : StructureGenerator
{
	private static readonly IntPtr NativeFieldInfoPtr_MAX_ITERATIONS;

	private static readonly IntPtr NativeFieldInfoPtr_cabinIdentifiers;

	private static readonly IntPtr NativeFieldInfoPtr_minChunkDistance;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShouldGenerate_Public_Virtual_Boolean_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_findPosition_Private_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_isPositionValid_Private_Boolean_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	public unsafe static int MAX_ITERATIONS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_ITERATIONS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_ITERATIONS, (void*)(&num));
		}
	}

	public unsafe List<string> cabinIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cabinIdentifiers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cabinIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int minChunkDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minChunkDistance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minChunkDistance)) = num;
		}
	}

	static CabinGenerator()
	{
		Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CabinGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_ITERATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr, "MAX_ITERATIONS");
		NativeFieldInfoPtr_cabinIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr, "cabinIdentifiers");
		NativeFieldInfoPtr_minChunkDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr, "minChunkDistance");
		NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr, 100683730);
		NativeMethodInfoPtr_ShouldGenerate_Public_Virtual_Boolean_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr, 100683731);
		NativeMethodInfoPtr_Generate_Public_Virtual_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr, 100683732);
		NativeMethodInfoPtr_findPosition_Private_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr, 100683733);
		NativeMethodInfoPtr_isPositionValid_Private_Boolean_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr, 100683734);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269210, RefRangeEnd = 269211, XrefRangeStart = 269191, XrefRangeEnd = 269210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CabinGenerator(IStructureManager structureManager, IIndoorLevelManager indoorLevelManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CabinGenerator>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)structureManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indoorLevelManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269211, XrefRangeEnd = 269252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ShouldGenerate(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShouldGenerate_Public_Virtual_Boolean_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269252, XrefRangeEnd = 269285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Generate(World world, Chunk chunk, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Generate_Public_Virtual_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269285, XrefRangeEnd = 269289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool findPosition(World world, Chunk chunk, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions, out Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findPosition_Private_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 269297, RefRangeEnd = 269301, XrefRangeStart = 269289, XrefRangeEnd = 269297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isPositionValid(World world, Chunk chunk, Vector3 position, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &position;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPositionValid_Private_Boolean_World_Chunk_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public CabinGenerator(IntPtr pointer)
		: base(pointer)
	{
	}
}

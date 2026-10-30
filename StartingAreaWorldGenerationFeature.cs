using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

public class StartingAreaWorldGenerationFeature : WorldGenerationFeature<StartingAreaWorldGenerationFeatureInfo>
{
	private static readonly IntPtr NativeFieldInfoPtr_MAX_ITERATIONS;

	private static readonly IntPtr NativeMethodInfoPtr_Generate_Protected_Virtual_Void_World_Chunk_StartingAreaWorldGenerationFeatureInfo_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_placeObject_Private_Void_World_Vector3_String_String_Single_Single_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GeneratesInCave_Public_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_placeObject_Private_Void_World_Vector3_String_Single_Single_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_getObjectPositionWithinRadius_Private_Vector3_World_Vector3_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_isObjectPositionValid_Private_Boolean_World_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	static StartingAreaWorldGenerationFeature()
	{
		Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartingAreaWorldGenerationFeature");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_ITERATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr, "MAX_ITERATIONS");
		NativeMethodInfoPtr_Generate_Protected_Virtual_Void_World_Chunk_StartingAreaWorldGenerationFeatureInfo_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr, 100683820);
		NativeMethodInfoPtr_placeObject_Private_Void_World_Vector3_String_String_Single_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr, 100683821);
		NativeMethodInfoPtr_GeneratesInCave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr, 100683822);
		NativeMethodInfoPtr_placeObject_Private_Void_World_Vector3_String_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr, 100683823);
		NativeMethodInfoPtr_getObjectPositionWithinRadius_Private_Vector3_World_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr, 100683824);
		NativeMethodInfoPtr_isObjectPositionValid_Private_Boolean_World_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr, 100683825);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr, 100683826);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270645, XrefRangeEnd = 270653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Generate(World world, Chunk chunk, StartingAreaWorldGenerationFeatureInfo info, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Generate_Protected_Virtual_Void_World_Chunk_StartingAreaWorldGenerationFeatureInfo_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270653, XrefRangeEnd = 270673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placeObject(World world, Vector3 startPosition, string identifier, string subObjectIdentifier, float minRange, float maxRange, int amount, int subObjectAmount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &startPosition;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(subObjectIdentifier);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &minRange;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &maxRange;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &amount;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &subObjectAmount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_placeObject_Private_Void_World_Vector3_String_String_Single_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 27783, RefRangeEnd = 27926, XrefRangeStart = 27783, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool GeneratesInCave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GeneratesInCave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 270682, RefRangeEnd = 270685, XrefRangeStart = 270673, XrefRangeEnd = 270682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placeObject(World world, Vector3 startPosition, string identifier, float minRange, float maxRange, int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &startPosition;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &minRange;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &maxRange;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &amount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_placeObject_Private_Void_World_Vector3_String_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 270704, RefRangeEnd = 270706, XrefRangeStart = 270685, XrefRangeEnd = 270704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 getObjectPositionWithinRadius(World world, Vector3 startingPosition, float minRange, float maxRange)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &startingPosition;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &minRange;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &maxRange;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getObjectPositionWithinRadius_Private_Vector3_World_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270706, XrefRangeEnd = 270716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isObjectPositionValid(World world, Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &position;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isObjectPositionValid_Private_Boolean_World_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 270719, RefRangeEnd = 270720, XrefRangeStart = 270716, XrefRangeEnd = 270719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartingAreaWorldGenerationFeature()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartingAreaWorldGenerationFeature>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartingAreaWorldGenerationFeature(IntPtr pointer)
		: base(pointer)
	{
	}
}

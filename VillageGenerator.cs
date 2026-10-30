using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[Serializable]
public class VillageGenerator : StructureGenerator
{
	private static readonly IntPtr NativeFieldInfoPtr_LARGE_HOUSE_1_IDENTIFIER;

	private static readonly IntPtr NativeFieldInfoPtr_SMALL_HOUSE_2_IDENTIFIER;

	private static readonly IntPtr NativeFieldInfoPtr_STORAGE_AREA_IDENTIFIER;

	private static readonly IntPtr NativeFieldInfoPtr_villageHouseIdentifiers;

	private static readonly IntPtr NativeFieldInfoPtr_smallStructureIdentifiers;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShouldGenerate_Public_Virtual_Boolean_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_generateCurvedRoadVillageChunk_Private_Void_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_generateIntersectionRoadVillageChunk_Private_Void_World_Chunk_Vector2_Vector2_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_generateIntersectionRoadVillageChunk_Private_Void_World_Chunk_ChunkInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr_generateStraightRoadVillageChunk_Private_Void_World_Chunk_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_findValidAngleDegrees_Private_Boolean_CustomRandom_List_1_Single_Single_byref_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_generateNonRoadVillageChunk_Private_Void_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_generateStructurePosition_Private_Void_World_Chunk_String_Vector3_Vector3_Single_Single_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_getRandomIdentifier_Private_String_Chunk_List_1_String_0;

	public unsafe static string LARGE_HOUSE_1_IDENTIFIER
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LARGE_HOUSE_1_IDENTIFIER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LARGE_HOUSE_1_IDENTIFIER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SMALL_HOUSE_2_IDENTIFIER
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SMALL_HOUSE_2_IDENTIFIER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SMALL_HOUSE_2_IDENTIFIER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STORAGE_AREA_IDENTIFIER
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STORAGE_AREA_IDENTIFIER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STORAGE_AREA_IDENTIFIER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static List<string> villageHouseIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_villageHouseIdentifiers, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_villageHouseIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<string> smallStructureIdentifiers
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_smallStructureIdentifiers, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_smallStructureIdentifiers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static VillageGenerator()
	{
		Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "VillageGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_LARGE_HOUSE_1_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, "LARGE_HOUSE_1_IDENTIFIER");
		NativeFieldInfoPtr_SMALL_HOUSE_2_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, "SMALL_HOUSE_2_IDENTIFIER");
		NativeFieldInfoPtr_STORAGE_AREA_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, "STORAGE_AREA_IDENTIFIER");
		NativeFieldInfoPtr_villageHouseIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, "villageHouseIdentifiers");
		NativeFieldInfoPtr_smallStructureIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, "smallStructureIdentifiers");
		NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683746);
		NativeMethodInfoPtr_ShouldGenerate_Public_Virtual_Boolean_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683747);
		NativeMethodInfoPtr_Generate_Public_Virtual_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683748);
		NativeMethodInfoPtr_generateCurvedRoadVillageChunk_Private_Void_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683749);
		NativeMethodInfoPtr_generateIntersectionRoadVillageChunk_Private_Void_World_Chunk_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683750);
		NativeMethodInfoPtr_generateIntersectionRoadVillageChunk_Private_Void_World_Chunk_ChunkInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683751);
		NativeMethodInfoPtr_generateStraightRoadVillageChunk_Private_Void_World_Chunk_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683752);
		NativeMethodInfoPtr_findValidAngleDegrees_Private_Boolean_CustomRandom_List_1_Single_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683753);
		NativeMethodInfoPtr_generateNonRoadVillageChunk_Private_Void_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683754);
		NativeMethodInfoPtr_generateStructurePosition_Private_Void_World_Chunk_String_Vector3_Vector3_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683755);
		NativeMethodInfoPtr_getRandomIdentifier_Private_String_Chunk_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr, 100683756);
	}

	[CallerCount(120)]
	[CachedScanResults(RefRangeStart = 3923, RefRangeEnd = 4043, XrefRangeStart = 3923, XrefRangeEnd = 4043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VillageGenerator(IStructureManager structureManager, IIndoorLevelManager indoorLevelManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VillageGenerator>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)structureManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indoorLevelManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269447, XrefRangeEnd = 269448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269448, XrefRangeEnd = 269492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269497, RefRangeEnd = 269498, XrefRangeStart = 269492, XrefRangeEnd = 269497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateCurvedRoadVillageChunk(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateCurvedRoadVillageChunk_Private_Void_World_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 269529, RefRangeEnd = 269531, XrefRangeStart = 269498, XrefRangeEnd = 269529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateIntersectionRoadVillageChunk(World world, Chunk chunk, Vector2 roadDirection, Vector2 roadDirectionBack, Vector2 branchDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &roadDirection;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &roadDirectionBack;
		*(Vector2**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &branchDirection;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateIntersectionRoadVillageChunk_Private_Void_World_Chunk_Vector2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269532, RefRangeEnd = 269533, XrefRangeStart = 269531, XrefRangeEnd = 269532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateIntersectionRoadVillageChunk(World world, Chunk chunk, ChunkInfo chunkInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkInfo);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateIntersectionRoadVillageChunk_Private_Void_World_Chunk_ChunkInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 269556, RefRangeEnd = 269558, XrefRangeStart = 269533, XrefRangeEnd = 269556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateStraightRoadVillageChunk(World world, Chunk chunk, Vector2 roadDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &roadDirection;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateStraightRoadVillageChunk_Private_Void_World_Chunk_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269581, RefRangeEnd = 269582, XrefRangeStart = 269558, XrefRangeEnd = 269581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool findValidAngleDegrees(CustomRandom random, List<float> usedAngles, float buffer, out float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)usedAngles);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &buffer;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref angle);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findValidAngleDegrees_Private_Boolean_CustomRandom_List_1_Single_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269603, RefRangeEnd = 269604, XrefRangeStart = 269582, XrefRangeEnd = 269603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateNonRoadVillageChunk(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateNonRoadVillageChunk_Private_Void_World_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 269631, RefRangeEnd = 269636, XrefRangeStart = 269604, XrefRangeEnd = 269631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateStructurePosition(World world, Chunk chunk, string identifier, Vector3 startPosition, Vector3 direction, float minRelativeDistance, float maxRelativeDistance, int maxAngleDeviation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startPosition;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &minRelativeDistance;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &maxRelativeDistance;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &maxAngleDeviation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateStructurePosition_Private_Void_World_Chunk_String_Vector3_Vector3_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269636, XrefRangeEnd = 269642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getRandomIdentifier(Chunk chunk, List<string> identifiers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifiers);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRandomIdentifier_Private_String_Chunk_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public VillageGenerator(IntPtr pointer)
		: base(pointer)
	{
	}
}

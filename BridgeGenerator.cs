using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

[Serializable]
public class BridgeGenerator : StructureGenerator
{
	private static readonly IntPtr NativeFieldInfoPtr_BRIDGE_PLATFORM_IDENTIFIER;

	private static readonly IntPtr NativeFieldInfoPtr_BRIDGE_RAMP_IDENTIFIER;

	private static readonly IntPtr NativeFieldInfoPtr_BRIDGE_PLATFORM_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_BRIDGE_RAMP_SIZE;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShouldGenerate_Public_Virtual_Boolean_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_findShoreInDirection_Private_Vector2Int_Int32_Int32_World_Chunk_Il2CppObjectBase_Vector2Int_Vector3_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_findChunkBorder_Private_Void_byref_Int32_byref_Int32_Vector3_Chunk_Int32_Int32_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_buildBridge_Private_Void_World_Coordinates_Single_Vector3_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_generateStructurePosition_Private_Void_World_Coordinates_String_Vector3_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	public unsafe static string BRIDGE_PLATFORM_IDENTIFIER
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BRIDGE_PLATFORM_IDENTIFIER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BRIDGE_PLATFORM_IDENTIFIER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BRIDGE_RAMP_IDENTIFIER
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BRIDGE_RAMP_IDENTIFIER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BRIDGE_RAMP_IDENTIFIER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static float BRIDGE_PLATFORM_SIZE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BRIDGE_PLATFORM_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BRIDGE_PLATFORM_SIZE, (void*)(&num));
		}
	}

	public unsafe static float BRIDGE_RAMP_SIZE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BRIDGE_RAMP_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BRIDGE_RAMP_SIZE, (void*)(&num));
		}
	}

	static BridgeGenerator()
	{
		Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "BridgeGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_BRIDGE_PLATFORM_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, "BRIDGE_PLATFORM_IDENTIFIER");
		NativeFieldInfoPtr_BRIDGE_RAMP_IDENTIFIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, "BRIDGE_RAMP_IDENTIFIER");
		NativeFieldInfoPtr_BRIDGE_PLATFORM_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, "BRIDGE_PLATFORM_SIZE");
		NativeFieldInfoPtr_BRIDGE_RAMP_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, "BRIDGE_RAMP_SIZE");
		NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, 100683723);
		NativeMethodInfoPtr_ShouldGenerate_Public_Virtual_Boolean_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, 100683724);
		NativeMethodInfoPtr_Generate_Public_Virtual_Boolean_World_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, 100683725);
		NativeMethodInfoPtr_findShoreInDirection_Private_Vector2Int_Int32_Int32_World_Chunk_Il2CppObjectBase_Vector2Int_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, 100683726);
		NativeMethodInfoPtr_findChunkBorder_Private_Void_byref_Int32_byref_Int32_Vector3_Chunk_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, 100683727);
		NativeMethodInfoPtr_buildBridge_Private_Void_World_Coordinates_Single_Vector3_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, 100683728);
		NativeMethodInfoPtr_generateStructurePosition_Private_Void_World_Coordinates_String_Vector3_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr, 100683729);
	}

	[CallerCount(120)]
	[CachedScanResults(RefRangeStart = 3923, RefRangeEnd = 4043, XrefRangeStart = 3923, XrefRangeEnd = 4043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BridgeGenerator(IStructureManager structureManager, IIndoorLevelManager indoorLevelManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BridgeGenerator>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)structureManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indoorLevelManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IStructureManager_IIndoorLevelManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269075, XrefRangeEnd = 269093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 269134, RefRangeEnd = 269136, XrefRangeStart = 269093, XrefRangeEnd = 269134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2Int findShoreInDirection(int yComponent, int xComponent, World world, Chunk chunk, Il2CppObjectBase heightmap, Vector2Int direction, Vector3 perpendicularRoadDirection, int mapSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[8];
		*ptr = (nint)(&yComponent);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &xComponent;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(heightmap);
		*(Vector2Int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &direction;
		*(Vector3**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &perpendicularRoadDirection;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &mapSize;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findShoreInDirection_Private_Vector2Int_Int32_Int32_World_Chunk_Il2CppObjectBase_Vector2Int_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 269161, RefRangeEnd = 269163, XrefRangeStart = 269136, XrefRangeEnd = 269161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void findChunkBorder(out int roadCenterYComponent, out int roadCenterXComponent, Vector3 perpendicularRoadDirection, Chunk chunk, int roadTerrainTypeInt, int heightmapSize, bool inPositiveDirection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = (nint)Unsafe.AsPointer(ref roadCenterYComponent);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref roadCenterXComponent);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &perpendicularRoadDirection;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &roadTerrainTypeInt;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &heightmapSize;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &inPositiveDirection;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findChunkBorder_Private_Void_byref_Int32_byref_Int32_Vector3_Chunk_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269177, RefRangeEnd = 269178, XrefRangeStart = 269163, XrefRangeEnd = 269177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buildBridge(World world, Coordinates coordinates, float shoresDistance, Vector3 directionOfBridge, Vector3 centerPosition, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &coordinates;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &shoresDistance;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &directionOfBridge;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &centerPosition;
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildBridge_Private_Void_World_Coordinates_Single_Vector3_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269190, RefRangeEnd = 269191, XrefRangeStart = 269178, XrefRangeEnd = 269190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateStructurePosition(World world, Coordinates coordinates, string identifier, Vector3 startPosition, Vector3 direction, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &coordinates;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &startPosition;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &direction;
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateStructurePosition_Private_Void_World_Coordinates_String_Vector3_Vector3_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BridgeGenerator(IntPtr pointer)
		: base(pointer)
	{
	}
}

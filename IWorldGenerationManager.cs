using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

public class IWorldGenerationManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_Task_World_WorldGen_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateStartingArea_Public_Abstract_Virtual_New_Task_World_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateRegionChunk_Public_Abstract_Virtual_New_Task_World_RegionChunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateChunks_Public_Abstract_Virtual_New_Task_1_List_1_Chunk_World_List_1_Coordinates_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateTerrain_Public_Abstract_Virtual_New_Void_World_RegionChunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateTerrain_Public_Abstract_Virtual_New_Task_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateWater_Public_Abstract_Virtual_New_Void_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateEffects_Public_Abstract_Virtual_New_Void_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateDetailObjects_Public_Abstract_Virtual_New_Void_Chunk_Coordinates_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateDetailObjectsLod_Public_Abstract_Virtual_New_Void_DetailLodCreationInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateWaterPlane_Public_Abstract_Virtual_New_Mesh_Single_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateCloudTextureData_Public_Abstract_Virtual_New_Il2CppStructArray_1_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateCloudTextureData_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Color_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateSoundCollider_Public_Abstract_Virtual_New_Void_Chunk_Vector3_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleQueuedTerrainTextureData_Public_Abstract_Virtual_New_Void_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleQueuedTerrainHeightData_Public_Abstract_Virtual_New_Void_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleQueuedTerrainDetailmapData_Public_Abstract_Virtual_New_Void_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleQueuedTerrainClearedSnowData_Public_Abstract_Virtual_New_Void_World_Chunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshDetailMaps_Public_Abstract_Virtual_New_Void_World_Chunk_Vector3_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Unload_Public_Abstract_Virtual_New_Void_0;

	static IWorldGenerationManager()
	{
		Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IWorldGenerationManager");
		NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_Task_World_WorldGen_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676048);
		NativeMethodInfoPtr_GenerateStartingArea_Public_Abstract_Virtual_New_Task_World_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676049);
		NativeMethodInfoPtr_GenerateRegionChunk_Public_Abstract_Virtual_New_Task_World_RegionChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676050);
		NativeMethodInfoPtr_GenerateChunks_Public_Abstract_Virtual_New_Task_1_List_1_Chunk_World_List_1_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676051);
		NativeMethodInfoPtr_CreateTerrain_Public_Abstract_Virtual_New_Void_World_RegionChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676052);
		NativeMethodInfoPtr_CreateTerrain_Public_Abstract_Virtual_New_Task_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676053);
		NativeMethodInfoPtr_CreateWater_Public_Abstract_Virtual_New_Void_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676054);
		NativeMethodInfoPtr_CreateEffects_Public_Abstract_Virtual_New_Void_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676055);
		NativeMethodInfoPtr_CreateDetailObjects_Public_Abstract_Virtual_New_Void_Chunk_Coordinates_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676056);
		NativeMethodInfoPtr_CreateDetailObjectsLod_Public_Abstract_Virtual_New_Void_DetailLodCreationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676057);
		NativeMethodInfoPtr_GenerateWaterPlane_Public_Abstract_Virtual_New_Mesh_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676058);
		NativeMethodInfoPtr_GenerateCloudTextureData_Public_Abstract_Virtual_New_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676059);
		NativeMethodInfoPtr_GenerateCloudTextureData_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676060);
		NativeMethodInfoPtr_CreateSoundCollider_Public_Abstract_Virtual_New_Void_Chunk_Vector3_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676061);
		NativeMethodInfoPtr_HandleQueuedTerrainTextureData_Public_Abstract_Virtual_New_Void_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676062);
		NativeMethodInfoPtr_HandleQueuedTerrainHeightData_Public_Abstract_Virtual_New_Void_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676063);
		NativeMethodInfoPtr_HandleQueuedTerrainDetailmapData_Public_Abstract_Virtual_New_Void_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676064);
		NativeMethodInfoPtr_HandleQueuedTerrainClearedSnowData_Public_Abstract_Virtual_New_Void_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676065);
		NativeMethodInfoPtr_RefreshDetailMaps_Public_Abstract_Virtual_New_Void_World_Chunk_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676066);
		NativeMethodInfoPtr_Unload_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldGenerationManager>.NativeClassPtr, 100676067);
	}

	[CallerCount(0)]
	public unsafe virtual Task Generate(World world, WorldGen config, Vector3 startingPositionOverride = default(Vector3))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)config);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &startingPositionOverride;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Generate_Public_Abstract_Virtual_New_Task_World_WorldGen_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task GenerateStartingArea(World world, Vector3 startingPositionOverride = default(Vector3))
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &startingPositionOverride;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateStartingArea_Public_Abstract_Virtual_New_Task_World_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task GenerateRegionChunk(World world, RegionChunk regionChunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionChunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateRegionChunk_Public_Abstract_Virtual_New_Task_World_RegionChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task<List<Chunk>> GenerateChunks(World world, List<Coordinates> chunkCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkCoordinates);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateChunks_Public_Abstract_Virtual_New_Task_1_List_1_Chunk_World_List_1_Coordinates_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Task<List<Chunk>>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void CreateTerrain(World world, RegionChunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateTerrain_Public_Abstract_Virtual_New_Void_World_RegionChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Task CreateTerrain(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateTerrain_Public_Abstract_Virtual_New_Task_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void CreateWater(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateWater_Public_Abstract_Virtual_New_Void_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void CreateEffects(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateEffects_Public_Abstract_Virtual_New_Void_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void CreateDetailObjects(Chunk chunk, Coordinates cellCoordinates, bool immediate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &cellCoordinates;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &immediate;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateDetailObjects_Public_Abstract_Virtual_New_Void_Chunk_Coordinates_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void CreateDetailObjectsLod(DetailLodCreationInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateDetailObjectsLod_Public_Abstract_Virtual_New_Void_DetailLodCreationInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Mesh GenerateWaterPlane(float chunkSize, int resolution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&chunkSize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &resolution;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateWaterPlane_Public_Abstract_Virtual_New_Mesh_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppStructArray<Color> GenerateCloudTextureData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateCloudTextureData_Public_Abstract_Virtual_New_Il2CppStructArray_1_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void GenerateCloudTextureData(Il2CppStructArray<Color> pixels, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pixels);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &time;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateCloudTextureData_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Color_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void CreateSoundCollider(Chunk chunk, Vector3 position, string tag, int layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &position;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(tag);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &layer;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateSoundCollider_Public_Abstract_Virtual_New_Void_Chunk_Vector3_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleQueuedTerrainTextureData(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleQueuedTerrainTextureData_Public_Abstract_Virtual_New_Void_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleQueuedTerrainHeightData(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleQueuedTerrainHeightData_Public_Abstract_Virtual_New_Void_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleQueuedTerrainDetailmapData(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleQueuedTerrainDetailmapData_Public_Abstract_Virtual_New_Void_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleQueuedTerrainClearedSnowData(World world, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleQueuedTerrainClearedSnowData_Public_Abstract_Virtual_New_Void_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RefreshDetailMaps(World world, Chunk chunk, Vector3 position, bool immediate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &position;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &immediate;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RefreshDetailMaps_Public_Abstract_Virtual_New_Void_World_Chunk_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void Unload()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Unload_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IWorldGenerationManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

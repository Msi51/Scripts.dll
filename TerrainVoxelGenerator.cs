using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MarchingCubesProject;
using UnityEngine.Pool;

public class TerrainVoxelGenerator : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_taskManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_marchingPool;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ITaskManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createMarching_Private_Marching_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMarching_Private_Void_Marching_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateVoxelData_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTerrainMeshData_Public_Void_Chunk_0;

	public unsafe ITaskManager taskManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ITaskManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskManager));
		}
	}

	public unsafe ObjectPool<Marching> marchingPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marchingPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPool<Marching>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marchingPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectPool));
		}
	}

	static TerrainVoxelGenerator()
	{
		Il2CppClassPointerStore<TerrainVoxelGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TerrainVoxelGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainVoxelGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_taskManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainVoxelGenerator>.NativeClassPtr, "taskManager");
		NativeFieldInfoPtr_marchingPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainVoxelGenerator>.NativeClassPtr, "marchingPool");
		NativeMethodInfoPtr__ctor_Public_Void_ITaskManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainVoxelGenerator>.NativeClassPtr, 100683758);
		NativeMethodInfoPtr_createMarching_Private_Marching_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainVoxelGenerator>.NativeClassPtr, 100683759);
		NativeMethodInfoPtr_getMarching_Private_Void_Marching_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainVoxelGenerator>.NativeClassPtr, 100683760);
		NativeMethodInfoPtr_GenerateVoxelData_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainVoxelGenerator>.NativeClassPtr, 100683761);
		NativeMethodInfoPtr_GenerateTerrainMeshData_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainVoxelGenerator>.NativeClassPtr, 100683762);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269664, RefRangeEnd = 269665, XrefRangeStart = 269642, XrefRangeEnd = 269664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainVoxelGenerator(ITaskManager taskManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainVoxelGenerator>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskManager);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ITaskManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269665, XrefRangeEnd = 269669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Marching createMarching()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createMarching_Private_Marching_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Marching>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269669, XrefRangeEnd = 269670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getMarching(Marching marching)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)marching);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMarching_Private_Void_Marching_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269672, RefRangeEnd = 269673, XrefRangeStart = 269670, XrefRangeEnd = 269672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateVoxelData(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateVoxelData_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 269680, RefRangeEnd = 269681, XrefRangeStart = 269673, XrefRangeEnd = 269680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateTerrainMeshData(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateTerrainMeshData_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TerrainVoxelGenerator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

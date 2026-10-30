using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class VoxelTerrainChunkPool : BasePool<VoxelTerrainChunk>
{
	private static readonly IntPtr NativeFieldInfoPtr_heightmapResolution;

	private static readonly IntPtr NativeFieldInfoPtr_height;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_VoxelTerrainChunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_onGet_Private_Static_Void_VoxelTerrainChunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_0;

	public unsafe int heightmapResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapResolution)) = num;
		}
	}

	public unsafe int height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = num;
		}
	}

	static VoxelTerrainChunkPool()
	{
		Il2CppClassPointerStore<VoxelTerrainChunkPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "VoxelTerrainChunkPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoxelTerrainChunkPool>.NativeClassPtr);
		NativeFieldInfoPtr_heightmapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoxelTerrainChunkPool>.NativeClassPtr, "heightmapResolution");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoxelTerrainChunkPool>.NativeClassPtr, "height");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoxelTerrainChunkPool>.NativeClassPtr, 100664551);
		NativeMethodInfoPtr_onCreate_Private_VoxelTerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoxelTerrainChunkPool>.NativeClassPtr, 100664552);
		NativeMethodInfoPtr_onGet_Private_Static_Void_VoxelTerrainChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoxelTerrainChunkPool>.NativeClassPtr, 100664553);
		NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoxelTerrainChunkPool>.NativeClassPtr, 100664554);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32311, XrefRangeEnd = 32334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VoxelTerrainChunkPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoxelTerrainChunkPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32334, XrefRangeEnd = 32343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VoxelTerrainChunk onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_VoxelTerrainChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<VoxelTerrainChunk>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32343, XrefRangeEnd = 32354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onGet(VoxelTerrainChunk terrainChunk)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainChunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGet_Private_Static_Void_VoxelTerrainChunk_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32354, XrefRangeEnd = 32357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProperties(int heightmapResolution, int height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&heightmapResolution);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &height;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public VoxelTerrainChunkPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

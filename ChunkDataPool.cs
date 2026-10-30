using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class ChunkDataPool : BasePool<ChunkData>
{
	private static readonly IntPtr NativeFieldInfoPtr_heightmapSize;

	private static readonly IntPtr NativeFieldInfoPtr_alphamapResolution;

	private static readonly IntPtr NativeFieldInfoPtr_detailResolution;

	private static readonly IntPtr NativeFieldInfoPtr_terrainTypeSize;

	private static readonly IntPtr NativeFieldInfoPtr_terrainTypesCount;

	private static readonly IntPtr NativeFieldInfoPtr_textureLayersCount;

	private static readonly IntPtr NativeFieldInfoPtr_terrainDetailLayersCount;

	private static readonly IntPtr NativeFieldInfoPtr_numBytes;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_ChunkData_0;

	private static readonly IntPtr NativeMethodInfoPtr_onGet_Private_Static_Void_ChunkData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNumBytes_Public_Int32_0;

	public unsafe int heightmapSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapSize)) = num;
		}
	}

	public unsafe int alphamapResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamapResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamapResolution)) = num;
		}
	}

	public unsafe int detailResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailResolution)) = num;
		}
	}

	public unsafe int terrainTypeSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeSize)) = num;
		}
	}

	public unsafe int terrainTypesCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypesCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypesCount)) = num;
		}
	}

	public unsafe int textureLayersCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureLayersCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureLayersCount)) = num;
		}
	}

	public unsafe int terrainDetailLayersCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainDetailLayersCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainDetailLayersCount)) = num;
		}
	}

	public unsafe int numBytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numBytes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numBytes)) = num;
		}
	}

	static ChunkDataPool()
	{
		Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChunkDataPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr);
		NativeFieldInfoPtr_heightmapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, "heightmapSize");
		NativeFieldInfoPtr_alphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, "alphamapResolution");
		NativeFieldInfoPtr_detailResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, "detailResolution");
		NativeFieldInfoPtr_terrainTypeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, "terrainTypeSize");
		NativeFieldInfoPtr_terrainTypesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, "terrainTypesCount");
		NativeFieldInfoPtr_textureLayersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, "textureLayersCount");
		NativeFieldInfoPtr_terrainDetailLayersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, "terrainDetailLayersCount");
		NativeFieldInfoPtr_numBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, "numBytes");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, 100664455);
		NativeMethodInfoPtr_onCreate_Private_ChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, 100664456);
		NativeMethodInfoPtr_onGet_Private_Static_Void_ChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, 100664457);
		NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, 100664458);
		NativeMethodInfoPtr_GetNumBytes_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr, 100664459);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30471, RefRangeEnd = 30472, XrefRangeStart = 30448, XrefRangeEnd = 30471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkDataPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkDataPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30472, XrefRangeEnd = 30502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkData onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_ChunkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ChunkData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30502, XrefRangeEnd = 30513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onGet(ChunkData chunkData)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGet_Private_Static_Void_ChunkData_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30516, RefRangeEnd = 30517, XrefRangeStart = 30513, XrefRangeEnd = 30516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProperties(int heightmapSize, int alphamapResolution, int detailResolution, int terrainTypeSize, int terrainTypesCount, int textureLayersCount, int terrainDetailLayersCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = (nint)(&heightmapSize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &alphamapResolution;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &detailResolution;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &terrainTypeSize;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &terrainTypesCount;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &textureLayersCount;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &terrainDetailLayersCount;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetNumBytes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumBytes_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ChunkDataPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

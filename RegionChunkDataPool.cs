using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class RegionChunkDataPool : BasePool<RegionChunkData>
{
	private static readonly IntPtr NativeFieldInfoPtr_heightmapSize;

	private static readonly IntPtr NativeFieldInfoPtr_alphamapResolution;

	private static readonly IntPtr NativeFieldInfoPtr_alphamapLayers;

	private static readonly IntPtr NativeFieldInfoPtr_numBytes;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_RegionChunkData_0;

	private static readonly IntPtr NativeMethodInfoPtr_onGet_Private_Static_Void_RegionChunkData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_Int32_0;

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

	public unsafe int alphamapLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamapLayers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamapLayers)) = num;
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

	static RegionChunkDataPool()
	{
		Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RegionChunkDataPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr);
		NativeFieldInfoPtr_heightmapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr, "heightmapSize");
		NativeFieldInfoPtr_alphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr, "alphamapResolution");
		NativeFieldInfoPtr_alphamapLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr, "alphamapLayers");
		NativeFieldInfoPtr_numBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr, "numBytes");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr, 100664516);
		NativeMethodInfoPtr_onCreate_Private_RegionChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr, 100664517);
		NativeMethodInfoPtr_onGet_Private_Static_Void_RegionChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr, 100664518);
		NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr, 100664519);
		NativeMethodInfoPtr_GetNumBytes_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr, 100664520);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31445, RefRangeEnd = 31446, XrefRangeStart = 31422, XrefRangeEnd = 31445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegionChunkDataPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionChunkDataPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31446, XrefRangeEnd = 31456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegionChunkData onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_RegionChunkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RegionChunkData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31456, XrefRangeEnd = 31460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onGet(RegionChunkData chunkData)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGet_Private_Static_Void_RegionChunkData_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31463, RefRangeEnd = 31464, XrefRangeStart = 31460, XrefRangeEnd = 31463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProperties(int heightmapSize, int alphamapResolution, int alphamapLayers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&heightmapSize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &alphamapResolution;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &alphamapLayers;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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

	public RegionChunkDataPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

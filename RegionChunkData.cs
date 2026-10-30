using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class RegionChunkData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_heightmap;

	private static readonly System.IntPtr NativeFieldInfoPtr_alphamap;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightmapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_alphamapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_alphamapLayers;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppObjectBase_Il2CppObjectBase_0;

	public unsafe Il2CppObjectBase heightmap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmap)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppObjectBase alphamap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamap)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

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

	static RegionChunkData()
	{
		Il2CppClassPointerStore<RegionChunkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RegionChunkData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionChunkData>.NativeClassPtr);
		NativeFieldInfoPtr_heightmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionChunkData>.NativeClassPtr, "heightmap");
		NativeFieldInfoPtr_alphamap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionChunkData>.NativeClassPtr, "alphamap");
		NativeFieldInfoPtr_heightmapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionChunkData>.NativeClassPtr, "heightmapResolution");
		NativeFieldInfoPtr_alphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionChunkData>.NativeClassPtr, "alphamapResolution");
		NativeFieldInfoPtr_alphamapLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionChunkData>.NativeClassPtr, "alphamapLayers");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppObjectBase_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionChunkData>.NativeClassPtr, 100683374);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 261409, RefRangeEnd = 261410, XrefRangeStart = 261403, XrefRangeEnd = 261409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegionChunkData(Il2CppObjectBase heightmap, Il2CppObjectBase alphamap)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionChunkData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(heightmap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(alphamap);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppObjectBase_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RegionChunkData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

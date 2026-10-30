using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class RegionMapData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_textures;

	private static readonly System.IntPtr NativeFieldInfoPtr_minCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileSizeRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapTileObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapTexts;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTileTextures_Public_Il2CppObjectBase_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<Il2CppObjectBase> textures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppObjectBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Coordinates minCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minCoordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minCoordinates)) = coordinates;
		}
	}

	public unsafe Coordinates maxCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCoordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCoordinates)) = coordinates;
		}
	}

	public unsafe float tileSizeRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileSizeRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileSizeRatio)) = num;
		}
	}

	public unsafe List<MapTileObject> mapTileObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapTileObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MapTileObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapTileObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MapText> mapTexts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapTexts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MapText>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapTexts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static RegionMapData()
	{
		Il2CppClassPointerStore<RegionMapData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RegionMapData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionMapData>.NativeClassPtr);
		NativeFieldInfoPtr_textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionMapData>.NativeClassPtr, "textures");
		NativeFieldInfoPtr_minCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionMapData>.NativeClassPtr, "minCoordinates");
		NativeFieldInfoPtr_maxCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionMapData>.NativeClassPtr, "maxCoordinates");
		NativeFieldInfoPtr_tileSizeRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionMapData>.NativeClassPtr, "tileSizeRatio");
		NativeFieldInfoPtr_mapTileObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionMapData>.NativeClassPtr, "mapTileObjects");
		NativeFieldInfoPtr_mapTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionMapData>.NativeClassPtr, "mapTexts");
		NativeMethodInfoPtr_GetTileTextures_Public_Il2CppObjectBase_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionMapData>.NativeClassPtr, 100678289);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionMapData>.NativeClassPtr, 100678290);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 223955, RefRangeEnd = 223957, XrefRangeStart = 223940, XrefRangeEnd = 223955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppObjectBase GetTileTextures(float zoomLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&zoomLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTileTextures_Public_Il2CppObjectBase_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 223973, RefRangeEnd = 223974, XrefRangeStart = 223957, XrefRangeEnd = 223973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegionMapData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionMapData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RegionMapData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

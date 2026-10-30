using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class MapTileObject : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_entityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_relativePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimapIconType;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapIconSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynamicSizingFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerMapMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoMapMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_entityLabel;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int entityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityId)) = num;
		}
	}

	public unsafe Coordinates chunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkCoordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkCoordinates)) = coordinates;
		}
	}

	public unsafe Vector2 relativePosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativePosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativePosition)) = vector;
		}
	}

	public unsafe MinimapIconType minimapIconType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimapIconType);
			return *(MinimapIconType*)num;
		}
		set
		{
			*(MinimapIconType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimapIconType)) = minimapIconType;
		}
	}

	public unsafe float mapIconSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapIconSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapIconSize)) = num;
		}
	}

	public unsafe float dynamicSizingFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicSizingFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicSizingFactor)) = num;
		}
	}

	public unsafe Quaternion rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation)) = quaternion;
		}
	}

	public unsafe PlayerMapMarker playerMapMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMapMarker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerMapMarker>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMapMarker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerMapMarker));
		}
	}

	public unsafe AutoMapMarker autoMapMarker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoMapMarker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoMapMarker>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoMapMarker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)autoMapMarker));
		}
	}

	public unsafe string entityLabel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityLabel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityLabel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static MapTileObject()
	{
		Il2CppClassPointerStore<MapTileObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MapTileObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr);
		NativeFieldInfoPtr_entityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, "entityId");
		NativeFieldInfoPtr_chunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, "chunkCoordinates");
		NativeFieldInfoPtr_relativePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, "relativePosition");
		NativeFieldInfoPtr_minimapIconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, "minimapIconType");
		NativeFieldInfoPtr_mapIconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, "mapIconSize");
		NativeFieldInfoPtr_dynamicSizingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, "dynamicSizingFactor");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_playerMapMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, "playerMapMarker");
		NativeFieldInfoPtr_autoMapMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, "autoMapMarker");
		NativeFieldInfoPtr_entityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, "entityLabel");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr, 100678286);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MapTileObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapTileObject>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MapTileObject(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

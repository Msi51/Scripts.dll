using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class ObjectLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IGNORE_RAYCAST;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENVIRONMENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_SELECTED;

	private static readonly System.IntPtr NativeFieldInfoPtr_THUMBNAIL;

	private static readonly System.IntPtr NativeFieldInfoPtr_RAIN_COVER;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_OBJECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_VALID_INDICATOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_INDICATOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_TERRAIN_COLLISION;

	private static readonly System.IntPtr NativeFieldInfoPtr_STAIRS_COLLIDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_environmentLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainDetailsLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_noOutlineLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_maskableLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_obscureShown;

	private static readonly System.IntPtr NativeFieldInfoPtr_bushCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_transparentFX;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_stairsColliderLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_hitBoxLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectileLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_entityCapsule;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainAndWaterLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainAndCaveLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainAndWaterAndCaveLayerMask;

	public unsafe static string IGNORE_RAYCAST
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IGNORE_RAYCAST, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IGNORE_RAYCAST, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENVIRONMENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENVIRONMENT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENVIRONMENT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SELECTED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SELECTED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SELECTED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string THUMBNAIL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THUMBNAIL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THUMBNAIL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RAIN_COVER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RAIN_COVER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RAIN_COVER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UI_OBJECT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_OBJECT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_OBJECT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string VALID_INDICATOR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VALID_INDICATOR, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VALID_INDICATOR, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string INVALID_INDICATOR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INVALID_INDICATOR, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INVALID_INDICATOR, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TERRAIN_COLLISION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TERRAIN_COLLISION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TERRAIN_COLLISION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STAIRS_COLLIDER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STAIRS_COLLIDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STAIRS_COLLIDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int defaultLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultLayer, (void*)(&num));
		}
	}

	public unsafe static int environmentLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_environmentLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_environmentLayer, (void*)(&num));
		}
	}

	public unsafe static int terrainLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainLayer, (void*)(&num));
		}
	}

	public unsafe static int regionLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_regionLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_regionLayer, (void*)(&num));
		}
	}

	public unsafe static int terrainDetailsLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainDetailsLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainDetailsLayer, (void*)(&num));
		}
	}

	public unsafe static int waterLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_waterLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_waterLayer, (void*)(&num));
		}
	}

	public unsafe static int noOutlineLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_noOutlineLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_noOutlineLayer, (void*)(&num));
		}
	}

	public unsafe static int maskableLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maskableLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maskableLayer, (void*)(&num));
		}
	}

	public unsafe static int obscureShown
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_obscureShown, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_obscureShown, (void*)(&num));
		}
	}

	public unsafe static int bushCollider
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bushCollider, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bushCollider, (void*)(&num));
		}
	}

	public unsafe static int transparentFX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_transparentFX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_transparentFX, (void*)(&num));
		}
	}

	public unsafe static int caveLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_caveLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_caveLayer, (void*)(&num));
		}
	}

	public unsafe static int stairsColliderLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stairsColliderLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stairsColliderLayer, (void*)(&num));
		}
	}

	public unsafe static int selectedLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_selectedLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_selectedLayer, (void*)(&num));
		}
	}

	public unsafe static int hitBoxLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hitBoxLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hitBoxLayer, (void*)(&num));
		}
	}

	public unsafe static int projectileLayer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_projectileLayer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_projectileLayer, (void*)(&num));
		}
	}

	public unsafe static int entityCapsule
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_entityCapsule, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_entityCapsule, (void*)(&num));
		}
	}

	public unsafe static int terrainAndWaterLayerMask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainAndWaterLayerMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainAndWaterLayerMask, (void*)(&num));
		}
	}

	public unsafe static int terrainAndCaveLayerMask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainAndCaveLayerMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainAndCaveLayerMask, (void*)(&num));
		}
	}

	public unsafe static int terrainAndWaterAndCaveLayerMask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_terrainAndWaterAndCaveLayerMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_terrainAndWaterAndCaveLayerMask, (void*)(&num));
		}
	}

	static ObjectLayer()
	{
		Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ObjectLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr);
		NativeFieldInfoPtr_IGNORE_RAYCAST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "IGNORE_RAYCAST");
		NativeFieldInfoPtr_ENVIRONMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "ENVIRONMENT");
		NativeFieldInfoPtr_SELECTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "SELECTED");
		NativeFieldInfoPtr_THUMBNAIL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "THUMBNAIL");
		NativeFieldInfoPtr_RAIN_COVER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "RAIN_COVER");
		NativeFieldInfoPtr_UI_OBJECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "UI_OBJECT");
		NativeFieldInfoPtr_VALID_INDICATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "VALID_INDICATOR");
		NativeFieldInfoPtr_INVALID_INDICATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "INVALID_INDICATOR");
		NativeFieldInfoPtr_TERRAIN_COLLISION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "TERRAIN_COLLISION");
		NativeFieldInfoPtr_STAIRS_COLLIDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "STAIRS_COLLIDER");
		NativeFieldInfoPtr_defaultLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "defaultLayer");
		NativeFieldInfoPtr_environmentLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "environmentLayer");
		NativeFieldInfoPtr_terrainLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "terrainLayer");
		NativeFieldInfoPtr_regionLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "regionLayer");
		NativeFieldInfoPtr_terrainDetailsLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "terrainDetailsLayer");
		NativeFieldInfoPtr_waterLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "waterLayer");
		NativeFieldInfoPtr_noOutlineLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "noOutlineLayer");
		NativeFieldInfoPtr_maskableLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "maskableLayer");
		NativeFieldInfoPtr_obscureShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "obscureShown");
		NativeFieldInfoPtr_bushCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "bushCollider");
		NativeFieldInfoPtr_transparentFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "transparentFX");
		NativeFieldInfoPtr_caveLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "caveLayer");
		NativeFieldInfoPtr_stairsColliderLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "stairsColliderLayer");
		NativeFieldInfoPtr_selectedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "selectedLayer");
		NativeFieldInfoPtr_hitBoxLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "hitBoxLayer");
		NativeFieldInfoPtr_projectileLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "projectileLayer");
		NativeFieldInfoPtr_entityCapsule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "entityCapsule");
		NativeFieldInfoPtr_terrainAndWaterLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "terrainAndWaterLayerMask");
		NativeFieldInfoPtr_terrainAndCaveLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "terrainAndCaveLayerMask");
		NativeFieldInfoPtr_terrainAndWaterAndCaveLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectLayer>.NativeClassPtr, "terrainAndWaterAndCaveLayerMask");
	}

	public ObjectLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

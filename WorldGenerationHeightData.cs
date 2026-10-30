using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class WorldGenerationHeightData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_world;

	private static readonly System.IntPtr NativeFieldInfoPtr_coordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_startX;

	private static readonly System.IntPtr NativeFieldInfoPtr_startY;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightmapX;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightmapY;

	private static readonly System.IntPtr NativeFieldInfoPtr_xCoord;

	private static readonly System.IntPtr NativeFieldInfoPtr_yCoord;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseMinHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseMaxHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultHeight;

	public unsafe World world
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
		}
	}

	public unsafe Coordinates coordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates)) = coordinates;
		}
	}

	public unsafe Il2CppStructArray<float> terrainTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int startX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startX)) = num;
		}
	}

	public unsafe int startY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startY)) = num;
		}
	}

	public unsafe int heightmapX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapX)) = num;
		}
	}

	public unsafe int heightmapY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapY)) = num;
		}
	}

	public unsafe float xCoord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xCoord);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xCoord)) = num;
		}
	}

	public unsafe float yCoord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yCoord);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yCoord)) = num;
		}
	}

	public unsafe float baseMinHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMinHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMinHeight)) = num;
		}
	}

	public unsafe float baseMaxHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMaxHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMaxHeight)) = num;
		}
	}

	public unsafe float initialHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialHeight)) = num;
		}
	}

	public unsafe float resultHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultHeight)) = num;
		}
	}

	static WorldGenerationHeightData()
	{
		Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WorldGenerationHeightData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr);
		NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "world");
		NativeFieldInfoPtr_coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "coordinates");
		NativeFieldInfoPtr_terrainTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "terrainTypes");
		NativeFieldInfoPtr_startX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "startX");
		NativeFieldInfoPtr_startY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "startY");
		NativeFieldInfoPtr_heightmapX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "heightmapX");
		NativeFieldInfoPtr_heightmapY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "heightmapY");
		NativeFieldInfoPtr_xCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "xCoord");
		NativeFieldInfoPtr_yCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "yCoord");
		NativeFieldInfoPtr_baseMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "baseMinHeight");
		NativeFieldInfoPtr_baseMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "baseMaxHeight");
		NativeFieldInfoPtr_initialHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "initialHeight");
		NativeFieldInfoPtr_resultHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr, "resultHeight");
	}

	public WorldGenerationHeightData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public WorldGenerationHeightData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldGenerationHeightData>.NativeClassPtr))
	{
	}
}

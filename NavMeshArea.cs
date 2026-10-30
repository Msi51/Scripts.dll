using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class NavMeshArea : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_navMeshNotWalkableArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_navMeshWaterArea;

	private static readonly System.IntPtr NativeFieldInfoPtr_navMeshWaterAreaMask;

	public unsafe static int navMeshNotWalkableArea
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_navMeshNotWalkableArea, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_navMeshNotWalkableArea, (void*)(&num));
		}
	}

	public unsafe static int navMeshWaterArea
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_navMeshWaterArea, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_navMeshWaterArea, (void*)(&num));
		}
	}

	public unsafe static int navMeshWaterAreaMask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_navMeshWaterAreaMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_navMeshWaterAreaMask, (void*)(&num));
		}
	}

	static NavMeshArea()
	{
		Il2CppClassPointerStore<NavMeshArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NavMeshArea");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavMeshArea>.NativeClassPtr);
		NativeFieldInfoPtr_navMeshNotWalkableArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshArea>.NativeClassPtr, "navMeshNotWalkableArea");
		NativeFieldInfoPtr_navMeshWaterArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshArea>.NativeClassPtr, "navMeshWaterArea");
		NativeFieldInfoPtr_navMeshWaterAreaMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshArea>.NativeClassPtr, "navMeshWaterAreaMask");
	}

	public NavMeshArea(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

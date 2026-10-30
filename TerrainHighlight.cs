using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct TerrainHighlight
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	[FieldOffset(0)]
	public Vector3 position;

	[FieldOffset(12)]
	public Color color;

	[FieldOffset(28)]
	public float radius;

	static TerrainHighlight()
	{
		Il2CppClassPointerStore<TerrainHighlight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TerrainHighlight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainHighlight>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainHighlight>.NativeClassPtr, "position");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainHighlight>.NativeClassPtr, "color");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainHighlight>.NativeClassPtr, "radius");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainHighlight>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

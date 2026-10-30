using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct PaintInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_paintShape;

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_rectangleRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_rectangleRatio;

	[FieldOffset(0)]
	public PaintShape paintShape;

	[FieldOffset(4)]
	public float radius;

	[FieldOffset(8)]
	public Quaternion rectangleRotation;

	[FieldOffset(24)]
	public float rectangleRatio;

	static PaintInfo()
	{
		Il2CppClassPointerStore<PaintInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PaintInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaintInfo>.NativeClassPtr);
		NativeFieldInfoPtr_paintShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintInfo>.NativeClassPtr, "paintShape");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintInfo>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_rectangleRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintInfo>.NativeClassPtr, "rectangleRotation");
		NativeFieldInfoPtr_rectangleRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaintInfo>.NativeClassPtr, "rectangleRatio");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PaintInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

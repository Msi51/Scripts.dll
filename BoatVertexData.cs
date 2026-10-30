using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct BoatVertexData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_distance;

	private static readonly System.IntPtr NativeFieldInfoPtr_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_globalVertexPos;

	[FieldOffset(0)]
	public float distance;

	[FieldOffset(4)]
	public int index;

	[FieldOffset(8)]
	public Vector3 globalVertexPos;

	static BoatVertexData()
	{
		Il2CppClassPointerStore<BoatVertexData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "BoatVertexData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatVertexData>.NativeClassPtr);
		NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatVertexData>.NativeClassPtr, "distance");
		NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatVertexData>.NativeClassPtr, "index");
		NativeFieldInfoPtr_globalVertexPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatVertexData>.NativeClassPtr, "globalVertexPos");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoatVertexData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

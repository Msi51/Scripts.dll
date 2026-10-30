using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct GeneratedStructure
{
	private static readonly System.IntPtr NativeFieldInfoPtr_chunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	[FieldOffset(0)]
	public Coordinates chunkCoordinates;

	[FieldOffset(8)]
	public Vector3 position;

	static GeneratedStructure()
	{
		Il2CppClassPointerStore<GeneratedStructure>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GeneratedStructure");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedStructure>.NativeClassPtr);
		NativeFieldInfoPtr_chunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratedStructure>.NativeClassPtr, "chunkCoordinates");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratedStructure>.NativeClassPtr, "position");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GeneratedStructure>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

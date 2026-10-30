using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct CaveResourceDirection
{
	private static readonly System.IntPtr NativeFieldInfoPtr_direction;

	private static readonly System.IntPtr NativeFieldInfoPtr_testEdges;

	[FieldOffset(0)]
	public Vector3 direction;

	[FieldOffset(12)]
	[MarshalAs(UnmanagedType.U1)]
	public bool testEdges;

	static CaveResourceDirection()
	{
		Il2CppClassPointerStore<CaveResourceDirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CaveResourceDirection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaveResourceDirection>.NativeClassPtr);
		NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveResourceDirection>.NativeClassPtr, "direction");
		NativeFieldInfoPtr_testEdges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveResourceDirection>.NativeClassPtr, "testEdges");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CaveResourceDirection>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

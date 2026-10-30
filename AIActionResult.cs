using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct AIActionResult
{
	private static readonly System.IntPtr NativeFieldInfoPtr_success;

	private static readonly System.IntPtr NativeFieldInfoPtr_completed;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool success;

	[FieldOffset(1)]
	[MarshalAs(UnmanagedType.U1)]
	public bool completed;

	static AIActionResult()
	{
		Il2CppClassPointerStore<AIActionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AIActionResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIActionResult>.NativeClassPtr);
		NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionResult>.NativeClassPtr, "success");
		NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionResult>.NativeClassPtr, "completed");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AIActionResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

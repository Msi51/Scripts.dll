using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct ForCoordinatesCollection
{
	static ForCoordinatesCollection()
	{
		Il2CppClassPointerStore<ForCoordinatesCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ForCoordinatesCollection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForCoordinatesCollection>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForCoordinatesCollection>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

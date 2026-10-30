using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct ForClassList
{
	static ForClassList()
	{
		Il2CppClassPointerStore<ForClassList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ForClassList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForClassList>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForClassList>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

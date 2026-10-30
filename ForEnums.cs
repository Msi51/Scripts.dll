using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct ForEnums
{
	static ForEnums()
	{
		Il2CppClassPointerStore<ForEnums>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ForEnums");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForEnums>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ForEnums>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

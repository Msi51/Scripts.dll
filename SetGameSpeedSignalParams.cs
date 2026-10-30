using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct SetGameSpeedSignalParams
{
	private static readonly System.IntPtr NativeFieldInfoPtr_speed;

	[FieldOffset(0)]
	public GameSpeed speed;

	static SetGameSpeedSignalParams()
	{
		Il2CppClassPointerStore<SetGameSpeedSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SetGameSpeedSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetGameSpeedSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetGameSpeedSignalParams>.NativeClassPtr, "speed");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetGameSpeedSignalParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct GameSpeedChangedSignalParams
{
	private static readonly System.IntPtr NativeFieldInfoPtr_newGameSpeed;

	[FieldOffset(0)]
	public GameSpeed newGameSpeed;

	static GameSpeedChangedSignalParams()
	{
		Il2CppClassPointerStore<GameSpeedChangedSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GameSpeedChangedSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSpeedChangedSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_newGameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSpeedChangedSignalParams>.NativeClassPtr, "newGameSpeed");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameSpeedChangedSignalParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct NoiseMinMaxMultiplier
{
	private static readonly System.IntPtr NativeFieldInfoPtr_multiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplierInverse;

	[FieldOffset(0)]
	public float multiplier;

	[FieldOffset(4)]
	public float multiplierInverse;

	static NoiseMinMaxMultiplier()
	{
		Il2CppClassPointerStore<NoiseMinMaxMultiplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NoiseMinMaxMultiplier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseMinMaxMultiplier>.NativeClassPtr);
		NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseMinMaxMultiplier>.NativeClassPtr, "multiplier");
		NativeFieldInfoPtr_multiplierInverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseMinMaxMultiplier>.NativeClassPtr, "multiplierInverse");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NoiseMinMaxMultiplier>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

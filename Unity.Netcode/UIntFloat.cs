using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Netcode;

[StructLayout(LayoutKind.Explicit)]
public struct UIntFloat
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FloatValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_UIntValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_DoubleValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_ULongValue;

	[FieldOffset(0)]
	public float FloatValue;

	[FieldOffset(0)]
	public uint UIntValue;

	[FieldOffset(0)]
	public double DoubleValue;

	[FieldOffset(0)]
	public ulong ULongValue;

	static UIntFloat()
	{
		Il2CppClassPointerStore<UIntFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "UIntFloat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIntFloat>.NativeClassPtr);
		NativeFieldInfoPtr_FloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIntFloat>.NativeClassPtr, "FloatValue");
		NativeFieldInfoPtr_UIntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIntFloat>.NativeClassPtr, "UIntValue");
		NativeFieldInfoPtr_DoubleValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIntFloat>.NativeClassPtr, "DoubleValue");
		NativeFieldInfoPtr_ULongValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIntFloat>.NativeClassPtr, "ULongValue");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIntFloat>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

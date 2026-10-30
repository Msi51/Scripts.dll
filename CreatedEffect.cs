using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct CreatedEffect
{
	private static readonly System.IntPtr NativeFieldInfoPtr_effectType;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	[FieldOffset(0)]
	public EffectType effectType;

	[FieldOffset(4)]
	public Vector3 position;

	static CreatedEffect()
	{
		Il2CppClassPointerStore<CreatedEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreatedEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatedEffect>.NativeClassPtr);
		NativeFieldInfoPtr_effectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatedEffect>.NativeClassPtr, "effectType");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatedEffect>.NativeClassPtr, "position");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreatedEffect>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

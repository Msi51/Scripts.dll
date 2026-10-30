using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct PlayUISoundSignalParams
{
	private static readonly System.IntPtr NativeFieldInfoPtr_soundEffectType;

	private static readonly System.IntPtr NativeFieldInfoPtr_volumeScale;

	[FieldOffset(0)]
	public SoundEffectType soundEffectType;

	[FieldOffset(4)]
	public float volumeScale;

	static PlayUISoundSignalParams()
	{
		Il2CppClassPointerStore<PlayUISoundSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlayUISoundSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayUISoundSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_soundEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayUISoundSignalParams>.NativeClassPtr, "soundEffectType");
		NativeFieldInfoPtr_volumeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayUISoundSignalParams>.NativeClassPtr, "volumeScale");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayUISoundSignalParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

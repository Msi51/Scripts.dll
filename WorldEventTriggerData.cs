using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct WorldEventTriggerData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_initialDateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetDateTime;

	[FieldOffset(0)]
	public Il2CppSystem.DateTime initialDateTime;

	[FieldOffset(8)]
	public Il2CppSystem.DateTime targetDateTime;

	static WorldEventTriggerData()
	{
		Il2CppClassPointerStore<WorldEventTriggerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WorldEventTriggerData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldEventTriggerData>.NativeClassPtr);
		NativeFieldInfoPtr_initialDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventTriggerData>.NativeClassPtr, "initialDateTime");
		NativeFieldInfoPtr_targetDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldEventTriggerData>.NativeClassPtr, "targetDateTime");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldEventTriggerData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

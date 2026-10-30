using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct NetworkAnimatorStateInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stateHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalizedTime;

	[FieldOffset(0)]
	public int stateHash;

	[FieldOffset(4)]
	public float normalizedTime;

	static NetworkAnimatorStateInfo()
	{
		Il2CppClassPointerStore<NetworkAnimatorStateInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NetworkAnimatorStateInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkAnimatorStateInfo>.NativeClassPtr);
		NativeFieldInfoPtr_stateHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkAnimatorStateInfo>.NativeClassPtr, "stateHash");
		NativeFieldInfoPtr_normalizedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkAnimatorStateInfo>.NativeClassPtr, "normalizedTime");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkAnimatorStateInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct CanPickupResult
{
	private static readonly System.IntPtr NativeFieldInfoPtr_withHandheldUnequipped;

	private static readonly System.IntPtr NativeFieldInfoPtr_canPickup;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool withHandheldUnequipped;

	[FieldOffset(1)]
	[MarshalAs(UnmanagedType.U1)]
	public bool canPickup;

	static CanPickupResult()
	{
		Il2CppClassPointerStore<CanPickupResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CanPickupResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanPickupResult>.NativeClassPtr);
		NativeFieldInfoPtr_withHandheldUnequipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPickupResult>.NativeClassPtr, "withHandheldUnequipped");
		NativeFieldInfoPtr_canPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanPickupResult>.NativeClassPtr, "canPickup");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CanPickupResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

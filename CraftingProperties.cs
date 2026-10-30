using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct CraftingProperties
{
	private static readonly System.IntPtr NativeFieldInfoPtr_valid;

	private static readonly System.IntPtr NativeFieldInfoPtr_quantity;

	private static readonly System.IntPtr NativeFieldInfoPtr_condition;

	private static readonly System.IntPtr NativeFieldInfoPtr_quality;

	private static readonly System.IntPtr NativeFieldInfoPtr_contaminatedPercentage;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool valid;

	[FieldOffset(4)]
	public float quantity;

	[FieldOffset(8)]
	public float condition;

	[FieldOffset(12)]
	public float quality;

	[FieldOffset(16)]
	public float contaminatedPercentage;

	static CraftingProperties()
	{
		Il2CppClassPointerStore<CraftingProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CraftingProperties");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CraftingProperties>.NativeClassPtr);
		NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProperties>.NativeClassPtr, "valid");
		NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProperties>.NativeClassPtr, "quantity");
		NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProperties>.NativeClassPtr, "condition");
		NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProperties>.NativeClassPtr, "quality");
		NativeFieldInfoPtr_contaminatedPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CraftingProperties>.NativeClassPtr, "contaminatedPercentage");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CraftingProperties>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

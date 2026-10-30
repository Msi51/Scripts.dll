using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct CanCraftResult
{
	private static readonly System.IntPtr NativeFieldInfoPtr_canCraft;

	private static readonly System.IntPtr NativeFieldInfoPtr_recipeId;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool canCraft;

	[FieldOffset(4)]
	public int recipeId;

	static CanCraftResult()
	{
		Il2CppClassPointerStore<CanCraftResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CanCraftResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanCraftResult>.NativeClassPtr);
		NativeFieldInfoPtr_canCraft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanCraftResult>.NativeClassPtr, "canCraft");
		NativeFieldInfoPtr_recipeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanCraftResult>.NativeClassPtr, "recipeId");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CanCraftResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

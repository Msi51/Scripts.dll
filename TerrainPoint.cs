using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct TerrainPoint
{
	private static readonly System.IntPtr NativeFieldInfoPtr_chunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_i;

	private static readonly System.IntPtr NativeFieldInfoPtr_j;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Coordinates_Int32_Int32_0;

	[FieldOffset(0)]
	public Coordinates chunkCoordinates;

	[FieldOffset(8)]
	public int i;

	[FieldOffset(12)]
	public int j;

	static TerrainPoint()
	{
		Il2CppClassPointerStore<TerrainPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TerrainPoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainPoint>.NativeClassPtr);
		NativeFieldInfoPtr_chunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainPoint>.NativeClassPtr, "chunkCoordinates");
		NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainPoint>.NativeClassPtr, "i");
		NativeFieldInfoPtr_j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainPoint>.NativeClassPtr, "j");
		NativeMethodInfoPtr__ctor_Public_Void_Coordinates_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainPoint>.NativeClassPtr, 100683381);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 261423, RefRangeEnd = 261429, XrefRangeStart = 261423, XrefRangeEnd = 261423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainPoint(Coordinates chunkCoordinates, int i, int j)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&chunkCoordinates);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Coordinates_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainPoint>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct QueuedClearedSnowPaint
{
	private static readonly System.IntPtr NativeFieldInfoPtr_otherChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_z;

	private static readonly System.IntPtr NativeFieldInfoPtr_opacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_decreaseAtEdges;

	private static readonly System.IntPtr NativeFieldInfoPtr_capStrength;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxOpacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintInfo;

	[FieldOffset(0)]
	public Coordinates otherChunkCoordinates;

	[FieldOffset(8)]
	public float x;

	[FieldOffset(12)]
	public float z;

	[FieldOffset(16)]
	public float opacity;

	[FieldOffset(20)]
	[MarshalAs(UnmanagedType.U1)]
	public bool decreaseAtEdges;

	[FieldOffset(21)]
	[MarshalAs(UnmanagedType.U1)]
	public bool capStrength;

	[FieldOffset(24)]
	public float maxOpacity;

	[FieldOffset(28)]
	public PaintInfo paintInfo;

	static QueuedClearedSnowPaint()
	{
		Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "QueuedClearedSnowPaint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr);
		NativeFieldInfoPtr_otherChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr, "otherChunkCoordinates");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr, "x");
		NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr, "z");
		NativeFieldInfoPtr_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr, "opacity");
		NativeFieldInfoPtr_decreaseAtEdges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr, "decreaseAtEdges");
		NativeFieldInfoPtr_capStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr, "capStrength");
		NativeFieldInfoPtr_maxOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr, "maxOpacity");
		NativeFieldInfoPtr_paintInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr, "paintInfo");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueuedClearedSnowPaint>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct QueuedTextureRectanglePaint
{
	private static readonly System.IntPtr NativeFieldInfoPtr_otherChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_z;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureType;

	private static readonly System.IntPtr NativeFieldInfoPtr_opacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_angle;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearTerrainTypes;

	[FieldOffset(0)]
	public Coordinates otherChunkCoordinates;

	[FieldOffset(8)]
	public float x;

	[FieldOffset(12)]
	public float z;

	[FieldOffset(16)]
	public TextureType textureType;

	[FieldOffset(20)]
	public float opacity;

	[FieldOffset(24)]
	public float angle;

	[FieldOffset(28)]
	public float width;

	[FieldOffset(32)]
	public float height;

	[FieldOffset(36)]
	[MarshalAs(UnmanagedType.U1)]
	public bool clearTerrainTypes;

	static QueuedTextureRectanglePaint()
	{
		Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "QueuedTextureRectanglePaint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr);
		NativeFieldInfoPtr_otherChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr, "otherChunkCoordinates");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr, "x");
		NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr, "z");
		NativeFieldInfoPtr_textureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr, "textureType");
		NativeFieldInfoPtr_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr, "opacity");
		NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr, "angle");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr, "width");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr, "height");
		NativeFieldInfoPtr_clearTerrainTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr, "clearTerrainTypes");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueuedTextureRectanglePaint>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

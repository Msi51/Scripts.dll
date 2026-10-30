using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct BoatTriangleData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_p1;

	private static readonly System.IntPtr NativeFieldInfoPtr_p2;

	private static readonly System.IntPtr NativeFieldInfoPtr_p3;

	private static readonly System.IntPtr NativeFieldInfoPtr_center;

	private static readonly System.IntPtr NativeFieldInfoPtr_normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_area;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_0;

	[FieldOffset(0)]
	public Vector3 p1;

	[FieldOffset(12)]
	public Vector3 p2;

	[FieldOffset(24)]
	public Vector3 p3;

	[FieldOffset(36)]
	public Vector3 center;

	[FieldOffset(48)]
	public Vector3 normal;

	[FieldOffset(60)]
	public float area;

	static BoatTriangleData()
	{
		Il2CppClassPointerStore<BoatTriangleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "BoatTriangleData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoatTriangleData>.NativeClassPtr);
		NativeFieldInfoPtr_p1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatTriangleData>.NativeClassPtr, "p1");
		NativeFieldInfoPtr_p2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatTriangleData>.NativeClassPtr, "p2");
		NativeFieldInfoPtr_p3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatTriangleData>.NativeClassPtr, "p3");
		NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatTriangleData>.NativeClassPtr, "center");
		NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatTriangleData>.NativeClassPtr, "normal");
		NativeFieldInfoPtr_area = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoatTriangleData>.NativeClassPtr, "area");
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoatTriangleData>.NativeClassPtr, 100678741);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 227551, RefRangeEnd = 227558, XrefRangeStart = 227531, XrefRangeEnd = 227551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoatTriangleData(Vector3 p1, Vector3 p2, Vector3 p3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&p1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &p3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoatTriangleData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

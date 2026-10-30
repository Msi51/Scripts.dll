using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct CaveNode
{
	private static readonly System.IntPtr NativeFieldInfoPtr_worldPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveRelativePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	private static readonly System.IntPtr NativeMethodInfoPtr_FileSerialize_Public_Virtual_Final_New_Void_FileBinarySerializer_0;

	[FieldOffset(0)]
	public Vector3 worldPosition;

	[FieldOffset(12)]
	public Vector3 worldDirection;

	[FieldOffset(24)]
	public Vector3 caveRelativePosition;

	[FieldOffset(36)]
	public float radius;

	static CaveNode()
	{
		Il2CppClassPointerStore<CaveNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CaveNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaveNode>.NativeClassPtr);
		NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveNode>.NativeClassPtr, "worldPosition");
		NativeFieldInfoPtr_worldDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveNode>.NativeClassPtr, "worldDirection");
		NativeFieldInfoPtr_caveRelativePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveNode>.NativeClassPtr, "caveRelativePosition");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveNode>.NativeClassPtr, "radius");
		NativeMethodInfoPtr_FileSerialize_Public_Virtual_Final_New_Void_FileBinarySerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveNode>.NativeClassPtr, 100668613);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 96113, RefRangeEnd = 96115, XrefRangeStart = 96107, XrefRangeEnd = 96113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void FileSerialize(FileBinarySerializer serializer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FileSerialize_Public_Virtual_Final_New_Void_FileBinarySerializer_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CaveNode>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

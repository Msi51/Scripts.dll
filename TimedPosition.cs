using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct TimedPosition
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_startTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_duration;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Single_0;

	[FieldOffset(0)]
	public Vector3 position;

	[FieldOffset(12)]
	public float startTime;

	[FieldOffset(16)]
	public float duration;

	static TimedPosition()
	{
		Il2CppClassPointerStore<TimedPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TimedPosition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedPosition>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedPosition>.NativeClassPtr, "position");
		NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedPosition>.NativeClassPtr, "startTime");
		NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedPosition>.NativeClassPtr, "duration");
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedPosition>.NativeClassPtr, 100668572);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95019, RefRangeEnd = 95020, XrefRangeStart = 95019, XrefRangeEnd = 95019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimedPosition(Vector3 position, float startTime, float duration)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startTime;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &duration;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimedPosition>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Netcode;

[StructLayout(LayoutKind.Explicit)]
public struct ByteBool
{
	private static readonly System.IntPtr NativeFieldInfoPtr_BoolValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_ByteValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_Collapse_Public_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Collapse_Public_Byte_Boolean_0;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool BoolValue;

	[FieldOffset(0)]
	public byte ByteValue;

	static ByteBool()
	{
		Il2CppClassPointerStore<ByteBool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "ByteBool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteBool>.NativeClassPtr);
		NativeFieldInfoPtr_BoolValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteBool>.NativeClassPtr, "BoolValue");
		NativeFieldInfoPtr_ByteValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteBool>.NativeClassPtr, "ByteValue");
		NativeMethodInfoPtr_Collapse_Public_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteBool>.NativeClassPtr, 100686239);
		NativeMethodInfoPtr_Collapse_Public_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteBool>.NativeClassPtr, 100686240);
	}

	[CallerCount(0)]
	public unsafe byte Collapse()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Collapse_Public_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 290967, RefRangeEnd = 290968, XrefRangeStart = 290967, XrefRangeEnd = 290967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe byte Collapse(bool b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Collapse_Public_Byte_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ByteBool>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

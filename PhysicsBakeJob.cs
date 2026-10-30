using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

[StructLayout(LayoutKind.Explicit)]
public struct PhysicsBakeJob
{
	private static readonly System.IntPtr NativeFieldInfoPtr_meshId;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

	[FieldOffset(0)]
	public readonly int meshId;

	static PhysicsBakeJob()
	{
		Il2CppClassPointerStore<PhysicsBakeJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PhysicsBakeJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsBakeJob>.NativeClassPtr);
		NativeFieldInfoPtr_meshId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsBakeJob>.NativeClassPtr, "meshId");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsBakeJob>.NativeClassPtr, 100673858);
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsBakeJob>.NativeClassPtr, 100673859);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 25738, RefRangeEnd = 25757, XrefRangeStart = 25738, XrefRangeEnd = 25757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhysicsBakeJob(int meshId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&meshId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 144903, RefRangeEnd = 144904, XrefRangeStart = 144902, XrefRangeEnd = 144903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsBakeJob>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

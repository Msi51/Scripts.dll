using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;

[StructLayout(LayoutKind.Explicit)]
public struct InventorySlotIndex
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_valid;

	private static readonly System.IntPtr NativeFieldInfoPtr_sectionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_immediateSlotIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentSlotIndex1;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentSlotIndex2;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool valid;

	[FieldOffset(4)]
	public InventorySectionType sectionType;

	[FieldOffset(8)]
	public int immediateSlotIndex;

	[FieldOffset(12)]
	public int parentSlotIndex1;

	[FieldOffset(16)]
	public int parentSlotIndex2;

	static InventorySlotIndex()
	{
		Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InventorySlotIndex");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr);
		NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr, "valid");
		NativeFieldInfoPtr_sectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr, "sectionType");
		NativeFieldInfoPtr_immediateSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr, "immediateSlotIndex");
		NativeFieldInfoPtr_parentSlotIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr, "parentSlotIndex1");
		NativeFieldInfoPtr_parentSlotIndex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr, "parentSlotIndex2");
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr, 100673503);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr, 100673504);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141942, XrefRangeEnd = 141971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 141977, RefRangeEnd = 141978, XrefRangeStart = 141971, XrefRangeEnd = 141977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventorySlotIndex>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

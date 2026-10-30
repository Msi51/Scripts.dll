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
public struct MoveItemStackEventParams
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_moverEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_fromInventoryEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_toInventoryEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_fromSlotIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_toSlotIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_noToSlotIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_movedAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_allItems;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	[FieldOffset(0)]
	public int moverEntityId;

	[FieldOffset(4)]
	public int fromInventoryEntityId;

	[FieldOffset(8)]
	public int toInventoryEntityId;

	[FieldOffset(12)]
	public InventorySlotIndex fromSlotIndex;

	[FieldOffset(32)]
	public InventorySlotIndex toSlotIndex;

	[FieldOffset(52)]
	[MarshalAs(UnmanagedType.U1)]
	public bool noToSlotIndex;

	[FieldOffset(56)]
	public int movedAmount;

	[FieldOffset(60)]
	[MarshalAs(UnmanagedType.U1)]
	public bool allItems;

	static MoveItemStackEventParams()
	{
		Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MoveItemStackEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_moverEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr, "moverEntityId");
		NativeFieldInfoPtr_fromInventoryEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr, "fromInventoryEntityId");
		NativeFieldInfoPtr_toInventoryEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr, "toInventoryEntityId");
		NativeFieldInfoPtr_fromSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr, "fromSlotIndex");
		NativeFieldInfoPtr_toSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr, "toSlotIndex");
		NativeFieldInfoPtr_noToSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr, "noToSlotIndex");
		NativeFieldInfoPtr_movedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr, "movedAmount");
		NativeFieldInfoPtr_allItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr, "allItems");
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr, 100670083);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112941, XrefRangeEnd = 112949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveItemStackEventParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

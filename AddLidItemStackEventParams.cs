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
public struct AddLidItemStackEventParams
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<AddLidItemStackEventParams>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_moverEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_slotInventoryEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_slotIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lidInventoryEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_lidItemIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	[FieldOffset(0)]
	public int moverEntityId;

	[FieldOffset(4)]
	public int slotInventoryEntityId;

	[FieldOffset(8)]
	public InventorySlotIndex slotIndex;

	[FieldOffset(28)]
	public int lidInventoryEntityId;

	[FieldOffset(32)]
	public InventorySlotIndex lidItemIndex;

	static AddLidItemStackEventParams()
	{
		Il2CppClassPointerStore<AddLidItemStackEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AddLidItemStackEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddLidItemStackEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_moverEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddLidItemStackEventParams>.NativeClassPtr, "moverEntityId");
		NativeFieldInfoPtr_slotInventoryEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddLidItemStackEventParams>.NativeClassPtr, "slotInventoryEntityId");
		NativeFieldInfoPtr_slotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddLidItemStackEventParams>.NativeClassPtr, "slotIndex");
		NativeFieldInfoPtr_lidInventoryEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddLidItemStackEventParams>.NativeClassPtr, "lidInventoryEntityId");
		NativeFieldInfoPtr_lidItemIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddLidItemStackEventParams>.NativeClassPtr, "lidItemIndex");
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddLidItemStackEventParams>.NativeClassPtr, 100669899);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108242, XrefRangeEnd = 108247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddLidItemStackEventParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

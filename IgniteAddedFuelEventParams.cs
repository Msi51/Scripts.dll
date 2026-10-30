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
public struct IgniteAddedFuelEventParams
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<IgniteAddedFuelEventParams>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_fuelEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_igniterEntityId;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	[FieldOffset(0)]
	public int fuelEntityId;

	[FieldOffset(4)]
	public int igniterEntityId;

	static IgniteAddedFuelEventParams()
	{
		Il2CppClassPointerStore<IgniteAddedFuelEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IgniteAddedFuelEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgniteAddedFuelEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_fuelEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteAddedFuelEventParams>.NativeClassPtr, "fuelEntityId");
		NativeFieldInfoPtr_igniterEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteAddedFuelEventParams>.NativeClassPtr, "igniterEntityId");
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAddedFuelEventParams>.NativeClassPtr, 100663459);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4045, RefRangeEnd = 4046, XrefRangeStart = 4045, XrefRangeEnd = 4046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IgniteAddedFuelEventParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

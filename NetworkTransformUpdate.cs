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
using UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct NetworkTransformUpdate
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_POSITION_BIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ROTATION_BIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateBits;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasPosition_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasRotation_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	[FieldOffset(0)]
	public Vector3 position;

	[FieldOffset(12)]
	public Quaternion rotation;

	[FieldOffset(28)]
	public byte updateBits;

	public unsafe static int POSITION_BIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_POSITION_BIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_POSITION_BIT, (void*)(&num));
		}
	}

	public unsafe static int ROTATION_BIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ROTATION_BIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ROTATION_BIT, (void*)(&num));
		}
	}

	public unsafe bool HasPosition
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24066, RefRangeEnd = 24067, XrefRangeStart = 24066, XrefRangeEnd = 24066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasPosition_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasRotation
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24067, RefRangeEnd = 24069, XrefRangeStart = 24067, XrefRangeEnd = 24067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasRotation_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static NetworkTransformUpdate()
	{
		Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NetworkTransformUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr);
		NativeFieldInfoPtr_POSITION_BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr, "POSITION_BIT");
		NativeFieldInfoPtr_ROTATION_BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr, "ROTATION_BIT");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr, "position");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_updateBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr, "updateBits");
		NativeMethodInfoPtr_get_HasPosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_get_HasRotation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr, 100663839);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24069, XrefRangeEnd = 24087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkTransformUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

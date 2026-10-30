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
public struct NetworkEntityMovementUpdate
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_HOST_TIME_BIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_VELOCITY_BIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_INPUT_SPEED_PERCENTAGE_BIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_estimatedHostTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_velocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputSpeedPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateBits;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasHostTime_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasVelocity_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasInputSpeedPercentage_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	[FieldOffset(0)]
	public float estimatedHostTime;

	[FieldOffset(4)]
	public Vector3 position;

	[FieldOffset(16)]
	public Vector3 velocity;

	[FieldOffset(28)]
	public float inputSpeedPercentage;

	[FieldOffset(32)]
	public byte updateBits;

	public unsafe static int HOST_TIME_BIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HOST_TIME_BIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HOST_TIME_BIT, (void*)(&num));
		}
	}

	public unsafe static int VELOCITY_BIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VELOCITY_BIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VELOCITY_BIT, (void*)(&num));
		}
	}

	public unsafe static int INPUT_SPEED_PERCENTAGE_BIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INPUT_SPEED_PERCENTAGE_BIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INPUT_SPEED_PERCENTAGE_BIT, (void*)(&num));
		}
	}

	public unsafe bool HasHostTime
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23805, RefRangeEnd = 23806, XrefRangeStart = 23805, XrefRangeEnd = 23806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasHostTime_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasVelocity
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23806, RefRangeEnd = 23807, XrefRangeStart = 23806, XrefRangeEnd = 23807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasVelocity_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasInputSpeedPercentage
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23807, RefRangeEnd = 23809, XrefRangeStart = 23807, XrefRangeEnd = 23809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasInputSpeedPercentage_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static NetworkEntityMovementUpdate()
	{
		Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NetworkEntityMovementUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr);
		NativeFieldInfoPtr_HOST_TIME_BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, "HOST_TIME_BIT");
		NativeFieldInfoPtr_VELOCITY_BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, "VELOCITY_BIT");
		NativeFieldInfoPtr_INPUT_SPEED_PERCENTAGE_BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, "INPUT_SPEED_PERCENTAGE_BIT");
		NativeFieldInfoPtr_estimatedHostTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, "estimatedHostTime");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, "position");
		NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, "velocity");
		NativeFieldInfoPtr_inputSpeedPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, "inputSpeedPercentage");
		NativeFieldInfoPtr_updateBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, "updateBits");
		NativeMethodInfoPtr_get_HasHostTime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr_get_HasVelocity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_get_HasInputSpeedPercentage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, 100663825);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, 100663826);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23943, XrefRangeEnd = 23982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkEntityMovementUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}

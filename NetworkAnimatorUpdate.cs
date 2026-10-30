using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Netcode;
using UnityEngine;

public sealed class NetworkAnimatorUpdate : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_STATE_INFO_BIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOOK_DIRECTION_BIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_FLOAT_VALUES_BIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_floatValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateBits;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasStateInfo_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasLookDirection_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasFloatValues_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe static int STATE_INFO_BIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STATE_INFO_BIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STATE_INFO_BIT, (void*)(&num));
		}
	}

	public unsafe static int LOOK_DIRECTION_BIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOOK_DIRECTION_BIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOOK_DIRECTION_BIT, (void*)(&num));
		}
	}

	public unsafe static int FLOAT_VALUES_BIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FLOAT_VALUES_BIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FLOAT_VALUES_BIT, (void*)(&num));
		}
	}

	public unsafe NetworkAnimatorStateInfo stateInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateInfo);
			return *(NetworkAnimatorStateInfo*)num;
		}
		set
		{
			*(NetworkAnimatorStateInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateInfo)) = networkAnimatorStateInfo;
		}
	}

	public unsafe Vector3 lookDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookDirection)) = vector;
		}
	}

	public unsafe List<Il2CppSystem.ValueTuple<int, float>> floatValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floatValues);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<int, float>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floatValues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe byte updateBits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateBits);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateBits)) = b;
		}
	}

	public unsafe bool HasStateInfo
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23805, RefRangeEnd = 23806, XrefRangeStart = 23805, XrefRangeEnd = 23805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasStateInfo_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasLookDirection
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23806, RefRangeEnd = 23807, XrefRangeStart = 23806, XrefRangeEnd = 23806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasLookDirection_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool HasFloatValues
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23807, RefRangeEnd = 23809, XrefRangeStart = 23807, XrefRangeEnd = 23807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasFloatValues_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static NetworkAnimatorUpdate()
	{
		Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NetworkAnimatorUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr);
		NativeFieldInfoPtr_STATE_INFO_BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, "STATE_INFO_BIT");
		NativeFieldInfoPtr_LOOK_DIRECTION_BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, "LOOK_DIRECTION_BIT");
		NativeFieldInfoPtr_FLOAT_VALUES_BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, "FLOAT_VALUES_BIT");
		NativeFieldInfoPtr_stateInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, "stateInfo");
		NativeFieldInfoPtr_lookDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, "lookDirection");
		NativeFieldInfoPtr_floatValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, "floatValues");
		NativeFieldInfoPtr_updateBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, "updateBits");
		NativeMethodInfoPtr_get_HasStateInfo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, 100663798);
		NativeMethodInfoPtr_get_HasLookDirection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, 100663799);
		NativeMethodInfoPtr_get_HasFloatValues_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, 100663800);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr, 100663801);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23809, XrefRangeEnd = 23899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NetworkAnimatorUpdate(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public NetworkAnimatorUpdate()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkAnimatorUpdate>.NativeClassPtr))
	{
	}
}

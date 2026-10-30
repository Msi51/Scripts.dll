using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;
using UnityEngine;

public class AttackProjectileEffect : BaseParamsResultInteractionEffect<AttackProjectileEffect.AttackProjectileEffectParams, AttackProjectileEffect.AttackProjectileEffectResult>
{
	[StructLayout(LayoutKind.Explicit)]
	public struct AttackProjectileEffectParams
	{
		private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<AttackProjectileEffectParams>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_projectileStackIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_targetPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_targetDirection;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraDirection;

		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

		[FieldOffset(0)]
		public InventorySlotIndex projectileStackIndex;

		[FieldOffset(20)]
		public Vector3 targetPosition;

		[FieldOffset(32)]
		public Vector3 targetDirection;

		[FieldOffset(44)]
		public Vector3 cameraDirection;

		static AttackProjectileEffectParams()
		{
			Il2CppClassPointerStore<AttackProjectileEffectParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, "AttackProjectileEffectParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackProjectileEffectParams>.NativeClassPtr);
			NativeFieldInfoPtr_projectileStackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackProjectileEffectParams>.NativeClassPtr, "projectileStackIndex");
			NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackProjectileEffectParams>.NativeClassPtr, "targetPosition");
			NativeFieldInfoPtr_targetDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackProjectileEffectParams>.NativeClassPtr, "targetDirection");
			NativeFieldInfoPtr_cameraDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackProjectileEffectParams>.NativeClassPtr, "cameraDirection");
			NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffectParams>.NativeClassPtr, 100671030);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124710, XrefRangeEnd = 124714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttackProjectileEffectParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct AttackProjectileEffectResult
	{
		private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<AttackProjectileEffectResult>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_success;

		private static readonly System.IntPtr NativeFieldInfoPtr_soundEffect;

		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool success;

		[FieldOffset(4)]
		public SoundEffectType soundEffect;

		static AttackProjectileEffectResult()
		{
			Il2CppClassPointerStore<AttackProjectileEffectResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, "AttackProjectileEffectResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackProjectileEffectResult>.NativeClassPtr);
			NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackProjectileEffectResult>.NativeClassPtr, "success");
			NativeFieldInfoPtr_soundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackProjectileEffectResult>.NativeClassPtr, "soundEffect");
			NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffectResult>.NativeClassPtr, 100671031);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttackProjectileEffectResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__spawnManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__networkManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__aiManager_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spawnManager_Public_get_ISpawnManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_spawnManager_Public_set_Void_ISpawnManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_networkManager_Public_get_INetworkManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_networkManager_Public_set_Void_INetworkManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_aiManager_Public_get_IAIManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_aiManager_Public_set_Void_IAIManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllowClientRequests_Public_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteResult_Public_Virtual_AttackProjectileEffectResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getProjectileLaunchDirection_Private_Vector3_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ISpawnManager _spawnManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spawnManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISpawnManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__spawnManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnManager));
		}
	}

	public unsafe INetworkManager _networkManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__networkManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<INetworkManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__networkManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkManager));
		}
	}

	public unsafe IAIManager _aiManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__aiManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAIManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__aiManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)iAIManager));
		}
	}

	public unsafe ISpawnManager spawnManager
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 30821, RefRangeEnd = 30837, XrefRangeStart = 30821, XrefRangeEnd = 30837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spawnManager_Public_get_ISpawnManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISpawnManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_spawnManager_Public_set_Void_ISpawnManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe INetworkManager networkManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96991, RefRangeEnd = 96992, XrefRangeStart = 96991, XrefRangeEnd = 96992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_networkManager_Public_get_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<INetworkManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_networkManager_Public_set_Void_INetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IAIManager aiManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aiManager_Public_get_IAIManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IAIManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_aiManager_Public_set_Void_IAIManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static AttackProjectileEffect()
	{
		Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AttackProjectileEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr);
		NativeFieldInfoPtr__spawnManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, "<spawnManager>k__BackingField");
		NativeFieldInfoPtr__networkManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, "<networkManager>k__BackingField");
		NativeFieldInfoPtr__aiManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, "<aiManager>k__BackingField");
		NativeMethodInfoPtr_get_spawnManager_Public_get_ISpawnManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671019);
		NativeMethodInfoPtr_set_spawnManager_Public_set_Void_ISpawnManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671020);
		NativeMethodInfoPtr_get_networkManager_Public_get_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671021);
		NativeMethodInfoPtr_set_networkManager_Public_set_Void_INetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671022);
		NativeMethodInfoPtr_get_aiManager_Public_get_IAIManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671023);
		NativeMethodInfoPtr_set_aiManager_Public_set_Void_IAIManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671024);
		NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671025);
		NativeMethodInfoPtr_AllowClientRequests_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671026);
		NativeMethodInfoPtr_ExecuteResult_Public_Virtual_AttackProjectileEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671027);
		NativeMethodInfoPtr_getProjectileLaunchDirection_Private_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671028);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr, 100671029);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122147, RefRangeEnd = 122149, XrefRangeStart = 122147, XrefRangeEnd = 122149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override InteractionEffectType GetEffectType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 44231, RefRangeEnd = 44249, XrefRangeStart = 44231, XrefRangeEnd = 44249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool AllowClientRequests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AllowClientRequests_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124714, XrefRangeEnd = 124887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override AttackProjectileEffectResult ExecuteResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ExecuteResult_Public_Virtual_AttackProjectileEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AttackProjectileEffectResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124887, XrefRangeEnd = 124892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 getProjectileLaunchDirection(Vector3 fromPosition, Vector3 toPosition, float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&fromPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toPosition;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getProjectileLaunchDirection_Private_Vector3_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124892, XrefRangeEnd = 124895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AttackProjectileEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackProjectileEffect>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AttackProjectileEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

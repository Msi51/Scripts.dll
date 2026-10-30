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

public class PlaceTerrainEffect : BaseParamsResultInteractionEffect<PlaceTerrainEffect.PlaceTerrainEffectParams, PlaceTerrainEffect.PlaceTerrainEffectResult>
{
	[StructLayout(LayoutKind.Explicit)]
	public struct PlaceTerrainEffectParams
	{
		private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<PlaceTerrainEffectParams>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_position;

		private static readonly System.IntPtr NativeFieldInfoPtr_terrainItemId;

		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

		[FieldOffset(0)]
		public Vector3 position;

		[FieldOffset(12)]
		public int terrainItemId;

		static PlaceTerrainEffectParams()
		{
			Il2CppClassPointerStore<PlaceTerrainEffectParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, "PlaceTerrainEffectParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceTerrainEffectParams>.NativeClassPtr);
			NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTerrainEffectParams>.NativeClassPtr, "position");
			NativeFieldInfoPtr_terrainItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTerrainEffectParams>.NativeClassPtr, "terrainItemId");
			NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffectParams>.NativeClassPtr, 100671380);
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
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaceTerrainEffectParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PlaceTerrainEffectResult
	{
		private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<PlaceTerrainEffectResult>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_success;

		private static readonly System.IntPtr NativeFieldInfoPtr_effectType;

		private static readonly System.IntPtr NativeFieldInfoPtr_effectPosition;

		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool success;

		[FieldOffset(4)]
		public EffectType effectType;

		[FieldOffset(8)]
		public Vector3 effectPosition;

		static PlaceTerrainEffectResult()
		{
			Il2CppClassPointerStore<PlaceTerrainEffectResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, "PlaceTerrainEffectResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceTerrainEffectResult>.NativeClassPtr);
			NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTerrainEffectResult>.NativeClassPtr, "success");
			NativeFieldInfoPtr_effectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTerrainEffectResult>.NativeClassPtr, "effectType");
			NativeFieldInfoPtr_effectPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTerrainEffectResult>.NativeClassPtr, "effectPosition");
			NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffectResult>.NativeClassPtr, 100671381);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127389, XrefRangeEnd = 127392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaceTerrainEffectResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__gameEventManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__placeTerrainSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__inventoryManager_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gameEventManager_Public_get_IGameEventManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_gameEventManager_Public_set_Void_IGameEventManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_placeTerrainSignal_Public_get_PlaceTerrainSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_placeTerrainSignal_Public_set_Void_PlaceTerrainSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inventoryManager_Public_get_IInventoryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_inventoryManager_Public_set_Void_IInventoryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteResult_Public_Virtual_PlaceTerrainEffectResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnExecuted_Protected_Virtual_Void_PlaceTerrainEffectResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe IGameEventManager _gameEventManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameEventManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameEventManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__gameEventManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager));
		}
	}

	public unsafe PlaceTerrainSignal _placeTerrainSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__placeTerrainSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlaceTerrainSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__placeTerrainSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placeTerrainSignal));
		}
	}

	public unsafe IInventoryManager _inventoryManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inventoryManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inventoryManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager));
		}
	}

	public unsafe IGameEventManager gameEventManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97543, RefRangeEnd = 97544, XrefRangeStart = 97543, XrefRangeEnd = 97544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gameEventManager_Public_get_IGameEventManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameEventManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gameEventManager_Public_set_Void_IGameEventManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe PlaceTerrainSignal placeTerrainSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_placeTerrainSignal_Public_get_PlaceTerrainSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlaceTerrainSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_placeTerrainSignal_Public_set_Void_PlaceTerrainSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IInventoryManager inventoryManager
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 32262, RefRangeEnd = 32263, XrefRangeStart = 32262, XrefRangeEnd = 32263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inventoryManager_Public_get_IInventoryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_inventoryManager_Public_set_Void_IInventoryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static PlaceTerrainEffect()
	{
		Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlaceTerrainEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr);
		NativeFieldInfoPtr__gameEventManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, "<gameEventManager>k__BackingField");
		NativeFieldInfoPtr__placeTerrainSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, "<placeTerrainSignal>k__BackingField");
		NativeFieldInfoPtr__inventoryManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, "<inventoryManager>k__BackingField");
		NativeMethodInfoPtr_get_gameEventManager_Public_get_IGameEventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, 100671370);
		NativeMethodInfoPtr_set_gameEventManager_Public_set_Void_IGameEventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, 100671371);
		NativeMethodInfoPtr_get_placeTerrainSignal_Public_get_PlaceTerrainSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, 100671372);
		NativeMethodInfoPtr_set_placeTerrainSignal_Public_set_Void_PlaceTerrainSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, 100671373);
		NativeMethodInfoPtr_get_inventoryManager_Public_get_IInventoryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, 100671374);
		NativeMethodInfoPtr_set_inventoryManager_Public_set_Void_IInventoryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, 100671375);
		NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, 100671376);
		NativeMethodInfoPtr_ExecuteResult_Public_Virtual_PlaceTerrainEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, 100671377);
		NativeMethodInfoPtr_OnExecuted_Protected_Virtual_Void_PlaceTerrainEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, 100671378);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr, 100671379);
	}

	[CallerCount(0)]
	public unsafe override InteractionEffectType GetEffectType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127392, XrefRangeEnd = 127412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override PlaceTerrainEffectResult ExecuteResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ExecuteResult_Public_Virtual_PlaceTerrainEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(PlaceTerrainEffectResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127412, XrefRangeEnd = 127419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnExecuted(PlaceTerrainEffectResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnExecuted_Protected_Virtual_Void_PlaceTerrainEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127419, XrefRangeEnd = 127422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlaceTerrainEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceTerrainEffect>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlaceTerrainEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

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

public class IgniteAttemptEffect : BaseParamsResultInteractionEffect<IgniteAttemptEffect.IgniteAttemptEffectParams, IgniteAttemptEffect.IgniteAttemptEffectResult>
{
	[StructLayout(LayoutKind.Explicit)]
	public struct IgniteAttemptEffectParams
	{
		private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<IgniteAttemptEffectParams>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_igniteChanceResult;

		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

		[FieldOffset(0)]
		public IgniteChanceResult igniteChanceResult;

		static IgniteAttemptEffectParams()
		{
			Il2CppClassPointerStore<IgniteAttemptEffectParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, "IgniteAttemptEffectParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgniteAttemptEffectParams>.NativeClassPtr);
			NativeFieldInfoPtr_igniteChanceResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteAttemptEffectParams>.NativeClassPtr, "igniteChanceResult");
			NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffectParams>.NativeClassPtr, 100671233);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126259, XrefRangeEnd = 126260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IgniteAttemptEffectParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct IgniteAttemptEffectResult
	{
		private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<IgniteAttemptEffectResult>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_success;

		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool success;

		static IgniteAttemptEffectResult()
		{
			Il2CppClassPointerStore<IgniteAttemptEffectResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, "IgniteAttemptEffectResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgniteAttemptEffectResult>.NativeClassPtr);
			NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteAttemptEffectResult>.NativeClassPtr, "success");
			NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffectResult>.NativeClassPtr, 100671234);
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
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IgniteAttemptEffectResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__showMessageOnObjectSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__gameEventManager_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showMessageOnObjectSignal_Public_get_ShowMessageOnObjectSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_showMessageOnObjectSignal_Public_set_Void_ShowMessageOnObjectSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fuelIgnitedSignal_Public_get_FuelIgnitedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fuelIgnitedSignal_Public_set_Void_FuelIgnitedSignal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gameEventManager_Public_get_IGameEventManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_gameEventManager_Public_set_Void_IGameEventManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteResult_Public_Virtual_IgniteAttemptEffectResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnExecuted_Protected_Virtual_Void_IgniteAttemptEffectResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ShowMessageOnObjectSignal _showMessageOnObjectSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showMessageOnObjectSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowMessageOnObjectSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showMessageOnObjectSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showMessageOnObjectSignal));
		}
	}

	public unsafe FuelIgnitedSignal _fuelIgnitedSignal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FuelIgnitedSignal>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fuelIgnitedSignal));
		}
	}

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

	public unsafe ShowMessageOnObjectSignal showMessageOnObjectSignal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showMessageOnObjectSignal_Public_get_ShowMessageOnObjectSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ShowMessageOnObjectSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_showMessageOnObjectSignal_Public_set_Void_ShowMessageOnObjectSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe FuelIgnitedSignal fuelIgnitedSignal
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 96676, RefRangeEnd = 96716, XrefRangeStart = 96676, XrefRangeEnd = 96716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fuelIgnitedSignal_Public_get_FuelIgnitedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FuelIgnitedSignal>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fuelIgnitedSignal_Public_set_Void_FuelIgnitedSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe IGameEventManager gameEventManager
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 30821, RefRangeEnd = 30837, XrefRangeStart = 30821, XrefRangeEnd = 30837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static IgniteAttemptEffect()
	{
		Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IgniteAttemptEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr);
		NativeFieldInfoPtr__showMessageOnObjectSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, "<showMessageOnObjectSignal>k__BackingField");
		NativeFieldInfoPtr__fuelIgnitedSignal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, "<fuelIgnitedSignal>k__BackingField");
		NativeFieldInfoPtr__gameEventManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, "<gameEventManager>k__BackingField");
		NativeMethodInfoPtr_get_showMessageOnObjectSignal_Public_get_ShowMessageOnObjectSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, 100671223);
		NativeMethodInfoPtr_set_showMessageOnObjectSignal_Public_set_Void_ShowMessageOnObjectSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, 100671224);
		NativeMethodInfoPtr_get_fuelIgnitedSignal_Public_get_FuelIgnitedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, 100671225);
		NativeMethodInfoPtr_set_fuelIgnitedSignal_Public_set_Void_FuelIgnitedSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, 100671226);
		NativeMethodInfoPtr_get_gameEventManager_Public_get_IGameEventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, 100671227);
		NativeMethodInfoPtr_set_gameEventManager_Public_set_Void_IGameEventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, 100671228);
		NativeMethodInfoPtr_GetEffectType_Public_Virtual_InteractionEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, 100671229);
		NativeMethodInfoPtr_ExecuteResult_Public_Virtual_IgniteAttemptEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, 100671230);
		NativeMethodInfoPtr_OnExecuted_Protected_Virtual_Void_IgniteAttemptEffectResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, 100671231);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr, 100671232);
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126260, XrefRangeEnd = 126272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IgniteAttemptEffectResult ExecuteResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ExecuteResult_Public_Virtual_IgniteAttemptEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(IgniteAttemptEffectResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126272, XrefRangeEnd = 126287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnExecuted(IgniteAttemptEffectResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnExecuted_Protected_Virtual_Void_IgniteAttemptEffectResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126287, XrefRangeEnd = 126290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IgniteAttemptEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgniteAttemptEffect>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IgniteAttemptEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

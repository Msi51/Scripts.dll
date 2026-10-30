using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.injector.api;

public class PlantItemStackEventHandler : NetworkedGameEventHandler<PlantItemStackEventParams, PlantItemStackEventResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_spawnManager;

	private static readonly IntPtr NativeFieldInfoPtr_placementSuccessSignal;

	private static readonly IntPtr NativeFieldInfoPtr_soundManager;

	private static readonly IntPtr NativeFieldInfoPtr_growablePhaseReachedEvent;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_PlantItemStackEventResult_Int32_PlantItemStackEventParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_PlantItemStackEventResult_Boolean_0;

	public unsafe ISpawnManager spawnManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ISpawnManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnManager));
		}
	}

	public unsafe PlacementSuccessSignal placementSuccessSignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementSuccessSignal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlacementSuccessSignal>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementSuccessSignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placementSuccessSignal));
		}
	}

	public unsafe ISoundManager soundManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ISoundManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundManager));
		}
	}

	public unsafe GrowablePhaseReachedEvent growablePhaseReachedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growablePhaseReachedEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GrowablePhaseReachedEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_growablePhaseReachedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)growablePhaseReachedEvent));
		}
	}

	static PlantItemStackEventHandler()
	{
		Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlantItemStackEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr);
		NativeFieldInfoPtr_spawnManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr, "spawnManager");
		NativeFieldInfoPtr_placementSuccessSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr, "placementSuccessSignal");
		NativeFieldInfoPtr_soundManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr, "soundManager");
		NativeFieldInfoPtr_growablePhaseReachedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr, "growablePhaseReachedEvent");
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr, 100670120);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr, 100670121);
		NativeMethodInfoPtr_Execute_Public_Virtual_PlantItemStackEventResult_Int32_PlantItemStackEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr, 100670122);
		NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_PlantItemStackEventResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr, 100670123);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 113796, RefRangeEnd = 113797, XrefRangeStart = 113793, XrefRangeEnd = 113796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlantItemStackEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantItemStackEventHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113797, XrefRangeEnd = 113814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113814, XrefRangeEnd = 113921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override PlantItemStackEventResult Execute(int clientId, PlantItemStackEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&clientId);
		*(PlantItemStackEventParams**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &eventParams;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_PlantItemStackEventResult_Int32_PlantItemStackEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(PlantItemStackEventResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113921, XrefRangeEnd = 113931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void HandleResult(PlantItemStackEventResult result, bool relayResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&result);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &relayResult;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_PlantItemStackEventResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlantItemStackEventHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

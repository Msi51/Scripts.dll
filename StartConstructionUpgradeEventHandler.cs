using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.injector.api;

public class StartConstructionUpgradeEventHandler : NetworkedGameEventHandler<StartConstructionUpgradeEventParams, StartConstructionUpgradeEventResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_inventoryManager;

	private static readonly IntPtr NativeFieldInfoPtr_blueprintManager;

	private static readonly IntPtr NativeFieldInfoPtr_soundManager;

	private static readonly IntPtr NativeFieldInfoPtr_showMessageOnObjectSignal;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_StartConstructionUpgradeEventResult_Int32_StartConstructionUpgradeEventParams_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_StartConstructionUpgradeEventResult_Boolean_0;

	public unsafe IInventoryManager inventoryManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInventoryManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager));
		}
	}

	public unsafe IBlueprintManager blueprintManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprintManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IBlueprintManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueprintManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blueprintManager));
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

	public unsafe ShowMessageOnObjectSignal showMessageOnObjectSignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMessageOnObjectSignal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ShowMessageOnObjectSignal>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMessageOnObjectSignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)showMessageOnObjectSignal));
		}
	}

	static StartConstructionUpgradeEventHandler()
	{
		Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartConstructionUpgradeEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr);
		NativeFieldInfoPtr_inventoryManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr, "inventoryManager");
		NativeFieldInfoPtr_blueprintManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr, "blueprintManager");
		NativeFieldInfoPtr_soundManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr, "soundManager");
		NativeFieldInfoPtr_showMessageOnObjectSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr, "showMessageOnObjectSignal");
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr, 100670339);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr, 100670340);
		NativeMethodInfoPtr_Execute_Public_Virtual_StartConstructionUpgradeEventResult_Int32_StartConstructionUpgradeEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr, 100670341);
		NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_StartConstructionUpgradeEventResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr, 100670342);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118591, RefRangeEnd = 118592, XrefRangeStart = 118588, XrefRangeEnd = 118591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StartConstructionUpgradeEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartConstructionUpgradeEventHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118592, XrefRangeEnd = 118609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118609, XrefRangeEnd = 118726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override StartConstructionUpgradeEventResult Execute(int clientId, StartConstructionUpgradeEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&clientId);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventParams));
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_StartConstructionUpgradeEventResult_Int32_StartConstructionUpgradeEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new StartConstructionUpgradeEventResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118726, XrefRangeEnd = 118825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void HandleResult(StartConstructionUpgradeEventResult result, bool relayResult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result));
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &relayResult;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleResult_Public_Virtual_Void_StartConstructionUpgradeEventResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartConstructionUpgradeEventHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

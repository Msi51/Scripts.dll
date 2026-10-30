using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.injector.api;

public class CancelConstructionUpgradeEventHandler : NetworkedGameEventHandler<CancelConstructionUpgradeEventParams, CancelConstructionUpgradeEventResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_spawnManager;

	private static readonly IntPtr NativeFieldInfoPtr_soundManager;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_CancelConstructionUpgradeEventResult_Int32_CancelConstructionUpgradeEventParams_0;

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

	static CancelConstructionUpgradeEventHandler()
	{
		Il2CppClassPointerStore<CancelConstructionUpgradeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CancelConstructionUpgradeEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancelConstructionUpgradeEventHandler>.NativeClassPtr);
		NativeFieldInfoPtr_spawnManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancelConstructionUpgradeEventHandler>.NativeClassPtr, "spawnManager");
		NativeFieldInfoPtr_soundManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancelConstructionUpgradeEventHandler>.NativeClassPtr, "soundManager");
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelConstructionUpgradeEventHandler>.NativeClassPtr, 100669920);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelConstructionUpgradeEventHandler>.NativeClassPtr, 100669921);
		NativeMethodInfoPtr_Execute_Public_Virtual_CancelConstructionUpgradeEventResult_Int32_CancelConstructionUpgradeEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelConstructionUpgradeEventHandler>.NativeClassPtr, 100669922);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108433, RefRangeEnd = 108434, XrefRangeStart = 108430, XrefRangeEnd = 108433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CancelConstructionUpgradeEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancelConstructionUpgradeEventHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108434, XrefRangeEnd = 108443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108443, XrefRangeEnd = 108501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override CancelConstructionUpgradeEventResult Execute(int clientId, CancelConstructionUpgradeEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&clientId);
		*(CancelConstructionUpgradeEventParams**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &eventParams;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_CancelConstructionUpgradeEventResult_Int32_CancelConstructionUpgradeEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CancelConstructionUpgradeEventResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public CancelConstructionUpgradeEventHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

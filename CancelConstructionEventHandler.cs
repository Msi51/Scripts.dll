using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.injector.api;

public class CancelConstructionEventHandler : NetworkedGameEventHandler<CancelConstructionEventParams, CancelConstructionEventResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_constructionManager;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_CancelConstructionEventResult_Int32_CancelConstructionEventParams_0;

	public unsafe IConstructionManager constructionManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IConstructionManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)constructionManager));
		}
	}

	static CancelConstructionEventHandler()
	{
		Il2CppClassPointerStore<CancelConstructionEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CancelConstructionEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancelConstructionEventHandler>.NativeClassPtr);
		NativeFieldInfoPtr_constructionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancelConstructionEventHandler>.NativeClassPtr, "constructionManager");
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelConstructionEventHandler>.NativeClassPtr, 100669917);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelConstructionEventHandler>.NativeClassPtr, 100669918);
		NativeMethodInfoPtr_Execute_Public_Virtual_CancelConstructionEventResult_Int32_CancelConstructionEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancelConstructionEventHandler>.NativeClassPtr, 100669919);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108402, RefRangeEnd = 108403, XrefRangeStart = 108399, XrefRangeEnd = 108402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CancelConstructionEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancelConstructionEventHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108403, XrefRangeEnd = 108408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108408, XrefRangeEnd = 108430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override CancelConstructionEventResult Execute(int clientId, CancelConstructionEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&clientId);
		*(CancelConstructionEventParams**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &eventParams;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_CancelConstructionEventResult_Int32_CancelConstructionEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(CancelConstructionEventResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public CancelConstructionEventHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

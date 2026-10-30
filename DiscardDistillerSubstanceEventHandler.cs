using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.injector.api;

public class DiscardDistillerSubstanceEventHandler : NetworkedGameEventHandler<DiscardDistillerSubstanceEventParams, DiscardDistillerSubstanceEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_DiscardDistillerSubstanceEventResult_Int32_DiscardDistillerSubstanceEventParams_0;

	static DiscardDistillerSubstanceEventHandler()
	{
		Il2CppClassPointerStore<DiscardDistillerSubstanceEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DiscardDistillerSubstanceEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscardDistillerSubstanceEventHandler>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscardDistillerSubstanceEventHandler>.NativeClassPtr, 100669981);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscardDistillerSubstanceEventHandler>.NativeClassPtr, 100669982);
		NativeMethodInfoPtr_Execute_Public_Virtual_DiscardDistillerSubstanceEventResult_Int32_DiscardDistillerSubstanceEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscardDistillerSubstanceEventHandler>.NativeClassPtr, 100669983);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111264, RefRangeEnd = 111265, XrefRangeStart = 111261, XrefRangeEnd = 111264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiscardDistillerSubstanceEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscardDistillerSubstanceEventHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111265, XrefRangeEnd = 111280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override DiscardDistillerSubstanceEventResult Execute(int clientId, DiscardDistillerSubstanceEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&clientId);
		*(DiscardDistillerSubstanceEventParams**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &eventParams;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_DiscardDistillerSubstanceEventResult_Int32_DiscardDistillerSubstanceEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DiscardDistillerSubstanceEventResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public DiscardDistillerSubstanceEventHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

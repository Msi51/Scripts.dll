using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using strange.extensions.injector.api;

public class AddPlayerMarkerEventHandler : NetworkedGameEventHandler<AddPlayerMarkerEventParams, AddPlayerMarkerEventResult>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_AddPlayerMarkerEventResult_Int32_AddPlayerMarkerEventParams_0;

	static AddPlayerMarkerEventHandler()
	{
		Il2CppClassPointerStore<AddPlayerMarkerEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AddPlayerMarkerEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddPlayerMarkerEventHandler>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPlayerMarkerEventHandler>.NativeClassPtr, 100669910);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPlayerMarkerEventHandler>.NativeClassPtr, 100669911);
		NativeMethodInfoPtr_Execute_Public_Virtual_AddPlayerMarkerEventResult_Int32_AddPlayerMarkerEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddPlayerMarkerEventHandler>.NativeClassPtr, 100669912);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108366, RefRangeEnd = 108367, XrefRangeStart = 108363, XrefRangeEnd = 108366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddPlayerMarkerEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddPlayerMarkerEventHandler>.NativeClassPtr))
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108367, XrefRangeEnd = 108376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override AddPlayerMarkerEventResult Execute(int clientId, AddPlayerMarkerEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&clientId);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventParams));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_AddPlayerMarkerEventResult_Int32_AddPlayerMarkerEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AddPlayerMarkerEventResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public AddPlayerMarkerEventHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

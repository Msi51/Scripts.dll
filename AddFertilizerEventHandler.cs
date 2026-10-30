using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.injector.api;

public class AddFertilizerEventHandler : NetworkedGameEventHandler<AddFertilizerEventParams, AddFertilizerEventResult>
{
	private static readonly IntPtr NativeFieldInfoPtr_soundManager;

	private static readonly IntPtr NativeFieldInfoPtr_gainExperienceEvent;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_AddFertilizerEventResult_Int32_AddFertilizerEventParams_0;

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

	public unsafe GainExperienceEvent gainExperienceEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gainExperienceEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GainExperienceEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gainExperienceEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gainExperienceEvent));
		}
	}

	static AddFertilizerEventHandler()
	{
		Il2CppClassPointerStore<AddFertilizerEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AddFertilizerEventHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddFertilizerEventHandler>.NativeClassPtr);
		NativeFieldInfoPtr_soundManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFertilizerEventHandler>.NativeClassPtr, "soundManager");
		NativeFieldInfoPtr_gainExperienceEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFertilizerEventHandler>.NativeClassPtr, "gainExperienceEvent");
		NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFertilizerEventHandler>.NativeClassPtr, 100669887);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFertilizerEventHandler>.NativeClassPtr, 100669888);
		NativeMethodInfoPtr_Execute_Public_Virtual_AddFertilizerEventResult_Int32_AddFertilizerEventParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFertilizerEventHandler>.NativeClassPtr, 100669889);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108017, RefRangeEnd = 108018, XrefRangeStart = 108009, XrefRangeEnd = 108017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddFertilizerEventHandler(IGameEventManager gameEventManager, IInjectionBinder binder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddFertilizerEventHandler>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameEventManager_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108018, XrefRangeEnd = 108023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108023, XrefRangeEnd = 108068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override AddFertilizerEventResult Execute(int clientId, AddFertilizerEventParams eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&clientId);
		*(AddFertilizerEventParams**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &eventParams;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_AddFertilizerEventResult_Int32_AddFertilizerEventParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AddFertilizerEventResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public AddFertilizerEventHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

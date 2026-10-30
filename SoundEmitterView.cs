using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class SoundEmitterView : BaseView
{
	private static readonly IntPtr NativeFieldInfoPtr_playSoundEvent;

	private static readonly IntPtr NativeFieldInfoPtr_playSoundLoopedEvent;

	private static readonly IntPtr NativeFieldInfoPtr_stopLoopedSoundSignal;

	private static readonly IntPtr NativeFieldInfoPtr_loopingAudioDatas;

	private static readonly IntPtr NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetEvents_Public_Virtual_Void_IGameEventManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Deactivated_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Virtual_Final_New_Void_SoundEffectType_Single_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Virtual_Final_New_Void_SoundEffectType_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySoundLooped_Public_Virtual_Final_New_Void_SoundEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLoopedSoundVolume_Public_Virtual_Final_New_Void_SoundEffectType_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopSound_Public_Virtual_Final_New_Void_SoundEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetLoopingAudioDatas_Public_Virtual_Final_New_List_1_LoopingAudioData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetStopLoopedSoundSignal_Public_Void_StopLoopedSoundSignal_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsUpdateListenerActive_Public_Virtual_Final_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleUpdate_Public_Virtual_Final_New_Void_byref_NetworkSoundEmitterUpdate_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe PlaySoundEvent playSoundEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playSoundEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlaySoundEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playSoundEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playSoundEvent));
		}
	}

	public unsafe PlaySoundLoopedEvent playSoundLoopedEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playSoundLoopedEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlaySoundLoopedEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playSoundLoopedEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playSoundLoopedEvent));
		}
	}

	public unsafe StopLoopedSoundSignal stopLoopedSoundSignal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopLoopedSoundSignal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StopLoopedSoundSignal>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopLoopedSoundSignal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stopLoopedSoundSignal));
		}
	}

	public unsafe List<LoopingAudioData> loopingAudioDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopingAudioDatas);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<LoopingAudioData>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loopingAudioDatas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static SoundEmitterView()
	{
		Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SoundEmitterView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr);
		NativeFieldInfoPtr_playSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, "playSoundEvent");
		NativeFieldInfoPtr_playSoundLoopedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, "playSoundLoopedEvent");
		NativeFieldInfoPtr_stopLoopedSoundSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, "stopLoopedSoundSignal");
		NativeFieldInfoPtr_loopingAudioDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, "loopingAudioDatas");
		NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682872);
		NativeMethodInfoPtr_SetEvents_Public_Virtual_Void_IGameEventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682873);
		NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682874);
		NativeMethodInfoPtr_Deactivated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682875);
		NativeMethodInfoPtr_PlaySound_Public_Virtual_Final_New_Void_SoundEffectType_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682876);
		NativeMethodInfoPtr_PlaySound_Public_Virtual_Final_New_Void_SoundEffectType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682877);
		NativeMethodInfoPtr_PlaySoundLooped_Public_Virtual_Final_New_Void_SoundEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682878);
		NativeMethodInfoPtr_SetLoopedSoundVolume_Public_Virtual_Final_New_Void_SoundEffectType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682879);
		NativeMethodInfoPtr_StopSound_Public_Virtual_Final_New_Void_SoundEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682880);
		NativeMethodInfoPtr_GetLoopingAudioDatas_Public_Virtual_Final_New_List_1_LoopingAudioData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682881);
		NativeMethodInfoPtr_SetStopLoopedSoundSignal_Public_Void_StopLoopedSoundSignal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682882);
		NativeMethodInfoPtr_IsUpdateListenerActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682883);
		NativeMethodInfoPtr_HandleUpdate_Public_Virtual_Final_New_Void_byref_NetworkSoundEmitterUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682884);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr, 100682885);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256330, XrefRangeEnd = 256332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetComponentName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetComponentName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256332, XrefRangeEnd = 256342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetEvents(IGameEventManager gameEventManager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameEventManager);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetEvents_Public_Virtual_Void_IGameEventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256342, XrefRangeEnd = 256350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256350, XrefRangeEnd = 256373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Deactivated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Deactivated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 256378, RefRangeEnd = 256380, XrefRangeStart = 256373, XrefRangeEnd = 256378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PlaySound(SoundEffectType soundEffectType, float volume = 1f, bool networked = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&soundEffectType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &volume;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &networked;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Virtual_Final_New_Void_SoundEffectType_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256380, XrefRangeEnd = 256381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PlaySound(SoundEffectType soundEffectType, bool networked)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&soundEffectType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &networked;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySound_Public_Virtual_Final_New_Void_SoundEffectType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256381, XrefRangeEnd = 256386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PlaySoundLooped(SoundEffectType soundEffectType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&soundEffectType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySoundLooped_Public_Virtual_Final_New_Void_SoundEffectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256386, XrefRangeEnd = 256412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetLoopedSoundVolume(SoundEffectType soundEffectType, float volume)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&soundEffectType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &volume;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLoopedSoundVolume_Public_Virtual_Final_New_Void_SoundEffectType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256412, XrefRangeEnd = 256417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void StopSound(SoundEffectType soundEffectType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&soundEffectType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopSound_Public_Virtual_Final_New_Void_SoundEffectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 97543, RefRangeEnd = 97544, XrefRangeStart = 97543, XrefRangeEnd = 97544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual List<LoopingAudioData> GetLoopingAudioDatas()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLoopingAudioDatas_Public_Virtual_Final_New_List_1_LoopingAudioData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<LoopingAudioData>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStopLoopedSoundSignal(StopLoopedSoundSignal signal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)signal);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStopLoopedSoundSignal_Public_Void_StopLoopedSoundSignal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256417, XrefRangeEnd = 256422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsUpdateListenerActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUpdateListenerActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256422, XrefRangeEnd = 256423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void HandleUpdate(ref NetworkSoundEmitterUpdate update)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref update);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleUpdate_Public_Virtual_Final_New_Void_byref_NetworkSoundEmitterUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundEmitterView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundEmitterView>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SoundEmitterView(IntPtr pointer)
		: base(pointer)
	{
	}
}

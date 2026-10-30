using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class ISoundEmitter : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Abstract_Virtual_New_Void_SoundEffectType_Single_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Abstract_Virtual_New_Void_SoundEffectType_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySoundLooped_Public_Abstract_Virtual_New_Void_SoundEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLoopedSoundVolume_Public_Abstract_Virtual_New_Void_SoundEffectType_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopSound_Public_Abstract_Virtual_New_Void_SoundEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetLoopingAudioDatas_Public_Abstract_Virtual_New_List_1_LoopingAudioData_0;

	static ISoundEmitter()
	{
		Il2CppClassPointerStore<ISoundEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISoundEmitter");
		NativeMethodInfoPtr_PlaySound_Public_Abstract_Virtual_New_Void_SoundEffectType_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISoundEmitter>.NativeClassPtr, 100682003);
		NativeMethodInfoPtr_PlaySound_Public_Abstract_Virtual_New_Void_SoundEffectType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISoundEmitter>.NativeClassPtr, 100682004);
		NativeMethodInfoPtr_PlaySoundLooped_Public_Abstract_Virtual_New_Void_SoundEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISoundEmitter>.NativeClassPtr, 100682005);
		NativeMethodInfoPtr_SetLoopedSoundVolume_Public_Abstract_Virtual_New_Void_SoundEffectType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISoundEmitter>.NativeClassPtr, 100682006);
		NativeMethodInfoPtr_StopSound_Public_Abstract_Virtual_New_Void_SoundEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISoundEmitter>.NativeClassPtr, 100682007);
		NativeMethodInfoPtr_GetLoopingAudioDatas_Public_Abstract_Virtual_New_List_1_LoopingAudioData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISoundEmitter>.NativeClassPtr, 100682008);
	}

	[CallerCount(0)]
	public unsafe virtual void PlaySound(SoundEffectType soundEffectType, float volume = 1f, bool networked = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&soundEffectType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &volume;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &networked;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PlaySound_Public_Abstract_Virtual_New_Void_SoundEffectType_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void PlaySound(SoundEffectType soundEffectType, bool networked)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&soundEffectType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &networked;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PlaySound_Public_Abstract_Virtual_New_Void_SoundEffectType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void PlaySoundLooped(SoundEffectType soundEffectType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&soundEffectType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PlaySoundLooped_Public_Abstract_Virtual_New_Void_SoundEffectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetLoopedSoundVolume(SoundEffectType soundEffectType, float volume)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&soundEffectType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &volume;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetLoopedSoundVolume_Public_Abstract_Virtual_New_Void_SoundEffectType_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void StopSound(SoundEffectType soundEffectType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&soundEffectType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_StopSound_Public_Abstract_Virtual_New_Void_SoundEffectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual List<LoopingAudioData> GetLoopingAudioDatas()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetLoopingAudioDatas_Public_Abstract_Virtual_New_List_1_LoopingAudioData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<LoopingAudioData>>(intPtr) : null;
	}

	public ISoundEmitter(IntPtr pointer)
		: base(pointer)
	{
	}
}

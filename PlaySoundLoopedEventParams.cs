using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class PlaySoundLoopedEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sourceObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundEffectType;

	private static readonly System.IntPtr NativeFieldInfoPtr_volume;

	public unsafe GameObject sourceObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe SoundEffectType soundEffectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundEffectType);
			return *(SoundEffectType*)num;
		}
		set
		{
			*(SoundEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundEffectType)) = soundEffectType;
		}
	}

	public unsafe float volume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volume);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volume)) = num;
		}
	}

	static PlaySoundLoopedEventParams()
	{
		Il2CppClassPointerStore<PlaySoundLoopedEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlaySoundLoopedEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySoundLoopedEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_sourceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundLoopedEventParams>.NativeClassPtr, "sourceObject");
		NativeFieldInfoPtr_soundEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundLoopedEventParams>.NativeClassPtr, "soundEffectType");
		NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundLoopedEventParams>.NativeClassPtr, "volume");
	}

	public PlaySoundLoopedEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PlaySoundLoopedEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySoundLoopedEventParams>.NativeClassPtr))
	{
	}
}

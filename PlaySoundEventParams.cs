using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public sealed class PlaySoundEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sourceEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundEffectType;

	private static readonly System.IntPtr NativeFieldInfoPtr_volume;

	public unsafe Entity sourceEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
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

	static PlaySoundEventParams()
	{
		Il2CppClassPointerStore<PlaySoundEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PlaySoundEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySoundEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_sourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundEventParams>.NativeClassPtr, "sourceEntity");
		NativeFieldInfoPtr_soundEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundEventParams>.NativeClassPtr, "soundEffectType");
		NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundEventParams>.NativeClassPtr, "volume");
	}

	public PlaySoundEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PlaySoundEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySoundEventParams>.NativeClassPtr))
	{
	}
}

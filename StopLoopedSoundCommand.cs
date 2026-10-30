using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using strange.extensions.command.impl;
using UnityEngine;

public class StopLoopedSoundCommand : Command
{
	private static readonly IntPtr NativeFieldInfoPtr__sourceObject_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__soundEffectType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__soundManager_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_sourceObject_Public_get_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_sourceObject_Public_set_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_soundEffectType_Public_get_SoundEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_soundEffectType_Public_set_Void_SoundEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_soundManager_Public_get_ISoundManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_soundManager_Public_set_Void_ISoundManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject _sourceObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sourceObject_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sourceObject_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe SoundEffectType _soundEffectType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__soundEffectType_k__BackingField);
			return *(SoundEffectType*)num;
		}
		set
		{
			*(SoundEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__soundEffectType_k__BackingField)) = soundEffectType;
		}
	}

	public unsafe ISoundManager _soundManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__soundManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ISoundManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__soundManager_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundManager));
		}
	}

	public unsafe GameObject sourceObject
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 977, RefRangeEnd = 983, XrefRangeStart = 977, XrefRangeEnd = 983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sourceObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sourceObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe SoundEffectType soundEffectType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_soundEffectType_Public_get_SoundEffectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(SoundEffectType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_soundEffectType_Public_set_Void_SoundEffectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ISoundManager soundManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_soundManager_Public_get_ISoundManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ISoundManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_soundManager_Public_set_Void_ISoundManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static StopLoopedSoundCommand()
	{
		Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StopLoopedSoundCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr);
		NativeFieldInfoPtr__sourceObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, "<sourceObject>k__BackingField");
		NativeFieldInfoPtr__soundEffectType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, "<soundEffectType>k__BackingField");
		NativeFieldInfoPtr__soundManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, "<soundManager>k__BackingField");
		NativeMethodInfoPtr_get_sourceObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, 100669206);
		NativeMethodInfoPtr_set_sourceObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, 100669207);
		NativeMethodInfoPtr_get_soundEffectType_Public_get_SoundEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, 100669208);
		NativeMethodInfoPtr_set_soundEffectType_Public_set_Void_SoundEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, 100669209);
		NativeMethodInfoPtr_get_soundManager_Public_get_ISoundManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, 100669210);
		NativeMethodInfoPtr_set_soundManager_Public_set_Void_ISoundManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, 100669211);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, 100669212);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr, 100669213);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100111, XrefRangeEnd = 100116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StopLoopedSoundCommand()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopLoopedSoundCommand>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StopLoopedSoundCommand(IntPtr pointer)
		: base(pointer)
	{
	}
}

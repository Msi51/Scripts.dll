using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class VariantDetails : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_hairIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_pieceClothingIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_painSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_threatenSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_deathSound;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<string> hairIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairIdentifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<CharacterMeshPieceType, List<string>> pieceClothingIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieceClothingIdentifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterMeshPieceType, List<string>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieceClothingIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe SoundEffectType painSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_painSound);
			return *(SoundEffectType*)num;
		}
		set
		{
			*(SoundEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_painSound)) = soundEffectType;
		}
	}

	public unsafe SoundEffectType threatenSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threatenSound);
			return *(SoundEffectType*)num;
		}
		set
		{
			*(SoundEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threatenSound)) = soundEffectType;
		}
	}

	public unsafe SoundEffectType deathSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deathSound);
			return *(SoundEffectType*)num;
		}
		set
		{
			*(SoundEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deathSound)) = soundEffectType;
		}
	}

	static VariantDetails()
	{
		Il2CppClassPointerStore<VariantDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "VariantDetails");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariantDetails>.NativeClassPtr);
		NativeFieldInfoPtr_hairIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariantDetails>.NativeClassPtr, "hairIdentifiers");
		NativeFieldInfoPtr_pieceClothingIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariantDetails>.NativeClassPtr, "pieceClothingIdentifiers");
		NativeFieldInfoPtr_painSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariantDetails>.NativeClassPtr, "painSound");
		NativeFieldInfoPtr_threatenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariantDetails>.NativeClassPtr, "threatenSound");
		NativeFieldInfoPtr_deathSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariantDetails>.NativeClassPtr, "deathSound");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariantDetails>.NativeClassPtr, 100668666);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96649, RefRangeEnd = 96650, XrefRangeStart = 96627, XrefRangeEnd = 96649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VariantDetails()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariantDetails>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public VariantDetails(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

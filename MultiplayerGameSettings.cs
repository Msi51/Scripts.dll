using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class MultiplayerGameSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_multiplayerGameOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_originalHostUserId;

	private static readonly System.IntPtr NativeFieldInfoPtr_userIds;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe MultiplayerGameOptions multiplayerGameOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplayerGameOptions);
			return new MultiplayerGameOptions(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplayerGameOptions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)multiplayerGameOptions)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ulong originalHostUserId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalHostUserId);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalHostUserId)) = num;
		}
	}

	public unsafe HashSet<ulong> userIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ulong>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_userIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	static MultiplayerGameSettings()
	{
		Il2CppClassPointerStore<MultiplayerGameSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MultiplayerGameSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiplayerGameSettings>.NativeClassPtr);
		NativeFieldInfoPtr_multiplayerGameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameSettings>.NativeClassPtr, "multiplayerGameOptions");
		NativeFieldInfoPtr_originalHostUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameSettings>.NativeClassPtr, "originalHostUserId");
		NativeFieldInfoPtr_userIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameSettings>.NativeClassPtr, "userIds");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiplayerGameSettings>.NativeClassPtr, 100679376);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MultiplayerGameSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiplayerGameSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MultiplayerGameSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

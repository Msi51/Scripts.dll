using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public sealed class SteamAppNews : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__NewsItems_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NewsItems_Public_get_Il2CppReferenceArray_1_SteamNewsItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_NewsItems_Public_set_Void_Il2CppReferenceArray_1_SteamNewsItem_0;

	public unsafe Il2CppReferenceArray<SteamNewsItem> _NewsItems_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NewsItems_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SteamNewsItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NewsItems_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<SteamNewsItem> NewsItems
	{
		[CallerCount(91)]
		[CachedScanResults(RefRangeStart = 19321, RefRangeEnd = 19412, XrefRangeStart = 19321, XrefRangeEnd = 19412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NewsItems_Public_get_Il2CppReferenceArray_1_SteamNewsItem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SteamNewsItem>>(intPtr) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 24959, RefRangeEnd = 24962, XrefRangeStart = 24959, XrefRangeEnd = 24962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NewsItems_Public_set_Void_Il2CppReferenceArray_1_SteamNewsItem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static SteamAppNews()
	{
		Il2CppClassPointerStore<SteamAppNews>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SteamAppNews");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAppNews>.NativeClassPtr);
		NativeFieldInfoPtr__NewsItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamAppNews>.NativeClassPtr, "<NewsItems>k__BackingField");
		NativeMethodInfoPtr_get_NewsItems_Public_get_Il2CppReferenceArray_1_SteamNewsItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppNews>.NativeClassPtr, 100667976);
		NativeMethodInfoPtr_set_NewsItems_Public_set_Void_Il2CppReferenceArray_1_SteamNewsItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAppNews>.NativeClassPtr, 100667977);
	}

	public SteamAppNews(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SteamAppNews()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamAppNews>.NativeClassPtr))
	{
	}
}

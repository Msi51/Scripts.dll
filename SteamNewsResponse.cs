using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public sealed class SteamNewsResponse : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__AppNews_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AppNews_Public_get_SteamAppNews_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AppNews_Public_set_Void_SteamAppNews_0;

	public unsafe SteamAppNews _AppNews_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AppNews_k__BackingField);
			return new SteamAppNews(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamAppNews>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AppNews_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)steamAppNews)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamAppNews>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe SteamAppNews AppNews
	{
		[CallerCount(91)]
		[CachedScanResults(RefRangeStart = 19321, RefRangeEnd = 19412, XrefRangeStart = 19321, XrefRangeEnd = 19412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AppNews_Public_get_SteamAppNews_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new SteamAppNews(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86094, XrefRangeEnd = 86095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AppNews_Public_set_Void_SteamAppNews_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static SteamNewsResponse()
	{
		Il2CppClassPointerStore<SteamNewsResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SteamNewsResponse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNewsResponse>.NativeClassPtr);
		NativeFieldInfoPtr__AppNews_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNewsResponse>.NativeClassPtr, "<AppNews>k__BackingField");
		NativeMethodInfoPtr_get_AppNews_Public_get_SteamAppNews_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNewsResponse>.NativeClassPtr, 100667978);
		NativeMethodInfoPtr_set_AppNews_Public_set_Void_SteamAppNews_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNewsResponse>.NativeClassPtr, 100667979);
	}

	public SteamNewsResponse(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SteamNewsResponse()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNewsResponse>.NativeClassPtr))
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class MultiplayerSettings : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_TIMEOUT_SECONDS;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_JOIN_TIMEOUT_SECONDS;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeoutSeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_joinTimeoutSeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_bannedUserIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_modUserIds;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaults_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0;

	public unsafe static float DEFAULT_TIMEOUT_SECONDS
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_TIMEOUT_SECONDS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_TIMEOUT_SECONDS, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_JOIN_TIMEOUT_SECONDS
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_JOIN_TIMEOUT_SECONDS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_JOIN_TIMEOUT_SECONDS, (void*)(&num));
		}
	}

	public unsafe float timeoutSeconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeoutSeconds);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeoutSeconds)) = num;
		}
	}

	public unsafe float joinTimeoutSeconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joinTimeoutSeconds);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joinTimeoutSeconds)) = num;
		}
	}

	public unsafe HashSet<ulong> bannedUserIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bannedUserIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ulong>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bannedUserIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<ulong> modUserIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modUserIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ulong>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modUserIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	static MultiplayerSettings()
	{
		Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MultiplayerSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr);
		NativeFieldInfoPtr_DEFAULT_TIMEOUT_SECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, "DEFAULT_TIMEOUT_SECONDS");
		NativeFieldInfoPtr_DEFAULT_JOIN_TIMEOUT_SECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, "DEFAULT_JOIN_TIMEOUT_SECONDS");
		NativeFieldInfoPtr_timeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, "timeoutSeconds");
		NativeFieldInfoPtr_joinTimeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, "joinTimeoutSeconds");
		NativeFieldInfoPtr_bannedUserIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, "bannedUserIds");
		NativeFieldInfoPtr_modUserIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, "modUserIds");
		NativeMethodInfoPtr_SetDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr, 100663641);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20534, RefRangeEnd = 20535, XrefRangeStart = 20534, XrefRangeEnd = 20534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaults_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20535, XrefRangeEnd = 20618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 20692, RefRangeEnd = 20693, XrefRangeStart = 20618, XrefRangeEnd = 20692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Dictionary<string, Il2CppSystem.Object> MapToDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapToDictionary_Public_Virtual_Final_New_Dictionary_2_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr) : null;
	}

	public MultiplayerSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public MultiplayerSettings()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiplayerSettings>.NativeClassPtr))
	{
	}
}

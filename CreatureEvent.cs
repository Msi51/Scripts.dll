using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class CreatureEvent : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_creatureIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DateTime_CreatureEventType_0;

	public unsafe string creatureIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creatureIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creatureIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppSystem.DateTime worldDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDateTime)) = dateTime;
		}
	}

	public unsafe CreatureEventType eventType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventType);
			return *(CreatureEventType*)num;
		}
		set
		{
			*(CreatureEventType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventType)) = creatureEventType;
		}
	}

	static CreatureEvent()
	{
		Il2CppClassPointerStore<CreatureEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreatureEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatureEvent>.NativeClassPtr);
		NativeFieldInfoPtr_creatureIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatureEvent>.NativeClassPtr, "creatureIdentifier");
		NativeFieldInfoPtr_worldDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatureEvent>.NativeClassPtr, "worldDateTime");
		NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatureEvent>.NativeClassPtr, "eventType");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureEvent>.NativeClassPtr, 100669643);
		NativeMethodInfoPtr__ctor_Public_Void_String_DateTime_CreatureEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatureEvent>.NativeClassPtr, 100669644);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreatureEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatureEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 104009, RefRangeEnd = 104010, XrefRangeStart = 104007, XrefRangeEnd = 104009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreatureEvent(string creatureIdentifier, Il2CppSystem.DateTime worldDateTime, CreatureEventType eventType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatureEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(creatureIdentifier);
		*(Il2CppSystem.DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldDateTime;
		*(CreatureEventType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_DateTime_CreatureEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreatureEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

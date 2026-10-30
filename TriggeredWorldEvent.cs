using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class TriggeredWorldEvent : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_worldEventType;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDateTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe WorldEventType worldEventType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldEventType);
			return *(WorldEventType*)num;
		}
		set
		{
			*(WorldEventType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldEventType)) = worldEventType;
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

	static TriggeredWorldEvent()
	{
		Il2CppClassPointerStore<TriggeredWorldEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TriggeredWorldEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggeredWorldEvent>.NativeClassPtr);
		NativeFieldInfoPtr_worldEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredWorldEvent>.NativeClassPtr, "worldEventType");
		NativeFieldInfoPtr_worldDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredWorldEvent>.NativeClassPtr, "worldDateTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredWorldEvent>.NativeClassPtr, 100683695);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TriggeredWorldEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggeredWorldEvent>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TriggeredWorldEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

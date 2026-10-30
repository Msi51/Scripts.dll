using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class ConstructionDestroyInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_entityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroyedEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_damaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggerWorldDateTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int entityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityId)) = num;
		}
	}

	public unsafe int destroyedEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyedEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyedEntityId)) = num;
		}
	}

	public unsafe bool damaged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damaged);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damaged)) = flag;
		}
	}

	public unsafe Il2CppSystem.DateTime triggerWorldDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerWorldDateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerWorldDateTime)) = dateTime;
		}
	}

	static ConstructionDestroyInfo()
	{
		Il2CppClassPointerStore<ConstructionDestroyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConstructionDestroyInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionDestroyInfo>.NativeClassPtr);
		NativeFieldInfoPtr_entityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionDestroyInfo>.NativeClassPtr, "entityId");
		NativeFieldInfoPtr_destroyedEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionDestroyInfo>.NativeClassPtr, "destroyedEntityId");
		NativeFieldInfoPtr_damaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionDestroyInfo>.NativeClassPtr, "damaged");
		NativeFieldInfoPtr_triggerWorldDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionDestroyInfo>.NativeClassPtr, "triggerWorldDateTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionDestroyInfo>.NativeClassPtr, 100669482);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConstructionDestroyInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionDestroyInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ConstructionDestroyInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

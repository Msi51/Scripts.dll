using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public sealed class ApplyInjuryEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_injuredEntityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_injuryIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_category;

	private static readonly System.IntPtr NativeFieldInfoPtr_location;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingDurabilityPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingCleanlinessPercentage;

	public unsafe int injuredEntityId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuredEntityId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuredEntityId)) = num;
		}
	}

	public unsafe string injuryIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injuryIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe InjuryCategory category
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category);
			return *(InjuryCategory*)num;
		}
		set
		{
			*(InjuryCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category)) = injuryCategory;
		}
	}

	public unsafe InjuryLocation location
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
			return *(InjuryLocation*)num;
		}
		set
		{
			*(InjuryLocation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)) = injuryLocation;
		}
	}

	public unsafe float startingDurabilityPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDurabilityPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDurabilityPercentage)) = num;
		}
	}

	public unsafe float startingCleanlinessPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCleanlinessPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCleanlinessPercentage)) = num;
		}
	}

	static ApplyInjuryEventParams()
	{
		Il2CppClassPointerStore<ApplyInjuryEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ApplyInjuryEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyInjuryEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_injuredEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyInjuryEventParams>.NativeClassPtr, "injuredEntityId");
		NativeFieldInfoPtr_injuryIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyInjuryEventParams>.NativeClassPtr, "injuryIdentifier");
		NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyInjuryEventParams>.NativeClassPtr, "category");
		NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyInjuryEventParams>.NativeClassPtr, "location");
		NativeFieldInfoPtr_startingDurabilityPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyInjuryEventParams>.NativeClassPtr, "startingDurabilityPercentage");
		NativeFieldInfoPtr_startingCleanlinessPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyInjuryEventParams>.NativeClassPtr, "startingCleanlinessPercentage");
	}

	public ApplyInjuryEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ApplyInjuryEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplyInjuryEventParams>.NativeClassPtr))
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class InventoryItemStackStats : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_condition;

	private static readonly System.IntPtr NativeFieldInfoPtr_durability;

	private static readonly System.IntPtr NativeFieldInfoPtr_qualityPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_rustPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_wetness;

	private static readonly System.IntPtr NativeFieldInfoPtr_hardenedPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_treatedPercentage;

	private static readonly System.IntPtr NativeFieldInfoPtr_tannedPercentage;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InventoryItemStackStats_0;

	public unsafe float condition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition)) = num;
		}
	}

	public unsafe float durability
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_durability);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_durability)) = num;
		}
	}

	public unsafe float qualityPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualityPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_qualityPercentage)) = num;
		}
	}

	public unsafe float rustPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rustPercentage)) = num;
		}
	}

	public unsafe float wetness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wetness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wetness)) = num;
		}
	}

	public unsafe float hardenedPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardenedPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardenedPercentage)) = num;
		}
	}

	public unsafe float treatedPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatedPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatedPercentage)) = num;
		}
	}

	public unsafe float tannedPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tannedPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tannedPercentage)) = num;
		}
	}

	static InventoryItemStackStats()
	{
		Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InventoryItemStackStats");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr);
		NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr, "condition");
		NativeFieldInfoPtr_durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr, "durability");
		NativeFieldInfoPtr_qualityPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr, "qualityPercentage");
		NativeFieldInfoPtr_rustPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr, "rustPercentage");
		NativeFieldInfoPtr_wetness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr, "wetness");
		NativeFieldInfoPtr_hardenedPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr, "hardenedPercentage");
		NativeFieldInfoPtr_treatedPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr, "treatedPercentage");
		NativeFieldInfoPtr_tannedPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr, "tannedPercentage");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr, 100673448);
		NativeMethodInfoPtr__ctor_Public_Void_InventoryItemStackStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr, 100673449);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InventoryItemStackStats()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140909, XrefRangeEnd = 140910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InventoryItemStackStats(InventoryItemStackStats stat)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryItemStackStats>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stat);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InventoryItemStackStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InventoryItemStackStats(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

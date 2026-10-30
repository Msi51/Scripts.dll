using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class AddInventoryResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_fits;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemResults;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddItemQuantity_Public_Void_InventoryItem_Int32_0;

	public unsafe bool fits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fits);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fits)) = flag;
		}
	}

	public unsafe Dictionary<InventoryItem, int> itemResults
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemResults);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InventoryItem, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemResults)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static AddInventoryResult()
	{
		Il2CppClassPointerStore<AddInventoryResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AddInventoryResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddInventoryResult>.NativeClassPtr);
		NativeFieldInfoPtr_fits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddInventoryResult>.NativeClassPtr, "fits");
		NativeFieldInfoPtr_itemResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddInventoryResult>.NativeClassPtr, "itemResults");
		NativeMethodInfoPtr_AddItemQuantity_Public_Void_InventoryItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddInventoryResult>.NativeClassPtr, 100672929);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 134144, RefRangeEnd = 134146, XrefRangeStart = 134127, XrefRangeEnd = 134144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddItemQuantity(InventoryItem item, int quantity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quantity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddItemQuantity_Public_Void_InventoryItem_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AddInventoryResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AddInventoryResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddInventoryResult>.NativeClassPtr))
	{
	}
}

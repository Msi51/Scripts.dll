using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

public class InventoryColumnUI : UIComponent
{
	private static readonly IntPtr NativeFieldInfoPtr_inventoriesLayoutGroup;

	private static readonly IntPtr NativeFieldInfoPtr_numSlots;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe LayoutGroup inventoriesLayoutGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoriesLayoutGroup);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoriesLayoutGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutGroup));
		}
	}

	public unsafe int numSlots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSlots);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numSlots)) = num;
		}
	}

	static InventoryColumnUI()
	{
		Il2CppClassPointerStore<InventoryColumnUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InventoryColumnUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryColumnUI>.NativeClassPtr);
		NativeFieldInfoPtr_inventoriesLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryColumnUI>.NativeClassPtr, "inventoriesLayoutGroup");
		NativeFieldInfoPtr_numSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryColumnUI>.NativeClassPtr, "numSlots");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryColumnUI>.NativeClassPtr, 100665404);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InventoryColumnUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryColumnUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InventoryColumnUI(IntPtr pointer)
		: base(pointer)
	{
	}
}

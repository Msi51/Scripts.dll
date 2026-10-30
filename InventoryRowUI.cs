using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class InventoryRowUI : UIComponent
{
	private static readonly IntPtr NativeFieldInfoPtr_numSlots;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	static InventoryRowUI()
	{
		Il2CppClassPointerStore<InventoryRowUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InventoryRowUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryRowUI>.NativeClassPtr);
		NativeFieldInfoPtr_numSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryRowUI>.NativeClassPtr, "numSlots");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryRowUI>.NativeClassPtr, 100665412);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 19009, RefRangeEnd = 19066, XrefRangeStart = 19009, XrefRangeEnd = 19066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InventoryRowUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryRowUI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InventoryRowUI(IntPtr pointer)
		: base(pointer)
	{
	}
}

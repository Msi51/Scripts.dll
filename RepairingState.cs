using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class RepairingState : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_activeRecipe;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeRepairStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressPercentage;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RepairRecipe activeRecipe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeRecipe);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RepairRecipe>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeRecipe)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)repairRecipe));
		}
	}

	public unsafe InventoryItemStack activeRepairStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeRepairStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeRepairStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryItemStack));
		}
	}

	public unsafe float progressPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressPercentage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressPercentage)) = num;
		}
	}

	static RepairingState()
	{
		Il2CppClassPointerStore<RepairingState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RepairingState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RepairingState>.NativeClassPtr);
		NativeFieldInfoPtr_activeRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairingState>.NativeClassPtr, "activeRecipe");
		NativeFieldInfoPtr_activeRepairStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairingState>.NativeClassPtr, "activeRepairStack");
		NativeFieldInfoPtr_progressPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RepairingState>.NativeClassPtr, "progressPercentage");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RepairingState>.NativeClassPtr, 100679236);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RepairingState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RepairingState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RepairingState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

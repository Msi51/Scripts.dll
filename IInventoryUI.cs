using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IInventoryUI : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetInventory_Public_Abstract_Virtual_New_Inventory_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAttachedWindow_Public_Abstract_Virtual_New_UIWindow_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetValidItemTags_Public_Abstract_Virtual_New_Void_HashSet_1_ItemTag_0;

	static IInventoryUI()
	{
		Il2CppClassPointerStore<IInventoryUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IInventoryUI");
		NativeMethodInfoPtr_GetInventory_Public_Abstract_Virtual_New_Inventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryUI>.NativeClassPtr, 100667607);
		NativeMethodInfoPtr_GetAttachedWindow_Public_Abstract_Virtual_New_UIWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryUI>.NativeClassPtr, 100667608);
		NativeMethodInfoPtr_GetValidItemTags_Public_Abstract_Virtual_New_Void_HashSet_1_ItemTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryUI>.NativeClassPtr, 100667609);
	}

	[CallerCount(0)]
	public unsafe virtual Inventory GetInventory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInventory_Public_Abstract_Virtual_New_Inventory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Inventory>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual UIWindow GetAttachedWindow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAttachedWindow_Public_Abstract_Virtual_New_UIWindow_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UIWindow>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void GetValidItemTags(HashSet<ItemTag> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetValidItemTags_Public_Abstract_Virtual_New_Void_HashSet_1_ItemTag_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IInventoryUI(IntPtr pointer)
		: base(pointer)
	{
	}
}

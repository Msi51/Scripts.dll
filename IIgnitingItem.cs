using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IIgnitingItem : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetItemStack_Public_Abstract_Virtual_New_Void_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemStack_Public_Abstract_Virtual_New_InventoryItemStack_0;

	static IIgnitingItem()
	{
		Il2CppClassPointerStore<IIgnitingItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IIgnitingItem");
		NativeMethodInfoPtr_SetItemStack_Public_Abstract_Virtual_New_Void_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIgnitingItem>.NativeClassPtr, 100681631);
		NativeMethodInfoPtr_GetItemStack_Public_Abstract_Virtual_New_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIgnitingItem>.NativeClassPtr, 100681632);
	}

	[CallerCount(0)]
	public unsafe virtual void SetItemStack(InventoryItemStack itemStack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemStack);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetItemStack_Public_Abstract_Virtual_New_Void_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItemStack GetItemStack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetItemStack_Public_Abstract_Virtual_New_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	public IIgnitingItem(IntPtr pointer)
		: base(pointer)
	{
	}
}

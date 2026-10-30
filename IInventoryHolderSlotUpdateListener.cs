using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IInventoryHolderSlotUpdateListener : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetSlotForUpdate_Public_Abstract_Virtual_New_InventorySlot_NetworkInventoryHolderSlotUpdate_0;

	static IInventoryHolderSlotUpdateListener()
	{
		Il2CppClassPointerStore<IInventoryHolderSlotUpdateListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IInventoryHolderSlotUpdateListener");
		NativeMethodInfoPtr_GetSlotForUpdate_Public_Abstract_Virtual_New_InventorySlot_NetworkInventoryHolderSlotUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInventoryHolderSlotUpdateListener>.NativeClassPtr, 100663792);
	}

	[CallerCount(0)]
	public unsafe virtual InventorySlot GetSlotForUpdate(NetworkInventoryHolderSlotUpdate update)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)update));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSlotForUpdate_Public_Abstract_Virtual_New_InventorySlot_NetworkInventoryHolderSlotUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventorySlot>(intPtr) : null;
	}

	public IInventoryHolderSlotUpdateListener(IntPtr pointer)
		: base(pointer)
	{
	}
}

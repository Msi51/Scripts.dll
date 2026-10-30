using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IStockpile : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetStockpiledItemStack_Public_Abstract_Virtual_New_Void_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStockpiledItem_Public_Abstract_Virtual_New_InventoryItem_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetStockpiledItemStack_Public_Abstract_Virtual_New_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMaxStackSize_Public_Abstract_Virtual_New_Int32_0;

	static IStockpile()
	{
		Il2CppClassPointerStore<IStockpile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IStockpile");
		NativeMethodInfoPtr_SetStockpiledItemStack_Public_Abstract_Virtual_New_Void_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStockpile>.NativeClassPtr, 100682023);
		NativeMethodInfoPtr_GetStockpiledItem_Public_Abstract_Virtual_New_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStockpile>.NativeClassPtr, 100682024);
		NativeMethodInfoPtr_GetStockpiledItemStack_Public_Abstract_Virtual_New_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStockpile>.NativeClassPtr, 100682025);
		NativeMethodInfoPtr_GetMaxStackSize_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStockpile>.NativeClassPtr, 100682026);
	}

	[CallerCount(0)]
	public unsafe virtual void SetStockpiledItemStack(InventoryItemStack itemStack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemStack);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetStockpiledItemStack_Public_Abstract_Virtual_New_Void_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItem GetStockpiledItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStockpiledItem_Public_Abstract_Virtual_New_InventoryItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItem>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual InventoryItemStack GetStockpiledItemStack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStockpiledItemStack_Public_Abstract_Virtual_New_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryItemStack>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual int GetMaxStackSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMaxStackSize_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IStockpile(IntPtr pointer)
		: base(pointer)
	{
	}
}

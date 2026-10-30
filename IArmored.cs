using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class IArmored : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetBlockedItem_Public_Abstract_Virtual_New_Void_ActionType_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBlockingItemStacks_Public_Abstract_Virtual_New_Void_Vector3_List_1_InventoryItemStack_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAllArmorItemStacks_Public_Abstract_Virtual_New_Void_Vector3_List_1_InventoryItemStack_0;

	static IArmored()
	{
		Il2CppClassPointerStore<IArmored>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IArmored");
		NativeMethodInfoPtr_SetBlockedItem_Public_Abstract_Virtual_New_Void_ActionType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArmored>.NativeClassPtr, 100681216);
		NativeMethodInfoPtr_GetBlockingItemStacks_Public_Abstract_Virtual_New_Void_Vector3_List_1_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArmored>.NativeClassPtr, 100681217);
		NativeMethodInfoPtr_GetAllArmorItemStacks_Public_Abstract_Virtual_New_Void_Vector3_List_1_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArmored>.NativeClassPtr, 100681218);
	}

	[CallerCount(0)]
	public unsafe virtual void SetBlockedItem(ActionType actionType, bool active)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&actionType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &active;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetBlockedItem_Public_Abstract_Virtual_New_Void_ActionType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetBlockingItemStacks(Vector3 direction, List<InventoryItemStack> blockingStacks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&direction);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blockingStacks);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBlockingItemStacks_Public_Abstract_Virtual_New_Void_Vector3_List_1_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetAllArmorItemStacks(Vector3 direction, List<InventoryItemStack> armorStacks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&direction);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)armorStacks);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAllArmorItemStacks_Public_Abstract_Virtual_New_Void_Vector3_List_1_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IArmored(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class ISmokeRack : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetSmokingInventorySection_Public_Abstract_Virtual_New_IInventorySection_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetHeatSourceObject_Public_Abstract_Virtual_New_GameObject_0;

	static ISmokeRack()
	{
		Il2CppClassPointerStore<ISmokeRack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISmokeRack");
		NativeMethodInfoPtr_GetSmokingInventorySection_Public_Abstract_Virtual_New_IInventorySection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISmokeRack>.NativeClassPtr, 100681998);
		NativeMethodInfoPtr_GetHeatSourceObject_Public_Abstract_Virtual_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISmokeRack>.NativeClassPtr, 100681999);
	}

	[CallerCount(0)]
	public unsafe virtual IInventorySection GetSmokingInventorySection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSmokingInventorySection_Public_Abstract_Virtual_New_IInventorySection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInventorySection>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameObject GetHeatSourceObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHeatSourceObject_Public_Abstract_Virtual_New_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	public ISmokeRack(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class IIndoorLevelNavigator : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetInTriggerObjects_Public_Abstract_Virtual_New_HashSet_1_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLowestTriggerLevel_Public_Abstract_Virtual_New_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetLowestTriggerLevel_Public_Abstract_Virtual_New_Int32_0;

	static IIndoorLevelNavigator()
	{
		Il2CppClassPointerStore<IIndoorLevelNavigator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IIndoorLevelNavigator");
		NativeMethodInfoPtr_GetInTriggerObjects_Public_Abstract_Virtual_New_HashSet_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIndoorLevelNavigator>.NativeClassPtr, 100681633);
		NativeMethodInfoPtr_SetLowestTriggerLevel_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIndoorLevelNavigator>.NativeClassPtr, 100681634);
		NativeMethodInfoPtr_GetLowestTriggerLevel_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIndoorLevelNavigator>.NativeClassPtr, 100681635);
	}

	[CallerCount(0)]
	public unsafe virtual HashSet<GameObject> GetInTriggerObjects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInTriggerObjects_Public_Abstract_Virtual_New_HashSet_1_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SetLowestTriggerLevel(int lowestTouchingLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&lowestTouchingLevel);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetLowestTriggerLevel_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual int GetLowestTriggerLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetLowestTriggerLevel_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IIndoorLevelNavigator(IntPtr pointer)
		: base(pointer)
	{
	}
}

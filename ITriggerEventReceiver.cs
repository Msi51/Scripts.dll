using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class ITriggerEventReceiver : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnTriggerColliderEnter_Public_Abstract_Virtual_New_Void_Collider_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnTriggerColliderExit_Public_Abstract_Virtual_New_Void_Collider_0;

	static ITriggerEventReceiver()
	{
		Il2CppClassPointerStore<ITriggerEventReceiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ITriggerEventReceiver");
		NativeMethodInfoPtr_OnTriggerColliderEnter_Public_Abstract_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggerEventReceiver>.NativeClassPtr, 100682084);
		NativeMethodInfoPtr_OnTriggerColliderExit_Public_Abstract_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggerEventReceiver>.NativeClassPtr, 100682085);
	}

	[CallerCount(0)]
	public unsafe virtual void OnTriggerColliderEnter(Collider other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnTriggerColliderEnter_Public_Abstract_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void OnTriggerColliderExit(Collider other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnTriggerColliderExit_Public_Abstract_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ITriggerEventReceiver(IntPtr pointer)
		: base(pointer)
	{
	}
}

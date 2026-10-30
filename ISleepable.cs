using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class ISleepable : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetSleepPointTransform_Public_Abstract_Virtual_New_Transform_0;

	static ISleepable()
	{
		Il2CppClassPointerStore<ISleepable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISleepable");
		NativeMethodInfoPtr_GetSleepPointTransform_Public_Abstract_Virtual_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISleepable>.NativeClassPtr, 100681991);
	}

	[CallerCount(0)]
	public unsafe virtual Transform GetSleepPointTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSleepPointTransform_Public_Abstract_Virtual_New_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	public ISleepable(IntPtr pointer)
		: base(pointer)
	{
	}
}

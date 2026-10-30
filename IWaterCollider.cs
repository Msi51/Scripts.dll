using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class IWaterCollider : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetSubmergedPercentage_Public_Abstract_Virtual_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCollidingWater_Public_Abstract_Virtual_New_Collider_0;

	static IWaterCollider()
	{
		Il2CppClassPointerStore<IWaterCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IWaterCollider");
		NativeMethodInfoPtr_GetSubmergedPercentage_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWaterCollider>.NativeClassPtr, 100682098);
		NativeMethodInfoPtr_GetCollidingWater_Public_Abstract_Virtual_New_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWaterCollider>.NativeClassPtr, 100682099);
	}

	[CallerCount(0)]
	public unsafe virtual float GetSubmergedPercentage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSubmergedPercentage_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Collider GetCollidingWater()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCollidingWater_Public_Abstract_Virtual_New_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr) : null;
	}

	public IWaterCollider(IntPtr pointer)
		: base(pointer)
	{
	}
}

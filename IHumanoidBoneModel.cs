using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class IHumanoidBoneModel : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_JawClosedRotation_Public_Abstract_Virtual_New_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_JawOpenRotation_Public_Abstract_Virtual_New_get_Vector3_0;

	public unsafe virtual Vector3 JawClosedRotation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_JawClosedRotation_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe virtual Vector3 JawOpenRotation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_JawOpenRotation_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static IHumanoidBoneModel()
	{
		Il2CppClassPointerStore<IHumanoidBoneModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IHumanoidBoneModel");
		NativeMethodInfoPtr_get_JawClosedRotation_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidBoneModel>.NativeClassPtr, 100678293);
		NativeMethodInfoPtr_get_JawOpenRotation_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHumanoidBoneModel>.NativeClassPtr, 100678294);
	}

	public IHumanoidBoneModel(IntPtr pointer)
		: base(pointer)
	{
	}
}

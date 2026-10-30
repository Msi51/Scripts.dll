using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class IProjectileAttacher : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_AttachProjectile_Public_Abstract_Virtual_New_Void_String_Transform_Vector3_Quaternion_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveProjectiles_Public_Abstract_Virtual_New_Void_GameObject_0;

	static IProjectileAttacher()
	{
		Il2CppClassPointerStore<IProjectileAttacher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IProjectileAttacher");
		NativeMethodInfoPtr_AttachProjectile_Public_Abstract_Virtual_New_Void_String_Transform_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProjectileAttacher>.NativeClassPtr, 100681917);
		NativeMethodInfoPtr_RemoveProjectiles_Public_Abstract_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProjectileAttacher>.NativeClassPtr, 100681918);
	}

	[CallerCount(0)]
	public unsafe virtual void AttachProjectile(string identifier, Transform transform, Vector3 relativePosition, Quaternion relativeRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &relativePosition;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &relativeRotation;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AttachProjectile_Public_Abstract_Virtual_New_Void_String_Transform_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveProjectiles(GameObject equippedGameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)equippedGameObject);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveProjectiles_Public_Abstract_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IProjectileAttacher(IntPtr pointer)
		: base(pointer)
	{
	}
}

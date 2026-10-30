using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class IParticleEffect : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetWorld_Public_Abstract_Virtual_New_Void_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorld_Public_Abstract_Virtual_New_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCollisionCallback_Public_Abstract_Virtual_New_Void_Action_3_World_GameObject_Vector3_0;

	static IParticleEffect()
	{
		Il2CppClassPointerStore<IParticleEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IParticleEffect");
		NativeMethodInfoPtr_SetWorld_Public_Abstract_Virtual_New_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParticleEffect>.NativeClassPtr, 100681781);
		NativeMethodInfoPtr_GetWorld_Public_Abstract_Virtual_New_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParticleEffect>.NativeClassPtr, 100681782);
		NativeMethodInfoPtr_SetCollisionCallback_Public_Abstract_Virtual_New_Void_Action_3_World_GameObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IParticleEffect>.NativeClassPtr, 100681783);
	}

	[CallerCount(0)]
	public unsafe virtual void SetWorld(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetWorld_Public_Abstract_Virtual_New_Void_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual World GetWorld()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWorld_Public_Abstract_Virtual_New_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SetCollisionCallback(Il2CppSystem.Action<World, GameObject, Vector3> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetCollisionCallback_Public_Abstract_Virtual_New_Void_Action_3_World_GameObject_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IParticleEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IPooledInstance : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetPool_Public_Abstract_Virtual_New_IGameObjectPool_0;

	private static readonly IntPtr NativeMethodInfoPtr_HasPool_Public_Abstract_Virtual_New_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetPool_Public_Abstract_Virtual_New_Void_IGameObjectPool_0;

	static IPooledInstance()
	{
		Il2CppClassPointerStore<IPooledInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IPooledInstance");
		NativeMethodInfoPtr_GetPool_Public_Abstract_Virtual_New_IGameObjectPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPooledInstance>.NativeClassPtr, 100681906);
		NativeMethodInfoPtr_HasPool_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPooledInstance>.NativeClassPtr, 100681907);
		NativeMethodInfoPtr_SetPool_Public_Abstract_Virtual_New_Void_IGameObjectPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPooledInstance>.NativeClassPtr, 100681908);
	}

	[CallerCount(0)]
	public unsafe virtual IGameObjectPool GetPool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPool_Public_Abstract_Virtual_New_IGameObjectPool_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IGameObjectPool>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool HasPool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HasPool_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetPool(IGameObjectPool gameObjectPool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObjectPool);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetPool_Public_Abstract_Virtual_New_Void_IGameObjectPool_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IPooledInstance(IntPtr pointer)
		: base(pointer)
	{
	}
}

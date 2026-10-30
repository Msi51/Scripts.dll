using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace strange.extensions.signal.impl;

public class ISignal : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_listener_Public_Abstract_Virtual_New_get_Delegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_listener_Public_Abstract_Virtual_New_set_Void_Delegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Abstract_Virtual_New_Void_0;

	public unsafe virtual Il2CppSystem.Delegate listener
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_listener_Public_Abstract_Virtual_New_get_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Delegate>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_listener_Public_Abstract_Virtual_New_set_Void_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ISignal()
	{
		Il2CppClassPointerStore<ISignal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.signal.impl", "ISignal");
		NativeMethodInfoPtr_get_listener_Public_Abstract_Virtual_New_get_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISignal>.NativeClassPtr, 100684271);
		NativeMethodInfoPtr_set_listener_Public_Abstract_Virtual_New_set_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISignal>.NativeClassPtr, 100684272);
		NativeMethodInfoPtr_RemoveAllListeners_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISignal>.NativeClassPtr, 100684273);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveAllListeners()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveAllListeners_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ISignal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace strange.extensions.dispatcher.eventdispatcher.api;

public class IEventBinding : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_TypeForCallback_Public_Abstract_Virtual_New_EventCallbackType_EventCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TypeForCallback_Public_Abstract_Virtual_New_EventCallbackType_EmptyCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_IEventBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_IEventBinding_EventCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_IEventBinding_EmptyCallback_0;

	static IEventBinding()
	{
		Il2CppClassPointerStore<IEventBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.dispatcher.eventdispatcher.api", "IEventBinding");
		NativeMethodInfoPtr_TypeForCallback_Public_Abstract_Virtual_New_EventCallbackType_EventCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventBinding>.NativeClassPtr, 100685012);
		NativeMethodInfoPtr_TypeForCallback_Public_Abstract_Virtual_New_EventCallbackType_EmptyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventBinding>.NativeClassPtr, 100685013);
		NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_IEventBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventBinding>.NativeClassPtr, 100685014);
		NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_IEventBinding_EventCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventBinding>.NativeClassPtr, 100685015);
		NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_IEventBinding_EmptyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventBinding>.NativeClassPtr, 100685016);
	}

	[CallerCount(0)]
	public unsafe virtual EventCallbackType TypeForCallback(EventCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TypeForCallback_Public_Abstract_Virtual_New_EventCallbackType_EventCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EventCallbackType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual EventCallbackType TypeForCallback(EmptyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TypeForCallback_Public_Abstract_Virtual_New_EventCallbackType_EmptyCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EventCallbackType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual IEventBinding Bind(Il2CppSystem.Object key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_IEventBinding_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IEventBinding To(EventCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_IEventBinding_EventCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IEventBinding To(EmptyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_To_Public_Abstract_Virtual_New_IEventBinding_EmptyCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventBinding>(intPtr) : null;
	}

	public IEventBinding(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

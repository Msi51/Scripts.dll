using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace strange.extensions.dispatcher.eventdispatcher.api;

public class IEventDispatcher : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_IEventBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Object_EventCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Object_EmptyCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Object_EventCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Object_EmptyCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasListener_Public_Abstract_Virtual_New_Boolean_Object_EventCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasListener_Public_Abstract_Virtual_New_Boolean_Object_EmptyCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateListener_Public_Abstract_Virtual_New_Void_Boolean_Object_EventCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateListener_Public_Abstract_Virtual_New_Void_Boolean_Object_EmptyCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseEvent_Public_Abstract_Virtual_New_Void_IEvent_0;

	static IEventDispatcher()
	{
		Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.dispatcher.eventdispatcher.api", "IEventDispatcher");
		NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_IEventBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr, 100685017);
		NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Object_EventCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr, 100685018);
		NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Object_EmptyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr, 100685019);
		NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Object_EventCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr, 100685020);
		NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Object_EmptyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr, 100685021);
		NativeMethodInfoPtr_HasListener_Public_Abstract_Virtual_New_Boolean_Object_EventCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr, 100685022);
		NativeMethodInfoPtr_HasListener_Public_Abstract_Virtual_New_Boolean_Object_EmptyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr, 100685023);
		NativeMethodInfoPtr_UpdateListener_Public_Abstract_Virtual_New_Void_Boolean_Object_EventCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr, 100685024);
		NativeMethodInfoPtr_UpdateListener_Public_Abstract_Virtual_New_Void_Boolean_Object_EmptyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr, 100685025);
		NativeMethodInfoPtr_ReleaseEvent_Public_Abstract_Virtual_New_Void_IEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventDispatcher>.NativeClassPtr, 100685026);
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
	public unsafe virtual void AddListener(Il2CppSystem.Object evt, EventCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Object_EventCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddListener(Il2CppSystem.Object evt, EmptyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddListener_Public_Abstract_Virtual_New_Void_Object_EmptyCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveListener(Il2CppSystem.Object evt, EventCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Object_EventCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveListener(Il2CppSystem.Object evt, EmptyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveListener_Public_Abstract_Virtual_New_Void_Object_EmptyCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool HasListener(Il2CppSystem.Object evt, EventCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HasListener_Public_Abstract_Virtual_New_Boolean_Object_EventCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool HasListener(Il2CppSystem.Object evt, EmptyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HasListener_Public_Abstract_Virtual_New_Boolean_Object_EmptyCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UpdateListener(bool toAdd, Il2CppSystem.Object evt, EventCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&toAdd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateListener_Public_Abstract_Virtual_New_Void_Boolean_Object_EventCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void UpdateListener(bool toAdd, Il2CppSystem.Object evt, EmptyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&toAdd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateListener_Public_Abstract_Virtual_New_Void_Boolean_Object_EmptyCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void ReleaseEvent(IEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseEvent_Public_Abstract_Virtual_New_Void_IEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IEventDispatcher(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

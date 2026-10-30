using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.framework.impl;

namespace strange.extensions.dispatcher.eventdispatcher.impl;

public class EventBinding : Binding
{
	private static readonly System.IntPtr NativeFieldInfoPtr_callbackTypes;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BindingResolver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TypeForCallback_Public_Virtual_Final_New_EventCallbackType_EmptyCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TypeForCallback_Public_Virtual_Final_New_EventCallbackType_EventCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Final_New_IEventBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To_Public_Virtual_Final_New_IEventBinding_EventCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To_Public_Virtual_Final_New_IEventBinding_EmptyCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To_Public_IEventBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveValue_Public_Virtual_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_storeMethodType_Private_Void_Delegate_0;

	public unsafe Dictionary<Il2CppSystem.Delegate, EventCallbackType> callbackTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callbackTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Delegate, EventCallbackType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callbackTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static EventBinding()
	{
		Il2CppClassPointerStore<EventBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.dispatcher.eventdispatcher.impl", "EventBinding");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventBinding>.NativeClassPtr);
		NativeFieldInfoPtr_callbackTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, "callbackTypes");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, 100684944);
		NativeMethodInfoPtr__ctor_Public_Void_BindingResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, 100684945);
		NativeMethodInfoPtr_TypeForCallback_Public_Virtual_Final_New_EventCallbackType_EmptyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, 100684946);
		NativeMethodInfoPtr_TypeForCallback_Public_Virtual_Final_New_EventCallbackType_EventCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, 100684947);
		NativeMethodInfoPtr_Bind_Public_Virtual_Final_New_IEventBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, 100684948);
		NativeMethodInfoPtr_To_Public_Virtual_Final_New_IEventBinding_EventCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, 100684949);
		NativeMethodInfoPtr_To_Public_Virtual_Final_New_IEventBinding_EmptyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, 100684950);
		NativeMethodInfoPtr_To_Public_IEventBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, 100684951);
		NativeMethodInfoPtr_RemoveValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, 100684952);
		NativeMethodInfoPtr_storeMethodType_Private_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBinding>.NativeClassPtr, 100684953);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280843, XrefRangeEnd = 280844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventBinding()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventBinding>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 280855, RefRangeEnd = 280857, XrefRangeStart = 280844, XrefRangeEnd = 280855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventBinding(Binder.BindingResolver resolver)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventBinding>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resolver);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BindingResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280857, XrefRangeEnd = 280861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual EventCallbackType TypeForCallback(EmptyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TypeForCallback_Public_Virtual_Final_New_EventCallbackType_EmptyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EventCallbackType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280861, XrefRangeEnd = 280865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual EventCallbackType TypeForCallback(EventCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TypeForCallback_Public_Virtual_Final_New_EventCallbackType_EventCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EventCallbackType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280865, XrefRangeEnd = 280869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual IEventBinding Bind(Il2CppSystem.Object key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bind_Public_Virtual_Final_New_IEventBinding_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280869, XrefRangeEnd = 280871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEventBinding To(EventCallback value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_To_Public_Virtual_Final_New_IEventBinding_EventCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEventBinding To(EmptyCallback value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_To_Public_Virtual_Final_New_IEventBinding_EmptyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280871, XrefRangeEnd = 280877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe IEventBinding To(Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_To_Public_IEventBinding_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280877, XrefRangeEnd = 280886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void RemoveValue(Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 280907, RefRangeEnd = 280910, XrefRangeStart = 280886, XrefRangeEnd = 280907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void storeMethodType(Il2CppSystem.Delegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_storeMethodType_Private_Void_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EventBinding(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

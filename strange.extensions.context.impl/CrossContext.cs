using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using strange.extensions.context.api;
using strange.extensions.dispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.injector.api;
using strange.framework.api;

namespace strange.extensions.context.impl;

public class CrossContext : Context
{
	private static readonly System.IntPtr NativeFieldInfoPtr__injectionBinder;

	private static readonly System.IntPtr NativeFieldInfoPtr__crossContextBridge;

	private static readonly System.IntPtr NativeFieldInfoPtr__crossContextDispatcher;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_injectionBinder_Public_Virtual_Final_New_get_ICrossContextInjectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_injectionBinder_Public_Virtual_Final_New_set_Void_ICrossContextInjectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_ContextStartupFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addCoreComponents_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_instantiateCoreComponents_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddContext_Public_Virtual_IContext_IContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignCrossContext_Public_Virtual_New_Void_ICrossContextCapable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCrossContext_Public_Virtual_New_Void_ICrossContextCapable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveContext_Public_Virtual_IContext_IContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_crossContextDispatcher_Public_Virtual_New_get_IDispatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_crossContextDispatcher_Public_Virtual_New_set_Void_IDispatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_crossContextBridge_Public_Virtual_New_get_IBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_crossContextBridge_Public_Virtual_New_set_Void_IBinder_0;

	public unsafe ICrossContextInjectionBinder _injectionBinder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__injectionBinder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICrossContextInjectionBinder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__injectionBinder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)crossContextInjectionBinder));
		}
	}

	public unsafe IBinder _crossContextBridge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__crossContextBridge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IBinder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__crossContextBridge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binder));
		}
	}

	public unsafe IEventDispatcher _crossContextDispatcher
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__crossContextDispatcher);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEventDispatcher>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__crossContextDispatcher)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventDispatcher));
		}
	}

	public unsafe virtual ICrossContextInjectionBinder injectionBinder
	{
		[CallerCount(93)]
		[CachedScanResults(RefRangeStart = 281276, RefRangeEnd = 281369, XrefRangeStart = 281271, XrefRangeEnd = 281276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_injectionBinder_Public_Virtual_Final_New_get_ICrossContextInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICrossContextInjectionBinder>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_injectionBinder_Public_Virtual_Final_New_set_Void_ICrossContextInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual IDispatcher crossContextDispatcher
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_crossContextDispatcher_Public_Virtual_New_get_IDispatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDispatcher>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281498, XrefRangeEnd = 281504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_crossContextDispatcher_Public_Virtual_New_set_Void_IDispatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual IBinder crossContextBridge
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281504, XrefRangeEnd = 281510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_crossContextBridge_Public_Virtual_New_get_IBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IBinder>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281510, XrefRangeEnd = 281516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_crossContextBridge_Public_Virtual_New_set_Void_IBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static CrossContext()
	{
		Il2CppClassPointerStore<CrossContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.context.impl", "CrossContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossContext>.NativeClassPtr);
		NativeFieldInfoPtr__injectionBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, "_injectionBinder");
		NativeFieldInfoPtr__crossContextBridge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, "_crossContextBridge");
		NativeFieldInfoPtr__crossContextDispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, "_crossContextDispatcher");
		NativeMethodInfoPtr_get_injectionBinder_Public_Virtual_Final_New_get_ICrossContextInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685072);
		NativeMethodInfoPtr_set_injectionBinder_Public_Virtual_Final_New_set_Void_ICrossContextInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685073);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685074);
		NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685075);
		NativeMethodInfoPtr__ctor_Public_Void_Object_ContextStartupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685076);
		NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685077);
		NativeMethodInfoPtr_addCoreComponents_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685078);
		NativeMethodInfoPtr_instantiateCoreComponents_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685079);
		NativeMethodInfoPtr_AddContext_Public_Virtual_IContext_IContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685080);
		NativeMethodInfoPtr_AssignCrossContext_Public_Virtual_New_Void_ICrossContextCapable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685081);
		NativeMethodInfoPtr_RemoveCrossContext_Public_Virtual_New_Void_ICrossContextCapable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685082);
		NativeMethodInfoPtr_RemoveContext_Public_Virtual_IContext_IContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685083);
		NativeMethodInfoPtr_get_crossContextDispatcher_Public_Virtual_New_get_IDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685084);
		NativeMethodInfoPtr_set_crossContextDispatcher_Public_Virtual_New_set_Void_IDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685085);
		NativeMethodInfoPtr_get_crossContextBridge_Public_Virtual_New_get_IBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685086);
		NativeMethodInfoPtr_set_crossContextBridge_Public_Virtual_New_set_Void_IBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContext>.NativeClassPtr, 100685087);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CrossContext()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CrossContext(Il2CppSystem.Object view)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281369, XrefRangeEnd = 281370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CrossContext(Il2CppSystem.Object view, ContextStartupFlags flags)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		*(ContextStartupFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_ContextStartupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 281250, RefRangeEnd = 281252, XrefRangeStart = 281250, XrefRangeEnd = 281252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CrossContext(Il2CppSystem.Object view, bool autoMapping)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContext>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)view);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &autoMapping;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 281408, RefRangeEnd = 281409, XrefRangeStart = 281370, XrefRangeEnd = 281408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void addCoreComponents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_addCoreComponents_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 281445, RefRangeEnd = 281446, XrefRangeStart = 281409, XrefRangeEnd = 281445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void instantiateCoreComponents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_instantiateCoreComponents_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281446, XrefRangeEnd = 281452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IContext AddContext(IContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddContext_Public_Virtual_IContext_IContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IContext>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281452, XrefRangeEnd = 281464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AssignCrossContext(ICrossContextCapable childContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)childContext);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AssignCrossContext_Public_Virtual_New_Void_ICrossContextCapable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281464, XrefRangeEnd = 281487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveCrossContext(ICrossContextCapable childContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)childContext);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveCrossContext_Public_Virtual_New_Void_ICrossContextCapable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281487, XrefRangeEnd = 281498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IContext RemoveContext(IContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveContext_Public_Virtual_IContext_IContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IContext>(intPtr) : null;
	}

	public CrossContext(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

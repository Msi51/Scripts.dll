using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using strange.extensions.injector.api;
using strange.extensions.reflector.api;

namespace strange.extensions.injector.impl;

public class Injector : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_infinityLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_INFINITY_LIMIT;

	private static readonly System.IntPtr NativeFieldInfoPtr__factory_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__binder_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__reflector_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_factory_Public_Virtual_Final_New_get_IInjectorFactory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_factory_Public_Virtual_Final_New_set_Void_IInjectorFactory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_binder_Public_Virtual_Final_New_get_IInjectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_binder_Public_Virtual_Final_New_set_Void_IInjectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reflector_Public_Virtual_Final_New_get_IReflectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_reflector_Public_Virtual_Final_New_set_Void_IReflectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_Object_IInjectionBinding_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryInject_Public_Virtual_Final_New_Object_IInjectionBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Inject_Public_Virtual_Final_New_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Inject_Public_Virtual_Final_New_Object_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Uninject_Public_Virtual_Final_New_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_performConstructorInjection_Private_Object_Object_IReflectedClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_performSetterInjection_Private_Void_Object_IReflectedClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getValueInjection_Private_Object_Type_Object_Object_PropertyInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_injectValueIntoPoint_Private_Void_Object_Object_PropertyInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_postInject_Private_Void_Object_IReflectedClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_performUninjection_Private_Void_Object_IReflectedClass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_Type_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_Type_Object_Object_PropertyInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_Type_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_armorAgainstInfiniteLoops_Private_Void_IInjectionBinding_0;

	public unsafe Dictionary<IInjectionBinding, int> infinityLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infinityLock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<IInjectionBinding, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infinityLock)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static int INFINITY_LIMIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INFINITY_LIMIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INFINITY_LIMIT, (void*)(&num));
		}
	}

	public unsafe IInjectorFactory _factory_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__factory_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectorFactory>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__factory_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injectorFactory));
		}
	}

	public unsafe IInjectionBinder _binder_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__binder_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectionBinder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__binder_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injectionBinder));
		}
	}

	public unsafe IReflectionBinder _reflector_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflector_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IReflectionBinder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflector_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reflectionBinder));
		}
	}

	public unsafe virtual IInjectorFactory factory
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_factory_Public_Virtual_Final_New_get_IInjectorFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectorFactory>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_factory_Public_Virtual_Final_New_set_Void_IInjectorFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual IInjectionBinder binder
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18747, RefRangeEnd = 18748, XrefRangeStart = 18747, XrefRangeEnd = 18748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_binder_Public_Virtual_Final_New_get_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectionBinder>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18749, RefRangeEnd = 18750, XrefRangeStart = 18749, XrefRangeEnd = 18750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_binder_Public_Virtual_Final_New_set_Void_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual IReflectionBinder reflector
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19167, RefRangeEnd = 19170, XrefRangeStart = 19167, XrefRangeEnd = 19170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reflector_Public_Virtual_Final_New_get_IReflectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IReflectionBinder>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reflector_Public_Virtual_Final_New_set_Void_IReflectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static Injector()
	{
		Il2CppClassPointerStore<Injector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.injector.impl", "Injector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Injector>.NativeClassPtr);
		NativeFieldInfoPtr_infinityLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Injector>.NativeClassPtr, "infinityLock");
		NativeFieldInfoPtr_INFINITY_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Injector>.NativeClassPtr, "INFINITY_LIMIT");
		NativeFieldInfoPtr__factory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Injector>.NativeClassPtr, "<factory>k__BackingField");
		NativeFieldInfoPtr__binder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Injector>.NativeClassPtr, "<binder>k__BackingField");
		NativeFieldInfoPtr__reflector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Injector>.NativeClassPtr, "<reflector>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684824);
		NativeMethodInfoPtr_get_factory_Public_Virtual_Final_New_get_IInjectorFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684825);
		NativeMethodInfoPtr_set_factory_Public_Virtual_Final_New_set_Void_IInjectorFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684826);
		NativeMethodInfoPtr_get_binder_Public_Virtual_Final_New_get_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684827);
		NativeMethodInfoPtr_set_binder_Public_Virtual_Final_New_set_Void_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684828);
		NativeMethodInfoPtr_get_reflector_Public_Virtual_Final_New_get_IReflectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684829);
		NativeMethodInfoPtr_set_reflector_Public_Virtual_Final_New_set_Void_IReflectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684830);
		NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_Object_IInjectionBinding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684831);
		NativeMethodInfoPtr_TryInject_Public_Virtual_Final_New_Object_IInjectionBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684832);
		NativeMethodInfoPtr_Inject_Public_Virtual_Final_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684833);
		NativeMethodInfoPtr_Inject_Public_Virtual_Final_New_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684834);
		NativeMethodInfoPtr_Uninject_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684835);
		NativeMethodInfoPtr_performConstructorInjection_Private_Object_Object_IReflectedClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684836);
		NativeMethodInfoPtr_performSetterInjection_Private_Void_Object_IReflectedClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684837);
		NativeMethodInfoPtr_getValueInjection_Private_Object_Type_Object_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684838);
		NativeMethodInfoPtr_injectValueIntoPoint_Private_Void_Object_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684839);
		NativeMethodInfoPtr_postInject_Private_Void_Object_IReflectedClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684840);
		NativeMethodInfoPtr_performUninjection_Private_Void_Object_IReflectedClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684841);
		NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684842);
		NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684843);
		NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_Type_Object_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684844);
		NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_Type_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684845);
		NativeMethodInfoPtr_armorAgainstInfiniteLoops_Private_Void_IInjectionBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Injector>.NativeClassPtr, 100684846);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 280165, RefRangeEnd = 280167, XrefRangeStart = 280158, XrefRangeEnd = 280165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Injector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Injector>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 280257, RefRangeEnd = 280258, XrefRangeStart = 280167, XrefRangeEnd = 280257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Instantiate(IInjectionBinding binding, bool tryInjectHere)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binding);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tryInjectHere;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Instantiate_Public_Virtual_Final_New_Object_IInjectionBinding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280258, XrefRangeEnd = 280268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object TryInject(IInjectionBinding binding, Il2CppSystem.Object target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binding);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryInject_Public_Virtual_Final_New_Object_IInjectionBinding_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280268, XrefRangeEnd = 280269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Inject(Il2CppSystem.Object target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Inject_Public_Virtual_Final_New_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 280310, RefRangeEnd = 280313, XrefRangeStart = 280269, XrefRangeEnd = 280310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Inject(Il2CppSystem.Object target, bool attemptConstructorInjection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &attemptConstructorInjection;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Inject_Public_Virtual_Final_New_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280313, XrefRangeEnd = 280344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Uninject(Il2CppSystem.Object target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Uninject_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 280373, RefRangeEnd = 280374, XrefRangeStart = 280344, XrefRangeEnd = 280373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object performConstructorInjection(Il2CppSystem.Object target, IReflectedClass reflection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reflection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_performConstructorInjection_Private_Object_Object_IReflectedClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 280395, RefRangeEnd = 280396, XrefRangeStart = 280374, XrefRangeEnd = 280395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void performSetterInjection(Il2CppSystem.Object target, IReflectedClass reflection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reflection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_performSetterInjection_Private_Void_Object_IReflectedClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 280417, RefRangeEnd = 280420, XrefRangeStart = 280396, XrefRangeEnd = 280417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object getValueInjection(Il2CppSystem.Type t, Il2CppSystem.Object name, Il2CppSystem.Object target, PropertyInfo propertyInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propertyInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getValueInjection_Private_Object_Type_Object_Object_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280420, XrefRangeEnd = 280431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void injectValueIntoPoint(Il2CppSystem.Object value, Il2CppSystem.Object target, PropertyInfo point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)point);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_injectValueIntoPoint_Private_Void_Object_Object_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280431, XrefRangeEnd = 280443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void postInject(Il2CppSystem.Object target, IReflectedClass reflection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reflection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_postInject_Private_Void_Object_IReflectedClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280443, XrefRangeEnd = 280447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void performUninjection(Il2CppSystem.Object target, IReflectedClass reflection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reflection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_performUninjection_Private_Void_Object_IReflectedClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 280448, RefRangeEnd = 280471, XrefRangeStart = 280447, XrefRangeEnd = 280448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void failIf(bool condition, string message, InjectionExceptionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&condition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		*(InjectionExceptionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280471, XrefRangeEnd = 280472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void failIf(bool condition, string message, InjectionExceptionType type, Il2CppSystem.Type t, Il2CppSystem.Object name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&condition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		*(InjectionExceptionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280472, XrefRangeEnd = 280477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void failIf(bool condition, string message, InjectionExceptionType type, Il2CppSystem.Type t, Il2CppSystem.Object name, Il2CppSystem.Object target, PropertyInfo propertyInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&condition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		*(InjectionExceptionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)propertyInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_Type_Object_Object_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 280478, RefRangeEnd = 280480, XrefRangeStart = 280477, XrefRangeEnd = 280478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void failIf(bool condition, string message, InjectionExceptionType type, Il2CppSystem.Type t, Il2CppSystem.Object name, Il2CppSystem.Object target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&condition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		*(InjectionExceptionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_failIf_Private_Void_Boolean_String_InjectionExceptionType_Type_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280480, XrefRangeEnd = 280501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void armorAgainstInfiniteLoops(IInjectionBinding binding)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binding);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_armorAgainstInfiniteLoops_Private_Void_IInjectionBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Injector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

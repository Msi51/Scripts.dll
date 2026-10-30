using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using strange.extensions.injector.api;
using strange.framework.api;

namespace strange.extensions.injector.impl;

public class CrossContextInjectionBinder : InjectionBinder
{
	private sealed class MethodInfoStoreGeneric_GetBinding_Public_Virtual_IInjectionBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_0, Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetBinding_Public_Virtual_IInjectionBinding_Object_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(CrossContextInjectionBinder.NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_Object_0, Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__CrossContextBinder_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CrossContextBinder_Public_Virtual_Final_New_get_IInjectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CrossContextBinder_Public_Virtual_Final_New_set_Void_IInjectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveBinding_Public_Virtual_Void_IBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInjectorForBinding_Protected_Virtual_IInjector_IInjectionBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unbind_Public_Virtual_Void_Object_Object_0;

	public unsafe IInjectionBinder _CrossContextBinder_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CrossContextBinder_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectionBinder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CrossContextBinder_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injectionBinder));
		}
	}

	public unsafe virtual IInjectionBinder CrossContextBinder
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 977, RefRangeEnd = 983, XrefRangeStart = 977, XrefRangeEnd = 983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CrossContextBinder_Public_Virtual_Final_New_get_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectionBinder>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CrossContextBinder_Public_Virtual_Final_New_set_Void_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static CrossContextInjectionBinder()
	{
		Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.injector.impl", "CrossContextInjectionBinder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr);
		NativeFieldInfoPtr__CrossContextBinder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, "<CrossContextBinder>k__BackingField");
		NativeMethodInfoPtr_get_CrossContextBinder_Public_Virtual_Final_New_get_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, 100684759);
		NativeMethodInfoPtr_set_CrossContextBinder_Public_Virtual_Final_New_set_Void_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, 100684760);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, 100684761);
		NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, 100684762);
		CrossContextInjectionBinder.NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, 100684763);
		CrossContextInjectionBinder.NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, 100684764);
		NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, 100684765);
		NativeMethodInfoPtr_ResolveBinding_Public_Virtual_Void_IBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, 100684766);
		NativeMethodInfoPtr_GetInjectorForBinding_Protected_Virtual_IInjector_IInjectionBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, 100684767);
		NativeMethodInfoPtr_Unbind_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr, 100684768);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 279614, RefRangeEnd = 279616, XrefRangeStart = 279586, XrefRangeEnd = 279614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CrossContextInjectionBinder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContextInjectionBinder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279616, XrefRangeEnd = 279621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IInjectionBinding GetBinding<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_GetBinding_Public_Virtual_IInjectionBinding_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectionBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279621, XrefRangeEnd = 279626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IInjectionBinding GetBinding<T>(Il2CppSystem.Object name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_GetBinding_Public_Virtual_IInjectionBinding_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectionBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe override IInjectionBinding GetBinding(Il2CppSystem.Object key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), CrossContextInjectionBinder.NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectionBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279626, XrefRangeEnd = 279633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IInjectionBinding GetBinding(Il2CppSystem.Object key, Il2CppSystem.Object name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetBinding_Public_Virtual_IInjectionBinding_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectionBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279633, XrefRangeEnd = 279641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ResolveBinding(IBinding binding, Il2CppSystem.Object key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binding);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ResolveBinding_Public_Virtual_Void_IBinding_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279641, XrefRangeEnd = 279647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IInjector GetInjectorForBinding(IInjectionBinding binding)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binding);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInjectorForBinding_Protected_Virtual_IInjector_IInjectionBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjector>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279647, XrefRangeEnd = 279654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Unbind(Il2CppSystem.Object key, Il2CppSystem.Object name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Unbind_Public_Virtual_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CrossContextInjectionBinder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

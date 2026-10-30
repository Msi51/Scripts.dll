using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using strange.extensions.mediation.api;
using strange.framework.api;
using strange.framework.impl;

namespace strange.extensions.mediation.impl;

public class MediationBinding : Binding
{
	private sealed class MethodInfoStoreGeneric_strange_extensions_mediation_api_IMediationBinding_ToMediator_Private_Virtual_Final_New_IMediationBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_strange_extensions_mediation_api_IMediationBinding_ToMediator_Private_Virtual_Final_New_IMediationBinding_0, Il2CppClassPointerStore<MediationBinding>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_strange_extensions_mediation_api_IMediationBinding_ToAbstraction_Private_Virtual_Final_New_IMediationBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_strange_extensions_mediation_api_IMediationBinding_ToAbstraction_Private_Virtual_Final_New_IMediationBinding_0, Il2CppClassPointerStore<MediationBinding>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Bind_Public_Virtual_Final_New_IMediationBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Bind_Public_Virtual_Final_New_IMediationBinding_0, Il2CppClassPointerStore<MediationBinding>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_To_Public_Virtual_Final_New_IMediationBinding_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_To_Public_Virtual_Final_New_IMediationBinding_0, Il2CppClassPointerStore<MediationBinding>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__abstraction;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BindingResolver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_strange_extensions_mediation_api_IMediationBinding_ToMediator_Private_Virtual_Final_New_IMediationBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_strange_extensions_mediation_api_IMediationBinding_ToAbstraction_Private_Virtual_Final_New_IMediationBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_strange_extensions_mediation_api_IMediationBinding_ToAbstraction_Private_Virtual_Final_New_IMediationBinding_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_abstraction_Public_Virtual_Final_New_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Final_New_IMediationBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Final_New_IMediationBinding_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To_Public_Virtual_Final_New_IMediationBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_To_Public_Virtual_Final_New_IMediationBinding_Object_0;

	public unsafe ISemiBinding _abstraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__abstraction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISemiBinding>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__abstraction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)semiBinding));
		}
	}

	public unsafe virtual Il2CppSystem.Object abstraction
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279520, XrefRangeEnd = 279526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_abstraction_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
	}

	static MediationBinding()
	{
		Il2CppClassPointerStore<MediationBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.mediation.impl", "MediationBinding");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr);
		NativeFieldInfoPtr__abstraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr, "_abstraction");
		NativeMethodInfoPtr__ctor_Public_Void_BindingResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr, 100684698);
		NativeMethodInfoPtr_strange_extensions_mediation_api_IMediationBinding_ToMediator_Private_Virtual_Final_New_IMediationBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr, 100684699);
		NativeMethodInfoPtr_strange_extensions_mediation_api_IMediationBinding_ToAbstraction_Private_Virtual_Final_New_IMediationBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr, 100684700);
		NativeMethodInfoPtr_strange_extensions_mediation_api_IMediationBinding_ToAbstraction_Private_Virtual_Final_New_IMediationBinding_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr, 100684701);
		NativeMethodInfoPtr_get_abstraction_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr, 100684702);
		NativeMethodInfoPtr_Bind_Public_Virtual_Final_New_IMediationBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr, 100684703);
		NativeMethodInfoPtr_Bind_Public_Virtual_Final_New_IMediationBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr, 100684704);
		NativeMethodInfoPtr_To_Public_Virtual_Final_New_IMediationBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr, 100684705);
		NativeMethodInfoPtr_To_Public_Virtual_Final_New_IMediationBinding_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr, 100684706);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279479, XrefRangeEnd = 279489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MediationBinding(strange.framework.impl.Binder.BindingResolver resolver)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediationBinding>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resolver);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BindingResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279489, XrefRangeEnd = 279498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IMediationBinding strange_extensions_mediation_api_IMediationBinding_ToMediator<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_strange_extensions_mediation_api_IMediationBinding_ToMediator_Private_Virtual_Final_New_IMediationBinding_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMediationBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279498, XrefRangeEnd = 279507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IMediationBinding strange_extensions_mediation_api_IMediationBinding_ToAbstraction<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_strange_extensions_mediation_api_IMediationBinding_ToAbstraction_Private_Virtual_Final_New_IMediationBinding_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMediationBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279507, XrefRangeEnd = 279520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IMediationBinding strange_extensions_mediation_api_IMediationBinding_ToAbstraction(Il2CppSystem.Type t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_strange_extensions_mediation_api_IMediationBinding_ToAbstraction_Private_Virtual_Final_New_IMediationBinding_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMediationBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279526, XrefRangeEnd = 279530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual IMediationBinding Bind<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Bind_Public_Virtual_Final_New_IMediationBinding_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMediationBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279530, XrefRangeEnd = 279537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual IMediationBinding Bind(Il2CppSystem.Object key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bind_Public_Virtual_Final_New_IMediationBinding_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMediationBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279537, XrefRangeEnd = 279541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual IMediationBinding To<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_To_Public_Virtual_Final_New_IMediationBinding_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMediationBinding>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279541, XrefRangeEnd = 279548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual IMediationBinding To(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_To_Public_Virtual_Final_New_IMediationBinding_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMediationBinding>(intPtr) : null;
	}

	public MediationBinding(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

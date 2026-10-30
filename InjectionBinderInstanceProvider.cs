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

public class InjectionBinderInstanceProvider : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetInstance_Public_Virtual_Final_New_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetInstance_Public_Virtual_Final_New_T_0, Il2CppClassPointerStore<InjectionBinderInstanceProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_injectionBinder;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IInjectionBinder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstance_Public_Virtual_Final_New_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstance_Public_Virtual_Final_New_Object_Type_0;

	public unsafe IInjectionBinder injectionBinder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injectionBinder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInjectionBinder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injectionBinder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injectionBinder));
		}
	}

	static InjectionBinderInstanceProvider()
	{
		Il2CppClassPointerStore<InjectionBinderInstanceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "InjectionBinderInstanceProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InjectionBinderInstanceProvider>.NativeClassPtr);
		NativeFieldInfoPtr_injectionBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InjectionBinderInstanceProvider>.NativeClassPtr, "injectionBinder");
		NativeMethodInfoPtr__ctor_Public_Void_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionBinderInstanceProvider>.NativeClassPtr, 100669807);
		NativeMethodInfoPtr_GetInstance_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionBinderInstanceProvider>.NativeClassPtr, 100669808);
		NativeMethodInfoPtr_GetInstance_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InjectionBinderInstanceProvider>.NativeClassPtr, 100669809);
	}

	[CallerCount(76)]
	[CachedScanResults(RefRangeStart = 70954, RefRangeEnd = 71030, XrefRangeStart = 70954, XrefRangeEnd = 71030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InjectionBinderInstanceProvider(IInjectionBinder injectionBinder)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InjectionBinderInstanceProvider>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)injectionBinder);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IInjectionBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 107191, RefRangeEnd = 107337, XrefRangeStart = 107189, XrefRangeEnd = 107191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual T GetInstance<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetInstance_Public_Virtual_Final_New_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107337, XrefRangeEnd = 107341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object GetInstance(Il2CppSystem.Type key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstance_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public InjectionBinderInstanceProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace strange.extensions.injector.api;

public class IInjectorFactory : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_IInjectionBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_IInjectionBinding_Il2CppReferenceArray_1_Object_0;

	static IInjectorFactory()
	{
		Il2CppClassPointerStore<IInjectorFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.injector.api", "IInjectorFactory");
		NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_IInjectionBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjectorFactory>.NativeClassPtr, 100684921);
		NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_IInjectionBinding_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInjectorFactory>.NativeClassPtr, 100684922);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppSystem.Object Get(IInjectionBinding binding)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binding);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_IInjectionBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppSystem.Object Get(IInjectionBinding binding, Il2CppReferenceArray<Il2CppSystem.Object> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binding);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Object_IInjectionBinding_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public IInjectorFactory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

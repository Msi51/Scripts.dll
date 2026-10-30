using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace strange.extensions.reflector.api;

public class IReflectionBinder : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_Get_Public_Abstract_Virtual_New_IReflectedClass_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_IReflectedClass_0, Il2CppClassPointerStore<IReflectionBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_IReflectedClass_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_IReflectedClass_0;

	static IReflectionBinder()
	{
		Il2CppClassPointerStore<IReflectionBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.reflector.api", "IReflectionBinder");
		NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_IReflectedClass_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReflectionBinder>.NativeClassPtr, 100684494);
		NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_IReflectedClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReflectionBinder>.NativeClassPtr, 100684495);
	}

	[CallerCount(0)]
	public unsafe virtual IReflectedClass Get(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_IReflectedClass_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IReflectedClass>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IReflectedClass Get<T>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_Get_Public_Abstract_Virtual_New_IReflectedClass_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IReflectedClass>(intPtr) : null;
	}

	public IReflectionBinder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

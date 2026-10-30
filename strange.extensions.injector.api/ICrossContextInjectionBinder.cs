using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace strange.extensions.injector.api;

public class ICrossContextInjectionBinder : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_CrossContextBinder_Public_Abstract_Virtual_New_get_IInjectionBinder_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_CrossContextBinder_Public_Abstract_Virtual_New_set_Void_IInjectionBinder_0;

	public unsafe virtual IInjectionBinder CrossContextBinder
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_CrossContextBinder_Public_Abstract_Virtual_New_get_IInjectionBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IInjectionBinder>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_CrossContextBinder_Public_Abstract_Virtual_New_set_Void_IInjectionBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ICrossContextInjectionBinder()
	{
		Il2CppClassPointerStore<ICrossContextInjectionBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.injector.api", "ICrossContextInjectionBinder");
		NativeMethodInfoPtr_get_CrossContextBinder_Public_Abstract_Virtual_New_get_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICrossContextInjectionBinder>.NativeClassPtr, 100684855);
		NativeMethodInfoPtr_set_CrossContextBinder_Public_Abstract_Virtual_New_set_Void_IInjectionBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICrossContextInjectionBinder>.NativeClassPtr, 100684856);
	}

	public ICrossContextInjectionBinder(IntPtr pointer)
		: base(pointer)
	{
	}
}

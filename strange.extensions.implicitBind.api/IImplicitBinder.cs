using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace strange.extensions.implicitBind.api;

public class IImplicitBinder : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ScanForAnnotatedClasses_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Abstract_Virtual_New_get_Assembly_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Assembly_Public_Abstract_Virtual_New_set_Void_Assembly_0;

	public unsafe virtual Assembly Assembly
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Assembly_Public_Abstract_Virtual_New_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_Assembly_Public_Abstract_Virtual_New_set_Void_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static IImplicitBinder()
	{
		Il2CppClassPointerStore<IImplicitBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.implicitBind.api", "IImplicitBinder");
		NativeMethodInfoPtr_ScanForAnnotatedClasses_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IImplicitBinder>.NativeClassPtr, 100684937);
		NativeMethodInfoPtr_get_Assembly_Public_Abstract_Virtual_New_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IImplicitBinder>.NativeClassPtr, 100684938);
		NativeMethodInfoPtr_set_Assembly_Public_Abstract_Virtual_New_set_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IImplicitBinder>.NativeClassPtr, 100684939);
	}

	[CallerCount(0)]
	public unsafe virtual void ScanForAnnotatedClasses([Optional] Il2CppStringArray usingNamespaces)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		if (usingNamespaces == null)
		{
			usingNamespaces = new Il2CppStringArray(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)usingNamespaces);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ScanForAnnotatedClasses_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public virtual void ScanForAnnotatedClasses(params string[] usingNamespaces)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		ScanForAnnotatedClasses(new Il2CppStringArray(usingNamespaces));
	}

	public IImplicitBinder(IntPtr pointer)
		: base(pointer)
	{
	}
}

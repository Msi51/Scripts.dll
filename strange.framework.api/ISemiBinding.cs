using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace strange.framework.api;

public class ISemiBinding : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_constraint_Public_Abstract_Virtual_New_get_BindingConstraintType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_constraint_Public_Abstract_Virtual_New_set_Void_BindingConstraintType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_uniqueValues_Public_Abstract_Virtual_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_uniqueValues_Public_Abstract_Virtual_New_set_Void_Boolean_0;

	public unsafe virtual BindingConstraintType constraint
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_constraint_Public_Abstract_Virtual_New_get_BindingConstraintType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(BindingConstraintType*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_constraint_Public_Abstract_Virtual_New_set_Void_BindingConstraintType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe virtual bool uniqueValues
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_uniqueValues_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_uniqueValues_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static ISemiBinding()
	{
		Il2CppClassPointerStore<ISemiBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.framework.api", "ISemiBinding");
		NativeMethodInfoPtr_get_constraint_Public_Abstract_Virtual_New_get_BindingConstraintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISemiBinding>.NativeClassPtr, 100684255);
		NativeMethodInfoPtr_set_constraint_Public_Abstract_Virtual_New_set_Void_BindingConstraintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISemiBinding>.NativeClassPtr, 100684256);
		NativeMethodInfoPtr_get_uniqueValues_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISemiBinding>.NativeClassPtr, 100684257);
		NativeMethodInfoPtr_set_uniqueValues_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISemiBinding>.NativeClassPtr, 100684258);
	}

	public ISemiBinding(IntPtr pointer)
		: base(pointer)
	{
	}
}

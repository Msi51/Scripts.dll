using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IModelDisplayProperties : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_AddDisplayProperty_Public_Abstract_Virtual_New_Void_ModelDisplayProperty_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_List_1_ModelDisplayProperty_0;

	static IModelDisplayProperties()
	{
		Il2CppClassPointerStore<IModelDisplayProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IModelDisplayProperties");
		NativeMethodInfoPtr_AddDisplayProperty_Public_Abstract_Virtual_New_Void_ModelDisplayProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModelDisplayProperties>.NativeClassPtr, 100678295);
		NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_List_1_ModelDisplayProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModelDisplayProperties>.NativeClassPtr, 100678296);
	}

	[CallerCount(0)]
	public unsafe virtual void AddDisplayProperty(ModelDisplayProperty property)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)property));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddDisplayProperty_Public_Abstract_Virtual_New_Void_ModelDisplayProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual List<ModelDisplayProperty> GetProperties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetProperties_Public_Abstract_Virtual_New_List_1_ModelDisplayProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ModelDisplayProperty>>(intPtr) : null;
	}

	public IModelDisplayProperties(IntPtr pointer)
		: base(pointer)
	{
	}
}

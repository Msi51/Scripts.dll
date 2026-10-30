using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IToolable : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetToolType_Public_Abstract_Virtual_New_Void_ToolType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetToolTypes_Public_Abstract_Virtual_New_List_1_ToolType_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetToolTypeRestriction_Public_Abstract_Virtual_New_Void_ToolType_0;

	static IToolable()
	{
		Il2CppClassPointerStore<IToolable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IToolable");
		NativeMethodInfoPtr_SetToolType_Public_Abstract_Virtual_New_Void_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolable>.NativeClassPtr, 100682047);
		NativeMethodInfoPtr_GetToolTypes_Public_Abstract_Virtual_New_List_1_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolable>.NativeClassPtr, 100682048);
		NativeMethodInfoPtr_SetToolTypeRestriction_Public_Abstract_Virtual_New_Void_ToolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IToolable>.NativeClassPtr, 100682049);
	}

	[CallerCount(0)]
	public unsafe virtual void SetToolType(ToolType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetToolType_Public_Abstract_Virtual_New_Void_ToolType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual List<ToolType> GetToolTypes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetToolTypes_Public_Abstract_Virtual_New_List_1_ToolType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ToolType>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SetToolTypeRestriction(ToolType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetToolTypeRestriction_Public_Abstract_Virtual_New_Void_ToolType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IToolable(IntPtr pointer)
		: base(pointer)
	{
	}
}

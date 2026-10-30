using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IWorkbench : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetWorkbenchType_Public_Abstract_Virtual_New_WorkbenchType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TakeWorkbenchDamage_Public_Abstract_Virtual_New_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShowWorkedItem_Public_Abstract_Virtual_New_Void_InventoryItem_0;

	static IWorkbench()
	{
		Il2CppClassPointerStore<IWorkbench>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IWorkbench");
		NativeMethodInfoPtr_GetWorkbenchType_Public_Abstract_Virtual_New_WorkbenchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorkbench>.NativeClassPtr, 100682110);
		NativeMethodInfoPtr_TakeWorkbenchDamage_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorkbench>.NativeClassPtr, 100682111);
		NativeMethodInfoPtr_ShowWorkedItem_Public_Abstract_Virtual_New_Void_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorkbench>.NativeClassPtr, 100682112);
	}

	[CallerCount(0)]
	public unsafe virtual WorkbenchType GetWorkbenchType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWorkbenchType_Public_Abstract_Virtual_New_WorkbenchType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(WorkbenchType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void TakeWorkbenchDamage(int numUses)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&numUses);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TakeWorkbenchDamage_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void ShowWorkedItem(InventoryItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShowWorkedItem_Public_Abstract_Virtual_New_Void_InventoryItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IWorkbench(IntPtr pointer)
		: base(pointer)
	{
	}
}

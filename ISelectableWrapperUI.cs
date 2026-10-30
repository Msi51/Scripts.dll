using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

public class ISelectableWrapperUI : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetSelectable_Public_Abstract_Virtual_New_Selectable_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetScrollRect_Public_Abstract_Virtual_New_Void_ScrollRect_0;

	static ISelectableWrapperUI()
	{
		Il2CppClassPointerStore<ISelectableWrapperUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISelectableWrapperUI");
		NativeMethodInfoPtr_GetSelectable_Public_Abstract_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectableWrapperUI>.NativeClassPtr, 100667627);
		NativeMethodInfoPtr_SetScrollRect_Public_Abstract_Virtual_New_Void_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISelectableWrapperUI>.NativeClassPtr, 100667628);
	}

	[CallerCount(0)]
	public unsafe virtual Selectable GetSelectable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSelectable_Public_Abstract_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SetScrollRect(ScrollRect parentScrollRect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentScrollRect);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetScrollRect_Public_Abstract_Virtual_New_Void_ScrollRect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ISelectableWrapperUI(IntPtr pointer)
		: base(pointer)
	{
	}
}

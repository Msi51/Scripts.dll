using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.EventSystems;

public class IPointerDoubleClickHandler : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerDoubleClick_Public_Abstract_Virtual_New_Void_PointerEventData_0;

	static IPointerDoubleClickHandler()
	{
		Il2CppClassPointerStore<IPointerDoubleClickHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IPointerDoubleClickHandler");
		NativeMethodInfoPtr_OnPointerDoubleClick_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerDoubleClickHandler>.NativeClassPtr, 100667611);
	}

	[CallerCount(0)]
	public unsafe virtual void OnPointerDoubleClick(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnPointerDoubleClick_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IPointerDoubleClickHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

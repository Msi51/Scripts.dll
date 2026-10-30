using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IFilterableUI : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_FilterRemoved_Public_Abstract_Virtual_New_Void_0;

	static IFilterableUI()
	{
		Il2CppClassPointerStore<IFilterableUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IFilterableUI");
		NativeMethodInfoPtr_FilterRemoved_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterableUI>.NativeClassPtr, 100667604);
	}

	[CallerCount(0)]
	public unsafe virtual void FilterRemoved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FilterRemoved_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IFilterableUI(IntPtr pointer)
		: base(pointer)
	{
	}
}

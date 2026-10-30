using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IRepairer : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetRepairingState_Public_Abstract_Virtual_New_RepairingState_0;

	static IRepairer()
	{
		Il2CppClassPointerStore<IRepairer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IRepairer");
		NativeMethodInfoPtr_GetRepairingState_Public_Abstract_Virtual_New_RepairingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRepairer>.NativeClassPtr, 100681928);
	}

	[CallerCount(0)]
	public unsafe virtual RepairingState GetRepairingState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetRepairingState_Public_Abstract_Virtual_New_RepairingState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RepairingState>(intPtr) : null;
	}

	public IRepairer(IntPtr pointer)
		: base(pointer)
	{
	}
}

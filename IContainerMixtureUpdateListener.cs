using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IContainerMixtureUpdateListener : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetMixtureForUpdate_Public_Abstract_Virtual_New_SubstanceMixture_0;

	static IContainerMixtureUpdateListener()
	{
		Il2CppClassPointerStore<IContainerMixtureUpdateListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IContainerMixtureUpdateListener");
		NativeMethodInfoPtr_GetMixtureForUpdate_Public_Abstract_Virtual_New_SubstanceMixture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContainerMixtureUpdateListener>.NativeClassPtr, 100663790);
	}

	[CallerCount(0)]
	public unsafe virtual SubstanceMixture GetMixtureForUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMixtureForUpdate_Public_Abstract_Virtual_New_SubstanceMixture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SubstanceMixture>(intPtr) : null;
	}

	public IContainerMixtureUpdateListener(IntPtr pointer)
		: base(pointer)
	{
	}
}

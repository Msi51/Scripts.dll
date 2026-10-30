using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IDisplayedStat : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetDisplayedStat_Public_Abstract_Virtual_New_DisplayedStat_0;

	static IDisplayedStat()
	{
		Il2CppClassPointerStore<IDisplayedStat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IDisplayedStat");
		NativeMethodInfoPtr_GetDisplayedStat_Public_Abstract_Virtual_New_DisplayedStat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDisplayedStat>.NativeClassPtr, 100681420);
	}

	[CallerCount(0)]
	public unsafe virtual DisplayedStat GetDisplayedStat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDisplayedStat_Public_Abstract_Virtual_New_DisplayedStat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DisplayedStat(pointer);
	}

	public IDisplayedStat(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IKiln : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetKilnType_Public_Abstract_Virtual_New_KilnType_0;

	static IKiln()
	{
		Il2CppClassPointerStore<IKiln>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IKiln");
		NativeMethodInfoPtr_GetKilnType_Public_Abstract_Virtual_New_KilnType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IKiln>.NativeClassPtr, 100681752);
	}

	[CallerCount(0)]
	public unsafe virtual KilnType GetKilnType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetKilnType_Public_Abstract_Virtual_New_KilnType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(KilnType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IKiln(IntPtr pointer)
		: base(pointer)
	{
	}
}

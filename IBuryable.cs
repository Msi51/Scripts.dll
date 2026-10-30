using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IBuryable : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_IsBuried_Public_Abstract_Virtual_New_Boolean_0;

	static IBuryable()
	{
		Il2CppClassPointerStore<IBuryable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IBuryable");
		NativeMethodInfoPtr_IsBuried_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBuryable>.NativeClassPtr, 100681295);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsBuried()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsBuried_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IBuryable(IntPtr pointer)
		: base(pointer)
	{
	}
}

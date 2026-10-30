using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IWorldBasedQueue : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ContainsElements_Public_Abstract_Virtual_New_Boolean_0;

	static IWorldBasedQueue()
	{
		Il2CppClassPointerStore<IWorldBasedQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IWorldBasedQueue");
		NativeMethodInfoPtr_ContainsElements_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldBasedQueue>.NativeClassPtr, 100683357);
	}

	[CallerCount(0)]
	public unsafe virtual bool ContainsElements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ContainsElements_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IWorldBasedQueue(IntPtr pointer)
		: base(pointer)
	{
	}
}

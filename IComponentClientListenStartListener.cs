using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IComponentClientListenStartListener : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnNetworkClientListenStart_Public_Abstract_Virtual_New_Void_Int32_0;

	static IComponentClientListenStartListener()
	{
		Il2CppClassPointerStore<IComponentClientListenStartListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IComponentClientListenStartListener");
		NativeMethodInfoPtr_OnNetworkClientListenStart_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentClientListenStartListener>.NativeClassPtr, 100663786);
	}

	[CallerCount(0)]
	public unsafe virtual void OnNetworkClientListenStart(int clientId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&clientId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnNetworkClientListenStart_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IComponentClientListenStartListener(IntPtr pointer)
		: base(pointer)
	{
	}
}

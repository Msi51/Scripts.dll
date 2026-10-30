using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IComponentSpawnedListener : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnNetworkSpawned_Public_Abstract_Virtual_New_Void_Int32_0;

	static IComponentSpawnedListener()
	{
		Il2CppClassPointerStore<IComponentSpawnedListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IComponentSpawnedListener");
		NativeMethodInfoPtr_OnNetworkSpawned_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentSpawnedListener>.NativeClassPtr, 100663787);
	}

	[CallerCount(0)]
	public unsafe virtual void OnNetworkSpawned(int clientId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&clientId);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnNetworkSpawned_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IComponentSpawnedListener(IntPtr pointer)
		: base(pointer)
	{
	}
}

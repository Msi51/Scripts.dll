using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class ISurvivalComponent : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentType_Public_Abstract_Virtual_New_Type_0;

	static ISurvivalComponent()
	{
		Il2CppClassPointerStore<ISurvivalComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISurvivalComponent");
		NativeMethodInfoPtr_GetComponentType_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurvivalComponent>.NativeClassPtr, 100682038);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppSystem.Type GetComponentType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetComponentType_Public_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	public ISurvivalComponent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

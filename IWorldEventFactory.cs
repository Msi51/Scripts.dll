using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IWorldEventFactory : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetWorldEvent_Public_Abstract_Virtual_New_IWorldEvent_WorldEventType_0;

	static IWorldEventFactory()
	{
		Il2CppClassPointerStore<IWorldEventFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IWorldEventFactory");
		NativeMethodInfoPtr_GetWorldEvent_Public_Abstract_Virtual_New_IWorldEvent_WorldEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldEventFactory>.NativeClassPtr, 100669860);
	}

	[CallerCount(0)]
	public unsafe virtual IWorldEvent GetWorldEvent(WorldEventType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWorldEvent_Public_Abstract_Virtual_New_IWorldEvent_WorldEventType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IWorldEvent>(intPtr) : null;
	}

	public IWorldEventFactory(IntPtr pointer)
		: base(pointer)
	{
	}
}

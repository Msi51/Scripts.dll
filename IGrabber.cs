using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IGrabber : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetGrabbedEntity_Public_Abstract_Virtual_New_Void_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetGrabbedEntity_Public_Abstract_Virtual_New_Entity_0;

	static IGrabber()
	{
		Il2CppClassPointerStore<IGrabber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IGrabber");
		NativeMethodInfoPtr_SetGrabbedEntity_Public_Abstract_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabber>.NativeClassPtr, 100681554);
		NativeMethodInfoPtr_GetGrabbedEntity_Public_Abstract_Virtual_New_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabber>.NativeClassPtr, 100681555);
	}

	[CallerCount(0)]
	public unsafe virtual void SetGrabbedEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetGrabbedEntity_Public_Abstract_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Entity GetGrabbedEntity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetGrabbedEntity_Public_Abstract_Virtual_New_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	public IGrabber(IntPtr pointer)
		: base(pointer)
	{
	}
}

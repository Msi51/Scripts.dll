using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IAttachedSelectedGameObjectUI : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetAttachedSelectedEntity_Public_Abstract_Virtual_New_Entity_0;

	private static readonly IntPtr NativeMethodInfoPtr_MoveToFrontOfSiblings_Public_Abstract_Virtual_New_Void_0;

	static IAttachedSelectedGameObjectUI()
	{
		Il2CppClassPointerStore<IAttachedSelectedGameObjectUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IAttachedSelectedGameObjectUI");
		NativeMethodInfoPtr_GetAttachedSelectedEntity_Public_Abstract_Virtual_New_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttachedSelectedGameObjectUI>.NativeClassPtr, 100667592);
		NativeMethodInfoPtr_MoveToFrontOfSiblings_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttachedSelectedGameObjectUI>.NativeClassPtr, 100667593);
	}

	[CallerCount(0)]
	public unsafe virtual Entity GetAttachedSelectedEntity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetAttachedSelectedEntity_Public_Abstract_Virtual_New_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void MoveToFrontOfSiblings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MoveToFrontOfSiblings_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IAttachedSelectedGameObjectUI(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace strange.extensions.dispatcher.api;

public class ITriggerProvider : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_AddTriggerable_Public_Abstract_Virtual_New_Void_ITriggerable_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveTriggerable_Public_Abstract_Virtual_New_Void_ITriggerable_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Triggerables_Public_Abstract_Virtual_New_get_Int32_0;

	public unsafe virtual int Triggerables
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Triggerables_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static ITriggerProvider()
	{
		Il2CppClassPointerStore<ITriggerProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "strange.extensions.dispatcher.api", "ITriggerProvider");
		NativeMethodInfoPtr_AddTriggerable_Public_Abstract_Virtual_New_Void_ITriggerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggerProvider>.NativeClassPtr, 100685031);
		NativeMethodInfoPtr_RemoveTriggerable_Public_Abstract_Virtual_New_Void_ITriggerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggerProvider>.NativeClassPtr, 100685032);
		NativeMethodInfoPtr_get_Triggerables_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITriggerProvider>.NativeClassPtr, 100685033);
	}

	[CallerCount(0)]
	public unsafe virtual void AddTriggerable(ITriggerable target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddTriggerable_Public_Abstract_Virtual_New_Void_ITriggerable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RemoveTriggerable(ITriggerable target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveTriggerable_Public_Abstract_Virtual_New_Void_ITriggerable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ITriggerProvider(IntPtr pointer)
		: base(pointer)
	{
	}
}

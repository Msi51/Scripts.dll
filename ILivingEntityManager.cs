using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ILivingEntityManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_HandleHitpointsDepleted_Public_Abstract_Virtual_New_Void_Entity_0;

	static ILivingEntityManager()
	{
		Il2CppClassPointerStore<ILivingEntityManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ILivingEntityManager");
		NativeMethodInfoPtr_HandleHitpointsDepleted_Public_Abstract_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILivingEntityManager>.NativeClassPtr, 100675511);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleHitpointsDepleted(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleHitpointsDepleted_Public_Abstract_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ILivingEntityManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

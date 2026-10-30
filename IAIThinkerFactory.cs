using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IAIThinkerFactory : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_CreateFor_Public_Abstract_Virtual_New_AIThinker_Entity_0;

	static IAIThinkerFactory()
	{
		Il2CppClassPointerStore<IAIThinkerFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IAIThinkerFactory");
		NativeMethodInfoPtr_CreateFor_Public_Abstract_Virtual_New_AIThinker_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAIThinkerFactory>.NativeClassPtr, 100669804);
	}

	[CallerCount(0)]
	public unsafe virtual AIThinker CreateFor(Entity e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateFor_Public_Abstract_Virtual_New_AIThinker_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AIThinker>(intPtr) : null;
	}

	public IAIThinkerFactory(IntPtr pointer)
		: base(pointer)
	{
	}
}

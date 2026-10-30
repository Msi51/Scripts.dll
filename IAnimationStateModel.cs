using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class IAnimationStateModel : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_AnimationStateMap_Public_Abstract_Virtual_New_get_Dictionary_2_AnimationState_Int32_0;

	public unsafe virtual Dictionary<AnimationState, int> AnimationStateMap
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_AnimationStateMap_Public_Abstract_Virtual_New_get_Dictionary_2_AnimationState_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AnimationState, int>>(intPtr) : null;
		}
	}

	static IAnimationStateModel()
	{
		Il2CppClassPointerStore<IAnimationStateModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IAnimationStateModel");
		NativeMethodInfoPtr_get_AnimationStateMap_Public_Abstract_Virtual_New_get_Dictionary_2_AnimationState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationStateModel>.NativeClassPtr, 100678292);
	}

	public IAnimationStateModel(IntPtr pointer)
		: base(pointer)
	{
	}
}

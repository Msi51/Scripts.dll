using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

public class IThumbnailRenderingManager : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_InitializeThumbnails_Public_Abstract_Virtual_New_IEnumerator_0;

	static IThumbnailRenderingManager()
	{
		Il2CppClassPointerStore<IThumbnailRenderingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IThumbnailRenderingManager");
		NativeMethodInfoPtr_InitializeThumbnails_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IThumbnailRenderingManager>.NativeClassPtr, 100675958);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator InitializeThumbnails()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeThumbnails_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	public IThumbnailRenderingManager(IntPtr pointer)
		: base(pointer)
	{
	}
}

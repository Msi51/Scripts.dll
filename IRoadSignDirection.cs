using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class IRoadSignDirection : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetInfo_Public_Abstract_Virtual_New_Void_RoadSignDirectionInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInfo_Public_Abstract_Virtual_New_RoadSignDirectionInfo_0;

	static IRoadSignDirection()
	{
		Il2CppClassPointerStore<IRoadSignDirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IRoadSignDirection");
		NativeMethodInfoPtr_SetInfo_Public_Abstract_Virtual_New_Void_RoadSignDirectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRoadSignDirection>.NativeClassPtr, 100681954);
		NativeMethodInfoPtr_GetInfo_Public_Abstract_Virtual_New_RoadSignDirectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRoadSignDirection>.NativeClassPtr, 100681955);
	}

	[CallerCount(0)]
	public unsafe virtual void SetInfo(RoadSignDirectionInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetInfo_Public_Abstract_Virtual_New_Void_RoadSignDirectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual RoadSignDirectionInfo GetInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInfo_Public_Abstract_Virtual_New_RoadSignDirectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoadSignDirectionInfo>(intPtr) : null;
	}

	public IRoadSignDirection(IntPtr pointer)
		: base(pointer)
	{
	}
}

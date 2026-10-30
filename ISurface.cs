using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class ISurface : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SurfaceTypeAtPosition_Public_Abstract_Virtual_New_SurfaceType_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCustomSurfaceType_Public_Abstract_Virtual_New_Void_SurfaceType_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearCustomSurfaceType_Public_Abstract_Virtual_New_Void_0;

	static ISurface()
	{
		Il2CppClassPointerStore<ISurface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISurface");
		NativeMethodInfoPtr_SurfaceTypeAtPosition_Public_Abstract_Virtual_New_SurfaceType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurface>.NativeClassPtr, 100682035);
		NativeMethodInfoPtr_SetCustomSurfaceType_Public_Abstract_Virtual_New_Void_SurfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurface>.NativeClassPtr, 100682036);
		NativeMethodInfoPtr_ClearCustomSurfaceType_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurface>.NativeClassPtr, 100682037);
	}

	[CallerCount(0)]
	public unsafe virtual SurfaceType SurfaceTypeAtPosition(Vector3 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&worldPosition);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SurfaceTypeAtPosition_Public_Abstract_Virtual_New_SurfaceType_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurfaceType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void SetCustomSurfaceType(SurfaceType surfaceType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&surfaceType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetCustomSurfaceType_Public_Abstract_Virtual_New_Void_SurfaceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void ClearCustomSurfaceType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClearCustomSurfaceType_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ISurface(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IMinimapRepresentation : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetMinimapIconType_Public_Abstract_Virtual_New_MinimapIconType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMinimapIconSize_Public_Abstract_Virtual_New_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_ShouldRotate_Public_Abstract_Virtual_New_Boolean_0;

	static IMinimapRepresentation()
	{
		Il2CppClassPointerStore<IMinimapRepresentation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IMinimapRepresentation");
		NativeMethodInfoPtr_GetMinimapIconType_Public_Abstract_Virtual_New_MinimapIconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMinimapRepresentation>.NativeClassPtr, 100681769);
		NativeMethodInfoPtr_GetMinimapIconSize_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMinimapRepresentation>.NativeClassPtr, 100681770);
		NativeMethodInfoPtr_ShouldRotate_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMinimapRepresentation>.NativeClassPtr, 100681771);
	}

	[CallerCount(0)]
	public unsafe virtual MinimapIconType GetMinimapIconType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMinimapIconType_Public_Abstract_Virtual_New_MinimapIconType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(MinimapIconType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual float GetMinimapIconSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetMinimapIconSize_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool ShouldRotate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ShouldRotate_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IMinimapRepresentation(IntPtr pointer)
		: base(pointer)
	{
	}
}

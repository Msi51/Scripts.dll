using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class IShowableInteraction : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GetDescriptionText_Public_Abstract_Virtual_New_String_LocalPlayer_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInteractionShowWorldPosition_Public_Abstract_Virtual_New_Vector3_LocalPlayer_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsPointerPosition_Public_Abstract_Virtual_New_Boolean_LocalPlayer_0;

	static IShowableInteraction()
	{
		Il2CppClassPointerStore<IShowableInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IShowableInteraction");
		NativeMethodInfoPtr_GetDescriptionText_Public_Abstract_Virtual_New_String_LocalPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShowableInteraction>.NativeClassPtr, 100681962);
		NativeMethodInfoPtr_GetInteractionShowWorldPosition_Public_Abstract_Virtual_New_Vector3_LocalPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShowableInteraction>.NativeClassPtr, 100681963);
		NativeMethodInfoPtr_IsPointerPosition_Public_Abstract_Virtual_New_Boolean_LocalPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShowableInteraction>.NativeClassPtr, 100681964);
	}

	[CallerCount(0)]
	public unsafe virtual string GetDescriptionText(LocalPlayer player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDescriptionText_Public_Abstract_Virtual_New_String_LocalPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Vector3 GetInteractionShowWorldPosition(LocalPlayer player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetInteractionShowWorldPosition_Public_Abstract_Virtual_New_Vector3_LocalPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsPointerPosition(LocalPlayer player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsPointerPosition_Public_Abstract_Virtual_New_Boolean_LocalPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public IShowableInteraction(IntPtr pointer)
		: base(pointer)
	{
	}
}

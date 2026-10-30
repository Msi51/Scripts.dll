using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class IPanUser : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_SetPanning_Public_Abstract_Virtual_New_Void_ActionType_SubstanceMixture_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopPanning_Public_Abstract_Virtual_New_Void_ActionType_0;

	static IPanUser()
	{
		Il2CppClassPointerStore<IPanUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IPanUser");
		NativeMethodInfoPtr_SetPanning_Public_Abstract_Virtual_New_Void_ActionType_SubstanceMixture_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanUser>.NativeClassPtr, 100681779);
		NativeMethodInfoPtr_StopPanning_Public_Abstract_Virtual_New_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPanUser>.NativeClassPtr, 100681780);
	}

	[CallerCount(0)]
	public unsafe virtual void SetPanning(ActionType actionType, SubstanceMixture substanceMixture, float percentageComplete)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&actionType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substanceMixture);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &percentageComplete;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetPanning_Public_Abstract_Virtual_New_Void_ActionType_SubstanceMixture_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void StopPanning(ActionType actionType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&actionType);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_StopPanning_Public_Abstract_Virtual_New_Void_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IPanUser(IntPtr pointer)
		: base(pointer)
	{
	}
}

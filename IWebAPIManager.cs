using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class IWebAPIManager : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SetSteamData_Public_Abstract_Virtual_New_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWelcomeMessage_Public_Abstract_Virtual_New_Void_Action_2_Int32_WelcomeResponse_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendError_Public_Abstract_Virtual_New_Void_Dictionary_2_String_Object_0;

	static IWebAPIManager()
	{
		Il2CppClassPointerStore<IWebAPIManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IWebAPIManager");
		NativeMethodInfoPtr_SetSteamData_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebAPIManager>.NativeClassPtr, 100676044);
		NativeMethodInfoPtr_GetWelcomeMessage_Public_Abstract_Virtual_New_Void_Action_2_Int32_WelcomeResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebAPIManager>.NativeClassPtr, 100676045);
		NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebAPIManager>.NativeClassPtr, 100676046);
		NativeMethodInfoPtr_SendError_Public_Abstract_Virtual_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebAPIManager>.NativeClassPtr, 100676047);
	}

	[CallerCount(0)]
	public unsafe virtual void SetSteamData(string userTicket, string appId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(userTicket);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(appId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetSteamData_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetWelcomeMessage(Il2CppSystem.Action<int, WelcomeResponse> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWelcomeMessage_Public_Abstract_Virtual_New_Void_Action_2_Int32_WelcomeResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SendEvent(Dictionary<string, Il2CppSystem.Object> eventParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventParams);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Dictionary_2_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SendError(Dictionary<string, Il2CppSystem.Object> errorParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errorParams);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SendError_Public_Abstract_Virtual_New_Void_Dictionary_2_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IWebAPIManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

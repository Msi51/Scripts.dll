using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Netcode;

public class INetworkedGameEventMessageHandler : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_HandleRequest_Public_Abstract_Virtual_New_Void_Int32_Int32_FastBufferReader_0;

	private static readonly IntPtr NativeMethodInfoPtr_HandleResponse_Public_Abstract_Virtual_New_Void_FastBufferReader_byref_GameEventMessageResponse_0;

	static INetworkedGameEventMessageHandler()
	{
		Il2CppClassPointerStore<INetworkedGameEventMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "INetworkedGameEventMessageHandler");
		NativeMethodInfoPtr_HandleRequest_Public_Abstract_Virtual_New_Void_Int32_Int32_FastBufferReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkedGameEventMessageHandler>.NativeClassPtr, 100664057);
		NativeMethodInfoPtr_HandleResponse_Public_Abstract_Virtual_New_Void_FastBufferReader_byref_GameEventMessageResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkedGameEventMessageHandler>.NativeClassPtr, 100664058);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleRequest(int clientId, int requestId, FastBufferReader reader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&clientId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &requestId;
		*(FastBufferReader**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &reader;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleRequest_Public_Abstract_Virtual_New_Void_Int32_Int32_FastBufferReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleResponse(FastBufferReader reader, ref GameEventMessageResponse response)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&reader);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)response));
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleResponse_Public_Abstract_Virtual_New_Void_FastBufferReader_byref_GameEventMessageResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public INetworkedGameEventMessageHandler(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class NetworkDataType : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TIMING_REQUEST;

	private static readonly System.IntPtr NativeFieldInfoPtr_TIMING_RESPONSE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MESSAGE;

	public unsafe static byte TIMING_REQUEST
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TIMING_REQUEST, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TIMING_REQUEST, (void*)(&b));
		}
	}

	public unsafe static byte TIMING_RESPONSE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TIMING_RESPONSE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TIMING_RESPONSE, (void*)(&b));
		}
	}

	public unsafe static byte MESSAGE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MESSAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MESSAGE, (void*)(&b));
		}
	}

	static NetworkDataType()
	{
		Il2CppClassPointerStore<NetworkDataType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NetworkDataType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkDataType>.NativeClassPtr);
		NativeFieldInfoPtr_TIMING_REQUEST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkDataType>.NativeClassPtr, "TIMING_REQUEST");
		NativeFieldInfoPtr_TIMING_RESPONSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkDataType>.NativeClassPtr, "TIMING_RESPONSE");
		NativeFieldInfoPtr_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkDataType>.NativeClassPtr, "MESSAGE");
	}

	public NetworkDataType(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

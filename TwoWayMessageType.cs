using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class TwoWayMessageType : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST;

	private static readonly System.IntPtr NativeFieldInfoPtr_RESPONSE;

	public unsafe static byte REQUEST
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST, (void*)(&b));
		}
	}

	public unsafe static byte RESPONSE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RESPONSE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RESPONSE, (void*)(&b));
		}
	}

	static TwoWayMessageType()
	{
		Il2CppClassPointerStore<TwoWayMessageType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TwoWayMessageType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwoWayMessageType>.NativeClassPtr);
		NativeFieldInfoPtr_REQUEST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageType>.NativeClassPtr, "REQUEST");
		NativeFieldInfoPtr_RESPONSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoWayMessageType>.NativeClassPtr, "RESPONSE");
	}

	public TwoWayMessageType(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

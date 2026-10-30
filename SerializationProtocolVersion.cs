using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class SerializationProtocolVersion : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_PROTOCOL_VERSION_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_PROTOCOL_VERSION_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CURRENT_PROTOCOL_VERSION;

	public unsafe static int PROTOCOL_VERSION_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROTOCOL_VERSION_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROTOCOL_VERSION_1, (void*)(&num));
		}
	}

	public unsafe static int PROTOCOL_VERSION_2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROTOCOL_VERSION_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROTOCOL_VERSION_2, (void*)(&num));
		}
	}

	public unsafe static int CURRENT_PROTOCOL_VERSION
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CURRENT_PROTOCOL_VERSION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CURRENT_PROTOCOL_VERSION, (void*)(&num));
		}
	}

	static SerializationProtocolVersion()
	{
		Il2CppClassPointerStore<SerializationProtocolVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SerializationProtocolVersion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationProtocolVersion>.NativeClassPtr);
		NativeFieldInfoPtr_PROTOCOL_VERSION_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationProtocolVersion>.NativeClassPtr, "PROTOCOL_VERSION_1");
		NativeFieldInfoPtr_PROTOCOL_VERSION_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationProtocolVersion>.NativeClassPtr, "PROTOCOL_VERSION_2");
		NativeFieldInfoPtr_CURRENT_PROTOCOL_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationProtocolVersion>.NativeClassPtr, "CURRENT_PROTOCOL_VERSION");
	}

	public SerializationProtocolVersion(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace FullSerializer;

public static class fsGlobalConfig : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsCaseSensitive;

	private static readonly System.IntPtr NativeFieldInfoPtr_AllowInternalExceptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_InternalFieldPrefix;

	public unsafe static bool IsCaseSensitive
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsCaseSensitive, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsCaseSensitive, (void*)(&flag));
		}
	}

	public unsafe static bool AllowInternalExceptions
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AllowInternalExceptions, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AllowInternalExceptions, (void*)(&flag));
		}
	}

	public unsafe static string InternalFieldPrefix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InternalFieldPrefix, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InternalFieldPrefix, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static fsGlobalConfig()
	{
		Il2CppClassPointerStore<fsGlobalConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsGlobalConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsGlobalConfig>.NativeClassPtr);
		NativeFieldInfoPtr_IsCaseSensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsGlobalConfig>.NativeClassPtr, "IsCaseSensitive");
		NativeFieldInfoPtr_AllowInternalExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsGlobalConfig>.NativeClassPtr, "AllowInternalExceptions");
		NativeFieldInfoPtr_InternalFieldPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsGlobalConfig>.NativeClassPtr, "InternalFieldPrefix");
	}

	public fsGlobalConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;
using UnityEngine;

public static class Log : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mainThread;

	private static readonly System.IntPtr NativeFieldInfoPtr_logger;

	private static readonly System.IntPtr NativeFieldInfoPtr_onWarn;

	private static readonly System.IntPtr NativeFieldInfoPtr_onError;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLogger_Public_Static_Void_ILogger_Action_1_String_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getLogContext_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Debug_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Debug_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_debugInternal_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Debug_Public_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Debug_Public_Static_Void_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_debugInternal_Private_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InfoLocal_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Info_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Info_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_infoInternal_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Info_Public_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Warn_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Warn_Public_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Error_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Error_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_errorInternal_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Error_Public_Static_Void_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_errorInternal_Private_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exception_Public_Static_Void_Exception_0;

	public unsafe static Thread mainThread
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainThread, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainThread, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread));
		}
	}

	public unsafe static ILogger logger
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_logger, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_logger, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)logger));
		}
	}

	public unsafe static Il2CppSystem.Action<string> onWarn
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onWarn, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onWarn, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe static Il2CppSystem.Action<string> onError
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onError, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onError, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	static Log()
	{
		Il2CppClassPointerStore<Log>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "Log");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Log>.NativeClassPtr);
		NativeFieldInfoPtr_mainThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Log>.NativeClassPtr, "mainThread");
		NativeFieldInfoPtr_logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Log>.NativeClassPtr, "logger");
		NativeFieldInfoPtr_onWarn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Log>.NativeClassPtr, "onWarn");
		NativeFieldInfoPtr_onError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Log>.NativeClassPtr, "onError");
		NativeMethodInfoPtr_SetLogger_Public_Static_Void_ILogger_Action_1_String_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663739);
		NativeMethodInfoPtr_getLogContext_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663740);
		NativeMethodInfoPtr_Debug_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663741);
		NativeMethodInfoPtr_Debug_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663742);
		NativeMethodInfoPtr_debugInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663743);
		NativeMethodInfoPtr_Debug_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr_Debug_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663745);
		NativeMethodInfoPtr_debugInternal_Private_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663746);
		NativeMethodInfoPtr_InfoLocal_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663747);
		NativeMethodInfoPtr_Info_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663748);
		NativeMethodInfoPtr_Info_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663749);
		NativeMethodInfoPtr_infoInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663750);
		NativeMethodInfoPtr_Info_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663751);
		NativeMethodInfoPtr_Warn_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663752);
		NativeMethodInfoPtr_Warn_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663753);
		NativeMethodInfoPtr_Error_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663754);
		NativeMethodInfoPtr_Error_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663755);
		NativeMethodInfoPtr_errorInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663756);
		NativeMethodInfoPtr_Error_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663757);
		NativeMethodInfoPtr_errorInternal_Private_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663758);
		NativeMethodInfoPtr_Exception_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Log>.NativeClassPtr, 100663759);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22612, RefRangeEnd = 22613, XrefRangeStart = 22602, XrefRangeEnd = 22612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLogger(ILogger logger, Il2CppSystem.Action<string> onWarn, Il2CppSystem.Action<string> onError)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)logger);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onWarn);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onError);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLogger_Public_Static_Void_ILogger_Action_1_String_Action_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 22640, RefRangeEnd = 22649, XrefRangeStart = 22613, XrefRangeEnd = 22640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getLogContext()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getLogContext_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22649, XrefRangeEnd = 22653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Debug(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Debug_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22653, XrefRangeEnd = 22654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Debug(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Debug_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22654, XrefRangeEnd = 22664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void debugInternal(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_debugInternal_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22664, XrefRangeEnd = 22665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Debug(string message, UnityEngine.Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Debug_Public_Static_Void_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22665, XrefRangeEnd = 22669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Debug(Il2CppSystem.Object obj, UnityEngine.Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Debug_Public_Static_Void_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22669, XrefRangeEnd = 22678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void debugInternal(string message, UnityEngine.Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_debugInternal_Private_Static_Void_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 22679, RefRangeEnd = 22683, XrefRangeStart = 22678, XrefRangeEnd = 22679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InfoLocal(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InfoLocal_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 22679, RefRangeEnd = 22683, XrefRangeStart = 22679, XrefRangeEnd = 22683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Info(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Info_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22683, XrefRangeEnd = 22687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Info(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Info_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22687, XrefRangeEnd = 22697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void infoInternal(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_infoInternal_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22697, XrefRangeEnd = 22706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Info(string message, UnityEngine.Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Info_Public_Static_Void_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(114)]
	[CachedScanResults(RefRangeStart = 22717, RefRangeEnd = 22831, XrefRangeStart = 22706, XrefRangeEnd = 22717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Warn(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Warn_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22842, RefRangeEnd = 22843, XrefRangeStart = 22831, XrefRangeEnd = 22842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Warn(string message, UnityEngine.Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Warn_Public_Static_Void_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 22847, RefRangeEnd = 22850, XrefRangeStart = 22843, XrefRangeEnd = 22847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Error(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Error_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(119)]
	[CachedScanResults(RefRangeStart = 22851, RefRangeEnd = 22970, XrefRangeStart = 22850, XrefRangeEnd = 22851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Error(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Error_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22970, XrefRangeEnd = 22981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void errorInternal(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_errorInternal_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 22985, RefRangeEnd = 22986, XrefRangeStart = 22981, XrefRangeEnd = 22985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Error(Il2CppSystem.Object obj, UnityEngine.Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Error_Public_Static_Void_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22986, XrefRangeEnd = 22997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void errorInternal(string message, UnityEngine.Object context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_errorInternal_Private_Static_Void_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(76)]
	[CachedScanResults(RefRangeStart = 23040, RefRangeEnd = 23116, XrefRangeStart = 22997, XrefRangeEnd = 23040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Exception(Il2CppSystem.Exception exception)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exception_Public_Static_Void_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Log(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

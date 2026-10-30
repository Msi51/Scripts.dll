using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class ResultCode : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SUCCESS;

	private static readonly System.IntPtr NativeFieldInfoPtr_GAME_FULL;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOBBY_NO_LONGER_EXISTS;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOT_ALLOWED_TO_JOIN_LOBBY;

	private static readonly System.IntPtr NativeFieldInfoPtr_GENERATION_FAILURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UNEXPECTED_ERROR;

	private static readonly System.IntPtr NativeFieldInfoPtr_NO_STEAM_CONNECTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_STEAM_TIMEOUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_STEAM_FAILURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONNECTION_FAILURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONNECTION_CLOSED;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONNECTION_TIMEOUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_SAVE_CORRUPTED;

	private static readonly System.IntPtr NativeFieldInfoPtr_DISK_FULL;

	private static readonly System.IntPtr NativeFieldInfoPtr_HOST_SHUTTING_DOWN;

	private static readonly System.IntPtr NativeFieldInfoPtr_WRONG_PASSWORD;

	private static readonly System.IntPtr NativeFieldInfoPtr_KICKED;

	private static readonly System.IntPtr NativeFieldInfoPtr_BANNED;

	private static readonly System.IntPtr NativeFieldInfoPtr_GAME_STILL_LOADING;

	private static readonly System.IntPtr NativeFieldInfoPtr_BAD_STATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_INCOMPATIBLE_VERSION;

	private static readonly System.IntPtr NativeFieldInfoPtr_RATE_LIMIT;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_Int32_0;

	public unsafe static int SUCCESS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUCCESS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUCCESS, (void*)(&num));
		}
	}

	public unsafe static int GAME_FULL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GAME_FULL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GAME_FULL, (void*)(&num));
		}
	}

	public unsafe static int LOBBY_NO_LONGER_EXISTS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOBBY_NO_LONGER_EXISTS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOBBY_NO_LONGER_EXISTS, (void*)(&num));
		}
	}

	public unsafe static int NOT_ALLOWED_TO_JOIN_LOBBY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOT_ALLOWED_TO_JOIN_LOBBY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOT_ALLOWED_TO_JOIN_LOBBY, (void*)(&num));
		}
	}

	public unsafe static int GENERATION_FAILURE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GENERATION_FAILURE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GENERATION_FAILURE, (void*)(&num));
		}
	}

	public unsafe static int UNEXPECTED_ERROR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UNEXPECTED_ERROR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UNEXPECTED_ERROR, (void*)(&num));
		}
	}

	public unsafe static int NO_STEAM_CONNECTION
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NO_STEAM_CONNECTION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NO_STEAM_CONNECTION, (void*)(&num));
		}
	}

	public unsafe static int STEAM_TIMEOUT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STEAM_TIMEOUT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STEAM_TIMEOUT, (void*)(&num));
		}
	}

	public unsafe static int STEAM_FAILURE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STEAM_FAILURE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STEAM_FAILURE, (void*)(&num));
		}
	}

	public unsafe static int CONNECTION_FAILURE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONNECTION_FAILURE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONNECTION_FAILURE, (void*)(&num));
		}
	}

	public unsafe static int CONNECTION_CLOSED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONNECTION_CLOSED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONNECTION_CLOSED, (void*)(&num));
		}
	}

	public unsafe static int CONNECTION_TIMEOUT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONNECTION_TIMEOUT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONNECTION_TIMEOUT, (void*)(&num));
		}
	}

	public unsafe static int SAVE_CORRUPTED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAVE_CORRUPTED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAVE_CORRUPTED, (void*)(&num));
		}
	}

	public unsafe static int DISK_FULL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISK_FULL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISK_FULL, (void*)(&num));
		}
	}

	public unsafe static int HOST_SHUTTING_DOWN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HOST_SHUTTING_DOWN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HOST_SHUTTING_DOWN, (void*)(&num));
		}
	}

	public unsafe static int WRONG_PASSWORD
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WRONG_PASSWORD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WRONG_PASSWORD, (void*)(&num));
		}
	}

	public unsafe static int KICKED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KICKED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KICKED, (void*)(&num));
		}
	}

	public unsafe static int BANNED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BANNED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BANNED, (void*)(&num));
		}
	}

	public unsafe static int GAME_STILL_LOADING
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GAME_STILL_LOADING, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GAME_STILL_LOADING, (void*)(&num));
		}
	}

	public unsafe static int BAD_STATE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BAD_STATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BAD_STATE, (void*)(&num));
		}
	}

	public unsafe static int INCOMPATIBLE_VERSION
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INCOMPATIBLE_VERSION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INCOMPATIBLE_VERSION, (void*)(&num));
		}
	}

	public unsafe static int RATE_LIMIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RATE_LIMIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RATE_LIMIT, (void*)(&num));
		}
	}

	static ResultCode()
	{
		Il2CppClassPointerStore<ResultCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ResultCode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResultCode>.NativeClassPtr);
		NativeFieldInfoPtr_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "SUCCESS");
		NativeFieldInfoPtr_GAME_FULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "GAME_FULL");
		NativeFieldInfoPtr_LOBBY_NO_LONGER_EXISTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "LOBBY_NO_LONGER_EXISTS");
		NativeFieldInfoPtr_NOT_ALLOWED_TO_JOIN_LOBBY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "NOT_ALLOWED_TO_JOIN_LOBBY");
		NativeFieldInfoPtr_GENERATION_FAILURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "GENERATION_FAILURE");
		NativeFieldInfoPtr_UNEXPECTED_ERROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "UNEXPECTED_ERROR");
		NativeFieldInfoPtr_NO_STEAM_CONNECTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "NO_STEAM_CONNECTION");
		NativeFieldInfoPtr_STEAM_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "STEAM_TIMEOUT");
		NativeFieldInfoPtr_STEAM_FAILURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "STEAM_FAILURE");
		NativeFieldInfoPtr_CONNECTION_FAILURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "CONNECTION_FAILURE");
		NativeFieldInfoPtr_CONNECTION_CLOSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "CONNECTION_CLOSED");
		NativeFieldInfoPtr_CONNECTION_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "CONNECTION_TIMEOUT");
		NativeFieldInfoPtr_SAVE_CORRUPTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "SAVE_CORRUPTED");
		NativeFieldInfoPtr_DISK_FULL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "DISK_FULL");
		NativeFieldInfoPtr_HOST_SHUTTING_DOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "HOST_SHUTTING_DOWN");
		NativeFieldInfoPtr_WRONG_PASSWORD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "WRONG_PASSWORD");
		NativeFieldInfoPtr_KICKED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "KICKED");
		NativeFieldInfoPtr_BANNED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "BANNED");
		NativeFieldInfoPtr_GAME_STILL_LOADING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "GAME_STILL_LOADING");
		NativeFieldInfoPtr_BAD_STATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "BAD_STATE");
		NativeFieldInfoPtr_INCOMPATIBLE_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "INCOMPATIBLE_VERSION");
		NativeFieldInfoPtr_RATE_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, "RATE_LIMIT");
		NativeMethodInfoPtr_GetText_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultCode>.NativeClassPtr, 100664555);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 32386, RefRangeEnd = 32405, XrefRangeStart = 32357, XrefRangeEnd = 32386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetText(int resultCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resultCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetText_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public ResultCode(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

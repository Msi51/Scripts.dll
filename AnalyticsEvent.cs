using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class AnalyticsEvent : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NEW_GAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_DEATH;

	private static readonly System.IntPtr NativeFieldInfoPtr_RETURN_TO_MAIN_MENU;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOAD_LAST_SAVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOAD_GAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_GAME_SAVED;

	private static readonly System.IntPtr NativeFieldInfoPtr_JOIN_GAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_JOIN_GAME_FAILURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_OBJECTIVE_ASSIGNED;

	private static readonly System.IntPtr NativeFieldInfoPtr_OBJECTIVE_TASK_GROUP_COMPLETE;

	private static readonly System.IntPtr NativeFieldInfoPtr_OBJECTIVE_TASK_GROUP_SKIPPED;

	private static readonly System.IntPtr NativeFieldInfoPtr_WORLD_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_NEW_DAY_REACHED;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_JOINED;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_LEFT;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_LEVEL_UP;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOG_MESSAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_QUIT;

	public unsafe static string NEW_GAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEW_GAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEW_GAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PLAYER_DEATH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_DEATH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_DEATH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RETURN_TO_MAIN_MENU
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RETURN_TO_MAIN_MENU, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RETURN_TO_MAIN_MENU, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LOAD_LAST_SAVE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOAD_LAST_SAVE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOAD_LAST_SAVE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LOAD_GAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOAD_GAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOAD_GAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GAME_SAVED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GAME_SAVED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GAME_SAVED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string JOIN_GAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JOIN_GAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JOIN_GAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string JOIN_GAME_FAILURE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JOIN_GAME_FAILURE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JOIN_GAME_FAILURE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OBJECTIVE_ASSIGNED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OBJECTIVE_ASSIGNED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OBJECTIVE_ASSIGNED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OBJECTIVE_TASK_GROUP_COMPLETE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OBJECTIVE_TASK_GROUP_COMPLETE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OBJECTIVE_TASK_GROUP_COMPLETE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OBJECTIVE_TASK_GROUP_SKIPPED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OBJECTIVE_TASK_GROUP_SKIPPED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OBJECTIVE_TASK_GROUP_SKIPPED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WORLD_EVENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WORLD_EVENT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WORLD_EVENT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NEW_DAY_REACHED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEW_DAY_REACHED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEW_DAY_REACHED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PLAYER_JOINED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_JOINED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_JOINED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PLAYER_LEFT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_LEFT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_LEFT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SKILL_LEVEL_UP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_LEVEL_UP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_LEVEL_UP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LOG_MESSAGE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOG_MESSAGE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOG_MESSAGE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string QUIT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QUIT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QUIT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static AnalyticsEvent()
	{
		Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "AnalyticsEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr);
		NativeFieldInfoPtr_NEW_GAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "NEW_GAME");
		NativeFieldInfoPtr_PLAYER_DEATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "PLAYER_DEATH");
		NativeFieldInfoPtr_RETURN_TO_MAIN_MENU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "RETURN_TO_MAIN_MENU");
		NativeFieldInfoPtr_LOAD_LAST_SAVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "LOAD_LAST_SAVE");
		NativeFieldInfoPtr_LOAD_GAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "LOAD_GAME");
		NativeFieldInfoPtr_GAME_SAVED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "GAME_SAVED");
		NativeFieldInfoPtr_JOIN_GAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "JOIN_GAME");
		NativeFieldInfoPtr_JOIN_GAME_FAILURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "JOIN_GAME_FAILURE");
		NativeFieldInfoPtr_OBJECTIVE_ASSIGNED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "OBJECTIVE_ASSIGNED");
		NativeFieldInfoPtr_OBJECTIVE_TASK_GROUP_COMPLETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "OBJECTIVE_TASK_GROUP_COMPLETE");
		NativeFieldInfoPtr_OBJECTIVE_TASK_GROUP_SKIPPED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "OBJECTIVE_TASK_GROUP_SKIPPED");
		NativeFieldInfoPtr_WORLD_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "WORLD_EVENT");
		NativeFieldInfoPtr_NEW_DAY_REACHED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "NEW_DAY_REACHED");
		NativeFieldInfoPtr_PLAYER_JOINED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "PLAYER_JOINED");
		NativeFieldInfoPtr_PLAYER_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "PLAYER_LEFT");
		NativeFieldInfoPtr_SKILL_LEVEL_UP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "SKILL_LEVEL_UP");
		NativeFieldInfoPtr_LOG_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "LOG_MESSAGE");
		NativeFieldInfoPtr_QUIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsEvent>.NativeClassPtr, "QUIT");
	}

	public AnalyticsEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

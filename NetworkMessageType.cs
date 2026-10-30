using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public static class NetworkMessageType : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CONNECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_JOIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_FINISH_LOAD;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHARACTER_CUSTOMIZATION;

	private static readonly System.IntPtr NativeFieldInfoPtr_GAME_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_WORLD_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_CHUNK_DATA;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHUNK;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHUNK_DATA;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHUNK_DATA_RECEIVED;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHUNK_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_CAVE_DATA;

	private static readonly System.IntPtr NativeFieldInfoPtr_CAVE_DATA;

	private static readonly System.IntPtr NativeFieldInfoPtr_CAVE_DATA_RECEIVED;

	private static readonly System.IntPtr NativeFieldInfoPtr_SPAWN_ENTITY;

	private static readonly System.IntPtr NativeFieldInfoPtr_DESPAWN_ENTITY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_DAMAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_LEVEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_LIVING_ENTITY_DEAD;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERACTION_STARTED;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERACTION_ENDED;

	private static readonly System.IntPtr NativeFieldInfoPtr_END_INTERACTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERACTION_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERACTION_EFFECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERACTION_EFFECT_RESULT;

	private static readonly System.IntPtr NativeFieldInfoPtr_CREATE_BUILDING_SECTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_BUILDING_SECTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_DELETE_BUILDING_SECTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAY_SOUND;

	private static readonly System.IntPtr NativeFieldInfoPtr_TERRAIN_HEIGHTMAP_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TERRAIN_ALPHAMAP_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TERRAIN_WATERMAP_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TERRAIN_DETAILMAP_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_WORLD_SLEEP_STARTING;

	private static readonly System.IntPtr NativeFieldInfoPtr_AWAKEN_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_RESPAWN;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_RESPAWNED;

	private static readonly System.IntPtr NativeFieldInfoPtr_SYNC_COMPLETED_HINTS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ADD_OBJECTIVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_OBJECTIVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ADD_OBJECTIVE_TASK_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_OBJECTIVE_TASK_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_COMPLETE_HINT;

	private static readonly System.IntPtr NativeFieldInfoPtr_READ_OBJECTIVE_TASK_GROUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_SELECTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_WORLD_TEXT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TERRAIN_LAYER_ZONE_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_WORLD_CAMP_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_WORLD_PLAYER_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_WORLD_DISEASE_CENTER_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CREATE_EFFECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOVABLE_PARENT_CREATED;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHARACTER_INSTANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAT_MESSAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_ACTIVITY;

	private static readonly System.IntPtr NativeFieldInfoPtr_GAME_EVENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_FIELD;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_TRANSFORM;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_ANIMATOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_ANIMATOR_BOOL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_ANIMATOR_BOOLS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_ANIMATOR_TRIGGER;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_SLOT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_SECTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_STACK_ORIGIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_CONTAINER_MIXTURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_MOVEMENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_MOVEMENT_POSITION;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_STATUS_EFFECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_SOUND_EMITTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_DISTILLER_MIXTURES;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_INJURY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_SKILL_SETUP;

	public unsafe static byte CONNECT
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONNECT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONNECT, (void*)(&b));
		}
	}

	public unsafe static byte JOIN
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JOIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JOIN, (void*)(&b));
		}
	}

	public unsafe static byte FINISH_LOAD
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FINISH_LOAD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FINISH_LOAD, (void*)(&b));
		}
	}

	public unsafe static byte CHARACTER_CUSTOMIZATION
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHARACTER_CUSTOMIZATION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHARACTER_CUSTOMIZATION, (void*)(&b));
		}
	}

	public unsafe static byte GAME_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GAME_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GAME_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte WORLD_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WORLD_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WORLD_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte REQUEST_CHUNK_DATA
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_CHUNK_DATA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_CHUNK_DATA, (void*)(&b));
		}
	}

	public unsafe static byte CHUNK
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHUNK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHUNK, (void*)(&b));
		}
	}

	public unsafe static byte CHUNK_DATA
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHUNK_DATA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHUNK_DATA, (void*)(&b));
		}
	}

	public unsafe static byte CHUNK_DATA_RECEIVED
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHUNK_DATA_RECEIVED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHUNK_DATA_RECEIVED, (void*)(&b));
		}
	}

	public unsafe static byte CHUNK_INFO
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHUNK_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHUNK_INFO, (void*)(&b));
		}
	}

	public unsafe static byte REQUEST_CAVE_DATA
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_CAVE_DATA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_CAVE_DATA, (void*)(&b));
		}
	}

	public unsafe static byte CAVE_DATA
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CAVE_DATA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CAVE_DATA, (void*)(&b));
		}
	}

	public unsafe static byte CAVE_DATA_RECEIVED
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CAVE_DATA_RECEIVED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CAVE_DATA_RECEIVED, (void*)(&b));
		}
	}

	public unsafe static byte SPAWN_ENTITY
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SPAWN_ENTITY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SPAWN_ENTITY, (void*)(&b));
		}
	}

	public unsafe static byte DESPAWN_ENTITY
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DESPAWN_ENTITY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DESPAWN_ENTITY, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_DAMAGE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_DAMAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_DAMAGE, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_LEVEL
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_LEVEL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_LEVEL, (void*)(&b));
		}
	}

	public unsafe static byte LIVING_ENTITY_DEAD
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LIVING_ENTITY_DEAD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LIVING_ENTITY_DEAD, (void*)(&b));
		}
	}

	public unsafe static byte INTERACTION_STARTED
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERACTION_STARTED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERACTION_STARTED, (void*)(&b));
		}
	}

	public unsafe static byte INTERACTION_ENDED
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERACTION_ENDED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERACTION_ENDED, (void*)(&b));
		}
	}

	public unsafe static byte END_INTERACTION
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_END_INTERACTION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_END_INTERACTION, (void*)(&b));
		}
	}

	public unsafe static byte INTERACTION_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERACTION_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERACTION_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte INTERACTION_EFFECT
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERACTION_EFFECT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERACTION_EFFECT, (void*)(&b));
		}
	}

	public unsafe static byte INTERACTION_EFFECT_RESULT
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERACTION_EFFECT_RESULT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERACTION_EFFECT_RESULT, (void*)(&b));
		}
	}

	public unsafe static byte CREATE_BUILDING_SECTION
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CREATE_BUILDING_SECTION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CREATE_BUILDING_SECTION, (void*)(&b));
		}
	}

	public unsafe static byte UPDATE_BUILDING_SECTION
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_BUILDING_SECTION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_BUILDING_SECTION, (void*)(&b));
		}
	}

	public unsafe static byte DELETE_BUILDING_SECTION
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DELETE_BUILDING_SECTION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DELETE_BUILDING_SECTION, (void*)(&b));
		}
	}

	public unsafe static byte PLAY_SOUND
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAY_SOUND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAY_SOUND, (void*)(&b));
		}
	}

	public unsafe static byte TERRAIN_HEIGHTMAP_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TERRAIN_HEIGHTMAP_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TERRAIN_HEIGHTMAP_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte TERRAIN_ALPHAMAP_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TERRAIN_ALPHAMAP_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TERRAIN_ALPHAMAP_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte TERRAIN_WATERMAP_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TERRAIN_WATERMAP_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TERRAIN_WATERMAP_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte TERRAIN_DETAILMAP_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TERRAIN_DETAILMAP_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TERRAIN_DETAILMAP_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte WORLD_SLEEP_STARTING
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WORLD_SLEEP_STARTING, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WORLD_SLEEP_STARTING, (void*)(&b));
		}
	}

	public unsafe static byte AWAKEN_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AWAKEN_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AWAKEN_PLAYER, (void*)(&b));
		}
	}

	public unsafe static byte REQUEST_RESPAWN
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_RESPAWN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_RESPAWN, (void*)(&b));
		}
	}

	public unsafe static byte PLAYER_RESPAWNED
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_RESPAWNED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_RESPAWNED, (void*)(&b));
		}
	}

	public unsafe static byte SYNC_COMPLETED_HINTS
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SYNC_COMPLETED_HINTS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SYNC_COMPLETED_HINTS, (void*)(&b));
		}
	}

	public unsafe static byte ADD_OBJECTIVE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ADD_OBJECTIVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ADD_OBJECTIVE, (void*)(&b));
		}
	}

	public unsafe static byte UPDATE_OBJECTIVE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_OBJECTIVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_OBJECTIVE, (void*)(&b));
		}
	}

	public unsafe static byte ADD_OBJECTIVE_TASK_GROUP
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ADD_OBJECTIVE_TASK_GROUP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ADD_OBJECTIVE_TASK_GROUP, (void*)(&b));
		}
	}

	public unsafe static byte UPDATE_OBJECTIVE_TASK_GROUP
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_OBJECTIVE_TASK_GROUP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_OBJECTIVE_TASK_GROUP, (void*)(&b));
		}
	}

	public unsafe static byte COMPLETE_HINT
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COMPLETE_HINT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COMPLETE_HINT, (void*)(&b));
		}
	}

	public unsafe static byte READ_OBJECTIVE_TASK_GROUP
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_READ_OBJECTIVE_TASK_GROUP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_READ_OBJECTIVE_TASK_GROUP, (void*)(&b));
		}
	}

	public unsafe static byte PLAYER_SELECTION
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_SELECTION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_SELECTION, (void*)(&b));
		}
	}

	public unsafe static byte WORLD_TEXT
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WORLD_TEXT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WORLD_TEXT, (void*)(&b));
		}
	}

	public unsafe static byte TERRAIN_LAYER_ZONE_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TERRAIN_LAYER_ZONE_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TERRAIN_LAYER_ZONE_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte WORLD_CAMP_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WORLD_CAMP_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WORLD_CAMP_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte WORLD_PLAYER_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WORLD_PLAYER_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WORLD_PLAYER_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte WORLD_DISEASE_CENTER_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WORLD_DISEASE_CENTER_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WORLD_DISEASE_CENTER_UPDATE, (void*)(&b));
		}
	}

	public unsafe static byte CREATE_EFFECT
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CREATE_EFFECT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CREATE_EFFECT, (void*)(&b));
		}
	}

	public unsafe static byte MOVABLE_PARENT_CREATED
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOVABLE_PARENT_CREATED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOVABLE_PARENT_CREATED, (void*)(&b));
		}
	}

	public unsafe static byte CHARACTER_INSTANCE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHARACTER_INSTANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHARACTER_INSTANCE, (void*)(&b));
		}
	}

	public unsafe static byte CHAT_MESSAGE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAT_MESSAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAT_MESSAGE, (void*)(&b));
		}
	}

	public unsafe static byte PLAYER_ACTIVITY
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_ACTIVITY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_ACTIVITY, (void*)(&b));
		}
	}

	public unsafe static byte GAME_EVENT
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GAME_EVENT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GAME_EVENT, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_FIELD
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_FIELD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_FIELD, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_TRANSFORM
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_TRANSFORM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_TRANSFORM, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_ANIMATOR
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_ANIMATOR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_ANIMATOR, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_ANIMATOR_BOOL
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_ANIMATOR_BOOL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_ANIMATOR_BOOL, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_ANIMATOR_BOOLS
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_ANIMATOR_BOOLS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_ANIMATOR_BOOLS, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_ANIMATOR_TRIGGER
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_ANIMATOR_TRIGGER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_ANIMATOR_TRIGGER, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_INVENTORY_HOLDER_SLOT
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_SLOT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_SLOT, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_INVENTORY_HOLDER_SECTION
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_SECTION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_SECTION, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_INVENTORY_HOLDER_STACK_ORIGIN
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_STACK_ORIGIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_STACK_ORIGIN, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_CONTAINER_MIXTURE
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_CONTAINER_MIXTURE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_CONTAINER_MIXTURE, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_MOVEMENT
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_MOVEMENT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_MOVEMENT, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_MOVEMENT_POSITION
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_MOVEMENT_POSITION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_MOVEMENT_POSITION, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_STATUS_EFFECT
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_STATUS_EFFECT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_STATUS_EFFECT, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_SOUND_EMITTER
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_SOUND_EMITTER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_SOUND_EMITTER, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_DISTILLER_MIXTURES
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_DISTILLER_MIXTURES, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_DISTILLER_MIXTURES, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_INJURY
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_INJURY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_INJURY, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_SKILL
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_SKILL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_SKILL, (void*)(&b));
		}
	}

	public unsafe static byte ENTITY_SKILL_SETUP
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_SKILL_SETUP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_SKILL_SETUP, (void*)(&b));
		}
	}

	static NetworkMessageType()
	{
		Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NetworkMessageType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr);
		NativeFieldInfoPtr_CONNECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CONNECT");
		NativeFieldInfoPtr_JOIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "JOIN");
		NativeFieldInfoPtr_FINISH_LOAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "FINISH_LOAD");
		NativeFieldInfoPtr_CHARACTER_CUSTOMIZATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CHARACTER_CUSTOMIZATION");
		NativeFieldInfoPtr_GAME_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "GAME_UPDATE");
		NativeFieldInfoPtr_WORLD_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "WORLD_UPDATE");
		NativeFieldInfoPtr_REQUEST_CHUNK_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "REQUEST_CHUNK_DATA");
		NativeFieldInfoPtr_CHUNK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CHUNK");
		NativeFieldInfoPtr_CHUNK_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CHUNK_DATA");
		NativeFieldInfoPtr_CHUNK_DATA_RECEIVED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CHUNK_DATA_RECEIVED");
		NativeFieldInfoPtr_CHUNK_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CHUNK_INFO");
		NativeFieldInfoPtr_REQUEST_CAVE_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "REQUEST_CAVE_DATA");
		NativeFieldInfoPtr_CAVE_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CAVE_DATA");
		NativeFieldInfoPtr_CAVE_DATA_RECEIVED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CAVE_DATA_RECEIVED");
		NativeFieldInfoPtr_SPAWN_ENTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "SPAWN_ENTITY");
		NativeFieldInfoPtr_DESPAWN_ENTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "DESPAWN_ENTITY");
		NativeFieldInfoPtr_ENTITY_DAMAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_DAMAGE");
		NativeFieldInfoPtr_ENTITY_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_LEVEL");
		NativeFieldInfoPtr_LIVING_ENTITY_DEAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "LIVING_ENTITY_DEAD");
		NativeFieldInfoPtr_INTERACTION_STARTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "INTERACTION_STARTED");
		NativeFieldInfoPtr_INTERACTION_ENDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "INTERACTION_ENDED");
		NativeFieldInfoPtr_END_INTERACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "END_INTERACTION");
		NativeFieldInfoPtr_INTERACTION_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "INTERACTION_UPDATE");
		NativeFieldInfoPtr_INTERACTION_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "INTERACTION_EFFECT");
		NativeFieldInfoPtr_INTERACTION_EFFECT_RESULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "INTERACTION_EFFECT_RESULT");
		NativeFieldInfoPtr_CREATE_BUILDING_SECTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CREATE_BUILDING_SECTION");
		NativeFieldInfoPtr_UPDATE_BUILDING_SECTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "UPDATE_BUILDING_SECTION");
		NativeFieldInfoPtr_DELETE_BUILDING_SECTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "DELETE_BUILDING_SECTION");
		NativeFieldInfoPtr_PLAY_SOUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "PLAY_SOUND");
		NativeFieldInfoPtr_TERRAIN_HEIGHTMAP_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "TERRAIN_HEIGHTMAP_UPDATE");
		NativeFieldInfoPtr_TERRAIN_ALPHAMAP_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "TERRAIN_ALPHAMAP_UPDATE");
		NativeFieldInfoPtr_TERRAIN_WATERMAP_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "TERRAIN_WATERMAP_UPDATE");
		NativeFieldInfoPtr_TERRAIN_DETAILMAP_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "TERRAIN_DETAILMAP_UPDATE");
		NativeFieldInfoPtr_WORLD_SLEEP_STARTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "WORLD_SLEEP_STARTING");
		NativeFieldInfoPtr_AWAKEN_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "AWAKEN_PLAYER");
		NativeFieldInfoPtr_REQUEST_RESPAWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "REQUEST_RESPAWN");
		NativeFieldInfoPtr_PLAYER_RESPAWNED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "PLAYER_RESPAWNED");
		NativeFieldInfoPtr_SYNC_COMPLETED_HINTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "SYNC_COMPLETED_HINTS");
		NativeFieldInfoPtr_ADD_OBJECTIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ADD_OBJECTIVE");
		NativeFieldInfoPtr_UPDATE_OBJECTIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "UPDATE_OBJECTIVE");
		NativeFieldInfoPtr_ADD_OBJECTIVE_TASK_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ADD_OBJECTIVE_TASK_GROUP");
		NativeFieldInfoPtr_UPDATE_OBJECTIVE_TASK_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "UPDATE_OBJECTIVE_TASK_GROUP");
		NativeFieldInfoPtr_COMPLETE_HINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "COMPLETE_HINT");
		NativeFieldInfoPtr_READ_OBJECTIVE_TASK_GROUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "READ_OBJECTIVE_TASK_GROUP");
		NativeFieldInfoPtr_PLAYER_SELECTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "PLAYER_SELECTION");
		NativeFieldInfoPtr_WORLD_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "WORLD_TEXT");
		NativeFieldInfoPtr_TERRAIN_LAYER_ZONE_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "TERRAIN_LAYER_ZONE_UPDATE");
		NativeFieldInfoPtr_WORLD_CAMP_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "WORLD_CAMP_UPDATE");
		NativeFieldInfoPtr_WORLD_PLAYER_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "WORLD_PLAYER_UPDATE");
		NativeFieldInfoPtr_WORLD_DISEASE_CENTER_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "WORLD_DISEASE_CENTER_UPDATE");
		NativeFieldInfoPtr_CREATE_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CREATE_EFFECT");
		NativeFieldInfoPtr_MOVABLE_PARENT_CREATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "MOVABLE_PARENT_CREATED");
		NativeFieldInfoPtr_CHARACTER_INSTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CHARACTER_INSTANCE");
		NativeFieldInfoPtr_CHAT_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "CHAT_MESSAGE");
		NativeFieldInfoPtr_PLAYER_ACTIVITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "PLAYER_ACTIVITY");
		NativeFieldInfoPtr_GAME_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "GAME_EVENT");
		NativeFieldInfoPtr_ENTITY_FIELD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_FIELD");
		NativeFieldInfoPtr_ENTITY_TRANSFORM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_TRANSFORM");
		NativeFieldInfoPtr_ENTITY_ANIMATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_ANIMATOR");
		NativeFieldInfoPtr_ENTITY_ANIMATOR_BOOL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_ANIMATOR_BOOL");
		NativeFieldInfoPtr_ENTITY_ANIMATOR_BOOLS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_ANIMATOR_BOOLS");
		NativeFieldInfoPtr_ENTITY_ANIMATOR_TRIGGER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_ANIMATOR_TRIGGER");
		NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_SLOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_INVENTORY_HOLDER_SLOT");
		NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_SECTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_INVENTORY_HOLDER_SECTION");
		NativeFieldInfoPtr_ENTITY_INVENTORY_HOLDER_STACK_ORIGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_INVENTORY_HOLDER_STACK_ORIGIN");
		NativeFieldInfoPtr_ENTITY_CONTAINER_MIXTURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_CONTAINER_MIXTURE");
		NativeFieldInfoPtr_ENTITY_MOVEMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_MOVEMENT");
		NativeFieldInfoPtr_ENTITY_MOVEMENT_POSITION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_MOVEMENT_POSITION");
		NativeFieldInfoPtr_ENTITY_STATUS_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_STATUS_EFFECT");
		NativeFieldInfoPtr_ENTITY_SOUND_EMITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_SOUND_EMITTER");
		NativeFieldInfoPtr_ENTITY_DISTILLER_MIXTURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_DISTILLER_MIXTURES");
		NativeFieldInfoPtr_ENTITY_INJURY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_INJURY");
		NativeFieldInfoPtr_ENTITY_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_SKILL");
		NativeFieldInfoPtr_ENTITY_SKILL_SETUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageType>.NativeClassPtr, "ENTITY_SKILL_SETUP");
	}

	public NetworkMessageType(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

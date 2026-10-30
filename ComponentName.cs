using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

public class ComponentName : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AI_CONTROLLED;

	private static readonly System.IntPtr NativeFieldInfoPtr_ANIMATED_MOVER;

	private static readonly System.IntPtr NativeFieldInfoPtr_BOAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_BURNABLE_CONSTRUCTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHARACTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_COMPASS_NEEDLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONSTRUCTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONTAINER;

	private static readonly System.IntPtr NativeFieldInfoPtr_COOKER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CRAFTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CREATURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CREATURE_REPULSION;

	private static readonly System.IntPtr NativeFieldInfoPtr_CUSTOMIZABLE_SKINNED_RENDERER;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEAD_GROWABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DECAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_DECAYABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DETAIL_DISPLACEMENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_DIALOG_CONVERSER;

	private static readonly System.IntPtr NativeFieldInfoPtr_DISEASE_CLOUD;

	private static readonly System.IntPtr NativeFieldInfoPtr_DISEASE_EFFECT_EMITTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_DISEASE_CLEARING;

	private static readonly System.IntPtr NativeFieldInfoPtr_DISEASED;

	private static readonly System.IntPtr NativeFieldInfoPtr_DISTILLER;

	private static readonly System.IntPtr NativeFieldInfoPtr_DOOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENERGY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENTITY_MOVEMENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_EQUIPPED_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_FUEL_BURNER;

	private static readonly System.IntPtr NativeFieldInfoPtr_GATHERABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_GENERATED_STRUCTURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_GRABBABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_GRABBER;

	private static readonly System.IntPtr NativeFieldInfoPtr_GROWABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_HARVESTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_HEATED_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_HITPOINTS;

	private static readonly System.IntPtr NativeFieldInfoPtr_HOSTILITY;

	private static readonly System.IntPtr NativeFieldInfoPtr_HUMANOID_ATTACKER;

	private static readonly System.IntPtr NativeFieldInfoPtr_HUMANOID_EQUIPPER;

	private static readonly System.IntPtr NativeFieldInfoPtr_HUNGER;

	private static readonly System.IntPtr NativeFieldInfoPtr_IGNITING_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_INDOOR_LEVEL_NAVIGATOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_INDOOR_LEVEL_TRIGGER;

	private static readonly System.IntPtr NativeFieldInfoPtr_INJURY;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERACTABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERACTOR;

	private static readonly System.IntPtr NativeFieldInfoPtr_INVENTORY_HOLDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEM_CONTAINER;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEM_FUELED;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEM_STOCKPILE;

	private static readonly System.IntPtr NativeFieldInfoPtr_KILN;

	private static readonly System.IntPtr NativeFieldInfoPtr_LIGHT_EMITTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_LIVING;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOOSE_SUBSTANCE_STOCKPILE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAP_EXPLORER;

	private static readonly System.IntPtr NativeFieldInfoPtr_MINIMAP_REPRESENTATION;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOLTEN_METAL_MOLD;

	private static readonly System.IntPtr NativeFieldInfoPtr_NAVIGATION_MARKER;

	private static readonly System.IntPtr NativeFieldInfoPtr_OBSCURABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PARTICLE_EFFECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_PHYSICS_OBJECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_PICKUPABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLACEABLE_SURFACE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLACED_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_INPUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_POOLED_INSTANCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PRESERVATION_CONTAINER;

	private static readonly System.IntPtr NativeFieldInfoPtr_PROJECTILE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PROJECTILE_ATTACHER;

	private static readonly System.IntPtr NativeFieldInfoPtr_PROXIMITY_HEATING;

	private static readonly System.IntPtr NativeFieldInfoPtr_RAIN_AFFECTED;

	private static readonly System.IntPtr NativeFieldInfoPtr_RAIN_COVER;

	private static readonly System.IntPtr NativeFieldInfoPtr_RAIN_COVERABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_RAIN_COVER_COLLIDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_REPAIR_BENCH;

	private static readonly System.IntPtr NativeFieldInfoPtr_REPAIRER;

	private static readonly System.IntPtr NativeFieldInfoPtr_RESOURCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ROAD_SIGN;

	private static readonly System.IntPtr NativeFieldInfoPtr_ROAD_SIGN_DIRECTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_SELECTABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHOWABLE_INTERACTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILLS;

	private static readonly System.IntPtr NativeFieldInfoPtr_SLEEPER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SLEEPABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SMOKE_RACK;

	private static readonly System.IntPtr NativeFieldInfoPtr_SNOW_COVER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SOAKER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SOUND_EMITTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_STAMINA;

	private static readonly System.IntPtr NativeFieldInfoPtr_STATUS_EFFECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_STORABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_STORABLE_EQUIPPER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SUN_BLOCKER;

	private static readonly System.IntPtr NativeFieldInfoPtr_SURFACE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TANNING_FRAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_TERRAIN_SHOWABLE_INTERACTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_THIRST;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOOLABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOXIC_DAMAGE_TAKER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOXIC_SMOKE_EMITTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRADER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRAPPABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_WARMTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_WATER_COLLIDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_WETNESS;

	private static readonly System.IntPtr NativeFieldInfoPtr_WIND_AFFECTED;

	private static readonly System.IntPtr NativeFieldInfoPtr_WHEELED_ENTITY;

	private static readonly System.IntPtr NativeFieldInfoPtr_WORKBENCH;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string AI_CONTROLLED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AI_CONTROLLED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AI_CONTROLLED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ANIMATED_MOVER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ANIMATED_MOVER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ANIMATED_MOVER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BOAT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BOAT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BOAT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BURNABLE_CONSTRUCTION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BURNABLE_CONSTRUCTION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BURNABLE_CONSTRUCTION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CHARACTER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHARACTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHARACTER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string COMPASS_NEEDLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COMPASS_NEEDLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COMPASS_NEEDLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CONSTRUCTION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONSTRUCTION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONSTRUCTION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CONTAINER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONTAINER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONTAINER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string COOKER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COOKER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COOKER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CRAFTER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CRAFTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CRAFTER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CREATURE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CREATURE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CREATURE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CREATURE_REPULSION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CREATURE_REPULSION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CREATURE_REPULSION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CUSTOMIZABLE_SKINNED_RENDERER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CUSTOMIZABLE_SKINNED_RENDERER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CUSTOMIZABLE_SKINNED_RENDERER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DEAD_GROWABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEAD_GROWABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEAD_GROWABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DECAL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DECAL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DECAL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DECAYABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DECAYABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DECAYABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DETAIL_DISPLACEMENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DETAIL_DISPLACEMENT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DETAIL_DISPLACEMENT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DIALOG_CONVERSER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DIALOG_CONVERSER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DIALOG_CONVERSER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DISEASE_CLOUD
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISEASE_CLOUD, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISEASE_CLOUD, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DISEASE_EFFECT_EMITTER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISEASE_EFFECT_EMITTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISEASE_EFFECT_EMITTER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DISEASE_CLEARING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISEASE_CLEARING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISEASE_CLEARING, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DISEASED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISEASED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISEASED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DISTILLER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISTILLER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISTILLER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DOOR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOOR, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOOR, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENERGY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENERGY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENERGY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENTITY_MOVEMENT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENTITY_MOVEMENT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENTITY_MOVEMENT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EQUIPPED_ITEM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EQUIPPED_ITEM, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EQUIPPED_ITEM, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string FUEL_BURNER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FUEL_BURNER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FUEL_BURNER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GATHERABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GATHERABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GATHERABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GENERATED_STRUCTURE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GENERATED_STRUCTURE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GENERATED_STRUCTURE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GRABBABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GRABBABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GRABBABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GRABBER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GRABBER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GRABBER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GROWABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GROWABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GROWABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HARVESTER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HARVESTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HARVESTER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HEATED_ITEM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HEATED_ITEM, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HEATED_ITEM, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HITPOINTS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HITPOINTS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HITPOINTS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HOSTILITY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HOSTILITY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HOSTILITY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HUMANOID_ATTACKER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HUMANOID_ATTACKER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HUMANOID_ATTACKER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HUMANOID_EQUIPPER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HUMANOID_EQUIPPER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HUMANOID_EQUIPPER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HUNGER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HUNGER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HUNGER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string IGNITING_ITEM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IGNITING_ITEM, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IGNITING_ITEM, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string INDOOR_LEVEL_NAVIGATOR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INDOOR_LEVEL_NAVIGATOR, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INDOOR_LEVEL_NAVIGATOR, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string INDOOR_LEVEL_TRIGGER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INDOOR_LEVEL_TRIGGER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INDOOR_LEVEL_TRIGGER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string INJURY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INJURY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INJURY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string INTERACTABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERACTABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERACTABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string INTERACTOR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERACTOR, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERACTOR, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string INVENTORY_HOLDER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INVENTORY_HOLDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INVENTORY_HOLDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ITEM_CONTAINER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEM_CONTAINER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEM_CONTAINER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ITEM_FUELED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEM_FUELED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEM_FUELED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ITEM_STOCKPILE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEM_STOCKPILE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEM_STOCKPILE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string KILN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KILN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KILN, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LIGHT_EMITTER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LIGHT_EMITTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LIGHT_EMITTER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LIVING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LIVING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LIVING, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LOOSE_SUBSTANCE_STOCKPILE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOOSE_SUBSTANCE_STOCKPILE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOOSE_SUBSTANCE_STOCKPILE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MAP_EXPLORER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAP_EXPLORER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAP_EXPLORER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MINIMAP_REPRESENTATION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MINIMAP_REPRESENTATION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MINIMAP_REPRESENTATION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MOLTEN_METAL_MOLD
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOLTEN_METAL_MOLD, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOLTEN_METAL_MOLD, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NAVIGATION_MARKER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NAVIGATION_MARKER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NAVIGATION_MARKER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OBSCURABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OBSCURABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OBSCURABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PARTICLE_EFFECT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PARTICLE_EFFECT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PARTICLE_EFFECT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PHYSICS_OBJECT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PHYSICS_OBJECT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PHYSICS_OBJECT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PICKUPABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PICKUPABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PICKUPABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PLACEABLE_SURFACE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLACEABLE_SURFACE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLACEABLE_SURFACE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PLACED_ITEM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLACED_ITEM, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLACED_ITEM, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PLAYER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PLAYER_INPUT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_INPUT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_INPUT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string POOLED_INSTANCE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_POOLED_INSTANCE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_POOLED_INSTANCE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PRESERVATION_CONTAINER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PRESERVATION_CONTAINER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PRESERVATION_CONTAINER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PROJECTILE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROJECTILE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROJECTILE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PROJECTILE_ATTACHER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROJECTILE_ATTACHER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROJECTILE_ATTACHER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PROXIMITY_HEATING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROXIMITY_HEATING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROXIMITY_HEATING, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RAIN_AFFECTED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RAIN_AFFECTED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RAIN_AFFECTED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RAIN_COVER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RAIN_COVER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RAIN_COVER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RAIN_COVERABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RAIN_COVERABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RAIN_COVERABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RAIN_COVER_COLLIDER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RAIN_COVER_COLLIDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RAIN_COVER_COLLIDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string REPAIR_BENCH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REPAIR_BENCH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REPAIR_BENCH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string REPAIRER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REPAIRER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REPAIRER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RESOURCE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RESOURCE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RESOURCE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ROAD_SIGN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ROAD_SIGN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ROAD_SIGN, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ROAD_SIGN_DIRECTION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ROAD_SIGN_DIRECTION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ROAD_SIGN_DIRECTION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SELECTABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SELECTABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SELECTABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SHOWABLE_INTERACTION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHOWABLE_INTERACTION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHOWABLE_INTERACTION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SKILLS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILLS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILLS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SLEEPER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SLEEPER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SLEEPER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SLEEPABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SLEEPABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SLEEPABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SMOKE_RACK
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SMOKE_RACK, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SMOKE_RACK, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SNOW_COVER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SNOW_COVER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SNOW_COVER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SOAKER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SOAKER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SOAKER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SOUND_EMITTER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SOUND_EMITTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SOUND_EMITTER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STAMINA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STAMINA, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STAMINA, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STATUS_EFFECT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STATUS_EFFECT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STATUS_EFFECT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STORABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STORABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STORABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string STORABLE_EQUIPPER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STORABLE_EQUIPPER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STORABLE_EQUIPPER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SUN_BLOCKER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUN_BLOCKER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUN_BLOCKER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SURFACE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SURFACE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SURFACE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TANNING_FRAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TANNING_FRAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TANNING_FRAME, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TERRAIN_SHOWABLE_INTERACTION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TERRAIN_SHOWABLE_INTERACTION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TERRAIN_SHOWABLE_INTERACTION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string THIRST
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THIRST, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THIRST, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TOOLABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOOLABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOOLABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TOXIC_DAMAGE_TAKER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOXIC_DAMAGE_TAKER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOXIC_DAMAGE_TAKER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TOXIC_SMOKE_EMITTER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOXIC_SMOKE_EMITTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOXIC_SMOKE_EMITTER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TRADER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRADER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRADER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TRAP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRAP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRAP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string TRAPPABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRAPPABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRAPPABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WARMTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WARMTH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WARMTH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WATER_COLLIDER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WATER_COLLIDER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WATER_COLLIDER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WETNESS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WETNESS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WETNESS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WIND_AFFECTED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WIND_AFFECTED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WIND_AFFECTED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WHEELED_ENTITY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WHEELED_ENTITY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WHEELED_ENTITY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WORKBENCH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WORKBENCH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WORKBENCH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ComponentName()
	{
		Il2CppClassPointerStore<ComponentName>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ComponentName");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentName>.NativeClassPtr);
		NativeFieldInfoPtr_AI_CONTROLLED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "AI_CONTROLLED");
		NativeFieldInfoPtr_ANIMATED_MOVER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "ANIMATED_MOVER");
		NativeFieldInfoPtr_BOAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "BOAT");
		NativeFieldInfoPtr_BURNABLE_CONSTRUCTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "BURNABLE_CONSTRUCTION");
		NativeFieldInfoPtr_CHARACTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "CHARACTER");
		NativeFieldInfoPtr_COMPASS_NEEDLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "COMPASS_NEEDLE");
		NativeFieldInfoPtr_CONSTRUCTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "CONSTRUCTION");
		NativeFieldInfoPtr_CONTAINER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "CONTAINER");
		NativeFieldInfoPtr_COOKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "COOKER");
		NativeFieldInfoPtr_CRAFTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "CRAFTER");
		NativeFieldInfoPtr_CREATURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "CREATURE");
		NativeFieldInfoPtr_CREATURE_REPULSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "CREATURE_REPULSION");
		NativeFieldInfoPtr_CUSTOMIZABLE_SKINNED_RENDERER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "CUSTOMIZABLE_SKINNED_RENDERER");
		NativeFieldInfoPtr_DEAD_GROWABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DEAD_GROWABLE");
		NativeFieldInfoPtr_DECAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DECAL");
		NativeFieldInfoPtr_DECAYABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DECAYABLE");
		NativeFieldInfoPtr_DETAIL_DISPLACEMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DETAIL_DISPLACEMENT");
		NativeFieldInfoPtr_DIALOG_CONVERSER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DIALOG_CONVERSER");
		NativeFieldInfoPtr_DISEASE_CLOUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DISEASE_CLOUD");
		NativeFieldInfoPtr_DISEASE_EFFECT_EMITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DISEASE_EFFECT_EMITTER");
		NativeFieldInfoPtr_DISEASE_CLEARING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DISEASE_CLEARING");
		NativeFieldInfoPtr_DISEASED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DISEASED");
		NativeFieldInfoPtr_DISTILLER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DISTILLER");
		NativeFieldInfoPtr_DOOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "DOOR");
		NativeFieldInfoPtr_ENERGY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "ENERGY");
		NativeFieldInfoPtr_ENTITY_MOVEMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "ENTITY_MOVEMENT");
		NativeFieldInfoPtr_EQUIPPED_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "EQUIPPED_ITEM");
		NativeFieldInfoPtr_FUEL_BURNER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "FUEL_BURNER");
		NativeFieldInfoPtr_GATHERABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "GATHERABLE");
		NativeFieldInfoPtr_GENERATED_STRUCTURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "GENERATED_STRUCTURE");
		NativeFieldInfoPtr_GRABBABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "GRABBABLE");
		NativeFieldInfoPtr_GRABBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "GRABBER");
		NativeFieldInfoPtr_GROWABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "GROWABLE");
		NativeFieldInfoPtr_HARVESTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "HARVESTER");
		NativeFieldInfoPtr_HEATED_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "HEATED_ITEM");
		NativeFieldInfoPtr_HITPOINTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "HITPOINTS");
		NativeFieldInfoPtr_HOSTILITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "HOSTILITY");
		NativeFieldInfoPtr_HUMANOID_ATTACKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "HUMANOID_ATTACKER");
		NativeFieldInfoPtr_HUMANOID_EQUIPPER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "HUMANOID_EQUIPPER");
		NativeFieldInfoPtr_HUNGER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "HUNGER");
		NativeFieldInfoPtr_IGNITING_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "IGNITING_ITEM");
		NativeFieldInfoPtr_INDOOR_LEVEL_NAVIGATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "INDOOR_LEVEL_NAVIGATOR");
		NativeFieldInfoPtr_INDOOR_LEVEL_TRIGGER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "INDOOR_LEVEL_TRIGGER");
		NativeFieldInfoPtr_INJURY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "INJURY");
		NativeFieldInfoPtr_INTERACTABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "INTERACTABLE");
		NativeFieldInfoPtr_INTERACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "INTERACTOR");
		NativeFieldInfoPtr_INVENTORY_HOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "INVENTORY_HOLDER");
		NativeFieldInfoPtr_ITEM_CONTAINER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "ITEM_CONTAINER");
		NativeFieldInfoPtr_ITEM_FUELED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "ITEM_FUELED");
		NativeFieldInfoPtr_ITEM_STOCKPILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "ITEM_STOCKPILE");
		NativeFieldInfoPtr_KILN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "KILN");
		NativeFieldInfoPtr_LIGHT_EMITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "LIGHT_EMITTER");
		NativeFieldInfoPtr_LIVING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "LIVING");
		NativeFieldInfoPtr_LOOSE_SUBSTANCE_STOCKPILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "LOOSE_SUBSTANCE_STOCKPILE");
		NativeFieldInfoPtr_MAP_EXPLORER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "MAP_EXPLORER");
		NativeFieldInfoPtr_MINIMAP_REPRESENTATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "MINIMAP_REPRESENTATION");
		NativeFieldInfoPtr_MOLTEN_METAL_MOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "MOLTEN_METAL_MOLD");
		NativeFieldInfoPtr_NAVIGATION_MARKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "NAVIGATION_MARKER");
		NativeFieldInfoPtr_OBSCURABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "OBSCURABLE");
		NativeFieldInfoPtr_PARTICLE_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PARTICLE_EFFECT");
		NativeFieldInfoPtr_PHYSICS_OBJECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PHYSICS_OBJECT");
		NativeFieldInfoPtr_PICKUPABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PICKUPABLE");
		NativeFieldInfoPtr_PLACEABLE_SURFACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PLACEABLE_SURFACE");
		NativeFieldInfoPtr_PLACED_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PLACED_ITEM");
		NativeFieldInfoPtr_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PLAYER");
		NativeFieldInfoPtr_PLAYER_INPUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PLAYER_INPUT");
		NativeFieldInfoPtr_POOLED_INSTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "POOLED_INSTANCE");
		NativeFieldInfoPtr_PRESERVATION_CONTAINER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PRESERVATION_CONTAINER");
		NativeFieldInfoPtr_PROJECTILE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PROJECTILE");
		NativeFieldInfoPtr_PROJECTILE_ATTACHER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PROJECTILE_ATTACHER");
		NativeFieldInfoPtr_PROXIMITY_HEATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "PROXIMITY_HEATING");
		NativeFieldInfoPtr_RAIN_AFFECTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "RAIN_AFFECTED");
		NativeFieldInfoPtr_RAIN_COVER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "RAIN_COVER");
		NativeFieldInfoPtr_RAIN_COVERABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "RAIN_COVERABLE");
		NativeFieldInfoPtr_RAIN_COVER_COLLIDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "RAIN_COVER_COLLIDER");
		NativeFieldInfoPtr_REPAIR_BENCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "REPAIR_BENCH");
		NativeFieldInfoPtr_REPAIRER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "REPAIRER");
		NativeFieldInfoPtr_RESOURCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "RESOURCE");
		NativeFieldInfoPtr_ROAD_SIGN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "ROAD_SIGN");
		NativeFieldInfoPtr_ROAD_SIGN_DIRECTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "ROAD_SIGN_DIRECTION");
		NativeFieldInfoPtr_SELECTABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SELECTABLE");
		NativeFieldInfoPtr_SHOWABLE_INTERACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SHOWABLE_INTERACTION");
		NativeFieldInfoPtr_SKILLS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SKILLS");
		NativeFieldInfoPtr_SLEEPER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SLEEPER");
		NativeFieldInfoPtr_SLEEPABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SLEEPABLE");
		NativeFieldInfoPtr_SMOKE_RACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SMOKE_RACK");
		NativeFieldInfoPtr_SNOW_COVER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SNOW_COVER");
		NativeFieldInfoPtr_SOAKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SOAKER");
		NativeFieldInfoPtr_SOUND_EMITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SOUND_EMITTER");
		NativeFieldInfoPtr_STAMINA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "STAMINA");
		NativeFieldInfoPtr_STATUS_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "STATUS_EFFECT");
		NativeFieldInfoPtr_STORABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "STORABLE");
		NativeFieldInfoPtr_STORABLE_EQUIPPER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "STORABLE_EQUIPPER");
		NativeFieldInfoPtr_SUN_BLOCKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SUN_BLOCKER");
		NativeFieldInfoPtr_SURFACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "SURFACE");
		NativeFieldInfoPtr_TANNING_FRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "TANNING_FRAME");
		NativeFieldInfoPtr_TERRAIN_SHOWABLE_INTERACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "TERRAIN_SHOWABLE_INTERACTION");
		NativeFieldInfoPtr_THIRST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "THIRST");
		NativeFieldInfoPtr_TOOLABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "TOOLABLE");
		NativeFieldInfoPtr_TOXIC_DAMAGE_TAKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "TOXIC_DAMAGE_TAKER");
		NativeFieldInfoPtr_TOXIC_SMOKE_EMITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "TOXIC_SMOKE_EMITTER");
		NativeFieldInfoPtr_TRADER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "TRADER");
		NativeFieldInfoPtr_TRAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "TRAP");
		NativeFieldInfoPtr_TRAPPABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "TRAPPABLE");
		NativeFieldInfoPtr_WARMTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "WARMTH");
		NativeFieldInfoPtr_WATER_COLLIDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "WATER_COLLIDER");
		NativeFieldInfoPtr_WETNESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "WETNESS");
		NativeFieldInfoPtr_WIND_AFFECTED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "WIND_AFFECTED");
		NativeFieldInfoPtr_WHEELED_ENTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "WHEELED_ENTITY");
		NativeFieldInfoPtr_WORKBENCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, "WORKBENCH");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentName>.NativeClassPtr, 100669235);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComponentName()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentName>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ComponentName(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

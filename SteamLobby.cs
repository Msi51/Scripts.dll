using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks;
using UnityEngine.Events;

public class SteamLobby : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_steamId;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameName;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameDayNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_numPlayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPlayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_passwordProtected;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficulty;

	private static readonly System.IntPtr NativeFieldInfoPtr_realism;

	private static readonly System.IntPtr NativeFieldInfoPtr_offlineTimeSimulation;

	private static readonly System.IntPtr NativeFieldInfoPtr_onUpdated;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CSteamID steamId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamId);
			return *(CSteamID*)num;
		}
		set
		{
			*(CSteamID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamId)) = cSteamID;
		}
	}

	public unsafe string gameVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameVersion);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameVersion)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string gameName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int gameDayNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameDayNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameDayNum)) = num;
		}
	}

	public unsafe int numPlayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numPlayers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numPlayers)) = num;
		}
	}

	public unsafe int maxPlayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPlayers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPlayers)) = num;
		}
	}

	public unsafe bool passwordProtected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passwordProtected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passwordProtected)) = flag;
		}
	}

	public unsafe GameDifficulty difficulty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficulty);
			return *(GameDifficulty*)num;
		}
		set
		{
			*(GameDifficulty*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficulty)) = gameDifficulty;
		}
	}

	public unsafe GameRealism realism
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realism);
			return *(GameRealism*)num;
		}
		set
		{
			*(GameRealism*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realism)) = gameRealism;
		}
	}

	public unsafe OfflineTimeSimulation offlineTimeSimulation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offlineTimeSimulation);
			return *(OfflineTimeSimulation*)num;
		}
		set
		{
			*(OfflineTimeSimulation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offlineTimeSimulation)) = offlineTimeSimulation;
		}
	}

	public unsafe UnityEvent<SteamLobby> onUpdated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onUpdated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent<SteamLobby>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onUpdated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityEvent));
		}
	}

	static SteamLobby()
	{
		Il2CppClassPointerStore<SteamLobby>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SteamLobby");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr);
		NativeFieldInfoPtr_steamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "steamId");
		NativeFieldInfoPtr_gameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "gameVersion");
		NativeFieldInfoPtr_gameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "gameName");
		NativeFieldInfoPtr_gameDayNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "gameDayNum");
		NativeFieldInfoPtr_numPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "numPlayers");
		NativeFieldInfoPtr_maxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "maxPlayers");
		NativeFieldInfoPtr_passwordProtected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "passwordProtected");
		NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "difficulty");
		NativeFieldInfoPtr_realism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "realism");
		NativeFieldInfoPtr_offlineTimeSimulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "offlineTimeSimulation");
		NativeFieldInfoPtr_onUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, "onUpdated");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr, 100664256);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28554, RefRangeEnd = 28555, XrefRangeStart = 28545, XrefRangeEnd = 28554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SteamLobby()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamLobby>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SteamLobby(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public sealed class MultiplayerGameOptions : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_maxPlayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibility;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiplayerGameName;

	private static readonly System.IntPtr NativeFieldInfoPtr_password;

	private static readonly System.IntPtr NativeFieldInfoPtr_friendlyFire;

	private static readonly System.IntPtr NativeFieldInfoPtr_offlineTimeSimulation;

	private static readonly System.IntPtr NativeFieldInfoPtr_respawnType;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowRespawnPositionUpdate;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

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

	public unsafe MultiplayerGameVisibility visibility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibility);
			return *(MultiplayerGameVisibility*)num;
		}
		set
		{
			*(MultiplayerGameVisibility*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibility)) = multiplayerGameVisibility;
		}
	}

	public unsafe string multiplayerGameName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplayerGameName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiplayerGameName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string password
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_password);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_password)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool friendlyFire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_friendlyFire);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_friendlyFire)) = flag;
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

	public unsafe RespawnType respawnType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_respawnType);
			return *(RespawnType*)num;
		}
		set
		{
			*(RespawnType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_respawnType)) = respawnType;
		}
	}

	public unsafe bool allowRespawnPositionUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowRespawnPositionUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowRespawnPositionUpdate)) = flag;
		}
	}

	public unsafe bool IsValid
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18746, RefRangeEnd = 18747, XrefRangeStart = 18745, XrefRangeEnd = 18746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static MultiplayerGameOptions()
	{
		Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MultiplayerGameOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr);
		NativeFieldInfoPtr_maxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, "maxPlayers");
		NativeFieldInfoPtr_visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, "visibility");
		NativeFieldInfoPtr_multiplayerGameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, "multiplayerGameName");
		NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, "password");
		NativeFieldInfoPtr_friendlyFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, "friendlyFire");
		NativeFieldInfoPtr_offlineTimeSimulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, "offlineTimeSimulation");
		NativeFieldInfoPtr_respawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, "respawnType");
		NativeFieldInfoPtr_allowRespawnPositionUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, "allowRespawnPositionUpdate");
		NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr, 100663548);
	}

	public MultiplayerGameOptions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public MultiplayerGameOptions()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiplayerGameOptions>.NativeClassPtr))
	{
	}
}

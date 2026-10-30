using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Steamworks;

public class ConnectedClient : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_clientId;

	private static readonly System.IntPtr NativeFieldInfoPtr_clientTick;

	private static readonly System.IntPtr NativeFieldInfoPtr_clientTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_latencyTrackingStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_estimatedLatencyMs;

	private static readonly System.IntPtr NativeFieldInfoPtr_fragmentedMessagesPerTick;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastFragmentedMessageDecreaseTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastFragmentedMessageIncreaseTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_steamID;

	private static readonly System.IntPtr NativeFieldInfoPtr_steamNetworkingIdentity;

	private static readonly System.IntPtr NativeFieldInfoPtr_steamUser;

	private static readonly System.IntPtr NativeFieldInfoPtr_steamConnections;

	private static readonly System.IntPtr NativeFieldInfoPtr_world;

	private static readonly System.IntPtr NativeFieldInfoPtr_clientState;

	private static readonly System.IntPtr NativeFieldInfoPtr_player;

	private static readonly System.IntPtr NativeFieldInfoPtr_moderator;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkedEntityIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkedBuildingSectionIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_hostNetworkedInteractionIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_clientStartedInteractionIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeRequests;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkedChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_listeningEntityIds;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MinInteractionId_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxInteractionId_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SteamNetworkingIdentity_SteamUser_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllConnectionsPresent_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Username_Public_get_String_0;

	public unsafe int clientId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientId)) = num;
		}
	}

	public unsafe int clientTick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientTick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientTick)) = num;
		}
	}

	public unsafe float clientTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientTime)) = num;
		}
	}

	public unsafe float latencyTrackingStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_latencyTrackingStartTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_latencyTrackingStartTime)) = num;
		}
	}

	public unsafe float estimatedLatencyMs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_estimatedLatencyMs);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_estimatedLatencyMs)) = num;
		}
	}

	public unsafe int fragmentedMessagesPerTick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fragmentedMessagesPerTick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fragmentedMessagesPerTick)) = num;
		}
	}

	public unsafe float lastFragmentedMessageDecreaseTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFragmentedMessageDecreaseTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFragmentedMessageDecreaseTime)) = num;
		}
	}

	public unsafe float lastFragmentedMessageIncreaseTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFragmentedMessageIncreaseTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFragmentedMessageIncreaseTime)) = num;
		}
	}

	public unsafe CSteamID steamID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamID);
			return *(CSteamID*)num;
		}
		set
		{
			*(CSteamID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamID)) = cSteamID;
		}
	}

	public unsafe SteamNetworkingIdentity steamNetworkingIdentity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamNetworkingIdentity);
			return new SteamNetworkingIdentity(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamNetworkingIdentity), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)steamNetworkingIdentity)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe SteamUser steamUser
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamUser);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SteamUser>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamUser)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)steamUser));
		}
	}

	public unsafe Il2CppStructArray<HSteamNetConnection> steamConnections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamConnections);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<HSteamNetConnection>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamConnections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe World world
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
		}
	}

	public unsafe ClientState clientState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientState);
			return *(ClientState*)num;
		}
		set
		{
			*(ClientState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientState)) = clientState;
		}
	}

	public unsafe WorldPlayer player
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldPlayer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldPlayer));
		}
	}

	public unsafe bool moderator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moderator);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moderator)) = flag;
		}
	}

	public unsafe HashSet<int> networkedEntityIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkedEntityIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkedEntityIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<int> networkedBuildingSectionIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkedBuildingSectionIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkedBuildingSectionIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<uint> hostNetworkedInteractionIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostNetworkedInteractionIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostNetworkedInteractionIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<uint> clientStartedInteractionIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientStartedInteractionIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientStartedInteractionIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<int, IActiveRequest> activeRequests
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeRequests);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, IActiveRequest>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeRequests)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<Coordinates> networkedChunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkedChunkCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkedChunkCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<int> listeningEntityIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listeningEntityIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listeningEntityIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe uint MinInteractionId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24087, RefRangeEnd = 24088, XrefRangeStart = 24087, XrefRangeEnd = 24087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MinInteractionId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe uint MaxInteractionId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24088, RefRangeEnd = 24089, XrefRangeStart = 24088, XrefRangeEnd = 24088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxInteractionId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsActive
	{
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 24146, RefRangeEnd = 24179, XrefRangeStart = 24146, XrefRangeEnd = 24146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe string Username
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24180, RefRangeEnd = 24182, XrefRangeStart = 24179, XrefRangeEnd = 24180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Username_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static ConnectedClient()
	{
		Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ConnectedClient");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr);
		NativeFieldInfoPtr_clientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "clientId");
		NativeFieldInfoPtr_clientTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "clientTick");
		NativeFieldInfoPtr_clientTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "clientTime");
		NativeFieldInfoPtr_latencyTrackingStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "latencyTrackingStartTime");
		NativeFieldInfoPtr_estimatedLatencyMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "estimatedLatencyMs");
		NativeFieldInfoPtr_fragmentedMessagesPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "fragmentedMessagesPerTick");
		NativeFieldInfoPtr_lastFragmentedMessageDecreaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "lastFragmentedMessageDecreaseTime");
		NativeFieldInfoPtr_lastFragmentedMessageIncreaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "lastFragmentedMessageIncreaseTime");
		NativeFieldInfoPtr_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "steamID");
		NativeFieldInfoPtr_steamNetworkingIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "steamNetworkingIdentity");
		NativeFieldInfoPtr_steamUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "steamUser");
		NativeFieldInfoPtr_steamConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "steamConnections");
		NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "world");
		NativeFieldInfoPtr_clientState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "clientState");
		NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "player");
		NativeFieldInfoPtr_moderator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "moderator");
		NativeFieldInfoPtr_networkedEntityIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "networkedEntityIds");
		NativeFieldInfoPtr_networkedBuildingSectionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "networkedBuildingSectionIds");
		NativeFieldInfoPtr_hostNetworkedInteractionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "hostNetworkedInteractionIds");
		NativeFieldInfoPtr_clientStartedInteractionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "clientStartedInteractionIds");
		NativeFieldInfoPtr_activeRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "activeRequests");
		NativeFieldInfoPtr_networkedChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "networkedChunkCoordinates");
		NativeFieldInfoPtr_listeningEntityIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, "listeningEntityIds");
		NativeMethodInfoPtr_get_MinInteractionId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_get_MaxInteractionId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr__ctor_Public_Void_SteamNetworkingIdentity_SteamUser_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_AllConnectionsPresent_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_get_Username_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr, 100663845);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24089, XrefRangeEnd = 24140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConnectedClient(SteamNetworkingIdentity steamNetworkingIdentity, SteamUser steamUser, int clientId, int numConnections)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectedClient>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)steamNetworkingIdentity));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)steamUser);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &clientId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &numConnections;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SteamNetworkingIdentity_SteamUser_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24140, XrefRangeEnd = 24146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AllConnectionsPresent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllConnectionsPresent_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public ConnectedClient(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

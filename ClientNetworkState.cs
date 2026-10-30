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

public class ClientNetworkState : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_clientId;

	private static readonly System.IntPtr NativeFieldInfoPtr_timingUpdatedTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_hostTick;

	private static readonly System.IntPtr NativeFieldInfoPtr_hostTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_latencyTrackingStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_estimatedLatencyMs;

	private static readonly System.IntPtr NativeFieldInfoPtr_hostSteamNetworkingIdentity;

	private static readonly System.IntPtr NativeFieldInfoPtr_hostSteamId;

	private static readonly System.IntPtr NativeFieldInfoPtr_hostSteamConnections;

	private static readonly System.IntPtr NativeFieldInfoPtr_joinedLobbyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_numConnectionsEstablished;

	private static readonly System.IntPtr NativeFieldInfoPtr_connectionState;

	private static readonly System.IntPtr NativeFieldInfoPtr_connectionCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeRequests;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkedInteractionIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_gamePlayers;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEstimatedHostTime_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe float timingUpdatedTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timingUpdatedTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timingUpdatedTime)) = num;
		}
	}

	public unsafe int hostTick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostTick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostTick)) = num;
		}
	}

	public unsafe float hostTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostTime)) = num;
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

	public unsafe SteamNetworkingIdentity hostSteamNetworkingIdentity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostSteamNetworkingIdentity);
			return new SteamNetworkingIdentity(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostSteamNetworkingIdentity), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)steamNetworkingIdentity)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CSteamID hostSteamId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostSteamId);
			return *(CSteamID*)num;
		}
		set
		{
			*(CSteamID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostSteamId)) = cSteamID;
		}
	}

	public unsafe Il2CppStructArray<HSteamNetConnection> hostSteamConnections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostSteamConnections);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<HSteamNetConnection>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hostSteamConnections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe CSteamID joinedLobbyId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joinedLobbyId);
			return *(CSteamID*)num;
		}
		set
		{
			*(CSteamID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joinedLobbyId)) = cSteamID;
		}
	}

	public unsafe int numConnectionsEstablished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numConnectionsEstablished);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numConnectionsEstablished)) = num;
		}
	}

	public unsafe ConnectionState connectionState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectionState);
			return *(ConnectionState*)num;
		}
		set
		{
			*(ConnectionState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectionState)) = connectionState;
		}
	}

	public unsafe Il2CppSystem.Action<int> connectionCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectionCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectionCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
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

	public unsafe HashSet<uint> networkedInteractionIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkedInteractionIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkedInteractionIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<GamePlayer> gamePlayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamePlayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GamePlayer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamePlayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ClientNetworkState()
	{
		Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ClientNetworkState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr);
		NativeFieldInfoPtr_clientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "clientId");
		NativeFieldInfoPtr_timingUpdatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "timingUpdatedTime");
		NativeFieldInfoPtr_hostTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "hostTick");
		NativeFieldInfoPtr_hostTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "hostTime");
		NativeFieldInfoPtr_latencyTrackingStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "latencyTrackingStartTime");
		NativeFieldInfoPtr_estimatedLatencyMs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "estimatedLatencyMs");
		NativeFieldInfoPtr_hostSteamNetworkingIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "hostSteamNetworkingIdentity");
		NativeFieldInfoPtr_hostSteamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "hostSteamId");
		NativeFieldInfoPtr_hostSteamConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "hostSteamConnections");
		NativeFieldInfoPtr_joinedLobbyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "joinedLobbyId");
		NativeFieldInfoPtr_numConnectionsEstablished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "numConnectionsEstablished");
		NativeFieldInfoPtr_connectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "connectionState");
		NativeFieldInfoPtr_connectionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "connectionCallback");
		NativeFieldInfoPtr_activeRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "activeRequests");
		NativeFieldInfoPtr_networkedInteractionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "networkedInteractionIds");
		NativeFieldInfoPtr_gamePlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, "gamePlayers");
		NativeMethodInfoPtr_GetEstimatedHostTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, 100663784);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr, 100663785);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23710, XrefRangeEnd = 23711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetEstimatedHostTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEstimatedHostTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23734, RefRangeEnd = 23735, XrefRangeStart = 23711, XrefRangeEnd = 23734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClientNetworkState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientNetworkState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ClientNetworkState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

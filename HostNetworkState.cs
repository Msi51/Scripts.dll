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

public class HostNetworkState : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_connectedClients;

	private static readonly System.IntPtr NativeFieldInfoPtr_steamClientIdMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_listenSockets;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSteamLobbyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPlayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_gamePassword;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConnectedClientCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<int, ConnectedClient> connectedClients
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectedClients);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, ConnectedClient>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connectedClients)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<ulong, int> steamClientIdMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamClientIdMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ulong, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_steamClientIdMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Il2CppStructArray<HSteamListenSocket> listenSockets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listenSockets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<HSteamListenSocket>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listenSockets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe CSteamID currentSteamLobbyId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSteamLobbyId);
			return *(CSteamID*)num;
		}
		set
		{
			*(CSteamID*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSteamLobbyId)) = cSteamID;
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

	public unsafe string gamePassword
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamePassword);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamePassword)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static HostNetworkState()
	{
		Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HostNetworkState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr);
		NativeFieldInfoPtr_connectedClients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr, "connectedClients");
		NativeFieldInfoPtr_steamClientIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr, "steamClientIdMap");
		NativeFieldInfoPtr_listenSockets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr, "listenSockets");
		NativeFieldInfoPtr_currentSteamLobbyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr, "currentSteamLobbyId");
		NativeFieldInfoPtr_maxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr, "maxPlayers");
		NativeFieldInfoPtr_gamePassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr, "gamePassword");
		NativeMethodInfoPtr_GetConnectedClientCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr, 100663905);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr, 100663906);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 24938, RefRangeEnd = 24941, XrefRangeStart = 24915, XrefRangeEnd = 24938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetConnectedClientCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConnectedClientCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 24957, RefRangeEnd = 24958, XrefRangeStart = 24941, XrefRangeEnd = 24957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HostNetworkState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HostNetworkState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HostNetworkState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

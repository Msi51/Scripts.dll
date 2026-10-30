using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class IPersistenceManager : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetSettings_Public_Abstract_Virtual_New_GameSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSettings_Public_Abstract_Virtual_New_Void_GameSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPreferences_Public_Abstract_Virtual_New_Void_GamePreferences_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SavePreferences_Public_Abstract_Virtual_New_Void_GamePreferences_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MigrateDemoFiles_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSavedGameNames_Public_Abstract_Virtual_New_Void_GameSaveType_ICollection_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSavedGameInfos_Public_Abstract_Virtual_New_Void_GameSaveType_ICollection_1_GameInfoSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateSortedSlotNames_Public_Abstract_Virtual_New_Void_GameSaveType_String_ICollection_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateSortedSlotNamesNewerThan_Public_Abstract_Virtual_New_Void_GameSaveType_String_String_ICollection_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDateSortedSavedGameNames_Public_Abstract_Virtual_New_Void_GameSaveType_ICollection_1_ValueTuple_2_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSavedGames_Public_Abstract_Virtual_New_Boolean_GameSaveType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadGameInfoSave_Public_Abstract_Virtual_New_Boolean_GameSaveType_String_byref_GameInfoSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadGameSave_Public_Abstract_Virtual_New_Boolean_GameSaveType_String_String_byref_GameSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveGameInfo_Public_Abstract_Virtual_New_Int32_Game_GameInfoSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Int32_GameSave_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadWorld_Public_Abstract_Virtual_New_Boolean_Game_String_String_byref_WorldSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveWorlds_Public_Abstract_Virtual_New_Int32_String_List_1_WorldSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadChunk_Public_Abstract_Virtual_New_Boolean_World_String_Coordinates_byref_ChunkSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadChunkData_Public_Abstract_Virtual_New_Void_World_String_Coordinates_ChunkData_ChunkData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadChunkCaveData_Public_Abstract_Virtual_New_Void_World_String_Coordinates_CaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveChunk_Public_Abstract_Virtual_New_Int32_String_ChunkSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveBaseChunkData_Public_Abstract_Virtual_New_Int32_World_Coordinates_ChunkData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveChunkData_Public_Abstract_Virtual_New_Int32_World_String_Coordinates_ChunkData_ChunkData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSessionChunk_Public_Abstract_Virtual_New_Int32_ChunkSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSessionChunkData_Public_Abstract_Virtual_New_Int32_World_Coordinates_ChunkData_ChunkData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveBaseChunkCaveData_Public_Abstract_Virtual_New_Int32_World_Coordinates_CaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSessionChunkCaveData_Public_Abstract_Virtual_New_Int32_World_Coordinates_CaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveChunkEntities_Public_Abstract_Virtual_New_Int32_World_String_ChunkEntitiesSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSessionChunkEntities_Public_Abstract_Virtual_New_Int32_World_ChunkEntitiesSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteGame_Public_Abstract_Virtual_New_Void_GameSaveType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteSlot_Public_Abstract_Virtual_New_Void_GameSaveType_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadChunkEntities_Public_Abstract_Virtual_New_Boolean_World_String_Coordinates_byref_ChunkEntitiesSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeSession_Public_Abstract_Virtual_New_Int32_World_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSession_Public_Abstract_Virtual_New_Void_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DuplicateSave_Public_Abstract_Virtual_New_Int32_World_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOldestAutosaveSlotName_Public_Abstract_Virtual_New_String_Game_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableSettingsWrites_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSettingsWrites_Public_Abstract_Virtual_New_Void_0;

	static IPersistenceManager()
	{
		Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IPersistenceManager");
		NativeMethodInfoPtr_GetSettings_Public_Abstract_Virtual_New_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675660);
		NativeMethodInfoPtr_SaveSettings_Public_Abstract_Virtual_New_Void_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675661);
		NativeMethodInfoPtr_LoadPreferences_Public_Abstract_Virtual_New_Void_GamePreferences_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675662);
		NativeMethodInfoPtr_SavePreferences_Public_Abstract_Virtual_New_Void_GamePreferences_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675663);
		NativeMethodInfoPtr_MigrateDemoFiles_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675664);
		NativeMethodInfoPtr_GetSavedGameNames_Public_Abstract_Virtual_New_Void_GameSaveType_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675665);
		NativeMethodInfoPtr_GetSavedGameInfos_Public_Abstract_Virtual_New_Void_GameSaveType_ICollection_1_GameInfoSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675666);
		NativeMethodInfoPtr_GetDateSortedSlotNames_Public_Abstract_Virtual_New_Void_GameSaveType_String_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675667);
		NativeMethodInfoPtr_GetDateSortedSlotNamesNewerThan_Public_Abstract_Virtual_New_Void_GameSaveType_String_String_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675668);
		NativeMethodInfoPtr_GetDateSortedSavedGameNames_Public_Abstract_Virtual_New_Void_GameSaveType_ICollection_1_ValueTuple_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675669);
		NativeMethodInfoPtr_HasSavedGames_Public_Abstract_Virtual_New_Boolean_GameSaveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675670);
		NativeMethodInfoPtr_LoadGameInfoSave_Public_Abstract_Virtual_New_Boolean_GameSaveType_String_byref_GameInfoSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675671);
		NativeMethodInfoPtr_LoadGameSave_Public_Abstract_Virtual_New_Boolean_GameSaveType_String_String_byref_GameSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675672);
		NativeMethodInfoPtr_SaveGameInfo_Public_Abstract_Virtual_New_Int32_Game_GameInfoSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675673);
		NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Int32_GameSave_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675674);
		NativeMethodInfoPtr_LoadWorld_Public_Abstract_Virtual_New_Boolean_Game_String_String_byref_WorldSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675675);
		NativeMethodInfoPtr_SaveWorlds_Public_Abstract_Virtual_New_Int32_String_List_1_WorldSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675676);
		NativeMethodInfoPtr_LoadChunk_Public_Abstract_Virtual_New_Boolean_World_String_Coordinates_byref_ChunkSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675677);
		NativeMethodInfoPtr_LoadChunkData_Public_Abstract_Virtual_New_Void_World_String_Coordinates_ChunkData_ChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675678);
		NativeMethodInfoPtr_LoadChunkCaveData_Public_Abstract_Virtual_New_Void_World_String_Coordinates_CaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675679);
		NativeMethodInfoPtr_SaveChunk_Public_Abstract_Virtual_New_Int32_String_ChunkSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675680);
		NativeMethodInfoPtr_SaveBaseChunkData_Public_Abstract_Virtual_New_Int32_World_Coordinates_ChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675681);
		NativeMethodInfoPtr_SaveChunkData_Public_Abstract_Virtual_New_Int32_World_String_Coordinates_ChunkData_ChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675682);
		NativeMethodInfoPtr_SaveSessionChunk_Public_Abstract_Virtual_New_Int32_ChunkSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675683);
		NativeMethodInfoPtr_SaveSessionChunkData_Public_Abstract_Virtual_New_Int32_World_Coordinates_ChunkData_ChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675684);
		NativeMethodInfoPtr_SaveBaseChunkCaveData_Public_Abstract_Virtual_New_Int32_World_Coordinates_CaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675685);
		NativeMethodInfoPtr_SaveSessionChunkCaveData_Public_Abstract_Virtual_New_Int32_World_Coordinates_CaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675686);
		NativeMethodInfoPtr_SaveChunkEntities_Public_Abstract_Virtual_New_Int32_World_String_ChunkEntitiesSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675687);
		NativeMethodInfoPtr_SaveSessionChunkEntities_Public_Abstract_Virtual_New_Int32_World_ChunkEntitiesSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675688);
		NativeMethodInfoPtr_DeleteGame_Public_Abstract_Virtual_New_Void_GameSaveType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675689);
		NativeMethodInfoPtr_DeleteSlot_Public_Abstract_Virtual_New_Void_GameSaveType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675690);
		NativeMethodInfoPtr_LoadChunkEntities_Public_Abstract_Virtual_New_Boolean_World_String_Coordinates_byref_ChunkEntitiesSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675691);
		NativeMethodInfoPtr_FinalizeSession_Public_Abstract_Virtual_New_Int32_World_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675692);
		NativeMethodInfoPtr_ClearSession_Public_Abstract_Virtual_New_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675693);
		NativeMethodInfoPtr_DuplicateSave_Public_Abstract_Virtual_New_Int32_World_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675694);
		NativeMethodInfoPtr_GetOldestAutosaveSlotName_Public_Abstract_Virtual_New_String_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675695);
		NativeMethodInfoPtr_DisableSettingsWrites_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675696);
		NativeMethodInfoPtr_EnableSettingsWrites_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPersistenceManager>.NativeClassPtr, 100675697);
	}

	[CallerCount(0)]
	public unsafe virtual GameSettings GetSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSettings_Public_Abstract_Virtual_New_GameSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameSettings>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SaveSettings(GameSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveSettings_Public_Abstract_Virtual_New_Void_GameSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void LoadPreferences(GamePreferences preferences)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preferences);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadPreferences_Public_Abstract_Virtual_New_Void_GamePreferences_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SavePreferences(GamePreferences preferences)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preferences);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SavePreferences_Public_Abstract_Virtual_New_Void_GamePreferences_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void MigrateDemoFiles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MigrateDemoFiles_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetSavedGameNames(GameSaveType gameSaveType, ICollection<string> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&gameSaveType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSavedGameNames_Public_Abstract_Virtual_New_Void_GameSaveType_ICollection_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetSavedGameInfos(GameSaveType gameSaveType, ICollection<GameInfoSave> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&gameSaveType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSavedGameInfos_Public_Abstract_Virtual_New_Void_GameSaveType_ICollection_1_GameInfoSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetDateSortedSlotNames(GameSaveType gameSaveType, string gameName, ICollection<string> resultSlotNames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&gameSaveType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultSlotNames);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDateSortedSlotNames_Public_Abstract_Virtual_New_Void_GameSaveType_String_ICollection_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetDateSortedSlotNamesNewerThan(GameSaveType gameSaveType, string gameName, string newerThanSlotName, ICollection<string> resultSlotNames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&gameSaveType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newerThanSlotName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultSlotNames);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDateSortedSlotNamesNewerThan_Public_Abstract_Virtual_New_Void_GameSaveType_String_String_ICollection_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void GetDateSortedSavedGameNames(GameSaveType gameSaveType, ICollection<Il2CppSystem.ValueTuple<string, string>> resultSavedGames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&gameSaveType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultSavedGames);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetDateSortedSavedGameNames_Public_Abstract_Virtual_New_Void_GameSaveType_ICollection_1_ValueTuple_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool HasSavedGames(GameSaveType gameSaveType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gameSaveType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HasSavedGames_Public_Abstract_Virtual_New_Boolean_GameSaveType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool LoadGameInfoSave(GameSaveType gameSaveType, string gameName, out GameInfoSave gameInfoSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&gameSaveType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameName);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadGameInfoSave_Public_Abstract_Virtual_New_Boolean_GameSaveType_String_byref_GameInfoSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		gameInfoSave = ((num3 == 0) ? null : new GameInfoSave(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool LoadGameSave(GameSaveType gameSaveType, string gameName, string slotName, out GameSave gameSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&gameSaveType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadGameSave_Public_Abstract_Virtual_New_Boolean_GameSaveType_String_String_byref_GameSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		gameSave = ((num3 == 0) ? null : new GameSave(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveGameInfo(Game game, GameInfoSave gameInfoSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)game);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameInfoSave);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveGameInfo_Public_Abstract_Virtual_New_Int32_Game_GameInfoSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveGame(GameSave gameSave, string slotName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameSave);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveGame_Public_Abstract_Virtual_New_Int32_GameSave_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool LoadWorld(Game game, string slotName, string worldName, out WorldSave worldSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)game);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(worldName);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadWorld_Public_Abstract_Virtual_New_Boolean_Game_String_String_byref_WorldSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		worldSave = ((num3 == 0) ? null : new WorldSave(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveWorlds(string slotName, List<WorldSave> worldSaves)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldSaves);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveWorlds_Public_Abstract_Virtual_New_Int32_String_List_1_WorldSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool LoadChunk(World world, string slotName, Coordinates coordinates, out ChunkSave chunkSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadChunk_Public_Abstract_Virtual_New_Boolean_World_String_Coordinates_byref_ChunkSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		chunkSave = ((num3 == 0) ? null : new ChunkSave(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void LoadChunkData(World world, string slotName, Coordinates coordinates, ChunkData resultBaseChunkData, ChunkData resultChunkData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultBaseChunkData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultChunkData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadChunkData_Public_Abstract_Virtual_New_Void_World_String_Coordinates_ChunkData_ChunkData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void LoadChunkCaveData(World world, string slotName, Coordinates coordinates, CaveData resultCaveData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultCaveData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadChunkCaveData_Public_Abstract_Virtual_New_Void_World_String_Coordinates_CaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveChunk(string slotName, ChunkSave chunkSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkSave);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveChunk_Public_Abstract_Virtual_New_Int32_String_ChunkSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveBaseChunkData(World world, Coordinates coordinates, ChunkData baseChunkData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseChunkData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveBaseChunkData_Public_Abstract_Virtual_New_Int32_World_Coordinates_ChunkData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveChunkData(World world, string slotName, Coordinates coordinates, ChunkData chunkData, ChunkData baseChunkData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseChunkData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveChunkData_Public_Abstract_Virtual_New_Int32_World_String_Coordinates_ChunkData_ChunkData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveSessionChunk(ChunkSave chunkSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkSave);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveSessionChunk_Public_Abstract_Virtual_New_Int32_ChunkSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveSessionChunkData(World world, Coordinates coordinates, ChunkData chunkData, ChunkData baseChunkData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseChunkData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveSessionChunkData_Public_Abstract_Virtual_New_Int32_World_Coordinates_ChunkData_ChunkData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveBaseChunkCaveData(World world, Coordinates coordinates, CaveData caveData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveBaseChunkCaveData_Public_Abstract_Virtual_New_Int32_World_Coordinates_CaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveSessionChunkCaveData(World world, Coordinates coordinates, CaveData caveData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveSessionChunkCaveData_Public_Abstract_Virtual_New_Int32_World_Coordinates_CaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveChunkEntities(World world, string slotName, ChunkEntitiesSave chunkEntitiesSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkEntitiesSave);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveChunkEntities_Public_Abstract_Virtual_New_Int32_World_String_ChunkEntitiesSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int SaveSessionChunkEntities(World world, ChunkEntitiesSave chunkEntitiesSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkEntitiesSave);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveSessionChunkEntities_Public_Abstract_Virtual_New_Int32_World_ChunkEntitiesSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void DeleteGame(GameSaveType gameSaveType, string gameName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&gameSaveType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DeleteGame_Public_Abstract_Virtual_New_Void_GameSaveType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void DeleteSlot(GameSaveType gameSaveType, string gameName, string slotName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&gameSaveType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(gameName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DeleteSlot_Public_Abstract_Virtual_New_Void_GameSaveType_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool LoadChunkEntities(World world, string slotName, Coordinates coordinates, out ChunkEntitiesSave chunkEntitiesSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadChunkEntities_Public_Abstract_Virtual_New_Boolean_World_String_Coordinates_byref_ChunkEntitiesSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		chunkEntitiesSave = ((num3 == 0) ? null : new ChunkEntitiesSave(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int FinalizeSession(World world, string slotName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinalizeSession_Public_Abstract_Virtual_New_Int32_World_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void ClearSession(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClearSession_Public_Abstract_Virtual_New_Void_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual int DuplicateSave(World world, string fromSlotName, string toSlotName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fromSlotName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(toSlotName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DuplicateSave_Public_Abstract_Virtual_New_Int32_World_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual string GetOldestAutosaveSlotName(Game game)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)game);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetOldestAutosaveSlotName_Public_Abstract_Virtual_New_String_Game_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void DisableSettingsWrites()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DisableSettingsWrites_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void EnableSettingsWrites()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_EnableSettingsWrites_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IPersistenceManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

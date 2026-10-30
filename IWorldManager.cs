using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

public class IWorldManager : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomWorldGen_Public_Abstract_Virtual_New_Void_WorldGen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorlds_Public_Abstract_Virtual_New_List_1_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldPlayer_Public_Abstract_Virtual_New_WorldPlayer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldPlayer_Public_Abstract_Virtual_New_WorldPlayer_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkLoadingWorld_Public_Abstract_Virtual_New_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNetworkLoadingWorld_Public_Abstract_Virtual_New_Void_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateWorld_Public_Abstract_Virtual_New_Task_1_World_Game_Int32_TimeSpan_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadWorldFromSave_Public_Abstract_Virtual_New_Task_WorldSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadNetworkWorld_Public_Abstract_Virtual_New_Task_World_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSerializedEntity_Public_Abstract_Virtual_New_Entity_World_SerializedEntity_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateWorld_Public_Abstract_Virtual_New_Void_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveActiveChunks_Public_Abstract_Virtual_New_Task_1_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWorldSaves_Public_Abstract_Virtual_New_List_1_WorldSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadOrGenerateChunk_Public_Abstract_Virtual_New_Task_1_Chunk_World_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadOrGenerateChunk_Public_Abstract_Virtual_New_Task_1_Chunk_World_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadOrGenerateChunksInRadius_Public_Abstract_Virtual_New_Task_World_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAllWorlds_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleWaterLevelTerrainHeightChange_Public_Abstract_Virtual_New_Void_World_Chunk_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWorldActivatedListener_Public_Abstract_Virtual_New_Void_Action_1_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWorldUnloadingListener_Public_Abstract_Virtual_New_Void_Action_1_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWorldUpdateListener_Public_Abstract_Virtual_New_Void_Action_1_World_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChunkUpdateListener_Public_Abstract_Virtual_New_Void_Action_3_World_Chunk_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWorldNewDayListener_Public_Abstract_Virtual_New_Void_Action_1_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChunkActivatedListener_Public_Abstract_Virtual_New_Void_Action_2_World_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyEntity_Public_Abstract_Virtual_New_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyObject_Public_Abstract_Virtual_New_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TriggerWorldEvent_Public_Abstract_Virtual_New_Boolean_World_WorldEventType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWaterMaterialTemplate_Public_Abstract_Virtual_New_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObscurableWindMaterial_Public_Abstract_Virtual_New_Material_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObscurableWindMaterialInverse_Public_Abstract_Virtual_New_Material_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIndoorAmount_Public_Abstract_Virtual_New_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unload_Public_Abstract_Virtual_New_Void_0;

	static IWorldManager()
	{
		Il2CppClassPointerStore<IWorldManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "IWorldManager");
		NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676068);
		NativeMethodInfoPtr_SetCustomWorldGen_Public_Abstract_Virtual_New_Void_WorldGen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676069);
		NativeMethodInfoPtr_GetWorlds_Public_Abstract_Virtual_New_List_1_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676070);
		NativeMethodInfoPtr_GetWorldPlayer_Public_Abstract_Virtual_New_WorldPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676071);
		NativeMethodInfoPtr_GetWorldPlayer_Public_Abstract_Virtual_New_WorldPlayer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676072);
		NativeMethodInfoPtr_GetNetworkLoadingWorld_Public_Abstract_Virtual_New_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676073);
		NativeMethodInfoPtr_SetNetworkLoadingWorld_Public_Abstract_Virtual_New_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676074);
		NativeMethodInfoPtr_GenerateWorld_Public_Abstract_Virtual_New_Task_1_World_Game_Int32_TimeSpan_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676075);
		NativeMethodInfoPtr_LoadWorldFromSave_Public_Abstract_Virtual_New_Task_WorldSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676076);
		NativeMethodInfoPtr_LoadNetworkWorld_Public_Abstract_Virtual_New_Task_World_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676077);
		NativeMethodInfoPtr_LoadSerializedEntity_Public_Abstract_Virtual_New_Entity_World_SerializedEntity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676078);
		NativeMethodInfoPtr_ActivateWorld_Public_Abstract_Virtual_New_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676079);
		NativeMethodInfoPtr_SaveActiveChunks_Public_Abstract_Virtual_New_Task_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676080);
		NativeMethodInfoPtr_CreateWorldSaves_Public_Abstract_Virtual_New_List_1_WorldSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676081);
		NativeMethodInfoPtr_LoadOrGenerateChunk_Public_Abstract_Virtual_New_Task_1_Chunk_World_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676082);
		NativeMethodInfoPtr_LoadOrGenerateChunk_Public_Abstract_Virtual_New_Task_1_Chunk_World_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676083);
		NativeMethodInfoPtr_LoadOrGenerateChunksInRadius_Public_Abstract_Virtual_New_Task_World_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676084);
		NativeMethodInfoPtr_UnloadAllWorlds_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676085);
		NativeMethodInfoPtr_HandleWaterLevelTerrainHeightChange_Public_Abstract_Virtual_New_Void_World_Chunk_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676086);
		NativeMethodInfoPtr_AddWorldActivatedListener_Public_Abstract_Virtual_New_Void_Action_1_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676087);
		NativeMethodInfoPtr_AddWorldUnloadingListener_Public_Abstract_Virtual_New_Void_Action_1_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676088);
		NativeMethodInfoPtr_AddWorldUpdateListener_Public_Abstract_Virtual_New_Void_Action_1_World_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676089);
		NativeMethodInfoPtr_AddChunkUpdateListener_Public_Abstract_Virtual_New_Void_Action_3_World_Chunk_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676090);
		NativeMethodInfoPtr_AddWorldNewDayListener_Public_Abstract_Virtual_New_Void_Action_1_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676091);
		NativeMethodInfoPtr_AddChunkActivatedListener_Public_Abstract_Virtual_New_Void_Action_2_World_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676092);
		NativeMethodInfoPtr_DestroyEntity_Public_Abstract_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676093);
		NativeMethodInfoPtr_DestroyObject_Public_Abstract_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676094);
		NativeMethodInfoPtr_TriggerWorldEvent_Public_Abstract_Virtual_New_Boolean_World_WorldEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676095);
		NativeMethodInfoPtr_GetWaterMaterialTemplate_Public_Abstract_Virtual_New_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676096);
		NativeMethodInfoPtr_GetObscurableWindMaterial_Public_Abstract_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676097);
		NativeMethodInfoPtr_GetObscurableWindMaterialInverse_Public_Abstract_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676098);
		NativeMethodInfoPtr_GetIndoorAmount_Public_Abstract_Virtual_New_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676099);
		NativeMethodInfoPtr_Unload_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWorldManager>.NativeClassPtr, 100676100);
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerator Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SetCustomWorldGen(WorldGen worldGen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGen);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetCustomWorldGen_Public_Abstract_Virtual_New_Void_WorldGen_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual List<World> GetWorlds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWorlds_Public_Abstract_Virtual_New_List_1_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<World>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual WorldPlayer GetWorldPlayer(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWorldPlayer_Public_Abstract_Virtual_New_WorldPlayer_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldPlayer>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual WorldPlayer GetWorldPlayer(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWorldPlayer_Public_Abstract_Virtual_New_WorldPlayer_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldPlayer>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual World GetNetworkLoadingWorld()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetNetworkLoadingWorld_Public_Abstract_Virtual_New_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SetNetworkLoadingWorld(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetNetworkLoadingWorld_Public_Abstract_Virtual_New_Void_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Task<World> GenerateWorld(Game game, int startMonth, Il2CppSystem.TimeSpan startTime, int seed = 0, bool loadStartingArea = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)game);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startMonth;
		*(Il2CppSystem.TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startTime;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &seed;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &loadStartingArea;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GenerateWorld_Public_Abstract_Virtual_New_Task_1_World_Game_Int32_TimeSpan_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<World>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task LoadWorldFromSave(WorldSave worldSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldSave);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadWorldFromSave_Public_Abstract_Virtual_New_Task_WorldSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task LoadNetworkWorld(World world, Vector3 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadNetworkWorld_Public_Abstract_Virtual_New_Task_World_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity LoadSerializedEntity(World world, SerializedEntity serializedEntity, float worldDateTimeCatchupFactor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializedEntity));
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldDateTimeCatchupFactor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadSerializedEntity_Public_Abstract_Virtual_New_Entity_World_SerializedEntity_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void ActivateWorld(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ActivateWorld_Public_Abstract_Virtual_New_Void_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Task<int> SaveActiveChunks(string slotName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(slotName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveActiveChunks_Public_Abstract_Virtual_New_Task_1_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<int>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual List<WorldSave> CreateWorldSaves()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateWorldSaves_Public_Abstract_Virtual_New_List_1_WorldSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WorldSave>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task<Chunk> LoadOrGenerateChunk(World world, Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadOrGenerateChunk_Public_Abstract_Virtual_New_Task_1_Chunk_World_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<Chunk>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task<Chunk> LoadOrGenerateChunk(World world, Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadOrGenerateChunk_Public_Abstract_Virtual_New_Task_1_Chunk_World_Coordinates_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<Chunk>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Task LoadOrGenerateChunksInRadius(World world, Vector3 position, bool activateImmediately = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &activateImmediately;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadOrGenerateChunksInRadius_Public_Abstract_Virtual_New_Task_World_Vector3_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void UnloadAllWorlds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UnloadAllWorlds_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void HandleWaterLevelTerrainHeightChange(World world, Chunk chunk, Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_HandleWaterLevelTerrainHeightChange_Public_Abstract_Virtual_New_Void_World_Chunk_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddWorldActivatedListener(Il2CppSystem.Action<World> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddWorldActivatedListener_Public_Abstract_Virtual_New_Void_Action_1_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddWorldUnloadingListener(Il2CppSystem.Action<World> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddWorldUnloadingListener_Public_Abstract_Virtual_New_Void_Action_1_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddWorldUpdateListener(Il2CppSystem.Action<World> listener, float frequency)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frequency;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddWorldUpdateListener_Public_Abstract_Virtual_New_Void_Action_1_World_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddChunkUpdateListener(Il2CppSystem.Action<World, Chunk, float> callback, float frequency)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frequency;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddChunkUpdateListener_Public_Abstract_Virtual_New_Void_Action_3_World_Chunk_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddWorldNewDayListener(Il2CppSystem.Action<World> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddWorldNewDayListener_Public_Abstract_Virtual_New_Void_Action_1_World_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddChunkActivatedListener(Il2CppSystem.Action<World, Chunk> listener)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listener);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddChunkActivatedListener_Public_Abstract_Virtual_New_Void_Action_2_World_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void DestroyEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DestroyEntity_Public_Abstract_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void DestroyObject(GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_DestroyObject_Public_Abstract_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool TriggerWorldEvent(World world, WorldEventType worldEventType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(WorldEventType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldEventType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_TriggerWorldEvent_Public_Abstract_Virtual_New_Boolean_World_WorldEventType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Material GetWaterMaterialTemplate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetWaterMaterialTemplate_Public_Abstract_Virtual_New_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Material GetObscurableWindMaterial(Material regularMaterial)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regularMaterial);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetObscurableWindMaterial_Public_Abstract_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Material GetObscurableWindMaterialInverse(Material obscurableMaterial)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obscurableMaterial);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetObscurableWindMaterialInverse_Public_Abstract_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual float GetIndoorAmount(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetIndoorAmount_Public_Abstract_Virtual_New_Single_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Unload()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Unload_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IWorldManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

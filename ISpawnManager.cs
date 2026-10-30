using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class ISpawnManager : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTerrainPool_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPool_Public_Abstract_Virtual_New_Void_String_PrefabInstantiationData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterPools_Public_Abstract_Virtual_New_Void_String_Dictionary_2_PrefabVariantType_PrefabInstantiationData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrototype_Public_Abstract_Virtual_New_GameObject_String_PrefabVariantType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreallocateObject_Public_Abstract_Virtual_New_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreallocateTerrain_Public_Abstract_Virtual_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSerializationContext_Public_Abstract_Virtual_New_SerializationContext_String_PrefabVariantType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnSerializationContext_Public_Abstract_Virtual_New_Void_String_PrefabVariantType_SerializationContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_PrefabVariantType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnSimpleActiveObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnAdvancedObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_Quaternion_PrefabVariantType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchEntityPrefabVariant_Public_Abstract_Virtual_New_Entity_Entity_PrefabVariantType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceEntity_Public_Abstract_Virtual_New_Entity_Entity_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnLoadedEntity_Public_Abstract_Virtual_New_Entity_Int32_String_Vector3_Quaternion_PrefabVariantType_Int32_Dictionary_2_Int32_Object_DateTime_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnNewEntity_Public_Abstract_Virtual_New_Entity_String_Vector3_Quaternion_PrefabVariantType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnStructure_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnEntityInWorld_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_PrefabVariantType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnEntityInWorld_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnActiveEntityInWorld_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_PrefabVariantType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnNetworkEntity_Public_Abstract_Virtual_New_Entity_Int32_String_Vector3_Quaternion_PrefabVariantType_Int32_Int32_SerializationContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnPickupableItem_Public_Abstract_Virtual_New_Entity_World_Vector3_Quaternion_InventoryItemStack_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnPickupableItems_Public_Abstract_Virtual_New_Void_World_Vector3_Quaternion_InventoryItemStack_Int32_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnPickupableItems_Public_Abstract_Virtual_New_Void_World_Vector3_Quaternion_InventoryItem_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnProjectile_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_InventoryItemStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnEquippedItem_Public_Abstract_Virtual_New_GameObject_String_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnTerrainObject_Public_Abstract_Virtual_New_GameObject_Vector3_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnWaterObject_Public_Abstract_Virtual_New_Entity_String_Vector3_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnCaveChunkObject_Public_Abstract_Virtual_New_GameObject_Vector3_Quaternion_Chunk_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnCaveWaterObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_Quaternion_Chunk_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitComponents_Public_Abstract_Virtual_New_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentNames_Public_Abstract_Virtual_New_ICollection_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unload_Public_Abstract_Virtual_New_Void_0;

	static ISpawnManager()
	{
		Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ISpawnManager");
		NativeMethodInfoPtr_RegisterTerrainPool_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675862);
		NativeMethodInfoPtr_RegisterPool_Public_Abstract_Virtual_New_Void_String_PrefabInstantiationData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675863);
		NativeMethodInfoPtr_RegisterPools_Public_Abstract_Virtual_New_Void_String_Dictionary_2_PrefabVariantType_PrefabInstantiationData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675864);
		NativeMethodInfoPtr_GetPrototype_Public_Abstract_Virtual_New_GameObject_String_PrefabVariantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675865);
		NativeMethodInfoPtr_PreallocateObject_Public_Abstract_Virtual_New_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675866);
		NativeMethodInfoPtr_PreallocateTerrain_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675867);
		NativeMethodInfoPtr_GetSerializationContext_Public_Abstract_Virtual_New_SerializationContext_String_PrefabVariantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675868);
		NativeMethodInfoPtr_ReturnSerializationContext_Public_Abstract_Virtual_New_Void_String_PrefabVariantType_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675869);
		NativeMethodInfoPtr_SpawnObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_PrefabVariantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675870);
		NativeMethodInfoPtr_SpawnSimpleActiveObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675871);
		NativeMethodInfoPtr_SpawnAdvancedObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_Quaternion_PrefabVariantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675872);
		NativeMethodInfoPtr_SwitchEntityPrefabVariant_Public_Abstract_Virtual_New_Entity_Entity_PrefabVariantType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675873);
		NativeMethodInfoPtr_ReplaceEntity_Public_Abstract_Virtual_New_Entity_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675874);
		NativeMethodInfoPtr_SpawnLoadedEntity_Public_Abstract_Virtual_New_Entity_Int32_String_Vector3_Quaternion_PrefabVariantType_Int32_Dictionary_2_Int32_Object_DateTime_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675875);
		NativeMethodInfoPtr_SpawnNewEntity_Public_Abstract_Virtual_New_Entity_String_Vector3_Quaternion_PrefabVariantType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675876);
		NativeMethodInfoPtr_SpawnStructure_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675877);
		NativeMethodInfoPtr_SpawnEntityInWorld_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_PrefabVariantType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675878);
		NativeMethodInfoPtr_SpawnEntityInWorld_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675879);
		NativeMethodInfoPtr_SpawnActiveEntityInWorld_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_PrefabVariantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675880);
		NativeMethodInfoPtr_SpawnNetworkEntity_Public_Abstract_Virtual_New_Entity_Int32_String_Vector3_Quaternion_PrefabVariantType_Int32_Int32_SerializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675881);
		NativeMethodInfoPtr_SpawnPickupableItem_Public_Abstract_Virtual_New_Entity_World_Vector3_Quaternion_InventoryItemStack_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675882);
		NativeMethodInfoPtr_SpawnPickupableItems_Public_Abstract_Virtual_New_Void_World_Vector3_Quaternion_InventoryItemStack_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675883);
		NativeMethodInfoPtr_SpawnPickupableItems_Public_Abstract_Virtual_New_Void_World_Vector3_Quaternion_InventoryItem_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675884);
		NativeMethodInfoPtr_SpawnProjectile_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_InventoryItemStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675885);
		NativeMethodInfoPtr_SpawnEquippedItem_Public_Abstract_Virtual_New_GameObject_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675886);
		NativeMethodInfoPtr_SpawnTerrainObject_Public_Abstract_Virtual_New_GameObject_Vector3_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675887);
		NativeMethodInfoPtr_SpawnWaterObject_Public_Abstract_Virtual_New_Entity_String_Vector3_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675888);
		NativeMethodInfoPtr_SpawnCaveChunkObject_Public_Abstract_Virtual_New_GameObject_Vector3_Quaternion_Chunk_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675889);
		NativeMethodInfoPtr_SpawnCaveWaterObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_Quaternion_Chunk_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675890);
		NativeMethodInfoPtr_InitComponents_Public_Abstract_Virtual_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675891);
		NativeMethodInfoPtr_GetComponentNames_Public_Abstract_Virtual_New_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675892);
		NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675893);
		NativeMethodInfoPtr_Unload_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpawnManager>.NativeClassPtr, 100675894);
	}

	[CallerCount(0)]
	public unsafe virtual void RegisterTerrainPool(int layer, int heightmapResolution, int alphamapResolution, int alphamapLayers, Vector3 terrainSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&layer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapResolution;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &alphamapResolution;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &alphamapLayers;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RegisterTerrainPool_Public_Abstract_Virtual_New_Void_Int32_Int32_Int32_Int32_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RegisterPool(string identifier, PrefabInstantiationData prefabData, int layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)prefabData));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RegisterPool_Public_Abstract_Virtual_New_Void_String_PrefabInstantiationData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void RegisterPools(string identifier, Dictionary<PrefabVariantType, PrefabInstantiationData> prefabDataMap, int layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefabDataMap);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RegisterPools_Public_Abstract_Virtual_New_Void_String_Dictionary_2_PrefabVariantType_PrefabInstantiationData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual GameObject GetPrototype(string identifier, PrefabVariantType prefabVariant = PrefabVariantType.DEFAULT)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariant;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPrototype_Public_Abstract_Virtual_New_GameObject_String_PrefabVariantType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void PreallocateObject(string identifier, int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PreallocateObject_Public_Abstract_Virtual_New_Void_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void PreallocateTerrain(int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&amount);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PreallocateTerrain_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual SerializationContext GetSerializationContext(string identifier, PrefabVariantType prefabVariantType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariantType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetSerializationContext_Public_Abstract_Virtual_New_SerializationContext_String_PrefabVariantType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializationContext>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void ReturnSerializationContext(string identifier, PrefabVariantType prefabVariantType, SerializationContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariantType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReturnSerializationContext_Public_Abstract_Virtual_New_Void_String_PrefabVariantType_SerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual GameObject SpawnObject(string identifier, Vector3 position, PrefabVariantType prefabVariant = PrefabVariantType.DEFAULT)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariant;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_PrefabVariantType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameObject SpawnSimpleActiveObject(string identifier, Vector3 position, Quaternion rotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnSimpleActiveObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameObject SpawnAdvancedObject(string identifier, Vector3 position, Quaternion rotation, PrefabVariantType prefabVariantType = PrefabVariantType.DEFAULT)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariantType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnAdvancedObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_Quaternion_PrefabVariantType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity SwitchEntityPrefabVariant(Entity oldEntity, PrefabVariantType newVariantType, int overrideEntityId = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)oldEntity);
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newVariantType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &overrideEntityId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SwitchEntityPrefabVariant_Public_Abstract_Virtual_New_Entity_Entity_PrefabVariantType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity ReplaceEntity(Entity oldEntity, string newIdentifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)oldEntity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newIdentifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReplaceEntity_Public_Abstract_Virtual_New_Entity_Entity_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity SpawnLoadedEntity(int entityId, string identifier, Vector3 position, Quaternion rotation, PrefabVariantType prefabVariantType, int level, Dictionary<int, Il2CppSystem.Object> fieldValues, Il2CppSystem.DateTime lastActiveDateTime, float worldDateTimeCatchupFactor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&entityId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariantType;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fieldValues);
		*(Il2CppSystem.DateTime**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastActiveDateTime;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldDateTimeCatchupFactor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnLoadedEntity_Public_Abstract_Virtual_New_Entity_Int32_String_Vector3_Quaternion_PrefabVariantType_Int32_Dictionary_2_Int32_Object_DateTime_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity SpawnNewEntity(string identifier, Vector3 position, Quaternion rotation, PrefabVariantType prefabVariantType = PrefabVariantType.DEFAULT, int level = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariantType;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnNewEntity_Public_Abstract_Virtual_New_Entity_String_Vector3_Quaternion_PrefabVariantType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity SpawnStructure(World world, Chunk chunk, Vector3 position, Quaternion rotation, string identifier, int level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnStructure_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity SpawnEntityInWorld(World world, Chunk chunk, Vector3 position, Quaternion rotation, string identifier, PrefabVariantType prefabVariant, int level = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariant;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnEntityInWorld_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_PrefabVariantType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity SpawnEntityInWorld(World world, Chunk chunk, Vector3 position, Quaternion rotation, string identifier, int level = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnEntityInWorld_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity SpawnActiveEntityInWorld(World world, Chunk chunk, Vector3 position, Quaternion rotation, string identifier, PrefabVariantType prefabVariant = PrefabVariantType.DEFAULT)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariant;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnActiveEntityInWorld_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_String_PrefabVariantType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity SpawnNetworkEntity(int entityId, string identifier, Vector3 position, Quaternion rotation, PrefabVariantType prefabVariantType, int level, int ownerClientId, SerializationContext serializationContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&entityId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(PrefabVariantType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &prefabVariantType;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &ownerClientId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializationContext);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnNetworkEntity_Public_Abstract_Virtual_New_Entity_Int32_String_Vector3_Quaternion_PrefabVariantType_Int32_Int32_SerializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity SpawnPickupableItem(World world, Vector3 position, Quaternion rotation, InventoryItemStack inventoryItemStack, int level = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryItemStack);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnPickupableItem_Public_Abstract_Virtual_New_Entity_World_Vector3_Quaternion_InventoryItemStack_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void SpawnPickupableItems(World world, Vector3 position, Quaternion baseRotation, InventoryItemStack stack, int level = 0, List<int> spawnedEntityIds = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseRotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnedEntityIds);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnPickupableItems_Public_Abstract_Virtual_New_Void_World_Vector3_Quaternion_InventoryItemStack_Int32_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SpawnPickupableItems(World world, Vector3 position, Quaternion baseRotation, InventoryItem item, int amount, int level = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseRotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnPickupableItems_Public_Abstract_Virtual_New_Void_World_Vector3_Quaternion_InventoryItem_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual Entity SpawnProjectile(World world, Chunk chunk, Vector3 position, Quaternion rotation, InventoryItemStack item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnProjectile_Public_Abstract_Virtual_New_Entity_World_Chunk_Vector3_Quaternion_InventoryItemStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameObject SpawnEquippedItem(string identifier, Transform transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnEquippedItem_Public_Abstract_Virtual_New_GameObject_String_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameObject SpawnTerrainObject(Vector3 position, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnTerrainObject_Public_Abstract_Virtual_New_GameObject_Vector3_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Entity SpawnWaterObject(string identifier, Vector3 position, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnWaterObject_Public_Abstract_Virtual_New_Entity_String_Vector3_Chunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameObject SpawnCaveChunkObject(Vector3 position, Quaternion rotation, Chunk chunk, Coordinates caveChunkCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&position);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Coordinates**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &caveChunkCoordinates;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnCaveChunkObject_Public_Abstract_Virtual_New_GameObject_Vector3_Quaternion_Chunk_Coordinates_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual GameObject SpawnCaveWaterObject(string identifier, Vector3 position, Quaternion rotation, Chunk chunk, Coordinates caveChunkCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Coordinates**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &caveChunkCoordinates;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SpawnCaveWaterObject_Public_Abstract_Virtual_New_GameObject_String_Vector3_Quaternion_Chunk_Coordinates_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void InitComponents(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitComponents_Public_Abstract_Virtual_New_Void_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual ICollection<string> GetComponentNames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetComponentNames_Public_Abstract_Virtual_New_ICollection_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
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

	public ISpawnManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

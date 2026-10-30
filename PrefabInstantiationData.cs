using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class PrefabInstantiationData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_prefabFilename;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_convertHitBoxLayerToDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearColliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearTriggerColliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearRigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_setKinematic;

	private static readonly System.IntPtr NativeFieldInfoPtr_addNavMeshObstacle;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveRootCapsuleCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_navMeshObstacleRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_layer;

	private static readonly System.IntPtr NativeFieldInfoPtr_removeObjects;

	public unsafe string prefabFilename
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabFilename);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabFilename)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ICollection<string> componentNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collection));
		}
	}

	public unsafe bool convertHitBoxLayerToDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convertHitBoxLayerToDefault);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convertHitBoxLayerToDefault)) = flag;
		}
	}

	public unsafe bool clearColliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearColliders);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearColliders)) = flag;
		}
	}

	public unsafe bool clearTriggerColliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearTriggerColliders);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearTriggerColliders)) = flag;
		}
	}

	public unsafe bool clearRigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearRigidbody);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearRigidbody)) = flag;
		}
	}

	public unsafe bool setKinematic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setKinematic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setKinematic)) = flag;
		}
	}

	public unsafe bool addNavMeshObstacle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addNavMeshObstacle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addNavMeshObstacle)) = flag;
		}
	}

	public unsafe bool moveRootCapsuleCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveRootCapsuleCollider);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveRootCapsuleCollider)) = flag;
		}
	}

	public unsafe float navMeshObstacleRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshObstacleRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshObstacleRadius)) = num;
		}
	}

	public unsafe float scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale)) = num;
		}
	}

	public unsafe int layer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layer)) = num;
		}
	}

	public unsafe ICollection<string> removeObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collection));
		}
	}

	static PrefabInstantiationData()
	{
		Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PrefabInstantiationData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr);
		NativeFieldInfoPtr_prefabFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "prefabFilename");
		NativeFieldInfoPtr_componentNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "componentNames");
		NativeFieldInfoPtr_convertHitBoxLayerToDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "convertHitBoxLayerToDefault");
		NativeFieldInfoPtr_clearColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "clearColliders");
		NativeFieldInfoPtr_clearTriggerColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "clearTriggerColliders");
		NativeFieldInfoPtr_clearRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "clearRigidbody");
		NativeFieldInfoPtr_setKinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "setKinematic");
		NativeFieldInfoPtr_addNavMeshObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "addNavMeshObstacle");
		NativeFieldInfoPtr_moveRootCapsuleCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "moveRootCapsuleCollider");
		NativeFieldInfoPtr_navMeshObstacleRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "navMeshObstacleRadius");
		NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "scale");
		NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "layer");
		NativeFieldInfoPtr_removeObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr, "removeObjects");
	}

	public PrefabInstantiationData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PrefabInstantiationData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabInstantiationData>.NativeClassPtr))
	{
	}
}

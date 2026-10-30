using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Unity.Collections;
using UnityEngine;

public sealed class CustomTerrainGameObjectPool : BasePool<GameObject>
{
	private static readonly IntPtr NativeFieldInfoPtr_alphamapResolution;

	private static readonly IntPtr NativeFieldInfoPtr_alphamapLayers;

	private static readonly IntPtr NativeFieldInfoPtr_terrainSize;

	private static readonly IntPtr NativeFieldInfoPtr_vertices;

	private static readonly IntPtr NativeFieldInfoPtr_defaultTriangles;

	private static readonly IntPtr NativeFieldInfoPtr_defaultUVs;

	private static readonly IntPtr NativeFieldInfoPtr_quadTreeMeshCache;

	private static readonly IntPtr NativeFieldInfoPtr_prototypeObject;

	private static readonly IntPtr NativeFieldInfoPtr_maxLodLevel;

	private static readonly IntPtr NativeFieldInfoPtr_quadsPerEdge;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Int32_Int32_Int32_Int32_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_buildTree_Private_QuadTreeNode_QuadTreeNode_Int32_Vector3_Single_Single_Int32_Il2CppStructArray_1_Vector3_GameObject_Material_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_onRelease_Private_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_onDestroy_Private_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPrototypeObject_Public_Virtual_Final_New_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

	public unsafe int alphamapResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamapResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamapResolution)) = num;
		}
	}

	public unsafe int alphamapLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamapLayers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alphamapLayers)) = num;
		}
	}

	public unsafe Vector3 terrainSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainSize)) = vector;
		}
	}

	public unsafe Il2CppStructArray<Vector3> vertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertices);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe NativeArray<int> defaultTriangles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultTriangles);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultTriangles), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Vector2> defaultUVs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultUVs);
			return new NativeArray<Vector2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector2>>.NativeClassPtr, (IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultUVs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeArray)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector2>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe QuadTreeMeshCache quadTreeMeshCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quadTreeMeshCache);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<QuadTreeMeshCache>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quadTreeMeshCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)quadTreeMeshCache));
		}
	}

	public unsafe GameObject prototypeObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prototypeObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prototypeObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe int maxLodLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLodLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLodLevel)) = num;
		}
	}

	public unsafe int quadsPerEdge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quadsPerEdge);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quadsPerEdge)) = num;
		}
	}

	static CustomTerrainGameObjectPool()
	{
		Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CustomTerrainGameObjectPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr);
		NativeFieldInfoPtr_alphamapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, "alphamapResolution");
		NativeFieldInfoPtr_alphamapLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, "alphamapLayers");
		NativeFieldInfoPtr_terrainSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, "terrainSize");
		NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, "vertices");
		NativeFieldInfoPtr_defaultTriangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, "defaultTriangles");
		NativeFieldInfoPtr_defaultUVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, "defaultUVs");
		NativeFieldInfoPtr_quadTreeMeshCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, "quadTreeMeshCache");
		NativeFieldInfoPtr_prototypeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, "prototypeObject");
		NativeFieldInfoPtr_maxLodLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, "maxLodLevel");
		NativeFieldInfoPtr_quadsPerEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, "quadsPerEdge");
		NativeMethodInfoPtr__ctor_Public_Void_GameObject_Int32_Int32_Int32_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, 100664463);
		NativeMethodInfoPtr_onCreate_Private_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, 100664464);
		NativeMethodInfoPtr_buildTree_Private_QuadTreeNode_QuadTreeNode_Int32_Vector3_Single_Single_Int32_Il2CppStructArray_1_Vector3_GameObject_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, 100664465);
		NativeMethodInfoPtr_onRelease_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, 100664466);
		NativeMethodInfoPtr_onDestroy_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, 100664467);
		NativeMethodInfoPtr_GetPrototypeObject_Public_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, 100664468);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr, 100664469);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30666, RefRangeEnd = 30668, XrefRangeStart = 30597, XrefRangeEnd = 30666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CustomTerrainGameObjectPool(GameObject prefabObject, int layer, int heightmapResolution, int alphamapResolution, int alphamapLayers, Vector3 terrainSize)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomTerrainGameObjectPool>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prefabObject);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &layer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &heightmapResolution;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &alphamapResolution;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &alphamapLayers;
		*(Vector3**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &terrainSize;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_Int32_Int32_Int32_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30668, XrefRangeEnd = 30763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 30784, RefRangeEnd = 30789, XrefRangeStart = 30763, XrefRangeEnd = 30784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe QuadTreeNode buildTree(QuadTreeNode parent, int childIndex, Vector3 center, float size, float fullSize, int level, Il2CppStructArray<Vector3> vertices, GameObject parentObject, Material material, int maxLodLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &childIndex;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &center;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &size;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &fullSize;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &level;
		*(IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentObject);
		*(IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(IntPtr)))) = &maxLodLevel;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buildTree_Private_QuadTreeNode_QuadTreeNode_Int32_Vector3_Single_Single_Int32_Il2CppStructArray_1_Vector3_GameObject_Material_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<QuadTreeNode>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30789, XrefRangeEnd = 30810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onRelease(GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onRelease_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30810, XrefRangeEnd = 30821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onDestroy(GameObject gameObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onDestroy_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 30821, RefRangeEnd = 30837, XrefRangeStart = 30821, XrefRangeEnd = 30821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual GameObject GetPrototypeObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrototypeObject_Public_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30837, XrefRangeEnd = 30848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CustomTerrainGameObjectPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

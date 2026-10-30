using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public static class MeshUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_meshDataMap;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineMeshes_Public_Static_Void_Mesh_List_1_CombineInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeReadableMeshCopy_Public_Static_Mesh_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateExactBounds_Public_Static_Bounds_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_calculateBounds_Private_Static_Void_Component_Mesh_byref_Vector3_byref_Vector3_0;

	public unsafe static Dictionary<Mesh, MeshData> meshDataMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_meshDataMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Mesh, MeshData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_meshDataMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static MeshUtil()
	{
		Il2CppClassPointerStore<MeshUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "MeshUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUtil>.NativeClassPtr);
		NativeFieldInfoPtr_meshDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtil>.NativeClassPtr, "meshDataMap");
		NativeMethodInfoPtr_CombineMeshes_Public_Static_Void_Mesh_List_1_CombineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtil>.NativeClassPtr, 100667841);
		NativeMethodInfoPtr_MakeReadableMeshCopy_Public_Static_Mesh_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtil>.NativeClassPtr, 100667842);
		NativeMethodInfoPtr_CalculateExactBounds_Public_Static_Bounds_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtil>.NativeClassPtr, 100667843);
		NativeMethodInfoPtr_calculateBounds_Private_Static_Void_Component_Mesh_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtil>.NativeClassPtr, 100667844);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83192, XrefRangeEnd = 83294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CombineMeshes(Mesh combinedMesh, List<CombineInstance> combines)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)combinedMesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)combines);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineMeshes_Public_Static_Void_Mesh_List_1_CombineInstance_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83336, RefRangeEnd = 83337, XrefRangeStart = 83294, XrefRangeEnd = 83336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mesh MakeReadableMeshCopy(Mesh nonReadableMesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nonReadableMesh);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeReadableMeshCopy_Public_Static_Mesh_Mesh_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 83413, RefRangeEnd = 83415, XrefRangeStart = 83337, XrefRangeEnd = 83413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateExactBounds(GameObject gameObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateExactBounds_Public_Static_Bounds_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 83457, RefRangeEnd = 83459, XrefRangeStart = 83415, XrefRangeEnd = 83457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void calculateBounds(Component component, Mesh mesh, ref Vector3 min, ref Vector3 max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref min);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref max);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calculateBounds_Private_Static_Void_Component_Mesh_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MeshUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

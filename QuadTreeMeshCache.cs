using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

public class QuadTreeMeshCache : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cache;

	private static readonly System.IntPtr NativeFieldInfoPtr_quadsPerEdge;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateTriangles_Public_NativeArray_1_Int32_TerrainDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	public unsafe Dictionary<TerrainDirection, NativeArray<int>> cache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<TerrainDirection, NativeArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
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

	static QuadTreeMeshCache()
	{
		Il2CppClassPointerStore<QuadTreeMeshCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "QuadTreeMeshCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuadTreeMeshCache>.NativeClassPtr);
		NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadTreeMeshCache>.NativeClassPtr, "cache");
		NativeFieldInfoPtr_quadsPerEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuadTreeMeshCache>.NativeClassPtr, "quadsPerEdge");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadTreeMeshCache>.NativeClassPtr, 100683362);
		NativeMethodInfoPtr_GetOrCreateTriangles_Public_NativeArray_1_Int32_TerrainDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadTreeMeshCache>.NativeClassPtr, 100683363);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuadTreeMeshCache>.NativeClassPtr, 100683364);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 261251, RefRangeEnd = 261252, XrefRangeStart = 261242, XrefRangeEnd = 261251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe QuadTreeMeshCache(int quadsPerEdge)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuadTreeMeshCache>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&quadsPerEdge);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 261273, RefRangeEnd = 261274, XrefRangeStart = 261252, XrefRangeEnd = 261273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<int> GetOrCreateTriangles(TerrainDirection direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&direction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateTriangles_Public_NativeArray_1_Int32_TerrainDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<int>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 261297, RefRangeEnd = 261298, XrefRangeStart = 261274, XrefRangeEnd = 261297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public QuadTreeMeshCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

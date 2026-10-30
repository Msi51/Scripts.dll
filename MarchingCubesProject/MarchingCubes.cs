using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace MarchingCubesProject;

public class MarchingCubes : Marching
{
	private static readonly IntPtr NativeFieldInfoPtr__EdgeVertex_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_EdgeConnection;

	private static readonly IntPtr NativeFieldInfoPtr_EdgeDirection;

	private static readonly IntPtr NativeFieldInfoPtr_CubeEdgeFlags;

	private static readonly IntPtr NativeFieldInfoPtr_TriangleConnectionTable;

	private static readonly IntPtr NativeMethodInfoPtr_get_EdgeVertex_Private_get_Il2CppStructArray_1_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_EdgeVertex_Private_set_Void_Il2CppStructArray_1_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_March_Protected_Virtual_Void_Single_Single_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Color32_IList_1_Vector3_IList_1_Color32_IList_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

	public unsafe Il2CppStructArray<Vector3> _EdgeVertex_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EdgeVertex_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EdgeVertex_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppObjectBase EdgeConnection
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EdgeConnection, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EdgeConnection, (void*)IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe static Il2CppObjectBase EdgeDirection
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EdgeDirection, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EdgeDirection, (void*)IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe static Il2CppStructArray<int> CubeEdgeFlags
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CubeEdgeFlags, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CubeEdgeFlags, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppObjectBase TriangleConnectionTable
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TriangleConnectionTable, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TriangleConnectionTable, (void*)IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Il2CppStructArray<Vector3> EdgeVertex
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 19179, RefRangeEnd = 19194, XrefRangeStart = 19179, XrefRangeEnd = 19194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EdgeVertex_Private_get_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EdgeVertex_Private_set_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static MarchingCubes()
	{
		Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "MarchingCubesProject", "MarchingCubes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr);
		NativeFieldInfoPtr__EdgeVertex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr, "<EdgeVertex>k__BackingField");
		NativeFieldInfoPtr_EdgeConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr, "EdgeConnection");
		NativeFieldInfoPtr_EdgeDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr, "EdgeDirection");
		NativeFieldInfoPtr_CubeEdgeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr, "CubeEdgeFlags");
		NativeFieldInfoPtr_TriangleConnectionTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr, "TriangleConnectionTable");
		NativeMethodInfoPtr_get_EdgeVertex_Private_get_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr, 100686400);
		NativeMethodInfoPtr_set_EdgeVertex_Private_set_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr, 100686401);
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr, 100686402);
		NativeMethodInfoPtr_March_Protected_Virtual_Void_Single_Single_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Color32_IList_1_Vector3_IList_1_Color32_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr, 100686403);
		NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr, 100686404);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 291780, RefRangeEnd = 291781, XrefRangeStart = 291772, XrefRangeEnd = 291780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MarchingCubes(float surface = 0f)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarchingCubes>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&surface);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291781, XrefRangeEnd = 291812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void March(float x, float y, float z, Il2CppStructArray<float> cube, Il2CppStructArray<Color32> colorCube, IList<Vector3> vertList, IList<Color32> colors, IList<int> indexList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[8];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &z;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cube);
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorCube);
		*(IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertList);
		*(IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indexList);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_March_Protected_Virtual_Void_Single_Single_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Color32_IList_1_Vector3_IList_1_Color32_IList_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291812, XrefRangeEnd = 291814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MarchingCubes(IntPtr pointer)
		: base(pointer)
	{
	}
}

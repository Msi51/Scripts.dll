using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Common.Unity.Drawing;

public class SegmentRenderer : BaseRenderer
{
	private static readonly IntPtr NativeFieldInfoPtr__LineModes_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Primatives_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DRAW_ORIENTATION_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_LineModes_Private_get_List_1_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_LineModes_Private_set_Void_List_1_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Primatives_Private_get_List_1_RenderPrimative_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Primatives_Private_set_Void_List_1_RenderPrimative_0;

	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddPrimative_Private_Void_RenderPrimative_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_IList_1_Int32_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_IList_1_Color_IList_1_Int32_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_Color_IList_1_Int32_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_Vector2_Vector2_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_Vector2_Vector2_Color_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_IList_1_Int32_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_IList_1_Color_IList_1_Int32_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_Color_IList_1_Int32_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_Vector3_Vector3_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_Vector3_Vector3_Color_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector4_IList_1_Int32_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector4_IList_1_Color_IList_1_Int32_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector4_Color_IList_1_Int32_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_Vector4_Vector4_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_Vector4_Vector4_Color_LINE_MODE_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSegmentIndices_Private_Void_Int32_IList_1_Int32_RenderPrimative_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDraw_Protected_Virtual_Void_Camera_Matrix4x4_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawVerticesAsLines_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawVerticesAsTriangles_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawVerticesAsQuads_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawVerticesAsTetrahedron_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawVerticesAsPentagons_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawVerticesAsHexagons_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0;

	public unsafe List<LINE_MODE> _LineModes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LineModes_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<LINE_MODE>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LineModes_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RenderPrimative> _Primatives_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Primatives_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RenderPrimative>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Primatives_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<LINE_MODE> LineModes
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 96529, RefRangeEnd = 96536, XrefRangeStart = 96529, XrefRangeEnd = 96536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LineModes_Private_get_List_1_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<LINE_MODE>>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LineModes_Private_set_Void_List_1_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe List<RenderPrimative> Primatives
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Primatives_Private_get_List_1_RenderPrimative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RenderPrimative>>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98360, RefRangeEnd = 98361, XrefRangeStart = 98360, XrefRangeEnd = 98361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Primatives_Private_set_Void_List_1_RenderPrimative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static SegmentRenderer()
	{
		Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Common.Unity.Drawing", "SegmentRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr);
		NativeFieldInfoPtr__LineModes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, "<LineModes>k__BackingField");
		NativeFieldInfoPtr__Primatives_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, "<Primatives>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686503);
		NativeMethodInfoPtr__ctor_Public_Void_DRAW_ORIENTATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686504);
		NativeMethodInfoPtr_get_LineModes_Private_get_List_1_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686505);
		NativeMethodInfoPtr_set_LineModes_Private_set_Void_List_1_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686506);
		NativeMethodInfoPtr_get_Primatives_Private_get_List_1_RenderPrimative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686507);
		NativeMethodInfoPtr_set_Primatives_Private_set_Void_List_1_RenderPrimative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686508);
		NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686509);
		NativeMethodInfoPtr_AddPrimative_Private_Void_RenderPrimative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686510);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686511);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_IList_1_Int32_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686512);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_IList_1_Color_IList_1_Int32_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686513);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_Color_IList_1_Int32_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686514);
		NativeMethodInfoPtr_Load_Public_Void_Vector2_Vector2_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686515);
		NativeMethodInfoPtr_Load_Public_Void_Vector2_Vector2_Color_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686516);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686517);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_IList_1_Int32_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686518);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_IList_1_Color_IList_1_Int32_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686519);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_Color_IList_1_Int32_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686520);
		NativeMethodInfoPtr_Load_Public_Void_Vector3_Vector3_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686521);
		NativeMethodInfoPtr_Load_Public_Void_Vector3_Vector3_Color_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686522);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector4_IList_1_Int32_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686523);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector4_IList_1_Color_IList_1_Int32_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686524);
		NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector4_Color_IList_1_Int32_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686525);
		NativeMethodInfoPtr_Load_Public_Void_Vector4_Vector4_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686526);
		NativeMethodInfoPtr_Load_Public_Void_Vector4_Vector4_Color_LINE_MODE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686527);
		NativeMethodInfoPtr_SetSegmentIndices_Private_Void_Int32_IList_1_Int32_RenderPrimative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686528);
		NativeMethodInfoPtr_OnDraw_Protected_Virtual_Void_Camera_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686529);
		NativeMethodInfoPtr_DrawVerticesAsLines_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686530);
		NativeMethodInfoPtr_DrawVerticesAsTriangles_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686531);
		NativeMethodInfoPtr_DrawVerticesAsQuads_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686532);
		NativeMethodInfoPtr_DrawVerticesAsTetrahedron_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686533);
		NativeMethodInfoPtr_DrawVerticesAsPentagons_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686534);
		NativeMethodInfoPtr_DrawVerticesAsHexagons_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr, 100686535);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292517, XrefRangeEnd = 292536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SegmentRenderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292536, XrefRangeEnd = 292555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SegmentRenderer(DRAW_ORIENTATION orientation)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SegmentRenderer>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&orientation);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DRAW_ORIENTATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292555, XrefRangeEnd = 292559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292559, XrefRangeEnd = 292570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPrimative(RenderPrimative prim)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prim);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPrimative_Private_Void_RenderPrimative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292570, XrefRangeEnd = 292571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector2> vertices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 292597, RefRangeEnd = 292598, XrefRangeStart = 292571, XrefRangeEnd = 292597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector2> vertices, IList<int> indices, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(LINE_MODE**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_IList_1_Int32_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292598, XrefRangeEnd = 292627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector2> vertices, IList<Color> colors, IList<int> indices = null, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(LINE_MODE**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_IList_1_Color_IList_1_Int32_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292627, XrefRangeEnd = 292653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector2> vertices, Color color, IList<int> indices = null, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &color;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(LINE_MODE**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector2_Color_IList_1_Int32_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292653, XrefRangeEnd = 292675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(Vector2 a, Vector2 b, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &b;
		*(LINE_MODE**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_Vector2_Vector2_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292675, XrefRangeEnd = 292697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(Vector2 a, Vector2 b, Color color, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &b;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &color;
		*(LINE_MODE**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_Vector2_Vector2_Color_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292697, XrefRangeEnd = 292698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector3> vertices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 292723, RefRangeEnd = 292724, XrefRangeStart = 292698, XrefRangeEnd = 292723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector3> vertices, IList<int> indices, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(LINE_MODE**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_IList_1_Int32_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292724, XrefRangeEnd = 292753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector3> vertices, IList<Color> colors, IList<int> indices = null, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(LINE_MODE**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_IList_1_Color_IList_1_Int32_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292753, XrefRangeEnd = 292778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector3> vertices, Color color, IList<int> indices = null, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &color;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(LINE_MODE**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector3_Color_IList_1_Int32_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292778, XrefRangeEnd = 292795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(Vector3 a, Vector3 b, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &b;
		*(LINE_MODE**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_Vector3_Vector3_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292795, XrefRangeEnd = 292812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(Vector3 a, Vector3 b, Color color, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &b;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &color;
		*(LINE_MODE**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_Vector3_Vector3_Color_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292812, XrefRangeEnd = 292837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector4> vertices, IList<int> indices = null, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(LINE_MODE**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector4_IList_1_Int32_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292837, XrefRangeEnd = 292866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector4> vertices, IList<Color> colors, IList<int> indices = null, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colors);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(LINE_MODE**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector4_IList_1_Color_IList_1_Int32_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292866, XrefRangeEnd = 292891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(IList<Vector4> vertices, Color color, IList<int> indices = null, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vertices);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &color;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(LINE_MODE**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_IList_1_Vector4_Color_IList_1_Int32_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292891, XrefRangeEnd = 292908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(Vector4 a, Vector4 b, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&a);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &b;
		*(LINE_MODE**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_Vector4_Vector4_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292908, XrefRangeEnd = 292925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(Vector4 a, Vector4 b, Color color, LINE_MODE mode = LINE_MODE.LINES)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&a);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &b;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &color;
		*(LINE_MODE**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mode;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_Vector4_Vector4_Color_LINE_MODE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 292939, RefRangeEnd = 292954, XrefRangeStart = 292925, XrefRangeEnd = 292939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSegmentIndices(int vertexCount, IList<int> indices, RenderPrimative primative)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&vertexCount);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)primative);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSegmentIndices_Private_Void_Int32_IList_1_Int32_RenderPrimative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292954, XrefRangeEnd = 292979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDraw(Camera camera, Matrix4x4 localToWorld)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &localToWorld;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDraw_Protected_Virtual_Void_Camera_Matrix4x4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 293009, RefRangeEnd = 293010, XrefRangeStart = 292979, XrefRangeEnd = 293009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawVerticesAsLines(Camera camera, Matrix4x4 localToWorld, Il2CppStructArray<int> indices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &localToWorld;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawVerticesAsLines_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 293065, RefRangeEnd = 293066, XrefRangeStart = 293010, XrefRangeEnd = 293065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawVerticesAsTriangles(Camera camera, Matrix4x4 localToWorld, Il2CppStructArray<int> indices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &localToWorld;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawVerticesAsTriangles_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 293133, RefRangeEnd = 293134, XrefRangeStart = 293066, XrefRangeEnd = 293133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawVerticesAsQuads(Camera camera, Matrix4x4 localToWorld, Il2CppStructArray<int> indices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &localToWorld;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawVerticesAsQuads_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 293225, RefRangeEnd = 293226, XrefRangeStart = 293134, XrefRangeEnd = 293225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawVerticesAsTetrahedron(Camera camera, Matrix4x4 localToWorld, Il2CppStructArray<int> indices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &localToWorld;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawVerticesAsTetrahedron_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 293305, RefRangeEnd = 293306, XrefRangeStart = 293226, XrefRangeEnd = 293305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawVerticesAsPentagons(Camera camera, Matrix4x4 localToWorld, Il2CppStructArray<int> indices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &localToWorld;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawVerticesAsPentagons_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 293398, RefRangeEnd = 293399, XrefRangeStart = 293306, XrefRangeEnd = 293398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawVerticesAsHexagons(Camera camera, Matrix4x4 localToWorld, Il2CppStructArray<int> indices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &localToWorld;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)indices);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawVerticesAsHexagons_Private_Void_Camera_Matrix4x4_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SegmentRenderer(IntPtr pointer)
		: base(pointer)
	{
	}
}

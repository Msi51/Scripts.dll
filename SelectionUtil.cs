using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class SelectionUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSelectable_Public_Static_Selectable_Selectable_Selectable_List_1_Type_List_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSelectableOnLeft_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSelectableOnRight_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSelectableOnUp_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSelectableOnDown_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSelectable_Public_Static_Selectable_Selectable_Vector3_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindNearestSelectable_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0;

	static SelectionUtil()
	{
		Il2CppClassPointerStore<SelectionUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SelectionUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionUtil>.NativeClassPtr);
		NativeMethodInfoPtr_CheckSelectable_Public_Static_Selectable_Selectable_Selectable_List_1_Type_List_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionUtil>.NativeClassPtr, 100667523);
		NativeMethodInfoPtr_FindSelectableOnLeft_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionUtil>.NativeClassPtr, 100667524);
		NativeMethodInfoPtr_FindSelectableOnRight_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionUtil>.NativeClassPtr, 100667525);
		NativeMethodInfoPtr_FindSelectableOnUp_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionUtil>.NativeClassPtr, 100667526);
		NativeMethodInfoPtr_FindSelectableOnDown_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionUtil>.NativeClassPtr, 100667527);
		NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionUtil>.NativeClassPtr, 100667528);
		NativeMethodInfoPtr_FindSelectable_Public_Static_Selectable_Selectable_Vector3_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionUtil>.NativeClassPtr, 100667529);
		NativeMethodInfoPtr_FindNearestSelectable_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionUtil>.NativeClassPtr, 100667530);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 79338, RefRangeEnd = 79340, XrefRangeStart = 79267, XrefRangeEnd = 79338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Selectable CheckSelectable(Selectable selectable, Selectable targetSelectable, List<Il2CppSystem.Type> typeWhitelist = null, List<Il2CppSystem.Type> allowedOtherWindowTypes = null, Il2CppSystem.Type requiredParentType = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetSelectable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeWhitelist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allowedOtherWindowTypes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredParentType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSelectable_Public_Static_Selectable_Selectable_Selectable_List_1_Type_List_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 79341, RefRangeEnd = 79345, XrefRangeStart = 79340, XrefRangeEnd = 79341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Selectable FindSelectableOnLeft(Selectable fromSelectable, Il2CppReferenceArray<Selectable> selectables, int selectableCount, List<Il2CppSystem.Type> typeWhitelist = null, List<Il2CppSystem.Type> allowedOtherWindowTypes = null, Il2CppSystem.Type requiredParentType = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromSelectable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectables);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectableCount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeWhitelist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allowedOtherWindowTypes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredParentType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSelectableOnLeft_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 79346, RefRangeEnd = 79350, XrefRangeStart = 79345, XrefRangeEnd = 79346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Selectable FindSelectableOnRight(Selectable fromSelectable, Il2CppReferenceArray<Selectable> selectables, int selectableCount, List<Il2CppSystem.Type> typeWhitelist = null, List<Il2CppSystem.Type> allowedOtherWindowTypes = null, Il2CppSystem.Type requiredParentType = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromSelectable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectables);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectableCount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeWhitelist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allowedOtherWindowTypes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredParentType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSelectableOnRight_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 79351, RefRangeEnd = 79355, XrefRangeStart = 79350, XrefRangeEnd = 79351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Selectable FindSelectableOnUp(Selectable fromSelectable, Il2CppReferenceArray<Selectable> selectables, int selectableCount, List<Il2CppSystem.Type> typeWhitelist = null, List<Il2CppSystem.Type> allowedOtherWindowTypes = null, Il2CppSystem.Type requiredParentType = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromSelectable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectables);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectableCount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeWhitelist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allowedOtherWindowTypes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredParentType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSelectableOnUp_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 79356, RefRangeEnd = 79360, XrefRangeStart = 79355, XrefRangeEnd = 79356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Selectable FindSelectableOnDown(Selectable fromSelectable, Il2CppReferenceArray<Selectable> selectables, int selectableCount, List<Il2CppSystem.Type> typeWhitelist = null, List<Il2CppSystem.Type> allowedOtherWindowTypes = null, Il2CppSystem.Type requiredParentType = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromSelectable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectables);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectableCount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeWhitelist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allowedOtherWindowTypes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredParentType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSelectableOnDown_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 79370, RefRangeEnd = 79371, XrefRangeStart = 79360, XrefRangeEnd = 79370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79371, XrefRangeEnd = 79409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Selectable FindSelectable(Selectable fromSelectable, Vector3 dir, Il2CppReferenceArray<Selectable> selectables, int selectableCount, List<Il2CppSystem.Type> typeWhitelist = null, List<Il2CppSystem.Type> allowedOtherWindowTypes = null, Il2CppSystem.Type requiredParentType = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromSelectable);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectables);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectableCount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeWhitelist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allowedOtherWindowTypes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredParentType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSelectable_Public_Static_Selectable_Selectable_Vector3_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 79436, RefRangeEnd = 79437, XrefRangeStart = 79409, XrefRangeEnd = 79436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Selectable FindNearestSelectable(Selectable fromSelectable, Il2CppReferenceArray<Selectable> selectables, int selectableCount, List<Il2CppSystem.Type> typeWhitelist = null, List<Il2CppSystem.Type> allowedOtherWindowTypes = null, Il2CppSystem.Type requiredParentType = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromSelectable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectables);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &selectableCount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)typeWhitelist);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allowedOtherWindowTypes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredParentType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindNearestSelectable_Public_Static_Selectable_Selectable_Il2CppReferenceArray_1_Selectable_Int32_List_1_Type_List_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Selectable>(intPtr) : null;
	}

	public SelectionUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

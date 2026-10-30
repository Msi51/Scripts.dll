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

public static class PhysicsUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_hits;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastOnlyObject_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastIgnoreObject_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SphereCastIgnoreObject_Public_Static_Boolean_Vector3_Single_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CapsuleCastIgnoreObject_Public_Static_Boolean_Vector3_Vector3_Single_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CapsuleCastIgnoreObject_Public_Static_Boolean_Vector3_Vector3_Single_Vector3_Single_Int32_QueryTriggerInteraction_GameObject_ICollection_1_RaycastHit_0;

	public unsafe static Il2CppStructArray<RaycastHit> hits
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hits, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hits, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static PhysicsUtil()
	{
		Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PhysicsUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr);
		NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr, "hits");
		NativeMethodInfoPtr_RaycastOnlyObject_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr, 100667863);
		NativeMethodInfoPtr_RaycastIgnoreObject_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr, 100667864);
		NativeMethodInfoPtr_SphereCastIgnoreObject_Public_Static_Boolean_Vector3_Single_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr, 100667865);
		NativeMethodInfoPtr_CapsuleCastIgnoreObject_Public_Static_Boolean_Vector3_Vector3_Single_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr, 100667866);
		NativeMethodInfoPtr_CapsuleCastIgnoreObject_Public_Static_Boolean_Vector3_Vector3_Single_Vector3_Single_Int32_QueryTriggerInteraction_GameObject_ICollection_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr, 100667867);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83626, RefRangeEnd = 83627, XrefRangeStart = 83604, XrefRangeEnd = 83626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RaycastOnlyObject(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction, GameObject onlyObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onlyObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastOnlyObject_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83649, RefRangeEnd = 83650, XrefRangeStart = 83627, XrefRangeEnd = 83649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RaycastIgnoreObject(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction, GameObject ignoredRootObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoredRootObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastIgnoreObject_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83650, XrefRangeEnd = 83672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SphereCastIgnoreObject(Vector3 origin, float sphereRadius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction, GameObject ignoredRootObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&origin);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sphereRadius;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoredRootObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SphereCastIgnoreObject_Public_Static_Boolean_Vector3_Single_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83694, RefRangeEnd = 83695, XrefRangeStart = 83672, XrefRangeEnd = 83694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CapsuleCastIgnoreObject(Vector3 point1, Vector3 point2, float sphereRadius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction, GameObject ignoredRootObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&point1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sphereRadius;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoredRootObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CapsuleCastIgnoreObject_Public_Static_Boolean_Vector3_Vector3_Single_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83722, RefRangeEnd = 83723, XrefRangeStart = 83695, XrefRangeEnd = 83722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CapsuleCastIgnoreObject(Vector3 point1, Vector3 point2, float sphereRadius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction, GameObject ignoredRootObject, ICollection<RaycastHit> resultHits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&point1);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point2;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sphereRadius;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoredRootObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultHits);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CapsuleCastIgnoreObject_Public_Static_Boolean_Vector3_Vector3_Single_Vector3_Single_Int32_QueryTriggerInteraction_GameObject_ICollection_1_RaycastHit_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public PhysicsUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

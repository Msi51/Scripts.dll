using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

public static class GameObjectUtil : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetComponents_Public_Static_ComponentIterator_1_T_GameObject_byref_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponents_Public_Static_ComponentIterator_1_T_GameObject_byref_List_1_T_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_blacklistLayerMask;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootGameObject_Public_Static_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootGameObject_Public_Static_GameObject_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceLayerRecursively_Public_Static_Void_GameObject_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponents_Public_Static_ComponentIterator_1_T_GameObject_byref_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindChildTransform_Public_Static_Transform_Transform_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindChildTransforms_Public_Static_List_1_Transform_Transform_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindChildObject_Public_Static_GameObject_Transform_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTransformTree_Public_Static_Transform_Transform_Transform_0;

	public unsafe static int blacklistLayerMask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_blacklistLayerMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_blacklistLayerMask, (void*)(&num));
		}
	}

	static GameObjectUtil()
	{
		Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GameObjectUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr);
		NativeFieldInfoPtr_blacklistLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, "blacklistLayerMask");
		NativeMethodInfoPtr_GetRootGameObject_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100667752);
		NativeMethodInfoPtr_GetRootGameObject_Public_Static_GameObject_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100667753);
		NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100667754);
		NativeMethodInfoPtr_ReplaceLayerRecursively_Public_Static_Void_GameObject_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100667755);
		NativeMethodInfoPtr_GetComponents_Public_Static_ComponentIterator_1_T_GameObject_byref_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100667756);
		NativeMethodInfoPtr_FindChildTransform_Public_Static_Transform_Transform_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100667757);
		NativeMethodInfoPtr_FindChildTransforms_Public_Static_List_1_Transform_Transform_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100667758);
		NativeMethodInfoPtr_FindChildObject_Public_Static_GameObject_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100667759);
		NativeMethodInfoPtr_CopyTransformTree_Public_Static_Transform_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100667760);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 81883, RefRangeEnd = 81913, XrefRangeStart = 81870, XrefRangeEnd = 81883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetRootGameObject(GameObject gameObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootGameObject_Public_Static_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 81922, RefRangeEnd = 81926, XrefRangeStart = 81913, XrefRangeEnd = 81922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetRootGameObject(Transform transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootGameObject_Public_Static_GameObject_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 81943, RefRangeEnd = 81970, XrefRangeStart = 81926, XrefRangeEnd = 81943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerRecursively(GameObject gameObject, int layer, bool ignoreBlacklistLayers = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreBlacklistLayers;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 81984, RefRangeEnd = 81986, XrefRangeStart = 81970, XrefRangeEnd = 81984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReplaceLayerRecursively(GameObject gameObject, int fromLayer, int toLayer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fromLayer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &toLayer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceLayerRecursively_Public_Static_Void_GameObject_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81986, XrefRangeEnd = 81990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ComponentIterator<T> GetComponents<T>(GameObject gameObject, out List<T> components) where T : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponents_Public_Static_ComponentIterator_1_T_GameObject_byref_List_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		components = ((num3 == 0) ? null : new List<T>(num3));
		return new ComponentIterator<T>(pointer);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 82036, RefRangeEnd = 82052, XrefRangeStart = 81990, XrefRangeEnd = 82036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform FindChildTransform(Transform fromTransform, string name, bool recursive = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recursive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindChildTransform_Public_Static_Transform_Transform_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 82113, RefRangeEnd = 82114, XrefRangeStart = 82052, XrefRangeEnd = 82113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Transform> FindChildTransforms(Transform fromTransform, string name, bool recursive = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &recursive;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindChildTransforms_Public_Static_List_1_Transform_Transform_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 82122, RefRangeEnd = 82129, XrefRangeStart = 82114, XrefRangeEnd = 82122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject FindChildObject(Transform fromTransform, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fromTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindChildObject_Public_Static_GameObject_Transform_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 82162, RefRangeEnd = 82163, XrefRangeStart = 82129, XrefRangeEnd = 82162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform CopyTransformTree(Transform sourceTransform, Transform destTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTransformTree_Public_Static_Transform_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	public GameObjectUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

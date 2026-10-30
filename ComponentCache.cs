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

public static class ComponentCache : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetComponent_Public_Static_T_GameObject_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponent_Public_Static_T_GameObject_Boolean_0, Il2CppClassPointerStore<ComponentCache>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_Static_T_GameObject_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentInChildren_Public_Static_T_GameObject_Boolean_0, Il2CppClassPointerStore<ComponentCache>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_childGameObjectMap;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponent_Public_Static_Component_GameObject_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponent_Public_Static_T_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Static_T_GameObject_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveGameObject_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearAll_Public_Static_Void_0;

	public unsafe static Dictionary<GameObject, Dictionary<Il2CppSystem.Type, Component>> gameObjectMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gameObjectMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameObject, Dictionary<Il2CppSystem.Type, Component>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gameObjectMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<GameObject, Dictionary<Il2CppSystem.Type, Component>> childGameObjectMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_childGameObjectMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameObject, Dictionary<Il2CppSystem.Type, Component>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_childGameObjectMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static ComponentCache()
	{
		Il2CppClassPointerStore<ComponentCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ComponentCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentCache>.NativeClassPtr);
		NativeFieldInfoPtr_gameObjectMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentCache>.NativeClassPtr, "gameObjectMap");
		NativeFieldInfoPtr_childGameObjectMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComponentCache>.NativeClassPtr, "childGameObjectMap");
		NativeMethodInfoPtr_GetComponent_Public_Static_Component_GameObject_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentCache>.NativeClassPtr, 100667660);
		NativeMethodInfoPtr_GetComponent_Public_Static_T_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentCache>.NativeClassPtr, 100667661);
		NativeMethodInfoPtr_GetComponentInChildren_Public_Static_T_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentCache>.NativeClassPtr, 100667662);
		NativeMethodInfoPtr_RemoveGameObject_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentCache>.NativeClassPtr, 100667663);
		NativeMethodInfoPtr_ClearAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentCache>.NativeClassPtr, 100667664);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 80283, RefRangeEnd = 80286, XrefRangeStart = 80256, XrefRangeEnd = 80283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Component GetComponent(GameObject gameObject, Il2CppSystem.Type type, bool write = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &write;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetComponent_Public_Static_Component_GameObject_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr) : null;
	}

	[CallerCount(117)]
	[CachedScanResults(RefRangeStart = 80297, RefRangeEnd = 80414, XrefRangeStart = 80286, XrefRangeEnd = 80297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponent<T>(GameObject gameObject, bool write = true) where T : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &write;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponent_Public_Static_T_GameObject_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 80454, RefRangeEnd = 80457, XrefRangeStart = 80414, XrefRangeEnd = 80454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentInChildren<T>(GameObject gameObject, bool write = true) where T : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &write;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentInChildren_Public_Static_T_GameObject_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 80486, RefRangeEnd = 80488, XrefRangeStart = 80457, XrefRangeEnd = 80486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveGameObject(GameObject gameObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveGameObject_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 80499, RefRangeEnd = 80500, XrefRangeStart = 80488, XrefRangeEnd = 80499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearAll()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearAll_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ComponentCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

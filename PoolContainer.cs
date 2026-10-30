using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class PoolContainer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_poolMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_contextPoolMap;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGameObjectPool_SerializationContextPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPool_Public_Void_PrefabVariantType_IGameObjectPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddContextPool_Public_Void_PrefabVariantType_SerializationContextPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasPool_Public_Boolean_PrefabVariantType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPool_Public_IGameObjectPool_PrefabVariantType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContextPool_Public_SerializationContextPool_PrefabVariantType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrototype_Public_GameObject_PrefabVariantType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unload_Public_Void_0;

	public unsafe Dictionary<PrefabVariantType, IGameObjectPool> poolMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poolMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<PrefabVariantType, IGameObjectPool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poolMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<PrefabVariantType, SerializationContextPool> contextPoolMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contextPoolMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<PrefabVariantType, SerializationContextPool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contextPoolMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static PoolContainer()
	{
		Il2CppClassPointerStore<PoolContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PoolContainer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr);
		NativeFieldInfoPtr_poolMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, "poolMap");
		NativeFieldInfoPtr_contextPoolMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, "contextPoolMap");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, 100678344);
		NativeMethodInfoPtr__ctor_Public_Void_IGameObjectPool_SerializationContextPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, 100678345);
		NativeMethodInfoPtr_AddPool_Public_Void_PrefabVariantType_IGameObjectPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, 100678346);
		NativeMethodInfoPtr_AddContextPool_Public_Void_PrefabVariantType_SerializationContextPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, 100678347);
		NativeMethodInfoPtr_HasPool_Public_Boolean_PrefabVariantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, 100678348);
		NativeMethodInfoPtr_GetPool_Public_IGameObjectPool_PrefabVariantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, 100678349);
		NativeMethodInfoPtr_GetContextPool_Public_SerializationContextPool_PrefabVariantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, 100678350);
		NativeMethodInfoPtr_GetPrototype_Public_GameObject_PrefabVariantType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, 100678351);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, 100678352);
		NativeMethodInfoPtr_Unload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr, 100678353);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224436, RefRangeEnd = 224437, XrefRangeStart = 224420, XrefRangeEnd = 224436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PoolContainer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 224459, RefRangeEnd = 224461, XrefRangeStart = 224437, XrefRangeEnd = 224459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PoolContainer(IGameObjectPool gameObjectPool, SerializationContextPool contextPool)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolContainer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObjectPool);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextPool);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_IGameObjectPool_SerializationContextPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224465, RefRangeEnd = 224466, XrefRangeStart = 224461, XrefRangeEnd = 224465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPool(PrefabVariantType variant, IGameObjectPool gameObjectPool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&variant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObjectPool);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPool_Public_Void_PrefabVariantType_IGameObjectPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224470, RefRangeEnd = 224471, XrefRangeStart = 224466, XrefRangeEnd = 224470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddContextPool(PrefabVariantType variant, SerializationContextPool contextPool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&variant);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextPool);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddContextPool_Public_Void_PrefabVariantType_SerializationContextPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 224475, RefRangeEnd = 224478, XrefRangeStart = 224471, XrefRangeEnd = 224475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasPool(PrefabVariantType variantType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&variantType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasPool_Public_Boolean_PrefabVariantType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 224481, RefRangeEnd = 224493, XrefRangeStart = 224478, XrefRangeEnd = 224481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IGameObjectPool GetPool(PrefabVariantType variant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&variant);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPool_Public_IGameObjectPool_PrefabVariantType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IGameObjectPool>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 224496, RefRangeEnd = 224508, XrefRangeStart = 224493, XrefRangeEnd = 224496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SerializationContextPool GetContextPool(PrefabVariantType variant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&variant);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContextPool_Public_SerializationContextPool_PrefabVariantType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SerializationContextPool>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224516, RefRangeEnd = 224517, XrefRangeStart = 224508, XrefRangeEnd = 224516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetPrototype(PrefabVariantType variant)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&variant);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrototype_Public_GameObject_PrefabVariantType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 224555, RefRangeEnd = 224557, XrefRangeStart = 224517, XrefRangeEnd = 224555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224595, RefRangeEnd = 224596, XrefRangeStart = 224557, XrefRangeEnd = 224595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unload()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PoolContainer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

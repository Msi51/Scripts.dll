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
using Il2CppSystem.Text;
using UnityEngine.Pool;

public static class PoolUtil : Il2CppSystem.Object
{
	public class ITrackedCollectionPool : Il2CppObjectBase
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveCount_Public_Abstract_Virtual_New_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCollectionType_Public_Abstract_Virtual_New_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPoolType_Public_Abstract_Virtual_New_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AppendLeakDetails_Public_Abstract_Virtual_New_Void_StringBuilder_0;

		static ITrackedCollectionPool()
		{
			Il2CppClassPointerStore<ITrackedCollectionPool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, "ITrackedCollectionPool");
			NativeMethodInfoPtr_GetActiveCount_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedCollectionPool>.NativeClassPtr, 100667878);
			NativeMethodInfoPtr_GetCollectionType_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedCollectionPool>.NativeClassPtr, 100667879);
			NativeMethodInfoPtr_GetPoolType_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedCollectionPool>.NativeClassPtr, 100667880);
			NativeMethodInfoPtr_AppendLeakDetails_Public_Abstract_Virtual_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITrackedCollectionPool>.NativeClassPtr, 100667881);
		}

		[CallerCount(0)]
		public unsafe virtual int GetActiveCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetActiveCount_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual Il2CppSystem.Type GetCollectionType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetCollectionType_Public_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}

		[CallerCount(0)]
		public unsafe virtual Il2CppSystem.Type GetPoolType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPoolType_Public_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}

		[CallerCount(0)]
		public unsafe virtual void AppendLeakDetails(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AppendLeakDetails_Public_Abstract_Virtual_New_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ITrackedCollectionPool(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class HashSetPool<T> : CollectionPool<HashSet<T>, T>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static HashSetPool()
		{
			Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, "HashSetPool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr, 100667882);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 83761, RefRangeEnd = 83771, XrefRangeStart = 83759, XrefRangeEnd = 83761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSetPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public HashSetPool(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ListPool<T> : CollectionPool<List<T>, T>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static ListPool()
		{
			Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, "ListPool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr, 100667883);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 83761, RefRangeEnd = 83771, XrefRangeStart = 83761, XrefRangeEnd = 83771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListPool<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ListPool(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DictionaryPool<TKey, TValue> : CollectionPool<Dictionary<TKey, TValue>, KeyValuePair<TKey, TValue>>
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static DictionaryPool()
		{
			Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, "DictionaryPool`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr, 100667884);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 83761, RefRangeEnd = 83771, XrefRangeStart = 83761, XrefRangeEnd = 83771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictionaryPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DictionaryPool(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class TrackedObjectPool<TCollection, TItem> : ObjectPool<TCollection> where TCollection : class, new()
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_TCollection_Action_1_TCollection_Action_1_TCollection_Action_1_TCollection_Boolean_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveCount_Public_Virtual_Final_New_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCollectionType_Public_Virtual_Final_New_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPoolType_Public_Virtual_Final_New_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AppendLeakDetails_Public_Virtual_Final_New_Void_StringBuilder_0;

		static TrackedObjectPool()
		{
			Il2CppClassPointerStore<TrackedObjectPool<TCollection, TItem>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, "TrackedObjectPool`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedObjectPool<TCollection, TItem>>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_Func_1_TCollection_Action_1_TCollection_Action_1_TCollection_Action_1_TCollection_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObjectPool<TCollection, TItem>>.NativeClassPtr, 100667885);
			NativeMethodInfoPtr_GetActiveCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObjectPool<TCollection, TItem>>.NativeClassPtr, 100667886);
			NativeMethodInfoPtr_GetCollectionType_Public_Virtual_Final_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObjectPool<TCollection, TItem>>.NativeClassPtr, 100667887);
			NativeMethodInfoPtr_GetPoolType_Public_Virtual_Final_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObjectPool<TCollection, TItem>>.NativeClassPtr, 100667888);
			NativeMethodInfoPtr_AppendLeakDetails_Public_Virtual_Final_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObjectPool<TCollection, TItem>>.NativeClassPtr, 100667889);
		}

		[CallerCount(0)]
		public unsafe TrackedObjectPool(Il2CppSystem.Func<TCollection> createFunc, Il2CppSystem.Action<TCollection> actionOnGet = null, Il2CppSystem.Action<TCollection> actionOnRelease = null, Il2CppSystem.Action<TCollection> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedObjectPool<TCollection, TItem>>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createFunc);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionOnGet);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionOnRelease);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionOnDestroy);
			*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &collectionCheck;
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultCapacity;
			*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSize;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Func_1_TCollection_Action_1_TCollection_Action_1_TCollection_Action_1_TCollection_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83771, XrefRangeEnd = 83772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetActiveCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveCount_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83772, XrefRangeEnd = 83776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.Type GetCollectionType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCollectionType_Public_Virtual_Final_New_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83776, XrefRangeEnd = 83780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.Type GetPoolType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPoolType_Public_Virtual_Final_New_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}

		[CallerCount(13368)]
		[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AppendLeakDetails(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendLeakDetails_Public_Virtual_Final_New_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TrackedObjectPool(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class CollectionPool<TCollection, TItem> : Il2CppSystem.Object where TCollection : class, new()
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pool;

		private static readonly System.IntPtr NativeMethodInfoPtr_onCreate_Private_Static_TCollection_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_onRelease_Private_Static_Void_TCollection_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_TCollection_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe static ObjectPool<TCollection> pool
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pool, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectPool<TCollection>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectPool));
			}
		}

		static CollectionPool()
		{
			Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, "CollectionPool`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCollection>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TItem>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr);
			NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, "pool");
			NativeMethodInfoPtr_onCreate_Private_Static_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100667890);
			NativeMethodInfoPtr_onRelease_Private_Static_Void_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100667891);
			NativeMethodInfoPtr_Get_Public_Static_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100667892);
			NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100667893);
			NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100667894);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr, 100667895);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83780, XrefRangeEnd = 83782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TCollection onCreate()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_Static_TCollection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TCollection>(intPtr, false, true);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83782, XrefRangeEnd = 83786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void onRelease(TCollection l)
		{
			//IL_0045->IL0048: Incompatible stack types: I vs Ref
			//IL_0038->IL0048: Incompatible stack types: I vs Ref
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref TCollection reference;
			if (!typeof(TCollection).IsValueType)
			{
				TCollection val = l;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref l;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onRelease_Private_Static_Void_TCollection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 83794, RefRangeEnd = 83840, XrefRangeStart = 83786, XrefRangeEnd = 83794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TCollection Get()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_TCollection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TCollection>(intPtr, false, true);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83847, RefRangeEnd = 83848, XrefRangeStart = 83840, XrefRangeEnd = 83847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PooledObject<TCollection> Get(out TCollection value)
		{
			//IL_0026->IL0028: Incompatible stack types: I vs Ref
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			Unsafe.SkipInit(out nint num);
			ref TCollection reference;
			if (!typeof(TCollection).IsValueType)
			{
				num = 0;
				reference = ref *(_003F*)(&num);
			}
			else
			{
				reference = ref value;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_TCollection_byref_TCollection_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			if (!typeof(TCollection).IsValueType)
			{
				nint num2 = num;
				value = ((num2 == 0) ? null : IL2CPP.PointerToValueGeneric<TCollection>((System.IntPtr)num2, false, false));
			}
			return new PooledObject<TCollection>(pointer);
		}

		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 83879, RefRangeEnd = 83930, XrefRangeStart = 83848, XrefRangeEnd = 83879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(TCollection toRelease)
		{
			//IL_0045->IL0048: Incompatible stack types: I vs Ref
			//IL_0038->IL0048: Incompatible stack types: I vs Ref
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref TCollection reference;
			if (!typeof(TCollection).IsValueType)
			{
				TCollection val = toRelease;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref toRelease;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Static_Void_TCollection_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionPool<TCollection, TItem>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CollectionPool(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_Get_Public_Static_PooledObject_1_List_1_T_byref_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_List_1_T_byref_List_1_T_0, Il2CppClassPointerStore<PoolUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Get_Public_Static_PooledObject_1_HashSet_1_T_byref_HashSet_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_HashSet_1_T_byref_HashSet_1_T_0, Il2CppClassPointerStore<PoolUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Get_Public_Static_PooledObject_1_Dictionary_2_TKey_TValue_byref_Dictionary_2_TKey_TValue_0<TKey, TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_Dictionary_2_TKey_TValue_byref_Dictionary_2_TKey_TValue_0, Il2CppClassPointerStore<PoolUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_trackedObjectPools;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_List_1_T_byref_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_HashSet_1_T_byref_HashSet_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_Dictionary_2_TKey_TValue_byref_Dictionary_2_TKey_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckInactivePools_Public_Static_Void_0;

	public unsafe static HashSet<ITrackedCollectionPool> trackedObjectPools
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_trackedObjectPools, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<ITrackedCollectionPool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_trackedObjectPools, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	static PoolUtil()
	{
		Il2CppClassPointerStore<PoolUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "PoolUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr);
		NativeFieldInfoPtr_trackedObjectPools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, "trackedObjectPools");
		NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_List_1_T_byref_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, 100667873);
		NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_HashSet_1_T_byref_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, 100667874);
		NativeMethodInfoPtr_Get_Public_Static_PooledObject_1_Dictionary_2_TKey_TValue_byref_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, 100667875);
		NativeMethodInfoPtr_CheckInactivePools_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolUtil>.NativeClassPtr, 100667876);
	}

	[CallerCount(630)]
	[CachedScanResults(RefRangeStart = 83932, RefRangeEnd = 84562, XrefRangeStart = 83930, XrefRangeEnd = 83932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PooledObject<List<T>> Get<T>(out List<T> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Get_Public_Static_PooledObject_1_List_1_T_byref_List_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		list = ((num2 == 0) ? null : new List<T>(num2));
		return new PooledObject<List<T>>(pointer);
	}

	[CallerCount(630)]
	[CachedScanResults(RefRangeStart = 83932, RefRangeEnd = 84562, XrefRangeStart = 83932, XrefRangeEnd = 84562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PooledObject<HashSet<T>> Get<T>(out HashSet<T> set)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Get_Public_Static_PooledObject_1_HashSet_1_T_byref_HashSet_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		set = ((num2 == 0) ? null : new HashSet<T>(num2));
		return new PooledObject<HashSet<T>>(pointer);
	}

	[CallerCount(630)]
	[CachedScanResults(RefRangeStart = 83932, RefRangeEnd = 84562, XrefRangeStart = 83932, XrefRangeEnd = 84562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PooledObject<Dictionary<TKey, TValue>> Get<TKey, TValue>(out Dictionary<TKey, TValue> dictionary)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Get_Public_Static_PooledObject_1_Dictionary_2_TKey_TValue_byref_Dictionary_2_TKey_TValue_0<TKey, TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		dictionary = ((num2 == 0) ? null : new Dictionary<TKey, TValue>(num2));
		return new PooledObject<Dictionary<TKey, TValue>>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84562, XrefRangeEnd = 84609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInactivePools()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInactivePools_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PoolUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

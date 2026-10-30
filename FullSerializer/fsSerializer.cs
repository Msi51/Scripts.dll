using System;
using System.Runtime.CompilerServices;
using FullSerializer.Internal;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace FullSerializer;

public class fsSerializer : Il2CppSystem.Object
{
	public class fsLazyCycleDefinitionWriter : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__pendingDefinitions;

		private static readonly System.IntPtr NativeFieldInfoPtr__references;

		private static readonly System.IntPtr NativeMethodInfoPtr_WriteDefinition_Public_Void_Int32_fsData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_WriteReference_Public_Void_Int32_Dictionary_2_String_fsData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Dictionary<int, fsData> _pendingDefinitions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pendingDefinitions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, fsData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__pendingDefinitions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe HashSet<int> _references
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__references);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__references)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		static fsLazyCycleDefinitionWriter()
		{
			Il2CppClassPointerStore<fsLazyCycleDefinitionWriter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "fsLazyCycleDefinitionWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fsLazyCycleDefinitionWriter>.NativeClassPtr);
			NativeFieldInfoPtr__pendingDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsLazyCycleDefinitionWriter>.NativeClassPtr, "_pendingDefinitions");
			NativeFieldInfoPtr__references = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsLazyCycleDefinitionWriter>.NativeClassPtr, "_references");
			NativeMethodInfoPtr_WriteDefinition_Public_Void_Int32_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsLazyCycleDefinitionWriter>.NativeClassPtr, 100686737);
			NativeMethodInfoPtr_WriteReference_Public_Void_Int32_Dictionary_2_String_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsLazyCycleDefinitionWriter>.NativeClassPtr, 100686738);
			NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsLazyCycleDefinitionWriter>.NativeClassPtr, 100686739);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsLazyCycleDefinitionWriter>.NativeClassPtr, 100686740);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295647, XrefRangeEnd = 295656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDefinition(int id, fsData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&id);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteDefinition_Public_Void_Int32_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295696, RefRangeEnd = 295697, XrefRangeStart = 295656, XrefRangeEnd = 295696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteReference(int id, Dictionary<string, fsData> dict)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&id);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dict);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteReference_Public_Void_Int32_Dictionary_2_String_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295697, XrefRangeEnd = 295704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295704, XrefRangeEnd = 295720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe fsLazyCycleDefinitionWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsLazyCycleDefinitionWriter>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public fsLazyCycleDefinitionWriter(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_RemoveProcessor_Public_Void_0<TProcessor>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RemoveProcessor_Public_Void_0, Il2CppClassPointerStore<fsSerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TProcessor>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_TrySerialize_Public_fsResult_T_byref_fsData_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TrySerialize_Public_fsResult_T_byref_fsData_0, Il2CppClassPointerStore<fsSerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_TryDeserialize_Public_fsResult_fsData_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryDeserialize_Public_fsResult_fsData_byref_T_0, Il2CppClassPointerStore<fsSerializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__reservedKeywords;

	private static readonly System.IntPtr NativeFieldInfoPtr_Key_ObjectReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_Key_ObjectDefinition;

	private static readonly System.IntPtr NativeFieldInfoPtr_Key_InstanceType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Key_Version;

	private static readonly System.IntPtr NativeFieldInfoPtr_Key_Content;

	private static readonly System.IntPtr NativeFieldInfoPtr__cachedConverterTypeInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr__cachedConverters;

	private static readonly System.IntPtr NativeFieldInfoPtr__cachedProcessors;

	private static readonly System.IntPtr NativeFieldInfoPtr__availableConverters;

	private static readonly System.IntPtr NativeFieldInfoPtr__availableDirectConverters;

	private static readonly System.IntPtr NativeFieldInfoPtr__processors;

	private static readonly System.IntPtr NativeFieldInfoPtr__references;

	private static readonly System.IntPtr NativeFieldInfoPtr__lazyReferenceWriter;

	private static readonly System.IntPtr NativeFieldInfoPtr_Context;

	private static readonly System.IntPtr NativeFieldInfoPtr_Config;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsReservedKeyword_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsObjectReference_Private_Static_Boolean_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsObjectDefinition_Private_Static_Boolean_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsVersioned_Private_Static_Boolean_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTypeSpecified_Private_Static_Boolean_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWrappedData_Private_Static_Boolean_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StripDeserializationMetadata_Public_Static_Void_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertLegacyData_Private_Static_Void_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_OnBeforeSerialize_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_OnAfterSerialize_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_OnBeforeDeserialize_Private_Static_Void_List_1_fsObjectProcessor_Type_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_OnBeforeDeserializeAfterInstanceCreation_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_OnAfterDeserialize_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureDictionary_Private_Static_Void_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddProcessor_Public_Void_fsObjectProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveProcessor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProcessors_Private_List_1_fsObjectProcessor_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddConverter_Public_Void_fsBaseConverter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConverter_Private_fsBaseConverter_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrySerialize_Public_fsResult_T_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDeserialize_Public_fsResult_fsData_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrySerialize_Public_fsResult_Type_Object_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrySerialize_Public_fsResult_Type_Type_Object_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSerialize_1_ProcessCycles_Private_fsResult_Type_Type_Object_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSerialize_2_Inheritance_Private_fsResult_Type_Type_Object_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSerialize_3_ProcessVersioning_Private_fsResult_Type_Object_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSerialize_4_Converter_Private_fsResult_Type_Object_byref_fsData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDeserialize_Public_fsResult_fsData_Type_byref_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryDeserialize_Public_fsResult_fsData_Type_Type_byref_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalDeserialize_1_CycleReference_Private_fsResult_Type_fsData_Type_byref_Object_byref_List_1_fsObjectProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalDeserialize_2_Version_Private_fsResult_Type_fsData_Type_byref_Object_byref_List_1_fsObjectProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalDeserialize_3_Inheritance_Private_fsResult_Type_fsData_Type_byref_Object_byref_List_1_fsObjectProcessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalDeserialize_4_Cycles_Private_fsResult_Type_fsData_Type_byref_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalDeserialize_5_Converter_Private_fsResult_Type_fsData_Type_byref_Object_0;

	public unsafe static HashSet<string> _reservedKeywords
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__reservedKeywords, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__reservedKeywords, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static string Key_ObjectReference
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Key_ObjectReference, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Key_ObjectReference, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Key_ObjectDefinition
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Key_ObjectDefinition, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Key_ObjectDefinition, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Key_InstanceType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Key_InstanceType, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Key_InstanceType, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Key_Version
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Key_Version, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Key_Version, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string Key_Content
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Key_Content, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Key_Content, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Dictionary<Il2CppSystem.Type, fsBaseConverter> _cachedConverterTypeInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedConverterTypeInstances);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, fsBaseConverter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedConverterTypeInstances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Il2CppSystem.Type, fsBaseConverter> _cachedConverters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedConverters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, fsBaseConverter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedConverters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Il2CppSystem.Type, List<fsObjectProcessor>> _cachedProcessors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedProcessors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, List<fsObjectProcessor>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cachedProcessors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<fsConverter> _availableConverters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__availableConverters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<fsConverter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__availableConverters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<Il2CppSystem.Type, fsDirectConverter> _availableDirectConverters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__availableDirectConverters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, fsDirectConverter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__availableDirectConverters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<fsObjectProcessor> _processors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__processors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<fsObjectProcessor>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__processors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe fsCyclicReferenceManager _references
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__references);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<fsCyclicReferenceManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__references)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fsCyclicReferenceManager2));
		}
	}

	public unsafe fsLazyCycleDefinitionWriter _lazyReferenceWriter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lazyReferenceWriter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<fsLazyCycleDefinitionWriter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lazyReferenceWriter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fsLazyCycleDefinitionWriter2));
		}
	}

	public unsafe fsContext Context
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Context);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<fsContext>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Context)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fsContext2));
		}
	}

	public unsafe fsConfig Config
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Config);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<fsConfig>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Config)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fsConfig2));
		}
	}

	static fsSerializer()
	{
		Il2CppClassPointerStore<fsSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "FullSerializer", "fsSerializer");
		NativeFieldInfoPtr__reservedKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "_reservedKeywords");
		NativeFieldInfoPtr_Key_ObjectReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "Key_ObjectReference");
		NativeFieldInfoPtr_Key_ObjectDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "Key_ObjectDefinition");
		NativeFieldInfoPtr_Key_InstanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "Key_InstanceType");
		NativeFieldInfoPtr_Key_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "Key_Version");
		NativeFieldInfoPtr_Key_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "Key_Content");
		NativeFieldInfoPtr__cachedConverterTypeInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "_cachedConverterTypeInstances");
		NativeFieldInfoPtr__cachedConverters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "_cachedConverters");
		NativeFieldInfoPtr__cachedProcessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "_cachedProcessors");
		NativeFieldInfoPtr__availableConverters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "_availableConverters");
		NativeFieldInfoPtr__availableDirectConverters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "_availableDirectConverters");
		NativeFieldInfoPtr__processors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "_processors");
		NativeFieldInfoPtr__references = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "_references");
		NativeFieldInfoPtr__lazyReferenceWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "_lazyReferenceWriter");
		NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "Context");
		NativeFieldInfoPtr_Config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, "Config");
		NativeMethodInfoPtr_IsReservedKeyword_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686702);
		NativeMethodInfoPtr_IsObjectReference_Private_Static_Boolean_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686703);
		NativeMethodInfoPtr_IsObjectDefinition_Private_Static_Boolean_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686704);
		NativeMethodInfoPtr_IsVersioned_Private_Static_Boolean_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686705);
		NativeMethodInfoPtr_IsTypeSpecified_Private_Static_Boolean_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686706);
		NativeMethodInfoPtr_IsWrappedData_Private_Static_Boolean_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686707);
		NativeMethodInfoPtr_StripDeserializationMetadata_Public_Static_Void_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686708);
		NativeMethodInfoPtr_ConvertLegacyData_Private_Static_Void_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686709);
		NativeMethodInfoPtr_Invoke_OnBeforeSerialize_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686710);
		NativeMethodInfoPtr_Invoke_OnAfterSerialize_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686711);
		NativeMethodInfoPtr_Invoke_OnBeforeDeserialize_Private_Static_Void_List_1_fsObjectProcessor_Type_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686712);
		NativeMethodInfoPtr_Invoke_OnBeforeDeserializeAfterInstanceCreation_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686713);
		NativeMethodInfoPtr_Invoke_OnAfterDeserialize_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686714);
		NativeMethodInfoPtr_EnsureDictionary_Private_Static_Void_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686715);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686716);
		NativeMethodInfoPtr_AddProcessor_Public_Void_fsObjectProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686717);
		NativeMethodInfoPtr_RemoveProcessor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686718);
		NativeMethodInfoPtr_GetProcessors_Private_List_1_fsObjectProcessor_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686719);
		NativeMethodInfoPtr_AddConverter_Public_Void_fsBaseConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686720);
		NativeMethodInfoPtr_GetConverter_Private_fsBaseConverter_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686721);
		NativeMethodInfoPtr_TrySerialize_Public_fsResult_T_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686722);
		NativeMethodInfoPtr_TryDeserialize_Public_fsResult_fsData_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686723);
		NativeMethodInfoPtr_TrySerialize_Public_fsResult_Type_Object_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686724);
		NativeMethodInfoPtr_TrySerialize_Public_fsResult_Type_Type_Object_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686725);
		NativeMethodInfoPtr_InternalSerialize_1_ProcessCycles_Private_fsResult_Type_Type_Object_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686726);
		NativeMethodInfoPtr_InternalSerialize_2_Inheritance_Private_fsResult_Type_Type_Object_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686727);
		NativeMethodInfoPtr_InternalSerialize_3_ProcessVersioning_Private_fsResult_Type_Object_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686728);
		NativeMethodInfoPtr_InternalSerialize_4_Converter_Private_fsResult_Type_Object_byref_fsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686729);
		NativeMethodInfoPtr_TryDeserialize_Public_fsResult_fsData_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686730);
		NativeMethodInfoPtr_TryDeserialize_Public_fsResult_fsData_Type_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686731);
		NativeMethodInfoPtr_InternalDeserialize_1_CycleReference_Private_fsResult_Type_fsData_Type_byref_Object_byref_List_1_fsObjectProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686732);
		NativeMethodInfoPtr_InternalDeserialize_2_Version_Private_fsResult_Type_fsData_Type_byref_Object_byref_List_1_fsObjectProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686733);
		NativeMethodInfoPtr_InternalDeserialize_3_Inheritance_Private_fsResult_Type_fsData_Type_byref_Object_byref_List_1_fsObjectProcessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686734);
		NativeMethodInfoPtr_InternalDeserialize_4_Cycles_Private_fsResult_Type_fsData_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686735);
		NativeMethodInfoPtr_InternalDeserialize_5_Converter_Private_fsResult_Type_fsData_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr, 100686736);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295720, XrefRangeEnd = 295728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsReservedKeyword(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsReservedKeyword_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295728, XrefRangeEnd = 295739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsObjectReference(fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsObjectReference_Private_Static_Boolean_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 295750, RefRangeEnd = 295753, XrefRangeStart = 295739, XrefRangeEnd = 295750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsObjectDefinition(fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsObjectDefinition_Private_Static_Boolean_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295753, XrefRangeEnd = 295764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsVersioned(fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsVersioned_Private_Static_Boolean_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295764, XrefRangeEnd = 295775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsTypeSpecified(fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTypeSpecified_Private_Static_Boolean_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295775, XrefRangeEnd = 295786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWrappedData(fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWrappedData_Private_Static_Boolean_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295786, XrefRangeEnd = 295826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StripDeserializationMetadata(ref fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StripDeserializationMetadata_Public_Static_Void_byref_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new fsData(intPtr4));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 295894, RefRangeEnd = 295897, XrefRangeStart = 295826, XrefRangeEnd = 295894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertLegacyData(ref fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertLegacyData_Private_Static_Void_byref_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new fsData(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295897, XrefRangeEnd = 295902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Il2CppSystem.Type storageType, Il2CppSystem.Object instance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)processors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_OnBeforeSerialize_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 295906, RefRangeEnd = 295907, XrefRangeStart = 295902, XrefRangeEnd = 295906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Il2CppSystem.Type storageType, Il2CppSystem.Object instance, ref fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)processors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_OnAfterSerialize_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_byref_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new fsData(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295907, XrefRangeEnd = 295912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Il2CppSystem.Type storageType, ref fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)processors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_OnBeforeDeserialize_Private_Static_Void_List_1_fsObjectProcessor_Type_byref_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new fsData(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295912, XrefRangeEnd = 295917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Il2CppSystem.Type storageType, Il2CppSystem.Object instance, ref fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)processors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_OnBeforeDeserializeAfterInstanceCreation_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_byref_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new fsData(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295917, XrefRangeEnd = 295921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Il2CppSystem.Type storageType, Il2CppSystem.Object instance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)processors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_OnAfterDeserialize_Private_Static_Void_List_1_fsObjectProcessor_Type_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 295945, RefRangeEnd = 295950, XrefRangeStart = 295921, XrefRangeEnd = 295945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureDictionary(fsData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureDictionary_Private_Static_Void_fsData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 296177, RefRangeEnd = 296178, XrefRangeStart = 295950, XrefRangeEnd = 296177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsSerializer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fsSerializer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296178, XrefRangeEnd = 296189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddProcessor(fsObjectProcessor processor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)processor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddProcessor_Public_Void_fsObjectProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296189, XrefRangeEnd = 296208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveProcessor<TProcessor>()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RemoveProcessor_Public_Void_0<TProcessor>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 296236, RefRangeEnd = 296240, XrefRangeStart = 296208, XrefRangeEnd = 296236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<fsObjectProcessor> GetProcessors(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProcessors_Private_List_1_fsObjectProcessor_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<fsObjectProcessor>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 296285, RefRangeEnd = 296286, XrefRangeStart = 296240, XrefRangeEnd = 296285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddConverter(fsBaseConverter converter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)converter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddConverter_Public_Void_fsBaseConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 296331, RefRangeEnd = 296337, XrefRangeStart = 296286, XrefRangeEnd = 296331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsBaseConverter GetConverter(Il2CppSystem.Type type, Il2CppSystem.Type overrideConverterType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConverter_Private_fsBaseConverter_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<fsBaseConverter>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 296342, RefRangeEnd = 296343, XrefRangeStart = 296337, XrefRangeEnd = 296342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TrySerialize<T>(T instance, out fsData data)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = instance;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref instance;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TrySerialize_Public_fsResult_T_byref_fsData_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		data = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296343, XrefRangeEnd = 296357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryDeserialize<T>(fsData data, ref T instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref instance));
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryDeserialize_Public_fsResult_fsData_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		Unsafe.As<T, object>(ref instance) = ((intPtr3 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr3, false, false));
		return new fsResult(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 296358, RefRangeEnd = 296361, XrefRangeStart = 296357, XrefRangeEnd = 296358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TrySerialize(Il2CppSystem.Type storageType, Il2CppSystem.Object instance, out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrySerialize_Public_fsResult_Type_Object_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		data = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 296378, RefRangeEnd = 296390, XrefRangeStart = 296361, XrefRangeEnd = 296378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TrySerialize(Il2CppSystem.Type storageType, Il2CppSystem.Type overrideConverterType, Il2CppSystem.Object instance, out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrySerialize_Public_fsResult_Type_Type_Object_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		data = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 296456, RefRangeEnd = 296457, XrefRangeStart = 296390, XrefRangeEnd = 296456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult InternalSerialize_1_ProcessCycles(Il2CppSystem.Type storageType, Il2CppSystem.Type overrideConverterType, Il2CppSystem.Object instance, out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSerialize_1_ProcessCycles_Private_fsResult_Type_Type_Object_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		data = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 296484, RefRangeEnd = 296486, XrefRangeStart = 296457, XrefRangeEnd = 296484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult InternalSerialize_2_Inheritance(Il2CppSystem.Type storageType, Il2CppSystem.Type overrideConverterType, Il2CppSystem.Object instance, out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSerialize_2_Inheritance_Private_fsResult_Type_Type_Object_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		data = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 296499, RefRangeEnd = 296500, XrefRangeStart = 296486, XrefRangeEnd = 296499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult InternalSerialize_3_ProcessVersioning(Il2CppSystem.Type overrideConverterType, Il2CppSystem.Object instance, out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSerialize_3_ProcessVersioning_Private_fsResult_Type_Object_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		data = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296500, XrefRangeEnd = 296502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult InternalSerialize_4_Converter(Il2CppSystem.Type overrideConverterType, Il2CppSystem.Object instance, out fsData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instance);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSerialize_4_Converter_Private_fsResult_Type_Object_byref_fsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		data = ((num3 == 0) ? null : new fsData(num3));
		return new fsResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 296503, RefRangeEnd = 296505, XrefRangeStart = 296502, XrefRangeEnd = 296503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryDeserialize(fsData data, Il2CppSystem.Type storageType, ref Il2CppSystem.Object result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryDeserialize_Public_fsResult_fsData_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		result = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppSystem.Object(intPtr3));
		return new fsResult(pointer);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 296523, RefRangeEnd = 296536, XrefRangeStart = 296505, XrefRangeEnd = 296523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult TryDeserialize(fsData data, Il2CppSystem.Type storageType, Il2CppSystem.Type overrideConverterType, ref Il2CppSystem.Object result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryDeserialize_Public_fsResult_fsData_Type_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		result = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppSystem.Object(intPtr3));
		return new fsResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 296577, RefRangeEnd = 296578, XrefRangeStart = 296536, XrefRangeEnd = 296577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult InternalDeserialize_1_CycleReference(Il2CppSystem.Type overrideConverterType, fsData data, Il2CppSystem.Type storageType, ref Il2CppSystem.Object result, out List<fsObjectProcessor> processors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num3 = 0;
		*(nint**)num2 = &num3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDeserialize_1_CycleReference_Private_fsResult_Type_fsData_Type_byref_Object_byref_List_1_fsObjectProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		result = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppSystem.Object(intPtr3));
		nint num4 = num3;
		processors = ((num4 == 0) ? null : new List<fsObjectProcessor>(num4));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296578, XrefRangeEnd = 296665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult InternalDeserialize_2_Version(Il2CppSystem.Type overrideConverterType, fsData data, Il2CppSystem.Type storageType, ref Il2CppSystem.Object result, out List<fsObjectProcessor> processors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num3 = 0;
		*(nint**)num2 = &num3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDeserialize_2_Version_Private_fsResult_Type_fsData_Type_byref_Object_byref_List_1_fsObjectProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		result = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppSystem.Object(intPtr3));
		nint num4 = num3;
		processors = ((num4 == 0) ? null : new List<fsObjectProcessor>(num4));
		return new fsResult(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 296796, RefRangeEnd = 296797, XrefRangeStart = 296665, XrefRangeEnd = 296796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult InternalDeserialize_3_Inheritance(Il2CppSystem.Type overrideConverterType, fsData data, Il2CppSystem.Type storageType, ref Il2CppSystem.Object result, out List<fsObjectProcessor> processors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storageType);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num3 = 0;
		*(nint**)num2 = &num3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDeserialize_3_Inheritance_Private_fsResult_Type_fsData_Type_byref_Object_byref_List_1_fsObjectProcessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		result = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppSystem.Object(intPtr3));
		nint num4 = num3;
		processors = ((num4 == 0) ? null : new List<fsObjectProcessor>(num4));
		return new fsResult(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296797, XrefRangeEnd = 296818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult InternalDeserialize_4_Cycles(Il2CppSystem.Type overrideConverterType, fsData data, Il2CppSystem.Type resultType, ref Il2CppSystem.Object result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultType);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDeserialize_4_Cycles_Private_fsResult_Type_fsData_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		result = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppSystem.Object(intPtr3));
		return new fsResult(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 296842, RefRangeEnd = 296844, XrefRangeStart = 296818, XrefRangeEnd = 296842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fsResult InternalDeserialize_5_Converter(Il2CppSystem.Type overrideConverterType, fsData data, Il2CppSystem.Type resultType, ref Il2CppSystem.Object result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)overrideConverterType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultType);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDeserialize_5_Converter_Private_fsResult_Type_fsData_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		result = ((intPtr3 == (System.IntPtr)0) ? null : new Il2CppSystem.Object(intPtr3));
		return new fsResult(pointer);
	}

	public fsSerializer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

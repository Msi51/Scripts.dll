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
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using Unity.Mathematics;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[System.Serializable]
public class World : Il2CppSystem.Object
{
	public sealed class NetworkWorldUpdate : Il2CppSystem.ValueType
	{
		private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_worldTimeScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldTimeScaleFactor;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldSleepState;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldDateTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_worldStartDateTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_sunAngleOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentWeatherState;

		private static readonly System.IntPtr NativeFieldInfoPtr_diseaseAmount;

		private static readonly System.IntPtr NativeFieldInfoPtr_terrainWetness;

		private static readonly System.IntPtr NativeFieldInfoPtr_terrainSnow;

		private static readonly System.IntPtr NativeFieldInfoPtr_temperature;

		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

		public unsafe float worldTimeScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTimeScale);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTimeScale)) = num;
			}
		}

		public unsafe float worldTimeScaleFactor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTimeScaleFactor);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTimeScaleFactor)) = num;
			}
		}

		public unsafe bool worldSleepState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSleepState);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSleepState)) = flag;
			}
		}

		public unsafe Il2CppSystem.DateTime worldDateTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDateTime);
				return *(Il2CppSystem.DateTime*)num;
			}
			set
			{
				*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDateTime)) = dateTime;
			}
		}

		public unsafe Il2CppSystem.DateTime worldStartDateTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldStartDateTime);
				return *(Il2CppSystem.DateTime*)num;
			}
			set
			{
				*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldStartDateTime)) = dateTime;
			}
		}

		public unsafe float sunAngleOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunAngleOffset);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunAngleOffset)) = num;
			}
		}

		public unsafe WeatherState currentWeatherState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWeatherState);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WeatherState>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWeatherState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)weatherState));
			}
		}

		public unsafe float diseaseAmount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseAmount);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseAmount)) = num;
			}
		}

		public unsafe float terrainWetness
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainWetness);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainWetness)) = num;
			}
		}

		public unsafe float terrainSnow
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainSnow);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainSnow)) = num;
			}
		}

		public unsafe float temperature
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temperature);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temperature)) = num;
			}
		}

		static NetworkWorldUpdate()
		{
			Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<World>.NativeClassPtr, "NetworkWorldUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr);
			NativeFieldInfoPtr_worldTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "worldTimeScale");
			NativeFieldInfoPtr_worldTimeScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "worldTimeScaleFactor");
			NativeFieldInfoPtr_worldSleepState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "worldSleepState");
			NativeFieldInfoPtr_worldDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "worldDateTime");
			NativeFieldInfoPtr_worldStartDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "worldStartDateTime");
			NativeFieldInfoPtr_sunAngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "sunAngleOffset");
			NativeFieldInfoPtr_currentWeatherState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "currentWeatherState");
			NativeFieldInfoPtr_diseaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "diseaseAmount");
			NativeFieldInfoPtr_terrainWetness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "terrainWetness");
			NativeFieldInfoPtr_terrainSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "terrainSnow");
			NativeFieldInfoPtr_temperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, "temperature");
			NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr, 100683655);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261553, XrefRangeEnd = 261564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NetworkWorldUpdate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public NetworkWorldUpdate()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkWorldUpdate>.NativeClassPtr))
		{
		}
	}

	public sealed class NetworkWorldCampUpdate : Il2CppSystem.ValueType
	{
		private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<NetworkWorldCampUpdate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_druidCamp;

		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

		public unsafe DruidCamp druidCamp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_druidCamp);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DruidCamp>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_druidCamp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)druidCamp));
			}
		}

		static NetworkWorldCampUpdate()
		{
			Il2CppClassPointerStore<NetworkWorldCampUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<World>.NativeClassPtr, "NetworkWorldCampUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkWorldCampUpdate>.NativeClassPtr);
			NativeFieldInfoPtr_druidCamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldCampUpdate>.NativeClassPtr, "druidCamp");
			NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkWorldCampUpdate>.NativeClassPtr, 100683656);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261564, XrefRangeEnd = 261565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NetworkWorldCampUpdate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public NetworkWorldCampUpdate()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkWorldCampUpdate>.NativeClassPtr))
		{
		}
	}

	public sealed class NetworkWorldDiseaseCenterUpdate : Il2CppSystem.ValueType
	{
		private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
		{
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<NetworkWorldDiseaseCenterUpdate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_chunkCoordinates;

		private static readonly System.IntPtr NativeFieldInfoPtr_diseaseCenters;

		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

		public unsafe Coordinates chunkCoordinates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkCoordinates);
				return *(Coordinates*)num;
			}
			set
			{
				*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkCoordinates)) = coordinates;
			}
		}

		public unsafe List<DiseaseCenter> diseaseCenters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseCenters);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DiseaseCenter>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseCenters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static NetworkWorldDiseaseCenterUpdate()
		{
			Il2CppClassPointerStore<NetworkWorldDiseaseCenterUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<World>.NativeClassPtr, "NetworkWorldDiseaseCenterUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkWorldDiseaseCenterUpdate>.NativeClassPtr);
			NativeFieldInfoPtr_chunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldDiseaseCenterUpdate>.NativeClassPtr, "chunkCoordinates");
			NativeFieldInfoPtr_diseaseCenters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkWorldDiseaseCenterUpdate>.NativeClassPtr, "diseaseCenters");
			NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkWorldDiseaseCenterUpdate>.NativeClassPtr, 100683657);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NetworkWorldDiseaseCenterUpdate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public NetworkWorldDiseaseCenterUpdate()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkWorldDiseaseCenterUpdate>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("World+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__212_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__212_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__212_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__212_3;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__212_4;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__212_5;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__handleNewDay_b__212_0_Internal_Void_CreatureSpawnData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__handleNewDay_b__212_1_Internal_Void_CreatureSpawnData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__handleNewDay_b__212_2_Internal_Void_CreatureSpawnData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__handleNewDay_b__212_3_Internal_Void_CreatureSpawnData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__handleNewDay_b__212_4_Internal_Void_CreatureSpawnData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__handleNewDay_b__212_5_Internal_Void_CreatureSpawnData_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Action<CreatureSpawnData> __9__212_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__212_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CreatureSpawnData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__212_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe static Il2CppSystem.Action<CreatureSpawnData> __9__212_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__212_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CreatureSpawnData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__212_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe static Il2CppSystem.Action<CreatureSpawnData> __9__212_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__212_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CreatureSpawnData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__212_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe static Il2CppSystem.Action<CreatureSpawnData> __9__212_3
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__212_3, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CreatureSpawnData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__212_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe static Il2CppSystem.Action<CreatureSpawnData> __9__212_4
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__212_4, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CreatureSpawnData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__212_4, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe static Il2CppSystem.Action<CreatureSpawnData> __9__212_5
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__212_5, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CreatureSpawnData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__212_5, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<World>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__212_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__212_0");
			NativeFieldInfoPtr___9__212_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__212_1");
			NativeFieldInfoPtr___9__212_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__212_2");
			NativeFieldInfoPtr___9__212_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__212_3");
			NativeFieldInfoPtr___9__212_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__212_4");
			NativeFieldInfoPtr___9__212_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__212_5");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100683659);
			NativeMethodInfoPtr__handleNewDay_b__212_0_Internal_Void_CreatureSpawnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100683660);
			NativeMethodInfoPtr__handleNewDay_b__212_1_Internal_Void_CreatureSpawnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100683661);
			NativeMethodInfoPtr__handleNewDay_b__212_2_Internal_Void_CreatureSpawnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100683662);
			NativeMethodInfoPtr__handleNewDay_b__212_3_Internal_Void_CreatureSpawnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100683663);
			NativeMethodInfoPtr__handleNewDay_b__212_4_Internal_Void_CreatureSpawnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100683664);
			NativeMethodInfoPtr__handleNewDay_b__212_5_Internal_Void_CreatureSpawnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100683665);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void _handleNewDay_b__212_0(CreatureSpawnData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__handleNewDay_b__212_0_Internal_Void_CreatureSpawnData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void _handleNewDay_b__212_1(CreatureSpawnData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__handleNewDay_b__212_1_Internal_Void_CreatureSpawnData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void _handleNewDay_b__212_2(CreatureSpawnData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__handleNewDay_b__212_2_Internal_Void_CreatureSpawnData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void _handleNewDay_b__212_3(CreatureSpawnData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__handleNewDay_b__212_3_Internal_Void_CreatureSpawnData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void _handleNewDay_b__212_4(CreatureSpawnData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__handleNewDay_b__212_4_Internal_Void_CreatureSpawnData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void _handleNewDay_b__212_5(CreatureSpawnData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__handleNewDay_b__212_5_Internal_Void_CreatureSpawnData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("World+<>c__DisplayClass273_0")]
	public sealed class __c__DisplayClass273_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_waitHandle;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__StartLoadingChunk_b__0_Internal_Boolean_0;

		public unsafe EventWaitHandle waitHandle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitHandle);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EventWaitHandle>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitHandle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventWaitHandle));
			}
		}

		static __c__DisplayClass273_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass273_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<World>.NativeClassPtr, "<>c__DisplayClass273_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass273_0>.NativeClassPtr);
			NativeFieldInfoPtr_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass273_0>.NativeClassPtr, "waitHandle");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass273_0>.NativeClassPtr, 100683666);
			NativeMethodInfoPtr__StartLoadingChunk_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass273_0>.NativeClassPtr, 100683667);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass273_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass273_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165728, RefRangeEnd = 165729, XrefRangeStart = 165728, XrefRangeEnd = 165729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartLoadingChunk_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__StartLoadingChunk_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass273_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<World>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_regionChunkDataPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionChunkPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionTerrainPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkDataPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkMapTexturePool;

	private static readonly System.IntPtr NativeFieldInfoPtr_takenPositionsPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentEntityMapPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_identifierToEntitiesMapPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_slopeDataPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_holeMapPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveDataPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_BASE_TIME_SCALE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SLEEPING_STATE_TIME_SCALE;

	private static readonly System.IntPtr NativeFieldInfoPtr_WEATHER_STATE_DURATION_MIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_WEATHER_STATE_DURATION_MAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_WEATHER_STATE_PREVENT_REPEAT_RAIN_TIME;

	private static readonly System.IntPtr NativeFieldInfoPtr_SNOW_MAX_TEMPERATURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_CHUNK_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_CELL_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_TERRAIN_HEIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_CAVE_CHUNK_SIZE_XZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_CAVE_CHUNK_SIZE_Y;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_WORLD_YEAR;

	private static readonly System.IntPtr NativeFieldInfoPtr_noon;

	private static readonly System.IntPtr NativeFieldInfoPtr_midnight;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunHorizonColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunNormalColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayAmbientColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_goldenHourAmbientColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_nightAmbientColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayFogColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_goldenHourFogColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_postSunsetFogColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_nightFogColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseStormFogColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseStormNightFogColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_undergroundFogColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_skySHDirections;

	private static readonly System.IntPtr NativeFieldInfoPtr_WATER_RIPPLE_COUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_DISEASE_REMOVED_AMOUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialGameVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_players;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldGenerator;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldCreatureConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkInfos;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigLakeCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_seaShoreCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_rockyAreaCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_villageCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_capitalCityCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_homeVillageCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_swamps;

	private static readonly System.IntPtr NativeFieldInfoPtr_villages;

	private static readonly System.IntPtr NativeFieldInfoPtr_survivorCamps;

	private static readonly System.IntPtr NativeFieldInfoPtr_caves;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseCenters;

	private static readonly System.IntPtr NativeFieldInfoPtr_druidCamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_pendingWorldEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggeredWorldEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedWaterMapChecks;

	private static readonly System.IntPtr NativeFieldInfoPtr_generatedChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_generatedStructures;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionChunkSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_cellsPerChunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkTerrainSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveChunkSizeXZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveChunkSizeY;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldTimeScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldTimeScaleFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSleepState;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSleepCountdown;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldDateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldStartDateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunAngleOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentWeatherState;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherStateHistories;

	private static readonly System.IntPtr NativeFieldInfoPtr_seed;

	private static readonly System.IntPtr NativeFieldInfoPtr_seedOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionChunkRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldRandom;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionCenterCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionName;

	private static readonly System.IntPtr NativeFieldInfoPtr_seaDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_seaName;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainIslandLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainIslandRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_rainSubstanceIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_diseaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainWetness;

	private static readonly System.IntPtr NativeFieldInfoPtr_temperature;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainSnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockedBlueprintIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockedCraftingRecipeIdentifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_seasonsEffectsStartDate;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadChunkTasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkWaitHandles;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeChunks;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionChunks;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkSerializedEntities;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleTerrainCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionChunksToGenerate;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunksToSave;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionChunksToActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionChunksToUnload;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunksToUnload;

	private static readonly System.IntPtr NativeFieldInfoPtr_entitiesToDestroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectsToDestroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_generatedChunksToActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadedChunksToActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_networkLoadedChunksToActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkSlopeDataToGenerate;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedDetailPlacementCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedSimpleObjectCreations;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedEntityCreations;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedEntityLoads;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedEntityNetworkLoads;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedEntityActivations;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedChunkCellPostProcessing;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedDetailLods;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedSoundColliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedTexturePaints;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedTextureRectanglePaints;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedClearedSnowPaints;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedPaintedChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedClearedSnowChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedHeightAdjustmentChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedDetailMapAdjustedCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedDetailMapRefresh;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedCaveChunkObjectsToCreate;

	private static readonly System.IntPtr NativeFieldInfoPtr_physicsBakeJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkQueuedTexturePaints;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkQueuedTextureRectanglePaints;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureLayerMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerTextureMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTypeIndexMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexTerrainTypeMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_outdoorReflectionProbe;

	private static readonly System.IntPtr NativeFieldInfoPtr_undergroundReflectionProbe;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderingVolume;

	private static readonly System.IntPtr NativeFieldInfoPtr_snowEffectObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_snowParticleSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_rainEffectObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_rainParticleSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainDeadnessOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterPlaneMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveWaterPlaneMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentEntityMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_identifierToEntitiesMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_game;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldState;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxVisibleLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_rainSubstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_dayRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_nightRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_fogIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_minViewDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxViewDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveWaterMaterialTemplate;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterMaterials;

	private static readonly System.IntPtr NativeFieldInfoPtr_sessionChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionMapData;

	private static readonly System.IntPtr NativeFieldInfoPtr_surfaceGatherItemDropMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_surfaceDigItemDropMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialGatherSurfaceTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_tillableSurfaceTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialSurfaceTypeSearch;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainItemTextureTypeMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_alwaysExposeDirtTextureTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_deepExposeDirtTextureTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureExposeMaxAmounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflectedCameraMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraTextureMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyboxCameraMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_entitiesInRangeResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterReflectionQualityLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_isReflectionRenderInProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflectionPipelineAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterRipples;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentWaterRippleIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearbyCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_numEntities;

	private static readonly System.IntPtr NativeFieldInfoPtr_numNetworkedEntities;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflectionProbeRenderId;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastReflectionProbeFinishTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_instancedEntityLODs;

	private static readonly System.IntPtr NativeFieldInfoPtr_instancedEntityProperties;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveClippingRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeNavMeshOperation;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeTerrainNavMeshOperation;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedTerrainNavMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_navMeshData;

	private static readonly System.IntPtr NativeFieldInfoPtr_queuedNavMeshUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_navMeshBuildSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_navMeshSources;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveRaycastHits;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraFrustumPlanes;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkedUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleNewDay_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateSpawnData_Private_Void_List_1_CreatureSpawnData_String_Action_1_CreatureSpawnData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeSpawnData_Private_Void_List_1_CreatureSpawnData_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleWeather_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleLighting_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCloudTextureData_Public_Void_Il2CppStructArray_1_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doChunkUpdates_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleDiseaseInfection_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleToxicSmoke_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleVisibleChunkCells_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_showVisibleCells_Private_Void_Chunk_Coordinates_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCellCulling_Private_Void_Coordinates_Coordinates_CellCulling_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handlePhysicsChunkCells_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_trackPhysicsCells_Private_Void_Chunk_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_trackPhysicsCell_Private_Void_Chunk_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleChunkCulling_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleWaterUpdates_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateWater_Private_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doMaterialUpdates_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doQueuedPaintUpdates_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateNavMesh_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addNavMeshSource_Private_Void_BoxCollider_List_1_NavMeshBuildSource_byref_Bounds_Vector3_NavMeshBuildSourceShape_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addNavMeshSource_Private_Void_TerrainCollider_Terrain_List_1_NavMeshBuildSource_byref_Bounds_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addNavMeshSource_Private_Void_MeshCollider_List_1_NavMeshBuildSource_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RegionCoordinatesMin_Public_get_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RegionCoordinatesMax_Public_get_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AreCoordinatesInRegion_Public_Boolean_Coordinates_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomCoordinatesInRegion_Public_Coordinates_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWaterRipple_Public_Void_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainDeepness_Public_Single_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainSteepness_Public_Single_Vector3_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DigTerrain_Public_Void_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustTerrain_Public_Void_TerrainPoint_Single_List_1_TerrainAdjustmentInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaceTerrain_Public_Single_Vector3_InventoryItem_Single_Single_List_1_TerrainAdjustmentInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmoothTerrain_Public_Void_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LevelTerrain_Public_Void_Vector3_Single_Single_Single_List_1_TerrainAdjustmentInfo_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintDirtForTerrainAdjustments_Private_Void_List_1_TerrainAdjustmentInfo_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintDirtForPosition_Private_Void_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustTerrainHeight_Private_Single_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_List_1_TextureType_Boolean_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_adjustTerrainHeight_Private_Single_TerrainPoint_Single_List_1_TerrainAdjustmentInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_smoothTerrain_Private_Single_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_List_1_TextureType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_levelTerrain_Private_Single_Vector3_Single_Single_Single_List_1_TerrainAdjustmentInfo_List_1_TextureType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TillSoil_Public_Void_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainPoint_Public_TerrainPoint_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainPointsWithinBounds_Public_Void_List_1_Vector3_List_1_TerrainPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainPointCollisions_Public_Void_List_1_TerrainPoint_GameObject_List_1_ValueTuple_2_TerrainPoint_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkInfo_Public_ChunkInfo_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HomeVillage_Public_get_Village_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CapitalCity_Public_get_Village_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVillage_Public_Village_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkCoordinatesForRegionPosition_Public_Coordinates_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRegionChunkCoordinates_Public_Coordinates_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRegionChunk_Public_RegionChunk_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveRegionChunks_Public_ICollection_1_RegionChunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRegionChunk_Public_Void_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRegionChunk_Public_Void_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkLoadTask_Public_Task_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartLoadingChunk_Public_Void_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunk_Public_Chunk_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunk_Public_Chunk_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkCoordinates_Public_Coordinates_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkCoordinates_Public_Coordinates_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Coordinates_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkCellCoordinates_Public_ChunkCellCoordinates_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCaveOriginChunk_Public_Chunk_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AreCoordinatesGenerated_Public_Boolean_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllGeneratedChunkCoordinates_Public_HashSet_1_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGeneratedChunk_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveGeneratedChunk_Public_Void_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActivateChunk_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveChunk_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearChunkWaitTasks_Public_Void_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsChunkActive_Public_Boolean_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveChunks_Public_ValueCollection_Coordinates_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumStructuresGenerated_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNumStructuresGenerated_Public_Int32_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnyStructuresNearby_Public_Boolean_Coordinates_Single_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGeneratedStructure_Public_Void_String_Coordinates_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearbyFeature_Public_Boolean_Coordinates_Single_ChunkInfoFeatureType_byref_ChunkInfoFeature_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFeatureNearby_Public_Boolean_Coordinates_Single_ChunkInfoFeatureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkNearbyFeature_Private_Boolean_Int32_Int32_ChunkInfoFeatureType_byref_ChunkInfoFeature_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSerializedEntities_Public_Void_Coordinates_List_1_SerializedEntity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSessionChunkCoordinate_Public_Void_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSessionChunkCoordinate_Public_Void_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSessionChunkCoordinates_Public_HashSet_1_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkEntityMap_Public_Dictionary_2_Coordinates_List_1_SerializedEntity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEntity_Public_Void_Entity_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEntity_Public_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueSimpleObjectCreation_Public_Void_SimpleObjectCreationInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueEntityCreation_Public_Void_EntityCreationInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueEntityLoad_Public_Void_SerializedEntity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueNetworkEntityLoad_Public_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueEntityActivation_Public_Void_Chunk_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueDetailObjectLod_Public_Void_DetailLodCreationInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueSoundCollider_Public_Void_Chunk_Vector3_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllPlayerEntities_Public_HashSet_1_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesWithComponent_Public_HashSet_1_Entity_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesWithIdentifier_Public_HashSet_1_Entity_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSlope_Public_Vector2_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSlopeMagnitude_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationOnTerrain_Public_Quaternion_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkCenterPosition_Public_Vector2_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkCenterPosition3_Public_Vector3_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkPosition_Public_Vector3_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainOriginalHeight_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainHeight_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainHeight_Public_Single_TerrainPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightmapDetails_Public_Boolean_Coordinates_Int32_Int32_Int32_byref_Chunk_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionInCave_Public_Vector3_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_TerrainPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnTerrainAndCave_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnTerrainAndWater_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCaveChunk_Public_CaveChunk_CaveData_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCaveData_Public_Boolean_Vector3_byref_CaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInCave_Public_Boolean_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChunkContainsCaveEntrance_Public_Boolean_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCaveChunkVoxelCoordinates_Public_Boolean_Vector3_byref_CaveChunk_byref_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnCaveFloor_Public_Boolean_Vector3_byref_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnCaveFloor_Public_Boolean_Vector3_Vector2_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionOnCaveFloor_Public_Boolean_Vector3_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTerrainPositionUnderWater_Public_Boolean_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCavePositionUnderWater_Public_Boolean_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainIslandDistance_Public_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainIslandAmount_Public_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWaterWaves_Public_Void_Vector3_byref_Vector4_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWaterHeight_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWaterHeightOffset_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWaterForceDirection_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainWetness_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSolidObjectTakenPosition_Public_Boolean_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGatherItemDropsAtPosition_Public_List_1_ItemDrop_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDigItemDropsAtPosition_Public_List_1_ItemDrop_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDigItemDropsForTexture_Public_List_1_ItemDrop_TextureType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureTypeAmountAtPosition_Public_Single_Vector3_TextureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureTypeAtPosition_Public_TextureType_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureTypeAtCavePosition_Public_TextureType_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PaintTextureTypeAtPosition_Public_Void_Vector3_TextureType_Single_Single_Single_FalloffType_List_1_TextureType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PaintTerrainItemTextureTypeAtPosition_Public_Void_Vector3_InventoryItem_Single_Single_Single_FalloffType_List_1_TextureType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSnowFootstep_Public_Void_Vector3_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSnow_Public_Void_Vector3_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSnow_Public_Void_Vector3_Single_Single_Boolean_PaintInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClearedSnowAtPosition_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldDrynessAtPosition_Public_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldDrynessAtPosition_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainTypeAtPosition_Public_TerrainType_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTerrainTypeAmountAtPosition_Public_Single_Vector3_TerrainType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSurfaceTypeAtTerrainPosition_Public_SurfaceType_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSurfaceNameAtPosition_Public_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getSurfaceType_Private_SurfaceType_TerrainType_TextureType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCaveSurfaceType_Private_SurfaceType_TextureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSurfaceType_Public_SurfaceType_TextureType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCaveSurfaceType_Public_SurfaceType_TextureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSurfaceTypeAtCavePosition_Public_SurfaceType_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiseaseAmountAtPosition_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkMapDepthValue_Public_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkMapDepthValue_Public_Single_Chunk_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkMapDepthValue_Public_Single_Chunk_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiseaseCentersNearPoint_Public_Void_Vector3_Single_ICollection_1_DiseaseCenter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiseaseCentersOnChunk_Public_Void_Chunk_ICollection_1_DiseaseCenter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiseaseCentersNearChunk_Public_Void_Chunk_ICollection_1_DiseaseCenter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDiseaseCenter_Public_Void_DiseaseCenter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDiseaseCenters_Public_Void_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiseaseRemovedAmount_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTerrainHeightDelta_Public_Single_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnyObjectsNearby_Public_Boolean_Vector3_Single_HashSet_1_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectsAroundPointWithComponent_Public_HashSet_1_GameObject_Vector3_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesAroundPointWithComponent_Public_Void_Vector3_Single_String_ICollection_1_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesAroundPointWithAllComponents_Public_Void_Vector3_Single_ICollection_1_Entity_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesAroundPointWithAnyComponents_Public_Void_Vector3_Single_ICollection_1_Entity_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEntitiesAroundPoint_Public_Void_Vector3_Single_ICollection_1_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEntitiesAroundPoint_Private_Void_Vector3_Single_Boolean_List_1_String_ICollection_1_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEntitiesInRange_Private_Void_Vector3_Single_ICollection_1_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellCoordinatesFromCenterChunk_Public_Void_Coordinates_Coordinates_byref_Coordinates_byref_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellCoordinatesFromCenterChunk_Public_Void_Coordinates_Int32_Int32_byref_Coordinates_byref_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearbyTerrainLayerZones_Public_Void_Vector3_Single_List_1_TerrainLayerZone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckZone_Public_Boolean_Chunk_TerrainLayerZone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSurroundingChunks_Public_List_1_Chunk_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLatitude_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextSunriseDateTime_Public_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextSunsetDateTime_Public_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determineNextWeatherState_Private_WeatherState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeatherStateHistoryData_Public_WeatherStateHistoryData_DateTime_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeatherStateHistoryData_Public_WeatherStateHistoryData_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPastRainTime_Public_Single_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPastRainTime_Public_Single_DateTime_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPastSnowTime_Public_Single_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRainSubstance_Public_Void_Substance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWorldSleepState_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasWorldSleepCountdown_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWorldSleepCountdown_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWorldTimeScaleFactor_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldTimeScaledDeltaTime_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldTimeScaledDeltaTime_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseTimeScale_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSleepState_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeatherDateTime_Public_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldDateTime_Public_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldStartDateTime_Public_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldDateTimeSeconds_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDateTime_Public_Void_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTime_Public_Void_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDay_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDay_Public_Int32_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentDay_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNightTime_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDayPercentage_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNightPercentage_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldState_Public_WorldState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActiveState_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUnloadedState_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWorldState_Public_Void_WorldState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCell_Public_Void_Chunk_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCell_Public_Void_Entity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCellBounds_Public_Void_Chunk_Vector3_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshDetailPlacements_Public_Void_Chunk_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRainIntensity_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSnowIntensity_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCloudsPercentage_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWindIntensity_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFogIntensity_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWaterReflectionQuality_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetViewDistance_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWaterMaterial_Public_Void_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initializeReflectionCamera_Private_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTriggeredWorldEvent_Public_Void_WorldEventType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWorldEventTriggered_Public_Boolean_WorldEventType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setupReflectionCamera_Private_Camera_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_positionReflectionCamera_Private_Void_Camera_Camera_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setupSkyboxCamera_Private_Camera_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_beginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleReflectionRendering_Private_Void_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_endCameraRendering_Private_Void_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_renderOutdoorReflectionProbe_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_renderOutdoorReflectionProbeSlice_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cameraSpacePlane_Private_Vector4_Camera_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_calculateReflectionMatrix_Private_Static_Void_byref_Matrix4x4_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UndergroundVisible_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OutdoorVisible_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnterCave_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitCave_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SchedulePhysicsBake_Public_Void_MeshCollider_Mesh_Boolean_Boolean_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueNavMeshUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyUpdates_Public_Void_NetworkWorldUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpdates_Public_NetworkWorldUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyUpdates_Public_Void_NetworkWorldCampUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCampUpdate_Public_NetworkWorldCampUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyUpdates_Public_Void_NetworkWorldDiseaseCenterUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiseaseCenterUpdate_Public_NetworkWorldDiseaseCenterUpdate_Coordinates_0;

	public unsafe static RegionChunkDataPool regionChunkDataPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_regionChunkDataPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegionChunkDataPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_regionChunkDataPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionChunkDataPool));
		}
	}

	public unsafe static RegionChunkPool regionChunkPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_regionChunkPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegionChunkPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_regionChunkPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionChunkPool));
		}
	}

	public unsafe static CustomTerrainGameObjectPool regionTerrainPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_regionTerrainPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomTerrainGameObjectPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_regionTerrainPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customTerrainGameObjectPool));
		}
	}

	public unsafe static ChunkDataPool chunkDataPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chunkDataPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChunkDataPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chunkDataPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkDataPool));
		}
	}

	public unsafe static TexturePool chunkMapTexturePool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chunkMapTexturePool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TexturePool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chunkMapTexturePool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texturePool));
		}
	}

	public unsafe static TakenPositionsPool takenPositionsPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_takenPositionsPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TakenPositionsPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_takenPositionsPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositionsPool));
		}
	}

	public unsafe static ComponentEntityMapPool componentEntityMapPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_componentEntityMapPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComponentEntityMapPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_componentEntityMapPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)componentEntityMapPool));
		}
	}

	public unsafe static IdentifierToEntitiesMapPool identifierToEntitiesMapPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_identifierToEntitiesMapPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IdentifierToEntitiesMapPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_identifierToEntitiesMapPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identifierToEntitiesMapPool));
		}
	}

	public unsafe static SlopeDataPool slopeDataPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_slopeDataPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SlopeDataPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_slopeDataPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slopeDataPool));
		}
	}

	public unsafe static HoleMapPool holeMapPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_holeMapPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HoleMapPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_holeMapPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)holeMapPool));
		}
	}

	public unsafe static CaveDataPool caveDataPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_caveDataPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CaveDataPool>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_caveDataPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveDataPool));
		}
	}

	public unsafe static float BASE_TIME_SCALE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BASE_TIME_SCALE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BASE_TIME_SCALE, (void*)(&num));
		}
	}

	public unsafe static float SLEEPING_STATE_TIME_SCALE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SLEEPING_STATE_TIME_SCALE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SLEEPING_STATE_TIME_SCALE, (void*)(&num));
		}
	}

	public unsafe static float WEATHER_STATE_DURATION_MIN
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WEATHER_STATE_DURATION_MIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WEATHER_STATE_DURATION_MIN, (void*)(&num));
		}
	}

	public unsafe static float WEATHER_STATE_DURATION_MAX
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WEATHER_STATE_DURATION_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WEATHER_STATE_DURATION_MAX, (void*)(&num));
		}
	}

	public unsafe static float WEATHER_STATE_PREVENT_REPEAT_RAIN_TIME
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WEATHER_STATE_PREVENT_REPEAT_RAIN_TIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WEATHER_STATE_PREVENT_REPEAT_RAIN_TIME, (void*)(&num));
		}
	}

	public unsafe static float SNOW_MAX_TEMPERATURE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SNOW_MAX_TEMPERATURE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SNOW_MAX_TEMPERATURE, (void*)(&num));
		}
	}

	public unsafe static int DEFAULT_CHUNK_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_CHUNK_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_CHUNK_SIZE, (void*)(&num));
		}
	}

	public unsafe static int DEFAULT_CELL_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_CELL_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_CELL_SIZE, (void*)(&num));
		}
	}

	public unsafe static int DEFAULT_TERRAIN_HEIGHT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_TERRAIN_HEIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_TERRAIN_HEIGHT, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_CAVE_CHUNK_SIZE_XZ
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_CAVE_CHUNK_SIZE_XZ, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_CAVE_CHUNK_SIZE_XZ, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_CAVE_CHUNK_SIZE_Y
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_CAVE_CHUNK_SIZE_Y, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_CAVE_CHUNK_SIZE_Y, (void*)(&num));
		}
	}

	public unsafe static int DEFAULT_WORLD_YEAR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_WORLD_YEAR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_WORLD_YEAR, (void*)(&num));
		}
	}

	public unsafe static Il2CppSystem.TimeSpan noon
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_noon, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_noon, (void*)(&timeSpan));
		}
	}

	public unsafe static Il2CppSystem.TimeSpan midnight
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_midnight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_midnight, (void*)(&timeSpan));
		}
	}

	public unsafe static Color sunHorizonColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sunHorizonColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sunHorizonColor, (void*)(&color));
		}
	}

	public unsafe static Color sunNormalColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sunNormalColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sunNormalColor, (void*)(&color));
		}
	}

	public unsafe static Color dayAmbientColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dayAmbientColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dayAmbientColor, (void*)(&color));
		}
	}

	public unsafe static Color goldenHourAmbientColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_goldenHourAmbientColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_goldenHourAmbientColor, (void*)(&color));
		}
	}

	public unsafe static Color nightAmbientColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nightAmbientColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nightAmbientColor, (void*)(&color));
		}
	}

	public unsafe static Color dayFogColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dayFogColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dayFogColor, (void*)(&color));
		}
	}

	public unsafe static Color goldenHourFogColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_goldenHourFogColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_goldenHourFogColor, (void*)(&color));
		}
	}

	public unsafe static Color postSunsetFogColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_postSunsetFogColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_postSunsetFogColor, (void*)(&color));
		}
	}

	public unsafe static Color nightFogColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nightFogColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nightFogColor, (void*)(&color));
		}
	}

	public unsafe static Color diseaseStormFogColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_diseaseStormFogColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_diseaseStormFogColor, (void*)(&color));
		}
	}

	public unsafe static Color diseaseStormNightFogColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_diseaseStormNightFogColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_diseaseStormNightFogColor, (void*)(&color));
		}
	}

	public unsafe static Color undergroundFogColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_undergroundFogColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_undergroundFogColor, (void*)(&color));
		}
	}

	public unsafe static Il2CppStructArray<float3> skySHDirections
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_skySHDirections, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_skySHDirections, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int WATER_RIPPLE_COUNT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WATER_RIPPLE_COUNT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WATER_RIPPLE_COUNT, (void*)(&num));
		}
	}

	public unsafe static float DISEASE_REMOVED_AMOUNT
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DISEASE_REMOVED_AMOUNT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DISEASE_REMOVED_AMOUNT, (void*)(&num));
		}
	}

	public unsafe string initialGameVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialGameVersion);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialGameVersion)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Dictionary<int, WorldPlayer> players
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_players);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, WorldPlayer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_players)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe WorldGenerator worldGenerator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldGenerator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldGenerator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldGenerator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGenerator));
		}
	}

	public unsafe WorldCreatureConfig worldCreatureConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldCreatureConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldCreatureConfig>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldCreatureConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldCreatureConfig));
		}
	}

	public unsafe Dictionary<Coordinates, ChunkInfo> chunkInfos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkInfos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, ChunkInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkInfos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<Coordinates> bigLakeCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigLakeCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigLakeCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Coordinates> seaShoreCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaShoreCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaShoreCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Coordinates> rockyAreaCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rockyAreaCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rockyAreaCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Coordinates> villageCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villageCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villageCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Coordinates capitalCityCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capitalCityCoordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capitalCityCoordinates)) = coordinates;
		}
	}

	public unsafe Coordinates homeVillageCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homeVillageCoordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homeVillageCoordinates)) = coordinates;
		}
	}

	public unsafe Dictionary<Coordinates, SwampCenter> swamps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_swamps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, SwampCenter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_swamps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Coordinates, Village> villages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villages);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, Village>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_villages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Coordinates, SurvivorCamp> survivorCamps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_survivorCamps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, SurvivorCamp>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_survivorCamps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Coordinates, Cave> caves
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caves);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, Cave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caves)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Coordinates, List<DiseaseCenter>> diseaseCenters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseCenters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, List<DiseaseCenter>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseCenters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe DruidCamp druidCamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_druidCamp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DruidCamp>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_druidCamp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)druidCamp));
		}
	}

	public unsafe Dictionary<WorldEventType, WorldEventTriggerData> pendingWorldEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingWorldEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<WorldEventType, WorldEventTriggerData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pendingWorldEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<WorldEventType, List<TriggeredWorldEvent>> triggeredWorldEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggeredWorldEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<WorldEventType, List<TriggeredWorldEvent>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggeredWorldEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Queue<Il2CppSystem.ValueTuple<Coordinates, int, int>> queuedWaterMapChecks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedWaterMapChecks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<Il2CppSystem.ValueTuple<Coordinates, int, int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedWaterMapChecks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe HashSet<Coordinates> generatedChunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedChunkCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedChunkCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<string, List<GeneratedStructure>> generatedStructures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedStructures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, List<GeneratedStructure>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedStructures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int chunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkSize)) = num;
		}
	}

	public unsafe int regionChunkSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunkSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunkSize)) = num;
		}
	}

	public unsafe int cellSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellSize)) = num;
		}
	}

	public unsafe int cellsPerChunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellsPerChunk);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellsPerChunk)) = num;
		}
	}

	public unsafe Vector3 chunkTerrainSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkTerrainSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkTerrainSize)) = vector;
		}
	}

	public unsafe float caveChunkSizeXZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunkSizeXZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunkSizeXZ)) = num;
		}
	}

	public unsafe float caveChunkSizeY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunkSizeY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunkSizeY)) = num;
		}
	}

	public unsafe float worldTimeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTimeScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTimeScale)) = num;
		}
	}

	public unsafe float worldTimeScaleFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTimeScaleFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldTimeScaleFactor)) = num;
		}
	}

	public unsafe bool worldSleepState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSleepState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSleepState)) = flag;
		}
	}

	public unsafe float worldSleepCountdown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSleepCountdown);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSleepCountdown)) = num;
		}
	}

	public unsafe Il2CppSystem.DateTime worldDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldDateTime)) = dateTime;
		}
	}

	public unsafe Il2CppSystem.DateTime worldStartDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldStartDateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldStartDateTime)) = dateTime;
		}
	}

	public unsafe float sunAngleOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunAngleOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunAngleOffset)) = num;
		}
	}

	public unsafe WeatherState currentWeatherState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWeatherState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WeatherState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWeatherState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)weatherState));
		}
	}

	public unsafe List<WeatherStateHistory> weatherStateHistories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherStateHistories);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WeatherStateHistory>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherStateHistories)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int seed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed)) = num;
		}
	}

	public unsafe Vector2 seedOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seedOffset);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seedOffset)) = vector;
		}
	}

	public unsafe int regionChunkRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunkRadius);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunkRadius)) = num;
		}
	}

	public unsafe CustomRandom worldRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldRandom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomRandom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldRandom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customRandom));
		}
	}

	public unsafe float waterLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterLevel)) = num;
		}
	}

	public unsafe Vector3 startingPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPosition)) = vector;
		}
	}

	public unsafe Vector2 startingDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDirection);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDirection)) = vector;
		}
	}

	public unsafe Coordinates startingChunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingChunkCoordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingChunkCoordinates)) = coordinates;
		}
	}

	public unsafe Coordinates regionCenterCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionCenterCoordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionCenterCoordinates)) = coordinates;
		}
	}

	public unsafe string regionName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Vector2 seaDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaDirection);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaDirection)) = vector;
		}
	}

	public unsafe string seaName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Vector2 mainIslandLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainIslandLocation);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainIslandLocation)) = vector;
		}
	}

	public unsafe float mainIslandRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainIslandRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainIslandRadius)) = num;
		}
	}

	public unsafe string rainSubstanceIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainSubstanceIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainSubstanceIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float diseaseAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diseaseAmount)) = num;
		}
	}

	public unsafe float terrainWetness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainWetness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainWetness)) = num;
		}
	}

	public unsafe float temperature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temperature);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temperature)) = num;
		}
	}

	public unsafe float terrainSnow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainSnow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainSnow)) = num;
		}
	}

	public unsafe HashSet<string> unlockedBlueprintIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedBlueprintIdentifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedBlueprintIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<string> unlockedCraftingRecipeIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedCraftingRecipeIdentifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedCraftingRecipeIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Il2CppSystem.DateTime seasonsEffectsStartDate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seasonsEffectsStartDate);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seasonsEffectsStartDate)) = dateTime;
		}
	}

	public unsafe Dictionary<Coordinates, Task> loadChunkTasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadChunkTasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, Task>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadChunkTasks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Coordinates, EventWaitHandle> chunkWaitHandles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkWaitHandles);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, EventWaitHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkWaitHandles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Coordinates, Chunk> activeChunks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeChunks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, Chunk>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeChunks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Coordinates, RegionChunk> regionChunks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, RegionChunk>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Coordinates, List<SerializedEntity>> chunkSerializedEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkSerializedEntities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, List<SerializedEntity>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkSerializedEntities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<Coordinates> visibleChunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleChunkCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleChunkCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<Coordinates> visibleTerrainCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleTerrainCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleTerrainCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe WorldBasedQueue<Coordinates> regionChunksToGenerate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunksToGenerate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunksToGenerate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Chunk> chunksToSave
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunksToSave);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Chunk>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunksToSave)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Coordinates> regionChunksToActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunksToActivate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunksToActivate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Coordinates> regionChunksToUnload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunksToUnload);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionChunksToUnload)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Chunk> chunksToUnload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunksToUnload);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Chunk>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunksToUnload)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Entity> entitiesToDestroy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entitiesToDestroy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entitiesToDestroy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<GameObject> objectsToDestroy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsToDestroy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectsToDestroy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Chunk> generatedChunksToActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedChunksToActivate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Chunk>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedChunksToActivate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Chunk> loadedChunksToActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedChunksToActivate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Chunk>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedChunksToActivate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Chunk> networkLoadedChunksToActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkLoadedChunksToActivate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Chunk>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_networkLoadedChunksToActivate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Il2CppSystem.ValueTuple<Coordinates, int, int, int, int>> chunkSlopeDataToGenerate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkSlopeDataToGenerate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Il2CppSystem.ValueTuple<Coordinates, int, int, int, int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkSlopeDataToGenerate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Il2CppSystem.ValueTuple<Coordinates, Coordinates, bool>> queuedDetailPlacementCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedDetailPlacementCells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Il2CppSystem.ValueTuple<Coordinates, Coordinates, bool>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedDetailPlacementCells)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<SimpleObjectCreationInfo> queuedSimpleObjectCreations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedSimpleObjectCreations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<SimpleObjectCreationInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedSimpleObjectCreations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<EntityCreationInfo> queuedEntityCreations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedEntityCreations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<EntityCreationInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedEntityCreations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<SerializedEntity> queuedEntityLoads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedEntityLoads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<SerializedEntity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedEntityLoads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Entity> queuedEntityNetworkLoads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedEntityNetworkLoads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedEntityNetworkLoads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<QueuedObjectActivation> queuedEntityActivations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedEntityActivations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<QueuedObjectActivation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedEntityActivations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Il2CppSystem.ValueTuple<Chunk, Coordinates>> queuedChunkCellPostProcessing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedChunkCellPostProcessing);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Il2CppSystem.ValueTuple<Chunk, Coordinates>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedChunkCellPostProcessing)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<DetailLodCreationInfo> queuedDetailLods
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedDetailLods);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<DetailLodCreationInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedDetailLods)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Il2CppSystem.ValueTuple<Chunk, Vector3, string, int>> queuedSoundColliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedSoundColliders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Il2CppSystem.ValueTuple<Chunk, Vector3, string, int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedSoundColliders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<QueuedTexturePaint> queuedTexturePaints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTexturePaints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<QueuedTexturePaint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTexturePaints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<QueuedTextureRectanglePaint> queuedTextureRectanglePaints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTextureRectanglePaints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<QueuedTextureRectanglePaint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTextureRectanglePaints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<QueuedClearedSnowPaint> queuedClearedSnowPaints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedClearedSnowPaints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<QueuedClearedSnowPaint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedClearedSnowPaints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Coordinates> queuedPaintedChunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedPaintedChunkCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedPaintedChunkCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Coordinates> queuedClearedSnowChunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedClearedSnowChunkCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedClearedSnowChunkCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Coordinates> queuedHeightAdjustmentChunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedHeightAdjustmentChunkCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedHeightAdjustmentChunkCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Coordinates> queuedDetailMapAdjustedCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedDetailMapAdjustedCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedDetailMapAdjustedCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Il2CppSystem.ValueTuple<Coordinates, Vector3, bool>> queuedDetailMapRefresh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedDetailMapRefresh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Il2CppSystem.ValueTuple<Coordinates, Vector3, bool>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedDetailMapRefresh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe WorldBasedQueue<Il2CppSystem.ValueTuple<Coordinates, CaveChunk, Coordinates, Vector3, Quaternion, bool>> queuedCaveChunkObjectsToCreate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedCaveChunkObjectsToCreate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldBasedQueue<Il2CppSystem.ValueTuple<Coordinates, CaveChunk, Coordinates, Vector3, Quaternion, bool>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedCaveChunkObjectsToCreate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldBasedQueue));
		}
	}

	public unsafe HashSet<PhysicsBakeJobData> physicsBakeJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsBakeJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<PhysicsBakeJobData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsBakeJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Dictionary<Coordinates, List<QueuedTexturePaint>> chunkQueuedTexturePaints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkQueuedTexturePaints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, List<QueuedTexturePaint>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkQueuedTexturePaints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Coordinates, List<QueuedTextureRectanglePaint>> chunkQueuedTextureRectanglePaints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkQueuedTextureRectanglePaints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, List<QueuedTextureRectanglePaint>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkQueuedTextureRectanglePaints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<TextureType, int> textureLayerMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureLayerMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<TextureType, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureLayerMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, TextureType> layerTextureMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerTextureMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, TextureType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerTextureMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<TerrainType, int> terrainTypeIndexMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeIndexMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<TerrainType, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeIndexMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, TerrainType> indexTerrainTypeMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexTerrainTypeMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, TerrainType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexTerrainTypeMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe GameObject lightObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe ReflectionProbe outdoorReflectionProbe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outdoorReflectionProbe);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReflectionProbe>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outdoorReflectionProbe)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reflectionProbe));
		}
	}

	public unsafe ReflectionProbe undergroundReflectionProbe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_undergroundReflectionProbe);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReflectionProbe>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_undergroundReflectionProbe)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reflectionProbe));
		}
	}

	public unsafe Volume renderingVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingVolume);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Volume>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingVolume)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)volume));
		}
	}

	public unsafe GameObject snowEffectObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snowEffectObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snowEffectObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe ParticleSystem snowParticleSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snowParticleSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snowParticleSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particleSystem));
		}
	}

	public unsafe GameObject rainEffectObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainEffectObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainEffectObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe ParticleSystem rainParticleSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainParticleSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainParticleSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particleSystem));
		}
	}

	public unsafe float terrainDeadnessOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainDeadnessOverride);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainDeadnessOverride)) = num;
		}
	}

	public unsafe int targetDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetDay)) = num;
		}
	}

	public unsafe Mesh waterPlaneMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterPlaneMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterPlaneMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe Mesh caveWaterPlaneMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveWaterPlaneMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveWaterPlaneMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh));
		}
	}

	public unsafe Dictionary<string, HashSet<Entity>> componentEntityMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentEntityMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<Entity>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentEntityMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, HashSet<Entity>> identifierToEntitiesMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifierToEntitiesMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<Entity>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifierToEntitiesMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Game game
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_game);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Game>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_game)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)game));
		}
	}

	public unsafe WorldState worldState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldState);
			return *(WorldState*)num;
		}
		set
		{
			*(WorldState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldState)) = worldState;
		}
	}

	public unsafe int maxVisibleLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVisibleLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxVisibleLevel)) = num;
		}
	}

	public unsafe Substance rainSubstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainSubstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Substance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainSubstance)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substance));
		}
	}

	public unsafe float dayRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayRatio)) = num;
		}
	}

	public unsafe float nightRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightRatio)) = num;
		}
	}

	public unsafe float fogIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogIntensity)) = num;
		}
	}

	public unsafe float minViewDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minViewDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minViewDistance)) = num;
		}
	}

	public unsafe float maxViewDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxViewDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxViewDistance)) = num;
		}
	}

	public unsafe Material caveWaterMaterialTemplate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveWaterMaterialTemplate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveWaterMaterialTemplate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe HashSet<Material> waterMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterMaterials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterMaterials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<Coordinates> sessionChunkCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sessionChunkCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sessionChunkCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe RegionMapData regionMapData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionMapData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegionMapData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regionMapData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionMapData));
		}
	}

	public unsafe Dictionary<SurfaceType, List<ItemDrop>> surfaceGatherItemDropMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceGatherItemDropMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<SurfaceType, List<ItemDrop>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceGatherItemDropMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<SurfaceType, List<ItemDrop>> surfaceDigItemDropMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceDigItemDropMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<SurfaceType, List<ItemDrop>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surfaceDigItemDropMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<SurfaceType> specialGatherSurfaceTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialGatherSurfaceTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<SurfaceType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialGatherSurfaceTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe HashSet<SurfaceType> tillableSurfaceTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tillableSurfaceTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<SurfaceType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tillableSurfaceTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<Il2CppSystem.ValueTuple<float, float>> specialSurfaceTypeSearch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialSurfaceTypeSearch);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<float, float>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialSurfaceTypeSearch)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<string, TextureType> terrainItemTextureTypeMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainItemTextureTypeMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, TextureType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainItemTextureTypeMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<TextureType> alwaysExposeDirtTextureTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysExposeDirtTextureTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TextureType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysExposeDirtTextureTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<TextureType> deepExposeDirtTextureTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deepExposeDirtTextureTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TextureType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deepExposeDirtTextureTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<TextureType, float> textureExposeMaxAmounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureExposeMaxAmounts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<TextureType, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureExposeMaxAmounts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Camera, Camera> reflectedCameraMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectedCameraMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Camera, Camera>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectedCameraMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Camera, Il2CppSystem.ValueTuple<RenderTexture, RenderTexture>> cameraTextureMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraTextureMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Camera, Il2CppSystem.ValueTuple<RenderTexture, RenderTexture>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraTextureMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Camera, Camera> skyboxCameraMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyboxCameraMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Camera, Camera>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyboxCameraMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<Entity> entitiesInRangeResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entitiesInRangeResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entitiesInRangeResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int waterReflectionQualityLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterReflectionQualityLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterReflectionQualityLevel)) = num;
		}
	}

	public unsafe bool isReflectionRenderInProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReflectionRenderInProgress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReflectionRenderInProgress)) = flag;
		}
	}

	public unsafe UniversalRenderPipelineAsset reflectionPipelineAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionPipelineAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionPipelineAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)universalRenderPipelineAsset));
		}
	}

	public unsafe Il2CppStructArray<Vector4> waterRipples
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterRipples);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterRipples)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int currentWaterRippleIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWaterRippleIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWaterRippleIndex)) = num;
		}
	}

	public unsafe List<Coordinates> nearbyCoordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearbyCoordinates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearbyCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int numEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numEntities);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numEntities)) = num;
		}
	}

	public unsafe int numNetworkedEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numNetworkedEntities);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numNetworkedEntities)) = num;
		}
	}

	public unsafe int reflectionProbeRenderId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbeRenderId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbeRenderId)) = num;
		}
	}

	public unsafe float lastReflectionProbeFinishTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastReflectionProbeFinishTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastReflectionProbeFinishTime)) = num;
		}
	}

	public unsafe Dictionary<string, List<InstancedEntityLOD>> instancedEntityLODs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancedEntityLODs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, List<InstancedEntityLOD>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancedEntityLODs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<Material, InstancedMaterialData> instancedEntityProperties
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancedEntityProperties);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Material, InstancedMaterialData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancedEntityProperties)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe float caveClippingRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveClippingRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveClippingRange)) = num;
		}
	}

	public unsafe AsyncOperation activeNavMeshOperation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeNavMeshOperation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeNavMeshOperation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncOperation));
		}
	}

	public unsafe AsyncOperation activeTerrainNavMeshOperation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeTerrainNavMeshOperation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeTerrainNavMeshOperation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncOperation));
		}
	}

	public unsafe Queue<Coordinates> queuedTerrainNavMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTerrainNavMeshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<Coordinates>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedTerrainNavMeshes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe NavMeshData navMeshData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NavMeshData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)navMeshData));
		}
	}

	public unsafe bool queuedNavMeshUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedNavMeshUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queuedNavMeshUpdate)) = flag;
		}
	}

	public unsafe NavMeshBuildSettings navMeshBuildSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshBuildSettings);
			return *(NavMeshBuildSettings*)num;
		}
		set
		{
			*(NavMeshBuildSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshBuildSettings)) = navMeshBuildSettings;
		}
	}

	public unsafe List<NavMeshBuildSource> navMeshSources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshSources);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NavMeshBuildSource>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_navMeshSources)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Il2CppStructArray<RaycastHit> caveRaycastHits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveRaycastHits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveRaycastHits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<Plane> cameraFrustumPlanes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraFrustumPlanes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraFrustumPlanes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Coordinates RegionCoordinatesMin
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 264403, RefRangeEnd = 264415, XrefRangeStart = 264402, XrefRangeEnd = 264403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RegionCoordinatesMin_Public_get_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Coordinates RegionCoordinatesMax
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 264416, RefRangeEnd = 264426, XrefRangeStart = 264415, XrefRangeEnd = 264416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RegionCoordinatesMax_Public_get_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe Village HomeVillage
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264912, RefRangeEnd = 264914, XrefRangeStart = 264908, XrefRangeEnd = 264912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HomeVillage_Public_get_Village_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Village>(intPtr) : null;
		}
	}

	public unsafe Village CapitalCity
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264914, XrefRangeEnd = 264918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CapitalCity_Public_get_Village_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Village>(intPtr) : null;
		}
	}

	public unsafe bool UndergroundVisible
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 267866, RefRangeEnd = 267874, XrefRangeStart = 267866, XrefRangeEnd = 267866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UndergroundVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool OutdoorVisible
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 267874, RefRangeEnd = 267889, XrefRangeStart = 267874, XrefRangeEnd = 267874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OutdoorVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static World()
	{
		Il2CppClassPointerStore<World>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "World");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<World>.NativeClassPtr);
		NativeFieldInfoPtr_regionChunkDataPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionChunkDataPool");
		NativeFieldInfoPtr_regionChunkPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionChunkPool");
		NativeFieldInfoPtr_regionTerrainPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionTerrainPool");
		NativeFieldInfoPtr_chunkDataPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunkDataPool");
		NativeFieldInfoPtr_chunkMapTexturePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunkMapTexturePool");
		NativeFieldInfoPtr_takenPositionsPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "takenPositionsPool");
		NativeFieldInfoPtr_componentEntityMapPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "componentEntityMapPool");
		NativeFieldInfoPtr_identifierToEntitiesMapPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "identifierToEntitiesMapPool");
		NativeFieldInfoPtr_slopeDataPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "slopeDataPool");
		NativeFieldInfoPtr_holeMapPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "holeMapPool");
		NativeFieldInfoPtr_caveDataPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "caveDataPool");
		NativeFieldInfoPtr_BASE_TIME_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "BASE_TIME_SCALE");
		NativeFieldInfoPtr_SLEEPING_STATE_TIME_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "SLEEPING_STATE_TIME_SCALE");
		NativeFieldInfoPtr_WEATHER_STATE_DURATION_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "WEATHER_STATE_DURATION_MIN");
		NativeFieldInfoPtr_WEATHER_STATE_DURATION_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "WEATHER_STATE_DURATION_MAX");
		NativeFieldInfoPtr_WEATHER_STATE_PREVENT_REPEAT_RAIN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "WEATHER_STATE_PREVENT_REPEAT_RAIN_TIME");
		NativeFieldInfoPtr_SNOW_MAX_TEMPERATURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "SNOW_MAX_TEMPERATURE");
		NativeFieldInfoPtr_DEFAULT_CHUNK_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "DEFAULT_CHUNK_SIZE");
		NativeFieldInfoPtr_DEFAULT_CELL_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "DEFAULT_CELL_SIZE");
		NativeFieldInfoPtr_DEFAULT_TERRAIN_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "DEFAULT_TERRAIN_HEIGHT");
		NativeFieldInfoPtr_DEFAULT_CAVE_CHUNK_SIZE_XZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "DEFAULT_CAVE_CHUNK_SIZE_XZ");
		NativeFieldInfoPtr_DEFAULT_CAVE_CHUNK_SIZE_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "DEFAULT_CAVE_CHUNK_SIZE_Y");
		NativeFieldInfoPtr_DEFAULT_WORLD_YEAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "DEFAULT_WORLD_YEAR");
		NativeFieldInfoPtr_noon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "noon");
		NativeFieldInfoPtr_midnight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "midnight");
		NativeFieldInfoPtr_sunHorizonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "sunHorizonColor");
		NativeFieldInfoPtr_sunNormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "sunNormalColor");
		NativeFieldInfoPtr_dayAmbientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "dayAmbientColor");
		NativeFieldInfoPtr_goldenHourAmbientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "goldenHourAmbientColor");
		NativeFieldInfoPtr_nightAmbientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "nightAmbientColor");
		NativeFieldInfoPtr_dayFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "dayFogColor");
		NativeFieldInfoPtr_goldenHourFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "goldenHourFogColor");
		NativeFieldInfoPtr_postSunsetFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "postSunsetFogColor");
		NativeFieldInfoPtr_nightFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "nightFogColor");
		NativeFieldInfoPtr_diseaseStormFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "diseaseStormFogColor");
		NativeFieldInfoPtr_diseaseStormNightFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "diseaseStormNightFogColor");
		NativeFieldInfoPtr_undergroundFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "undergroundFogColor");
		NativeFieldInfoPtr_skySHDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "skySHDirections");
		NativeFieldInfoPtr_WATER_RIPPLE_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "WATER_RIPPLE_COUNT");
		NativeFieldInfoPtr_DISEASE_REMOVED_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "DISEASE_REMOVED_AMOUNT");
		NativeFieldInfoPtr_initialGameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "initialGameVersion");
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "name");
		NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "players");
		NativeFieldInfoPtr_worldGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "worldGenerator");
		NativeFieldInfoPtr_worldCreatureConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "worldCreatureConfig");
		NativeFieldInfoPtr_chunkInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunkInfos");
		NativeFieldInfoPtr_bigLakeCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "bigLakeCoordinates");
		NativeFieldInfoPtr_seaShoreCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "seaShoreCoordinates");
		NativeFieldInfoPtr_rockyAreaCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "rockyAreaCoordinates");
		NativeFieldInfoPtr_villageCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "villageCoordinates");
		NativeFieldInfoPtr_capitalCityCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "capitalCityCoordinates");
		NativeFieldInfoPtr_homeVillageCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "homeVillageCoordinates");
		NativeFieldInfoPtr_swamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "swamps");
		NativeFieldInfoPtr_villages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "villages");
		NativeFieldInfoPtr_survivorCamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "survivorCamps");
		NativeFieldInfoPtr_caves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "caves");
		NativeFieldInfoPtr_diseaseCenters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "diseaseCenters");
		NativeFieldInfoPtr_druidCamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "druidCamp");
		NativeFieldInfoPtr_pendingWorldEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "pendingWorldEvents");
		NativeFieldInfoPtr_triggeredWorldEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "triggeredWorldEvents");
		NativeFieldInfoPtr_queuedWaterMapChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedWaterMapChecks");
		NativeFieldInfoPtr_generatedChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "generatedChunkCoordinates");
		NativeFieldInfoPtr_generatedStructures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "generatedStructures");
		NativeFieldInfoPtr_chunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunkSize");
		NativeFieldInfoPtr_regionChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionChunkSize");
		NativeFieldInfoPtr_cellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "cellSize");
		NativeFieldInfoPtr_cellsPerChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "cellsPerChunk");
		NativeFieldInfoPtr_chunkTerrainSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunkTerrainSize");
		NativeFieldInfoPtr_caveChunkSizeXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "caveChunkSizeXZ");
		NativeFieldInfoPtr_caveChunkSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "caveChunkSizeY");
		NativeFieldInfoPtr_worldTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "worldTimeScale");
		NativeFieldInfoPtr_worldTimeScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "worldTimeScaleFactor");
		NativeFieldInfoPtr_worldSleepState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "worldSleepState");
		NativeFieldInfoPtr_worldSleepCountdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "worldSleepCountdown");
		NativeFieldInfoPtr_worldDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "worldDateTime");
		NativeFieldInfoPtr_worldStartDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "worldStartDateTime");
		NativeFieldInfoPtr_sunAngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "sunAngleOffset");
		NativeFieldInfoPtr_currentWeatherState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "currentWeatherState");
		NativeFieldInfoPtr_weatherStateHistories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "weatherStateHistories");
		NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "seed");
		NativeFieldInfoPtr_seedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "seedOffset");
		NativeFieldInfoPtr_regionChunkRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionChunkRadius");
		NativeFieldInfoPtr_worldRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "worldRandom");
		NativeFieldInfoPtr_waterLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "waterLevel");
		NativeFieldInfoPtr_startingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "startingPosition");
		NativeFieldInfoPtr_startingDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "startingDirection");
		NativeFieldInfoPtr_startingChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "startingChunkCoordinates");
		NativeFieldInfoPtr_regionCenterCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionCenterCoordinates");
		NativeFieldInfoPtr_regionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionName");
		NativeFieldInfoPtr_seaDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "seaDirection");
		NativeFieldInfoPtr_seaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "seaName");
		NativeFieldInfoPtr_mainIslandLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "mainIslandLocation");
		NativeFieldInfoPtr_mainIslandRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "mainIslandRadius");
		NativeFieldInfoPtr_rainSubstanceIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "rainSubstanceIdentifier");
		NativeFieldInfoPtr_diseaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "diseaseAmount");
		NativeFieldInfoPtr_terrainWetness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "terrainWetness");
		NativeFieldInfoPtr_temperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "temperature");
		NativeFieldInfoPtr_terrainSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "terrainSnow");
		NativeFieldInfoPtr_unlockedBlueprintIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "unlockedBlueprintIdentifiers");
		NativeFieldInfoPtr_unlockedCraftingRecipeIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "unlockedCraftingRecipeIdentifiers");
		NativeFieldInfoPtr_seasonsEffectsStartDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "seasonsEffectsStartDate");
		NativeFieldInfoPtr_loadChunkTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "loadChunkTasks");
		NativeFieldInfoPtr_chunkWaitHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunkWaitHandles");
		NativeFieldInfoPtr_activeChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "activeChunks");
		NativeFieldInfoPtr_regionChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionChunks");
		NativeFieldInfoPtr_chunkSerializedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunkSerializedEntities");
		NativeFieldInfoPtr_visibleChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "visibleChunkCoordinates");
		NativeFieldInfoPtr_visibleTerrainCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "visibleTerrainCoordinates");
		NativeFieldInfoPtr_regionChunksToGenerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionChunksToGenerate");
		NativeFieldInfoPtr_chunksToSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunksToSave");
		NativeFieldInfoPtr_regionChunksToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionChunksToActivate");
		NativeFieldInfoPtr_regionChunksToUnload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionChunksToUnload");
		NativeFieldInfoPtr_chunksToUnload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunksToUnload");
		NativeFieldInfoPtr_entitiesToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "entitiesToDestroy");
		NativeFieldInfoPtr_objectsToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "objectsToDestroy");
		NativeFieldInfoPtr_generatedChunksToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "generatedChunksToActivate");
		NativeFieldInfoPtr_loadedChunksToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "loadedChunksToActivate");
		NativeFieldInfoPtr_networkLoadedChunksToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "networkLoadedChunksToActivate");
		NativeFieldInfoPtr_chunkSlopeDataToGenerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunkSlopeDataToGenerate");
		NativeFieldInfoPtr_queuedDetailPlacementCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedDetailPlacementCells");
		NativeFieldInfoPtr_queuedSimpleObjectCreations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedSimpleObjectCreations");
		NativeFieldInfoPtr_queuedEntityCreations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedEntityCreations");
		NativeFieldInfoPtr_queuedEntityLoads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedEntityLoads");
		NativeFieldInfoPtr_queuedEntityNetworkLoads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedEntityNetworkLoads");
		NativeFieldInfoPtr_queuedEntityActivations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedEntityActivations");
		NativeFieldInfoPtr_queuedChunkCellPostProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedChunkCellPostProcessing");
		NativeFieldInfoPtr_queuedDetailLods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedDetailLods");
		NativeFieldInfoPtr_queuedSoundColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedSoundColliders");
		NativeFieldInfoPtr_queuedTexturePaints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedTexturePaints");
		NativeFieldInfoPtr_queuedTextureRectanglePaints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedTextureRectanglePaints");
		NativeFieldInfoPtr_queuedClearedSnowPaints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedClearedSnowPaints");
		NativeFieldInfoPtr_queuedPaintedChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedPaintedChunkCoordinates");
		NativeFieldInfoPtr_queuedClearedSnowChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedClearedSnowChunkCoordinates");
		NativeFieldInfoPtr_queuedHeightAdjustmentChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedHeightAdjustmentChunkCoordinates");
		NativeFieldInfoPtr_queuedDetailMapAdjustedCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedDetailMapAdjustedCoordinates");
		NativeFieldInfoPtr_queuedDetailMapRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedDetailMapRefresh");
		NativeFieldInfoPtr_queuedCaveChunkObjectsToCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedCaveChunkObjectsToCreate");
		NativeFieldInfoPtr_physicsBakeJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "physicsBakeJobs");
		NativeFieldInfoPtr_chunkQueuedTexturePaints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunkQueuedTexturePaints");
		NativeFieldInfoPtr_chunkQueuedTextureRectanglePaints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "chunkQueuedTextureRectanglePaints");
		NativeFieldInfoPtr_textureLayerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "textureLayerMap");
		NativeFieldInfoPtr_layerTextureMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "layerTextureMap");
		NativeFieldInfoPtr_terrainTypeIndexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "terrainTypeIndexMap");
		NativeFieldInfoPtr_indexTerrainTypeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "indexTerrainTypeMap");
		NativeFieldInfoPtr_lightObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "lightObject");
		NativeFieldInfoPtr_outdoorReflectionProbe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "outdoorReflectionProbe");
		NativeFieldInfoPtr_undergroundReflectionProbe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "undergroundReflectionProbe");
		NativeFieldInfoPtr_renderingVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "renderingVolume");
		NativeFieldInfoPtr_snowEffectObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "snowEffectObject");
		NativeFieldInfoPtr_snowParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "snowParticleSystem");
		NativeFieldInfoPtr_rainEffectObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "rainEffectObject");
		NativeFieldInfoPtr_rainParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "rainParticleSystem");
		NativeFieldInfoPtr_terrainDeadnessOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "terrainDeadnessOverride");
		NativeFieldInfoPtr_targetDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "targetDay");
		NativeFieldInfoPtr_waterPlaneMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "waterPlaneMesh");
		NativeFieldInfoPtr_caveWaterPlaneMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "caveWaterPlaneMesh");
		NativeFieldInfoPtr_componentEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "componentEntityMap");
		NativeFieldInfoPtr_identifierToEntitiesMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "identifierToEntitiesMap");
		NativeFieldInfoPtr_game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "game");
		NativeFieldInfoPtr_worldState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "worldState");
		NativeFieldInfoPtr_maxVisibleLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "maxVisibleLevel");
		NativeFieldInfoPtr_rainSubstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "rainSubstance");
		NativeFieldInfoPtr_dayRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "dayRatio");
		NativeFieldInfoPtr_nightRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "nightRatio");
		NativeFieldInfoPtr_fogIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "fogIntensity");
		NativeFieldInfoPtr_minViewDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "minViewDistance");
		NativeFieldInfoPtr_maxViewDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "maxViewDistance");
		NativeFieldInfoPtr_caveWaterMaterialTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "caveWaterMaterialTemplate");
		NativeFieldInfoPtr_waterMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "waterMaterials");
		NativeFieldInfoPtr_sessionChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "sessionChunkCoordinates");
		NativeFieldInfoPtr_regionMapData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "regionMapData");
		NativeFieldInfoPtr_surfaceGatherItemDropMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "surfaceGatherItemDropMap");
		NativeFieldInfoPtr_surfaceDigItemDropMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "surfaceDigItemDropMap");
		NativeFieldInfoPtr_specialGatherSurfaceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "specialGatherSurfaceTypes");
		NativeFieldInfoPtr_tillableSurfaceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "tillableSurfaceTypes");
		NativeFieldInfoPtr_specialSurfaceTypeSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "specialSurfaceTypeSearch");
		NativeFieldInfoPtr_terrainItemTextureTypeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "terrainItemTextureTypeMap");
		NativeFieldInfoPtr_alwaysExposeDirtTextureTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "alwaysExposeDirtTextureTypes");
		NativeFieldInfoPtr_deepExposeDirtTextureTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "deepExposeDirtTextureTypes");
		NativeFieldInfoPtr_textureExposeMaxAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "textureExposeMaxAmounts");
		NativeFieldInfoPtr_reflectedCameraMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "reflectedCameraMap");
		NativeFieldInfoPtr_cameraTextureMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "cameraTextureMap");
		NativeFieldInfoPtr_skyboxCameraMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "skyboxCameraMap");
		NativeFieldInfoPtr_entitiesInRangeResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "entitiesInRangeResult");
		NativeFieldInfoPtr_waterReflectionQualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "waterReflectionQualityLevel");
		NativeFieldInfoPtr_isReflectionRenderInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "isReflectionRenderInProgress");
		NativeFieldInfoPtr_reflectionPipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "reflectionPipelineAsset");
		NativeFieldInfoPtr_waterRipples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "waterRipples");
		NativeFieldInfoPtr_currentWaterRippleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "currentWaterRippleIndex");
		NativeFieldInfoPtr_nearbyCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "nearbyCoordinates");
		NativeFieldInfoPtr_numEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "numEntities");
		NativeFieldInfoPtr_numNetworkedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "numNetworkedEntities");
		NativeFieldInfoPtr_reflectionProbeRenderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "reflectionProbeRenderId");
		NativeFieldInfoPtr_lastReflectionProbeFinishTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "lastReflectionProbeFinishTime");
		NativeFieldInfoPtr_instancedEntityLODs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "instancedEntityLODs");
		NativeFieldInfoPtr_instancedEntityProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "instancedEntityProperties");
		NativeFieldInfoPtr_caveClippingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "caveClippingRange");
		NativeFieldInfoPtr_activeNavMeshOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "activeNavMeshOperation");
		NativeFieldInfoPtr_activeTerrainNavMeshOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "activeTerrainNavMeshOperation");
		NativeFieldInfoPtr_queuedTerrainNavMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedTerrainNavMeshes");
		NativeFieldInfoPtr_navMeshData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "navMeshData");
		NativeFieldInfoPtr_queuedNavMeshUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "queuedNavMeshUpdate");
		NativeFieldInfoPtr_navMeshBuildSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "navMeshBuildSettings");
		NativeFieldInfoPtr_navMeshSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "navMeshSources");
		NativeFieldInfoPtr_caveRaycastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "caveRaycastHits");
		NativeFieldInfoPtr_cameraFrustumPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<World>.NativeClassPtr, "cameraFrustumPlanes");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683392);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683393);
		NativeMethodInfoPtr_init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683394);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683395);
		NativeMethodInfoPtr_NetworkedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683396);
		NativeMethodInfoPtr_Update_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683397);
		NativeMethodInfoPtr_handleNewDay_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683398);
		NativeMethodInfoPtr_updateSpawnData_Private_Void_List_1_CreatureSpawnData_String_Action_1_CreatureSpawnData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683399);
		NativeMethodInfoPtr_removeSpawnData_Private_Void_List_1_CreatureSpawnData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683400);
		NativeMethodInfoPtr_handleWeather_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683401);
		NativeMethodInfoPtr_handleLighting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683402);
		NativeMethodInfoPtr_GenerateCloudTextureData_Public_Void_Il2CppStructArray_1_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683403);
		NativeMethodInfoPtr_doChunkUpdates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683404);
		NativeMethodInfoPtr_handleDiseaseInfection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683405);
		NativeMethodInfoPtr_handleToxicSmoke_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683406);
		NativeMethodInfoPtr_handleVisibleChunkCells_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683407);
		NativeMethodInfoPtr_showVisibleCells_Private_Void_Chunk_Coordinates_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683408);
		NativeMethodInfoPtr_setCellCulling_Private_Void_Coordinates_Coordinates_CellCulling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683409);
		NativeMethodInfoPtr_handlePhysicsChunkCells_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683410);
		NativeMethodInfoPtr_trackPhysicsCells_Private_Void_Chunk_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683411);
		NativeMethodInfoPtr_trackPhysicsCell_Private_Void_Chunk_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683412);
		NativeMethodInfoPtr_handleChunkCulling_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683413);
		NativeMethodInfoPtr_handleWaterUpdates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683414);
		NativeMethodInfoPtr_updateWater_Private_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683415);
		NativeMethodInfoPtr_doMaterialUpdates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683416);
		NativeMethodInfoPtr_doQueuedPaintUpdates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683417);
		NativeMethodInfoPtr_UpdateNavMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683418);
		NativeMethodInfoPtr_addNavMeshSource_Private_Void_BoxCollider_List_1_NavMeshBuildSource_byref_Bounds_Vector3_NavMeshBuildSourceShape_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683419);
		NativeMethodInfoPtr_addNavMeshSource_Private_Void_TerrainCollider_Terrain_List_1_NavMeshBuildSource_byref_Bounds_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683420);
		NativeMethodInfoPtr_addNavMeshSource_Private_Void_MeshCollider_List_1_NavMeshBuildSource_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683421);
		NativeMethodInfoPtr_get_RegionCoordinatesMin_Public_get_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683422);
		NativeMethodInfoPtr_get_RegionCoordinatesMax_Public_get_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683423);
		NativeMethodInfoPtr_AreCoordinatesInRegion_Public_Boolean_Coordinates_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683424);
		NativeMethodInfoPtr_GetRandomCoordinatesInRegion_Public_Coordinates_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683425);
		NativeMethodInfoPtr_CreateWaterRipple_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683426);
		NativeMethodInfoPtr_GetTerrainDeepness_Public_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683427);
		NativeMethodInfoPtr_GetTerrainSteepness_Public_Single_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683428);
		NativeMethodInfoPtr_DigTerrain_Public_Void_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683429);
		NativeMethodInfoPtr_AdjustTerrain_Public_Void_TerrainPoint_Single_List_1_TerrainAdjustmentInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683430);
		NativeMethodInfoPtr_PlaceTerrain_Public_Single_Vector3_InventoryItem_Single_Single_List_1_TerrainAdjustmentInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683431);
		NativeMethodInfoPtr_SmoothTerrain_Public_Void_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683432);
		NativeMethodInfoPtr_LevelTerrain_Public_Void_Vector3_Single_Single_Single_List_1_TerrainAdjustmentInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683433);
		NativeMethodInfoPtr_paintDirtForTerrainAdjustments_Private_Void_List_1_TerrainAdjustmentInfo_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683434);
		NativeMethodInfoPtr_paintDirtForPosition_Private_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683435);
		NativeMethodInfoPtr_adjustTerrainHeight_Private_Single_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_List_1_TextureType_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683436);
		NativeMethodInfoPtr_adjustTerrainHeight_Private_Single_TerrainPoint_Single_List_1_TerrainAdjustmentInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683437);
		NativeMethodInfoPtr_smoothTerrain_Private_Single_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_List_1_TextureType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683438);
		NativeMethodInfoPtr_levelTerrain_Private_Single_Vector3_Single_Single_Single_List_1_TerrainAdjustmentInfo_List_1_TextureType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683439);
		NativeMethodInfoPtr_TillSoil_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683440);
		NativeMethodInfoPtr_GetTerrainPoint_Public_TerrainPoint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683441);
		NativeMethodInfoPtr_GetTerrainPointsWithinBounds_Public_Void_List_1_Vector3_List_1_TerrainPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683442);
		NativeMethodInfoPtr_GetTerrainPointCollisions_Public_Void_List_1_TerrainPoint_GameObject_List_1_ValueTuple_2_TerrainPoint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683443);
		NativeMethodInfoPtr_GetChunkInfo_Public_ChunkInfo_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683444);
		NativeMethodInfoPtr_get_HomeVillage_Public_get_Village_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683445);
		NativeMethodInfoPtr_get_CapitalCity_Public_get_Village_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683446);
		NativeMethodInfoPtr_GetVillage_Public_Village_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683447);
		NativeMethodInfoPtr_GetChunkCoordinatesForRegionPosition_Public_Coordinates_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683448);
		NativeMethodInfoPtr_GetRegionChunkCoordinates_Public_Coordinates_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683449);
		NativeMethodInfoPtr_GetRegionChunk_Public_RegionChunk_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683450);
		NativeMethodInfoPtr_GetActiveRegionChunks_Public_ICollection_1_RegionChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683451);
		NativeMethodInfoPtr_AddRegionChunk_Public_Void_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683452);
		NativeMethodInfoPtr_RemoveRegionChunk_Public_Void_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683453);
		NativeMethodInfoPtr_GetChunkLoadTask_Public_Task_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683454);
		NativeMethodInfoPtr_StartLoadingChunk_Public_Void_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683455);
		NativeMethodInfoPtr_GetChunk_Public_Chunk_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683456);
		NativeMethodInfoPtr_GetChunk_Public_Chunk_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683457);
		NativeMethodInfoPtr_GetChunkCoordinates_Public_Coordinates_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683458);
		NativeMethodInfoPtr_GetChunkCoordinates_Public_Coordinates_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683459);
		NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683460);
		NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Coordinates_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683461);
		NativeMethodInfoPtr_GetChunkCellCoordinates_Public_ChunkCellCoordinates_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683462);
		NativeMethodInfoPtr_GetCaveOriginChunk_Public_Chunk_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683463);
		NativeMethodInfoPtr_AreCoordinatesGenerated_Public_Boolean_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683464);
		NativeMethodInfoPtr_GetAllGeneratedChunkCoordinates_Public_HashSet_1_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683465);
		NativeMethodInfoPtr_AddGeneratedChunk_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683466);
		NativeMethodInfoPtr_RemoveGeneratedChunk_Public_Void_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683467);
		NativeMethodInfoPtr_ActivateChunk_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683468);
		NativeMethodInfoPtr_RemoveChunk_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683469);
		NativeMethodInfoPtr_ClearChunkWaitTasks_Public_Void_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683470);
		NativeMethodInfoPtr_IsChunkActive_Public_Boolean_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683471);
		NativeMethodInfoPtr_GetActiveChunks_Public_ValueCollection_Coordinates_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683472);
		NativeMethodInfoPtr_GetNumStructuresGenerated_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683473);
		NativeMethodInfoPtr_GetNumStructuresGenerated_Public_Int32_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683474);
		NativeMethodInfoPtr_AnyStructuresNearby_Public_Boolean_Coordinates_Single_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683475);
		NativeMethodInfoPtr_AddGeneratedStructure_Public_Void_String_Coordinates_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683476);
		NativeMethodInfoPtr_GetNearbyFeature_Public_Boolean_Coordinates_Single_ChunkInfoFeatureType_byref_ChunkInfoFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683477);
		NativeMethodInfoPtr_IsFeatureNearby_Public_Boolean_Coordinates_Single_ChunkInfoFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683478);
		NativeMethodInfoPtr_checkNearbyFeature_Private_Boolean_Int32_Int32_ChunkInfoFeatureType_byref_ChunkInfoFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683479);
		NativeMethodInfoPtr_AddSerializedEntities_Public_Void_Coordinates_List_1_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683480);
		NativeMethodInfoPtr_AddSessionChunkCoordinate_Public_Void_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683481);
		NativeMethodInfoPtr_RemoveSessionChunkCoordinate_Public_Void_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683482);
		NativeMethodInfoPtr_GetSessionChunkCoordinates_Public_HashSet_1_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683483);
		NativeMethodInfoPtr_GetChunkEntityMap_Public_Dictionary_2_Coordinates_List_1_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683484);
		NativeMethodInfoPtr_AddEntity_Public_Void_Entity_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683485);
		NativeMethodInfoPtr_RemoveEntity_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683486);
		NativeMethodInfoPtr_QueueSimpleObjectCreation_Public_Void_SimpleObjectCreationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683487);
		NativeMethodInfoPtr_QueueEntityCreation_Public_Void_EntityCreationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683488);
		NativeMethodInfoPtr_QueueEntityLoad_Public_Void_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683489);
		NativeMethodInfoPtr_QueueNetworkEntityLoad_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683490);
		NativeMethodInfoPtr_QueueEntityActivation_Public_Void_Chunk_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683491);
		NativeMethodInfoPtr_QueueDetailObjectLod_Public_Void_DetailLodCreationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683492);
		NativeMethodInfoPtr_QueueSoundCollider_Public_Void_Chunk_Vector3_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683493);
		NativeMethodInfoPtr_GetAllPlayerEntities_Public_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683494);
		NativeMethodInfoPtr_GetEntitiesWithComponent_Public_HashSet_1_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683495);
		NativeMethodInfoPtr_GetEntitiesWithIdentifier_Public_HashSet_1_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683496);
		NativeMethodInfoPtr_GetSlope_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683497);
		NativeMethodInfoPtr_GetSlopeMagnitude_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683498);
		NativeMethodInfoPtr_GetRotationOnTerrain_Public_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683499);
		NativeMethodInfoPtr_GetChunkCenterPosition_Public_Vector2_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683500);
		NativeMethodInfoPtr_GetChunkCenterPosition3_Public_Vector3_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683501);
		NativeMethodInfoPtr_GetChunkPosition_Public_Vector3_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683502);
		NativeMethodInfoPtr_GetTerrainOriginalHeight_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683503);
		NativeMethodInfoPtr_GetTerrainHeight_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683504);
		NativeMethodInfoPtr_GetTerrainHeight_Public_Single_TerrainPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683505);
		NativeMethodInfoPtr_GetHeightmapDetails_Public_Boolean_Coordinates_Int32_Int32_Int32_byref_Chunk_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683506);
		NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683507);
		NativeMethodInfoPtr_GetPositionInCave_Public_Vector3_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683508);
		NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_TerrainPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683509);
		NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683510);
		NativeMethodInfoPtr_GetPositionOnTerrainAndCave_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683511);
		NativeMethodInfoPtr_GetPositionOnTerrainAndWater_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683512);
		NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683513);
		NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683514);
		NativeMethodInfoPtr_GetCaveChunk_Public_CaveChunk_CaveData_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683515);
		NativeMethodInfoPtr_GetCaveData_Public_Boolean_Vector3_byref_CaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683516);
		NativeMethodInfoPtr_IsInCave_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683517);
		NativeMethodInfoPtr_ChunkContainsCaveEntrance_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683518);
		NativeMethodInfoPtr_GetCaveChunkVoxelCoordinates_Public_Boolean_Vector3_byref_CaveChunk_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683519);
		NativeMethodInfoPtr_GetPositionOnCaveFloor_Public_Boolean_Vector3_byref_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683520);
		NativeMethodInfoPtr_GetPositionOnCaveFloor_Public_Boolean_Vector3_Vector2_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683521);
		NativeMethodInfoPtr_GetPositionOnCaveFloor_Public_Boolean_Vector3_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683522);
		NativeMethodInfoPtr_IsTerrainPositionUnderWater_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683523);
		NativeMethodInfoPtr_IsCavePositionUnderWater_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683524);
		NativeMethodInfoPtr_GetMainIslandDistance_Public_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683525);
		NativeMethodInfoPtr_GetMainIslandAmount_Public_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683526);
		NativeMethodInfoPtr_GetWaterWaves_Public_Void_Vector3_byref_Vector4_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683527);
		NativeMethodInfoPtr_GetWaterHeight_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683528);
		NativeMethodInfoPtr_GetWaterHeightOffset_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683529);
		NativeMethodInfoPtr_GetWaterForceDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683530);
		NativeMethodInfoPtr_GetTerrainWetness_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683531);
		NativeMethodInfoPtr_IsSolidObjectTakenPosition_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683532);
		NativeMethodInfoPtr_GetGatherItemDropsAtPosition_Public_List_1_ItemDrop_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683533);
		NativeMethodInfoPtr_GetDigItemDropsAtPosition_Public_List_1_ItemDrop_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683534);
		NativeMethodInfoPtr_GetDigItemDropsForTexture_Public_List_1_ItemDrop_TextureType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683535);
		NativeMethodInfoPtr_GetTextureTypeAmountAtPosition_Public_Single_Vector3_TextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683536);
		NativeMethodInfoPtr_GetTextureTypeAtPosition_Public_TextureType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683537);
		NativeMethodInfoPtr_GetTextureTypeAtCavePosition_Public_TextureType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683538);
		NativeMethodInfoPtr_PaintTextureTypeAtPosition_Public_Void_Vector3_TextureType_Single_Single_Single_FalloffType_List_1_TextureType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683539);
		NativeMethodInfoPtr_PaintTerrainItemTextureTypeAtPosition_Public_Void_Vector3_InventoryItem_Single_Single_Single_FalloffType_List_1_TextureType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683540);
		NativeMethodInfoPtr_ClearSnowFootstep_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683541);
		NativeMethodInfoPtr_ClearSnow_Public_Void_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683542);
		NativeMethodInfoPtr_ClearSnow_Public_Void_Vector3_Single_Single_Boolean_PaintInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683543);
		NativeMethodInfoPtr_GetClearedSnowAtPosition_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683544);
		NativeMethodInfoPtr_GetWorldDrynessAtPosition_Public_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683545);
		NativeMethodInfoPtr_GetWorldDrynessAtPosition_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683546);
		NativeMethodInfoPtr_GetTerrainTypeAtPosition_Public_TerrainType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683547);
		NativeMethodInfoPtr_GetTerrainTypeAmountAtPosition_Public_Single_Vector3_TerrainType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683548);
		NativeMethodInfoPtr_GetSurfaceTypeAtTerrainPosition_Public_SurfaceType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683549);
		NativeMethodInfoPtr_GetSurfaceNameAtPosition_Public_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683550);
		NativeMethodInfoPtr_getSurfaceType_Private_SurfaceType_TerrainType_TextureType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683551);
		NativeMethodInfoPtr_getCaveSurfaceType_Private_SurfaceType_TextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683552);
		NativeMethodInfoPtr_GetSurfaceType_Public_SurfaceType_TextureType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683553);
		NativeMethodInfoPtr_GetCaveSurfaceType_Public_SurfaceType_TextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683554);
		NativeMethodInfoPtr_GetSurfaceTypeAtCavePosition_Public_SurfaceType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683555);
		NativeMethodInfoPtr_GetDiseaseAmountAtPosition_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683556);
		NativeMethodInfoPtr_GetChunkMapDepthValue_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683557);
		NativeMethodInfoPtr_GetChunkMapDepthValue_Public_Single_Chunk_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683558);
		NativeMethodInfoPtr_GetChunkMapDepthValue_Public_Single_Chunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683559);
		NativeMethodInfoPtr_GetDiseaseCentersNearPoint_Public_Void_Vector3_Single_ICollection_1_DiseaseCenter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683560);
		NativeMethodInfoPtr_GetDiseaseCentersOnChunk_Public_Void_Chunk_ICollection_1_DiseaseCenter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683561);
		NativeMethodInfoPtr_GetDiseaseCentersNearChunk_Public_Void_Chunk_ICollection_1_DiseaseCenter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683562);
		NativeMethodInfoPtr_AddDiseaseCenter_Public_Void_DiseaseCenter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683563);
		NativeMethodInfoPtr_RemoveDiseaseCenters_Public_Void_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683564);
		NativeMethodInfoPtr_GetDiseaseRemovedAmount_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683565);
		NativeMethodInfoPtr_GetMaxTerrainHeightDelta_Public_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683566);
		NativeMethodInfoPtr_AnyObjectsNearby_Public_Boolean_Vector3_Single_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683567);
		NativeMethodInfoPtr_GetObjectsAroundPointWithComponent_Public_HashSet_1_GameObject_Vector3_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683568);
		NativeMethodInfoPtr_GetEntitiesAroundPointWithComponent_Public_Void_Vector3_Single_String_ICollection_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683569);
		NativeMethodInfoPtr_GetEntitiesAroundPointWithAllComponents_Public_Void_Vector3_Single_ICollection_1_Entity_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683570);
		NativeMethodInfoPtr_GetEntitiesAroundPointWithAnyComponents_Public_Void_Vector3_Single_ICollection_1_Entity_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683571);
		NativeMethodInfoPtr_GetEntitiesAroundPoint_Public_Void_Vector3_Single_ICollection_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683572);
		NativeMethodInfoPtr_getEntitiesAroundPoint_Private_Void_Vector3_Single_Boolean_List_1_String_ICollection_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683573);
		NativeMethodInfoPtr_getEntitiesInRange_Private_Void_Vector3_Single_ICollection_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683574);
		NativeMethodInfoPtr_GetCellCoordinatesFromCenterChunk_Public_Void_Coordinates_Coordinates_byref_Coordinates_byref_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683575);
		NativeMethodInfoPtr_GetCellCoordinatesFromCenterChunk_Public_Void_Coordinates_Int32_Int32_byref_Coordinates_byref_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683576);
		NativeMethodInfoPtr_GetNearbyTerrainLayerZones_Public_Void_Vector3_Single_List_1_TerrainLayerZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683577);
		NativeMethodInfoPtr_CheckZone_Public_Boolean_Chunk_TerrainLayerZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683578);
		NativeMethodInfoPtr_GetSurroundingChunks_Public_List_1_Chunk_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683579);
		NativeMethodInfoPtr_GetLatitude_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683580);
		NativeMethodInfoPtr_GetNextSunriseDateTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683581);
		NativeMethodInfoPtr_GetNextSunsetDateTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683582);
		NativeMethodInfoPtr_determineNextWeatherState_Private_WeatherState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683583);
		NativeMethodInfoPtr_GetWeatherStateHistoryData_Public_WeatherStateHistoryData_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683584);
		NativeMethodInfoPtr_GetWeatherStateHistoryData_Public_WeatherStateHistoryData_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683585);
		NativeMethodInfoPtr_GetPastRainTime_Public_Single_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683586);
		NativeMethodInfoPtr_GetPastRainTime_Public_Single_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683587);
		NativeMethodInfoPtr_GetPastSnowTime_Public_Single_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683588);
		NativeMethodInfoPtr_SetRainSubstance_Public_Void_Substance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683589);
		NativeMethodInfoPtr_SetWorldSleepState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683590);
		NativeMethodInfoPtr_HasWorldSleepCountdown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683591);
		NativeMethodInfoPtr_SetWorldSleepCountdown_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683592);
		NativeMethodInfoPtr_SetWorldTimeScaleFactor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683593);
		NativeMethodInfoPtr_GetWorldTimeScaledDeltaTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683594);
		NativeMethodInfoPtr_GetWorldTimeScaledDeltaTime_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683595);
		NativeMethodInfoPtr_GetBaseTimeScale_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683596);
		NativeMethodInfoPtr_IsSleepState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683597);
		NativeMethodInfoPtr_GetWeatherDateTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683598);
		NativeMethodInfoPtr_GetWorldDateTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683599);
		NativeMethodInfoPtr_GetWorldStartDateTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683600);
		NativeMethodInfoPtr_GetWorldDateTimeSeconds_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683601);
		NativeMethodInfoPtr_SetDateTime_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683602);
		NativeMethodInfoPtr_SetTime_Public_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683603);
		NativeMethodInfoPtr_SetDay_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683604);
		NativeMethodInfoPtr_GetDay_Public_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683605);
		NativeMethodInfoPtr_GetCurrentDay_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683606);
		NativeMethodInfoPtr_IsNightTime_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683607);
		NativeMethodInfoPtr_GetDayPercentage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683608);
		NativeMethodInfoPtr_GetNightPercentage_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683609);
		NativeMethodInfoPtr_GetWorldState_Public_WorldState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683610);
		NativeMethodInfoPtr_IsActiveState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683611);
		NativeMethodInfoPtr_IsUnloadedState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683612);
		NativeMethodInfoPtr_SetWorldState_Public_Void_WorldState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683613);
		NativeMethodInfoPtr_RefreshCell_Public_Void_Chunk_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683614);
		NativeMethodInfoPtr_RefreshCell_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683615);
		NativeMethodInfoPtr_GetCellBounds_Public_Void_Chunk_Vector3_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683616);
		NativeMethodInfoPtr_RefreshDetailPlacements_Public_Void_Chunk_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683617);
		NativeMethodInfoPtr_SetRainIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683618);
		NativeMethodInfoPtr_SetSnowIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683619);
		NativeMethodInfoPtr_SetCloudsPercentage_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683620);
		NativeMethodInfoPtr_SetWindIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683621);
		NativeMethodInfoPtr_SetFogIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683622);
		NativeMethodInfoPtr_SetWaterReflectionQuality_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683623);
		NativeMethodInfoPtr_SetViewDistance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683624);
		NativeMethodInfoPtr_AddWaterMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683625);
		NativeMethodInfoPtr_initializeReflectionCamera_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683626);
		NativeMethodInfoPtr_AddTriggeredWorldEvent_Public_Void_WorldEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683627);
		NativeMethodInfoPtr_IsWorldEventTriggered_Public_Boolean_WorldEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683628);
		NativeMethodInfoPtr_setupReflectionCamera_Private_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683629);
		NativeMethodInfoPtr_positionReflectionCamera_Private_Void_Camera_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683630);
		NativeMethodInfoPtr_setupSkyboxCamera_Private_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683631);
		NativeMethodInfoPtr_beginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683632);
		NativeMethodInfoPtr_handleReflectionRendering_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683633);
		NativeMethodInfoPtr_endCameraRendering_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683634);
		NativeMethodInfoPtr_renderOutdoorReflectionProbe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683635);
		NativeMethodInfoPtr_renderOutdoorReflectionProbeSlice_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683636);
		NativeMethodInfoPtr_cameraSpacePlane_Private_Vector4_Camera_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683637);
		NativeMethodInfoPtr_calculateReflectionMatrix_Private_Static_Void_byref_Matrix4x4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683638);
		NativeMethodInfoPtr_get_UndergroundVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683639);
		NativeMethodInfoPtr_get_OutdoorVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683640);
		NativeMethodInfoPtr_EnterCave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683641);
		NativeMethodInfoPtr_ExitCave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683642);
		NativeMethodInfoPtr_SchedulePhysicsBake_Public_Void_MeshCollider_Mesh_Boolean_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683643);
		NativeMethodInfoPtr_QueueNavMeshUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683644);
		NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683645);
		NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683646);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683647);
		NativeMethodInfoPtr_ApplyUpdates_Public_Void_NetworkWorldUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683648);
		NativeMethodInfoPtr_GetUpdates_Public_NetworkWorldUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683649);
		NativeMethodInfoPtr_ApplyUpdates_Public_Void_NetworkWorldCampUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683650);
		NativeMethodInfoPtr_GetCampUpdate_Public_NetworkWorldCampUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683651);
		NativeMethodInfoPtr_ApplyUpdates_Public_Void_NetworkWorldDiseaseCenterUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683652);
		NativeMethodInfoPtr_GetDiseaseCenterUpdate_Public_NetworkWorldDiseaseCenterUpdate_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<World>.NativeClassPtr, 100683653);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe World()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<World>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 261709, RefRangeEnd = 261710, XrefRangeStart = 261565, XrefRangeEnd = 261709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe World(int seed, int startMonth, Il2CppSystem.TimeSpan startTime)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<World>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&seed);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startMonth;
		*(Il2CppSystem.TimeSpan**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 262507, RefRangeEnd = 262509, XrefRangeStart = 261710, XrefRangeEnd = 262507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 262523, RefRangeEnd = 262524, XrefRangeStart = 262509, XrefRangeEnd = 262523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NetworkedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NetworkedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 262556, RefRangeEnd = 262557, XrefRangeStart = 262524, XrefRangeEnd = 262556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update(out bool newDay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref newDay);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 262719, RefRangeEnd = 262720, XrefRangeStart = 262557, XrefRangeEnd = 262719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleNewDay(int newDayNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newDayNumber);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleNewDay_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 262735, RefRangeEnd = 262738, XrefRangeStart = 262720, XrefRangeEnd = 262735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateSpawnData(List<CreatureSpawnData> spawnDatas, string identifier, Il2CppSystem.Action<CreatureSpawnData> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnDatas);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateSpawnData_Private_Void_List_1_CreatureSpawnData_String_Action_1_CreatureSpawnData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 262781, RefRangeEnd = 262783, XrefRangeStart = 262738, XrefRangeEnd = 262781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeSpawnData(List<CreatureSpawnData> spawnDatas, string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spawnDatas);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeSpawnData_Private_Void_List_1_CreatureSpawnData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 262904, RefRangeEnd = 262906, XrefRangeStart = 262783, XrefRangeEnd = 262904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleWeather(bool controlWeather = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&controlWeather);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleWeather_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 263129, RefRangeEnd = 263133, XrefRangeStart = 262906, XrefRangeEnd = 263129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleLighting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleLighting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263133, XrefRangeEnd = 263143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateCloudTextureData(Il2CppStructArray<Color> pixels, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pixels);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCloudTextureData_Public_Void_Il2CppStructArray_1_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 263161, RefRangeEnd = 263163, XrefRangeStart = 263143, XrefRangeEnd = 263161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doChunkUpdates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doChunkUpdates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 263198, RefRangeEnd = 263199, XrefRangeStart = 263163, XrefRangeEnd = 263198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleDiseaseInfection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleDiseaseInfection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 263275, RefRangeEnd = 263276, XrefRangeStart = 263199, XrefRangeEnd = 263275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleToxicSmoke()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleToxicSmoke_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 263329, RefRangeEnd = 263333, XrefRangeStart = 263276, XrefRangeEnd = 263329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleVisibleChunkCells()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleVisibleChunkCells_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 263443, RefRangeEnd = 263445, XrefRangeStart = 263333, XrefRangeEnd = 263443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void showVisibleCells(Chunk startingChunk, Coordinates playerCellCoordinates, Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startingChunk);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerCellCoordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showVisibleCells_Private_Void_Chunk_Coordinates_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 263455, RefRangeEnd = 263456, XrefRangeStart = 263445, XrefRangeEnd = 263455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setCellCulling(Coordinates chunkCoordinates, Coordinates cellCoordinates, CellCulling culling)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&chunkCoordinates);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellCoordinates;
		*(CellCulling**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &culling;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCellCulling_Private_Void_Coordinates_Coordinates_CellCulling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 263506, RefRangeEnd = 263508, XrefRangeStart = 263456, XrefRangeEnd = 263506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handlePhysicsChunkCells()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handlePhysicsChunkCells_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 263510, RefRangeEnd = 263512, XrefRangeStart = 263508, XrefRangeEnd = 263510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void trackPhysicsCells(Chunk startingChunk, Coordinates centerCellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startingChunk);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &centerCellCoordinates;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_trackPhysicsCells_Private_Void_Chunk_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 263519, RefRangeEnd = 263520, XrefRangeStart = 263512, XrefRangeEnd = 263519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void trackPhysicsCell(Chunk startingChunk, Coordinates cellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)startingChunk);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellCoordinates;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_trackPhysicsCell_Private_Void_Chunk_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 263562, RefRangeEnd = 263566, XrefRangeStart = 263520, XrefRangeEnd = 263562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleChunkCulling()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleChunkCulling_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 263638, RefRangeEnd = 263640, XrefRangeStart = 263566, XrefRangeEnd = 263638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleWaterUpdates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleWaterUpdates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 263673, RefRangeEnd = 263674, XrefRangeStart = 263640, XrefRangeEnd = 263673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateWater(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateWater_Private_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 263964, RefRangeEnd = 263966, XrefRangeStart = 263674, XrefRangeEnd = 263964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doMaterialUpdates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doMaterialUpdates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264087, RefRangeEnd = 264088, XrefRangeStart = 263966, XrefRangeEnd = 264087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doQueuedPaintUpdates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doQueuedPaintUpdates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264088, XrefRangeEnd = 264345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateNavMesh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateNavMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264345, XrefRangeEnd = 264365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addNavMeshSource(BoxCollider boxCollider, List<NavMeshBuildSource> navMeshSources, ref Bounds bounds, Vector3 offset = default(Vector3), NavMeshBuildSourceShape shape = NavMeshBuildSourceShape.Box, int area = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boxCollider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)navMeshSources);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bounds);
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(NavMeshBuildSourceShape**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shape;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &area;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addNavMeshSource_Private_Void_BoxCollider_List_1_NavMeshBuildSource_byref_Bounds_Vector3_NavMeshBuildSourceShape_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264365, XrefRangeEnd = 264383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addNavMeshSource(TerrainCollider terrainCollider, Terrain terrain, List<NavMeshBuildSource> navMeshSources, ref Bounds bounds, int area = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainCollider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrain);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)navMeshSources);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bounds);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &area;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addNavMeshSource_Private_Void_TerrainCollider_Terrain_List_1_NavMeshBuildSource_byref_Bounds_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 264400, RefRangeEnd = 264402, XrefRangeStart = 264383, XrefRangeEnd = 264400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addNavMeshSource(MeshCollider meshCollider, List<NavMeshBuildSource> navMeshSources, ref Bounds bounds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshCollider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)navMeshSources);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bounds);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addNavMeshSource_Private_Void_MeshCollider_List_1_NavMeshBuildSource_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264426, XrefRangeEnd = 264428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AreCoordinatesInRegion(Coordinates coordinates, int borderBuffer = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&coordinates);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &borderBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AreCoordinatesInRegion_Public_Boolean_Coordinates_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 264435, RefRangeEnd = 264441, XrefRangeStart = 264428, XrefRangeEnd = 264435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetRandomCoordinatesInRegion(int borderBuffer = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&borderBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomCoordinatesInRegion_Public_Coordinates_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 264441, RefRangeEnd = 264446, XrefRangeStart = 264441, XrefRangeEnd = 264441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateWaterRipple(Vector3 position, float strength = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWaterRipple_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 264447, RefRangeEnd = 264451, XrefRangeStart = 264446, XrefRangeEnd = 264447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTerrainDeepness(Vector3 position, float radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainDeepness_Public_Single_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 264467, RefRangeEnd = 264470, XrefRangeStart = 264451, XrefRangeEnd = 264467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTerrainSteepness(Vector3 position, float radius, bool upwardsOnly = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &upwardsOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainSteepness_Public_Single_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264498, RefRangeEnd = 264499, XrefRangeStart = 264470, XrefRangeEnd = 264498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DigTerrain(Vector3 position, float amount, float radius, List<TerrainAdjustmentInfo> resultAdjustments, bool avoidRocks = true, bool ignoreSolidObjectTakenPositions = false, bool paintAdjustments = false, bool avoidFurtherTerrain = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustments);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &avoidRocks;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreSolidObjectTakenPositions;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintAdjustments;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &avoidFurtherTerrain;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DigTerrain_Public_Void_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264501, RefRangeEnd = 264502, XrefRangeStart = 264499, XrefRangeEnd = 264501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustTerrain(TerrainPoint point, float amount, List<TerrainAdjustmentInfo> resultAdjustments, bool refreshDetails)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&point);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustments);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &refreshDetails;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustTerrain_Public_Void_TerrainPoint_Single_List_1_TerrainAdjustmentInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264519, RefRangeEnd = 264520, XrefRangeStart = 264502, XrefRangeEnd = 264519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float PlaceTerrain(Vector3 position, InventoryItem terrainItem, float maxAdjustment, float radius, List<TerrainAdjustmentInfo> resultAdjustments)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainItem);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxAdjustment;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustments);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaceTerrain_Public_Single_Vector3_InventoryItem_Single_Single_List_1_TerrainAdjustmentInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264538, RefRangeEnd = 264539, XrefRangeStart = 264520, XrefRangeEnd = 264538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmoothTerrain(Vector3 position, float radius, float strength, List<TerrainAdjustmentInfo> resultAdjustments, bool avoidRocks = true, bool ignoreSolidObjectTakenPositions = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustments);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &avoidRocks;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreSolidObjectTakenPositions;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothTerrain_Public_Void_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264557, RefRangeEnd = 264558, XrefRangeStart = 264539, XrefRangeEnd = 264557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LevelTerrain(Vector3 position, float height, float radius, float strength, List<TerrainAdjustmentInfo> resultAdjustments, bool avoidRocks = true, bool ignoreSolidObjectTakenPositions = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustments);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &avoidRocks;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreSolidObjectTakenPositions;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LevelTerrain_Public_Void_Vector3_Single_Single_Single_List_1_TerrainAdjustmentInfo_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 264583, RefRangeEnd = 264587, XrefRangeStart = 264558, XrefRangeEnd = 264583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintDirtForTerrainAdjustments(List<TerrainAdjustmentInfo> resultAdjustments, float maxAdjustment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustments);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxAdjustment;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintDirtForTerrainAdjustments_Private_Void_List_1_TerrainAdjustmentInfo_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264587, XrefRangeEnd = 264592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintDirtForPosition(Vector3 position, float radius, float opacity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintDirtForPosition_Private_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 264634, RefRangeEnd = 264637, XrefRangeStart = 264592, XrefRangeEnd = 264634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float adjustTerrainHeight(Vector3 position, float radius, float adjustment, List<TerrainAdjustmentInfo> resultAdjustments, List<TextureType> ignoredTextures, bool ignoreSolidObjectTakenPositions, bool avoidFurtherTerrain = true, float maxAdjustment = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &adjustment;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoredTextures);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreSolidObjectTakenPositions;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &avoidFurtherTerrain;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxAdjustment;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustTerrainHeight_Private_Single_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_List_1_TextureType_Boolean_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264678, RefRangeEnd = 264679, XrefRangeStart = 264637, XrefRangeEnd = 264678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float adjustTerrainHeight(TerrainPoint point, float adjustment, List<TerrainAdjustmentInfo> resultAdjustments, bool refreshDetails)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&point);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &adjustment;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustments);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &refreshDetails;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_adjustTerrainHeight_Private_Single_TerrainPoint_Single_List_1_TerrainAdjustmentInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264721, RefRangeEnd = 264722, XrefRangeStart = 264679, XrefRangeEnd = 264721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float smoothTerrain(Vector3 position, float radius, float strength, List<TerrainAdjustmentInfo> resultAdjustments, List<TextureType> ignoredTextures, bool ignoreSolidObjectTakenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoredTextures);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreSolidObjectTakenPositions;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_smoothTerrain_Private_Single_Vector3_Single_Single_List_1_TerrainAdjustmentInfo_List_1_TextureType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264764, RefRangeEnd = 264765, XrefRangeStart = 264722, XrefRangeEnd = 264764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float levelTerrain(Vector3 position, float height, float radius, float strength, List<TerrainAdjustmentInfo> resultAdjustments, List<TextureType> ignoredTextures, bool ignoreSolidObjectTakenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoredTextures);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreSolidObjectTakenPositions;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_levelTerrain_Private_Single_Vector3_Single_Single_Single_List_1_TerrainAdjustmentInfo_List_1_TextureType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264779, RefRangeEnd = 264780, XrefRangeStart = 264765, XrefRangeEnd = 264779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TillSoil(Vector3 position, float amount, float radius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TillSoil_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264780, XrefRangeEnd = 264786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainPoint GetTerrainPoint(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainPoint_Public_TerrainPoint_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TerrainPoint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 264830, RefRangeEnd = 264835, XrefRangeStart = 264786, XrefRangeEnd = 264830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetTerrainPointsWithinBounds(List<Vector3> boundPoints, List<TerrainPoint> resultTerrainPoints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boundPoints);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultTerrainPoints);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainPointsWithinBounds_Public_Void_List_1_Vector3_List_1_TerrainPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 264877, RefRangeEnd = 264880, XrefRangeStart = 264835, XrefRangeEnd = 264877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetTerrainPointCollisions(List<TerrainPoint> terrainPoints, GameObject gameObject, List<Il2CppSystem.ValueTuple<TerrainPoint, float>> terrainCollisions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainPoints);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainCollisions);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainPointCollisions_Public_Void_List_1_TerrainPoint_GameObject_List_1_ValueTuple_2_TerrainPoint_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 264884, RefRangeEnd = 264908, XrefRangeStart = 264880, XrefRangeEnd = 264884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkInfo GetChunkInfo(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkInfo_Public_ChunkInfo_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChunkInfo>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264918, XrefRangeEnd = 264921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Village GetVillage(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVillage_Public_Village_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Village>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264921, XrefRangeEnd = 264922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetChunkCoordinatesForRegionPosition(Vector2 relativePosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&relativePosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkCoordinatesForRegionPosition_Public_Coordinates_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 264934, RefRangeEnd = 264936, XrefRangeStart = 264922, XrefRangeEnd = 264934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetRegionChunkCoordinates(Vector3 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRegionChunkCoordinates_Public_Coordinates_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 264939, RefRangeEnd = 264943, XrefRangeStart = 264936, XrefRangeEnd = 264939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegionChunk GetRegionChunk(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRegionChunk_Public_RegionChunk_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegionChunk>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 264947, RefRangeEnd = 264949, XrefRangeStart = 264943, XrefRangeEnd = 264947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ICollection<RegionChunk> GetActiveRegionChunks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveRegionChunks_Public_ICollection_1_RegionChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<RegionChunk>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264958, RefRangeEnd = 264959, XrefRangeStart = 264949, XrefRangeEnd = 264958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddRegionChunk(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRegionChunk_Public_Void_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264963, RefRangeEnd = 264964, XrefRangeStart = 264959, XrefRangeEnd = 264963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveRegionChunk(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRegionChunk_Public_Void_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264967, RefRangeEnd = 264968, XrefRangeStart = 264964, XrefRangeEnd = 264967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task GetChunkLoadTask(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkLoadTask_Public_Task_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 264996, RefRangeEnd = 264997, XrefRangeStart = 264968, XrefRangeEnd = 264996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartLoadingChunk(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartLoadingChunk_Public_Void_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 265000, RefRangeEnd = 265054, XrefRangeStart = 264997, XrefRangeEnd = 265000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Chunk GetChunk(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunk_Public_Chunk_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Chunk>(intPtr) : null;
	}

	[CallerCount(56)]
	[CachedScanResults(RefRangeStart = 265058, RefRangeEnd = 265114, XrefRangeStart = 265054, XrefRangeEnd = 265058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Chunk GetChunk(Vector3 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunk_Public_Chunk_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Chunk>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 265126, RefRangeEnd = 265131, XrefRangeStart = 265114, XrefRangeEnd = 265126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetChunkCoordinates(Vector2 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkCoordinates_Public_Coordinates_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(91)]
	[CachedScanResults(RefRangeStart = 265143, RefRangeEnd = 265234, XrefRangeStart = 265131, XrefRangeEnd = 265143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetChunkCoordinates(Vector3 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkCoordinates_Public_Coordinates_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 265236, RefRangeEnd = 265239, XrefRangeStart = 265234, XrefRangeEnd = 265236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetCellCoordinates(Vector3 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 265259, RefRangeEnd = 265262, XrefRangeStart = 265239, XrefRangeEnd = 265259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coordinates GetCellCoordinates(Coordinates chunkCoordinates, Vector3 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&chunkCoordinates);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellCoordinates_Public_Coordinates_Coordinates_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Coordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 265265, RefRangeEnd = 265267, XrefRangeStart = 265262, XrefRangeEnd = 265265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkCellCoordinates GetChunkCellCoordinates(Vector3 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkCellCoordinates_Public_ChunkCellCoordinates_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ChunkCellCoordinates*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 265275, RefRangeEnd = 265285, XrefRangeStart = 265267, XrefRangeEnd = 265275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Chunk GetCaveOriginChunk(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaveOriginChunk_Public_Chunk_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Chunk>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 265289, RefRangeEnd = 265291, XrefRangeStart = 265285, XrefRangeEnd = 265289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AreCoordinatesGenerated(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AreCoordinatesGenerated_Public_Boolean_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 96467, RefRangeEnd = 96470, XrefRangeStart = 96467, XrefRangeEnd = 96470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Coordinates> GetAllGeneratedChunkCoordinates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllGeneratedChunkCoordinates_Public_HashSet_1_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265295, RefRangeEnd = 265296, XrefRangeStart = 265291, XrefRangeEnd = 265295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddGeneratedChunk(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGeneratedChunk_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265300, RefRangeEnd = 265301, XrefRangeStart = 265296, XrefRangeEnd = 265300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveGeneratedChunk(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveGeneratedChunk_Public_Void_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 265317, RefRangeEnd = 265320, XrefRangeStart = 265301, XrefRangeEnd = 265317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateChunk(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateChunk_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 265326, RefRangeEnd = 265330, XrefRangeStart = 265320, XrefRangeEnd = 265326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveChunk(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveChunk_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 265340, RefRangeEnd = 265343, XrefRangeStart = 265330, XrefRangeEnd = 265340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearChunkWaitTasks(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearChunkWaitTasks_Public_Void_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 265347, RefRangeEnd = 265358, XrefRangeStart = 265343, XrefRangeEnd = 265347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsChunkActive(Coordinates chunkCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&chunkCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsChunkActive_Public_Boolean_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 265362, RefRangeEnd = 265373, XrefRangeStart = 265358, XrefRangeEnd = 265362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<Coordinates, Chunk>.ValueCollection GetActiveChunks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveChunks_Public_ValueCollection_Coordinates_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, Chunk>.ValueCollection>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265373, XrefRangeEnd = 265377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNumStructuresGenerated(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumStructuresGenerated_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265377, XrefRangeEnd = 265414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNumStructuresGenerated(List<string> structureIdentifiers = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)structureIdentifiers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNumStructuresGenerated_Public_Int32_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 265488, RefRangeEnd = 265490, XrefRangeStart = 265414, XrefRangeEnd = 265488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AnyStructuresNearby(Coordinates coordinates, float chunkRange, List<string> structureIdentifiers = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&coordinates);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkRange;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)structureIdentifiers);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnyStructuresNearby_Public_Boolean_Coordinates_Single_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 265504, RefRangeEnd = 265508, XrefRangeStart = 265490, XrefRangeEnd = 265504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddGeneratedStructure(string identifier, Coordinates coordinates, Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGeneratedStructure_Public_Void_String_Coordinates_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265514, RefRangeEnd = 265515, XrefRangeStart = 265508, XrefRangeEnd = 265514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetNearbyFeature(Coordinates coordinates, float chunkRange, ChunkInfoFeatureType featureType, out ChunkInfoFeature chunkInfoFeature)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&coordinates);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkRange;
		*(ChunkInfoFeatureType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &featureType;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref chunkInfoFeature);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearbyFeature_Public_Boolean_Coordinates_Single_ChunkInfoFeatureType_byref_ChunkInfoFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265521, RefRangeEnd = 265522, XrefRangeStart = 265515, XrefRangeEnd = 265521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFeatureNearby(Coordinates coordinates, float chunkRange, ChunkInfoFeatureType featureType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&coordinates);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkRange;
		*(ChunkInfoFeatureType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &featureType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFeatureNearby_Public_Boolean_Coordinates_Single_ChunkInfoFeatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 265529, RefRangeEnd = 265537, XrefRangeStart = 265522, XrefRangeEnd = 265529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkNearbyFeature(int x, int y, ChunkInfoFeatureType featureType, out ChunkInfoFeature chunkInfoFeature)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(ChunkInfoFeatureType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &featureType;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref chunkInfoFeature);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkNearbyFeature_Private_Boolean_Int32_Int32_ChunkInfoFeatureType_byref_ChunkInfoFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265541, RefRangeEnd = 265542, XrefRangeStart = 265537, XrefRangeEnd = 265541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSerializedEntities(Coordinates coordinates, List<SerializedEntity> serializedEntities)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&coordinates);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serializedEntities);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSerializedEntities_Public_Void_Coordinates_List_1_SerializedEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265546, RefRangeEnd = 265547, XrefRangeStart = 265542, XrefRangeEnd = 265546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSessionChunkCoordinate(Coordinates chunkCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&chunkCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSessionChunkCoordinate_Public_Void_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265551, RefRangeEnd = 265552, XrefRangeStart = 265547, XrefRangeEnd = 265551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveSessionChunkCoordinate(Coordinates chunkCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&chunkCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSessionChunkCoordinate_Public_Void_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe HashSet<Coordinates> GetSessionChunkCoordinates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSessionChunkCoordinates_Public_HashSet_1_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Dictionary<Coordinates, List<SerializedEntity>> GetChunkEntityMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkEntityMap_Public_Dictionary_2_Coordinates_List_1_SerializedEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, List<SerializedEntity>>>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 265589, RefRangeEnd = 265599, XrefRangeStart = 265552, XrefRangeEnd = 265589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddEntity(Entity entity, Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEntity_Public_Void_Entity_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265630, RefRangeEnd = 265631, XrefRangeStart = 265599, XrefRangeEnd = 265630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveEntity(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveEntity_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 265634, RefRangeEnd = 265636, XrefRangeStart = 265631, XrefRangeEnd = 265634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueSimpleObjectCreation(SimpleObjectCreationInfo simpleObjectCreationInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)simpleObjectCreationInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueSimpleObjectCreation_Public_Void_SimpleObjectCreationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 265639, RefRangeEnd = 265648, XrefRangeStart = 265636, XrefRangeEnd = 265639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueEntityCreation(EntityCreationInfo entityCreationInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)entityCreationInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueEntityCreation_Public_Void_EntityCreationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265651, RefRangeEnd = 265652, XrefRangeStart = 265648, XrefRangeEnd = 265651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueEntityLoad(SerializedEntity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)entity));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueEntityLoad_Public_Void_SerializedEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265656, RefRangeEnd = 265657, XrefRangeStart = 265652, XrefRangeEnd = 265656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueNetworkEntityLoad(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueNetworkEntityLoad_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 265662, RefRangeEnd = 265665, XrefRangeStart = 265657, XrefRangeEnd = 265662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueEntityActivation(Chunk chunk, Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueEntityActivation_Public_Void_Chunk_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265668, RefRangeEnd = 265669, XrefRangeStart = 265665, XrefRangeEnd = 265668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueDetailObjectLod(DetailLodCreationInfo lodCreationInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodCreationInfo));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueDetailObjectLod_Public_Void_DetailLodCreationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265675, RefRangeEnd = 265676, XrefRangeStart = 265669, XrefRangeEnd = 265675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueSoundCollider(Chunk chunk, Vector3 position, string tag, int layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(tag);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueSoundCollider_Public_Void_Chunk_Vector3_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 265681, RefRangeEnd = 265699, XrefRangeStart = 265676, XrefRangeEnd = 265681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Entity> GetAllPlayerEntities()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllPlayerEntities_Public_HashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 265702, RefRangeEnd = 265737, XrefRangeStart = 265699, XrefRangeEnd = 265702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Entity> GetEntitiesWithComponent(string componentName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(componentName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntitiesWithComponent_Public_HashSet_1_Entity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 265740, RefRangeEnd = 265751, XrefRangeStart = 265737, XrefRangeEnd = 265740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Entity> GetEntitiesWithIdentifier(string identifier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntitiesWithIdentifier_Public_HashSet_1_Entity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265751, XrefRangeEnd = 265757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetSlope(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSlope_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 265768, RefRangeEnd = 265772, XrefRangeStart = 265757, XrefRangeEnd = 265768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSlopeMagnitude(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSlopeMagnitude_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 265780, RefRangeEnd = 265791, XrefRangeStart = 265772, XrefRangeEnd = 265780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetRotationOnTerrain(Vector3 sourcePosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sourcePosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationOnTerrain_Public_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 265791, RefRangeEnd = 265794, XrefRangeStart = 265791, XrefRangeEnd = 265791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetChunkCenterPosition(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkCenterPosition_Public_Vector2_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector3 GetChunkCenterPosition3(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkCenterPosition3_Public_Vector3_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector3 GetChunkPosition(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkPosition_Public_Vector3_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 265798, RefRangeEnd = 265801, XrefRangeStart = 265794, XrefRangeEnd = 265798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTerrainOriginalHeight(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainOriginalHeight_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 265805, RefRangeEnd = 265843, XrefRangeStart = 265801, XrefRangeEnd = 265805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTerrainHeight(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainHeight_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265843, XrefRangeEnd = 265846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTerrainHeight(TerrainPoint terrainPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&terrainPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainHeight_Public_Single_TerrainPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 265856, RefRangeEnd = 265866, XrefRangeStart = 265846, XrefRangeEnd = 265856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetHeightmapDetails(Coordinates chunkCoordinates, int heightmapResolution, int inHeightmapI, int inHeightmapJ, out Chunk chunk, out int outHeightmapI, out int outHeightmapJ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&chunkCoordinates);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapResolution;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inHeightmapI;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inHeightmapJ;
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outHeightmapI);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outHeightmapJ);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeightmapDetails_Public_Boolean_Coordinates_Int32_Int32_Int32_byref_Chunk_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		chunk = ((num3 == 0) ? null : new Chunk(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 265873, RefRangeEnd = 265880, XrefRangeStart = 265866, XrefRangeEnd = 265873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionOnTerrain(Ray ray)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ray);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265887, RefRangeEnd = 265888, XrefRangeStart = 265880, XrefRangeEnd = 265887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionInCave(Ray ray)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ray);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionInCave_Public_Vector3_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 265891, RefRangeEnd = 265893, XrefRangeStart = 265888, XrefRangeEnd = 265891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionOnTerrain(TerrainPoint terrainPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&terrainPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_TerrainPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 265899, RefRangeEnd = 265929, XrefRangeStart = 265893, XrefRangeEnd = 265899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionOnTerrain(Vector3 sourcePosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sourcePosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 265938, RefRangeEnd = 265943, XrefRangeStart = 265929, XrefRangeEnd = 265938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionOnTerrainAndCave(Vector3 sourcePosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sourcePosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnTerrainAndCave_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 265949, RefRangeEnd = 265956, XrefRangeStart = 265943, XrefRangeEnd = 265949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionOnTerrainAndWater(Vector3 sourcePosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sourcePosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnTerrainAndWater_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 265962, RefRangeEnd = 265964, XrefRangeStart = 265956, XrefRangeEnd = 265962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionOnTerrain(Vector3 sourcePosition, Vector2 delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sourcePosition);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 265970, RefRangeEnd = 265975, XrefRangeStart = 265964, XrefRangeEnd = 265970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionOnTerrain(Vector3 sourcePosition, Vector3 delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sourcePosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnTerrain_Public_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265975, XrefRangeEnd = 265993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaveChunk GetCaveChunk(CaveData caveData, Vector3 localPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveData);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &localPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaveChunk_Public_CaveChunk_CaveData_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CaveChunk>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265993, XrefRangeEnd = 265996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetCaveData(Vector3 position, out CaveData caveData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaveData_Public_Boolean_Vector3_byref_CaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		caveData = ((num3 == 0) ? null : new CaveData(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 265997, RefRangeEnd = 265998, XrefRangeStart = 265996, XrefRangeEnd = 265997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsInCave(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInCave_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 266002, RefRangeEnd = 266004, XrefRangeStart = 265998, XrefRangeEnd = 266002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ChunkContainsCaveEntrance(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChunkContainsCaveEntrance_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 266033, RefRangeEnd = 266038, XrefRangeStart = 266004, XrefRangeEnd = 266033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetCaveChunkVoxelCoordinates(Vector3 position, out CaveChunk caveChunk, out Vector3Int vCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref vCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaveChunkVoxelCoordinates_Public_Boolean_Vector3_byref_CaveChunk_byref_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		caveChunk = ((num3 == 0) ? null : new CaveChunk(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 266054, RefRangeEnd = 266068, XrefRangeStart = 266038, XrefRangeEnd = 266054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetPositionOnCaveFloor(Vector3 sourcePosition, out Vector3 caveFloorPosition, bool highestLevel = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&sourcePosition);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref caveFloorPosition);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &highestLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnCaveFloor_Public_Boolean_Vector3_byref_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266068, XrefRangeEnd = 266069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetPositionOnCaveFloor(Vector3 sourcePosition, Vector2 delta, out Vector3 caveFloorPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&sourcePosition);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref caveFloorPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnCaveFloor_Public_Boolean_Vector3_Vector2_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266070, RefRangeEnd = 266071, XrefRangeStart = 266069, XrefRangeEnd = 266070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetPositionOnCaveFloor(Vector3 sourcePosition, Vector3 delta, out Vector3 caveFloorPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&sourcePosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delta;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref caveFloorPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionOnCaveFloor_Public_Boolean_Vector3_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 266089, RefRangeEnd = 266098, XrefRangeStart = 266071, XrefRangeEnd = 266089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsTerrainPositionUnderWater(Vector3 position, float amountUnderwater = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &amountUnderwater;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTerrainPositionUnderWater_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266098, XrefRangeEnd = 266099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCavePositionUnderWater(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCavePositionUnderWater_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266103, RefRangeEnd = 266104, XrefRangeStart = 266099, XrefRangeEnd = 266103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMainIslandDistance(Vector2 worldLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldLocation);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainIslandDistance_Public_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 266113, RefRangeEnd = 266115, XrefRangeStart = 266104, XrefRangeEnd = 266113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMainIslandAmount(Vector2 worldLocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldLocation);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainIslandAmount_Public_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 266119, RefRangeEnd = 266121, XrefRangeStart = 266115, XrefRangeEnd = 266119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetWaterWaves(Vector3 position, out Vector4 waveA, out Vector4 waveB)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref waveA);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref waveB);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWaterWaves_Public_Void_Vector3_byref_Vector4_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 266125, RefRangeEnd = 266137, XrefRangeStart = 266121, XrefRangeEnd = 266125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWaterHeight(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWaterHeight_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266152, RefRangeEnd = 266153, XrefRangeStart = 266137, XrefRangeEnd = 266152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWaterHeightOffset(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWaterHeightOffset_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 266171, RefRangeEnd = 266174, XrefRangeStart = 266153, XrefRangeEnd = 266171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetWaterForceDirection(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWaterForceDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetTerrainWetness()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainWetness_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 266182, RefRangeEnd = 266186, XrefRangeStart = 266174, XrefRangeEnd = 266182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSolidObjectTakenPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSolidObjectTakenPosition_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266191, RefRangeEnd = 266192, XrefRangeStart = 266186, XrefRangeEnd = 266191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ItemDrop> GetGatherItemDropsAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGatherItemDropsAtPosition_Public_List_1_ItemDrop_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemDrop>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 266199, RefRangeEnd = 266203, XrefRangeStart = 266192, XrefRangeEnd = 266199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ItemDrop> GetDigItemDropsAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDigItemDropsAtPosition_Public_List_1_ItemDrop_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemDrop>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266207, RefRangeEnd = 266208, XrefRangeStart = 266203, XrefRangeEnd = 266207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<ItemDrop> GetDigItemDropsForTexture(TextureType textureType, float terrainHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textureType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDigItemDropsForTexture_Public_List_1_ItemDrop_TextureType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ItemDrop>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 266215, RefRangeEnd = 266217, XrefRangeStart = 266208, XrefRangeEnd = 266215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTextureTypeAmountAtPosition(Vector3 position, TextureType textureType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(TextureType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureTypeAmountAtPosition_Public_Single_Vector3_TextureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266223, RefRangeEnd = 266224, XrefRangeStart = 266217, XrefRangeEnd = 266223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureType GetTextureTypeAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureTypeAtPosition_Public_TextureType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TextureType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266224, XrefRangeEnd = 266225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureType GetTextureTypeAtCavePosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureTypeAtCavePosition_Public_TextureType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TextureType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 266254, RefRangeEnd = 266261, XrefRangeStart = 266225, XrefRangeEnd = 266254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PaintTextureTypeAtPosition(Vector3 position, TextureType textureType, float opacity, float maxOpacity, float brushSize, FalloffType falloffType, List<TextureType> existingTextureFilter = null, bool refreshDetails = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&position);
		*(TextureType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureType;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxOpacity;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &brushSize;
		*(FalloffType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &falloffType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)existingTextureFilter);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &refreshDetails;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PaintTextureTypeAtPosition_Public_Void_Vector3_TextureType_Single_Single_Single_FalloffType_List_1_TextureType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266265, RefRangeEnd = 266266, XrefRangeStart = 266261, XrefRangeEnd = 266265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PaintTerrainItemTextureTypeAtPosition(Vector3 position, InventoryItem terrainItem, float opacity, float maxOpacity, float brushSize, FalloffType falloffType, List<TextureType> requiredTextures = null, bool refreshDetails = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainItem);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxOpacity;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &brushSize;
		*(FalloffType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &falloffType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredTextures);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &refreshDetails;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PaintTerrainItemTextureTypeAtPosition_Public_Void_Vector3_InventoryItem_Single_Single_Single_FalloffType_List_1_TextureType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266272, RefRangeEnd = 266273, XrefRangeStart = 266266, XrefRangeEnd = 266272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSnowFootstep(Vector3 position, float strength = 1f, float size = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSnowFootstep_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 266279, RefRangeEnd = 266283, XrefRangeStart = 266273, XrefRangeEnd = 266279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSnow(Vector3 position, float strength = 1f, float size = 1f, bool capStrength = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &capStrength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSnow_Public_Void_Vector3_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266289, RefRangeEnd = 266290, XrefRangeStart = 266283, XrefRangeEnd = 266289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSnow(Vector3 position, float strength, float maxValue, bool capStrength, PaintInfo paintInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &capStrength;
		*(PaintInfo**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSnow_Public_Void_Vector3_Single_Single_Boolean_PaintInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266290, XrefRangeEnd = 266296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetClearedSnowAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClearedSnowAtPosition_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266296, XrefRangeEnd = 266297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWorldDrynessAtPosition(Vector2 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldDrynessAtPosition_Public_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 266321, RefRangeEnd = 266323, XrefRangeStart = 266297, XrefRangeEnd = 266321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWorldDrynessAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldDrynessAtPosition_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266328, RefRangeEnd = 266329, XrefRangeStart = 266323, XrefRangeEnd = 266328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainType GetTerrainTypeAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainTypeAtPosition_Public_TerrainType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(TerrainType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 266335, RefRangeEnd = 266338, XrefRangeStart = 266329, XrefRangeEnd = 266335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTerrainTypeAmountAtPosition(Vector3 position, TerrainType terrainType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(TerrainType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTerrainTypeAmountAtPosition_Public_Single_Vector3_TerrainType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 266349, RefRangeEnd = 266361, XrefRangeStart = 266338, XrefRangeEnd = 266349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SurfaceType GetSurfaceTypeAtTerrainPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSurfaceTypeAtTerrainPosition_Public_SurfaceType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurfaceType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266408, RefRangeEnd = 266409, XrefRangeStart = 266361, XrefRangeEnd = 266408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSurfaceNameAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSurfaceNameAtPosition_Public_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe SurfaceType getSurfaceType(TerrainType terrainType, TextureType textureType, float terrainHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&terrainType);
		*(TextureType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureType;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getSurfaceType_Private_SurfaceType_TerrainType_TextureType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurfaceType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe SurfaceType getCaveSurfaceType(TextureType textureType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&textureType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCaveSurfaceType_Private_SurfaceType_TextureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurfaceType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 266409, RefRangeEnd = 266413, XrefRangeStart = 266409, XrefRangeEnd = 266409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SurfaceType GetSurfaceType(TextureType textureType, float terrainHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&textureType);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSurfaceType_Public_SurfaceType_TextureType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurfaceType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe SurfaceType GetCaveSurfaceType(TextureType textureType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&textureType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaveSurfaceType_Public_SurfaceType_TextureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurfaceType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266414, RefRangeEnd = 266415, XrefRangeStart = 266413, XrefRangeEnd = 266414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SurfaceType GetSurfaceTypeAtCavePosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSurfaceTypeAtCavePosition_Public_SurfaceType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(SurfaceType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 266421, RefRangeEnd = 266435, XrefRangeStart = 266415, XrefRangeEnd = 266421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetDiseaseAmountAtPosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiseaseAmountAtPosition_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266444, RefRangeEnd = 266445, XrefRangeStart = 266435, XrefRangeEnd = 266444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChunkMapDepthValue(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkMapDepthValue_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266445, XrefRangeEnd = 266450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChunkMapDepthValue(Chunk chunk, Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkMapDepthValue_Public_Single_Chunk_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 266454, RefRangeEnd = 266456, XrefRangeStart = 266450, XrefRangeEnd = 266454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChunkMapDepthValue(Chunk chunk, int i, int j)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkMapDepthValue_Public_Single_Chunk_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266497, RefRangeEnd = 266498, XrefRangeStart = 266456, XrefRangeEnd = 266497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetDiseaseCentersNearPoint(Vector3 position, float buffer, ICollection<DiseaseCenter> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiseaseCentersNearPoint_Public_Void_Vector3_Single_ICollection_1_DiseaseCenter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266498, XrefRangeEnd = 266519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetDiseaseCentersOnChunk(Chunk chunk, ICollection<DiseaseCenter> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiseaseCentersOnChunk_Public_Void_Chunk_ICollection_1_DiseaseCenter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266558, RefRangeEnd = 266559, XrefRangeStart = 266519, XrefRangeEnd = 266558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetDiseaseCentersNearChunk(Chunk chunk, ICollection<DiseaseCenter> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiseaseCentersNearChunk_Public_Void_Chunk_ICollection_1_DiseaseCenter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266559, XrefRangeEnd = 266574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDiseaseCenter(DiseaseCenter diseaseCenter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)diseaseCenter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDiseaseCenter_Public_Void_DiseaseCenter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266578, RefRangeEnd = 266579, XrefRangeStart = 266574, XrefRangeEnd = 266578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDiseaseCenters(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDiseaseCenters_Public_Void_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 266579, RefRangeEnd = 266582, XrefRangeStart = 266579, XrefRangeEnd = 266579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetDiseaseRemovedAmount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiseaseRemovedAmount_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266604, RefRangeEnd = 266605, XrefRangeStart = 266582, XrefRangeEnd = 266604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetMaxTerrainHeightDelta(Vector3 position, float range)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxTerrainHeightDelta_Public_Single_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 266636, RefRangeEnd = 266648, XrefRangeStart = 266605, XrefRangeEnd = 266636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AnyObjectsNearby(Vector3 position, float range, HashSet<Entity> ignoreEntities = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoreEntities);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnyObjectsNearby_Public_Boolean_Vector3_Single_HashSet_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266680, RefRangeEnd = 266681, XrefRangeStart = 266648, XrefRangeEnd = 266680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<GameObject> GetObjectsAroundPointWithComponent(Vector3 position, float range, string requiredComponentName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(requiredComponentName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjectsAroundPointWithComponent_Public_HashSet_1_GameObject_Vector3_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr) : null;
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 266703, RefRangeEnd = 266750, XrefRangeStart = 266681, XrefRangeEnd = 266703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetEntitiesAroundPointWithComponent(Vector3 position, float range, string requiredComponentName, ICollection<Entity> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(requiredComponentName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntitiesAroundPointWithComponent_Public_Void_Vector3_Single_String_ICollection_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266750, XrefRangeEnd = 266751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetEntitiesAroundPointWithAllComponents(Vector3 position, float range, ICollection<Entity> result, List<string> requiredComponentNames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredComponentNames);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntitiesAroundPointWithAllComponents_Public_Void_Vector3_Single_ICollection_1_Entity_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 266752, RefRangeEnd = 266755, XrefRangeStart = 266751, XrefRangeEnd = 266752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetEntitiesAroundPointWithAnyComponents(Vector3 position, float range, ICollection<Entity> result, List<string> requiredComponentNames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredComponentNames);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntitiesAroundPointWithAnyComponents_Public_Void_Vector3_Single_ICollection_1_Entity_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 266756, RefRangeEnd = 266761, XrefRangeStart = 266755, XrefRangeEnd = 266756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetEntitiesAroundPoint(Vector3 position, float range, ICollection<Entity> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEntitiesAroundPoint_Public_Void_Vector3_Single_ICollection_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 266818, RefRangeEnd = 266821, XrefRangeStart = 266761, XrefRangeEnd = 266818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getEntitiesAroundPoint(Vector3 position, float range, bool allRequired, List<string> requiredComponentNames, ICollection<Entity> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allRequired;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredComponentNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEntitiesAroundPoint_Private_Void_Vector3_Single_Boolean_List_1_String_ICollection_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 266894, RefRangeEnd = 266896, XrefRangeStart = 266821, XrefRangeEnd = 266894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getEntitiesInRange(Vector3 position, float range, ICollection<Entity> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEntitiesInRange_Private_Void_Vector3_Single_ICollection_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266896, XrefRangeEnd = 266897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCellCoordinatesFromCenterChunk(Coordinates chunkCoordinates, Coordinates cellOffset, out Coordinates resultChunkCoordinates, out Coordinates resultCellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&chunkCoordinates);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellOffset;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref resultChunkCoordinates);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref resultCellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellCoordinatesFromCenterChunk_Public_Void_Coordinates_Coordinates_byref_Coordinates_byref_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 266899, RefRangeEnd = 266910, XrefRangeStart = 266897, XrefRangeEnd = 266899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCellCoordinatesFromCenterChunk(Coordinates chunkCoordinates, int inputCellX, int inputCellY, out Coordinates resultChunkCoordinates, out Coordinates resultCellCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&chunkCoordinates);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCellX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCellY;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref resultChunkCoordinates);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref resultCellCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellCoordinatesFromCenterChunk_Public_Void_Coordinates_Int32_Int32_byref_Coordinates_byref_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 266942, RefRangeEnd = 266945, XrefRangeStart = 266910, XrefRangeEnd = 266942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetNearbyTerrainLayerZones(Vector3 position, float range, List<TerrainLayerZone> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearbyTerrainLayerZones_Public_Void_Vector3_Single_List_1_TerrainLayerZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 266970, RefRangeEnd = 266972, XrefRangeStart = 266945, XrefRangeEnd = 266970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckZone(Chunk chunk, TerrainLayerZone terrainLayerZone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainLayerZone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckZone_Public_Boolean_Chunk_TerrainLayerZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 266985, RefRangeEnd = 266986, XrefRangeStart = 266972, XrefRangeEnd = 266985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Chunk> GetSurroundingChunks(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSurroundingChunks_Public_List_1_Chunk_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Chunk>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 267005, RefRangeEnd = 267008, XrefRangeStart = 266986, XrefRangeEnd = 267005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLatitude()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLatitude_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267044, RefRangeEnd = 267045, XrefRangeStart = 267008, XrefRangeEnd = 267044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.DateTime GetNextSunriseDateTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextSunriseDateTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267077, RefRangeEnd = 267078, XrefRangeStart = 267045, XrefRangeEnd = 267077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.DateTime GetNextSunsetDateTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextSunsetDateTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 267179, RefRangeEnd = 267185, XrefRangeStart = 267078, XrefRangeEnd = 267179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WeatherState determineNextWeatherState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineNextWeatherState_Private_WeatherState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WeatherState>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 267222, RefRangeEnd = 267227, XrefRangeStart = 267185, XrefRangeEnd = 267222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WeatherStateHistoryData GetWeatherStateHistoryData(Il2CppSystem.DateTime checkedStartDateTime, Il2CppSystem.DateTime checkedEndDateTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&checkedStartDateTime);
		*(Il2CppSystem.DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkedEndDateTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeatherStateHistoryData_Public_WeatherStateHistoryData_DateTime_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(WeatherStateHistoryData*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267227, XrefRangeEnd = 267232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WeatherStateHistoryData GetWeatherStateHistoryData(Il2CppSystem.TimeSpan timeSpan)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeSpan);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeatherStateHistoryData_Public_WeatherStateHistoryData_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(WeatherStateHistoryData*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267232, XrefRangeEnd = 267237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPastRainTime(Il2CppSystem.TimeSpan timeSpan)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeSpan);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPastRainTime_Public_Single_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267238, RefRangeEnd = 267239, XrefRangeStart = 267237, XrefRangeEnd = 267238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPastRainTime(Il2CppSystem.DateTime startDateTime, Il2CppSystem.DateTime endDateTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&startDateTime);
		*(Il2CppSystem.DateTime**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &endDateTime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPastRainTime_Public_Single_DateTime_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267244, RefRangeEnd = 267245, XrefRangeStart = 267239, XrefRangeEnd = 267244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetPastSnowTime(Il2CppSystem.TimeSpan timeSpan)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeSpan);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPastSnowTime_Public_Single_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 267248, RefRangeEnd = 267251, XrefRangeStart = 267245, XrefRangeEnd = 267248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRainSubstance(Substance substance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)substance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRainSubstance_Public_Void_Substance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetWorldSleepState(bool worldSleepState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldSleepState);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWorldSleepState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267251, RefRangeEnd = 267252, XrefRangeStart = 267251, XrefRangeEnd = 267251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasWorldSleepCountdown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasWorldSleepCountdown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetWorldSleepCountdown(float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWorldSleepCountdown_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetWorldTimeScaleFactor(float worldTimeScaleFactor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldTimeScaleFactor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWorldTimeScaleFactor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 267253, RefRangeEnd = 267278, XrefRangeStart = 267252, XrefRangeEnd = 267253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWorldTimeScaledDeltaTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldTimeScaledDeltaTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 267278, RefRangeEnd = 267280, XrefRangeStart = 267278, XrefRangeEnd = 267278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWorldTimeScaledDeltaTime(float deltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deltaTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldTimeScaledDeltaTime_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(52)]
	[CachedScanResults(RefRangeStart = 267280, RefRangeEnd = 267332, XrefRangeStart = 267280, XrefRangeEnd = 267280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetBaseTimeScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseTimeScale_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsSleepState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSleepState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 267333, RefRangeEnd = 267340, XrefRangeStart = 267332, XrefRangeEnd = 267333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.DateTime GetWeatherDateTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeatherDateTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Il2CppSystem.DateTime GetWorldDateTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldDateTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Il2CppSystem.DateTime GetWorldStartDateTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldStartDateTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267340, XrefRangeEnd = 267348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetWorldDateTimeSeconds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldDateTimeSeconds_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetDateTime(Il2CppSystem.DateTime dateTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDateTime_Public_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267354, RefRangeEnd = 267355, XrefRangeStart = 267348, XrefRangeEnd = 267354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTime(Il2CppSystem.TimeSpan time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTime_Public_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267355, RefRangeEnd = 267356, XrefRangeStart = 267355, XrefRangeEnd = 267355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDay(int day)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&day);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDay_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 267372, RefRangeEnd = 267377, XrefRangeStart = 267356, XrefRangeEnd = 267372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetDay(Il2CppSystem.DateTime worldDateTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldDateTime);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDay_Public_Int32_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 267393, RefRangeEnd = 267413, XrefRangeStart = 267377, XrefRangeEnd = 267393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCurrentDay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentDay_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 267413, RefRangeEnd = 267428, XrefRangeStart = 267413, XrefRangeEnd = 267413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsNightTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNightTime_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetDayPercentage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDayPercentage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe float GetNightPercentage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNightPercentage_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe WorldState GetWorldState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldState_Public_WorldState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(WorldState*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 267428, RefRangeEnd = 267436, XrefRangeStart = 267428, XrefRangeEnd = 267428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsActiveState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActiveState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 267436, RefRangeEnd = 267444, XrefRangeStart = 267436, XrefRangeEnd = 267436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsUnloadedState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUnloadedState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 267468, RefRangeEnd = 267476, XrefRangeStart = 267444, XrefRangeEnd = 267468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWorldState(WorldState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWorldState_Public_Void_WorldState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 267494, RefRangeEnd = 267497, XrefRangeStart = 267476, XrefRangeEnd = 267494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshCell(Chunk chunk, Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshCell_Public_Void_Chunk_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 267520, RefRangeEnd = 267525, XrefRangeStart = 267497, XrefRangeEnd = 267520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshCell(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshCell_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 267528, RefRangeEnd = 267530, XrefRangeStart = 267525, XrefRangeEnd = 267528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCellBounds(Chunk chunk, Vector3 position, out int cellMinX, out int cellMinY, out int cellMaxX, out int cellMaxY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cellMinX);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cellMinY);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cellMaxX);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cellMaxY);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCellBounds_Public_Void_Chunk_Vector3_byref_Int32_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267543, RefRangeEnd = 267544, XrefRangeStart = 267530, XrefRangeEnd = 267543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshDetailPlacements(Chunk chunk, Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshDetailPlacements_Public_Void_Chunk_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267546, RefRangeEnd = 267547, XrefRangeStart = 267544, XrefRangeEnd = 267546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRainIntensity(float intensity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intensity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRainIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267549, RefRangeEnd = 267550, XrefRangeStart = 267547, XrefRangeEnd = 267549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSnowIntensity(float intensity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intensity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSnowIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267552, RefRangeEnd = 267553, XrefRangeStart = 267550, XrefRangeEnd = 267552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCloudsPercentage(float percentage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&percentage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCloudsPercentage_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267555, RefRangeEnd = 267556, XrefRangeStart = 267553, XrefRangeEnd = 267555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWindIntensity(float percentage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&percentage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWindIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetFogIntensity(float intensity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intensity);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFogIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 267594, RefRangeEnd = 267596, XrefRangeStart = 267556, XrefRangeEnd = 267594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWaterReflectionQuality(int qualityLevel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&qualityLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWaterReflectionQuality_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 267601, RefRangeEnd = 267604, XrefRangeStart = 267596, XrefRangeEnd = 267601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetViewDistance(float viewDistance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewDistance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetViewDistance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267608, RefRangeEnd = 267609, XrefRangeStart = 267604, XrefRangeEnd = 267608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddWaterMaterial(Material waterMaterial)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)waterMaterial);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWaterMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267609, XrefRangeEnd = 267610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initializeReflectionCamera(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initializeReflectionCamera_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267629, RefRangeEnd = 267630, XrefRangeStart = 267610, XrefRangeEnd = 267629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTriggeredWorldEvent(WorldEventType worldEventType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldEventType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTriggeredWorldEvent_Public_Void_WorldEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267634, RefRangeEnd = 267635, XrefRangeStart = 267630, XrefRangeEnd = 267634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsWorldEventTriggered(WorldEventType worldEventType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldEventType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWorldEventTriggered_Public_Boolean_WorldEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267680, RefRangeEnd = 267681, XrefRangeStart = 267635, XrefRangeEnd = 267680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Camera setupReflectionCamera(Camera realCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)realCamera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setupReflectionCamera_Private_Camera_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267711, RefRangeEnd = 267712, XrefRangeStart = 267681, XrefRangeEnd = 267711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void positionReflectionCamera(Camera realCamera, Camera reflectionCamera, float yPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)realCamera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reflectionCamera);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &yPos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_positionReflectionCamera_Private_Void_Camera_Camera_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267712, XrefRangeEnd = 267756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Camera setupSkyboxCamera(Camera realCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)realCamera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setupSkyboxCamera_Private_Camera_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267756, XrefRangeEnd = 267763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void beginCameraRendering(ScriptableRenderContext context, Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_beginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267852, RefRangeEnd = 267853, XrefRangeStart = 267763, XrefRangeEnd = 267852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void handleReflectionRendering(ScriptableRenderContext context, Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleReflectionRendering_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267853, XrefRangeEnd = 267855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void endCameraRendering(ScriptableRenderContext scriptableRenderContext, Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&scriptableRenderContext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_endCameraRendering_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 267859, RefRangeEnd = 267860, XrefRangeStart = 267855, XrefRangeEnd = 267859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void renderOutdoorReflectionProbe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_renderOutdoorReflectionProbe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267860, XrefRangeEnd = 267862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool renderOutdoorReflectionProbeSlice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_renderOutdoorReflectionProbeSlice_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267862, XrefRangeEnd = 267866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 cameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &normal;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sideSign;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cameraSpacePlane_Private_Vector4_Camera_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void calculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref reflectionMat);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calculateReflectionMatrix_Private_Static_Void_byref_Matrix4x4_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268044, RefRangeEnd = 268045, XrefRangeStart = 267889, XrefRangeEnd = 268044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnterCave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnterCave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 268189, RefRangeEnd = 268191, XrefRangeStart = 268045, XrefRangeEnd = 268189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExitCave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitCave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 268202, RefRangeEnd = 268205, XrefRangeStart = 268191, XrefRangeEnd = 268202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SchedulePhysicsBake(MeshCollider meshCollider, Mesh mesh, bool updateNavMesh = true, bool deleteOldMesh = false, Il2CppSystem.Action callback = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshCollider);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mesh);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateNavMesh;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &deleteOldMesh;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SchedulePhysicsBake_Public_Void_MeshCollider_Mesh_Boolean_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 268205, RefRangeEnd = 268207, XrefRangeStart = 268205, XrefRangeEnd = 268205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void QueueNavMeshUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueNavMeshUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268222, RefRangeEnd = 268223, XrefRangeStart = 268207, XrefRangeEnd = 268222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268223, XrefRangeEnd = 268290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268291, RefRangeEnd = 268292, XrefRangeStart = 268290, XrefRangeEnd = 268291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyUpdates(NetworkWorldUpdate message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyUpdates_Public_Void_NetworkWorldUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268293, RefRangeEnd = 268294, XrefRangeStart = 268292, XrefRangeEnd = 268293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NetworkWorldUpdate GetUpdates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpdates_Public_NetworkWorldUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NetworkWorldUpdate(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98360, RefRangeEnd = 98361, XrefRangeStart = 98360, XrefRangeEnd = 98361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyUpdates(NetworkWorldCampUpdate message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyUpdates_Public_Void_NetworkWorldCampUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268295, RefRangeEnd = 268296, XrefRangeStart = 268294, XrefRangeEnd = 268295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NetworkWorldCampUpdate GetCampUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCampUpdate_Public_NetworkWorldCampUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NetworkWorldCampUpdate(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 268300, RefRangeEnd = 268301, XrefRangeStart = 268296, XrefRangeEnd = 268300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyUpdates(NetworkWorldDiseaseCenterUpdate message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)message));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyUpdates_Public_Void_NetworkWorldDiseaseCenterUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 268305, RefRangeEnd = 268307, XrefRangeStart = 268301, XrefRangeEnd = 268305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NetworkWorldDiseaseCenterUpdate GetDiseaseCenterUpdate(Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiseaseCenterUpdate_Public_NetworkWorldDiseaseCenterUpdate_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NetworkWorldDiseaseCenterUpdate(pointer);
	}

	public World(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

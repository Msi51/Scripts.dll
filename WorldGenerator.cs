using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

public class WorldGenerator : Il2CppSystem.Object
{
	[ObfuscatedName("WorldGenerator+<>c__DisplayClass32_0")]
	public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_radius;

		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_world;

		private static readonly System.IntPtr NativeFieldInfoPtr_tempTypes;

		private static readonly System.IntPtr NativeFieldInfoPtr_coveredCoordinates;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateChunkInfos_b__0_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_ChunkInfo_Coordinates_0;

		public unsafe int radius
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius)) = num;
			}
		}

		public unsafe int x
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x)) = num;
			}
		}

		public unsafe int y
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y)) = num;
			}
		}

		public unsafe WorldGenerator __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldGenerator>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGenerator));
			}
		}

		public unsafe World world
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
			}
		}

		public unsafe Il2CppStructArray<float> tempTypes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempTypes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe HashSet<Coordinates> coveredCoordinates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coveredCoordinates);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coveredCoordinates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
			}
		}

		static __c__DisplayClass32_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "<>c__DisplayClass32_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr);
			NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, "radius");
			NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, "x");
			NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, "y");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, "world");
			NativeFieldInfoPtr_tempTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, "tempTypes");
			NativeFieldInfoPtr_coveredCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, "coveredCoordinates");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, 100684059);
			NativeMethodInfoPtr__GenerateChunkInfos_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, 100684060);
			NativeMethodInfoPtr_Method_Internal_Boolean_ChunkInfo_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, 100684061);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass32_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272219, XrefRangeEnd = 272224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GenerateChunkInfos_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateChunkInfos_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272229, RefRangeEnd = 272230, XrefRangeStart = 272224, XrefRangeEnd = 272229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Internal_Boolean_ChunkInfo_Coordinates_0(ChunkInfo chunkInfo, Coordinates coordinates)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunkInfo);
			*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Boolean_ChunkInfo_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass32_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("WorldGenerator+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__32_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__43_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateChunkInfos_b__32_2_Internal_Int32_Coordinates_Coordinates_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateRoadChunkInfo_b__43_0_Internal_Int32_Tuple_2_Coordinates_Coordinates_Tuple_2_Coordinates_Coordinates_0;

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Comparison<Coordinates> __9__32_2
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__32_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Coordinates>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__32_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<Il2CppSystem.Tuple<Coordinates, Coordinates>> __9__43_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Il2CppSystem.Tuple<Coordinates, Coordinates>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__43_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__32_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__32_2");
			NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__43_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100684063);
			NativeMethodInfoPtr__GenerateChunkInfos_b__32_2_Internal_Int32_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100684064);
			NativeMethodInfoPtr__GenerateRoadChunkInfo_b__43_0_Internal_Int32_Tuple_2_Coordinates_Coordinates_Tuple_2_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100684065);
		}

		[CallerCount(1714)]
		[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272230, XrefRangeEnd = 272231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GenerateChunkInfos_b__32_2(Coordinates c1, Coordinates c2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&c1);
			*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateChunkInfos_b__32_2_Internal_Int32_Coordinates_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272231, XrefRangeEnd = 272238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GenerateRoadChunkInfo_b__43_0(Il2CppSystem.Tuple<Coordinates, Coordinates> first, Il2CppSystem.Tuple<Coordinates, Coordinates> second)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)first);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)second);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateRoadChunkInfo_b__43_0_Internal_Int32_Tuple_2_Coordinates_Coordinates_Tuple_2_Coordinates_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("WorldGenerator+<GenerateChunkInfos>d__32")]
	public sealed class _GenerateChunkInfos_d__32 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_world;

		private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

		private static readonly System.IntPtr NativeFieldInfoPtr__chunkInfos_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe WorldGenerator __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldGenerator>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGenerator));
			}
		}

		public unsafe World world
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
			}
		}

		public unsafe __c__DisplayClass32_0 __8__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass32_0>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___8__1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c__DisplayClass32_));
			}
		}

		public unsafe Dictionary<Coordinates, ChunkInfo> _chunkInfos_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__chunkInfos_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, ChunkInfo>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__chunkInfos_5__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static _GenerateChunkInfos_d__32()
		{
			Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "<GenerateChunkInfos>d__32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr, "world");
			NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr, "<>8__1");
			NativeFieldInfoPtr__chunkInfos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr, "<chunkInfos>5__2");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr, "<>u__1");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr, 100684066);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr, 100684067);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272238, XrefRangeEnd = 272402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272402, XrefRangeEnd = 272406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _GenerateChunkInfos_d__32(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _GenerateChunkInfos_d__32()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GenerateChunkInfos_d__32>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("WorldGenerator+<GenerateCliffChunkInfos>d__55")]
	public sealed class _GenerateCliffChunkInfos_d__55 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr_startingCoordinates;

		private static readonly System.IntPtr NativeFieldInfoPtr_world;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__cliffsToGenerate_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__numGenerated_5__3;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Coordinates startingCoordinates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCoordinates);
				return *(Coordinates*)num;
			}
			set
			{
				*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCoordinates)) = coordinates;
			}
		}

		public unsafe World world
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
			}
		}

		public unsafe WorldGenerator __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldGenerator>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGenerator));
			}
		}

		public unsafe int _cliffsToGenerate_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cliffsToGenerate_5__2);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cliffsToGenerate_5__2)) = num;
			}
		}

		public unsafe int _numGenerated_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numGenerated_5__3);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numGenerated_5__3)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int _i_5__4
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__4);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__4)) = num;
			}
		}

		static _GenerateCliffChunkInfos_d__55()
		{
			Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "<GenerateCliffChunkInfos>d__55");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr_startingCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, "startingCoordinates");
			NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, "world");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__cliffsToGenerate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, "<cliffsToGenerate>5__2");
			NativeFieldInfoPtr__numGenerated_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, "<numGenerated>5__3");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, "<>u__1");
			NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, "<i>5__4");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, 100684068);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr, 100684069);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272406, XrefRangeEnd = 272446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272446, XrefRangeEnd = 272452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _GenerateCliffChunkInfos_d__55(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _GenerateCliffChunkInfos_d__55()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GenerateCliffChunkInfos_d__55>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("WorldGenerator+<GenerateCaveChunkInfos>d__57")]
	public sealed class _GenerateCaveChunkInfos_d__57 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr_world;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr_startingCoordinates;

		private static readonly System.IntPtr NativeFieldInfoPtr__cavesToGenerate_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__numGenerated_5__3;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe World world
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<World>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_world)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world));
			}
		}

		public unsafe WorldGenerator __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldGenerator>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGenerator));
			}
		}

		public unsafe Coordinates startingCoordinates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCoordinates);
				return *(Coordinates*)num;
			}
			set
			{
				*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCoordinates)) = coordinates;
			}
		}

		public unsafe int _cavesToGenerate_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cavesToGenerate_5__2);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cavesToGenerate_5__2)) = num;
			}
		}

		public unsafe int _numGenerated_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numGenerated_5__3);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numGenerated_5__3)) = num;
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int _i_5__4
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__4);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__i_5__4)) = num;
			}
		}

		static _GenerateCaveChunkInfos_d__57()
		{
			Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "<GenerateCaveChunkInfos>d__57");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, "world");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr_startingCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, "startingCoordinates");
			NativeFieldInfoPtr__cavesToGenerate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, "<cavesToGenerate>5__2");
			NativeFieldInfoPtr__numGenerated_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, "<numGenerated>5__3");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, "<>u__1");
			NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, "<i>5__4");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, 100684070);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr, 100684071);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272452, XrefRangeEnd = 272489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272489, XrefRangeEnd = 272495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _GenerateCaveChunkInfos_d__57(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _GenerateCaveChunkInfos_d__57()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_GenerateCaveChunkInfos_d__57>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_OBJECT_PLACEMENT_ITERATIONS;

	private static readonly System.IntPtr NativeFieldInfoPtr_config;

	private static readonly System.IntPtr NativeFieldInfoPtr_taskManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNetworkedWorld;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseTerrainMinHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseTerrainMaxHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_featureMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseTerrainHeightLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTypeLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainMinMaxHeightFilterLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainHeightFilterLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondaryTerrainHeightFilterLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseTerrainTextureLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTypeTextureLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightAffectingTextureLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_structureGenerators;

	private static readonly System.IntPtr NativeFieldInfoPtr_voxelCaveChunkGenerator;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainVoxelGenerator;

	private static readonly System.IntPtr NativeFieldInfoPtr_usedVillageNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveResourceDirections;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_WorldGen_ITaskManager_IAIManager_IInventoryManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFeature_Public_IWorldGenerationFeature_WorldGenerationFeatureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTerrainTypeLayer_Public_Void_TerrainTypeLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTerrainHeightLayer_Public_Void_IBaseTerrainHeightLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMinMaxHeightFilterLayer_Public_Void_ITerrainMinMaxHeightFilterLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHeightFilterLayer_Public_Void_ITerrainHeightFilterLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSecondaryHeightFilterLayer_Public_Void_ISecondaryTerrainHeightFilterLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBaseTerrainTextureLayers_Public_Void_List_1_BaseTerrainTextureLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTerrainTextureLayer_Public_Void_Int32_ITerrainTextureLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddStructureGenerator_Public_Void_IStructureGenerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVoxelCaveChunkGenerator_Public_Void_VoxelCaveChunkGenerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTerrainVoxelGenerator_Public_Void_TerrainVoxelGenerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateChunkInfos_Public_Task_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateChunkInfo_Public_ChunkInfo_World_Coordinates_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sampleChunkInfo_Private_Void_World_Coordinates_ChunkInfo_Il2CppStructArray_1_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sampleHeight_Private_Single_World_byref_WorldGenerationHeightData_Coordinates_Il2CppStructArray_1_Single_Int32_Vector2_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findAllNeighborChunkInfos_Private_Void_World_Coordinates_HashSet_1_Coordinates_Func_3_ChunkInfo_Coordinates_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRiverChunkInfo_Public_Int32_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateVillageChunkInfo_Public_Int32_World_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateCapitalCityExtensionChunkInfo_Private_Void_World_Coordinates_Queue_1_Coordinates_Int32_List_1_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateVillageExtensionChunkInfo_Private_Void_World_Coordinates_List_1_Coordinates_Single_List_1_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNeighborRiverNavTiles_Private_Void_World_ChunkNavTile_Coordinates_List_1_ChunkNavTile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNeighborRoadNavTiles_Private_Void_World_ChunkNavTile_Coordinates_List_1_ChunkNavTile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRoadChunkInfo_Public_Int32_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tryAddingRoadBorderConnections_Private_Void_World_Coordinates_Coordinates_List_1_Tuple_2_Coordinates_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tryAddingRoadBorderConnection_Private_Boolean_World_Coordinates_Coordinates_List_1_Tuple_2_Coordinates_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_roadBorderSourceValid_Private_Boolean_World_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRoadChunkInfo_Public_Int32_World_List_1_Tuple_2_Coordinates_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compareTileCoordinates_Private_Int32_ChunkNavTile_ChunkNavTile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMinCostDistanceTile_Private_ChunkNavTile_ICollection_1_ChunkNavTile_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findMatchingTile_Private_ChunkNavTile_ICollection_1_ChunkNavTile_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getPath_Private_Boolean_World_Coordinates_Coordinates_PathNavTileGetter_List_1_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateResourceChunkInfos_Public_Int32_World_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSwampChunkInfos_Public_Int32_World_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateBridgeChunkInfos_Public_Void_World_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCliffChunkInfos_Public_Task_1_Int32_World_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tryAddCliff_Private_Boolean_World_Coordinates_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCaveChunkInfos_Public_Task_1_Int32_World_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tryAddCave_Private_Boolean_World_Coordinates_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRegionChunkData_Public_Void_RegionChunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateChunkData_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateTerrainTypes_Private_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateTerrainTypesForHeightmapPoint_Private_Void_Int32_Coordinates_Vector2_Int32_Int32_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateHeightmap_Private_Void_RegionChunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateHeightmap_Private_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateHeightForPoint_Public_Single_World_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateHeightForPoint_Private_Single_byref_WorldGenerationHeightData_Vector2_Single_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSlopeData_Public_Void_Chunk_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSlopeData_Public_Void_Chunk_Int32_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_calculateSlope_Private_Vector2_Coordinates_Il2CppObjectBase_Vector2_Int32_byref_WorldGenerationHeightData_Single_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_calculateSlope_Private_Vector2_Il2CppObjectBase_Int32_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateWaterMap_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateTerrainTextures_Private_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateTerrainTextures_Private_Void_RegionChunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementTerrainTexture_Public_Void_Dictionary_2_TextureType_Int32_Il2CppObjectBase_Int32_Int32_TextureType_Single_Single_List_1_TextureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTerrainTexture_Public_Void_Dictionary_2_TextureType_Int32_Il2CppObjectBase_Int32_Int32_TextureType_Single_List_1_TextureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTerrainTexture_Public_Void_Il2CppObjectBase_Int32_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PaintTerrainTexture_Public_Void_Chunk_QueuedTexturePaint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PaintTerrainTexture_Public_Void_Chunk_Single_Single_TextureType_Single_Single_Single_FalloffType_List_1_TextureType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RectanglePaintTerrainTexture_Public_Void_Chunk_QueuedTextureRectanglePaint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RectanglePaintTerrainTexture_Public_Void_Chunk_Single_Single_TextureType_Single_Single_Single_Single_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PaintClearedSnow_Public_Void_Chunk_QueuedClearedSnowPaint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PaintClearedSnow_Public_Void_Chunk_Single_Single_Single_PaintInfo_Boolean_Boolean_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_processHeightAffectingTextures_Private_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getHeight_Private_Single_World_Coordinates_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PaintTerrainHeight_Public_Single_Chunk_Single_Single_Single_Single_Single_List_1_TextureType_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AdjustTerrainHeightAtPoint_Public_Single_Chunk_TerrainPoint_Single_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmoothTerrainHeight_Public_Single_Chunk_Single_Single_Single_Single_List_1_TextureType_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LevelTerrainHeight_Public_Single_Chunk_Single_Single_Single_Single_Single_List_1_TextureType_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateTerrainLayerZones_Private_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckZone_Public_Boolean_Chunk_Int32_Int32_Queue_1_ValueTuple_2_Int32_Int32_HashSet_1_ValueTuple_2_Int32_Int32_List_1_ValueTuple_2_Int32_Int32_Int32_Int32_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_processSecondaryHeightFilters_Private_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDiseaseMap_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateEnvironmentObjects_Private_Void_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findSubObjectPlacement_Private_Boolean_Chunk_Int32_Int32_WorldGenSubObject_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectPlacement_Public_Boolean_Chunk_String_byref_EntityCreationInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateObjectPlacement_Public_Boolean_Chunk_String_Vector3_byref_EntityCreationInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isObjectPlacementValid_Private_Boolean_Chunk_WorldGenObject_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_placeObject_Private_Void_Chunk_Int32_Int32_Single_Single_String_Int32_Single_Single_Boolean_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateStructures_Private_Void_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateCaves_Private_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCaveChunkResources_Public_Void_Chunk_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_processCaveResourceNodePosition_Private_Void_Chunk_CaveNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getValidCaveSurfacePlacement_Private_Boolean_Vector3_Vector3_Boolean_byref_Vector3_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isCaveResourcePositionValid_Private_Boolean_Chunk_WorldGenObject_CaveData_CaveNode_Vector3_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateFeatures_Private_Void_Chunk_Boolean_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateHoleMap_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTerrainDetailMaps_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTerrainDetailMaps_Public_Void_Chunk_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDetailObjectPlacementInfo_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDetailObjectPlacementInfo_Public_Void_Chunk_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteDetails_Public_HashSet_1_Coordinates_Chunk_Single_Single_Single_Single_List_1_TextureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkHeights_Private_Boolean_Chunk_Int32_Int32_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckTakenPositions_Public_Boolean_Chunk_Int32_Int32_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkPositionTaken_Public_Void_Coordinates_Int32_Vector3_Vector2_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkPositionTaken_Public_Void_Int32_Int32_Int32_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkPositionTaken_Public_Void_Coordinates_Int32_Vector3_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCaveMeshData_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTerrain_Public_Void_Chunk_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateFeature_Public_Void_IWorldGenerationFeatureInfo_World_Chunk_Boolean_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	public unsafe static int MAX_OBJECT_PLACEMENT_ITERATIONS
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_OBJECT_PLACEMENT_ITERATIONS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_OBJECT_PLACEMENT_ITERATIONS, (void*)(&num));
		}
	}

	public unsafe WorldGen config
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_config);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldGen>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_config)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldGen));
		}
	}

	public unsafe ITaskManager taskManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ITaskManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskManager));
		}
	}

	public unsafe bool isNetworkedWorld
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNetworkedWorld);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNetworkedWorld)) = flag;
		}
	}

	public unsafe float baseTerrainMinHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainMinHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainMinHeight)) = num;
		}
	}

	public unsafe float baseTerrainMaxHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainMaxHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainMaxHeight)) = num;
		}
	}

	public unsafe Dictionary<WorldGenerationFeatureType, IWorldGenerationFeature> featureMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<WorldGenerationFeatureType, IWorldGenerationFeature>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe IBaseTerrainHeightLayer baseTerrainHeightLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainHeightLayer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IBaseTerrainHeightLayer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainHeightLayer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseTerrainHeightLayer));
		}
	}

	public unsafe List<TerrainTypeLayer> terrainTypeLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TerrainTypeLayer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeLayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ITerrainMinMaxHeightFilterLayer> terrainMinMaxHeightFilterLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainMinMaxHeightFilterLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ITerrainMinMaxHeightFilterLayer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainMinMaxHeightFilterLayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ITerrainHeightFilterLayer> terrainHeightFilterLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainHeightFilterLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ITerrainHeightFilterLayer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainHeightFilterLayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ISecondaryTerrainHeightFilterLayer> secondaryTerrainHeightFilterLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryTerrainHeightFilterLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ISecondaryTerrainHeightFilterLayer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryTerrainHeightFilterLayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe SortedList<float, BaseTerrainTextureLayer> baseTerrainTextureLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainTextureLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SortedList<float, BaseTerrainTextureLayer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseTerrainTextureLayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sortedList));
		}
	}

	public unsafe Dictionary<int, List<ITerrainTextureLayer>> terrainTypeTextureLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeTextureLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<ITerrainTextureLayer>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTypeTextureLayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, List<ITerrainTextureLayer>> heightAffectingTextureLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightAffectingTextureLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<ITerrainTextureLayer>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightAffectingTextureLayers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<IStructureGenerator> structureGenerators
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_structureGenerators);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IStructureGenerator>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_structureGenerators)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe VoxelCaveChunkGenerator voxelCaveChunkGenerator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voxelCaveChunkGenerator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VoxelCaveChunkGenerator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voxelCaveChunkGenerator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)voxelCaveChunkGenerator));
		}
	}

	public unsafe TerrainVoxelGenerator terrainVoxelGenerator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainVoxelGenerator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TerrainVoxelGenerator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainVoxelGenerator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainVoxelGenerator));
		}
	}

	public unsafe HashSet<string> usedVillageNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedVillageNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedVillageNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe Il2CppStructArray<CaveResourceDirection> caveResourceDirections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResourceDirections);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<CaveResourceDirection>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResourceDirections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static WorldGenerator()
	{
		Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WorldGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr);
		NativeFieldInfoPtr_MAX_OBJECT_PLACEMENT_ITERATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "MAX_OBJECT_PLACEMENT_ITERATIONS");
		NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "config");
		NativeFieldInfoPtr_taskManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "taskManager");
		NativeFieldInfoPtr_isNetworkedWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "isNetworkedWorld");
		NativeFieldInfoPtr_baseTerrainMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "baseTerrainMinHeight");
		NativeFieldInfoPtr_baseTerrainMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "baseTerrainMaxHeight");
		NativeFieldInfoPtr_featureMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "featureMap");
		NativeFieldInfoPtr_baseTerrainHeightLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "baseTerrainHeightLayer");
		NativeFieldInfoPtr_terrainTypeLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "terrainTypeLayers");
		NativeFieldInfoPtr_terrainMinMaxHeightFilterLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "terrainMinMaxHeightFilterLayers");
		NativeFieldInfoPtr_terrainHeightFilterLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "terrainHeightFilterLayers");
		NativeFieldInfoPtr_secondaryTerrainHeightFilterLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "secondaryTerrainHeightFilterLayers");
		NativeFieldInfoPtr_baseTerrainTextureLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "baseTerrainTextureLayers");
		NativeFieldInfoPtr_terrainTypeTextureLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "terrainTypeTextureLayers");
		NativeFieldInfoPtr_heightAffectingTextureLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "heightAffectingTextureLayers");
		NativeFieldInfoPtr_structureGenerators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "structureGenerators");
		NativeFieldInfoPtr_voxelCaveChunkGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "voxelCaveChunkGenerator");
		NativeFieldInfoPtr_terrainVoxelGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "terrainVoxelGenerator");
		NativeFieldInfoPtr_usedVillageNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "usedVillageNames");
		NativeFieldInfoPtr_caveResourceDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, "caveResourceDirections");
		NativeMethodInfoPtr__ctor_Public_Void_WorldGen_ITaskManager_IAIManager_IInventoryManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683959);
		NativeMethodInfoPtr_GetFeature_Public_IWorldGenerationFeature_WorldGenerationFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683960);
		NativeMethodInfoPtr_AddTerrainTypeLayer_Public_Void_TerrainTypeLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683961);
		NativeMethodInfoPtr_SetTerrainHeightLayer_Public_Void_IBaseTerrainHeightLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683962);
		NativeMethodInfoPtr_AddMinMaxHeightFilterLayer_Public_Void_ITerrainMinMaxHeightFilterLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683963);
		NativeMethodInfoPtr_AddHeightFilterLayer_Public_Void_ITerrainHeightFilterLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683964);
		NativeMethodInfoPtr_AddSecondaryHeightFilterLayer_Public_Void_ISecondaryTerrainHeightFilterLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683965);
		NativeMethodInfoPtr_SetBaseTerrainTextureLayers_Public_Void_List_1_BaseTerrainTextureLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683966);
		NativeMethodInfoPtr_AddTerrainTextureLayer_Public_Void_Int32_ITerrainTextureLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683967);
		NativeMethodInfoPtr_AddStructureGenerator_Public_Void_IStructureGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683968);
		NativeMethodInfoPtr_SetVoxelCaveChunkGenerator_Public_Void_VoxelCaveChunkGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683969);
		NativeMethodInfoPtr_SetTerrainVoxelGenerator_Public_Void_TerrainVoxelGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683970);
		NativeMethodInfoPtr_GenerateChunkInfos_Public_Task_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683971);
		NativeMethodInfoPtr_GenerateChunkInfo_Public_ChunkInfo_World_Coordinates_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683972);
		NativeMethodInfoPtr_sampleChunkInfo_Private_Void_World_Coordinates_ChunkInfo_Il2CppStructArray_1_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683973);
		NativeMethodInfoPtr_sampleHeight_Private_Single_World_byref_WorldGenerationHeightData_Coordinates_Il2CppStructArray_1_Single_Int32_Vector2_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683974);
		NativeMethodInfoPtr_findAllNeighborChunkInfos_Private_Void_World_Coordinates_HashSet_1_Coordinates_Func_3_ChunkInfo_Coordinates_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683975);
		NativeMethodInfoPtr_GenerateRiverChunkInfo_Public_Int32_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683976);
		NativeMethodInfoPtr_GenerateVillageChunkInfo_Public_Int32_World_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683977);
		NativeMethodInfoPtr_generateCapitalCityExtensionChunkInfo_Private_Void_World_Coordinates_Queue_1_Coordinates_Int32_List_1_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683978);
		NativeMethodInfoPtr_generateVillageExtensionChunkInfo_Private_Void_World_Coordinates_List_1_Coordinates_Single_List_1_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683979);
		NativeMethodInfoPtr_getNeighborRiverNavTiles_Private_Void_World_ChunkNavTile_Coordinates_List_1_ChunkNavTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683980);
		NativeMethodInfoPtr_getNeighborRoadNavTiles_Private_Void_World_ChunkNavTile_Coordinates_List_1_ChunkNavTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683981);
		NativeMethodInfoPtr_GenerateRoadChunkInfo_Public_Int32_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683982);
		NativeMethodInfoPtr_tryAddingRoadBorderConnections_Private_Void_World_Coordinates_Coordinates_List_1_Tuple_2_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683983);
		NativeMethodInfoPtr_tryAddingRoadBorderConnection_Private_Boolean_World_Coordinates_Coordinates_List_1_Tuple_2_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683984);
		NativeMethodInfoPtr_roadBorderSourceValid_Private_Boolean_World_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683985);
		NativeMethodInfoPtr_GenerateRoadChunkInfo_Public_Int32_World_List_1_Tuple_2_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683986);
		NativeMethodInfoPtr_compareTileCoordinates_Private_Int32_ChunkNavTile_ChunkNavTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683987);
		NativeMethodInfoPtr_getMinCostDistanceTile_Private_ChunkNavTile_ICollection_1_ChunkNavTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683988);
		NativeMethodInfoPtr_findMatchingTile_Private_ChunkNavTile_ICollection_1_ChunkNavTile_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683989);
		NativeMethodInfoPtr_getPath_Private_Boolean_World_Coordinates_Coordinates_PathNavTileGetter_List_1_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683990);
		NativeMethodInfoPtr_GenerateResourceChunkInfos_Public_Int32_World_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683991);
		NativeMethodInfoPtr_GenerateSwampChunkInfos_Public_Int32_World_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683992);
		NativeMethodInfoPtr_GenerateBridgeChunkInfos_Public_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683993);
		NativeMethodInfoPtr_GenerateCliffChunkInfos_Public_Task_1_Int32_World_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683994);
		NativeMethodInfoPtr_tryAddCliff_Private_Boolean_World_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683995);
		NativeMethodInfoPtr_GenerateCaveChunkInfos_Public_Task_1_Int32_World_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683996);
		NativeMethodInfoPtr_tryAddCave_Private_Boolean_World_Coordinates_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683997);
		NativeMethodInfoPtr_GenerateRegionChunkData_Public_Void_RegionChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683998);
		NativeMethodInfoPtr_GenerateChunkData_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100683999);
		NativeMethodInfoPtr_generateTerrainTypes_Private_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684000);
		NativeMethodInfoPtr_generateTerrainTypesForHeightmapPoint_Private_Void_Int32_Coordinates_Vector2_Int32_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684001);
		NativeMethodInfoPtr_generateHeightmap_Private_Void_RegionChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684002);
		NativeMethodInfoPtr_generateHeightmap_Private_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684003);
		NativeMethodInfoPtr_GenerateHeightForPoint_Public_Single_World_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684004);
		NativeMethodInfoPtr_generateHeightForPoint_Private_Single_byref_WorldGenerationHeightData_Vector2_Single_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684005);
		NativeMethodInfoPtr_GenerateSlopeData_Public_Void_Chunk_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684006);
		NativeMethodInfoPtr_CalculateSlopeData_Public_Void_Chunk_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684007);
		NativeMethodInfoPtr_calculateSlope_Private_Vector2_Coordinates_Il2CppObjectBase_Vector2_Int32_byref_WorldGenerationHeightData_Single_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684008);
		NativeMethodInfoPtr_calculateSlope_Private_Vector2_Il2CppObjectBase_Int32_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684009);
		NativeMethodInfoPtr_GenerateWaterMap_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684010);
		NativeMethodInfoPtr_generateTerrainTextures_Private_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684011);
		NativeMethodInfoPtr_generateTerrainTextures_Private_Void_RegionChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684012);
		NativeMethodInfoPtr_IncrementTerrainTexture_Public_Void_Dictionary_2_TextureType_Int32_Il2CppObjectBase_Int32_Int32_TextureType_Single_Single_List_1_TextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684013);
		NativeMethodInfoPtr_SetTerrainTexture_Public_Void_Dictionary_2_TextureType_Int32_Il2CppObjectBase_Int32_Int32_TextureType_Single_List_1_TextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684014);
		NativeMethodInfoPtr_SetTerrainTexture_Public_Void_Il2CppObjectBase_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684015);
		NativeMethodInfoPtr_PaintTerrainTexture_Public_Void_Chunk_QueuedTexturePaint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684016);
		NativeMethodInfoPtr_PaintTerrainTexture_Public_Void_Chunk_Single_Single_TextureType_Single_Single_Single_FalloffType_List_1_TextureType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684017);
		NativeMethodInfoPtr_RectanglePaintTerrainTexture_Public_Void_Chunk_QueuedTextureRectanglePaint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684018);
		NativeMethodInfoPtr_RectanglePaintTerrainTexture_Public_Void_Chunk_Single_Single_TextureType_Single_Single_Single_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684019);
		NativeMethodInfoPtr_PaintClearedSnow_Public_Void_Chunk_QueuedClearedSnowPaint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684020);
		NativeMethodInfoPtr_PaintClearedSnow_Public_Void_Chunk_Single_Single_Single_PaintInfo_Boolean_Boolean_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684021);
		NativeMethodInfoPtr_processHeightAffectingTextures_Private_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684022);
		NativeMethodInfoPtr_getHeight_Private_Single_World_Coordinates_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684023);
		NativeMethodInfoPtr_PaintTerrainHeight_Public_Single_Chunk_Single_Single_Single_Single_Single_List_1_TextureType_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684024);
		NativeMethodInfoPtr_AdjustTerrainHeightAtPoint_Public_Single_Chunk_TerrainPoint_Single_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684025);
		NativeMethodInfoPtr_SmoothTerrainHeight_Public_Single_Chunk_Single_Single_Single_Single_List_1_TextureType_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684026);
		NativeMethodInfoPtr_LevelTerrainHeight_Public_Single_Chunk_Single_Single_Single_Single_Single_List_1_TextureType_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684027);
		NativeMethodInfoPtr_generateTerrainLayerZones_Private_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684028);
		NativeMethodInfoPtr_CheckZone_Public_Boolean_Chunk_Int32_Int32_Queue_1_ValueTuple_2_Int32_Int32_HashSet_1_ValueTuple_2_Int32_Int32_List_1_ValueTuple_2_Int32_Int32_Int32_Int32_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684029);
		NativeMethodInfoPtr_processSecondaryHeightFilters_Private_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684030);
		NativeMethodInfoPtr_GenerateDiseaseMap_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684031);
		NativeMethodInfoPtr_generateEnvironmentObjects_Private_Void_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684032);
		NativeMethodInfoPtr_findSubObjectPlacement_Private_Boolean_Chunk_Int32_Int32_WorldGenSubObject_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684033);
		NativeMethodInfoPtr_FindObjectPlacement_Public_Boolean_Chunk_String_byref_EntityCreationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684034);
		NativeMethodInfoPtr_ValidateObjectPlacement_Public_Boolean_Chunk_String_Vector3_byref_EntityCreationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684035);
		NativeMethodInfoPtr_isObjectPlacementValid_Private_Boolean_Chunk_WorldGenObject_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684036);
		NativeMethodInfoPtr_placeObject_Private_Void_Chunk_Int32_Int32_Single_Single_String_Int32_Single_Single_Boolean_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684037);
		NativeMethodInfoPtr_generateStructures_Private_Void_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684038);
		NativeMethodInfoPtr_generateCaves_Private_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684039);
		NativeMethodInfoPtr_GenerateCaveChunkResources_Public_Void_Chunk_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684040);
		NativeMethodInfoPtr_processCaveResourceNodePosition_Private_Void_Chunk_CaveNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684041);
		NativeMethodInfoPtr_getValidCaveSurfacePlacement_Private_Boolean_Vector3_Vector3_Boolean_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684042);
		NativeMethodInfoPtr_isCaveResourcePositionValid_Private_Boolean_Chunk_WorldGenObject_CaveData_CaveNode_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684043);
		NativeMethodInfoPtr_generateFeatures_Private_Void_Chunk_Boolean_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684044);
		NativeMethodInfoPtr_GenerateHoleMap_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684045);
		NativeMethodInfoPtr_GenerateTerrainDetailMaps_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684046);
		NativeMethodInfoPtr_GenerateTerrainDetailMaps_Public_Void_Chunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684047);
		NativeMethodInfoPtr_GenerateDetailObjectPlacementInfo_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684048);
		NativeMethodInfoPtr_GenerateDetailObjectPlacementInfo_Public_Void_Chunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684049);
		NativeMethodInfoPtr_DeleteDetails_Public_HashSet_1_Coordinates_Chunk_Single_Single_Single_Single_List_1_TextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684050);
		NativeMethodInfoPtr_checkHeights_Private_Boolean_Chunk_Int32_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684051);
		NativeMethodInfoPtr_CheckTakenPositions_Public_Boolean_Chunk_Int32_Int32_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684052);
		NativeMethodInfoPtr_MarkPositionTaken_Public_Void_Coordinates_Int32_Vector3_Vector2_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684053);
		NativeMethodInfoPtr_MarkPositionTaken_Public_Void_Int32_Int32_Int32_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684054);
		NativeMethodInfoPtr_MarkPositionTaken_Public_Void_Coordinates_Int32_Vector3_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684055);
		NativeMethodInfoPtr_GenerateCaveMeshData_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684056);
		NativeMethodInfoPtr_GenerateTerrain_Public_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684057);
		NativeMethodInfoPtr_GenerateFeature_Public_Void_IWorldGenerationFeatureInfo_World_Chunk_Boolean_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr, 100684058);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272598, RefRangeEnd = 272599, XrefRangeStart = 272495, XrefRangeEnd = 272598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldGenerator(WorldGen config, ITaskManager taskManager, IAIManager aiManager, IInventoryManager inventoryManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldGenerator>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)config);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aiManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inventoryManager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_WorldGen_ITaskManager_IAIManager_IInventoryManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272602, RefRangeEnd = 272603, XrefRangeStart = 272599, XrefRangeEnd = 272602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IWorldGenerationFeature GetFeature(WorldGenerationFeatureType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFeature_Public_IWorldGenerationFeature_WorldGenerationFeatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWorldGenerationFeature>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272607, RefRangeEnd = 272608, XrefRangeStart = 272603, XrefRangeEnd = 272607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTerrainTypeLayer(TerrainTypeLayer layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTerrainTypeLayer_Public_Void_TerrainTypeLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTerrainHeightLayer(IBaseTerrainHeightLayer baseTerrainHeightLayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseTerrainHeightLayer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTerrainHeightLayer_Public_Void_IBaseTerrainHeightLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 272612, RefRangeEnd = 272614, XrefRangeStart = 272608, XrefRangeEnd = 272612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMinMaxHeightFilterLayer(ITerrainMinMaxHeightFilterLayer layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMinMaxHeightFilterLayer_Public_Void_ITerrainMinMaxHeightFilterLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 272618, RefRangeEnd = 272629, XrefRangeStart = 272614, XrefRangeEnd = 272618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddHeightFilterLayer(ITerrainHeightFilterLayer layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddHeightFilterLayer_Public_Void_ITerrainHeightFilterLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272629, XrefRangeEnd = 272633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSecondaryHeightFilterLayer(ISecondaryTerrainHeightFilterLayer layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSecondaryHeightFilterLayer_Public_Void_ISecondaryTerrainHeightFilterLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272672, RefRangeEnd = 272673, XrefRangeStart = 272633, XrefRangeEnd = 272672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBaseTerrainTextureLayers(List<BaseTerrainTextureLayer> layers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layers);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBaseTerrainTextureLayers_Public_Void_List_1_BaseTerrainTextureLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272701, RefRangeEnd = 272702, XrefRangeStart = 272673, XrefRangeEnd = 272701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTerrainTextureLayer(int terrainTypeIndex, ITerrainTextureLayer layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&terrainTypeIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTerrainTextureLayer_Public_Void_Int32_ITerrainTextureLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 272706, RefRangeEnd = 272710, XrefRangeStart = 272702, XrefRangeEnd = 272706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddStructureGenerator(IStructureGenerator structureGenerator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)structureGenerator);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddStructureGenerator_Public_Void_IStructureGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVoxelCaveChunkGenerator(VoxelCaveChunkGenerator voxelCaveChunkGenerator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)voxelCaveChunkGenerator);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVoxelCaveChunkGenerator_Public_Void_VoxelCaveChunkGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTerrainVoxelGenerator(TerrainVoxelGenerator terrainVoxelGenerator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainVoxelGenerator);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTerrainVoxelGenerator_Public_Void_TerrainVoxelGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272721, RefRangeEnd = 272722, XrefRangeStart = 272710, XrefRangeEnd = 272721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task GenerateChunkInfos(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateChunkInfos_Public_Task_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 272749, RefRangeEnd = 272751, XrefRangeStart = 272722, XrefRangeEnd = 272749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkInfo GenerateChunkInfo(World world, Coordinates coordinates, Il2CppStructArray<float> terrainTypes = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainTypes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateChunkInfo_Public_ChunkInfo_World_Coordinates_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChunkInfo>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 272788, RefRangeEnd = 272792, XrefRangeStart = 272751, XrefRangeEnd = 272788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sampleChunkInfo(World world, Coordinates coordinates, ChunkInfo info, Il2CppStructArray<float> sampledTerrainTypes = null, bool sampleHeights = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sampledTerrainTypes);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sampleHeights;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sampleChunkInfo_Private_Void_World_Coordinates_ChunkInfo_Il2CppStructArray_1_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272792, XrefRangeEnd = 272802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float sampleHeight(World world, ref WorldGenerationHeightData data, Coordinates coordinates, Il2CppStructArray<float> sampledTerrainTypes, int heightmapResolution, Vector2 seedOffset, int heightmapI, int heightmapJ, float chunkTerrainSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sampledTerrainTypes);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapResolution;
		*(Vector2**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkTerrainSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sampleHeight_Private_Single_World_byref_WorldGenerationHeightData_Coordinates_Il2CppStructArray_1_Single_Int32_Vector2_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 272853, RefRangeEnd = 272855, XrefRangeStart = 272802, XrefRangeEnd = 272853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void findAllNeighborChunkInfos(World world, Coordinates coordinates, HashSet<Coordinates> resultCoordinates, Il2CppSystem.Func<ChunkInfo, Coordinates, bool> checker)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultCoordinates);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)checker);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findAllNeighborChunkInfos_Private_Void_World_Coordinates_HashSet_1_Coordinates_Func_3_ChunkInfo_Coordinates_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 272937, RefRangeEnd = 272938, XrefRangeStart = 272855, XrefRangeEnd = 272937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GenerateRiverChunkInfo(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRiverChunkInfo_Public_Int32_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 273101, RefRangeEnd = 273104, XrefRangeStart = 272938, XrefRangeEnd = 273101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GenerateVillageChunkInfo(World world, int numToGenerate, bool generateSeasideVillage = true, bool generateCapitalCity = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numToGenerate;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateSeasideVillage;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateCapitalCity;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateVillageChunkInfo_Public_Int32_World_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 273178, RefRangeEnd = 273179, XrefRangeStart = 273104, XrefRangeEnd = 273178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateCapitalCityExtensionChunkInfo(World world, Coordinates startCoordinates, Queue<Coordinates> coordinatesToCheck, int minAmount, List<Coordinates> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startCoordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)coordinatesToCheck);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &minAmount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateCapitalCityExtensionChunkInfo_Private_Void_World_Coordinates_Queue_1_Coordinates_Int32_List_1_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 273241, RefRangeEnd = 273244, XrefRangeStart = 273179, XrefRangeEnd = 273241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateVillageExtensionChunkInfo(World world, Coordinates startCoordinates, List<Coordinates> neighborCoordinates, float chance, List<Coordinates> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startCoordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)neighborCoordinates);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &chance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateVillageExtensionChunkInfo_Private_Void_World_Coordinates_List_1_Coordinates_Single_List_1_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273244, XrefRangeEnd = 273316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getNeighborRiverNavTiles(World world, ChunkNavTile currentTile, Coordinates targetCoordinates, List<ChunkNavTile> resultTiles)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentTile);
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCoordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultTiles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNeighborRiverNavTiles_Private_Void_World_ChunkNavTile_Coordinates_List_1_ChunkNavTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273316, XrefRangeEnd = 273394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getNeighborRoadNavTiles(World world, ChunkNavTile currentTile, Coordinates targetCoordinates, List<ChunkNavTile> resultTiles)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentTile);
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCoordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultTiles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNeighborRoadNavTiles_Private_Void_World_ChunkNavTile_Coordinates_List_1_ChunkNavTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 273441, RefRangeEnd = 273442, XrefRangeStart = 273394, XrefRangeEnd = 273441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GenerateRoadChunkInfo(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRoadChunkInfo_Public_Int32_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 273454, RefRangeEnd = 273456, XrefRangeStart = 273442, XrefRangeEnd = 273454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void tryAddingRoadBorderConnections(World world, Coordinates regionMin, Coordinates regionMax, List<Il2CppSystem.Tuple<Coordinates, Coordinates>> pairs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &regionMin;
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &regionMax;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tryAddingRoadBorderConnections_Private_Void_World_Coordinates_Coordinates_List_1_Tuple_2_Coordinates_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 273500, RefRangeEnd = 273504, XrefRangeStart = 273456, XrefRangeEnd = 273500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool tryAddingRoadBorderConnection(World world, Coordinates minCoordinates, Coordinates maxCoordinates, List<Il2CppSystem.Tuple<Coordinates, Coordinates>> pairs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minCoordinates;
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxCoordinates;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tryAddingRoadBorderConnection_Private_Boolean_World_Coordinates_Coordinates_List_1_Tuple_2_Coordinates_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273504, XrefRangeEnd = 273510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool roadBorderSourceValid(World world, Coordinates coordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_roadBorderSourceValid_Private_Boolean_World_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 273599, RefRangeEnd = 273601, XrefRangeStart = 273510, XrefRangeEnd = 273599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GenerateRoadChunkInfo(World world, List<Il2CppSystem.Tuple<Coordinates, Coordinates>> pairs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRoadChunkInfo_Public_Int32_World_List_1_Tuple_2_Coordinates_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273601, XrefRangeEnd = 273602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int compareTileCoordinates(ChunkNavTile tile1, ChunkNavTile tile2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tile1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tile2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compareTileCoordinates_Private_Int32_ChunkNavTile_ChunkNavTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 273620, RefRangeEnd = 273621, XrefRangeStart = 273602, XrefRangeEnd = 273620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkNavTile getMinCostDistanceTile(ICollection<ChunkNavTile> tiles)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tiles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMinCostDistanceTile_Private_ChunkNavTile_ICollection_1_ChunkNavTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChunkNavTile>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 273637, RefRangeEnd = 273638, XrefRangeStart = 273621, XrefRangeEnd = 273637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkNavTile findMatchingTile(ICollection<ChunkNavTile> tiles, Coordinates targetCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tiles);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetCoordinates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findMatchingTile_Private_ChunkNavTile_ICollection_1_ChunkNavTile_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChunkNavTile>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 273710, RefRangeEnd = 273712, XrefRangeStart = 273638, XrefRangeEnd = 273710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool getPath(World world, Coordinates start, Coordinates end, PathNavTileGetter neighborGetter, List<Coordinates> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)neighborGetter);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getPath_Private_Boolean_World_Coordinates_Coordinates_PathNavTileGetter_List_1_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273712, XrefRangeEnd = 273809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GenerateResourceChunkInfos(World world, Coordinates startingCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingCoordinates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateResourceChunkInfos_Public_Int32_World_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 273952, RefRangeEnd = 273953, XrefRangeStart = 273809, XrefRangeEnd = 273952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GenerateSwampChunkInfos(World world, Coordinates startingCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingCoordinates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSwampChunkInfos_Public_Int32_World_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 273989, RefRangeEnd = 273990, XrefRangeStart = 273953, XrefRangeEnd = 273989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateBridgeChunkInfos(World world)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateBridgeChunkInfos_Public_Void_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274005, RefRangeEnd = 274006, XrefRangeStart = 273990, XrefRangeEnd = 274005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task<int> GenerateCliffChunkInfos(World world, Coordinates startingCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingCoordinates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCliffChunkInfos_Public_Task_1_Int32_World_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 274105, RefRangeEnd = 274107, XrefRangeStart = 274006, XrefRangeEnd = 274105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool tryAddCliff(World world, Coordinates startingCoordinates, Coordinates cliffCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingCoordinates;
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cliffCoordinates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tryAddCliff_Private_Boolean_World_Coordinates_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274122, RefRangeEnd = 274123, XrefRangeStart = 274107, XrefRangeEnd = 274122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task<int> GenerateCaveChunkInfos(World world, Coordinates startingCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingCoordinates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCaveChunkInfos_Public_Task_1_Int32_World_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 274251, RefRangeEnd = 274253, XrefRangeStart = 274123, XrefRangeEnd = 274251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool tryAddCave(World world, Coordinates startingCoordinates, Coordinates caveCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startingCoordinates;
		*(Coordinates**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &caveCoordinates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tryAddCave_Private_Boolean_World_Coordinates_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274255, RefRangeEnd = 274256, XrefRangeStart = 274253, XrefRangeEnd = 274255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateRegionChunkData(RegionChunk regionChunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionChunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRegionChunkData_Public_Void_RegionChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274298, RefRangeEnd = 274299, XrefRangeStart = 274256, XrefRangeEnd = 274298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateChunkData(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateChunkData_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274313, RefRangeEnd = 274314, XrefRangeStart = 274299, XrefRangeEnd = 274313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateTerrainTypes(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateTerrainTypes_Private_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274314, XrefRangeEnd = 274331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateTerrainTypesForHeightmapPoint(int heightmapResolution, Coordinates coordinates, Vector2 seedOffset, int heightmapI, int heightmapJ, Il2CppStructArray<float> resultTerrainTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&heightmapResolution);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultTerrainTypes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateTerrainTypesForHeightmapPoint_Private_Void_Int32_Coordinates_Vector2_Int32_Int32_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274352, RefRangeEnd = 274353, XrefRangeStart = 274331, XrefRangeEnd = 274352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateHeightmap(RegionChunk regionChunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionChunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateHeightmap_Private_Void_RegionChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274385, RefRangeEnd = 274386, XrefRangeStart = 274353, XrefRangeEnd = 274385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateHeightmap(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateHeightmap_Private_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274405, RefRangeEnd = 274406, XrefRangeStart = 274386, XrefRangeEnd = 274405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GenerateHeightForPoint(World world, Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateHeightForPoint_Public_Single_World_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274406, XrefRangeEnd = 274446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float generateHeightForPoint(ref WorldGenerationHeightData data, Vector2 seedOffset, float maxTerrainHeight, int i, int j, int heightmapResolution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxTerrainHeight;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapResolution;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateHeightForPoint_Private_Single_byref_WorldGenerationHeightData_Vector2_Single_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 274461, RefRangeEnd = 274464, XrefRangeStart = 274446, XrefRangeEnd = 274461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateSlopeData(Chunk chunk, bool initialGeneration = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &initialGeneration;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSlopeData_Public_Void_Chunk_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 274473, RefRangeEnd = 274476, XrefRangeStart = 274464, XrefRangeEnd = 274473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateSlopeData(Chunk chunk, int minJ, int minI, int maxJ, int maxI, bool initialGeneration = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minJ;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minI;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxJ;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxI;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &initialGeneration;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSlopeData_Public_Void_Chunk_Int32_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274500, RefRangeEnd = 274501, XrefRangeStart = 274476, XrefRangeEnd = 274500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 calculateSlope(Coordinates coordinates, Il2CppObjectBase heightmap, Vector2 seedOffset, int heightmapResolution, ref WorldGenerationHeightData data, float maxTerrainHeight, int i, int j, bool initialGeneration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&coordinates);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(heightmap);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seedOffset;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapResolution;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxTerrainHeight;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &initialGeneration;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calculateSlope_Private_Vector2_Coordinates_Il2CppObjectBase_Vector2_Int32_byref_WorldGenerationHeightData_Single_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Vector2 calculateSlope(Il2CppObjectBase heightmap, int heightmapSize, float terrainSize, int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(heightmap);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapSize;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainSize;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_calculateSlope_Private_Vector2_Il2CppObjectBase_Int32_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274513, RefRangeEnd = 274514, XrefRangeStart = 274501, XrefRangeEnd = 274513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateWaterMap(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateWaterMap_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274603, RefRangeEnd = 274604, XrefRangeStart = 274514, XrefRangeEnd = 274603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateTerrainTextures(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateTerrainTextures_Private_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274698, RefRangeEnd = 274699, XrefRangeStart = 274604, XrefRangeEnd = 274698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateTerrainTextures(RegionChunk regionChunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionChunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateTerrainTextures_Private_Void_RegionChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 274706, RefRangeEnd = 274708, XrefRangeStart = 274699, XrefRangeEnd = 274706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementTerrainTexture(Dictionary<TextureType, int> textureLayerMap, Il2CppObjectBase alphaMaps, int i, int j, TextureType paintedTextureType, float incrementAmount, float maxOpacity, List<TextureType> requiredTextures = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureLayerMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(alphaMaps);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(TextureType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintedTextureType;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &incrementAmount;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxOpacity;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredTextures);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementTerrainTexture_Public_Void_Dictionary_2_TextureType_Int32_Il2CppObjectBase_Int32_Int32_TextureType_Single_Single_List_1_TextureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 274774, RefRangeEnd = 274776, XrefRangeStart = 274708, XrefRangeEnd = 274774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTerrainTexture(Dictionary<TextureType, int> textureLayerMap, Il2CppObjectBase alphaMaps, int i, int j, TextureType paintedTextureType, float opacity, List<TextureType> requiredTextures = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textureLayerMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(alphaMaps);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(TextureType**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintedTextureType;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredTextures);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTerrainTexture_Public_Void_Dictionary_2_TextureType_Int32_Il2CppObjectBase_Int32_Int32_TextureType_Single_List_1_TextureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 274779, RefRangeEnd = 274781, XrefRangeStart = 274776, XrefRangeEnd = 274779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTerrainTexture(Il2CppObjectBase alphaMaps, int i, int j, int textureIndex, float opacity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(alphaMaps);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureIndex;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTerrainTexture_Public_Void_Il2CppObjectBase_Int32_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 274782, RefRangeEnd = 274784, XrefRangeStart = 274781, XrefRangeEnd = 274782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PaintTerrainTexture(Chunk chunk, QueuedTexturePaint paint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)paint));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PaintTerrainTexture_Public_Void_Chunk_QueuedTexturePaint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 274824, RefRangeEnd = 274830, XrefRangeStart = 274784, XrefRangeEnd = 274824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PaintTerrainTexture(Chunk chunk, float x, float z, TextureType textureType, float opacity, float maxOpacity, float brushSize, FalloffType falloffType = FalloffType.LINEAR, List<TextureType> existingTextureFilter = null, bool queueOtherChunkUpdates = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(TextureType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureType;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxOpacity;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &brushSize;
		*(FalloffType**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &falloffType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)existingTextureFilter);
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &queueOtherChunkUpdates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PaintTerrainTexture_Public_Void_Chunk_Single_Single_TextureType_Single_Single_Single_FalloffType_List_1_TextureType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 274831, RefRangeEnd = 274833, XrefRangeStart = 274830, XrefRangeEnd = 274831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RectanglePaintTerrainTexture(Chunk chunk, QueuedTextureRectanglePaint paint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(QueuedTextureRectanglePaint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paint;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RectanglePaintTerrainTexture_Public_Void_Chunk_QueuedTextureRectanglePaint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 274886, RefRangeEnd = 274888, XrefRangeStart = 274833, XrefRangeEnd = 274886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RectanglePaintTerrainTexture(Chunk chunk, float x, float z, TextureType textureType, float opacity, float angle, float width, float height, bool clearTerrainTypes, bool queueOtherChunkUpdates = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(TextureType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureType;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearTerrainTypes;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &queueOtherChunkUpdates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RectanglePaintTerrainTexture_Public_Void_Chunk_Single_Single_TextureType_Single_Single_Single_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 274889, RefRangeEnd = 274890, XrefRangeStart = 274888, XrefRangeEnd = 274889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PaintClearedSnow(Chunk chunk, QueuedClearedSnowPaint paint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(QueuedClearedSnowPaint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &paint;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PaintClearedSnow_Public_Void_Chunk_QueuedClearedSnowPaint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 274949, RefRangeEnd = 274957, XrefRangeStart = 274890, XrefRangeEnd = 274949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PaintClearedSnow(Chunk chunk, float x, float z, float opacity, PaintInfo paintInfo, bool decreaseAtEdges = true, bool capStrength = false, float maxOpacity = 1f, bool queueOtherChunkUpdates = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		*(PaintInfo**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &paintInfo;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &decreaseAtEdges;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &capStrength;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxOpacity;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &queueOtherChunkUpdates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PaintClearedSnow_Public_Void_Chunk_Single_Single_Single_PaintInfo_Boolean_Boolean_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275006, RefRangeEnd = 275007, XrefRangeStart = 274957, XrefRangeEnd = 275006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void processHeightAffectingTextures(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_processHeightAffectingTextures_Private_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 275008, RefRangeEnd = 275013, XrefRangeStart = 275007, XrefRangeEnd = 275008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getHeight(World world, Coordinates chunkCoordinates, int heightmapResolution, int heightmapI, int heightmapJ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkCoordinates;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapResolution;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getHeight_Private_Single_World_Coordinates_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275141, RefRangeEnd = 275142, XrefRangeStart = 275013, XrefRangeEnd = 275141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float PaintTerrainHeight(Chunk chunk, float x, float z, float radius, float adjustmentAmount, float maxAdjustment, List<TextureType> ignoredTextures, List<TerrainAdjustmentInfo> resultAdjustmentInfos, HashSet<Coordinates> resultAffectedHeightmapCoordinates, bool ignoreSolidObjectTakenPositions = false, bool avoidFurtherTerrain = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &adjustmentAmount;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxAdjustment;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoredTextures);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustmentInfos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAffectedHeightmapCoordinates);
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreSolidObjectTakenPositions;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &avoidFurtherTerrain;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PaintTerrainHeight_Public_Single_Chunk_Single_Single_Single_Single_Single_List_1_TextureType_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275154, RefRangeEnd = 275155, XrefRangeStart = 275142, XrefRangeEnd = 275154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float AdjustTerrainHeightAtPoint(Chunk chunk, TerrainPoint point, float adjustment, List<TerrainAdjustmentInfo> resultAdjustmentInfos, HashSet<Coordinates> resultAffectedHeightmapCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(TerrainPoint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &adjustment;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustmentInfos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAffectedHeightmapCoordinates);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AdjustTerrainHeightAtPoint_Public_Single_Chunk_TerrainPoint_Single_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275235, RefRangeEnd = 275236, XrefRangeStart = 275155, XrefRangeEnd = 275235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float SmoothTerrainHeight(Chunk chunk, float x, float z, float radius, float strength, List<TextureType> ignoredTextures, List<TerrainAdjustmentInfo> resultAdjustmentInfos, HashSet<Coordinates> resultAffectedHeightmapCoordinates, bool ignoreSolidObjectTakenPositions = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoredTextures);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustmentInfos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAffectedHeightmapCoordinates);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreSolidObjectTakenPositions;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothTerrainHeight_Public_Single_Chunk_Single_Single_Single_Single_List_1_TextureType_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275307, RefRangeEnd = 275308, XrefRangeStart = 275236, XrefRangeEnd = 275307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float LevelTerrainHeight(Chunk chunk, float x, float z, float levelHeight, float radius, float strength, List<TextureType> ignoredTextures, List<TerrainAdjustmentInfo> resultAdjustmentInfos, HashSet<Coordinates> resultAffectedHeightmapCoordinates, bool ignoreSolidObjectTakenPositions = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelHeight;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &strength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignoredTextures);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAdjustmentInfos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultAffectedHeightmapCoordinates);
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreSolidObjectTakenPositions;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LevelTerrainHeight_Public_Single_Chunk_Single_Single_Single_Single_Single_List_1_TextureType_List_1_TerrainAdjustmentInfo_HashSet_1_Coordinates_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275413, RefRangeEnd = 275414, XrefRangeStart = 275308, XrefRangeEnd = 275413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateTerrainLayerZones(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateTerrainLayerZones_Private_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 275470, RefRangeEnd = 275472, XrefRangeStart = 275414, XrefRangeEnd = 275470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckZone(Chunk chunk, int alphamapI, int alphamapJ, Queue<Il2CppSystem.ValueTuple<int, int>> pointsToCheck, HashSet<Il2CppSystem.ValueTuple<int, int>> allCheckedPoints, List<Il2CppSystem.ValueTuple<int, int>> zonePoints, int textureIndex, int chunkSize, out Vector3 centerPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alphamapI;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &alphamapJ;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointsToCheck);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allCheckedPoints);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)zonePoints);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureIndex;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkSize;
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref centerPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckZone_Public_Boolean_Chunk_Int32_Int32_Queue_1_ValueTuple_2_Int32_Int32_HashSet_1_ValueTuple_2_Int32_Int32_List_1_ValueTuple_2_Int32_Int32_Int32_Int32_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275494, RefRangeEnd = 275495, XrefRangeStart = 275472, XrefRangeEnd = 275494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void processSecondaryHeightFilters(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_processSecondaryHeightFilters_Private_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 275598, RefRangeEnd = 275601, XrefRangeStart = 275495, XrefRangeEnd = 275598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateDiseaseMap(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDiseaseMap_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275714, RefRangeEnd = 275715, XrefRangeStart = 275601, XrefRangeEnd = 275714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateEnvironmentObjects(Chunk chunk, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateEnvironmentObjects_Private_Void_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275719, RefRangeEnd = 275720, XrefRangeStart = 275715, XrefRangeEnd = 275719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool findSubObjectPlacement(Chunk chunk, int i, int j, WorldGenSubObject subObject, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions, out int newHeightmapX, out int newHeightmapY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref newHeightmapX);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref newHeightmapY);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findSubObjectPlacement_Private_Boolean_Chunk_Int32_Int32_WorldGenSubObject_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 275754, RefRangeEnd = 275756, XrefRangeStart = 275720, XrefRangeEnd = 275754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FindObjectPlacement(Chunk chunk, string identifier, out EntityCreationInfo placementInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindObjectPlacement_Public_Boolean_Chunk_String_byref_EntityCreationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		placementInfo = ((num3 == 0) ? null : new EntityCreationInfo(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 275800, RefRangeEnd = 275802, XrefRangeStart = 275756, XrefRangeEnd = 275800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidateObjectPlacement(Chunk chunk, string identifier, Vector3 position, out EntityCreationInfo placementInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateObjectPlacement_Public_Boolean_Chunk_String_Vector3_byref_EntityCreationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		placementInfo = ((num3 == 0) ? null : new EntityCreationInfo(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 275836, RefRangeEnd = 275838, XrefRangeStart = 275802, XrefRangeEnd = 275836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isObjectPlacementValid(Chunk chunk, WorldGenObject obj, int i, int j, float terrainTypeAmount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &terrainTypeAmount;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isObjectPlacementValid_Private_Boolean_Chunk_WorldGenObject_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 275854, RefRangeEnd = 275856, XrefRangeStart = 275838, XrefRangeEnd = 275854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void placeObject(Chunk chunk, int heightmapI, int heightmapJ, float offsetX, float offsetY, string identifier, int itemAmount, float clearance, float slopeCompensationFactor, bool alignToSurface, float grownPercentage, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetX;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetY;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(identifier);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemAmount;
		*(float**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearance;
		*(float**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &slopeCompensationFactor;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignToSurface;
		*(float**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &grownPercentage;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_placeObject_Private_Void_Chunk_Int32_Int32_Single_Single_String_Int32_Single_Single_Boolean_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275879, RefRangeEnd = 275880, XrefRangeStart = 275856, XrefRangeEnd = 275879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateStructures(Chunk chunk, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateStructures_Private_Void_Chunk_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275880, XrefRangeEnd = 275883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateCaves(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateCaves_Private_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 275909, RefRangeEnd = 275910, XrefRangeStart = 275883, XrefRangeEnd = 275909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateCaveChunkResources(Chunk chunk, Coordinates caveChunkCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &caveChunkCoordinates;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCaveChunkResources_Public_Void_Chunk_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 276020, RefRangeEnd = 276021, XrefRangeStart = 275910, XrefRangeEnd = 276020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void processCaveResourceNodePosition(Chunk chunk, CaveNode caveNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(CaveNode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &caveNode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_processCaveResourceNodePosition_Private_Void_Chunk_CaveNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 276081, RefRangeEnd = 276083, XrefRangeStart = 276021, XrefRangeEnd = 276081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool getValidCaveSurfacePlacement(Vector3 nodeWorldPosition, Vector3 direction, bool edgeTest, out Vector3 surfacePosition, out Quaternion surfaceRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&nodeWorldPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &edgeTest;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref surfacePosition);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref surfaceRotation);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getValidCaveSurfacePlacement_Private_Boolean_Vector3_Vector3_Boolean_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 276089, RefRangeEnd = 276090, XrefRangeStart = 276083, XrefRangeEnd = 276089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isCaveResourcePositionValid(Chunk chunk, WorldGenObject obj, CaveData caveData, CaveNode caveNode, Vector3 surfacePosition, Quaternion surfaceRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveData);
		*(CaveNode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &caveNode;
		*(Vector3**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &surfacePosition;
		*(Quaternion**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &surfaceRotation;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isCaveResourcePositionValid_Private_Boolean_Chunk_WorldGenObject_CaveData_CaveNode_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 276168, RefRangeEnd = 276170, XrefRangeStart = 276090, XrefRangeEnd = 276168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void generateFeatures(Chunk chunk, bool inCave, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inCave;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateFeatures_Private_Void_Chunk_Boolean_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 276190, RefRangeEnd = 276193, XrefRangeStart = 276170, XrefRangeEnd = 276190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateHoleMap(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateHoleMap_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 276196, RefRangeEnd = 276198, XrefRangeStart = 276193, XrefRangeEnd = 276196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateTerrainDetailMaps(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateTerrainDetailMaps_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 276253, RefRangeEnd = 276256, XrefRangeStart = 276198, XrefRangeEnd = 276253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateTerrainDetailMaps(Chunk chunk, int cellX, int cellY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateTerrainDetailMaps_Public_Void_Chunk_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 276259, RefRangeEnd = 276261, XrefRangeStart = 276256, XrefRangeEnd = 276259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateDetailObjectPlacementInfo(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDetailObjectPlacementInfo_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 276286, RefRangeEnd = 276290, XrefRangeStart = 276261, XrefRangeEnd = 276286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateDetailObjectPlacementInfo(Chunk chunk, int cellX, int cellY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cellY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDetailObjectPlacementInfo_Public_Void_Chunk_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276290, XrefRangeEnd = 276315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Coordinates> DeleteDetails(Chunk chunk, float x, float z, float opacity, float brushSize, List<TextureType> requiredTextures = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &opacity;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &brushSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requiredTextures);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteDetails_Public_HashSet_1_Coordinates_Chunk_Single_Single_Single_Single_List_1_TextureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<Coordinates>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe bool checkHeights(Chunk chunk, int heightmapX, int heightmapY, float radius, float heightmapValue, float tolerance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapY;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapValue;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &tolerance;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkHeights_Private_Boolean_Chunk_Int32_Int32_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 276315, RefRangeEnd = 276317, XrefRangeStart = 276315, XrefRangeEnd = 276315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckTakenPositions(Chunk chunk, int heightmapI, int heightmapJ, float radius, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapI;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapJ;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckTakenPositions_Public_Boolean_Chunk_Int32_Int32_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 276317, RefRangeEnd = 276318, XrefRangeStart = 276317, XrefRangeEnd = 276317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkPositionTaken(Coordinates coordinates, int chunkSize, Vector3 position, Vector2 size, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&coordinates);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkSize;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkPositionTaken_Public_Void_Coordinates_Int32_Vector3_Vector2_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 276321, RefRangeEnd = 276323, XrefRangeStart = 276318, XrefRangeEnd = 276321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkPositionTaken(int chunkSize, int i, int j, float radius, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&chunkSize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkPositionTaken_Public_Void_Int32_Int32_Int32_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 276325, RefRangeEnd = 276328, XrefRangeStart = 276323, XrefRangeEnd = 276325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkPositionTaken(Coordinates coordinates, int chunkSize, Vector3 position, float radius, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&coordinates);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkSize;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkPositionTaken_Public_Void_Coordinates_Int32_Vector3_Single_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 276330, RefRangeEnd = 276332, XrefRangeStart = 276328, XrefRangeEnd = 276330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateCaveMeshData(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCaveMeshData_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276332, XrefRangeEnd = 276335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateTerrain(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateTerrain_Public_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 276351, RefRangeEnd = 276353, XrefRangeStart = 276335, XrefRangeEnd = 276351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateFeature(IWorldGenerationFeatureInfo featureInfo, World world, Chunk chunk, bool inCave, Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)featureInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)world);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inCave;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateFeature_Public_Void_IWorldGenerationFeatureInfo_World_Chunk_Boolean_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldGenerator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

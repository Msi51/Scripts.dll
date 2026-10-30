using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Netcode;

public sealed class TerrainDetailmapUpdateMessage : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0, Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_detailmap;

	private static readonly System.IntPtr NativeFieldInfoPtr_coordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_minJ;

	private static readonly System.IntPtr NativeFieldInfoPtr_minI;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxJ;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxI;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppObjectBase_Coordinates_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0;

	public unsafe Il2CppObjectBase detailmap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailmap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailmap)), IL2CPP.Il2CppObjectBaseToPtr(val));
		}
	}

	public unsafe Coordinates coordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates)) = coordinates;
		}
	}

	public unsafe int minJ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minJ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minJ)) = num;
		}
	}

	public unsafe int minI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minI);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minI)) = num;
		}
	}

	public unsafe int maxJ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxJ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxJ)) = num;
		}
	}

	public unsafe int maxI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxI);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxI)) = num;
		}
	}

	static TerrainDetailmapUpdateMessage()
	{
		Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TerrainDetailmapUpdateMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr);
		NativeFieldInfoPtr_detailmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr, "detailmap");
		NativeFieldInfoPtr_coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr, "coordinates");
		NativeFieldInfoPtr_minJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr, "minJ");
		NativeFieldInfoPtr_minI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr, "minI");
		NativeFieldInfoPtr_maxJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr, "maxJ");
		NativeFieldInfoPtr_maxI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr, "maxI");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppObjectBase_Coordinates_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr, 100664174);
		NativeMethodInfoPtr_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr, 100664175);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 27437, RefRangeEnd = 27441, XrefRangeStart = 27437, XrefRangeEnd = 27441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainDetailmapUpdateMessage(Il2CppObjectBase detailmap, Coordinates coordinates, int minJ, int minI, int maxJ, int maxI)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(detailmap);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minJ;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &minI;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxJ;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxI;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppObjectBase_Coordinates_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27526, XrefRangeEnd = 27578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void NetworkSerialize<T>(BufferSerializer<T> serializer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)serializer));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NetworkSerialize_Public_Virtual_Final_New_Void_BufferSerializer_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TerrainDetailmapUpdateMessage(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public TerrainDetailmapUpdateMessage()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainDetailmapUpdateMessage>.NativeClassPtr))
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class CaveData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gameVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveChunkSizeXZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveChunkSizeY;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveResolutionXZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveResolutionY;

	private static readonly System.IntPtr NativeFieldInfoPtr_caveChunks;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFilename_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFilename_Public_Static_String_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseFilename_Public_Static_String_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCaveChunkPosition_Public_Vector3_Coordinates_0;

	public unsafe string gameVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameVersion);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameVersion)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Vector3 position
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = vector;
		}
	}

	public unsafe Quaternion rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation)) = quaternion;
		}
	}

	public unsafe Vector3 positionOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOffset)) = vector;
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

	public unsafe int caveResolutionXZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionXZ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionXZ)) = num;
		}
	}

	public unsafe int caveResolutionY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionY)) = num;
		}
	}

	public unsafe Dictionary<Coordinates, CaveChunk> caveChunks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, CaveChunk>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static CaveData()
	{
		Il2CppClassPointerStore<CaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaveData>.NativeClassPtr);
		NativeFieldInfoPtr_gameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveData>.NativeClassPtr, "gameVersion");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveData>.NativeClassPtr, "position");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveData>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_positionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveData>.NativeClassPtr, "positionOffset");
		NativeFieldInfoPtr_waterLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveData>.NativeClassPtr, "waterLevel");
		NativeFieldInfoPtr_caveChunkSizeXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveData>.NativeClassPtr, "caveChunkSizeXZ");
		NativeFieldInfoPtr_caveChunkSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveData>.NativeClassPtr, "caveChunkSizeY");
		NativeFieldInfoPtr_caveResolutionXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveData>.NativeClassPtr, "caveResolutionXZ");
		NativeFieldInfoPtr_caveResolutionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveData>.NativeClassPtr, "caveResolutionY");
		NativeFieldInfoPtr_caveChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveData>.NativeClassPtr, "caveChunks");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveData>.NativeClassPtr, 100668608);
		NativeMethodInfoPtr_GetFilename_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveData>.NativeClassPtr, 100668609);
		NativeMethodInfoPtr_GetFilename_Public_Static_String_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveData>.NativeClassPtr, 100668610);
		NativeMethodInfoPtr_GetBaseFilename_Public_Static_String_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveData>.NativeClassPtr, 100668611);
		NativeMethodInfoPtr_GetCaveChunkPosition_Public_Vector3_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveData>.NativeClassPtr, 100668612);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96047, RefRangeEnd = 96048, XrefRangeStart = 96038, XrefRangeEnd = 96047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaveData(float caveChunkSizeXZ, float caveChunkSizeY, int caveResolutionXZ, int caveResolutionY)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&caveChunkSizeXZ);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &caveChunkSizeY;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &caveResolutionXZ;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &caveResolutionY;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 96083, RefRangeEnd = 96085, XrefRangeStart = 96048, XrefRangeEnd = 96083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFilename(string x, string y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(y);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFilename_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96088, RefRangeEnd = 96089, XrefRangeStart = 96085, XrefRangeEnd = 96088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFilename(Coordinates chunkCoordinates)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&chunkCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFilename_Public_Static_String_Coordinates_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 96097, RefRangeEnd = 96099, XrefRangeStart = 96089, XrefRangeEnd = 96097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetBaseFilename(Coordinates coordinates)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBaseFilename_Public_Static_String_Coordinates_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 96105, RefRangeEnd = 96107, XrefRangeStart = 96099, XrefRangeEnd = 96105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetCaveChunkPosition(Coordinates caveChunkCoordinates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&caveChunkCoordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaveChunkPosition_Public_Vector3_Coordinates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public CaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

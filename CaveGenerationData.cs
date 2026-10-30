using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class CaveGenerationData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_caveData;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingChunkCoordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_chunkRandom;

	private static readonly System.IntPtr NativeFieldInfoPtr_startVoxelPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRegularRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxBigRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxCavernRadius;

	public unsafe CaveData caveData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CaveData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveData));
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

	public unsafe CustomRandom chunkRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkRandom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CustomRandom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkRandom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)customRandom));
		}
	}

	public unsafe Vector3 startVoxelPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startVoxelPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startVoxelPos)) = vector;
		}
	}

	public unsafe float maxRegularRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRegularRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRegularRadius)) = num;
		}
	}

	public unsafe float maxBigRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBigRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBigRadius)) = num;
		}
	}

	public unsafe float maxCavernRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCavernRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxCavernRadius)) = num;
		}
	}

	static CaveGenerationData()
	{
		Il2CppClassPointerStore<CaveGenerationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CaveGenerationData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaveGenerationData>.NativeClassPtr);
		NativeFieldInfoPtr_caveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveGenerationData>.NativeClassPtr, "caveData");
		NativeFieldInfoPtr_startingChunkCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveGenerationData>.NativeClassPtr, "startingChunkCoordinates");
		NativeFieldInfoPtr_chunkRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveGenerationData>.NativeClassPtr, "chunkRandom");
		NativeFieldInfoPtr_startVoxelPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveGenerationData>.NativeClassPtr, "startVoxelPos");
		NativeFieldInfoPtr_maxRegularRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveGenerationData>.NativeClassPtr, "maxRegularRadius");
		NativeFieldInfoPtr_maxBigRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveGenerationData>.NativeClassPtr, "maxBigRadius");
		NativeFieldInfoPtr_maxCavernRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveGenerationData>.NativeClassPtr, "maxCavernRadius");
	}

	public CaveGenerationData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CaveGenerationData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaveGenerationData>.NativeClassPtr))
	{
	}
}

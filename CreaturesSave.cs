using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class CreaturesSave : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nextPackId;

	private static readonly System.IntPtr NativeFieldInfoPtr_creatureChunkDataMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_activePackMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_inactivePackMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastHostileSpawnedDateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastHostileKilledDateTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int nextPackId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextPackId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextPackId)) = num;
		}
	}

	public unsafe Dictionary<Coordinates, CreatureChunkData> creatureChunkDataMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creatureChunkDataMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Coordinates, CreatureChunkData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creatureChunkDataMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, CreaturePack> activePackMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activePackMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, CreaturePack>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activePackMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, CreaturePack> inactivePackMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inactivePackMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, CreaturePack>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inactivePackMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Il2CppSystem.DateTime lastHostileSpawnedDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastHostileSpawnedDateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastHostileSpawnedDateTime)) = dateTime;
		}
	}

	public unsafe Il2CppSystem.DateTime lastHostileKilledDateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastHostileKilledDateTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastHostileKilledDateTime)) = dateTime;
		}
	}

	static CreaturesSave()
	{
		Il2CppClassPointerStore<CreaturesSave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CreaturesSave");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreaturesSave>.NativeClassPtr);
		NativeFieldInfoPtr_nextPackId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreaturesSave>.NativeClassPtr, "nextPackId");
		NativeFieldInfoPtr_creatureChunkDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreaturesSave>.NativeClassPtr, "creatureChunkDataMap");
		NativeFieldInfoPtr_activePackMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreaturesSave>.NativeClassPtr, "activePackMap");
		NativeFieldInfoPtr_inactivePackMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreaturesSave>.NativeClassPtr, "inactivePackMap");
		NativeFieldInfoPtr_lastHostileSpawnedDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreaturesSave>.NativeClassPtr, "lastHostileSpawnedDateTime");
		NativeFieldInfoPtr_lastHostileKilledDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreaturesSave>.NativeClassPtr, "lastHostileKilledDateTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreaturesSave>.NativeClassPtr, 100674426);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreaturesSave()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreaturesSave>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CreaturesSave(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

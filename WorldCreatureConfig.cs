using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class WorldCreatureConfig : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_numPassivesDaytime;

	private static readonly System.IntPtr NativeFieldInfoPtr_numPassivesNighttime;

	private static readonly System.IntPtr NativeFieldInfoPtr_numFishDaytime;

	private static readonly System.IntPtr NativeFieldInfoPtr_numFishNighttime;

	private static readonly System.IntPtr NativeFieldInfoPtr_numHostilesDaytime;

	private static readonly System.IntPtr NativeFieldInfoPtr_numHostilesNighttime;

	private static readonly System.IntPtr NativeFieldInfoPtr_validPassiveCreaturesNighttime;

	private static readonly System.IntPtr NativeFieldInfoPtr_validPassiveCreaturesDaytime;

	private static readonly System.IntPtr NativeFieldInfoPtr_validFishCreaturesNighttime;

	private static readonly System.IntPtr NativeFieldInfoPtr_validFishCreaturesDaytime;

	private static readonly System.IntPtr NativeFieldInfoPtr_validHostileCreaturesNighttime;

	private static readonly System.IntPtr NativeFieldInfoPtr_validHostileCreaturesDaytime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int numPassivesDaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numPassivesDaytime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numPassivesDaytime)) = num;
		}
	}

	public unsafe int numPassivesNighttime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numPassivesNighttime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numPassivesNighttime)) = num;
		}
	}

	public unsafe int numFishDaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numFishDaytime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numFishDaytime)) = num;
		}
	}

	public unsafe int numFishNighttime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numFishNighttime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numFishNighttime)) = num;
		}
	}

	public unsafe int numHostilesDaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numHostilesDaytime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numHostilesDaytime)) = num;
		}
	}

	public unsafe int numHostilesNighttime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numHostilesNighttime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numHostilesNighttime)) = num;
		}
	}

	public unsafe List<CreatureSpawnData> validPassiveCreaturesNighttime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validPassiveCreaturesNighttime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CreatureSpawnData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validPassiveCreaturesNighttime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CreatureSpawnData> validPassiveCreaturesDaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validPassiveCreaturesDaytime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CreatureSpawnData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validPassiveCreaturesDaytime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CreatureSpawnData> validFishCreaturesNighttime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validFishCreaturesNighttime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CreatureSpawnData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validFishCreaturesNighttime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CreatureSpawnData> validFishCreaturesDaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validFishCreaturesDaytime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CreatureSpawnData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validFishCreaturesDaytime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CreatureSpawnData> validHostileCreaturesNighttime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validHostileCreaturesNighttime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CreatureSpawnData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validHostileCreaturesNighttime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CreatureSpawnData> validHostileCreaturesDaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validHostileCreaturesDaytime);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CreatureSpawnData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validHostileCreaturesDaytime)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static WorldCreatureConfig()
	{
		Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WorldCreatureConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr);
		NativeFieldInfoPtr_numPassivesDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "numPassivesDaytime");
		NativeFieldInfoPtr_numPassivesNighttime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "numPassivesNighttime");
		NativeFieldInfoPtr_numFishDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "numFishDaytime");
		NativeFieldInfoPtr_numFishNighttime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "numFishNighttime");
		NativeFieldInfoPtr_numHostilesDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "numHostilesDaytime");
		NativeFieldInfoPtr_numHostilesNighttime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "numHostilesNighttime");
		NativeFieldInfoPtr_validPassiveCreaturesNighttime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "validPassiveCreaturesNighttime");
		NativeFieldInfoPtr_validPassiveCreaturesDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "validPassiveCreaturesDaytime");
		NativeFieldInfoPtr_validFishCreaturesNighttime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "validFishCreaturesNighttime");
		NativeFieldInfoPtr_validFishCreaturesDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "validFishCreaturesDaytime");
		NativeFieldInfoPtr_validHostileCreaturesNighttime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "validHostileCreaturesNighttime");
		NativeFieldInfoPtr_validHostileCreaturesDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, "validHostileCreaturesDaytime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr, 100683674);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 268390, RefRangeEnd = 268392, XrefRangeStart = 268356, XrefRangeEnd = 268390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WorldCreatureConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldCreatureConfig>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldCreatureConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

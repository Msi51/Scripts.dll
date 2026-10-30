using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public sealed class GameStartingConditions : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_startMonth;

	private static readonly System.IntPtr NativeFieldInfoPtr_startTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingEnergy;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingHunger;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingThirst;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingDisease;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingWorldDiseaseAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingCreatureConfig;

	public unsafe int startMonth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startMonth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startMonth)) = num;
		}
	}

	public unsafe Il2CppSystem.TimeSpan startTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime);
			return *(Il2CppSystem.TimeSpan*)num;
		}
		set
		{
			*(Il2CppSystem.TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime)) = timeSpan;
		}
	}

	public unsafe List<Il2CppSystem.ValueTuple<string, int, float>> startingItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<string, int, float>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float startingEnergy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingEnergy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingEnergy)) = num;
		}
	}

	public unsafe float startingHunger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingHunger);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingHunger)) = num;
		}
	}

	public unsafe float startingThirst
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingThirst);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingThirst)) = num;
		}
	}

	public unsafe float startingDisease
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDisease);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDisease)) = num;
		}
	}

	public unsafe float startingWorldDiseaseAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingWorldDiseaseAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingWorldDiseaseAmount)) = num;
		}
	}

	public unsafe WorldCreatureConfig startingCreatureConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCreatureConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WorldCreatureConfig>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingCreatureConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)worldCreatureConfig));
		}
	}

	static GameStartingConditions()
	{
		Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "GameStartingConditions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr);
		NativeFieldInfoPtr_startMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr, "startMonth");
		NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr, "startTime");
		NativeFieldInfoPtr_startingItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr, "startingItems");
		NativeFieldInfoPtr_startingEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr, "startingEnergy");
		NativeFieldInfoPtr_startingHunger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr, "startingHunger");
		NativeFieldInfoPtr_startingThirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr, "startingThirst");
		NativeFieldInfoPtr_startingDisease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr, "startingDisease");
		NativeFieldInfoPtr_startingWorldDiseaseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr, "startingWorldDiseaseAmount");
		NativeFieldInfoPtr_startingCreatureConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr, "startingCreatureConfig");
	}

	public GameStartingConditions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GameStartingConditions()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameStartingConditions>.NativeClassPtr))
	{
	}
}

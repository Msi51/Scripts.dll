using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public sealed class TerrainAdjustmentInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_z;

	private static readonly System.IntPtr NativeFieldInfoPtr_adjustment;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureAmounts;

	public unsafe float x
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x)) = num;
		}
	}

	public unsafe float z
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_z);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_z)) = num;
		}
	}

	public unsafe float adjustment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjustment);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adjustment)) = num;
		}
	}

	public unsafe List<Il2CppSystem.ValueTuple<TextureType, float>> textureAmounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureAmounts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<TextureType, float>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureAmounts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static TerrainAdjustmentInfo()
	{
		Il2CppClassPointerStore<TerrainAdjustmentInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TerrainAdjustmentInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainAdjustmentInfo>.NativeClassPtr);
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainAdjustmentInfo>.NativeClassPtr, "x");
		NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainAdjustmentInfo>.NativeClassPtr, "z");
		NativeFieldInfoPtr_adjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainAdjustmentInfo>.NativeClassPtr, "adjustment");
		NativeFieldInfoPtr_textureAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainAdjustmentInfo>.NativeClassPtr, "textureAmounts");
	}

	public TerrainAdjustmentInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public TerrainAdjustmentInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainAdjustmentInfo>.NativeClassPtr))
	{
	}
}

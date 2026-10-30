using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class TillSoilEventParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tillerEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetSurfaceType;

	private static readonly System.IntPtr NativeFieldInfoPtr_amount;

	public unsafe Entity tillerEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tillerEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tillerEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe Vector3 terrainPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainPosition)) = vector;
		}
	}

	public unsafe float radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius)) = num;
		}
	}

	public unsafe SurfaceType targetSurfaceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSurfaceType);
			return *(SurfaceType*)num;
		}
		set
		{
			*(SurfaceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetSurfaceType)) = surfaceType;
		}
	}

	public unsafe float amount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amount)) = num;
		}
	}

	static TillSoilEventParams()
	{
		Il2CppClassPointerStore<TillSoilEventParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TillSoilEventParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TillSoilEventParams>.NativeClassPtr);
		NativeFieldInfoPtr_tillerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TillSoilEventParams>.NativeClassPtr, "tillerEntity");
		NativeFieldInfoPtr_terrainPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TillSoilEventParams>.NativeClassPtr, "terrainPosition");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TillSoilEventParams>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_targetSurfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TillSoilEventParams>.NativeClassPtr, "targetSurfaceType");
		NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TillSoilEventParams>.NativeClassPtr, "amount");
	}

	public TillSoilEventParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public TillSoilEventParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TillSoilEventParams>.NativeClassPtr))
	{
	}
}

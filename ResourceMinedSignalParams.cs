using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public sealed class ResourceMinedSignalParams : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_minedEntity;

	private static readonly System.IntPtr NativeFieldInfoPtr_toolType;

	private static readonly System.IntPtr NativeFieldInfoPtr_miningImpactDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_fromTop;

	public unsafe Entity minedEntity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minedEntity);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Entity>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minedEntity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entity));
		}
	}

	public unsafe ToolType toolType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toolType);
			return *(ToolType*)num;
		}
		set
		{
			*(ToolType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toolType)) = toolType;
		}
	}

	public unsafe Vector3 miningImpactDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miningImpactDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_miningImpactDirection)) = vector;
		}
	}

	public unsafe bool fromTop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromTop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromTop)) = flag;
		}
	}

	static ResourceMinedSignalParams()
	{
		Il2CppClassPointerStore<ResourceMinedSignalParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ResourceMinedSignalParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceMinedSignalParams>.NativeClassPtr);
		NativeFieldInfoPtr_minedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedSignalParams>.NativeClassPtr, "minedEntity");
		NativeFieldInfoPtr_toolType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedSignalParams>.NativeClassPtr, "toolType");
		NativeFieldInfoPtr_miningImpactDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedSignalParams>.NativeClassPtr, "miningImpactDirection");
		NativeFieldInfoPtr_fromTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedSignalParams>.NativeClassPtr, "fromTop");
	}

	public ResourceMinedSignalParams(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ResourceMinedSignalParams()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceMinedSignalParams>.NativeClassPtr))
	{
	}
}

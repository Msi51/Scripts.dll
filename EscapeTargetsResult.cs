using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public sealed class EscapeTargetsResult : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_escapeFromEntities;

	private static readonly System.IntPtr NativeFieldInfoPtr_avoidancePositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_escapeTargetPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_urgency;

	public unsafe List<Entity> escapeFromEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapeFromEntities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapeFromEntities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector3> avoidancePositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidancePositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidancePositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Vector3 escapeTargetPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapeTargetPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escapeTargetPosition)) = vector;
		}
	}

	public unsafe float urgency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_urgency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_urgency)) = num;
		}
	}

	static EscapeTargetsResult()
	{
		Il2CppClassPointerStore<EscapeTargetsResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EscapeTargetsResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscapeTargetsResult>.NativeClassPtr);
		NativeFieldInfoPtr_escapeFromEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeTargetsResult>.NativeClassPtr, "escapeFromEntities");
		NativeFieldInfoPtr_avoidancePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeTargetsResult>.NativeClassPtr, "avoidancePositions");
		NativeFieldInfoPtr_escapeTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeTargetsResult>.NativeClassPtr, "escapeTargetPosition");
		NativeFieldInfoPtr_urgency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscapeTargetsResult>.NativeClassPtr, "urgency");
	}

	public EscapeTargetsResult(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public EscapeTargetsResult()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscapeTargetsResult>.NativeClassPtr))
	{
	}
}

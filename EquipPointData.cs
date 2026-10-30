using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class EquipPointData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_positionOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationRelativeToEquipper;

	private static readonly System.IntPtr NativeFieldInfoPtr_equipperIdleAnimationState;

	private static readonly System.IntPtr NativeFieldInfoPtr_equipperPuttingDownAnimationState;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionBetweenEquipPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationToEquipPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_equipperWalkAnimationStates;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionAnimationStates;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionOffsets;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe Vector3 rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation)) = vector;
		}
	}

	public unsafe bool rotationRelativeToEquipper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationRelativeToEquipper);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationRelativeToEquipper)) = flag;
		}
	}

	public unsafe AnimationState equipperIdleAnimationState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipperIdleAnimationState);
			return *(AnimationState*)num;
		}
		set
		{
			*(AnimationState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipperIdleAnimationState)) = animationState;
		}
	}

	public unsafe AnimationState equipperPuttingDownAnimationState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipperPuttingDownAnimationState);
			return *(AnimationState*)num;
		}
		set
		{
			*(AnimationState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipperPuttingDownAnimationState)) = animationState;
		}
	}

	public unsafe EquipPoint positionBetweenEquipPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionBetweenEquipPoint);
			return *(EquipPoint*)num;
		}
		set
		{
			*(EquipPoint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionBetweenEquipPoint)) = equipPoint;
		}
	}

	public unsafe EquipPoint rotationToEquipPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationToEquipPoint);
			return *(EquipPoint*)num;
		}
		set
		{
			*(EquipPoint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationToEquipPoint)) = equipPoint;
		}
	}

	public unsafe List<AnimationState> equipperWalkAnimationStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipperWalkAnimationStates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AnimationState>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equipperWalkAnimationStates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<InteractionType, AnimationState> interactionAnimationStates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionAnimationStates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InteractionType, AnimationState>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionAnimationStates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<InteractionType, EquipPointOffsetData> interactionOffsets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionOffsets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<InteractionType, EquipPointOffsetData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionOffsets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static EquipPointData()
	{
		Il2CppClassPointerStore<EquipPointData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EquipPointData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr);
		NativeFieldInfoPtr_positionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, "positionOffset");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_rotationRelativeToEquipper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, "rotationRelativeToEquipper");
		NativeFieldInfoPtr_equipperIdleAnimationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, "equipperIdleAnimationState");
		NativeFieldInfoPtr_equipperPuttingDownAnimationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, "equipperPuttingDownAnimationState");
		NativeFieldInfoPtr_positionBetweenEquipPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, "positionBetweenEquipPoint");
		NativeFieldInfoPtr_rotationToEquipPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, "rotationToEquipPoint");
		NativeFieldInfoPtr_equipperWalkAnimationStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, "equipperWalkAnimationStates");
		NativeFieldInfoPtr_interactionAnimationStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, "interactionAnimationStates");
		NativeFieldInfoPtr_interactionOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, "interactionOffsets");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, 100672942);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr, 100672943);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 134223, RefRangeEnd = 134224, XrefRangeStart = 134170, XrefRangeEnd = 134223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MapFromDictionary(Dictionary<string, Il2CppSystem.Object> dictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EquipPointData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipPointData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EquipPointData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

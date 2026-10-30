using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ResourceMinedEffect : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pieceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectIdentifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_particleEffectType;

	private static readonly System.IntPtr NativeFieldInfoPtr_particleEffectCopyMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_useResourceRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_usePieceCenterPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_eject;

	private static readonly System.IntPtr NativeFieldInfoPtr_ejectSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_tipOver;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomYRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_minAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_amountPerStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_chance;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionOffsetLocal;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceX;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceY;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_sounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_childTransferTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_avoidRandomOffset;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int pieceIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieceIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pieceIndex)) = num;
		}
	}

	public unsafe string objectIdentifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectIdentifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe EffectType particleEffectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleEffectType);
			return *(EffectType*)num;
		}
		set
		{
			*(EffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleEffectType)) = effectType;
		}
	}

	public unsafe bool particleEffectCopyMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleEffectCopyMesh);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleEffectCopyMesh)) = flag;
		}
	}

	public unsafe bool useResourceRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useResourceRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useResourceRotation)) = flag;
		}
	}

	public unsafe bool usePieceCenterPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePieceCenterPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePieceCenterPosition)) = flag;
		}
	}

	public unsafe bool eject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eject)) = flag;
		}
	}

	public unsafe float ejectSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ejectSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ejectSpeed)) = num;
		}
	}

	public unsafe bool tipOver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tipOver);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tipOver)) = flag;
		}
	}

	public unsafe bool randomYRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomYRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomYRotation)) = flag;
		}
	}

	public unsafe int minAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minAmount)) = num;
		}
	}

	public unsafe int maxAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAmount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAmount)) = num;
		}
	}

	public unsafe int amountPerStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountPerStack);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amountPerStack)) = num;
		}
	}

	public unsafe float chance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance)) = num;
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

	public unsafe Vector3 positionOffsetLocal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOffsetLocal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionOffsetLocal)) = vector;
		}
	}

	public unsafe Vector3 rotationOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationOffset)) = vector;
		}
	}

	public unsafe float forceX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceX)) = num;
		}
	}

	public unsafe float forceY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceY)) = num;
		}
	}

	public unsafe float forceZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceZ)) = num;
		}
	}

	public unsafe List<ResourceMinedSound> sounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sounds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ResourceMinedSound>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sounds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool childTransferTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childTransferTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childTransferTarget)) = flag;
		}
	}

	public unsafe bool avoidRandomOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidRandomOffset);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidRandomOffset)) = flag;
		}
	}

	static ResourceMinedEffect()
	{
		Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ResourceMinedEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr);
		NativeFieldInfoPtr_pieceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "pieceIndex");
		NativeFieldInfoPtr_objectIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "objectIdentifier");
		NativeFieldInfoPtr_particleEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "particleEffectType");
		NativeFieldInfoPtr_particleEffectCopyMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "particleEffectCopyMesh");
		NativeFieldInfoPtr_useResourceRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "useResourceRotation");
		NativeFieldInfoPtr_usePieceCenterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "usePieceCenterPosition");
		NativeFieldInfoPtr_eject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "eject");
		NativeFieldInfoPtr_ejectSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "ejectSpeed");
		NativeFieldInfoPtr_tipOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "tipOver");
		NativeFieldInfoPtr_randomYRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "randomYRotation");
		NativeFieldInfoPtr_minAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "minAmount");
		NativeFieldInfoPtr_maxAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "maxAmount");
		NativeFieldInfoPtr_amountPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "amountPerStack");
		NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "chance");
		NativeFieldInfoPtr_positionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "positionOffset");
		NativeFieldInfoPtr_positionOffsetLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "positionOffsetLocal");
		NativeFieldInfoPtr_rotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "rotationOffset");
		NativeFieldInfoPtr_forceX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "forceX");
		NativeFieldInfoPtr_forceY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "forceY");
		NativeFieldInfoPtr_forceZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "forceZ");
		NativeFieldInfoPtr_sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "sounds");
		NativeFieldInfoPtr_childTransferTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "childTransferTarget");
		NativeFieldInfoPtr_avoidRandomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, "avoidRandomOffset");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, 100678425);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr, 100678426);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225041, XrefRangeEnd = 225180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe ResourceMinedEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceMinedEffect>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ResourceMinedEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

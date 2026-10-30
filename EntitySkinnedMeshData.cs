using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class EntitySkinnedMeshData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rootBoneName;

	private static readonly System.IntPtr NativeFieldInfoPtr_boneIndexMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_variantPiecePrototypeMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_variantAvatarMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyeMaterialMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_hairMaterialMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_variantSkinToneDataMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_variantHairIdentifierMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_variantFaceRendererNameMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_variantBlendShapeDataMap;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string rootBoneName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootBoneName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rootBoneName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Dictionary<string, int> boneIndexMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneIndexMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneIndexMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CharacterVariant, Dictionary<string, GameObject>> variantPiecePrototypeMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantPiecePrototypeMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterVariant, Dictionary<string, GameObject>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantPiecePrototypeMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CharacterVariant, Avatar> variantAvatarMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantAvatarMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterVariant, Avatar>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantAvatarMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, Material> eyeMaterialMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyeMaterialMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyeMaterialMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<string, Material> hairMaterialMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairMaterialMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairMaterialMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CharacterVariant, Dictionary<string, SkinToneData>> variantSkinToneDataMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantSkinToneDataMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterVariant, Dictionary<string, SkinToneData>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantSkinToneDataMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CharacterVariant, Dictionary<string, List<string>>> variantHairIdentifierMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantHairIdentifierMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterVariant, Dictionary<string, List<string>>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantHairIdentifierMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CharacterVariant, string> variantFaceRendererNameMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantFaceRendererNameMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterVariant, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantFaceRendererNameMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CharacterVariant, Dictionary<string, CharacterBlendShapeData>> variantBlendShapeDataMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantBlendShapeDataMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterVariant, Dictionary<string, CharacterBlendShapeData>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_variantBlendShapeDataMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static EntitySkinnedMeshData()
	{
		Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "EntitySkinnedMeshData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr);
		NativeFieldInfoPtr_rootBoneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, "rootBoneName");
		NativeFieldInfoPtr_boneIndexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, "boneIndexMap");
		NativeFieldInfoPtr_variantPiecePrototypeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, "variantPiecePrototypeMap");
		NativeFieldInfoPtr_variantAvatarMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, "variantAvatarMap");
		NativeFieldInfoPtr_eyeMaterialMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, "eyeMaterialMap");
		NativeFieldInfoPtr_hairMaterialMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, "hairMaterialMap");
		NativeFieldInfoPtr_variantSkinToneDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, "variantSkinToneDataMap");
		NativeFieldInfoPtr_variantHairIdentifierMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, "variantHairIdentifierMap");
		NativeFieldInfoPtr_variantFaceRendererNameMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, "variantFaceRendererNameMap");
		NativeFieldInfoPtr_variantBlendShapeDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, "variantBlendShapeDataMap");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr, 100676289);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179032, RefRangeEnd = 179033, XrefRangeStart = 178976, XrefRangeEnd = 179032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EntitySkinnedMeshData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntitySkinnedMeshData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EntitySkinnedMeshData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

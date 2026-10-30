using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class WorldGenTerrainLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_textureType;

	private static readonly System.IntPtr NativeFieldInfoPtr_diffuseTexturePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalTexturePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_maskMapTexturePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_smoothness;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightRemapMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightRemapMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_dirtAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_grassAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_tessellationScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_diffuseTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_maskMapTexture;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TextureType textureType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureType);
			return *(TextureType*)num;
		}
		set
		{
			*(TextureType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureType)) = textureType;
		}
	}

	public unsafe string diffuseTexturePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTexturePath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTexturePath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string normalTexturePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalTexturePath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalTexturePath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string maskMapTexturePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maskMapTexturePath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maskMapTexturePath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float tileSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileSize)) = num;
		}
	}

	public unsafe float normalScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalScale)) = num;
		}
	}

	public unsafe float smoothness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothness)) = num;
		}
	}

	public unsafe float heightRemapMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightRemapMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightRemapMin)) = num;
		}
	}

	public unsafe float heightRemapMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightRemapMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightRemapMax)) = num;
		}
	}

	public unsafe float dirtAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirtAmount)) = num;
		}
	}

	public unsafe float grassAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grassAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grassAmount)) = num;
		}
	}

	public unsafe float tessellationScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tessellationScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tessellationScale)) = num;
		}
	}

	public unsafe Texture2D diffuseTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_diffuseTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D normalTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D maskMapTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maskMapTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maskMapTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	static WorldGenTerrainLayer()
	{
		Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "WorldGenTerrainLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr);
		NativeFieldInfoPtr_textureType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "textureType");
		NativeFieldInfoPtr_diffuseTexturePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "diffuseTexturePath");
		NativeFieldInfoPtr_normalTexturePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "normalTexturePath");
		NativeFieldInfoPtr_maskMapTexturePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "maskMapTexturePath");
		NativeFieldInfoPtr_tileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "tileSize");
		NativeFieldInfoPtr_normalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "normalScale");
		NativeFieldInfoPtr_smoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "smoothness");
		NativeFieldInfoPtr_heightRemapMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "heightRemapMin");
		NativeFieldInfoPtr_heightRemapMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "heightRemapMax");
		NativeFieldInfoPtr_dirtAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "dirtAmount");
		NativeFieldInfoPtr_grassAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "grassAmount");
		NativeFieldInfoPtr_tessellationScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "tessellationScale");
		NativeFieldInfoPtr_diffuseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "diffuseTexture");
		NativeFieldInfoPtr_normalTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "normalTexture");
		NativeFieldInfoPtr_maskMapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, "maskMapTexture");
		NativeMethodInfoPtr_MapFromDictionary_Public_Virtual_Final_New_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, 100670416);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr, 100670417);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120521, XrefRangeEnd = 120643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe WorldGenTerrainLayer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldGenTerrainLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public WorldGenTerrainLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

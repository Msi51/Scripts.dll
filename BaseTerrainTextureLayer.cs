using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class BaseTerrainTextureLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_textureTypeIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_terrainTextureHeightFilter;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureTypeIndex_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureTypeIndex_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeTextureAmount_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHeightFilter_Public_TerrainTextureHeightFilter_0;

	public unsafe int textureTypeIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureTypeIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureTypeIndex)) = num;
		}
	}

	public unsafe TerrainTextureHeightFilter terrainTextureHeightFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTextureHeightFilter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TerrainTextureHeightFilter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_terrainTextureHeightFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)terrainTextureHeightFilter));
		}
	}

	static BaseTerrainTextureLayer()
	{
		Il2CppClassPointerStore<BaseTerrainTextureLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "BaseTerrainTextureLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseTerrainTextureLayer>.NativeClassPtr);
		NativeFieldInfoPtr_textureTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTerrainTextureLayer>.NativeClassPtr, "textureTypeIndex");
		NativeFieldInfoPtr_terrainTextureHeightFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseTerrainTextureLayer>.NativeClassPtr, "terrainTextureHeightFilter");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTerrainTextureLayer>.NativeClassPtr, 100683852);
		NativeMethodInfoPtr_GetTextureTypeIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTerrainTextureLayer>.NativeClassPtr, 100683853);
		NativeMethodInfoPtr_SetTextureTypeIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTerrainTextureLayer>.NativeClassPtr, 100683854);
		NativeMethodInfoPtr_ComputeTextureAmount_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTerrainTextureLayer>.NativeClassPtr, 100683855);
		NativeMethodInfoPtr_GetHeightFilter_Public_TerrainTextureHeightFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseTerrainTextureLayer>.NativeClassPtr, 100683856);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 271393, RefRangeEnd = 271394, XrefRangeStart = 271386, XrefRangeEnd = 271393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseTerrainTextureLayer(int textureTypeIndex, float minHeight, float maxHeight, float minHeightFadeRange, float maxHeightFadeRange)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseTerrainTextureLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&textureTypeIndex);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minHeight;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxHeight;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &minHeightFadeRange;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxHeightFadeRange;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetTextureTypeIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureTypeIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 292, RefRangeEnd = 297, XrefRangeStart = 292, XrefRangeEnd = 297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTextureTypeIndex(int textureTypeIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&textureTypeIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextureTypeIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 271396, RefRangeEnd = 271398, XrefRangeStart = 271394, XrefRangeEnd = 271396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float ComputeTextureAmount(float terrainHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&terrainHeight);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeTextureAmount_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 28728, RefRangeEnd = 28739, XrefRangeStart = 28728, XrefRangeEnd = 28739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainTextureHeightFilter GetHeightFilter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHeightFilter_Public_TerrainTextureHeightFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TerrainTextureHeightFilter>(intPtr) : null;
	}

	public BaseTerrainTextureLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

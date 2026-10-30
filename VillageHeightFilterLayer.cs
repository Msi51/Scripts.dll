using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class VillageHeightFilterLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_perlinScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_deviationMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightmapResolution;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHeight_Public_Virtual_Final_New_Single_byref_WorldGenerationHeightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0;

	public unsafe float perlinScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perlinScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perlinScale)) = num;
		}
	}

	public unsafe float deviationMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviationMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deviationMax)) = num;
		}
	}

	public unsafe int heightmapResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapResolution);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapResolution)) = num;
		}
	}

	static VillageHeightFilterLayer()
	{
		Il2CppClassPointerStore<VillageHeightFilterLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "VillageHeightFilterLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VillageHeightFilterLayer>.NativeClassPtr);
		NativeFieldInfoPtr_perlinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillageHeightFilterLayer>.NativeClassPtr, "perlinScale");
		NativeFieldInfoPtr_deviationMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillageHeightFilterLayer>.NativeClassPtr, "deviationMax");
		NativeFieldInfoPtr_heightmapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VillageHeightFilterLayer>.NativeClassPtr, "heightmapResolution");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageHeightFilterLayer>.NativeClassPtr, 100683952);
		NativeMethodInfoPtr_ComputeHeight_Public_Virtual_Final_New_Single_byref_WorldGenerationHeightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageHeightFilterLayer>.NativeClassPtr, 100683953);
		NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VillageHeightFilterLayer>.NativeClassPtr, 100683954);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 271791, RefRangeEnd = 271794, XrefRangeStart = 271791, XrefRangeEnd = 271794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VillageHeightFilterLayer(float perlinScale, float deviationMax, int heightmapResolution)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VillageHeightFilterLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&perlinScale);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deviationMax;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &heightmapResolution;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272178, XrefRangeEnd = 272201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float ComputeHeight(ref WorldGenerationHeightData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHeight_Public_Virtual_Final_New_Single_byref_WorldGenerationHeightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13368)]
	[CachedScanResults(RefRangeStart = 5047, RefRangeEnd = 18415, XrefRangeStart = 5047, XrefRangeEnd = 18415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PostProcessHeight(Chunk chunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chunk);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public VillageHeightFilterLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

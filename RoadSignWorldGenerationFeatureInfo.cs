using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class RoadSignWorldGenerationFeatureInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureType_Public_Virtual_Final_New_WorldGenerationFeatureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static RoadSignWorldGenerationFeatureInfo()
	{
		Il2CppClassPointerStore<RoadSignWorldGenerationFeatureInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RoadSignWorldGenerationFeatureInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadSignWorldGenerationFeatureInfo>.NativeClassPtr);
		NativeMethodInfoPtr_GetFeatureType_Public_Virtual_Final_New_WorldGenerationFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadSignWorldGenerationFeatureInfo>.NativeClassPtr, 100683802);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadSignWorldGenerationFeatureInfo>.NativeClassPtr, 100683803);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 124899, RefRangeEnd = 124904, XrefRangeStart = 124899, XrefRangeEnd = 124904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual WorldGenerationFeatureType GetFeatureType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFeatureType_Public_Virtual_Final_New_WorldGenerationFeatureType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(WorldGenerationFeatureType*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoadSignWorldGenerationFeatureInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadSignWorldGenerationFeatureInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RoadSignWorldGenerationFeatureInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

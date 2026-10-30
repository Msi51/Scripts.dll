using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class StartingAreaWorldGenerationFeatureInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureType_Public_Virtual_Final_New_WorldGenerationFeatureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static StartingAreaWorldGenerationFeatureInfo()
	{
		Il2CppClassPointerStore<StartingAreaWorldGenerationFeatureInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "StartingAreaWorldGenerationFeatureInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartingAreaWorldGenerationFeatureInfo>.NativeClassPtr);
		NativeMethodInfoPtr_GetFeatureType_Public_Virtual_Final_New_WorldGenerationFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingAreaWorldGenerationFeatureInfo>.NativeClassPtr, 100683818);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingAreaWorldGenerationFeatureInfo>.NativeClassPtr, 100683819);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 25657, RefRangeEnd = 25704, XrefRangeStart = 25657, XrefRangeEnd = 25704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe StartingAreaWorldGenerationFeatureInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartingAreaWorldGenerationFeatureInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StartingAreaWorldGenerationFeatureInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

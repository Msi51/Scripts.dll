using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

[System.Serializable]
public class DruidCampWorldGenerationFeatureInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureType_Public_Virtual_Final_New_WorldGenerationFeatureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static DruidCampWorldGenerationFeatureInfo()
	{
		Il2CppClassPointerStore<DruidCampWorldGenerationFeatureInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "DruidCampWorldGenerationFeatureInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DruidCampWorldGenerationFeatureInfo>.NativeClassPtr);
		NativeMethodInfoPtr_GetFeatureType_Public_Virtual_Final_New_WorldGenerationFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DruidCampWorldGenerationFeatureInfo>.NativeClassPtr, 100683782);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DruidCampWorldGenerationFeatureInfo>.NativeClassPtr, 100683783);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122147, RefRangeEnd = 122149, XrefRangeStart = 122147, XrefRangeEnd = 122149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe DruidCampWorldGenerationFeatureInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DruidCampWorldGenerationFeatureInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DruidCampWorldGenerationFeatureInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

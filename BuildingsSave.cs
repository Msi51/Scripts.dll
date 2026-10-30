using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class BuildingsSave : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nextBuildingSectionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildingSections;

	private static readonly System.IntPtr NativeFieldInfoPtr_entityIdBuildingSectionIdMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_constructionDestroyInfoList;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int nextBuildingSectionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextBuildingSectionId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextBuildingSectionId)) = num;
		}
	}

	public unsafe Dictionary<int, BuildingSection> buildingSections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingSections);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, BuildingSection>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildingSections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, List<int>> entityIdBuildingSectionIdMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityIdBuildingSectionIdMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entityIdBuildingSectionIdMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<ConstructionDestroyInfo> constructionDestroyInfoList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionDestroyInfoList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ConstructionDestroyInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constructionDestroyInfoList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static BuildingsSave()
	{
		Il2CppClassPointerStore<BuildingsSave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "BuildingsSave");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingsSave>.NativeClassPtr);
		NativeFieldInfoPtr_nextBuildingSectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingsSave>.NativeClassPtr, "nextBuildingSectionId");
		NativeFieldInfoPtr_buildingSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingsSave>.NativeClassPtr, "buildingSections");
		NativeFieldInfoPtr_entityIdBuildingSectionIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingsSave>.NativeClassPtr, "entityIdBuildingSectionIdMap");
		NativeFieldInfoPtr_constructionDestroyInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingsSave>.NativeClassPtr, "constructionDestroyInfoList");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingsSave>.NativeClassPtr, 100673984);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuildingsSave()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingsSave>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BuildingsSave(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

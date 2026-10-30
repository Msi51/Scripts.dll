using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class LODObjectTracker : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_generationCount;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int generationCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generationCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generationCount)) = num;
		}
	}

	static LODObjectTracker()
	{
		Il2CppClassPointerStore<LODObjectTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "LODObjectTracker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODObjectTracker>.NativeClassPtr);
		NativeFieldInfoPtr_generationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODObjectTracker>.NativeClassPtr, "generationCount");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODObjectTracker>.NativeClassPtr, 100682673);
	}

	[CallerCount(229)]
	[CachedScanResults(RefRangeStart = 18764, RefRangeEnd = 18993, XrefRangeStart = 18764, XrefRangeEnd = 18993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LODObjectTracker()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LODObjectTracker>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LODObjectTracker(IntPtr pointer)
		: base(pointer)
	{
	}
}

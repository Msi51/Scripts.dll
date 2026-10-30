using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public class NoiseHeightLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_noiseFilter;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NoiseFilter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHeightFactor_Public_Virtual_Final_New_Single_Single_Single_0;

	public unsafe NoiseFilter noiseFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseFilter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NoiseFilter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseFilter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)noiseFilter));
		}
	}

	static NoiseHeightLayer()
	{
		Il2CppClassPointerStore<NoiseHeightLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "NoiseHeightLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseHeightLayer>.NativeClassPtr);
		NativeFieldInfoPtr_noiseFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseHeightLayer>.NativeClassPtr, "noiseFilter");
		NativeMethodInfoPtr__ctor_Public_Void_NoiseFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseHeightLayer>.NativeClassPtr, 100683896);
		NativeMethodInfoPtr_ComputeHeightFactor_Public_Virtual_Final_New_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseHeightLayer>.NativeClassPtr, 100683897);
	}

	[CallerCount(76)]
	[CachedScanResults(RefRangeStart = 70954, RefRangeEnd = 71030, XrefRangeStart = 70954, XrefRangeEnd = 71030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NoiseHeightLayer(NoiseFilter noiseFilter)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoiseHeightLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)noiseFilter);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NoiseFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271789, XrefRangeEnd = 271790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float ComputeHeightFactor(float xCoord, float yCoord)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&xCoord);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yCoord;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHeightFactor_Public_Virtual_Final_New_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public NoiseHeightLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

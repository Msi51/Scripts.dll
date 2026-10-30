using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

public class CaveHeightFilterLayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_heightmapResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_localNoise;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHeight_Public_Virtual_Final_New_Single_byref_WorldGenerationHeightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0;

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

	public unsafe FastNoiseLite localNoise
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localNoise);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FastNoiseLite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localNoise)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fastNoiseLite));
		}
	}

	static CaveHeightFilterLayer()
	{
		Il2CppClassPointerStore<CaveHeightFilterLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CaveHeightFilterLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaveHeightFilterLayer>.NativeClassPtr);
		NativeFieldInfoPtr_heightmapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveHeightFilterLayer>.NativeClassPtr, "heightmapResolution");
		NativeFieldInfoPtr_localNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveHeightFilterLayer>.NativeClassPtr, "localNoise");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveHeightFilterLayer>.NativeClassPtr, 100683857);
		NativeMethodInfoPtr_ComputeHeight_Public_Virtual_Final_New_Single_byref_WorldGenerationHeightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveHeightFilterLayer>.NativeClassPtr, 100683858);
		NativeMethodInfoPtr_PostProcessHeight_Public_Virtual_Final_New_Void_Chunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveHeightFilterLayer>.NativeClassPtr, 100683859);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 271408, RefRangeEnd = 271409, XrefRangeStart = 271398, XrefRangeEnd = 271408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaveHeightFilterLayer(int heightmapResolution)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaveHeightFilterLayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&heightmapResolution);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271409, XrefRangeEnd = 271488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public CaveHeightFilterLayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

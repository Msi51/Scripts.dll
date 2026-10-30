using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class HoleMapPool : BasePool<Il2CppObjectBase>
{
	private static readonly IntPtr NativeFieldInfoPtr_heightmapSize;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_Il2CppObjectBase_0;

	private static readonly IntPtr NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppObjectBase_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_Int32_0;

	public unsafe int heightmapSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightmapSize)) = num;
		}
	}

	static HoleMapPool()
	{
		Il2CppClassPointerStore<HoleMapPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "HoleMapPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoleMapPool>.NativeClassPtr);
		NativeFieldInfoPtr_heightmapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoleMapPool>.NativeClassPtr, "heightmapSize");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoleMapPool>.NativeClassPtr, 100664483);
		NativeMethodInfoPtr_onCreate_Private_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoleMapPool>.NativeClassPtr, 100664484);
		NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoleMapPool>.NativeClassPtr, 100664485);
		NativeMethodInfoPtr_SetProperties_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoleMapPool>.NativeClassPtr, 100664486);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31072, RefRangeEnd = 31073, XrefRangeStart = 31049, XrefRangeEnd = 31072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HoleMapPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoleMapPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31073, XrefRangeEnd = 31076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppObjectBase onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31076, XrefRangeEnd = 31080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onGet(Il2CppObjectBase holeMap)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(holeMap);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppObjectBase_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31083, RefRangeEnd = 31084, XrefRangeStart = 31080, XrefRangeEnd = 31083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProperties(int heightmapSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&heightmapSize);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HoleMapPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

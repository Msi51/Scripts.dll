using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public sealed class RegionChunkPool : BasePool<RegionChunk>
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_RegionChunk_0;

	static RegionChunkPool()
	{
		Il2CppClassPointerStore<RegionChunkPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "RegionChunkPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionChunkPool>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionChunkPool>.NativeClassPtr, 100664521);
		NativeMethodInfoPtr_onCreate_Private_RegionChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionChunkPool>.NativeClassPtr, 100664522);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31481, RefRangeEnd = 31482, XrefRangeStart = 31464, XrefRangeEnd = 31481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegionChunkPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionChunkPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31482, XrefRangeEnd = 31486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegionChunk onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_RegionChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RegionChunk>(intPtr) : null;
	}

	public RegionChunkPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

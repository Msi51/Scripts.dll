using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class CaveChunkPool : BasePool<CaveChunk>
{
	private static readonly IntPtr NativeFieldInfoPtr_caveResolutionXZ;

	private static readonly IntPtr NativeFieldInfoPtr_caveResolutionY;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_CaveChunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_onGet_Private_Static_Void_CaveChunk_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_0;

	public unsafe int caveResolutionXZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionXZ);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionXZ)) = num;
		}
	}

	public unsafe int caveResolutionY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveResolutionY)) = num;
		}
	}

	static CaveChunkPool()
	{
		Il2CppClassPointerStore<CaveChunkPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CaveChunkPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaveChunkPool>.NativeClassPtr);
		NativeFieldInfoPtr_caveResolutionXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveChunkPool>.NativeClassPtr, "caveResolutionXZ");
		NativeFieldInfoPtr_caveResolutionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveChunkPool>.NativeClassPtr, "caveResolutionY");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveChunkPool>.NativeClassPtr, 100664443);
		NativeMethodInfoPtr_onCreate_Private_CaveChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveChunkPool>.NativeClassPtr, 100664444);
		NativeMethodInfoPtr_onGet_Private_Static_Void_CaveChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveChunkPool>.NativeClassPtr, 100664445);
		NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveChunkPool>.NativeClassPtr, 100664446);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30279, RefRangeEnd = 30280, XrefRangeStart = 30256, XrefRangeEnd = 30279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaveChunkPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaveChunkPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30280, XrefRangeEnd = 30294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaveChunk onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_CaveChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CaveChunk>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30294, XrefRangeEnd = 30306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onGet(CaveChunk caveChunk)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveChunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGet_Private_Static_Void_CaveChunk_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30309, RefRangeEnd = 30310, XrefRangeStart = 30306, XrefRangeEnd = 30309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProperties(int caveResolutionXZ, int caveResolutionY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&caveResolutionXZ);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &caveResolutionY;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CaveChunkPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

public class CaveDataPool : BasePool<CaveData>
{
	private static readonly IntPtr NativeFieldInfoPtr_caveChunkSizeXZ;

	private static readonly IntPtr NativeFieldInfoPtr_caveChunkSizeY;

	private static readonly IntPtr NativeFieldInfoPtr_caveResolutionXZ;

	private static readonly IntPtr NativeFieldInfoPtr_caveResolutionY;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_CaveData_0;

	private static readonly IntPtr NativeMethodInfoPtr_onGet_Private_Static_Void_CaveData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_Single_Single_Int32_Int32_0;

	public unsafe float caveChunkSizeXZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunkSizeXZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunkSizeXZ)) = num;
		}
	}

	public unsafe float caveChunkSizeY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunkSizeY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caveChunkSizeY)) = num;
		}
	}

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

	static CaveDataPool()
	{
		Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "CaveDataPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr);
		NativeFieldInfoPtr_caveChunkSizeXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr, "caveChunkSizeXZ");
		NativeFieldInfoPtr_caveChunkSizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr, "caveChunkSizeY");
		NativeFieldInfoPtr_caveResolutionXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr, "caveResolutionXZ");
		NativeFieldInfoPtr_caveResolutionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr, "caveResolutionY");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr, 100664447);
		NativeMethodInfoPtr_onCreate_Private_CaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr, 100664448);
		NativeMethodInfoPtr_onGet_Private_Static_Void_CaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr, 100664449);
		NativeMethodInfoPtr_SetProperties_Public_Void_Single_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr, 100664450);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30336, RefRangeEnd = 30337, XrefRangeStart = 30310, XrefRangeEnd = 30336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaveDataPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaveDataPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30337, XrefRangeEnd = 30341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CaveData onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_CaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CaveData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30341, XrefRangeEnd = 30345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onGet(CaveData caveData)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caveData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGet_Private_Static_Void_CaveData_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30345, RefRangeEnd = 30346, XrefRangeStart = 30345, XrefRangeEnd = 30345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProperties(float caveChunkSizeXZ, float caveChunkSizeY, int caveResolutionXZ, int caveResolutionY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&caveChunkSizeXZ);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &caveChunkSizeY;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &caveResolutionXZ;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &caveResolutionY;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Single_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CaveDataPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

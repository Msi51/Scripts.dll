using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class SlopeDataPool : BasePool<Il2CppReferenceArray<Il2CppStructArray<Vector2>>>
{
	private static readonly IntPtr NativeFieldInfoPtr_heightmapSize;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Vector2_0;

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

	static SlopeDataPool()
	{
		Il2CppClassPointerStore<SlopeDataPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SlopeDataPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlopeDataPool>.NativeClassPtr);
		NativeFieldInfoPtr_heightmapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlopeDataPool>.NativeClassPtr, "heightmapSize");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlopeDataPool>.NativeClassPtr, 100664533);
		NativeMethodInfoPtr_onCreate_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlopeDataPool>.NativeClassPtr, 100664534);
		NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlopeDataPool>.NativeClassPtr, 100664535);
		NativeMethodInfoPtr_SetProperties_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlopeDataPool>.NativeClassPtr, 100664536);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32100, RefRangeEnd = 32101, XrefRangeStart = 32077, XrefRangeEnd = 32100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlopeDataPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlopeDataPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32101, XrefRangeEnd = 32112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Il2CppStructArray<Vector2>> onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<Vector2>>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32112, XrefRangeEnd = 32114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onGet(Il2CppReferenceArray<Il2CppStructArray<Vector2>> slopeData)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slopeData);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Vector2_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32117, RefRangeEnd = 32118, XrefRangeStart = 32114, XrefRangeEnd = 32117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProperties(int heightmapSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&heightmapSize);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SlopeDataPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

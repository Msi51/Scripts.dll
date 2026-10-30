using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

public class TakenPositionsPool : BasePool<Il2CppReferenceArray<Il2CppStructArray<bool>>>
{
	private static readonly IntPtr NativeFieldInfoPtr_heightmapSize;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0;

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

	static TakenPositionsPool()
	{
		Il2CppClassPointerStore<TakenPositionsPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "TakenPositionsPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TakenPositionsPool>.NativeClassPtr);
		NativeFieldInfoPtr_heightmapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TakenPositionsPool>.NativeClassPtr, "heightmapSize");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakenPositionsPool>.NativeClassPtr, 100664537);
		NativeMethodInfoPtr_onCreate_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakenPositionsPool>.NativeClassPtr, 100664538);
		NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakenPositionsPool>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr_SetProperties_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TakenPositionsPool>.NativeClassPtr, 100664540);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32141, RefRangeEnd = 32142, XrefRangeStart = 32118, XrefRangeEnd = 32141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TakenPositionsPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TakenPositionsPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32142, XrefRangeEnd = 32153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Il2CppStructArray<bool>> onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<bool>>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32153, XrefRangeEnd = 32155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onGet(Il2CppReferenceArray<Il2CppStructArray<bool>> takenPositions)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)takenPositions);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32158, RefRangeEnd = 32159, XrefRangeStart = 32155, XrefRangeEnd = 32158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProperties(int heightmapSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&heightmapSize);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TakenPositionsPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

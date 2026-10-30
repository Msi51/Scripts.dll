using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

public class ChunkCellsPool : BasePool<Il2CppReferenceArray<Il2CppReferenceArray<Cell>>>
{
	private static readonly IntPtr NativeFieldInfoPtr_cellsPerChunk;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_onCreate_Private_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Cell_0;

	private static readonly IntPtr NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Cell_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetProperties_Public_Void_Int32_0;

	public unsafe int cellsPerChunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellsPerChunk);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cellsPerChunk)) = num;
		}
	}

	static ChunkCellsPool()
	{
		Il2CppClassPointerStore<ChunkCellsPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChunkCellsPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkCellsPool>.NativeClassPtr);
		NativeFieldInfoPtr_cellsPerChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkCellsPool>.NativeClassPtr, "cellsPerChunk");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkCellsPool>.NativeClassPtr, 100664451);
		NativeMethodInfoPtr_onCreate_Private_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkCellsPool>.NativeClassPtr, 100664452);
		NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkCellsPool>.NativeClassPtr, 100664453);
		NativeMethodInfoPtr_SetProperties_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkCellsPool>.NativeClassPtr, 100664454);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30369, RefRangeEnd = 30370, XrefRangeStart = 30346, XrefRangeEnd = 30369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkCellsPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkCellsPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30370, XrefRangeEnd = 30430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Il2CppReferenceArray<Cell>> onCreate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCreate_Private_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<Cell>>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30430, XrefRangeEnd = 30444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onGet(Il2CppReferenceArray<Il2CppReferenceArray<Cell>> cells)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cells);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onGet_Private_Static_Void_Il2CppReferenceArray_1_Il2CppReferenceArray_1_Cell_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30447, RefRangeEnd = 30448, XrefRangeStart = 30444, XrefRangeEnd = 30447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetProperties(int cellsPerChunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&cellsPerChunk);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProperties_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChunkCellsPool(IntPtr pointer)
		: base(pointer)
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class ChunkEntitiesSave : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gameVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_coordinates;

	private static readonly System.IntPtr NativeFieldInfoPtr_serializedEntities;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFilename_Public_Static_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFilenameDEPRECATED_Public_Static_String_String_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFilename_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFilename_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFilename_Public_Static_String_Coordinates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string gameVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameVersion);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameVersion)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Coordinates coordinates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates);
			return *(Coordinates*)num;
		}
		set
		{
			*(Coordinates*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coordinates)) = coordinates;
		}
	}

	public unsafe List<SerializedEntity> serializedEntities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serializedEntities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SerializedEntity>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serializedEntities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ChunkEntitiesSave()
	{
		Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "ChunkEntitiesSave");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr);
		NativeFieldInfoPtr_gameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr, "gameVersion");
		NativeFieldInfoPtr_coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr, "coordinates");
		NativeFieldInfoPtr_serializedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr, "serializedEntities");
		NativeMethodInfoPtr_GetFilename_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr, 100679265);
		NativeMethodInfoPtr_GetFilenameDEPRECATED_Public_Static_String_String_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr, 100679266);
		NativeMethodInfoPtr_GetFilename_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr, 100679267);
		NativeMethodInfoPtr_GetFilename_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr, 100679268);
		NativeMethodInfoPtr_GetFilename_Public_Static_String_Coordinates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr, 100679269);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr, 100679270);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231080, RefRangeEnd = 231081, XrefRangeStart = 231041, XrefRangeEnd = 231080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFilename(string slotName, string x, string y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(y);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFilename_Public_Static_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231084, RefRangeEnd = 231085, XrefRangeStart = 231081, XrefRangeEnd = 231084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFilenameDEPRECATED(string slotName, Coordinates coordinates)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(slotName);
		*(Coordinates**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coordinates;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFilenameDEPRECATED_Public_Static_String_String_Coordinates_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 231088, RefRangeEnd = 231090, XrefRangeStart = 231085, XrefRangeEnd = 231088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFilename()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFilename_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 231125, RefRangeEnd = 231128, XrefRangeStart = 231090, XrefRangeEnd = 231125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFilename(string x, string y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(y);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFilename_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 231131, RefRangeEnd = 231134, XrefRangeStart = 231128, XrefRangeEnd = 231131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFilename(Coordinates coordinates)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coordinates);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFilename_Public_Static_String_Coordinates_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1714)]
	[CachedScanResults(RefRangeStart = 1005, RefRangeEnd = 2719, XrefRangeStart = 1005, XrefRangeEnd = 2719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChunkEntitiesSave()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkEntitiesSave>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChunkEntitiesSave(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

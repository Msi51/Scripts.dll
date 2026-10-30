using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;
using MarchingCubesProject;

public static class SerializationUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArray_Public_Static_Void_VoxelArray_StreamBinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArray_Public_Static_Void_VoxelArray_StreamBinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastReadFloat_Public_Static_Single_StreamBinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastReadFloat_Public_Static_Single_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FastWriteFloat_Public_Static_Void_BinaryWriter_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarshalVectors_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarshalInts_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnmarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnmarshalVectors_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnmarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnmarshalInts_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Int32_0;

	static SerializationUtil()
	{
		Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "", "SerializationUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr);
		SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667903);
		SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667904);
		SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667905);
		SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667906);
		SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667907);
		NativeMethodInfoPtr_ReadArray_Public_Static_Void_VoxelArray_StreamBinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667908);
		SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667909);
		SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667910);
		SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667911);
		SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667912);
		SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667913);
		NativeMethodInfoPtr_WriteArray_Public_Static_Void_VoxelArray_StreamBinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667914);
		NativeMethodInfoPtr_FastReadFloat_Public_Static_Single_StreamBinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667915);
		NativeMethodInfoPtr_FastReadFloat_Public_Static_Single_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667916);
		NativeMethodInfoPtr_FastWriteFloat_Public_Static_Void_BinaryWriter_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667917);
		SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667918);
		SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667919);
		SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667920);
		SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667921);
		SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667922);
		SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667923);
		SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667924);
		SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667925);
		SerializationUtil.NativeMethodInfoPtr_MarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667926);
		NativeMethodInfoPtr_MarshalVectors_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667927);
		SerializationUtil.NativeMethodInfoPtr_MarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667928);
		NativeMethodInfoPtr_MarshalInts_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667929);
		SerializationUtil.NativeMethodInfoPtr_UnmarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667930);
		NativeMethodInfoPtr_UnmarshalVectors_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667931);
		SerializationUtil.NativeMethodInfoPtr_UnmarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667932);
		NativeMethodInfoPtr_UnmarshalInts_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtil>.NativeClassPtr, 100667933);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85441, XrefRangeEnd = 85445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadArray(Il2CppObjectBase dest, StreamBinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85449, RefRangeEnd = 85450, XrefRangeStart = 85445, XrefRangeEnd = 85449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadArray(Il2CppObjectBase dest, StreamBinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85456, RefRangeEnd = 85457, XrefRangeStart = 85450, XrefRangeEnd = 85456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadArray(Il2CppObjectBase dest, StreamBinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85457, XrefRangeEnd = 85462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadArray(Il2CppObjectBase dest, StreamBinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85466, RefRangeEnd = 85467, XrefRangeStart = 85462, XrefRangeEnd = 85466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadArray(Il2CppObjectBase dest, StreamBinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85478, RefRangeEnd = 85479, XrefRangeStart = 85467, XrefRangeEnd = 85478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadArray(VoxelArray dest, StreamBinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadArray_Public_Static_Void_VoxelArray_StreamBinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 85483, RefRangeEnd = 85486, XrefRangeStart = 85479, XrefRangeEnd = 85483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArray(Il2CppObjectBase source, StreamBinaryWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85490, RefRangeEnd = 85491, XrefRangeStart = 85486, XrefRangeEnd = 85490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArray(Il2CppObjectBase source, StreamBinaryWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85497, RefRangeEnd = 85498, XrefRangeStart = 85491, XrefRangeEnd = 85497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArray(Il2CppObjectBase source, StreamBinaryWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85498, XrefRangeEnd = 85502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArray(Il2CppObjectBase source, StreamBinaryWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85506, RefRangeEnd = 85507, XrefRangeStart = 85502, XrefRangeEnd = 85506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArray(Il2CppObjectBase source, StreamBinaryWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_StreamBinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85517, RefRangeEnd = 85518, XrefRangeStart = 85507, XrefRangeEnd = 85517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArray(VoxelArray source, StreamBinaryWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteArray_Public_Static_Void_VoxelArray_StreamBinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85518, XrefRangeEnd = 85520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float FastReadFloat(StreamBinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastReadFloat_Public_Static_Single_StreamBinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float FastReadFloat(BinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastReadFloat_Public_Static_Single_BinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85520, XrefRangeEnd = 85521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FastWriteFloat(BinaryWriter writer, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FastWriteFloat_Public_Static_Void_BinaryWriter_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85521, XrefRangeEnd = 85522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadArray(Il2CppObjectBase dest, BinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85522, XrefRangeEnd = 85524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadArray(Il2CppObjectBase dest, BinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85524, XrefRangeEnd = 85527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadArray(Il2CppObjectBase dest, BinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85527, XrefRangeEnd = 85529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadArray(Il2CppObjectBase dest, BinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_ReadArray_Public_Static_Void_Il2CppObjectBase_BinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85529, XrefRangeEnd = 85531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArray(Il2CppObjectBase source, BinaryWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85531, XrefRangeEnd = 85533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArray(Il2CppObjectBase source, BinaryWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85533, XrefRangeEnd = 85536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArray(Il2CppObjectBase source, BinaryWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85536, XrefRangeEnd = 85538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArray(Il2CppObjectBase source, BinaryWriter writer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_WriteArray_Public_Static_Void_Il2CppObjectBase_BinaryWriter_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85538, XrefRangeEnd = 85544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MarshalFloats(Il2CppObjectBase sourceFloats, Il2CppStructArray<float> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceFloats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_MarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85544, XrefRangeEnd = 85550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MarshalVectors(Il2CppObjectBase sourceFloats, Il2CppStructArray<float> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceFloats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarshalVectors_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85550, XrefRangeEnd = 85554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MarshalFloats(Il2CppObjectBase sourceFloats, Il2CppStructArray<float> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceFloats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_MarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85554, XrefRangeEnd = 85557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MarshalInts(Il2CppObjectBase sourceInts, Il2CppStructArray<int> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceInts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarshalInts_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85557, XrefRangeEnd = 85560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnmarshalFloats(Il2CppObjectBase destFloats, Il2CppStructArray<float> sourceFloats)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(destFloats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFloats);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_UnmarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85560, XrefRangeEnd = 85563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnmarshalVectors(Il2CppObjectBase destVectors, Il2CppStructArray<float> sourceFloats)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(destVectors);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFloats);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnmarshalVectors_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85563, XrefRangeEnd = 85567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnmarshalFloats(Il2CppObjectBase destFloats, Il2CppStructArray<float> sourceFloats)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(destFloats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceFloats);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtil.NativeMethodInfoPtr_UnmarshalFloats_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85567, XrefRangeEnd = 85570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnmarshalInts(Il2CppObjectBase destInts, Il2CppStructArray<int> sourceInts)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(destInts);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceInts);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnmarshalInts_Public_Static_Void_Il2CppObjectBase_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SerializationUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}

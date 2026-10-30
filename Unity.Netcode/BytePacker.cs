using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Unity.Netcode;

public static class BytePacker : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_WriteValuePacked_Public_Static_Void_FastBufferWriter_TEnum_0<TEnum>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_TEnum_0, Il2CppClassPointerStore<BytePacker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ToUint_Private_Static_UInt32_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ToUint_Private_Static_UInt32_T_0, Il2CppClassPointerStore<BytePacker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ToUlong_Private_Static_UInt64_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ToUlong_Private_Static_UInt64_T_0, Il2CppClassPointerStore<BytePacker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_BitPackedUshortMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_BitPackedShortMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_BitPackedShortMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_BitPackedUintMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_BitPackedIntMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_BitPackedIntMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_BitPackedULongMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_BitPackedLongMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_BitPackedLongMin;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_TEnum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Ray2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUint_Private_Static_UInt32_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUlong_Private_Static_UInt64_T_0;

	public unsafe static ushort BitPackedUshortMax
	{
		get
		{
			Unsafe.SkipInit(out ushort result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BitPackedUshortMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BitPackedUshortMax, (void*)(&num));
		}
	}

	public unsafe static short BitPackedShortMax
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BitPackedShortMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BitPackedShortMax, (void*)(&num));
		}
	}

	public unsafe static short BitPackedShortMin
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BitPackedShortMin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BitPackedShortMin, (void*)(&num));
		}
	}

	public unsafe static uint BitPackedUintMax
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BitPackedUintMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BitPackedUintMax, (void*)(&num));
		}
	}

	public unsafe static int BitPackedIntMax
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BitPackedIntMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BitPackedIntMax, (void*)(&num));
		}
	}

	public unsafe static int BitPackedIntMin
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BitPackedIntMin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BitPackedIntMin, (void*)(&num));
		}
	}

	public unsafe static ulong BitPackedULongMax
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BitPackedULongMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BitPackedULongMax, (void*)(&num));
		}
	}

	public unsafe static long BitPackedLongMax
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BitPackedLongMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BitPackedLongMax, (void*)(&num));
		}
	}

	public unsafe static long BitPackedLongMin
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BitPackedLongMin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BitPackedLongMin, (void*)(&num));
		}
	}

	static BytePacker()
	{
		Il2CppClassPointerStore<BytePacker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Scripts.dll", "Unity.Netcode", "BytePacker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BytePacker>.NativeClassPtr);
		NativeFieldInfoPtr_BitPackedUshortMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, "BitPackedUshortMax");
		NativeFieldInfoPtr_BitPackedShortMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, "BitPackedShortMax");
		NativeFieldInfoPtr_BitPackedShortMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, "BitPackedShortMin");
		NativeFieldInfoPtr_BitPackedUintMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, "BitPackedUintMax");
		NativeFieldInfoPtr_BitPackedIntMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, "BitPackedIntMax");
		NativeFieldInfoPtr_BitPackedIntMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, "BitPackedIntMin");
		NativeFieldInfoPtr_BitPackedULongMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, "BitPackedULongMax");
		NativeFieldInfoPtr_BitPackedLongMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, "BitPackedLongMax");
		NativeFieldInfoPtr_BitPackedLongMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, "BitPackedLongMin");
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685908);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685909);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685910);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685911);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685912);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685913);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685914);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685915);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685916);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685917);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685918);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685919);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685920);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685921);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Ray2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685922);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685923);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685924);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685925);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685926);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685927);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685928);
		NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685929);
		NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685930);
		NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685931);
		NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685932);
		NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685933);
		NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685934);
		NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685935);
		NativeMethodInfoPtr_ToUint_Private_Static_UInt32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685936);
		NativeMethodInfoPtr_ToUlong_Private_Static_UInt64_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BytePacker>.NativeClassPtr, 100685937);
	}

	[CallerCount(0)]
	public unsafe static void WriteValuePacked<TEnum>(FastBufferWriter writer, TEnum value) where TEnum : System.Enum, new()
	{
		//IL_0053->IL0056: Incompatible stack types: I vs Ref
		//IL_0046->IL0056: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TEnum reference;
		if (!typeof(TEnum).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WriteValuePacked_Public_Static_Void_FastBufferWriter_TEnum_0<TEnum>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289715, XrefRangeEnd = 289717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289717, XrefRangeEnd = 289719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289719, XrefRangeEnd = 289723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289723, XrefRangeEnd = 289727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289727, XrefRangeEnd = 289738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289738, XrefRangeEnd = 289739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289739, XrefRangeEnd = 289740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289740, XrefRangeEnd = 289741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289741, XrefRangeEnd = 289742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289742, XrefRangeEnd = 289743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289743, XrefRangeEnd = 289744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289744, XrefRangeEnd = 289748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, Ray ray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(Ray**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ray;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Ray_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289748, XrefRangeEnd = 289758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, Ray2D ray2d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(Ray2D**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ray2d;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Ray2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289758, XrefRangeEnd = 289766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289766, XrefRangeEnd = 289782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, Color32 color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289782, XrefRangeEnd = 289786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, Vector2 vector2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &vector2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 289792, RefRangeEnd = 289794, XrefRangeStart = 289786, XrefRangeEnd = 289792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, Vector3 vector3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &vector3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, Vector4 vector4)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &vector4;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289794, XrefRangeEnd = 289797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValuePacked(FastBufferWriter writer, string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValuePacked_Public_Static_Void_FastBufferWriter_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueBitPacked(FastBufferWriter writer, short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 289810, RefRangeEnd = 289815, XrefRangeStart = 289797, XrefRangeEnd = 289810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueBitPacked(FastBufferWriter writer, ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(ushort**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueBitPacked(FastBufferWriter writer, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 289828, RefRangeEnd = 289854, XrefRangeStart = 289815, XrefRangeEnd = 289828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueBitPacked(FastBufferWriter writer, uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueBitPacked(FastBufferWriter writer, long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 289871, RefRangeEnd = 289875, XrefRangeStart = 289854, XrefRangeEnd = 289871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteValueBitPacked(FastBufferWriter writer, ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writer);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteValueBitPacked_Public_Static_Void_FastBufferWriter_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static uint ToUint<T>(T value) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ToUint_Private_Static_UInt32_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static ulong ToUlong<T>(T value) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ToUlong_Private_Static_UInt64_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public BytePacker(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
